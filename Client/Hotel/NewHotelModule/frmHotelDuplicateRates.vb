Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelDuplicateRates
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelDuplicateRates_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmHotelDuplicateRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim newrateid As String = qrysingledata("newratecode", "ratecode+1 as newratecode", "tblhotelroomrates order by ratecode desc limit 1")

            com.CommandText = "INSERT INTO tblhotelroomrates set ratecode='" & newrateid & "',roomtype='" & roomtype.Text & "',description='" & rchar(txtRateName.Text) & "',allowzerorate=0,actived=1,lockrate=0,temporaryrate=1, originrate='" & rateid.Text & "',onlinerate=0,packagedetails='',bookingno='" & foliono.Text & "', addedby='" & globaluserid & "'" : com.ExecuteNonQuery()

            com.CommandText = "INSERT INTO tblhotelratesbreakdown (roomtype,ratecode,dayrate,breakdowntype,itemcode,itemname,amount) " _
                                   + " SELECT '" & roomtype.Text & "','" & newrateid & "',dayrate,breakdowntype,itemcode,itemname,amount FROM tblhotelratesbreakdown where ratecode='" & rateid.Text & "'" : com.ExecuteNonQuery()
            frmHotelCustomPackage.loadPackages()
            MessageBox.Show("Rate successfully duplicated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class