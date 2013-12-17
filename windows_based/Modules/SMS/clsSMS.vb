Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.IO.Ports
Imports System.Threading
Imports System.Text.RegularExpressions

Public Class clsSMS

#Region "Open and Close Ports"
    'Open Port
    Public Function OpenPort(p_strPortName As String, p_uBaudRate As Integer, p_uDataBits As Integer, p_uReadTimeout As Integer, p_uWriteTimeout As Integer) As SerialPort
        receiveNow = New AutoResetEvent(False)
        Dim port As New SerialPort()

        Try
            port.PortName = p_strPortName
            'COM1
            port.BaudRate = p_uBaudRate
            '9600
            port.DataBits = p_uDataBits
            '8
            port.StopBits = IO.Ports.StopBits.One
            '1
            port.Parity = IO.Ports.Parity.None
            'None
            port.ReadTimeout = p_uReadTimeout
            '300
            port.WriteTimeout = p_uWriteTimeout
            '300
            port.Encoding = Encoding.GetEncoding("iso-8859-1")
            AddHandler port.DataReceived, New SerialDataReceivedEventHandler(AddressOf port_DataReceived)
            port.Open()
            port.DtrEnable = True
            port.RtsEnable = True
        Catch ex As Exception
            Throw ex
        End Try
        Return port
    End Function

    'Close Port
    Public Sub ClosePort(port As SerialPort)
        Try
            port.Close()
            RemoveHandler port.DataReceived, New SerialDataReceivedEventHandler(AddressOf port_DataReceived)
            port = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    'Execute AT Command
    Public Function ExecCommand(port As SerialPort, command As String, responseTimeout As Integer, errorMessage As String) As String
        Try

            port.DiscardOutBuffer()
            port.DiscardInBuffer()
            receiveNow.Reset()
            port.Write(command & vbCr)

            Dim input As String = ReadResponse(port, responseTimeout)
            If (input.Length = 0) OrElse ((Not input.EndsWith(vbCr & vbLf & "> ")) AndAlso (Not input.EndsWith(vbCr & vbLf & "OK" & vbCr & vbLf))) Then
                Throw New ApplicationException("No success message was received.")
            End If
            Return input
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Receive data from port
    Public Sub port_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        Try
            If e.EventType = SerialData.Chars Then
                receiveNow.[Set]()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ReadResponse(port As SerialPort, timeout As Integer) As String
        Dim buffer As String = String.Empty
        Try
            Do
                If receiveNow.WaitOne(timeout, False) Then
                    Dim t As String = port.ReadExisting()
                    buffer += t
                Else
                    If buffer.Length > 0 Then
                        Throw New ApplicationException("Response received is incomplete.")
                    Else
                        Throw New ApplicationException("No data received from phone.")
                    End If
                End If
            Loop While Not buffer.EndsWith(vbCr & vbLf & "OK" & vbCr & vbLf) AndAlso Not buffer.EndsWith(vbCr & vbLf & "> ") AndAlso Not buffer.EndsWith(vbCr & vbLf & "ERROR" & vbCr & vbLf)
        Catch ex As Exception
            Throw ex
        End Try
        Return buffer
    End Function

#Region "Count SMS"
    Public Function CountSMSmessages(port As SerialPort) As Integer
        Dim CountTotalMessages As Integer = 0
        Try

            '#Region "Execute Command"

            Dim recievedData As String = ExecCommand(port, "AT", 300, "No phone connected at ")
            recievedData = ExecCommand(port, "AT+CMGF=1", 300, "Failed to set message format.")
            Dim command As [String] = "AT+CPMS?"
            recievedData = ExecCommand(port, command, 1000, "Failed to count SMS message")
            Dim uReceivedDataLength As Integer = recievedData.Length

            '#End Region

            '#Region "If command is executed successfully"
            If (recievedData.Length >= 45) AndAlso (recievedData.StartsWith("AT+CPMS?")) Then

                '#Region "Parsing SMS"
                Dim strSplit As String() = recievedData.Split(","c)
                Dim strMessageStorageArea1 As String = strSplit(0)
                'SM
                Dim strMessageExist1 As String = strSplit(1)
                'Msgs exist in SM
                '#End Region
                '#Region "Count Total Number of SMS In SIM"
                '#End Region

                CountTotalMessages = Convert.ToInt32(strMessageExist1)
                '#End Region

                '#Region "If command is not executed successfully"
            ElseIf recievedData.Contains("ERROR") Then

                '#Region "Error in Counting total number of SMS"
                Dim recievedError As String = recievedData
                recievedError = recievedError.Trim()
                '#End Region

                recievedData = "Following error occured while counting the message" & recievedError
            End If
            '#End Region


            Return CountTotalMessages
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

