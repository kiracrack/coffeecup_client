Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSCustomOrderProductSearch

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            txtsearch.SelectAll()
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowProductList()
        PaintColumnFormat()
    End Sub

    Public Sub ShowProductList()
        'Dim category As String = ""
        'If Globalcustomorderproductcategory.Length > 0 Then
        '    For Each word In Globalcustomorderproductcategory.Split(New Char() {","c})
        '        If word.Length > 1 Then
        '            category = category + " catid='" & word & "' or "
        '        End If
        '    Next
        '    category = category.Remove(category.Length - 3, 3)
        'End If
        '
        'If category = "" Then
        '    MsgBox("There no configured product category for this function! Please contact your system administrator", MsgBoxStyle.Critical, "Customized product order search")
        '    Exit Sub
        'End If
        MyDataGridView.DataSource = Nothing : msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select productid, ucase(itemname) as 'Product Name', ucase(Unit) as 'Unit',sellingprice as 'Unit Cost' from tblglobalproducts where (itemname like '%" & rchar(txtsearch.Text) & "%') and productid in (select productid from tblproductserviceitem where source_productid='" & productid.Text & "')", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"productid"})
        GridCurrencyColumn(MyDataGridView, {"Unit Cost"})
        GridColumnAlignment(MyDataGridView, {"Unit"}, DataGridViewContentAlignment.MiddleCenter)
        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        PaintColumnFormat()
        MyDataGridView.Focus()
    End Sub
    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"productid"}, 0)
        GridColumnWidth(MyDataGridView, {"Unit", "Unit Cost"}, 80)

        Dim column As Array = {"productid", "Unit", "Unit Cost"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        GridColumnWidth(MyDataGridView, {"Product Name"}, (MyDataGridView.Width) - TotalVisibleColumn)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmPOSCustomProductEnterQuantity.postrn.Text = postrn.Text
            frmPOSCustomProductEnterQuantity.txtBatchcode.Text = txtBatchcode.Text
            frmPOSCustomProductEnterQuantity.productid.Text = MyDataGridView.Item("productid", MyDataGridView.CurrentRow.Index).Value().ToString
            frmPOSCustomProductEnterQuantity.Show(Me)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            ShowProductList()
        End If
    End Sub

    Private Sub MyDataGridView_Resize(sender As Object, e As EventArgs) Handles MyDataGridView.Resize
        PaintColumnFormat()
    End Sub
End Class