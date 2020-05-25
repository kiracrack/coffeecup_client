Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmReceivedFFE
    Dim edited As Boolean = False

    Private Sub frmReceivedConsumable_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If edited = True Then
            If MessageBox.Show("You have made some changes on your purchase order!" & Environment.NewLine & Environment.NewLine & "Note: Your edited item(s) will be resetted upon closing this form. but item(s) that already recieved will remain recieved. " & Environment.NewLine & Environment.NewLine & "Are you sure you want to exit?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub frmRReceivedConsumable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadPurchaseOrder()
    End Sub

    Public Sub LoadPurchaseOrder()
        LoadToComboBoxDB("select a.ponumber,concat(date_format(a.datetrn,'%Y-%m-%d'),' - ', a.ponumber,' - ', a.requestref,' - ',ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER'),' - ',(select officename from tblcompoffice where officeid=a.officeid)) as 'details' from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where catid in (select catid from tblprocategory where ffe=1) and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") & " group by b.ponumber;", "details", "ponumber", ponumber)
    End Sub

    Private Sub ponumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ponumber.SelectedValueChanged
        If ponumber.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpurchaseorder where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtInvoiceNumber.Text = rst("invoiceno").ToString
            txtTotalAmount.Text = rst("subtotal").ToString
            txtVerifiedAmount.Text = rst("totalamount").ToString
            ckAp.Checked = CBool(rst("ap"))
        End While
        rst.Close()
        FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
    End Sub
    Public Sub FilterDetails(ByVal strponumber As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  trnid, officeid,vendorid,productid,itemname as 'Particular', " _
                                    + " QUANTITY as 'Quantity',Cost, Total, total as originaltotal, case when delivered=1 then 'yes' when delivered=0 then 'not' else 'not included' end as 'verified' " _
                                    + " from tblpurchaseorderitem " _
                                    + " where catid in (select catid from tblprocategory where ffe=1) and ponumber='" & strponumber & "' ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "verified", "originaltotal", "officeid", "vendorid", "productid"})
        GridColumnAlignment(MyDataGridView, {"Quantity"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)
        MyDataGridView.Columns("Quantity").Width = 50
        MyDataGridView.Columns("Cost").Width = 50
        MyDataGridView.Columns("Total").Width = 80

        MyDataGridView.Columns("Particular").ReadOnly = True
        MyDataGridView.Columns("Particular").DefaultCellStyle.BackColor = Color.LemonChiffon
        'MyDataGridView.Columns("Particular").DefaultCellStyle.SelectionBackColor = Color.LemonChiffon
        'MyDataGridView.Columns("Particular").DefaultCellStyle.SelectionForeColor = Color.Black

        MyDataGridView.Columns("Total").ReadOnly = True
        MyDataGridView.Columns("Total").DefaultCellStyle.BackColor = Color.LemonChiffon
        MyDataGridView.Columns("Total").DefaultCellStyle.SelectionBackColor = Color.LemonChiffon
        MyDataGridView.Columns("Total").DefaultCellStyle.SelectionForeColor = Color.Black

        ReformatGridColor()
        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i

        Dim totalcost As Double = 0
        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("verified", i).Value().ToString <> "not included" Then
                totalcost = totalcost + Val(CC(MyDataGridView.Item("Total", i).Value().ToString))
            End If
        Next
        txtTotalAmount.Text = FormatNumber(totalcost, 2)
    End Sub

    Public Sub ReformatGridColor()
        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("verified", i).Value().ToString = "not included" Then
                MyDataGridView.Rows(i).DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Strikeout)
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                MyDataGridView.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Red
                MyDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.White
                MyDataGridView("Particular", i).Style.SelectionBackColor = Color.LemonChiffon
                MyDataGridView("Total", i).Style.SelectionBackColor = Color.LemonChiffon

                MyDataGridView.Rows(i).ReadOnly = True
            ElseIf MyDataGridView.Item("verified", i).Value().ToString = "yes" Then
                MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.YellowGreen
                MyDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.YellowGreen
                MyDataGridView.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
                MyDataGridView.Rows(i).ReadOnly = True
            Else
                MyDataGridView.Rows(i).DefaultCellStyle.Font = DefaultFont
                MyDataGridView.Rows(i).DefaultCellStyle.SelectionForeColor = DefaultForeColor
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = DefaultForeColor
                MyDataGridView.Rows(i).ReadOnly = False

                MyDataGridView("Particular", i).Style.BackColor = Color.LemonChiffon
                MyDataGridView("Particular", i).Style.ForeColor = Color.Black
                MyDataGridView("Particular", i).Style.SelectionBackColor = Color.DodgerBlue
                MyDataGridView("Particular", i).Style.SelectionForeColor = Color.Black

                MyDataGridView("Total", i).Style.BackColor = Color.LemonChiffon
                MyDataGridView("Total", i).Style.ForeColor = Color.Black
                MyDataGridView("Total", i).Style.SelectionBackColor = Color.LemonChiffon
                MyDataGridView("Total", i).Style.SelectionForeColor = Color.Black
            End If
        Next
        MyDataGridView.Columns("Particular").ReadOnly = True
        MyDataGridView.Columns("Total").ReadOnly = True

    End Sub
    Private Sub myDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        Dim gv As DataGridView = DirectCast(sender, DataGridView)
        Dim colCurrency As Array = {"Cost", "Total"}
        For Each valueArr As String In colCurrency
            If Not IsNothing(e.Value) Then
                If IsNumeric(e.Value) Then
                    If e.ColumnIndex = MyDataGridView.Columns(valueArr).Index Then
                        e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                    End If
                End If
            End If
        Next

        If gv.Item("verified", e.RowIndex).Value.ToString = "not included" Then
            gv.Item("Particular", e.RowIndex).ToolTipText = "this item will not include on upon closing this purchase order"
        ElseIf gv.Item("verified", e.RowIndex).Value.ToString = "yes" Then
            gv.Item("Particular", e.RowIndex).ToolTipText = "item already received and excluded on receiving upon closing this purchase order"
        End If
        ' End If
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub myDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellValueChanged
        Try
            Dim gv As DataGridView = DirectCast(sender, DataGridView)
            gv("Total", e.RowIndex).Value = Val(CC(gv("Cost", e.RowIndex).Value)) * Val(CC(gv("Quantity", e.RowIndex).Value))

            Dim totalcost As Double = 0
            For i = 0 To MyDataGridView.RowCount - 1
                If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                    totalcost = totalcost + Val(CC(MyDataGridView.Item("Total", i).Value().ToString))
                End If
            Next
            txtTotalAmount.Text = FormatNumber(totalcost, 2)

            If Val(CC(gv("Quantity", e.RowIndex).Value)) <= 0 Then
                gv("Quantity", e.RowIndex).Style.BackColor = Color.Red
                gv("Quantity", e.RowIndex).Style.ForeColor = Color.White
                gv.Item("Quantity", e.RowIndex).ToolTipText = "Invalid Quantity"
            Else
                gv("Quantity", e.RowIndex).Style.ForeColor = Color.Black
                gv("Quantity", e.RowIndex).Style.BackColor = Color.White
                gv.Item("Quantity", e.RowIndex).ToolTipText = Nothing
            End If

            If Val(CC(gv("Total", e.RowIndex).Value)) > gv("originaltotal", e.RowIndex).Value Then
                gv("Total", e.RowIndex).Style.BackColor = Color.Red
                gv("Total", e.RowIndex).Style.ForeColor = Color.White
                gv("Total", e.RowIndex).Style.SelectionBackColor = Color.Red
                gv("Total", e.RowIndex).Style.SelectionForeColor = Color.White
                gv.Item("Total", e.RowIndex).ToolTipText = "Exceeded from orignal amount " & FormatNumber(gv("originaltotal", e.RowIndex).Value, 2)
            Else
                If gv("verified", e.RowIndex).Value = "not" Then
                    gv("Particular", e.RowIndex).Style.BackColor = Color.LemonChiffon
                    gv("Particular", e.RowIndex).Style.ForeColor = Color.Black
                    gv("Particular", e.RowIndex).Style.SelectionBackColor = Color.LemonChiffon
                    gv("Particular", e.RowIndex).Style.SelectionForeColor = Color.Black

                    gv("Total", e.RowIndex).Style.BackColor = Color.LemonChiffon
                    gv("Total", e.RowIndex).Style.ForeColor = Color.Black
                    gv("Total", e.RowIndex).Style.SelectionBackColor = Color.LemonChiffon
                    gv("Total", e.RowIndex).Style.SelectionForeColor = Color.Black
                End If
                gv.Item("Total", e.RowIndex).ToolTipText = Nothing
            End If
            If gv("verified", e.RowIndex).Value = "not included" Then
                gv("Particular", e.RowIndex).Style.ForeColor = Color.Red
                gv("Particular", e.RowIndex).Style.SelectionForeColor = Color.Red
                gv("Total", e.RowIndex).Style.ForeColor = Color.Red
                gv("Total", e.RowIndex).Style.SelectionForeColor = Color.Red
            End If
            edited = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub myDataGridView_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles MyDataGridView.DataError
        MessageBox.Show("Error inputed value! please enter proper inputs", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ponumber.Text = "" Then
            MessageBox.Show("Please please select purchase order number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponumber.Focus()
            Exit Sub
        ElseIf txtattached1.Text = "" Then
            MessageBox.Show("Please attach official receipt!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtattached1.Focus()
            Exit Sub
        ElseIf checkAttachment(txtattached1.Text) = False Then
            MessageBox.Show("Your attachment is to large, please resize or compress your attachement to continue this process", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtattached1.Focus()
            Exit Sub
        End If
        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                If Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)) <= 0 Then
                    MessageBox.Show("Your purchase order contains invalid quantity!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Next
        If officeid.Text <> compOfficeid Then
            If MessageBox.Show("You are about to received delivery item from other office purchase order!" & Environment.NewLine & Environment.NewLine & "Note: If you continue this receiving, all item you received will be add to your office inventory! Not the requesting party" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Else
                Exit Sub
            End If
        End If

        If MessageBox.Show("Are you sure you want to close current purchase order?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If AddAttachmentPackage(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), "delivery_official_receipt", {txtattached1.Text}) = True Then
                For i = 0 To MyDataGridView.RowCount - 1
                    If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                        dst = New DataSet
                        msda = New MySqlDataAdapter("Select * from tblpurchaseorderitem where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "' and trnid='" & MyDataGridView.Item("trnid", i).Value().ToString & "'", conn)
                        msda.Fill(dst, 0)
                        For cnt = 0 To dst.Tables(0).Rows.Count - 1
                            With (dst.Tables(0))
                                UpdateFFEInventory("new", "", DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), compOfficeid, "", .Rows(cnt)("vendorid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)), Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)), "", True, "", False, Val(CC(MyDataGridView.Item("Total", i).Value)), 0, "", "", "", "", True, "FFE PROFILE NOT COMPLETED", True, Nothing)
                                com.CommandText = "update tblpurchaseorderitem set delivered=1, datedelivered=current_timestamp, quantity='" & Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)) & "',cost='" & Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)) & "', total='" & Val(CC(MyDataGridView.Item("Total", i).Value().ToString)) & "' where trnid='" & MyDataGridView.Item("trnid", i).Value().ToString & "'" : com.ExecuteNonQuery()
                            End With
                        Next cnt
                    End If
                Next

                If Val(CC(txtTotalAmount.Text)) > 0 And ckAp.Checked = True Then
                    com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                 + "select 'payable-accounts',vendorid,ponumber,'Purchase Order', note, '" & Val(CC(txtVerifiedAmount.Text)) & "', 0,datetrn,createby,1,'" & globaluserid & "',current_timestamp from tblpurchaseorder where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
                End If

                com.CommandText = "DELETE from tblpurchaseorderitem where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "' and delivered=-1" : com.ExecuteNonQuery()
                com.CommandText = "update tblpurchaseorder set invoiceno='" & txtInvoiceNumber.Text & "', vat=0, charges=0, discount=0,totalamount='" & Val(CC(txtVerifiedAmount.Text)) & "', " _
                                        + " delivered=1, datedelivered=current_timestamp,receivedby='" & globaluserid & "' where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
                '#record history
                RecordApprovingHistory("purchase order", qrysingledata("requestref", "requestref", "tblpurchaseorder where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'"), DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), "Received", "PO#" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & " Received delivery purchases")
                ponumber.SelectedIndex = -1 : LoadPurchaseOrder() : FilterDetails("") : txtattached1.Text = "" : edited = False : txtInvoiceNumber.Text = ""
                MessageBox.Show("Purchase order successfuly closed!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Closing purchase order encounter error during uploading your attachment. Please try again!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmda1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "All Types (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'txtattached1.Text = objOpenFileDialog.FileName
                If checkAttachment(objOpenFileDialog.FileName) = False Then
                    txtattached1.BackColor = Color.Red
                Else
                    txtattached1.BackColor = Color.White
                    If (Not System.IO.Directory.Exists(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")) Then
                        System.IO.Directory.CreateDirectory(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")
                    End If
                    System.IO.File.Delete(file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                    System.IO.File.Copy(objOpenFileDialog.FileName, file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                End If
                txtattached1.Text = file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName)
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

  

    Private Sub cmdSendOfficialReceipt_Click(sender As Object, e As EventArgs) Handles cmdSendOfficialReceipt.Click
        If MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value = "yes" Then
            MessageBox.Show("Item was already received!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value = "not"
        com.CommandText = "update tblpurchaseorderitem set delivered=0 where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentCell.RowIndex).Value & "'" : com.ExecuteNonQuery()
        ReformatGridColor()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value = "yes" Then
            MessageBox.Show("Item was already received!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value = "not included"
        com.CommandText = "update tblpurchaseorderitem set delivered=-1 where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentCell.RowIndex).Value & "'" : com.ExecuteNonQuery()
        ReformatGridColor()
    End Sub

    Private Sub ReceiveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveItemToolStripMenuItem.Click
        If MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value = "yes" Then
            MessageBox.Show("Item was already received!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If officeid.Text <> compOfficeid Then
            If MessageBox.Show("You are about to received delivery item from other office purchase order!" & Environment.NewLine & Environment.NewLine & "Note: If you continue this receiving, all item you received will be add to your office inventory!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Else
                Exit Sub
            End If
        End If

        If MessageBox.Show("This item will automaticaly add to your current inventory." & Environment.NewLine & Environment.NewLine & "NOTE: This action is no undo function! in order to correct the erroneuos entries, please ask assistance from the procurement department for adjustment! Not the requesting party" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value = "yes"
            UpdateFFEInventory("new", "", DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), compOfficeid, "", MyDataGridView.Item("vendorid", MyDataGridView.CurrentCell.RowIndex).Value, MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value, Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value)), Val(CC(MyDataGridView.Item("Cost", MyDataGridView.CurrentCell.RowIndex).Value)), "", True, "", False, Val(CC(MyDataGridView.Item("Total", MyDataGridView.CurrentCell.RowIndex).Value)), 0, "", "", "", "", True, "FFE PROFILE NOT COMPLETED", True, Nothing)
            com.CommandText = "update tblpurchaseorderitem set quantity=" & Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value)) & ", cost=" & Val(CC(MyDataGridView.Item("Cost", MyDataGridView.CurrentCell.RowIndex).Value)) & ",total=" & Val(CC(MyDataGridView.Item("Total", MyDataGridView.CurrentCell.RowIndex).Value)) & ", delivered=1,datedelivered=current_timestamp where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentCell.RowIndex).Value & "'" : com.ExecuteNonQuery()
            FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
        End If
    End Sub
    Private Sub Calucator_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalAmount.TextChanged
        txtVerifiedAmount.Text = FormatNumber(Val(CC(txtTotalAmount.Text)), 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSearchPurchaseOrder.ckConsumable.Checked = False
        frmSearchPurchaseOrder.Show(Me)
    End Sub

  
End Class