#Region "Read SMS"

    Public receiveNow As AutoResetEvent

    Public Function ReadSMS(port As SerialPort, p_strCommand As String) As ShortMessageCollection

        ' Set up the phone and read the messages
        Dim messages As ShortMessageCollection = Nothing
        Try

            '#Region "Execute Command"
            ' Check connection
            ExecCommand(port, "AT", 300, "No phone connected")
            ' Use message format "Text mode"
            ExecCommand(port, "AT+CMGF=1", 300, "Failed to set message format.")
            ' Use character set "PCCP437"
            ExecCommand(port, "AT+CSCS=""PCCP437""", 300, "Failed to set character set.")
            ' Select SIM storage
            ExecCommand(port, "AT+CPMS=""SM""", 300, "Failed to select message storage.")
            ' Read the messages
            Dim input As String = ExecCommand(port, p_strCommand, 5000, "Failed to read the messages.")
            '#End Region

            '#Region "Parse messages"
            '#End Region

            messages = ParseMessages(input)
        Catch ex As Exception
            Throw ex
        End Try

        If messages IsNot Nothing Then
            Return messages
        Else
            Return Nothing
        End If

    End Function
    Public Function ParseMessages(input As String) As ShortMessageCollection
        Dim messages As New ShortMessageCollection()
        Try
            Dim r As New Regex("\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n")
            Dim m As Match = r.Match(input)
            While m.Success
                Dim msg As New ShortMessage()
                'msg.Index = int.Parse(m.Groups[1].Value);
                msg.Index = m.Groups(1).Value
                msg.Status = m.Groups(2).Value
                msg.Sender = m.Groups(3).Value
                msg.Alphabet = m.Groups(4).Value
                msg.Sent = m.Groups(5).Value
                msg.Message = m.Groups(6).Value
                messages.Add(msg)

                m = m.NextMatch()

            End While
        Catch ex As Exception
            Throw ex
        End Try
        Return messages
    End Function

#End Region

#Region "Send SMS"

    Shared readNow As New AutoResetEvent(False)

    Public Function sendMsg(port As SerialPort, PhoneNo As String, Message As String) As Boolean
        Dim isSend As Boolean = False

        Try

            Dim recievedData As String = ExecCommand(port, "AT", 300, "No phone connected")
            recievedData = ExecCommand(port, "AT+CMGF=1", 300, "Failed to set message format.")
            Dim command As [String] = "AT+CMGS=""" & PhoneNo & """"
            recievedData = ExecCommand(port, command, 300, "Failed to accept phoneNo")
            command = Message & Char.ConvertFromUtf32(26) & vbCr
            recievedData = ExecCommand(port, command, 3000, "Failed to send message")
            '3 seconds
            If recievedData.EndsWith(vbCr & vbLf & "OK" & vbCr & vbLf) Then
                isSend = True
            ElseIf recievedData.Contains("ERROR") Then
                isSend = False
            End If
            Return isSend
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Private Shared Sub DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        Try
            If e.EventType = SerialData.Chars Then
                readNow.[Set]()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Delete SMS"
    Public Function DeleteMsg(port As SerialPort, p_strCommand As String) As Boolean
        Dim isDeleted As Boolean = False
        Try

            '#Region "Execute Command"
            Dim recievedData As String = ExecCommand(port, "AT", 300, "No phone connected")
            recievedData = ExecCommand(port, "AT+CMGF=1", 300, "Failed to set message format.")
            Dim command As [String] = p_strCommand
            recievedData = ExecCommand(port, command, 300, "Failed to delete message")
            '#End Region

            If recievedData.EndsWith(vbCr & vbLf & "OK" & vbCr & vbLf) Then
                isDeleted = True
            End If
            If recievedData.Contains("ERROR") Then
                isDeleted = False
            End If
            Return isDeleted
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

End Class