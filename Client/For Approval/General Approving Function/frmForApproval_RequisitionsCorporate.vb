Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmForApproval_RequisitionsCorporate
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loaddetails(pid.Text)
        ShowParticularsItems()
    End Sub

    Public Function loaddetails(ByVal id As String)
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as 'office', " _
                                 + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST', " _
                                 + " (select DESCRIPTION from tblrequesttype where POTYPEID = tblrequisitions.POTYPEID) as 'POTYPE', " _
                                 + " (select designation from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'DESIGNATION', " _
                                 + " if(corporatelevel=1,'CORPORATE','BRANCH') as applevel," _
                                 + " (select customcorporateapproval from tblcompoffice where officeid =tblrequisitions.officeid) as custom, " _
                                 + RequisitionCorporateStatus _
                                 + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblrequisitions.pid),'-') as 'Attachment' " _
                                 + " from tblrequisitions where PID='" & id & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtoffice.Text = rst("office").ToString
            requestby.Text = rst("REQUESTBY").ToString
            txtRequestby.Text = rst("REQUEST").ToString
            txtDesignation.Text = rst("DESIGNATION").ToString
            txtdatereq.Text = rst("DATEREQUEST").ToString
            txtdetails.Text = rst("DETAILS").ToString
            txtpotype.Text = rst("POTYPE").ToString
            txtDisbursement.Text = rst("applevel").ToString
            txtDateNeeded.Text = rst("dateneeded").ToString
            txtStatus.Text = rst("Status").ToString

            potypeid.Text = rst("potypeid").ToString
            ckCustom.Checked = rst("custom")
            officeid.Text = rst("officeid").ToString

            If rst("Attachment").ToString = "-" Then
                cmdAttachment.Enabled = False
                cmdAttachment.Text = "Not Availaible"
            Else
                cmdAttachment.Enabled = True
                cmdAttachment.Text = rst("Attachment").ToString
            End If
        End While
        rst.Close()
        TextBoxColorCode(txtStatus)
        Return 0
    End Function

    Public Sub ShowParticularsItems()
        MyDataGridView_Particular.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid,productid, (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionsitem.CATID ) as 'Category', " _
                                + " ifnull((select sum(quantity) from tblinventory where quantity>0 and officeid=tblrequisitionsitem.officeid and productid=tblrequisitionsitem.productid),0) as 'Onhand Quantity', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionsitem " _
                                + " where pid='" & pid.Text & "' order by (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Particular.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Particular, {"trnid", "productid"})
        GridCurrencyColumnDecimalCount(MyDataGridView_Particular, {"Onhand Quantity"}, 4)
        GridColumnAlignment(MyDataGridView_Particular, {"Quantity", "Onhand Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
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
        filterApprovalLogs(True, {pid.Text}, "", MyDataGridView_Approval)
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Particular.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Particular.CurrentCell = Me.MyDataGridView_Particular.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdHold.Click
        If txtRemarks.Text = "" Or txtRemarks.Text = "Please enter message" Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to put on hold on this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover,corporateapproval) " _
                       + " SELECT '" & potypeid.Text & "','requisition','" & pid.Text & "','" & pid.Text & "','hold','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp,1 FROM tblapprovermainprocess where authorizedid='" & globaluserid & "' and requestcode='" & potypeid.Text & "' and apptype='requisition-approving-process' " & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") : com.ExecuteNonQuery()

            com.CommandText = "update tblrequisitions set hold=1 where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            InsertEmailNotification("requisition", getEmailAccount(requestby.Text), "REQUISITION HOLD (" & pid.Text & ") ", FormatingEmailRequisition(pid.Text, UCase(txtpotype.Text)), txtRemarks.Text)
            frmCorpForApprovalList.FilterSelectedTab()
            MessageBox.Show("Request successfully on hold!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
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
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover,corporateapproval) " _
                      + " SELECT '" & potypeid.Text & "','requisition','" & pid.Text & "','" & pid.Text & "','approved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp,1 FROM tblapprovermainprocess where authorizedid='" & globaluserid & "' and requestcode='" & potypeid.Text & "' and apptype='requisition-approving-process' " & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") : com.ExecuteNonQuery()

            If CBool(qrysingledata("finalapp", "finalapp", "tblapprovermainprocess where authorizedid='" & globaluserid & "' and requestcode='" & potypeid.Text & "' and apptype='requisition-approving-process' " & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''"))) = True Then
                com.CommandText = "update tblrequisitions set approvedcorporate=true,dateapproved=current_timestamp where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
                InsertEmailNotification("requisition", getEmailAccount(requestby.Text), "REQUISITION APPROVED (" & pid.Text & ") ", FormatingEmailRequisition(pid.Text, UCase(txtpotype.Text)), txtRemarks.Text)
            Else
                NextEmailCorporateLevelRequisitionApprover(pid.Text, txtpotype.Text, txtRemarks.Text)
            End If

            frmCorpForApprovalList.FilterSelectedTab()
            MessageBox.Show("Request successfully Approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdDisapprove.Click
        If txtRemarks.Text = "" Or txtRemarks.Text = "Please enter message" Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to disapprove this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover,corporateapproval) " _
                      + " SELECT '" & potypeid.Text & "','requisition','" & pid.Text & "','" & pid.Text & "','disapproved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp,1 FROM tblapprovermainprocess where authorizedid='" & globaluserid & "' and requestcode='" & potypeid.Text & "' and apptype='requisition-approving-process' " & If(ckCustom.Checked = True, " and officeid='" & officeid.Text & "'", " and officeid=''") : com.ExecuteNonQuery()

            com.CommandText = "update tblrequisitions set disapproved=1,datedisapproved=current_timestamp where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
            InsertEmailNotification("requisition", getEmailAccount(requestby.Text), "REQUISITION DISAPPROVED (" & pid.Text & ") ", FormatingEmailRequisition(pid.Text, UCase(txtpotype.Text)), txtRemarks.Text)

            frmCorpForApprovalList.FilterSelectedTab()
            MessageBox.Show("Request successfully disapproved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        ViewAttachmentPackage_Database({pid.Text}, "")
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        PrintDatagridview("Requisition Approval History<br/><strong>" & pid.Text & "</strong>", "Requisition Approval History", "Office: " & txtoffice.Text & "<br/>Requested By: " & txtRequestby.Text & "<br/>Request Type: " & txtpotype.Text, MyDataGridView_Approval, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filterApprovalLogs(True, {pid.Text}, "", MyDataGridView_Approval)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If MyDataGridView_Particular.Item("productid", MyDataGridView_Particular.CurrentRow.Index).Value().ToString = "" Then
            MessageBox.Show("Please select item!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmViewPreviousPurchase.productid.Text = MyDataGridView_Particular.Item("productid", MyDataGridView_Particular.CurrentRow.Index).Value().ToString
        frmViewPreviousPurchase.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ShowParticularsItems()
    End Sub

    Private Sub cmdChangeAmount_Click(sender As Object, e As EventArgs) Handles cmdChangeAmount.Click
        If MyDataGridView_Particular.Item("trnid", MyDataGridView_Particular.CurrentRow.Index).Value().ToString = "" Then
            MessageBox.Show("Please select item!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRequestChangeAmount.id.Text = MyDataGridView_Particular.Item("trnid", MyDataGridView_Particular.CurrentRow.Index).Value().ToString
        frmRequestChangeAmount.Show(Me)
    End Sub

    Private Sub ChangeSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSupplierToolStripMenuItem.Click
        frmChangeMultipleSupplier.Show(Me)
    End Sub
    Public Sub ChangeSupplier(ByVal vendorid As String)
        For Each rw As DataGridViewRow In MyDataGridView_Particular.SelectedRows
            com.CommandText = "update tblrequisitionsitem set vendorid='" & vendorid & "' where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowParticularsItems()
    End Sub

End Class