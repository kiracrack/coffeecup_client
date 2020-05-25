Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmPOSDeliveryItem
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
        msda = New MySqlDataAdapter("Select trnid, productname as 'Product Name', Quantity, Unit from tblsalestransaction inner join tblsalesdeliveryitem on tblsalestransaction.id = tblsalesdeliveryitem.refitem where refcode='" & refcode.Text & "'", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid"})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        Dim colCurrency As Array = {"Quantity"}
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

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "DELETE FROM tblsalesdeliveryitem where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterDetails()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub
End Class