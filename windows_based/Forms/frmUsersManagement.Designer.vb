<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsersManagement))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.gridList = New System.Windows.Forms.DataGridView()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CapisanoDataSet = New Capisano.capisanoDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.CheckBox()
        Me.a1 = New System.Windows.Forms.CheckBox()
        Me.a2 = New System.Windows.Forms.CheckBox()
        Me.a4 = New System.Windows.Forms.CheckBox()
        Me.a3 = New System.Windows.Forms.CheckBox()
        Me.b4 = New System.Windows.Forms.CheckBox()
        Me.b3 = New System.Windows.Forms.CheckBox()
        Me.b2 = New System.Windows.Forms.CheckBox()
        Me.b1 = New System.Windows.Forms.CheckBox()
        Me.b = New System.Windows.Forms.CheckBox()
        Me.b5 = New System.Windows.Forms.CheckBox()
        Me.b6 = New System.Windows.Forms.CheckBox()
        Me.c = New System.Windows.Forms.CheckBox()
        Me.d = New System.Windows.Forms.CheckBox()
        Me.f = New System.Windows.Forms.CheckBox()
        Me.d3 = New System.Windows.Forms.CheckBox()
        Me.d2 = New System.Windows.Forms.CheckBox()
        Me.d1 = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.UserTableAdapter = New Capisano.capisanoDataSetTableAdapters.userTableAdapter()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapisanoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(447, 20)
        Me.txtSearch.TabIndex = 42
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(461, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 41
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'gridList
        '
        Me.gridList.AllowUserToAddRows = False
        Me.gridList.AllowUserToDeleteRows = False
        Me.gridList.AllowUserToOrderColumns = True
        Me.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridList.Location = New System.Drawing.Point(12, 38)
        Me.gridList.Name = "gridList"
        Me.gridList.ReadOnly = True
        Me.gridList.Size = New System.Drawing.Size(524, 151)
        Me.gridList.TabIndex = 40
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.CapisanoDataSet
        '
        'CapisanoDataSet
        '
        Me.CapisanoDataSet.DataSetName = "capisanoDataSet"
        Me.CapisanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Username :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(79, 195)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(161, 20)
        Me.txtUsername.TabIndex = 44
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 221)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(161, 20)
        Me.txtPassword.TabIndex = 46
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Otoritas :"
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(79, 249)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(95, 17)
        Me.a.TabIndex = 48
        Me.a.Text = "Data Master"
        Me.a.UseVisualStyleBackColor = True
        '
        'a1
        '
        Me.a1.AutoSize = True
        Me.a1.Location = New System.Drawing.Point(96, 272)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(120, 17)
        Me.a1.TabIndex = 49
        Me.a1.Text = "Daftar Kategori Item"
        Me.a1.UseVisualStyleBackColor = True
        '
        'a2
        '
        Me.a2.AutoSize = True
        Me.a2.Location = New System.Drawing.Point(222, 272)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(78, 17)
        Me.a2.TabIndex = 50
        Me.a2.Text = "Daftar Item"
        Me.a2.UseVisualStyleBackColor = True
        '
        'a4
        '
        Me.a4.AutoSize = True
        Me.a4.Location = New System.Drawing.Point(439, 272)
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(85, 17)
        Me.a4.TabIndex = 52
        Me.a4.Text = "Daftar Menu"
        Me.a4.UseVisualStyleBackColor = True
        '
        'a3
        '
        Me.a3.AutoSize = True
        Me.a3.Location = New System.Drawing.Point(306, 272)
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(127, 17)
        Me.a3.TabIndex = 51
        Me.a3.Text = "Daftar Kategori Menu"
        Me.a3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.AutoSize = True
        Me.b4.Location = New System.Drawing.Point(96, 341)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(81, 17)
        Me.b4.TabIndex = 57
        Me.b4.Text = "Activity Log"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.AutoSize = True
        Me.b3.Location = New System.Drawing.Point(363, 318)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(118, 17)
        Me.b3.TabIndex = 56
        Me.b3.Text = "Users Management"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.AutoSize = True
        Me.b2.Location = New System.Drawing.Point(222, 318)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(135, 17)
        Me.b2.TabIndex = 55
        Me.b2.Text = "Payments and Pending"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.AutoSize = True
        Me.b1.Location = New System.Drawing.Point(96, 318)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(120, 17)
        Me.b1.TabIndex = 54
        Me.b1.Text = "Orders and Pending"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(79, 295)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(57, 17)
        Me.b.TabIndex = 53
        Me.b.Text = "Tools"
        Me.b.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.AutoSize = True
        Me.b5.Location = New System.Drawing.Point(222, 341)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(102, 17)
        Me.b5.TabIndex = 58
        Me.b5.Text = "Closing Bulanan"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.AutoSize = True
        Me.b6.Location = New System.Drawing.Point(363, 341)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(84, 17)
        Me.b6.TabIndex = 59
        Me.b6.Text = "Ganti Priode"
        Me.b6.UseVisualStyleBackColor = True
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(79, 364)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(70, 17)
        Me.c.TabIndex = 60
        Me.c.Text = "Reports"
        Me.c.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.Location = New System.Drawing.Point(79, 387)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(72, 17)
        Me.d.TabIndex = 61
        Me.d.Text = "Settings"
        Me.d.UseVisualStyleBackColor = True
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f.Location = New System.Drawing.Point(79, 434)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(52, 17)
        Me.f.TabIndex = 62
        Me.f.Text = "Help"
        Me.f.UseVisualStyleBackColor = True
        '
        'd3
        '
        Me.d3.AutoSize = True
        Me.d3.Location = New System.Drawing.Point(363, 411)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(96, 17)
        Me.d3.TabIndex = 65
        Me.d3.Text = "SMS Template"
        Me.d3.UseVisualStyleBackColor = True
        '
        'd2
        '
        Me.d2.AutoSize = True
        Me.d2.Location = New System.Drawing.Point(222, 411)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(90, 17)
        Me.d2.TabIndex = 64
        Me.d2.Text = "SMS Settings"
        Me.d2.UseVisualStyleBackColor = True
        '
        'd1
        '
        Me.d1.AutoSize = True
        Me.d1.Location = New System.Drawing.Point(96, 411)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(98, 17)
        Me.d1.TabIndex = 63
        Me.d1.Text = "Server Settings"
        Me.d1.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(325, 198)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 66
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(325, 227)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 67
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(406, 198)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 68
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(406, 227)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 69
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'frmUsersManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 461)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a4)
        Me.Controls.Add(Me.a3)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gridList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsersManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users Management"
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapisanoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents gridList As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.CheckBox
    Friend WithEvents a1 As System.Windows.Forms.CheckBox
    Friend WithEvents a2 As System.Windows.Forms.CheckBox
    Friend WithEvents a4 As System.Windows.Forms.CheckBox
    Friend WithEvents a3 As System.Windows.Forms.CheckBox
    Friend WithEvents b4 As System.Windows.Forms.CheckBox
    Friend WithEvents b3 As System.Windows.Forms.CheckBox
    Friend WithEvents b2 As System.Windows.Forms.CheckBox
    Friend WithEvents b1 As System.Windows.Forms.CheckBox
    Friend WithEvents b As System.Windows.Forms.CheckBox
    Friend WithEvents b5 As System.Windows.Forms.CheckBox
    Friend WithEvents b6 As System.Windows.Forms.CheckBox
    Friend WithEvents c As System.Windows.Forms.CheckBox
    Friend WithEvents d As System.Windows.Forms.CheckBox
    Friend WithEvents f As System.Windows.Forms.CheckBox
    Friend WithEvents d3 As System.Windows.Forms.CheckBox
    Friend WithEvents d2 As System.Windows.Forms.CheckBox
    Friend WithEvents d1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents CapisanoDataSet As Capisano.capisanoDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As Capisano.capisanoDataSetTableAdapters.userTableAdapter
End Class
