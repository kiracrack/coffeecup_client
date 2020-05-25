Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSClientAccountPayment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
      
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmPOSPaymentConfirmation_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdatePaymentMode()
    End Sub
    Public Sub UpdatePaymentMode()
        Dim paymentMode As String = ""
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
    End Sub

    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged, rbMultiPayment.CheckedChanged
        SelectPaymentType()
    End Sub
    Public Sub SelectPaymentType()
        If rbCash.Checked = True Then
            cmdInputPaymentDetails.Visible = False

        ElseIf rbMultiPayment.Checked = True Then
            cmdInputPaymentDetails.Text = "Please other payment details"
            cmdInputPaymentDetails.Visible = True

        End If
    End Sub

    Private Sub frmHotelPaymentPosting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblpaymenttransactions", "trnid='" & txtBatchcode.Text & "' and transactiontype='pos'") = 0 Then
            Dim TemporaryPayment As Double = Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalespaymentvoucher where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'"))
            If TemporaryPayment > 0 Then
                If MessageBox.Show("System found an payment transaction not validated with this OR Number! Are you sure you want to cancel all payment transaction?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    CancelPaymentTransaction(txtBatchcode.Text)
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim firstDayofMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        If cifid.Text <> "" Then
            If countqry("tblsalesclientcharges", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Or countqry("tblsalesaccounttransaction", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Then
                txtdateFrom.Value = CDate(qrysingledata("dt", "ifnull(date_format(datetrn,'%Y,%m,%d'),current_timestamp) as dt", "tblsalesclientcharges where accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0 union " _
                                                            + " select ifnull(date_format(datetrn,'%Y,%m,%d'),current_timestamp) as dt from tblsalesaccounttransaction where accountno='" & cifid.Text & "' and debit> 0 and paymentupdated=0 and cancelled=0 order by dt asc limit 1"))
            Else
                txtdateFrom.Value = Now
            End If
        Else
            txtdateFrom.Value = Now
        End If
        LoadClientInfo()
        txtDateTo.Value = Format(Now)
        ListView1.View = View.Details
        ListView1.Columns.Add("Date", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("trnid", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Order Number", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Invoice No.", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Amount", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("trntype", -2, HorizontalAlignment.Left)
        ListView1.Columns(1).Width = 0
        ListView1.Columns(0).Width = 90
        ListView1.Columns(2).Width = 90
        ListView1.Columns(4).Width = 120
        ListView1.Columns(5).Width = 0
        LoadInvoices()
        GetOrNumber()

        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
    End Sub
    Public Sub GetOrNumber()
        If GLobalclientjournalsequence = True Then
            txtBatchcode.ReadOnly = True
            Dim batchcodepayment As String = getPOSClientJournalSecquence()
            txtBatchcode.Text = "P" & batchcodepayment
            com.CommandText = "UPDATE tblgeneralsettings set clientjournalsequence='" & batchcodepayment & "'" : com.ExecuteNonQuery()
        Else
            txtBatchcode.ReadOnly = False
        End If
    End Sub
    Public Sub LoadClientInfo()
        txtClient.Items.Clear()
        If Globalenableclientfilter = True Then
            com.CommandText = "select * from tblclientaccounts where groupcode in (select groupcode from tblclientfilter where permissioncode='" & globalAuthcode & "') and walkinaccount=0 and approved=1 and hotelclient=0 and deleted=0 and blocked=0 order by companyname asc" : rst = com.ExecuteReader
        Else
            com.CommandText = "select * from tblclientaccounts where approved=1 and walkinaccount=0 and hotelclient=0 and deleted=0 and blocked=0 order by companyname asc" : rst = com.ExecuteReader
        End If
        While rst.Read
            txtClient.Items.Add(New ComboBoxItem(rst("companyname").ToString, rst("cifid").ToString))
        End While
        rst.Close()
    End Sub

    Private Sub txtClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClient.SelectedIndexChanged
        If txtClient.Text <> "" Then
            cifid.Text = DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue()
            LoadInvoices()
        Else
            cifid.Text = ""
        End If
    End Sub

    Public Sub LoadInvoices()
        ListView1.Items.Clear()
        com.CommandText = "select 'Invoice' as 'trntype', datetrn as dt, trnid,date_format(datetrn,'%Y-%m-%d') as 'Date', batchcode as 'Order Number', invoiceno as 'Invoice No.' ,if(paymentrefnumber<>'',(amount-(select paymentamount from tblpaymenttransactions where tblpaymenttransactions.trnid=tblsalesclientcharges.paymentrefnumber and cancelled=0)),amount) as 'Amount'  from tblsalesclientcharges where accountno='" & cifid.Text & "' and  paymentupdated=0 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.Value) & "' and '" & ConvertDate(txtDateTo.Value) & "' union " _
            + " select 'Other', datetrn as dt,id as trnid, date_format(datetrn,'%Y-%m-%d'), 'other-trnsaction','-',debit from tblsalesaccounttransaction where accountno='" & cifid.Text & "' and debit> 0 and paymentupdated=0 and cancelled=0 and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdateFrom.Value) & "' and '" & ConvertDate(txtDateTo.Value) & "' order by dt asc " : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("Date").ToString, 0)
            item1.SubItems.Add(rst("trnid").ToString)
            item1.SubItems.Add(rst("Order Number").ToString)
            item1.SubItems.Add(rst("Invoice No.").ToString)
            item1.SubItems.Add(FormatNumber(rst("Amount").ToString, 2))
            item1.SubItems.Add(rst("trntype").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
        txtAmountTender.Text = "0.00"
        If countqry("tblsalesclientcharges", "accountno='" & cifid.Text & "' and cancelled=0 and verified=1 and paymentupdated=0") > 0 Or countqry("tblsalesaccounttransaction", "accountno='" & cifid.Text & "' and paymentupdated=0") > 0 Then
            lblbalance.Text = "Total Checked Invoice"
            'Me.Size = New Size(840, 501)
        Else

            lblbalance.Text = "Open Balance"
            'Me.Size = New Size(332, 501)
        End If
        txtOpenBalance.Text = FormatNumber(Val(qrysingledata("openbalance", "sum(debit)- sum(credit) as 'openbalance'", "tblglaccountledger where journalmode='client-accounts' and accountno='" & cifid.Text & "' and cancelled=0")) - Val(qrysingledata("payment", "sum(paymentamount) as 'payment'", "tblpaymenttransactions where verified=0 and accountno='" & cifid.Text & "' and cancelled=0")), 2)
    End Sub

    Private Sub txtdateFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtdateFrom.ValueChanged, txtDateTo.ValueChanged
        LoadInvoices()
    End Sub

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        ' On Error Resume Next
        Dim totalAmount As Double = 0
        For Each itm As ListViewItem In ListView1.Items
            If itm.Checked Then
                totalAmount = FormatNumber(totalAmount + Val(CC(itm.SubItems(4).Text)), 2)
            End If
        Next
        txtAmount.Text = FormatNumber(totalAmount, 2)
        txtAmountTender.Text = FormatNumber(totalAmount, 2)
    End Sub

    Private Sub txtPaymentAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmountTender.TextChanged, txtAmount.TextChanged, txtDiscount.TextChanged
        Dim ttlamount As Double = Val(CC(txtAmount.Text)) : Dim payamount As Double = Val(CC(txtAmountTender.Text)) : Dim discount As Double = Val(CC(txtDiscount.Text))
        txtVariance.Text = FormatNumber((payamount + discount) - ttlamount, 2)
        ckChange.Checked = False

        If Val(CC(txtVariance.Text)) < 0 Then
            txtVariance.BackColor = Color.Red
            txtVariance.ForeColor = Color.White
            lblvariance.Text = "Variance"
            ckChange.Visible = False
        ElseIf Val(CC(txtVariance.Text)) > 0 Then
            If Val(CC(txtAmount.Text)) > 0 Then
                txtVariance.BackColor = Color.Lime
                txtVariance.ForeColor = Color.Black
                lblvariance.Text = "Change"
                ckChange.Visible = True
            Else
                txtVariance.BackColor = DefaultBackColor
                txtVariance.ForeColor = Color.Black
                lblvariance.Text = "Amount Payment"
                ckChange.Visible = False
            End If
        Else
            txtVariance.BackColor = DefaultBackColor
            txtVariance.ForeColor = Color.Black
            lblvariance.Text = "Variance"
            ckChange.Visible = False
        End If

        If Val(CC(txtAmountTender.Text)) > 0 Then
            AcceptButton = cmdConfirm
        Else
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub ckDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles ckDiscount.CheckedChanged
        If ckDiscount.Checked = True Then
            txtDiscount.ReadOnly = False
            txtDiscountRemarks.ReadOnly = False
        Else
            txtDiscount.ReadOnly = True
            txtDiscountRemarks.ReadOnly = True
            txtDiscount.Text = "0.00"
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub

    Public Sub FilterTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select trnid, datetrn, (select companyname from tblclientaccounts where cifid = tblpaymenttransactions.accountno) as 'Client',ucase(paymenttype) as 'Payment Type', totalamount as 'Total Amount', paymentamount as 'Payment Amount', Discount, Variance, Note, Verified  from tblpaymenttransactions where depositto='" & globalSalesTrnCOde & "' and cancelled=0 union all " _
                                            + " select '', current_timestamp, '', 'Total',null, sum(paymentamount),null,null, '',null from tblpaymenttransactions where depositto='" & globalSalesTrnCOde & "' and cancelled=0) as s order by datetrn asc ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Note").Width = 300
        MyDataGridView.Columns("trnid").Visible = False
        MyDataGridView.Columns("datetrn").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Total Amount", "Payment Amount", "Discount", "Variance"})
        GridColumnAlignment(MyDataGridView, {"Total Amount", "Payment Amount", "Discount", "Variance"}, DataGridViewContentAlignment.MiddleRight)


        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtBatchcode.Text = "" Then
            MessageBox.Show("Please enter OR Number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBatchcode.Focus()
            Exit Sub
        ElseIf countqry("tblpaymenttransactions", "trnid='" & txtBatchcode.Text & "' and cancelled=0") > 0 Then
            MessageBox.Show("Or Number already exists!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBatchcode.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MessageBox.Show("Please Select client!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClient.Focus()
            Exit Sub
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
        ElseIf Val(CC(txtAmountTender.Text)) <= 0 Then
            MessageBox.Show("Please enter proper amount!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmountTender.Focus()
            Exit Sub
        
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim totalpayment As Double = 0
            If Val(CC(txtAmount.Text)) > 0 Then
                If ckChange.Checked = False And Val(CC(txtVariance.Text)) > 0 Then
                    totalpayment = Val(CC(txtAmountTender.Text)) - Val(CC(txtVariance.Text))
                Else
                    totalpayment = Val(CC(txtAmountTender.Text))
                End If
            Else
                totalpayment = Val(CC(txtAmountTender.Text))
            End If


            If rbCash.Checked = True Then
                If Val(CC(txtAmountTender.Text)) <> 0 Then
                    If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'") > 0 Then
                        com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange=0,datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & txtBatchcode.Text & "',amount='" & Val(CC(txtAmountTender.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    End If
                End If
            End If

            com.CommandText = "insert into tblpaymenttransactions set trnid='" & txtBatchcode.Text & "', transactiontype='pos', accountno='" & cifid.Text & "', paymenttype='" & txtPaymentMode.Text & "', totalamount='" & Val(CC(txtAmount.Text)) & "', paymentamount='" & totalpayment & "',depositpaymentchange=" & ckChange.CheckState & ", discount='" & Val(CC(txtDiscount.Text)) & "', variance='" & Val(CC(txtVariance.Text)) & "', note='" & rchar(txtNote.Text) & "',depositto='" & globalSalesTrnCOde & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            If Val(CC(txtVariance.Text)) > 0 And ckChange.Checked = True Then
                com.CommandText = "update tblclientaccounts set creditbalance='" & Val(CC(txtVariance.Text)) & "' where cifid='" & cifid.Text & "'" : com.ExecuteNonQuery()
            End If
            'auto cleared client payment posting settings
            com.CommandText = "update tblpaymenttransactions set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp where trnid='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblglaccountledger (batchcode,journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                    + "select '" & txtBatchcode.Text & "','client-accounts',accountno,trnid,'Payment Invoice',note, 0, paymentamount,datetrn,trnby,1,'" & globaluserid & "',ADDTIME(current_timestamp,2) from tblpaymenttransactions where trnid='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()

            If ckDiscount.Checked = True Then
                com.CommandText = "insert into tblglaccountledger set batchcode='" & txtBatchcode.Text & "',journalmode='client-accounts',accountno='" & cifid.Text & "',referenceno='" & txtBatchcode.Text & "',itemcode='Invoice Discount',remarks='" & rchar(txtDiscountRemarks.Text) & "',debit=0,credit='" & Val(CC(txtDiscount.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If

            For Each itm As ListViewItem In ListView1.CheckedItems
                If itm.SubItems(5).Text = "Invoice" Then
                    com.CommandText = "update tblsalesclientcharges set paymentupdated=1, paymentrefnumber='" & txtBatchcode.Text & "' where trnid='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblsalesaccounttransaction set paymentupdated=1, paymentrefnumber='" & txtBatchcode.Text & "' where id='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                End If
            Next
            If MessageBox.Show("Do you want to print acknowlegement receipt transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If LCase(Globalclientjournaltemplate) = "pos" Then
                    If globalEnablePosPrinter = True Then
                        PrintPOSClientJournalReceipt(txtBatchcode.Text, txtClient.Text, "Charge Invoice", txtPaymentMode.Text & " - " & txtNote.Text, totalpayment, False)
                        If MessageBox.Show("Print receipt for merchant copy? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            PrintPOSClientJournalReceipt(txtBatchcode.Text, txtClient.Text, "Charge Invoice", txtPaymentMode.Text & " - " & txtNote.Text, totalpayment, False)
                        End If
                    End If
                Else
                    GenerateLXClientJournal(txtClient.Text, qrysingledata("compadd", "compadd", "tblclientaccounts where cifid='" & cifid.Text & "'"), "Charge Invoice", txtPaymentMode.Text & " - " & txtNote.Text, totalpayment, txtBatchcode.Text, Me)
                End If
            End If

            rbCash.Checked = True : cifid.Text = "" : txtClient.SelectedIndex = -1 : LoadInvoices()
            txtAmountTender.Text = "0.00" : txtVariance.Text = "0.00"
            txtAmount.Text = "0.00"
            txtDiscountRemarks.Text = ""
            txtNote.Text = ""
            FilterTransaction() : GetOrNumber()
            MessageBox.Show("Payment successfully posted!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        'For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
        '    If CBool(rw.Cells("Verified").Value) = True Then
        '        MessageBox.Show(rw.Cells("Client").Value & " transaction already verified! cannot be cancel", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'Next
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblpaymenttransactions set cancelled=1, cancelledby='" & globaluserid & "',datecancelled=current_timestamp where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblglaccountledger set cancelled=1, cancelledby='" & globaluserid & "',datecancelled=current_timestamp  where batchcode='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblsalesclientcharges set paymentupdated=0, paymentrefnumber='' where paymentrefnumber='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblsalesaccounttransaction set paymentupdated=0, paymentrefnumber='' where paymentrefnumber='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                CancelPaymentTransaction(rw.Cells("trnid").Value.ToString)
            Next
            FilterTransaction() : LoadInvoices()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        InputNumberOnly(txtAmountTender, e)
    End Sub
    Private Sub txtAmountTender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountTender.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtAmountTender, e)
        End If
    End Sub
    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        InputNumberOnly(txtDiscount, e)
    End Sub

    Private Sub cmdInputPaymentDetails_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdInputPaymentDetails.LinkClicked
        frmPOSMultiPayments.batchcode.Text = txtBatchcode.Text
        frmPOSMultiPayments.lblTransaction.Text = txtClient.Text
        frmPOSMultiPayments.txtTotalOnScreen.Text = If(Val(CC(txtAmount.Text)) = 0, txtOpenBalance.Text, txtAmount.Text)
        frmPOSMultiPayments.cifid.Text = cifid.Text
        frmPOSMultiPayments.mode.Text = "client"
        frmPOSMultiPayments.ShowDialog(Me)
    End Sub

    Private Sub txtVariance_TextChanged(sender As Object, e As EventArgs) Handles txtVariance.TextChanged

    End Sub
End Class