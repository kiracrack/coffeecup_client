Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmFFEforDisposalList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmFFEforDisposalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowList()
    End Sub

    Public Sub ShowList()
        msda = New MySqlDataAdapter("Select ffecode as 'FFE Code'," _
                  + " productname as 'Particular', " _
                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as 'FFE Type', " _
                  + " Quantity, Unit, bookvalue as 'Book Value',  date_format(lastdepreciationdate, '%Y-%m-%d') as 'Last Depreciation Date', " _
                  + " case when disposalapproved=1 then 'Approved' else 'Pending Approval' end as 'Status' " _
                  + " from tblinventoryffe where officeid='" & officeid.Text & "' and disposalrequested=1 and disposed=0", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView, {"Book Value"})
        GridColumnAlignment(MyDataGridView, {"Unit", "Quantity", "FFE Code", "FFE Type", "Status", "Last Depreciation Date"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowList()
    End Sub

    Private Sub cmdConfirmed_Click(sender As Object, e As EventArgs) Handles cmdConfirmed.Click
        If MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString = "Pending Approval" Then
            MessageBox.Show("Status Currently for approval", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            com.CommandText = "UPDATE tblinventoryffe set disposed=1, datedisposed=current_timestamp, disposedby='" & globaluserid & "',flaged=0,flagedreason='', blocked=0, lockedediting=0 where ffecode='" & MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            LogFFEHistory(MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString, "FFE Confirmed Dispose")
            ShowList()
            MessageBox.Show("Disposal successfully confirmed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If globalCorporateApprover = True Then
                frmCorpForApprovalList.FilterSelectedTab()
            Else
                frmBranchForApprovalList.FilterSelectedTab()
            End If
        End If
    End Sub
End Class
