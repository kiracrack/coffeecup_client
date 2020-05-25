Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCustomPackageItem
    Public TransactionDone As Boolean = False

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Insert) Then
            cmdAddnew.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelCustomPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadPackageItem()
        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i

        If countqry("tblhotelfolioroom", "rateid='" & ratecode.Text & "' and inhouse=1 and cancelled=0 ") > 0 Then
            MyDataGridView.ContextMenuStrip = Nothing
        Else
            MyDataGridView.ContextMenuStrip = cms_packages
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        MyDataGridView.Parent = TabControl1.SelectedTab
        If frmHotelRoomRateBreakdownAddItem.Visible = True Then
            frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = TabControl1.SelectedTab.Name
        End If
        LoadPackageItem()
    End Sub


    Public Sub LoadPackageItem()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select * from (select id, itemname as 'Item Name', Amount from tblhotelratesbreakdown where  dayrate='" & txtNight.SelectedIndex & "' and ratecode='" & ratecode.Text & "' and breakdowntype='" & TabControl1.SelectedTab.Name & "' union all " _
                                    + " select '','',sum(amount) from tblhotelratesbreakdown where dayrate='" & txtNight.SelectedIndex & "' and ratecode='" & ratecode.Text & "' and breakdowntype='" & TabControl1.SelectedTab.Name & "') as a ", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id"})
        GridColumnWidth(MyDataGridView, {"Item Name"}, 300)
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnWidth(MyDataGridView, {"Amount"}, 60)
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub


    Private Sub cmdAddnew_Click(sender As Object, e As EventArgs) Handles cmdAddnew.Click
        If txtNight.Text = "" Then
            MessageBox.Show("Please select day", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNight.Focus()
            Exit Sub
        End If
        frmHotelRoomRateBreakdownAddItem.txtDayRate.Text = txtNight.SelectedIndex
        frmHotelRoomRateBreakdownAddItem.roomtype.Text = roomtype.Text
        frmHotelRoomRateBreakdownAddItem.ratecode.Text = ratecode.Text
        frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = TabControl1.SelectedTab.Name
        frmHotelRoomRateBreakdownAddItem.Show(Me)
    End Sub

    Private Sub cmdRemoveSelected_Click(sender As Object, e As EventArgs) Handles cmdRemoveSelected.Click
        If MessageBox.Show("Are you sure you want to removed selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "delete from tblhotelratesbreakdown where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            com.CommandText = "UPDATE tblhotelroomrates set editedby='" & globalfullname & "'  where ratecode='" & ratecode.Text & "'" : com.ExecuteNonQuery()
            LoadPackageItem()
        End If
    End Sub

    Private Sub cmdEditSelected_Click(sender As Object, e As EventArgs) Handles cmdEditSelected.Click
        frmHotelRoomRateBreakdownAddItem.roomtype.Text = roomtype.Text
        frmHotelRoomRateBreakdownAddItem.ratecode.Text = ratecode.Text
        frmHotelRoomRateBreakdownAddItem.breakdowntype.Text = TabControl1.SelectedTab.Name
        frmHotelRoomRateBreakdownAddItem.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmHotelRoomRateBreakdownAddItem.mode.Text = "edit"

        frmHotelRoomRateBreakdownAddItem.Show(Me)
    End Sub

    Private Sub txtRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtNight.SelectedIndexChanged
        LoadPackageItem()
    End Sub

    Private Sub cmdRefreshCompanion_Click(sender As Object, e As EventArgs) Handles cmdRefreshCompanion.Click
        LoadPackageItem()
    End Sub
End Class