Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim cmd As MySqlDataReader
    'fungsi untuk drag form
    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)
    Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub
    Private Sub frmLogin_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub
    Private Sub frmLogin_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmLocalServerSettings.Close()
        frmMain.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cek As Integer = 0
        Try
            functions.localConnect()
            cmd = New MySqlCommand("Select password from user where username ='" + txtUsername.Text + "'", functions.localConnection).ExecuteReader()
            Try
                cmd.Read()
                If (cmd.GetString(0) = txtPassword.Text) Then
                    cek = 1
                End If
                cmd.Close()
            Catch ex As Exception
                cek = 0
                cmd.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cek = 2
            cmd.Close()
        End Try

        If (cek = 1) Then
            Me.Close()
            frmLocalServerSettings.Close()
            frmMain.Show()
            frmMain.timerShow.Start()
            variabels.oper = txtUsername.Text
            variabels.periode = functions.getPeriode
            variabels.periodeAktif = functions.getPeriode
        ElseIf (cek = 0) Then
            MessageBox.Show("Username atau Password salah!")
        ElseIf (cek = 2) Then
            MessageBox.Show("Koneksi Bermasalah!")
        End If
    End Sub

    Private Sub btnServerSettings_Click(sender As Object, e As EventArgs) Handles btnServerSettings.Click
        frmLocalServerSettings.ShowDialog()
    End Sub

    Private Sub timerShow_Tick(sender As Object, e As EventArgs) Handles timerShow.Tick
        If (Me.Opacity = 1) Then
            timerShow.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.01
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerShow.Start()
    End Sub
End Class