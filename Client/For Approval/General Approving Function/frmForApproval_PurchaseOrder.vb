Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmForApproval_PurchaseOrder
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
 
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loaddetails(ponumber.Text)
        ShowParticularsItems()
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

    Public Function loaddetails(ByVal id As String)
        com.CommandText = "select  *, (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid ) as 'office', " _
                                 + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                                 + " ifnull((select requestby from tblrequisitions where pid = tblpurchaseorder.requestref),createby) as 'requestby', " _
                                  + " (select custombranchapproval from tblcompoffice where officeid=tblpurchaseorder.officeid) as custom, " _
                                 + " (select sum(total) from tblpurchaseorderitem where ponumber=tblpurchaseorder.ponumber) as 'Total', " _
                                 + PurchaseOrderStatus _
                                 + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where (refnumber = tblpurchaseorder.ponumber or refnumber = tblpurchaseorder.requestref)),'-') as 'Attachment'  " _
                                 + " from tblpurchaseorder where ponumber='" & id & "'"
        rst = com.ExecuteReader
        While rst.Read
            pid.Text = rst("requestref").ToString
            officeid.Text = rst("officeid").ToString
            txtoffice.Text = rst("office").ToString
            txtdatereq.Text = rst("datetrn").ToString
            txtNote.Text = rst("note").ToString
            requestby.Text = rst("requestby").ToString
            txtTotalAmount.Text = FormatNumber(Val(rst("Total").ToString), 2)
            txtSupplier.Text = rst("Supplier").ToString
            txtStatus.Text = rst("Status").ToString
            If globalCorporateApprover = True Then
                ckCustom.Checked = False
            Else
                ckCustom.Checked = rst("custom")
            End If
            If rst("Attachment").ToString = "-" Then
                cmdAttachment.Enabled = False
                cmdAttachment.Text = "Not Availaible"
            Else
                cmdAttachment.Enabled = True
                cmdAttachment.Text = rst("Attachment").ToString
            End If
            ckCorporate.Checked = rst("corporatelevel")
        End While
        rst.Close()
        txtRequestby.Text = qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & requestby.Text & "'")
        If countqry(If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess"), "apptype='purchase-order-signatories' and " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and finalapp=1") > 0 Then
            ckFinalApprover.Checked = True
        Else
            ckFinalApprover.Checked = False
        End If

        TextBoxColorCode(txtStatus)
        Return 0
    End Function
   
    Public Sub ShowParticularsItems()
        MyDataGridView_Particular.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select itemname as 'Particular', " _
                                + " (select description from tblprocategory where CATID = tblpurchaseorderitem.catid ) as 'Category', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks " _
                                + " from tblpurchaseorderitem " _
                                + " where ponumber='" & ponumber.Text & "'", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Particular.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_Particular, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Particular, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_Particular, {"Cost", "Total"})

        If MyDataGridView_Particular.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView_Particular.RowCount - 1
                totalsum = totalsum + MyDataGridView_Particular.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).Cells("Cost").Value = "Total"
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).Cells("Total").Value = totalsum
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
        filterApprovalLogs(False, {ponumber.Text, pid.Text}, "", MyDataGridView_Approval)
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
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                      + " SELECT 'purchase-order','purchase order','" & ponumber.Text & "','approved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where  " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='purchase-order-signatories' " & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") : com.ExecuteNonQuery()
            com.CommandText = "update tblpurchaseorder set verifiedby='" & globaluserid & "',verified=" & ckFinalApprover.CheckState & ", dateverified=current_timestamp,verifiedby='" & globaluserid & "' where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()

            If ckFinalApprover.Checked = True Then
                InsertEmailNotification("purchase-order", getEmailAccount(requestby.Text), "PURCHASE ORDER APPROVED (" & ponumber.Text & ") ", FormatingEmailPurchaseOrder(ponumber.Text), txtRemarks.Text)
            Else
                NextEmailPurchaseOrderApprover(ponumber.Text, ckCorporate.CheckState, txtRemarks.Text)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdDisapproved.Click
        If txtRemarks.Text = "" Or txtRemarks.Text = "Please enter message" Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to disapprove this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                         + " SELECT 'purchase-order','purchase order','" & ponumber.Text & "','cancelled','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='purchase-order-signatories'" & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") : com.ExecuteNonQuery()
            com.CommandText = "update tblpurchaseorder set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp  where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            InsertEmailNotification("purchase-order", getEmailAccount(requestby.Text), "PURCHASE ORDER DISAPPROVED (" & ponumber.Text & ") ", FormatingEmailPurchaseOrder(ponumber.Text), txtRemarks.Text)
            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
            MessageBox.Show("Request successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        ViewAttachmentPackage_Database({pid.Text}, "")
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        PrintDatagridview("Requisition Approval History<br/><strong>" & pid.Text & "</strong>", "Requisition Approval History", "Office: " & txtoffice.Text & "<br/>Requested By: " & txtRequestby.Text & "<br/>Total Amount: " & txtTotalAmount.Text, MyDataGridView_Approval, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filterApprovalLogs(False, {pid.Text, ponumber.Text}, "", MyDataGridView_Approval)
    End Sub
End Class