﻿Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmVoucherOtherExpense
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmVoucherOtherExpense_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub
    Private Sub frmVoucherOtherExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionName()
        If mode.Text = "edit" Then
            showInfo()
        End If
    End Sub
    Public Sub LoadTransactionName()
        If LCase(globalusername) = "root" Then
            LoadXgridLookupSearch("select itemcode, itemname as 'Item Name' from tblglitem where sl=1  and groupcode in (select groupcode from tblglgrouptag where expenses=1 and deleted=0)", "tblglitem", txtTransactionName, Gridview_TransactionName)
        Else
            LoadXgridLookupSearch("select itemcode, itemname as 'Item Name' from tblglitem where sl=1 and itemcode in (select itemcode from tblglaccountfilter where permissioncode='" & globalpermissioncode & "') and groupcode in (select groupcode from tblglgrouptag where expenses=1 and deleted=0)", "tblglitem", txtTransactionName, Gridview_TransactionName)
        End If
        Gridview_TransactionName.Columns("itemcode").Visible = False
    End Sub
    Private Sub txtTransactionName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransactionName.EditValueChanged
        On Error Resume Next
        itemcode.Text = txtTransactionName.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
    End Sub
    Public Sub showInfo()
        com.CommandText = "select * from tbldisbursementexpense where id='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            voucherno.Text = rst("voucherno").ToString
            itemcode.Text = rst("itemcode").ToString
            txtTransactionName.EditValue = rst("itemcode").ToString
            txtRemarks.Text = rst("remarks").ToString
            txtCheckAmount.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtTransactionName.Text = "" Then
            MessageBox.Show("Please select transaction name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTransactionName.Focus()
            Exit Sub
        ElseIf Val(CC(txtCheckAmount.Text)) <= 0 Then
            MessageBox.Show("Please enter amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCheckAmount.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tbldisbursementexpense set voucherno='" & voucherno.Text & "', companyid='" & companyid.Text & "', itemcode='" & itemcode.Text & "', remarks='" & rchar(txtRemarks.Text) & "', amount='" & Val(CC(txtCheckAmount.Text)) & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbldisbursementexpense set voucherno='" & voucherno.Text & "', companyid='" & companyid.Text & "', itemcode='" & itemcode.Text & "', remarks='" & rchar(txtRemarks.Text) & "', amount='" & Val(CC(txtCheckAmount.Text)) & "', datetrn=current_date" : com.ExecuteNonQuery()
            End If
            frmLiquidationForm.loaddetails()
            MessageBox.Show("Expense successfully saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

End Class