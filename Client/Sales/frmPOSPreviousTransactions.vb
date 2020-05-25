Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSPreviousTransactions
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSTransactionsHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        TabControl1.SelectedTab = tabVoidCancelled
        ShowVoidandCancelledTransactions()

        TabControl1.SelectedTab = tabDetails
        ShowDetailTransactions()

        TabControl1.SelectedTab = tabBatch
        ShowBatchTransactions()
    End Sub
    Public Sub ShowBatchTransactions()
        MyDataGridView_Batch.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select datetrn, batchcode as 'Batch Code', (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid) as 'Client', " _
                                            + " totalitem as 'Total Item',totalitemcancelled as 'Item Cancelled', totaldiscount as 'Total Discount',totaltax as 'Total Tax', subtotal as 'Sub Total',total as 'Total Amount', amounttendered as 'Cash Tendered', amountchange as 'Change',CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction' from tblsalesbatch where onhold=0 and void=0  and userid='" & globaluserid & "' and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select current_timestamp,'Total','',sum(totalitem),sum(totalitemcancelled),sum(totaldiscount),sum(totaltax),sum(subtotal),sum(total),sum(amounttendered),sum(amountchange),concat('Total Batch Count ',count(*)) from tblsalesbatch where onhold=0 and void=0 and userid='" & globaluserid & "' and trnsumcode='" & globalSalesTrnCOde & "') as s  order by datetrn asc;", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Batch.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Batch, {"datetrn"})
        GridColumnAlignment(MyDataGridView_Batch, {"Batch Code", "Total Item", "Item Cancelled"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Batch, {"Sub Total", "Total Amount", "Total Discount", "Total Tax", "Cash Tendered", "Change"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_Batch, {"Sub Total", "Total Amount", "Total Discount", "Total Tax", "Cash Tendered", "Change"})

        MyDataGridView_Batch.Rows(MyDataGridView_Batch.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Batch.Rows(MyDataGridView_Batch.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Batch.Rows(MyDataGridView_Batch.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ShowDetailTransactions()
        MyDataGridView_Detail.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select datetrn, batchcode as 'Batch Code', (select companyname from tblclientaccounts where cifid = tblsalestransaction.cifid) as 'Client', " _
                                            + " productname as 'Particular' ,Quantity, Unit,sellprice as 'Unit Price', distotal as 'Discount',taxtotal as 'Tax', subtotal as 'Sub Total',total as 'Total Amount', CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction' from tblsalestransaction where onhold=0 and tblsalestransaction.cancelled=0 and void=0  and userid='" & globaluserid & "' and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select current_timestamp,'Total','','',sum(quantity),'',sum(sellprice),sum(distotal),sum(taxtotal),sum(subtotal),sum(total),concat('Total Item Count ',count(*)) from tblsalestransaction where onhold=0 and tblsalestransaction.cancelled=0 and void=0 and userid='" & globaluserid & "' and trnsumcode='" & globalSalesTrnCOde & "') as s  order by datetrn asc;", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Detail.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Detail, {"datetrn"})
        GridCurrencyColumn(MyDataGridView_Detail, {"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount"})
        GridColumnAlignment(MyDataGridView_Detail, {"Batch Code", "Quantity", "Unit", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Detail, {"Discount", "Tax", "Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ShowVoidandCancelledTransactions()
        MyDataGridView_VoidCancelled.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select datetrn, batchcode as 'Batch Code', (select companyname from tblclientaccounts where cifid = tblsalestransaction.cifid) as 'Client', " _
                                            + " productname as 'Particular' ,Quantity, Unit,sellprice as 'Unit Price', distotal as 'Discount',taxtotal as 'Tax', subtotal as 'Sub Total',total as 'Total Amount', CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction',case when void=1 then 'Void' when cancelled=1 then 'Cancelled' when (void=1 and cancelled=1) then 'Cancelled/Voided' end as 'Remarks'  from tblsalestransaction where (cancelled=1 or void=1)  and userid='" & globaluserid & "' and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select current_timestamp,'Total','','',sum(quantity),'',sum(sellprice),sum(distotal),sum(taxtotal),sum(subtotal),sum(total),concat('Total Item Count ',count(*)),'' from tblsalestransaction where (cancelled=1 or void=1) and userid='" & globaluserid & "' and trnsumcode='" & globalSalesTrnCOde & "') as s  order by datetrn asc;", conn)
        msda.Fill(dst, 0)
        MyDataGridView_VoidCancelled.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_VoidCancelled, {"datetrn"})
        GridCurrencyColumn(MyDataGridView_VoidCancelled, {"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount"})
        GridColumnAlignment(MyDataGridView_VoidCancelled, {"Batch Code", "Quantity", "Unit", "Unit Price", "Remarks"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_VoidCancelled, {"Discount", "Tax", "Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_VoidCancelled.Rows(MyDataGridView_VoidCancelled.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_VoidCancelled.Rows(MyDataGridView_VoidCancelled.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_VoidCancelled.Rows(MyDataGridView_VoidCancelled.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
End Class