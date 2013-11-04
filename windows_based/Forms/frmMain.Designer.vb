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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.timerShow = New System.Windows.Forms.Timer(Me.components)
        Me.lblMin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DaftarKategoriMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SMSSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgBottom1 = New System.Windows.Forms.PictureBox()
        Me.lineBottom1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.OrderPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosingBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPeriodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OrderReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuMain.SuspendLayout()
        CType(Me.imgBottom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Capisano - Catering Pilih Pesan Online dengan SMS Gateway"
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.SystemColors.Control
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Black
        Me.lblExit.Location = New System.Drawing.Point(771, 1)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(30, 25)
        Me.lblExit.TabIndex = 39
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMax
        '
        Me.lblMax.BackColor = System.Drawing.SystemColors.Control
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.Color.Black
        Me.lblMax.Location = New System.Drawing.Point(741, 1)
        Me.lblMax.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(30, 25)
        Me.lblMax.TabIndex = 40
        Me.lblMax.Text = "□"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerShow
        '
        Me.timerShow.Interval = 10
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.Control
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Black
        Me.lblMin.Location = New System.Drawing.Point(711, 1)
        Me.lblMin.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(30, 25)
        Me.lblMin.TabIndex = 41
        Me.lblMin.Text = "—"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 24)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'menuMain
        '
        Me.menuMain.AutoSize = False
        Me.menuMain.Dock = System.Windows.Forms.DockStyle.None
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOOLSToolStripMenuItem, Me.SMSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.SETTINGSToolStripMenuItem, Me.toolstripMain})
        Me.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.menuMain.Location = New System.Drawing.Point(0, 44)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(792, 24)
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
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportsToolStripMenuItem, Me.MonthlyReportsToolStripMenuItem, Me.OrderReportToolStripMenuItem, Me.PaymentsReportToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'MonthlyReportsToolStripMenuItem
        '
        Me.MonthlyReportsToolStripMenuItem.Name = "MonthlyReportsToolStripMenuItem"
        Me.MonthlyReportsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MonthlyReportsToolStripMenuItem.Text = "Monthly Reports"
        '
        'DailyReportsToolStripMenuItem
        '
        Me.DailyReportsToolStripMenuItem.Name = "DailyReportsToolStripMenuItem"
        Me.DailyReportsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DailyReportsToolStripMenuItem.Text = "Daily Reports"
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
        Me.SMSSettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewHelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'imgBottom1
        '
        Me.imgBottom1.BackgroundImage = CType(resources.GetObject("imgBottom1.BackgroundImage"), System.Drawing.Image)
        Me.imgBottom1.Enabled = False
        Me.imgBottom1.Location = New System.Drawing.Point(0, 543)
        Me.imgBottom1.Name = "imgBottom1"
        Me.imgBottom1.Size = New System.Drawing.Size(440, 49)
        Me.imgBottom1.TabIndex = 53
        Me.imgBottom1.TabStop = False
        '
        'lineBottom1
        '
        Me.lineBottom1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lineBottom1.BorderWidth = 10
        Me.lineBottom1.Enabled = False
        Me.lineBottom1.Name = "lineBottom1"
        Me.lineBottom1.X1 = -1
        Me.lineBottom1.X2 = 440
        Me.lineBottom1.Y1 = 595
        Me.lineBottom1.Y2 = 595
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lineBottom1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 600)
        Me.ShapeContainer1.TabIndex = 54
        Me.ShapeContainer1.TabStop = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.SystemColors.Control
        Me.panelTop.Controls.Add(Me.menuMain)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(800, 80)
        Me.panelTop.TabIndex = 55
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelMain.Location = New System.Drawing.Point(0, 87)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(788, 276)
        Me.panelMain.TabIndex = 56
        '
        'OrderPendingToolStripMenuItem
        '
        Me.OrderPendingToolStripMenuItem.Name = "OrderPendingToolStripMenuItem"
        Me.OrderPendingToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OrderPendingToolStripMenuItem.Text = "Order and Pending"
        '
        'PaymentPendingToolStripMenuItem
        '
        Me.PaymentPendingToolStripMenuItem.Name = "PaymentPendingToolStripMenuItem"
        Me.PaymentPendingToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PaymentPendingToolStripMenuItem.Text = "Payments and Pending"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'OrderReportToolStripMenuItem
        '
        Me.OrderReportToolStripMenuItem.Name = "OrderReportToolStripMenuItem"
        Me.OrderReportToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OrderReportToolStripMenuItem.Text = "Order Report"
        '
        'PaymentsReportToolStripMenuItem
        '
        Me.PaymentsReportToolStripMenuItem.Name = "PaymentsReportToolStripMenuItem"
        Me.PaymentsReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PaymentsReportToolStripMenuItem.Text = "Payments Report"
        '
        'AdministratorLogsToolStripMenuItem
        '
        Me.AdministratorLogsToolStripMenuItem.Name = "AdministratorLogsToolStripMenuItem"
        Me.AdministratorLogsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AdministratorLogsToolStripMenuItem.Text = "Activity Logs"
        '
        'UserManagementToolStripMenuItem1
        '
        Me.UserManagementToolStripMenuItem1.Name = "UserManagementToolStripMenuItem1"
        Me.UserManagementToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.UserManagementToolStripMenuItem1.Text = "Users Management"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.imgBottom1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.Text = "Capisano - Catering Pilih Pesan Online dengan SMS Gateway"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        CType(Me.imgBottom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents timerShow As System.Windows.Forms.Timer
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOOLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgBottom1 As System.Windows.Forms.PictureBox
    Friend WithEvents lineBottom1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents SETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SMSTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarKategoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DaftarKategoriMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents OrderPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClosingBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPeriodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
