Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmUnitConverter

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmUnitConverter()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F3 Then
            cmdFind.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        FilterDetails()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        frmUnitConverterInfo.Show(Me)
    End Sub

    Public Sub FilterDetails()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select convcode, (select itemname from tblglobalproducts where productid=tblunitconverter.productid) as 'Target Conversion', " _
                                        + " (select unit from tblglobalproducts where productid=tblunitconverter.productid) as 'Unit Unit', " _
                                        + " group_concat((select (select itemname from tblglobalproducts where productid=tblunitconverterdetails.productid) from tblunitconverterdetails where convcode=tblunitconverter.convcode)) as 'Source Conversion' from tblunitconverter group by convcode; ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"convcode"})
    End Sub
    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        Dim colCurrency As Array = {"Selling Amount", "Converted Unit Cost"}
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
    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete.PerformClick()
        End If
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdOnlineData_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmUnitConverterInfo.mode.Text = "edit"
        frmUnitConverterInfo.id.Text = MyDataGridView.Item("convcode", MyDataGridView.CurrentRow.Index).Value().ToString
        frmUnitConverterInfo.Show(Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want continue delete?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "delete from tblunitconverter where convcode='" & rw.Cells("convcode").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblunitconverterdetails where convcode='" & rw.Cells("convcode").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterDetails()
        End If
    End Sub

   
End Class