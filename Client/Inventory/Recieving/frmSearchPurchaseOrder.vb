Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmSearchPurchaseOrder

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            If Not textsearch.Focused = True Then
                textsearch.SelectAll()
                textsearch.Focus()
            End If
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ViewIventoryItem()
        textsearch.Focus()
    End Sub

    Public Sub ViewIventoryItem()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select a.requestref as 'Request No.', a.ponumber as 'PO Number', " _
                   + " (select officename from tblcompoffice where officeid = a.officeid) as 'Office', " _
                   + " ifnull((select ucase(companyname) from tblglobalvendor where vendorid = a.vendorid),'DELETED SUPPLIER') as 'Supplier', " _
                   + " a.totalamount as 'Total', " _
                   + " date_format(a.datetrn,'%Y-%m-%d %r') as 'Date Created',concat(date_format(a.datetrn,'%Y-%m-%d'),' - ', a.ponumber,' - ', a.requestref,' - ',ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER'),' - ',(select officename from tblcompoffice where officeid=a.officeid)) as 'details'  " _
                   + " from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where b.catid in (select catid from tblprocategory where " & If(ckConsumable.Checked = True, " consumable=1 ", "ffe=1") & ") and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") _
                   + " and (a.requestref like '%" & textsearch.Text & "%' or a.ponumber like '%" & textsearch.Text & "%' or ifnull((select ucase(companyname) from tblglobalvendor where vendorid = a.vendorid),'DELETED SUPPLIER') like '%" & textsearch.Text & "%'  or (select officename from tblcompoffice where officeid = a.officeid) like '%" & textsearch.Text & "%') group by b.ponumber order by a.datetrn asc;", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"details"})
        GridColumnAlignment(MyDataGridView, {"Request No.", "PO Number", "Date Created"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Total"})
    End Sub


    Private Sub textsearch_GotFocus(sender As Object, e As EventArgs) Handles textsearch.GotFocus
        If textsearch.Text = "Enter keyword here to search.." Then
            textsearch.Text = ""
        End If
    End Sub

    Private Sub textsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            ViewIventoryItem()
            MyDataGridView.Focus()
        End If
    End Sub

    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        showInfo()
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Public Sub showInfo()
        If frmReceivedConsumable.Visible = True Then
            frmReceivedConsumable.ponumber.Text = MyDataGridView.Item("details", MyDataGridView.CurrentRow.Index).Value().ToString
        End If
        If frmReceivedFFE.Visible = True Then
            frmReceivedFFE.ponumber.Text = MyDataGridView.Item("details", MyDataGridView.CurrentRow.Index).Value().ToString
        End If
        Me.Close()
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        'You're Code
        If e.KeyCode = Keys.Enter Then
            showInfo()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
        Else
            e.Handled = True
        End If
        Return
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewIventoryItem()
    End Sub


    Private Sub textsearch_LostFocus(sender As Object, e As EventArgs) Handles textsearch.LostFocus
        If textsearch.Text = "" Then
            textsearch.Text = "Enter keyword here to search.."
        End If
    End Sub
  
End Class