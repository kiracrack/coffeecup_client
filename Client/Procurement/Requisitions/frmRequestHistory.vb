Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmRequestHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FillComboFromFile_history()
    End Sub

    '#Region "FOR REVISION"
    '    Private Sub FillComboFromFile_revision()
    '        LoadToComboBoxDB("select trnrefno from tblrequisitions where officeid='" & compOfficeid & "' and approvedbranch=0 and hold=1 order by daterequest asc", "trnrefno", "trnrefno", pid_revision)
    '        txtRequestLogs_revision.Text = pid_revision.Items.Count & " total request for revision"
    '    End Sub

    '    Private Sub pid_revision_SelectedIndexChanged(sender As Object, e As EventArgs)
    '        loadForRevisionParticular()
    '    End Sub
    '    Public Sub loadForRevisionParticular()
    '        MyDataGridView_revision.DataSource = Nothing : dst = New DataSet
    '        msda = New MySqlDataAdapter("Select  trnid,vendorid,catid,productid,(select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
    '                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionsitem.CATID ) as 'Category', " _
    '                                + " QUANTITY as 'Quantity'," _
    '                                + " UNIT as 'Unit', " _
    '                                + " COST as 'Cost', " _
    '                                + " TOTAL as 'Total', " _
    '                                + " Remarks, " _
    '                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
    '                                + " from tblrequisitionsitem " _
    '                                + " where trnrefno='" & pid_revision.Text & "'", conn)
    '        msda.Fill(dst, 0)
    '        MyDataGridView_revision.DataSource = dst.Tables(0)

    '        GridHideColumn(MyDataGridView_revision, {"trnid", "vendorid", "catid", "productid"})
    '        GridColumnAlignment(MyDataGridView_revision, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
    '        GridColumnAlignment(MyDataGridView_revision, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

    '        If MyDataGridView_revision.RowCount - 1 > 0 Then
    '            Dim totalsum As Double = 0
    '            For i = 0 To MyDataGridView_revision.RowCount - 1
    '                totalsum = totalsum + MyDataGridView_revision.Rows(i).Cells("Total").Value()
    '            Next
    '            MyDataGridView_revision.Rows(MyDataGridView_revision.RowCount - 1).Cells("Cost").Value = "Total"
    '            MyDataGridView_revision.Rows(MyDataGridView_revision.RowCount - 1).Cells("Total").Value = FormatNumber(totalsum, 2)
    '            MyDataGridView_revision.Rows(MyDataGridView_revision.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
    '            MyDataGridView_revision.Rows(MyDataGridView_revision.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
    '        End If
    '        pid.Text = qrysingledata("pid", "pid", "tblrequisitions where trnrefno='" & pid_revision.Text & "'")
    '        filterApprovalLogs(True, {pid.Text}, MyDataGridView_Approval)
    '    End Sub


    '    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    '        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '            Me.MyDataGridView_revision.CurrentCell = Me.MyDataGridView_revision.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '        End If
    '    End Sub

    '    Private Sub cmdreset_Click(sender As Object, e As EventArgs)
    '        Me.Close()
    '    End Sub

    '    Private Sub cmdRevise_Click(sender As Object, e As EventArgs)
    '        If pid_revision.Text = "" Then
    '            MessageBox.Show("Please select Request Number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            pid_revision.Focus()
    '            Exit Sub
    '        End If
    '        If MessageBox.Show("Are you sure you want to create copy for this request?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '            DownloadRequest(pid_revision.Text, pid_revision.Text)
    '            pid_revision.Text = ""
    '            loadForRevisionParticular()
    '            MessageBox.Show("Your request successfully restored, please check your draft list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End Sub

    '#End Region

#Region "REQUISITION HISTORY"
    Private Sub FillComboFromFile_history()
        LoadToComboBoxDB("select trnrefno from tblrequisitionslogs where officeid='" & compOfficeid & "' order by daterequest asc", "trnrefno", "trnrefno", pid_history)
        txtRequestLogs_history.Text = pid_history.Items.Count & " total request history"
    End Sub

    Private Sub pid_history_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pid_history.SelectedIndexChanged
        loadForhistoryParticular()
    End Sub
    Public Sub loadForhistoryParticular()
        MyDataGridView_history.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  trnid,vendorid,catid,productid,(select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionslogsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionslogsitem.CATID ) as 'Category', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionslogsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionslogsitem " _
                                + " where trnrefno='" & pid_history.Text & "'", conn)
        msda.Fill(dst, 0)
        MyDataGridView_history.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView_history, {"trnid", "vendorid", "catid", "productid"})
        GridColumnAlignment(MyDataGridView_history, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_history, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        If MyDataGridView_history.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView_history.RowCount - 1
                totalsum = totalsum + MyDataGridView_history.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView_history.Rows(MyDataGridView_history.RowCount - 1).Cells("Cost").Value = "Total"
            MyDataGridView_history.Rows(MyDataGridView_history.RowCount - 1).Cells("Total").Value = FormatNumber(totalsum, 2)
            MyDataGridView_history.Rows(MyDataGridView_history.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView_history.Rows(MyDataGridView_history.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub MyDataGridView_history_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_history.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_history.CurrentCell = Me.MyDataGridView_history.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdcancel_history_Click(sender As Object, e As EventArgs) Handles cmdcancel_history.Click
        Me.Close()
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If pid_history.Text = "" Then
            MessageBox.Show("Please select reference number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pid_history.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to restore request for history?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim newRequest As String = getGlobalTrnid(compOfficeid, globaluserid)
            DownloadRequest(pid_history.Text, newRequest)
            pid_history.Text = ""
            loadForhistoryParticular()
            MessageBox.Show("Your request successfully restored! please check your draft list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

  
End Class