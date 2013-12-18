Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Ports

Partial Public Class SMSapplication
    Inherits Form

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Private Variables"
    Public Shared port As New SerialPort()
    Public Shared objclsSMS As New clsSMS()
    Private objShortMessageCollection As New ShortMessageCollection()
#End Region

#Region "Private Methods"

#Region "Write StatusBar"
    Private Sub WriteStatusBar(status As String)
        Try
            statusBar1.Text = "Message: " & status

        Catch ex As Exception
        End Try
    End Sub
#End Region

#End Region

#Region "Private Events"

    Private Sub SMSapplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '#Region "Display all available COM Ports"
            Dim ports As String() = SerialPort.GetPortNames()

            ' Add all port names to the combo box:
            For Each port As String In ports
                Me.cboPortName.Items.Add(port)
            Next
            '#End Region

            'Remove tab pages
            Me.tabSMSapplication.TabPages.Remove(tbSendSMS)
            Me.tabSMSapplication.TabPages.Remove(tbReadSMS)
            Me.tabSMSapplication.TabPages.Remove(tbDeleteSMS)

            Me.btnDisconnect.Enabled = False
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            'Open communication port 
            SMSapplication.port = objclsSMS.OpenPort(Me.cboPortName.Text, Convert.ToInt32(Me.cboBaudRate.Text), Convert.ToInt32(Me.cboDataBits.Text), Convert.ToInt32(Me.txtReadTimeOut.Text), Convert.ToInt32(Me.txtWriteTimeOut.Text))

            If SMSapplication.port IsNot Nothing Then
                Me.gboPortSettings.Enabled = False

                'MessageBox.Show("Modem is connected at PORT " + this.cboPortName.Text);
                Me.statusBar1.Text = "Modem is connected at PORT " & Convert.ToString(Me.cboPortName.Text)

                'Add tab pages
                Me.tabSMSapplication.TabPages.Add(tbSendSMS)
                Me.tabSMSapplication.TabPages.Add(tbReadSMS)
                Me.tabSMSapplication.TabPages.Add(tbDeleteSMS)

                Me.lblConnectionStatus.Text = "Connected at " & Convert.ToString(Me.cboPortName.Text)
                Me.btnDisconnect.Enabled = True
            Else

                'MessageBox.Show("Invalid port settings");
                Me.statusBar1.Text = "Invalid port settings"
            End If
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try

    End Sub
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Try
            Me.gboPortSettings.Enabled = True
            objclsSMS.ClosePort(SMSapplication.port)

            'Remove tab pages
            Me.tabSMSapplication.TabPages.Remove(tbSendSMS)
            Me.tabSMSapplication.TabPages.Remove(tbReadSMS)
            Me.tabSMSapplication.TabPages.Remove(tbDeleteSMS)

            Me.lblConnectionStatus.Text = "Not Connected"

            Me.btnDisconnect.Enabled = False
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
    End Sub

    Public Shared Function sendSMS(nomor As String, pesan As String)
        Try
            objclsSMS.sendMsg(port, nomor, pesan)
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click

        '.............................................. Send SMS ....................................................
        Try

            If objclsSMS.sendMsg(SMSapplication.port, Me.txtSIM.Text, Me.txtMessage.Text) Then
                'MessageBox.Show("Message has sent successfully");
                Me.statusBar1.Text = "Message has sent successfully"
            Else
                'MessageBox.Show("Failed to send message");
                Me.statusBar1.Text = "Failed to send message"

            End If
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
    End Sub
    Private Sub btnReadSMS_Click(sender As Object, e As EventArgs) Handles btnReadSMS.Click
        Try
            'count SMS 
            Dim uCountSMS As Integer = objclsSMS.CountSMSmessages(SMSapplication.port)
            If uCountSMS > 0 Then

                '#Region "Command"
                Dim strCommand As String = "AT+CMGL=""ALL"""

                If Me.rbReadAll.Checked Then
                    strCommand = "AT+CMGL=""ALL"""
                ElseIf Me.rbReadUnRead.Checked Then
                    strCommand = "AT+CMGL=""REC UNREAD"""
                ElseIf Me.rbReadStoreSent.Checked Then
                    strCommand = "AT+CMGL=""STO SENT"""
                ElseIf Me.rbReadStoreUnSent.Checked Then
                    strCommand = "AT+CMGL=""STO UNSENT"""
                End If
                '#End Region

                ' If SMS exist then read SMS
                '#Region "Read SMS"
                '.............................................. Read all SMS ....................................................
                objShortMessageCollection = objclsSMS.ReadSMS(SMSapplication.port, strCommand)
                For Each msg As ShortMessage In objShortMessageCollection

                    Dim item As New ListViewItem(New String() {msg.Index, msg.Sent, msg.Sender, msg.Message})
                    item.Tag = msg

                    lvwMessages.Items.Add(item)
                    '#End Region

                Next
            Else
                lvwMessages.Clear()
                'MessageBox.Show("There is no message in SIM");

                Me.statusBar1.Text = "There is no message in SIM"
            End If
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
    End Sub
    Private Sub btnDeleteSMS_Click(sender As Object, e As EventArgs) Handles btnDeleteSMS.Click
        Try
            'Count SMS 
            Dim uCountSMS As Integer = objclsSMS.CountSMSmessages(SMSapplication.port)
            If uCountSMS > 0 Then
                Dim dr As DialogResult = MessageBox.Show("Are u sure u want to delete the SMS?", "Delete confirmation", MessageBoxButtons.YesNo)

                If dr.ToString() = "Yes" Then
                    '#Region "Delete SMS"

                    If Me.rbDeleteAllSMS.Checked Then
                        '...............................................Delete all SMS ....................................................

                        '#Region "Delete all SMS"
                        Dim strCommand As String = "AT+CMGD=1,4"
                        If objclsSMS.DeleteMsg(SMSapplication.port, strCommand) Then
                            'MessageBox.Show("Messages has deleted successfuly ");
                            Me.statusBar1.Text = "Messages has deleted successfuly"
                        Else
                            'MessageBox.Show("Failed to delete messages ");
                            Me.statusBar1.Text = "Failed to delete messages"
                            '#End Region

                        End If
                    ElseIf Me.rbDeleteReadSMS.Checked Then
                        '...............................................Delete Read SMS ....................................................

                        '#Region "Delete Read SMS"
                        Dim strCommand As String = "AT+CMGD=1,3"
                        If objclsSMS.DeleteMsg(SMSapplication.port, strCommand) Then
                            'MessageBox.Show("Messages has deleted successfuly");
                            Me.statusBar1.Text = "Messages has deleted successfuly"
                        Else
                            'MessageBox.Show("Failed to delete messages ");
                            Me.statusBar1.Text = "Failed to delete messages"
                            '#End Region

                        End If

                        '#End Region
                    End If
                End If
            End If
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try

    End Sub
    Private Sub btnCountSMS_Click(sender As Object, e As EventArgs) Handles btnCountSMS.Click
        Try
            'Count SMS
            Dim uCountSMS As Integer = objclsSMS.CountSMSmessages(SMSapplication.port)
            Me.txtCountSMS.Text = uCountSMS.ToString()
        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
    End Sub

#End Region
#Region "Error Log"
    Public Sub ErrorLog(Message As String)
        Dim sw As StreamWriter = Nothing

        Try
            WriteStatusBar(Message)

            Dim sLogFormat As String = DateTime.Now.ToShortDateString().ToString() & " " & DateTime.Now.ToLongTimeString().ToString() & " ==> "
            'string sPathName = @"E:\";
            Dim sPathName As String = "SMSapplicationErrorLog_"

            Dim sYear As String = DateTime.Now.Year.ToString()
            Dim sMonth As String = DateTime.Now.Month.ToString()
            Dim sDay As String = DateTime.Now.Day.ToString()

            Dim sErrorTime As String = sDay & "-" & sMonth & "-" & sYear

            sw = New StreamWriter(sPathName & sErrorTime & ".txt", True)

            sw.WriteLine(sLogFormat & Message)

            sw.Flush()
            'ErrorLog(ex.ToString());
        Catch ex As Exception
        Finally
            If sw IsNot Nothing Then
                sw.Dispose()
                sw.Close()
            End If
        End Try

    End Sub
#End Region

End Class