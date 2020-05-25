Imports System.Globalization

Public Class frmStockhouseRegistration
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtOfficeName.Text = "" Then
            MessageBox.Show("Please provide office name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOfficeName.Focus()
            Exit Sub
        ElseIf countqry("tblstockhouse", "stockhousename='" & rchar(txtOfficeName.Text) & "'") > 0 Then
            MessageBox.Show("Office name already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOfficeName.SelectAll()
            txtOfficeName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim OfficeCode As String = getStockhouseid()
            com.CommandText = "INSERT into tblstockhouse set stockhouseid='" & OfficeCode & "',  stockhousename='" & UCase(txtOfficeName.Text) & "',officeid='" & compOfficeid & "' " : com.ExecuteNonQuery()
            frmNewInventoryEntry.LoadStockhouse()
            txtOfficeName.Text = ""
            MsgBox("Office successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub
 
    Private Sub frmStockhouseRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
End Class
