Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmChangeItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            If Not txtSearchBox.Focus = True Then
                txtSearchBox.SelectAll()
                txtSearchBox.Focus()
            End If
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChangeItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ' SearchProduct()
    End Sub
    Private Sub txtSearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBox.KeyPress
        If Trim(txtSearchBox.Text) = "" Then Exit Sub
        If e.KeyChar = Chr(13) Then
            If txtSearchBox.Text.Length < 3 Then
                MsgBox("Please enter keyword at least 3 characters to continue search!", MsgBoxStyle.Exclamation, "Error Search")
                txtSearchBox.Focus()
                Exit Sub
            End If
            SearchProduct()
            MyDataGridView.Focus()
        End If
    End Sub
    Public Sub SearchProduct()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select productid,catid, itemname as 'Product Name', Unit from tblglobalproducts where itemname like '%" & rchar(txtSearchBox.Text) & "%' and catid in (select catid from tblprocategory where consumable=1) and deleted=0  order by itemname asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"productid", "catid"})
        GridColumnAlignment(MyDataGridView, {"Unit"}, DataGridViewContentAlignment.MiddleCenter)
        ' GridColumnAlignment(MyDataGridView, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)
    End Sub

    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblpurchaseorderitem set productid='" & MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value & "', itemname='" & MyDataGridView.Item("Product Name", MyDataGridView.CurrentCell.RowIndex).Value & "',catid='" & MyDataGridView.Item("catid", MyDataGridView.CurrentCell.RowIndex).Value & "', unit='" & MyDataGridView.Item("Unit", MyDataGridView.CurrentCell.RowIndex).Value & "', remarks='changed item' where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
                frmReceivedConsumable.ChangeItem(MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value, MyDataGridView.Item("Product Name", MyDataGridView.CurrentCell.RowIndex).Value, MyDataGridView.Item("Unit", MyDataGridView.CurrentCell.RowIndex).Value)

                Me.Close()
            End If
        End If
    End Sub
End Class