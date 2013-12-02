Public Class frmSetting

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim config As System.Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)

        If txtServerNAme.Text.Trim = "" Then
            MsgBox("Server Name harus diisi.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If txtProcName.Text.Trim = "" Then
            MsgBox("Processor Name   harus diisi.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If CheckBox1.Checked And txtRceiver.Text.Trim = "" Then
            MsgBox("Nomor Penerima   harus diisi.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Val(txtRefresh.Text) < 1 Then
            MsgBox("Time refresh harus lebih dari nol.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        config.AppSettings.Settings.Item("ServerName").Value = txtServerNAme.Text
        config.AppSettings.Settings.Item("Processor").Value = txtProcName.Text
        config.AppSettings.Settings.Item("CommPort").Value = cbPort.Text
        config.AppSettings.Settings.Item("BaudRate").Value = cbBaudRate.Text
        config.AppSettings.Settings.Item("DataBits").Value = cbDataBits.Text
        config.AppSettings.Settings.Item("Parity").Value = cbParity.Text
        config.AppSettings.Settings.Item("StopBits").Value = cbStopBits.Text
        config.AppSettings.Settings.Item("TimeRefresh").Value = txtRefresh.Text
        config.AppSettings.Settings.Item("Autostart").Value = CheckBox3.Checked.ToString

        config.AppSettings.Settings.Item("CekPulsaOnStart").Value = CInt(CheckBox2.Checked)
        config.AppSettings.Settings.Item("ReminderActive").Value = CInt(CheckBox1.Checked)
        config.AppSettings.Settings.Item("CekPulsaNo").Value = txtDestNumb.Text
        config.AppSettings.Settings.Item("CekPulsaSendTo").Value = txtRceiver.Text
        config.AppSettings.Settings.Item("ReminderEvent").Value = jam.Value & ":" & menit.Value

        config.Save()

        GetSettings()

        Close()

    End Sub

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbPort.Items.Clear()
        For i As Integer = 1 To 256
            cbPort.Items.Add("COM" & i)
        Next
        txtServerNAme.Text = ServerName
        cbBaudRate.Text = BaudRate
        cbStopBits.Text = StopBits
        cbParity.Text = Parity
        cbDataBits.Text = DataBits
        cbPort.Text = CommPort
        txtProcName.Text = ProcessorName
        txtRefresh.Text = timeRefreshx
        txtDestNumb.Text = CekPulsaNo
        CheckBox1.Checked = ReminderPulsa
        CheckBox2.Checked = CekPulsaOnStart

        If Autostart.ToUpper = "TRUE" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If

        If ReminderEvent.Trim <> "" Then
            jam.Value = Val(Split(ReminderEvent, ":")(0))
            menit.Value = Val(Split(ReminderEvent, ":")(1))
        End If

        txtRceiver.Text = CekPulsaSendTo
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label8.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox3.CheckedChanged
        GroupBox3.Enabled = CheckBox1.Checked
    End Sub
End Class