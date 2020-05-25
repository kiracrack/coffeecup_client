Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmAcctVoucherDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmVoucherOtherExpense_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub

    Private Sub frmAcctVoucherDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtInvoiceDate.EditValue = CDate(Now)
        If mode.Text = "edit" Then
            showInfo()
        End If
    End Sub

    Public Sub showInfo()
        com.CommandText = "select * from tbldisbursementdetails where id='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            voucherno.Text = rst("voucherno").ToString
            supplierid.Text = rst("vendorid").ToString
            suppliername.Text = rst("supplier").ToString
            txtInvoiceDate.EditValue = CDate(rst("datetrn").ToString)
            txtPONumber.Text = rst("ponumber").ToString
            txtTransactionName.Text = rst("description").ToString
            txtNote.Text = rst("note").ToString
            txtInvoiceNo.Text = rst("invoiceno").ToString
            txtAmount.EditValue = rst("amount").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtInvoiceDate.Text = "" Then
            MessageBox.Show("please select invoice date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInvoiceDate.Focus()
            Exit Sub
        ElseIf txtPONumber.Text = "" Then
            MessageBox.Show("please enter po number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPONumber.Focus()
            Exit Sub
        ElseIf txtInvoiceNo.Text = "" Then
            MessageBox.Show("please enter invoice number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInvoiceNo.Focus()
            Exit Sub
        ElseIf Val(txtAmount.EditValue) = 0 Then
            MessageBox.Show("please enter amount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmount.Focus()
            Exit Sub
        ElseIf txtTransactionName.Text = "" Then
            MessageBox.Show("please enter transaction name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTransactionName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tbldisbursementdetails set  vendorid='" & supplierid.Text & "',supplier='" & rchar(suppliername.Text) & "', datetrn='" & ConvertDate(txtInvoiceDate.EditValue) & "',ponumber='" & txtPONumber.Text & "',description='" & rchar(txtTransactionName.Text) & "',note='" & rchar(txtNote.Text) & "',invoiceno='" & txtInvoiceNo.Text & "',amount='" & txtAmount.EditValue & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
                frmAcctVoucherInfo.LoadVoucherExpenses()
                MessageBox.Show("Transaction successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                com.CommandText = "insert into tbldisbursementdetails set voucherno='" & If(voucherno.Text = "", globaluserid & "-temp", voucherno.Text) & "',vendorid='" & supplierid.Text & "',supplier='" & rchar(suppliername.Text) & "', datetrn='" & ConvertDate(txtInvoiceDate.EditValue) & "',ponumber='" & txtPONumber.Text & "',description='" & rchar(txtTransactionName.Text) & "',note='" & rchar(txtNote.Text) & "',invoiceno='" & txtInvoiceNo.Text & "',amount='" & txtAmount.EditValue & "' " : com.ExecuteNonQuery()
                ClearInfo()
                frmAcctVoucherInfo.LoadVoucherExpenses()
                MessageBox.Show("Transaction successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
         
        End If
    End Sub

    Public Sub ClearInfo()
        txtTransactionName.Text = ""
        txtNote.Text = ""
        txtAmount.EditValue = "0"
        mode.Text = ""
        trnid.Text = ""
        txtAmount.Focus()
    End Sub
End Class