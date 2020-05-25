Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelRoomDiscount

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
         ElseIf keyData = (Keys.Space) Then
            txtDescription.SelectAll()
            txtDescription.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowDiscountRate()
        If mode.Text <> "edit" Then
            txtCode.Text = getDiscountCode()
        End If
        If LCase(globalusername) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
    End Sub
    Public Sub ShowDiscountRate()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select discode as 'Code', Description, discountrate as 'Discount Rate' from tblhotelroomsdiscount", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Code"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Discount Rate"})
        GridColumnAlignment(MyDataGridView, {"Discount Rate"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowDiscountRate()
    End Sub

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Please enter Description!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtRate.Text = "" Or Val(txtRate.Text) = 0 Then
            MessageBox.Show("Please enter discount rate!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRate.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblhotelroomsdiscount set description='" & rchar(txtDescription.Text) & "', discountrate='" & Val(txtRate.Text) & "' where  discode='" & txtCode.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelroomsdiscount set discode='" & txtCode.Text & "', description='" & rchar(txtDescription.Text) & "', discountrate='" & Val(txtRate.Text) & "'" : com.ExecuteNonQuery()
            End If
            mode.Text = "" : txtCode.Text = getDiscountCode() : txtDescription.Text = "" : txtRate.Text = "0.00" : txtDescription.Focus()
            ShowDiscountRate()
            MessageBox.Show("Discount successfully saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "edit"
        txtCode.Text = MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString
        com.CommandText = "select * from tblhotelroomsdiscount where discode = '" & txtCode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            txtRate.Text = FormatNumber(rst("discountrate").ToString, 2)
        End While
        rst.Close()
        txtDescription.Focus()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblhotelroomsdiscount where discode = '" & MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            ShowDiscountRate()
            MessageBox.Show("Discount successfully deleted!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class