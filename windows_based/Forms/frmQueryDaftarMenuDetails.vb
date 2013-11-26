Imports MySql.Data.MySqlClient
Public Class frmQueryDaftarMenuDetails
    Dim cmd As MySqlCommand
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

    Private Sub frmQueryDaftarMenuDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshData()
    End Sub

    Dim i As Integer
    Private Sub gridList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridList.CellDoubleClick
        frmDaftarMenu.btnAddDetails.Enabled = True
        frmDaftarMenu.btnDeleteDetails.Enabled = False
        frmDaftarMenu.btnUpdateDetails.Enabled = False
        i = gridList.CurrentRow.Index
        frmDaftarMenu.txtCodeDetails.Text = gridList.Item(0, i).Value
        frmDaftarMenu.txtNameDetails.Text = gridList.Item(1, i).Value
        frmDaftarMenu.txtCategoryDetails.Text = gridList.Item(2, i).Value
        frmDaftarMenu.txtPriceDetails.Text = gridList.Item(3, i).Value
        Me.Close()
    End Sub
End Class