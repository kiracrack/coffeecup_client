Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelMaintainanceTimeframe
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
 
    Private Sub frmHotelMaintainanceTimeframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select * from tblhotelroomstatus where maintainance=1", "description", "statuscode", txtRoomStatus)
        com.CommandText = "select *,(select description from tblhotelroomtype where code=tblhotelrooms.roomtype) as details,(select companyname from tblclientaccounts where cifid = tblhotelrooms.hotelcifid) as hotel from tblhotelrooms where roomid='" & roomid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            hotelcif.Text = rst("hotelcifid").ToString
            hotelname.Text = rst("hotel").ToString
            txtRoomNumber.Text = rst("roomnumber").ToString
            txtRoomDetails.Text = rst("details").ToString

        End While
        rst.Close()

        If countqry("tblhotelroommaintainance", "roomid='" & roomid.Text & "' and closed=0") > 0 Then
            com.CommandText = "select * from tblhotelroommaintainance where roomid='" & roomid.Text & "' and closed=0" : rst = com.ExecuteReader
            While rst.Read
                txtDateFrom.Value = rst("startdate").ToString
                txtDateTo.Text = rst("enddate").ToString
                roomstatus.Text = rst("roomstatus")
                txtRoomStatus.Text = rst("statusdescription")
                txtRemarks.Text = rst("remarks").ToString
            End While
            rst.Close()
        End If
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If countqry("tblhotelroommaintainance", "roomid='" & roomid.Text & "' and closed=0") = 0 Then
            com.CommandText = "insert into tblhotelroommaintainance set hotelcif='" & hotelcif.Text & "', hotelname='" & hotelname.Text & "', roomid='" & roomid.Text & "', roomno='" & txtRoomNumber.Text & "', roomdetails='" & txtRoomDetails.Text & "', startdate='" & ConvertDateTime(txtDateFrom.Value) & "', enddate='" & ConvertDateTime(txtDateTo.Value) & "',roomstatus='" & roomstatus.Text & "',statusdescription='" & txtRoomStatus.Text & "', remarks='" & rchar(txtRemarks.Text) & "',trnby='" & globalfullname & "',datetrn=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblhotelroommaintainance set hotelcif='" & hotelcif.Text & "', hotelname='" & hotelname.Text & "', roomno='" & txtRoomNumber.Text & "', roomdetails='" & txtRoomDetails.Text & "', startdate='" & ConvertDateTime(txtDateFrom.Value) & "', enddate='" & ConvertDateTime(txtDateTo.Value) & "',roomstatus='" & roomstatus.Text & "',statusdescription='" & txtRoomStatus.Text & "', remarks='" & rchar(txtRemarks.Text) & "',updateby='" & globalfullname & "',dateupdated=current_timestamp where roomid='" & roomid.Text & "' and closed=0" : com.ExecuteNonQuery()
        End If
        com.CommandText = "UPDATE tblhotelrooms set maintainance=1, roomstatus='" & roomstatus.Text & "',remarks='" & rchar(txtRemarks.Text) & "' where roomid='" & roomid.Text & "'" : com.ExecuteNonQuery()
        MsgBox("Room maintainance successfully saved!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub txtRoomStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomStatus.SelectedValueChanged
        roomstatus.Text = DirectCast(txtRoomStatus.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub
End Class