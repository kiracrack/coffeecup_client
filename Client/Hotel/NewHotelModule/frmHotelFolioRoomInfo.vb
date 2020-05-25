Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelFolioRoomInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F3 Then

            Return False
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelFolioRoomInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ApplySystemTheme(ToolStrip1)
        LoadRoomInformation()
        txtDateCheckin.Text = qrysingledata("arival", "arival", "tblhotelfolioroom where folioid='" & folioid.Text & "'")
    End Sub

    Public Sub LoadRoomInformation()
        com.CommandText = "select * from tblhotelfolioroom where folioid='" & folioid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            If CBool(rst("checkout")) = True Then
                cmdUpdateBreakdown.Enabled = False
                cmdLoadBreakDown.Enabled = False
                cmdEditDate.Visible = False
            Else
                cmdUpdateBreakdown.Enabled = True
                cmdLoadBreakDown.Enabled = False
                cmdEditDate.Visible = True
            End If
        End While
        rst.Close()

        LoadXgrid("SELECT id,roomtrncode as 'Code', RateID, date_format(datetrn,'%Y-%m-%d')  as Date, Adult,(select description from tblhotelroomrates where ratecode=tblhotelfolioroomsummary.rateid) as 'Package',  AdultRate as 'RoomRate',Child,ChildRate,Extra as 'ExtraPerson',extraRate as 'ExtraPersonRate',Total FROM `tblhotelfolioroomsummary` where folioid='" & folioid.Text & "'", "tblhotelfolioroomsummary", Em, GridView_Room)
        XgridHideColumn({"id", "Code", "RateID"}, GridView_Room)
        XgridColCurrency({"RoomRate", "ChildRate", "ExtraPersonRate", "Total"}, GridView_Room)
        XgridColAlign({"Date", "Adult", "Child", "ExtraPerson", "PerRoomCharge"}, GridView_Room, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView_Room)
        XgridColWidth({"Date", "Total"}, GridView_Room, 120)
    End Sub

    Public Sub LoadRoomBreakdown()
        LoadXgrid("select case when breakdowntype='roomrate' then 'ROOM/PAX RATE' when breakdowntype='child' then 'CHILD RATE' when breakdowntype='extra' then 'EXTRA PERSON RATE' end as 'CHARGES', itemname as 'Description', Amount from tblhotelfolioroombreakdown where roomtrncode='" & roomtrncode.Text & "' order by breakdowntype desc", "tblhotelfolioroombreakdown", Em_Breakdown, GridView_Breakdown)
        GridView_Breakdown.Columns("CHARGES").Group()
        XgridColCurrency({"Amount"}, GridView_Breakdown)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_Breakdown)
        XgridColWidth({"Amount"}, GridView_Breakdown, 100)
        GridView_Breakdown.ExpandAllGroups()
    End Sub

    Private Sub Em_Click(sender As Object, e As EventArgs) Handles Em.Click
        If GridView_Room.RowCount = 0 Then Exit Sub
        roomtrncode.Text = GridView_Room.GetFocusedRowCellValue("Code").ToString
        rateid.Text = GridView_Room.GetFocusedRowCellValue("RateID").ToString
        LoadRoomBreakdown()
    End Sub

    Private Sub Em_GotFocus(sender As Object, e As EventArgs) Handles Em.GotFocus
        If GridView_Room.RowCount = 0 Then Exit Sub
        roomtrncode.Text = GridView_Room.GetFocusedRowCellValue("Code").ToString
        rateid.Text = GridView_Room.GetFocusedRowCellValue("RateID").ToString
        LoadRoomBreakdown()
    End Sub

    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If GridView_Room.RowCount = 0 Then Exit Sub
        roomtrncode.Text = GridView_Room.GetFocusedRowCellValue("Code").ToString
        rateid.Text = GridView_Room.GetFocusedRowCellValue("RateID").ToString
        LoadRoomBreakdown()
    End Sub

    Private Sub Gridview1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_Room.FocusedRowChanged
        If GridView_Room.RowCount = 0 Then Exit Sub
        roomtrncode.Text = GridView_Room.GetFocusedRowCellValue("Code").ToString
        rateid.Text = GridView_Room.GetFocusedRowCellValue("RateID").ToString
        LoadRoomBreakdown()
    End Sub
    
    

    Private Sub cmdRefreshDeposit_Click(sender As Object, e As EventArgs) Handles cmdRefreshDeposit.Click
        LoadRoomBreakdown()
    End Sub

   
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Print room folio report for room " & GetRoomFolioInfo(folioid.Text, "roomno"))
        GenerateMasterFolio(False, folioid.Text, True, "", Me)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        GenerateMasterFolio(False, folioid.Text, False, ConvertDate(GridView_Room.GetFocusedRowCellValue("Date").ToString), Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdUpdateBreakdown.Click
        If countqry("tblhotelroomrates", "ratecode='" & rateid.Text & "' and lockrate=1") > 0 Then
            MessageBox.Show("Modification of Standard Package Rate are not allowed! You can add your own customized rate or ask your reservation or autorized for modification of standard package on the server.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmHotelUpdatePackage.code.Text = rateid.Text
        frmHotelUpdatePackage.foliono.Text = foliono.Text
        frmHotelUpdatePackage.txtdateCheckin.Text = txtDateCheckin.Text
        frmHotelUpdatePackage.Show(Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles cmdLoadBreakDown.Click
        UpdateFolioSummary(foliono.Text)
        LoadRoomInformation()
        LoadRoomBreakdown()
    End Sub

    Private Sub EditSelectedDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEditDate.Click
        frmHotelEditDailyrate.trnid.Text = GridView_Room.GetFocusedRowCellValue("id").ToString
        frmHotelEditDailyrate.ShowDialog(Me)
    End Sub
End Class