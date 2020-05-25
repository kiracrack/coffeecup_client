Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSOnholdConfirmation
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
     
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtContactPerson.Text = "" Then
            MsgBox("Please contact person!", MsgBoxStyle.Exclamation, "Error Message")
            txtContactPerson.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblsalesbatch set onholdname='" & rchar(txtContactPerson.Text) & "', onhold=1, advancepayment='" & Val(CC(GridView1.Columns("Deposit").SummaryText)) & "', datetrn=current_timestamp, processed=1, dateprocess=current_timestamp where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalestransaction set onhold=1  where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
            ' PrintPOSOrderSlipCashierAssistant(batchcode.Text, globalfullname, txtContactPerson.Text, globalAssistantFullName, frmPointOfSale.txtTotalOnScreen.Text, frmPointOfSale.MyDataGridView)
            frmPointOfSale.BeginNewTransaction()
            'Me.Hide()
            If MessageBox.Show("Do you want to print customer bill? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                PrintPOSOderSlip(batchcode.Text, txtContactPerson.Text, "")
            End If
            MsgBox(batchcode.Text & " successfully put on hold!", MsgBoxStyle.Information)
            Me.Close()
         
        End If
    End Sub

    Private Sub txtAdvancePayment_GotFocus(sender As Object, e As EventArgs) Handles txtAdvancePayment.GotFocus
        If Val(CC(txtAdvancePayment.Text)) > 0 Then
            Me.AcceptButton = cmdAddPayment
        Else
            Me.AcceptButton = cmdConfirmPayment
        End If
    End Sub
    Private Sub txtAdvancePayment_LostFocus(sender As Object, e As EventArgs) Handles txtAdvancePayment.LostFocus
        Me.AcceptButton = cmdConfirmPayment
    End Sub

    Private Sub txtAdvancePayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdvancePayment.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirmPayment.PerformClick()
        Else
            InputNumberOnly(txtAdvancePayment, e)
        End If
    End Sub
  
    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        com.CommandText = "select * from tblsalesbatch where batchcode='" & batchcode.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtContactPerson.Text = rst("onholdname").ToString
        End While
        rst.Close()
        LoadDeposits()
    End Sub

    Public Sub LoadDeposits()
        LoadXgrid("select trnid,trnsumcode, 'CASH' as 'Mode of Payment', Deposit, datetrn as 'Date Added', (select fullname from tblaccounts where accountid=tblsalescashpayment.trnby) as 'Added By' from tblsalescashpayment where batchcode='" & batchcode.Text & "' and cancelled=0 ", "tblsalescashpayment", Em, GridView1)
        XgridHideColumn({"trnid", "trnsumcode"}, GridView1)
        XgridColCurrency({"Deposit"}, GridView1)
        XgridColAlign({"Mode of Payment"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Deposit"}, GridView1)
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles cmdAddPayment.Click
        If Val(CC(txtAdvancePayment.Text)) <= 0 Then
            MessageBox.Show("Please enter valid amount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAdvancePayment.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & batchcode.Text & "',deposit='" & Val(CC(txtAdvancePayment.Text)) & "', datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        txtAdvancePayment.Text = "0.00"
        cmdConfirmPayment.Focus()
        LoadDeposits()
    End Sub

    Private Sub cmdVoid_Click(sender As Object, e As EventArgs) Handles cmdVoid.Click
        If GridView1.RowCount = 0 Then Exit Sub
        If GridView1.GetFocusedRowCellValue("trnsumcode").ToString <> globalSalesTrnCOde Then
            MessageBox.Show("Cancelling payment from other cashier is not allowed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "DELETE from tblsalescashpayment where trnid='" & GridView1.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
            LoadDeposits()
        End If
    End Sub
    Private Sub txtAdvancePayment_TextChanged(sender As Object, e As EventArgs) Handles txtAdvancePayment.TextChanged
        If Val(CC(txtAdvancePayment.Text)) > 0 Then
            Me.AcceptButton = cmdAddPayment
        Else
            Me.AcceptButton = cmdConfirmPayment
        End If
    End Sub
End Class