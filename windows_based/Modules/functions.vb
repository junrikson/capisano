Imports MySql.Data.MySqlClient
Class functions
    'Fungsi Konek Database
    Public Shared Function localConnect()
        Try
            If (localConnection.State = ConnectionState.Closed) Then
                localConnection.Open()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Fungsi Dapatkan Periode aktif
    Public Shared Function getPeriode()
        Dim cmd As MySqlDataReader
        Dim periode As Date
        Try
            functions.localConnect()
            cmd = New MySqlCommand("select periode from setup where code ='" + variabels.codename + "'", functions.localConnection).ExecuteReader()
            cmd.Read()
            periode = cmd.GetString(0)
            cmd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return periode
    End Function

    'Fungsi update Periode aktif
    Public Shared Function updatePeriode(newPeriode As Date)
        Dim cmd As MySqlCommand
        Try
            functions.localConnect()
            cmd = New MySqlCommand
            cmd.Connection = functions.localConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update setup set periode = @periode where code ='" + variabels.codename + "'"
            cmd.Parameters.AddWithValue("@periode", newPeriode)
            cmd.ExecuteNonQuery()
            variabels.periode = newPeriode
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function



    'Fungsi Fill ComboBox
    Public Shared Function fillComboBox(query As String, cb As ComboBox, cn As MySqlConnection)
        Try
            Dim command As New MySqlCommand(query, cn)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim dR As MySqlDataReader = command.ExecuteReader()
            While dR.Read()
                If dR(0) IsNot Nothing Then
                    cb.Items.Add(dR(0).ToString())
                End If
            End While
            dR.Close()
        Catch ex As MySqlException
            Return False
        End Try
        Return True
    End Function

    'Objek koneksi Lokal
    Public Shared localConnection As New MySqlConnection("server=" + variabels.localServerAdress + "; user id=" + variabels.localServerUsername + "; password=" + variabels.localServerPassword + "; database=" + variabels.localDatabaseName)

    'Objek koneksi Lokal
    Public Shared webConnection As New MySqlConnection("server=" + variabels.webServerAdress + "; user id=" + variabels.webServerUsername + "; password=" + variabels.webServerPassword + "; database=" + variabels.webDatabaseName)

    'Fungsi Konek Database
    Public Shared Function cekOtoritas(menu As String)
        Dim cmd As MySqlDataReader
        Dim otoritas As Boolean = False
        Try
            functions.localConnect()
            cmd = New MySqlCommand("select " + menu + " from user where username ='" + variabels.oper + "'", functions.localConnection).ExecuteReader()
            cmd.Read()
            otoritas = cmd.GetBoolean(0)
            cmd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return otoritas
    End Function

    'Copy Data
    Public Shared Function copyData(cmdSelect As MySqlCommand, cmdInsert As MySqlCommand, cmdUpdate As MySqlCommand, tableSelect As String, tableInsert As String, tableUpdate As String)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.AcceptChangesDuringFill = False
        da.SelectCommand = cmdSelect
        da.UpdateCommand = cmdUpdate
        da.InsertCommand = cmdInsert
        Try
            da.Fill(ds, tableSelect)
            da.Update(ds, tableInsert)
            cmdUpdate.ExecuteNonQuery()
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Shared Function updateData(cmdSelect As MySqlCommand, cmdUpdate As MySqlCommand, tableSelect As String, tableUpdate As String)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.AcceptChangesDuringFill = False
        da.SelectCommand = cmdSelect
        da.UpdateCommand = cmdUpdate
        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)
        Try
            da.Fill(ds, tableSelect)
            da.Update(ds, tableUpdate)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    'Fungsi Cek Data Output Pending
    Public Shared Function buttonCek(query As String, btnCek As Button, lblCek As Label)
        Dim cmd As MySqlDataReader
        Try
            functions.localConnect()
            cmd = New MySqlCommand(query, functions.localConnection).ExecuteReader()
            Try
                cmd.Read()
                If (cmd.GetValue(0) > 0) Then
                    lblCek.ForeColor = Color.Red
                    btnCek.Text = "U"
                    lblCek.Text = cmd.GetValue(0)
                End If
                cmd.Close()
            Catch ex As Exception
                cmd.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Public Shared Function updateDaftarKategoriItem()
        Try
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Kategori Item Updating..."
            Dim cmdSelect As MySqlCommand = New MySqlCommand("select code, name, details, auto, operator, modul, status from daftarkategoriitem where status='N'", functions.localConnection)
            Dim cmdInsert As MySqlCommand = New MySqlCommand("insert into daftarkategoriitem (code, name, details, auto, operator, modul, status) values(@code, @name, @details, @auto, @operator, @modul, @status)", functions.webConnection)
            cmdInsert.Parameters.Add(New MySqlParameter("@code", MySqlDbType.VarChar, 25, "code"))
            cmdInsert.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50, "name"))
            cmdInsert.Parameters.Add(New MySqlParameter("@details", MySqlDbType.VarChar, 100, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@auto", MySqlDbType.Int32, 11, "auto"))
            cmdInsert.Parameters.Add(New MySqlParameter("@operator", MySqlDbType.VarChar, 50, "operator"))
            cmdInsert.Parameters.Add(New MySqlParameter("@modul", MySqlDbType.VarChar, 10, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            Dim cmdUpdate As MySqlCommand = New MySqlCommand("update daftarkategoriitem set status = 'Y'", functions.localConnection)
            functions.copyData(cmdSelect, cmdInsert, cmdUpdate, "daftarkategoriitem", "daftarkategoriitem", "daftarkategoriitem")

            'cmdSelect = New MySqlCommand("select code, name, details, status from daftarkategoriitem where status='U'", functions.localConnection)
            'cmdUpdate = New MySqlCommand("update daftarkategoriitem set code = @code, name = @name, details = @details, status = @status where code = @oldCode", functions.webConnection)
            'cmdUpdate.Parameters.Add(New MySqlParameter("@code", MySqlDbType.VarChar, 25, "code"))
            'cmdUpdate.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50, "name"))
            'cmdUpdate.Parameters.Add(New MySqlParameter("@details", MySqlDbType.VarChar, 100, "details"))
            'cmdUpdate.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            'Dim parameter As MySqlParameter = cmdUpdate.Parameters.Add("@oldCode", MySqlDbType.VarChar, 25, "code")
            'parameter.SourceVersion = DataRowVersion.Original
            'functions.updateData(cmdSelect, cmdUpdate, "daftarkategoriitem", "daftarkategoriitem")

            frmMain.lblPendingDKI.ForeColor = Color.Black
            frmMain.lblPendingDKI.Text = "0"
            frmMain.btnDKI.Text = "C"
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Kategori Item Update Success."
        Catch ex As Exception
            frmMain.panelStatus.BackColor = Color.DarkRed
            frmMain.panelStatus.Text = "Daftar Kategori Item Update Failed."
        End Try
        Return True
    End Function

    Public Shared Function updateDaftarItem()
        Try
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Item Updating..."
            Dim cmdSelect As MySqlCommand = New MySqlCommand("select code, name, kategori, price, details, images, auto, operator, modul, status from daftaritem where status='N'", functions.localConnection)
            Dim cmdInsert As MySqlCommand = New MySqlCommand("insert into daftaritem (code, name, kategori, price, details, images, auto, operator, modul, status) values(@code, @name, @kategori, @price, @details, @images, @auto, @operator, @modul, @status)", functions.webConnection)
            cmdInsert.Parameters.Add(New MySqlParameter("@code", MySqlDbType.VarChar, 25, "code"))
            cmdInsert.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50, "name"))
            cmdInsert.Parameters.Add(New MySqlParameter("@kategori", MySqlDbType.VarChar, 25, "kategori"))
            cmdInsert.Parameters.Add(New MySqlParameter("@price", MySqlDbType.Double, 11, "price"))
            cmdInsert.Parameters.Add(New MySqlParameter("@details", MySqlDbType.VarChar, 100, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@images", MySqlDbType.VarChar, 100, "images"))
            cmdInsert.Parameters.Add(New MySqlParameter("@auto", MySqlDbType.Int32, 11, "auto"))
            cmdInsert.Parameters.Add(New MySqlParameter("@operator", MySqlDbType.VarChar, 50, "operator"))
            cmdInsert.Parameters.Add(New MySqlParameter("@modul", MySqlDbType.VarChar, 10, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            Dim cmdUpdate As MySqlCommand = New MySqlCommand("update daftaritem set status = 'Y'", functions.localConnection)
            functions.copyData(cmdSelect, cmdInsert, cmdUpdate, "daftaritem", "daftaritem", "daftaritem")

            frmMain.lblPendingDI.ForeColor = Color.Black
            frmMain.lblPendingDI.Text = "0"
            frmMain.btnDI.Text = "C"
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Item Update Success."
        Catch ex As Exception
            frmMain.panelStatus.BackColor = Color.DarkRed
            frmMain.panelStatus.Text = "Daftar Item Update Failed."
        End Try
        Return True
    End Function

    Public Shared Function updateDaftarKategoriMenu()
        Try
            frmMain.panelStatus.ForeColor = Color.WhiteSmoke
            frmMain.panelStatus.Text = "Daftar Kategori Menu Updating..."
            Dim cmdSelect As MySqlCommand = New MySqlCommand("select code, name, details, auto, operator, modul, status from daftarkategorimenu where status='N'", functions.localConnection)
            Dim cmdInsert As MySqlCommand = New MySqlCommand("insert into daftarkategorimenu (code, name, details, auto, operator, modul, status) values(@code, @name, @details, @auto, @operator, @modul, @status)", functions.webConnection)
            cmdInsert.Parameters.Add(New MySqlParameter("@code", MySqlDbType.VarChar, 25, "code"))
            cmdInsert.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50, "name"))
            cmdInsert.Parameters.Add(New MySqlParameter("@details", MySqlDbType.VarChar, 100, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@auto", MySqlDbType.Int32, 11, "auto"))
            cmdInsert.Parameters.Add(New MySqlParameter("@operator", MySqlDbType.VarChar, 50, "operator"))
            cmdInsert.Parameters.Add(New MySqlParameter("@modul", MySqlDbType.VarChar, 10, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            Dim cmdUpdate As MySqlCommand = New MySqlCommand("update daftarkategorimenu set status = 'Y'", functions.localConnection)
            If (functions.copyData(cmdSelect, cmdInsert, cmdUpdate, "daftarkategorimenu", "daftarkategorimenu", "daftarkategorimenu") = True) Then
                frmMain.lblPendingDKM.ForeColor = Color.Black
                frmMain.lblPendingDKM.Text = "0"
                frmMain.btnDKM.Text = "C"
                frmMain.panelStatus.ForeColor = Color.WhiteSmoke
                frmMain.panelStatus.Text = "Daftar Kategori Menu Update Success."
            Else
                frmMain.panelStatus.ForeColor = Color.Red
                frmMain.panelStatus.Text = "Daftar Kategori Menu Update Failed."
            End If
        Catch ex As Exception
            frmMain.panelStatus.ForeColor = Color.Red
            frmMain.panelStatus.Text = "Daftar Kategori Menu Update Failed."
        End Try
        Return True
    End Function

    Public Shared Function updateDaftarMenu()
        Try
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Menu Updating..."
            Dim cmdSelect As MySqlCommand = New MySqlCommand("select code, name, kategori, price, details, images, auto, operator, modul, status from daftarmenu where status='N'", functions.localConnection)
            Dim cmdInsert As MySqlCommand = New MySqlCommand("insert into daftarmenu (code, name, kategori, price, details, images, auto, operator, modul, status) values(@code, @name, @kategori, @price, @details, @images, @auto, @operator, @modul, @status)", functions.webConnection)
            cmdInsert.Parameters.Add(New MySqlParameter("@code", MySqlDbType.VarChar, 25, "code"))
            cmdInsert.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50, "name"))
            cmdInsert.Parameters.Add(New MySqlParameter("@kategori", MySqlDbType.VarChar, 25, "kategori"))
            cmdInsert.Parameters.Add(New MySqlParameter("@price", MySqlDbType.Double, 11, "price"))
            cmdInsert.Parameters.Add(New MySqlParameter("@details", MySqlDbType.VarChar, 100, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@images", MySqlDbType.VarChar, 100, "images"))
            cmdInsert.Parameters.Add(New MySqlParameter("@auto", MySqlDbType.Int32, 11, "auto"))
            cmdInsert.Parameters.Add(New MySqlParameter("@operator", MySqlDbType.VarChar, 50, "operator"))
            cmdInsert.Parameters.Add(New MySqlParameter("@modul", MySqlDbType.VarChar, 10, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            Dim cmdUpdate As MySqlCommand = New MySqlCommand("update daftarmenu set status = 'Y'", functions.localConnection)
            functions.copyData(cmdSelect, cmdInsert, cmdUpdate, "daftarmenu", "daftarmenu", "daftarmenu")

            cmdSelect = New MySqlCommand("select menucode, itemcode, itemname, itemkategori, itemprice, itemqty, auto, operator, modul, status from daftarmenudetails where status='N'", functions.localConnection)
            cmdInsert = New MySqlCommand("insert into daftarmenudetails (menucode, itemcode, itemname, itemkategori, itemprice, itemqty, auto, operator, modul, status) values(@menucode, @itemcode, @itemname, @itemkategori, @itemprice, @itemqty, @auto, @operator, @modul, @status)", functions.webConnection)
            cmdInsert.Parameters.Add(New MySqlParameter("@menucode", MySqlDbType.VarChar, 25, "menucode"))
            cmdInsert.Parameters.Add(New MySqlParameter("@itemcode", MySqlDbType.VarChar, 25, "itemcode"))
            cmdInsert.Parameters.Add(New MySqlParameter("@itemname", MySqlDbType.VarChar, 50, "itemname"))
            cmdInsert.Parameters.Add(New MySqlParameter("@itemkategori", MySqlDbType.VarChar, 25, "itemkategori"))
            cmdInsert.Parameters.Add(New MySqlParameter("@itemprice", MySqlDbType.Double, 11, "itemprice"))
            cmdInsert.Parameters.Add(New MySqlParameter("@itemqty", MySqlDbType.Int32, 11, "itemqty"))
            cmdInsert.Parameters.Add(New MySqlParameter("@auto", MySqlDbType.Int32, 11, "auto"))
            cmdInsert.Parameters.Add(New MySqlParameter("@operator", MySqlDbType.VarChar, 50, "operator"))
            cmdInsert.Parameters.Add(New MySqlParameter("@modul", MySqlDbType.VarChar, 10, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            cmdUpdate = New MySqlCommand("update daftarmenudetails set status = 'Y'", functions.localConnection)
            functions.copyData(cmdSelect, cmdInsert, cmdUpdate, "daftarmenudetails", "daftarmenudetails", "daftarmenudetails")

            frmMain.lblPendingDM.ForeColor = Color.Black
            frmMain.lblPendingDM.Text = "0"
            frmMain.btnDM.Text = "C"
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Menu Update Success."
        Catch ex As Exception
            frmMain.panelStatus.BackColor = Color.DarkRed
            frmMain.panelStatus.Text = "Daftar Menu Update Failed."
        End Try
        Return True
    End Function

    Public Shared Function updateDaftarCustomer()
        Try
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Customer Updating..."
            Dim cmdSelect As MySqlCommand = New MySqlCommand("select code, name, kategori, price, details, images, auto, operator, modul, status from daftaritem where status='N'", functions.localConnection)
            Dim cmdInsert As MySqlCommand = New MySqlCommand("insert into daftaritem (code, name, kategori, price, details, images, auto, operator, modul, status) values(@code, @name, @kategori, @price, @details, @images, @auto, @operator, @modul, @status)", functions.webConnection)
            cmdInsert.Parameters.Add(New MySqlParameter("@code", MySqlDbType.VarChar, 25, "code"))
            cmdInsert.Parameters.Add(New MySqlParameter("@name", MySqlDbType.VarChar, 50, "name"))
            cmdInsert.Parameters.Add(New MySqlParameter("@kategori", MySqlDbType.VarChar, 25, "kategori"))
            cmdInsert.Parameters.Add(New MySqlParameter("@price", MySqlDbType.Double, 11, "price"))
            cmdInsert.Parameters.Add(New MySqlParameter("@details", MySqlDbType.VarChar, 100, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@images", MySqlDbType.VarChar, 100, "images"))
            cmdInsert.Parameters.Add(New MySqlParameter("@auto", MySqlDbType.Int32, 11, "auto"))
            cmdInsert.Parameters.Add(New MySqlParameter("@operator", MySqlDbType.VarChar, 50, "operator"))
            cmdInsert.Parameters.Add(New MySqlParameter("@modul", MySqlDbType.VarChar, 10, "details"))
            cmdInsert.Parameters.Add(New MySqlParameter("@status", MySqlDbType.VarChar, 1, "status"))
            Dim cmdUpdate As MySqlCommand = New MySqlCommand("update daftaritem set status = 'Y'", functions.localConnection)
            functions.copyData(cmdSelect, cmdInsert, cmdUpdate, "daftaritem", "daftaritem", "daftaritem")

            frmMain.lblPendingDI.ForeColor = Color.Black
            frmMain.lblPendingDI.Text = "0"
            frmMain.btnDI.Text = "C"
            frmMain.panelStatus.BackColor = Color.Black
            frmMain.panelStatus.Text = "Daftar Customer Update Success."
        Catch ex As Exception
            frmMain.panelStatus.BackColor = Color.DarkRed
            frmMain.panelStatus.Text = "Daftar Customer Update Failed."
        End Try
        Return True
    End Function
End Class
