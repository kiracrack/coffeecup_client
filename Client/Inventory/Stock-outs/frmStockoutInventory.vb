Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmStockoutInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.Space Then
            txtfilter.Focus()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmStockoutInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtfilter.Text = ""
        ApplySystemTheme(ToolStrip3)
        filter()
        txtfilter.Focus()
    End Sub

    Public Sub filter()
        LoadXgrid("Select trnid as 'Stock No.', productname as 'Product Name', " _
                        + " quantity as 'Available Quantity', Unit, purchasedprice as 'Unit Cost', date_format(dateinventory,'%Y-%m-%d %r') as 'Date Inventory' " _
                        + " from tblinventory where officeid='" & compOfficeid & "' and (productname like '%" & txtfilter.Text & "%' or productid like '%" & txtfilter.Text & "%')  and quantity > 0  order by productname asc", "tblinventory", Em, inventoryGrid)
        XgridColCurrencyDecimalCount({"Available Quantity", "Unit Cost"}, 3, inventoryGrid)
        XgridColAlign({"Stock No.", "Unit", "Available Quantity"}, inventoryGrid, DevExpress.Utils.HorzAlignment.Center)
        inventoryGrid.BestFitColumns()
        inventoryGrid.Focus()
        Em.Focus()
    End Sub

    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar() = Chr(13) Then
            ShowStockoutQuan()
        End If
    End Sub
    Private Sub Em_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.DoubleClick
        ShowStockoutQuan()
    End Sub

    Private Sub menuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuView.Click
        ShowStockoutQuan()
    End Sub
    Public Sub ShowStockoutQuan()
        frmStockoutQuantity.stockid.Text = inventoryGrid.GetFocusedRowCellValue("Stock No.").ToString
        frmStockoutQuantity.Show(Me)
    End Sub

  
    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            filter()
        End If
    End Sub

    Private Sub txtfilter_GotFocus(sender As Object, e As EventArgs) Handles txtfilter.GotFocus
        If txtfilter.Text = "Enter keyword here to search.." Then
            txtfilter.Text = ""
        End If
    End Sub

    Private Sub txtfilter_LostFocus(sender As Object, e As EventArgs) Handles txtfilter.LostFocus
        If txtfilter.Text = "" Then
            txtfilter.Text = "Enter keyword here to search.."
        End If
    End Sub


End Class