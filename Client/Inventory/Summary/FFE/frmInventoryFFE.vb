Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports System.Text


Public Class frmInventoryFFE
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmInventoryFFE_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim FFEDisposal As Integer = countqry("tblinventoryffe", "officeid='" & officeid.Text & "' and disposalrequested=1 and disposed=0")
        If FFEDisposal > 0 Then
            Dim ApprovedDisposal As Integer = countqry("tblinventoryffe", "officeid='" & officeid.Text & "' and disposalrequested=1 and disposalapproved=1 and disposed=0")
            If ApprovedDisposal > 0 Then
                cmdDisposal.Text = "Approved Disposal (" & ApprovedDisposal & ")"
                If globalFontColor = "LIGHT" Then
                    lineDisposal.ForeColor = Color.Gold
                Else
                    lineDisposal.ForeColor = Color.Red
                End If
                lineDisposal.Visible = True
            Else
                cmdDisposal.Text = "Request for Disposal (" & FFEDisposal & ")"
                If globalFontColor = "LIGHT" Then
                    cmdDisposal.ForeColor = Color.LightGray
                Else
                    cmdDisposal.ForeColor = Color.Black
                End If
                lineDisposal.Visible = True
            End If
            cmdDisposal.Visible = True
        Else
            If globalFontColor = "LIGHT" Then
                cmdDisposal.ForeColor = Color.LightGray
            Else
                cmdDisposal.ForeColor = Color.Black
            End If
            cmdDisposal.Visible = False
            lineDisposal.Visible = False
        End If
    End Sub
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadToComboBoxDB("SELECT * FROM tblprocategory where ffe=1 order by description asc;", "description", "catid", txtcategory)
        ViewLocalInventoryFFE()
        SecurityCheck()
        officeid.Text = compOfficeid
        If compallowmanageffeotheroffice = True Then
            lblOffice.Visible = True
            txtOffice.Visible = True
            lineOffice.Visible = True
            LoadOffice()
        Else
            lblOffice.Visible = False
            txtOffice.Visible = False
            lineOffice.Visible = False
        End If
    End Sub

    Public Sub LoadOffice()
        com.CommandText = "select * from tblcompoffice order by officename asc" : rst = com.ExecuteReader
        While rst.Read
            txtOffice.Items.Add(rst("officename").ToString())
        End While
        rst.Close()
        txtOffice.Text = compOfficename
    End Sub

    Public Sub SecurityCheck()
        If ckDisposed.Checked = True Then
            cmdEdit.Visible = False
            cmdTransfer.Visible = False
            cmdRequestforDisposal.Visible = False
        Else
            cmdEdit.Visible = True
            If LCase(globalusername) = "root" Or allowmanualffeinventory = True Or compallowmanageffeotheroffice = True Then
                cmdManualInventory.Visible = True
                lineManuelInventory.Visible = True
            Else
                cmdManualInventory.Visible = False
                lineManuelInventory.Visible = False
            End If
            cmdTransfer.Visible = True
            cmdRequestforDisposal.Visible = True
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewLocalInventoryFFE()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            ViewLocalInventoryFFE()
        End If
    End Sub

    Public Sub ViewLocalInventoryFFE()
        SecurityCheck()
        If compallowmanageffeotheroffice = True Then
            UpdateDepreciationInventory(officeid.Text)
        Else
            UpdateDepreciationInventory(compOfficeid)
        End If

        MyDataGridView.DataSource = Nothing : dst = New DataSet

        msda = New MySqlDataAdapter("Select ffecode as 'FFE Code'," _
                  + " productid as 'Product Code', " _
                  + " productname as 'Particular', " _
                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as 'FFE Type', " _
                  + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventoryffe.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
                  + " categoryname as 'Category', " _
                  + " Quantity, Unit, unitcost as 'Unit Cost', totalamount as Total, date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', " _
                  + " (select companyname from tblglobalvendor where vendorid=tblinventoryffe.vendorid) as 'Supplier', " _
                  + " if(warranty=1,date_format(warrantydate,'%Y-%m-%d'),'-') as 'Date Warranty', " _
                  + " bookvalue as 'Book Value', monthlydepreciation as 'Monthly Depreciation', date_format(lastdepreciationdate, '%Y-%m-%d') as 'Last Depreciation Date', " _
                  + " acctableperson as 'Accountable Person', date_format(acctdateissued, '%Y-%m-%d') as 'Date Issued', " _
                  + " case when disposed=1 then 'Disposed' else 'Actived' end as 'Status', " _
                  + " Flaged, " _
                  + " flagedreason as 'Flaged Reason', lockedediting " _
                  + " from tblinventoryffe where " & If(ckDisposed.Checked = True, " disposed=1 and ", " disposed=0 and ") & If(ckall.Checked = True, "", " catid='" & catid.Text & "' and ") & If(compallowmanageffeotheroffice = True, " officeid='" & officeid.Text & "' and ", " officeid='" & compOfficeid & "' and ") _
                  + " (ffecode like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " productname like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " acctableperson like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " categoryname like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " date_format(datepurchased, '%Y-%m-%d')  like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " date_format(warrantydate, '%Y-%m-%d')  like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " flagedreason like '%" & rchar(txtsearch.Text) & "%') order by productname asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"lockedediting"})
        GridColumnAlignment(MyDataGridView, {"FFE Code", "FFE Type", "Product Code", "Quantity", "Unit", "Status", "Date Purchased", "Date Warranty", "Last Depreciation Date", "Date Issued"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost", "Total", "Book Value", "Monthly Depreciation"})

        If MyDataGridView.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView.RowCount - 1
                totalsum = totalsum + MyDataGridView.Rows(i).Cells("Book Value").Value()
            Next
            MyDataGridView.Columns("Book Value").Width = 100
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Book Value").Value = totalsum
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
        For i = 0 To MyDataGridView.RowCount - 1
            If CBool(MyDataGridView.Item("Flaged", i).Value) = True Then
                MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
        GridColumnChoosed(MyDataGridView, Me.Name)

    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString = "Disposed" Then
            MessageBox.Show("Disposed item not allowed", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf MyDataGridView.Item("FFE Type", MyDataGridView.CurrentRow.Index).Value().ToString = "" Then
            MessageBox.Show(StrConv(MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString, VbStrConv.ProperCase) & " FFE type currently not configured! please contact system administrator" & Environment.NewLine & Environment.NewLine & "NOTE: Please contact the following Department base on product category." & Environment.NewLine & Environment.NewLine & "IT Equiptment Asset - IT Department Office" & Environment.NewLine & "FFE and Other Asset - Procurement Office ", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CBool(MyDataGridView.Item("lockedediting", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            MessageBox.Show("Editing not allowed!" & Environment.NewLine & Environment.NewLine & MyDataGridView.Item("Flaged Reason", MyDataGridView.CurrentRow.Index).Value().ToString, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmNewInventoryEntry.mode.Text = "edit"
        frmNewInventoryEntry.officeid.Text = officeid.Text
        frmNewInventoryEntry.ffecode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmNewInventoryEntry.Show(Me)
    End Sub
  

    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        ViewLocalInventoryFFE()
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        On Error Resume Next
        Dim colname As String = ""
        For i = 0 To MyDataGridView.ColumnCount - 1
            colname += MyDataGridView.Columns(i).Name & ","
        Next
        frmColumnChooser.txttype.Text = Me.Name
        frmColumnChooser.init_grid(MyDataGridView)
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
        frmColumnChooser.Show(Me)
    End Sub

 
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdManualInventory.Click
        frmNewInventoryEntry.officeid.Text = officeid.Text
        frmNewInventoryEntry.Show(Me)
    End Sub
   
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text + "<br/><strong>" + If(ckDisposed.Checked = True, "DISPOSED FFE REPORT", "ACTIVE FFE REPORT") + "</strong>", StrConv(txtOffice.Text, VbStrConv.ProperCase) & " FFE Inventory", If(ckall.Checked = True, "", "FILTERED: " & txtcategory.Text), MyDataGridView, Me)
    End Sub

    Private Sub PrintMemorandumOfReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMemorandumOfReceiptToolStripMenuItem.Click
        PrintFFeMR(MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString, Me)
    End Sub

    Private Sub cmdExportToExcel_Click(sender As Object, e As EventArgs) Handles cmdExportToExcel.Click
        ExportGridToExcel(Me.Text, dst)
    End Sub

    Private Sub cmdViewProfile_Click(sender As Object, e As EventArgs) Handles cmdViewProfile.Click
        frmNewInventoryEntry.mode.Text = "view"
        frmNewInventoryEntry.officeid.Text = officeid.Text
        frmNewInventoryEntry.ffecode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmNewInventoryEntry.Show(Me)
    End Sub

    Private Sub ckall_CheckedChanged(sender As Object, e As EventArgs) Handles ckall.CheckedChanged
        If ckall.Checked = True Then
            txtcategory.Enabled = False
            ViewLocalInventoryFFE()
        Else
            txtcategory.Enabled = True
        End If
    End Sub

    Private Sub ckDisposed_CheckedChanged(sender As Object, e As EventArgs) Handles ckDisposed.CheckedChanged
        ViewLocalInventoryFFE()
    End Sub

    Private Sub txtcategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtcategory.SelectedValueChanged
        If txtcategory.Text = "" Then Exit Sub
        catid.Text = DirectCast(txtcategory.SelectedItem, ComboBoxItem).HiddenValue()
        ViewLocalInventoryFFE()
    End Sub

    Private Sub txtOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtOffice.SelectedIndexChanged
        officeid.Text = qrysingledata("officeid", "officeid", "tblcompoffice where officename='" & txtOffice.Text & "'")
        ViewLocalInventoryFFE()
    End Sub

 
    Private Sub TransferFFEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        If CBool(MyDataGridView.Item("lockedediting", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            MessageBox.Show("Transfer not allowed!" & Environment.NewLine & Environment.NewLine & MyDataGridView.Item("Flaged Reason", MyDataGridView.CurrentRow.Index).Value().ToString, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmCreateTransferFFE.officeid_from.Text = officeid.Text
        frmCreateTransferFFE.txtFFECode.ReadOnly = True
        frmCreateTransferFFE.txtFFECode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmCreateTransferFFE.FFEDetails()
        frmCreateTransferFFE.Show()
    End Sub

    Private Sub RequestForDisposalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRequestforDisposal.Click
        If MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value() = "" Then Exit Sub
        If MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString = "Disposed" Then
            MessageBox.Show("Disposed item not allowed", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CBool(MyDataGridView.Item("lockedediting", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            MessageBox.Show("Request for disposal not allowed!" & Environment.NewLine & Environment.NewLine & MyDataGridView.Item("Flaged Reason", MyDataGridView.CurrentRow.Index).Value().ToString, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmFFERequestforDisposal.txtFFECode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmFFERequestforDisposal.txtDescription.Text = MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString
        frmFFERequestforDisposal.Show(Me)
    End Sub

    Private Sub ViewTransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionHistoryToolStripMenuItem.Click
        frmFFEHistory.ffecode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmFFEHistory.txtDescription.Text = MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString
        frmFFEHistory.Show(Me)
    End Sub

    Private Sub cmdDisposal_Click(sender As Object, e As EventArgs) Handles cmdDisposal.Click
        frmFFEforDisposalList.officeid.Text = officeid.Text
        frmFFEforDisposalList.Show(Me)
    End Sub

    Private Sub cmdSeparationOfQuantity_Click(sender As Object, e As EventArgs) Handles cmdSeparationOfQuantity.Click
        If CBool(MyDataGridView.Item("lockedediting", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            MessageBox.Show("Transfer not allowed!" & Environment.NewLine & Environment.NewLine & MyDataGridView.Item("Flaged Reason", MyDataGridView.CurrentRow.Index).Value().ToString, GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmSeparationOfQuantity.officeid_from.Text = officeid.Text
        frmSeparationOfQuantity.txtFFECode.ReadOnly = True
        frmSeparationOfQuantity.txtFFECode.Text = MyDataGridView.Item("FFE Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmSeparationOfQuantity.FFEDetails()
        frmSeparationOfQuantity.Show()
    End Sub
End Class