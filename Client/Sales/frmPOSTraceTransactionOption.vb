Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSTraceTransactionOption
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

  
    Private Sub cmdTracePreviousTransaction_Click(sender As Object, e As EventArgs) Handles cmdTracePreviousTransaction.Click
        frmPOSTraceTransaction.Show(frmPointOfSale)
        Me.Close()
    End Sub

    Private Sub cmdTraceCurrentTransaction_Click(sender As Object, e As EventArgs) Handles cmdTraceCurrentTransaction.Click
        frmPOSCurrentTransactions.Show(frmPointOfSale)
        Me.Close()
    End Sub
End Class