Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmReceivedConsumable_backup
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
        If GlobalAllowchangeitempo = True Then
            cmdChangeItem.Visible = True
        Else
            cmdChangeItem.Visible = False
        End If
        PopulateGridViewControls("Select", 20, "CHECKBOX", MyDataGridView, True, False)
        PopulateGridViewControls("trnid", 0, "", MyDataGridView, False, True)
        PopulateGridViewControls("officeid", 0, "", MyDataGridView, False, True)
        PopulateGridViewControls("vendorid", 0, "", MyDataGridView, False, True)
        PopulateGridViewControls("productid", 0, "", MyDataGridView, False, True)

        PopulateGridViewControls("Particular", 50, "", MyDataGridView, True, True)
        PopulateGridViewControls("Unit", 50, "", MyDataGridView, True, False)
        PopulateGridViewControls("Quantity", 50, "", MyDataGridView, True, False)
        PopulateGridViewControls("Cost", 50, "", MyDataGridView, True, False)
        PopulateGridViewControls("Total", 80, "", MyDataGridView, True, False)
        PopulateGridViewControls("originaltotal", 0, "", MyDataGridView, True, False)
        PopulateGridViewControls("verified", 0, "", MyDataGridView, True, False)
        PopulateGridViewControls("catid", 0, "", MyDataGridView, False, True)
        GridHideColumn(MyDataGridView, {"trnid", "verified", "originaltotal", "officeid", "vendorid", "productid"})
        LoadPurchaseOrder()
    End Sub
    Public Function ChangeItem(ByVal productid As String, ByVal productname As String, ByVal unit As String)
        MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value = productid
        MyDataGridView.Item("Particular", MyDataGridView.CurrentCell.RowIndex).Value = productname
        MyDataGridView.Item("Unit", MyDataGridView.CurrentCell.RowIndex).Value = unit
    End Function
    Public Sub LoadPurchaseOrder()
        LoadToComboBoxDB("select a.ponumber,concat(date_format(a.datetrn,'%Y-%m-%d'),' - ', a.ponumber,' - ', a.requestref,' - ',ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER'),' - ',(select officename from tblcompoffice where officeid=a.officeid)) as 'details' from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where " _
                         + " catid in (select catid from tblprocategory where consumable=1) and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") & " group by b.ponumber order by a.datetrn asc;", "details", "ponumber", ponumber)
    End Sub

    Private Sub ponumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ponumber.SelectedValueChanged
        If ponumber.Text = "" Then Exit Sub
        com.CommandText = "select * from tblpurchaseorder where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtInvoiceNumber.Text = rst("invoiceno").ToString
            'txtTotalAmount.Text = rst("subtotal").ToString
            ckAp.Checked = CBool(rst("ap"))
        End While
        rst.Close()
        FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
    End Sub
    Public Sub FilterDetails(ByVal strponumber As String)
        MyDataGridView.Rows.Clear()
        'MyDataGridView.DataSource = Nothing : dst = New DataSet
        'msda = New MySqlDataAdapter("Select trnid, officeid,vendorid,productid,itemname as 'Particular',Unit, " _
        '                            + " QUANTITY as 'Quantity',Cost, Total, total as originaltotal, case when delivered=1 then 'yes' when delivered=0 then 'not' else 'not included' end as 'verified' " _
        '                            + " from tblpurchaseorderitem " _
        '                            + " where catid in (select catid from tblprocategory where consumable=1) and ponumber='" & strponumber & "' ", conn)
        com.CommandText = "Select *, itemname as 'Particular',Unit, " _
                                    + " QUANTITY as 'Quantity',Cost, Total, total as originaltotal, case when delivered=1 then 'yes' when delivered=0 then 'not' else 'not included' end as 'verified' " _
                                    + " from tblpurchaseorderitem " _
                                    + " where catid in (select catid from tblprocategory where consumable=1) and ponumber='" & strponumber & "' order by itemname asc " : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Rows.Add(False, rst("trnid").ToString, rst("officeid").ToString, rst("vendorid").ToString, rst("productid").ToString, rst("Particular").ToString, rst("Unit").ToString, rst("Quantity").ToString, rst("Cost").ToString, rst("Total").ToString, rst("originaltotal").ToString, rst("verified").ToString, rst("catid").ToString)
        End While
        rst.Close()

        'msda.Fill(dst, 0)
        'MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "verified", "originaltotal", "officeid", "vendorid", "productid"})
        GridColumnAlignment(MyDataGridView, {"Unit", "Quantity"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)
        MyDataGridView.Columns("Unit").Width = 50
        MyDataGridView.Columns("Quantity").Width = 50
        MyDataGridView.Columns("Cost").Width = 50
        MyDataGridView.Columns("Total").Width = 80

        MyDataGridView.Columns("Particular").ReadOnly = True
        MyDataGridView.Columns("Particular").DefaultCellStyle.BackColor = Color.LemonChiffon
        MyDataGridView.Columns("Unit").ReadOnly = True
        MyDataGridView.Columns("Unit").DefaultCellStyle.BackColor = Color.LemonChiffon
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
                For Each col In MyDataGridView.Columns
                    If col.Name <> "Select" Then
                        MyDataGridView.Rows(i).Cells(col.Name).ReadOnly = True
                    End If
                Next

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

                MyDataGridView("Unit", i).Style.BackColor = Color.LemonChiffon
                MyDataGridView("Unit", i).Style.ForeColor = Color.Black
                MyDataGridView("Unit", i).Style.SelectionBackColor = Color.DodgerBlue
                MyDataGridView("Unit", i).Style.SelectionForeColor = Color.Black

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
            edited = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub myDataGridView_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles MyDataGridView.DataError
        MessageBox.Show("Error inputed value! please enter proper inputs", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ponumber.Text = "" Then
            MessageBox.Show("Please select purchase order number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponumber.Focus()
            Exit Sub

        End If
        Dim ExedeedAmount As Boolean = False
        For i = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                If Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)) <= 0 Then
                    MessageBox.Show("Your purchase order contains invalid quantity!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                If Val(CC(MyDataGridView.Item("Total", i).Value().ToString)) > Val(CC(MyDataGridView.Item("originaltotal", i).Value().ToString)) Then
                    ExedeedAmount = True

                End If
            End If
        Next
        If officeid.Text <> compOfficeid Then
            If MessageBox.Show("You are about to received delivery item from other office purchase order!" & Environment.NewLine & Environment.NewLine & "Note: If you continue this receiving, all item you received will be add to your office inventory! Not the requesting party" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Else
                Exit Sub
            End If
        End If
        Dim VerifiedExceededAmountBy As String = ""
        If ExedeedAmount = True Then
            If Globalallowreceivedexceedingpoamount = True Then
                If MessageBox.Show("You are about to received with exceeded amount po from original approved purchase order amount! " & Environment.NewLine & Environment.NewLine & "Note: transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmPOSAdminConfirmation.ShowDialog(Me)
                    If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                        VerifiedExceededAmountBy = frmPOSAdminConfirmation.userid.Text
                        frmPOSAdminConfirmation.ApprovedConfirmation = False
                        frmPOSAdminConfirmation.Dispose()
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please check your total item cost and must be not exceeded base on original approved total cost", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Are you sure you want to close current purchase order?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If AddAttachmentPackage(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), "delivery_official_receipt", {txtattached1.Text}) = True Then
                For i = 0 To MyDataGridView.RowCount - 1
                    If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                        dst = Nothing : dst = New DataSet
                        msda = New MySqlDataAdapter("Select * from tblpurchaseorderitem where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "' and trnid='" & MyDataGridView.Item("trnid", i).Value().ToString & "'", conn)
                        msda.Fill(dst, 0)
                        For cnt = 0 To dst.Tables(0).Rows.Count - 1
                            With (dst.Tables(0))
                                'If countqry("tblunitconverter", "productid_source = '" & .Rows(cnt)("productid").ToString() & "' and autoconvert=1") > 0 Then
                                '    AutoProductUnitConvertion(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), .Rows(cnt)("productid").ToString(), Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)), Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)))
                                'Else

                                'End If

                                UpdateInventory("Purchase order", DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), compOfficeid, .Rows(cnt)("vendorid").ToString(), "", .Rows(cnt)("productid").ToString(), Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)), Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)), "Purchase Order #" + DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
                                com.CommandText = "update tblpurchaseorderitem set delivered=1, datedelivered=current_timestamp, quantity='" & Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)) & "',cost='" & Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)) & "', total='" & Val(CC(MyDataGridView.Item("Total", i).Value().ToString)) & "' where trnid='" & MyDataGridView.Item("trnid", i).Value().ToString & "'" : com.ExecuteNonQuery()
                            End With
                        Next cnt
                    End If
                Next
                com.CommandText = "DELETE from tblpurchaseorderitem where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "' and delivered=-1" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblpurchaseorder set subtotal='" & Val(CC(txtTotalAmount.Text)) & "', invoiceno='" & txtInvoiceNumber.Text & "', vat='0', charges='0', discount='0',totalamount='" & Val(CC(txtVerifiedAmount.Text)) & "', delivered=1, datedelivered=current_timestamp,receivedby='" & globaluserid & "',verifiedexceededamountby='" & VerifiedExceededAmountBy & "' where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()

                If Val(CC(txtTotalAmount.Text)) > 0 And ckAp.Checked = True Then
                    com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                 + "select 'payable-accounts',vendorid,ponumber,'Purchase Order', note, '" & Val(CC(txtVerifiedAmount.Text)) & "', 0,datetrn,createby,1,'" & globaluserid & "',current_timestamp from tblpurchaseorder where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
                End If

                '#record history
                RecordApprovingHistory("purchase order", qrysingledata("requestref", "requestref", "tblpurchaseorder where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'"), DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), "Received", "PO#" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & " Received delivery purchases")
                ponumber.SelectedIndex = -1 : LoadPurchaseOrder() : FilterDetails("") : txtattached1.Text = "" : edited = False : txtInvoiceNumber.Text = ""
                ckAll.Checked = False
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
        Dim totalAmount As Double = 0
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                totalAmount = totalAmount + MyDataGridView.Item("Total", I).Value
            End If
        Next
        If totalAmount = 0 Then
            MessageBox.Show("Please check atleast one on the item list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                MyDataGridView.Item("verified", I).Value = "not"
                com.CommandText = "update tblpurchaseorderitem set delivered=0 where trnid='" & MyDataGridView.Item("trnid", I).Value & "'" : com.ExecuteNonQuery()
            End If
        Next

        FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
        ReformatGridColor()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim totalAmount As Double = 0
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                totalAmount = totalAmount + MyDataGridView.Item("Total", I).Value
            End If
        Next
        If totalAmount = 0 Then
            MessageBox.Show("Please check atleast one on the item list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                MyDataGridView.Item("verified", I).Value = "not included"
                com.CommandText = "update tblpurchaseorderitem set delivered=-1 where trnid='" & MyDataGridView.Item("trnid", I).Value & "'" : com.ExecuteNonQuery()
            End If
        Next


        FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
        ReformatGridColor()
    End Sub

    Private Sub ReceiveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveItemToolStripMenuItem.Click
        Dim totalAmount As Double = 0
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                totalAmount = totalAmount + MyDataGridView.Item("Total", I).Value
            End If
        Next
        If totalAmount = 0 Then
            MessageBox.Show("Please check atleast one on the item list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                If MyDataGridView.Item("verified", I).Value = "yes" Then
                    MessageBox.Show("Some item was already received!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        If MessageBox.Show("This item will automaticaly add to your current inventory." & Environment.NewLine & Environment.NewLine & "NOTE: This action is no undo function! in order to correct the erroneuos entries, please ask assistance from the procurement department for adjustment!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For I = 0 To MyDataGridView.RowCount - 1
                If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    MyDataGridView.Item("verified", I).Value = "yes"
                    UpdateInventory("Purchase order", DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), compOfficeid, MyDataGridView.Item("vendorid", I).Value, "", MyDataGridView.Item("productid", I).Value, Val(CC(MyDataGridView.Item("Quantity", I).Value)), Val(CC(MyDataGridView.Item("Cost", I).Value)), "Purchase Order #" + DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
                    com.CommandText = "update tblpurchaseorderitem set quantity=" & Val(CC(MyDataGridView.Item("Quantity", I).Value)) & ", cost=" & Val(CC(MyDataGridView.Item("Cost", I).Value)) & ",total=" & Val(CC(MyDataGridView.Item("Total", I).Value)) & ", delivered=1,datedelivered=current_timestamp where trnid='" & MyDataGridView.Item("trnid", I).Value & "'" : com.ExecuteNonQuery()
                End If
            Next
            FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
        End If
    End Sub

    Private Sub Calucator_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalAmount.TextChanged
        txtVerifiedAmount.Text = FormatNumber(Val(CC(txtTotalAmount.Text)), 2)
    End Sub


    Private Sub PartialReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartialReceivedToolStripMenuItem.Click
        frmConsumableSeparationOfQuantity.trnid.Text = Val(CC(MyDataGridView.Item("trnid", MyDataGridView.CurrentCell.RowIndex).Value))
        frmConsumableSeparationOfQuantity.productid.Text = Val(CC(MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value))
        frmConsumableSeparationOfQuantity.txtQuantity.Text = Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value))
        frmConsumableSeparationOfQuantity.txtNewQuantity.Text = Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value))
        frmConsumableSeparationOfQuantity.txtUnitCost.Text = Val(CC(MyDataGridView.Item("Cost", MyDataGridView.CurrentCell.RowIndex).Value))
        frmConsumableSeparationOfQuantity.ponumber.Text = DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue()
        frmConsumableSeparationOfQuantity.ShowDialog(Me)
    End Sub

    Public Sub DivisionOFItem(ByVal productid As String, ByVal originalquantity As Double, ByVal dividedquantity As Double)
        MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value = originalquantity - dividedquantity

        com.CommandText = "Select *, itemname as 'Particular',Unit, " _
                                   + " QUANTITY as 'Quantity',Cost, Total, total as originaltotal, case when delivered=1 then 'yes' when delivered=0 then 'not' else 'not included' end as 'verified' " _
                                   + " from tblpurchaseorderitem " _
                                   + " where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "' and productid='" & productid & "' and quantity='" & dividedquantity & "' and datetrn=current_timestamp" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Rows.Add(False, rst("trnid").ToString, rst("officeid").ToString, rst("vendorid").ToString, rst("productid").ToString, rst("Particular").ToString, rst("Unit").ToString, rst("Quantity").ToString, rst("Cost").ToString, rst("Total").ToString, rst("originaltotal").ToString, rst("verified").ToString, rst("catid").ToString)
        End While
        rst.Close()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
    End Sub

    Private Sub cmdChangeItem_Click(sender As Object, e As EventArgs) Handles cmdChangeItem.Click
        If MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value().ToString = "yes" Then
            MessageBox.Show("Changing item already recieved are not allowed!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmChangeItem.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentCell.RowIndex).Value
        frmChangeItem.ponumber.Text = DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue()
        If frmChangeItem.Visible = True Then
            frmChangeItem.Focus()
        Else
            frmChangeItem.Show(Me)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If ponumber.Text = "" Then
            MessageBox.Show("Please select purchase order number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponumber.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to cancel this purchase order?." & Environment.NewLine & Environment.NewLine & "NOTE: This action is no undo function! in order to correct the erroneuos entries, please ask assistance from the procurement department for adjustment!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblpurchaseorder set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where ponumber='" & DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
            LoadPurchaseOrder()
            MessageBox.Show("Purchase order successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdChangeSupplier_Click(sender As Object, e As EventArgs) Handles cmdChangeSupplier.Click
        If ponumber.Text = "" Then
            MessageBox.Show("Please select purchase order number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponumber.Focus()
            Exit Sub
        End If
        frmChangeSupplier.ponumber.Text = DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue()
        frmChangeSupplier.ShowDialog(Me)
    End Sub

    Private Sub CreateReceivingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateReceivingReportToolStripMenuItem.Click
        Dim totalAmount As Double = 0
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                totalAmount = totalAmount + MyDataGridView.Item("Total", I).Value
            End If
        Next
        If totalAmount = 0 Then
            MessageBox.Show("Please check atleast one on the item list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRRReport.ponumber.Text = DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue()
        frmRRReport.txtTotalSelectedAmount.Text = FormatNumber(totalAmount, 2)
        frmRRReport.Show(Me)
    End Sub

    Public Sub UpdateRR(ByVal rrnumber As String, ByVal requestref As String, ByVal ponumbr As String, ByVal officeid As String, ByVal vendorid As String, ByVal DirectIssuance As Boolean, ByVal transmittalbatchcode As String, ByVal note As String)
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                MyDataGridView.Item("verified", I).Value = "yes"
                com.CommandText = "insert into tblreceivedreportitem set requestref='" & requestref & "',ponumber='" & ponumbr & "',rrnumber='" & rrnumber & "', officeid='" & officeid & "', vendorid='" & vendorid & "', productid='" & MyDataGridView.Item("productid", I).Value & "', itemname='" & rchar(MyDataGridView.Item("Particular", I).Value) & "', catid='" & rchar(MyDataGridView.Item("catid", I).Value) & "', quantity=" & Val(CC(rchar(MyDataGridView.Item("Quantity", I).Value))) & ",unit='" & rchar(MyDataGridView.Item("Unit", I).Value) & "',cost='" & Val(CC(rchar(MyDataGridView.Item("Cost", I).Value))) & "',total='" & Val(CC(rchar(MyDataGridView.Item("Total", I).Value))) & "',trnby='" & globaluserid & "', datetrn=current_timestamp,delivered=1,datedelivered=current_timestamp" : com.ExecuteNonQuery()
                com.CommandText = "update tblpurchaseorderitem set quantity=" & Val(CC(MyDataGridView.Item("Quantity", I).Value)) & ", cost=" & Val(CC(MyDataGridView.Item("Cost", I).Value)) & ",total=" & Val(CC(MyDataGridView.Item("Total", I).Value)) & ", delivered=1,datedelivered=current_timestamp where trnid='" & MyDataGridView.Item("trnid", I).Value & "'" : com.ExecuteNonQuery()
            End If
        Next
        If DirectIssuance = True Then
            DirectStockIssuance(requestref, transmittalbatchcode, note, officeid)
        Else
            For I = 0 To MyDataGridView.RowCount - 1
                If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    UpdateInventory("Purchase order", DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), compOfficeid, MyDataGridView.Item("vendorid", I).Value, "", MyDataGridView.Item("productid", I).Value, Val(CC(MyDataGridView.Item("Quantity", I).Value)), Val(CC(MyDataGridView.Item("Cost", I).Value)), "Purchase Order #" + DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
                End If
            Next
            FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
            frmRRReport.Close()
            MessageBox.Show("Receiving Report successfull updated! " & Environment.NewLine & Environment.NewLine _
                      & "Report Number#: " & rrnumber & Environment.NewLine _
                      & "Date/time Updated: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                      & "Please check your receiving of good inventory transfer regulary to monitor your request!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Public Sub DirectStockIssuance(ByVal reqreference As String, ByVal batchcode As String, ByVal note As String, ByVal officeid As String)
        While MainForm.BackgroundWorker1.IsBusy()
            Windows.Forms.Application.DoEvents()
        End While

        Dim requestid As String = "" : Dim requestName As String = "" : Dim officename As String = ""
        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblrequisitions.requestby) as requestbyname,(select officename from tblcompoffice where officeid='" & officeid & "') as office from tblrequisitions where pid='" & reqreference & "'" : rst = com.ExecuteReader
        While rst.Read
            requestid = rst("requestby").ToString
            requestName = rst("requestbyname").ToString
            officename = rst("office").ToString
        End While
        rst.Close()
        com.CommandText = "insert into tbltransferbatch set batchcode='" & batchcode & "', " _
                            + " inventory_from='" & compOfficeid & "', " _
                            + " inventory_to='" & officeid & "', " _
                            + " note='" & rchar(note) & "', " _
                            + " requestby='" & requestid & "', " _
                            + " datetransfer=current_timestamp, " _
                            + " trnby='" & globaluserid & "', " _
                            + " confirmed=1, " _
                            + " confirmedby='" & globaluserid & "', " _
                            + " dateconfirmed=current_timestamp" : com.ExecuteNonQuery()

        For cnts = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(cnts).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                com.CommandText = "insert into tbltransferitem set  " _
                                     + " batchcode='" & batchcode & "', " _
                                     + " refcode='', " _
                                     + " itemid='" & MyDataGridView.Item("productid", cnts).Value & "', " _
                                     + " quantity='" & Val(CC(MyDataGridView.Item("Quantity", cnts).Value)) & "', " _
                                     + " unitcost='" & Val(CC(MyDataGridView.Item("Cost", cnts).Value)) & "', " _
                                     + " remarks='', " _
                                     + " trnby='" & globaluserid & "', " _
                                     + " datetrn=current_timestamp;" : com.ExecuteNonQuery()

                UpdateInventory("Direct Issuance", DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue(), officeid, MyDataGridView.Item("vendorid", cnts).Value, "", MyDataGridView.Item("productid", cnts).Value, Val(CC(MyDataGridView.Item("Quantity", cnts).Value)), Val(CC(MyDataGridView.Item("Cost", cnts).Value)), "Purchase Order #" + DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
            End If
        Next

        Me.Cursor = Cursors.Default
        If globalEnablePosPrinter = True Then
            PrintTransmittal(note, batchcode, officename, requestName, CDate(Now).ToString)
        End If
        FilterDetails(DirectCast(ponumber.SelectedItem, ComboBoxItem).HiddenValue())
        frmRRReport.Close()
        MessageBox.Show("Your request was successfully sent! " & Environment.NewLine & Environment.NewLine _
                        & "Batch No#: " & batchcode & Environment.NewLine _
                        & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                        & "Please check your receiving of good inventory transfer regulary to monitor your request!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        For I = 0 To MyDataGridView.RowCount - 1
            If MyDataGridView.Item("verified", I).Value = "not" Or MyDataGridView.Item("verified", I).Value = "not included" Then
                If ckAll.Checked = True Then
                    MyDataGridView.Item("Select", I).Value = 1
                Else
                    MyDataGridView.Item("Select", I).Value = 0
                End If
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSearchPurchaseOrder.ckConsumable.Checked = True
        frmSearchPurchaseOrder.Show(Me)
    End Sub

    Private Sub ponumber_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ponumber.SelectedIndexChanged

    End Sub
End Class