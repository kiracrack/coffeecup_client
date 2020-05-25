Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCustomPackage
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelCustomPackage_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadBreakdown()
    End Sub

    Private Sub frmHotelCustomPackage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmHotelCustomPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadRoomType()
        loadPackages()
    End Sub

    Public Sub LoadRoomType()
        LoadToComboBoxDB("select * from tblhotelroomtype", "description", "code", txtRoomType)

        If countqry("tblhotelgrouproom", " bookno='" & foliono.text & "' and cancelled=0") > 0 Then
            Dim strroomtype As String = "" : Dim strRoomTypecode As String = ""
            com.CommandText = "select * from tblhotelgrouproom where bookno='" & foliono.text & "' and hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and cancelled=0 limit 1" : rst = com.ExecuteReader
            While rst.Read
                strroomtype = rst("description").ToString
                strRoomTypecode = rst("roomtype").ToString
            End While
            rst.Close()
            txtRoomType.Text = strroomtype
            roomtype.Text = strRoomTypecode
        ElseIf countqry("tblhotelroomtransaction", " folioid='" & foliono.text & "' and cancelled=0") > 0 Then
            Dim strroomtype As String = "" : Dim strRoomTypecode As String = ""
            com.CommandText = "select *,(select description from tblhotelroomtype where code = tblhotelroomtransaction.roomtype) as room_type from tblhotelroomtransaction where folioid='" & foliono.text & "'" : rst = com.ExecuteReader
            While rst.Read
                strroomtype = rst("room_type").ToString
                strRoomTypecode = rst("roomtype").ToString
            End While
            rst.Close()
            txtRoomType.Text = strroomtype
            roomtype.Text = strRoomTypecode

        End If
    End Sub

    Private Sub txtDiscounttype_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomType.SelectedValueChanged
        roomtype.Text = DirectCast(txtRoomType.SelectedItem, ComboBoxItem).HiddenValue()
        loadPackages()
    End Sub

    Public Sub loadPackages()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select ratecode as Code,roomtype, Description from tblhotelroomrates where deleted=0 and bookingno='" & foliono.Text & "' and roomtype='" & roomtype.Text & "' and temporaryrate=1", conn)
        'msda = New MySqlDataAdapter("select ratecode as Code,roomtype, Description from tblhotelroomrates where deleted=0 and (roomtype='" & roomtype.Text & "' and foliono.text='" & foliono.text & "' and temporaryrate=1) or ratecode='" & rateid.Text & "'", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"roomtype", "Code"})
        GridColumnAlignment(MyDataGridView, {"Code"}, DataGridViewContentAlignment.MiddleCenter)
        If MyDataGridView.RowCount = 0 Then
            code.Text = ""
            LoadBreakdown()
        End If
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdConfirmedBooking_Click(sender As Object, e As EventArgs) Handles cmdConfirmedBooking.Click
        If txtRoomType.Text = "" Then
            MessageBox.Show("Please select room type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoomType.Focus()
            Exit Sub
        ElseIf txtPackagename.Text = "" Then
            MessageBox.Show("Please enter package name", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPackagename.Focus()
            Exit Sub
        ElseIf countqry("tblhotelroomrates", "description='" & rchar(txtPackagename.Text) & "' and actived=1 and lockrate=1 and temporaryrate=1 and bookingno='" & foliono.Text & "'") > 0 Then
            MessageBox.Show("Package name already exists", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPackagename.Focus()
            Exit Sub
        End If
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Created new package " & txtPackagename.Text & " for room type " & txtRoomType.Text)
        If mode.Text = "edit" Then
            com.CommandText = "Update tblhotelroomrates set roomtype='" & roomtype.Text & "', description='" & rchar(txtPackagename.Text) & "',actived=1,lockrate=0,temporaryrate=1,bookingno='" & foliono.Text & "',editedby='" & globalfullname & "' where ratecode='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblhotelroomrates set roomtype='" & roomtype.Text & "', description='" & rchar(txtPackagename.Text) & "',actived=1,lockrate=0,temporaryrate=1,bookingno='" & foliono.Text & "',addedby='" & globalfullname & "'" : com.ExecuteNonQuery()
        End If
        txtPackagename.Text = "" : mode.Text = "" : id.Text = "" : loadPackages() : txtPackagename.Focus()
    End Sub

    Private Sub cmdRemoveCompanion_Click(sender As Object, e As EventArgs) Handles cmdRemoveCompanion.Click
        If countqry("tblhotelfolioroom", "rateid='" & MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString & "' and inhouse=1 and cancelled=0 and foliono='" & foliono.Text & "'") > 0 Then
            MessageBox.Show("Modification or Deletion are not allowed! Package is currently in used! If you wish to modify this package select on room list > Right Click > Room Management > View Room Info > Update Internal Breakdown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "UPDATE tblhotelroomrates set deleted=1,deletedby='" & globaluserid & "' where ratecode='" & MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            loadPackages()
        End If
    End Sub

    Private Sub cmdEditCompanion_Click(sender As Object, e As EventArgs) Handles cmdEditCompanion.Click
        If MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString = "" Then
            MessageBox.Show("There is no item selected! make sure, the selection is on the list", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf countqry("tblhotelroomrates", "ratecode='" & MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString & "' and lockrate=1") > 0 Then
            MessageBox.Show("Modification of Standard Package Rate are not allowed! You can add your own customized rate or ask your reservation or autorized for modification of standard package on the server.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        id.Text = MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString
        com.CommandText = "select * from tblhotelroomrates where ratecode='" & id.Text & "'  " : rst = com.ExecuteReader
        While rst.Read
            txtPackagename.Text = rst("description").ToString
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub
 
    Private Sub cmdRefreshCompanion_Click(sender As Object, e As EventArgs) Handles cmdRefreshCompanion.Click
        loadPackages()
    End Sub
     
    Private Sub MyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentClick
        GetCode()
    End Sub
    Public Sub LoadBreakdown()
        DataGridView1.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT a.dayrate+1 as 'Day',ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='roomrate' and dayrate=a.dayrate),0) as 'Room Rate', " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='child' and dayrate=a.dayrate),0) as 'Child Rate', " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='extra' and dayrate=a.dayrate),0) as 'Extra Person Rate' " _
                                                + " FROM `tblhotelratesbreakdown` as a where ratecode='" & code.Text & "' group by dayrate;", conn)
        msda.Fill(dst, 0)
        DataGridView1.DataSource = dst.Tables(0)
        GridColumnAlignment(DataGridView1, {"Day"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(DataGridView1, {"Room Rate", "Child Rate", "Extra Person Rate"})

    End Sub
    Private Sub DataGridView1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub MyDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles MyDataGridView.CellValidating
        GetCode()
    End Sub

    Private Sub MyDataGridView_Click(sender As Object, e As EventArgs) Handles MyDataGridView.Click
        GetCode()
    End Sub

    Public Sub GetCode()
        If MyDataGridView.RowCount > 0 Then
            code.Text = MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString
            If code.Text <> "" Then
                LoadBreakdown()
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        LoadBreakdown()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If code.Text = "" Then
            MessageBox.Show("Please select room type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoomType.Focus()
            Exit Sub
        End If
        If DataGridView1.RowCount > 0 Then
            frmHotelCustomPackageItem.txtNight.SelectedIndex = Val(DataGridView1.Item("Day", DataGridView1.CurrentRow.Index).Value().ToString) - 1
        End If
        frmHotelCustomPackageItem.roomtype.Text = roomtype.Text
        frmHotelCustomPackageItem.ratecode.Text = code.Text
        frmHotelCustomPackageItem.Show(Me)
    End Sub

    Private Sub DuplicateStandardRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateStandardRateToolStripMenuItem.Click
        If countqry("tblhotelroomrates", "ratecode='" & MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString & "' and lockrate=0") > 0 Then
            frmHotelDuplicateRates.foliono.Text = foliono.Text
            frmHotelDuplicateRates.roomtype.Text = roomtype.Text
            frmHotelDuplicateRates.rateid.Text = MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString
            frmHotelDuplicateRates.txtRateName.Text = MyDataGridView.Item("Description", MyDataGridView.CurrentRow.Index).Value().ToString & " - Copy"
            frmHotelDuplicateRates.Show(Me)
        Else
            frmHotelDuplicateRates.foliono.Text = foliono.Text
            frmHotelDuplicateRates.roomtype.Text = roomtype.Text
            frmHotelDuplicateRates.rateid.Text = MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString
            frmHotelDuplicateRates.txtRateName.Text = MyDataGridView.Item("Description", MyDataGridView.CurrentRow.Index).Value().ToString & "(" & foliono.Text & ")"
            frmHotelDuplicateRates.Show(Me)
        End If
       
    End Sub
End Class