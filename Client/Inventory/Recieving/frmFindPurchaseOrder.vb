Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmFindPurchaseOrder
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            txtSearch.Focus()
            txtSearch.SelectAll()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmFindPurchaseOrder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmFindPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FilterDetails(txtSearch.Text)
    End Sub

    Public Sub FilterDetails(ByVal skey As String)
        If skey = "" Then Exit Sub
        'com.CommandText = "DROP temporary table if exists tmppendingdelivery;" : com.ExecuteNonQuery()
        'com.CommandText = "create temporary table tmppendingdelivery select * from tblpurchaseorderitem where delivered=0 " : com.ExecuteNonQuery()
        'com.CommandText = "ALTER TABLE `tmppendingdelivery` ADD INDEX `ponumber`(`ponumber`);" : com.ExecuteNonQuery()

        'LoadXgrid("select a.ponumber as 'PO Number', if((select count(*) from tmppendingdelivery where ponumber=a.ponumber)>0,'PENDING','FOR CLOSE') as Status, date_format(a.datetrn,'%Y-%m-%d') as 'Date', a.requestref as 'Request Reference', ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER') as 'Supplier',(select officename from tblcompoffice where officeid=a.officeid) as 'Office', sum(total) as 'Remaining Total' from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where " _
        '                 + " catid in (select catid from tblprocategory where " & If(ckAssets.Checked = True, "ffe=1", "consumable=1") & ") and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(ckAssets.Checked = True, If(compallowmanageffeotheroffice = True, "", "and a.officeid='" & compOfficeid & "'"), If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'")) & " " _
        '                 + " and (a.ponumber like '%" & txtSearch.Text & "%' or a.requestref like '%" & txtSearch.Text & "%' or (select officename from tblcompoffice where officeid=a.officeid) like '%" & txtSearch.Text & "%' or ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER') like '%" & txtSearch.Text & "%') group by b.ponumber order by a.datetrn asc;", "tblpurchaseorder", Em, GridView1)

        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select a.ponumber as 'PO Number', if((select count(ponumber) from tblpurchaseorderitem where ponumber=a.ponumber and delivered=0)>0,'PENDING','FOR CLOSE') as Status, date_format(a.datetrn,'%Y-%m-%d') as 'Date', a.requestref as 'Request Reference', ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER') as 'Supplier',(select officename from tblcompoffice where officeid=a.officeid) as 'Office', sum(total) as 'Total' from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where " _
                         + " catid in (select catid from tblprocategory where " & If(ckAssets.Checked = True, "ffe=1", "consumable=1") & ") and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(ckAssets.Checked = True, If(compallowmanageffeotheroffice = True, "", "and a.officeid='" & compOfficeid & "'"), If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'")) & " " _
                         + " and (a.ponumber like '%" & skey & "%' or a.requestref like '%" & skey & "%' or (select officename from tblcompoffice where officeid=a.officeid) like '%" & skey & "%' or ifnull((select companyname from tblglobalvendor where vendorid=a.vendorid),'DELETED SUPPLIER') like '%" & skey & "%') " & If(GLobalEnableCentralStockReceiving = True, "", " and (select companyid from tblcompoffice where officeid=a.officeid)='" & GlobalCompanyid & "'  ") & " group by b.ponumber order by a.datetrn asc;", "tblpurchaseorder", Em, GridView1)

        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst2, "tblpurchaseorder")
        XgridColCurrency({"Total"}, GridView1)
        XgridColWidth({"Total"}, GridView1, 80)
        XgridGeneralSummaryCurrency({"Total"}, GridView1)
        XgridColAlign({"PO Number", "Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        Em.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "FOR CLOSE" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.White
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            FilterDetails(txtSearch.Text)
        End If

    End Sub

    Private Sub Em_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Em.KeyPress
        If e.KeyChar() = Chr(13) Then
            ProceedSelection()
        End If
    End Sub
    Private Sub Em_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.DoubleClick
        ProceedSelection()
    End Sub

    Public Sub ProceedSelection()
        frmReceivedConsumable.ponumber.Text = GridView1.GetFocusedRowCellValue("PO Number").ToString
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            FilterDetails("%%%")
        Else
            FilterDetails(txtSearch.Text)
        End If
    End Sub
End Class