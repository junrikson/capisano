<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClosingBulanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClosingBulanan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClosing = New System.Windows.Forms.Button()
        Me.btnUnclosing = New System.Windows.Forms.Button()
        Me.dateClosing = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode :"
        '
        'btnClosing
        '
        Me.btnClosing.Location = New System.Drawing.Point(64, 40)
        Me.btnClosing.Name = "btnClosing"
        Me.btnClosing.Size = New System.Drawing.Size(75, 23)
        Me.btnClosing.TabIndex = 4
        Me.btnClosing.Text = "Closing"
        Me.btnClosing.UseVisualStyleBackColor = True
        '
        'btnUnclosing
        '
        Me.btnUnclosing.Location = New System.Drawing.Point(145, 40)
        Me.btnUnclosing.Name = "btnUnclosing"
        Me.btnUnclosing.Size = New System.Drawing.Size(75, 23)
        Me.btnUnclosing.TabIndex = 5
        Me.btnUnclosing.Text = "Unclosing"
        Me.btnUnclosing.UseVisualStyleBackColor = True
        '
        'dateClosing
        '
        Me.dateClosing.CustomFormat = "MMMM yyyy"
        Me.dateClosing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateClosing.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateClosing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dateClosing.Location = New System.Drawing.Point(65, 12)
        Me.dateClosing.Name = "dateClosing"
        Me.dateClosing.ShowUpDown = True
        Me.dateClosing.Size = New System.Drawing.Size(200, 20)
        Me.dateClosing.TabIndex = 6
        Me.dateClosing.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'frmClosingBulanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 75)
        Me.Controls.Add(Me.dateClosing)
        Me.Controls.Add(Me.btnUnclosing)
        Me.Controls.Add(Me.btnClosing)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClosingBulanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Closing Bulanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClosing As System.Windows.Forms.Button
    Friend WithEvents btnUnclosing As System.Windows.Forms.Button
    Friend WithEvents dateClosing As System.Windows.Forms.DateTimePicker
End Class
