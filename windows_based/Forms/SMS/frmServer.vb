Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Text
Imports System.IO.Ports
Imports System.Threading
Imports System.Text.RegularExpressions

Public Class frmServer
    Dim Buffer As Object = ""
    Dim Command As String
    Dim FlagNewMessage As Boolean = True ' variable indikasi membaca SMS
    Dim ObjMessageSender As New clsMessageSender ' object Sender SMS
    Dim ObjMessageEvent As New MessageEvent     ' Object message event
    Dim ObjMessageReceiver As New MessageReceiver   ' Object SMS Receiver/penerima SMS
    Dim oMsgList As Collection      ' Object penyimpan daftar SMS masuk
    Dim OMsgToSend As New Collection ' Object penyimpan daftar SMS yg harus dikirim
    Dim continueLoop As Boolean = True
    Dim TimeRefresh As Integer = timeRefreshx
    Dim AllReaded As Boolean = False
    Dim IsUSSD As Boolean = False

    Private Sub comm_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles comm.DataReceived

        Dim n As Integer = comm.BytesToRead
        Dim comBuffer As Byte() = New Byte(n - 1) {}
        comm.Read(comBuffer, 0, n)

        ' baca data dari modem
        For i As Integer = 0 To n - 1
            Buffer = Buffer & Chr(comBuffer(i).ToString)
        Next



        If IsUSSD Then

            If InStr(Buffer, "+CUSD: 4") > 0 Or (InStr(Buffer, "+CUSD:") > 0 And InStr(Buffer, ",15")) Or InStr(Buffer, "ERROR") > 0 Or InStr(Buffer, "OK") > 0 Then
                AllReaded = True

            End If

        Else
            ' data selesai dibaca ditandai dengan status OK atau ERROR
            If (IsOperationError(Buffer) = True) Or (IsOperationSuccess(Buffer) = True) Then
                AllReaded = True
            End If
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If comm.IsOpen Then
            comm.Close()
            Exit Sub
        End If

        If Not comm.IsOpen Then
            MsgBox("Port " & comm.PortName & " ditutup", MsgBoxStyle.Information)
        Else
            MsgBox("Port " & comm.PortName & " gagal ditutup", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub comm_ErrorReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialErrorReceivedEventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not comm.IsOpen Then
            MsgBox(comm.PortName & " belum terbuka.", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSetting.Click
        Dim frm As New frmSetting

        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub toolConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolConnect.Click
        Dim xparity As String = "0"

        If ServerName = "" Then
            MsgBox("Anda belum menentukan nama ServerGateway.", MsgBoxStyle.Exclamation)
            Dim frm As New frmSetting
            frm.ShowDialog()
            frm = Nothing

        End If

        ' Setting parameter device
        Try
            Select Case Parity

                Case "Even"
                    xparity = "2"
                Case "Odd"
                    xparity = "1"
                Case "None"
                    xparity = "0"
                Case "Mark"
                    xparity = "3"
                Case "Space"
                    xparity = "4"
            End Select

            If toolConnect.Text = "Connect" Then
                comm.BaudRate = BaudRate
                comm.StopBits = StopBits
                comm.Parity = xparity
                comm.DataBits = DataBits
                comm.PortName = CommPort

                'jika belum terbuka, buka koneksi dengan device

                If Not comm.IsOpen Then
                    comm.Open()
                End If

                If comm.IsOpen And Koneksi() Then
                    ResetBuffer()
                    InitModem()
                    TimeRefresh = 3

                    toolConnect.Text = "Disconnect"
                    toolConnect.Image = ImageList1.Images(0)
                    toolReset.Enabled = False
                    toolSetting.Enabled = False
                    toolSend.Enabled = True
                    Command = "INIT"


                Else
                    Tutup()
                    toolConnect.Text = "Connect"
                    toolConnect.Image = ImageList1.Images(1)
                    toolSetting.Enabled = False

                    Timer1.Enabled = False
                    StatusStrip1.Items(0).Text = "Disconnected from " & CommPort
                    StatusStrip1.Items(1).Text = ""
                    StatusStrip1.Items(2).Text = ""
                    StatusStrip1.Items(3).Text = ""
                    StatusStrip1.Items(4).Text = ""
                    toolSend.Enabled = False
                End If
            Else
                If MsgBox("Putuskan sambungan ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Command = "BREAK"
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Sub CloseDevice()
        Timer1.Enabled = False

        ' jika koneksi terbuka, tutup koneksi
        If comm.IsOpen Then
            comm.Close()
            Tutup()
        End If
        If Not comm.IsOpen Then

            toolConnect.Text = "Connect"
            toolConnect.Image = ImageList1.Images(1)
            toolSetting.Enabled = True
            toolReset.Enabled = True
            toolSend.Enabled = False
            Timer1.Enabled = False
            StatusStrip1.Items(0).Text = "Disconnected from " & CommPort
            StatusStrip1.Items(1).Text = ""
            StatusStrip1.Items(2).Text = ""
            StatusStrip1.Items(1).Text = ""
            StatusStrip1.Items(2).Text = ""
            StatusStrip1.Items(3).Text = ""
            StatusStrip1.Items(4).Text = ""
        Else
            MsgBox("Port " & comm.PortName & " disconnect failed.", MsgBoxStyle.Critical)
            toolConnect.Text = "Disconnect"
            toolConnect.Image = ImageList1.Images(0)
            toolSend.Enabled = True
            toolSetting.Enabled = False
            Timer1.Enabled = True

        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If lvInbox.Items.Count > 1000 Then
            lvInbox.Items.Clear()
        End If

        If lvOutbox.Items.Count > 1000 Then
            lvOutbox.Items.Clear()
        End If
        StatusStrip1.Items(3).Text = "Time Refresh : " & TimeRefresh
        If TimeRefresh > 1 Then
            TimeRefresh = TimeRefresh - 1
            Exit Sub
        Else

            TimeRefresh = timeRefreshx
        End If


        If ReminderPulsa Then
            If Hour(Now) = Val(Split(ReminderEvent, ":")(0)) And Minute(Now) = Val(Split(ReminderEvent, ":")(1)) And FlagSend Then
                FlagSend = False
                CekPulsa()
            End If

            If Minute(Now) > Val(Split(ReminderEvent, ":")(1)) Then
                FlagSend = True
            End If
        End If


        StatusStrip1.Items(4).Text = "Idle"

        ' CEK DAFTAR SMS MASUK DARI MODEM
        comm.Write("AT+CMGL=4" & Chr(13))

        Wait() ' TUNGGU RESPON


        If IsOperationSuccess(Buffer) Then ' JIKA OPERASI SUKES

            oMsgList = ObjMessageEvent.MessageList(Buffer) ' PARSING DAFTAR PESAN 


            ResetBuffer() ' KOSONGKAN BUFFER

            Dim SaveStatus As Long
            Dim indexmsg As Long = 0
            If oMsgList.Count > 0 Then ' JIKA ADA DAFTAR PESAN MASUK

                For i As Integer = 1 To oMsgList.Count
                    StatusStrip1.Items(4).Text = "Read Message (s)"
                    ObjMessageReceiver.Value = oMsgList.Item(1).ToString ' AMBIL PESAN

                    indexmsg = ObjMessageReceiver.IndexOfMessage
                    ' SIMPAN PESAN MASUK KE DATABASE
                    SaveStatus = SaveMessage(ObjMessageReceiver.MessagePhoneNumber, ObjMessageReceiver.MessageText, Format(ObjMessageReceiver.MessageTime, "MM/dd/yyyy hh:mm:ss"))

                    ' JIKA PENYIMPANAN BERHASIL, HAPUS PESAN MASUK DARI DAFTAR
                    If SaveStatus = 0 Then
                        Dim x As ListViewItem
                        x = lvInbox.Items.Insert(0, Format(ObjMessageReceiver.MessageTime, "dd/MM/yyyy hh:mm:ss"))
                        x.SubItems.Add(ObjMessageReceiver.MessagePhoneNumber)
                        x.SubItems.Add(ObjMessageReceiver.MessageText)
                        x.SubItems.Add(CommPort)
                        oMsgList.Remove(1)
                    End If


                    comm.Write("AT+CMGD=" & indexmsg.ToString.Trim & Chr(13)) ' HAPUS DAFTAR PESAN MASUK DARI MEMORY SIMCARD

                    Wait()
                    ResetBuffer()
                Next
            Else
                StatusStrip1.Items(4).Text = "Kosong"
            End If
        End If


        If OMsgToSend.Count > 0 Then ' JIKA ADA DAFTAR PESAN YANG HARUS DIKIRIM
            Dim lenghtOfMessage As Decimal
            Dim message As String
            For i As Integer = 1 To OMsgToSend.Count

                StatusStrip1.Items(4).Text = "Sending Message (s)"

                ' MULAI MENGIRIM PESAN
                lenghtOfMessage = Math.Ceiling(OMsgToSend.Item(1).Message.ToString.Length / 160)


                For j As Integer = 0 To lenghtOfMessage - 1

                    message = Mid(OMsgToSend.Item(1).Message, (j * 160 + 1), 160)
                    comm.Write("AT+CMGS=" & (Len(ObjMessageSender.MessageSubmit(OMsgToSend.Item(1).MobilePhone, message)) / 2) - 1 & vbCr)
                    comm.Write(ObjMessageSender.MessageSubmit(OMsgToSend.Item(1).MobilePhone, message) & Chr(26))
                    'wait modem repson
                    Wait()

                    If j < lenghtOfMessage - 1 Then
                        ResetBuffer()
                    End If
                Next


                If IsOperationSuccess(Buffer) Then 'JIKA OPERASI SUKSES, HAPUS PESAN DARI DAFTAR

                    Dim x As ListViewItem
                    x = lvOutbox.Items.Insert(0, Format(OMsgToSend.Item(1).DateOfSMS, "dd/MM/yyyy hh:mm:yy"))
                    x.SubItems.Add(OMsgToSend.Item(1).MobilePhone)
                    x.SubItems.Add(OMsgToSend.Item(1).Message)
                    x.SubItems.Add("~ Message Sent- OK")
                    x.SubItems.Add(CommPort)
                    MovetoHistory(OMsgToSend.Item(1).ID) 'Pindah ke history
                    DeleteOutbox(OMsgToSend.Item(1).ID) ' HAPUS OUTBOX
                    OMsgToSend.Remove(1)

                ElseIf IsOperationError(Buffer) Then

                    Dim x As ListViewItem
                    x = lvOutbox.Items.Insert(0, Format(OMsgToSend.Item(1).DateOfSMS, "dd/MM/yyyy hh:mm:yy"))
                    x.SubItems.Add(OMsgToSend.Item(1).MobilePhone)
                    x.SubItems.Add(OMsgToSend.Item(1).Message)
                    x.SubItems.Add("~ Message Sent- Failed")
                    OMsgToSend.Item(1).trysend = OMsgToSend.Item(1).trysend + 1
                    If OMsgToSend.Item(1).trysend = 3 Then
                        OMsgToSend.Remove(1)
                    End If
                End If
                ResetBuffer()
            Next

        Else
            StatusStrip1.Items(4).Text = "Getting message (s) to send"
            GetMessageToSend() ' AMBIL PESAN YANG HARUS DIKIRIM DARI DATABASE
            StatusStrip1.Items(4).Text = "Idle"
            ResetBuffer()
        End If

        If Command = "BREAK" Then
            CloseDevice()
        End If

    End Sub

    ' FUNGSI UNTUK MENGUNGGU RESPON DARI DEVICE
    Sub Wait()
        Timer1.Enabled = False
        While Not AllReaded
            Application.DoEvents()
            StatusStrip1.Items(4).Text = "Waiting respon from modem"
        End While
    End Sub

    ' PESAN UNTUK MEAMBAHKAN PESAN YANG HARUS DIKIRM KE DAFTAR
    Private Sub SendMessage(ByVal ID As Long, ByVal Nomor As String, ByVal Message As String, ByVal SMSDate As Date)
        Dim item As New MessageItem

        item.ID = ID

        If Mid(Nomor, 1, 1) = "0" Then
            item.MobilePhone = "+62" & Mid(Nomor, 2, Nomor.Length)
        Else
            item.MobilePhone = Nomor
        End If

        item.Message = Message
        item.DateOfSMS = SMSDate

        OMsgToSend.Add(item)
    End Sub

    ' FUNGSI UNTUK MENGOSONGKAN BUFFER
    Private Sub ResetBuffer()
        Buffer = ""
        AllReaded = False
        Timer1.Enabled = True
    End Sub

    ' FUNGSI UNTUK INISIALIASI DEVICE
    Private Sub InitModem()

        comm.Write("AT" + Chr(13)) ' CEK DEVICE SUPPORT AT COMMAND ATAU IDAK
        Wait()

        ' JIKA DEVICE TIDAK SUPPORT AT COMMAND
        If IsOperationError(Buffer) Then
            CloseDevice()
            MsgBox("Device tidak support AT COMMAND.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ResetBuffer()

        ' DEAKTIFKAN MODE ECHO
        comm.Write("ATE0" + Chr(13))
        Wait()
        ResetBuffer()


        ' SET MODE DEVICE KE HEXADECIMAL
        comm.Write("AT+CMGF=0" + Chr(13))
        Wait()
        ResetBuffer()

        ' CARI TAHU MANUFAKTUR DEVCE
        comm.Write("AT+CGMI" + Chr(13))
        Wait()
        StatusStrip1.Items(0).Text = "Manufacture : " & ParseBufferOK(Buffer)
        ResetBuffer()

        ' CARI TAHU MODEL DEVICE
        comm.Write("AT+CGMM" + Chr(13))
        Wait()
        StatusStrip1.Items(1).Text = "Model : " & ParseBufferOK(Buffer)
        ResetBuffer()

        ' CARI TAHU SERIAL NUMBER DEVICE (IMMEI)
        comm.Write("AT+CGSN" + Chr(13))
        Wait()

        StatusStrip1.Items(2).Text = "Serial Number : " & ParseBufferOK(Buffer) & " Connected to " & comm.PortName
        ResetBuffer()

        If CekPulsaOnStart Then
            CekPulsa()
        End If


        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    ' FUNGSI UNTUK MENCARI DAFTAR PESAN YANG HARUS DIKIRM
    Private Sub GetMessageToSend()

        Dim obs(2) As Object
        Dim ds As New DataSet
        Dim dt As New DataTable
        'this is space to write StoreProcedure Execution Code
        Try


            ds = ExecuteSQLQuery("select id,no_hp,tgl_sms,pesan,ip,com from sms_outbox where ip='" & ServerName & "' and com='" & Replace(CommPort, "COM", "") & "'")
            dt = ds.Tables(0)

            If dt.Rows.Count = 0 Then
                FlagNewMessage = True

                Exit Sub
            End If
            Dim NOhp As String

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If Mid(GetFieldString(dt.Rows(i).Item("no_hp")), 1, 1) = "0" Then
                    NOhp = "+62" + Mid(GetFieldString(dt.Rows(i).Item("no_hp")), 2, GetFieldString(dt.Rows(i).Item("no_hp")).Length - 1)
                Else
                    NOhp = GetFieldString(dt.Rows(i).Item("no_hp"))

                End If

                SendMessage(GetFieldString(dt.Rows(i).Item("ID"), FormatString.None), NOhp, GetFieldString(dt.Rows(i).Item("pesan")), GetFieldString(dt.Rows(i).Item("tgl_sms"), FormatString.None))

            Next
            FlagNewMessage = False
            '-----------------------------------------------------------------

        Catch ex As Exception
            MsgBox("Gagal mendapatkan data SMS Outbox : " + ex.ToString, MsgBoxStyle.Critical)

            ds = Nothing
            dt = Nothing
        End Try


        ds = Nothing
        dt = Nothing
    End Sub



    ' HAPUS SMS OUTBOX
    Private Function DeleteOutbox(ByVal ID As Long) As Long

        Dim obs(0) As Object
        Dim retVal As Long

        'this is space to write StoreProcedure Execution Code
        Try

            ExecuteSQLQuery("delete from sms_outbox where ID='" & ID & "'")

        Catch ex As Exception
            retVal = -1
            Return retVal
        End Try


        Return retVal
    End Function

    Private Function MovetoHistory(ByVal ID As Long) As Long

        Dim ds As New DataSet
        Dim Tgl As Date, no_hp As String = "", pesan As String = "", tipe As Integer = 0, com As String = ""

        Dim retVal As Long

        'this is space to write StoreProcedure Execution Code
        Try
            ds = ExecuteSQLQuery("select * from sms_outbox where id='" & ID & "'")

            If ds.Tables(0).Rows.Count > 0 Then
                With ds.Tables(0).Rows(0)
                    Tgl = .Item("tgl_sms")
                    no_hp = GetFieldString(.Item("no_hp"), FormatString.None)
                    pesan = GetFieldString(.Item("pesan"), FormatString.None)
                    tipe = 1
                    com = GetFieldString(.Item("com"), FormatString.None)

                End With
            End If
            If ds.Tables(0).Rows.Count > 0 Then
                ExecuteSQLQuery("insert into sms_history(no_hp,pesan,tipe,com,tgl_sms) values('" & no_hp & "','" & pesan & "','" & tipe & "','" & com & "','" & Format(Tgl, "yyyy-MM-dd hh:mm:ss") & "')")
            End If
        Catch ex As Exception
            retVal = -1
            Return retVal
        End Try


        Return retVal
    End Function

    Dim cmd As MySqlCommand
    ' SIMPAN SMS DITERIMA KE DATABASE
    Private Function SaveMessage(ByVal Nomor As String, ByVal Message As String, ByVal SMSDate As Date) As Long
        Dim password As String = "C" + functions.GetRandom(100, 999).ToString + "A" + functions.GetRandom(10, 99).ToString + "P"
        Dim phone As String = "0" + Nomor.Substring(3, Nomor.Length - 3)

        If (Message.Length > 2) Then
            If ((Message.Substring(0, 3) = "REG") Or (Message.Substring(0, 3) = "reg") Or (Message.Substring(0, 3) = "Reg")) Then
                Try
                    functions.localConnect()
                    cmd = New MySqlCommand
                    cmd.Connection = functions.localConnection
                    cmd.CommandType = CommandType.Text

                    cmd.CommandText = "insert into daftarcustomer (phone, password) VALUES ('" & phone & "', '" & password & "')"
                    cmd.ExecuteNonQuery()

                    Dim pesan As String = "Pendaftaran Berhasil. USERNAME : " + phone + " dan PASSWORD : " + password
                    Try
                        SMSapplication.sendSMS(phone, pesan)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                Catch ex As MySqlException
                End Try
            End If
        End If
        Dim retVal As Long

        'this is space to write StoreProcedure Execution Code
        Try

            ExecuteSQLQuery("insert into sms_inbox(sourceno,tgl,text,port,ip) VALUES (" & _
                            "'" & Nomor & "','" & Format(SMSDate, "yyyy-MM-dd hh:mm:ss") & "','" & _
                            Message & "','" & Replace(CommPort, "COM", "") & "','" & ServerName & "')")
            '-----------------------------------------------------------------
        Catch ex As Exception

            retVal = 1
            Return retVal
        End Try
        Return retVal
    End Function

    Private Sub frmServer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If comm.IsOpen Then
            e.Cancel = 1
            NotifyIcon1.Visible = True
            Me.Visible = False
            NotifyIcon1.ShowBalloonTip(5000)
        Else

        End If

    End Sub


    Private Sub frmServer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetSettings()

        Text = "SMS Settings"
        StatusStrip1.Items(0).Text = "Disconnected from " & CommPort

        If ServerName = "" Or ProcessorName = "" Then
            MsgBox("Anda belum menentukan nama ServerGateway.", MsgBoxStyle.Exclamation)
            Dim frm As New frmSetting
            frm.ShowDialog()
            frm = Nothing

        End If

        '  toolConnect_Click(sender, e)
    End Sub


    Private Sub lvInbox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInbox.Resize
        lvInbox.Columns(0).Width = 100
        lvInbox.Columns(1).Width = 100
        lvInbox.Columns(2).Width = lvInbox.Width - 300
    End Sub


    Private Sub lvInbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvInbox.SelectedIndexChanged
        If lvInbox.SelectedItems.Count > 0 Then
            txtDetail.Text = lvInbox.SelectedItems(0).SubItems(2).Text
        End If

    End Sub

    Private Sub lvOutbox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvOutbox.Resize
        lvOutbox.Columns(0).Width = 100
        lvOutbox.Columns(1).Width = 100
        lvOutbox.Columns(2).Width = lvOutbox.Width - 450
    End Sub

    Private Sub lvOutbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvOutbox.SelectedIndexChanged
        If lvOutbox.SelectedItems.Count > 0 Then
            txtDetail.Text = lvOutbox.SelectedItems(0).SubItems(2).Text
        End If

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'jika belum terbuka
        If Not comm.IsOpen Then
            comm.BaudRate = BaudRate
            comm.StopBits = StopBits
            comm.Parity = IO.Ports.Parity.None
            comm.DataBits = DataBits
            comm.PortName = CommPort
            comm.Open()
        Else
            comm.Write("AT" & Chr(13))
        End If
    End Sub

    Sub CekPulsa()
        Dim respon As String
        Dim ReminderNo() As String
        ReminderNo = Split(CekPulsaSendTo, vbNewLine)
        IsUSSD = True
        comm.Write("AT+CUSD=1," & CekPulsaNo + Chr(13))
        Dim y As ListViewItem
        y = lvOutbox.Items.Insert(0, Format(Now, "dd/MM/yyyy hh:mm:ss"))
        y.SubItems.Add("Cek Pulsa")
        y.SubItems.Add(CekPulsaNo)
        y.SubItems.Add("~ Message Sent- OK")
        y.SubItems.Add(CommPort)
        Wait()

        respon = GetUSSDRespon(Buffer)

        If respon = "" Then
            respon = "Modem tidak support USSD command"
        End If
        If ReminderPulsa And ReminderNo.Length > 0 Then
            For i As Integer = 0 To ReminderNo.Length - 1
                SendMessage(0, ReminderNo(i), respon, Now)
            Next
        End If



        Dim x As ListViewItem
        x = lvInbox.Items.Insert(0, Format(Now, "dd/MM/yyyy hh:mm:ss"))
        x.SubItems.Add("Cek Pulsa")
        x.SubItems.Add(respon)
        x.SubItems.Add(CommPort)

        ResetBuffer()
        IsUSSD = False
        comm.Write("AT+CUSD=2" + Chr(13))
        Wait()
        ResetBuffer()
    End Sub



    Private Sub toolReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolReset.Click
        Try


            Dim Xparity As String = ""
            Select Case Parity

                Case "Even"
                    Xparity = "2"
                Case "Odd"
                    Xparity = "1"
                Case "None"
                    Xparity = "0"
                Case "Mark"
                    Xparity = "3"
                Case "Space"
                    Xparity = "4"
            End Select


            comm.BaudRate = BaudRate
            comm.StopBits = StopBits
            comm.Parity = Xparity
            comm.DataBits = DataBits
            comm.PortName = CommPort

            'jika belum terbuka, buka koneksi dengan device

            If Not comm.IsOpen Then
                comm.Open()
            End If

            If comm.IsOpen Then
                Buffer = ""
                AllReaded = False

                If MsgBox("Reset modem ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    comm.Close()
                    Exit Sub
                End If


                comm.Write("AT+CFUN=0" + Chr(13))
                Wait()


                If IsOperationError(Buffer) Then
                    MsgBox("Operasi reset modem gagal.", MsgBoxStyle.Critical)
                    Buffer = ""
                    AllReaded = False
                    Exit Sub
                End If

                comm.Write("AT+CFUN=1" + Chr(13))
                Wait()

                If IsOperationSuccess(Buffer) Then
                    MsgBox("Modem berhasil di reset. Silakan koneksikan ulang modem.", MsgBoxStyle.Information)
                    Buffer = ""
                    AllReaded = False
                Else
                    MsgBox("Operasi reset modem gagal.", MsgBoxStyle.Critical)
                    Buffer = ""
                    AllReaded = False

                End If

            End If
            StatusStrip1.Items(4).Text = "Idle"
            comm.Close()
        Catch ex As Exception
            MsgBox("Modem belum siap", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtDetail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDetail.TextChanged

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Visible = False
        Me.Visible = True
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim frm As New frmAbout
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSend.Click
        Dim frm As New frmSendSMS
        frm.ShowDialog()
        frm = Nothing
    End Sub
End Class

