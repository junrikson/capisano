Imports MySql.Data.MySqlClient
Public Class frmDaftarItem
    Dim cmd As MySqlCommand
    Dim modul As String = "DFTITEM"
    Private Function refreshData()
        Try
            functions.localConnect()
            cmd = New MySqlCommand("Select code as Code, name as Name, kategori as Kategori, price as Price, details as Details, images as Images, timestamp as Time, operator as Operator from daftaritem", functions.localConnection)
            Dim da = New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            da.Fill(dt)
            gridList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub frmDaftarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        refreshData()
        imageItem.BackgroundImage = Image.FromFile(System.IO.Path.Combine("images", "default.jpg"))
        functions.fillComboBox("select code from daftarkategoriitem", comboCategory, functions.localConnection)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (btnAdd.Text = "Add") Then
            txtCode.Text = ""
            txtCode.Enabled = True
            btnAdd.Text = "Save"
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        Else
            Try
                functions.localConnect()
                cmd = New MySqlCommand
                cmd.Connection = functions.localConnection
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "insert into daftaritem (code, name, kategori, price, details, images, operator, modul) VALUES ('" + txtCode.Text + "', '" + txtName.Text + "', '" + comboCategory.Text + "', '" + txtPrice.Text + "', '" + txtDetails.Text + "', '" + txtImages.Text + "', '" + variabels.oper + "', '" + modul + "');"
                cmd.ExecuteNonQuery()

                txtCode.Enabled = True
                txtCode.Text = ""
                btnUpdate.Enabled = False
                btnDelete.Enabled = False

                refreshData()
            Catch ex As MySqlException
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from daftaritem where code = '" & txtCode.Text & "'"
            cmd.ExecuteNonQuery()

            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            txtCode.Text = ""
            txtCode.Enabled = True
            btnAdd.Text = "Save"

            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update daftaritem set name = '" + txtName.Text + "', kategori='" + comboCategory.Text + "', price='" + txtPrice.Text + "', details='" + txtDetails.Text + "', images='" + txtImages.Text + "', operator='" + variabels.oper + "' where code = '" + txtCode.Text + "'"
            cmd.ExecuteNonQuery()
            btnAdd.Text = "Add"
            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Dim i As Integer
    Private Sub gridList_Click(sender As Object, e As EventArgs) Handles gridList.Click
        btnAdd.Text = "Add"
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        txtCode.Enabled = False
        i = gridList.CurrentRow.Index
        txtCode.Text = gridList.Item(0, i).Value
        txtName.Text = gridList.Item(1, i).Value
        comboCategory.Text = gridList.Item(2, i).Value
        txtPrice.Text = gridList.Item(3, i).Value
        txtDetails.Text = gridList.Item(4, i).Value
        txtImages.Text = gridList.Item(5, i).Value
    End Sub

    Private Sub imageItem_Click(sender As Object, e As EventArgs) Handles imageItem.Click
        Process.Start("images\default.jpg")
    End Sub
End Class