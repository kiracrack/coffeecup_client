Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmInventoryLockCutoffDetails
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmInventoryLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ViewLocalparticulars()
    End Sub
    
    Public Sub ViewLocalparticulars()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select productname as 'Particular',  categoryname as 'Category',  Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type',  quantity as 'Quantity',Unit,  purchasedprice as 'Purchased Price',(purchasedprice*quantity) as 'Total',  date_format(lastupdate, '%Y-%m-%d %r') as 'Date Inventory'  from tblinventorylocked where officeid='" & compOfficeid & "' and date_format(cutoff,'%Y-%m') = '" & cutoff.Text & "' and prepaid=0 union all " _
                                        + " Select '',  '',  '',  null,'',null,sum((purchasedprice*quantity)), null from tblinventorylocked where officeid='" & compOfficeid & "' and date_format(cutoff,'%Y-%m') = '" & cutoff.Text & "' and prepaid=0 group by prepaid union all " _
                                        + " Select productname as 'Particular',  categoryname as 'Category',  Case when prepaid=1 then 'Prepaid' else 'On hand' end as 'Inventory Type',  quantity as 'Quantity',Unit,  purchasedprice as 'Purchased Price',(purchasedprice*quantity) as 'Total',  date_format(lastupdate, '%Y-%m-%d %r') as 'Date Inventory'  from tblinventorylocked where officeid='" & compOfficeid & "' and date_format(cutoff,'%Y-%m') = '" & cutoff.Text & "' and prepaid=1 union all " _
                                        + " Select '',  '',  '',  null,'',null,sum((purchasedprice*quantity)), null from tblinventorylocked where officeid='" & compOfficeid & "' and date_format(cutoff,'%Y-%m') = '" & cutoff.Text & "' and prepaid=1 group by prepaid", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity"}, 4)
        GridCurrencyColumn(MyDataGridView, {"Purchased Price", "Total"})
        GridColumnAlignment(MyDataGridView, {"Inventory Type", "Quantity"}, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        ExportGridToExcel(RemoveSpecialCharacter(Me.Text), dst)
    End Sub


    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview("Cut-off Inventory Report", "Inventory Report", Me.Text, MyDataGridView, Me)
    End Sub

    Private Sub itemid_TextChanged(sender As Object, e As EventArgs) Handles cutoff.TextChanged
        ViewLocalparticulars()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewLocalparticulars()
    End Sub
End Class