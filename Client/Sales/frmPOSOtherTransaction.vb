Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSOtherTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSOtherTransaction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblpaymenttransactions", "trnid='" & txtORNumber.Text & "'") = 0 Then
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


    Private Sub frmPOSOtherTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtGLItem.Items.Clear()
        com.CommandText = "select * from tbltransactioncode order by itemname asc" : rst = com.ExecuteReader
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()
        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)
        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
        GetORNumber()

    End Sub
    Public Sub GetORNumber()
        If GLobalclientjournalsequence = True Then
            txtORNumber.ReadOnly = True
            txtORNumber.Text = getPOSClientJournalSecquence()
            com.CommandText = "UPDATE tblgeneralsettings set clientjournalsequence='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()
        Else
            txtORNumber.ReadOnly = False
        End If
    End Sub
    Public Sub FilterTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select id, datetrn, (select itemname from tbltransactioncode where itemcode = tblsalesothertransaction.itemcode) as 'Description', Remarks, Amount, datetrn as 'Date Post' from tblsalesothertransaction where trnsumcode = '" & globalSalesTrnCOde & "' and cancelled=0 union all " _
                                            + " select '', current_timestamp, '', 'Total', sum(amount),  ''  from tblsalesothertransaction where trnsumcode = '" & globalSalesTrnCOde & "' and cancelled=0) as s order by datetrn asc ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Remarks").Width = 300
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("datetrn").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
       
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtGLItem.Text = "" Then
            MessageBox.Show("Please select item name type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGLItem.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmountTender.Text)) = 0 Then
            MessageBox.Show("Please enter proper amount", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmountTender.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            Dim paymentmode As String = "" : Dim paymentmode2 As String = ""
            If rbMultiPayment.Checked = True Then
                paymentmode = ", paymenttype='others' "
                paymentmode2 = "Others"
            Else
                paymentmode = ", paymenttype='cash'"
                paymentmode2 = "Cash"
                If Val(CC(txtAmountTender.Text)) > 0 Then
                    If countqry("tblsalescashpayment", "trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'") > 0 Then
                        com.CommandText = "UPDATE tblsalescashpayment set amount='" & Val(CC(txtAmountTender.Text)) & "',cashchange=0,datetrn=current_timestamp,trnby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "' and batchcode='" & txtORNumber.Text & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "insert into tblsalescashpayment set trnsumcode='" & globalSalesTrnCOde & "',batchcode='" & txtORNumber.Text & "',amount='" & Val(CC(txtAmountTender.Text)) & "',datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    End If
                End If
            End If
            com.CommandText = "insert into tblsalesothertransaction set officeid='" & compOfficeid & "', trnsumcode='" & globalSalesTrnCOde & "', itemcode='" & itemcode.Text & "', amount='" & Val(CC(txtAmountTender.Text)) & "',  remarks='" & rchar(txtRemarks.Text) & "', trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            GetORNumber() : FilterTransaction() : txtRemarks.Text = "" : txtAmountTender.Text = "0.00"
            MsgBox("Transaction Successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtGLItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGLItem.SelectedIndexChanged
        If txtGLItem.Text <> "" Then
            itemcode.Text = DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            itemcode.Text = ""
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblsalesothertransaction set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtDebit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountTender.KeyPress
        InputNumberOnly(txtAmountTender, e)
    End Sub

    Private Sub rbMultiPayment_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged, rbMultiPayment.CheckedChanged
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
        frmPOSMultiPayments.batchcode.Text = txtORNumber.Text
        frmPOSMultiPayments.lblTransaction.Text = GlobalWalkinAccountName
        frmPOSMultiPayments.txtTotalOnScreen.Text = txtAmountTender.Text
        frmPOSMultiPayments.cifid.Text = GlobalWalkinAccountCIFCode
        frmPOSMultiPayments.mode.Text = "other"
        frmPOSMultiPayments.ShowDialog(Me)
    End Sub

    
End Class