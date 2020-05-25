Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmReviewRecivedItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FilterDetails()
    End Sub
   
    Public Sub FilterDetails()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  trnid, (select ITEMNAME from tblglobalproducts where PRODUCTID = tblpurchaseorderitem.PRODUCTID ) as 'Particular', " _
                                    + " QUANTITY as 'Quantity',Cost, Total " _
                                    + " from tblpurchaseorderitem " _
                                    + " where ponumber='" & ponumber.Text & "'", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid"})
        GridColumnAlignment(MyDataGridView, {"Quantity"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

    End Sub
    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        Dim colCurrency As Array = {"Cost", "Total"}
        For Each valueArr As String In colCurrency
            If Not IsNothing(e.Value) Then
                If IsNumeric(e.Value) Then
                    If e.ColumnIndex = MyDataGridView.Columns(valueArr).Index Then
                        e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                    End If
                End If
            End If
        Next
    End Sub
       
End Class