Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelUpdatePackage
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelCustomPackage_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadBreakdown()
    End Sub

    Private Sub frmHotelUpdatePackage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        
    End Sub

    Private Sub frmHotelCustomPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadPackageInfo()
    End Sub

    Public Sub LoadPackageInfo()
        com.CommandText = "select *,(select description from tblhotelroomtype where code=tblhotelroomrates.roomtype) as room_type from tblhotelroomrates where ratecode='" & code.Text & "' and deleted=0" : rst = com.ExecuteReader
        While rst.Read
            roomtype.Text = rst("roomtype").ToString
            txtRoomType.Text = rst("room_type").ToString
            txtPackagename.Text = rst("description").ToString
        End While
        rst.Close()
        LoadPackages()
    End Sub
 
    Private Sub cmdConfirmedBooking_Click(sender As Object, e As EventArgs) Handles cmdConfirmedBooking.Click
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Update package " & txtPackagename.Text)
            com.CommandText = "Update tblhotelroomrates set description='" & rchar(txtPackagename.Text) & "' where ratecode='" & code.Text & "'" : com.ExecuteNonQuery()
            UpdateFolioSummary(foliono.Text)
            frmHotelFolioRoomInfo.LoadRoomInformation()
            frmHotelFolioRoomInfo.LoadRoomBreakdown()
            MessageBox.Show("Package successfully updated", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
 
    Public Sub LoadPackages()
        LoadXgrid("SELECT a.dayrate+1 as 'Day', DATE_ADD('" & ConvertDate(txtdateCheckin.Text) & "', INTERVAL a.dayrate DAY) as 'Date', ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='roomrate' and dayrate=a.dayrate),0) as 'Room Rate', " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='child' and dayrate=a.dayrate),0) as 'Child Rate', " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='extra' and dayrate=a.dayrate),0) as 'Extra Person Rate' " _
                                                + " FROM `tblhotelratesbreakdown` as a where ratecode='" & code.Text & "' group by dayrate;", "tblhotelratesbreakdown", Em, GridView_Package)

        XgridColCurrency({"Room Rate", "Child Rate", "Extra Person Rate"}, GridView_Package)
        XgridColAlign({"Day", "Date"}, GridView_Package, DevExpress.Utils.HorzAlignment.Center)
        If GridView_Package.RowCount = 0 Then
            txtNight.Text = ""
        End If
    End Sub
    Public Sub LoadBreakdown()
        LoadXgrid("select id, itemname as 'Item Name', Amount from tblhotelratesbreakdown where dayrate='" & txtNight.Text & "' and ratecode='" & code.Text & "' and breakdowntype='" & TabControl1.SelectedTab.Name & "'", "tblhotelratesbreakdown", GridControl1, GridView_breakdown)
        XgridHideColumn({"id"}, GridView_breakdown)
        XgridColCurrency({"Amount"}, GridView_breakdown)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_breakdown)
        XgridColWidth({"Amount"}, GridView_breakdown, 100)
        If GridView_Package.RowCount = 0 Then
            LoadPackages()
        End If
    End Sub
    
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        LoadPackages()
    End Sub

    Private Sub Em_Click(sender As Object, e As EventArgs) Handles Em.Click
        If GridView_Package.RowCount = 0 Then Exit Sub
        txtNight.Text = Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1
        LoadBreakdown()
    End Sub

    Private Sub Em_GotFocus(sender As Object, e As EventArgs) Handles Em.GotFocus
        If GridView_Package.RowCount = 0 Then Exit Sub
        txtNight.Text = Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1
        LoadBreakdown()
    End Sub

    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If GridView_Package.RowCount = 0 Then Exit Sub
        txtNight.Text = Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1
        LoadBreakdown()
    End Sub


    Private Sub Gridview1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_Package.FocusedRowChanged
        If GridView_Package.RowCount = 0 Then Exit Sub
        txtNight.Text = Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1
        LoadBreakdown()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        GridControl1.Parent = TabControl1.SelectedTab
        LoadBreakdown()
    End Sub

    Private Sub cmdAddnew_Click(sender As Object, e As EventArgs) Handles cmdAddnew.Click
        If CDate(GridView_Package.GetFocusedRowCellValue("Date").ToString) < getServerDate() Then
            MessageBox.Show("Cannot remove previous date. transaction is already in processed.", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Add new charge item for package " & txtPackagename.Text)
        frmHotelRoomRateBreakdownAddItem.txtDayRate.Text = If(txtNight.Text = "", "0", txtNight.Text)
        frmHotelRoomRateBreakdownAddItem.roomtype.Text = roomtype.Text
        frmHotelRoomRateBreakdownAddItem.ratecode.Text = code.Text
        frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = TabControl1.SelectedTab.Name
        frmHotelRoomRateBreakdownAddItem.Show(Me)
    End Sub

    Private Sub cmdRemoveSelected_Click(sender As Object, e As EventArgs) Handles cmdRemoveSelected.Click
        If CDate(GridView_Package.GetFocusedRowCellValue("Date").ToString) < getServerDate() Then
            MessageBox.Show("Cannot remove previous date. transaction is already in processed.", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For I = 0 To GridView_breakdown.SelectedRowsCount - 1
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Remove charge item " & GridView_breakdown.GetRowCellValue(GridView_breakdown.GetSelectedRows(I), "Item Name") & " of package " & txtPackagename.Text)
            com.CommandText = "delete from tblhotelratesbreakdown where id='" & GridView_breakdown.GetRowCellValue(GridView_breakdown.GetSelectedRows(I), "id") & "'" : com.ExecuteNonQuery()
        Next
        LoadBreakdown()
    End Sub

    Private Sub cmdEditSelected_Click(sender As Object, e As EventArgs) Handles cmdEditSelected.Click
        If CDate(GridView_Package.GetFocusedRowCellValue("Date").ToString) < getServerDate() Then
            MessageBox.Show("Cannot remove previous date. transaction is already in processed.", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Edit charge item of package " & txtPackagename.Text)
        frmHotelRoomRateBreakdownAddItem.roomtype.Text = roomtype.Text
        frmHotelRoomRateBreakdownAddItem.ratecode.Text = code.Text
        frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = TabControl1.SelectedTab.Name
        frmHotelRoomRateBreakdownAddItem.id.Text = GridView_breakdown.GetFocusedRowCellValue("id").ToString
        frmHotelRoomRateBreakdownAddItem.mode.Text = "edit"
        frmHotelRoomRateBreakdownAddItem.Show(Me)
    End Sub

    Private Sub txtRoomType_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadBreakdown()
    End Sub

    Private Sub AddNightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNightToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim DayNo As Integer = Val(qrysingledata("dr", "ifnull(dayrate,0) as dr", "tblhotelratesbreakdown where ratecode='" & code.Text & "' order by dayrate desc limit 1"))
            Dim Details As String = ""

            com.CommandText = "select * from tblhotelratesbreakdown where ratecode='" & code.Text & "' and dayrate='" & Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1 & "'" : rst = com.ExecuteReader
            While rst.Read
                Details += "insert into tblhotelratesbreakdown set roomtype='" & rst("roomtype").ToString & "',ratecode='" & rst("ratecode").ToString & "',dayrate='" & DayNo + 1 & "',breakdowntype='" & rst("breakdowntype").ToString & "',itemcode='" & rst("itemcode").ToString & "',itemname='" & rchar(rst("itemname").ToString) & "',amount='" & rst("amount").ToString & "'; "
            End While
            rst.Close()

            If Details.Length > 0 Then
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Added day " & DayNo & " of package " & txtPackagename.Text)
                com.CommandText = Details : com.ExecuteNonQuery()
                LoadPackages()
            End If
        End If
    End Sub

    Private Sub RemovePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePackageToolStripMenuItem.Click
        If CDate(GridView_Package.GetFocusedRowCellValue("Date").ToString) < getServerDate() Then
            MessageBox.Show("Cannot remove previous date. transaction is already in processed.", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to removed selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Remove day " & Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1 & " of package " & txtPackagename.Text)
            com.CommandText = "delete from tblhotelratesbreakdown where ratecode='" & code.Text & "' and dayrate='" & Val(GridView_Package.GetFocusedRowCellValue("Day").ToString) - 1 & "'" : com.ExecuteNonQuery()
            LoadPackages()
            LoadBreakdown()
        End If
    End Sub
End Class