Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmEmployeeAttendance
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmEmployeeAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadAttendance()
    End Sub
    Public Sub LoadAttendance()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        If countqry("tblpayrollattendance", "payrollcode='" & payrollcode.Text & "' and employeeid='" & employeeid.Text & "' and approved=1") > 0 Then
            msda = New MySqlDataAdapter("call sp_payrollcomputeattendance(FALSE,'" & payrollcode.Text & "','" & employeeid.Text & "')", conn)
        Else
            msda = New MySqlDataAdapter("call sp_payrollcomputeattendance(TRUE,'" & payrollcode.Text & "','" & employeeid.Text & "')", conn)
        End If
        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id"})
        GridCurrencyColumn(MyDataGridView, {"RenderedHours"})
        GridColumnAlignment(MyDataGridView, {"AttendanceDate", "RenderedHours", "DayOfWeek", "ShiftSchedule", "MorningIn", "MorningOut", "NoonIn", "NoonOut", "OvertimeIn", "OvertimeOut", "RenderedHours", "Late", "Undertime", "Overtime"}, DataGridViewContentAlignment.MiddleCenter)
        GridDisableColumn(MyDataGridView, {"AttendanceDate", "DayOfWeek", "ShiftSchedule", "RestDay", "Absent", "HalfDay", "MorningIn", "MorningOut", "NoonIn", "NoonOut", "OvertimeIn", "OvertimeOut", "RenderedHours", "Late", "Undertime", "Overtime", "ApprovedOvertime"})

    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub MyDataGridView_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles MyDataGridView.RowPrePaint
        If CBool(MyDataGridView.Rows(e.RowIndex).Cells("Absent").Value) = True Then
            MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        ElseIf MyDataGridView.Rows(e.RowIndex).Cells("DayOfWeek").Value.ToString = "SUNDAY" Then
            MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green
        ElseIf CBool(MyDataGridView.Rows(e.RowIndex).Cells("HalfDay").Value) = True Then
            MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Blue
        Else
            MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If MessageBox.Show("Are you sure you want to continue? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To MyDataGridView.RowCount - 1
                com.CommandText = "update tblpayrollattendance set restday=" & CBool(MyDataGridView.Item("RestDay", I).Value().ToString) & ", " _
                           + " absent=" & CBool(MyDataGridView.Item("Absent", I).Value().ToString) & ", " _
                           + " halfday=" & CBool(MyDataGridView.Item("HalfDay", I).Value().ToString) & ", " _
                           + " overtimeapproved=" & CBool(MyDataGridView.Item("ApprovedOvertime", I).Value().ToString) & ", " _
                           + " renderedcount='" & Val(MyDataGridView.Item("RenderedHours", I).Value().ToString) & "'," _
                           + " latecount='" & Val(MyDataGridView.Item("Late", I).Value().ToString) & "', " _
                           + " undertimecount='" & Val(MyDataGridView.Item("Undertime", I).Value().ToString) & "', " _
                           + " overtimecount='" & Val(MyDataGridView.Item("Overtime", I).Value().ToString) & "', " _
                           + " remarks='" & rchar(MyDataGridView.Item("Remarks", I).Value().ToString) & "', " _
                           + " checked=1, checkedby='" & globaluserid & "', approved=0, approvedby='' " _
                           + " where id='" & MyDataGridView.Item("id", I).Value().ToString & "'" : com.ExecuteNonQuery()
            Next
            frmEmployeeList.showEmployeeList()
            MessageBox.Show("Attendance was successfull Overide!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub ShowPicture(ByVal empid As String, ByVal logindate As String)
        com.CommandText = "select * from "  & sqlfiledir & ".tblattendanceimage where employeeid='" & empid & "' and logindate='" & logindate & "'" : rst = com.ExecuteReader
        While rst.Read
            pic_morning_1.Image = convertSQlImage("1st_timein")
            pic_morning_2.Image = convertSQlImage("1st_timeout")
            pic_afternoon_1.Image = convertSQlImage("2nd_timein")
            pic_afternoon_2.Image = convertSQlImage("2nd_timeout")
            pic_overtime_1.Image = convertSQlImage("3rd_timein")
            pic_overtime_2.Image = convertSQlImage("3rd_timeout")
        End While
        rst.Close()
    End Sub
    Public Function convertSQlImage(ByVal fld As String) As Image
        If rst(fld).ToString <> "" Then
            imgBytes = CType(rst(fld), Byte())
            stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
            img = Image.FromStream(stream)
            convertSQlImage = img
        End If
    End Function

    Private Sub MyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentClick
        ShowPicture(employeeid.Text, ConvertDate(MyDataGridView.Item("AttendanceDate", MyDataGridView.CurrentRow.Index).Value().ToString()))
    End Sub

    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        ShowPicture(employeeid.Text, ConvertDate(MyDataGridView.Item("AttendanceDate", MyDataGridView.CurrentRow.Index).Value().ToString()))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class