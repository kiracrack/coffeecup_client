Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOScashDonimination
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
    End Sub

    Public Sub FilterTransaction()
        dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select trnid,date_format(timeposted,'%r') as 'Time Posted', totalbills as 'Total Bills',  totalcoins as 'Total Coins', totalamount as 'Total' from tblsalescashdenomination where trnsumcode = '" & globalSalesTrnCOde & "' union all " _
                                    + " select '','', sum(totalbills),sum(totalcoins),sum(totalamount) from tblsalescashdenomination where trnsumcode = '" & globalSalesTrnCOde & "') as s", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("trnid").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Total Bills", "Total Coins", "Total"})
        GridColumnAlignment(MyDataGridView, {"Time Posted"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Total Bills", "Total Coins", "Total"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If Val(CC(txtTotalAmount.Text)) <= 0 Then
            MessageBox.Show("Please enter any of amount", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTotalOneThousand.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblsalescashdenomination set trnsumcode='" & globalSalesTrnCOde & "', onethousand='" & Val(CC(txtCountOnethousand.Text)) & "', fivehundred='" & Val(CC(txtCountFiveHundred.Text)) & "',twohundred='" & Val(CC(txtCountTwoHundred.Text)) & "',onehundred='" & Val(CC(txtCountOneHundred.Text)) & "', fithty='" & Val(CC(txtCountFifty.Text)) & "',twenty='" & Val(CC(txtCountTwenty.Text)) & "',ten='" & Val(CC(txtCountTen.Text)) & "', five='" & Val(CC(txtCountFive.Text)) & "',one='" & Val(CC(txtCountOne.Text)) & "',others='" & Val(CC(txtTotalOthers.Text)) & "',totalbills='" & Val(CC(txtTotalBills.Text)) & "', totalcoins='" & Val(CC(txtTotalCoins.Text)) & "', totalamount='" & Val(CC(txtTotalAmount.Text)) & "', timeposted=current_time" : com.ExecuteNonQuery()
            If MessageBox.Show("Do you want to print cash blotter denomination? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                PrintPOSCashDenomination(txtCountOnethousand.Text, txtCountFiveHundred.Text, txtCountTwoHundred.Text, txtCountOneHundred.Text, txtCountFifty.Text, txtCountTwenty.Text, txtCountTen.Text, txtCountFive.Text, txtCountOne.Text, txtTotalOthers.Text, txtTotalBills.Text, txtTotalCoins.Text, txtTotalAmount.Text)
            End If
            MsgBox("Cash denomination successfully saved!", MsgBoxStyle.Information)
            FilterTransaction()
            Me.Close()
        End If
    End Sub

   

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "DELETE from tblsalescashdenomination where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

#Region "C A L C U L A T O R"
    Public Sub Calculator()
        txtTotalOneThousand.Text = FormatNumber(Val(CC(txtOneThousand.Text)) * Val(CC(txtCountOnethousand.Text)), 2)
        txtTotalFiveHundred.Text = FormatNumber(Val(CC(txtFiveHundred.Text)) * Val(CC(txtCountFiveHundred.Text)), 2)
        txtTotalTwoHundred.Text = FormatNumber(Val(CC(txtTwoHundred.Text)) * Val(CC(txtCountTwoHundred.Text)), 2)
        txtTotalOneHundred.Text = FormatNumber(Val(CC(txtOneHundred.Text)) * Val(CC(txtCountOneHundred.Text)), 2)
        txtTotalFifty.Text = FormatNumber(Val(CC(txtFifty.Text)) * Val(CC(txtCountFifty.Text)), 2)
        txtTotalTwenty.Text = FormatNumber(Val(CC(txtTwenty.Text)) * Val(CC(txtCountTwenty.Text)), 2)
        txtTotalTen.Text = FormatNumber(Val(CC(txtTen.Text)) * Val(CC(txtCountTen.Text)), 2)
        txtTotalFive.Text = FormatNumber(Val(CC(txtFive.Text)) * Val(CC(txtCountFive.Text)), 2)
        txtTotalOne.Text = FormatNumber(Val(CC(txtOne.Text)) * Val(CC(txtCountOne.Text)), 2)

        txtTotalBills.Text = FormatNumber(Val(CC(txtTotalOneThousand.Text)) + Val(CC(txtTotalFiveHundred.Text)) + Val(CC(txtTotalTwoHundred.Text)) + Val(CC(txtTotalOneHundred.Text)) + Val(CC(txtTotalFifty.Text)) + Val(CC(txtTotalTwenty.Text)), 2)
        txtTotalCoins.Text = FormatNumber(Val(CC(txtTotalTen.Text)) + Val(CC(txtTotalFive.Text)) + Val(CC(txtTotalOne.Text)) + Val(CC(txtTotalOthers.Text)), 2)
        txtTotalAmount.Text = FormatNumber(Val(CC(txtTotalBills.Text)) + Val(CC(txtTotalCoins.Text)), 2)

    End Sub
#End Region

    Private Sub txtCountTxtChanged_TextChanged(sender As Object, e As EventArgs) Handles txtCountOnethousand.TextChanged, txtCountFiveHundred.TextChanged, txtCountTwoHundred.TextChanged, txtCountOneHundred.TextChanged, txtCountFifty.TextChanged, txtCountTwenty.TextChanged, txtCountTen.TextChanged, txtCountFive.TextChanged, txtCountOne.TextChanged, txtTotalOthers.TextChanged
        Calculator()
    End Sub


#Region "INPUT FILTER"

    Private Sub txtCountOnethousand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountOnethousand.KeyPress
        InputNumberOnly(txtCountOnethousand, e)
    End Sub
    Private Sub txtCountFiveHundred_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountFiveHundred.KeyPress
        InputNumberOnly(txtCountFiveHundred, e)
    End Sub
    Private Sub txtCountTwoHundred_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountTwoHundred.KeyPress
        InputNumberOnly(txtCountTwoHundred, e)
    End Sub
    Private Sub txtCountOneHundred_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountOneHundred.KeyPress
        InputNumberOnly(txtCountOneHundred, e)
    End Sub
    Private Sub txtCountFifty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountFifty.KeyPress
        InputNumberOnly(txtCountFifty, e)
    End Sub
    Private Sub txtCountTwenty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountTwenty.KeyPress
        InputNumberOnly(txtCountTwenty, e)
    End Sub
    Private Sub txtCountTen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountTen.KeyPress
        InputNumberOnly(txtCountTen, e)
    End Sub
    Private Sub txtCountFive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountFive.KeyPress
        InputNumberOnly(txtCountFive, e)
    End Sub
    Private Sub txtCountOne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountOne.KeyPress
        InputNumberOnly(txtCountFive, e)
    End Sub
    Private Sub txtTotalOthers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalOthers.KeyPress
        InputNumberOnly(txtTotalOthers, e)
    End Sub

    Private Sub txtCountOnethousand_LostFocus(sender As Object, e As EventArgs) Handles txtCountOnethousand.LostFocus
        If txtCountOnethousand.Text = "" Then
            txtCountOnethousand.Text = "0"
        End If
    End Sub
    Private Sub txtCountFiveHundred_LostFocus(sender As Object, e As EventArgs) Handles txtCountFiveHundred.LostFocus
        If txtCountFiveHundred.Text = "" Then
            txtCountFiveHundred.Text = "0"
        End If
    End Sub
    Private Sub txtCountTwoHundred_LostFocus(sender As Object, e As EventArgs) Handles txtCountTwoHundred.LostFocus
        If txtCountTwoHundred.Text = "" Then
            txtCountTwoHundred.Text = "0"
        End If
    End Sub
    Private Sub txtCountOneHundred_LostFocus(sender As Object, e As EventArgs) Handles txtCountOneHundred.LostFocus
        If txtCountOneHundred.Text = "" Then
            txtCountOneHundred.Text = "0"
        End If
    End Sub
    Private Sub txtCountFifty_LostFocus(sender As Object, e As EventArgs) Handles txtCountFifty.LostFocus
        If txtCountFifty.Text = "" Then
            txtCountFifty.Text = "0"
        End If
    End Sub
    Private Sub txtCountTwenty_LostFocus(sender As Object, e As EventArgs) Handles txtCountTwenty.LostFocus
        If txtCountTwenty.Text = "" Then
            txtCountTwenty.Text = "0"
        End If
    End Sub
    Private Sub txtCountTen_LostFocus(sender As Object, e As EventArgs) Handles txtCountTen.LostFocus
        If txtCountTen.Text = "" Then
            txtCountTen.Text = "0"
        End If
    End Sub
    Private Sub txtCountFive_LostFocus(sender As Object, e As EventArgs) Handles txtCountFive.LostFocus
        If txtCountFive.Text = "" Then
            txtCountFive.Text = "0"
        End If
    End Sub
    Private Sub txtCountOne_LostFocus(sender As Object, e As EventArgs) Handles txtCountOne.LostFocus
        If txtCountOne.Text = "" Then
            txtCountOne.Text = "0"
        End If
    End Sub
    Private Sub txtTotalOthers_LostFocus(sender As Object, e As EventArgs) Handles txtTotalOthers.LostFocus
        If txtTotalOthers.Text = "" Then
            txtTotalOthers.Text = "0.00"
        End If
    End Sub
#End Region
  
    Private Sub frmPOScashDonimination_HelpButtonClicked(sender As Object, e As ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        MsgBox("To view this for using shortcut key is Ctrl+B")
    End Sub
End Class