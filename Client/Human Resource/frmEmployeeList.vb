Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmEmployeeList

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadPayrollCode()
    End Sub

    Public Sub LoadPayrollCode()
        com.CommandText = "select payrollcode as 'Payroll Code', date_format(datefrom,'%Y-%m-%d') as 'Period From', date_format(dateto,'%Y-%m-%d') as 'Period To',schedulecode from tblpayrollperiod where approved=0 order by datefrom asc" : rst = com.ExecuteReader
        While rst.Read
            txtPayrollcode.Items.Add(rst("Payroll Code").ToString())
        End While
        rst.Close()
    End Sub

    Public Sub showEmployeeList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        Dim tablename As String = "coffeecup_reports.tblattendance" & globaluserid

        com.CommandText = "DROP table if exists " & tablename & "; " : com.ExecuteNonQuery()
        com.CommandText = "CREATE TABLE " & tablename & " select * from tblpayrollattendance where regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and employeeid in (select employeeid from tblpayrollattendancefilter where approverid='" & globaluserid & "');" : com.ExecuteNonQuery()

        msda = New MySqlDataAdapter("select e.employeeid, (select officename from tblcompoffice where officeid=e.officeid) as Office, " _
                                            + " (select departmentname from tblcompdepartments where depid=e.depid) as Department, Fullname, " _
                                            + " (select description from tblemployeetype where code = e.employeetypecode) as 'Employee Status', " _
                                            + " ifnull((select count(*) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "'),0) as 'Total Working Days', " _
                                            + " ifnull((select count(*) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and absent=0 and restday=0),0) as 'Rendered Days', " _
                                            + " ifnull((select count(*) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and absent=1),0) as Absent, " _
                                            + " ifnull((select count(*) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and halfday=1),0) as 'Half Day', " _
                                            + " ifnull((select cast(if(latetype='MINUTE',concat(sum(latecount),' Min(s)'),concat(format(60/sum(latecount),2),' Hour(s)')) as char(100)) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and absent=0),0) as 'Late Count', " _
                                            + " ifnull((select cast(if(undertimetype='MINUTE',concat(sum(undertimecount),' Min(s)'),concat(format(60/sum(undertimecount),2),' Hour(s)')) as char(100)) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and absent=0),0) as 'Undertime Count', " _
                                            + " ifnull((select cast(if(overtimetype='MINUTE',concat(ifnull(sum(overtimecount),0),' Min(s)'),concat(format(60/sum(overtimecount),2),' Hour(s)')) as char(100)) from " & tablename & " where employeeid = e.employeeid and regularday=1 and payrollcode='" & txtPayrollcode.Text & "' and absent=0 and overtimeapproved=1),0) as 'Overtime Count', " _
                                            + " (select distinct approved from " & tablename & " where payrollcode='" & txtPayrollcode.Text & "' and " & tablename & ".employeeid=e.employeeid) as Approved, " _
                                            + " (select distinct checked from " & tablename & " where payrollcode='" & txtPayrollcode.Text & "' and " & tablename & ".employeeid=e.employeeid) as Checked " _
                                            + " from tblemployees as e inner join tblpayrollbasicrate as p on e.positioncode = p.code and e.actived=1 and e.resigned=0 inner join " & tablename & "  as a on a.employeeid=e.employeeid where a.payrollcode='" & txtPayrollcode.Text & "' group by e.employeeid order by fullname asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"employeeid"})
        GridColumnAlignment(MyDataGridView, {"Office", "Employee Status", "Total Working Days", "Rendered Days", "Absent", "Half Day", "Late Count", "Undertime Count", "Overtime Count"}, DataGridViewContentAlignment.MiddleCenter)

        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i

        GridColumAutonWidth(MyDataGridView, {"Office", "Department", "Fullname"})
        For i = 0 To MyDataGridView.RowCount - 1
            If CBool(MyDataGridView.Item("Approved", i).Value()) = True Then
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = DefaultForeColor
            Else
                If CBool(MyDataGridView.Item("Checked", i).Value()) = True Then
                    MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                Else
                    MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                End If
            End If
        Next
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub txtPayrollcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtPayrollcode.SelectedIndexChanged
        showEmployeeList()
    End Sub

    Private Sub MyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentClick

    End Sub

    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        cmdApprovedAttendance.PerformClick()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/>", txtPayrollcode.Text, "", MyDataGridView, Me)
    End Sub

    Private Sub RefreshListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        showEmployeeList()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdApprovedAttendance.Click
        frmEmployeeAttendance.payrollcode.Text = txtPayrollcode.Text
        frmEmployeeAttendance.employeeid.Text = MyDataGridView.Item("employeeid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmEmployeeAttendance.Text = MyDataGridView.Item("Fullname", MyDataGridView.CurrentRow.Index).Value().ToString
        frmEmployeeAttendance.ShowDialog(Me)
    End Sub
 
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmEmployeeShift.Show(Me)
    End Sub
End Class