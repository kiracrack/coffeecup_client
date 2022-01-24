Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSChargetoClientAcct
    Public TransactionDone As Boolean = False
    Dim DefaultglItemLocation As String
    Dim defaultglCode As String
    Dim defaultglItem As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F1) Then
            rbCash.Checked = True
            txtAmountTender.Focus()

        ElseIf keyData = (Keys.F2) Then
            If Globalenablectaadvancepayment = True Then
                If rbMultiPayment.Checked = True Then
                    showMultiPayment()
                Else
                    rbMultiPayment.Checked = True
                End If
            End If
        End If
        Return ProcessCmdKey
    End Function

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
            frmPOSMultiPayments.mode.Text = "partial"

            frmPOSMultiPayments.ShowDialog()
            txtAmountTender.ReadOnly = True
        Else
            txtAmountTender.ReadOnly = False
        End If
    End Sub
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionInformation()
        com.CommandText = "select * from tbltransactioncode order by itemname asc" : rst = com.ExecuteReader
        txtGLItem.Items.Clear()
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()

        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)

        If GLobalchargeinvoicessequence = True Then
            txtInvoiceNumber.ReadOnly = True
            txtInvoiceNumber.Text = getPOSChargeInvoiceSecquence()
            com.CommandText = "UPDATE tblgeneralsettings set chargeinvoicessequence='" & txtInvoiceNumber.Text & "'" : com.ExecuteNonQuery()
        Else
            txtInvoiceNumber.ReadOnly = False
        End If

        If Globalenablectaadvancepayment = True Then
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
        Else
            rbCash.Enabled = False
            rbMultiPayment.Enabled = False
            txtAmountTender.Enabled = False
        End If
    End Sub
   
    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Transaction Reference # " & txtBatchcode.Text & ")"
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and tblsalestransaction.cancelled=0")), 2)
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtGLItem.Text = "" Then
            MsgBox("Please select transaction item name!", MsgBoxStyle.Exclamation, "Error Message")
            txtGLItem.Focus()
            Exit Sub
        ElseIf txtInvoiceNumber.Text = "" Then
            MsgBox("Please enter Invoice Number!", MsgBoxStyle.Exclamation, "Error Message")
            txtRemarks.Focus()
            Exit Sub
        ElseIf countqry("tblsalesclientcharges", "invoiceno='" & txtInvoiceNumber.Text & "' and cancelled=0") > 0 Then
            MessageBox.Show("Invoice number already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInvoiceNumber.Focus()
            Exit Sub

        ElseIf countqry("tblsalestransaction", "total<0 and adjoveride=0 and  batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0") > 0 Then
            MessageBox.Show("Your transaction contains adjustment or discount currently for approval! please contact your supperior to continue this transaction", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmountTender.Focus()
            Exit Sub
        ElseIf rbMultiPayment.Checked = False Then
            Dim TotalOtherPayment As Double = Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'"))

            If TotalOtherPayment > 0 Then
                MessageBox.Show("This transaction contains OTHER PAYMENT amounting " & FormatNumber(TotalOtherPayment, 2) & "! please select other payment option and review all entries", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
 
        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            com.CommandText = "insert into tblsalesclientcharges set trnsumcode='" & globalSalesTrnCOde & "',  accountno='" & cifid.Text & "', batchcode='" & txtBatchcode.Text & "', glitemcode='" & itemcode.Text & "', invoiceno='" & txtInvoiceNumber.Text & "', remarks='" & If(Globalenableacknowlegedchargetoaccountremarks = True, "Charge from: " & StrConv(compOfficename, vbProperCase) & If(rchar(txtRemarks.Text) = "", "", " - " & rchar(txtRemarks.Text)), rchar(txtRemarks.Text)) & "', amount='" & Val(CC(txtTotalOnScreen.Text)) & "', datetrn=ADDTIME(" & If(globalBackDateTransaction = True, "concat('" & ConvertDate(globalBackDate) & "',' ',current_time)", "current_timestamp") & ",1),trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT INTO `tblsalesclientchargesitem` (trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,inventorytrnid,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn) " _
                                                             + " SELECT trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,inventorytrnid,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn FROM `tblsalestransaction` where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0;" : com.ExecuteNonQuery()

            Dim seriesno As String = GetPOSSeriesNumber(compOfficeid)
            com.CommandText = "update tblsalesbatch set amounttendered='" & Val(CC(txtTotalOnScreen.Text)) & "',seriesno='" & seriesno & "', paymenttype='cta', amountchange=0, floattrn=0 where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

            'auto cleared client charges settings
            com.CommandText = "insert into tblglaccountledger (batchcode,journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                            + " select '" & txtBatchcode.Text & "','client-accounts',accountno,invoiceno,'" & StrConv(rchar(txtGLItem.Text), vbProperCase) & "',remarks,amount,0,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblsalesclientcharges where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalesclientcharges set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

            'PARTIAL PAYMENT
            If Val(CC(txtAmountTender.Text)) > 0 Then
                Dim paymentmode As String = "" : Dim paymentmode2 As String = ""

                If rbMultiPayment.Checked = True Then
                    paymentmode = ", paymenttype='others' "
                    paymentmode2 = "Others"
                Else
                    paymentmode = ", paymenttype='cash'"
                    paymentmode2 = "Cash"
                    If Val(CC(txtAmountTender.Text)) > 0 Then
                        If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'") > 0 Then
                            com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange=0,datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & txtBatchcode.Text & "',amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange=0,datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                        End If
                    End If
                End If

                'update client account payment status
                com.CommandText = "insert into tblpaymenttransactions set trnid='" & txtBatchcode.Text & "', transactiontype='pos', accountno='" & cifid.Text & "', paymenttype='" & paymentmode2 & "', totalamount='" & Val(CC(txtTotalOnScreen.Text)) & "', paymentamount='" & Val(CC(txtAmountTender.Text)) & "',variance='" & Val(CC(txtTotalOnScreen.Text)) - Val(CC(txtAmountTender.Text)) & "', note='" & If(Val(CC(txtTotalOnScreen.Text)) = Val(CC(txtAmountTender.Text)), "PAID", "Partial ") & " Ref#" & rchar(txtInvoiceNumber.Text) & "',depositto='" & globalSalesTrnCOde & "', datetrn=ADDTIME(current_timestamp,2),trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblsalesclientcharges set paymentupdated=" & If(Val(CC(txtTotalOnScreen.Text)) > Val(CC(txtAmountTender.Text)), "0", "1") & ", paymentrefnumber='" & txtBatchcode.Text & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

                com.CommandText = "update tblpaymenttransactions set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglaccountledger (batchcode,journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                    + "select '" & txtBatchcode.Text & "','client-accounts',accountno,trnid,'Partial Payment',note, 0, paymentamount,datetrn,trnby,1,'" & globaluserid & "',current_timestamp from tblpaymenttransactions where trnid='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            End If

            'printing all transaction
            If LCase(Globalchargeinvoicetemplate) = "pos" Then
                If globalEnablePosPrinter = True Then
                    PrintPOSChargeInvoiceReceipt(If(Globalchargeinvoicettitle = "", txtGLItem.Text, Globalchargeinvoicettitle), txtInvoiceNumber.Text, txtClientName.Text, txtTotalOnScreen.Text, "", frmPointOfSale.MyDataGridView, False)
                    If MessageBox.Show("Print receipt for merchant copy? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        PrintPOSChargeInvoiceReceipt(If(Globalchargeinvoicettitle = "", txtGLItem.Text, Globalchargeinvoicettitle), txtInvoiceNumber.Text, txtClientName.Text, txtTotalOnScreen.Text, "", frmPointOfSale.MyDataGridView, True)
                    End If
                End If
            Else
                GenerateLXChargeInvoice(txtBatchcode.Text, txtClientName.Text, txtGLItem.Text, qrysingledata("compadd", "compadd", "tblclientaccounts where cifid='" & cifid.Text & "'"), txtInvoiceNumber.Text, Val(CC(txtAmountTender.Text)), txtRemarks.Text, Me)
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

End Class