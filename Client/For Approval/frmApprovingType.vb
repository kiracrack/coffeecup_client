Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmApprovingType

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdCorporate.Click
        If frmCorpForApprovalList.Visible = False Then
            frmCorpForApprovalList.Show()
        Else
            frmCorpForApprovalList.WindowState = FormWindowState.Normal
        End If
        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdBranch.Click
        If frmBranchForApprovalList.Visible = False Then
            frmBranchForApprovalList.Show()
        Else
            frmBranchForApprovalList.WindowState = FormWindowState.Normal
        End If
        Me.Close()
    End Sub

    Private Sub frmApprovingType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

        Dim forapprovalCorporate As Integer = 0
        If globalCorporateApprover = True Then
            com.CommandText = "call sp_forapproval(true, 'PR'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
            Dim Requisition As Integer = countrecord("tmpforapprovalprview")
            If Requisition > 0 Then
                forapprovalCorporate = Requisition
            End If
        End If

        If forapprovalCorporate > 0 Then
            cmdCorporate.Text = "Corporate Request (" & forapprovalCorporate & ")"
            cmdCorporate.ForeColor = Color.Red
        Else
            cmdCorporate.Text = "Corporate Request"
            cmdCorporate.ForeColor = DefaultForeColor
        End If

        Dim forapprovalBranch As Integer = 0
        If globalBranchApprover = True Or globalapproveanyoffices = True Then
            com.CommandText = "call sp_forapproval(False, 'PR'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
            Dim Requisition As Integer = countrecord("tmpforapprovalprview")
            If Requisition > 0 Then
                forapprovalBranch = Requisition
            End If
        End If

        If forapprovalBranch > 0 Then
            cmdBranch.Text = "Branch Request (" & forapprovalBranch & ")"
            cmdBranch.ForeColor = Color.Red
        Else
            cmdBranch.Text = "Branch Request"
            cmdBranch.ForeColor = DefaultForeColor
        End If

    End Sub
End Class