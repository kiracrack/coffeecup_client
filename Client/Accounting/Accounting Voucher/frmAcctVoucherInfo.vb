Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraReports.UI

Public Class frmAcctVoucherInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAPPaymentRequest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
     
    Private Sub frmVoucherPaymentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtVoucherDate.EditValue = CDate(Now)
        txtCheckDate.EditValue = CDate(Now)
        If mode.Text = "edit" Then
            LoadSupplier()
            ShowPayableInfo()
            DisableControls(False)
        ElseIf mode.Text = "view" Then
            LoadSupplier()
            ShowPayableInfo()
            DisableControls(True)
        Else
            LoadSupplier()
            DisableControls(False)
        End If
        LoadOffice()
        LoadVoucherExpenses()
        LoadAccountingEntries()
    End Sub


    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where deleted=0  order by officename asc", "tblcompoffice", txtOffice, gv_Office)
        gv_Office.Columns("officeid").Visible = False
    End Sub

    Public Sub DisableControls(ByVal readonlyForm As Boolean)
        radVoucherType.ReadOnly = readonlyForm
        txtVoucherDate.ReadOnly = readonlyForm
        txtOffice.ReadOnly = readonlyForm
        txtSupplier.ReadOnly = readonlyForm
        txtNote.ReadOnly = readonlyForm
        txtCheckNumber.ReadOnly = readonlyForm
        txtCheckAmount.ReadOnly = readonlyForm
        txtCheckDate.ReadOnly = readonlyForm
        If readonlyForm = True Then
            cmdSave.Visible = False
            cmdAddPayableItem.Visible = False
            Em.ContextMenuStrip = Nothing
            Em_Journal.ContextMenuStrip = Nothing
        Else
            cmdSave.Visible = True
            cmdAddPayableItem.Visible = True
            Em.ContextMenuStrip = gridmenustrip
            Em_Journal.ContextMenuStrip = contextJournal
        End If
    End Sub

    Public Sub ShowPayableInfo()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tbldisbursementvoucher where voucherno='" & txtVoucherNo.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtTmpVoucherNo.Text = .Rows(cnt)("voucherno").ToString
                radVoucherType.EditValue = .Rows(cnt)("itemcode").ToString
                txtOffice.EditValue = .Rows(cnt)("officeid").ToString
                txtSupplier.EditValue = .Rows(cnt)("vendorid").ToString()
                txtNote.Text = .Rows(cnt)("note").ToString()
                txtCheckNumber.Text = .Rows(cnt)("checkno").ToString()
                txtCheckDate.EditValue = .Rows(cnt)("checkdate").ToString()
                txtCheckAmount.Text = .Rows(cnt)("checkamount").ToString()
            End With
        Next
    End Sub
    Public Sub ClearFIelds()
        txtTmpVoucherNo.Text = "SYSTEM GENERATED"
        radVoucherType.EditValue = "check"
        txtSupplier.EditValue = Nothing
        txtOffice.EditValue = Nothing
        txtCheckNumber.Text = ""
        txtCheckAmount.Text = "0"
        txtNote.Text = ""
        txtVoucherNo.Text = ""
        mode.Text = ""
        LoadVoucherExpenses()
        LoadAccountingEntries()
    End Sub
 
    Public Sub LoadSupplier()
        LoadXgridLookupSearch("select vendorid, companyname as 'Supplier' from tblglobalvendor where deleted=0 order by companyname asc", "tblglobalvendor", txtSupplier, gridVendorAccount)
        gridVendorAccount.Columns("vendorid").Visible = False
    End Sub
 
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadVoucherExpenses()
    End Sub

    Public Sub LoadVoucherExpenses()
        LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', Description, invoiceno as 'Invoice No.', Amount,Note from tbldisbursementdetails where voucherno='" & If(txtVoucherNo.Text = "", globaluserid & "-temp", txtVoucherNo.Text) & "' order by datetrn asc", "tbldisbursementdetails", Em, GridView1)

        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"PO Number", "Payable Type", "Date", "Invoice No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount"}, GridView1)
        'XgridColWidth({"Description"}, GridView1, 200)
        XgridColWidth({"Amount"}, GridView1, 100)

        If GridView1.RowCount > 0 Then
            txtSupplier.ReadOnly = True
        Else
            txtSupplier.ReadOnly = False
        End If

        LoadAccountingEntries()
    End Sub


    Public Sub LoadAccountingEntries()
        LoadXgrid("select id, itemname as 'Item Name', Debitamount as Debit, Creditamount as Credit, Remarks  from tblgljournalitems where ticketno='" & If(txtVoucherNo.Text = "", globaluserid & "-temp", txtVoucherNo.Text) & "'", "tblgljournalitems", Em_Journal, GridView_Journal)
        XgridHideColumn({"id"}, GridView_Journal)
        XgridColCurrency({"Debit", "Credit"}, GridView_Journal)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView_Journal)
        XgridColWidth({"Debit", "Credit"}, GridView_Journal, 100)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdAddPayableItem.Click
        If txtSupplier.Text = "" Then
            MessageBox.Show("Please select supplier!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSupplier.Focus()
            Exit Sub
        End If
        frmAcctVoucherDetails.suppliername.Text = txtSupplier.Text
        frmAcctVoucherDetails.voucherno.Text = txtVoucherNo.Text
        frmAcctVoucherDetails.supplierid.Text = txtSupplier.EditValue
        frmAcctVoucherDetails.ShowDialog(Me)
    End Sub


    Private Sub ViewPurchaseOrderProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmPurchaseOrderView.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        If frmPurchaseOrderView.Visible = True Then
            frmPurchaseOrderView.Focus()
        Else
            frmPurchaseOrderView.Show(Me)
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tbldisbursementdetails where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadVoucherExpenses()
        End If
    End Sub

    Private Sub AddPayableItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPayableItemToolStripMenuItem.Click
        cmdAddPayableItem.PerformClick()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtOffice.Text = "" Then
            MessageBox.Show("please select office!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtVoucherDate.Text = "" Then
            MessageBox.Show("please select voucher date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVoucherDate.Focus()
            Exit Sub
        ElseIf txtSupplier.Text = "" Then
            MessageBox.Show("please select claimant!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSupplier.Focus()
            Exit Sub
        ElseIf txtNote.Text = "" Then
            MessageBox.Show("please enter note!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNote.Focus()
            Exit Sub
        ElseIf txtCheckNumber.Text = "" And radVoucherType.EditValue = "check" Then
            MessageBox.Show("please enter check number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckNumber.Focus()
            Exit Sub
        ElseIf txtCheckDate.Text = "" And radVoucherType.EditValue = "check" Then
            MessageBox.Show("please enter check date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckDate.Focus()
            Exit Sub
        ElseIf Val(txtCheckAmount.EditValue) = 0 And radVoucherType.EditValue = "check" Then
            MessageBox.Show("please enter check amount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckAmount.Focus()
            Exit Sub
        ElseIf GridView1.RowCount = 0 Then
            MessageBox.Show("please enter atleast one payable transaction!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckAmount.Focus()
            Exit Sub

        ElseIf GridView_Journal.RowCount = 0 Then
            MessageBox.Show("please enter accounting entries!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            XtraTabControl2.SelectedTabPageIndex = 1
            Exit Sub

        ElseIf Val(CC(GridView_Journal.Columns("Debit").SummaryText)) <> Val(CC(GridView_Journal.Columns("Credit").SummaryText)) Then
            MessageBox.Show("Accounting entries did not match the debit and credit amount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            XtraTabControl2.SelectedTabPageIndex = 1
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tbldisbursementvoucher set voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "', companyid='" & GlobalCompanyid & "', officeid='" & txtOffice.EditValue & "',itemcode='" & radVoucherType.EditValue & "', vendorid='" & txtSupplier.EditValue & "', " & If(radVoucherType.EditValue = "check", "`check`=1,cash=0,checkno='" & txtCheckNumber.Text & "', checkdate='" & ConvertDate(txtCheckDate.EditValue) & "',checkamount='" & txtCheckAmount.EditValue & "', ", "cash=1,`check`=0,checkno='', checkdate=null,checkamount=0, ") & " amount='" & Val(CC(GridView1.Columns("Amount").SummaryText)) & "',sourcefund='', note='" & rchar(txtNote.Text) & "', hold=0, corporatelevel=0, datetrn=current_timestamp, trnby='" & globaluserid & "' where voucherno='" & txtVoucherNo.Text & "'" : com.ExecuteNonQuery()
                ClearFIelds()
                frmAcctVoucherList.FilterSelectedTab()
                MessageBox.Show("Voucher successfully posted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim voucherno As String = ""
                If radVoucherType.EditValue = "check" Then
                    voucherno = "CK-" & getAccountingVoucherSequence("check")
                Else
                    voucherno = "CH-" & getAccountingVoucherSequence("cash")
                End If
                com.CommandText = "update tblgljournalitems set ticketno='" & voucherno & "' where ticketno='" & globaluserid & "-temp'" : com.ExecuteNonQuery()
                com.CommandText = "update tbldisbursementdetails set voucherno='" & voucherno & "' where voucherno='" & globaluserid & "-temp'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbldisbursementvoucher set voucherno='" & voucherno & "',voucherdate='" & ConvertDate(txtVoucherDate.EditValue) & "', companyid='" & GlobalCompanyid & "', officeid='" & txtOffice.EditValue & "',itemcode='" & radVoucherType.EditValue & "', vendorid='" & txtSupplier.EditValue & "', " & If(radVoucherType.EditValue = "check", "`check`=1,cash=0,checkno='" & txtCheckNumber.Text & "', checkdate='" & ConvertDate(txtCheckDate.EditValue) & "',checkamount='" & txtCheckAmount.EditValue & "', ", "cash=1,`check`=0,checkno='', checkdate=null,checkamount=0,") & " amount='" & Val(CC(GridView1.Columns("Amount").SummaryText)) & "',sourcefund='', note='" & rchar(txtNote.Text) & "', corporatelevel=0, datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                frmAcctVoucherList.FilterSelectedTab()
                MessageBox.Show("Voucher successfully posted and subject for clearing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If txtVoucherNo.Text = "" Then
                    PrintAccountingDisbursementVoucher(voucherno, Me)
                End If
                ClearFIelds()
            End If
        End If
    End Sub
    
    Private Sub radVoucherType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radVoucherType.SelectedIndexChanged
        If radVoucherType.EditValue = "check" Then
            XtraTabControl1.Visible = True
        Else
            XtraTabControl1.Visible = False
        End If
    End Sub

    Private Sub cmdCheckPrint_Click(sender As Object, e As EventArgs) Handles cmdCheckPrint.Click
        Dim report As New rptCheckPrint()
        report.txtCheckPayee.Text = "*** " & txtSupplier.Text & " ***"
        report.txtCheckDate.Text = "*** " & CDate(txtCheckDate.EditValue).ToString("MMMM dd, yyyy") & " ***"
        report.txtNumberInWords.Text = "*** " & NumToWords(Val(CC(txtCheckAmount.Text))) & " ***"
        report.txtCheckAmount.Text = "*** " & txtCheckAmount.Text & " ***"
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmGLJournalDetails.txtTicketNo.Text = txtVoucherNo.Text
        frmGLJournalDetails.ShowDialog(Me)
    End Sub

    Private Sub EditSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedItemToolStripMenuItem.Click
        frmGLJournalDetails.mode.Text = "edit"
        frmGLJournalDetails.id.Text = GridView_Journal.GetFocusedRowCellValue("id").ToString()
        frmGLJournalDetails.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView_Journal.SelectedRowsCount - 1
                com.CommandText = "DELETE from tblgljournalitems where id='" & GridView_Journal.GetRowCellValue(GridView_Journal.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadAccountingEntries()
            MessageBox.Show("Selected item successfully removed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        LoadAccountingEntries()
    End Sub

    Private Sub EditPayableItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPayableItemToolStripMenuItem.Click
        frmAcctVoucherDetails.mode.Text = "edit"
        frmAcctVoucherDetails.trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString()
        frmAcctVoucherDetails.ShowDialog(Me)
    End Sub

    Private Sub cmdPrintVoucher_Click(sender As Object, e As EventArgs) Handles cmdPrintVoucher.Click
        If txtVoucherNo.Text = "" Then
            XtraMessageBox.Show("Please Save voucher before print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        PrintAccountingDisbursementVoucher(txtVoucherNo.Text, Me)
    End Sub
End Class