Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSCheckEncashment
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtCheckNumber.Text = ""
        txtIssuerBank.Text = ""
        txtRemarks.Text = ""
        txtAmount.Text = ""

        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
    End Sub

    Public Sub FilterTransaction()
        dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select id,datetrn, checknumber as 'Check Number',issuerbank as 'Issuer Bank', companyname as 'Company Name', date_format(checkdate,'%Y-%m-%d') as 'Check Date', Amount, Remarks,  datetrn as 'Date Post' from tblsaleschecktocash where trnsumcode = '" & globalSalesTrnCOde & "' and tblsaleschecktocash.cancelled=0 union all " _
                                    + " select '',current_timestamp,'','','', 'Total', sum(amount), '','' from tblsaleschecktocash where trnsumcode = '" & globalSalesTrnCOde & "' and tblsaleschecktocash.cancelled=0) as s order by datetrn asc", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Remarks").Width = 500
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("datetrn").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Check Number", "Check Date"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtCheckNumber.Text = "" Then
            MessageBox.Show("Please check number!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckNumber.Focus()
            Exit Sub
        ElseIf txtIssuerBank.Text = "" Then
            MessageBox.Show("Please enter issuer bank", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtIssuerBank.Focus()
            Exit Sub
        ElseIf txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter company name", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmount.Text)) <= 0 Then
            MessageBox.Show("Please enter proper amount", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmount.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblsaleschecktocash set trnsumcode='" & globalSalesTrnCOde & "', userid='" & globaluserid & "', checknumber='" & rchar(txtCheckNumber.Text) & "', issuerbank='" & rchar(txtIssuerBank.Text) & "',companyname='" & rchar(txtCompanyName.Text) & "', checkdate='" & ConvertDate(txtDateTransaction.Value) & "', remarks='" & rchar(txtRemarks.Text) & "',amount='" & Val(CC(txtAmount.Text)) & "', datetrn=current_timestamp, verified=1,dateverified=current_timestamp,verifiedby='" & globaluserid & "'" : com.ExecuteNonQuery()
            txtCheckNumber.Text = ""
            txtIssuerBank.Text = ""
            txtRemarks.Text = ""
            txtAmount.Text = ""
            FilterTransaction()
            MsgBox("Check Successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtAmount, e)
        End If
    End Sub


    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblsaleschecktocash set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub
End Class