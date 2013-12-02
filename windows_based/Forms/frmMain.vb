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
        Dim frm As New frmServer
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

    'Fungsi Pada Left Sidebar
    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        If (panelInfo.Visible = True) Then
            panelInfo.Visible = False
        Else
            panelInfo.Visible = True
        End If
    End Sub

    Private Sub timerOutputUpdate_Tick(sender As Object, e As EventArgs) Handles timerOutputUpdate.Tick
        If (chkDKI.Enabled = True) Then
            functions.updateDaftarKategoriItem()
        End If
        If (chkDI.Enabled = True) Then
            functions.updateDaftarItem()
        End If
        If (chkDKM.Enabled = True) Then
            functions.updateDaftarKategoriMenu()
        End If
        If (chkDM.Enabled = True) Then
            functions.updateDaftarMenu()
        End If
        If (chkDC.Enabled = True) Then
            functions.updateDaftarCustomer()
        End If
    End Sub

    Private Sub btnUpdateOutput_Click(sender As Object, e As EventArgs) Handles btnUpdateOutput.Click
        timerOutputUpdate.Interval = txtIntervalOutput.Text
        If (btnUpdateOutput.Text = "Start") Then
            timerOutputUpdate.Start()
            btnUpdateOutput.Text = "Stop"
        Else
            timerOutputUpdate.Stop()
            btnUpdateOutput.Text = "Start"
        End If
    End Sub

   Private Sub btnDKI_Click(sender As Object, e As EventArgs) Handles btnDKI.Click
        If (btnDKI.Text = "C") Then
            functions.buttonCek("select count(*) from daftarkategoriitem where status='N' || status='U'", btnDKI, lblPendingDKI)
        Else
            functions.updateDaftarKategoriItem()
        End If
    End Sub

    Private Sub btnDI_Click(sender As Object, e As EventArgs) Handles btnDI.Click
        If (btnDI.Text = "C") Then
            functions.buttonCek("select count(*) from daftaritem where status='N' || status='U'", btnDI, lblPendingDI)
        Else
            functions.updateDaftarItem()
        End If
    End Sub

    Private Sub btnDKM_Click(sender As Object, e As EventArgs) Handles btnDKM.Click
        If (btnDKM.Text = "C") Then
            functions.buttonCek("select count(*) from daftarkategorimenu where status='N' || status='U'", btnDKM, lblPendingDKM)
        Else
            functions.updateDaftarKategoriMenu()
        End If
    End Sub

    Private Sub btnDM_Click(sender As Object, e As EventArgs) Handles btnDM.Click
        If (btnDM.Text = "C") Then
            functions.buttonCek("select a1.total + a2.total from ((select count(*) as total from daftarmenu where status='N' || status='U') as a1, (select count(*) as total from daftarmenudetails where status='N' || status='U') as a2)", btnDM, lblPendingDM)
        Else
            functions.updateDaftarMenu()
        End If
    End Sub

    Private Sub btnDC_Click(sender As Object, e As EventArgs) Handles btnDC.Click
        If (btnDC.Text = "C") Then
            functions.buttonCek("select count(*) from daftarcustomer where status='N' || status='U'", btnDC, lblPendingDC)
        Else
            functions.updateDaftarCustomer()
        End If
    End Sub
End Class
