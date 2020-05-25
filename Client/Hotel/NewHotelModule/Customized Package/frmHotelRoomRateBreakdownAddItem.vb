Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmHotelRoomRateBreakdownAddItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelRoomRateBreakdownAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadItemPackage()
        If mode.Text = "edit" Then
            com.CommandText = "select * from tblhotelratesbreakdown where id='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                itemcode.Text = rst("itemcode").ToString
                txtitemname.Text = rst("itemname").ToString
                txtAmount.Text = FormatNumber(rst("amount").ToString, 2)
                txtDayRate.Text = rst("dayrate").ToString
            End While
            rst.Close()
        End If
    End Sub

    Public Sub LoadItemPackage()
        LoadToComboBoxDB("select * from tblhotelpackageitem order by description asc", "description", "itemcode", txtitemname)
    End Sub
    Private Sub txtitemname_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtitemname.SelectedValueChanged
        itemcode.Text = DirectCast(txtitemname.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub

    Private Sub txtitemname_DropDownClosed(sender As Object, e As EventArgs) Handles txtitemname.DropDownClosed
        txtAmount.Focus()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mode.Text = "edit" Then
            com.CommandText = "Update tblhotelratesbreakdown set roomtype='" & roomtype.Text & "',dayrate='" & txtDayRate.Text & "', ratecode='" & ratecode.Text & "', breakdowntype='" & breakdowntype.Text & "', itemcode='" & itemcode.Text & "', itemname='" & rchar(txtitemname.Text) & "', amount='" & Val(CC(txtAmount.Text)) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            txtAmount.Text = "0.00"
            Me.Close()
        Else
            com.CommandText = "insert into tblhotelratesbreakdown set roomtype='" & roomtype.Text & "',dayrate='" & txtDayRate.Text & "', ratecode='" & ratecode.Text & "', breakdowntype='" & breakdowntype.Text & "', itemcode='" & itemcode.Text & "', itemname='" & rchar(txtitemname.Text) & "', amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
            txtitemname.Focus()
            txtitemname.DroppedDown = True
            txtAmount.Text = "0.00"
        End If
        com.CommandText = "UPDATE tblhotelroomrates set editedby='" & globalfullname & "'  where ratecode='" & ratecode.Text & "'" : com.ExecuteNonQuery()
        If frmHotelCustomPackageItem.Visible = True Then
            frmHotelCustomPackageItem.LoadPackageItem()
        End If
        If frmHotelUpdatePackage.Visible = True Then
            frmHotelUpdatePackage.LoadBreakdown()
        End If
    End Sub


    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.PerformClick()
        Else
            InputNumberOnly(txtAmount, e)
        End If
    End Sub
End Class
