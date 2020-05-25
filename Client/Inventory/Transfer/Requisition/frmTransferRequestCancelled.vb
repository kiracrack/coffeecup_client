Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmTransferRequestCancelled
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue cancel this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbltransferrequest set cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "',cancelledremarks='" & rchar(txtdetails.Text) & "' where reqcode='" & Batchcode.Text & "'" : com.ExecuteNonQuery()
            frmTransferRequisition.tabColumnOption()
            MessageBox.Show("Request successfully cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If frmTransferRequestReview.Visible = True Then
                frmTransferRequestReview.Close()
            End If
            Me.Close()
        End If
    End Sub
End Class