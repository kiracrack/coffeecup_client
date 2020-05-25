Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSInterOffice
    Public TransactionDone As Boolean = False
    Dim DefaultglItemLocation As String
    Dim defaultglCode As String
    Dim defaultglItem As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelPaymentPosting_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If countqry("tblsalesinteroffice", "paymentref='" & txtORNumber.Text & "' and trnno='" & txtInvoiceNumber.Text & "'") = 0 Then
            Dim paymentMode As String = ""
            Dim check As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtORNumber.Text & "'")) > 0 Then
                check = "CHECK PAYMENT"
            End If
            Dim card As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtORNumber.Text & "'")) > 0 Then
                card = qrysingledata("carddetails", "carddetails", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtORNumber.Text & "'")
            End If
            Dim online As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'")) > 0 Then
                online = qrysingledata("payment", "(select bankname from tblbankaccounts where bankcode=tblsalesdepositpaymenttransaction.bankaccount) as payment", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'")
            End If
            Dim ticket As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'")) > 0 Then
                ticket = "DUE"
            End If
            Dim cash As String = ""
            If Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'")) > 0 Or rbCash.Checked = True Then
                cash = "CASH"
            End If
            If check <> "" Then
                paymentMode += check + ", "
            End If
            If card <> "" Then
                paymentMode += card + ", "
            End If
            If online <> "" Then
                paymentMode += online + ", "
            End If
            If cash <> "" Then
                paymentMode += cash + ", "
            End If
            If paymentMode.Length > 0 Then
                txtPaymentMode.Text = paymentMode.Remove(paymentMode.Length - 2, 2)
            End If
        End If
    End Sub

    Private Sub frmPOSInterOffice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblsalesinteroffice", "paymentref='" & txtORNumber.Text & "' and trnno='" & txtInvoiceNumber.Text & "'") = 0 Then
            Dim TemporaryPayment As Double = Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtORNumber.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtORNumber.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'")) +
                                                 Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'"))
            If TemporaryPayment > 0 Then
                If MessageBox.Show("System found an payment transaction not validated with this OR Number! Are you sure you want to cancel all payment transaction?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    CancelPaymentTransaction(txtORNumber.Text)
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmPOSInterOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionInformation()
        com.CommandText = "select * from tbltransactioncode order by itemname asc" : rst = com.ExecuteReader
        txtGLItem.Items.Clear()
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()
        LoadToComboBoxDB("select officeid,ucase(officename) as office from tblcompoffice where officeid<>'" & compOfficeid & "' order by office asc", "office", "officeid", txtOffice)

        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)

        txtOffice.Text = defaultCombobox(txtOffice, Me, False)
        companyid.Text = defaultCombobox(txtOffice, Me, True)

        txtInvoiceNumber.Text = getDuetoSequence()
        txtRemarks.Focus()
        txtORNumber.Text = GetBIRORNumber()
    End Sub

    Private Sub txtOffice_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOffice.SelectedValueChanged
        If txtOffice.Text = "" Then Exit Sub
        officeid.Text = DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub
    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Transaction Reference # " & txtBatchcode.Text & ")"
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and tblsalestransaction.cancelled=0")), 2)
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If Val(CC(txtTotal.Text)) <> Val(CC(txtTotalOnScreen.Text)) Then
            MsgBox("Total payment amount did not match on total due amount!", MsgBoxStyle.Exclamation, "Error Message")
            Exit Sub
        ElseIf txtGLItem.Text = "" Then
            MsgBox("Please select transaction item name!", MsgBoxStyle.Exclamation, "Error Message")
            txtGLItem.Focus()
            Exit Sub
        ElseIf txtOffice.Text = "" Then
            MsgBox("Please select office name!", MsgBoxStyle.Exclamation, "Error Message")
            txtOffice.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MsgBox("Please enter remarks!", MsgBoxStyle.Exclamation, "Error Message")
            txtRemarks.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            SaveDefaultComboItem(txtOffice, txtOffice.Text, DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            Dim getCompanyid As String = qrysingledata("companyid", "companyid", "tblcompoffice where officeid='" & officeid.Text & "'")
            com.CommandText = "insert into tblsalesinteroffice set trnno='" & txtInvoiceNumber.Text & "',  trnsumcode='" & globalSalesTrnCOde & "',  batchcode='" & txtBatchcode.Text & "',coveredamount='" & Val(CC(txtAmountCovered.Text)) & "',excessamount='" & Val(CC(txtAmountTender.Text)) & "',excesscashpayment=" & If(rbCash.Checked = True, 1, 0) & ",paymentref='" & txtORNumber.Text & "', " _
                + " duetocompany='" & GlobalCompanyid & "',duefromcompany='" & getCompanyid & "',originofficeid='" & compOfficeid & "', duefromofficeid='" & officeid.Text & "', transactioncode='" & itemcode.Text & "',  remarks='" & rchar(txtRemarks.Text) & "', amount='" & Val(CC(txtTotalOnScreen.Text)) & "', datetrn=ADDTIME(" & If(globalBackDateTransaction = True, "concat('" & ConvertDate(globalBackDate) & "',' ',current_time)", "current_timestamp") & ",1),trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            Dim seriesno As String = GetPOSSeriesNumber(compOfficeid)
            com.CommandText = "update tblsalesbatch set amounttendered='" & Val(CC(txtTotalOnScreen.Text)) & "',seriesno='" & seriesno & "',paymenttype='due', amountchange=0, floattrn=0, processed=1, dateprocess=current_timestamp where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

            'printing all transaction
            If LCase(Globalchargeinvoicetemplate) = "pos" Then
                If globalEnablePosPrinter = True Then
                    PrintPOSDue(txtInvoiceNumber.Text, txtGLItem.Text, txtOffice.Text, txtTotalOnScreen.Text, txtRemarks.Text, frmPointOfSale.MyDataGridView, False)
                    If MessageBox.Show("Print receipt for merchant copy? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        PrintPOSDue(txtInvoiceNumber.Text, txtGLItem.Text, txtOffice.Text, txtTotalOnScreen.Text, txtRemarks.Text, frmPointOfSale.MyDataGridView, True)
                    End If
                End If
            End If
            TransactionDone = True
            Me.Close()
        End If
    End Sub

    Private Sub txtGLItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGLItem.SelectedIndexChanged
        If txtGLItem.Text <> "" Then
            itemcode.Text = DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            itemcode.Text = ""
        End If
    End Sub

    Private Sub txtInvoiceNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoiceNumber.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirmPayment.PerformClick()
        Else
            InputNumberOnly(txtInvoiceNumber, e)
        End If
    End Sub
 
    Private Sub txtAmountCovered_TextChanged(sender As Object, e As EventArgs) Handles txtAmountCovered.TextChanged, txtAmountTender.TextChanged
        txtTotal.Text = FormatNumber(Val(CC(txtAmountCovered.Text)) + Val(CC(txtAmountTender.Text)))
    End Sub

    Private Sub rbCash_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged, rbMultiPayment.CheckedChanged
        SelectPaymentType()
    End Sub
    Public Sub SelectPaymentType()
        If rbCash.Checked = True Then
            cmdInputPaymentDetails.Enabled = False
            txtAmountTender.ReadOnly = False
        ElseIf rbMultiPayment.Checked = True Then
            cmdInputPaymentDetails.Text = "Please input other payment details"
            cmdInputPaymentDetails.Enabled = True
            txtAmountTender.ReadOnly = True
        End If
    End Sub

    Private Sub cmdInputPaymentDetails_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdInputPaymentDetails.LinkClicked
        If Val(CC(txtAmountTender.Text)) < 0 Then
            txtAmountTender.Text = "0.00"
        End If
        frmPOSMultiPayments.batchcode.Text = txtORNumber.Text
        frmPOSMultiPayments.lblTransaction.Text = GlobalWalkinAccountName
        frmPOSMultiPayments.txtTotalOnScreen.Text = txtAmountTender.Text
        frmPOSMultiPayments.cifid.Text = GlobalWalkinAccountCIFCode
        frmPOSMultiPayments.mode.Text = "interoffice"
        frmPOSMultiPayments.ShowDialog(Me)
    End Sub
End Class