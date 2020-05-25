Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSPaymentConfirmation
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
            txtComplimentaryRemarks.Focus()

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
                ticket = qrysingledata("payment", "(select itemname from tbltransactioncode where itemcode=tblsalesticketpaymenttransaction.itemcode) as payment", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")
            End If
            Dim cash As String = ""
            If Val(qrysingledata("ttlcash", "sum(amount) as ttlcash", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) > 0 Or rbCash.Checked = True Then
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
        ShowPrintPreview()
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
            frmPOSMultiPayments.mode.Text = "pos"

            frmPOSMultiPayments.ShowDialog()
            txtAmountTender.ReadOnly = True
        Else
            txtAmountTender.ReadOnly = False
        End If
    End Sub

    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

        txtPaymentChange.BackColor = Color.Lime
        txtPaymentChange.ForeColor = Color.Black
        txtComplimentaryRemarks.Text = ""
        If Globalenablesaleinvoicenumber = True Then
            lbltender.Text = "Enter Invoice # and Amount not less than total transaction amount"
            txtInvoiceNumber.Visible = True
            txtAmountTender.Left = 218
            txtAmountTender.Size = New Size(217, 59)
            txtInvoiceNumber.TabIndex = 0
            txtAmountTender.TabIndex = 1
        Else
            lbltender.Text = "Enter Amount not less than total transaction amount"
            txtInvoiceNumber.Visible = False
            txtAmountTender.Left = 65
            txtAmountTender.Size = New Size(371, 59)
            txtInvoiceNumber.TabIndex = 999
            txtAmountTender.TabIndex = 0
        End If

        msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *,chittotal as sop from tblsalesbatch where batchcode='" & txtBatchcode.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                vat.Text = FormatNumber(.Rows(cnt)("totaltax"), 2)
                svc.Text = FormatNumber(.Rows(cnt)("totalsvcharge"), 2)
                If Val(.Rows(cnt)("advancepayment").ToString) > 0 Then
                    txtdeposit.Text = Val(.Rows(cnt)("advancepayment").ToString)
                End If
                ckChitCounter.Checked = CBool(.Rows(cnt)("chittrn").ToString)
                If CBool(.Rows(cnt)("chittrn").ToString) = True Then
                    txtSOPTaxRate.Text = GlobalTaxRate
                    txtNetSOP.Text = FormatNumber(.Rows(cnt)("sop").ToString, 2)
                End If
            End With
        Next
        LoadTransactionInformation()
        Dim TotalOtherPayment As Double = Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalespaymentvoucher where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                            Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'"))
        If TotalOtherPayment > 0 Then
            rbMultiPayment.Checked = True
        End If

        Dim TotalPayment As Double = TotalOtherPayment + Val(qrysingledata("ttl", "ifnull(sum(amount),0) as ttl", "tblsalescashpayment where batchcode='" & txtBatchcode.Text & "'"))
        If TotalPayment > 0 Then
            txtAmountTender.Text = FormatNumber(TotalPayment, 2)
        End If
        ShowPrintPreview()
        If ckChitCounter.Checked = True Then
            Me.Size = New Size(1179, 458)
            GroupChitCounter.Visible = True
        Else
            Me.Size = New Size(816, 458)
            GroupChitCounter.Visible = False
        End If
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub ShowPrintPreview()
        txtPrintPreview.Text = PrintPOSReciept(False, ckSOPclaim.CheckState, txtBatchcode.Text, "", frmPointOfSale.txtClient.Text, txtPaymentMode.Text, Val(CC(vat.Text)), Val(CC(svc.Text)), Val(txtdeposit.Text), Val(CC(txtTotalOnScreen.Text)), Val(CC(txtAmountTender.Text)), Val(CC(txtPaymentChange.Text)), frmPointOfSale.MyDataGridView)
        If ckChitCounter.Checked = True Then
            txtPrintPreview.Text += PrintPOSChitReciept(False, txtBatchcode.Text, frmPointOfSale.txtClient.Text, txtPaymentMode.Text, txtChitCustomerName.Text, txtNetSOP.Text, txtPayableTax.Text, txtNetSOPAfterTax.Text, frmPointOfSale.MyDataGridView)
        End If
    End Sub

    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Total Transaction (Reference # " & txtBatchcode.Text & ")"
        Dim totalamount As Double = Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0"))
        Dim totaDeposit As Double = Val(qrysingledata("advancepayment", "advancepayment", "tblsalesbatch where batchcode='" & txtBatchcode.Text & "' and void=0"))
        If ckChitCounter.Checked = True Then
            txtTotalOnScreen.Text = FormatNumber((totalamount + Val(CC(txtNetSOPAfterTax.Text))) - totaDeposit, 2)
            txtAmountTender.Text = FormatNumber((totalamount + Val(CC(txtNetSOPAfterTax.Text))) - totaDeposit, 2)
        Else
            txtTotalOnScreen.Text = FormatNumber(totalamount - totaDeposit, 2)
            txtAmountTender.Text = FormatNumber(totalamount - totaDeposit, 2)
        End If
        
        If totaDeposit > 0 Then
            lblTransaction.Text = "Enter proceed transaction balance"
        Else
            lblTransaction.Text = "Enter proceed transaction amount"
        End If
    End Sub
    Public Sub ComputeChange()
        Dim subtotal As Double = Val(CC(txtTotalOnScreen.Text)) : Dim tender As Double = Val(CC(txtAmountTender.Text))
        txtPaymentChange.Text = FormatNumber(tender - subtotal, 2)
        If tender < Val(CC(txtTotalOnScreen.Text)) Then
            txtPaymentChange.BackColor = Color.Red
            txtPaymentChange.ForeColor = Color.White
            Me.AcceptButton = Nothing
        Else
            txtPaymentChange.BackColor = Color.Lime
            txtPaymentChange.ForeColor = Color.Black
            Me.AcceptButton = cmdConfirmPayment
        End If
    End Sub

    Private Sub txtAmountTender_GotFocus(sender As Object, e As EventArgs) Handles txtAmountTender.GotFocus
        txtAmountTender.SelectAll()
    End Sub

    Private Sub txtAmountTender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountTender.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirmPayment.PerformClick()
        Else
            InputNumberOnly(txtAmountTender, e)
        End If
    End Sub

    Private Sub txtAmountTender_TextChanged(sender As Object, e As EventArgs) Handles txtAmountTender.TextChanged
        If txtAmountTender.Text = "" Then
            txtAmountTender.Text = "0.00"
            txtAmountTender.SelectAll()
        End If
        ComputeChange()
        ShowPrintPreview()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If Globalenablesaleinvoicenumber = True And txtInvoiceNumber.Text = "" Then
            MessageBox.Show("Please enter valid Invoice Number!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInvoiceNumber.Focus()
            Exit Sub

        ElseIf Val(CC(txtAmountTender.Text)) < Val(CC(txtTotalOnScreen.Text)) Then
            MessageBox.Show("Please enter valid payment amount!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmountTender.Focus()
            Exit Sub

        ElseIf countqry("tblsalestransaction", "total < 0 and adjoveride=0 and batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0") > 0 Then
            Dim discountOveride As String = ""
            If MessageBox.Show("Your transaction contains adjustment or discount currently for approval!! " & Environment.NewLine & Environment.NewLine & "If you want to overide current discount click YES to enter autorized account or NO to submit it as for approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSAdminConfirmation.ShowDialog(Me)
                If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                    discountOveride = ", adjoveride=1, adjoverideby='" & frmPOSAdminConfirmation.userid.Text & "' "
                    frmPOSAdminConfirmation.ApprovedConfirmation = False
                    frmPOSAdminConfirmation.Dispose()
                Else
                    txtAmountTender.Focus()
                    Exit Sub
                End If
            Else
                txtAmountTender.Focus()
                Exit Sub
            End If
        ElseIf rbMultiPayment.Checked = False Then
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
        If ckChitCounter.Checked = True Then
            If txtChitCustomerName.Text = "" Then
                MessageBox.Show("Please enter Customer name!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtChitCustomerName.Focus()
                Exit Sub
            ElseIf txtChitCustAddress.Text = "" Then
                MessageBox.Show("Please enter Customer address!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtChitCustomerName.Focus()
                Exit Sub
            End If
        End If
        If radComplimentary.Checked = True Then
            If txtComplimentaryRemarks.Text = "" Then
                MessageBox.Show("Please enter complimentary remarks!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtComplimentaryRemarks.Focus()
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are you sure you want to continue post payment transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If rbCash.Checked = True Then
                If Val(CC(txtAmountTender.Text)) > 0 Then
                    If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'") > 0 Then
                        com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange='" & Val(CC(txtPaymentChange.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & txtBatchcode.Text & "',amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange='" & Val(CC(txtPaymentChange.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    End If
                End If
            End If
            Dim seriesno As String = GetPOSSeriesNumber(compOfficeid)
            com.CommandText = "update tblsalesbatch set amounttendered='" & Val(CC(txtAmountTender.Text)) & "', seriesno='" & seriesno & "', invoiceno='" & txtInvoiceNumber.Text & "', amountchange='" & Val(CC(txtPaymentChange.Text)) & "', floattrn=0,paymenttype='" & txtPaymentMode.Text & "',complimentary=" & If(radComplimentary.Checked = True, 1, 0) & ",complimentaryremarks='" & rchar(txtComplimentaryRemarks.Text) & "', processed=1, dateprocess=current_timestamp where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

            If ckChitCounter.Checked = True Then
                com.CommandText = "insert into tblsaleschitbatch set trnsumcode ='" & globalSalesTrnCOde & "',batchcode='" & txtBatchcode.Text & "',customername='" & rchar(txtChitCustomerName.Text) & "', address='" & rchar(txtChitCustAddress.Text) & "', contactnumber='" & rchar(txtChitContactNumber.Text) & "', chittotal='" & Val(CC(txtNetSOP.Text)) & "',originaltotal='" & Val(CC(txtTotalOnScreen.Text)) & "',netdiscount='" & Val(CC(txtNetSOPAfterTax.Text)) & "',taxrate='" & Val(CC(txtSOPTaxRate.Text)) & "', netdiscountaftertax='" & Val(CC(txtNetSOPAfterTax.Text)) & "', claimsop=" & ckSOPclaim.CheckState & ", userid ='" & globaluserid & "',datetrn=current_timestamp" : com.ExecuteNonQuery()
                PrintPOSReciept(True, ckSOPclaim.CheckState, txtBatchcode.Text, seriesno, frmPointOfSale.txtClient.Text, txtPaymentMode.Text, Val(CC(vat.Text)), Val(CC(svc.Text)), Val(txtdeposit.Text), Val(CC(txtTotalOnScreen.Text)), Val(CC(txtAmountTender.Text)), Val(CC(txtPaymentChange.Text)), frmPointOfSale.MyDataGridView)
                PrintPOSChitReciept(True, txtBatchcode.Text, frmPointOfSale.txtClient.Text, txtPaymentMode.Text, txtChitCustomerName.Text, txtNetSOP.Text, txtPayableTax.Text, txtNetSOPAfterTax.Text, frmPointOfSale.MyDataGridView)
            Else                If MessageBox.Show("Do you want to print transaction?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    If Globalenableposcashdrawer = True Then
                        OpenCashDrawer()
                    End If
                    PrintPOSReciept(True, ckSOPclaim.CheckState, txtBatchcode.Text, seriesno, frmPointOfSale.txtClient.Text, txtPaymentMode.Text, Val(CC(vat.Text)), Val(CC(svc.Text)), Val(txtdeposit.Text), Val(CC(txtTotalOnScreen.Text)), Val(CC(txtAmountTender.Text)), Val(CC(txtPaymentChange.Text)), frmPointOfSale.MyDataGridView)
                Else
                    If Globalenableposcashdrawer = True Then
                        OpenCashDrawer()
                    End If
                End If            End If
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
            TransactionDone = True
            Me.Close()
        End If

    End Sub

    Private Sub txtOriginalTotal_GotFocus(sender As Object, e As EventArgs)
        Me.AcceptButton = cmdConfirmPayment
    End Sub

    Private Sub txtInvoiceNumber_GotFocus(sender As Object, e As EventArgs) Handles txtInvoiceNumber.GotFocus
        Me.AcceptButton = Nothing
        txtInvoiceNumber.SelectAll()
    End Sub

    Private Sub txtInvoiceNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoiceNumber.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtInvoiceNumber.Text <> "" Then
                txtAmountTender.Focus()
            End If
        Else
            InputNumberOnly(txtInvoiceNumber, e)
        End If
    End Sub

#Region "C H I T"
    Private Sub ckChitVat_CheckedChanged(sender As Object, e As EventArgs) Handles ckChitVat.CheckedChanged
        If ckChitVat.Checked = True Then
            txtSOPTaxRate.Text = FormatNumber(GlobalTaxRate, 2)
        Else
            txtSOPTaxRate.Text = FormatNumber(0, 2)
        End If
        ComputeChit()
    End Sub

    Private Sub txtNetSOP_TextChanged(sender As Object, e As EventArgs) Handles txtNetSOP.TextChanged
        ComputeChit()
    End Sub
    Public Sub ComputeChit()
        txtNetSOPAfterTax.Text = FormatNumber(Val(CC(txtNetSOP.Text)) - ((Val(CC(txtSOPTaxRate.Text)) / 100) * Val(CC(txtNetSOP.Text))), 2)
        txtPayableTax.Text = FormatNumber(Val(CC(txtNetSOP.Text)) - Val(CC(txtNetSOPAfterTax.Text)), 2)
    End Sub
#End Region
     
    Private Sub radComplimentary_CheckedChanged(sender As Object, e As EventArgs) Handles radComplimentary.CheckedChanged
        If radComplimentary.Checked = True Then
            lblChange.Text = "Complimentary Remarks"
            txtComplimentaryRemarks.Visible = True
            txtPaymentChange.Visible = False
        Else
            lblChange.Text = "Change"
            txtComplimentaryRemarks.Visible = False
            txtPaymentChange.Visible = True
        End If
        UpdatePaymentMode()
    End Sub

    Private Sub txtComplimentaryRemarks_GotFocus(sender As Object, e As EventArgs) Handles txtComplimentaryRemarks.GotFocus
        Me.AcceptButton = cmdConfirmPayment
    End Sub

    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged
        UpdatePaymentMode()
    End Sub

    Private Sub ckSOPclaim_CheckedChanged(sender As Object, e As EventArgs) Handles ckSOPclaim.CheckedChanged
        If ckSOPclaim.Checked = True Then
            txtTotalOnScreen.Text = FormatNumber(Val(CC(txtTotalOnScreen.Text)) - Val(CC(txtNetSOPAfterTax.Text)), 2)
        Else
            txtTotalOnScreen.Text = FormatNumber(Val(CC(txtTotalOnScreen.Text)) + Val(CC(txtNetSOPAfterTax.Text)), 2)
        End If
        ShowPrintPreview()
    End Sub

    Private Sub txtTotalOnScreen_TextChanged(sender As Object, e As EventArgs) Handles txtTotalOnScreen.TextChanged
        ComputeChange()
    End Sub

    Private Sub txtInvoiceNumber_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceNumber.TextChanged

    End Sub

    Private Sub txtChitCustAddress_GotFocus(sender As Object, e As EventArgs) Handles txtChitCustAddress.GotFocus
        Me.AcceptButton = cmdConfirmPayment
    End Sub
     
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmPOSTagtoRoomTransaction.txtBatchcode.Text = txtBatchcode.Text
        frmPOSTagtoRoomTransaction.txtTotalOnScreen.Text = txtTotalOnScreen.Text
        frmPOSTagtoRoomTransaction.ShowDialog(Me)
    End Sub
End Class