Public Class frmGantiPeriode
    Private Sub frmGantiPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateClosing.Text = variabels.periodeAktif
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        variabels.periodeAktif = dateClosing.Text
        Me.Close()
    End Sub
End Class