Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSMultiPayments_backup
    Public TransactionDone As Boolean = False
    Dim DefaultglItemLocation As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then
            TabControl1.SelectedIndex = 0

        ElseIf keyData = Keys.F2 Then
            TabControl1.SelectedIndex = 1

        ElseIf keyData = Keys.F3 Then
            TabControl1.SelectedIndex = 2

        ElseIf keyData = Keys.F4 Then
            TabControl1.SelectedIndex = 3

        End If
        Return ProcessCmdKey
    End Function
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            AcceptButton = cmdConfirm
        Else
            AcceptButton = Nothing
        End If
    End Sub
    Private Sub frmPOSMultiPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        TabControl1.SelectedIndex = 0
        txtpaymentchange.Text = ""
        CardBankAccount()
        DepositBankAccount()
        LoadPaymentSummary()
        LoadCheckPayment()
        LoadCardPayment()
        LoadBankDepositPayment()
    End Sub

#Region "PAYMENT SUMMARY"
    Private Sub txtCashPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashPayment.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtCashPayment, e)
        End If
    End Sub

    Private Sub txtCashPayment_TextChanged(sender As Object, e As EventArgs) Handles txtCashPayment.TextChanged
        txtTotalPayment.Text = FormatNumber(Val(CC(txtCashPayment.Text)) + Val(CC(txtTotalOtherPayment.Text)), 2)
        If Val(CC(txtCashPayment.Text)) > 0 Then
            txtpaymentchange.Text = Val(CC(txtTotalPayment.Text)) - Val(CC(txtTotalOnScreen.Text))
        End If
    End Sub
    Public Sub LoadPaymentSummary()
        txtTotalOtherPayment.Text = FormatNumber(Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & batchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & batchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & batchcode.Text & "'")), 2)
        txtTotalPayment.Text = FormatNumber(Val(CC(txtCashPayment.Text)) + Val(CC(txtTotalOtherPayment.Text)), 2)
        txtCashPayment.Text = FormatNumber(Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescashpayment where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & batchcode.Text & "'")), 2)
        If Val(CC(txtTotalOtherPayment.Text)) > Val(CC(txtTotalOnScreen.Text)) Then
            txtCashPayment.ReadOnly = True
            txtCashPayment.Text = "0.00"
        Else
            txtCashPayment.ReadOnly = False
        End If
        If Val(CC(txtCashPayment.Text)) > 0 Then
            txtpaymentchange.Text = Val(CC(txtTotalPayment.Text)) - Val(CC(txtTotalOnScreen.Text))
        End If
    End Sub
#End Region

