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
        If (functions.cekOtoritas("priv_a2")) Then
            Dim frm As New frmDaftarItem
            frm.MdiParent = Me
            frm.Show()
        Else
            MessageBox.Show("You dont have access to view this modul !", "No Access !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DaftarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarMenuToolStripMenuItem.Click
        If (functions.cekOtoritas("priv_a4")) Then
            Dim frm As New frmDaftarMenu
            frmDaftarMenu.MdiParent = Me
            frmDaftarMenu.Show()
        Else
            MessageBox.Show("You dont have access to view this modul !", "No Access !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DaftarKategoriMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKategoriMenuToolStripMenuItem.Click
        If (functions.cekOtoritas("priv_a3")) Then
            Dim frm As New frmDaftarKategoriMenu
            frm.MdiParent = Me
            frm.Show()
        Else
            MessageBox.Show("You dont have access to view this modul !", "No Access !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DaftarKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKategoriToolStripMenuItem.Click
        If (functions.cekOtoritas("priv_a1")) Then
            Dim frm As New frmDaftarKategoriItem
            frm.MdiParent = Me
            frm.Show()
        Else
            MessageBox.Show("You dont have access to view this modul !", "No Access !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub SMSSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSSettingsToolStripMenuItem.Click
        Dim frm As New frmSMSSettings
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAbout.MdiParent = Me
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
        frmClosingBulanan.MdiParent = Me
        frmClosingBulanan.Show()
    End Sub

    Private Sub GantiPeriodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPeriodeToolStripMenuItem.Click
        frmGantiPeriode.MdiParent = Me
        frmGantiPeriode.Show()
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Process.Start("http://www.capisano.tk/forum/")
    End Sub

    Private Sub DaftarCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarCustomerToolStripMenuItem.Click
        Dim frm As New frmDaftarCustomer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        If (panelInfo.Visible = True) Then
            panelInfo.Visible = False
        Else
            panelInfo.Visible = True
        End If
    End Sub

    Dim test As Integer = 0
    Private Sub timerOutputUpdate_Tick(sender As Object, e As EventArgs) Handles timerOutputUpdate.Tick
        test = test + 1
        txtTest.Text = test
    End Sub

    Private Sub btnUpdateOutput_Click(sender As Object, e As EventArgs) Handles btnUpdateOutput.Click
        timerOutputUpdate.Interval = txtIntervalOutput.Text
        If (chkIntervalOutput.Checked = True) Then
            timerOutputUpdate.Start()
        Else
            timerOutputUpdate.Stop()
        End If
    End Sub
End Class
