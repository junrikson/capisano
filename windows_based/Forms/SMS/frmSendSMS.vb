Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Ports

Public Class frmSendSMS
    Private objclsSMS As New clsSMS()
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim Xparity As String = ""
            Select Case Parity
                Case "Even"
                    Xparity = "2"
                Case "Odd"
                    Xparity = "1"
                Case "None"
                    Xparity = "0"
                Case "Mark"
                    Xparity = "3"
                Case "Space"
                    Xparity = "4"
            End Select
            frmServer.comm.BaudRate = BaudRate
            frmServer.comm.StopBits = StopBits
            frmServer.comm.Parity = Xparity
            frmServer.comm.DataBits = DataBits
            frmServer.comm.PortName = CommPort
            'If Not frmServer.comm.IsOpen Then
            '    frmServer.comm.Open()
            'End If
            'objclsSMS.sendMsg(frmServer.comm, txtHP.Text, txtPesan.Text)
            Dim ObjMessageSender As New clsMessageSender
            Dim message As String
            message = txtPesan.Text
            frmServer.comm.Write("AT+CMGS=" & (Len(ObjMessageSender.MessageSubmit(txtHP.Text, message)) / 2) - 1 & vbCr)
            frmServer.comm.Write(ObjMessageSender.MessageSubmit(txtHP.Text, message) & Chr(26))
            frmServer.Wait()

            'If frmServer.comm.IsOpen Then
            '    frmServer.comm.Close()
            'End If

            Close()

        Catch ex As Exception
            MsgBox("Posting pesan gagal : " & Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class