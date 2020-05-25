Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Data.OleDb

Public Class frmPOSCurrentTransactions
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSTransactionsHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowBatchTransactions()
    End Sub

   
    Public Sub ShowBatchTransactions()
        MyDataGridView_Batch.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("CALL sp_salestransaction('CURRENT','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Batch.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Batch, {"datetrn"})
        GridColumnAlignment(MyDataGridView_Batch, {"Batch Code", "Payment Type", "Invoice No", If(Globalenablechittransaction = True, "Chit Transaction", Nothing)}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
 
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                For Each rw As DataGridViewRow In MyDataGridView_Batch.SelectedRows
                    VoidBatchSalesTransaction(rw.Cells("Batch Code").Value.ToString, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                Next
                ShowBatchTransactions()
                MsgBox("Transaction successfully void!", MsgBoxStyle.Information)
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
    End Sub

    Private Sub ReprintTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprintTransactionToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to re-print selected transaction? " & Environment.NewLine & Environment.NewLine & "Note: Re-Print transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                For Each rw As DataGridViewRow In MyDataGridView_Batch.SelectedRows
                    RePrintPOSTransaction(rw.Cells("Batch Code").Value.ToString, "tblsalesbatch", "batchcode", "receipt")
                Next
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If

    End Sub
End Class