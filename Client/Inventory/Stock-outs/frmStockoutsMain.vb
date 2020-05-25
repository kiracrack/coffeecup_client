Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.Utils

Public Class frmStockoutsMain

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        filter()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        filter()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            filter()
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        filter()
    End Sub

    Public Sub filter()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(postingdate,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(postingdate,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If

        LoadXgrid("Select  ID,BatchCode, date_format(postingdate,'%Y-%m-%d') as 'Stockout Date', (select officename from tblcompoffice where officeid=tblstockoutitem.officeid) as 'Office', " _
                            + " (select itemname from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                            + " (select description from tblprocategory where CATID = tblstockoutitem.CATID) as 'Category', " _
                            + " refcode as 'Stock ID', " _
                            + " Quantity,Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',  Remarks, " _
                            + " (select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as 'Stockout Type',  " _
                            + " (select fullname from tblaccounts where accountid=tblstockoutitem.trnby) as 'Transaction By', date_format(datetrn,'%Y-%m-%d %r') as 'Date Transaction' " _
                            + " from tblstockoutitem where confirmed=1 and officeid='" & compOfficeid & "' " & filterasof & " and ((select itemname from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) like '%" & rchar(txtsearch.Text) & "%')", "tblstockoutitem", Em, GridView1)

        XgridColAlign({"ID", "Series No.", "Quantity", "Unit", "Stockout Date", "Stockout Time"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridColCurrencyDecimalCount({"Quantity", "Unit Cost", "Total Cost"}, 3, GridView1)
        XgridColAlign({"BatchCode", "Stockout Date", "Stock ID", "Stockout Date"}, GridView1, HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Cost"}, GridView1)
    End Sub

    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        filter()
    End Sub


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmBatchStockout.Show(Me)
    End Sub

    Private Sub cmdPrint_Click_1(sender As Object, e As EventArgs) Handles cmdPrint.Click
        DXPrintDatagridview(Me.Text, "Stockout Transaction History", "Stockout transaction period from " & CDate(txtfrmdate.Text).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Text).ToString("MMMM, dd yyyy"), GridView1, Me)
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

End Class