Imports MySql.Data.MySqlClient
Public Class frmClosingBulanan
    Private Sub frmClosingBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateClosing.Text = variabels.periode
    End Sub

    Private Sub btnClosing_Click(sender As Object, e As EventArgs) Handles btnClosing.Click
        functions.updatePeriode(variabels.periode.AddMonths(1))
        dateClosing.Text = variabels.periode
    End Sub

    Private Sub btnUnclosing_Click(sender As Object, e As EventArgs) Handles btnUnclosing.Click
        functions.updatePeriode(variabels.periode.AddMonths(-1))
        dateClosing.Text = variabels.periode
    End Sub
End Class