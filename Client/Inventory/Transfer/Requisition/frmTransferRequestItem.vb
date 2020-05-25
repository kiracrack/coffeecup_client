Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmTransferRequestItem

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        tabColumnOption()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabColumnOption()
    End Sub
    Public Sub tabColumnOption()
        If TabControl1.SelectedTab Is tabRequested Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewRequestedTransfer()
        Else
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewProcessedTransfer()
        End If
    End Sub
    Public Sub ViewProcessedTransfer()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitem.itemid) as 'Particular', " _
                           + " Quantity, Unit, " _
                           + " Remarks " _
                           + " from tbltransferrequestitem  where reqcode = '" & Batchcode.Text & "' and processed=1" _
                           + " order by datetrn asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity"}, 4)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Public Sub ViewRequestedTransfer()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select (select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferrequestitemlogs.itemid) as 'Particular', " _
                           + " Quantity, Unit, " _
                           + " Remarks " _
                           + " from tbltransferrequestitemlogs where reqcode = '" & Batchcode.Text & "'" _
                           + " order by datetrn asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity"}, 4)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        tabColumnOption()
    End Sub
End Class