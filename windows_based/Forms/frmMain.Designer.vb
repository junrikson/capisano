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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolstripMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgBottom1 = New System.Windows.Forms.PictureBox()
        Me.lineBottom1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgBottom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 12)
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
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOOLSToolStripMenuItem, Me.SMSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.toolstripMain})
        Me.MenuStrip1.Location = New System.Drawing.Point(8, 44)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(221, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolstripMain
        '
        Me.toolstripMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.toolstripMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.toolstripMain.ImageTransparentColor = System.Drawing.SystemColors.Control
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(47, 20)
        Me.toolstripMain.Text = "HELP"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.TOOLSToolStripMenuItem.Text = "TOOLS"
        '
        'SMSToolStripMenuItem
        '
        Me.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        Me.SMSToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SMSToolStripMenuItem.Text = "SMS"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthlyReportsToolStripMenuItem, Me.DailyReportsToolStripMenuItem})
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgBottom1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.Text = "Capisano - Catering Pilih Pesan Online dengan SMS Gateway"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgBottom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents timerShow As System.Windows.Forms.Timer
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
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

End Class
