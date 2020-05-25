Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSAccountJournal
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtGLItem.Items.Clear()
        com.CommandText = "select * from tbltransactioncode order by itemname asc" : rst = com.ExecuteReader
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()

        txtClient.Items.Clear()
        com.CommandText = "select * from tblbankaccounts order by bankname asc" : rst = com.ExecuteReader
        While rst.Read
            txtClient.Items.Add(New ComboBoxItem(rst("bankname").ToString, rst("bankcode").ToString))
        End While
        rst.Close()

        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)

        If GLobalclientjournalsequence = True Then
            txtReferenceNumber.ReadOnly = True
            txtReferenceNumber.Text = getPOSClientJournalSecquence()
        Else
            txtReferenceNumber.ReadOnly = False
        End If

        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
        If GLobalclientjournalsequence = True Then
            txtReferenceNumber.ReadOnly = True
            txtReferenceNumber.Text = getPOSClientJournalSecquence()
            com.CommandText = "UPDATE tblgeneralsettings set clientjournalsequence='" & txtReferenceNumber.Text & "'" : com.ExecuteNonQuery()
        Else
            txtReferenceNumber.ReadOnly = False
        End If
    End Sub

    Public Sub FilterTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select id,accountno, datetrn, (select itemname from tbltransactioncode where itemcode = tblsalesaccountjournal.itemcode) as 'Description', (select bankname from tblbankaccounts where bankcode = tblsalesaccountjournal.accountno) as 'Account', Remarks, Debit, Credit, datetrn as 'Date Post'  from tblsalesaccountjournal where trnsumcode = '" & globalSalesTrnCOde & "' and tblsalesaccountjournal.cancelled=0 union all " _
                                            + " select '','' ,current_timestamp, '', '', 'Total', sum(debit),sum(credit), '' from tblsalesaccountjournal where trnsumcode = '" & globalSalesTrnCOde & "' and tblsalesaccountjournal.cancelled=0) as s order by datetrn asc ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Remarks").Width = 300
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("datetrn").Visible = False
        MyDataGridView.Columns("accountno").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Debit", "Credit"})
        GridColumnAlignment(MyDataGridView, {"Debit", "Credit"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtGLItem.Text = "" Then
            MessageBox.Show("Please select item name type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGLItem.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MessageBox.Show("Please select account", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClient.Focus()
            Exit Sub

        ElseIf Val(CC(txtDebit.Text)) <= 0 And Val(CC(txtCredit.Text)) <= 0 Then
            MessageBox.Show("Please enter amount either debit or credit!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            com.CommandText = "insert into tblsalesaccountjournal set officeid='" & compOfficeid & "', trnsumcode='" & globalSalesTrnCOde & "', itemcode='" & itemcode.Text & "',accountno='" & cifcode.Text & "',referenceno='" & txtReferenceNumber.Text & "', debit='" & Val(CC(txtDebit.Text)) & "',credit='" & Val(CC(txtCredit.Text)) & "', remarks='" & rchar(txtRemarks.Text) & "',affectcash=1,trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            MsgBox("Transaction Successfully saved!", MsgBoxStyle.Information)
            FilterTransaction()
            txtRemarks.Text = ""
            txtCredit.Text = "0.00"
            txtDebit.Text = "0.00"
        End If
    End Sub

    Private Sub txtDebit_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebit.TextChanged
        If Val(CC(txtDebit.Text)) > 0 Then
            txtCredit.ReadOnly = True
            txtCredit.Text = "0"
        Else
            txtCredit.ReadOnly = False
        End If
    End Sub

    Private Sub txtCredit_EditValueChanged(sender As Object, e As EventArgs) Handles txtCredit.TextChanged
        If Val(CC(txtCredit.Text)) > 0 Then
            txtDebit.ReadOnly = True
            txtDebit.Text = "0"
        Else
            txtDebit.ReadOnly = False
        End If
    End Sub

    Private Sub txtGLItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGLItem.SelectedIndexChanged
        If txtGLItem.Text <> "" Then
            itemcode.Text = DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            itemcode.Text = ""
        End If
    End Sub
    Private Sub txtClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClient.SelectedIndexChanged
        If txtClient.Text <> "" Then
            cifcode.Text = DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            cifcode.Text = ""
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblsalesaccountjournal set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtDebit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebit.KeyPress
        InputNumberOnly(txtDebit, e)
    End Sub
End Class