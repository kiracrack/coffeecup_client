Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmTransferRequestReview
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        FilterDetails()
        com.CommandText = "select *,date_format(daterequest,'%M %d, %Y %r') as 'daterequested',(select officename from tblcompoffice where officeid = tbltransferrequest.inventory_to) as 'office',(select fullname from tblaccounts where accountid=tbltransferrequest.requestby) as 'requestedby' from tbltransferrequest where reqcode='" & Batchcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtOfficeName.Text = rst("office").ToString
            txtMessage.Text = rst("message").ToString
            txtRequestedBy.Text = rst("requestedby").ToString
            txtDateRequested.Text = rst("daterequested").ToString
            txtreqid.Text = rst("requestby").ToString
            txtFrom.Text = rst("inventory_from").ToString
            txtTo.Text = rst("inventory_to").ToString
        End While
        rst.Close()
    End Sub

    Public Sub FilterDetails()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid,itemid, " _
                         + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) as 'Particular', " _
                         + " Quantity, Unit, " _
                         + " Remarks, " _
                         + " ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and quantity>0 and officeid = '" & compOfficeid & "'),0) as 'Available Inventory', " _
                         + " if(ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and quantity>0 and officeid = '" & compOfficeid & "'),0) < Quantity, 'Inventory out of stock','Available') as 'Status' " _
                         + " from tbltransferrequestitem  where processed=0 and reqcode = '" & Batchcode.Text & "'" _
                         + " order by (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "itemid"})
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity", "Available Inventory"}, 4)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Available Inventory", "Unit"}, DataGridViewContentAlignment.MiddleCenter)

        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("Status", i).Value().ToString = "Inventory out of stock" Then
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
        filterApprovalLogs(True, {Batchcode.Text}, "", MyDataGridView_Approval)
    End Sub
    'Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
    '    If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '        Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '    End If
    'End Sub

    Public Sub FilterNotAvailableInventory()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid,itemid, " _
                         + " (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) as 'Particular', " _
                         + " Quantity, Unit, " _
                         + " Remarks, " _
                         + " ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and quantity>0 and officeid = '" & compOfficeid & "'),0) as 'Available Inventory', " _
                         + " if(ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and quantity>0 and officeid = '" & compOfficeid & "'),0) < Quantity, 'Inventory out of stock','Available') as 'Status' " _
                         + " from tbltransferrequestitem  where processed=0 and reqcode = '" & Batchcode.Text & "' and if(ifnull((select sum(quantity) from tblinventory where productid=tbltransferrequestitem.itemid and officeid = '" & compOfficeid & "'),0) < Quantity, 'Inventory out of stock','Available') = 'Inventory out of stock' " _
                         + " order by (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "itemid"})
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity", "Available Inventory"}, 4)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Available Inventory", "Unit"}, DataGridViewContentAlignment.MiddleCenter)

        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("Status", i).Value().ToString = "Inventory out of stock" Then
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub

    'Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
    '    If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '        Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '    End If
    'End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        frmTransferRequestCancelled.Batchcode.Text = Batchcode.Text
        frmTransferRequestCancelled.Show(Me)
    End Sub


    Private Sub cmdChangeQuantity_Click(sender As Object, e As EventArgs) Handles cmdChangeQuantity.Click
        frmTransferRequestChangeQuantity.txtquan.Text = MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferRequestChangeQuantity.txtunit.Text = MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferRequestChangeQuantity.txtProductName.Text = MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferRequestChangeQuantity.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferRequestChangeQuantity.Show(Me)
    End Sub

    Private Sub cmdNotAvailable_Click(sender As Object, e As EventArgs) Handles cmdNotAvailable.Click
        If MessageBox.Show("Are you sure you want to continue?" & Environment.NewLine & Environment.NewLine & "NOTE: There's no undo function for this transaction.", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "delete from tbltransferrequestitem where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterDetails()
        End If
    End Sub

    Private Sub cmdRestoreDefault_Click(sender As Object, e As EventArgs) Handles cmdRestoreDefault.Click
        If MessageBox.Show("Are you sure you want to continue? your changes will be lost", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tbltransferrequestitem where reqcode='" & Batchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tbltransferrequestitem select * from tbltransferrequestitemlogs where reqcode='" & Batchcode.Text & "'" : com.ExecuteNonQuery()
            FilterDetails()
        End If
    End Sub

    Public Function StockTransferConfirmation(ByVal note As String, ByVal closerequest As Boolean)
        Dim newBatchCode As String = getStockTransferSequenceNo()
        com.CommandText = "insert into tbltransferbatch set batchcode='" & newBatchCode & "', " _
                                  + " inventory_from='" & txtFrom.Text & "', " _
                                  + " inventory_to='" & txtTo.Text & "', " _
                                  + " note='" & rchar(note) & "', " _
                                  + " requestby='" & txtreqid.Text & "', " _
                                  + " datetransfer=current_timestamp, " _
                                  + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            Dim remquantity As Double = 0 : Dim strquery As String = ""
            dst = New DataSet
            msda = New MySqlDataAdapter("Select * from tblinventory where officeid='" & txtFrom.Text & "' and productid='" & rw.Cells("itemid").Value.ToString & "' and quantity > 0 order by dateinventory,trnid", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If remquantity = 0 Then
                        If Val(CC(rw.Cells("Quantity").Value.ToString)) > Val(.Rows(cnt)("quantity").ToString()) Then
                            remquantity = Val(CC(rw.Cells("Quantity").Value.ToString)) - Val(.Rows(cnt)("quantity").ToString())
                            com.CommandText = "insert into tbltransferitem set  " _
                             + " batchcode='" & newBatchCode & "', " _
                             + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                             + " itemid='" & rw.Cells("itemid").Value.ToString & "', " _
                             + " unit='" & rw.Cells("Unit").Value.ToString & "', " _
                             + " quantity='" & Val(.Rows(cnt)("quantity").ToString()) & "', " _
                             + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                             + " remarks='" & rchar(rw.Cells("Remarks").Value.ToString) & "', " _
                             + " trnby='" & globaluserid & "', " _
                             + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "insert into tbltransferitem set  " _
                              + " batchcode='" & newBatchCode & "', " _
                             + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                             + " itemid='" & rw.Cells("itemid").Value.ToString & "', " _
                             + " unit='" & rw.Cells("Unit").Value.ToString & "', " _
                             + " quantity='" & Val(rw.Cells("Quantity").Value.ToString) & "', " _
                             + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                             + " remarks='" & rchar(rw.Cells("Remarks").Value.ToString) & "', " _
                             + " trnby='" & globaluserid & "', " _
                             + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                            Exit For
                        End If
                    Else
                        If remquantity > Val(.Rows(cnt)("quantity").ToString()) Then
                            remquantity = remquantity - Val(.Rows(cnt)("quantity").ToString())
                            com.CommandText = "insert into tbltransferitem set  " _
                             + " batchcode='" & newBatchCode & "', " _
                             + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                             + " itemid='" & rw.Cells("itemid").Value.ToString & "', " _
                             + " unit='" & rw.Cells("Unit").Value.ToString & "', " _
                             + " quantity='" & Val(.Rows(cnt)("quantity").ToString()) & "', " _
                             + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                             + " remarks='" & rchar(rw.Cells("Remarks").Value.ToString) & "', " _
                             + " trnby='" & globaluserid & "', " _
                             + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "insert into tbltransferitem set  " _
                             + " batchcode='" & newBatchCode & "', " _
                             + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                             + " itemid='" & rw.Cells("itemid").Value.ToString & "', " _
                             + " unit='" & rw.Cells("Unit").Value.ToString & "', " _
                             + " quantity='" & Val(remquantity) & "', " _
                             + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                             + " remarks='" & rchar(rw.Cells("Remarks").Value.ToString) & "', " _
                             + " trnby='" & globaluserid & "', " _
                             + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                            Exit For
                        End If
                    End If
                End With
            Next
            com.CommandText = "update tbltransferrequestitem set processed=1 where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
        Next

        com.CommandText = "update tbltransferitem set status=0 where batchcode='" & newBatchCode & "'" : com.ExecuteNonQuery()
        If closerequest = True Then
            com.CommandText = "update tbltransferrequest set confirmed=1,confirmedby='" & globaluserid & "', dateconfirmed=current_timestamp where reqcode='" & Batchcode.Text & "'" : com.ExecuteNonQuery()
        End If
 
        ReceivedTransfer(newBatchCode, True)

        If globalEnablePosPrinter = True Then
            PrintTransmittal(False, note, newBatchCode, txtOfficeName.Text, txtRequestedBy.Text, txtDateRequested.Text)
        End If
        MessageBox.Show("Stock was successfully Processed! " & Environment.NewLine & Environment.NewLine _
                           & "Batch No#: " & newBatchCode & Environment.NewLine _
                           & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                           & "Please check your Stock Transfer Processing!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmTransferRequisition.tabColumnOption()
        Me.Close()
        Return 0
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        PrintDatagridviewSignatories("ISSUANCE SLIP", "ISSUANCE DETAILS", "Request #: " & Batchcode.Text & "<br/>Office Requestor: " & txtOfficeName.Text & "<br/>Requested By: " & txtRequestedBy.Text & "<br/>Date Requested: " & txtDateRequested.Text & "<br/>Message: " & txtMessage.Text, MyDataGridView, "Requested By", txtreqid.Text, "Verified By", globaluserid, "Approved By", compOfficerid, Me)
    End Sub

    Private Sub ProcessSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessSelectedItemToolStripMenuItem.Click
        Dim outstock As Boolean = False
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("Status").Value.ToString = "Inventory out of stock" Then
                outstock = True
            End If
        Next
        If outstock = True Then
            MessageBox.Show("Some item not available to execute!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MyDataGridView.SelectedRows.Count = MyDataGridView.RowCount Then
            frmTransferRequestConfirmed.ckClose.Checked = True
            frmTransferRequestConfirmed.ckClose.Enabled = False
        Else
            frmTransferRequestConfirmed.ckClose.Checked = False
            frmTransferRequestConfirmed.ckClose.Enabled = True
        End If
        frmTransferRequestConfirmed.Batchcode.Text = Batchcode.Text
        frmTransferRequestConfirmed.Show(Me)
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        frmTransferBrowseInventory.officeid.Text = txtTo.Text
        frmTransferBrowseInventory.batchcode.Text = Batchcode.Text
        frmTransferBrowseInventory.mode.Text = "process"
        frmTransferBrowseInventory.Show(Me)
    End Sub
End Class