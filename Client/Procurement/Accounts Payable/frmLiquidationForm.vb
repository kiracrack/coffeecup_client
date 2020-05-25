Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmLiquidationForm
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLiquidationForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmLiquidationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loaddetails()
    End Sub

    Public Sub loaddetails()
        com.CommandText = "select * from tbldisbursementvoucher as a where voucherno='" & voucherno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtVoucherAmount.Text = FormatNumber(rst("amount"), 2)
            companyid.Text = rst("companyid").ToString
        End While
        rst.Close()
        ShowExpenseEntries()
        filterOtherExpense()
        ShowParticularsItems()
        txtAmountSpend.Text = FormatNumber(Val(CC(GridView_Voucher.Columns("Total Actual Spend").SummaryText)) + Val(CC(Gridview_OtherExpense.Columns("Amount").SummaryText)), 2)
        Dim SpendDifference As Double = 0
        SpendDifference = Val(CC(txtVoucherAmount.Text)) - Val(CC(txtAmountSpend.Text))

        If SpendDifference > 0 Then
            txtAmountRefunded.Text = FormatNumber(SpendDifference, 2)
        ElseIf SpendDifference < 0 Then
            txtAmountReimbursed.Text = FormatNumber(-SpendDifference, 2)
        Else
            txtAmountRefunded.Text = "0.00"
            txtAmountReimbursed.Text = "0.00"
        End If
    End Sub

    Public Sub ShowExpenseEntries()
        LoadXgrid("select date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', (select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as 'Supplier', invoiceno as 'Invoice No.', totalamount as 'Total Actual Spend', Delivered, date_format(datedelivered,'%Y-%m-%d %r') as 'Date Delivered'  from tblpurchaseorder where paymentrefnumber='" & voucherno.Text & "' order by datetrn asc", "tblpurchaseorder", Em_Voucher, GridView_Voucher)
        XgridColAlign({"PO Number", "Payable Type", "Date", "Invoice No."}, GridView_Voucher, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Actual Spend"}, GridView_Voucher)
        XgridGeneralSummaryCurrency({"Total Actual Spend"}, GridView_Voucher)
        XgridGroupSummaryCurrency({"Total Actual Spend"}, GridView_Voucher)
        XgridColWidth({"Total Actual Spend"}, GridView_Voucher, 120)

    End Sub
    Public Sub filterOtherExpense()
        LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', " _
                      + " (select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode) as 'Transaction Name', " _
                      + " Remarks, " _
                      + "  Amount " _
                      + " from tbldisbursementexpense  " _
                      + " WHERE voucherno = '" & voucherno.Text & "' order by datetrn asc", "tbldisbursementexpense", Em_OtherExpense, Gridview_OtherExpense)

        XgridHideColumn({"id"}, Gridview_OtherExpense)
        XgridColCurrency({"Amount"}, Gridview_OtherExpense)
        XgridGeneralSummaryCurrency({"Amount"}, Gridview_OtherExpense)
        Gridview_OtherExpense.Columns("Amount").Width = 120
    End Sub

    Public Sub ShowParticularsItems()
        LoadXgrid("SELECT a.ponumber as 'PO Number',(select companyname from tblglobalvendor where vendorid=a.vendorid) as 'Supplier',  itemname 'Particular', Quantity,Unit, Cost, Total, Remarks, a.Delivered, a.datedelivered as 'Date Delivered'  FROM `tblpurchaseorderitem` as a inner join tblpurchaseorder as b on a.ponumber=b.ponumber where b.paymentrefnumber='" & voucherno.Text & "'", "tblpurchaseorderitem", Em, GridView_Summary)

        XgridColCurrency({"Total", "Cost"}, GridView_Summary)
        XgridColAlign({"PO Number", "Quantity", "Unit", "Delivered"}, GridView_Summary, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView_Summary)
        XgridGroupSummaryCurrency({"Total"}, GridView_Summary)
        XgridColWidth({"Cost", "Total"}, GridView_Summary, 120)

    End Sub

    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        com.CommandText = "update tbldisbursementvoucher set amountspend='" & Val(CC(txtAmountSpend.Text)) & "', amountrefunded='" & Val(CC(txtAmountRefunded.Text)) & "', amountreimbursed='" & Val(CC(txtAmountReimbursed.Text)) & "',dateliquidated=current_timestamp where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
        PrintLiquidationReport(voucherno.Text, Me, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If countqry("tblpurchaseorder", "paymentrefnumber='" & voucherno.Text & "' and delivered=0 and cancelled=0") > 0 Then
            MsgBox("Liquidition cannot be submit! There's some PO currently not received yet", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbldisbursementvoucher set amountspend='" & Val(CC(txtAmountSpend.Text)) & "', amountrefunded='" & Val(CC(txtAmountRefunded.Text)) & "', amountreimbursed='" & Val(CC(txtAmountReimbursed.Text)) & "',liquidated=1, dateliquidated=current_timestamp where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
            RecordApprovingHistory("voucher", voucherno.Text, voucherno.Text, "liquidition", "Voucher#" & voucherno.Text & " liquidition submitted")
            If frmAPDisbursementVoucher.Visible = True Then
                frmAPDisbursementVoucher.ShowUnliquidatedCashAdvance()
            End If
            MessageBox.Show("Liquidation successfully submitted!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmVoucherOtherExpense.mode.Text = "edit"
        frmVoucherOtherExpense.companyid.Text = companyid.Text
        frmVoucherOtherExpense.trnid.Text = Gridview_OtherExpense.GetFocusedRowCellValue("id").ToString
        frmVoucherOtherExpense.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmVoucherOtherExpense.voucherno.Text = voucherno.Text
        frmVoucherOtherExpense.companyid.Text = companyid.Text
        frmVoucherOtherExpense.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To Gridview_OtherExpense.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tbldisbursementexpense where id='" & Gridview_OtherExpense.GetRowCellValue(Gridview_OtherExpense.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            filterOtherExpense()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        filterOtherExpense()
    End Sub
   
 
End Class