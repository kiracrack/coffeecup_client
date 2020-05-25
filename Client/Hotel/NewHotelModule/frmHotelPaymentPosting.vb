Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelPaymentPosting
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelPaymentPosting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmHotelPaymentPosting_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' If countqry("tblhoteltransaction", "referenceno='" & txtORNumber.Text & "' and folioid='" & folioid.Text & "' and paymenttrn=1") = 0 Then
        Dim paymentMode As String = ""
        Dim check As String = ""
        If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtReferenceNo.Text & "'")) > 0 Then
            check = "CHECK PAYMENT"
        End If
        Dim card As String = ""
        If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtReferenceNo.Text & "'")) > 0 Then
            card = qrysingledata("carddetails", "carddetails", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtReferenceNo.Text & "'")
        End If
        Dim online As String = ""
        If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) > 0 Then
            online = qrysingledata("payment", "(select bankname from tblbankaccounts where bankcode=tblsalesdepositpaymenttransaction.bankaccount) as payment", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")
        End If
        Dim voucher As String = ""
        If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalespaymentvoucher where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) > 0 Then
            voucher = "VOUCHER"
        End If
        Dim ticket As String = ""
        If Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) > 0 Then
            ticket = "DUE"
        End If
        Dim cash As String = ""
        If Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) > 0 Or rbCash.Checked = True Then
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
        ' End If
    End Sub


    Private Sub frmHotelPaymentPosting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblhoteltransaction", "referenceno='" & txtReferenceNo.Text & "' and folioid='" & folioid.Text & "' and paymenttrn=1") = 0 Then
            Dim TemporaryPayment As Double = Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsaleschecktransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtReferenceNo.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalescardtransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and referenceno='" & txtReferenceNo.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesdepositpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalespaymentvoucher where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) +
                                                 Val(qrysingledata("amount", "amount", "tblsalescashpayment where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'")) +
                                                 Val(qrysingledata("ttl", "sum(amount) as ttl", "tblsalesticketpaymenttransaction where cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'"))
            If TemporaryPayment > 0 Then
                If MessageBox.Show("System found an payment transaction not validated with this OR Number! Are you sure you want to cancel all payment transaction?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    CancelPaymentTransaction(txtReferenceNo.Text)
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmHotelPaymentPosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "edit" Then
            ShowPaymentInfo()
        Else
            GetORNumber()
            If ckMainFolio.Checked = True Then
                If ckMultiple.Checked = True Then
                    lblSettlement.Text = "Multiple Folio Settlement"
                    txtAmountTender.ReadOnly = True
                Else
                    lblSettlement.Text = "Single Folio Settlement"
                    txtAmountTender.ReadOnly = False
                End If
            Else
                If ckMultiple.Checked = True Then
                    lblSettlement.Text = "Multiple Room Settlement"
                    txtAmountTender.ReadOnly = True
                Else
                    lblSettlement.Text = "Single Room Settlement"
                    txtAmountTender.ReadOnly = False
                End If
            End If
        End If
    End Sub

    Public Sub ShowPaymentInfo()
        'com.CommandText = "select * from "
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtReferenceNo.Text = "" Then
            MessageBox.Show("Please enter reference Number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReferenceNo.Focus()
            Exit Sub
        ElseIf countqry("tblhoteltransaction", "paymenttrn=1 and referenceno='" & txtReferenceNo.Text & "' and cancelled=0") > 0 And mode.Text <> "edit" Then
            MessageBox.Show("OR Number already exists!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReferenceNo.Focus()
            Exit Sub

        ElseIf Val(CC(txtAmountTender.Text)) = 0 Then
            MessageBox.Show("Please enter proper amount!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmountTender.Focus()
            Exit Sub

        ElseIf txtORNo.Text = "" Then
            MessageBox.Show("Please enter OR Number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtORNo.Focus()
            Exit Sub

        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), folioid.Text, "Post " & If(ckMainFolio.Checked = True, "main folio", "room") & " payment with " & StrConv(txtPaymentMode.Text, VbStrConv.ProperCase) & " amount " & txtAmountTender.Text & " OR Number " & txtORNo.Text)
            If rbCash.Checked = True Then
                If Val(CC(txtAmountTender.Text)) <> 0 Then
                    If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'") > 0 Then
                        com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange=0,datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtReferenceNo.Text & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & txtReferenceNo.Text & "',amount='" & Val(CC(txtAmountTender.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    End If
                End If
            End If
            If ckMainFolio.Checked = True Then
                If ckMultiple.Checked = True Then
                    Dim cmdQuery As String = "" : Dim FolioQuery As String = "" : Dim PrintGuestName As String = "" : Dim PrintGuestAddress As String = ""
                    For Each folio In folioid.Text.Split(New Char() {","c})
                        com.CommandText = "select *, ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-(ifnull((select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0)+ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0)),0) as BalanceDue " _
                                            + "  from tblhotelfolioguest where foliono='" & folio & "'" : rst = com.ExecuteReader
                        While rst.Read
                            cmdQuery += "insert into tblhotelfoliotransaction set folioid='', foliono='" & rst("foliono").ToString & "', hotelcifid='', guestid='" & rst("guestid").ToString & "',roomid='',roomno='', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', referenceno='" & txtReferenceNo.Text & "',ornumber='" & txtORNo.Text & "', remarks='" & txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)) & "', credit='" & Val(CC(rst("BalanceDue").ToString)) & "',paymenttrn=1," & If(ckDue.Checked = True, "offsetpayment=1,", "") & " datetrn=current_timestamp,trnby='" & globaluserid & "'|"
                            FolioQuery += "guestid='" & rst("guestid").ToString & "' or "
                        End While
                        rst.Close()
                    Next

                    For Each Exec In cmdQuery.Split(New Char() {"|"c})
                        If Exec <> "" Then
                            com.CommandText = Exec : com.ExecuteNonQuery()
                        End If
                    Next
                    If FolioQuery.Length > 0 Then
                        com.CommandText = "SELECT group_concat(fullname) as guest, address FROM `tblhotelguest` where (" & FolioQuery.Remove(FolioQuery.Length - 3, 3) & ")" : rst = com.ExecuteReader
                        While rst.Read
                            PrintGuestName = rst("guest").ToString
                            PrintGuestAddress = rst("address").ToString
                        End While
                        rst.Close()
                    End If
                    GenerateLXClientJournal(PrintGuestName, PrintGuestAddress, "ACKNOWLEGEMENT", txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)), txtAmountTender.Text, txtORNo.Text, Me)
                Else
                    Dim cmdQuery As String = "" : Dim PrintGuestName As String = "" : Dim PrintGuestAddress As String = ""
                    com.CommandText = "select *,(select fullname from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'Guest',(select address from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'address' from tblhotelfolioguest where foliono='" & folioid.Text & "'" : rst = com.ExecuteReader
                    While rst.Read
                        cmdQuery += "INSERT INTO tblhotelfoliotransaction set folioid='', foliono='" & rst("foliono").ToString & "', hotelcifid='', guestid='" & rst("guestid").ToString & "',roomid='',roomno='', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', referenceno='" & txtReferenceNo.Text & "',ornumber='" & txtORNo.Text & "', remarks='" & txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)) & "', credit='" & Val(CC(txtAmountTender.Text)) & "',paymenttrn=1," & If(ckDue.Checked = True, "offsetpayment=1,", "") & " datetrn=current_timestamp,trnby='" & globaluserid & "'"
                        PrintGuestName = rst("Guest").ToString
                        PrintGuestAddress = rst("address").ToString
                    End While
                    rst.Close()

                    com.CommandText = cmdQuery : com.ExecuteNonQuery()
                    GenerateLXClientJournal(PrintGuestName, PrintGuestAddress, "ACKNOWLEGEMENT", txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)), txtAmountTender.Text, txtORNo.Text, Me)
                End If
            Else
                If ckMultiple.Checked = True Then
                    Dim cmdQuery As String = "" : Dim FolioQuery As String = "" : Dim PrintGuestName As String = "" : Dim PrintGuestAddress As String = ""
                    For Each folio In folioid.Text.Split(New Char() {","c})
                        com.CommandText = "select *, (ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0) + " _
                                            + " ifnull((select sum(debit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and chargefrompos=1 and cancelled=0 and appliedcoupon=0),0)) " _
                                            + " - ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and paymenttrn=1 and cancelled=0),0) as 'BalanceDue' " _
                                            + "  from tblhotelfolioroom where folioid='" & folio & "'" : rst = com.ExecuteReader
                        While rst.Read
                            cmdQuery += "insert into tblhotelfoliotransaction set folioid='" & folio & "', foliono='" & rst("foliono").ToString & "', hotelcifid='" & rst("hotelcif").ToString & "',  guestid='" & rst("guestid").ToString & "',roomid='" & rst("roomid").ToString & "',roomno='" & rst("roomno").ToString & "', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', referenceno='" & txtReferenceNo.Text & "', ornumber='" & txtORNo.Text & "',remarks='" & txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)) & "', credit='" & Val(CC(rst("BalanceDue").ToString)) & "',paymenttrn=1," & If(ckDue.Checked = True, "offsetpayment=1,", "") & "datetrn=current_timestamp,trnby='" & globaluserid & "'|"
                            FolioQuery += "guestid='" & rst("guestid").ToString & "' or "
                        End While
                        rst.Close()
                    Next

                    For Each Exec In cmdQuery.Split(New Char() {"|"c})
                        If Exec <> "" Then
                            com.CommandText = Exec : com.ExecuteNonQuery()
                        End If
                    Next
                    If FolioQuery.Length > 0 Then
                        com.CommandText = "SELECT group_concat(fullname) as guest, address FROM `tblhotelguest` where (" & FolioQuery.Remove(FolioQuery.Length - 3, 3) & ")" : rst = com.ExecuteReader
                        While rst.Read
                            PrintGuestName = rst("guest").ToString
                            PrintGuestAddress = rst("address").ToString
                        End While
                        rst.Close()
                    End If
                    GenerateLXClientJournal(PrintGuestName, PrintGuestAddress, "ACKNOWLEGEMENT", txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)), txtAmountTender.Text, txtReferenceNo.Text, Me)
                Else
                    Dim cmdQuery As String = "" : Dim PrintGuestName As String = "" : Dim PrintGuestAddress As String = ""
                    com.CommandText = "select *,(select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as 'Guest',(select address from tblhotelguest where guestid=tblhotelfolioroom.guestid) as 'address' from tblhotelfolioroom where folioid='" & folioid.Text & "'" : rst = com.ExecuteReader
                    While rst.Read
                        cmdQuery += " tblhotelfoliotransaction set folioid='" & folioid.Text & "', foliono='" & rst("foliono").ToString & "', hotelcifid='" & rst("hotelcif").ToString & "', guestid='" & rst("guestid").ToString & "',roomid='" & rst("roomid").ToString & "',roomno='" & rst("roomno").ToString & "', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', referenceno='" & txtReferenceNo.Text & "', remarks='" & txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)) & "', credit='" & Val(CC(txtAmountTender.Text)) & "',paymenttrn=1," & If(ckDue.Checked = True, "offsetpayment=1,", "") & "datetrn=current_timestamp,trnby='" & globaluserid & "'"
                        PrintGuestName = rst("Guest").ToString
                        PrintGuestAddress = rst("address").ToString
                    End While
                    rst.Close()

                    If mode.Text = "edit" Then
                        com.CommandText = "UPDATE " & cmdQuery & " where folioid='" & folioid.Text & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "INSERT INTO " & cmdQuery : com.ExecuteNonQuery()
                    End If
                    GenerateLXClientJournal(PrintGuestName, PrintGuestAddress, "ACKNOWLEGEMENT", txtPaymentMode.Text & If(txtRemarks.Text = "", "", " - " & rchar(txtRemarks.Text)), txtAmountTender.Text, txtReferenceNo.Text, Me)
                End If
            End If
            If frmHotelCheckInTransactionV2.Visible = True Then
                frmHotelCheckInTransactionV2.LoadFolioInfo()
            End If
            If ckDue.Checked = True Then
                com.CommandText = "insert into tblglaccountledger set journalmode='bank-accounts',accountno='', " _
                                        + " referenceno='" & folioid.Text & "', " _
                                        + " itemcode='', " _
                                        + " remarks='Payment Refund " & rchar(txtRemarks.Text) & "', " _
                                        + " debit='" & -Val(CC(txtAmountTender.Text)) & "', " _
                                        + " credit=0,datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            rbCash.Checked = True : txtAmountTender.Text = "0" : txtRemarks.Text = "" : GetORNumber()
            Me.Hide()
            MessageBox.Show("Payment successfully posted!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Public Sub GetORNumber()
        If GLobalhotelreceiptsequence = True Then
            txtReferenceNo.ReadOnly = True
            txtReferenceNo.Text = getPOSHotelReceiptSequence()
            com.CommandText = "UPDATE tblgeneralsettings set hotelreceiptsequence='" & txtReferenceNo.Text & "'" : com.ExecuteNonQuery()
            txtAmountTender.Focus()
        Else
            txtReferenceNo.ReadOnly = False
        End If
    End Sub

    Private Sub txtORNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferenceNo.KeyPress
        InputNumberOnly(txtReferenceNo, e)
    End Sub

    Private Sub rbCash_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged, rbMultiPayment.CheckedChanged
        SelectPaymentType()
    End Sub
    Public Sub SelectPaymentType()
        If rbCash.Checked = True Then
            cmdInputPaymentDetails.Enabled = False

        ElseIf rbMultiPayment.Checked = True Then
            cmdInputPaymentDetails.Text = "Please input other payment details"
            cmdInputPaymentDetails.Enabled = True
        End If
    End Sub

    Private Sub cmdInputPaymentDetails_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdInputPaymentDetails.LinkClicked
        If Val(CC(txtAmountTender.Text)) < 0 Then
            txtAmountTender.Text = "0.00"
        End If
        frmPOSMultiPayments.batchcode.Text = txtReferenceNo.Text
        frmPOSMultiPayments.lblTransaction.Text = GlobalWalkinAccountName
        frmPOSMultiPayments.txtTotalOnScreen.Text = txtAmountTender.Text
        frmPOSMultiPayments.cifid.Text = GlobalWalkinAccountCIFCode
        frmPOSMultiPayments.mode.Text = "hotelpayment"
        frmPOSMultiPayments.ShowDialog(Me)
    End Sub

    Private Sub txtAmountTender_TextChanged(sender As Object, e As EventArgs) Handles txtAmountTender.TextChanged
        If (Val(CC(txtAmountTender.Text))) < 0 Then
            rbMultiPayment.Enabled = False
            ckDue.Visible = True
        Else
            rbMultiPayment.Enabled = True
            ckDue.Visible = False
        End If

    End Sub
End Class