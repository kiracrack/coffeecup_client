Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRecievedTransferConsumableitem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRecievedTransferConsumableitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ViewLocalparticulars()
    End Sub
    Public Sub ViewLocalparticulars()
        Try
            LoadXgrid("Select trnid,refcode,(select ITEMNAME from tblglobalproducts where PRODUCTID=tbltransferitem.itemid) as 'Particular', " _
                               + " Quantity, Unit, unitcost as 'Unit Cost', " _
                               + " unitcost * Quantity  as 'Total Cost'," _
                               + " Remarks " _
                               + " from tbltransferitem where batchcode = '" & batchcode.Text & "' " _
                               + " order by itemid asc", "tbltransferitem", Cm, Gridview1)

            XgridHideColumn({"trnid", "refcode"}, Gridview1)
            XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total Cost"}, 3, Gridview1)
            XgridColAlign({"Quantity", "Unit"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridGeneralSummaryCurrency({"Quantity", "Total Cost"}, Gridview1)
            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & Gridview1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Gridview1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    Gridview1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()
        Catch ex As Exception
            If ex.Message = "Object reference not set to an instance of an object." Then
                rst.Close()
                com.CommandText = "delete from tblcolumnindex where form='" & Me.Name & "' and gridview='" & Gridview1.Name & "'" : com.ExecuteNonQuery()
                ViewLocalparticulars()
            End If
        End Try
    End Sub
     
    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles Gridview1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, Gridview1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles Gridview1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, Gridview1)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewLocalparticulars()
    End Sub

    Private Sub PrintReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintReportToolStripMenuItem.Click
        DXPrintDatagridview("TRANSFER ITEM REQUEST", "List of item", Me.Text, Gridview1, Me)
    End Sub
End Class