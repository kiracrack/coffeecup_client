Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmPOSCustomOrderItemized
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Insert) Then
            frmPOSCustomOrderProductSearch.postrn.Text = postrn.Text
            frmPOSCustomOrderProductSearch.productid.Text = productid.Text
            frmPOSCustomOrderProductSearch.txtBatchcode.Text = txtBatchcode.Text
            frmPOSCustomOrderProductSearch.ShowDialog(Me)
      
        End If
        Return ProcessCmdKey
    End Function

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub frmPOSCustomOrderItemized_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowItemList()
        PaintColumnFormat()
    End Sub

    Public Sub ShowItemList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select cast(id as unsigned) as id,  ucase(productname) as 'Item Name', Quantity,ucase(Unit) as 'Unit',unitprice as 'Unit Cost' from tblsalesproductcustomorder where postrn='" & postrn.Text & "' and void=0", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id"})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost"})
        PaintColumnFormat()
    End Sub
    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"id"}, 0)
        GridColumnWidth(MyDataGridView, {"Quantity", "Unit Cost"}, 80)
        GridColumnWidth(MyDataGridView, {"Unit"}, 100)
        Dim column As Array = {"id", "Quantity", "Unit Cost", "Unit"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        GridColumnWidth(MyDataGridView, {"Item Name"}, (MyDataGridView.Width) - TotalVisibleColumn)
    End Sub
    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        ElseIf e.KeyCode() = Keys.Delete Then
            If MessageBox.Show("Are you sure you want to cancel selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                    com.CommandText = "delete from tblsalesproductcustomorder where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                    frmPointOfSale.ValidatePOSTransaction(txtBatchcode.Text)
                    ShowItemList()
                Next
            End If
        End If
    End Sub

    Private Sub MyDataGridView_Resize(sender As Object, e As EventArgs) Handles MyDataGridView.Resize
        PaintColumnFormat()
    End Sub
End Class