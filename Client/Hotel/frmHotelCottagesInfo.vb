Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCottagesInfo
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtContactPerson.Text = "" Then
            MsgBox("Please contact person name!", MsgBoxStyle.Exclamation, "Error Message")
            txtContactPerson.Focus()
            Exit Sub
        End If
        If trnid.Text <> "" Then
            com.CommandText = "UPDATE tblhotelcottagestransaction set clientname='" & rchar(txtContactPerson.Text) & "',contactnumber='" & txtContactNumber.Text & "'  where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT into tblhotelcottagestransaction set trnsumcode='" & globalSalesTrnCOde & "', productid='" & productid.Text & "',  clientname='" & rchar(txtContactPerson.Text) & "',contactnumber='" & txtContactNumber.Text & "',  trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
        End If
        com.CommandText = "update tblhotelcottages set availability= " & If(mode.Text = "checkin", "0", "-1") & " where productid='" & productid.Text & "'" : com.ExecuteNonQuery()
        frmHotelCottagesSummary.ShowHotelAndCottages()
        Me.Hide()
        MsgBox(txtProductName.Text & " successfully set as " & If(mode.Text = "checkin", "occupied", "reserved"), MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        com.CommandText = "select * from tblhotelcottagestransaction where id='" & trnid.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtContactPerson.Text = rst("clientname").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
        End While
        rst.Close()
        If mode.Text = "checkin" Then
            Me.Text = "Check-In Information"
        Else
            Me.Text = "Reservation Information"
        End If
    End Sub
End Class