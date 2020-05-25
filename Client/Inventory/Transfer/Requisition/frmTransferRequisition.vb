Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmTransferRequisition
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
        If countqry("tbltransferrequest", "confirmed=0 and cancelled=0 and inventory_from='" & compOfficeid & "'") > 0 Then
            XtraTabControl1.SelectedTabPage = xtabIncoming
        End If
        If globalBranchApprover = True Then
            cmdCancel.Visible = True
        Else
            cmdCancel.Visible = False
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is xtabOutGoing Or XtraTabControl1.SelectedTabPage Is xtabIncoming Then
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
        If XtraTabControl1.SelectedTabPage Is xtabOutGoing Then
            cmdCancel.Visible = True
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary(" DATEDIFF(current_date,daterequest) as 'Day(s) Count' from tbltransferrequest where confirmed=0 and cancelled=0 and inventory_to='" & compOfficeid & "'", "confirmed=0 and cancelled=0 and inventory_to='" & compOfficeid & "' ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabIncoming Then
            cmdCancel.Visible = True
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary(" DATEDIFF(current_date,daterequest) as 'Day(s) Count' from tbltransferrequest where cleared=1 and confirmed=0 and cancelled=0 and inventory_from='" & compOfficeid & "' ", "cleared=1 and confirmed=0 and cancelled=0 and inventory_from='" & compOfficeid & "' ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabConfirm Then
            cmdCancel.Visible = False
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary(" DATEDIFF(dateconfirmed,daterequest) as 'Day(s) Confirmed',  (select fullname from tblaccounts where accountid = tbltransferrequest.confirmedby) as 'Confirmed By', date_format(dateconfirmed,'%Y-%m-%d %r') as 'Date Confirmed' from tbltransferrequest where confirmed=1 and cancelled=0 and (inventory_from='" & compOfficeid & "' or inventory_to='" & compOfficeid & "') ", "confirmed=1 and cancelled=0 and (inventory_from='" & compOfficeid & "' or inventory_to='" & compOfficeid & "') ")
        ElseIf XtraTabControl1.SelectedTabPage Is xtabCancelled Then
            cmdCancel.Visible = False
            Em.Parent = XtraTabControl1.SelectedTabPage
            ViewTransmitalSummary(" DATEDIFF(datecancelled,daterequest) as 'Day(s) Cancelled',  (select fullname from tblaccounts where accountid = tbltransferrequest.cancelledby) as 'Cancelled By', date_format(datecancelled,'%Y-%m-%d %r') as 'Date Cancelled', cancelledremarks as 'Cancelled Remarks' from tbltransferrequest where cancelled=1 and (inventory_from='" & compOfficeid & "' or inventory_to='" & compOfficeid & "') ", "cancelled=1 and (inventory_from='" & compOfficeid & "' or inventory_to='" & compOfficeid & "') ")
        End If
    End Sub

    Private Sub ReprintIssuanceSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprintIssuanceSlipToolStripMenuItem.Click
        If XtraTabControl1.SelectedTabPage Is xtabOutGoing Or XtraTabControl1.SelectedTabPage Is xtabIncoming Then
            DXPrintDatagridviewSignatories("ISSUANCE SLIP", "ISSUANCE DETAILS", "Request #: " & GridView1.GetFocusedRowCellValue("Request Code").ToString & "<br/>Office Requestor: " & GridView1.GetFocusedRowCellValue("Office").ToString & "<br/>Requested By: " & GridView1.GetFocusedRowCellValue("Request By").ToString & "<br/>Date Requested: " & GridView1.GetFocusedRowCellValue("Date Request").ToString & "<br/>Message: " & GridView1.GetFocusedRowCellValue("Message").ToString, GridView1, "Requested By", GridView1.GetFocusedRowCellValue("requestby").ToString, "Verified By", globaluserid, "Approved By:", compOfficerid, Me)
        Else
            DXPrintDatagridviewSignatories("ISSUANCE SLIP", "ISSUANCE DETAILS", "Request #: " & GridView1.GetFocusedRowCellValue("Request Code").ToString & "<br/>Office Requestor: " & GridView1.GetFocusedRowCellValue("To").ToString & "<br/>Requested By: " & GridView1.GetFocusedRowCellValue("Request By").ToString & "<br/>Date Requested: " & GridView1.GetFocusedRowCellValue("Date Request").ToString & "<br/>Message: " & GridView1.GetFocusedRowCellValue("Message").ToString, GridView1, "Requested By", GridView1.GetFocusedRowCellValue("requestby").ToString, "Verified By", globaluserid, "Approved By:", compOfficerid, Me)
        End If
    End Sub

    Public Sub ViewTransmitalSummary(ByVal query As String, ByVal subquery As String)
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            Dim filterasof As String = ""
            If ckasof.Checked = True Then
                filterasof = " "
            Else
                filterasof = " and date_format(daterequest,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
            End If
            Dim office As String = ""
            If XtraTabControl1.SelectedTabPage Is xtabOutGoing Then
                office = "(select officename from tblcompoffice where officeid=tbltransferrequest.inventory_from) as 'Office',"
            ElseIf XtraTabControl1.SelectedTabPage Is xtabIncoming Then
                office = "(select officename from tblcompoffice where officeid=tbltransferrequest.inventory_to) as 'Office',"
            Else
                office = "(select officename from tblcompoffice where officeid=tbltransferrequest.inventory_from) as 'From', (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_to) as 'To', "
            End If

            dst2.EnforceConstraints = False : dst2.Relations.Clear() : dst2.Clear()
            LoadXgrid("Select reqcode,requestby,reqcode as 'Request Code', " & office _
                          + " (select sum(quantity) from tbltransferrequestitem where reqcode=tbltransferrequest.reqcode) as 'Total Item', " _
                          + " Message, " _
                          + " (select fullname from tblaccounts where accountid = tbltransferrequest.requestby) as 'Request By' , " _
                          + " date_format(daterequest,'%Y-%m-%d %r')  as 'Date Request', " _
                          + " (select fullname from tblaccounts where accountid = tbltransferrequest.trnby) as 'Created By' , " _
                          + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end ) as 'Status', " & query _
                          + " " & If(XtraTabControl1.SelectedTabPage Is xtabOutGoing Or XtraTabControl1.SelectedTabPage Is xtabIncoming, "", filterasof) _
                          + " and (reqcode like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " Message like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " (select fullname from tblaccounts where accountid = tbltransferrequest.trnby) like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_from) like '%" & rchar(txtsearch.Text) & "%' or " _
                          + " (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_to) like '%" & rchar(txtsearch.Text) & "%') order by daterequest desc", "tbltransferrequest", Em, GridView1)
            msda.SelectCommand.CommandTimeout = 6000000
            msda.Fill(dst2, "tbltransferrequest")
            XgridHideColumn({"reqcode", "requestby"}, GridView1)
            XgridColAlign({"Request Code", "Total Item", "Date Request", "Status", "Day(s) Count", "Day(s) Confirmed", "Day(s) Cancelled"}, GridView1, DevExpress.Utils.HorzAlignment.Center)


            msda = New MySqlDataAdapter("Select reqcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) as 'Particular', " _
                                           + " Quantity, Unit, " _
                                           + " Remarks " _
                                           + " from tbltransferrequestitem where reqcode in (select reqcode from tbltransferrequest where " & subquery & ") " _
                                           + " order by datetrn asc", conn)
            msda.Fill(dst2, "tbltransferrequestitem")

            BandgridView = New GridView(Em)
            Dim keyColumn As DataColumn = dst2.Tables("tbltransferrequest").Columns("reqcode")
            Dim foreignKeyColumn2 As DataColumn = dst2.Tables("tbltransferrequestitem").Columns("reqcode")

            dst2.Relations.Add("TransmittalDetails", keyColumn, foreignKeyColumn2)
            Em.LevelTree.Nodes.Add("TransmittalDetails", BandgridView)

            Em.DataSource = dst2.Tables("tbltransferrequest")

            '############## Band Gridview #####################
            BandgridView.PopulateColumns(dst2.Tables("tbltransferrequestitem"))


            DXBandGridFormat(BandgridView)
            XgridHideColumn({"reqcode"}, BandgridView)
            XgridColCurrencyDecimalCount({"Quantity"}, 3, BandgridView)
            XgridColAlign({"Quantity", "Unit"}, BandgridView, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Quantity"}, BandgridView)
            XgridColWidth({"Particular"}, BandgridView, 300)
            BandgridView.BestFitColumns()

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
        DXPrintDatagridview(Me.Text & "<br/><strong>" & XtraTabControl1.SelectedTabPage.Text & "</strong>", "List of " & XtraTabControl1.SelectedTabPage.Text, "Report period from " & CDate(txtfrmdate.Value).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Value).ToString("MMMM, dd yyyy"), GridView1, Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If XtraTabControl1.SelectedTabPage Is xtabIncoming Then
            frmTransferRequestReview.Batchcode.Text = GridView1.GetFocusedRowCellValue("Request Code").ToString
            frmTransferRequestReview.Show(Me)
        Else
            frmTransferRequestItem.Batchcode.Text = GridView1.GetFocusedRowCellValue("Request Code").ToString
            frmTransferRequestItem.Show(Me)
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
        frmTransferRequestCancelled.Batchcode.Text = GridView1.GetFocusedRowCellValue("Request Code").ToString
        frmTransferRequestCancelled.Show(Me)
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                ' MessageBox.Show("Your file successfully exported with filename " & LCase(Me.Text) & ".xls", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                MainForm.NotifyIcon1.BalloonTipTitle = "Successfully Exported"
                MainForm.NotifyIcon1.BalloonTipText = "Your file successfully exported at " & f.SelectedPath & "\" & LCase(Me.Text) & ".xls"
                MainForm.NotifyIcon1.ShowBalloonTip(1000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdUnitConverter_Click(sender As Object, e As EventArgs)
        frmUnitConverter.Show(Me)
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        frmTransferRequestNew.Show(Me)
    End Sub


End Class