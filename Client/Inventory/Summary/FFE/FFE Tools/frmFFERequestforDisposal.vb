Imports System.Globalization

Public Class frmFFERequestforDisposal
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtRequestLevel.Text = "" Then
            MessageBox.Show("Please select Approving level!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRequestLevel.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblinventoryffe set disposalrequested=1, disposalrequestcorporatelevel=" & txtRequestLevel.SelectedIndex & ",disposaldaterequested=current_timestamp,disposalrequestedby='" & globaluserid & "', flaged=1, lockedediting=1, flagedreason='REQUESTED FOR DISPOSAL' where ffecode='" & txtFFECode.Text & "'" : com.ExecuteNonQuery()
            LogFFEHistory(txtFFECode.Text, "requested for disposal")
            MessageBox.Show("Disposal successfully requested!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmInventoryFFE.ViewLocalInventoryFFE()
            Me.Close()
        End If
    End Sub

    Private Sub frmStockhouseRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If compCorporateoffice = True Then
            txtRequestLevel.SelectedIndex = 1
            txtRequestLevel.Enabled = False
        Else
            txtRequestLevel.SelectedIndex = -1
            txtRequestLevel.Enabled = True
        End If
    End Sub
End Class
