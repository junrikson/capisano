Imports MySql.Data.MySqlClient
Module modPublicFunction
    Public ServerName As String
    Public CommPort As String
    Public BaudRate As String
    Public Parity As String
    Public DataBits As String
    Public StopBits As String
    Public ProcessorName As String
    Public GateWayTipe As String
    Public CekPulsaOnStart As Boolean
    Public ReminderPulsa As Boolean
    Public CekPulsaNo As String
    Public CekPulsaSendTo As String
    Public ReminderEvent As String
    Public FlagSend As Boolean = True
    Public timeRefreshx As Integer
    Public Autostart As String
    Public Server As String, UID As String, Password As String, Port As String, Database As String
    Public UserName As String
    Private konek As New MySqlConnection
    Public Function GetUSSDRespon(ByVal buffer As String) As String
        Dim Respon As String = ""
        Dim FPosCUSD As Integer
        Dim ResponCode As String
        FPosCUSD = InStr(buffer, "+CUSD")

        ResponCode = Mid(buffer, FPosCUSD + 7, 1)

        If ResponCode = "4" Then
            Respon = "Cek Pulsa Error!"
        Else
            Respon = Mid(buffer, FPosCUSD + 9, buffer.Length)
        End If


        Return Respon
    End Function
    Public Function Koneksi() As Boolean


        Try
            konek.ConnectionString = "Server=" & Server & ";Database=" & Database & ";UID=" & UID & ";Password=" & Password & ";Port=" & Port

            konek.Open()
            Return True

        Catch ex As Exception
            MsgBox("Koneksi gagal : " & ex.Message.ToString, MsgBoxStyle.Critical)
            Return False
        End Try


    End Function

    Public Function Tutup() As Boolean


        Try
            konek.Close()
            Return True

        Catch ex As Exception
            MsgBox("Tutup koneksi gagal : " & ex.Message.ToString, MsgBoxStyle.Critical)
            Return False
        End Try


    End Function



    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataSet
        Dim sqlDT As New DataSet
        Try

            Dim sqlDA As New MySqlDataAdapter(SQLQuery, konek)

            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
        Catch ex As Exception

            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
        Return sqlDT
    End Function
    Public Sub GetSettings()

        Dim config As System.Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)

        ServerName = config.AppSettings.Settings.Item("ServerName").Value
        ProcessorName = config.AppSettings.Settings.Item("Processor").Value
        CommPort = config.AppSettings.Settings.Item("CommPort").Value
        BaudRate = config.AppSettings.Settings.Item("BaudRate").Value
        Parity = config.AppSettings.Settings.Item("Parity").Value
        DataBits = config.AppSettings.Settings.Item("DataBits").Value
        StopBits = config.AppSettings.Settings.Item("StopBits").Value
        Autostart = config.AppSettings.Settings.Item("Autostart").Value

        CekPulsaOnStart = CBool(Val(config.AppSettings.Settings.Item("CekPulsaOnStart").Value))
        ReminderPulsa = CBool(Val(config.AppSettings.Settings.Item("ReminderActive").Value))
        CekPulsaNo = config.AppSettings.Settings.Item("CekPulsaNo").Value
        CekPulsaSendTo = config.AppSettings.Settings.Item("CekPulsaSendTo").Value
        ReminderEvent = config.AppSettings.Settings.Item("ReminderEvent").Value
        timeRefreshx = Val(config.AppSettings.Settings.Item("TimeRefresh").Value)


        Server = config.AppSettings.Settings.Item("ServerDB").Value
        Database = config.AppSettings.Settings.Item("Database").Value
        Password = config.AppSettings.Settings.Item("DBPassword").Value
        UID = config.AppSettings.Settings.Item("DBUser").Value

        If Autostart.ToUpper = "TRUE" Then
            WriteString("LocalMachine", "Software\Microsoft\Windows\CurrentVersion\Run", Application.ProductName, Application.ExecutablePath)
        Else
            DelString("LocalMachine", "Software\Microsoft\Windows\CurrentVersion\Run", Application.ProductName)
        End If


    End Sub


    Public Function IsOperationSuccess(ByVal Data As String) As Boolean
        Dim res As Boolean = False
        If Data.Trim = "" Then
            Return False
        End If
        If InStr(Data, "OK") > 0 Then
            res = True
        End If
        Return res
    End Function

    Public Function IsOperationError(ByVal Data As String) As Boolean
        Dim res As Boolean = False
        If Data.Trim = "" Then
            Return False
        End If
        If InStr(Data, "ERROR") > 0 Then

            res = True
        End If

        Return res
    End Function

    Public Function ReadyToSend(ByVal Data As String) As Boolean

        If Data.Trim = "" Then
            Return False
        End If
        If InStr(Data, ">") > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

    Public Function ParseBufferOK(ByVal Data As String) As String
        Dim xData As String = Data
        If Data.Trim = "" Then
            Return ""
        End If
        Dim Res As String = ""
        xData = Replace(Data, Chr(13), ";")

        If Not IsOperationSuccess(xData) Then
            Return Res.Trim
        End If

        Res = Split(xData.Trim, ";")(1)

        Return Res.Trim
    End Function

    Public Function ParseMessage(ByVal Data As String) As String
        Dim xData As String = Data

        Dim Res As String = ""
        xData = Replace(Data, Chr(13), "")
        xData = Replace(xData.Trim, Chr(10), " ")

        If Not IsOperationSuccess(xData) Then
            Return Res.Trim
        End If


        Res = Split(xData, " ")(2)

        Return Res.Trim
    End Function

    Public Function GetFieldString(ByVal SrcVal As Object, Optional ByVal StrFormat As FormatString = FormatString.None) As String
        Dim result As String = ""

        Dim arrFormat(4) As String

        arrFormat(0) = ""
        arrFormat(1) = "Currency"
        arrFormat(2) = "Standard"
        arrFormat(3) = "MM/dd/yyyy hh:mm:ss"
        arrFormat(4) = "MM/dd/yyyy"


        If IsDBNull(SrcVal) Then
            result = ""
        Else
            result = Format(SrcVal.ToString, arrFormat(StrFormat))
        End If

        Return result

    End Function

End Module
