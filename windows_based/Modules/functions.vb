Class functions
    Public Shared Function connect()
        Try
            frmMain.localConnection.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
