Imports System.Windows.Forms

Public Class frmCheckinVIP
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtVIPCardNo.Text = "" Then
            MessageBox.Show("Please enter vip card no", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter vip card no", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to activate vip card?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "insert into tblsalesvipguest set cifid='" & cifid.Text & "', guestid='" & guestid.Text & "', checkin=1,datein=current_timestamp,companion='" & txtCompanion.Text & "',activateby='" & globalfullname & "' " : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblclientaccounts set vipactivated=1 where cifid='" & cifid.Text & "'" : com.ExecuteNonQuery()
            frmVIPOnline.ShowItemList()
            MessageBox.Show("VIP Card Successfully Activated", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub frmUserlogoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub txtBackdateRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVIPCardNo.KeyPress
        If e.KeyChar() = Chr(13) Then
            If countqry("tblhotelguest inner join tblclientaccounts on tblhotelguest.guestid=tblclientaccounts.vipguestid", " vipcardno='" & txtVIPCardNo.Text & "' and blocked=1") > 0 Then
                MessageBox.Show("VIP Card was blocked! please ask assistance to customer service", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If countqry("tblhotelguest inner join tblclientaccounts on tblhotelguest.guestid=tblclientaccounts.vipguestid", " vipactivated=0 and blocked=0 and vipcardno='" & txtVIPCardNo.Text & "'") > 0 Then
                com.CommandText = "select * from tblhotelguest inner join tblclientaccounts on tblhotelguest.guestid=tblclientaccounts.vipguestid where vipactivated=0 and blocked=0 and vipcardno='" & txtVIPCardNo.Text & "'" : rst = com.ExecuteReader
                While rst.Read
                    cifid.Text = rst("cifid").ToString
                    guestid.Text = rst("guestid").ToString
                    txtCompanyName.Text = rst("fullname").ToString
                End While
                rst.Close()
                txtCompanion.Focus()
            Else
                MessageBox.Show("No VIP card found on the list", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        End If
    End Sub

    Private Sub txtCompanion_GotFocus(sender As Object, e As EventArgs) Handles txtCompanion.GotFocus
        Me.AcceptButton = OK_Button
    End Sub

    Private Sub txtCompanion_LostFocus(sender As Object, e As EventArgs) Handles txtCompanion.LostFocus
        Me.AcceptButton = Nothing
    End Sub

  
End Class
