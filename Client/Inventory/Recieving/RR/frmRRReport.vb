Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRRReport
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRRReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtRRDate.Value = CDate(Now).ToShortDateString
        loadVendor()
        LoadToComboBoxDB("select *,concat(rrnumber, ' - ',date_format(datereceived,'%Y-%m-%d'),' - ',(select companyname from tblglobalvendor where vendorid=tblreceivedreport.vendorid)) as details from tblreceivedreport order by rrnumber desc", "details", "rrnumber", txtExistingRR)
        LoadToComboBoxDB("select * from tblcompoffice order by officename asc", "officename", "officeid", txtOffice)
        LoadToComboBoxDB("select * from tblcompoffice order by officename asc", "officename", "officeid", txtIssueTo)
        com.CommandText = "select *, ifnull((select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid ),'DELETED SUPPLIER') as supplier,(select officename from tblcompoffice where officeid=tblpurchaseorder.officeid) as office from tblpurchaseorder where ponumber='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            refnumber.Text = rst("requestref").ToString
            txtvendor.Text = rst("supplier").ToString
            vendorid.Text = rst("vendorid").ToString
            officeid.Text = rst("officeid").ToString
            txtOffice.Text = rst("office").ToString
        End While
        rst.Close()
        LoadTemporaryItem()
    End Sub

    Public Sub LoadTemporaryItem()
        Try
            LoadXgrid("Select requestref,ponumber,trnid,vendorid,productid,catid, itemname as 'Particular', Unit, Quantity,  Cost as 'Unit Cost', cost*quantity as 'Total Cost', ponumber as 'PO Number', date_format(datepurchased,'%Y-%m-%d') as 'Date Purchased', (select companyname from tblglobalvendor where vendorid=tblpurchaseorderitem.vendorid) as 'Supplier' from tblpurchaseorderitem where trnid in (select trnid from tmpreceivingreport)", "tbltransferitem", Em, Gridview1)
            XgridHideColumn({"trnid", "requestref", "ponumber", "vendorid", "productid", "catid"}, Gridview1)
            XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total Cost"}, 3, Gridview1)
            XgridColAlign({"Quantity", "Unit", "PO Number", "Date Purchased"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Quantity", "Total Cost"}, Gridview1)
            txtTotalSelectedAmount.Text = FormatNumber(Gridview1.Columns("Total Cost").SummaryText, 3)
            For Each col In Gridview1.Columns
                col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                XgridDisableColumn({col.ToString}, Gridview1)
            Next
            XgridEnableColumn({"Quantity", "Unit Cost"}, Gridview1)
            Gridview1.Appearance.HeaderPanel.Font = New Font("Segoe UI", 9.0!)
            Gridview1.Appearance.Row.Font = New Font("Segoe UI", 9.0!)
            Gridview1.Appearance.FooterPanel.Font = New Font("Segoe UI", 9.0!)
            Gridview1.Appearance.GroupFooter.Font = New Font("Segoe UI", 9.0!)
            Gridview1.UserCellPadding = New Padding(2)
            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & Gridview1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Gridview1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    Gridview1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Gridview1_Click(sender As Object, e As EventArgs) Handles Gridview1.Click
        txtTotalSelectedAmount.Text = FormatNumber(Gridview1.Columns("Total Cost").SummaryText, 3)
    End Sub
     
    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles Gridview1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, Gridview1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles Gridview1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, Gridview1)
    End Sub

    Public Sub UpdateRR(ByVal rrnumber As String, ByVal requestref As String, ByVal officeid As String, ByVal vendorid As String, ByVal issueto As String, ByVal note As String)
        ProgressBarControl1.Visible = True
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = Gridview1.RowCount - 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        For I = 0 To Gridview1.RowCount - 1
            com.CommandText = "insert into tblreceivedreportitem set requestref='" & Gridview1.GetRowCellValue(I, "requestref").ToString & "',ponumber='" & Gridview1.GetRowCellValue(I, "ponumber").ToString & "',potrnid='" & Gridview1.GetRowCellValue(I, "trnid").ToString & "', rrnumber='" & rrnumber & "', officeid='" & officeid & "', vendorid='" & Gridview1.GetRowCellValue(I, "vendorid").ToString & "', productid='" & Gridview1.GetRowCellValue(I, "productid").ToString & "', itemname='" & rchar(Gridview1.GetRowCellValue(I, "Particular").ToString) & "', catid='" & rchar(Gridview1.GetRowCellValue(I, "catid").ToString) & "', quantity=" & Val(CC(Gridview1.GetRowCellValue(I, "Quantity").ToString)) & ",unit='" & rchar(Gridview1.GetRowCellValue(I, "Unit").ToString) & "',cost='" & Val(CC(Gridview1.GetRowCellValue(I, "Unit Cost").ToString)) & "',total='" & Val(CC(Gridview1.GetRowCellValue(I, "Total Cost").ToString)) & "',trnby='" & globaluserid & "', datetrn=current_timestamp,datepurchased=" & If(Gridview1.GetRowCellValue(I, "Date Purchased").ToString = "", "current_timestamp", "'" & ConvertDate(Gridview1.GetRowCellValue(I, "Date Purchased").ToString) & "'") & ",delivered=1,datedelivered=current_timestamp" : com.ExecuteNonQuery()
            com.CommandText = "update tblpurchaseorderitem set quantity=" & Val(CC(Gridview1.GetRowCellValue(I, "Quantity").ToString)) & ", cost=" & Val(CC(Gridview1.GetRowCellValue(I, "Unit Cost").ToString)) & ",total=" & Val(CC(Gridview1.GetRowCellValue(I, "Total Cost").ToString)) & ", delivered=1,datedelivered=current_timestamp where trnid='" & Gridview1.GetRowCellValue(I, "trnid").ToString & "'" : com.ExecuteNonQuery()
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        ProgressBarControl1.Update()
        ProgressBarControl1.Refresh()
        ProgressBarControl1.Visible = False


        Dim Batchcode As String = getStockTransferSequenceNo()
        DirectStockIssuance(Batchcode, rrnumber, requestref, note, issueto)
        com.CommandText = "update tblreceivedreport set issuedreference='" & Batchcode & "' where rrnumber='" & rrnumber & "' " : com.ExecuteNonQuery()
    End Sub
    Public Sub DirectStockIssuance(ByVal Batchcode As String, ByVal rrnumber As String, ByVal reqreference As String, ByVal note As String, ByVal officeid As String)
        While MainForm.BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While

        Dim requestid As String = "" : Dim requestName As String = "" : Dim officename As String = ""
        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblrequisitions.requestby) as requestbyname,(select officename from tblcompoffice where officeid='" & officeid & "') as office from tblrequisitions where pid='" & reqreference & "'" : rst = com.ExecuteReader
        While rst.Read
            requestid = rst("requestby").ToString
            requestName = rst("requestbyname").ToString
            officename = rst("office").ToString
        End While
        rst.Close()
        com.CommandText = "insert into tbltransferbatch set batchcode='" & Batchcode & "', " _
                            + " inventory_from='" & compOfficeid & "', " _
                            + " inventory_to='" & officeid & "', " _
                            + " note='" & rchar(note) & "', " _
                            + " requestby='" & requestid & "', " _
                            + " datetransfer=current_timestamp, " _
                            + " trnby='" & globaluserid & "', " _
                            + " source_rr=1," _
                            + " confirmed=0, " _
                            + " confirmedby='', " _
                            + " dateconfirmed=null" : com.ExecuteNonQuery()

        For I = 0 To Gridview1.RowCount - 1
            com.CommandText = "insert into tbltransferitem set  " _
                                   + " batchcode='" & Batchcode & "', " _
                                   + " refcode='', " _
                                   + " itemid='" & Gridview1.GetRowCellValue(I, "productid").ToString & "', " _
                                   + " quantity='" & Val(CC(Gridview1.GetRowCellValue(I, "Quantity").ToString)) & "', " _
                                   + " unit='" & rchar(Gridview1.GetRowCellValue(I, "Unit").ToString) & "', " _
                                   + " unitcost='" & Val(CC(Gridview1.GetRowCellValue(I, "Unit Cost").ToString)) & "', " _
                                   + " remarks='', " _
                                   + " trnby='" & globaluserid & "', " _
                                   + " datetrn=current_timestamp;" : com.ExecuteNonQuery()
        Next

        Me.Cursor = Cursors.Default
        If globalEnablePosPrinter = True Then
            PrintTransmittal(False, note, Batchcode, officename, requestName, CDate(Now).ToString)
        End If
        com.CommandText = "delete from tmpreceivingreport" : com.ExecuteNonQuery()
        frmReceivedConsumable.FilterDetails(ponumber.Text)
        MessageBox.Show("Transmittal was successfully sent! " & Environment.NewLine & Environment.NewLine _
                        & "RR Number#: " & rrnumber & Environment.NewLine _
                        & "Transmittal No#: " & Batchcode & Environment.NewLine _
                        & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                        & "Please check your receiving of good inventory transfer regulary to monitor your request!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        For I = 0 To Gridview1.SelectedRowsCount - 1
            com.CommandText = "delete from tmpreceivingreport where trnid='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
        Next
        LoadTemporaryItem()
    End Sub

    Public Sub loadVendor()
        LoadToComboBoxDB("select * from tblglobalvendor order by companyname asc", "companyname", "vendorid", txtvendor)
    End Sub

    Private Sub txtvendor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtvendor.SelectedValueChanged
        If txtvendor.Text <> "" Then
            vendorid.Text = DirectCast(txtvendor.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            vendorid.Text = ""
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        txtTotalSelectedAmount.Text = FormatNumber(Gridview1.Columns("Total Cost").SummaryText, 3)
        If ckAddtoExisting.Checked = True And txtExistingRR.Text = "" Then
            MessageBox.Show("Please select existing RR Number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtExistingRR.Focus()
            Exit Sub
        ElseIf txtInvoiceNumber.Text = "" Then
            MessageBox.Show("Please enter delivery/invoice receipt number!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInvoiceNumber.Focus()
            Exit Sub
        ElseIf txtIssueTo.Text = "" Then
            MessageBox.Show("Please select issue to!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtIssueTo.Focus()
            Exit Sub
        ElseIf radPayOption.SelectedIndex = -1 Then
            MessageBox.Show("Please select pay type transaction!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            radPayOption.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            If ckAddtoExisting.Checked = True Then
                com.CommandText = "UPDATE tblreceivedreport set requestref='" & refnumber.Text & "', ponumber='" & ponumber.Text & "', vendorid='" & vendorid.Text & "', invoiceno='" & txtInvoiceNumber.Text & "', officeid='" & officeid.Text & "', totalamount='" & Val(CC(txtTotalSelectedAmount.Text)) + Val(CC(txtOldRRAmount.Text)) & "',vatablesales='" & Val(CC(txtVatableSales.Text)) & "',totalvat='" & Val(CC(txtTotalVat.Text)) & "',cash=" & radPayOption.EditValue & ", directissue=1, issuedto='" & issueto.Text & "', note='" & rchar(txtNote.Text) & "', datereceived=concat('" & ConvertDate(txtRRDate.Value) & "',' ',current_time), receivedby='" & globaluserid & "' where rrnumber='" & txtOldRRnumber.Text & "'" : com.ExecuteNonQuery()
                UpdateRR(txtOldRRnumber.Text, refnumber.Text, officeid.Text, vendorid.Text, issueto.Text, txtNote.Text)
            Else
                Dim newRRnumber = GetRRNumber()
                com.CommandText = "insert into tblreceivedreport set rrnumber='" & newRRnumber & "', requestref='" & refnumber.Text & "', ponumber='" & ponumber.Text & "', vendorid='" & vendorid.Text & "', invoiceno='" & txtInvoiceNumber.Text & "', officeid='" & officeid.Text & "', totalamount='" & Val(CC(txtTotalSelectedAmount.Text)) & "',vatablesales='" & Val(CC(txtVatableSales.Text)) & "',totalvat='" & Val(CC(txtTotalVat.Text)) & "',cash=" & radPayOption.EditValue & ", directissue=1, issuedto='" & issueto.Text & "', note='" & rchar(txtNote.Text) & "', datereceived=concat('" & ConvertDate(txtRRDate.Value) & "',' ',current_time),receivedby='" & globaluserid & "'" : com.ExecuteNonQuery()
                UpdateRR(newRRnumber, refnumber.Text, officeid.Text, vendorid.Text, issueto.Text, txtNote.Text)
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSupplierRegistration.ShowDialog(Me)
    End Sub


    Private Sub ckAddtoExisting_CheckedChanged(sender As Object, e As EventArgs) Handles ckAddtoExisting.CheckedChanged
        If ckAddtoExisting.Checked = True Then
            txtExistingRR.Enabled = True
            grpNew.Enabled = False
            txtRRNumber.Text = ""
        Else
            txtExistingRR.Enabled = False
            txtExistingRR.SelectedIndex = -1
            grpNew.Enabled = True
            txtRRNumber.Text = "SYSTEM GENERATED"
        End If
    End Sub
 
    Private Sub txtIssueTo_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtIssueTo.SelectedValueChanged
        If txtIssueTo.Text <> "" Then
            issueto.Text = DirectCast(txtIssueTo.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            issueto.Text = ""
        End If
    End Sub

    Private Sub txtOffice_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOffice.SelectedValueChanged
        If txtOffice.Text <> "" Then
            officeid.Text = DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            officeid.Text = ""
        End If
    End Sub

    Private Sub txtExistingRR_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtExistingRR.SelectedValueChanged
        If txtExistingRR.Text <> "" Then
            txtOldRRnumber.Text = DirectCast(txtExistingRR.SelectedItem, ComboBoxItem).HiddenValue()
            txtRRNumber.Text = txtOldRRnumber.Text
            txtOldRRAmount.Text = qrysingledata("totalamount", "totalamount", "tblreceivedreport where rrnumber='" & txtOldRRnumber.Text & "'")
            txtInvoiceNumber.Text = qrysingledata("invoiceno", "invoiceno", "tblreceivedreport where rrnumber='" & txtOldRRnumber.Text & "'")
        Else
            txtOldRRnumber.Text = ""
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadTemporaryItem()
    End Sub

    Private Sub ChangeSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSupplierToolStripMenuItem.Click
        frmChangeRRSupplier.Show(Me)
    End Sub
    Public Sub ChangeSupplier(ByVal vendorid As String, ByVal datepurchased As String)
        For I = 0 To Gridview1.SelectedRowsCount - 1
            com.CommandText = "update tblpurchaseorderitem set vendorid='" & vendorid & "',datepurchased='" & datepurchased & "' where trnid='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
        Next
        LoadTemporaryItem()
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colQuantity" Or e.Column.Name = "colUnitCost" Then
            e.Appearance.BackColor = Color.Yellow
            e.Appearance.ForeColor = Color.Black

        End If
    End Sub


    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gridview1.CellValueChanged
        If e.Column.FieldName = "Quantity" Or e.Column.FieldName = "Unit Cost" Then
            Dim quantity As Double = Val(CC(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("Quantity")).ToString()))
            Dim unitcost As Double = Val(CC(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("Unit Cost")).ToString()))
            Dim TotalCost As Double = unitcost * quantity
            Gridview1.SetRowCellValue(e.RowHandle, Gridview1.Columns("Total Cost"), TotalCost)
            com.CommandText = "update tblpurchaseorderitem set quantity='" & quantity & "', cost='" & unitcost & "',total='" & TotalCost & "' where trnid='" & Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("trnid")).ToString() & "'" : com.ExecuteNonQuery()
            txtTotalSelectedAmount.Text = FormatNumber(Gridview1.Columns("Total Cost").SummaryText, 3)
        End If
    End Sub

    Private Sub txtTotalSelectedAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTotalSelectedAmount.TextChanged
        COmputeVate()
    End Sub

    Private Sub ckVatable_CheckedChanged(sender As Object, e As EventArgs) Handles ckVatable.CheckedChanged
        COmputeVate()
    End Sub
    Public Sub COmputeVate()
        If ckVatable.Checked = True Then
            txtVatableSales.Text = FormatNumber(Val(CC(txtTotalSelectedAmount.Text)) / 1.12, 2)
            txtTotalVat.Text = FormatNumber(Val(CC(txtVatableSales.Text)) * 0.12, 2)
        Else
            txtVatableSales.Text = "0.00"
            txtTotalVat.Text = "0.00"
        End If
    End Sub
     
End Class