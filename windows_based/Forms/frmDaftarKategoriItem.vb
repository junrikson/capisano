Imports MySql.Data.MySqlClient
Public Class frmDaftarKategoriItem
    Dim cmd As MySqlCommand
    Private Function refreshData()
        Try
            functions.connect()
            cmd = New MySqlCommand("Select code as Code, name as Name, details as Details, timestamp as Time from daftarkategoriitem", frmMain.localConnection)
            Dim da = New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            da.Fill(dt)
            gridList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub frmDaftarKategoriItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        refreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (btnAdd.Text = "Copy") Then
            txtCode.Text = ""
            txtCode.Enabled = True
            btnAdd.Text = "Add"
            btnUpdate.Enabled = False
        Else
            Try
                functions.connect()
                cmd = New MySqlCommand
                cmd.Connection = frmMain.localConnection
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "insert into daftarkategoriitem (code, name, details) VALUES ('" + txtCode.Text + "', '" + txtName.Text + "', '" + txtDetails.Text + "');"
                cmd.ExecuteNonQuery()

                txtCode.Enabled = True
                refreshData()
            Catch ex As MySqlException
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            functions.connect()
            cmd = New MySqlCommand
            cmd.Connection = frmMain.localConnection
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from daftarkategoriitem where code = '" & txtCode.Text & "'"
            cmd.ExecuteNonQuery()
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            txtCode.Enabled = True
            btnAdd.Text = "Add"
            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            functions.connect()
            cmd = New MySqlCommand
            cmd.Connection = frmMain.localConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update daftarkategoriitem set name = '" + txtName.Text + "', details='" + txtDetails.Text + "' where code = '" + txtCode.Text + "'"
            cmd.ExecuteNonQuery()
            frmMain.localConnection.Close()
            btnAdd.Text = "Copy"
            btnUpdate.Enabled = False
            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Dim i As Integer
    Private Sub gridList_Click(sender As Object, e As EventArgs) Handles gridList.Click
        btnAdd.Text = "Copy"
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        txtCode.Enabled = False
        i = gridList.CurrentRow.Index
        txtCode.Text = gridList.Item(0, i).Value
        txtName.Text = gridList.Item(1, i).Value
        txtDetails.Text = gridList.Item(2, i).Value
    End Sub
End Class