Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmReceivedConsumable
    Dim edited As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            cmdFindPO.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

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

        If ckAssets.Checked = True Then
            Me.Text = "Receive Fixed Assets Stock Delivery"
            cmdReceivingReport.Visible = False
        Else
            Me.Text = "Receive Consumable Stock Delivery"
            'cmdReceivingReport.Visible = True
            If GLobalenablereceivingreport = True Then
                cmdReceivingReport.Visible = True
                cmdReceivedCheckedItems.Visible = False
            Else
                cmdReceivingReport.Visible = False
                cmdReceivedCheckedItems.Visible = True
            End If
        End If

    End Sub


    Public Function ChangeItem(ByVal productid As String, ByVal productname As String, ByVal unit As String)
        MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value = productid
        MyDataGridView.Item("Particular", MyDataGridView.CurrentCell.RowIndex).Value = productname
        MyDataGridView.Item("Unit", MyDataGridView.CurrentCell.RowIndex).Value = unit
    End Function

    Private Sub ponumber_TextChanged(sender As Object, e As EventArgs) Handles ponumber.TextChanged
        LoadPoDetails()
    End Sub
    Public Sub LoadPoDetails()
        If ponumber.Text = "" Then Exit Sub
        com.CommandText = "select *,concat(requestref, ' - ', ifnull((select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid),'DELETED SUPPLIER')) as podetails from tblpurchaseorder where ponumber='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            txtInvoiceNumber.Text = rst("invoiceno").ToString
            txtPurchaseOrderDetails.Text = rst("podetails").ToString
            ckAp.Checked = CBool(rst("ap"))
        End While
        rst.Close()
        FilterDetails(ponumber.Text)
    End Sub
    Public Sub FilterDetails(ByVal strponumber As String)
        MyDataGridView.Rows.Clear()
        com.CommandText = "Select *, itemname as 'Particular',Unit, " _
                                    + " QUANTITY as 'Quantity',Cost, Total, total as originaltotal, case when delivered=1 then 'yes' when delivered=0 then 'not' else 'not included' end as 'verified' " _
                                    + " from tblpurchaseorderitem " _
                                    + " where catid in (select catid from tblprocategory where " & If(ckAssets.Checked = True, "ffe=1", "consumable=1") & ") and ponumber='" & strponumber & "' order by itemname asc " : rst = com.ExecuteReader
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
            'ElseIf qrysingledata("glcodeaccountspayable", "glcodeaccountspayable", "tblgldefaultitem") = "" And enable Then
            '    MessageBox.Show("Default accounts payable account title currently not configured! Please contact your system administrator", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
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
            If AddAttachmentPackage(ponumber.Text, "delivery_official_receipt", {txtattached1.Text}) = True Then
                For i = 0 To MyDataGridView.RowCount - 1
                    If MyDataGridView.Item("verified", i).Value().ToString = "not" Then
                        dst = Nothing : dst = New DataSet
                        msda = New MySqlDataAdapter("Select * from tblpurchaseorderitem where ponumber='" & ponumber.Text & "' and trnid='" & MyDataGridView.Item("trnid", i).Value().ToString & "'", conn)
                        msda.Fill(dst, 0)
                        For cnt = 0 To dst.Tables(0).Rows.Count - 1
                            With (dst.Tables(0))
                                'If countqry("tblunitconverter", "productid_source = '" & .Rows(cnt)("productid").ToString() & "' and autoconvert=1") > 0 Then
                                '    AutoProductUnitConvertion(ponumber.text, .Rows(cnt)("productid").ToString(), Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)), Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)))
                                'Else

                                'End If
                                If ckAssets.Checked = True Then
                                    UpdateFFEInventory("new", "", ponumber.Text, compOfficeid, "", .Rows(cnt)("vendorid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)), Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)), "", True, "", False, Val(CC(MyDataGridView.Item("Total", i).Value)), 0, "", "", "", "", True, "FFE PROFILE NOT COMPLETED", True, Nothing)
                                Else
                                    UpdateInventory("Purchase order", ponumber.Text, compOfficeid, .Rows(cnt)("vendorid").ToString(), "", .Rows(cnt)("productid").ToString(), Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)), Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)), "Purchase Order #" + ponumber.Text, ponumber.Text, "")
                                End If

                                com.CommandText = "update tblpurchaseorderitem set delivered=1, datedelivered=current_timestamp, quantity='" & Val(CC(MyDataGridView.Item("Quantity", i).Value().ToString)) & "',cost='" & Val(CC(MyDataGridView.Item("Cost", i).Value().ToString)) & "', total='" & Val(CC(MyDataGridView.Item("Total", i).Value().ToString)) & "' where trnid='" & MyDataGridView.Item("trnid", i).Value().ToString & "'" : com.ExecuteNonQuery()
                            End With
                        Next cnt
                    End If
                Next
                com.CommandText = "DELETE from tblpurchaseorderitem where ponumber='" & ponumber.Text & "' and delivered=-1" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblpurchaseorder set subtotal='" & Val(CC(txtTotalAmount.Text)) & "', invoiceno='" & txtInvoiceNumber.Text & "', vat='0', charges='0', discount='0',totalamount='" & Val(CC(txtVerifiedAmount.Text)) & "', delivered=1, datedelivered=current_timestamp,receivedby='" & globaluserid & "',verifiedexceededamountby='" & VerifiedExceededAmountBy & "' where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()

                If Val(CC(txtTotalAmount.Text)) > 0 And ckAp.Checked = True Then
                    com.CommandText = "insert into tblglaccountledger (journalmode,accountno,referenceno,itemcode,remarks,debit,credit,datetrn,trnby,cleared,clearedby,datecleared) " _
                                                 + "select 'payable-accounts',vendorid,ponumber,'Purchase Order', note, '" & Val(CC(txtVerifiedAmount.Text)) & "', 0,datetrn,createby,1,'" & globaluserid & "',current_timestamp from tblpurchaseorder where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
                End If
                com.CommandText = "call sp_acct_entries('" & ponumber.Text & "','" & compOfficeid & "', 'RECEIVED_PO_AP','')" : com.ExecuteNonQuery()

                '#record history
                RecordApprovingHistory("purchase order", qrysingledata("requestref", "requestref", "tblpurchaseorder where ponumber='" & ponumber.Text & "'"), ponumber.Text, "Received", "PO#" & ponumber.Text & " Received delivery purchases")
                ponumber.Text = "" : txtPurchaseOrderDetails.Text = "" : FilterDetails("") : txtattached1.Text = "" : edited = False : txtInvoiceNumber.Text = ""
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

        FilterDetails(ponumber.Text)
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


        FilterDetails(ponumber.Text)
        ReformatGridColor()
    End Sub

    Private Sub ReceiveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdReceivedCheckedItems.Click
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
                    If ckAssets.Checked Then
                        UpdateFFEInventory("new", "", ponumber.Text, compOfficeid, "", MyDataGridView.Item("vendorid", MyDataGridView.CurrentCell.RowIndex).Value, MyDataGridView.Item("productid", MyDataGridView.CurrentCell.RowIndex).Value, Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value)), Val(CC(MyDataGridView.Item("Cost", MyDataGridView.CurrentCell.RowIndex).Value)), "", True, "", False, Val(CC(MyDataGridView.Item("Total", MyDataGridView.CurrentCell.RowIndex).Value)), 0, "", "", "", "", True, "FFE PROFILE NOT COMPLETED", True, Nothing)
                    Else
                        UpdateInventory("Purchase order", ponumber.Text, compOfficeid, MyDataGridView.Item("vendorid", I).Value, "", MyDataGridView.Item("productid", I).Value, Val(CC(MyDataGridView.Item("Quantity", I).Value)), Val(CC(MyDataGridView.Item("Cost", I).Value)), "Purchase Order #" + ponumber.Text, ponumber.Text, "")
                    End If
                    com.CommandText = "update tblpurchaseorderitem set quantity=" & Val(CC(MyDataGridView.Item("Quantity", I).Value)) & ", cost=" & Val(CC(MyDataGridView.Item("Cost", I).Value)) & ",total=" & Val(CC(MyDataGridView.Item("Total", I).Value)) & ", delivered=1,datedelivered=current_timestamp where trnid='" & MyDataGridView.Item("trnid", I).Value & "'" : com.ExecuteNonQuery()
                End If
            Next
            FilterDetails(ponumber.Text)
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
        frmConsumableSeparationOfQuantity.ponumber.Text = ponumber.Text
        frmConsumableSeparationOfQuantity.ShowDialog(Me)
    End Sub

    Public Sub DivisionOFItem(ByVal productid As String, ByVal originalquantity As Double, ByVal dividedquantity As Double)
        MyDataGridView.Item("Quantity", MyDataGridView.CurrentCell.RowIndex).Value = originalquantity - dividedquantity

        com.CommandText = "Select *, itemname as 'Particular',Unit, " _
                                   + " QUANTITY as 'Quantity',Cost, Total, total as originaltotal, case when delivered=1 then 'yes' when delivered=0 then 'not' else 'not included' end as 'verified' " _
                                   + " from tblpurchaseorderitem " _
                                   + " where ponumber='" & ponumber.Text & "' and productid='" & productid & "' and quantity='" & dividedquantity & "' and datetrn=current_timestamp" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Rows.Add(False, rst("trnid").ToString, rst("officeid").ToString, rst("vendorid").ToString, rst("productid").ToString, rst("Particular").ToString, rst("Unit").ToString, rst("Quantity").ToString, rst("Cost").ToString, rst("Total").ToString, rst("originaltotal").ToString, rst("verified").ToString, rst("catid").ToString)
        End While
        rst.Close()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterDetails(ponumber.Text)
    End Sub

    Private Sub cmdChangeItem_Click(sender As Object, e As EventArgs) Handles cmdChangeItem.Click
        If MyDataGridView.Item("verified", MyDataGridView.CurrentCell.RowIndex).Value().ToString = "yes" Then
            MessageBox.Show("Changing item already recieved are not allowed!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmChangeItem.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentCell.RowIndex).Value
        frmChangeItem.ponumber.Text = ponumber.Text
        If frmChangeItem.Visible = True Then
            frmChangeItem.Focus()
        Else
            frmChangeItem.Show(Me)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If GlobalOrganization_KB = True Then
            MessageBox.Show("Functions is restricted!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If ponumber.Text = "" Then
            MessageBox.Show("Please select purchase order number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponumber.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to cancel this purchase order?." & Environment.NewLine & Environment.NewLine & "NOTE: This action is no undo function! in order to correct the erroneuos entries, please ask assistance from the procurement department for adjustment!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblpurchaseorder set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            txtPurchaseOrderDetails.Text = "" : ponumber.Text = ""
            MessageBox.Show("Purchase order successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdChangeSupplier_Click(sender As Object, e As EventArgs) Handles cmdChangeSupplier.Click
        If GlobalOrganization_KB = True Then
            MessageBox.Show("Functions is restricted!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If ponumber.Text = "" Then
            MessageBox.Show("Please select purchase order number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponumber.Focus()
            Exit Sub
        End If
        frmChangeSupplier.ponumber.Text = ponumber.Text
        frmChangeSupplier.ShowDialog(Me)
    End Sub

    Private Sub CreateReceivingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdReceivingReport.Click
        com.CommandText = "CREATE TEMPORARY TABLE if not EXISTS tmpreceivingreport (  `trnid` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,  PRIMARY KEY (`trnid`))ENGINE = InnoDB;" : com.ExecuteNonQuery()
        Dim totalAmount As Double = 0
        For I = 0 To MyDataGridView.RowCount - 1
            If DirectCast(MyDataGridView.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                totalAmount = totalAmount + MyDataGridView.Item("Total", I).Value
                If countqry("tmpreceivingreport", "trnid='" & MyDataGridView.Item("trnid", I).Value & "'") = 0 Then
                    com.CommandText = "insert into tmpreceivingreport set trnid='" & MyDataGridView.Item("trnid", I).Value & "'" : com.ExecuteNonQuery()
                End If
            End If
        Next
        If totalAmount = 0 Then
            MessageBox.Show("Please check atleast one on the item list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRRReport.ponumber.Text = ponumber.Text
        'frmRRReport.txtTotalSelectedAmount.Text = FormatNumber(totalAmount, 2)
        If frmRRReport.Visible = True Then
            frmRRReport.LoadTemporaryItem()
            frmRRReport.Focus()
        Else
            frmRRReport.Show(Me)
        End If

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

    Private Sub cmdFindPO_Click(sender As Object, e As EventArgs) Handles cmdFindPO.Click
        frmFindPurchaseOrder.ckAssets.Checked = ckAssets.CheckState
        frmFindPurchaseOrder.ShowDialog(Me)
    End Sub


End Class