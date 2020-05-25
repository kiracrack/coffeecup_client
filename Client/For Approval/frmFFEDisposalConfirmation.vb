Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmFFEDisposalConfirmation

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

     
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtRequestType.Text = "" Then
            MessageBox.Show("Please select your confirmation type!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRequestType.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Or txtRemarks.Text = "Please enter message" Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblapprovalhistory` (approvaltype,appdescription,mainreference,referenceno,status,remarks,apptitle,applevel,confirmid,confirmby,position,dateconfirm,finalapprover) " _
                    + " SELECT 'ffe-for-disposal','disposal request','" & FFECode.Text & "','" & FFECode.Text & "','approved','" & rchar(txtRemarks.Text) & "',apptitle,applevel,'" & globaluserid & "','" & globalfullname & "','" & globalposition & "',current_timestamp,finalapp FROM  " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='ffe-for-disposal'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblinventoryffe set disposalapproved=ifnull((select if(finalapp=1,true,false) from " & If(globalCorporateApprover = True, "tblapprovermainprocess ", "tblapproverclientprocess") & " where " & If(globalCorporateApprover = True, "authorizedid='" & globaluserid & "'", "authcode='" & globalAuthcode & "'") & " and apptype='ffe-for-disposal'),0), disposaldateapproved=current_timestamp where ffecode='" & FFECode.Text & "'" : com.ExecuteNonQuery()
            LogFFEHistory(FFECode.Text, rchar(txtRemarks.Text))
            MessageBox.Show("Disposal successfully confirmed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
            Me.Close()
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
End Class