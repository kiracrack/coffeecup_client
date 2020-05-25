Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSClientAccountTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtGLItem.Items.Clear()
        com.CommandText = "select * from tbltransactioncode order by itemname asc" : rst = com.ExecuteReader
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()

        txtClient.Items.Clear()
        If Globalenableclientfilter = True Then
            com.CommandText = "select * from tblclientaccounts where groupcode in (select clientgroup from tblclientfilter where permissioncode='" & globalAuthcode & "') and walkinaccount=0 and approved=1 and deleted=0 order by companyname asc" : rst = com.ExecuteReader
        Else
            com.CommandText = "select * from tblclientaccounts where approved=1 and walkinaccount=0 and deleted=0 order by companyname asc" : rst = com.ExecuteReader
        End If
        While rst.Read
            txtClient.Items.Add(New ComboBoxItem(rst("companyname").ToString, rst("cifid").ToString))
        End While
        rst.Close()

        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)

        If GLobalclientjournalsequence = True Then
            txtReferenceNumber.ReadOnly = True
            txtReferenceNumber.Text = getPOSClientJournalSecquence()
        Else
            txtReferenceNumber.ReadOnly = False
        End If

        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
        If GLobalclientjournalsequence = True Then
            txtReferenceNumber.ReadOnly = True
            txtReferenceNumber.Text = getPOSClientJournalSecquence()
            com.CommandText = "UPDATE tblgeneralsettings set clientjournalsequence='" & txtReferenceNumber.Text & "'" : com.ExecuteNonQuery()
        Else
            txtReferenceNumber.ReadOnly = False
        End If
    End Sub

    Public Sub FilterTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select id,accountno, datetrn, (select itemname from tbltransactioncode where itemcode = tblsalesaccounttransaction.itemcode) as 'Description', (select companyname from tblclientaccounts where cifid = tblsalesaccounttransaction.accountno) as 'Client', Remarks, Debit as 'Amount', datetrn as 'Date Post', case when affectcash = 1 then 'Yes' else 'No' end as 'Affect Cash' from tblsalesaccounttransaction where trnsumcode = '" & globalSalesTrnCOde & "' and tblsalesaccounttransaction.cancelled=0 union all " _
                                            + " select '','' ,current_timestamp, '', '', 'Total', sum(debit), '','' from tblsalesaccounttransaction where trnsumcode = '" & globalSalesTrnCOde & "' and tblsalesaccounttransaction.cancelled=0) as s order by datetrn asc ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Remarks").Width = 300
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("datetrn").Visible = False
        MyDataGridView.Columns("accountno").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridColumnAlignment(MyDataGridView, {"Affect Cash"}, DataGridViewContentAlignment.MiddleCenter)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtGLItem.Text = "" Then
            MessageBox.Show("Please select item name type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGLItem.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MessageBox.Show("Please select client account", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClient.Focus()
            Exit Sub
        
        ElseIf Val(CC(txtDebit.Text)) <= 0 Then
            MessageBox.Show("Please enter amount!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDebit.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            com.CommandText = "insert into tblsalesaccounttransaction set officeid='" & compOfficeid & "', trnsumcode='" & globalSalesTrnCOde & "', itemcode='" & itemcode.Text & "',accountno='" & cifcode.Text & "',referenceno='" & txtReferenceNumber.Text & "', debit='" & Val(CC(txtDebit.Text)) & "', remarks='" & rchar(txtRemarks.Text) & "',affectcash='" & ckAffectCash.CheckState & "',trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            If ckQuotation.Checked = True Then
                If AddAttachmentPackage(qrysingledata("id", "id", "tblsalesaccounttransaction where trnby='" & globaluserid & "' order by id desc limit 1"), "sales_other_transaction", {txtattached1.Text}) = False Then
                    Exit Sub
                End If
            End If
            If MessageBox.Show("Do you want to print acknowlegement receipt transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If LCase(Globalclientjournaltemplate) = "pos" Then
                    If globalEnablePosPrinter = True Then
                        PrintPOSClientJournalReceipt(txtReferenceNumber.Text, txtClient.Text, txtGLItem.Text, txtRemarks.Text, Val(CC(txtDebit.Text)), False)
                        If MessageBox.Show("Print receipt for merchant copy? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            PrintPOSClientJournalReceipt(txtReferenceNumber.Text, txtClient.Text, txtGLItem.Text, txtRemarks.Text, Val(CC(txtDebit.Text)), True)
                        End If
                    End If
                Else
                    GenerateLXClientJournal(txtClient.Text, qrysingledata("compadd", "compadd", "tblclientaccounts where cifid='" & cifcode.Text & "'"), txtGLItem.Text, txtRemarks.Text, Val(CC(txtDebit.Text)), txtReferenceNumber.Text, Me)
                End If
            End If
            
            MsgBox("Transaction Successfully saved!", MsgBoxStyle.Information)
            FilterTransaction()
            txtRemarks.Text = ""
            txtDebit.Text = "0.00"
        End If
    End Sub

    Private Sub txtGLItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGLItem.SelectedIndexChanged
        If txtGLItem.Text <> "" Then
            itemcode.Text = DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            itemcode.Text = ""
        End If
    End Sub
    Private Sub txtClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClient.SelectedIndexChanged
        If txtClient.Text <> "" Then
            cifcode.Text = DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            cifcode.Text = ""
        End If
    End Sub


    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblsalesaccounttransaction set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtDebit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebit.KeyPress
        InputNumberOnly(txtDebit, e)
    End Sub
    
    Private Sub ckQuotation_CheckedChanged(sender As Object, e As EventArgs) Handles ckQuotation.CheckedChanged
        If ckQuotation.Checked = True Then
            cmda1.Enabled = True
        Else
            txtattached1.Text = ""
            cmda1.Enabled = False
        End If
    End Sub

    Private Sub txtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Process.Start(Application.StartupPath & "\attachment.pdf")
    End Sub

    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmda1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "All Types (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'txtattached1.Text = objOpenFileDialog.FileName
                If checkAttachment(objOpenFileDialog.FileName) = False Then
                    txtattached1.BackColor = Color.Red
                Else
                    txtattached1.BackColor = Color.White
                    If (Not System.IO.Directory.Exists(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")) Then
                        System.IO.Directory.CreateDirectory(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")
                    End If
                    System.IO.File.Delete(file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                    System.IO.File.Copy(objOpenFileDialog.FileName, file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                End If
                txtattached1.Text = file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName)
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub
End Class