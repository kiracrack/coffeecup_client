Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmAdvanceSearch

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub
    Public Sub SearchByProduct()
        Dim saleQuery As String = ""
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        If EnableModuleSales = True Then
            saleQuery = "  case when (select consumable from tblprocategory where CATID = tblglobalproducts.CATID) = 1 then format(sellingprice,2) else '-' end as 'Selling Price' "
        Else
            saleQuery = " ifnull(ifnull((select procost from tblitemvendor where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by lastupdate asc limit 1), (select purchasedprice from tblinventory where productid=tblglobalproducts.productid and officeid = '" & compOfficeid & "' limit 1)),0) as 'Latest Cost', (select companyname from tblitemvendor inner join tblglobalvendor on tblglobalvendor.vendorid = tblitemvendor.vendorid  where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by procost asc limit 1) as 'Vendor' "
        End If
        msda = New MySqlDataAdapter("Select PRODUCTID as 'Item Code', " _
                           + " ITEMNAME as 'Particulars', " _
                           + " (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category', Unit," & saleQuery _
                           + "  from tblglobalproducts where ITEMNAME like '%" & rchar(txtfilter.Text) & "%' and actived=1" _
                           + " order by ITEMNAME asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        If EnableModuleSales = True Then
            GridColumnAlignment(MyDataGridView, {"Selling Price"}, DataGridViewContentAlignment.MiddleRight)
        Else
            GridColumnAlignment(MyDataGridView, {"Latest Cost"}, DataGridViewContentAlignment.MiddleRight)
        End If
        GridColumnAlignment(MyDataGridView, {"Item Code", "Unit"}, DataGridViewContentAlignment.MiddleCenter)

    End Sub
    Public Sub SearchByRequest()
        MsgBox("Features not available yet..", vbExclamation)
    End Sub
    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        On Error Resume Next
        If txtSearchOption.Text = "Particular Item" Then
            Dim colCurrency As Array = {"Latest Cost"}
            If Not IsNothing(e.Value) Then
                If IsNumeric(e.Value) Then
                    For Each valueArr As String In colCurrency
                        If e.ColumnIndex = MyDataGridView.Columns(valueArr).Index Then
                            e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                        End If
                    Next
                End If
            End If
        End If

    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearchOption.Text = "" Then
                MessageBox.Show("Please select search option Type!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSearchOption.Focus()
                Exit Sub
            End If
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            If txtSearchOption.Text = "Request Status" Then
                SearchByRequest()
            ElseIf txtSearchOption.Text = "Particular Item" Then
                SearchByProduct()
            End If
        End If
    End Sub
End Class