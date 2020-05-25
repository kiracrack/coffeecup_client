Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmViewPreviousPurchase
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmViewPreviousPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        filterApprovalLogs()
    End Sub
   
    Public Sub filterApprovalLogs()
       MyDataGridView_Particular.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select ponumber, (select officename from tblcompoffice where officeid = tblpurchaseorderitem.officeid) as 'Requesting Office', " _
                                + " itemname as 'Particular', " _
                                + " (select description from tblprocategory where CATID = tblpurchaseorderitem.catid ) as 'Category', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " datetrn as 'Date Requested', " _
                                + " Delivered, " _
                                + " datedelivered as 'Date Delivered' " _
                                + " from tblpurchaseorderitem " _
                                + " where productid='" & productid.Text & "'", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Particular.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Particular, {"ponumber"})
        GridColumnAlignment(MyDataGridView_Particular, {"Quantity", "Unit", "Delivered"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Particular, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_Particular, {"Cost", "Total"})
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Particular.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Particular.CurrentCell = Me.MyDataGridView_Particular.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If MyDataGridView_Particular.RowCount = 0 Then Exit Sub
        frmPurchaseOrderView.ponumber.Text = MyDataGridView_Particular.Item("ponumber", MyDataGridView_Particular.CurrentRow.Index).Value().ToString()
        frmPurchaseOrderView.Show(Me)
    End Sub
    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_Particular.CellDoubleClick
        cmdView.PerformClick()
    End Sub
 

End Class