Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils


Public Class frmAccountsPayable
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAccountsPayable_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim forPaymentRequest As Integer = countqry("tblpurchaseorder", "corporatelevel=0 and verified=1 and forwarded=1 and paymentrequested=0 and officeid='" & compOfficeid & "' and cancelled=0;")
        If forPaymentRequest > 0 Then
            If globalFontColor = "LIGHT" Then
                cmdCreatePayment.ForeColor = Color.Gold
            Else
                cmdCreatePayment.ForeColor = Color.Red
            End If
            cmdCreatePayment.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            cmdCreatePayment.Text = "Create Payment Request (" & forPaymentRequest & ")"
        Else
            If globalFontColor = "LIGHT" Then
                cmdCreatePayment.ForeColor = Color.LightGray
            Else
                cmdCreatePayment.ForeColor = Color.Black
            End If
            cmdCreatePayment.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            cmdCreatePayment.Text = "Create Payment Request"
        End If
    End Sub

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FilterSelectedTab()
        ApplySystemTheme(ToolStrip3)
       
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        FilterSelectedTab()
    End Sub

    Public Function FilterSelectedTab()
        If TabControl1.SelectedTab Is tabPending Then
            ShowForApproval(txtfilter.Text)
            cmdRevise.Visible = True
        ElseIf TabControl1.SelectedTab Is tabCleared Then
            MyDataGridView.ContextMenuStrip = cms_em
            ShowClearedVoucher(txtfilter.Text)
            cmdRevise.Visible = False
        End If
    End Function
    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            FilterSelectedTab()
        End If
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub DataGridView_Pending_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Pending.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.DataGridView_Pending.CurrentCell = Me.DataGridView_Pending.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub


