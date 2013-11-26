Imports MySql.Data.MySqlClient
Public Class frmSMSTemplate
    Dim cmd As MySqlCommand
    Dim modul As String = "SMSTEM"
    Private Function refreshData()
        Try
            functions.localConnect()
            cmd = New MySqlCommand("select code as Code, description as Description, message as Message, timestamp as Time, operator as Operator from smstemplate", functions.localConnection)
            Dim da = New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            da.Fill(dt)
            gridList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub frmSMSTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        refreshData()
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

                cmd.CommandText = "insert into smstemplate (code, description, message, operator, modul) VALUES ('" + txtCode.Text + "', '" + txtDescription.Text + "', '" + txtMessage.Text + "', '" + variabels.oper + "', '" + modul + "');"
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

            cmd.CommandText = "delete from smstemplate where code = '" & txtCode.Text & "'"
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
            cmd.CommandText = "update smstemplate set description = '" + txtDescription.Text + "', message='" + txtMessage.Text + "', operator='" + variabels.oper + "' where code = '" + txtCode.Text + "'"
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
        txtDescription.Text = gridList.Item(1, i).Value
        txtMessage.Text = gridList.Item(2, i).Value
    End Sub
End Class