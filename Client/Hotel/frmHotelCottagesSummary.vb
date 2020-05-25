Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCottagesSummary

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
         ElseIf keyData = (Keys.Space) Then
            txtsearch.Focus()

        ElseIf keyData = (Keys.Delete) Then
            cmdLocalData.PerformClick()

        ElseIf keyData = (Keys.Space) Then
            OccupieToolStripMenuItem.PerformClick()

        ElseIf keyData = (Keys.Control) + Keys.C Then
            CloseSelectedTransactionToolStripMenuItem.PerformClick()

        ElseIf keyData = (Keys.Control) + Keys.R Then
            ReserveToolStripMenuItem.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowHotelAndCottages()
    End Sub
    Public Sub ShowHotelAndCottages()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""

        msda = New MySqlDataAdapter("select productid, sort as 'Number', (select id from tblhotelcottagestransaction where productid = tblhotelcottages.productid and closedtrn=0 and cancelled=0) as 'trnid',  " _
                                    + " (select itemname from tblglobalproducts where productid = tblhotelcottages.productid) as 'Cottages and Tables', " _
                                    + " (select clientname from tblhotelcottagestransaction where productid = tblhotelcottages.productid and closedtrn=0 and cancelled=0) as 'Customer Name', " _
                                    + " (select contactnumber from tblhotelcottagestransaction where productid = tblhotelcottages.productid and closedtrn=0 and cancelled=0) as 'Contact #', " _
                                    + " case when availability=1 then 'Availabe' when availability=0 then 'Occupied' else 'Reserved' end as 'Availability' from tblhotelcottages where  (select itemname from tblglobalproducts where productid=tblhotelcottages.productid) like '%" & rchar(txtsearch.Text) & "%' or case when availability=1 then 'Availabe' when availability=0 then 'Occupied' else 'Researved' end  like '%" & rchar(txtsearch.Text) & "%'  order by sort asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"productid", "trnid"})
        GridColumnAlignment(MyDataGridView, {"Availability", "Number"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

   
    Private Sub OccupieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OccupieToolStripMenuItem.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            frmHotelCottagesInfo.trnid.Text = rw.Cells("trnid").Value.ToString
            frmHotelCottagesInfo.productid.Text = rw.Cells("productid").Value.ToString
            frmHotelCottagesInfo.mode.Text = "checkin"
            frmHotelCottagesInfo.txtProductName.Text = rw.Cells("Cottages and Tables").Value.ToString
            frmHotelCottagesInfo.Show(Me)
        Next
    End Sub

    Private Sub MyDataGridView_Sorted(sender As Object, e As EventArgs) Handles MyDataGridView.CellFormatting
        For i = 0 To MyDataGridView.RowCount - 2
            If MyDataGridView.Item("Availability", i).Value().ToString = "Occupied" Then
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            ElseIf MyDataGridView.Item("Availability", i).Value().ToString = "Reserved" Then
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Orange

            End If
        Next
    End Sub

    Private Sub CloseSelectedTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseSelectedTransactionToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to close selected item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                If rw.Cells("trnid").Value.ToString <> "" Then
                    com.CommandText = "update tblhotelcottagestransaction set closedtrn=1, closeddate=current_timestamp where id='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblhotelcottages set availability=1 where productid='" & rw.Cells("productid").Value.ToString & "'" : com.ExecuteNonQuery()
                End If
            Next

            ShowHotelAndCottages()
            MsgBox("Selected item successfully closed", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to cancel selected item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                If rw.Cells("trnid").Value.ToString <> "" Then
                    com.CommandText = "update tblhotelcottagestransaction set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblhotelcottages set availability=1 where productid='" & rw.Cells("productid").Value.ToString & "'" : com.ExecuteNonQuery()
                End If
            Next

            ShowHotelAndCottages()
            MsgBox("Selected item successfully cancelled", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ReserveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReserveToolStripMenuItem.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            frmHotelCottagesInfo.trnid.Text = rw.Cells("trnid").Value.ToString
            frmHotelCottagesInfo.productid.Text = rw.Cells("productid").Value.ToString
            frmHotelCottagesInfo.mode.Text = "reserve"
            frmHotelCottagesInfo.txtProductName.Text = rw.Cells("Cottages and Tables").Value.ToString
            frmHotelCottagesInfo.Show(Me)
        Next
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        ShowHotelAndCottages()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowHotelAndCottages()
    End Sub

    Private Sub SetSortOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetSortOrderToolStripMenuItem.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            frmHotelCottagesSort.productid.Text = rw.Cells("productid").Value.ToString
            frmHotelCottagesSort.Show(Me)
        Next
    End Sub
End Class