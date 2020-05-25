Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSProcessOrderSlip
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F1) Then
            rbCash.Checked = True
            txtAmountTender.Focus()

        ElseIf keyData = (Keys.F2) Then
            If rbMultiPayment.Checked = True Then
                showMultiPayment()
            Else
                rbMultiPayment.Checked = True
            End If

        ElseIf keyData = (Keys.F3) Then
            radComplimentary.Checked = True

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSPaymentConfirmation_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdatePaymentMode()
    End Sub
    Public Sub UpdatePaymentMode()
        Dim paymentMode As String = ""
        If radComplimentary.Checked = True Then
            txtPaymentMode.Text = "COMPLIMENTARY"
        Else
            Dim check As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) > 0 Then
                check = "CHECK PAYMENT"
            End If
            Dim card As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) > 0 Then
                card = qrysingledata("carddetails", "carddetails", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")
            End If
            Dim online As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) > 0 Then
                online = qrysingledata("payment", "(select bankname from tblbankaccounts where bankcode=tblsalesdepositpaymenttransaction.bankaccount) as payment", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")
            End If
            Dim voucher As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalespaymentvoucher where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) > 0 Then
                voucher = "VOUCHER"
            End If
            Dim ticket As String = ""
            If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) > 0 Then
                ticket = "DUE"
            End If
            Dim cash As String = ""
            If Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) > 0 Or rbCash.Checked = True Then
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
            If voucher <> "" Then
                paymentMode += voucher + ", "
            End If
            If ticket <> "" Then
                paymentMode += ticket + ", "
            End If
            If cash <> "" Then
                paymentMode += cash + ", "
            End If
            If paymentMode.Length > 0 Then
                txtPaymentMode.Text = paymentMode.Remove(paymentMode.Length - 2, 2)
            End If
        End If
    End Sub


    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtSalesPerson.Text = "" Then
            MsgBox("Please Sales person!", MsgBoxStyle.Exclamation, "Error Message")
            txtSalesPerson.Focus()
            Exit Sub
        ElseIf rbMultiPayment.Checked = False
            Dim TotalOtherPayment As Double = 0
            TotalOtherPayment = Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalespaymentvoucher where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'"))

            If TotalOtherPayment > 0 Then
                MessageBox.Show("This transaction contains OTHER PAYMENT amounting " & FormatNumber(TotalOtherPayment, 2) & "! please select other payment option and review all entries", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
      
        'If rbMultiPayment.Checked = False Then
        '    If Val(CC(txtAmountTender.Text)) > 0 Then
        '        If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'") > 0 Then
        '            com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtAmountTender.Text)) & "', cashchange='0',datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
        '        Else
        '            com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & txtBatchcode.Text & "',amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange='0',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        '        End If
        '    End If
        'End If

        com.CommandText = "update tblsalesbatch set forcashiertrn=1,trnby='" & salesid.Text & "', advancepayment='" & Val(CC(txtAmountTender.Text)) & "', datetrn=current_timestamp, processed=1, dateprocess=current_timestamp where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
        If GlobalEnableQueuingSlip = True Then
            'PrintPOSOderSlip(txtBatchcode.Text, txtClientName.Text, globalAssistantFullName)
        Else
            PrintPOSOrderSlipCashierAssistant(If(ckChitCounter.Checked = True, "CHIT TRANSACTION", "ORDER SLIP"), txtBatchcode.Text, globalfullname, txtSalesPerson.Text, globalAssistantFullName, Val(CC(frmPointOfSale.txtTotalOnScreen.Text)), Val(CC(txtAmountTender.Text)), frmPointOfSale.MyDataGridView)
        End If

        If countqry("tblsalescoupon", "batchcode='" & txtBatchcode.Text & "' and cancelled=0 and printed=0") > 0 Then
            Dim CouponList As String = ""
            com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product from tblsalescoupon where batchcode='" & txtBatchcode.Text & "' and cancelled=0" : rst = com.ExecuteReader
            While rst.Read
                CouponList += rst("couponcode").ToString & " - " & rst("product") & vbTab & FormatNumber(Val(rst("total").ToString), 2).ToString & Environment.NewLine
            End While
            rst.Close()
            If MessageBox.Show("Your transaction contains coupon! Do you want to print coupon ticket?" & Environment.NewLine & Environment.NewLine & CouponList, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                PrintCoupon(txtBatchcode.Text)
            End If
        End If

        frmPointOfSale.BeginNewTransaction()
        Me.Hide()
        MsgBox(txtBatchcode.Text & " successfully submitted!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub txtPaymentAmount_GotFocus(sender As Object, e As EventArgs) Handles txtAmountTender.GotFocus
        txtAmountTender.SelectAll()
    End Sub

    Private Sub txtAmountTender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountTender.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSalesPerson.Text = "" Then
                txtSalesPerson.Focus()
            End If
        Else
            InputNumberOnly(txtAmountTender, e)
        End If
    End Sub

    Private Sub rbCheck_CheckedChanged(sender As Object, e As EventArgs) Handles rbMultiPayment.CheckedChanged
        showMultiPayment()
    End Sub
    Public Sub showMultiPayment()
        If rbMultiPayment.Checked = True Then
            txtAmountTender.Text = "0.00"
            frmPOSMultiPayments.batchcode.Text = txtBatchcode.Text
            frmPOSMultiPayments.lblTransaction.Text = lblTransaction.Text
            frmPOSMultiPayments.txtTotalOnScreen.Text = txtTotalOnScreen.Text
            frmPOSMultiPayments.cifid.Text = frmPointOfSale.cifid.Text
            frmPOSMultiPayments.mode.Text = "processor"

            frmPOSMultiPayments.ShowDialog()
            txtAmountTender.ReadOnly = True
        Else
            txtAmountTender.ReadOnly = False
        End If
    End Sub

    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadSalesPerson()
        txtAmountTender.Text = "0.00"
        LoadTransactionInformation()
        com.CommandText = "select *,(select companyname from tblclientaccounts where cifid=tblsalesbatch.cifid) as client from tblsalesbatch where batchcode='" & txtBatchcode.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            If Val(rst("advancepayment").ToString) > 0 Then
                txtAmountTender.Text = FormatNumber(Val(rst("advancepayment").ToString), 2)
            End If
            ckChitCounter.Checked = rst("chittrn")
            txtClientName.Text = rst("client").ToString
        End While
        rst.Close()

        Dim TotalOtherPayment As Double = Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'"))
        If TotalOtherPayment > 0 Then
            rbMultiPayment.Checked = True
        End If

        Dim TotalPayment As Double = TotalOtherPayment + Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'"))
        If TotalPayment > 0 Then
            txtAmountTender.Text = FormatNumber(TotalPayment, 2)
        End If
        validateTransaction()
    End Sub
    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Total Transaction (Reference # " & txtBatchcode.Text & ")"
        Dim totalamount As Double = Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0"))
        txtTotalOnScreen.Text = FormatNumber(totalamount, 2)
        txtAmountTender.Text = FormatNumber(totalamount, 2)
    End Sub
    Public Sub loadSalesPerson()
        txtSalesPerson.Items.Clear()
        If Globalenablesalesassistant = True Then
            com.CommandText = "select distinct accountid, if(nickname is null or nickname ='' ,fullname,ucase(nickname))  as 'name' from tblaccounts where coffeecupposition in (select authcode from tbluserauthority where pointofsaleassistant=1) " & If(Globaldefaultsalespersonpermission = "", "", " or coffeecupposition = '" & Globaldefaultsalespersonpermission & "'") & " order by if(nickname is null or nickname ='' ,fullname,ucase(nickname)) asc" : rst = com.ExecuteReader
            While rst.Read
                txtSalesPerson.Items.Add(New ComboBoxItem(rst("name").ToString, rst("accountid").ToString))
            End While
            rst.Close()
        Else
            txtSalesPerson.Items.Add(New ComboBoxItem(globalAssistantFullName, globalAssistantUserId))
            salesid.Text = globalAssistantUserId
            txtSalesPerson.Text = globalAssistantFullName
            'cmdConfirmPayment.Enabled = True
            'Me.AcceptButton = cmdConfirmPayment
        End If
    End Sub

    Private Sub txtSalesPerson_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSalesPerson.KeyDown
        salesid.Text = ""
        If e.KeyData = Keys.Enter Then
            If txtSalesPerson.Text = "" Or txtSalesPerson.Text = "%" Then Exit Sub
            If countqry("tblaccounts", " if(nickname is null or nickname ='' ,fullname,ucase(nickname)) = '" & txtSalesPerson.Text & "'") = 0 Then
                com.CommandText = "select distinct accountid, if(nickname is null or nickname ='' ,fullname,ucase(nickname))  as 'name' from tblaccounts where coffeecupposition in (select authcode from tbluserauthority where pointofsaleassistant=1) " & If(Globaldefaultsalespersonpermission = "", "", " or coffeecupposition = '" & Globaldefaultsalespersonpermission & "'") & " order by if(nickname is null or nickname ='' ,fullname,ucase(nickname)) asc" : rst = com.ExecuteReader
                While rst.Read
                    txtSalesPerson.Items.Add(New ComboBoxItem(rst("name").ToString, rst("accountid").ToString))
                End While
                rst.Close()
            Else
                salesid.Text = DirectCast(txtSalesPerson.SelectedItem, ComboBoxItem).HiddenValue()
                validateTransaction()
            End If
        End If
    End Sub

    'Private Sub salesid_TextChanged(sender As Object, e As EventArgs) Handles salesid.TextChanged
    '    validateTransaction()
    'End Sub

    Private Sub txtPaymentAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmountTender.TextChanged
        validateTransaction()
    End Sub

    Public Sub validateTransaction()
        If salesid.Text = "" Then
            cmdConfirmPayment.Enabled = False
            Me.AcceptButton = Nothing
        Else
            cmdConfirmPayment.Enabled = True
            Me.AcceptButton = cmdConfirmPayment
        End If
    End Sub

    Private Sub txtSalesPerson_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtSalesPerson.SelectedValueChanged
        salesid.Text = DirectCast(txtSalesPerson.SelectedItem, ComboBoxItem).HiddenValue()
        validateTransaction()
    End Sub

    Private Sub radComplimentary_CheckedChanged(sender As Object, e As EventArgs) Handles radComplimentary.CheckedChanged
        UpdatePaymentMode()
    End Sub

    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged
        UpdatePaymentMode()
    End Sub
End Class