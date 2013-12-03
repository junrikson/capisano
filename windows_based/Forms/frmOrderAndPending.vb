Imports MySql.Data.MySqlClient
Public Class frmOrderAndPending
    Dim cmd As MySqlCommand
    Dim modul As String = "DFTCUST"
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim orderid As String = ""
    Private Function refreshDataPending()
        Try
            functions.webConnect()
            cmd = New MySqlCommand("select auto as 'Order ID', username as 'Username', name as 'Item', price as 'Price', qty as 'Qty', total as Total from daftarorder where status = 'N'", functions.webConnection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            gridListPending.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub btnRefreshPending_Click(sender As Object, e As EventArgs) Handles btnRefreshPending.Click
        refreshDataPending()
    End Sub

    Dim i As Integer
    Private Sub gridListPending_Click(sender As Object, e As EventArgs) Handles gridListPending.Click
        i = gridListPending.CurrentRow.Index
        orderid = gridListPending.Item(0, i).Value
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Try
            functions.webConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.webConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update daftarorder set status = 'Y' where auto ='" + orderid + "'"
            cmd.ExecuteNonQuery()
            refreshDataPending()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class