#Region "FOR DISBURSEMENT"
    Public Sub ShowForApproval(ByVal SearchKey As String)
        DataGridView_Pending.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Payable No.', if(corporatelevel=1,'CORPORATE','BRANCH') as 'Approval Level', if(cancelled=1,'Cancelled',if(hold=1,'Hold',if(cleared=1,'Cleared',if(verified=1,'Approved','For Approval')))) as 'Status'," _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as 'Supplier', Amount, " _
                                    + "  Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted',  " _
                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By' " _
                                    + "   from tbldisbursementvoucher where cleared=0 and cancelled=0 and officeid='" & compOfficeid & "' order by datetrn desc", conn)

        msda.Fill(dst, 0)
        DataGridView_Pending.DataSource = dst.Tables(0)
        GridColumnAlignment(DataGridView_Pending, {"Payable No.", "Status", "Date", "Approval Level", "Date Posted", "Status"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(DataGridView_Pending, {"Amount"})
        GridColumnAlignment(DataGridView_Pending, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

    End Sub
    '

    Public Sub ShowClearedVoucher(ByVal SearchKey As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Payable No.',  if(corporatelevel=1,'CORPORATE','BRANCH') as 'Approval Level',if(cancelled=1,'Cancelled',if(hold=1,'Hold',if(cleared=1,'Cleared',if(verified=1,'Approved','For Approval')))) as 'Status'," _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as 'Supplier', Amount, " _
                                    + "  Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', Verified as Approved, if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'Date Approved', Cleared,date_format(datecleared,'%Y-%m-%d %r') as 'Date Cleared'  " _
                                    + "   from tbldisbursementvoucher where cleared=1 and cancelled=0 and officeid='" & compOfficeid & "' order by datetrn desc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Payable No.", "Status", "Date", "Approval Level", "Date Posted", "Date Approved", "Date Cleared"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
    End Sub

#End Region


    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterSelectedTab()
    End Sub

    Private Sub RequestForPaymentApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestForPaymentApprovalToolStripMenuItem.Click
        Dim PayableNo As String = ""
        If TabControl1.SelectedTab Is tabPending Then
            If DataGridView_Pending.Item("Status", DataGridView_Pending.CurrentRow.Index).Value().ToString() <> "Approved" And DataGridView_Pending.Item("Status", DataGridView_Pending.CurrentRow.Index).Value().ToString() <> "Cleared" Then
                MessageBox.Show("Only appproved accounts payable can be print", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            PayableNo = DataGridView_Pending.Item("Payable No.", DataGridView_Pending.CurrentRow.Index).Value().ToString()
        Else
            If MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString() <> "Approved" And MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString() <> "Cleared" Then
                MessageBox.Show("Only appproved accounts payable can be print", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            PayableNo = MyDataGridView.Item("Payable No.", MyDataGridView.CurrentRow.Index).Value().ToString()
        End If

        RecordApprovingHistory("payable", PayableNo, PayableNo, "Printed", "Printing Payable#" & PayableNo)

        Dim report As New rptAccountsPayable()
        report.XrBarCode1.Text = PayableNo

        com.CommandText = "Select *,(select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as office, date_format(voucherdate,'%M %d %Y') as 'Date', " _
            + " (select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid) as 'Supplier' from tbldisbursementvoucher where voucherno='" & PayableNo & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtOfficename.Text = rst("office").ToString
            report.payableno.Text = rst("voucherno").ToString
            'report.txtRequisitionNo.Text = rst("requestref").ToString
            report.txtNote.Text = rst("note").ToString
            report.txtVendorSuplier.Text = rst("Supplier").ToString
            report.txtAmount.Text = FormatNumber(Val(rst("amount").ToString), 2)
            report.txtDate.Text = rst("Date").ToString
        End While
        rst.Close()

        LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', (select SUBSTRING_INDEX(requestref,'-',-1) from tblpurchaseorder where ponumber=tbldisbursementdetails.ponumber) as 'PR No.', ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', invoiceno as 'Invoice No.', Amount,Note from tbldisbursementdetails where voucherno='" & PayableNo & "' order by datetrn asc", "tbldisbursementdetails", Em_Voucher, GridView_Voucher)

        XgridHideColumn({"id"}, GridView_Voucher)
        XgridColAlign({"PO Number", "PR No.", "Payable Type", "Date", "Invoice No."}, GridView_Voucher, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView_Voucher)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_Voucher)
        XgridGroupSummaryCurrency({"Amount"}, GridView_Voucher)
        'XgridColWidth({"Amount"}, GridView_Voucher, 100)
        'XgridColWidth({"Note"}, GridView_Voucher, 300)
        GridView_Voucher.PaintStyleName = "web"
        report.PaperKind = System.Drawing.Printing.PaperKind.Letter
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Em_Voucher))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        If TabControl1.SelectedTab Is tabPending Then
            frmForApproval_AccountsPayable.mode.Text = "view"
            frmForApproval_AccountsPayable.voucherno.Text = DataGridView_Pending.Item("Payable No.", DataGridView_Pending.CurrentRow.Index).Value().ToString()
            frmForApproval_AccountsPayable.Show(Me)

        ElseIf TabControl1.SelectedTab Is tabCleared Then
            frmForApproval_AccountsPayable.mode.Text = "view"
            frmForApproval_AccountsPayable.voucherno.Text = MyDataGridView.Item("Payable No.", MyDataGridView.CurrentRow.Index).Value().ToString()
            frmForApproval_AccountsPayable.Show(Me)

        End If


    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdCreatePayment.Click
        frmAPPaymentRequest.Show(Me)
    End Sub

    Private Sub RevisedPayableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRevise.Click
        If DataGridView_Pending.Item("Status", DataGridView_Pending.CurrentRow.Index).Value().ToString() <> "Hold" Then
            MessageBox.Show("Only hold accounts payable can be revise", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmAPPaymentRequest.mode.Text = "edit"
        frmAPPaymentRequest.txtVoucherNo.Text = DataGridView_Pending.Item("Payable No.", DataGridView_Pending.CurrentRow.Index).Value().ToString()
        frmAPPaymentRequest.Show(Me)
    End Sub
End Class