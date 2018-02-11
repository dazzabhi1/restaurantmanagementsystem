Imports System.Data.OleDb
Public Class frmSplash

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Timer2.Enabled = False
            Me.Hide()
            frmLogin.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub
End Class