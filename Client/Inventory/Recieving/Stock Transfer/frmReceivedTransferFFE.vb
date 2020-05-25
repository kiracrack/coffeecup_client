Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmReceivedTransferFFE
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmReceivedType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        tabFilter()
    End Sub
 
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tabInComing Or TabControl1.SelectedTab Is tabInTransit Then
            txtfrmdate.Enabled = False : txttodate.Enabled = False : ckasof.Checked = False : ckasof.Enabled = False
        Else
            txttodate.Enabled = True : ckasof.Enabled = True
            If ckasof.Checked = True Then
                txtfrmdate.Enabled = False
            Else
                txtfrmdate.Enabled = True
            End If

        End If
        tabFilter()
    End Sub
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        tabFilter()
    End Sub
    Private Sub textsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        tabFilter()
    End Sub


    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabInComing Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            FilterTransaction(" received=0 and officeid_to='" & compOfficeid & "'", "")
            cmdCancel.Visible = False
            cmdReceived.Visible = True
        ElseIf TabControl1.SelectedTab Is tabInTransit Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            FilterTransaction(" received=0 and officeid_from='" & compOfficeid & "'", "")
            cmdCancel.Visible = True
            cmdReceived.Visible = False
        ElseIf TabControl1.SelectedTab Is tabTransfered Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            FilterTransaction(" received=1 and (officeid_from='" & compOfficeid & "' or officeid_to='" & compOfficeid & "') ", ",Received, datereceived as 'Date Received', receivedby as 'Received By' ")
            cmdCancel.Visible = False
            cmdReceived.Visible = False
        ElseIf TabControl1.SelectedTab Is tabCancelled Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            FilterTransaction(" cancelled=1  and (officeid_from='" & compOfficeid & "' or officeid_to='" & compOfficeid & "') ", ",Cancelled, datecancelled as 'Date Cancelled', Cancelledby as 'Cancelled by' ")
            cmdCancel.Visible = False
            cmdReceived.Visible = False
        End If
    End Sub

    Public Sub FilterTransaction(ByVal filters As String, ByVal dateDisplay As String)
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(daterequest,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(daterequest,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        dst = New DataSet
        msda = New MySqlDataAdapter("SELECT id, ffecode as 'FFE Code', ProductName as 'Product Name', ProductType as 'Product Type', " _
                                            + " (select officename from tblcompoffice where officeid = tblinventoryffetransfer.officeid_from) as 'Transfer From', " _
                                            + " (select officename from tblcompoffice where officeid = tblinventoryffetransfer.officeid_to) as 'Transfer To', Message, " _
                                            + " daterequest as 'Date Request', requestby as 'Request By' " _
                                            + dateDisplay _
                                            + "  FROM `tblinventoryffetransfer` where " & filters & If(TabControl1.SelectedTab Is tabInComing Or TabControl1.SelectedTab Is tabInTransit, "", filterasof) & " and " _
                                            + " (ffecode like '%" & txtsearch.Text & "%' or ProductName like '%" & txtsearch.Text & "%' or ProductType like '%" & txtsearch.Text & "%');", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Message").Width = 500
        MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"FFE Code", "Date Request", "Date Received"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub ViewFFEProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFFEProfileToolStripMenuItem.Click
        frmNewInventoryEntry.mode.Text = "view"
        frmNewInventoryEntry.ffecode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmNewInventoryEntry.Show(Me)
    End Sub

    Private Sub cmdReceived_Click(sender As Object, e As EventArgs) Handles cmdReceived.Click
        If MessageBox.Show("Are you sure you want to received selected incoming FFE Item?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblinventoryffetransfer set received=1, datereceived=current_timestamp,receivedby='" & globalfullname & "' where id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblinventoryffe set flaged=0, lockedediting=0, flagedreason='', officeid='" & compOfficeid & "' where ffecode='" & MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            LogFFEHistory(MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString, "received from " & MyDataGridView.Item("Transfer From", MyDataGridView.CurrentRow.Index).Value().ToString)
            tabFilter()
            MessageBox.Show("FFE successfully received!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to cancel selected transfer?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblinventoryffetransfer set cancelled=1, datecancelled=current_timestamp,cancelledby='" & globalfullname & "' where id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblinventoryffe set flaged=0, lockedediting=0, flagedreason='' where ffecode='" & MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            LogFFEHistory(MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString, "cancelled transfer")
            tabFilter()
            MessageBox.Show("FFE successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If Not TabControl1.SelectedTab Is tabInComing Or Not TabControl1.SelectedTab Is tabInTransit Then
            If ckasof.Checked = True Then
                txtfrmdate.Enabled = False
            Else
                txtfrmdate.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text, TabControl1.SelectedTab.Text, If(TabControl1.SelectedTab Is tabInComing Or TabControl1.SelectedTab Is tabInTransit, "", If(ckasof.Checked = True, "Date filter as of " & txttodate.Text, "Date period from " & txtfrmdate.Text & " to " & txttodate.Text)), MyDataGridView, Me)
    End Sub

    Private Sub cmdPrintPreview_Click(sender As Object, e As EventArgs) Handles cmdPrintPreview.Click
        ExportGridToExcel(Me.Text & "-" & TabControl1.SelectedTab.Text, dst)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

 
End Class