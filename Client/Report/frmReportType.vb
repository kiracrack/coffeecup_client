Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmReportType

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdConsumable.Click
        frmReportGenerator.Show()
        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdFFE.Click
        frmVIPReportViewer.Show()
        Me.Close()
    End Sub

   
End Class