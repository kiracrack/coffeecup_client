Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelHouseKeepingUpdateInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmHotelHouseKeepingUpdateInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select statuscode, description from tblhotelroomstatus", "description", "statuscode", txtRoomStatus)
        LoadToComboBoxDB("select distinct(remarks) as remark from tblhotelhousekeepingreports", "remark", "remark", txtRemarks)
        LoadHouseKeeper()

    End Sub
    Public Sub LoadHouseKeeper()
        ckHouserKeeper.Items.Clear()
        com.CommandText = "select fullname from tblaccounts where officeid='" & compOfficeid & "' and deleted=0" : rst = com.ExecuteReader()
        While rst.Read
            ckHouserKeeper.Items.Add(rst("fullname"))
        End While
        rst.Close()

    End Sub
    Public Sub ClearInfo()
        txtRoomStatus.Items.Clear()
        LoadToComboBoxDB("select * from tblhotelroomstatus", "description", "statuscode", txtRoomStatus)
        ckupdateRoom.Checked = False
        ckAllowCheckin.Checked = False
        ckMaintainance.Checked = False
    End Sub
     
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtRoomStatus.Text = "" Then
            MessageBox.Show("Please enter room status", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoomStatus.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to Continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim housekeeper As String = ""
            For i = 0 To ckHouserKeeper.Items.Count - 1
                If ckHouserKeeper.GetItemChecked(i) = True Then
                    housekeeper = housekeeper + ckHouserKeeper.Items(i).ToString + ","
                End If
            Next
            frmHotelRoomForHouseKeeping.UpdateRoomStatus(roomstatus.Text, ckAllowCheckin.CheckState, ckMaintainance.CheckState, housekeeper, txtRemarks.Text)
            Me.Close()
        End If
    End Sub
   
    Private Sub txtRoomStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomStatus.SelectedValueChanged
        If txtRoomStatus.Text = "" Then Exit Sub
        roomstatus.Text = DirectCast(txtRoomStatus.SelectedItem, ComboBoxItem).HiddenValue()
        com.CommandText = "select * from tblhotelroomstatus where statuscode='" & roomstatus.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            ckupdateRoom.Checked = rst("updateroomstatus")
            ckAllowCheckin.Checked = rst("vacantcleared")
            ckMaintainance.Checked = rst("maintainance")
        End While
        rst.Close()
    End Sub
     
End Class