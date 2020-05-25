Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Data.OleDb

Public Class frmPOSTransactionsHistory
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
        tabFilter()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub
    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabInvoices Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = cms_em
            cmdReprint.Visible = True
            ViewInvoices()

        ElseIf TabControl1.SelectedTab Is tabInteroffice Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = cms_em
            cmdReprint.Visible = True
            ViewInterOffice()

        ElseIf TabControl1.SelectedTab Is tabVoid Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = Nothing
            ShowVoidTransactions()

        ElseIf TabControl1.SelectedTab Is tabCancelled Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = Nothing
            ShowCancelledTransactions()

        ElseIf TabControl1.SelectedTab Is tabDetails Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = Nothing
            cmdReprint.Visible = False
            ShowDetailTransactions()

        ElseIf TabControl1.SelectedTab Is tabBatch Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = cms_em
            cmdReprint.Visible = True
            ShowBatchTransactions()

        ElseIf TabControl1.SelectedTab Is tabInvoices Then
            Em.Parent = TabControl1.SelectedTab
            Em.ContextMenuStrip = cms_em
            cmdReprint.Visible = True
            ViewInvoices()

        End If

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & TabControl1.SelectedTab.Name & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If

        End While
        rst.Close()
        SaveFilterColumn(GridView1, Me.Text & TabControl1.SelectedTab.Name)
    End Sub
 
    Public Sub ViewInvoices()
        LoadXgrid("CALL sp_salestransaction('INVOICE','" & globalSalesTrnCOde & "',0)", "CALL sp_salestransaction('INVOICE','" & globalSalesTrnCOde & "',0)", Em, GridView1)

        XgridColCurrency({"Total Amount", "Amount"}, GridView1)
        XgridColAlign({"Batch Code", "Invoice No."}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView1)
    End Sub
     

    Public Sub ViewInterOffice()
        LoadXgrid("CALL sp_salestransaction('INTEROFFICE','" & globalSalesTrnCOde & "',0)", "CALL sp_salestransaction('INTEROFFICE','" & globalSalesTrnCOde & "',0)", Em, GridView1)

        XgridColCurrency({"Amount Due", "Covered Amount", "Excess Amount"}, GridView1)
        XgridColAlign({"Batch Code", "Transaction No.", "Excess Cash Payment"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount Due", "Covered Amount", "Excess Amount"}, GridView1)
    End Sub
   
    Public Sub ShowBatchTransactions()
        
        LoadXgrid("CALL sp_salestransaction('BATCH','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('BATCH','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", Em, GridView1)

        XgridColCurrency({"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Total Tax", "Amount Tendered", "Change", If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Invoice No.", "Total Item", "Item Cancelled", "Payment Type", If(Globalenablesaleinvoicenumber = True, "Invoice No", Nothing), If(Globalenablechittransaction = True, "SOP Transaction", Nothing)}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount", "Total SOP"}, GridView1)
    End Sub
   
    Public Sub ShowDetailTransactions()
        LoadXgrid("CALL sp_salestransaction('DETAILED','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('DETAILED','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", Em, GridView1)

        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Unit Price"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Amount", "Total SOP"}, GridView1)
    End Sub
    
    Public Sub ShowVoidTransactions()
        LoadXgrid("CALL sp_salestransaction('VOID','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('VOID','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", Em, GridView1)

        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Status", "Unit Price"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total SOP", "Total Amount"}, GridView1)
    End Sub

    Public Sub ShowCancelledTransactions()
        LoadXgrid("CALL sp_salestransaction('CANCELLED','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", "CALL sp_salestransaction('CANCELLED','" & globalSalesTrnCOde & "'," & Globalenablechittransaction & ")", Em, GridView1)

        XgridColCurrency({"Quantity", "Unit Price", "Discount", "Tax", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "SOP", Nothing), If(Globalenablechittransaction = True, "Total SOP", Nothing)}, GridView1)
        XgridColAlign({"Batch Code", "Quantity", "Unit", "Status", "Unit Price"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Discount", "Tax", "Sub Total", "Total SOP", "Total Amount"}, GridView1)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name & TabControl1.SelectedTab.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name & TabControl1.SelectedTab.Name, GridView1)
    End Sub

    
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdVoid.Click
        If MessageBox.Show("Are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    VoidBatchSalesTransaction(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Batch Code").ToString(), frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                Next
                tabFilter()
                MsgBox("Transaction successfully void!", MsgBoxStyle.Information)
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
    End Sub

    Private Sub ReprintTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdReprint.Click
        If MessageBox.Show("Are you sure you want to re-print selected transaction? " & Environment.NewLine & Environment.NewLine & "Note: Re-Print transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                For I = 0 To GridView1.SelectedRowsCount - 1
                    RePrintPOSTransaction(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Batch Code").ToString(), "tblsalesbatch", "batchcode", "receipt")
                Next
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If


    End Sub

    Private Sub cmdColumnChooser_Click(sender As Object, e As EventArgs) Handles cmdColumnChooser.Click
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text & TabControl1.SelectedTab.Name)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXPrintDatagridview(TabControl1.SelectedTab.Text, "Database Report", "Cashier: " & globalfullname, GridView1, Me)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class