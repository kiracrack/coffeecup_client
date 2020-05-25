Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmRecievedTransferConsumable
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

    Private Sub textsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        tabColumnOption()
    End Sub

    Public Sub tabColumnOption()
        If XtraTabControl1.SelectedTabPage Is xtabPending Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            cmdConfirm.Visible = True : cmdCancel.Visible = True
            ViewTransmitalSummary(" DATEDIFF(current_date,datetransfer) as 'Day(s) Count' from tbltransferbatch where confirmed=0 and cancelled=0 and inventory_to='" & compOfficeid & "' ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabConfirm Then
            cmdConfirm.Visible = False : cmdCancel.Visible = False
            Em.Parent = XtraTabControl1.SelectedTabPage

            ViewTransmitalSummary(" DATEDIFF(dateconfirmed,datetransfer) as 'Day(s) Confirmed',(select fullname from tblaccounts where accountid = tbltransferbatch.confirmedby) as 'Confirmed By', date_format(dateconfirmed, '%Y-%m-%d %r') as 'Date Confirmed' from tbltransferbatch where confirmed=1 and cancelled=0 and inventory_to='" & compOfficeid & "' ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabCancelled Then
            cmdConfirm.Visible = False : cmdCancel.Visible = False
            Em.Parent = XtraTabControl1.SelectedTabPage

            ViewTransmitalSummary(" DATEDIFF(datecancelled,datecancelled) as 'Day(s) Cancelled',(select fullname from tblaccounts where accountid = tbltransferbatch.cancelledby) as 'Cancelled By', date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled' from tbltransferbatch where cancelled=1 and inventory_to='" & compOfficeid & "' ")
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
            LoadXgrid("Select trnid,inventory_from, batchcode, batchcode as 'Batch Code', (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) as 'From', " _
                                        + " (select sum(quantity) from tbltransferitem where batchcode=tbltransferbatch.batchcode) as 'Total Item', " _
                                        + " Note, " _
                                        + " (select fullname from tblaccounts where accountid = tbltransferbatch.requestby) as 'Request By' , " _
                                        + " date_format(datetransfer,'%Y-%m-%d %r')  as 'Date Request', " _
                                        + " (select fullname from tblaccounts where accountid = tbltransferbatch.trnby) as 'Created by' , " _
                                        + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end ) as 'Status', " & query _
                                        + " " & If(XtraTabControl1.SelectedTabPage Is xtabPending, "", filterasof) _
                                        + " and (batchcode like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " note like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " (select fullname from tblaccounts where accountid = tbltransferbatch.trnby) like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_from) like '%" & rchar(txtsearch.Text) & "%' or " _
                                        + " (select officename from tblcompoffice where officeid=tbltransferbatch.inventory_to) like '%" & rchar(txtsearch.Text) & "%')  order by datetransfer desc", "tbltransferbatch", Em, GridView1)
            msda.SelectCommand.CommandTimeout = 6000000
            msda.Fill(dst2, "tbltransferbatch")
            XgridHideColumn({"trnid", "batchcode", "inventory_from"}, GridView1)
            XgridColAlign({"Batch Code", "Total Item", "Date Request", "Status", "Day(s) Count", "Day(s) Confirmed", "Day(s) Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)


            msda = New MySqlDataAdapter("Select batchcode, trnid,refcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Particular', " _
                                           + " Quantity, Unit, unitcost as 'Unit Cost', " _
                                           + " unitcost * Quantity  as 'Total'," _
                                           + " Remarks " _
                                           + " from tbltransferitem where batchcode in (select batchcode from tbltransferbatch where cancelled=0 and inventory_to='" & compOfficeid & "')" _
                                           + " order by itemid asc", conn)
            msda.Fill(dst2, "tbltransferitem")

            BandgridView = New GridView(Em)
            Dim keyColumn As DataColumn = dst2.Tables("tbltransferbatch").Columns("batchcode")
            Dim foreignKeyColumn2 As DataColumn = dst2.Tables("tbltransferitem").Columns("batchcode")

            dst2.Relations.Add("TransmittalDetails", keyColumn, foreignKeyColumn2)
            Em.LevelTree.Nodes.Add("TransmittalDetails", BandgridView)

            Em.DataSource = dst2.Tables("tbltransferbatch")

            '############## Band Gridview #####################
            BandgridView.PopulateColumns(dst2.Tables("tbltransferitem"))
            BandgridView.BestFitColumns(True)

            DXBandGridFormat(BandgridView)
            XgridHideColumn({"trnid", "batchcode", "refcode"}, BandgridView)
            XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total"}, 3, BandgridView)
            XgridColAlign({"Quantity", "Unit"}, BandgridView, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Quantity", "Total"}, BandgridView)
            XgridColWidth({"Particular"}, BandgridView, 300)

            DXColumnViewSettings(Me.Name & XtraTabControl1.SelectedTabPage.Name, GridView1)
            SaveFilterColumn(GridView1, Me.Text & XtraTabControl1.SelectedTabPage.Name)
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


    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabColumnOption()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        frmRecievedTransferConsumableitem.Text = "Ref. Number: " & GridView1.GetFocusedRowCellValue("Batch Code").ToString & " from " & GridView1.GetFocusedRowCellValue("From").ToString
        frmRecievedTransferConsumableitem.batchcode.Text = GridView1.GetFocusedRowCellValue("Batch Code").ToString
        frmRecievedTransferConsumableitem.Show(Me)
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If Not XtraTabControl1.SelectedTabPage Is xtabPending Then
            If ckasof.Checked = True Then
                txtfrmdate.Enabled = False
            Else
                txtfrmdate.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        tabColumnOption()
    End Sub

    Private Sub AdjustInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If compInventoryMethod = "" Then
            MessageBox.Show("Your office have not set inventory method, please contact your administrator!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Continue confirm batch transfer inventory?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If countqry("tbltransferbatch", "confirmed=0 and cancelled=0 and inventory_to='" & compOfficeid & "' and batchcode='" & GridView1.GetFocusedRowCellValue("Batch Code").ToString & "'") = 0 Then
                Dim UserConfirm As String = qrysingledata("username", "(select fullname from tblaccounts where accountid=tbltransferbatch.confirmedby) as username", "tbltransferbatch where batchcode='" & GridView1.GetFocusedRowCellValue("Batch Code").ToString & "'")
                MessageBox.Show("This request is already confirmed by " & UserConfirm & "!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If ReceivedTransfer(GridView1.GetFocusedRowCellValue("Batch Code").ToString, False) = True Then
                tabColumnOption()
                MessageBox.Show("Request successfully confirmed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmdView.PerformClick()
            End If
        End If
    End Sub


    Private Sub RemoveFromInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to continue cancel this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            CancelTransfer(GridView1.GetFocusedRowCellValue("Batch Code").ToString)
            tabColumnOption()
            MessageBox.Show("Request successfully cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXPrintDatagridview(Me.Text, XtraTabControl1.SelectedTabPage.Text, If(XtraTabControl1.SelectedTabPage Is xtabPending, "", If(ckasof.Checked = True, "Date filter as of " & txttodate.Text, "Date period from " & txtfrmdate.Text & " to " & txttodate.Text)), GridView1, Me)
    End Sub

    Private Sub cmdColumnChooser_Click(sender As Object, e As EventArgs) Handles cmdColumnChooser.Click
        Dim colname As String = ""
        For I = 0 To GridView1.Columns.Count - 1
            colname += GridView1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(GridView1, Me.Text & XtraTabControl1.SelectedTabPage.Name)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub cmdPrintPreview_Click(sender As Object, e As EventArgs) Handles cmdPrintPreview.Click
        DXExportGridToExcel(Me.Text, GridView1)
    End Sub
End Class