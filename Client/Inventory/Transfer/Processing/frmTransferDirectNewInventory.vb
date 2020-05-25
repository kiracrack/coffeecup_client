Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmTransferDirectNewInventory

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F3 Then
            cmdFind.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        Me.Cursor = Cursors.WaitCursor
        LoadToComboBoxDB("select * from tblcompoffice where officeid<>'" & compOfficeid & "' order by officename asc", "officename", "officeid", txtOffice)
        loadTempParticular()
        Me.Cursor = Cursors.Default
    End Sub
    
    Public Sub loadTempParticular()
       MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trnid, itemid as 'productid',(select itemname from tblglobalproducts where productid=tbltransferrequestitem.itemid) as 'Product Name', " _
                                    + " Quantity,ifnull((select sum(quantity) from tblinventory where quantity>0 and officeid='" & compOfficeid & "' and productid=tbltransferrequestitem.itemid),0) as 'Available Quantity', Unit, Remarks from tbltransferrequestitem where trnby='" & globaluserid & "' and processed=-1", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "productid"})
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity", "Available Quantity"}, 4)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Available Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        If txtOffice.Text = "" Then
            MessageBox.Show("Please select office!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        End If
        frmTransferBrowseInventory.mode.Text = "direct"
        frmTransferBrowseInventory.officeid.Text = DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue
        frmTransferBrowseInventory.Show(Me)
    End Sub

    Private Sub cmdPrintPreview_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow(MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            If MessageBox.Show("Are you sure you want to permanently delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "delete from tbltransferrequestitem where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                loadTempParticular()
            End If
        End If
    End Sub

    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete.PerformClick()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If txtOffice.Text = "" Then
            MessageBox.Show("Please select office!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtrequester.Text = "" Then
            MessageBox.Show("Please select request by!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtrequester.Focus()
            Exit Sub
        ElseIf txtMessage.Text = "" Or txtMessage.Text = "Please enter message.." Then
            MessageBox.Show("Please enter message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMessage.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to send your request? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            Dim Batchcode As String = getStockTransferSequenceNo()
            com.CommandText = "insert into tbltransferbatch set batchcode='" & Batchcode & "', " _
                                + " inventory_from='" & compOfficeid & "', " _
                                + " inventory_to='" & DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue & "', " _
                                + " note='" & rchar(txtMessage.Text) & "', " _
                                + " requestby='" & DirectCast(txtrequester.SelectedItem, ComboBoxItem).HiddenValue & "', " _
                                + " datetransfer=current_timestamp, " _
                                + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            For cnts = 0 To MyDataGridView.RowCount - 1
                Dim remquantity As Double = 0 : Dim strquery As String = ""
                dst = New DataSet
                msda = New MySqlDataAdapter("Select * from tblinventory where officeid='" & compOfficeid & "' and productid='" & MyDataGridView.Item("productid", cnts).Value & "' and quantity > 0 order by dateinventory,trnid", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If remquantity = 0 Then
                            If Val(CC(MyDataGridView.Item("Quantity", cnts).Value)) > Val(.Rows(cnt)("quantity").ToString()) Then
                                remquantity = Val(CC(MyDataGridView.Item("Quantity", cnts).Value)) - Val(.Rows(cnt)("quantity").ToString())
                                com.CommandText = "insert into tbltransferitem set  " _
                                 + " batchcode='" & Batchcode & "', " _
                                 + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                                 + " itemid='" & MyDataGridView.Item("productid", cnts).Value & "', " _
                                 + " quantity='" & Val(.Rows(cnt)("quantity").ToString()) & "', " _
                                 + " unit='" & MyDataGridView.Item("Unit", cnts).Value & "', " _
                                 + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                                 + " remarks='" & rchar(MyDataGridView.Item("Remarks", cnts).Value) & "', " _
                                 + " trnby='" & globaluserid & "', " _
                                 + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                            Else
                                com.CommandText = "insert into tbltransferitem set  " _
                                  + " batchcode='" & Batchcode & "', " _
                                 + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                                 + " itemid='" & MyDataGridView.Item("productid", cnts).Value & "', " _
                                 + " unit='" & MyDataGridView.Item("Unit", cnts).Value & "', " _
                                 + " quantity='" & Val(MyDataGridView.Item("Quantity", cnts).Value) & "', " _
                                 + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                                 + " remarks='" & rchar(MyDataGridView.Item("Remarks", cnts).Value) & "', " _
                                 + " trnby='" & globaluserid & "', " _
                                 + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                                Exit For
                            End If
                        Else
                            If remquantity > Val(.Rows(cnt)("quantity").ToString()) Then
                                remquantity = remquantity - Val(.Rows(cnt)("quantity").ToString())
                                com.CommandText = "insert into tbltransferitem set  " _
                                 + " batchcode='" & Batchcode & "', " _
                                 + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                                 + " itemid='" & MyDataGridView.Item("productid", cnts).Value & "', " _
                                 + " quantity='" & Val(.Rows(cnt)("quantity").ToString()) & "', " _
                                 + " unit='" & MyDataGridView.Item("Unit", cnts).Value & "', " _
                                 + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                                 + " remarks='" & rchar(MyDataGridView.Item("Remarks", cnts).Value) & "', " _
                                 + " trnby='" & globaluserid & "', " _
                                 + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                            Else
                                com.CommandText = "insert into tbltransferitem set  " _
                                 + " batchcode='" & Batchcode & "', " _
                                 + " refcode='" & .Rows(cnt)("trnid").ToString() & "', " _
                                 + " itemid='" & MyDataGridView.Item("productid", cnts).Value & "', " _
                                 + " quantity='" & Val(remquantity) & "', " _
                                 + " unit='" & MyDataGridView.Item("Unit", cnts).Value & "', " _
                                 + " unitcost='" & Val(CC(.Rows(cnt)("purchasedprice").ToString())) & "', " _
                                 + " remarks='" & rchar(MyDataGridView.Item("Remarks", cnts).Value) & "', " _
                                 + " trnby='" & globaluserid & "', " _
                                 + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
                                Exit For
                            End If
                        End If
                    End With
                Next
            Next

            com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & Batchcode & "', n_title='New transfer request', n_description='from " & StrConv(compOfficename, vbProperCase) & " to " & StrConv(txtOffice.Text, vbProperCase) & "', n_type='transfer', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tbltransferrequestitem set reqcode='" & Batchcode & "', processed=1  where processed=-1 and trnby='" & globaluserid & "'" : com.ExecuteNonQuery()

            ReceivedTransfer(Batchcode, True)
            Me.Cursor = Cursors.Default
            If globalEnablePosPrinter = True Then
                PrintTransmittal(False, txtMessage.Text, Batchcode, txtOffice.Text, txtrequester.Text, CDate(Now).ToString)
            End If
            frmTransferProcessing.tabColumnOption()
            MessageBox.Show("Your transmittal was successfully sent! " & Environment.NewLine & Environment.NewLine _
                            & "Batch No#: " & Batchcode & Environment.NewLine _
                            & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                            & "Please check your receiving of good inventory transfer regulary to monitor your request!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    
    Private Sub bid_SelectedIndexChanged(sender As Object, e As EventArgs)
        loadTempParticular()
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdAddProduct_Click(sender As Object, e As EventArgs) Handles cmdAddProduct.Click
        frmProductRequest.Show(Me)
    End Sub
    Private Sub txtMessage_LostFocus(sender As Object, e As EventArgs) Handles txtMessage.LostFocus
        If txtMessage.Text = "" Then
            txtMessage.Text = "Please enter message.."
        End If
    End Sub
    Private Sub txtMessage_GotFocus(sender As Object, e As EventArgs) Handles txtMessage.GotFocus
        If txtMessage.Text = "Please enter message.." Then
            txtMessage.Text = ""
        End If
    End Sub

    Private Sub txtOffice_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOffice.SelectedValueChanged
        LoadToComboBoxDB("select * from tblaccounts where username<>'ROOT' and officeid='" & DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue & "' and deleted=0 order by fullname asc", "fullname", "accountid", txtrequester)
    End Sub
End Class