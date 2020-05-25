Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmForApproval_StockTransfer
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApproval_StockTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loaddetails(batchcode.Text)
        ShowParticularsItems()

    End Sub

    Public Function loaddetails(ByVal id As String)
        com.CommandText = "Select *, (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_to) as 'office', " _
                      + " (select fullname from tblaccounts where accountid = tbltransferrequest.requestby) as 'RequestBy'  from tbltransferrequest where reqcode='" & id & "'" : rst = com.ExecuteReader
        While rst.Read
            inventory_from.Text = rst("inventory_from").ToString
            txtoffice.Text = rst("office").ToString
            txtdatereq.Text = rst("daterequest").ToString
            txtNote.Text = rst("Message").ToString
            txtRequestby.Text = rst("RequestBy").ToString
        End While
        rst.Close()
        Return 0
    End Function

    Public Sub ShowParticularsItems()
        MyDataGridView_Particular.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) as 'Particular', " _
                         + " Quantity as 'Requested Quantity', Unit, " _
                         + " Remarks, " _
                         + " ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and quantity>0 and officeid = '" & inventory_from.Text & "'),0) as 'Available Inventory', " _
                         + " if(ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and quantity>0 and officeid = '" & inventory_from.Text & "'),0) < Quantity, 'Inventory out of stock','Available') as 'Status' " _
                         + " from tbltransferrequestitem  where processed=0 and reqcode = '" & batchcode.Text & "'" _
                         + " order by datetrn asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Particular.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_Particular, {"Requested Quantity", "Available Inventory", "Unit"}, DataGridViewContentAlignment.MiddleCenter)

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
                      + " SELECT 'stock-transfer-signatories','stock transfer','" & batchcode.Text & "','" & batchcode.Text & "','approved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='stock-transfer-signatories'" : com.ExecuteNonQuery()
            com.CommandText = "update tbltransferrequest set clearedby='" & globaluserid & "',cleared=(select if(finalapp=1,true,false) from tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='stock-transfer-signatories'), datecleared=current_timestamp where reqcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()


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
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                         + " SELECT 'stock-transfer-signatories','stock transfer','" & batchcode.Text & "','" & batchcode.Text & "','cancelled','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='stock-transfer-signatories'" : com.ExecuteNonQuery()
            com.CommandText = "update tbltransferrequest set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp  where reqcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()

            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
            MessageBox.Show("Request successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
 
End Class