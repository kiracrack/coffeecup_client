Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelChargeAccount
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
 
    Private Sub frmHotelChargeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadClient()
        com.CommandText = "select * from tbltransactioncode order by itemname asc" : rst = com.ExecuteReader
        txtGLItem.Items.Clear()
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()

        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)
    End Sub
    Public Sub LoadClient()
        txtClient.Items.Clear()
        com.CommandText = "select * from tblclientaccounts where groupcode in (select groupcode from tblclientgroup where posvisible=1) order by companyname asc" : rst = com.ExecuteReader
        While rst.Read
            txtClient.Items.Add(New ComboBoxItem(rst("companyname").ToString, rst("cifid").ToString))
        End While
        rst.Close()
    End Sub

    Private Sub txtGLItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGLItem.SelectedIndexChanged
        If txtGLItem.Text <> "" Then
            itemcode.Text = DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            itemcode.Text = ""
        End If
    End Sub
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If countqry("tblclientaccounts", "cifid='" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "' and creditlimit=1") > 0 Then
            Dim remainingcredit As Double = Val(qrysingledata("creditlimitamount", "creditlimitamount", "tblclientaccounts where cifid='" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "'")) - (Val(qrysingledata("totaldue", "sum(debit)-sum(credit) as totaldue", "tblglaccountledger where accountno='" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "' and cancelled=0")) + Val(qrysingledata("amount", "amount", "tblsalesclientcharges where accountno='" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "' and verified=0 and cancelled=0")))
            If remainingcredit < Val(CC(txtAmountTender.Text)) Then
                MessageBox.Show(txtClient.Text & " has only " & FormatNumber(remainingcredit, 2) & " available from credit limit! Transaction cannot be continue", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Charge to client account " & StrConv(txtClient.Text, vbProperCase) & " (" & StrConv(txtGLItem.Text, VbStrConv.ProperCase) & ") with total amount of " & txtAmountTender.Text)
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            com.CommandText = "insert into tblsalesclientcharges set trnsumcode='" & globalSalesTrnCOde & "',  accountno='" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "',foliocharge=1, batchcode='folio#" & foliono.Text & "', glitemcode='" & itemcode.Text & "', invoiceno='" & foliono.Text & "', remarks='" & rchar(txtRemarks.Text) & "', amount='" & Val(CC(txtAmountTender.Text)) & "', datetrn=current_timestamp,trnby='" & globaluserid & "', verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblglaccountledger set " _
                        + " batchcode='', " _
                        + " journalmode='client-accounts', " _
                        + " accountno='" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "', " _
                        + " referenceno='" & foliono.Text & "', " _
                        + " itemcode='" & itemcode.Text & "', " _
                        + " remarks='" & rchar(txtRemarks.Text) & "', " _
                        + " debit='" & Val(CC(txtAmountTender.Text)) & "', " _
                        + " datetrn=current_timestamp, " _
                        + " cleared=1, " _
                        + " clearedby='" & globaluserid & "', " _
                        + " datecleared=current_timestamp, " _
                        + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            com.CommandText = "insert into tblhotelfoliotransaction set folioid='',foliono='" & foliono.Text & "', guestid='" & guestid.Text & "',roomid='',roomno='', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', referenceno='" & txtReferenceNo.Text & "', remarks='Charge to " & rchar(txtClient.Text) & "', credit='" & Val(CC(txtAmountTender.Text)) & "',paymenttrn=1,offsetpayment=1,datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            If frmHotelCheckInTransactionV2.Visible = True Then
                frmHotelCheckInTransactionV2.LoadFolioInfo()
            End If
            MessageBox.Show("Transaction successfully checked out", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class