Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmTransferProcessingItem

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ViewLocalparticulars()
    End Sub
    Public Sub ViewLocalparticulars()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid,refcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Particular', " _
                           + " Quantity, Unit, unitcost as 'Unit Cost', " _
                           + " unitcost * Quantity  as 'Total'," _
                           + " Remarks " _
                           + " from tbltransferitem where batchcode = '" & Batchcode.Text & "'" _
                           + " order by datetrn asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "refcode"})

        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity"}, 3)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        'GridColumnAlignment(MyDataGridView, {"Total", "Unit Cost"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView, {"Total", "Unit Cost"})

    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewLocalparticulars()
    End Sub
End Class