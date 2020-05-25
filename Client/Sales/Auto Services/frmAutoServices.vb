Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmAutoServices
 
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        Me.Text = StrConv(GlobalOrganizationName, vbProperCase) & " " & Me.Text
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        tabFilter()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            tabFilter()
        End If
    End Sub

    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabPending Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewPendingTransaction()
            EditSelectedToolStripMenuItem.Visible = True
            cmdCancel.Visible = True

        ElseIf TabControl1.SelectedTab Is tabClosed Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewClosedTransaction()
            EditSelectedToolStripMenuItem.Visible = False
            cmdCancel.Visible = False
             
        ElseIf TabControl1.SelectedTab Is tabCancelled Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewCancelledransaction()
            EditSelectedToolStripMenuItem.Visible = False
            cmdCancel.Visible = False
        End If

    End Sub
   
    Public Sub ViewPendingTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trncode as 'Transaction #', " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Customer Name', " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Address', " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Contact Number', " _
                           + " carmodel as 'Car Model', " _
                           + " platenumber as 'Plate Number', " _
                           + " odometer as 'Mileage', " _
                           + " attmechanics as 'Attending Mechanics', " _
                           + " ifnull((Select sum(total) from tblsalestransaction inner join tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode and cancelled=0 and void=0 where tblsalesautotransaction.trncode=tblsalesautoservices.trncode),0) as 'Total Transaction', " _
                           + " date_format(datetrn, '%Y-%m-%d %r') as 'Transaction Date', " _
                           + " (select fullname from tblaccounts where accountid = tblsalesautoservices.trnby) as 'Transaction by' " _
                           + " from tblsalesautoservices where closed=0 and cancelled=0 and " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) like '%" & txtsearch.Text & "%' order by trncode asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Recomendation").Width = 300
        'MyDataGridView.Columns("Recomendation").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

        GridCurrencyColumn(MyDataGridView, {"Total Transaction"})
        GridColumnAlignment(MyDataGridView, {"Transaction #", "Car Model", "Plate Number", "Transaction Date"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Total Transaction"}, DataGridViewContentAlignment.MiddleRight)
        GridNumberColumn(MyDataGridView, {"Mileage"})
        txtfrmdate.Enabled = False
        txttodate.Enabled = False
        ckasof.Enabled = False

    End Sub

    Public Sub ViewClosedTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trncode as 'Transaction #', " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Customer Name', " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Address', " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Contact Number', " _
                           + " carmodel as 'Car Model', " _
                           + " platenumber as 'Plate Number', " _
                           + " odometer as 'Mileage', " _
                           + " attmechanics as 'Attending Mechanics', " _
                           + " ifnull((Select sum(total) from tblsalestransaction inner join tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode and cancelled=0 and void=0 where tblsalesautotransaction.trncode=tblsalesautoservices.trncode),0) as 'Total Transaction', " _
                           + " date_format(datetrn, '%Y-%m-%d %r') as 'Transaction Date', " _
                           + " (select fullname from tblaccounts where accountid = tblsalesautoservices.trnby) as 'Transaction by', " _
                           + " date_format(dateclosed, '%Y-%m-%d %r') as 'Date Closed', " _
                           + " (select fullname from tblaccounts where accountid = tblsalesautoservices.closedby) as 'Closed by' " _
                           + " from tblsalesautoservices where closed=1 and " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) like '%" & txtsearch.Text & "%' order by trncode asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridCurrencyColumn(MyDataGridView, {"Total Transaction"})
        GridColumnAlignment(MyDataGridView, {"Transaction #", "Car Model", "Plate Number", "Transaction Date", "Date Closed"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Total Transaction"}, DataGridViewContentAlignment.MiddleRight)
        GridNumberColumn(MyDataGridView, {"Mileage"})
        txtfrmdate.Enabled = True
        txttodate.Enabled = True
        ckasof.Enabled = True
    End Sub

    Public Sub ViewCancelledransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trncode as 'Transaction #', " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Customer Name', " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Address', " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'Contact Number', " _
                           + " carmodel as 'Car Model', " _
                           + " platenumber as 'Plate Number', " _
                           + " odometer as 'Mileage', " _
                           + " attmechanics as 'Attending Mechanics', " _
                           + " ifnull((Select sum(total) from tblsalestransaction inner join tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode and cancelled=0 and void=0 where tblsalesautotransaction.trncode=tblsalesautoservices.trncode),0) as 'Total Transaction', " _
                           + " date_format(datetrn, '%Y-%m-%d %r') as 'Transaction Date', " _
                           + " (select fullname from tblaccounts where accountid = tblsalesautoservices.trnby) as 'Transaction by', " _
                           + " date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled', " _
                           + " (select fullname from tblaccounts where accountid = tblsalesautoservices.cancelledby) as 'Cancelled by' " _
                           + " from tblsalesautoservices where cancelled=1 and " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) like '%" & txtsearch.Text & "%' order by trncode asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridCurrencyColumn(MyDataGridView, {"Total Transaction"})
        GridColumnAlignment(MyDataGridView, {"Transaction #", "Car Model", "Plate Number", "Transaction Date", "Date Cancelled"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Total Transaction"}, DataGridViewContentAlignment.MiddleRight)
        GridNumberColumn(MyDataGridView, {"Mileage"})
        txtfrmdate.Enabled = True
        txttodate.Enabled = True
        ckasof.Enabled = True
    End Sub

    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        cmdStatement.PerformClick()
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub
  
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
 
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text, TabControl1.SelectedTab.Text, If(ckasof.Checked = False, "Reports period from " & CDate(txtfrmdate.Text).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Text).ToString("MMMM, dd yyyy"), "Reports as of " & CDate(txttodate.Text).ToString("MMMM, dd yyyy")), MyDataGridView, Me)
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

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdNewCheckinGuest.Click
        If frmAutoNewServices.Visible = False Then
            frmAutoNewServices.Show()
        Else
            frmAutoNewServices.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub RemoveFromInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdStatement.Click
        frmAutoViewServices.txtReference.Text = MyDataGridView.Item("Transaction #", MyDataGridView.CurrentRow.Index).Value().ToString
        If TabControl1.SelectedTab Is tabPending Then
            frmAutoViewServices.cmdAddTransaction.Enabled = True
            frmAutoViewServices.cmdPrintAgreement.Enabled = True
            frmAutoViewServices.cmdClosedService.Enabled = True

        ElseIf TabControl1.SelectedTab Is tabClosed Then
            frmAutoViewServices.cmdAddTransaction.Enabled = False
            frmAutoViewServices.cmdPrintAgreement.Enabled = True
            frmAutoViewServices.cmdClosedService.Enabled = False

        ElseIf TabControl1.SelectedTab Is tabCancelled Then
            frmAutoViewServices.cmdAddTransaction.Enabled = False
            frmAutoViewServices.cmdPrintAgreement.Enabled = False
            frmAutoViewServices.cmdClosedService.Enabled = False
        End If

        If frmAutoViewServices.Visible = False Then
            frmAutoViewServices.Show(Me)
        Else
            frmAutoViewServices.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CancelTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblsalesautoservices set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trncode='" & MyDataGridView.Item("Transaction #", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            tabFilter()
            MsgBox("Service successfully cancelled!", MsgBoxStyle.Information, "Message")
        End If
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
        frmAutoNewServices.txtReference.Text = MyDataGridView.Item("Transaction #", MyDataGridView.CurrentRow.Index).Value().ToString
        frmAutoNewServices.mode.Text = "edit"
        If frmAutoNewServices.Visible = False Then
            frmAutoNewServices.Show(Me)
        Else
            frmAutoNewServices.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class