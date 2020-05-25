Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmClinicScheduleReminder

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAutoNewServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ViewSchedule()
    End Sub
 

    Public Sub ViewSchedule()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select b.trnid, date_format(schedule,'%M %d, %Y') as 'Schedule', (select companyname from tblclientaccounts where cifid  = b.clientcif) as 'Client', " _
                                    + " (select telephone from tblclientaccounts where cifid  = b.clientcif) as 'Contact No.',productname as 'Product Schedule' from tblclinicschedule as a inner join tblclinicservices as b on b.trnid = a.trnid where b.officeid='" & compOfficeid & "' and date_format(schedule,'%Y-%m-%d') <= '" & ConvertDate(CDate(Now.AddDays(1).ToShortDateString)) & "' and a.cancelled=0 and cleared=0", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"trnid"})
        'GridColumnAlignment(MyDataGridView, {"Schedule"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    
    Private Sub cmdPrintStatement_Click(sender As Object, e As EventArgs) Handles cmdPrintStatement.Click
        PrintDatagridview(Me.Text & "<br/>", Me.Text, "", MyDataGridView, Me)
    End Sub
    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        ViewStatementToolStripMenuItem.PerformClick()
    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewSchedule()
    End Sub

    Private Sub ViewStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStatementToolStripMenuItem.Click
        frmClinicStatementLedger.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        If frmClinicStatementLedger.Visible = False Then
            frmClinicStatementLedger.Show(Me)
        Else
            frmClinicStatementLedger.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class