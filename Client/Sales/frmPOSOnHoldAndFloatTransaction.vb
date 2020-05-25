Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSOnHoldAndFloatTransaction
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F5) Then
            If mode.Text = "floattrn" Then
                ShowFloatTransactions()

            ElseIf mode.Text = "onhold" Then
                ShowOnholdTransactions()

            ElseIf mode.Text = "orderslip" Then
                ShowOrderSlipTransactions()

            End If
        ElseIf keyData = (Keys.Enter) Then
            If mode.Text = "onhold" Then
                If MessageBox.Show("Are you sure you want to restore selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    com.CommandText = "update tblsalesbatch set userid='" & globalTransactionUserid & "', trnsumcode='" & globalSalesTrnCOde & "' , onhold=0 where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblsalestransaction set trnsumcode='" & globalSalesTrnCOde & "',onhold=0 where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                    frmPointOfSale.cifid.Text = qrysingledata("val", "cifid as 'val'", "tblsalesbatch where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
                    frmPointOfSale.txtClient.Text = qrysingledata("val", "(select companyname from tblclientaccounts where cifid=tblsalesbatch.cifid) as 'val'", "tblsalesbatch where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
                    frmPointOfSale.txtBatchcode.Text = MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString
                    frmPointOfSale.ValidatePOSTransaction(MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString)
                    frmPointOfSale.txtBarCode.Focus()
                    Me.Close()
                End If

            ElseIf mode.Text = "orderslip" Then
                If MessageBox.Show("Are you sure you want to process selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    If countqry("tblsalesbatch", "forcashiertrn=1 and batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'") > 0 Then
                        com.CommandText = "update tblsalesbatch set forcashiertrn=0 where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                        frmPointOfSale.cifid.Text = qrysingledata("val", "cifid as 'val'", "tblsalesbatch where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
                        frmPointOfSale.txtClient.Text = qrysingledata("val", "(select companyname from tblclientaccounts where cifid=tblsalesbatch.cifid) as 'val'", "tblsalesbatch where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
                        frmPointOfSale.txtBatchcode.Text = MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString
                        frmPointOfSale.ValidatePOSTransaction(MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString)
                        Me.Close()
                    Else
                        MsgBox("Order slip was locked with another user!", MsgBoxStyle.Critical)
                    End If
                End If
            Else
                If MessageBox.Show("Are you sure you want to restore selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    frmPointOfSale.cifid.Text = qrysingledata("val", "cifid as 'val'", "tblsalesbatch where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
                    frmPointOfSale.txtClient.Text = qrysingledata("val", "(select companyname from tblclientaccounts where cifid=tblsalesbatch.cifid) as 'val'", "tblsalesbatch where batchcode='" & MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
                    frmPointOfSale.txtBatchcode.Text = MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString
                    frmPointOfSale.ValidatePOSTransaction(MyDataGridView.Item("Batch Code", MyDataGridView.CurrentRow.Index).Value().ToString)
                    Me.Close()
                End If
            End If
     
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "floattrn" Then
            ShowFloatTransactions()
            Me.Text = "Recovered Transactions (Press ENTER key to restore selected transaction)"
        ElseIf mode.Text = "onhold" Then
            ShowOnholdTransactions()
            Me.Text = "On Hold Transactions (Press ENTER key to restore selected transaction)"
          
        ElseIf mode.Text = "orderslip" Then
            ShowOrderSlipTransactions()
            If globalAuthPointofSaleAssistant = True Then
                Me.Text = "Order Slip Transactions for cashier transaction"
            Else
                Me.Text = "Order Slip Transactions (Press ENTER key to process selected transaction)"
            End If

           
        End If

        If globalAuthPointofSaleAssistant = True Then
            cmdVoid.Visible = False
        Else
            cmdVoid.Visible = True
        End If
    End Sub
   
    Public Sub ShowOrderSlipTransactions()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  batchcode as 'Batch Code'," & If(Globalenablechittransaction = True, "chittrn as 'SOP Transaction',", "") & "  (select fullname from tblaccounts where accountid=tblsalesbatch.trnby) as 'Sales Person',  totalitem as 'Total Item', total as 'Total Amount', advancepayment as 'Payment Amount',  " _
                                                    + "date_format(datetrn,'%Y-%m-%d %r') as 'Date Entered', (select fullname from tblaccounts where accountid=tblsalesbatch.userid) as 'Processed By' from tblsalesbatch where forcashiertrn=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "' order by datetrn desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Batch Code", "Total Item", If(Globalenablechittransaction = True, "SOP Transaction", Nothing)}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)

        GridCurrencyColumn(MyDataGridView, {"Sub Total", "Total Amount", "Payment Amount"})
    End Sub

    Public Sub ShowOnholdTransactions()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  batchcode as 'Batch Code'," & If(Globalenablechittransaction = True, "chittrn as 'SOP Transaction',", "") & " onholdname as 'Customer Name',  totalitem as 'Total Item', total as 'Total Amount', advancepayment as 'Payment Deposit', total-advancepayment as 'Balance',  " _
                                                    + "date_format(datetrn,'%Y-%m-%d %r') as 'Date Hold', (select fullname from tblaccounts where accountid=tblsalesbatch.userid) as 'Transaction By' from tblsalesbatch where onhold=1 and void=0 and officeid='" & compOfficeid & "' " & If(Globalallowaccessallonhold = False, " and (userid='" & globaluserid & "'  or userid='" & globalAssistantUserId & "' or trnsumcode in (select trncode from tblsalessummary where userid='" & globaluserid & "' and openfortrn=1))", "") & " order by datetrn desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Batch Code", "Total Item", If(Globalenablechittransaction = True, "SOP Transaction", Nothing)}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)

        GridCurrencyColumn(MyDataGridView, {"Sub Total", "Total Amount", "Payment Deposit", "Balance"})
    End Sub

    Public Sub ShowFloatTransactions()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  batchcode as 'Batch Code'," & If(Globalenablechittransaction = True, "chittrn as 'SOP Transaction',", "") & " (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid) as 'Client', " _
                                                    + " totalitem as 'Total Item',  subtotal as 'Sub Total',total as 'Total Amount', date_format(datetrn,'%Y-%m-%d %r') as 'Date Transaction' from tblsalesbatch where void=0 and floattrn=1 and onhold=0 and forcashiertrn=0 and trnsumcode='" & globalSalesTrnCOde & "' order by datetrn desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Batch Code", "Total Item", If(Globalenablechittransaction = True, "SOP Transaction", Nothing)}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView, {"Sub Total", "Total Amount"})
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdVoid.Click
        If MessageBox.Show("Are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                    VoidBatchSalesTransaction(rw.Cells("Batch Code").Value.ToString, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                Next
                If mode.Text = "floattrn" Then
                    ShowFloatTransactions()
                    MsgBox("Recovered transaction successfully void!", MsgBoxStyle.Information)
                ElseIf mode.Text = "onhold" Then
                    ShowOnholdTransactions()
                    MsgBox("On hold transaction successfully void!", MsgBoxStyle.Information)
                ElseIf mode.Text = "orderslip" Then
                    ShowOrderSlipTransactions()
                    MsgBox("Order Slip transaction successfully void!", MsgBoxStyle.Information)

                End If
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
    End Sub
End Class