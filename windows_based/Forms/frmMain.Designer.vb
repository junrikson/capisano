<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timerShow = New System.Windows.Forms.Timer(Me.components)
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DaftarKategoriMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserManagementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosingBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPeriodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SMSSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.panelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerShow
        '
        Me.timerShow.Interval = 10
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOOLSToolStripMenuItem, Me.SMSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.SETTINGSToolStripMenuItem, Me.toolstripMain})
        Me.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(800, 24)
        Me.menuMain.TabIndex = 52
        Me.menuMain.Text = "MenuStrip1"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarKategoriToolStripMenuItem, Me.DaftarItemToolStripMenuItem, Me.ToolStripSeparator3, Me.DaftarKategoriMenuToolStripMenuItem, Me.DaftarMenuToolStripMenuItem})
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.TOOLSToolStripMenuItem.Text = "DATA MASTER"
        '
        'DaftarKategoriToolStripMenuItem
        '
        Me.DaftarKategoriToolStripMenuItem.Name = "DaftarKategoriToolStripMenuItem"
        Me.DaftarKategoriToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DaftarKategoriToolStripMenuItem.Text = "Daftar Kategori Item"
        '
        'DaftarItemToolStripMenuItem
        '
        Me.DaftarItemToolStripMenuItem.Name = "DaftarItemToolStripMenuItem"
        Me.DaftarItemToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DaftarItemToolStripMenuItem.Text = "Daftar Item"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(184, 6)
        '
        'DaftarKategoriMenuToolStripMenuItem
        '
        Me.DaftarKategoriMenuToolStripMenuItem.Name = "DaftarKategoriMenuToolStripMenuItem"
        Me.DaftarKategoriMenuToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DaftarKategoriMenuToolStripMenuItem.Text = "Daftar Kategori Menu"
        '
        'DaftarMenuToolStripMenuItem
        '
        Me.DaftarMenuToolStripMenuItem.Name = "DaftarMenuToolStripMenuItem"
        Me.DaftarMenuToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DaftarMenuToolStripMenuItem.Text = "Daftar Menu "
        '
        'SMSToolStripMenuItem
        '
        Me.SMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderPendingToolStripMenuItem, Me.PaymentPendingToolStripMenuItem, Me.ToolStripSeparator2, Me.UserManagementToolStripMenuItem1, Me.AdministratorLogsToolStripMenuItem, Me.ClosingBulananToolStripMenuItem, Me.GantiPeriodeToolStripMenuItem})
        Me.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        Me.SMSToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SMSToolStripMenuItem.Text = "TOOLS"
        '
        'OrderPendingToolStripMenuItem
        '
        Me.OrderPendingToolStripMenuItem.Name = "OrderPendingToolStripMenuItem"
        Me.OrderPendingToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OrderPendingToolStripMenuItem.Text = "Orders and Pending"
        '
        'PaymentPendingToolStripMenuItem
        '
        Me.PaymentPendingToolStripMenuItem.Name = "PaymentPendingToolStripMenuItem"
        Me.PaymentPendingToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PaymentPendingToolStripMenuItem.Text = "Payments and Pending"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'UserManagementToolStripMenuItem1
        '
        Me.UserManagementToolStripMenuItem1.Name = "UserManagementToolStripMenuItem1"
        Me.UserManagementToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.UserManagementToolStripMenuItem1.Text = "Users Management"
        '
        'AdministratorLogsToolStripMenuItem
        '
        Me.AdministratorLogsToolStripMenuItem.Name = "AdministratorLogsToolStripMenuItem"
        Me.AdministratorLogsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AdministratorLogsToolStripMenuItem.Text = "Activity Logs"
        '
        'ClosingBulananToolStripMenuItem
        '
        Me.ClosingBulananToolStripMenuItem.Name = "ClosingBulananToolStripMenuItem"
        Me.ClosingBulananToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ClosingBulananToolStripMenuItem.Text = "Closing Bulanan"
        '
        'GantiPeriodeToolStripMenuItem
        '
        Me.GantiPeriodeToolStripMenuItem.Name = "GantiPeriodeToolStripMenuItem"
        Me.GantiPeriodeToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.GantiPeriodeToolStripMenuItem.Text = "Ganti Periode"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportsToolStripMenuItem, Me.MonthlyReportsToolStripMenuItem, Me.OrderReportToolStripMenuItem, Me.PaymentsReportToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'DailyReportsToolStripMenuItem
        '
        Me.DailyReportsToolStripMenuItem.Name = "DailyReportsToolStripMenuItem"
        Me.DailyReportsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DailyReportsToolStripMenuItem.Text = "Daily Reports"
        '
        'MonthlyReportsToolStripMenuItem
        '
        Me.MonthlyReportsToolStripMenuItem.Name = "MonthlyReportsToolStripMenuItem"
        Me.MonthlyReportsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MonthlyReportsToolStripMenuItem.Text = "Monthly Reports"
        '
        'OrderReportToolStripMenuItem
        '
        Me.OrderReportToolStripMenuItem.Name = "OrderReportToolStripMenuItem"
        Me.OrderReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OrderReportToolStripMenuItem.Text = "Order Report"
        '
        'PaymentsReportToolStripMenuItem
        '
        Me.PaymentsReportToolStripMenuItem.Name = "PaymentsReportToolStripMenuItem"
        Me.PaymentsReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PaymentsReportToolStripMenuItem.Text = "Payments Report"
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.SMSSettingsToolStripMenuItem, Me.SMSTemplateToolStripMenuItem})
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SETTINGSToolStripMenuItem.Text = "SETTINGS"
        '
        'WebSettingsToolStripMenuItem
        '
        Me.WebSettingsToolStripMenuItem.Name = "WebSettingsToolStripMenuItem"
        Me.WebSettingsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.WebSettingsToolStripMenuItem.Text = "Server Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'SMSSettingsToolStripMenuItem
        '
        Me.SMSSettingsToolStripMenuItem.Name = "SMSSettingsToolStripMenuItem"
        Me.SMSSettingsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SMSSettingsToolStripMenuItem.Text = "SMS Settings"
        '
        'SMSTemplateToolStripMenuItem
        '
        Me.SMSTemplateToolStripMenuItem.Name = "SMSTemplateToolStripMenuItem"
        Me.SMSTemplateToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SMSTemplateToolStripMenuItem.Text = "SMS Template"
        '
        'toolstripMain
        '
        Me.toolstripMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.toolstripMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.toolstripMain.ImageTransparentColor = System.Drawing.SystemColors.Control
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(47, 20)
        Me.toolstripMain.Text = "HELP"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ViewHelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.panelStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'panelStatus
        '
        Me.panelStatus.AutoSize = False
        Me.panelStatus.Name = "panelStatus"
        Me.panelStatus.Size = New System.Drawing.Size(255, 17)
        Me.panelStatus.Text = "Selamat datang di capisano."
        Me.panelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.Text = "Capisano - Catering Pilih Pesan Online dengan SMS Gateway"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerShow As System.Windows.Forms.Timer
    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents TOOLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarKategoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DaftarKategoriMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserManagementToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClosingBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPeriodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SMSSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents panelStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
