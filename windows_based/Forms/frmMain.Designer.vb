﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.timerShow = New System.Windows.Forms.Timer(Me.components)
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DaftarKategoriMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DaftarCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.panelRightBorder = New System.Windows.Forms.Panel()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timerOutputUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPendingDKI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkDKI = New System.Windows.Forms.CheckBox()
        Me.lblPendingDI = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkDI = New System.Windows.Forms.CheckBox()
        Me.lblPendingDKM = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkDKM = New System.Windows.Forms.CheckBox()
        Me.lblPendingDM = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkDM = New System.Windows.Forms.CheckBox()
        Me.lblPendingDC = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkDC = New System.Windows.Forms.CheckBox()
        Me.btnUpdateOutput = New System.Windows.Forms.Button()
        Me.txtIntervalOutput = New System.Windows.Forms.TextBox()
        Me.chkIntervalOutput = New System.Windows.Forms.CheckBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.panelInfo = New System.Windows.Forms.Panel()
        Me.menuMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.panelRightBorder.SuspendLayout()
        Me.panelInfo.SuspendLayout()
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
        Me.TOOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarKategoriToolStripMenuItem, Me.DaftarItemToolStripMenuItem, Me.ToolStripSeparator3, Me.DaftarKategoriMenuToolStripMenuItem, Me.DaftarMenuToolStripMenuItem, Me.ToolStripSeparator4, Me.DaftarCustomerToolStripMenuItem})
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(184, 6)
        '
        'DaftarCustomerToolStripMenuItem
        '
        Me.DaftarCustomerToolStripMenuItem.Name = "DaftarCustomerToolStripMenuItem"
        Me.DaftarCustomerToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DaftarCustomerToolStripMenuItem.Text = "Daftar Customer"
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
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.panelStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.panelStatus.Name = "panelStatus"
        Me.panelStatus.Size = New System.Drawing.Size(255, 17)
        Me.panelStatus.Text = "Selamat datang di capisano."
        Me.panelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelRightBorder
        '
        Me.panelRightBorder.AllowDrop = True
        Me.panelRightBorder.BackColor = System.Drawing.SystemColors.Control
        Me.panelRightBorder.Controls.Add(Me.btnShowInfo)
        Me.panelRightBorder.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelRightBorder.Location = New System.Drawing.Point(0, 34)
        Me.panelRightBorder.Name = "panelRightBorder"
        Me.panelRightBorder.Size = New System.Drawing.Size(19, 544)
        Me.panelRightBorder.TabIndex = 56
        '
        'btnShowInfo
        '
        Me.btnShowInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnShowInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowInfo.FlatAppearance.BorderSize = 0
        Me.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnShowInfo.Location = New System.Drawing.Point(0, 6)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(16, 110)
        Me.btnShowInfo.TabIndex = 57
        Me.btnShowInfo.Text = "SUMMARY"
        Me.btnShowInfo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 10)
        Me.Panel1.TabIndex = 2
        '
        'timerOutputUpdate
        '
        Me.timerOutputUpdate.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data output update pending"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Web Server"
        '
        'lblPendingDKI
        '
        Me.lblPendingDKI.Location = New System.Drawing.Point(4, 31)
        Me.lblPendingDKI.Name = "lblPendingDKI"
        Me.lblPendingDKI.Size = New System.Drawing.Size(24, 13)
        Me.lblPendingDKI.TabIndex = 3
        Me.lblPendingDKI.Text = "0"
        Me.lblPendingDKI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(31, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Daftar Kategori Item"
        '
        'chkDKI
        '
        Me.chkDKI.AutoSize = True
        Me.chkDKI.Location = New System.Drawing.Point(147, 30)
        Me.chkDKI.Name = "chkDKI"
        Me.chkDKI.Size = New System.Drawing.Size(15, 14)
        Me.chkDKI.TabIndex = 6
        Me.chkDKI.UseVisualStyleBackColor = True
        '
        'lblPendingDI
        '
        Me.lblPendingDI.Location = New System.Drawing.Point(4, 51)
        Me.lblPendingDI.Name = "lblPendingDI"
        Me.lblPendingDI.Size = New System.Drawing.Size(24, 13)
        Me.lblPendingDI.TabIndex = 7
        Me.lblPendingDI.Text = "0"
        Me.lblPendingDI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(31, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Daftar Item"
        '
        'chkDI
        '
        Me.chkDI.AutoSize = True
        Me.chkDI.Location = New System.Drawing.Point(147, 50)
        Me.chkDI.Name = "chkDI"
        Me.chkDI.Size = New System.Drawing.Size(15, 14)
        Me.chkDI.TabIndex = 9
        Me.chkDI.UseVisualStyleBackColor = True
        '
        'lblPendingDKM
        '
        Me.lblPendingDKM.Location = New System.Drawing.Point(4, 71)
        Me.lblPendingDKM.Name = "lblPendingDKM"
        Me.lblPendingDKM.Size = New System.Drawing.Size(24, 13)
        Me.lblPendingDKM.TabIndex = 10
        Me.lblPendingDKM.Text = "0"
        Me.lblPendingDKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(31, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Daftar Kategori Menu"
        '
        'chkDKM
        '
        Me.chkDKM.AutoSize = True
        Me.chkDKM.Location = New System.Drawing.Point(147, 70)
        Me.chkDKM.Name = "chkDKM"
        Me.chkDKM.Size = New System.Drawing.Size(15, 14)
        Me.chkDKM.TabIndex = 12
        Me.chkDKM.UseVisualStyleBackColor = True
        '
        'lblPendingDM
        '
        Me.lblPendingDM.Location = New System.Drawing.Point(4, 91)
        Me.lblPendingDM.Name = "lblPendingDM"
        Me.lblPendingDM.Size = New System.Drawing.Size(24, 13)
        Me.lblPendingDM.TabIndex = 13
        Me.lblPendingDM.Text = "0"
        Me.lblPendingDM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(31, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Daftar Menu"
        '
        'chkDM
        '
        Me.chkDM.AutoSize = True
        Me.chkDM.Location = New System.Drawing.Point(147, 90)
        Me.chkDM.Name = "chkDM"
        Me.chkDM.Size = New System.Drawing.Size(15, 14)
        Me.chkDM.TabIndex = 15
        Me.chkDM.UseVisualStyleBackColor = True
        '
        'lblPendingDC
        '
        Me.lblPendingDC.Location = New System.Drawing.Point(4, 111)
        Me.lblPendingDC.Name = "lblPendingDC"
        Me.lblPendingDC.Size = New System.Drawing.Size(24, 13)
        Me.lblPendingDC.TabIndex = 16
        Me.lblPendingDC.Text = "0"
        Me.lblPendingDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(31, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Daftar Customer"
        '
        'chkDC
        '
        Me.chkDC.AutoSize = True
        Me.chkDC.Location = New System.Drawing.Point(147, 110)
        Me.chkDC.Name = "chkDC"
        Me.chkDC.Size = New System.Drawing.Size(15, 14)
        Me.chkDC.TabIndex = 18
        Me.chkDC.UseVisualStyleBackColor = True
        '
        'btnUpdateOutput
        '
        Me.btnUpdateOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateOutput.Location = New System.Drawing.Point(138, 135)
        Me.btnUpdateOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpdateOutput.Name = "btnUpdateOutput"
        Me.btnUpdateOutput.Size = New System.Drawing.Size(52, 26)
        Me.btnUpdateOutput.TabIndex = 19
        Me.btnUpdateOutput.Text = "Update"
        Me.btnUpdateOutput.UseVisualStyleBackColor = True
        '
        'txtIntervalOutput
        '
        Me.txtIntervalOutput.Location = New System.Drawing.Point(72, 139)
        Me.txtIntervalOutput.Name = "txtIntervalOutput"
        Me.txtIntervalOutput.Size = New System.Drawing.Size(57, 20)
        Me.txtIntervalOutput.TabIndex = 20
        Me.txtIntervalOutput.Text = "1000"
        '
        'chkIntervalOutput
        '
        Me.chkIntervalOutput.AutoSize = True
        Me.chkIntervalOutput.Location = New System.Drawing.Point(10, 141)
        Me.chkIntervalOutput.Name = "chkIntervalOutput"
        Me.chkIntervalOutput.Size = New System.Drawing.Size(61, 17)
        Me.chkIntervalOutput.TabIndex = 21
        Me.chkIntervalOutput.Text = "Interval"
        Me.chkIntervalOutput.UseVisualStyleBackColor = True
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(29, 209)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(100, 20)
        Me.txtTest.TabIndex = 22
        '
        'panelInfo
        '
        Me.panelInfo.BackColor = System.Drawing.SystemColors.Control
        Me.panelInfo.Controls.Add(Me.txtTest)
        Me.panelInfo.Controls.Add(Me.chkIntervalOutput)
        Me.panelInfo.Controls.Add(Me.txtIntervalOutput)
        Me.panelInfo.Controls.Add(Me.btnUpdateOutput)
        Me.panelInfo.Controls.Add(Me.chkDC)
        Me.panelInfo.Controls.Add(Me.Label12)
        Me.panelInfo.Controls.Add(Me.lblPendingDC)
        Me.panelInfo.Controls.Add(Me.chkDM)
        Me.panelInfo.Controls.Add(Me.Label10)
        Me.panelInfo.Controls.Add(Me.lblPendingDM)
        Me.panelInfo.Controls.Add(Me.chkDKM)
        Me.panelInfo.Controls.Add(Me.Label8)
        Me.panelInfo.Controls.Add(Me.lblPendingDKM)
        Me.panelInfo.Controls.Add(Me.chkDI)
        Me.panelInfo.Controls.Add(Me.Label6)
        Me.panelInfo.Controls.Add(Me.lblPendingDI)
        Me.panelInfo.Controls.Add(Me.chkDKI)
        Me.panelInfo.Controls.Add(Me.Label5)
        Me.panelInfo.Controls.Add(Me.Label4)
        Me.panelInfo.Controls.Add(Me.lblPendingDKI)
        Me.panelInfo.Controls.Add(Me.Label3)
        Me.panelInfo.Controls.Add(Me.Label1)
        Me.panelInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelInfo.Location = New System.Drawing.Point(19, 34)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Size = New System.Drawing.Size(200, 544)
        Me.panelInfo.TabIndex = 59
        Me.panelInfo.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panelInfo)
        Me.Controls.Add(Me.panelRightBorder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.panelRightBorder.ResumeLayout(False)
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
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
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DaftarCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelRightBorder As System.Windows.Forms.Panel
    Friend WithEvents btnShowInfo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents timerOutputUpdate As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPendingDKI As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkDKI As System.Windows.Forms.CheckBox
    Friend WithEvents lblPendingDI As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkDI As System.Windows.Forms.CheckBox
    Friend WithEvents lblPendingDKM As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkDKM As System.Windows.Forms.CheckBox
    Friend WithEvents lblPendingDM As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkDM As System.Windows.Forms.CheckBox
    Friend WithEvents lblPendingDC As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkDC As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdateOutput As System.Windows.Forms.Button
    Friend WithEvents txtIntervalOutput As System.Windows.Forms.TextBox
    Friend WithEvents chkIntervalOutput As System.Windows.Forms.CheckBox
    Friend WithEvents txtTest As System.Windows.Forms.TextBox
    Friend WithEvents panelInfo As System.Windows.Forms.Panel

End Class
