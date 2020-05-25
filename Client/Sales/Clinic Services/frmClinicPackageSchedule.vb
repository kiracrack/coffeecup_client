Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmClinicPackageSchedule

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAutoNewServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadServicesInfo()
        ViewScheduleInfo()
        LoadToComboBoxDB("select * from tblglobalproducts where forcontract=1 and menuitem=1 order by itemname asc", "itemname", "productid", txtProduct)
    End Sub

    Public Sub LoadServicesInfo()
        Dim salesid As String = "" : Dim salesProduct As String = ""
        com.CommandText = "select *, (select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'customer' " _
                           + " from tblclinicservices where trnid='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtReference.Text = rst("servicecode").ToString
        End While
        rst.Close()
    End Sub

    Public Sub ViewScheduleInfo()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id,productname as 'Product', date_format(schedule,'%M %d, %Y') as 'Schedule' from tblclinicschedule where cancelled=0 and trnid='" & trnid.Text & "' order by date_format(schedule,'%Y-%m-%d') asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"id"})
        GridColumnAlignment(MyDataGridView, {"Schedule"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtProduct.Text = "" Then
            MsgBox("Please select product!", MsgBoxStyle.Exclamation, "Error Message")
            txtProduct.Focus()
            Exit Sub
        ElseIf countqry("tblclinicschedule", "trnid='" & trnid.Text & "' and schedule='" & ConvertDate(txtSchedule.Text) & "' and cancelled=0") > 0 Then
            MsgBox("Please Schedule already exists!", MsgBoxStyle.Exclamation, "Error Message")
            txtSchedule.Focus()
            Exit Sub
        End If
        com.CommandText = "INSERT INTO tblclinicschedule set trnid='" & trnid.Text & "', servicecode='" & txtReference.Text & "', productid='" & productid.Text & "',  productname='" & txtProduct.Text & "',schedule='" & ConvertDate(txtSchedule.Text) & "', addedby='" & globalfullname & "',dateadded=current_timestamp" : com.ExecuteNonQuery()
        ViewScheduleInfo()
    End Sub

    Private Sub txtProduct_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedValueChanged
        productid.Text = DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewScheduleInfo()
    End Sub

    Private Sub cmdClearedSchedule_Click(sender As Object, e As EventArgs) Handles cmdClearedSchedule.Click
        If countqry("tblclinicschedule", "id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "' and cleared=1") > 0 Then
            MsgBox("Schedule already cleared! Cancelation not allowed", MsgBoxStyle.Critical, "Error Message")
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to Continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblclinicschedule set cancelled=1, datecancelled=current_timestamp,cancelledby='" & globalfullname & "' where id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            ViewScheduleInfo()
            MsgBox("Schedule successfully cancelled", MsgBoxStyle.Information, "Message")
        End If
    End Sub
End Class