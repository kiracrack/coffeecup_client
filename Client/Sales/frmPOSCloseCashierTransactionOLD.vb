Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPOSCloseCashierTransactionOLD
    Public TransactionDone As Boolean = False
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Control) + Keys.B Then
            frmPOScashDonimination.Show(Me)
        ElseIf keyData = (Keys.Control) + Keys.P Then
            EditChapterToolStripMenuItem.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSCloseTransaction_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadCashDenomination()
    End Sub
    Private Sub frmPOSCloseTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

        'If EnableModuleFuel = True Then
        '    If TabControl1.TabPages.Contains(tabSoldFuel) = False Then
        '        TabControl1.TabPages.Add(tabSoldFuel)
        '    End If
        '    If TabControl1.TabPages.Contains(tabWalkinFuelSales) = False Then
        '        TabControl1.TabPages.Add(tabWalkinFuelSales)
        '    End If
        'Else
        '    TabControl1.TabPages.Remove(tabSoldFuel)
        '    TabControl1.TabPages.Remove(tabWalkinFuelSales)
        'End If

        'Temporary Disable
        TabControl1.TabPages.Remove(tabSoldFuel)
        TabControl1.TabPages.Remove(tabSoldProduct)
        TabControl1.TabPages.Remove(tabKeyAccounts)
        TabControl1.TabPages.Remove(tabKeyAccountsWalkinSales)
        TabControl1.TabPages.Remove(tabWalkinFuelSales)
        TabControl1.TabPages.Remove(tabWalkinOtherProductSales)


        If Globalenablechittransaction = True Then
            lblTotalChit.Visible = True
            txtTotalChitTransaction.Visible = True
        Else
            lblTotalChit.Visible = False
            txtTotalChitTransaction.Visible = False
        End If
        If globalAuthHotelManagement = True Then
            lblHotelTitle.Visible = True
            lblHotelSales.Visible = True
            lblHotelPayments.Visible = True
            txtHotelSales.Visible = True
            txtHotelPayments.Visible = True

        Else
            lblHotelTitle.Visible = False
            lblHotelSales.Visible = False
            lblHotelPayments.Visible = False
            txtHotelSales.Visible = False
            txtHotelPayments.Visible = False
        End If
        If EnableModuleHotel = True Then
            lblChargeToHotel.Visible = True
            txtChargeToHotel.Visible = True
        Else
            lblChargeToHotel.Visible = False
            txtChargeToHotel.Visible = False
        End If
        LoadTransactionSummary()
        LoadCashDenomination()
        tabFilter()

        LoadReport()
        txtPrintReport.SelectedIndex = 0
        If GlobalEnableCashierReportSummaryView = True Then
            TabControl1.Enabled = True
            PanelCashierCloseTransaction.Visible = False
            PanelCashierCloseTransaction.SendToBack()
        Else
            TabControl1.Enabled = False
            PanelCashierCloseTransaction.Visible = True
            PanelCashierCloseTransaction.BringToFront()
            Me.AcceptButton = cmdCloseCashierTransaction
            txtNextcashBeginning.Focus()
        End If
        TransactionBalanceSheet(myDataGridView_balanceSheetEmail)

    End Sub
    Public Sub LoadCashDenomination()
        com.CommandText = "select ifnull(sum(totalamount),0) as ttlamount,ifnull(sum(totalbills),0) as ttlbills, ifnull(sum(totalcoins),0) as ttlcoins from tblsalescashdenomination where trnsumcode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
        While rst.Read
            txtActualCashOnHand.Text = FormatNumber(rst("ttlamount"), 2)
            txtTotalBill.Text = FormatNumber(rst("ttlbills"), 2)
            txtTotalCoins.Text = FormatNumber(rst("ttlcoins"), 2)

            txt_ActualCashOnHand.Text = FormatNumber(rst("ttlamount"), 2)
            txt_TotalBill.Text = FormatNumber(rst("ttlbills"), 2)
            txt_TotalCoins.Text = FormatNumber(rst("ttlcoins"), 2)
        End While
        rst.Close()
    End Sub

    Public Sub LoadReport()
        txtPrintReport.Items.Clear()
        txtPrintReport.Items.Add("Sale's Blotter Report")
        txtPrintReport.Items.Add("Sale's Transaction Summary")
        txtPrintReport.Items.Add("Key Accounts Transaction")
        If globalAuthHotelManagement = True Then
            txtPrintReport.Items.Add("In-house Guest Report")
        End If
    End Sub

    Public Sub LoadTransactionSummary()
        txtDateFrom.Text = qrysingledata("val", "date_format(dateopen,'%M %d, %Y %h:%m %p') as 'val'", "tblsalessummary where trncode='" & globalSalesTrnCOde & "'")
        txtDateTo.Text = Format(Now, "MMMM dd, yyyy hh:mm tt")
        txtBeginningCash.Text = FormatNumber(Val(qrysingledata("val", "ifnull(begcash,0) as 'val'", "tblsalessummary where trncode='" & globalSalesTrnCOde & "'")), 2)
        txtDiscountOverall.Text = FormatNumber(-Val(qrysingledata("ttl", "sum(total) as ttl", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and total<0 and cancelled=0 and void=0 and onhold=0")), 2)
        txtTotalExpenses.Text = FormatNumber(qrysingledata("val", "ifnull(sum(amount),0) as 'val'", "tblexpenses where duefromcode='" & globalSalesTrnCOde & "' and cancelled=0 and affectcash=1"), 2)
        txtDebitAccountJournal.Text = FormatNumber(qrysingledata("val", "ifnull(sum(debit),0) as 'val'", "tblsalesaccountjournal where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and affectcash=1"), 2)
        txtCreditAccountJournal.Text = FormatNumber(qrysingledata("val", "ifnull(sum(credit),0) as 'val'", "tblsalesaccountjournal where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and affectcash=1"), 2)
        txtPOSSales.Text = FormatNumber(qrysingledata("val", "ifnull(sum(total),0) as 'val'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and total>0 and cancelled=0 and void=0 and onhold=0 and catid not in (select distinct catid from tblsalesfuelpump inner join tblglobalproducts on tblsalesfuelpump.productid = tblglobalproducts.productid)"), 2)

        'txtGLDebit.Text = FormatNumber(qrysingledata("val", "ifnull(sum(if(debit=0,credit,debit)),0) as 'val'", "tblgljournal where addtocashiercash=1 and reference='" & globalSalesTrnCOde & "' and cancelled=0"), 2)
        'txtGLCredit.Text = FormatNumber(qrysingledata("val", "ifnull(sum(if(debit=0,credit,debit)),0) as 'val'", "tblgljournal where addtocashiercash=0 and reference='" & globalSalesTrnCOde & "' and cancelled=0"), 2)

        txtClientJournalEntries.Text = FormatNumber(qrysingledata("val", "ifnull(sum(debit),0) as 'val'", "tblsalesaccounttransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and affectcash=1"), 2)
        txtTotalReturnItem.Text = FormatNumber(qrysingledata("val", "ifnull(sum(totalcost),0) as 'val'", "tblsalesreturneditem where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and affectcash=1"), 2)
        txtOtherTransation.Text = FormatNumber(qrysingledata("val", "ifnull(sum(amount),0) as 'val'", "tblsalesothertransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0"), 2)

        txtTotalSoldItem.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(totalitem),0) as 'ttl'", "tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and void=0"), 0)
        txtCancelledItem.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(totalitemcancelled),0) as 'ttl'", "tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and void=0"), 0)
        txtTotalVoidItem.Text = FormatNumber(qrysingledata("ttl", "count(*) as 'ttl'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and void=1"), 0)
        txtTotalCancelledTransaction.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(total),0) as 'ttl'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=1"), 2)
        txtTotalVoidTransaction.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(total),0) as 'ttl'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and void=1"), 2)
        txtTotalDiscount.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(totaldiscount),0) as 'ttl'", "tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and void=0")), 2)
        txtTotalCharges.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(totalcharge),0) as 'ttl'", "tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and void=0")), 2)
        txtTotalTax.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(totaltax),0) as 'ttl'", "tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and void=0"), 2)
        txtTotalChitTransaction.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(netdiscount-netdiscountaftertax),0) as 'ttl'", "tblsaleschitbatch where trnsumcode='" & globalSalesTrnCOde & "' and void=0"), 2)


        txtHotelSales.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(debit),0) as 'ttl'", "tblhoteltransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and roomcharge=1 and chargefrompos=0"), 2)
        txtChargeToHotel.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(debit),0) as 'ttl'", "tblhoteltransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and chargefrompos=1"), 2)
        txtHotelPayments.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(credit),0) as 'ttl'", "tblhoteltransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and paymenttrn=1 ")) + qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsalesclientcharges where foliocharge=1 and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'"), 2)
        txtInterOffice.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(coveredamount),0) as 'ttl'", "tblsalesinteroffice where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0"), 2)
        txtTotalCoupon.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(total),0) as 'ttl'", "tblsalescoupon where verified=1 and verifiedtrnsumcode='" & globalSalesTrnCOde & "'"), 2)


        txtTotalChargeAcct.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsalesclientcharges where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'"), 2)
        txtKeyAccountPayment.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(paymentamount),0) as 'ttl'", "tblpaymenttransactions where depositto='" & globalSalesTrnCOde & "' and cancelled=0 "), 2)

        txtTotalCheck.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsaleschecktransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0")) + Val(qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsaleschecktocash where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0")), 2)
        txtCreditCard.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsalescardtransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0")), 2)
        txtPaymentDeposit.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsalesdepositpaymenttransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0")), 2)
        txtAccountingTicket.Text = FormatNumber(Val(qrysingledata("ttl", "ifnull(sum(amount),0) as 'ttl'", "tblsalesticketpaymenttransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0")), 2)

        txtTotalIncome.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(income),0) as 'ttl'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and cancelled=0 and void=0 and purchasedprice>0 and sellprice>0 and inventory=1"), 2)
        txtOldStockncome.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(income),0) as 'ttl'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and cancelled=0 and void=0 and purchasedprice=0 and sellprice>0 and inventory=1"), 2)
        txtTotalIncomeServices.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(income),0) as 'ttl'", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and cancelled=0 and void=0 and income>0 and inventory=0"), 2)
        Dim complimentary As Double = 0
        complimentary = FormatNumber(qrysingledata("ttl", "ifnull(sum(total),0) as 'ttl'", "tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=0 and void=0 and complimentary=1 and paymenttype='cpty'"), 2)

        'TOTAL SALES = TOTAL READING + TOTAL OTHER PRODUCT
        com.CommandText = "call sp_salessummary('" & globalSalesTrnCOde & "')" : com.ExecuteNonQuery()

        txtTotalSales.Text = FormatNumber(ComputeSoldFuelReadingSales() + ComputeOtherProductSales() + Val(CC(txtHotelSales.Text)), 2)
        If countqry("tmpsalessummary", "description='SYSTEM CASH END'") > 0 Then
            txtTotalCashSales.Text = FormatNumber(qrysingledata("ttl", "ifnull(credit,0) as ttl", " tmpsalessummary where description='SYSTEM CASH END'"), 2)
        Else
            txtTotalCashSales.Text = "0.00"
        End If


        txtTotalTrnDebit.Text = FormatNumber(Val(CC(txtTotalSales.Text)) + Val(CC(txtBeginningCash.Text)) + Val(CC(txtTotalChitTransaction.Text)) + Val(CC(txtKeyAccountPayment.Text)) + Val(CC(txtCreditAccountJournal.Text)) + Val(CC(txtGLDebit.Text)) + Val(CC(txtOtherTransation.Text)) - Val(CC(txtHotelSales.Text)), 2)
        txtTotalTrnCredit.Text = FormatNumber(Val(CC(txtDiscountOverall.Text)) + Val(CC(txtTotalExpenses.Text)) + Val(CC(txtTotalReturnItem.Text)) + Val(CC(txtTotalCheck.Text)) + Val(CC(txtCreditCard.Text)) + Val(CC(txtPaymentDeposit.Text)) + Val(CC(txtAccountingTicket.Text)) + Val(CC(txtClientJournalEntries.Text)) + Val(CC(txtTotalChargeAcct.Text)) + Val(CC(txtChargeToHotel.Text)) + Val(CC(txtInterOffice.Text)) + Val(CC(txtTotalCoupon.Text)) + Val(CC(txtTotalCashSales.Text)) + Val(CC(txtDebitAccountJournal.Text)) + Val(CC(txtGLCredit.Text)) + complimentary, 2)
    End Sub

    Public Sub ComputeCashRemitted()
        ' Dim cashonHand As Double = Val(CC(txtActualCashOnHand.Text)) : Dim nextbeginingcash As Double = Val(CC(txtNextcashBeginning.Text))
        txtCashRemitted.Text = FormatNumber(Val(CC(txtActualCashOnHand.Text)) - Val(CC(txtNextcashBeginning.Text)), 2)
        txt_CashRemitted.Text = FormatNumber(Val(CC(txtActualCashOnHand.Text)) - Val(CC(txtNextcashBeginning.Text)), 2)

    End Sub

    Private Sub txtTotalCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalBill.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtTotalBill, e)
        End If
    End Sub

    Private Sub txtNextcashBeginning_KeyPress(sender As Object, e As EventArgs) Handles txtNextcashBeginning.TextChanged
        ComputeCashRemitted()
    End Sub

    Private Sub txt_NextcashBeginning_KeyPress(sender As Object, e As EventArgs) Handles txt_NextcashBeginning.TextChanged
        txtNextcashBeginning.Text = txt_NextcashBeginning.Text
        ComputeCashRemitted()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        CloseCashierTransaction()
    End Sub

    Public Function DeductFuelInventory() As String
        Dim DeductInventory As String = "" : Dim RecordInventory As String = ""
        '#load fuel Sale Reading
        Dim productid As String = ""
        com.CommandText = "select productid, itemname from tblglobalproducts where productid in (select distinct productid from tblsalesfuelpump) and actived=1" : rst = com.ExecuteReader
        While rst.Read
            productid = productid + rst("productid").ToString + ":"
        End While
        rst.Close()
        '#end fuel products

        If productid <> "" Then
            productid = productid.Remove(productid.Length - 1, 1)
        End If

        'Calculate Total Sales Reading
        For Each word In productid.Split(New Char() {":"c})
            Dim prevQuantity As Double = 0
            If qrysingledata("quantity", "quantity", "tblinventory where productid='" & word & "' and officeid='" & compOfficeid & "'") = "" Then
                prevQuantity = 0
            Else
                prevQuantity = qrysingledata("quantity", "quantity", "tblinventory where productid='" & word & "' and officeid='" & compOfficeid & "'")
            End If
            com.CommandText = "select *, ifnull(sum(quantity-(select quantity from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0) as 'netquantity'  from tblsalesfuelreading  as a where a.trnsumcode='" & globalSalesTrnCOde & "' and a.productid='" & word & "'" : rst = com.ExecuteReader
            While rst.Read
                DeductInventory = DeductInventory + "update tblinventory set quantity=quantity-" & rst("netquantity").ToString & " where productid='" & word & "' and officeid='" & compOfficeid & "'; " & Chr(13)
                RecordInventory = RecordInventory + "insert into tblsalesfuelsold set trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', productid='" & word & "',quantity='" & rst("netquantity").ToString & "',prevquantity='" & Val(CC(prevQuantity)) & "';" & Chr(13)
            End While
            rst.Close()
        Next
        If DeductInventory <> "" Then
            com.CommandText = DeductInventory : com.ExecuteNonQuery()
            com.CommandText = "delete from tblsalesfuelsold where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
            com.CommandText = RecordInventory : com.ExecuteNonQuery()
        End If
        Return 0
    End Function



    Private Sub txtActualCashOnHand_TextChanged(sender As Object, e As EventArgs) Handles txtActualCashOnHand.TextChanged
        ComputeVariance()
        ComputeCashRemitted()
    End Sub

    Private Sub MyDataGridView_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles MyDataGridView.ColumnAdded
        MyDataGridView.Columns.Item(e.Column.Index).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub txtTotalCashSales_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCashSales.TextChanged
        ComputeVariance()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub

    Private Sub cmdPrintReport_Click(sender As Object, e As EventArgs) Handles cmdPrintReport.Click
        If trapTransaction() = True Then
            If txtPrintReport.Text = "" Then
                MessageBox.Show("Please select report time to print", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPrintReport.Focus()
                Exit Sub
            End If

            If globalEnablePosPrinter = True Then
                If txtPrintReport.SelectedIndex = 0 Then
                    PrintSalesBlotter()

                ElseIf txtPrintReport.SelectedIndex = 1 Then
                    PrintSalesSummary()

                ElseIf txtPrintReport.SelectedIndex = 2 Then
                    PrintKeyAccountsTransaction()

                ElseIf txtPrintReport.SelectedIndex = 3 Then
                    PrintInhouseGuestTransaction()
                End If
            End If
        End If
    End Sub

    Public Sub ComputeVariance()
        Dim totalcashsales As Double = Val(CC(txtTotalCashSales.Text)) : Dim actualCash As Double = Val(CC(txtActualCashOnHand.Text))
        txtCashVariance.Text = FormatNumber(actualCash - totalcashsales, 2)

        If Val(CC(txtCashVariance.Text)) = 0 Then
            txtCashVariance.BackColor = DefaultBackColor
            txtCashVariance.ForeColor = Color.Black
        Else
            txtCashVariance.BackColor = Color.Red
            txtCashVariance.ForeColor = Color.White
        End If

    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub

    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabSoldFuel Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ReadFuelReadingSales()

        ElseIf TabControl1.SelectedTab Is tabBalanceSheet Then
            TransactionBalanceSheet(MyDataGridView_balancesheet)

        ElseIf TabControl1.SelectedTab Is tabCheckTransaction Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ReadCheckTransaction()

        ElseIf TabControl1.SelectedTab Is tabCreditCard Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ReadCreditCardTransaction()

        ElseIf TabControl1.SelectedTab Is tabDeposit Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ReadBankDepositTransaction()

            'ElseIf TabControl1.SelectedTab Is tabSoldProduct Then
            '    MyDataGridView.Parent = TabControl1.SelectedTab
            '    ReadOtherProductSales()

            'ElseIf TabControl1.SelectedTab Is tabKeyAccounts Then
            '    MyDataGridView.Parent = TabControl1.SelectedTab
            '    ReadKeyAccountSales()

            'ElseIf TabControl1.SelectedTab Is tabKeyAccountsWalkinSales Then
            '    MyDataGridView.Parent = TabControl1.SelectedTab
            '    ReadKeyAccountWalkinSales()

            'ElseIf TabControl1.SelectedTab Is tabWalkinFuelSales Then
            '    MyDataGridView.Parent = TabControl1.SelectedTab
            '    ReadWalkinFuelReadingSales()

            'ElseIf TabControl1.SelectedTab Is tabWalkinOtherProductSales Then
            '    MyDataGridView.Parent = TabControl1.SelectedTab
            '    ReadWalkinOtherProductSales()
        End If
    End Sub

#Region "S U M M A R Y   R E P O R T S"
    Public Sub TransactionBalanceSheet(ByVal gv As DataGridView)
        gv.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("call sp_salessummary('" & globalSalesTrnCOde & "')", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        gv.DataSource = dst.Tables(0)

        GridHideColumn(gv, {"dt"})
        GridCurrencyColumn(gv, {"Debit", "Credit"})

        If gv.RowCount > 0 Then
            gv.Rows(gv.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            gv.Rows(gv.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
            gv.Rows(gv.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        End If


        'For i = 0 To gv.RowCount - 1
        '    If gv.Item("Details", i).Value().ToString = "TOTAL" Then
        '        If gv.Item("Debit", i).Value().ToString <> gv.Item("Credit", i).Value().ToString Then
        '            gv.Rows(i).DefaultCellStyle.BackColor = Color.Red
        '            gv.Rows(i).DefaultCellStyle.ForeColor = Color.White
        '            gv.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        Else
        '            gv.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
        '            gv.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        '            gv.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        End If
        '    End If
        'Next

        gv.Columns("Description").Width = 400
        gv.Columns("Credit").Width = 120
        gv.Columns("Debit").Width = 120

        GridCurrencyColumn(gv, {"Credit", "Debit"})
        GridColumnAlignment(gv, {"Credit", "Debit"}, DataGridViewContentAlignment.MiddleRight)
        GridColumnAlignment(gv, {"Description"}, DataGridViewContentAlignment.MiddleLeft)
        For i = 0 To gv.Columns.Count - 1
            gv.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

#Region "TEMPORARY"

    Public Sub ReadFuelReadingSales()
        ''#load fuel products
        'Dim productid As String = ""
        'com.CommandText = "select productid, itemname from tblglobalproducts where productid in (select distinct productid from tblsalesfuelpump) and actived=1" : rst = com.ExecuteReader
        'While rst.Read
        '    productid = productid + rst("productid").ToString + ":"
        'End While
        'rst.Close()
        ''#end fuel products

        'If productid <> "" Then
        '    productid = productid.Remove(productid.Length - 1, 1)
        'End If

        ''load total fuel sales
        'MyDataGridView.Rows.Clear()
        'MyDataGridView.ColumnCount = 4
        'MyDataGridView.ColumnHeadersVisible = True

        'MyDataGridView.Columns(0).Name = "Particular"
        'MyDataGridView.Columns(1).Name = "Quantity"
        'MyDataGridView.Columns(2).Name = "Unit Price"
        'MyDataGridView.Columns(3).Name = "Total"

        'Dim totalsoldfuel As Double = 0
        'For Each word In productid.Split(New Char() {":"c})
        '    com.CommandText = "select *, (select itemname from tblglobalproducts where productid=a.productid and actived=1) as 'productname', (ifnull(sum(round(quantity,2)-(select round(quantity,2) from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0)) as 'totalround(quantity,2)', (ifnull(sum(round(quantity,2)-(select round(quantity,2) from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0)) * unitprice as 'total'  from tblsalesfuelreading  as a where a.trnsumcode='" & globalSalesTrnCOde & "' and productid='" & word & "'" : rst = com.ExecuteReader
        '    While rst.Read
        '        If Val(rst("total").ToString) > 0 Then
        '            MyDataGridView.Rows.Add(rst("productname").ToString, FormatNumber(rst("totalround(quantity,2)").ToString, 2), FormatNumber(rst("unitprice").ToString), FormatNumber(rst("total").ToString, 2))
        '            totalsoldfuel = totalsoldfuel + Val(rst("total").ToString)
        '        End If
        '    End While
        '    rst.Close()
        'Next
        'MyDataGridView.Rows.Add("GRAND TOTAL", "", "", FormatNumber(totalsoldfuel, 2))
        ''End total fuel sales

        'MyDataGridView.Columns("Particular").Width = 180
        'MyDataGridView.Columns("Total").Width = 120

        'GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Total"})
        'GridColumnAlignment(MyDataGridView, {"Quantity", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Total"}, DataGridViewContentAlignment.MiddleRight)

        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ReadOtherProductSales()
        ''#Other Products
        'Dim catid As String = "" : Dim categoryname As String = ""
        'com.CommandText = "select catid, description from tblprocategory where catid in (select distinct catid from tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and tblsalestransaction.cancelled=0 and void=0) and catid not in (select distinct catid from tblsalesfuelpump inner join tblglobalproducts on tblsalesfuelpump.productid = tblglobalproducts.productid and tblglobalproducts.actived=1 )" : rst = com.ExecuteReader
        'While rst.Read
        '    catid = catid + rst("catid").ToString + ":"
        '    categoryname = categoryname + rst("description").ToString + ":"
        'End While
        'rst.Close()
        ''#End Other Products

        'If catid <> "" Then
        '    catid = catid.Remove(catid.Length - 1, 1)
        '    categoryname = categoryname.Remove(categoryname.Length - 1, 1)
        'End If
        ''load total fuel sales
        'MyDataGridView.Rows.Clear()
        'MyDataGridView.ColumnCount = 4
        'MyDataGridView.ColumnHeadersVisible = True

        'MyDataGridView.Columns(0).Name = "Particular"
        'MyDataGridView.Columns(1).Name = "Quantity"
        'MyDataGridView.Columns(2).Name = "Unit Price"
        'MyDataGridView.Columns(3).Name = "Total"

        ''load total category sales
        'Dim grandtotal As Double = 0
        'For Each word In catid.Split(New Char() {":"c})
        '    Dim subtotal As Double = 0 : Dim catname As String = ""
        '    com.CommandText = "select *, sum(quantity) as 'totalquantity',sum(total) as 'ttl', (select description from tblprocategory where catid=tblsalestransaction.catid ) as 'catname',(select itemname from tblglobalproducts where productid=tblsalestransaction.productid and actived=1) as 'product' from tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and catid='" & word & "' and tblsalestransaction.cancelled=0 and void=0 and tblsalestransaction.onhold=0 group by productid,sellprice" : rst = com.ExecuteReader
        '    While rst.Read
        '        MyDataGridView.Rows.Add(rst("product").ToString, FormatNumber(rst("totalquantity").ToString, 2), FormatNumber(rst("sellprice").ToString, 2), FormatNumber(rst("ttl").ToString, 2))
        '        subtotal = subtotal + Val(rst("ttl").ToString)
        '        catname = rst("catname").ToString
        '    End While
        '    rst.Close()
        '    grandtotal = grandtotal + subtotal
        '    MyDataGridView.Rows.Add("TOTAL " & UCase(catname), "", "", FormatNumber(subtotal, 2))
        '    MyDataGridView.Rows.Add("", "", "", "")
        'Next
        'MyDataGridView.Rows.Add("GRAND TOTAL", "", "", FormatNumber(grandtotal, 2))
        ''End total category sales
        'For Each word In categoryname.Split(New Char() {":"c})
        '    For i = 0 To MyDataGridView.RowCount - 1
        '        If MyDataGridView.Item("Particular", i).Value().ToString = "TOTAL " & UCase(word) Then
        '            MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
        '            MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        '            MyDataGridView.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        End If
        '    Next
        'Next


        'MyDataGridView.Columns("Particular").Width = 180
        'MyDataGridView.Columns("Total").Width = 120

        'GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Total"})
        'GridColumnAlignment(MyDataGridView, {"Quantity", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Total"}, DataGridViewContentAlignment.MiddleRight)

        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ReadKeyAccountSales()
        ''#Other Products
        ''load total fuel sales
        'MyDataGridView.Rows.Clear()
        'MyDataGridView.ColumnCount = 8
        'MyDataGridView.ColumnHeadersVisible = True

        'MyDataGridView.Columns(0).Name = "Client"
        'MyDataGridView.Columns(1).Name = "Particular"
        'MyDataGridView.Columns(2).Name = "Quantity"
        'MyDataGridView.Columns(3).Name = "Unit Price"
        'MyDataGridView.Columns(4).Name = "Charges"
        'MyDataGridView.Columns(5).Name = "Discount"
        'MyDataGridView.Columns(6).Name = "SubTotal"
        'MyDataGridView.Columns(7).Name = "Total"


        'Dim catid As String = "" : Dim categoryname As String = ""
        'com.CommandText = "select distinct catid,(select description from tblprocategory where catid=tblsalestransaction.catid ) as 'catname'  from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode where tblsalestransaction.trnsumcode='" & globalSalesTrnCOde & "' and tblsalestransaction.cancelled=0 and void=0" : rst = com.ExecuteReader
        'While rst.Read
        '    catid = catid + rst("catid").ToString + ":"
        '    categoryname = categoryname + rst("catname").ToString + ":"
        'End While
        'rst.Close()
        ''#End Other Products
        'If catid <> "" Then
        '    catid = catid.Remove(catid.Length - 1, 1)
        '    categoryname = categoryname.Remove(categoryname.Length - 1, 1)
        'End If
        'Dim grandCharges As Double = 0 : Dim grandDiscount As Double = 0 : Dim grandSubtotal As Double = 0 : Dim grandtotal As Double = 0
        'For Each word In catid.Split(New Char() {":"c})
        '    Dim subCharges As Double = 0 : Dim subDiscount As Double = 0 : Dim subSubtotal As Double = 0 : Dim subtotal As Double = 0 : Dim catname As String = ""
        '    com.CommandText = "select *, round(quantity,2) as 'ttlquantity',(select companyname from tblclientaccounts where cifid = tblsalestransaction.cifid) as 'Client',(select description from tblprocategory where catid=tblsalestransaction.catid ) as 'catname', (select itemname from tblglobalproducts where productid=tblsalestransaction.productid and actived=1) as 'product' from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode where tblsalestransaction.trnsumcode='" & globalSalesTrnCOde & "' and catid='" & word & "'  and tblsalestransaction.cancelled=0 and void=0" : rst = com.ExecuteReader
        '    While rst.Read
        '        MyDataGridView.Rows.Add(rst("Client").ToString, rst("product").ToString, FormatNumber(rst("ttlquantity").ToString, 2), FormatNumber(rst("sellprice").ToString, 2), FormatNumber(rst("chargetotal").ToString, 2), FormatNumber(rst("distotal").ToString, 2), FormatNumber(rst("subtotal").ToString, 2), FormatNumber(rst("total").ToString, 2))
        '        catname = rst("catname").ToString

        '        subCharges = subCharges + Val(rst("chargetotal").ToString)
        '        subDiscount = subDiscount + Val(rst("distotal").ToString)
        '        subSubtotal = subSubtotal + Val(rst("subtotal").ToString)
        '        subtotal = subtotal + Val(rst("total").ToString)

        '        grandCharges = grandCharges + Val(rst("chargetotal").ToString)
        '        grandDiscount = grandDiscount + Val(rst("distotal").ToString)
        '        grandSubtotal = grandSubtotal + Val(rst("subtotal").ToString)
        '        grandtotal = grandtotal + Val(rst("total").ToString)
        '    End While
        '    rst.Close()
        '    MyDataGridView.Rows.Add("TOTAL " & UCase(catname), "", "", "", FormatNumber(subCharges, 2), FormatNumber(subDiscount, 2), FormatNumber(subSubtotal, 2), FormatNumber(subtotal, 2))
        '    MyDataGridView.Rows.Add("", "", "", "", "")
        'Next

        'For Each word In categoryname.Split(New Char() {":"c})
        '    For i = 0 To MyDataGridView.RowCount - 1
        '        If MyDataGridView.Item("Client", i).Value().ToString = "TOTAL " & UCase(word) Then
        '            MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
        '            MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        '            MyDataGridView.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        End If
        '    Next
        'Next

        'MyDataGridView.Rows.Add("GRAND TOTAL", "", "", "", FormatNumber(grandCharges, 2), FormatNumber(grandDiscount, 2), FormatNumber(grandSubtotal, 2), FormatNumber(grandtotal, 2))

        'MyDataGridView.Columns("Client").Width = 140
        'MyDataGridView.Columns("Particular").Width = 180
        'MyDataGridView.Columns("Charges").Width = 90
        'MyDataGridView.Columns("Discount").Width = 90
        'MyDataGridView.Columns("SubTotal").Width = 90
        'MyDataGridView.Columns("Total").Width = 90
        'GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Charges", "Discount", "SubTotal", "Total"})
        'GridColumnAlignment(MyDataGridView, {"Quantity", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Charges", "Discount", "SubTotal", "Total"}, DataGridViewContentAlignment.MiddleRight)
        'GridColumnAlignment(MyDataGridView, {"Particular"}, DataGridViewContentAlignment.MiddleLeft)

        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ReadKeyAccountWalkinSales()
        ''#Other Products
        ''load total fuel sales
        'MyDataGridView.Rows.Clear()
        'MyDataGridView.ColumnCount = 8
        'MyDataGridView.ColumnHeadersVisible = True

        'MyDataGridView.Columns(0).Name = "Client"
        'MyDataGridView.Columns(1).Name = "Particular"
        'MyDataGridView.Columns(2).Name = "Quantity"
        'MyDataGridView.Columns(3).Name = "Unit Price"
        'MyDataGridView.Columns(4).Name = "Charges"
        'MyDataGridView.Columns(5).Name = "Discount"
        'MyDataGridView.Columns(6).Name = "SubTotal"
        'MyDataGridView.Columns(7).Name = "Total"



        'Dim catid As String = "" : Dim categoryname As String = ""
        'com.CommandText = "select distinct catid,(select description from tblprocategory where catid=tblsalestransaction.catid ) as 'catname'  from tblsalestransaction where batchcode not in (select batchcode from tblsalesclientcharges  where trnsumcode='" & globalSalesTrnCOde & "' ) and tblsalestransaction.cancelled=0 and void=0 and tblsalestransaction.onhold=0 and tblsalestransaction.trnsumcode='" & globalSalesTrnCOde & "' and cifid not in (select cifid from tblclientaccounts where walkinaccount=1)" : rst = com.ExecuteReader
        'While rst.Read
        '    catid = catid + rst("catid").ToString + ":"
        '    categoryname = categoryname + rst("catname").ToString + ":"
        'End While
        'rst.Close()
        ''#End Other Products
        'If catid <> "" Then
        '    catid = catid.Remove(catid.Length - 1, 1)
        '    categoryname = categoryname.Remove(categoryname.Length - 1, 1)
        'End If
        'Dim grandCharges As Double = 0 : Dim grandDiscount As Double = 0 : Dim grandSubtotal As Double = 0 : Dim grandtotal As Double = 0
        'For Each word In catid.Split(New Char() {":"c})
        '    Dim subCharges As Double = 0 : Dim subDiscount As Double = 0 : Dim subSubtotal As Double = 0 : Dim subtotal As Double = 0 : Dim catname As String = ""
        '    com.CommandText = "select *, round(quantity,2) as 'ttlquantity',(select companyname from tblclientaccounts where cifid = tblsalestransaction.cifid) as 'Client',(select description from tblprocategory where catid=tblsalestransaction.catid ) as 'catname', (select itemname from tblglobalproducts where productid=tblsalestransaction.productid and actived=1) as 'product' from tblsalestransaction where batchcode not in (select batchcode from tblsalesclientcharges  where trnsumcode='" & globalSalesTrnCOde & "' ) and tblsalestransaction.cancelled=0 and void=0 and tblsalestransaction.onhold=0 and tblsalestransaction.trnsumcode='" & globalSalesTrnCOde & "' and catid='" & word & "' and cifid not in (select cifid from tblclientaccounts where walkinaccount=1)" : rst = com.ExecuteReader
        '    While rst.Read
        '        MyDataGridView.Rows.Add(rst("Client").ToString, rst("product").ToString, FormatNumber(rst("ttlquantity").ToString, 2), FormatNumber(rst("sellprice").ToString, 2), FormatNumber(rst("chargetotal").ToString, 2), FormatNumber(rst("distotal").ToString, 2), FormatNumber(rst("subtotal").ToString, 2), FormatNumber(rst("total").ToString, 2))
        '        subCharges = subCharges + Val(rst("chargetotal").ToString)
        '        subDiscount = subDiscount + Val(rst("distotal").ToString)
        '        subSubtotal = subSubtotal + Val(rst("subtotal").ToString)
        '        subtotal = subtotal + Val(rst("total").ToString)

        '        grandCharges = grandCharges + Val(rst("chargetotal").ToString)
        '        grandDiscount = grandDiscount + Val(rst("distotal").ToString)
        '        grandSubtotal = grandSubtotal + Val(rst("subtotal").ToString)
        '        grandtotal = grandtotal + Val(rst("total").ToString)
        '        catname = rst("catname").ToString
        '    End While
        '    rst.Close()
        '    MyDataGridView.Rows.Add("TOTAL " & UCase(catname), "", "", "", FormatNumber(subCharges, 2), FormatNumber(subDiscount, 2), FormatNumber(subSubtotal, 2), FormatNumber(subtotal, 2))
        '    MyDataGridView.Rows.Add("", "", "", "", "", "", "", "")
        'Next

        'For Each word In categoryname.Split(New Char() {":"c})
        '    For i = 0 To MyDataGridView.RowCount - 1
        '        If MyDataGridView.Item("Client", i).Value().ToString = "TOTAL " & UCase(word) Then
        '            MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
        '            MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        '            MyDataGridView.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        End If
        '    Next
        'Next

        'MyDataGridView.Rows.Add("GRAND TOTAL", "", "", "", FormatNumber(grandCharges, 2), FormatNumber(grandDiscount, 2), FormatNumber(grandSubtotal, 2), FormatNumber(grandtotal, 2))

        'MyDataGridView.Columns("Client").Width = 140
        'MyDataGridView.Columns("Particular").Width = 180
        'MyDataGridView.Columns("Charges").Width = 90
        'MyDataGridView.Columns("Discount").Width = 90
        'MyDataGridView.Columns("SubTotal").Width = 90
        'MyDataGridView.Columns("Total").Width = 90
        'GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Charges", "Discount", "SubTotal", "Total"})
        'GridColumnAlignment(MyDataGridView, {"Quantity", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Charges", "Discount", "SubTotal", "Total"}, DataGridViewContentAlignment.MiddleRight)
        'GridColumnAlignment(MyDataGridView, {"Particular"}, DataGridViewContentAlignment.MiddleLeft)


        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ReadWalkinFuelReadingSales()
        ''#load fuel products
        'Dim productid As String = ""
        'com.CommandText = "select productid, itemname from tblglobalproducts where productid in (select distinct productid from tblsalesfuelpump) and actived=1" : rst = com.ExecuteReader
        'While rst.Read
        '    productid = productid + rst("productid").ToString + ":"
        'End While
        'rst.Close()
        ''#end fuel products

        'If productid <> "" Then
        '    productid = productid.Remove(productid.Length - 1, 1)
        'End If

        ''load total fuel sales
        'MyDataGridView.Rows.Clear()
        'MyDataGridView.ColumnCount = 4
        'MyDataGridView.ColumnHeadersVisible = True

        'MyDataGridView.Columns(0).Name = "Particular"
        'MyDataGridView.Columns(1).Name = "Quantity"
        'MyDataGridView.Columns(2).Name = "Unit Price"
        'MyDataGridView.Columns(3).Name = "Total"

        'Dim totalsoldfuel As Double = 0
        'For Each word In productid.Split(New Char() {":"c})
        '    com.CommandText = "select *, (select itemname from tblglobalproducts where productid=a.productid and actived=1) as 'productname', ifnull(sum(round(quantity,2)-(select round(quantity,2) from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0)-ifnull((select round(sum(round(quantity,2)),2) from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode  where tblsalestransaction.productid = a.productid and tblsalestransaction.trnsumcode = a.trnsumcode and void=0 and tblsalestransaction.cancelled=0),0) as 'totalround(quantity,2)', " _
        '                        + " (ifnull(sum(round(quantity,2)-(select round(quantity,2) from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0)-ifnull((select round(sum(round(quantity,2)),2) from tblsalestransaction inner join tblsalesclientcharges on tblsalestransaction.batchcode = tblsalesclientcharges.batchcode where tblsalestransaction.productid = a.productid and tblsalestransaction.trnsumcode = a.trnsumcode and void=0 and tblsalestransaction.cancelled=0),0)) * unitprice as 'total'  from tblsalesfuelreading  as a where a.trnsumcode='" & globalSalesTrnCOde & "' and productid='" & word & "'" : rst = com.ExecuteReader
        '    While rst.Read
        '        If Val(rst("total").ToString) > 0 Then
        '            MyDataGridView.Rows.Add(rst("productname").ToString, FormatNumber(rst("totalround(quantity,2)").ToString, 2), FormatNumber(rst("unitprice").ToString), FormatNumber(rst("total").ToString, 2))
        '            totalsoldfuel = totalsoldfuel + Val(rst("total").ToString)
        '        End If
        '    End While
        '    rst.Close()
        'Next
        'MyDataGridView.Rows.Add("GRAND TOTAL", "", "", FormatNumber(totalsoldfuel, 2))
        ''End total fuel sales

        'MyDataGridView.Columns("Particular").Width = 180
        'MyDataGridView.Columns("Total").Width = 120

        'GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Total"})
        'GridColumnAlignment(MyDataGridView, {"Quantity", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Total"}, DataGridViewContentAlignment.MiddleRight)

        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ReadWalkinOtherProductSales()
        ''#Other Products
        'Dim catid As String = "" : Dim categoryname As String = ""
        'com.CommandText = "select catid, description from tblprocategory where catid in (select distinct catid from tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and tblsalestransaction.cancelled=0 and void=0) and catid not in (select distinct catid from tblsalesfuelpump inner join tblglobalproducts on tblsalesfuelpump.productid = tblglobalproducts.productid and tblglobalproducts.actived=1 )" : rst = com.ExecuteReader
        'While rst.Read
        '    catid = catid + rst("catid").ToString + ":"
        '    categoryname = categoryname + rst("description").ToString + ":"
        'End While
        'rst.Close()
        ''#End Other Products

        'If catid <> "" Then
        '    catid = catid.Remove(catid.Length - 1, 1)
        '    categoryname = categoryname.Remove(categoryname.Length - 1, 1)
        'End If
        ''load total fuel sales
        'MyDataGridView.Rows.Clear()
        'MyDataGridView.ColumnCount = 4
        'MyDataGridView.ColumnHeadersVisible = True

        'MyDataGridView.Columns(0).Name = "Particular"
        'MyDataGridView.Columns(1).Name = "Quantity"
        'MyDataGridView.Columns(2).Name = "Unit Price"
        'MyDataGridView.Columns(3).Name = "Total"

        ''load total category sales
        'Dim grandtotal As Double = 0
        'For Each word In catid.Split(New Char() {":"c})
        '    Dim subtotal As Double = 0 : Dim catname As String = ""
        '    com.CommandText = "select *, sum(quantity) as 'totalquantity',sum(total) as 'ttl', (select description from tblprocategory where catid=tblsalestransaction.catid ) as 'catname',(select itemname from tblglobalproducts where productid=tblsalestransaction.productid and actived=1) as 'product' from tblsalestransaction where batchcode not in (select tblsalesclientcharges.batchcode from tblsalesclientcharges  where batchcode='" & globalSalesTrnCOde & "') and trnsumcode='" & globalSalesTrnCOde & "' and catid='" & word & "' and tblsalestransaction.cancelled=0 and void=0 and tblsalestransaction.onhold=0 group by productid,sellprice" : rst = com.ExecuteReader
        '    While rst.Read
        '        MyDataGridView.Rows.Add(rst("product").ToString, FormatNumber(rst("totalquantity").ToString, 2), FormatNumber(rst("sellprice").ToString, 2), FormatNumber(rst("ttl").ToString, 2))
        '        subtotal = subtotal + Val(rst("ttl").ToString)
        '        catname = rst("catname").ToString
        '    End While
        '    rst.Close()
        '    grandtotal = grandtotal + subtotal
        '    MyDataGridView.Rows.Add("TOTAL " & UCase(catname), "", "", FormatNumber(subtotal, 2))
        '    MyDataGridView.Rows.Add("", "", "", "")
        'Next
        'MyDataGridView.Rows.Add("GRAND TOTAL", "", "", FormatNumber(grandtotal, 2))
        ''End total category sales
        'For Each word In categoryname.Split(New Char() {":"c})
        '    For i = 0 To MyDataGridView.RowCount - 1
        '        If MyDataGridView.Item("Particular", i).Value().ToString = "TOTAL " & UCase(word) Then
        '            MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
        '            MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        '            MyDataGridView.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        End If
        '    Next
        'Next

        'MyDataGridView.Columns("Particular").Width = 180
        'MyDataGridView.Columns("Total").Width = 120

        'GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Total"})
        'GridColumnAlignment(MyDataGridView, {"Quantity", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Total"}, DataGridViewContentAlignment.MiddleRight)

        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

#End Region

    Public Sub ReadCheckTransaction()
        MyDataGridView_Check.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select datetrn as dt, referenceno as 'Reference', (select companyname from tblclientaccounts where cifid = tblsaleschecktransaction.accountno) as 'Client', checkno as 'Check No.', checkdetails 'Issuer Bank', remarks as 'Company Name',Amount,datetrn as 'Date Transaction' from tblsaleschecktransaction where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select datetrn as dt, id,'Check Encashment',checknumber,issuerbank,companyname,amount,datetrn from tblsaleschecktocash where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select  current_timestamp,'','','','','Total',(select sum(amount) from tblsaleschecktransaction where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "') + (select sum(amount) from tblsaleschecktocash where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "'),null) as s order by dt asc;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Check.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView_Check, {"dt"})
        GridCurrencyColumn(MyDataGridView_Check, {"Amount"})
        GridColumnAlignment(MyDataGridView_Check, {"Check No.", "Reference"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Check, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Check.Rows(MyDataGridView_Check.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Check.Rows(MyDataGridView_Check.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Check.Rows(MyDataGridView_Check.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub

    Public Sub ReadCreditCardTransaction()
        MyDataGridView_Card.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select referenceno as 'Reference', (select companyname from tblclientaccounts where cifid = tblsalescardtransaction.accountno) as 'Client', cardnumber as 'Card No.', carddetails 'Card Details', tracenumber as 'Trace Number', Remarks as 'Card Name', Amount ,datetrn as 'Date Transaction' from tblsalescardtransaction where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select  '','','','','','Total',sum(amount),null from tblsalescardtransaction where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "') as s;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Card.DataSource = dst.Tables(0)

        GridCurrencyColumn(MyDataGridView_Card, {"Amount"})
        GridColumnAlignment(MyDataGridView_Card, {"Card No.", "Trace Number", "Reference"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Card, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Card.Rows(MyDataGridView_Card.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Card.Rows(MyDataGridView_Card.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Card.Rows(MyDataGridView_Card.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ReadBankDepositTransaction()
        MyDataGridView_BankDeposit.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select batchcode as 'Reference', (select bankname from tblbankaccounts where bankcode = tblsalesdepositpaymenttransaction.bankaccount) as 'Deposit to', Amount ,datetrn as 'Date Transaction' from tblsalesdepositpaymenttransaction where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select  '','Total',sum(amount),null from tblsalesdepositpaymenttransaction where cancelled=0  and trnsumcode='" & globalSalesTrnCOde & "') as s;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_BankDeposit.DataSource = dst.Tables(0)

        GridCurrencyColumn(MyDataGridView_BankDeposit, {"Amount"})
        GridColumnAlignment(MyDataGridView_BankDeposit, {"Reference"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_BankDeposit, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_BankDeposit.Rows(MyDataGridView_BankDeposit.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_BankDeposit.Rows(MyDataGridView_BankDeposit.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_BankDeposit.Rows(MyDataGridView_BankDeposit.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
#End Region

#Region "C O M P U T A T I O N"

    Public Function ComputeSoldFuelReadingSales() As Double
        ComputeSoldFuelReadingSales = 0
        '#load fuel Sale Reading
        Dim productid As String = ""
        com.CommandText = "select productid, itemname from tblglobalproducts where productid in (select distinct productid from tblsalesfuelpump) and actived=1" : rst = com.ExecuteReader
        While rst.Read
            productid = productid + rst("productid").ToString + ":"
        End While
        rst.Close()
        '#end fuel products

        If productid <> "" Then
            productid = productid.Remove(productid.Length - 1, 1)
        End If

        'Calculate Total Sales Reading
        Dim totalsoldfuel As Double = 0
        For Each word In productid.Split(New Char() {":"c})
            com.CommandText = "select (ifnull(sum(round(quantity,2)-(select round(quantity,2) from tblsalesfuelreading as b where b.dateentry  <  a.dateentry and b.pumpcode = a.pumpcode order by dateentry desc limit 1 )),0)) * unitprice as 'total'  from tblsalesfuelreading  as a where a.trnsumcode='" & globalSalesTrnCOde & "' and a.productid='" & word & "'" : rst = com.ExecuteReader
            While rst.Read
                If Val(rst("total").ToString) > 0 Then
                    ComputeSoldFuelReadingSales = ComputeSoldFuelReadingSales + Val(rst("total").ToString)
                End If
            End While
            rst.Close()
        Next

        Return ComputeSoldFuelReadingSales
    End Function

    Public Function ComputeKeyAccountsFuelSales() As Double
        ComputeKeyAccountsFuelSales = Val(qrysingledata("ttl", "sum(total) as ttl", "tblsalestransaction  where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and void=0 and batchcode in (select batchcode from tblsalesclientcharges where trnsumcode='" & globalSalesTrnCOde & "') and catid in (select distinct catid from tblsalesfuelpump inner join tblglobalproducts on tblsalesfuelpump.productid = tblglobalproducts.productid and tblglobalproducts.actived=1)"))
        Return ComputeKeyAccountsFuelSales
    End Function

    Public Function ComputeOtherProductSales() As Double
        ComputeOtherProductSales = Val(qrysingledata("ttl", "sum(total) as ttl", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and total>0 and cancelled=0 and void=0 and onhold=0 and catid not in (select distinct catid from tblsalesfuelpump inner join tblglobalproducts on tblsalesfuelpump.productid = tblglobalproducts.productid)"))
        Return ComputeOtherProductSales
    End Function

    Public Function ComputeKeyAccountsDiscountFuelSales() As Double
        'ComputeKeyAccountsDiscountFuelSales = Val(qrysingledata("ttl", "sum(distotal) as ttl", "tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0 and void=0 and batchcode in (select batchcode from tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and floattrn=0 and void=0 and onhold=0 and paymenttype='cash')  and batchcode not in (select batchcode from tblsalesclientcharges where trnsumcode='" & globalSalesTrnCOde & "') and cifid not in (select cifid from tblclientaccounts where walkinaccount=1)"))
        Return ComputeKeyAccountsDiscountFuelSales
    End Function

#End Region

#Region "B L O T T E R"
    Public Sub PrintSalesBlotter()
        Dim details As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("SALES BLOTTER") & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("From: " & txtDateFrom.Text) & Environment.NewLine
        details += PrintLeftText("To: " & txtDateTo.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintLeftRigthText(lblSoldItem.Text, txtTotalSoldItem.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblCancelledItem.Text, txtCancelledItem.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblVoidItem.Text, txtTotalVoidItem.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalCancelled.Text, txtTotalCancelledTransaction.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalVoid.Text, txtTotalVoidTransaction.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalDiscount.Text, txtTotalDiscount.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalCharges.Text, txtTotalCharges.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalTax.Text, txtTotalTax.Text) & Environment.NewLine & Environment.NewLine

        If GLobalEnableViewSalesCashendreport = True Then
            details += PrintCenterText("- Debit Transaction -") & Environment.NewLine
        End If
        details += PrintLeftRigthText(UCase(lblTotalSales.Text), txtTotalSales.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblBeginningCash.Text, txtBeginningCash.Text) & Environment.NewLine
        If Val(CC(txtTotalChitTransaction.Text)) > 0 Then
            details += PrintLeftRigthText(lblTotalChit.Text, txtTotalChitTransaction.Text) & Environment.NewLine
        End If
        If Val(CC(txtKeyAccountPayment.Text)) > 0 Then
            details += PrintLeftRigthText(lblKeyaccountPayment.Text, txtKeyAccountPayment.Text) & Environment.NewLine
        End If
        If Val(CC(txtCreditAccountJournal.Text)) > 0 Then
            details += PrintLeftRigthText(lblCreditAccountJournal.Text, txtCreditAccountJournal.Text) & Environment.NewLine
        End If
        If Val(CC(txtGLDebit.Text)) > 0 Then
            details += PrintLeftRigthText("Journal Entries", txtGLDebit.Text) & Environment.NewLine
        End If
        If Val(CC(txtOtherTransation.Text)) > 0 Then
            details += PrintLeftRigthText(lblOtherTransaction.Text, txtOtherTransation.Text) & Environment.NewLine
        End If
        If GLobalEnableViewSalesCashendreport = True Then
            details += Environment.NewLine & PrintLeftRigthText("TOTAL DEBIT", txtTotalTrnDebit.Text) & Environment.NewLine
            details += PrintLeftRigthText("", "------------") & Environment.NewLine

            details += Environment.NewLine & PrintCenterText("- Credit Transaction -") & Environment.NewLine
        End If

        If Val(CC(txtDiscountOverall.Text)) > 0 Then
            details += PrintLeftRigthText(lblDiscount.Text, txtDiscountOverall.Text) & Environment.NewLine
        End If

        If Val(CC(txtTotalExpenses.Text)) > 0 Then
            details += PrintLeftRigthText(lblTotalExpense.Text, txtTotalExpenses.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalReturnItem.Text)) > 0 Then
            details += PrintLeftRigthText(lblReturnItem.Text, txtTotalReturnItem.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalCheck.Text)) > 0 Then
            details += PrintLeftRigthText(lblTotalCheck.Text, txtTotalCheck.Text) & Environment.NewLine
        End If
        If Val(CC(txtCreditCard.Text)) > 0 Then
            details += PrintLeftRigthText(lblcard.Text, txtCreditCard.Text) & Environment.NewLine
        End If
        If Val(CC(txtPaymentDeposit.Text)) > 0 Then
            details += PrintLeftRigthText(lblpaymentdeposit.Text, txtPaymentDeposit.Text) & Environment.NewLine
        End If
        If Val(CC(txtAccountingTicket.Text)) > 0 Then
            details += PrintLeftRigthText(lblAccountingTicket.Text, txtAccountingTicket.Text) & Environment.NewLine
        End If
        If Val(CC(txtDebitAccountJournal.Text)) > 0 Then
            details += PrintLeftRigthText(lblDebitAccountJournal.Text, txtDebitAccountJournal.Text) & Environment.NewLine
        End If
        If Val(CC(txtClientJournalEntries.Text)) > 0 Then
            details += PrintLeftRigthText(lblClientJournalEntries.Text, txtClientJournalEntries.Text) & Environment.NewLine
        End If
        If Val(CC(txtGLCredit.Text)) > 0 Then
            details += PrintLeftRigthText("Journal Entries", txtGLCredit.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalChargeAcct.Text)) > 0 Then
            details += PrintLeftRigthText(lblKeyAccountsCharge.Text, txtTotalChargeAcct.Text) & Environment.NewLine
        End If
        If Val(CC(txtChargeToHotel.Text)) > 0 Then
            details += PrintLeftRigthText(lblChargeToHotel.Text, txtChargeToHotel.Text) & Environment.NewLine
        End If
        If Val(CC(txtInterOffice.Text)) > 0 Then
            details += PrintLeftRigthText(lblInterOffice.Text, txtInterOffice.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalCoupon.Text)) > 0 Then
            details += PrintLeftRigthText(lblCoupon.Text, txtTotalCoupon.Text) & Environment.NewLine
        End If

        If GLobalEnableViewSalesCashendreport = True Then
            If Val(CC(txtTotalCashSales.Text)) > 0 Then
                details += PrintLeftRigthText(lblCashEnd.Text, txtTotalCashSales.Text) & Environment.NewLine
            End If
            details += Environment.NewLine & PrintLeftRigthText("TOTAL CREDIT", txtTotalTrnCredit.Text) & Environment.NewLine
            details += PrintLeftRigthText("", "------------") & Environment.NewLine & Environment.NewLine
        End If

        If Val(CC(txtHotelSales.Text)) > 0 Then
            details += PrintLeftRigthText(lblHotelSales.Text, txtHotelSales.Text) & Environment.NewLine
        End If
        If Val(CC(txtHotelPayments.Text)) > 0 Then
            details += PrintLeftRigthText(lblHotelPayments.Text, txtHotelPayments.Text) & Environment.NewLine
        End If

        If GLobalEnableViewSalesCashendreport = True Then
            details += Environment.NewLine & PrintLeftRigthText(lblCashEnd.Text, txtTotalCashSales.Text) & Environment.NewLine
            details += PrintLeftRigthText(lblActualCashOnHand.Text, FormatNumber(txtActualCashOnHand.Text, 2)) & Environment.NewLine
            details += PrintLeftRigthText(lblCashVariance.Text, txtCashVariance.Text) & Environment.NewLine
        Else
            details += Environment.NewLine & PrintLeftRigthText(lblActualCashOnHand.Text, FormatNumber(txtActualCashOnHand.Text, 2)) & Environment.NewLine
        End If

        details += PrintLeftRigthText(lblTotalBills.Text, FormatNumber(txtTotalBill.Text, 2)) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalCoins.Text, txtTotalCoins.Text) & Environment.NewLine

        details += Environment.NewLine & PrintLeftRigthText(lblNextCashBeggining.Text, FormatNumber(Val(CC(txtNextcashBeginning.Text)), 2)) & Environment.NewLine
        details += PrintLeftRigthText(lblCashRemitted.Text, txtCashRemitted.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        com.CommandText = "update tblsalessummary set blotter='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where trncode='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()
        If globalPosCustomFont = True Then
            globalPosCustomFont = False
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
            globalPosCustomFont = True
        Else
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
        End If
    End Sub

    Public Sub PrintSalesBlotterOldVersion()
        Dim details As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("SALES BLOTTER") & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("From: " & txtDateFrom.Text) & Environment.NewLine
        details += PrintLeftText("To: " & txtDateTo.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintLeftRigthText(lblSoldItem.Text, txtTotalSoldItem.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblCancelledItem.Text, txtCancelledItem.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblVoidItem.Text, txtTotalVoidItem.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalCancelled.Text, txtTotalCancelledTransaction.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalVoid.Text, txtTotalVoidTransaction.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalDiscount.Text, txtTotalDiscount.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalCharges.Text, txtTotalCharges.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalTax.Text, txtTotalTax.Text) & Environment.NewLine & Environment.NewLine

        If GLobalEnableViewSalesCashendreport = True Then
            details += PrintCenterText("- Debit Transaction -") & Environment.NewLine
        End If
        details += PrintLeftRigthText(UCase(lblTotalSales.Text), txtTotalSales.Text) & Environment.NewLine
        details += PrintLeftRigthText(lblBeginningCash.Text, txtBeginningCash.Text) & Environment.NewLine
        If Val(CC(txtTotalChitTransaction.Text)) > 0 Then
            details += PrintLeftRigthText(lblTotalChit.Text, txtTotalChitTransaction.Text) & Environment.NewLine
        End If
        If Val(CC(txtKeyAccountPayment.Text)) > 0 Then
            details += PrintLeftRigthText(lblKeyaccountPayment.Text, txtKeyAccountPayment.Text) & Environment.NewLine
        End If
        If Val(CC(txtCreditAccountJournal.Text)) > 0 Then
            details += PrintLeftRigthText(lblCreditAccountJournal.Text, txtCreditAccountJournal.Text) & Environment.NewLine
        End If
        If Val(CC(txtGLDebit.Text)) > 0 Then
            details += PrintLeftRigthText("Journal Entries", txtGLDebit.Text) & Environment.NewLine
        End If
        If Val(CC(txtOtherTransation.Text)) > 0 Then
            details += PrintLeftRigthText(lblOtherTransaction.Text, txtOtherTransation.Text) & Environment.NewLine
        End If
        If GLobalEnableViewSalesCashendreport = True Then
            details += Environment.NewLine & PrintLeftRigthText("TOTAL DEBIT", txtTotalTrnDebit.Text) & Environment.NewLine
            details += PrintLeftRigthText("", "------------") & Environment.NewLine

            details += Environment.NewLine & PrintCenterText("- Credit Transaction -") & Environment.NewLine
        End If

        If Val(CC(txtDiscountOverall.Text)) > 0 Then
            details += PrintLeftRigthText(lblDiscount.Text, txtDiscountOverall.Text) & Environment.NewLine
        End If

        If Val(CC(txtTotalExpenses.Text)) > 0 Then
            details += PrintLeftRigthText(lblTotalExpense.Text, txtTotalExpenses.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalReturnItem.Text)) > 0 Then
            details += PrintLeftRigthText(lblReturnItem.Text, txtTotalReturnItem.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalCheck.Text)) > 0 Then
            details += PrintLeftRigthText(lblTotalCheck.Text, txtTotalCheck.Text) & Environment.NewLine
        End If
        If Val(CC(txtCreditCard.Text)) > 0 Then
            details += PrintLeftRigthText(lblcard.Text, txtCreditCard.Text) & Environment.NewLine
        End If
        If Val(CC(txtPaymentDeposit.Text)) > 0 Then
            details += PrintLeftRigthText(lblpaymentdeposit.Text, txtPaymentDeposit.Text) & Environment.NewLine
        End If
        If Val(CC(txtAccountingTicket.Text)) > 0 Then
            details += PrintLeftRigthText(lblAccountingTicket.Text, txtAccountingTicket.Text) & Environment.NewLine
        End If
        If Val(CC(txtDebitAccountJournal.Text)) > 0 Then
            details += PrintLeftRigthText(lblDebitAccountJournal.Text, txtDebitAccountJournal.Text) & Environment.NewLine
        End If
        If Val(CC(txtClientJournalEntries.Text)) > 0 Then
            details += PrintLeftRigthText(lblClientJournalEntries.Text, txtClientJournalEntries.Text) & Environment.NewLine
        End If
        If Val(CC(txtGLCredit.Text)) > 0 Then
            details += PrintLeftRigthText("Journal Entries", txtGLCredit.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalChargeAcct.Text)) > 0 Then
            details += PrintLeftRigthText(lblKeyAccountsCharge.Text, txtTotalChargeAcct.Text) & Environment.NewLine
        End If
        If Val(CC(txtChargeToHotel.Text)) > 0 Then
            details += PrintLeftRigthText(lblChargeToHotel.Text, txtChargeToHotel.Text) & Environment.NewLine
        End If
        If Val(CC(txtInterOffice.Text)) > 0 Then
            details += PrintLeftRigthText(lblInterOffice.Text, txtInterOffice.Text) & Environment.NewLine
        End If
        If Val(CC(txtTotalCoupon.Text)) > 0 Then
            details += PrintLeftRigthText(lblCoupon.Text, txtTotalCoupon.Text) & Environment.NewLine
        End If

        If GLobalEnableViewSalesCashendreport = True Then
            If Val(CC(txtTotalCashSales.Text)) > 0 Then
                details += PrintLeftRigthText(lblCashEnd.Text, txtTotalCashSales.Text) & Environment.NewLine
            End If
            details += Environment.NewLine & PrintLeftRigthText("TOTAL CREDIT", txtTotalTrnCredit.Text) & Environment.NewLine
            details += PrintLeftRigthText("", "------------") & Environment.NewLine & Environment.NewLine
        End If

        If Val(CC(txtHotelSales.Text)) > 0 Then
            details += PrintLeftRigthText(lblHotelSales.Text, txtHotelSales.Text) & Environment.NewLine
        End If
        If Val(CC(txtHotelPayments.Text)) > 0 Then
            details += PrintLeftRigthText(lblHotelPayments.Text, txtHotelPayments.Text) & Environment.NewLine
        End If

        If GLobalEnableViewSalesCashendreport = True Then
            details += Environment.NewLine & PrintLeftRigthText(lblCashEnd.Text, txtTotalCashSales.Text) & Environment.NewLine
            details += PrintLeftRigthText(lblActualCashOnHand.Text, FormatNumber(txtActualCashOnHand.Text, 2)) & Environment.NewLine
            details += PrintLeftRigthText(lblCashVariance.Text, txtCashVariance.Text) & Environment.NewLine
        Else
            details += Environment.NewLine & PrintLeftRigthText(lblActualCashOnHand.Text, FormatNumber(txtActualCashOnHand.Text, 2)) & Environment.NewLine
        End If

        details += PrintLeftRigthText(lblTotalBills.Text, FormatNumber(txtTotalBill.Text, 2)) & Environment.NewLine
        details += PrintLeftRigthText(lblTotalCoins.Text, txtTotalCoins.Text) & Environment.NewLine

        details += Environment.NewLine & PrintLeftRigthText(lblNextCashBeggining.Text, FormatNumber(Val(CC(txtNextcashBeginning.Text)), 2)) & Environment.NewLine
        details += PrintLeftRigthText(lblCashRemitted.Text, txtCashRemitted.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        com.CommandText = "update tblsalessummary set blotter='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where trncode='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()
        If globalPosCustomFont = True Then
            globalPosCustomFont = False
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
            globalPosCustomFont = True
        Else
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
        End If
    End Sub
    Public Sub PrintSalesSummary()
        Dim details As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("PRODUCTS SUMMARY") & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("From: " & txtDateFrom.Text) & Environment.NewLine
        details += PrintLeftText("To: " & txtDateTo.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintLeftRigthText(" QTY " & "  " & "PARTICULAR", "TOTAL") & Environment.NewLine & Environment.NewLine
        com.CommandText = "select (select itemname from tblglobalproducts where productid = tblsalestransaction.productid limit 1) as 'Particular', sum(total) as 'ttl',sum(quantity) as 'ttlq'  from tblsalestransaction where total > 0 and onhold=0 and cancelled=0 and void=0 and trnsumcode='" & globalSalesTrnCOde & "' group by (select itemname from tblglobalproducts where productid = tblsalestransaction.productid limit 1) order by (select itemname from tblglobalproducts where productid = tblsalestransaction.productid limit 1) asc" : rst = com.ExecuteReader
        Dim totalamount As Double = 0
        While rst.Read
            Dim ttlquan As String = rst("ttlq").ToString
            If ttlquan.Length = 1 Then
                ttlquan = "   " & ttlquan
            ElseIf ttlquan.Length = 2 Then
                ttlquan = "  " & ttlquan
            ElseIf ttlquan.Length = 3 Then
                ttlquan = " " & ttlquan
            Else
                ttlquan = ttlquan
            End If
            details += PrintLeftRigthText(ttlquan & "   " & LCase(rst("Particular").ToString), FormatNumber(rst("ttl").ToString, 2)) & Environment.NewLine
            totalamount = totalamount + Val(rst("ttl").ToString)
        End While
        rst.Close()

        details += Environment.NewLine
        details += PrintLeftRigthText("Total", FormatNumber(totalamount, 2)) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        POSPrint(details, globalSalesTrnCOde & " - products", "BLOTTER")

    End Sub

    Public Sub PrintKeyAccountsTransaction()
        Dim details As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("KEY ACCOUNT SALES") & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("From: " & txtDateFrom.Text) & Environment.NewLine
        details += PrintLeftText("To: " & txtDateTo.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        Dim totalamount As Double = 0
        com.CommandText = "select sum(amount) as 'ttl', (select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'Client' from tblsalesclientcharges where trnsumcode='" & globalSalesTrnCOde & "'  and cancelled=0 group by accountno order by  (select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) asc" : rst = com.ExecuteReader()
        While rst.Read
            details += PrintLeftRigthText(rst("Client").ToString, FormatNumber(rst("ttl").ToString, 2)) & Environment.NewLine
            totalamount = totalamount + Val(rst("ttl").ToString)
        End While
        rst.Close()
        details += Environment.NewLine
        details += PrintLeftRigthText("Total", FormatNumber(totalamount, 2)) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        POSPrint(details, globalSalesTrnCOde & " - client accounts", "BLOTTER")
    End Sub

    Public Sub PrintInhouseGuestTransaction()
        Dim details As String = ""
        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("IN-HOUSE GUEST REPORT") & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("From: " & txtDateFrom.Text) & Environment.NewLine
        details += PrintLeftText("To: " & txtDateTo.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        Dim totalamount As Double = 0
        details += PrintLeftRigthText("Guest", "Current Balance") & Environment.NewLine
        com.CommandText = "select  ((select sum(debit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0) - (select sum(credit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0)) as 'currentbalance', (select fullname from tblhotelguest where guestid = tblhotelroomtransaction.guestid) as 'guest' from tblhotelroomtransaction where closed=0 and cancelled=0" : rst = com.ExecuteReader()
        While rst.Read
            details += PrintLeftRigthText(rst("guest").ToString, FormatNumber(rst("currentbalance").ToString, 2)) & Environment.NewLine
            totalamount = totalamount + Val(rst("currentbalance").ToString)
        End While
        rst.Close()
        details += Environment.NewLine
        details += PrintLeftRigthText("Total", FormatNumber(totalamount, 2)) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        POSPrint(details, globalSalesTrnCOde & " - hotel inhouse", "BLOTTER")
    End Sub

#End Region

#Region "CLOSING TRANSACTION"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPOScashDonimination.Show(Me)
    End Sub

    Private Sub cmdEnterCashDenomination_Click(sender As Object, e As EventArgs) Handles cmdEnterCashDenomination.Click
        frmPOScashDonimination.Show(Me)
    End Sub

    Private Sub cmdCloseCashierTransaction_Click(sender As Object, e As EventArgs) Handles cmdCloseCashierTransaction.Click
        CloseCashierTransaction()
    End Sub
    Public Function trapTransaction() As Boolean
        If Val(CC(txtActualCashOnHand.Text)) = 0 Then
            If MessageBox.Show("You are about to confirm with ZERO Actual Cash on Hand Amount! Click (YES) to Confirm?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                Return True
            Else
                txtActualCashOnHand.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Public Function trapNextBegginingCash() As Boolean
        If Val(CC(txtNextcashBeginning.Text)) = 0 Then
            If MessageBox.Show("You are about to confirm with ZERO next Beggining Cash?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                Return True
            Else
                txtNextcashBeginning.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    Public Sub CloseCashierTransaction()
        If trapTransaction() = True Then
            If trapNextBegginingCash() = True Then
                If MessageBox.Show("Are you sure you want to continue close account transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    If EnableModuleFuel = True Then
                        DeductFuelInventory()
                    End If
                    If MessageBox.Show("Do you want to print sales blotter? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        PrintSalesBlotter()
                    End If
                    com.CommandText = "update tblsalessummary set totalsolditem='" & Val(CC(txtTotalSoldItem.Text)) & "', " _
                                                + " totalexpenses='" & Val(CC(txtTotalExpenses.Text)) & "', " _
                                                + " totalclientjournal='" & Val(CC(txtClientJournalEntries.Text)) & "', " _
                                                + " debitaccountjournal='" & Val(CC(txtDebitAccountJournal.Text)) & "', " _
                                                + " creaditaccountjournal='" & Val(CC(txtCreditAccountJournal.Text)) & "', " _
                                                + " totalothertransaction='" & Val(CC(txtOtherTransation.Text)) & "', " _
                                                + " cancelleditem='" & Val(CC(txtCancelledItem.Text)) & "', " _
                                                + " voiditem='" & Val(CC(txtTotalVoidItem.Text)) & "', " _
                                                + " totalcancelled='" & Val(CC(txtTotalCancelledTransaction.Text)) & "', " _
                                                + " totalvoid='" & Val(CC(txtTotalVoidTransaction.Text)) & "', " _
                                                + " totaldiscount='" & Val(CC(txtTotalDiscount.Text)) & "', " _
                                                + " totalcharge='" & Val(CC(txtTotalCharges.Text)) & "', " _
                                                + " totaltax='" & Val(CC(txtTotalTax.Text)) & "', " _
                                                + " totalchit='" & Val(CC(txtTotalChitTransaction.Text)) & "', " _
                                                + " totalchargeacct='" & Val(CC(txtTotalChargeAcct.Text)) & "', " _
                                                + " totalpaymentacct='" & Val(CC(txtKeyAccountPayment.Text)) & "', " _
                                                + " totalcheck='" & Val(CC(txtTotalCheck.Text)) & "', " _
                                                + " totalcard='" & Val(CC(txtCreditCard.Text)) & "', " _
                                                + " totaldeposit='" & Val(CC(txtPaymentDeposit.Text)) & "', " _
                                                + " totalacctticket='" & Val(CC(txtAccountingTicket.Text)) & "', " _
                                                + " totalsales='" & Val(CC(txtTotalSales.Text)) & "', " _
                                                + " totalcashsales='" & Val(CC(txtTotalCashSales.Text)) & "', " _
                                                + " totalactualcash='" & Val(CC(txtActualCashOnHand.Text)) & "', " _
                                                + " cashvariance='" & Val(CC(txtCashVariance.Text)) & "', " _
                                                + " totalincome='" & Val(CC(txtTotalIncome.Text)) & "', " _
                                                + " totalcash='" & Val(CC(txtTotalBill.Text)) & "', " _
                                                + " totalcoins='" & Val(CC(txtTotalCoins.Text)) & "', " _
                                                + " nextbeginningcash='" & Val(CC(txtNextcashBeginning.Text)) & "', " _
                                                + " cashremitted='" & Val(CC(txtCashRemitted.Text)) & "', " _
                                                + " dateclose=current_timestamp, " _
                                                + " closedby='" & globaluserid & "', " _
                                                + " openfortrn=0 where trncode='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()

                    If globalBackDateTransaction = False Then
                        com.CommandText = "update tblaccounts set cashbeggining='" & Val(CC(txtNextcashBeginning.Text)) & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
                    End If
                    SendSalesReport()
                    TransactionDone = True
                    LoadAccountDetails(globaluserid)
                    MainForm.ValidateModule()
                    Me.Close()
                End If
            End If
        End If
    End Sub
#End Region

#Region "CREATE EMAIL NOTIFICATION"
    Public Function SendSalesReport()
        Dim SalesReports As String = ""
        Dim EmailList As String = ""
        com.CommandText = "select * from tblaccounts where notifysales=1" : rst = com.ExecuteReader
        While rst.Read
            EmailList = EmailList + rst("emailaddress").ToString + ","
        End While
        rst.Close()

        If EmailList.Length > 0 Then
            EmailList = EmailList.Remove(EmailList.Length - 1, 1)
        End If

        SalesReports = ""
        SalesReports = "Reference #: " & globalSalesTrnCOde _
                  + "<br/>Office: " & compOfficename _
                  + "<br/>Cashier: " & globalfullname _
                  + "<br/>From: " & txtDateFrom.Text _
                  + "<br/>To: " & txtDateTo.Text _
                  + "<br/><br/>Total Sold Item: " & txtTotalSoldItem.Text _
                  + "<br/>Total Cancelled Item: " & txtCancelledItem.Text _
                  + "<br/>Total Void Item: " & txtTotalVoidItem.Text _
                  + "<br/>Total Cancelled Transaction: " & txtTotalCancelledTransaction.Text _
                  + "<br/>Total Void Transaction: " & txtTotalVoidTransaction.Text _
                  + "<br/>Per Item Discount: " & txtTotalDiscount.Text _
                  + "<br/>Per Item Charges: " & txtTotalCharges.Text

        If Val(CC(txtTotalChitTransaction.Text)) > 0 Then
            SalesReports += "<br/>Total Chit Transaction: " & txtTotalChitTransaction.Text
        End If

        SalesReports += "<br/><br/>Total System Cash End: " & txtTotalCashSales.Text
        SalesReports += "<br/>Actual Cash on Hand: " & txtActualCashOnHand.Text
        If Val(CC(txtCashVariance.Text)) < 0 Then
            SalesReports += "<br/>Shortages: <font color='red'>" & txtCashVariance.Text & "</font>"
        ElseIf Val(CC(txtCashVariance.Text)) > 0 Then
            SalesReports += "<br/>Overages: <font color='blue'>" & txtCashVariance.Text & "</font>"
        Else
            SalesReports += "<br/>Variance: " & txtCashVariance.Text
        End If

        SalesReports += "<br/><br/>Next Day Cash Beginning: " & FormatNumber(txtNextcashBeginning.Text, 2)
        SalesReports += "<br/>Total Cash Remitted: " & txtCashRemitted.Text

        SalesReports += "<br/><br/>Total Sales: " & txtTotalSales.Text
        SalesReports += "<br/>Total Stock Income: " & txtTotalIncome.Text
        SalesReports += "<br/>Total Old Stock Income: " & txtOldStockncome.Text
        SalesReports += "<br/>Total Services Income: " & txtTotalIncomeServices.Text

        SalesReports += "<br/><br/>"
        'Sales Balance Sheet
        Dim balanceSheet As String = ""
        SalesReports += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                      + " <tr> " _
                                           + " <th style='padding: 0 5px' colspan='3'>Sales Balance Sheet</th> " _
                                      + " </tr>" _
                                      + " <tr> " _
                                           + " <th style='padding: 0 5px'>Details</th> " _
                                           + " <th style='padding: 0 5px'>Debit</th> " _
                                           + " <th style='padding: 0 5px'>Credit</th> " _
                                      + " </tr>"

        For i = 0 To myDataGridView_balanceSheetEmail.RowCount - 1
            If myDataGridView_balanceSheetEmail.Item("Description", i).Value() = "" Then
                balanceSheet += "<tr> " _
                                    + " <td style='padding: 0 5px'>&nbsp;</td> " _
                                    + " <td style='padding: 0 5px' align='right'>&nbsp;</td> " _
                                    + " <td style='padding: 0 5px' align='right'>&nbsp;</td> " _
                         + " </tr> "
            Else
                balanceSheet += "<tr> " _
                                    + " <td style='padding: 0 5px'>" & myDataGridView_balanceSheetEmail.Item("Description", i).Value().ToString.Replace(vbCrLf, " ") & "</td> " _
                                    + " <td style='padding: 0 5px' align='right'>" & If(Val(myDataGridView_balanceSheetEmail.Item("Debit", i).Value()) = 0, "", FormatNumber(myDataGridView_balanceSheetEmail.Item("Debit", i).Value(), 2)) & "</td> " _
                                    + " <td style='padding: 0 5px' align='right'>" & If(Val(myDataGridView_balanceSheetEmail.Item("Credit", i).Value()) = 0, "", FormatNumber(myDataGridView_balanceSheetEmail.Item("Credit", i).Value(), 2)) & "</td> " _
                         + " </tr> "
            End If

        Next
        SalesReports += balanceSheet + "</table><br/><br/>"
        '--------------------------------------------------------------------------

        'generate list of invoices
        If countqry("tblsalesclientcharges", "cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 Then
            SalesReports += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                            + " <th style='padding: 0 5px' colspan='3'>Client account transaction</th> " _
                                       + " </tr>" _
                                       + " <tr> " _
                                            + " <th style='padding: 0 5px'>Company Name</th> " _
                                            + " <th style='padding: 0 5px'>Invoice No.</th> " _
                                            + " <th style='padding: 0 5px'>Amount</th> " _
                                       + " </tr>"
            Dim salesClientChargesRow As String = "" : Dim totalCharge As Double = 0
            com.CommandText = "select  *, (select companyname from tblclientaccounts where cifid = tblsalesclientcharges.accountno) as 'Client', amount  from tblsalesclientcharges where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
            While rst.Read
                salesClientChargesRow += "<tr> " _
                                        + " <td style='padding: 0 5px'>" & LCase(rst("Client").ToString).Replace("ñ", "&ntilde;") & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("invoiceno").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                             + " </tr> "
                totalCharge = totalCharge + Val(rst("amount").ToString)
            End While
            rst.Close()
            salesClientChargesRow += "<tr><td style='padding: 0 5px' colspan='2' align='right'>Total </td><td style='padding: 0 5px' align='right'>" & FormatNumber(totalCharge, 2) & "</td></tr> "
            salesClientChargesRow += "</table><br/><br/>"
            SalesReports += salesClientChargesRow
        End If

        ''generate hotel room charges
        'Dim roomChargeHeader As String = "" : Dim roomChargeBody As String = ""
        'If countqry("tblhoteltransaction", "chargefrompos=0 and cancelled=0  and paymenttrn=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 And globalAuthHotelManagement Then
        '    Dim TotalTransaction As Double = 0
        '    roomChargeHeader += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
        '                               + " <tr> " _
        '                                    + " <th style='padding: 0 5px' colspan='5'>Hotel Room Transaction</th> " _
        '                               + " </tr>" _
        '                               + " <tr> " _
        '                                    + " <th style='padding: 0 5px'>Folio No</th> " _
        '                                    + " <th style='padding: 0 5px'>Room No.</th> " _
        '                                    + " <th style='padding: 0 5px'>Guest Name</th> " _
        '                                    + " <th style='padding: 0 5px'>Remarks</th> " _
        '                                    + " <th style='padding: 0 5px'>Amount</th> " _
        '                               + " </tr>"

        '    com.CommandText = "select *, folioid, " _
        '                                    + " (select (select fullname from tblhotelguest where guestid = tblhotelroomtransaction.guestid) from tblhotelroomtransaction where folioid = tblhoteltransaction.folioid) as 'Guest', " _
        '                                    + " (select (select roomnumber from tblhotelrooms where roomid = tblhotelroomtransaction.roomid) from tblhotelroomtransaction where folioid = tblhoteltransaction.folioid) as 'RoomNumber', " _
        '                                    + " remarks as 'Description', debit as 'Amount' from tblhoteltransaction where debit>0 and chargefrompos=0 and cancelled=0  and paymenttrn=0 and trnsumcode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
        '    While rst.Read
        '        roomChargeBody += "<tr> " _
        '                                + " <td style='padding: 0 5px' align='center'>" & LCase(rst("folioid").ToString) & "</td> " _
        '                                + " <td style='padding: 0 5px' align='center'>" & LCase(rst("RoomNumber").ToString) & "</td> " _
        '                                + " <td style='padding: 0 5px'>" & LCase(rst("Guest").ToString).Replace("ñ", "&ntilde;") & "</td> " _
        '                                + " <td style='padding: 0 5px' align='center'>" & LCase(rst("Description").ToString) & "</td> " _
        '                                + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("Amount").ToString, 2) & "</td> " _
        '                     + " </tr> "
        '        TotalTransaction = TotalTransaction + Val(rst("Amount").ToString)
        '    End While
        '    rst.Close()
        '    roomChargeBody += "<tr><td style='padding: 0 5px' colspan='4' align='right'>Total </td><td style='padding: 0 5px' align='right'>" & FormatNumber(TotalTransaction, 2) & "</td></tr> "
        '    roomChargeBody += "</table><br/><br/>"
        '    SalesReports += roomChargeHeader + roomChargeBody
        'End If
        ''------------------------------------------------------------------------------

        'generate list of checkin guest
        Dim CheckInheader As String = "" : Dim checkinBody As String = ""
        If countqry("tblhotelroomtransaction", "closed=0 and cancelled=0") > 0 And globalAuthHotelManagement Then
            Dim totalcheckin As Double = 0
            CheckInheader += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                            + " <th style='padding: 0 5px' colspan='9'>IN-HOUSE GUEST REPORT</th> " _
                                       + " </tr>" _
                                       + " <tr> " _
                                            + " <th style='padding: 0 5px'>Folio No</th> " _
                                            + " <th style='padding: 0 5px'>Room No.</th> " _
                                            + " <th style='padding: 0 5px'>Guest Name</th> " _
                                            + " <th style='padding: 0 5px'>Date Check-in</th> " _
                                            + " <th style='padding: 0 5px'>Date Check-out</th> " _
                                            + " <th style='padding: 0 5px'>No. Days</th> " _
                                            + " <th style='padding: 0 5px'>Pax</th> " _
                                            + " <th style='padding: 0 5px'>Child</th> " _
                                            + " <th style='padding: 0 5px'>Open Balance</th> " _
                                       + " </tr>"

            com.CommandText = "select *, (select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid) as 'roomno',(noadults+noextra) as adult, " _
                           + " (select fullname from tblhotelguest where guestid=tblhotelroomtransaction.guestid) as 'GuestName', " _
                           + " date_format(datecheckin, '%Y-%m-%d') as 'Date Check-in', " _
                           + " date_format(datecheckout, '%Y-%m-%d') as 'Date Check-out', " _
                           + " (select count(*) from tblhoteltransaction where folioid=tblhotelroomtransaction.folioid and roomcharge=1 and cancelled=0)  as 'NoDays', " _
                           + " ((select sum(debit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0 and appliedcoupon=0) - (select sum(credit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0)) as 'OpenBalance'  " _
                           + " from tblhotelroomtransaction where closed=0 and inhouse=1 and cancelled=0 order by folioid asc" : rst = com.ExecuteReader
            While rst.Read
                checkinBody += "<tr> " _
                                        + " <td style='padding: 0 5px' align='center'>" & LCase(rst("foliono").ToString) & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & LCase(rst("roomno").ToString) & "</td> " _
                                        + " <td style='padding: 0 5px'>" & LCase(rst("GuestName").ToString).Replace("ñ", "&ntilde;") & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("Date Check-in").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("Date Check-out").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("NoDays").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("adult").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("nochild").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("OpenBalance").ToString, 2) & "</td> " _
                             + " </tr> "
                totalcheckin = totalcheckin + Val(rst("OpenBalance").ToString)
            End While
            rst.Close()
            checkinBody += "<tr><td style='padding: 0 5px' colspan='8' align='right'>Total </td><td style='padding: 0 5px' align='right'>" & FormatNumber(totalcheckin, 2) & "</td></tr> "
            checkinBody += "</table><br/><br/>"
            SalesReports += CheckInheader + checkinBody
        End If

        'generate list of checkin guest
        Dim ChangeRoomHeader As String = "" : Dim ChangeRoomBody As String = ""
        If countqry("tblhotelroomchangelog", "date_format(datechange,'%Y-%m-%d')=current_date") > 0 And globalAuthHotelManagement Then
            ChangeRoomHeader += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                            + " <th style='padding: 0 5px' colspan='7'>ROOM UPGRADE REPORT</th> " _
                                       + " </tr>" _
                                       + " <tr> " _
                                            + " <th style='padding: 0 5px'>Guest Name</th> " _
                                            + " <th style='padding: 0 5px'>From Room Type</th> " _
                                            + " <th style='padding: 0 5px'>To Room Type</th> " _
                                            + " <th style='padding: 0 5px'>Remarks</th> " _
                                            + " <th style='padding: 0 5px'>Change By</th> " _
                                            + " <th style='padding: 0 5px'>Overide By</th> " _
                                            + " <th style='padding: 0 5px'>Date Changed</th> " _
                                       + " </tr>"

            com.CommandText = "select *,date_format(datechange,'%Y-%m-%d') as dt, (select fullname from tblhotelguest where guestid=tblhotelroomchangelog.guestid) as 'GuestName',(select fullname from tblaccounts where accountid=tblhotelroomchangelog.changeby) as chgby,(select fullname from tblaccounts where accountid=tblhotelroomchangelog.overideby) as ovrdby from tblhotelroomchangelog where date_format(datechange,'%Y-%m-%d')=current_date" : rst = com.ExecuteReader
            While rst.Read
                ChangeRoomBody += "<tr> " _
                                        + " <td style='padding: 0 5px'>" & LCase(rst("GuestName").ToString).Replace("ñ", "&ntilde;") & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("fromroomtype").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("toroomtype").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("remarks").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("chgby").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("ovrdby").ToString & "</td> " _
                                        + " <td style='padding: 0 5px' align='center'>" & rst("dt").ToString & "</td> " _
                             + " </tr> "
            End While
            rst.Close()
            ChangeRoomBody += "</table><br/><br/>"
            SalesReports += ChangeRoomHeader + ChangeRoomBody
        End If

        '------------------------------------------------------------------------------
        ''generate list of reservation guest
        'Dim Reservationheader As String = "" : Dim ReservationBody As String = ""
        'If countqry("tblhotelroomreservation", "proceedcheckin=0 and cancelled=0 and expired=0") > 0 And globalAuthHotelManagement Then
        '    Reservationheader += "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
        '                               + " <tr> " _
        '                                    + " <th style='padding: 0 5px' colspan='6'>Guest Reservation Report</th> " _
        '                               + " </tr>" _
        '                               + " <tr> " _
        '                                    + " <th style='padding: 0 5px' align='center'>Room No.</th> " _
        '                                    + " <th style='padding: 0 5px'>Guest Name</th> " _
        '                                    + " <th style='padding: 0 5px'>Date Arival</th> " _
        '                                    + " <th style='padding: 0 5px'>Date Checkout</th> " _
        '                                    + " <th style='padding: 0 5px'>Payment Deposit</th> " _
        '                                    + " <th style='padding: 0 5px'>Status</th> " _
        '                               + " </tr>"

        '    com.CommandText = "select *, (select roomnumber from tblhotelrooms where roomid  = tblhotelroomreservation.roomid) as 'roomno', " _
        '                   + " (select fullname from tblhotelguest where guestid=tblhotelroomreservation.guestid) as 'GuestName', " _
        '                   + " date_format(datearaival, '%Y-%m-%d') as 'DateArival', " _
        '                   + " date_format(checkoutdate, '%Y-%m-%d') as 'checkoutdate', " _
        '                   + " paymentdeposit as 'PaymentDeposit',  " _
        '                   + " if(DATEDIFF(dateexpiry,current_date) > 0, if(DATEDIFF(dateexpiry,current_date)=1,'Expired Today',cast(concat(DATEDIFF(dateexpiry,current_date), ' Remaining Days Expiration') as char(200))),'Expired') as 'Status' " _
        '                   + " from tblhotelroomreservation where proceedcheckin=0 and cancelled=0 and expired=0 " : rst = com.ExecuteReader
        '    While rst.Read
        '        ReservationBody += "<tr> " _
        '                                + " <td style='padding: 0 5px' align='center'>" & LCase(rst("roomno").ToString) & "</td> " _
        '                                + " <td style='padding: 0 5px'>" & LCase(rst("GuestName").ToString).Replace("ñ", "&ntilde;") & "</td> " _
        '                                + " <td style='padding: 0 5px' align='center'>" & rst("DateArival").ToString & "</td> " _
        '                                + " <td style='padding: 0 5px' align='center'>" & rst("checkoutdate").ToString & "</td> " _
        '                                + " <td style='padding: 0 5px' align='right'>" & FormatNumber(rst("PaymentDeposit").ToString, 2) & "</td> " _
        '                                + " <td style='padding: 0 5px'>" & rst("Status").ToString & "</td> " _
        '                     + " </tr> "
        '    End While
        '    rst.Close()
        '    ReservationBody += "</table><br/><br/>"
        '    SalesReports += Reservationheader + ReservationBody
        'End If
        '------------------------------------------------------------------------------
        InsertEmailNotification("SALES", EmailList, If(globalBackDateTransaction = True, StrConv(globalBackDateRemarks, vbProperCase) & " " & ConvertDate(globalBackDate), If(GlobalShowsalesreportemailcaptionasoffice = True, StrConv(compOfficename, VbStrConv.ProperCase) & " Sales ", "Coffeecup Sales Report ") & ConvertDate(txtDateFrom.Text)), SalesReports, "")
        Return True
    End Function
#End Region

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        TransactionBalanceSheet(MyDataGridView_balancesheet)
        PrintDatagridview("SALES BLOTTER", "SALES BLOTTER", "Transaction No.: " & globalSalesTrnCOde & "<br/>Cashier: <b>" & globalfullname & "</b><br/>Sarting Date: " & txtDateFrom.Text & "<br/>Closing Date: " & txtDateTo.Text, MyDataGridView_balancesheet, Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditChapterToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GenerateLXCashiersRemittance(globalSalesTrnCOde, Me)
    End Sub
End Class