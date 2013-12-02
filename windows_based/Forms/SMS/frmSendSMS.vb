Public Class frmSendSMS
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            ExecuteSQLQuery("insert into sms_outbox(no_hp,tgl_sms,pesan,com,ip) values('" &
                            txtHP.Text & "','" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "','" & txtPesan.Text & "','" & Replace(CommPort, "COM", "") & "','" & ServerName & "')")

            MsgBox("Pesan terkirim", vbInformation)
            Close()
        Catch ex As Exception
            MsgBox("Posting pesan gagal : " & Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class