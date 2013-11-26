Imports MySql.Data.MySqlClient
Public Class frmDaftarKategoriItem
    Dim cmd As MySqlCommand
    Dim modul As String = "DFTKITEM"
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Private Function refreshData()
        Try
            functions.localConnect()
            cmd = New MySqlCommand("Select code as Code, name as Name, details as Details, timestamp as Time, operator as Operator from daftarkategoriitem", functions.localConnection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
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
        kriteria = gridList.Columns(0).Name
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

                cmd.CommandText = "insert into daftarkategoriitem (code, name, details, operator, modul) VALUES ('" + txtCode.Text + "', '" + txtName.Text + "', '" + txtDetails.Text + "', '" + variabels.oper + "', '" + modul + "');"
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

            cmd.CommandText = "delete from daftarkategoriitem where code = '" & txtCode.Text & "'"
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
            cmd.CommandText = "update daftarkategoriitem set name = '" + txtName.Text + "', details='" + txtDetails.Text + "', operator='" + variabels.oper + "' where code = '" + txtCode.Text + "'"
            cmd.ExecuteNonQuery()
            btnAdd.Text = "Add"
            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Dim i As Integer = 0
    Dim k As Integer = 0
    Private Sub gridList_Click(sender As Object, e As EventArgs) Handles gridList.Click
        btnAdd.Text = "Add"
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        txtCode.Enabled = False
        i = gridList.CurrentRow.Index
        k = gridList.CurrentCell.ColumnIndex
        kriteria = gridList.Columns(k).Name
        txtCode.Text = gridList.Item(0, i).Value
        txtName.Text = gridList.Item(1, i).Value
        txtDetails.Text = gridList.Item(2, i).Value
    End Sub

    Dim kriteria As String = ""
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv = New DataView(dt)
        dv.RowFilter = kriteria + " like '%" + txtSearch.Text + "%'"
        gridList.DataSource = dv
    End Sub
End Class