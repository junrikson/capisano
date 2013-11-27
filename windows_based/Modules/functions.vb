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
End Class
