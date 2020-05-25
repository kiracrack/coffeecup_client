Imports System.Windows.Forms

Public Class frmPOSNewTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If MessageBox.Show("Are you sure you want to create new sale transaction?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "insert into tblsalessummary set companyid='" & GlobalCompanyid & "', officeid='" & compOfficeid & "', " _
                            + " userid='" & globaluserid & "', " _
                            + " begcash='" & Val(CC(txtAmount.Text)) & "', " _
                            + " cashfrom='', " _
                            + " dateopen=current_timestamp, " _
                            + " openby='" & globaluserid & "'" : com.ExecuteNonQuery()

            If Val(CC(txtAmount.Text)) > 0 Then
                com.CommandText = "update tblaccounts set cashbeggining='" & Val(CC(txtAmount.Text)) & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
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
        txtAmount.Text = FormatNumber(qrysingledata("cashbeggining", "cashbeggining", "tblaccounts where accountid='" & globaluserid & "'"), 2)
    End Sub

End Class
