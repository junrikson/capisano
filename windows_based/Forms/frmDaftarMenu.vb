Imports MySql.Data.MySqlClient
Public Class frmDaftarMenu
    Dim cmd As MySqlCommand
    Dim modul As String = "DFTMENU"
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Private Function refreshData()
        Try
            functions.localConnect()
            cmd = New MySqlCommand("Select code as Code, name as Name, kategori as Kategori, price as Price, details as Details, images as Images, timestamp as Time, operator as Operator from daftarmenu", functions.localConnection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            gridList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Function updateTotal()
        Dim total As Double = 0
        For row As Integer = 0 To gridListDetails.Rows.Count - 1 Step 1
            total = total + gridListDetails.Item(3, row).Value
        Next
        total = total + gridList.Item(3, i).Value
        txtTotal.Text = total
        Return True
    End Function

    Private Sub frmDaftarMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        refreshData()
        functions.fillComboBox("select code from daftarkategorimenu", comboCategory, functions.localConnection)
        imageMenu.BackgroundImage = Image.FromFile(System.IO.Path.Combine("images", "default.jpg"))
        kriteria = gridList.Columns(0).Name
    End Sub

    Private Sub imageMenu_Click(sender As Object, e As EventArgs) Handles imageMenu.Click
        Process.Start("images\default.jpg")
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

                cmd.CommandText = "insert into daftarmenu (code, name, kategori, price, details, images, operator, modul) VALUES ('" + txtCode.Text + "', '" + txtName.Text + "', '" + comboCategory.Text + "', '" + txtPrice.Text + "', '" + txtDetails.Text + "', '" + txtImages.Text + "', '" + variabels.oper + "', '" + modul + "');"
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

            cmd.CommandText = "delete from daftarmenu where code = '" & txtCode.Text & "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "delete from daftarmenudetails where menucode='" & txtCode.Text & "'"
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
            cmd.CommandText = "update daftarmenu set name = '" + txtName.Text + "', kategori='" + comboCategory.Text + "', price='" + txtPrice.Text + "', details='" + txtDetails.Text + "', images='" + txtImages.Text + "', operator='" + variabels.oper + "' where code = '" + txtCode.Text + "'"
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
        txtCode.Enabled = False
        btnAddDetails.Enabled = False
        btnUpdateDetails.Enabled = False
        btnDeleteDetails.Enabled = False
        i = gridList.CurrentRow.Index
        k = gridList.CurrentCell.ColumnIndex
        kriteria = gridList.Columns(k).Name
        txtCode.Text = gridList.Item(0, i).Value
        txtName.Text = gridList.Item(1, i).Value
        comboCategory.Text = gridList.Item(2, i).Value
        txtPrice.Text = gridList.Item(3, i).Value
        txtDetails.Text = gridList.Item(4, i).Value
        txtImages.Text = gridList.Item(5, i).Value
        refreshDataDetails(gridList.Item(0, i).Value.ToString)
        kriteriaDetails = gridListDetails.Columns(0).Name
        updateTotal()
    End Sub

    Dim kriteria As String = ""
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv = New DataView(dt)
        dv.RowFilter = kriteria + " like '%" + txtSearch.Text + "%'"
        gridList.DataSource = dv
    End Sub

    'Details
    Dim modulDetails As String = "DFTMENUDET"
    Dim daDetails As MySqlDataAdapter
    Dim dtDetails As DataTable
    Private Function refreshDataDetails(menucode As String)
        Try
            functions.localConnect()
            cmd = New MySqlCommand("select itemcode as Code, itemname as Name, itemkategori as Kategori, itemprice as Price, itemqty as Qty, timestamp as Time, operator as Operator, auto as Auto from daftarmenudetails where menucode = '" + menucode + "'", functions.localConnection)
            daDetails = New MySqlDataAdapter(cmd)
            dtDetails = New DataTable()
            daDetails.Fill(dtDetails)
            gridListDetails.DataSource = dtDetails
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Private Sub btnBrowseDetails_Click(sender As Object, e As EventArgs) Handles btnBrowseDetails.Click
        frmQueryDaftarMenuDetails.Show()
    End Sub

    Private Sub btnAddDetails_Click(sender As Object, e As EventArgs) Handles btnAddDetails.Click
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "insert into daftarmenudetails (menucode, itemcode, itemname, itemkategori, itemprice, itemqty, operator, modul) VALUES ('" + txtCode.Text + "', '" + txtCodeDetails.Text + "', '" + txtNameDetails.Text + "', '" + txtCategoryDetails.Text + "', '" + txtPriceDetails.Text + "', '" + txtQtyDetails.Text + "', '" + variabels.oper + "', '" + modulDetails + "');"
            cmd.ExecuteNonQuery()

            btnAddDetails.Enabled = False
            btnDeleteDetails.Enabled = False
            btnUpdateDetails.Enabled = False
            refreshDataDetails(txtCode.Text)
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
        updateTotal()
    End Sub

    Private Sub btnUpdateDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDetails.Click
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update daftarmenudetails set itemqty = '" + txtQtyDetails.Text + "', itemprice='" + txtPriceDetails.Text + "', operator='" + variabels.oper + "' where auto= '" + txtAutoDetails.Text + "'"
            cmd.ExecuteNonQuery()
            refreshDataDetails(txtCode.Text)
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
        updateTotal()
    End Sub

    Private Sub btnDeleteDetails_Click(sender As Object, e As EventArgs) Handles btnDeleteDetails.Click
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from daftarmenudetails where auto='" & txtAutoDetails.Text & "'"
            cmd.ExecuteNonQuery()

            btnDeleteDetails.Enabled = False
            btnUpdateDetails.Enabled = False
            btnAddDetails.Enabled = False
            txtCodeDetails.Text = ""

            refreshDataDetails(txtCode.Text)
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
        updateTotal()
    End Sub

    Dim j As Integer = 0
    Private Sub gridListDetails_Click(sender As Object, e As EventArgs) Handles gridListDetails.Click
        btnAddDetails.Enabled = False
        btnUpdateDetails.Enabled = True
        btnDeleteDetails.Enabled = True
        j = gridListDetails.CurrentRow.Index
        txtCodeDetails.Text = gridListDetails.Item(0, j).Value
        txtNameDetails.Text = gridListDetails.Item(1, j).Value
        txtCategoryDetails.Text = gridListDetails.Item(2, j).Value
        txtPriceDetails.Text = gridListDetails.Item(3, j).Value
        txtQtyDetails.Text = gridListDetails.Item(4, j).Value
        txtAutoDetails.Text = gridListDetails.Item(7, j).Value
    End Sub

    Dim kriteriaDetails As String = ""
    Private Sub txtSearchDetails_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDetails.TextChanged
        Dim dv = New DataView(dtDetails)
        dv.RowFilter = kriteriaDetails + " like '%" + txtSearchDetails.Text + "%'"
        gridListDetails.DataSource = dv
    End Sub

    Private Sub btnRefreshDetails_Click(sender As Object, e As EventArgs) Handles btnRefreshDetails.Click
        refreshDataDetails(gridList.Item(0, i).Value.ToString)
    End Sub
End Class