#Region "CHECK PAYMENT"

    Private Sub txtCheckNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheckNumber.KeyPress
        InputNumberOnly(txtCardNumber, e)
    End Sub
    Public Sub LoadCheckPayment()
        MyDataGridView_check.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select trnid, checkno as 'Check No.', checkdetails as 'Check Details',Remarks, Amount from tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & batchcode.Text & "' union all " _
                                    + " select  '','','','Total', sum(Amount) from tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & batchcode.Text & "') as s;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_check.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_check, {"trnid"})
        GridCurrencyColumn(MyDataGridView_check, {"Amount"})
        GridColumnAlignment(MyDataGridView_check, {"Check No."}, DataGridViewContentAlignment.MiddleCenter)

        MyDataGridView_check.Rows(MyDataGridView_check.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_check.Rows(MyDataGridView_check.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_check.Rows(MyDataGridView_check.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoadPaymentSummary()
    End Sub
    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        If txtCheckNumber.Text = "" Then
            MessageBox.Show("Please enter check number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckNumber.Focus()
            Exit Sub
        ElseIf txtCheckDetails.Text = "" Then
            MessageBox.Show("Please enter check details!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckDetails.Focus()
            Exit Sub
        ElseIf txtCheckName.Text = "" Then
            MessageBox.Show("Please enter check person name!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckName.Focus()
            Exit Sub
        ElseIf Val(cc(txtCheckAmount.Text)) <= 0 Then
            MessageBox.Show("Please enter check amount!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckAmount.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into tblsaleschecktransaction set trnsumcode='" & globalSalesTrnCOde & "', accountno='" & cifid.Text & "',referenceno='" & batchcode.Text & "',checkno='" & txtCheckNumber.Text & "',checkdetails='" & rchar(txtCheckDetails.Text) & "',remarks='" & rchar(txtCheckName.Text) & "',amount='" & Val(CC(txtCheckAmount.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "';" : com.ExecuteNonQuery()
        txtCheckNumber.Text = "" : txtCheckDetails.Text = "" : txtCheckName.Text = "" : txtCheckAmount.Text = "0.00" : txtCheckNumber.Focus() : LoadCheckPayment()
    End Sub
    Private Sub txtCheckAmount_GotFocus(sender As Object, e As EventArgs) Handles txtCheckAmount.GotFocus
        AcceptButton = cmdCheck
    End Sub
    Private Sub txtCheckAmount_LostFocus(sender As Object, e As EventArgs) Handles txtCheckAmount.LostFocus
        AcceptButton = Nothing
    End Sub
#End Region

#Region "CARD PAYMENT"
    Public Sub CardBankAccount()
        com.CommandText = "select * from tblbankaccounts where cashaccount=0 order by accountname asc" : rst = com.ExecuteReader
        txtCardPOSBankAccounts.Items.Clear()
        While rst.Read
            txtCardPOSBankAccounts.Items.Add(New ComboBoxItem(rst("bankname").ToString, rst("bankcode").ToString))
        End While
        rst.Close()

        txtCardPOSBankAccounts.Text = defaultCombobox(txtCardPOSBankAccounts, Me, False)
        banknumber.Text = defaultCombobox(txtCardPOSBankAccounts, Me, True)
    End Sub

    Private Sub txtcardTraceNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcardTraceNumber.KeyPress
        If e.KeyChar = Chr(13) Then
            InputNumberOnly(txtcardTraceNumber, e)
        End If
    End Sub

    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress
        InputNumberOnly(txtCardNumber, e)
    End Sub

    Private Sub txtBankAccounts_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCardPOSBankAccounts.SelectedValueChanged
        If txtCardPOSBankAccounts.Text <> "" Then
            banknumber.Text = DirectCast(txtCardPOSBankAccounts.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            banknumber.Text = ""
        End If
    End Sub
    Public Sub LoadCardPayment()
        MyDataGridView_Card.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select trnid, cardnumber as 'Card No.', carddetails as 'Card Details',tracenumber as 'Trace Number', Amount, (select bankname from tblbankaccounts where bankcode=tblsalescardtransaction.bankaccount) as 'POS Merchant' from tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & batchcode.Text & "' union all " _
                                    + " select  '','','','Total', sum(Amount),'' from tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & batchcode.Text & "') as s;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Card.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Card, {"trnid"})
        GridCurrencyColumn(MyDataGridView_Card, {"Amount"})
        GridColumnAlignment(MyDataGridView_Card, {"Card No.", "Trace Number"}, DataGridViewContentAlignment.MiddleCenter)

        MyDataGridView_Card.Rows(MyDataGridView_Card.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Card.Rows(MyDataGridView_Card.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Card.Rows(MyDataGridView_Card.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoadPaymentSummary()
    End Sub
    Private Sub cmdCard_Click(sender As Object, e As EventArgs) Handles cmdCard.Click
        If txtCardNumber.Text = "" Then
            MessageBox.Show("Please enter card number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCardNumber.Focus()
            Exit Sub
        ElseIf txtCardDetails.Text = "" Then
            MessageBox.Show("Please enter card details!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCardDetails.Focus()
            Exit Sub
        ElseIf txtCardHolderName.Text = "" Then
            MessageBox.Show("Please enter card holder name!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCardHolderName.Focus()
            Exit Sub
        ElseIf txtCardPOSBankAccounts.Text = "" Then
            MessageBox.Show("Please select POS merchant!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCardPOSBankAccounts.Focus()
            Exit Sub
        ElseIf txtcardTraceNumber.Text = "" Then
            MessageBox.Show("Please enter card trace number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcardTraceNumber.Focus()
            Exit Sub
        ElseIf Val(CC(txtCardAmount.Text)) <= 0 Then
            MessageBox.Show("Please enter card transaction amount!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCardAmount.Focus()
            Exit Sub
        End If
        If txtCardPOSBankAccounts.Text <> "" Then
            SaveDefaultComboItem(txtCardPOSBankAccounts, txtCardPOSBankAccounts.Text, DirectCast(txtCardPOSBankAccounts.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        End If
        com.CommandText = "insert into tblsalescardtransaction set trnsumcode='" & globalSalesTrnCOde & "', accountno='" & cifid.Text & "',referenceno='" & batchcode.Text & "',cardnumber='" & txtCardNumber.Text & "',carddetails='" & rchar(txtCardDetails.Text) & "', tracenumber='" & txtcardTraceNumber.Text & "',bankaccount='" & banknumber.Text & "',remarks='" & rchar(txtCardHolderName.Text) & "',amount='" & Val(CC(txtCardAmount.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "';" : com.ExecuteNonQuery()
        txtCardNumber.Text = "" : txtCardDetails.Text = "" : txtcardTraceNumber.Text = "" : txtCardHolderName.Text = "" : txtCardAmount.Text = "0.00" : txtCardNumber.Focus() : LoadCardPayment()

    End Sub
    Private Sub txtCardAmount_GotFocus(sender As Object, e As EventArgs) Handles txtCardAmount.GotFocus
        AcceptButton = cmdCard
    End Sub
    Private Sub txtCardAmount_LostFocus(sender As Object, e As EventArgs) Handles txtCardAmount.LostFocus
        AcceptButton = Nothing
    End Sub
#End Region

#Region "BANK DEPOSIT"
    Public Sub DepositBankAccount()
        com.CommandText = "select * from tblbankaccounts where cashaccount=0 order by accountname asc" : rst = com.ExecuteReader
        txtDepositBankAccount.Items.Clear()
        While rst.Read
            txtDepositBankAccount.Items.Add(New ComboBoxItem(rst("bankname").ToString, rst("bankcode").ToString))
        End While
        rst.Close()

        txtDepositBankAccount.Text = defaultCombobox(txtDepositBankAccount, Me, False)
        txtDepositBankCode.Text = defaultCombobox(txtDepositBankAccount, Me, True)
    End Sub
    Private Sub txtDepositBankAccount_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDepositBankAccount.SelectedValueChanged
        If txtDepositBankAccount.Text <> "" Then
            txtDepositBankCode.Text = DirectCast(txtDepositBankAccount.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            txtDepositBankCode.Text = ""
        End If
    End Sub

    Public Sub LoadBankDepositPayment()
        MyDataGridView_BankDeposit.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select trnid, (select bankname from tblbankaccounts where bankcode=tblsalesdepositpaymenttransaction.bankaccount) as 'Bank Account', referenceno as 'Reference No.', Amount from tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & batchcode.Text & "' union all " _
                                    + " select  '', '','Total', sum(Amount) from tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & batchcode.Text & "') as s;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_BankDeposit.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_BankDeposit, {"trnid"})
        GridCurrencyColumn(MyDataGridView_BankDeposit, {"Amount"})
        GridColumnAlignment(MyDataGridView_BankDeposit, {"Reference No."}, DataGridViewContentAlignment.MiddleCenter)

        MyDataGridView_BankDeposit.Rows(MyDataGridView_BankDeposit.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_BankDeposit.Rows(MyDataGridView_BankDeposit.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_BankDeposit.Rows(MyDataGridView_BankDeposit.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoadPaymentSummary()
    End Sub
    Private Sub cmdBankDeposit_Click(sender As Object, e As EventArgs) Handles cmdBankDeposit.Click
        If txtDepositBankAccount.Text = "" Then
            MessageBox.Show("Please select deposit bank account!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDepositBankAccount.Focus()
            Exit Sub
        End If

        If txtDepositBankAccount.Text <> "" Then
            SaveDefaultComboItem(txtDepositBankAccount, txtDepositBankAccount.Text, DirectCast(txtDepositBankAccount.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        End If

        com.CommandText = "insert into tblsalesdepositpaymenttransaction set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & batchcode.Text & "',bankaccount='" & txtDepositBankCode.Text & "',referenceno='" & frmPOSPaymentTypeDetails.txtDepositRefNumber.Text & "',amount='" & Val(CC(txtDepositAmount.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        txtDepositRefNumber.Text = "" : txtDepositAmount.Text = "0.00" : txtDepositBankAccount.Focus() : LoadBankDepositPayment()

    End Sub

    Private Sub txtDepositAmount_GotFocus(sender As Object, e As EventArgs) Handles txtDepositAmount.GotFocus
        AcceptButton = cmdBankDeposit
    End Sub
    Private Sub txtDepositAmount_LostFocus(sender As Object, e As EventArgs) Handles txtDepositAmount.LostFocus
        AcceptButton = Nothing
    End Sub
#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to cancel selected transaction? " & Environment.NewLine & Environment.NewLine & "Note: canceling payment transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                If TabControl1.SelectedIndex = 1 Then
                    For Each rw As DataGridViewRow In MyDataGridView_check.SelectedRows
                        com.CommandText = "UPDATE tblsaleschecktransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "', datecancelled=current_timestamp where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                    Next
                    LoadCheckPayment()
                ElseIf TabControl1.SelectedIndex = 2 Then
                    For Each rw As DataGridViewRow In MyDataGridView_Card.SelectedRows
                        com.CommandText = "UPDATE tblsalescardtransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "', datecancelled=current_timestamp where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                    Next
                    LoadCardPayment()
                ElseIf TabControl1.SelectedIndex = 3 Then
                    For Each rw As DataGridViewRow In MyDataGridView_BankDeposit.SelectedRows
                        com.CommandText = "UPDATE tblsalesdepositpaymenttransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "', datecancelled=current_timestamp where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                    Next
                    LoadBankDepositPayment()
                End If
            End If
        End If

    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        Me.Close()
    End Sub

    Private Sub frmPOSMultiPayments_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Val(CC(txtCashPayment.Text)) > 0 Then
            If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & batchcode.Text & "'") > 0 Then
                com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtCashPayment.Text)) & "',cashchange='" & Val(CC(txtpaymentchange.Text)) & "', datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & batchcode.Text & "',amount='" & Val(CC(txtDepositAmount.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
        End If
        If mode.Text = "pos" Then
            frmPOSPaymentConfirmation.txtAmountTender.Text = txtTotalPayment.Text
            frmPOSPaymentConfirmation.cmdConfirmPayment.Focus()

        ElseIf mode.Text = "partial" Then
            frmPOSChargetoClientAcct.txtAmountTender.Text = txtTotalPayment.Text
            frmPOSChargetoClientAcct.cmdConfirmPayment.Focus()

        ElseIf mode.Text = "other" Then
            frmPOSOtherTransaction.txtAmountTender.Text = txtTotalPayment.Text
            frmPOSOtherTransaction.cmdConfirmPayment.Focus()

        ElseIf mode.Text = "hotelpayment" Then
            frmHotelPaymentPosting.txtAmountTender.Text = txtTotalPayment.Text
            frmHotelPaymentPosting.cmdConfirmPayment.Focus()

        
        Else
            frmPOSClientAccountPayment.txtAmountTender.Text = txtTotalPayment.Text
            frmPOSClientAccountPayment.txtAmountTender.Focus()
            frmPOSClientAccountPayment.txtAmountTender.SelectAll()
        End If

    End Sub

End Class