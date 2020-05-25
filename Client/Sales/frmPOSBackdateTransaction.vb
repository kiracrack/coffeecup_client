Imports System.Windows.Forms

Public Class frmPOSBackdateTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtDateTransaction.Value = Now Then
            MessageBox.Show("Back date transaction cannot proceed with current date! Please select other date except today", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtBackdateRemarks.Text = "" Then
            MessageBox.Show("Please enter back date remarks", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to create new sale transaction?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "insert into tblsalessummary set companyid='" & GlobalCompanyid & "',  officeid='" & compOfficeid & "', " _
                            + " backdatetrn=1, backdate='" & ConvertDate(txtDateTransaction.Value) & "', backdateremarks='" & rchar(txtBackdateRemarks.Text) & "'," _
                            + " userid='" & globaluserid & "', " _
                            + " begcash='0', " _
                            + " dateopen=current_timestamp, " _
                            + " cashfrom='', " _
                            + " openby='" & globaluserid & "'" : com.ExecuteNonQuery()

            LoadAccountDetails(globaluserid)
            MainForm.ValidateModule()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        formclose = False
    End Sub

    Private Sub frmUserlogoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtDateTransaction.MaxDate = Now.AddDays(-1)
    End Sub
End Class
