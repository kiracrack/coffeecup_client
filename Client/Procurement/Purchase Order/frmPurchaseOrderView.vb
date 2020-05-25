Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmPurchaseOrderView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loaddetails()
        SearchByRequesitions()
    End Sub

    Private Sub ponumber_TextChanged(sender As Object, e As EventArgs) Handles ponumber.TextChanged
        loaddetails()
        SearchByRequesitions()
    End Sub
    Public Function loaddetails()
        com.CommandText = "select *, (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid ) as 'office', " _
                                 + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                                 + " if(corporatelevel=1,'CORPORATE','OFFICE') as applevel, " _
                                 + PurchaseOrderStatus _
                                 + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from "  & sqlfiledir & ".tblattachmentlogs where refnumber = tblpurchaseorder.ponumber or refnumber=tblpurchaseorder.requestref),'-') as 'Attachment'  " _
                                 + " from tblpurchaseorder where ponumber='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtoffice.Text = rst("office").ToString
            txtSupplier.Text = rst("Supplier").ToString
            txtStatus.Text = rst("Status").ToString
            pid.Text = rst("requestref").ToString
            txtApprovingLEvel.Text = rst("applevel").ToString
            txtInvoiceNumber.Text = rst("invoiceno").ToString
            txtTotalAmount.Text = FormatNumber(rst("subtotal").ToString, 2)
            txtVat.Text = FormatNumber(rst("vat").ToString, 2)
            txtCharges.Text = FormatNumber(rst("charges").ToString, 2)
            txtDiscount.Text = FormatNumber(rst("discount").ToString, 2)
            txtVerifiedAmount.Text = FormatNumber(rst("totalamount").ToString, 2)

            If rst("Attachment").ToString <> "-" Then
                If txtStatus.Text = "APPROVED" Then
                    cmdAttachment.Enabled = True
                    If CBool(rst("forwarded")) = False Then
                        cmdAttachment.Text = "Waiting to be forwarded"
                        cmdAttachment.Enabled = False
                    Else
                        cmdAttachment.Text = "Download Purchase Order"
                        cmdAttachment.Enabled = True
                    End If

                Else
                    cmdAttachment.Enabled = True
                    cmdAttachment.Text = rst("Attachment").ToString
                End If
            Else
                cmdAttachment.Enabled = False
                cmdAttachment.Text = "Not Availaible"
            End If

        End While
        rst.Close()
        TextBoxColorCode(txtStatus)
        Return 0
    End Function

    Public Sub SearchByRequesitions()
        MyDataGridView_Particular.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select itemname as 'Particular', " _
                              + " (select DESCRIPTION from tblprocategory where CATID = tblpurchaseorderitem.CATID ) as 'Category', " _
                              + " QUANTITY as 'Quantity'," _
                              + " UNIT as 'Unit', " _
                              + " COST as 'Cost', " _
                              + " TOTAL as 'Total', " _
                              + " Remarks " _
                              + " from tblpurchaseorderitem " _
                              + " where ponumber='" & ponumber.Text & "'", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Particular.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView_Particular, {"Cost", "Total"})
        GridColumnAlignment(MyDataGridView_Particular, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Particular, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        If MyDataGridView_Particular.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView_Particular.RowCount - 1
                totalsum = totalsum + MyDataGridView_Particular.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).Cells("Cost").Value = "Total"
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).Cells("Total").Value = totalsum
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
        filterApprovalLogs(False, {ponumber.Text, pid.Text}, "", MyDataGridView_Approval)
    End Sub

    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        If txtStatus.Text = "APPROVED" Then
            If ViewAttachmentPackage_Database({ponumber.Text}, "purchase-order") = True Then
                RecordApprovingHistory("purchase order", pid.Text, ponumber.Text, "downloaded", "PO#" & ponumber.Text & " Downloaded")
            End If
        Else
            ViewAttachmentPackage_Database({pid.Text, ponumber.Text}, "")
        End If
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        PrintDatagridview("Requisition Approval History<br/><strong>" & pid.Text & "</strong>", "Requisition Approval History", "Office: " & txtoffice.Text, MyDataGridView_Approval, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filterApprovalLogs(False, {pid.Text, ponumber.Text}, "", MyDataGridView_Approval)
    End Sub
End Class