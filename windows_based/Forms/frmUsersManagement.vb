Imports MySql.Data.MySqlClient
Public Class frmUsersManagement
    Dim cmd As MySqlCommand
    Private Function refreshData()
        Try
            functions.connect()
            cmd = New MySqlCommand("Select username as Username, password as Password, priv_a1 as 'Kat. Item', priv_a2 as 'Dftr. Item', priv_a3 as 'Kat. Menu', priv_a4 as 'Kat. Menu', priv_b1 as 'Orders', priv_b2 as 'Payments', priv_b3 as 'User Manage', priv_b4 as 'Log', priv_b5 as Closing, priv_b6 as Periode, priv_c1 as Reports, priv_d1 as 'Server Set', priv_d2 as 'SMS Set', priv_d3 as 'SMS Temp.', priv_d1 as Help from user", frmMain.localConnection)
            Dim da = New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            da.Fill(dt)
            gridList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub frmUsersManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        refreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (btnAdd.Text = "Copy") Then
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Enabled = True
            btnAdd.Text = "Add"
            btnUpdate.Enabled = False
        Else
            Try
                functions.connect()
                cmd = New MySqlCommand
                cmd.Connection = frmMain.localConnection
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "insert into user (username, password, priv_a1, priv_a2, priv_a3, priv_a4, priv_b1, priv_b2, priv_b3, priv_b4, priv_b5, priv_b6, priv_c1, priv_d1, priv_d2, priv_d3, priv_e1) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + a1.Text + "', '" + a2.Text + "', '" + a3.Text + "', '" + a4.Text + "', '" + b1.Text + "', '" + b2.Text + "', '" + b3.Text + "', '" + b4.Text + "', '" + b5.Text + "', '" + b6.Text + "', '" + c.Text + "', '" + d1.Text + "', '" + d2.Text + "', '" + d3.Text + "', '" + f.Text + "');"
                cmd.ExecuteNonQuery()

                txtUsername.Enabled = True
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

            cmd.CommandText = "delete from user where username = '" & txtUsername.Text & "'"
            cmd.ExecuteNonQuery()
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            txtUsername.Enabled = True
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
            cmd.CommandText = "update user set password = '" + txtPassword.Text + "', priv_a1='" + a1.Text + "', priv_a2='" + a2.Text + "', priv_a3='" + a3.Text + "', priv_a4='" + a4.Text + "', priv_b1='" + b1.Text + "', priv_b2='" + b2.Text + "', priv_b3='" + b3.Text + "', priv_b4='" + b4.Text + "', priv_b5='" + b5.Text + "', priv_b6='" + b6.Text + "', priv_c1='" + c.Text + "', priv_d1='" + d1.Text + "', priv_d2='" + d2.Text + "', priv_d3='" + d3.Text + "', priv_e1='" + f.Text + "' where username = '" + txtUsername.Text + "'"
            cmd.ExecuteNonQuery()
            frmMain.localConnection.Close()
            btnAdd.Text = "Copy"
            btnUpdate.Enabled = False
            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub a_CheckedChanged(sender As Object, e As EventArgs) Handles a.CheckedChanged
        If (a.Checked = True) Then
            a1.Checked = True
            a2.Checked = True
            a3.Checked = True
            a4.Checked = True
        Else
            a1.Checked = False
            a2.Checked = False
            a3.Checked = False
            a4.Checked = False
        End If
    End Sub

    Private Sub b_CheckedChanged(sender As Object, e As EventArgs) Handles b.CheckedChanged
        If (b.Checked = True) Then
            b1.Checked = True
            b2.Checked = True
            b3.Checked = True
            b4.Checked = True
            b5.Checked = True
            b6.Checked = True
        Else
            b1.Checked = False
            b2.Checked = False
            b3.Checked = False
            b4.Checked = False
            b5.Checked = False
            b6.Checked = False
        End If
    End Sub

    Private Sub d_CheckedChanged(sender As Object, e As EventArgs) Handles d.CheckedChanged
        If (d.Checked = True) Then
            d1.Checked = True
            d2.Checked = True
            d3.Checked = True
        Else
            d1.Checked = False
            d2.Checked = False
            d3.Checked = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnAdd.Enabled = True
        txtUsername.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnAdd.Text = "Add"
        txtPassword.Text = ""
        txtUsername.Text = ""
        a.Checked = False
        a1.Checked = False
        a2.Checked = False
        a3.Checked = False
        a4.Checked = False
        b.Checked = False
        b1.Checked = False
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False
        b5.Checked = False
        b6.Checked = False
        c.Checked = False
        d1.Checked = False
        d2.Checked = False
        d3.Checked = False
        d.Checked = False
    End Sub

    Dim i As Integer
    Private Sub gridUsersManagement_Click(sender As Object, e As EventArgs) Handles gridList.Click
        btnAdd.Text = "Copy"
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        txtUsername.Enabled = False
        i = gridList.CurrentRow.Index
        txtUsername.Text = gridList.Item(0, i).Value
        txtPassword.Text = gridList.Item(1, i).Value
        a.Checked = False
        a1.Checked = gridList.Item(2, i).Value
        a2.Checked = gridList.Item(3, i).Value
        a3.Checked = gridList.Item(4, i).Value
        a4.Checked = gridList.Item(5, i).Value
        b.Checked = False
        b1.Checked = gridList.Item(6, i).Value
        b2.Checked = gridList.Item(7, i).Value
        b3.Checked = gridList.Item(8, i).Value
        b4.Checked = gridList.Item(9, i).Value
        b5.Checked = gridList.Item(10, i).Value
        b6.Checked = gridList.Item(11, i).Value
        c.Checked = gridList.Item(12, i).Value
        d.Checked = False
        d1.Checked = gridList.Item(13, i).Value
        d2.Checked = gridList.Item(14, i).Value
        d3.Checked = gridList.Item(15, i).Value
        f.Checked = gridList.Item(16, i).Value
    End Sub
End Class