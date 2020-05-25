Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmClinicStatementLedger
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelGuestStatementLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        For Each col In MyDataGridView.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub ShowGuestInfo(ByVal trnid As String)
        com.CommandText = "select *,date_format(current_timestamp, '%M %d, %Y %r') as 'dateledger', date_format(datetrn, '%M %d, %Y') as 'datetransaction', " _
                           + " (select companyname from tblclientaccounts where cifid=tblclinicservices.clientcif) as 'client', " _
                           + " (select compadd from tblclientaccounts where cifid=tblclinicservices.clientcif) as 'address' " _
                           + " from tblclinicservices where trnid='" & trnid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtServiceNo.Text = rst("servicecode").ToString
            cifd.Text = rst("clientcif").ToString
            txtClient.Text = UCase(rst("client").ToString)
            'txtAddress.Text = StrConv(rst("address").ToString, VbStrConv.ProperCase)
            txtPackageName.Text = rst("packagename").ToString
            txtDateTransaction.Text = rst("datetransaction").ToString
            txtDate.Text = rst("dateledger").ToString
            txtPackageAmount.Text = FormatNumber(rst("amount").ToString, 2)
            If CBool(rst("closed")) = True Or CBool(rst("cancelled")) = True Then
                cmdCloseTransaction.Visible = False
                lineClose.Visible = False
                MyDataGridView.ContextMenuStrip = Nothing
            Else
                cmdCloseTransaction.Visible = True
                lineClose.Visible = True
                MyDataGridView.ContextMenuStrip = cms_em
            End If
        End While
        rst.Close()
    End Sub

    Public Sub FilterDetails(ByVal trnid As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id,productid, date_format(schedule,'%M %d, %Y') as 'Schedule', Productname as 'Product Schedule',(select group_concat(fullname) from tblclinicsattending where schedid=tblclinicschedule.id) as 'Attending Personnel',Cleared, date_format(datecleared,'%Y-%m-%d %r') as 'Date Cleared', clearedby as 'Cleared By'  from tblclinicschedule where trnid='" & trnid & "' and cancelled=0 order by date_format(schedule,'%Y-%m-%d') asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id", "productid"})
        'MyDataGridView.Columns("Balance").Width = 100
        GridColumnAlignment(MyDataGridView, {"Date Cleared"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdPrintStatement_Click(sender As Object, e As EventArgs) Handles cmdPrintStatement.Click
        GenerateLXClinicService(trnid.Text, Me)
    End Sub

    Private Sub trnid_TextChanged(sender As Object, e As EventArgs) Handles trnid.TextChanged
        ShowGuestInfo(trnid.Text)
        FilterDetails(trnid.Text)
    End Sub
   
    Private Sub cmdClearedSchedule_Click(sender As Object, e As EventArgs) Handles cmdClearedSchedule.Click
        If countqry("tblclinicschedule", "id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "' and cleared=1") > 0 Then
            MsgBox("Schedule already cleared! Clearing not allowed", MsgBoxStyle.Critical, "Error Message")
            Exit Sub
        End If
        frmClinicAttendingPersonnel.schedid.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmClinicAttendingPersonnel.productid.Text = MyDataGridView.Item("productid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmClinicAttendingPersonnel.serviceid.Text = trnid.Text
        frmClinicAttendingPersonnel.serviceno.Text = txtServiceNo.Text
        If frmClinicAttendingPersonnel.Visible = True Then
            frmClinicAttendingPersonnel.Focus()
        Else
            frmClinicAttendingPersonnel.Show(Me)
        End If
    End Sub
 
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterDetails(trnid.Text)
    End Sub

    Private Sub cmdCloseTransaction_Click(sender As Object, e As EventArgs) Handles cmdCloseTransaction.Click
        If countqry("tblclinicschedule", "trnid='" & trnid.Text & "' and cleared=0 and cancelled=0") > 0 Then
            MsgBox("Some schedule currently not cleared! please clear all schedule to proceed close", MsgBoxStyle.Critical, "Error Message")
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to Continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblclinicservices set closed=1, dateclosed=current_timestamp,closedby='" & globaluserid & "' where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            frmClinicServices.tabFilter()
            MessageBox.Show("Service package successfully closed", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class