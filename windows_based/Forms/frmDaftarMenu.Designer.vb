<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaftarMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDaftarMenu))
        Me.comboCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.imageMenu = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.gridList = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.RichTextBox()
        Me.gridListDetails = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImages = New System.Windows.Forms.TextBox()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.txtNameDetails = New System.Windows.Forms.TextBox()
        Me.txtCodeDetails = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrowseDetails = New System.Windows.Forms.Button()
        Me.txtPriceDetails = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearchDetails = New System.Windows.Forms.TextBox()
        Me.btnRefreshDetails = New System.Windows.Forms.Button()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.btnDeleteDetails = New System.Windows.Forms.Button()
        Me.btnAddDetails = New System.Windows.Forms.Button()
        Me.txtQtyDetails = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCategoryDetails = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAutoDetails = New System.Windows.Forms.TextBox()
        CType(Me.imageMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboCategory
        '
        Me.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCategory.FormattingEnabled = True
        Me.comboCategory.Location = New System.Drawing.Point(67, 301)
        Me.comboCategory.Name = "comboCategory"
        Me.comboCategory.Size = New System.Drawing.Size(100, 21)
        Me.comboCategory.TabIndex = 45
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(67, 326)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 44
        Me.txtPrice.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Price :"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(147, 425)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 42
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'imageMenu
        '
        Me.imageMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imageMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imageMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imageMenu.Location = New System.Drawing.Point(374, 241)
        Me.imageMenu.Name = "imageMenu"
        Me.imageMenu.Size = New System.Drawing.Size(197, 197)
        Me.imageMenu.TabIndex = 40
        Me.imageMenu.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(482, 20)
        Me.txtSearch.TabIndex = 39
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(496, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 38
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
        Me.gridList.Size = New System.Drawing.Size(559, 197)
        Me.gridList.TabIndex = 37
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(228, 425)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(66, 425)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(67, 274)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(275, 20)
        Me.txtName.TabIndex = 34
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(67, 248)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Category :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Code :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Details :"
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(67, 353)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(273, 51)
        Me.txtDetails.TabIndex = 48
        Me.txtDetails.Text = ""
        '
        'gridListDetails
        '
        Me.gridListDetails.AllowUserToAddRows = False
        Me.gridListDetails.AllowUserToDeleteRows = False
        Me.gridListDetails.AllowUserToOrderColumns = True
        Me.gridListDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListDetails.Location = New System.Drawing.Point(586, 38)
        Me.gridListDetails.Name = "gridListDetails"
        Me.gridListDetails.ReadOnly = True
        Me.gridListDetails.Size = New System.Drawing.Size(328, 197)
        Me.gridListDetails.TabIndex = 49
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(759, 425)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(155, 26)
        Me.txtTotal.TabIndex = 50
        Me.txtTotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(582, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "TOTAL PRICE :   Rp"
        '
        'txtImages
        '
        Me.txtImages.Location = New System.Drawing.Point(374, 446)
        Me.txtImages.Name = "txtImages"
        Me.txtImages.Size = New System.Drawing.Size(140, 20)
        Me.txtImages.TabIndex = 56
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.Location = New System.Drawing.Point(516, 444)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(55, 23)
        Me.btnBrowseImage.TabIndex = 55
        Me.btnBrowseImage.Text = "Browse"
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'txtNameDetails
        '
        Me.txtNameDetails.Enabled = False
        Me.txtNameDetails.Location = New System.Drawing.Point(639, 274)
        Me.txtNameDetails.Name = "txtNameDetails"
        Me.txtNameDetails.Size = New System.Drawing.Size(275, 20)
        Me.txtNameDetails.TabIndex = 60
        '
        'txtCodeDetails
        '
        Me.txtCodeDetails.Enabled = False
        Me.txtCodeDetails.Location = New System.Drawing.Point(639, 248)
        Me.txtCodeDetails.Name = "txtCodeDetails"
        Me.txtCodeDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeDetails.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(597, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(600, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Code :"
        '
        'btnBrowseDetails
        '
        Me.btnBrowseDetails.Location = New System.Drawing.Point(745, 246)
        Me.btnBrowseDetails.Name = "btnBrowseDetails"
        Me.btnBrowseDetails.Size = New System.Drawing.Size(55, 23)
        Me.btnBrowseDetails.TabIndex = 61
        Me.btnBrowseDetails.Text = "Browse"
        Me.btnBrowseDetails.UseVisualStyleBackColor = True
        '
        'txtPriceDetails
        '
        Me.txtPriceDetails.Location = New System.Drawing.Point(639, 326)
        Me.txtPriceDetails.Name = "txtPriceDetails"
        Me.txtPriceDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceDetails.TabIndex = 63
        Me.txtPriceDetails.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(600, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Price :"
        '
        'txtSearchDetails
        '
        Me.txtSearchDetails.Location = New System.Drawing.Point(586, 12)
        Me.txtSearchDetails.Name = "txtSearchDetails"
        Me.txtSearchDetails.Size = New System.Drawing.Size(251, 20)
        Me.txtSearchDetails.TabIndex = 65
        '
        'btnRefreshDetails
        '
        Me.btnRefreshDetails.Location = New System.Drawing.Point(839, 9)
        Me.btnRefreshDetails.Name = "btnRefreshDetails"
        Me.btnRefreshDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshDetails.TabIndex = 64
        Me.btnRefreshDetails.Text = "Refresh"
        Me.btnRefreshDetails.UseVisualStyleBackColor = True
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.Enabled = False
        Me.btnUpdateDetails.Location = New System.Drawing.Point(725, 381)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateDetails.TabIndex = 68
        Me.btnUpdateDetails.Text = "Update"
        Me.btnUpdateDetails.UseVisualStyleBackColor = True
        '
        'btnDeleteDetails
        '
        Me.btnDeleteDetails.Enabled = False
        Me.btnDeleteDetails.Location = New System.Drawing.Point(806, 381)
        Me.btnDeleteDetails.Name = "btnDeleteDetails"
        Me.btnDeleteDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteDetails.TabIndex = 67
        Me.btnDeleteDetails.Text = "Delete"
        Me.btnDeleteDetails.UseVisualStyleBackColor = True
        '
        'btnAddDetails
        '
        Me.btnAddDetails.Enabled = False
        Me.btnAddDetails.Location = New System.Drawing.Point(644, 381)
        Me.btnAddDetails.Name = "btnAddDetails"
        Me.btnAddDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDetails.TabIndex = 66
        Me.btnAddDetails.Text = "Save"
        Me.btnAddDetails.UseVisualStyleBackColor = True
        '
        'txtQtyDetails
        '
        Me.txtQtyDetails.Location = New System.Drawing.Point(639, 351)
        Me.txtQtyDetails.Name = "txtQtyDetails"
        Me.txtQtyDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtQtyDetails.TabIndex = 70
        Me.txtQtyDetails.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(585, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Quantity :"
        '
        'txtCategoryDetails
        '
        Me.txtCategoryDetails.Enabled = False
        Me.txtCategoryDetails.Location = New System.Drawing.Point(639, 300)
        Me.txtCategoryDetails.Name = "txtCategoryDetails"
        Me.txtCategoryDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoryDetails.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(583, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Category :"
        '
        'txtAutoDetails
        '
        Me.txtAutoDetails.Enabled = False
        Me.txtAutoDetails.Location = New System.Drawing.Point(814, 351)
        Me.txtAutoDetails.Name = "txtAutoDetails"
        Me.txtAutoDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtAutoDetails.TabIndex = 73
        Me.txtAutoDetails.Visible = False
        '
        'frmDaftarMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 474)
        Me.Controls.Add(Me.txtAutoDetails)
        Me.Controls.Add(Me.txtCategoryDetails)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtQtyDetails)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnUpdateDetails)
        Me.Controls.Add(Me.btnDeleteDetails)
        Me.Controls.Add(Me.btnAddDetails)
        Me.Controls.Add(Me.txtSearchDetails)
        Me.Controls.Add(Me.btnRefreshDetails)
        Me.Controls.Add(Me.txtPriceDetails)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBrowseDetails)
        Me.Controls.Add(Me.txtNameDetails)
        Me.Controls.Add(Me.txtCodeDetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtImages)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.gridListDetails)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.comboCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.imageMenu)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDaftarMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Menu"
        CType(Me.imageMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents imageMenu As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents gridList As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents gridListDetails As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtImages As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseImage As System.Windows.Forms.Button
    Friend WithEvents txtNameDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseDetails As System.Windows.Forms.Button
    Friend WithEvents txtPriceDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSearchDetails As System.Windows.Forms.TextBox
    Friend WithEvents btnRefreshDetails As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDetails As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDetails As System.Windows.Forms.Button
    Friend WithEvents btnAddDetails As System.Windows.Forms.Button
    Friend WithEvents txtQtyDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCategoryDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAutoDetails As System.Windows.Forms.TextBox
End Class
