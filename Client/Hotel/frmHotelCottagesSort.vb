Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCottagesSort
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        com.CommandText = "UPDATE tblhotelcottages set sort='" & txtNumber.Text & "' where productid='" & productid.Text & "'" : com.ExecuteNonQuery()
        frmHotelCottagesSummary.ShowHotelAndCottages()
        Me.Close()
    End Sub

    Private Sub frmHotelCottagesSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumber.Text = qrysingledata("sort", "sort", "tblhotelcottages where productid='" & productid.Text & "'")
    End Sub
End Class