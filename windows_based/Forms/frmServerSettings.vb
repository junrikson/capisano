Public Class frmServerSettings
    'fungsi untuk drag form
    
    Private Sub frmServerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = variabels.localServerAdress
        txtUsername.Text = variabels.localServerUsername
        txtPassword.Text = variabels.localServerPassword
        txtDatabase.Text = variabels.localDatabaseName

        txtServerWeb.Text = variabels.WebServerAdress
        txtUsernameWeb.Text = variabels.WebServerUsername
        txtPasswordWeb.Text = variabels.WebServerPassword
        txtDatabaseWeb.Text = variabels.WebDatabaseName
    End Sub

    Private Sub btnSaveLocal_Click(sender As Object, e As EventArgs) Handles btnSaveLocal.Click
        My.Computer.FileSystem.WriteAllText("config.cfg", "#Local Server Host" + vbCrLf + txtServer.Text + vbCrLf + txtUsername.Text + vbCrLf + txtPassword.Text + vbCrLf + txtDatabase.Text + vbCrLf, False)
        variabels.localServerAdress = txtServer.Text
        variabels.localServerUsername = txtUsername.Text
        variabels.localServerPassword = txtPassword.Text
        variabels.localDatabaseName = txtDatabase.Text
    End Sub

    Private Sub btnSaveWeb_Click(sender As Object, e As EventArgs) Handles btnSaveWeb.Click
        My.Computer.FileSystem.WriteAllText("config\webserver.cfg", "#Website Server Host" + vbCrLf + txtServerWeb.Text + vbCrLf + txtUsernameWeb.Text + vbCrLf + txtPasswordWeb.Text + vbCrLf + txtDatabaseWeb.Text + vbCrLf, False)
        variabels.webServerAdress = txtServerWeb.Text
        variabels.webServerUsername = txtUsernameWeb.Text
        variabels.webServerPassword = txtPasswordWeb.Text
        variabels.webDatabaseName = txtDatabaseWeb.Text
    End Sub
End Class