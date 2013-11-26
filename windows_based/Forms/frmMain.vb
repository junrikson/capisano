Imports MySql.Data.MySqlClient
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        variabels.codename = "capisano"
        frmLogin.ShowDialog()
    End Sub

    Private Sub timerShow_Tick(sender As Object, e As EventArgs) Handles timerShow.Tick
        If (Me.Opacity = 1) Then
            timerShow.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.01
        End If
    End Sub

    Private Sub WebSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSettingsToolStripMenuItem.Click
        Dim frm As New frmServerSettings
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SMSTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSTemplateToolStripMenuItem.Click
        Dim frm As New frmSMSTemplate
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DaftarItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarItemToolStripMenuItem.Click
        Dim frm As New frmDaftarItem
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DaftarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarMenuToolStripMenuItem.Click
        Dim frm As New frmDaftarMenu
        frmDaftarMenu.MdiParent = Me
        frmDaftarMenu.Show()
    End Sub

    Private Sub DaftarKategoriMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKategoriMenuToolStripMenuItem.Click
        Dim frm As New frmDaftarKategoriMenu
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DaftarKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKategoriToolStripMenuItem.Click
        Dim frm As New frmDaftarKategoriItem
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SMSSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSSettingsToolStripMenuItem.Click
        Dim frm As New frmSMSSettings
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAbout.Show()
    End Sub

    Private Sub OrderPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderPendingToolStripMenuItem.Click
        Dim frm As New frmOrderAndPending
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PaymentPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentPendingToolStripMenuItem.Click
        Dim frm As New frmPaymentsAndPending
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UserManagementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem1.Click
        Dim frm As New frmUsersManagement
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AdministratorLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministratorLogsToolStripMenuItem.Click
        Dim frm As New frmActivityLog
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ClosingBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosingBulananToolStripMenuItem.Click
        frmClosingBulanan.Show()
    End Sub

    Private Sub GantiPeriodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPeriodeToolStripMenuItem.Click
        frmGantiPeriode.Show()
    End Sub
End Class
