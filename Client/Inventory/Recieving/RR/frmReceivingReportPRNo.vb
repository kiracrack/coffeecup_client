Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils

Public Class frmReceivingReportPRNo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmReceivingReportPRNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowPRnumber()
    End Sub

    Public Sub ShowPRnumber()
        LoadXgrid("select distinct requestref 'PR Number', (select companyname from tblglobalvendor where vendorid=tblreceivedreportitem.vendorid) as 'Supplier' from tblreceivedreportitem where rrnumber='" & rrnumber.Text & "'", "tblreceivedreportitem", Em, GridView1)
        XgridColAlign({"PR Number"}, GridView1, HorzAlignment.Center)
        GridView1.Columns("PR Number").Width = 150
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click
        frmRequisitionsView.pid.Text = GridView1.GetFocusedRowCellValue("PR Number").ToString()
        frmRequisitionsView.Show(Me)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowPRnumber()
    End Sub
     
End Class