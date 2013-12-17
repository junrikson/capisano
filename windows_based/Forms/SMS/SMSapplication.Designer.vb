<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSapplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMSapplication))
        Me.tabSMSapplication = New System.Windows.Forms.TabControl()
        Me.tbPortSettings = New System.Windows.Forms.TabPage()
        Me.gboPortSettings = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtWriteTimeOut = New System.Windows.Forms.TextBox()
        Me.txtReadTimeOut = New System.Windows.Forms.TextBox()
        Me.cboParityBits = New System.Windows.Forms.ComboBox()
        Me.cboStopBits = New System.Windows.Forms.ComboBox()
        Me.cboDataBits = New System.Windows.Forms.ComboBox()
        Me.cboBaudRate = New System.Windows.Forms.ComboBox()
        Me.cboPortName = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbSendSMS = New System.Windows.Forms.TabPage()
        Me.gboSendSMS = New System.Windows.Forms.GroupBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtSIM = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.tbReadSMS = New System.Windows.Forms.TabPage()
        Me.gboReadSMS = New System.Windows.Forms.GroupBox()
        Me.rbReadStoreUnSent = New System.Windows.Forms.RadioButton()
        Me.rbReadStoreSent = New System.Windows.Forms.RadioButton()
        Me.rbReadUnRead = New System.Windows.Forms.RadioButton()
        Me.rbReadAll = New System.Windows.Forms.RadioButton()
        Me.btnReadSMS = New System.Windows.Forms.Button()
        Me.lvwMessages = New System.Windows.Forms.ListView()
        Me.colIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSentTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMessage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbDeleteSMS = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCountSMS = New System.Windows.Forms.Button()
        Me.txtCountSMS = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.gboDeleteSMS = New System.Windows.Forms.GroupBox()
        Me.rbDeleteReadSMS = New System.Windows.Forms.RadioButton()
        Me.btnDeleteSMS = New System.Windows.Forms.Button()
        Me.rbDeleteAllSMS = New System.Windows.Forms.RadioButton()
        Me.gboConnectionStatus = New System.Windows.Forms.GroupBox()
        Me.label23 = New System.Windows.Forms.Label()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.tabSMSapplication.SuspendLayout()
        Me.tbPortSettings.SuspendLayout()
        Me.gboPortSettings.SuspendLayout()
        Me.tbSendSMS.SuspendLayout()
        Me.gboSendSMS.SuspendLayout()
        Me.tbReadSMS.SuspendLayout()
        Me.gboReadSMS.SuspendLayout()
        Me.tbDeleteSMS.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.gboDeleteSMS.SuspendLayout()
        Me.gboConnectionStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSMSapplication
        '
        Me.tabSMSapplication.Controls.Add(Me.tbPortSettings)
        Me.tabSMSapplication.Controls.Add(Me.tbSendSMS)
        Me.tabSMSapplication.Controls.Add(Me.tbReadSMS)
        Me.tabSMSapplication.Controls.Add(Me.tbDeleteSMS)
        Me.tabSMSapplication.Location = New System.Drawing.Point(12, 12)
        Me.tabSMSapplication.Name = "tabSMSapplication"
        Me.tabSMSapplication.SelectedIndex = 0
        Me.tabSMSapplication.Size = New System.Drawing.Size(524, 400)
        Me.tabSMSapplication.TabIndex = 1
        '
        'tbPortSettings
        '
        Me.tbPortSettings.Controls.Add(Me.gboPortSettings)
        Me.tbPortSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbPortSettings.Name = "tbPortSettings"
        Me.tbPortSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPortSettings.Size = New System.Drawing.Size(516, 374)
        Me.tbPortSettings.TabIndex = 0
        Me.tbPortSettings.Text = "Port Settings"
        Me.tbPortSettings.UseVisualStyleBackColor = True
        '
        'gboPortSettings
        '
        Me.gboPortSettings.Controls.Add(Me.btnOK)
        Me.gboPortSettings.Controls.Add(Me.txtWriteTimeOut)
        Me.gboPortSettings.Controls.Add(Me.txtReadTimeOut)
        Me.gboPortSettings.Controls.Add(Me.cboParityBits)
        Me.gboPortSettings.Controls.Add(Me.cboStopBits)
        Me.gboPortSettings.Controls.Add(Me.cboDataBits)
        Me.gboPortSettings.Controls.Add(Me.cboBaudRate)
        Me.gboPortSettings.Controls.Add(Me.cboPortName)
        Me.gboPortSettings.Controls.Add(Me.label7)
        Me.gboPortSettings.Controls.Add(Me.label6)
        Me.gboPortSettings.Controls.Add(Me.label5)
        Me.gboPortSettings.Controls.Add(Me.label4)
        Me.gboPortSettings.Controls.Add(Me.label3)
        Me.gboPortSettings.Controls.Add(Me.label2)
        Me.gboPortSettings.Controls.Add(Me.label1)
        Me.gboPortSettings.Location = New System.Drawing.Point(16, 17)
        Me.gboPortSettings.Name = "gboPortSettings"
        Me.gboPortSettings.Size = New System.Drawing.Size(469, 337)
        Me.gboPortSettings.TabIndex = 0
        Me.gboPortSettings.TabStop = False
        Me.gboPortSettings.Text = "Port Settings"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(200, 289)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 25)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "Connect"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtWriteTimeOut
        '
        Me.txtWriteTimeOut.Location = New System.Drawing.Point(219, 220)
        Me.txtWriteTimeOut.MaxLength = 5
        Me.txtWriteTimeOut.Name = "txtWriteTimeOut"
        Me.txtWriteTimeOut.Size = New System.Drawing.Size(121, 20)
        Me.txtWriteTimeOut.TabIndex = 13
        Me.txtWriteTimeOut.Text = "300"
        '
        'txtReadTimeOut
        '
        Me.txtReadTimeOut.Location = New System.Drawing.Point(219, 194)
        Me.txtReadTimeOut.MaxLength = 5
        Me.txtReadTimeOut.Name = "txtReadTimeOut"
        Me.txtReadTimeOut.Size = New System.Drawing.Size(121, 20)
        Me.txtReadTimeOut.TabIndex = 12
        Me.txtReadTimeOut.Text = "300"
        '
        'cboParityBits
        '
        Me.cboParityBits.FormattingEnabled = True
        Me.cboParityBits.Items.AddRange(New Object() {"Even", "Odd", "None"})
        Me.cboParityBits.Location = New System.Drawing.Point(219, 167)
        Me.cboParityBits.Name = "cboParityBits"
        Me.cboParityBits.Size = New System.Drawing.Size(121, 21)
        Me.cboParityBits.TabIndex = 11
        Me.cboParityBits.Text = "None"
        '
        'cboStopBits
        '
        Me.cboStopBits.FormattingEnabled = True
        Me.cboStopBits.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.cboStopBits.Location = New System.Drawing.Point(219, 140)
        Me.cboStopBits.Name = "cboStopBits"
        Me.cboStopBits.Size = New System.Drawing.Size(121, 21)
        Me.cboStopBits.TabIndex = 10
        Me.cboStopBits.Text = "1"
        '
        'cboDataBits
        '
        Me.cboDataBits.FormattingEnabled = True
        Me.cboDataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cboDataBits.Location = New System.Drawing.Point(219, 113)
        Me.cboDataBits.Name = "cboDataBits"
        Me.cboDataBits.Size = New System.Drawing.Size(121, 21)
        Me.cboDataBits.TabIndex = 9
        Me.cboDataBits.Text = "8"
        '
        'cboBaudRate
        '
        Me.cboBaudRate.FormattingEnabled = True
        Me.cboBaudRate.Items.AddRange(New Object() {"110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"})
        Me.cboBaudRate.Location = New System.Drawing.Point(219, 85)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.cboBaudRate.TabIndex = 8
        Me.cboBaudRate.Text = "9600"
        '
        'cboPortName
        '
        Me.cboPortName.FormattingEnabled = True
        Me.cboPortName.Location = New System.Drawing.Point(219, 58)
        Me.cboPortName.Name = "cboPortName"
        Me.cboPortName.Size = New System.Drawing.Size(121, 21)
        Me.cboPortName.TabIndex = 7
        Me.cboPortName.Text = "COM1"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(128, 223)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 6
        Me.label7.Text = "Write Timeout"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(128, 197)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(74, 13)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Read Timeout"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(128, 170)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(53, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Parity Bits"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(128, 143)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Stop Bits"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(127, 116)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(50, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Data Bits"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(128, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Baud Rate"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(128, 62)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Port Name"
        '
        'tbSendSMS
        '
        Me.tbSendSMS.Controls.Add(Me.gboSendSMS)
        Me.tbSendSMS.Location = New System.Drawing.Point(4, 22)
        Me.tbSendSMS.Name = "tbSendSMS"
        Me.tbSendSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSendSMS.Size = New System.Drawing.Size(516, 374)
        Me.tbSendSMS.TabIndex = 1
        Me.tbSendSMS.Text = "Send SMS"
        Me.tbSendSMS.UseVisualStyleBackColor = True
        '
        'gboSendSMS
        '
        Me.gboSendSMS.Controls.Add(Me.label8)
        Me.gboSendSMS.Controls.Add(Me.btnSendSMS)
        Me.gboSendSMS.Controls.Add(Me.label9)
        Me.gboSendSMS.Controls.Add(Me.txtSIM)
        Me.gboSendSMS.Controls.Add(Me.txtMessage)
        Me.gboSendSMS.Location = New System.Drawing.Point(20, 6)
        Me.gboSendSMS.Name = "gboSendSMS"
        Me.gboSendSMS.Size = New System.Drawing.Size(479, 352)
        Me.gboSendSMS.TabIndex = 43
        Me.gboSendSMS.TabStop = False
        Me.gboSendSMS.Text = "Send SMS"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(72, 115)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 13)
        Me.label8.TabIndex = 43
        Me.label8.Text = "Message"
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Location = New System.Drawing.Point(198, 297)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(75, 25)
        Me.btnSendSMS.TabIndex = 40
        Me.btnSendSMS.Text = "Send"
        Me.btnSendSMS.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(182, 46)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(26, 13)
        Me.label9.TabIndex = 42
        Me.label9.Text = "SIM"
        '
        'txtSIM
        '
        Me.txtSIM.Location = New System.Drawing.Point(185, 62)
        Me.txtSIM.MaxLength = 15
        Me.txtSIM.Name = "txtSIM"
        Me.txtSIM.Size = New System.Drawing.Size(118, 20)
        Me.txtSIM.TabIndex = 41
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(75, 131)
        Me.txtMessage.MaxLength = 160
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(323, 134)
        Me.txtMessage.TabIndex = 39
        '
        'tbReadSMS
        '
        Me.tbReadSMS.Controls.Add(Me.gboReadSMS)
        Me.tbReadSMS.Location = New System.Drawing.Point(4, 22)
        Me.tbReadSMS.Name = "tbReadSMS"
        Me.tbReadSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbReadSMS.Size = New System.Drawing.Size(516, 374)
        Me.tbReadSMS.TabIndex = 2
        Me.tbReadSMS.Text = "Read SMS"
        Me.tbReadSMS.UseVisualStyleBackColor = True
        '
        'gboReadSMS
        '
        Me.gboReadSMS.Controls.Add(Me.rbReadStoreUnSent)
        Me.gboReadSMS.Controls.Add(Me.rbReadStoreSent)
        Me.gboReadSMS.Controls.Add(Me.rbReadUnRead)
        Me.gboReadSMS.Controls.Add(Me.rbReadAll)
        Me.gboReadSMS.Controls.Add(Me.btnReadSMS)
        Me.gboReadSMS.Controls.Add(Me.lvwMessages)
        Me.gboReadSMS.Location = New System.Drawing.Point(19, 10)
        Me.gboReadSMS.Name = "gboReadSMS"
        Me.gboReadSMS.Size = New System.Drawing.Size(481, 347)
        Me.gboReadSMS.TabIndex = 43
        Me.gboReadSMS.TabStop = False
        Me.gboReadSMS.Text = "Read SMS"
        '
        'rbReadStoreUnSent
        '
        Me.rbReadStoreUnSent.AutoSize = True
        Me.rbReadStoreUnSent.Location = New System.Drawing.Point(191, 53)
        Me.rbReadStoreUnSent.Name = "rbReadStoreUnSent"
        Me.rbReadStoreUnSent.Size = New System.Drawing.Size(144, 17)
        Me.rbReadStoreUnSent.TabIndex = 48
        Me.rbReadStoreUnSent.Text = "Read Store UnSent SMS"
        Me.rbReadStoreUnSent.UseVisualStyleBackColor = True
        '
        'rbReadStoreSent
        '
        Me.rbReadStoreSent.AutoSize = True
        Me.rbReadStoreSent.Location = New System.Drawing.Point(191, 30)
        Me.rbReadStoreSent.Name = "rbReadStoreSent"
        Me.rbReadStoreSent.Size = New System.Drawing.Size(130, 17)
        Me.rbReadStoreSent.TabIndex = 47
        Me.rbReadStoreSent.Text = "Read Store Sent SMS"
        Me.rbReadStoreSent.UseVisualStyleBackColor = True
        '
        'rbReadUnRead
        '
        Me.rbReadUnRead.AutoSize = True
        Me.rbReadUnRead.Location = New System.Drawing.Point(24, 53)
        Me.rbReadUnRead.Name = "rbReadUnRead"
        Me.rbReadUnRead.Size = New System.Drawing.Size(120, 17)
        Me.rbReadUnRead.TabIndex = 45
        Me.rbReadUnRead.Text = "Read UnRead SMS"
        Me.rbReadUnRead.UseVisualStyleBackColor = True
        '
        'rbReadAll
        '
        Me.rbReadAll.AutoSize = True
        Me.rbReadAll.Location = New System.Drawing.Point(24, 30)
        Me.rbReadAll.Name = "rbReadAll"
        Me.rbReadAll.Size = New System.Drawing.Size(91, 17)
        Me.rbReadAll.TabIndex = 44
        Me.rbReadAll.Text = "Read All SMS"
        Me.rbReadAll.UseVisualStyleBackColor = True
        '
        'btnReadSMS
        '
        Me.btnReadSMS.Location = New System.Drawing.Point(203, 300)
        Me.btnReadSMS.Name = "btnReadSMS"
        Me.btnReadSMS.Size = New System.Drawing.Size(75, 25)
        Me.btnReadSMS.TabIndex = 41
        Me.btnReadSMS.Text = "Read"
        Me.btnReadSMS.UseVisualStyleBackColor = True
        '
        'lvwMessages
        '
        Me.lvwMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIndex, Me.colSentTime, Me.colSender, Me.colMessage})
        Me.lvwMessages.FullRowSelect = True
        Me.lvwMessages.Location = New System.Drawing.Point(16, 127)
        Me.lvwMessages.MultiSelect = False
        Me.lvwMessages.Name = "lvwMessages"
        Me.lvwMessages.Size = New System.Drawing.Size(448, 152)
        Me.lvwMessages.TabIndex = 38
        Me.lvwMessages.UseCompatibleStateImageBehavior = False
        Me.lvwMessages.View = System.Windows.Forms.View.Details
        '
        'colIndex
        '
        Me.colIndex.Text = "Index"
        Me.colIndex.Width = 43
        '
        'colSentTime
        '
        Me.colSentTime.Text = "SentTime"
        Me.colSentTime.Width = 69
        '
        'colSender
        '
        Me.colSender.Text = "Sender"
        Me.colSender.Width = 50
        '
        'colMessage
        '
        Me.colMessage.Text = "Message"
        Me.colMessage.Width = 275
        '
        'tbDeleteSMS
        '
        Me.tbDeleteSMS.Controls.Add(Me.groupBox1)
        Me.tbDeleteSMS.Controls.Add(Me.gboDeleteSMS)
        Me.tbDeleteSMS.Location = New System.Drawing.Point(4, 22)
        Me.tbDeleteSMS.Name = "tbDeleteSMS"
        Me.tbDeleteSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDeleteSMS.Size = New System.Drawing.Size(516, 374)
        Me.tbDeleteSMS.TabIndex = 3
        Me.tbDeleteSMS.Text = "Delete SMS"
        Me.tbDeleteSMS.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnCountSMS)
        Me.groupBox1.Controls.Add(Me.txtCountSMS)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Location = New System.Drawing.Point(70, 23)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(375, 96)
        Me.groupBox1.TabIndex = 45
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Count SMS"
        '
        'btnCountSMS
        '
        Me.btnCountSMS.Location = New System.Drawing.Point(149, 55)
        Me.btnCountSMS.Name = "btnCountSMS"
        Me.btnCountSMS.Size = New System.Drawing.Size(75, 25)
        Me.btnCountSMS.TabIndex = 46
        Me.btnCountSMS.Text = "Count"
        Me.btnCountSMS.UseVisualStyleBackColor = True
        '
        'txtCountSMS
        '
        Me.txtCountSMS.Location = New System.Drawing.Point(80, 26)
        Me.txtCountSMS.Name = "txtCountSMS"
        Me.txtCountSMS.ReadOnly = True
        Me.txtCountSMS.Size = New System.Drawing.Size(34, 20)
        Me.txtCountSMS.TabIndex = 1
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(13, 29)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(61, 13)
        Me.label10.TabIndex = 0
        Me.label10.Text = "Count SMS"
        '
        'gboDeleteSMS
        '
        Me.gboDeleteSMS.Controls.Add(Me.rbDeleteReadSMS)
        Me.gboDeleteSMS.Controls.Add(Me.btnDeleteSMS)
        Me.gboDeleteSMS.Controls.Add(Me.rbDeleteAllSMS)
        Me.gboDeleteSMS.Location = New System.Drawing.Point(70, 169)
        Me.gboDeleteSMS.Name = "gboDeleteSMS"
        Me.gboDeleteSMS.Size = New System.Drawing.Size(375, 153)
        Me.gboDeleteSMS.TabIndex = 44
        Me.gboDeleteSMS.TabStop = False
        Me.gboDeleteSMS.Text = "Delete SMS"
        '
        'rbDeleteReadSMS
        '
        Me.rbDeleteReadSMS.AutoSize = True
        Me.rbDeleteReadSMS.Checked = True
        Me.rbDeleteReadSMS.Location = New System.Drawing.Point(16, 58)
        Me.rbDeleteReadSMS.Name = "rbDeleteReadSMS"
        Me.rbDeleteReadSMS.Size = New System.Drawing.Size(114, 17)
        Me.rbDeleteReadSMS.TabIndex = 45
        Me.rbDeleteReadSMS.TabStop = True
        Me.rbDeleteReadSMS.Text = "Delete Read SMS "
        Me.rbDeleteReadSMS.UseVisualStyleBackColor = True
        '
        'btnDeleteSMS
        '
        Me.btnDeleteSMS.Location = New System.Drawing.Point(149, 111)
        Me.btnDeleteSMS.Name = "btnDeleteSMS"
        Me.btnDeleteSMS.Size = New System.Drawing.Size(75, 25)
        Me.btnDeleteSMS.TabIndex = 42
        Me.btnDeleteSMS.Text = "Delete"
        Me.btnDeleteSMS.UseVisualStyleBackColor = True
        '
        'rbDeleteAllSMS
        '
        Me.rbDeleteAllSMS.AutoSize = True
        Me.rbDeleteAllSMS.Location = New System.Drawing.Point(16, 26)
        Me.rbDeleteAllSMS.Name = "rbDeleteAllSMS"
        Me.rbDeleteAllSMS.Size = New System.Drawing.Size(96, 17)
        Me.rbDeleteAllSMS.TabIndex = 43
        Me.rbDeleteAllSMS.Text = "Delete All SMS"
        Me.rbDeleteAllSMS.UseVisualStyleBackColor = True
        '
        'gboConnectionStatus
        '
        Me.gboConnectionStatus.BackColor = System.Drawing.Color.Transparent
        Me.gboConnectionStatus.Controls.Add(Me.label23)
        Me.gboConnectionStatus.Controls.Add(Me.lblConnectionStatus)
        Me.gboConnectionStatus.Controls.Add(Me.btnDisconnect)
        Me.gboConnectionStatus.Location = New System.Drawing.Point(76, 418)
        Me.gboConnectionStatus.Name = "gboConnectionStatus"
        Me.gboConnectionStatus.Size = New System.Drawing.Size(361, 56)
        Me.gboConnectionStatus.TabIndex = 42
        Me.gboConnectionStatus.TabStop = False
        Me.gboConnectionStatus.Text = "Connection Status"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(16, 19)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(100, 13)
        Me.label23.TabIndex = 37
        Me.label23.Text = "Connection Status :"
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.AutoSize = True
        Me.lblConnectionStatus.ForeColor = System.Drawing.Color.Red
        Me.lblConnectionStatus.Location = New System.Drawing.Point(25, 32)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(79, 13)
        Me.lblConnectionStatus.TabIndex = 36
        Me.lblConnectionStatus.Text = "Not Connected"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(259, 19)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 25)
        Me.btnDisconnect.TabIndex = 4
        Me.btnDisconnect.Text = "Disconnect"
        '
        'statusBar1
        '
        Me.statusBar1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.statusBar1.Location = New System.Drawing.Point(0, 510)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(539, 20)
        Me.statusBar1.TabIndex = 76
        Me.statusBar1.Text = "Message"
        '
        'SMSapplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 530)
        Me.Controls.Add(Me.statusBar1)
        Me.Controls.Add(Me.gboConnectionStatus)
        Me.Controls.Add(Me.tabSMSapplication)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SMSapplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMSapplication"
        Me.tabSMSapplication.ResumeLayout(False)
        Me.tbPortSettings.ResumeLayout(False)
        Me.gboPortSettings.ResumeLayout(False)
        Me.gboPortSettings.PerformLayout()
        Me.tbSendSMS.ResumeLayout(False)
        Me.gboSendSMS.ResumeLayout(False)
        Me.gboSendSMS.PerformLayout()
        Me.tbReadSMS.ResumeLayout(False)
        Me.gboReadSMS.ResumeLayout(False)
        Me.gboReadSMS.PerformLayout()
        Me.tbDeleteSMS.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.gboDeleteSMS.ResumeLayout(False)
        Me.gboDeleteSMS.PerformLayout()
        Me.gboConnectionStatus.ResumeLayout(False)
        Me.gboConnectionStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tabSMSapplication As System.Windows.Forms.TabControl
    Private WithEvents tbPortSettings As System.Windows.Forms.TabPage
    Private WithEvents gboPortSettings As System.Windows.Forms.GroupBox
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents txtWriteTimeOut As System.Windows.Forms.TextBox
    Private WithEvents txtReadTimeOut As System.Windows.Forms.TextBox
    Private WithEvents cboParityBits As System.Windows.Forms.ComboBox
    Private WithEvents cboStopBits As System.Windows.Forms.ComboBox
    Private WithEvents cboDataBits As System.Windows.Forms.ComboBox
    Private WithEvents cboBaudRate As System.Windows.Forms.ComboBox
    Private WithEvents cboPortName As System.Windows.Forms.ComboBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents tbSendSMS As System.Windows.Forms.TabPage
    Private WithEvents gboSendSMS As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents btnSendSMS As System.Windows.Forms.Button
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtSIM As System.Windows.Forms.TextBox
    Private WithEvents txtMessage As System.Windows.Forms.TextBox
    Private WithEvents tbReadSMS As System.Windows.Forms.TabPage
    Private WithEvents gboReadSMS As System.Windows.Forms.GroupBox
    Private WithEvents rbReadStoreUnSent As System.Windows.Forms.RadioButton
    Private WithEvents rbReadStoreSent As System.Windows.Forms.RadioButton
    Private WithEvents rbReadUnRead As System.Windows.Forms.RadioButton
    Private WithEvents rbReadAll As System.Windows.Forms.RadioButton
    Private WithEvents btnReadSMS As System.Windows.Forms.Button
    Private WithEvents lvwMessages As System.Windows.Forms.ListView
    Private WithEvents colIndex As System.Windows.Forms.ColumnHeader
    Private WithEvents colSentTime As System.Windows.Forms.ColumnHeader
    Private WithEvents colSender As System.Windows.Forms.ColumnHeader
    Private WithEvents colMessage As System.Windows.Forms.ColumnHeader
    Private WithEvents tbDeleteSMS As System.Windows.Forms.TabPage
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnCountSMS As System.Windows.Forms.Button
    Private WithEvents txtCountSMS As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents gboDeleteSMS As System.Windows.Forms.GroupBox
    Private WithEvents rbDeleteReadSMS As System.Windows.Forms.RadioButton
    Private WithEvents btnDeleteSMS As System.Windows.Forms.Button
    Private WithEvents rbDeleteAllSMS As System.Windows.Forms.RadioButton
    Private WithEvents gboConnectionStatus As System.Windows.Forms.GroupBox
    Private WithEvents label23 As System.Windows.Forms.Label
    Private WithEvents lblConnectionStatus As System.Windows.Forms.Label
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents statusBar1 As System.Windows.Forms.StatusBar
End Class
