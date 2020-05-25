Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmEmployeeShift
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmEmployeeAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        PopulateGridViewControls("employeeid", 0, "", MyDataGridView, False, True)
        PopulateGridViewControls("Employee Name", 200, "", MyDataGridView, True, True)
        PopulateGridViewControls("Shift Schedule", 70, "COMBO", MyDataGridView, True, False)
        PopulateGridViewControls("shiftcode", 0, "", MyDataGridView, False, True)
        LoadEmployees()
    End Sub

    Public Sub LoadEmployees()
        MyDataGridView.Rows.Clear()
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblemployees where resigned=0 and actived=1 and employeeid in (select employeeid from tblpayrollattendancefilter where approverid='" & globaluserid & "') order by fullname asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                MyDataGridView.Rows.Add(.Rows(cnt)("employeeid"), .Rows(cnt)("fullname").ToString(), "", "")
            End With
        Next
        For rowIndex As Integer = 0 To MyDataGridView.Rows.Count - 1
            LoadToGridComboBoxCell("Shift Schedule", rowIndex, "select description from tblpayrollshiftsettings", "description", False, MyDataGridView)
            com.CommandText = "select *,ifnull((select description from tblpayrollshiftsettings where shiftcode=tblemployees.shiftcode),'') as shift from tblemployees where employeeid='" & MyDataGridView.Rows(rowIndex).Cells("employeeid").Value & "'" : rst = com.ExecuteReader
            While rst.Read
                If rst("shift").ToString <> "" Then
                    MyDataGridView.Rows(rowIndex).Cells("Shift Schedule").Value = rst("shift").ToString
                    MyDataGridView.Rows(rowIndex).Cells("shiftcode").Value = rst("shiftcode").ToString
                End If
            End While
            rst.Close()

        Next
    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles MyDataGridView.EditingControlShowing
        If MyDataGridView.CurrentCell.ColumnIndex = 2 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        com.CommandText = "select shiftcode from tblpayrollshiftsettings where description='" & combo.SelectedItem & "'" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Item("shiftcode", MyDataGridView.CurrentRow.Index).Value = rst("shiftcode").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If MessageBox.Show("Are you sure you want to continue? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For rowIndex As Integer = 0 To MyDataGridView.Rows.Count - 1
                com.CommandText = "update tblemployees set shiftcode='" & MyDataGridView.Rows(rowIndex).Cells("shiftcode").Value.ToString & "' where employeeid='" & MyDataGridView.Rows(rowIndex).Cells("employeeid").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            MessageBox.Show("Employee Shift Successfully Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      
    End Sub
End Class