Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils

Public Class frmReceivingReport
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F1 Then

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmReceivingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadInventoryTo()
        txtfrmdate.EditValue = CDate(Now)
        txttodate.EditValue = CDate(Now)
        lblOffice.Text = "Select Office"
        filter()
    End Sub
    Public Sub loadInventoryTo()
        LoadXgridLookupSearch("SELECT officeid,officename as 'Select Office' from tblcompoffice order by officename asc", "tblcompoffice", txtInventory, gv_purchaseorder)
        gv_purchaseorder.Columns("officeid").Visible = False
    End Sub
    Private Sub txtStockto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInventory.EditValueChanged
        On Error Resume Next
        officeid.Text = txtInventory.Properties.View.GetFocusedRowCellValue("officeid").ToString()
    End Sub
    Public Sub filter()
        ' On Error Resume Next

        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datereceived,'%Y-%m-%d') <= '" & ConvertDate(CDate(Now)) & "' "
        Else
            filterasof = " and date_format(datereceived,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select * from (select datereceived,officeid, rrnumber as 'RR Number', (select group_concat(distinct requestref SEPARATOR '\n') from tblreceivedreportitem where rrnumber=tblreceivedreport.rrnumber) as 'Requisition No.', ponumber as 'PO Number', " _
                  + " (select group_concat(distinct (select companyname from tblglobalvendor where vendorid = tblreceivedreportitem.vendorid) SEPARATOR '\n') from tblreceivedreportitem where rrnumber=tblreceivedreport.rrnumber)  as 'Supplier', " _
                  + " (select officename from tblcompoffice where officeid=tblreceivedreport.officeid) as 'Requesting Office', invoiceno as 'Invoice No.', " _
                  + " totalamount as 'Total Amount',vatablesales as 'Vatable Sales',totalvat as 'Vat', if(cash=1,'CASH','CREDIT') as 'Pay Type',   DirectIssue, (select officename from tblcompoffice where officeid=tblreceivedreport.issuedto) as 'Issued To', " _
                  + " issuedreference as 'Issued Reference', Note, (select fullname from tblaccounts where accountid=tblreceivedreport.receivedby) as 'Received by', " _
                  + " date_format(datereceived,'%Y-%m-%d') as 'Date Received' from  tblreceivedreport where officeid in (select officeid from tblcompoffice where companyid='" & GlobalCompanyid & "') " & filterasof & ") as a " _
                            + If(txtSearch.Text = "", " where officeid in (select officeid from tblcompoffice where companyid='" & GlobalCompanyid & "') " & filterasof, "" _
                            + " where officeid in (select officeid from tblcompoffice where companyid='" & GlobalCompanyid & "') and (`RR Number` like '%" & rchar(txtSearch.Text) & "%' or `Requisition No.` like '%" & rchar(txtSearch.Text) & "%' or `Requesting Office` like '%" & rchar(txtSearch.Text) & "%' or `Invoice No.` like '%" & rchar(txtSearch.Text) & "%' )") & " order by datereceived asc", "tblreceivedreport", Em, GridView1)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblreceivedreport")
        XgridHideColumn({"datereceived", "officeid"}, GridView1)
        XgridColMemo({"Requisition No.", "Supplier", "Issued To", "Note"}, GridView1)
        GridView1.Columns("Requisition No.").AppearanceCell.TextOptions.VAlignment = VertAlignment.Center
        GridView1.Columns("Supplier").AppearanceCell.TextOptions.VAlignment = VertAlignment.Center


        GridView1.Columns("Supplier").ColumnEdit = MemoEdit
        XgridColCurrency({"Total Amount"}, GridView1)
        XgridColAlign({"RR Number", "PO Number", "Requisition No.", "Pay Type", "Invoice No.", "Issued Reference", "Date Received"}, GridView1, HorzAlignment.Center)

        XgridColWidth({"Supplier"}, GridView1, 200)
        XgridColWidth({"Vatable Sales", "Vat", "Total Amount"}, GridView1, 80)
        XgridGeneralSummaryCurrency({"Vatable Sales", "Vat", "Total Amount"}, GridView1)

        msda = New MySqlDataAdapter("select rrnumber as 'RR Number', requestref as 'PR Number', ponumber as 'PO Number', itemname  as 'Product', (select description from tblprocategory where catid = tblreceivedreportitem.catid) as 'Category', Quantity,Unit,cost as 'Unit Cost',Total, date_format(datedelivered,'%Y-%m-%d %r') as 'Date Delivered',(select companyname from tblglobalvendor where vendorid=tblreceivedreportitem.vendorid) as 'Supplier' from tblreceivedreportitem " _
                                    + " where rrnumber in (select rrnumber from tblreceivedreport where officeid in (select officeid from tblcompoffice where companyid='" & GlobalCompanyid & "')  " _
                                    + If(txtSearch.Text = "", filterasof, "" _
                                    + " and (rrnumber like '%" & rchar(txtSearch.Text) & "%' or requestref like '%" & rchar(txtSearch.Text) & "%' or (select officename from tblcompoffice where officeid=tblreceivedreport.officeid) like '%" & rchar(txtSearch.Text) & "%' or invoiceno like '%" & rchar(txtSearch.Text) & "%' )") _
                                    + ")", conn)
        msda.Fill(dst, "tblreceivedreportitem")

        BandgridView = New GridView(Em)
        Dim keyColumn As DataColumn = dst.Tables("tblreceivedreport").Columns("RR Number")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblreceivedreportitem").Columns("RR Number")

        dst.Relations.Add("PurchaseDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("PurchaseDetails", BandgridView)

        Em.DataSource = dst.Tables("tblreceivedreport")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblreceivedreportitem"))
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False
        XgridHideColumn({"RR Number"}, BandgridView)
        XgridColCurrency({"Unit Cost", "Total"}, BandgridView)
        XgridColAlign({"PR Number", "PO Number", "Quantity", "Unit", "Date Delivered"}, BandgridView, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, BandgridView)
        SaveFilterColumn(GridView1, Me.Text)

    End Sub
   
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub


    Private Sub ckasof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
            txttodate.Enabled = False
        Else
            txtfrmdate.Enabled = True
            txttodate.Enabled = True
        End If
    End Sub
    Private Sub ck_inventory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_inventory.CheckedChanged
        If ck_inventory.Checked = True Then
            txtInventory.Enabled = False
            txtInventory.Properties.DataSource = False
            txtInventory.Text = ""
        Else
            loadInventoryTo()
            txtInventory.Enabled = True
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DXPrintDatagridview(Me.Text, "DATABASE RECORD", If(ckasof.Checked = True, "Report as of " & Now.ToString("MMMM dd, yyyy"), "Report From " & txtfrmdate.Text & " to " & txttodate.Text), GridView1, Me)
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        PrintReport(GridView1.GetFocusedRowCellValue("RR Number").ToString)
    End Sub
    Public Sub PrintReport(ByVal rrnumber As String)
        Dim report As New rptReceivedReport()
        report.XrBarCode1.Text = rrnumber

        com.CommandText = "select *, " _
                  + " (select companyname from tblglobalvendor where vendorid = tblreceivedreport.vendorid) as 'Supplier', " _
                  + " (select officename from tblcompoffice where officeid=tblreceivedreport.officeid) as 'RequestingOffice', invoiceno as 'Invoice No.', " _
                  + " totalamount, DirectIssue, (select officename from tblcompoffice where officeid=tblreceivedreport.issuedto) as 'IssuedTo', " _
                  + " Note, (select fullname from tblaccounts where accountid=tblreceivedreport.receivedby) as 'Received by', " _
                  + " date_format(datereceived,'%Y-%m-%d') as 'Date Received' from  tblreceivedreport where rrnumber='" & rrnumber & "'" : rst = com.ExecuteReader
        While rst.Read
            report.txtSupplier.Text = rst("Supplier").ToString
            report.txtRRNumber.Text = rst("rrnumber").ToString
            report.txtTotalAmount.Text = FormatNumber(rst("totalamount").ToString, 2)
            report.txtVatableSales.Text = FormatNumber(rst("vatablesales").ToString, 2)
            report.txtTotalVat.Text = FormatNumber(rst("totalvat").ToString, 2)
            report.txtPayAs.Text = If(CBool(rst("cash")), "Cash Transaction", "Credit Tansaction")
            report.txtNote.Text = rst("note").ToString
            report.txtRequestingOffice.Text = rst("RequestingOffice").ToString
            report.txtDirectIssue.Text = rst("IssuedTo").ToString
            report.rxrRRnumber.Text = rst("issuedreference").ToString
            report.txtRRDate.Text = rst("datereceived").ToString
        End While
        rst.Close()
        LoadXgrid("select SUBSTRING_INDEX(requestref,'-',-1) as 'PR No.', itemname  as 'Product', Quantity,Unit,cost as 'Unit Cost',Total,date_format(datepurchased,'%Y-%m-%d') as 'Purchased', date_format(datedelivered,'%Y-%m-%d') as 'Received',(select companyname from tblglobalvendor where vendorid=tblreceivedreportitem.vendorid) as 'Supplier' from tblreceivedreportitem where rrnumber='" & rrnumber & "'", "tblreceivedreportitem", bm, GridView2)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblreceivedreportitem")

        XgridColCurrency({"Unit Cost", "Total"}, GridView2)
        XgridColAlign({"PR No.", "Quantity", "Unit", "Purchased", "Received"}, GridView2, HorzAlignment.Center)
        XgridColMemo({"Product", "Supplier"}, GridView2)
        GridView2.Columns("Supplier").Width = 150
        XgridGeneralSummaryCurrency({"Total"}, GridView2)
        GridView2.Columns("Total").Width = 100
        report.PaperKind = System.Drawing.Printing.PaperKind.Letter
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(bm))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            filter()
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click
        If countqrybySpecificColumn("tblreceivedreportitem", "distinct requestref", "rrnumber='" & GridView1.GetFocusedRowCellValue("RR Number").ToString() & "'") > 1 Then
            frmReceivingReportPRNo.rrnumber.Text = GridView1.GetFocusedRowCellValue("RR Number").ToString()
            frmReceivingReportPRNo.ShowDialog(Me)
        Else
            frmRequisitionsView.pid.Text = GridView1.GetFocusedRowCellValue("Requisition No.").ToString()
            frmRequisitionsView.Show(Me)
        End If
    End Sub
End Class