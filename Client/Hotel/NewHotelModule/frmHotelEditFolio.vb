Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelEditFolio
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelEditFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowFolioInfo()
    End Sub

    Public Sub ShowFolioInfo()
        com.CommandText = "select * from tblhotelfolioroom where folioid='" & folioid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            foliono.Text = rst("foliono").ToString
            txtDateArival.Value = rst("arival").ToString
            txtDeparture.Text = rst("departure").ToString
            txtPax.Text = rst("pax").ToString
            txtChild.Text = rst("child").ToString
            txtExtra.Text = rst("extra").ToString
        End While
        rst.Close()
    End Sub
      
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If MessageBox.Show("WARNING: Editing full room information will update all day rates! if you wish to change only individual room daily transaction. Go to View Room Info > Edit Selected Date" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Edited room " & GetRoomFolioInfo(folioid.Text, "roomno") & " from " & txtDateArival.Text & " to " & txtDeparture.Text & " with " & txtPax.Text & " adult(s), " & txtChild.Text & " Child(s) and " & txtExtra.Text & " Extra Person(s)")

            com.CommandText = "update tblhotelfolioroom set arival='" & ConvertDate(txtDateArival.Value) & "', departure='" & ConvertDate(txtDeparture.Value) & "', pax='" & Val(txtPax.Text) & "', child='" & Val(txtChild.Text) & "', extra='" & Val(txtExtra.Text) & "'  where folioid='" & folioid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblhotelfolioroomsummary set arival='" & ConvertDate(txtDateArival.Value) & "', departure='" & ConvertDate(txtDeparture.Value) & "', adult='" & Val(txtPax.Text) & "', child='" & Val(txtChild.Text) & "', extra='" & Val(txtExtra.Text) & "' where folioid='" & folioid.Text & "'" : com.ExecuteNonQuery()

            UpdateFolioSummary(foliono.Text)
            frmHotelCheckInTransactionV2.FilterRoom()
            MessageBox.Show("Room successfully updated! ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
     
End Class