Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports DevExpress.Utils

Public Class frmGLJournalInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSJournalEntries_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If countqry("tblgljournalentries", "ticketno='" & txtTicketNo.Text & "'") = 0 Then
            If countqry("tblgljournalitems", "ticketno='" & txtTicketNo.Text & "'") > 0 Then
                If MessageBox.Show("System found an ticket transaction not validated yet! Are you sure you want to cancel ticket item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "DELETE from tblgljournalitems where ticketno='" & txtTicketNo.Text & "'" : com.ExecuteNonQuery()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmPOSJournalEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtTrndate.EditValue = CDate(Now)
        txtTicketNo.ReadOnly = True
        FilterJournalTickets()
        menuFunctions(False)
        LoadOffice()

        txtTicketNumber.Text = "AUTO GENERATE"
        LoadTickets()
    End Sub

    Public Sub LoadOffice()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice where deleted=0  order by officename asc", "tblcompoffice", txtOffice, gv_Office)
        gv_Office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        officeid.Text = txtOffice.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub

    Public Sub menuFunctions(ByVal hide As Boolean)
        If hide = True Then
            cmdAddExpense.Visible = False
            cmdSaveVoucher.Visible = False
            txtDetails.ReadOnly = True
            Em.ContextMenuStrip = Nothing
        Else
            cmdAddExpense.Visible = True
            cmdSaveVoucher.Visible = True
            txtDetails.ReadOnly = False
            Em.ContextMenuStrip = gridmenustrip
        End If
    End Sub

    Public Sub ShowTicketInformation()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *  from tblgljournalentries where ticketno='" & txtTicketNo.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtTicketNumber.Text = .Rows(cnt)("ticketno").ToString
                txtDetails.Text = .Rows(cnt)("details").ToString
                officeid.Text = .Rows(cnt)("officeid").ToString
                txtOffice.EditValue = .Rows(cnt)("officeid").ToString
                txtTrndate.EditValue = .Rows(cnt)("postingdate").ToString
            End With
        Next
        If mode.Text = "edit" Then
            menuFunctions(False)
        ElseIf mode.Text = "view" Then
            menuFunctions(True)
        End If
        LoadTickets()
    End Sub

    Public Sub LoadTickets()
        LoadXgrid("select id, itemname as 'Item Name', Debitamount as Debit, Creditamount as Credit, Remarks  from tblgljournalitems where ticketno='" & If(txtTicketNo.Text = "", globaluserid & "-temp", txtTicketNo.Text) & "'", "tblgljournalitems", Em, GridView1)
        XgridHideColumn({"id"}, GridView1)
        XgridColCurrency({"Debit", "Credit"}, GridView1)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
        XgridColWidth({"Debit", "Credit"}, GridView1, 100)
    End Sub


    Private Sub cmdSaveVoucher_Click_1(sender As Object, e As EventArgs) Handles cmdSaveVoucher.Click
        If txtDetails.Text = "" Then
            MessageBox.Show("Please enter ticket details!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub
        ElseIf Val(CC(GridView1.Columns("Debit").SummaryItem.SummaryValue)) <> Val(CC(GridView1.Columns("Credit").SummaryItem.SummaryValue)) Then
            MessageBox.Show("Total debit and total credit not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblgljournalentries set postingdate='" & ConvertDate(txtTrndate.EditValue) & "', companyid='" & GlobalCompanyid & "', officeid='" & officeid.Text & "', details='" & rchar(txtDetails.Text) & "', datetrn=current_timestamp, postrn=0, trnby='" & globaluserid & "', trnname='" & globalfullname & "' where ticketno='" & txtTicketNo.Text & "'" : com.ExecuteNonQuery()
                MessageBox.Show("Ticket successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ticket As String = getTicketNumberSequence()
                com.CommandText = "insert into tblgljournalentries set ticketno='" & ticket & "', postingdate='" & ConvertDate(txtTrndate.EditValue) & "', companyid='" & GlobalCompanyid & "', officeid='" & officeid.Text & "',  details='" & rchar(txtDetails.Text) & "', datetrn=current_timestamp, postrn=0, trnby='" & globaluserid & "',trnname='" & globalfullname & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblgljournalitems set ticketno='" & ticket & "' where ticketno='" & globaluserid & "-temp'" : com.ExecuteNonQuery()
                MessageBox.Show("Ticket successfully posted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txtTicketNumber.Text = "AUTO GENERATE" : txtTicketNo.Text = "" : txtDetails.Text = "" : LoadTickets() : menuFunctions(False)
            FilterJournalTickets()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadTickets()
    End Sub

    Private Sub EditExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditExpenseToolStripMenuItem.Click
        frmGLJournalDetails.mode.Text = "edit"
        frmGLJournalDetails.id.Text = GridView1.GetFocusedRowCellValue("id").ToString()
        frmGLJournalDetails.ShowDialog(Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "DELETE from tblgljournalitems where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadTickets()
            MessageBox.Show("Selected item successfully removed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdAddExpense_Click(sender As Object, e As EventArgs) Handles cmdAddExpense.Click
        frmGLJournalDetails.txtTicketNo.Text = txtTicketNo.Text
        frmGLJournalDetails.ShowDialog(Me)
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        cmdAddExpense.PerformClick()
    End Sub

#Region "TICKET SUMMARY"
    Public Sub FilterJournalTickets()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear() : dst.Clear()
        LoadXgrid("Select ticketno as 'Ticket No.',  (select officename from tblcompoffice where officeid=tblgljournalentries.officeid) as 'Office',date_format(PostingDate, '%Y-%m-%d') as 'Posting Date',  Details, " _
                                        + " (select sum(debitamount) from tblgljournalitems where ticketno=tblgljournalentries.ticketno) as Amount, date_format(datetrn, '%Y-%m-%d') as 'Date Created' " _
                                        + " from tblgljournalentries where trnby='" & globaluserid & "' and postrn=0 and cleared=0 order by datetrn desc", "tblgljournalentries", Em_Tickets, grid_tickets)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblgljournalentries")


        XgridColCurrency({"Amount"}, grid_tickets)
        XgridColAlign({"Account"}, grid_tickets, HorzAlignment.Center)
        grid_tickets.BestFitColumns()
        XgridColAlign({"Ticket No.", "Date Created", "Date Cleared", "Posting Date", "Date Created", "Date Cancelled"}, grid_tickets, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, grid_tickets)
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdViewItem.PerformClick()
    End Sub

    Private Sub EditVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVoucherToolStripMenuItem.Click
        If grid_tickets.GetFocusedRowCellValue("Ticket No.").ToString = "" Then
            MessageBox.Show("There is no item selected! make sure, the selection is on the list", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf grid_tickets.GetFocusedRowCellValue("Cancelled") = True Then
            MessageBox.Show("Editing cancelled Ticket not allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        mode.Text = "edit"
        txtTicketNo.Text = grid_tickets.GetFocusedRowCellValue("Ticket No.").ToString()
        XtraTabControl1.SelectedTabPage = tabInformation
        ShowTicketInformation()
    End Sub

    Private Sub cmdViewItem_Click(sender As Object, e As EventArgs) Handles cmdViewItem.Click
        mode.Text = "view"
        txtTicketNo.Text = grid_tickets.GetFocusedRowCellValue("Ticket No.").ToString()
        XtraTabControl1.SelectedTabPage = tabInformation
        ShowTicketInformation()
    End Sub

    Private Sub CancelVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelVoucherToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to cancel this item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To grid_tickets.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblgljournalentries set cancelled=1,datecancelled=current_timestamp,cancelledby='" & globalfullname & "' where ticketno='" & grid_tickets.GetRowCellValue(grid_tickets.GetSelectedRows(I), "Ticket No.").ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tblglticket where referenceno='" & grid_tickets.GetRowCellValue(grid_tickets.GetSelectedRows(I), "Ticket No.").ToString & "' and journal=1" : com.ExecuteNonQuery()
            Next
            FilterJournalTickets()
            MessageBox.Show("Ticket successfully cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FilterJournalTickets()
    End Sub
#End Region


   
End Class