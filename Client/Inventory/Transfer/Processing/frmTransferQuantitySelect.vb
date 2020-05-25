Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmTransferQuantitySelect
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmTransferQuantitySelect_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmTransferQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtquan.Select(0, txtquan.Text.Length)

    End Sub
   
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If Val(CC(txtquan.Text)) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        ElseIf (mode.Text = "direct" Or mode.Text = "process") And Val(CC(txtquan.Text)) > Val(CC(txtavailable.Text)) Then
            MessageBox.Show("Available quantity is only " & txtavailable.Text & "!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquan.Focus()
            Exit Sub
        ElseIf mode.Text <> "process" And countqry("tbltransferrequestitem", "itemid='" & productid.Text & "' and trnby='" & globaluserid & "' and processed=-1") > 0 Then
            MessageBox.Show("Item is already exists on batch list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquan.Focus()
            Exit Sub
        End If
        If mode.Text = "process" Then
            com.CommandText = "insert into tbltransferrequestitem set reqcode='" & batchcode.Text & "', itemid='" & productid.Text & "', quantity='" & txtquan.Value & "', unit='" & txtunit.Text & "', remarks='" & rchar(txtdetails.Text) & "', trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            'ElseIf mode.Text = "request" Or mode.Text = "direct" Then
        Else
            com.CommandText = "insert into tbltransferrequestitem set reqcode='" & batchcode.Text & "', itemid='" & productid.Text & "', quantity='" & txtquan.Value & "', unit='" & txtunit.Text & "', remarks='" & rchar(txtdetails.Text) & "', trnby='" & globaluserid & "', datetrn=current_timestamp,processed=-1" : com.ExecuteNonQuery()
        End If

        If frmTransferDirectNewInventory.Visible = True Then
            frmTransferDirectNewInventory.loadTempParticular()
        End If
        If frmTransferRequestNew.Visible = True Then
            frmTransferRequestNew.loadTempParticular()
        End If
        If frmTransferRequestReview.Visible = True Then
            frmTransferRequestReview.FilterDetails()
        End If
        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub
End Class