Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmReportGenerator
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmReportGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadReportType()
    End Sub

    Public Sub LoadReportType()
        LoadToComboBoxDB("SELECT * from tblreporttemplatetype where code in (select filtercode from tblreportfilter where permissioncode='" & globalAuthcode & "')", "Description", "code", txtReportType)
    End Sub

    Private Sub txtReportType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtReportType.SelectedValueChanged
        If txtReportType.Text = "" Then Exit Sub
        reportype.Text = DirectCast(txtReportType.SelectedItem, ComboBoxItem).HiddenValue()
        LoadReportTemplate()
    End Sub

    Public Sub LoadReportTemplate()
        LoadToComboBoxDB("SELECT * from tblreporttemplate where reporttype='" & reportype.Text & "' and status=1 order by rptname asc", "rptname", "rptid", txtReportName)
    End Sub

    Private Sub txtReportName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtReportName.SelectedValueChanged
        If txtReportName.Text = "" Then Exit Sub
        id.Text = DirectCast(txtReportName.SelectedItem, ComboBoxItem).HiddenValue()
        com.CommandText = "select * from tblreporttemplate where rptid='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            ckDateQuery.Checked = rst("datequery")
            If CBool(rst("datequery")) = True Then
                date_from.Enabled = True
                date_to.Enabled = True
            Else
                date_from.Enabled = False
                date_to.Enabled = False
            End If
        End While
        rst.Close()
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        filter()
    End Sub

    Public Sub filter()
        Dim strquery As String = ""
        Try
            dst.Clear()
            com.CommandText = "select * from tblreporttemplate where rptid='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strquery = DecryptTripleDES(rst("rptquery").ToString)
                If rst("datequery") = True Then
                    strquery = rDateSelect(strquery, date_from.Text, date_to.Text)
                End If
            End While
            rst.Close()

            LoadXgrid(strquery, 0, Em, gridview1)

            com.CommandText = "select * from tblreportconfig where rptid='" & id.Text & "' order by sortorder asc"
            rst = com.ExecuteReader
            While rst.Read

                If rst("colgroup") = True Then
                    gridview1.Columns(rst("colname").ToString).Group()
                    gridview1.ExpandAllGroups()
                End If

                If Val(rst("coltype").ToString) = 0 Then
                    gridview1.Columns(rst("colname").ToString).ColumnEdit = MemoEdit

                    If rst("alignment").ToString = "L" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Default)
                    ElseIf rst("alignment").ToString = "C" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Center)
                    ElseIf rst("alignment").ToString = "R" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Far)
                    End If

                ElseIf Val(rst("coltype").ToString) = 1 Then
                    gridview1.Columns(rst("colname").ToString).Width = 120
                    XgridColCurrency({rst("colname").ToString}, gridview1)
                    XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Far)

                ElseIf Val(rst("coltype").ToString) = 2 Then
                    gridview1.Columns(rst("colname").ToString).Width = 120
                    XgridColNumber(rst("colname").ToString, gridview1)

                    If rst("alignment").ToString = "C" Then
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Center)
                    Else
                        XgridColAlign({rst("colname").ToString}, gridview1, DevExpress.Utils.HorzAlignment.Far)
                    End If

                End If

                If rst("colgrpsum") = True Then
                    Dim splitother As String() = rst("colgrpsumtext").ToString.Split(New Char() {","c})
                    For Each idword In splitother
                        Dim item1 As New GridGroupSummaryItem()
                        item1.FieldName = idword
                        If rst("colgrpsumtype").ToString = "SUM" Then
                            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            item1.DisplayFormat = "{0:n}"
                        Else
                            item1.SummaryType = DevExpress.Data.SummaryItemType.Count
                            item1.DisplayFormat = "{0:N0}"
                        End If
                        item1.ShowInGroupColumnFooter = gridview1.Columns(idword)
                        gridview1.GroupSummary.Add(item1)
                    Next
                End If

                If rst("colgensum") = True Then
                    If rst("colgensumtype").ToString = "SUM" Then
                        gridview1.Columns(rst("colname").ToString).SummaryItem.SummaryType = SummaryItemType.Sum
                        gridview1.Columns(rst("colname").ToString).SummaryItem.DisplayFormat = rst("colgensumtext").ToString & " {0:n}"
                    Else
                        gridview1.Columns(rst("colname").ToString).SummaryItem.SummaryType = SummaryItemType.Count
                        gridview1.Columns(rst("colname").ToString).SummaryItem.DisplayFormat = rst("colgensumtext").ToString & " {0:N0}"
                    End If
                    gridview1.Columns(rst("colname").ToString).SummaryItem.Tag = 1
                    CType(gridview1.Columns(rst("colname").ToString).View, GridView).OptionsView.ShowFooter = True
                End If
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Query:" & strquery & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        Catch errMS As Exception
            XtraMessageBox.Show("Query:" & strquery & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        End Try
    End Sub

    Public Function rDateSelect(ByVal str As String, ByVal sFromdate As Date, ByVal sTodate As Date)
        Dim from_dateSel As Date = sFromdate
        Dim to_dateSel As Date = sTodate

        ' CONVERTION FROM DATE SELECT
        Dim from_RFullDate As String = ConvertDate(date_from.Text)
        Dim from_RMonthDate As String = from_dateSel.ToString("MM")
        Dim from_RDayDate As String = from_dateSel.ToString("dd")
        Dim from_RYearDate As String = from_dateSel.Year
        str = str.Replace("{from_fulldate}", from_RFullDate)
        str = str.Replace("{from_year}", from_RYearDate)
        str = str.Replace("{from_month}", from_RMonthDate)
        str = str.Replace("{from_day}", from_RDayDate)

        ' CONVERTION TO DATE SELECT
        Dim to_RFullDate As String = ConvertDate(date_to.Text)
        Dim to_RMonthDate As String = to_dateSel.ToString("MM")
        Dim to_RDayDate As String = to_dateSel.ToString("dd")
        Dim to_RYearDate As String = to_dateSel.Year
        str = str.Replace("{to_fulldate}", to_RFullDate)
        str = str.Replace("{to_year}", to_RYearDate)
        str = str.Replace("{to_month}", to_RMonthDate)
        str = str.Replace("{to_day}", to_RDayDate)
        Return str
    End Function
    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        ExportGridToExcel(RemoveSpecialCharacter(Me.Text), dst)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXPrintDatagridview(txtReportType.Text & "<br/><strong>" & txtReportName.Text & "</strong>", "REPORT DETAILS", If(ckDateQuery.Checked = True, "Report period from " & CDate(date_from.Value).ToString("MMMM, dd yyyy") & " to " & CDate(date_to.Value).ToString("MMMM, dd yyyy"), ""), gridview1, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filter()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ExportGridToExcel(UCase(txtReportName.Text), dst)
    End Sub
End Class