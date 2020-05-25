Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmForApproval_DisbursementVoucher
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApproval_AccountsPayable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub
    Private Sub voucherno_TextChanged(sender As Object, e As EventArgs) Handles voucherno.TextChanged
        loaddetails()
        ShowExpenseEntries()
        filterOtherExpense()
        ShowParticularsItems()
        If mode.Text = "view" Then
            XtraTabControl1.Size = New Size(729, 481)
            cmdHold.Visible = False
            cmdApproved.Visible = False
        Else
            XtraTabControl1.Size = New Size(729, 390)
            cmdHold.Visible = True
            cmdApproved.Visible = True
        End If
    End Sub
    Public Function loaddetails()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid=a.officeid) as office, " _
            + " (select fullname from tblaccounts where accountid = a.trnby) as 'requestby', " _
            + " (select designation from tblaccounts where accountid = a.trnby) as 'position', " _
             + " (select custombranchapproval from tblcompoffice where officeid=a.officeid) as custom, " _
             + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber in (select ponumber from tblpurchaseorder where paymentrefnumber=a.voucherno)),'-') as 'Attachment',  " _
            + " if(ca=1,(select fullname from tblaccounts where accountid=a.vendorid),(select companyname from tblglobalvendor where vendorid=a.vendorid)) as payto from tbldisbursementvoucher as a where voucherno='" & voucherno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            If CBool(rst("directexpense")) = True Then
                tabRequestDescription.PageVisible = False
                tabItemRequested.PageVisible = False
            Else
                tabRequestDescription.PageVisible = True
                tabItemRequested.PageVisible = True
            End If
            If CBool(rst("check")) = True Then
                txtClasification.Text = "CHECK PAYMENT"
            ElseIf CBool(rst("cash")) = True Then
                txtClasification.Text = "CASH PAYMENT"
            ElseIf CBool(rst("ca")) = True Then
                txtClasification.Text = "CASH ADVANCE"
            End If
            ckCustom.Checked = rst("custom")
            vendorid.Text = rst("payto").ToString
            requestby.Text = rst("trnby").ToString
            officeid.Text = rst("officeid").ToString
            txtoffice.Text = rst("office").ToString
            txtRequestby.Text = rst("requestby").ToString
            txtDesignation.Text = rst("position").ToString
            txtdatereq.Text = rst("datetrn").ToString
            txtSupplier.Text = rst("payto").ToString
            vendorid.Text = rst("payto").ToString
            txtTotalAmount.Text = FormatNumber(rst("amount"), 2)
            txtNote.Text = rst("note").ToString
            If CBool(rst("verified")) = True Then
                txtStatus.Text = "APPROVED"
            Else
                txtStatus.Text = "PENDING"
            End If

            If rst("Attachment").ToString <> "-" Then
                cmdAttachment.Enabled = True
                cmdAttachment.Text = rst("Attachment").ToString
            Else
                cmdAttachment.Enabled = False
                cmdAttachment.Text = "Not Availaible"
            End If
            ckCorporate.Checked = CBool(rst("corporatelevel"))
        End While
        rst.Close()
        TextBoxColorCode(txtStatus)

        If countqry(If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess"), "apptype='voucher-signatories' and " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and finalapp=1") > 0 Then
            ckFinalApprover.Checked = True
        Else
            ckFinalApprover.Checked = False
        End If
        Return 0
    End Function

    Public Sub ShowExpenseEntries()
        If txtClasification.Text = "CASH ADVANCE" Then
            LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', Supplier, Amount, Note from tbldisbursementdetails where voucherno='" & voucherno.Text & "' order by datetrn asc", "tbldisbursementdetails", Em_Voucher, GridView_Voucher)
        Else
            LoadXgrid("select id,date_format(datetrn,'%Y-%m-%d') as 'Date', ponumber as 'PO Number', if(forpo=1,'Purchase Order','Payment Request') as 'Description', invoiceno as 'Invoice No.', Amount,Note from tbldisbursementdetails where voucherno='" & voucherno.Text & "' order by datetrn asc", "tbldisbursementdetails", Em_Voucher, GridView_Voucher)
        End If

        XgridHideColumn({"id"}, GridView_Voucher)
        XgridColAlign({"PO Number", "Payable Type", "Date", "Invoice No."}, GridView_Voucher, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView_Voucher)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_Voucher)
        XgridGroupSummaryCurrency({"Amount"}, GridView_Voucher)
        XgridColWidth({"Amount"}, GridView_Voucher, 100)
        XgridColWidth({"Note"}, GridView_Voucher, 300)
    End Sub


    Public Sub ShowParticularsItems()
        LoadXgrid("SELECT a.ponumber as 'PO Number',(select companyname from tblglobalvendor where vendorid=a.vendorid) as 'Supplier',  itemname 'Particular', Quantity,Unit, Cost, Total, Remarks, a.Delivered, a.datedelivered as 'Date Delivered'  FROM `tblpurchaseorderitem` as a inner join tblpurchaseorder as b on a.ponumber=b.ponumber where b.paymentrefnumber='" & voucherno.Text & "'", "tblpurchaseorderitem", Em, GridView_Summary)

        XgridColCurrency({"Total", "Cost"}, GridView_Summary)
        XgridColAlign({"PO Number", "Quantity", "Unit", "Delivered"}, GridView_Summary, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView_Summary)
        XgridGroupSummaryCurrency({"Total"}, GridView_Summary)
        XgridColWidth({"Cost", "Total"}, GridView_Summary, 120)

        filterApprovalLogsGridview(False, {voucherno.Text}, "voucher", Em_History, gridHistory)
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


    Private Sub txtRemarks_GotFocus(sender As Object, e As EventArgs) Handles txtRemarks.GotFocus
        If txtRemarks.Text = "Please enter message" Then
            txtRemarks.Text = ""
        End If
    End Sub

    Private Sub txtRemarks_LostFocus(sender As Object, e As EventArgs) Handles txtRemarks.LostFocus
        If txtRemarks.Text = "" Then
            txtRemarks.Text = "Please enter message"
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdApproved.Click
        If GlobalStrictApproverSignature = True And qrysingledata("digitalsign", "digitalsign", "tblaccounts where accountid='" & globaluserid & "'").ToString.Length = 0 Then
            MessageBox.Show("Your account has no digital signature! Please contact IT Department and follow instruction below: " & Environment.NewLine & Environment.NewLine & "1. Submit your signature on clean white paper with your fullname" & Environment.NewLine & "2. Scan it and Email to IT Department" & Environment.NewLine & "3. wait for IT confirmation, then you can proceed your approval", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Or txtRemarks.Text = "Please enter message" Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to approve this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                      + " SELECT 'voucher','voucher','" & voucherno.Text & "','" & voucherno.Text & "','approved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='voucher-signatories'" & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") : com.ExecuteNonQuery()

            com.CommandText = "update tbldisbursementvoucher set verifiedby='" & globaluserid & "', verified=ifnull((select if(finalapp=1,true,false) from " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='voucher-signatories' " & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") & "),0),dateverified=current_timestamp where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()

            If ckFinalApprover.Checked = True Then
                InsertEmailNotification("voucher", getEmailAccount(requestby.Text), "Disbursement (" & StrConv(txtClasification.Text, VbStrConv.ProperCase) & ") APPROVED (" & voucherno.Text & ") ", FormatingEmailAccountsPayable(voucherno.Text), txtRemarks.Text)
            Else
                NextEmailAccountPayableApprover(voucherno.Text, officeid.Text, "Disbursement (" & StrConv(txtClasification.Text, VbStrConv.ProperCase) & ")", ckCorporate.CheckState, txtRemarks.Text)
            End If

            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
            MessageBox.Show("Request successfully approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        Dim ponumber(10) As String : Dim cnt As Integer = 0
        com.CommandText = "select * from tblpurchaseorder where paymentrefnumber='" & voucherno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            ponumber(cnt) = rst("ponumber").ToString
            cnt += 1
        End While
        rst.Close()
        If ponumber.Count > 0 Then
            ViewAttachmentPackage_Database(ponumber, "")
        End If
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        DXPrintDatagridview("Disbursement Voucher Approval History", "Disbursement Voucher Approval History", "Office: " & txtoffice.Text & "<br/>Requested By: " & txtRequestby.Text & "<br/>Total Amount: " & txtTotalAmount.Text, gridHistory, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filterApprovalLogsGridview(False, {voucherno.Text}, "voucher", Em_History, gridHistory)
    End Sub

    Private Sub cmdHold_Click(sender As Object, e As EventArgs) Handles cmdHold.Click
        If MessageBox.Show("Are you sure you want to hold this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbldisbursementvoucher set hold=1 where voucherno='" & voucherno.Text & "'" : com.ExecuteNonQuery()
            InsertEmailNotification("voucher", getEmailAccount(requestby.Text), txtClasification.Text & " DISBURSEMENT HOLD (" & voucherno.Text & ") ", FormatingEmailAccountsPayable(voucherno.Text), txtRemarks.Text)
            RecordApprovingHistory("voucher", voucherno.Text, voucherno.Text, "hold", rchar(txtRemarks.Text))
            frmCorpForApprovalList.FilterSelectedTab()
            MessageBox.Show("Request successfully hold!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
        
    End Sub
End Class