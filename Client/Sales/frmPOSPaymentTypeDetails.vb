Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSPaymentTypeDetails
    Public TransactionDone As Boolean = False
    Dim DefaultglItemLocation As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        com.CommandText = "select * from tblbankaccounts where cashaccount=0 order by accountname asc" : rst = com.ExecuteReader
        txtCardPOSBankAccounts.Items.Clear()
        While rst.Read
            txtCardPOSBankAccounts.Items.Add(New ComboBoxItem(rst("bankname").ToString, rst("bankcode").ToString))
        End While
        rst.Close()

        com.CommandText = "select * from tblbankaccounts where cashaccount=0 order by accountname asc" : rst = com.ExecuteReader
        txtDepositBankAccount.Items.Clear()
        While rst.Read
            txtDepositBankAccount.Items.Add(New ComboBoxItem(rst("bankname").ToString, rst("bankcode").ToString))
        End While
        rst.Close()

        txtCardPOSBankAccounts.Text = defaultCombobox(txtCardPOSBankAccounts, Me, False)
        banknumber.Text = defaultCombobox(txtCardPOSBankAccounts, Me, True)

        txtDepositBankAccount.Text = defaultCombobox(txtDepositBankAccount, Me, False)
        txtDepositBankCode.Text = defaultCombobox(txtDepositBankAccount, Me, True)
    End Sub

    Private Sub txtcardTraceNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcardTraceNumber.KeyPress
        If e.KeyChar = Chr(13) Then
            InputNumberOnly(txtcardTraceNumber, e)
        End If
    End Sub

    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress
        InputNumberOnly(txtCardNumber, e)
    End Sub

    Private Sub txtCheckNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheckNumber.KeyPress
        InputNumberOnly(txtCardNumber, e)
    End Sub

    Private Sub txtBankAccounts_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCardPOSBankAccounts.SelectedValueChanged
        If txtCardPOSBankAccounts.Text <> "" Then
            banknumber.Text = DirectCast(txtCardPOSBankAccounts.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            banknumber.Text = ""
        End If
    End Sub

    Private Sub txtDepositBankAccount_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDepositBankAccount.SelectedValueChanged
        If txtDepositBankAccount.Text <> "" Then
            txtDepositBankCode.Text = DirectCast(txtDepositBankAccount.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            txtDepositBankCode.Text = ""
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtCardPOSBankAccounts.Text <> "" Then
            SaveDefaultComboItem(txtCardPOSBankAccounts, txtCardPOSBankAccounts.Text, DirectCast(txtCardPOSBankAccounts.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        End If
        If txtDepositBankAccount.Text <> "" Then
            SaveDefaultComboItem(txtDepositBankAccount, txtDepositBankAccount.Text, DirectCast(txtDepositBankAccount.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        End If
        Me.Close()
    End Sub
End Class