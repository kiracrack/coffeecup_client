Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmRequestManagement
    ' The class that will do the printing process.
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Text = StrConv(GlobalOrganizationName, vbProperCase) & " " & Me.Text
        ApplySystemTheme(ToolStrip3)
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        tabFilter()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If txtsearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            tabFilter()
        End If
    End Sub

  
    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabPending Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewRequisitionList("((corporatelevel=1 and (approvedbranch=0 or approvedcorporate=0)) or (corporatelevel=0 and approvedbranch=0)) and cancelled=0 and disapproved=0", "")
            cmdDownloadApprovedCopy.Visible = False
            GridHideColumn(MyDataGridView, {"officeid", "Office"})
            GridColumnAlignment(MyDataGridView, {"Date Request", "Date Needed", "Total Item", "Status", "Attachment"}, DataGridViewContentAlignment.MiddleCenter)
            GridColumnAlignment(MyDataGridView, {"Total Amount"}, DataGridViewContentAlignment.MiddleRight)
            ckasof.Enabled = False : txtfrmdate.Enabled = False : txttodate.Enabled = False
            CancelRequestToolStripMenuItem.Visible = True
        ElseIf TabControl1.SelectedTab Is tabApproved Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewRequisitionList("((corporatelevel=1 and approvedbranch=1 and approvedcorporate=1) or (corporatelevel=0 and approvedbranch=1)) and cancelled=0 and disapproved=0", "approved")
            cmdDownloadApprovedCopy.Visible = True

            GridColumnAlignment(MyDataGridView, {"Date Request", "Total Item", "Date Needed", "Date Request", "Date Approved", "Status", "Attachment"}, DataGridViewContentAlignment.MiddleCenter)
            GridColumnAlignment(MyDataGridView, {"Total Amount"}, DataGridViewContentAlignment.MiddleRight)
            ckasof.Enabled = True : txtfrmdate.Enabled = True : txttodate.Enabled = True
            CancelRequestToolStripMenuItem.Visible = False
        ElseIf TabControl1.SelectedTab Is tabCancelled Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewRequisitionList("cancelled=1", "cancelled")
            cmdDownloadApprovedCopy.Visible = False

            GridColumnAlignment(MyDataGridView, {"Date Request", "Total Item", "Date Needed", "Date Request", "Date Cancelled", "Status", "Attachment"}, DataGridViewContentAlignment.MiddleCenter)
            GridColumnAlignment(MyDataGridView, {"Total Amount"}, DataGridViewContentAlignment.MiddleRight)
            ckasof.Enabled = True : txtfrmdate.Enabled = True : txttodate.Enabled = True
            CancelRequestToolStripMenuItem.Visible = False
        ElseIf TabControl1.SelectedTab Is tabDisapproved Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewRequisitionList("disapproved=1", "disapproved")
            cmdDownloadApprovedCopy.Visible = False

            GridColumnAlignment(MyDataGridView, {"Date Request", "Total Item", "Date Needed", "Date Request", "Date Disapproved", "Status", "Attachment"}, DataGridViewContentAlignment.MiddleCenter)
            GridColumnAlignment(MyDataGridView, {"Total Amount"}, DataGridViewContentAlignment.MiddleRight)
            ckasof.Enabled = True : txtfrmdate.Enabled = True : txttodate.Enabled = True
            CancelRequestToolStripMenuItem.Visible = False
        End If
        GridHideColumn(MyDataGridView, {"officeid", "trnrefno", "Office"})
     
    End Sub

    Public Sub ViewRequisitionList(ByVal query As String, ByVal columndate As String)
        Dim filterasof As String = "" : Dim strdate As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(daterequest,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(daterequest,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        If columndate = "approved" Then
            strdate = "date_format(dateapproved, '%Y-%m-%d %r') as 'Date Approved', "

        ElseIf columndate = "cancelled" Then
            strdate = " date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled', "

        ElseIf columndate = "disapproved" Then
            strdate = " date_format(datedisapproved, '%Y-%m-%d %r')  as 'Date Disapproved', "
        End If

        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnrefno, case when cancelled=1 and disapproved=0 then 'Cancelled' " _
                                         + " when cancelled=0 and disapproved=1 then 'Disapproved' " _
                                         + " when hold=1 then 'On Hold' " _
                                         + " when approvedbranch=0 then 'Pending Branch Approval' " _
                                         + " when corporatelevel=1 and approvedbranch=1 and approvedcorporate=0 and received=0 then 'Waiting for Receiving' " _
                                         + " when corporatelevel=1 and approvedbranch=1 and approvedcorporate=0 and received=1 then 'Pending Corporate Approval' " _
                                         + " else 'Approved' end as 'Status', " _
                                         + " pid as 'Request No', " _
                                        + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as 'Office', " _
                                        + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'Request By' , " _
                                        + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'Request Type', " _
                                        + " ifnull((select sum(quantity) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Item', " _
                                        + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Amount', " _
                                        + " date_format(DATEREQUEST, '%Y-%m-%d %r') as 'Date Request', " _
                                        + " date_format(dateneeded, '%Y-%m-%d') as 'Date Needed', " _
                                        + " case when corporatelevel=1 then 'CORPORATE' else 'BRANCH LEVEL' end as 'Request Level', " _
                                        + strdate _
                                        + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby) as 'Transaction By',  " _
                                        + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblrequisitions.pid or refnumber in (select trnid from tblrequisitionsitem where pid = tblrequisitions.pid)),'-') as 'Attachment' " _
                                        + " from tblrequisitions " _
                                        + " WHERE officeid='" & compOfficeid & "' and " & query & If(TabControl1.SelectedTab Is tabPending, "", filterasof) _
                                        + " and ((select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " (select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid) like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " pid like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby)  like '%" & rchar(txtsearch.Text) & "%') order by daterequest desc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView, {"Total Amount"})
        If MyDataGridView.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView.RowCount - 1
                totalsum = totalsum + MyDataGridView.Rows(i).Cells("Total Amount").Value()
            Next
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Total Amount").Value = totalsum
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If

        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("Status", i).Value = "On Hold" Then
                MyDataGridView.Rows(i).Cells("Status").Style.BackColor = Color.Orange
                MyDataGridView.Rows(i).Cells("Status").Style.ForeColor = Color.Black
            End If
        Next
        GridColumnChoosed(MyDataGridView, Me.Name & TabControl1.SelectedTab.Name)
    End Sub
 
    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        ViewParticularToolStripMenuItem.PerformClick()

    End Sub
 
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub

    ' The PrintPage action for the PrintDocument control
    Private Sub MyPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles MyPrintDocument.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        On Error Resume Next
        Dim colname As String = ""
        For i = 0 To MyDataGridView.ColumnCount - 1
            colname += MyDataGridView.Columns(i).Name & ","
        Next
        frmColumnChooser.txttype.Text = Me.Name & TabControl1.SelectedTab.Name
        frmColumnChooser.init_grid(MyDataGridView)
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
        frmColumnChooser.Show(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(TabControl1.SelectedTab.Text, TabControl1.SelectedTab.Text, If(ckasof.Checked = False, "Requisition reports period from " & CDate(txtfrmdate.Text).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Text).ToString("MMMM, dd yyyy"), "Requisition reports as of " & CDate(txttodate.Text).ToString("MMMM, dd yyyy")), MyDataGridView, Me)
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub
 
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        tabFilter()
    End Sub

    Private Sub ViewParticularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewParticularToolStripMenuItem.Click
        If MyDataGridView.Item("Request No", MyDataGridView.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        frmRequisitionsView.txtStatus.Text = UCase(MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString())
        frmRequisitionsView.pid.Text = MyDataGridView.Item("Request No", MyDataGridView.CurrentRow.Index).Value().ToString()
        If frmRequisitionsView.Visible = True Then
            frmRequisitionsView.Focus()
        Else
            frmRequisitionsView.Show(Me)
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                ' MessageBox.Show("Your file successfully exported with filename " & LCase(Me.Text) & ".xls", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                MainForm.NotifyIcon1.BalloonTipTitle = "Successfully Exported"
                MainForm.NotifyIcon1.BalloonTipText = "Your file successfully exported at " & f.SelectedPath & "\" & LCase(Me.Text) & ".xls"
                MainForm.NotifyIcon1.ShowBalloonTip(1000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdDownloadApprovedCopy_Click(sender As Object, e As EventArgs) Handles cmdDownloadApprovedCopy.Click
        ViewAttachmentPackage_Database({MyDataGridView.Item("Request No", MyDataGridView.CurrentRow.Index).Value().ToString}, "requisition-approved")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ExportGridToExcel(UCase(TabControl1.SelectedTab.Text), dst)
    End Sub
 

    Private Sub UploadAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadAttachmentToolStripMenuItem.Click
        frmFileUploader.trncode.Text = MyDataGridView.Item("Request No", MyDataGridView.CurrentRow.Index).Value().ToString
        frmFileUploader.ShowDialog(Me)
    End Sub

    Private Sub ViewAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttachmentToolStripMenuItem.Click
        If TabControl1.SelectedTab Is tabPending Then
            frmFileViewer.viewonly = False
        Else
            frmFileViewer.viewonly = True
        End If
        frmFileViewer.trncode.Text = MyDataGridView.Item("Request No", MyDataGridView.CurrentRow.Index).Value().ToString
        frmFileViewer.ShowDialog(Me)
    End Sub

    Private Sub ToolStripSeparator2_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ReviseOnholdRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviseOnholdRequestToolStripMenuItem.Click
        If MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString <> "On Hold" Then
            MessageBox.Show("Only onhold request can be revise!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        DownloadRequest(MyDataGridView.Item("trnrefno", MyDataGridView.CurrentRow.Index).Value().ToString, MyDataGridView.Item("trnrefno", MyDataGridView.CurrentRow.Index).Value().ToString)
        frmRequisition.CheckBox1.Checked = True
        frmRequisition.mode.Text = "edit"
        frmRequisition.FillComboFromFile()
        frmRequisition.pid.Text = MyDataGridView.Item("trnrefno", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequisition.Show(Me)
    End Sub

    Private Sub CancelRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelRequestToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to cancel selected requisition? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblrequisitions set cancelled=1,datecancelled=current_timestamp where pid='" & rw.Cells("Request No").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            MsgBox("Requisition successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub
End Class