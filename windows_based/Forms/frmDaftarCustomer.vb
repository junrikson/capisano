Imports MySql.Data.MySqlClient
Public Class frmDaftarCustomer
    Dim cmd As MySqlCommand
    Dim modul As String = "DFTCUST"
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Private Function refreshData()
        Try
            functions.localConnect()
            cmd = New MySqlCommand("Select phone as Phone, email as Email, password as Password, name as Name, address as Alamat, city as Kota, state as Provinsi, country as Negara, postal as 'K. Pos', timestamp as Time, operator as Operator, auto as Auto from daftarcustomer", functions.localConnection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            gridList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub frmDaftarKategoriMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            txtPhone.Text = ""
            txtPhone.Enabled = True
            btnAdd.Text = "Save"
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        Else
            Try
                functions.localConnect()
                cmd = New MySqlCommand
                cmd.Connection = functions.localConnection
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "insert into daftarcustomer (phone, email, password, name, address, city, state, country, postal, operator, modul) VALUES ('" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "', '" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtState.Text + "', '" + txtCountry.Text + "', '" + txtPostal.Text + "', '" + variabels.oper + "', '" + modul + "');"
                cmd.ExecuteNonQuery()

                txtPhone.Enabled = True
                txtPhone.Text = ""
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

            cmd.CommandText = "delete from daftarcustomer where auto='" & txtAuto.Text & "'"
            cmd.ExecuteNonQuery()

            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            txtPhone.Text = ""
            txtPhone.Enabled = True
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
            cmd.CommandText = "update daftarcustomer set phone = '" + txtPhone.Text + "', email='" + txtEmail.Text + "', password='" + txtPassword.Text + "', name='" + txtName.Text + "', address='" + txtAddress.Text + "', city='" + txtCity.Text + "', state='" + txtState.Text + "', country='" + txtCountry.Text + "', postal='" + txtPostal.Text + "', operator='" + variabels.oper + "' where auto='" & txtAuto.Text & "'"
            cmd.ExecuteNonQuery()
            btnAdd.Text = "Add"
            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Dim i As Integer
    Dim k As Integer = 0
    Private Sub gridList_Click(sender As Object, e As EventArgs) Handles gridList.Click
        btnAdd.Text = "Add"
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        i = gridList.CurrentRow.Index
        k = gridList.CurrentCell.ColumnIndex
        kriteria = gridList.Columns(k).Name
        txtPhone.Text = gridList.Item(0, i).Value
        txtEmail.Text = gridList.Item(1, i).Value
        txtPassword.Text = gridList.Item(2, i).Value
        txtName.Text = gridList.Item(3, i).Value
        txtCity.Text = gridList.Item(5, i).Value
        txtState.Text = gridList.Item(6, i).Value
        txtCountry.Text = gridList.Item(7, i).Value
        txtPostal.Text = gridList.Item(8, i).Value
        txtAuto.Text = gridList.Item(11, i).Value
    End Sub

    Dim kriteria As String = ""
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv = New DataView(dt)
        dv.RowFilter = kriteria + " like '%" + txtSearch.Text + "%'"
        gridList.DataSource = dv
    End Sub
End Class