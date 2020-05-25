Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmEmployees
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
       
        End If
        Return ProcessCmdKey
    End Function

    Private Sub EditEnventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEnventoryToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                If Not rw.Cells("Username").Value Is Nothing Then
                    com.CommandText = "insert into tblaccounts set fullname='" & rw.Cells("Fullname").Value.ToString & "', designation='" & UCase(rchar(rw.Cells("com_position").Value.ToString)) & "', officeid='" & compOfficeid & "', username='" & UCase(rw.Cells("Username").Value.ToString) & "',password='" & EncryptTripleDES(UCase(rw.Cells("Username").Value.ToString) + "1234") & "',datereg=current_timestamp;" : com.ExecuteNonQuery()
                End If
            Next
            frmNewInventoryEntry.LoadAccountable()
            loadEmployees()
            MsgBox("Selected accounts successfully loaded!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
    Public Sub loadEmployees()
        If txtSearch.Text = "" Then Exit Sub
        msda = New MySqlDataAdapter("select emp_id as 'Username', Fullname, com_branch as 'Branch',com_position  from tblkbemployees where (emp_id like '%" & txtSearch.Text & "%' or fullname like '%" & txtSearch.Text & "%' or com_branch like '%" & txtSearch.Text & "%' or com_position like '%" & txtSearch.Text & "%') and emp_id not in (select username from tblaccounts) order by fullname asc;", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("com_position").Visible = False
        MyDataGridView.Columns("Username").Width = 80
        GridColumnAlignment(MyDataGridView, {"Username"}, DataGridViewContentAlignment.MiddleCenter)
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            loadEmployees()
        End If
    End Sub
    
End Class
