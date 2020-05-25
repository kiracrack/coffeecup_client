Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSDeliverySlip
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSDeliverySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadBranches()
        ListView1.View = View.Details
        ListView1.Columns.Add("Particular", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("trnid", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Quantity", -2, HorizontalAlignment.Center)
        ListView1.Columns.Add("Unit", -2, HorizontalAlignment.Left)
        ListView1.Columns(0).Width = 250
        ListView1.Columns(1).Width = 0
        ListView1.Columns(2).Width = 90
        ListView1.Columns(3).Width = 90
 
        LoadRemarks()
        tabSeparator.SelectedTab = tabTransaction
        FilterTransaction()
        tabSeparator.SelectedTab = tabPost
        createTransactionID()
        ' txtfrmdate.Value = Now
    End Sub
    Public Sub createTransactionID()
        If GLobalsalesdeliverysequence = True Then
            txtReferenceNumber.ReadOnly = True
            txtReferenceNumber.Text = getPOSSalesDeliverySequence()
            com.CommandText = "UPDATE tblgeneralsettings set salesdeliverysequence='" & txtReferenceNumber.Text & "'" : com.ExecuteNonQuery()
        Else
            txtReferenceNumber.ReadOnly = False
        End If
    End Sub
    Public Sub LoadRemarks()
        CreateHTMLReportTemplate("SalesDelivery.txt")
        LoadToComboBoxTxt(txtTransactionType, Application.StartupPath.ToString & "\Templates\SalesDelivery.txt")
    End Sub
    Public Sub LoadBranches()
        txtBranch.Items.Clear()
        com.CommandText = "select * from tblcompoffice where officename not like '%CORPORATE%' order by officename asc" : rst = com.ExecuteReader
        While rst.Read
            txtBranch.Items.Add(New ComboBoxItem(rst("officename").ToString, rst("officeid").ToString))
        End While
        rst.Close()
    End Sub
    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedIndexChanged
        If txtBranch.Text <> "" Then
            officeid.Text = DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            officeid.Text = ""
        End If
    End Sub
    Public Sub FilterTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id,refcode as 'Transaction No.', datecreated,clientname as 'Client Name',clientaddress as 'Address', (select sum(quantity) from tblsalestransaction inner join tblsalesdeliveryitem on id = tblsalesdeliveryitem.refitem where tblsalesdeliveryitem.refcode = tblsalesdeliveryslip.refcode) as 'Total Items', " _
                                            + " (select officename from tblcompoffice where officeid = tblsalesdeliveryslip.requestto) as 'Location', Remarks as 'Transaction Type' from tblsalesdeliveryslip where trnsumcode = '" & globalSalesTrnCOde & "' and cancelled=0 order by datecreated asc ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Address").Width = 300
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("datecreated").Visible = False
        GridColumnAlignment(MyDataGridView, {"Total Items", "Transaction No."}, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub


    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtbatchcode.Text = "" Then
            MessageBox.Show("Invalid transaction reference number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSearchCode.Focus()
            Exit Sub
        ElseIf ListView1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select item", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtReferenceNumber.Text = "" Then
            MessageBox.Show("Please enter Transaction number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReferenceNumber.Focus()
            Exit Sub
        ElseIf txtClientName.Text = "" Then
            MessageBox.Show("Please enter client name", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClientName.Focus()
            Exit Sub
        ElseIf txtBranch.Text = "" Then
            MessageBox.Show("Please select location", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBranch.Focus()
            Exit Sub
        ElseIf txtTransactionType.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTransactionType.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtBranch, txtBranch.Text, DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            SaveDefaultComboItem(txtTransactionType, txtTransactionType.Text, txtTransactionType.Text, Me)
            com.CommandText = "insert into tblsalesdeliveryslip set refcode='" & txtReferenceNumber.Text & "', trnsumcode='" & globalSalesTrnCOde & "', trnrefsumcode='" & txttrnsumcode.Text & "', batchcode='" & txtbatchcode.Text & "',clientname='" & rchar(txtClientName.Text) & "',clientaddress='" & rchar(txtAddress.Text) & "', requestfrom='" & compOfficeid & "', requestto='" & officeid.Text & "', remarks='" & rchar(txtTransactionType.Text) & "', createdby='" & globaluserid & "', datecreated=current_timestamp" : com.ExecuteNonQuery()
            For Each itm As ListViewItem In ListView1.CheckedItems
                com.CommandText = "delete from tblsalesdeliveryitem where refitem='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblsalesdeliveryitem set refcode='" & txtReferenceNumber.Text & "', trnrefsumcode='" & txttrnsumcode.Text & "', batchcode='" & txtbatchcode.Text & "', refitem='" & itm.SubItems(1).Text & "', trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            Next

            If MessageBox.Show("Do you want to print acknowlegement receipt transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If LCase(Globalsalesdeliverytemplate) = "pos" Then
                    If globalEnablePosPrinter = True Then
                        PrintPOSDeliverySlip(txtReferenceNumber.Text, txtClientName.Text, txtBranch.Text, ListView1, False)
                        If MessageBox.Show("Print receipt for merchant copy? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            PrintPOSDeliverySlip(txtReferenceNumber.Text, txtClientName.Text, txtBranch.Text, ListView1, True)
                        End If
                    End If
                Else
                    GenerateLXSalesDelivery(txtTransactionType.SelectedIndex, txtReferenceNumber.Text, txtClientName.Text, txtAddress.Text, txtReferenceNumber.Text, txtBranch.Text, txtTransactionType.Text, Me)
                End If
            End If
            txtSearchCode.Text = ""
            createTransactionID()
            FilterTransaction()
            TraceTransaction()
            txtClientName.Text = ""
            txtAddress.Text = ""
            ListView1.Items.Clear()
            txtSearchCode.Focus()
            MsgBox("Transaction Successfully posted!", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "UPDATE tblsalesdeliveryslip set cancelled=1,datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where refcode='" & rw.Cells("Transaction No.").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesdeliveryitem set cancelled=1  where refcode='" & rw.Cells("Transaction No.").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub referencenumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchCode.KeyPress
        If e.KeyChar() = Chr(13) Then
            If countqry("tblsalesbatch", "(batchcode='" & rchar(txtSearchCode.Text) & "' or invoiceno='" & rchar(txtSearchCode.Text) & "')") = 0 Then
                MsgBox("Reference code was not found in the system! Please try again..", MsgBoxStyle.Exclamation)
                txtSearchCode.SelectAll()
                txtSearchCode.Focus()
                Exit Sub
            End If
            TraceTransaction()
        End If
    End Sub
    Public Sub TraceTransaction()
        com.CommandText = "select *,(select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid and walkinaccount=0) as 'client',(select compadd from tblclientaccounts where cifid = tblsalesbatch.cifid and walkinaccount=0) as 'address' from tblsalesbatch where (batchcode='" & txtSearchCode.Text & "' or invoiceno='" & txtSearchCode.Text & "') and void=0 and onhold=0" : rst = com.ExecuteReader
        While rst.Read
            txtbatchcode.Text = rst("batchcode").ToString
            txttrnsumcode.Text = rst("trnsumcode").ToString
            txtClientName.Text = rst("client").ToString
            txtAddress.Text = rst("address").ToString
        End While
        rst.Close()

        ListView1.Items.Clear()
        com.CommandText = "select * from tblsalestransaction inner join tblprocategory on tblsalestransaction.catid = tblprocategory.catid where consumable=1 and batchcode='" & txtbatchcode.Text & "' and tblsalestransaction.id not in (select refitem from tblsalesdeliveryitem where batchcode='" & txtbatchcode.Text & "' and cancelled=0) and cancelled=0 and void=0 " : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("productname").ToString, 0)
            item1.SubItems.Add(rst("id").ToString)
            item1.SubItems.Add(rst("Quantity").ToString)
            item1.SubItems.Add(rst("Unit").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub ViewItemTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewItemTransactionToolStripMenuItem.Click
        frmPOSDeliveryItem.refcode.Text = MyDataGridView.Item("Transaction No.", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSDeliveryItem.Show(Me)
    End Sub

    Private Sub ReprintTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprintTransactionToolStripMenuItem.Click
        If LCase(Globalsalesdeliverytemplate) = "pos" Then
            If globalEnablePosPrinter = True Then
                For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                    RePrintPOSTransaction(rw.Cells("Transaction No.").Value.ToString, "tblsalesdeliveryslip", "refcode", "receipt")
                Next
            End If
        Else
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\DELIVERY\" & rw.Cells("Transaction No.").Value.ToString & ".html"
                Me.WindowState = FormWindowState.Minimized
                PrintLXReceipt(SaveLocation.Replace("\", "/"), Me)
            Next
        End If
    End Sub

    Private Sub txtClientHistoryName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClientHistoryName.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtClientHistoryName.Text = "" Or txtClientHistoryName.Text = "%" Then Exit Sub
            If countqry("tblsalesdeliveryslip", " concat(date_format(datecreated,'%Y-%m-%d'), ' - ',refcode,' - ', clientname)  = '" & rchar(txtClientHistoryName.Text) & "'") = 0 Then
                LoadToComboBoxDB("select refcode, concat(date_format(datecreated,'%Y-%m-%d'), ' - ',refcode,' - ', clientname) as 'client' from tblsalesdeliveryslip where (date_format(datecreated,'%Y-%m-%d') like '%" & rchar(txtClientHistoryName.Text) & "%' or batchcode like '%" & rchar(txtClientHistoryName.Text) & "%' or refcode like '%" & rchar(txtClientHistoryName.Text) & "%' or clientname like '%" & rchar(txtClientHistoryName.Text) & "%' or clientaddress like '%" & rchar(txtClientHistoryName.Text) & "%') and cancelled=0;", "client", "refcode", txtClientHistoryName)
                txtClientHistoryName.DroppedDown = True
            Else
                viewTraceinfo()
            End If
        End If
    End Sub

    Public Sub viewTraceinfo()
        Dim refcode As String = ""
        If txtClientHistoryName.Text.Length > 0 Then
            refcode = DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue()
        End If
        com.CommandText = "select * from tblsalesdeliveryslip where refcode='" & refcode & "'" : rst = com.ExecuteReader
        While rst.Read
            txtTraceTransactionDate.Text = rst("datecreated").ToString
            txtHistoryBatchcode.Text = rst("batchcode").ToString
        End While
        rst.Close()

        DataGridView1.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid, productname as 'Product Name', Quantity, Unit from tblsalestransaction inner join tblsalesdeliveryitem on tblsalestransaction.id = tblsalesdeliveryitem.refitem where refcode='" & refcode & "'", conn)

        msda.Fill(dst, 0)
        DataGridView1.DataSource = dst.Tables(0)
        GridHideColumn(DataGridView1, {"trnid"})
        GridColumnAlignment(DataGridView1, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        txtHistoryBatchcode.Text = qrysingledata("batchcode", "batchcode", "tblsalesdeliveryslip where refcode='" & refcode & "'")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If txtClientHistoryName.Text = "" Then
            MsgBox("Please validate client!", MsgBoxStyle.Exclamation)
            txtClientName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In DataGridView1.SelectedRows
                com.CommandText = "DELETE FROM tblsalesdeliveryitem where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
            Next

            'com.CommandText = "UPDATE tblsalesdeliveryslip set cancelled=1,datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
            'com.CommandText = "UPDATE tblsalesdeliveryitem set cancelled=1  where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
            createTransactionID()
            txtSearchCode.Text = txtHistoryBatchcode.Text
            TraceTransaction()
            txtClientName.Text = qrysingledata("clientname", "clientname", "tblsalesdeliveryslip where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'")
            txtAddress.Text = qrysingledata("clientaddress", "clientaddress", "tblsalesdeliveryslip where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'")

            tabSeparator.SelectedIndex = 0
            FilterTransaction()
            viewTraceinfo()
        End If
    End Sub

    Private Sub CorrectTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrectTransactionToolStripMenuItem.Click
        If txtbatchcode.Text = "" Then
            MsgBox("Please validate client!", MsgBoxStyle.Exclamation)
            txtClientHistoryName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("This transaction will be cancelled in order to correct new entry! Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblsalesdeliveryslip set cancelled=1,datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblsalesdeliveryitem set cancelled=1  where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
            createTransactionID()
            txtSearchCode.Text = txtHistoryBatchcode.Text
            TraceTransaction()
            txtClientName.Text = qrysingledata("clientname", "clientname", "tblsalesdeliveryslip where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'")
            txtAddress.Text = qrysingledata("clientaddress", "clientaddress", "tblsalesdeliveryslip where refcode='" & DirectCast(txtClientHistoryName.SelectedItem, ComboBoxItem).HiddenValue() & "'")

            tabSeparator.SelectedIndex = 0
            FilterTransaction()
            viewTraceinfo()
        End If
    End Sub

    Private Sub txtClientHistoryName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClientHistoryName.SelectedIndexChanged
        txtTraceTransactionDate.Text = ""
        txtHistoryBatchcode.Text = ""
    End Sub
End Class