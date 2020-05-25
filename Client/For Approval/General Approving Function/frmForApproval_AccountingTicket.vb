Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmForApproval_AccountingTicket
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApproval_AccountingTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "view" Then
            TabControl1.Size = New Size(656, 407)
            cmdApproved.Visible = False
            cmdDisapproved.Visible = False
        Else
            TabControl1.Size = New Size(656, 351)
            cmdApproved.Visible = True
            cmdDisapproved.Visible = True
        End If
    End Sub
    Private Sub ticketno_TextChanged(sender As Object, e As EventArgs) Handles ticketno.TextChanged
        loaddetails()
        ShowExpenseEntries()
    End Sub
    Public Function loaddetails()
        com.CommandText = "select *, (select officename from tblcompoffice where officeid=tblgljournal.officeid) as office, " _
            + " (select fullname from tblaccounts where accountid = tblgljournal.trnby) as 'requestby', " _
            + " (select designation from tblaccounts where accountid = tblgljournal.trnby) as 'position' " _
             + " from tblgljournal where ticketno='" & ticketno.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtoffice.Text = rst("office").ToString
            txtRequestby.Text = rst("requestby").ToString
            txtDesignation.Text = rst("position").ToString
            txtdatereq.Text = rst("datetrn").ToString
            txtTotalAmount.Text = FormatNumber(rst("amount"), 2)
            txtNote.Text = rst("remarks").ToString
            If CBool(rst("verified")) = True Then
                txtStatus.Text = "APPROVED"
            Else
                txtStatus.Text = "FOR APPROVAL"
            End If
 
            ckCorporate.Checked = CBool(rst("corporatelevel"))
        End While
        rst.Close()
        TextBoxColorCode(txtStatus)

        If countqry(If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess"), "apptype='accounting-tickets' and " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and finalapp=1") > 0 Then
            ckFinalApprover.Checked = True
        Else
            ckFinalApprover.Checked = False
        End If
        Return 0
    End Function

    Public Sub ShowExpenseEntries()
        MyDataGridView_voucher.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select (select itemname from tblglitem where itemcode=tblglticket.itemcode) as 'Item Name', Debit,Credit,Remarks  from tblglticket where ticketno='" & ticketno.Text & "' union all " _
                                    + " select  '',sum(Debit),sum(Credit),'' from tblglticket where ticketno='" & ticketno.Text & "' ", conn)

        msda.Fill(dst, 0)
        MyDataGridView_voucher.DataSource = dst.Tables(0)
        MyDataGridView_voucher.Columns("Item Name").Width = 150
        MyDataGridView_voucher.Columns("Remarks").Width = 250
        GridColumnAlignment(MyDataGridView_voucher, {"Debit", "Credit"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_voucher, {"Debit", "Credit"})
        If MyDataGridView_voucher.RowCount - 1 > 0 Then
            MyDataGridView_voucher.Rows(MyDataGridView_voucher.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView_voucher.Rows(MyDataGridView_voucher.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
        For i = 0 To MyDataGridView_voucher.Columns.Count - 1
            MyDataGridView_voucher.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        filterApprovalLogs(False, {ticketno.Text}, "", MyDataGridView_Approval)
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
            Dim gltoken As String = CreateGLTicketToken(ticketno.Text, globaluserid)
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                      + " SELECT 'accounting-tickets','accounting ticket','" & ticketno.Text & "','" & ticketno.Text & "','approved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='accounting-tickets'" : com.ExecuteNonQuery()

            com.CommandText = "update tblgljournal set gltoken='" & gltoken & "',dateverified=current_timestamp, verifiedby='" & globaluserid & "', verified=ifnull((select if(finalapp=1,true,false) from " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='accounting-tickets'),0),dateverified=current_timestamp where ticketno='" & ticketno.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblglticket set gltoken='" & gltoken & "',cleared=1,datecleared=current_timestamp,clearedby='" & globalfullname & "' where ticketno='" & ticketno.Text & "'" : com.ExecuteNonQuery()

            'If ckFinalApprover.Checked = True Then
            '    InsertEmailNotification("accounts-payable", getEmailAccount(requestby.Text), "ACCOUNTS PAYABLE APPROVED (" & ticketno.Text & ") ", FormatingEmailAccountsPayable(ticketno.Text), txtRemarks.Text)
            'Else
            '    NextEmailAccountPayableApprover(ticketno.Text, officeid.Text, ckCorporate.CheckState, txtRemarks.Text)
            'End If

            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
            MessageBox.Show("Request successfully approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs)
        ViewAttachmentPackage_Database({ticketno.Text}, "")
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        PrintDatagridview("Accounting Ticket Approval History<br/>" & "Ticket #: " & ticketno.Text, "Requisition Approval History", "Office: " & txtoffice.Text & "<br/>Requested By: " & txtRequestby.Text & "<br/>Total Amount: " & txtTotalAmount.Text, MyDataGridView_Approval, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filterApprovalLogs(False, {ticketno.Text}, "", MyDataGridView_Approval)
    End Sub

     
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdDisapproved.Click
        If txtRemarks.Text = "" Or txtRemarks.Text = "Please enter message" Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to disapprove this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                         + " SELECT 'accounting-tickets','purchase order','" & ticketno.Text & "','cancelled','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='accounting-tickets'" : com.ExecuteNonQuery()
            com.CommandText = "update tblgljournal set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp  where ticketno='" & ticketno.Text & "'" : com.ExecuteNonQuery()
            'InsertEmailNotification("purchase-order", getEmailAccount(requestby.Text), "PURCHASE ORDER DISAPPROVED (" & ponumber.Text & ") ", FormatingEmailPurchaseOrder(ticketno.Text), txtRemarks.Text)
            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
            MessageBox.Show("Request successfully disapproved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class