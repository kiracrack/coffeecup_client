Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmInventoryAdjust
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtquan.Select(0, txtquan.Text.Length)
        clearFields()
    End Sub

    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Not IsNothing(e.Value) And e.ColumnIndex > 3 Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
            End If
        End If
    End Sub

    Public Sub clearFields()
        id.Text = getGlobalTrnid(compOfficeid.Remove(2, compOfficeid.Length - 2), globaluserid)
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If CC(txtquan.Text) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblinventory set quantity='" & Val(CC(txtquan.Value)) & "',purchasedprice='" & Val(CC(txtUnitCost.Value)) & "', lastupdate=current_timestamp,lasttrnby='" & globaluserid & "' where trnid='" & refno.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & refno.Text & "', n_title='Inventory Adjusted', n_description='" & txtProductName.Text & " from quantity of " & txtCurrQuantity.Value.ToString & " to " & txtquan.Value.ToString & " of " & StrConv(compOfficename, vbProperCase) & " inventory', n_type='request', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
        MessageBox.Show("Your inventory was successfully adjusted! " & Environment.NewLine & Environment.NewLine _
                              & "Date/time Adjusted: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                              & "You will check your inventory summary!" & Environment.NewLine & "Note: Please download or synch inventory to get updated data!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtquan_ValueChanged(sender As Object, e As EventArgs) Handles txtquan.ValueChanged
        Calculator()
    End Sub
    Public Sub Calculator()
        txtTotalCost.Value = txtUnitCost.Value * txtquan.Value
    End Sub

    Private Sub txtUnitCost_ValueChanged(sender As Object, e As EventArgs) Handles txtUnitCost.ValueChanged
        Calculator()
    End Sub
End Class