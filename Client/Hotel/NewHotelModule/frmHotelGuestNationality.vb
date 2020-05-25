Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmHotelGuestNationality
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtAgentName.Text = "" Then
            MessageBox.Show("Please provide Nationality!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAgentName.Focus()
            Exit Sub
        ElseIf countqry("tblguestnationality", "nationality='" & rchar(txtAgentName.Text) & "'") > 0 Then
            MessageBox.Show("Nationality name already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAgentName.SelectAll()
            txtAgentName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT into tblguestnationality set nationality='" & UCase(txtAgentName.Text) & "'" : com.ExecuteNonQuery()
            LoadNationality()
            txtAgentName.Text = ""
            MsgBox("Nationality successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmHotelAddAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadNationality()
    End Sub
    Public Sub LoadNationality()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT id, Nationality FROM `tblguestnationality` order by nationality asc;", conn)
        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id"})
    End Sub

    Private Sub cmdRefreshCompanion_Click(sender As Object, e As EventArgs) Handles cmdRefreshCompanion.Click
        LoadNationality()
    End Sub

    Private Sub cmdRemoveSelected_Click(sender As Object, e As EventArgs) Handles cmdRemoveSelected.Click
        If MessageBox.Show("Are you sure you want to removed selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "delete from tblguestnationality where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadNationality()
        End If
    End Sub
End Class
