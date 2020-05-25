Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Data.OleDb

Public Class frmPOSTraceTransaction
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
    End Sub

    Private Sub txtSearchKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchKeyword.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtSearchKeyword.Text = "" Or txtSearchKeyword.Text = "%" Then Exit Sub
            If countqry("tblsalesbatch", " concat(date_format(datetrn,'%Y-%m-%d'),' - ', batchcode,' - ', (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid))  = '" & rchar(txtSearchKeyword.Text) & "'") = 0 Then
                LoadToComboBoxDB("select batchcode, concat(date_format(datetrn,'%Y-%m-%d'), ' - ', batchcode,' - ', (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid)) as 'client' from tblsalesbatch where (date_format(datetrn,'%Y-%m-%d') like '%" & rchar(txtSearchKeyword.Text) & "%' or batchcode like '%" & rchar(txtSearchKeyword.Text) & "%' or (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid) like '%" & rchar(txtSearchKeyword.Text) & "%') order by datetrn desc limit 100", "client", "batchcode", txtSearchKeyword)
                txtSearchKeyword.DroppedDown = True
            Else
                If txtSearchKeyword.Text.Length > 0 Then
                    TraceTransaction(DirectCast(txtSearchKeyword.SelectedItem, ComboBoxItem).HiddenValue())
                End If
            End If
        End If
    End Sub

    Public Sub TraceTransaction(ByVal batchcode As String)
        com.CommandText = "select *, (select fullname from tblaccounts where accountid=tblsalesbatch.voidby) as 'voidbyuser', if(invoiceno='',(select invoiceno from tblsalesclientcharges where batchcode=tblsalesbatch.batchcode),invoiceno) as 'invoice' from tblsalesbatch where batchcode='" & batchcode & "'" : rst = com.ExecuteReader
        While rst.Read
            txtBatchcode.Text = rst("batchcode").ToString
            txtInvoiceNumber.Text = rst("invoice").ToString
            txtTotalItem.Text = rst("totalitem").ToString
            txtTotalAmount.Text = FormatNumber(rst("total"), 2)
            txtAmountTendered.Text = FormatNumber(rst("amounttendered"), 2)
            txtAmountChange.Text = FormatNumber(rst("amountchange"), 2)
            txtPaymentType.Text = UCase(rst("paymenttype").ToString)
            ckVoid.Checked = rst("void")
            txtVoidBy.Text = rst("voidbyuser").ToString

            If ckVoid.Checked = True Then
                cmdVoidTransaction.Visible = False
            Else
                If rst("trnsumcode").ToString = globalSalesTrnCOde Then
                    cmdVoidTransaction.Visible = True
                Else
                    cmdVoidTransaction.Visible = False
                End If
            End If

            If Globalenablechittransaction = True Then
                lblChitAmount.Visible = True
                txtTotalChit.Visible = True
                lblChitCustomerName.Visible = True
                txtChitCustomerName.Visible = True
                lblChitNetDiscount.Visible = True
                txtChitNetDiscount.Visible = True
            Else
                lblChitAmount.Visible = False
                txtTotalChit.Visible = False
                lblChitCustomerName.Visible = False
                txtChitCustomerName.Visible = False
                lblChitNetDiscount.Visible = False
                txtChitNetDiscount.Visible = False
            End If
        End While
        rst.Close()

        com.CommandText = "select * from tblsaleschitbatch where  batchcode='" & batchcode & "'" : rst = com.ExecuteReader
        While rst.Read
            txtTotalChit.Text = FormatNumber(rst("chittotal"), 2)
            txtChitCustomerName.Text = rst("customername").ToString
            txtChitNetDiscount.Text = FormatNumber(rst("netdiscountaftertax"), 2)
        End While
        rst.Close()

        MyDataGridView_Trace.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select datetrn, batchcode as 'Batch Code'," _
                                            + " productname as 'Particular' ,sum(Quantity) as 'Quantity', Unit,sellprice as 'Unit Price'," & If(Globalenablechittransaction = True, "chitsellprice as 'Chit Price',", "") & " distotal as 'Discount',taxtotal as 'Tax', subtotal as 'Sub Total',  " & If(Globalenablechittransaction = True, "chittotal as 'Total Chit',", "") & "total as 'Total Amount', CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction', Cancelled, Void,(select fullname from tblaccounts where accountid=tblsalestransaction.userid) as 'Transaction By' from tblsalestransaction where batchcode='" & batchcode & "' group by batchcode,productid union all " _
                                            + " select current_timestamp,'','',null,'',null," & If(Globalenablechittransaction = True, "null,", "") & " null,null,null," & If(Globalenablechittransaction = True, "null,", "") & "sum(total),'',null,null,'' from tblsalestransaction where batchcode='" & batchcode & "') as s  order by datetrn asc;", conn)

        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Trace.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Trace, {"datetrn"})
        GridCurrencyColumn(MyDataGridView_Trace, {"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)})
        GridColumnAlignment(MyDataGridView_Trace, {"Batch Code", "Quantity", "Unit", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Trace, {"Discount", "Tax", "Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Trace.Rows(MyDataGridView_Trace.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Trace.Rows(MyDataGridView_Trace.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Trace.Rows(MyDataGridView_Trace.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are you sure you want to re-print selected transaction? " & Environment.NewLine & Environment.NewLine & "Note: Re-Print transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                RePrintPOSTransaction(txtBatchcode.Text, "tblsalesbatch", "batchcode", "receipt")
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If

    End Sub

    Private Sub cmdVoidTransaction_Click(sender As Object, e As EventArgs) Handles cmdVoidTransaction.Click
        If MessageBox.Show("Are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                TraceTransaction(txtBatchcode.Text)
                MsgBox("Transaction successfully void!", MsgBoxStyle.Information)
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
    End Sub
End Class