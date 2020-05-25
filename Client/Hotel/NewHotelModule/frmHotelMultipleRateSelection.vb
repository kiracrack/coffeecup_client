Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelMultipleRateSelection
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelMultipleRateSelection_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmHotelMultipleRateSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select *, concat(ratecode,' - ',description) as rate from tblhotelroomrates where (roomtype='" & frmHotelPickMultipleRoom.roomtype.Text & "' and temporaryrate=0) or (roomtype='" & frmHotelPickMultipleRoom.roomtype.Text & "' and bookingno='" & frmHotelPickMultipleRoom.foliono.Text & "') and deleted=0 order by description asc", "rate", "ratecode", txtRoomType)
    End Sub

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtRoomType.Text = "" Then
            MessageBox.Show("Please select package!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRoomType.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmHotelPickMultipleRoom.UpdateRoomRates(rateid.Text, txtRoomType.Text, Val(CC(txtBalanceDue.Text)), CheckBox1.CheckState)
            Me.Close()
        End If
    End Sub
 
  
    Private Sub txtRoomType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomType.SelectedValueChanged
        rateid.Text = DirectCast(txtRoomType.SelectedItem, ComboBoxItem).HiddenValue()
        com.CommandText = "select  *,ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='roomrate' and dayrate=0),0) as roomrate,(select chargepernight from tblhotelroomtype where code=tblhotelroomrates.roomtype) as pernight  from tblhotelroomrates where ratecode='" & DirectCast(txtRoomType.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
        While rst.Read
            txtBalanceDue.Text = FormatNumber(rst("roomrate").ToString, 2)
            CheckBox1.Checked = CBool(rst("pernight"))
        End While
        rst.Close()
    End Sub
End Class