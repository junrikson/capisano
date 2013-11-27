Imports MySql.Data.MySqlClient
Public Class frmUsersManagement
    Dim cmd As MySqlCommand
    Dim priv_a1, priv_a2, priv_a3, priv_a4, priv_b1, priv_b2, priv_b3, priv_b4, priv_b5, priv_b6, priv_c1, priv_d1, priv_d2, priv_d3, priv_e1 As Integer
    Dim modul As String = "USERMNG"
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Private Function refreshData()
        Try
            functions.localConnect()
            cmd = New MySqlCommand("Select username as Username, password as Password, priv_a1 as 'Kat. Item', priv_a2 as 'Dftr. Item', priv_a3 as 'Kat. Menu', priv_a4 as 'Kat. Menu', priv_b1 as 'Orders', priv_b2 as 'Payments', priv_b3 as 'User Manage', priv_b4 as 'Log', priv_b5 as Closing, priv_b6 as Periode, priv_c1 as Reports, priv_d1 as 'Server Set', priv_d2 as 'SMS Set', priv_d3 as 'SMS Temp.', priv_d1 as Help, timestamp as Time, operator as Operator, modul as Modul from user", functions.localConnection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
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
        kriteria = gridList.Columns(0).Name
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        setVariabel()
        If (btnAdd.Text = "Add") Then
            txtUsername.Text = ""
            txtUsername.Enabled = True
            btnAdd.Text = "Save"
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        Else
            Try
                functions.localConnect()
                cmd = New MySqlCommand
                cmd.Connection = functions.localConnection
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "insert into user (username, password, priv_a1, priv_a2, priv_a3, priv_a4, priv_b1, priv_b2, priv_b3, priv_b4, priv_b5, priv_b6, priv_c1, priv_d1, priv_d2, priv_d3, priv_e1, operator, modul) VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & priv_a1 & "', '" & priv_a2 & "', '" & priv_a3 & "', '" & priv_a4 & "', '" & priv_b1 & "', '" & priv_b2 & "', '" & priv_b3 & "', '" & priv_b4 & "', '" & priv_b5 & "', '" & priv_b6 & "', '" & priv_c1 & "', '" & priv_d1 & "', '" & priv_d2 & "', '" & priv_d3 & "', '" & priv_e1 & "', '" & variabels.oper & "', '" & modul & "');"
                cmd.ExecuteNonQuery()

                txtUsername.Enabled = True
                txtUsername.Text = ""
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

            cmd.CommandText = "delete from user where username = '" & txtUsername.Text & "'"
            cmd.ExecuteNonQuery()
            
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            txtUsername.Text = ""
            txtUsername.Enabled = True
            btnAdd.Text = "Save"

            refreshData()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        setVariabel()
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update user set password = '" & txtPassword.Text & "', priv_a1='" & priv_a1 & "', priv_a2='" & priv_a2 & "', priv_a3='" & priv_a3 & "', priv_a4='" & priv_a4 & "', priv_b1='" & priv_b1 & "', priv_b2='" & priv_b2 & "', priv_b3='" & priv_b3 & "', priv_b4='" & priv_b4 & "', priv_b5='" & priv_b5 & "', priv_b6='" & priv_b6 & "', priv_c1='" & priv_c1 & "', priv_d1='" & priv_d1 & "', priv_d2='" & priv_d2 & "', priv_d3='" & priv_d3 & "', priv_e1='" & priv_e1 & "', operator='" & variabels.oper & "', modul='" & modul & "' where username = '" & txtUsername.Text & "'"
            cmd.ExecuteNonQuery()
            btnAdd.Text = "Add"
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
    Dim k As Integer = 0
    Private Sub gridUsersManagement_Click(sender As Object, e As EventArgs) Handles gridList.Click
        btnAdd.Text = "Add"
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        txtUsername.Enabled = False
        i = gridList.CurrentRow.Index
        k = gridList.CurrentCell.ColumnIndex
        kriteria = gridList.Columns(k).Name
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

    Dim kriteria As String = ""
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv = New DataView(dt)
        dv.RowFilter = kriteria + " like '%" + txtSearch.Text + "%'"
        gridList.DataSource = dv
    End Sub

    Private Function setVariabel()
        If (a1.Checked = True) Then
            priv_a1 = 1
        Else
            priv_a1 = 0
        End If

        If (a2.Checked = True) Then
            priv_a2 = 1
        Else
            priv_a2 = 0
        End If

        If (a3.Checked = True) Then
            priv_a3 = 1
        Else
            priv_a3 = 0
        End If

        If (a4.Checked = True) Then
            priv_a4 = 1
        Else
            priv_a4 = 0
        End If

        If (b1.Checked = True) Then
            priv_b1 = 1
        Else
            priv_b1 = 0
        End If

        If (b2.Checked = True) Then
            priv_b2 = 1
        Else
            priv_b2 = 0
        End If

        If (b3.Checked = True) Then
            priv_b3 = 1
        Else
            priv_b3 = 0
        End If

        If (b4.Checked = True) Then
            priv_b4 = 1
        Else
            priv_b4 = 0
        End If

        If (b5.Checked = True) Then
            priv_b5 = 1
        Else
            priv_b5 = 0
        End If

        If (b6.Checked = True) Then
            priv_b6 = 1
        Else
            priv_b6 = 0
        End If

        If (c.Checked = True) Then
            priv_c1 = 1
        Else
            priv_c1 = 0
        End If

        If (d1.Checked = True) Then
            priv_d1 = 1
        Else
            priv_d1 = 0
        End If

        If (d2.Checked = True) Then
            priv_d2 = 1
        Else
            priv_d2 = 0
        End If

        If (d3.Checked = True) Then
            priv_d3 = 1
        Else
            priv_d3 = 0
        End If

        If (f.Checked = True) Then
            priv_e1 = 1
        Else
            priv_e1 = 0
        End If

        Return True
    End Function
End Class