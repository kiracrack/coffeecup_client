Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSClientSearch

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            txtsearch.SelectAll()
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowProductList()
        PaintColumnFormat()
    End Sub

    Public Sub ShowProductList()
        MyDataGridView.DataSource = Nothing : msda = Nothing : dst = New DataSet
        If Globalenableclientfilter = True Then
            msda = New MySqlDataAdapter("Select cifid as 'Client ID',  COMPANYNAME as 'Client Name',  COMPADD as 'Address',  TELEPHONE as 'Contact No.', birthdate as 'Birth Date',emailadd as 'Email',VIP from tblclientaccounts where groupcode in (select groupcode from tblclientfilter where permissioncode='" & globalAuthcode & "') and (COMPANYNAME like '%" & rchar(txtsearch.Text) & "%' or (select vipcardno from tblhotelguest where guestid=tblclientaccounts.vipguestid)  like '%" & rchar(txtsearch.Text) & "%') and deleted=0 and blocked=0 and (vip=0 or (vip=1 and vipactivated=1)) order by companyname asc", conn)
        Else
            msda = New MySqlDataAdapter("Select cifid as 'Client ID',  COMPANYNAME as 'Client Name',  COMPADD as 'Address',  TELEPHONE as 'Contact No.', birthdate as 'Birth Date',emailadd as 'Email',VIP from tblclientaccounts where (COMPANYNAME like '%" & rchar(txtsearch.Text) & "%' or (select vipcardno from tblhotelguest where guestid=tblclientaccounts.vipguestid) like '%" & rchar(txtsearch.Text) & "%') and deleted=0 and blocked=0 and (vip=0 or (vip=1 and vipactivated=1)) order by COMPANYNAME asc", conn)
        End If
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"Client ID"})
        GridColumnAlignment(MyDataGridView, {"Client ID", "Contact No.", "Birth Date", "Email", "VIP"}, DataGridViewContentAlignment.MiddleCenter)
        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        PaintColumnFormat()
        MyDataGridView.Focus()
    End Sub
    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"Client ID"}, 0)
        GridColumnWidth(MyDataGridView, {"Address"}, 200)
        GridColumnWidth(MyDataGridView, {"Contact No.", "Birth Date", "Email", "VIP"}, 80)

        Dim column As Array = {"Client ID", "Address", "Contact No.", "Birth Date", "Email", "VIP"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        GridColumnWidth(MyDataGridView, {"Client Name"}, (MyDataGridView.Width) - TotalVisibleColumn)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmPointOfSale.cifid.Text = MyDataGridView.Item("Client ID", MyDataGridView.CurrentRow.Index).Value().ToString
            frmPointOfSale.txtClient.Text = MyDataGridView.Item("Client Name", MyDataGridView.CurrentRow.Index).Value().ToString
            frmPointOfSale.txtBarCode.Focus()
            frmPointOfSale.grpBarcode.Focus()
            Me.Close()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            ShowProductList()
        End If
    End Sub
 
End Class