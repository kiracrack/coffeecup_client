Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCancelReservation
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If MessageBox.Show("  Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "Update tblhotelfolioroom set roomid='',roomno='', cancelled=1 where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()

            com.CommandText = "Update tblhotelfolioroombreakdown set roomid='', cancelled=1 where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "Update tblhotelfolioroomsummary set roomid='',roomno='', cancelled=1 where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblhotelfolioguest set cancelled=1,datecancelled=current_timestamp,cancelledby='" & globaluserid & "',cancelledremarks='" & rchar(txtRemarks.Text) & "' where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            MessageBox.Show("Folio successfully cencelled", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmHotelManagementv2.tabFilter()
            Me.Close()
        End If
    End Sub
    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
End Class