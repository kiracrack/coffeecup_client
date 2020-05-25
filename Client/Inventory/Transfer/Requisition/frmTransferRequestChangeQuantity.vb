Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmTransferRequestChangeQuantity
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtquan.Select(0, txtquan.Text.Length)
    End Sub

    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Not IsNothing(e.Value) And e.ColumnIndex > 3 Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
            End If
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If CC(txtquan.Text) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        ElseIf txtdetails.Text = "" Then
            MessageBox.Show("Please Enter Remarks!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdetails.Focus()
            Exit Sub
        End If

        com.CommandText = "update tbltransferrequestitem set quantity='" & txtquan.Value & "', remarks='" & rchar(txtdetails.Text) & "' where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
        MessageBox.Show("Quantity successfully changed!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmTransferRequestReview.FilterDetails()
        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub
End Class