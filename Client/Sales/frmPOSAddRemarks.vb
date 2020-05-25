Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmPOSAddRemarks

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

 
    Private Sub frmPOSEditLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        com.CommandText = "update tblsalestransaction set remarks='" & txtRemarks.Text & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
        frmPointOfSale.ValidatePOSTransaction(txtBatchcode.Text)
        'MessageBox.Show("Remarks successfully added!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class