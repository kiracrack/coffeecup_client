Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmTransferProcessing
    ' The class that will do the printing process.
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        tabColumnOption()
        If globalBranchApprover = True Then
            cmdCancel.Visible = True
        Else
            cmdCancel.Visible = False
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is xtabPending Then
            txtfrmdate.Enabled = False : txttodate.Enabled = False : ckasof.Checked = False : ckasof.Enabled = False
        Else
            txttodate.Enabled = True : ckasof.Enabled = True
            If ckasof.Checked = True Then
                txtfrmdate.Enabled = False
            Else
                txtfrmdate.Enabled = True
            End If

        End If
        tabColumnOption()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            tabColumnOption()
        End If
    End Sub

    Public Sub tabColumnOption()
        If XtraTabControl1.SelectedTabPage Is xtabPending Then
            cmdCancel.Visible = True : RePrintTransmittalToolStripMenuItem.Visible = True
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary(" DATEDIFF(current_date,datetransfer) as 'Day(s) Count'   from tbltransferbatch where confirmed=0 and cancelled=0 and inventory_from='" & compOfficeid & "' ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabConfirm Then
            cmdCancel.Visible = False : RePrintTransmittalToolStripMenuItem.Visible = True
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary("  DATEDIFF(dateconfirmed,datetransfer) as 'Day(s) Confirmed',(select fullname from tblaccounts where accountid = tbltransferbatch.confirmedby) as 'Confirmed By', date_format(dateconfirmed, '%Y-%m-%d %r') as 'Date Confirmed'   from tbltransferbatch where confirmed=1 and cancelled=0 and inventory_from='" & compOfficeid & "' ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabCancelled Then
            cmdCancel.Visible = False : RePrintTransmittalToolStripMenuItem.Visible = False
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary(" DATEDIFF(dateconfirmed,datecancelled) as 'Day(s) Cancelled',(select fullname from tblaccounts where accountid = tbltransferbatch.cancelledby) as 'Cancelled By', date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled'  from tbltransferbatch where cancelled=1 and inventory_from='" & compOfficeid & "' ")
        End If
    End Sub

    Public Sub ViewTransmitalSummary(ByVal query As String)
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            Dim filterasof As String = ""
            If ckasof.Checked = True Then
                filterasof = " and date_format(datetransfer,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
            Else
                filterasof = " and date_format(datetransfer,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
            End If

            dst2.EnforceConstraints = False : dst2.Relations.Clear() : dst2.Clear()
            LoadXgrid("Select batchcode,batchcode as 'Batch Code', (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) as 'Transfer To', source_rr as RR, " _
                          + " (select sum(quantity) from tbltransferitem where batchcode=tbltransferbatch.batchcode) as 'Total Item', " _
                          + If(XtraTabControl1.SelectedTabPage Is xtabPending, " if(source_rr=1,false,if((select ifnull(sum(credit),0) from tblinventoryledger where referenceno=tbltransferbatch.batchcode  and (trntype='Transfer stock' or trntype='Direct Issuance (RR)' or trntype='Transfer cancelled'))=0,true,false)) ", _
                                " if(source_rr=1,false,(select sum(debit)-sum(credit) from tblinventoryledger where referenceno=tbltransferbatch.batchcode and (trntype='Transfer stock' or trntype='Direct Issuance (RR)' or trntype='Transfer cancelled'))) ") & " as descrepancy, " _
                          + " Note, " _
                          + " (select fullname from tblaccounts where accountid = tbltransferbatch.requestby) as 'Request By' , " _
                          + " date_format(datetransfer,'%Y-%m-%d %r')  as 'Date Processed', " _
                          + " (select fullname from tblaccounts where accountid = tbltransferbatch.trnby) as 'Created' , " _
                          + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end ) as 'Status', " & query _
                          + If(txtsearch.Text = "", If(XtraTabControl1.SelectedTabPage Is xtabPending, "", filterasof), "") _
                          + " and (batchcode like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " note like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " (select fullname from tblaccounts where accountid = tbltransferbatch.trnby) like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) like '%" & rchar(txtsearch.Text) & "%')  order by datetransfer desc", "tbltransferbatch", Em, GridView1)
            msda.SelectCommand.CommandTimeout = 6000000
            msda.Fill(dst2, "tbltransferbatch")
            XgridHideColumn({"trnid", "descrepancy", "batchcode", "inventory_from"}, GridView1)
            XgridColAlign({"Batch Code", "RR", "Total Item", "Date Request", "Status", "descrepancy", "Day(s) Count", "Day(s) Confirmed", "Day(s) Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

            msda = New MySqlDataAdapter("Select batchcode, trnid,refcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Particular', " _
                                           + " Quantity, Unit, unitcost as 'Unit Cost', " _
                                           + " unitcost * Quantity  as 'Total'," _
                                           + " Remarks " _
                                           + " from tbltransferitem where batchcode in (select batchcode from tbltransferbatch where cancelled=0 and inventory_from='" & compOfficeid & "')" _
                                           + " order by datetrn asc", conn)
            msda.Fill(dst2, "tbltransferitem")

            BandgridView = New GridView(Em)
            Dim keyColumn As DataColumn = dst2.Tables("tbltransferbatch").Columns("batchcode")
            Dim foreignKeyColumn2 As DataColumn = dst2.Tables("tbltransferitem").Columns("batchcode")

            dst2.Relations.Add("TransmittalDetails", keyColumn, foreignKeyColumn2)
            Em.LevelTree.Nodes.Add("TransmittalDetails", BandgridView)

            Em.DataSource = dst2.Tables("tbltransferbatch")

            '############## Band Gridview #####################
            BandgridView.PopulateColumns(dst2.Tables("tbltransferitem"))


            DXBandGridFormat(BandgridView)
            XgridHideColumn({"trnid", "batchcode", "refcode"}, BandgridView)
            XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total"}, 3, BandgridView)
            XgridColAlign({"Quantity", "Unit"}, BandgridView, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Quantity", "Total"}, BandgridView)
            XgridColWidth({"Particular"}, BandgridView, 300)
            BandgridView.BestFitColumns()

            DXColumnViewSettings(Me.Name & XtraTabControl1.SelectedTabPage.Name, GridView1)
            SaveFilterColumn(GridView1, Me.Text & XtraTabControl1.SelectedTabPage.Name)
            XgridHideColumn({"trnid", "descrepancy", "batchcode", "inventory_from"}, GridView1)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
        End Try
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name & XtraTabControl1.SelectedTabPage.Name, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name & XtraTabControl1.SelectedTabPage.Name, GridView1)
    End Sub


    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If View.GetRowCellDisplayText(e.RowHandle, View.Columns("descrepancy")).ToString <> "" Then
            Dim descrepancy As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("descrepancy")))
            If e.Column.Name = "colTotalItem" Then
                If descrepancy = True Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.BackColor2 = Color.Red
                    e.Appearance.ForeColor = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabColumnOption()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        On Error Resume Next
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text & XtraTabControl1.SelectedTabPage.Name)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXPrintDatagridview(Me.Text, XtraTabControl1.SelectedTabPage.Text, If(XtraTabControl1.SelectedTabPage Is xtabPending, "", If(ckasof.Checked = True, "Date filter as of " & txttodate.Text, "Date period from " & txtfrmdate.Text & " to " & txttodate.Text)), GridView1, Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If XtraTabControl1.SelectedTabPage Is xtabPending Then
            If CBool(GridView1.GetFocusedRowCellValue("RR").ToString) = True Then
                frmTransferProcessingItem.Batchcode.Text = GridView1.GetFocusedRowCellValue("Batch Code").ToString
                frmTransferProcessingItem.Show(Me)
            Else
                frmTransferProcessingDescripancyItem_temp.Batchcode.Text = GridView1.GetFocusedRowCellValue("Batch Code").ToString
                frmTransferProcessingDescripancyItem_temp.Show(Me)
            End If
        Else
            frmTransferProcessingDescripancyItem_temp.Batchcode.Text = GridView1.GetFocusedRowCellValue("Batch Code").ToString
            frmTransferProcessingDescripancyItem_temp.Show(Me)
        End If
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        tabColumnOption()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        frmManualInventory.Show(Me)
    End Sub

    Private Sub RemoveFromInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to continue cancel this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CancelTransfer(GridView1.GetFocusedRowCellValue("Batch Code").ToString)
            tabColumnOption()
            MessageBox.Show("Request successfully cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub cmdUnitConverter_Click(sender As Object, e As EventArgs)
        frmUnitConverter.Show(Me)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        frmTransferDirectNewInventory.Show(Me)
    End Sub

    Private Sub RePrintTransmittalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RePrintTransmittalToolStripMenuItem.Click
        PrintTransmittal(True, GridView1.GetFocusedRowCellValue("Note").ToString, GridView1.GetFocusedRowCellValue("Batch Code").ToString, GridView1.GetFocusedRowCellValue("Transfer To").ToString, GridView1.GetFocusedRowCellValue("Request By").ToString, CDate(Now).ToString)
    End Sub
End Class