Public Class frmLocalServerSettings
    'fungsi untuk drag form
    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)
    Private Sub frmServerSettings_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub
    Private Sub frmServerSettings_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub
    Private Sub frmServerSettings_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.Close()
    End Sub

    Private Sub lblMin_MouseLeave(sender As Object, e As EventArgs) Handles lblMin.MouseLeave
        lblMin.BackColor = Color.Transparent
    End Sub

    Private Sub lblMin_MouseMove(sender As Object, e As MouseEventArgs) Handles lblMin.MouseMove
        lblMin.BackColor = Color.White
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.BackColor = Color.Transparent
    End Sub

    Private Sub lblExit_MouseMove(sender As Object, e As MouseEventArgs) Handles lblExit.MouseMove
        lblExit.BackColor = Color.White
    End Sub

    Private Sub frmServerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerShow.Start()
    End Sub

    Private Sub timerShow_Tick(sender As Object, e As EventArgs) Handles timerShow.Tick
        If (Me.Opacity = 1) Then
            timerShow.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.01
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class