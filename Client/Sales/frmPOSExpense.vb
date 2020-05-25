Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSExpense
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        com.CommandText = "select * from tblglitem where sl=1 and itemcode in (select itemcode from tblglaccountfilter where permissioncode='" & globalAuthcode & "')  order by itemname asc" : rst = com.ExecuteReader
        txtGLItem.Items.Clear()
        While rst.Read
            txtGLItem.Items.Add(New ComboBoxItem(rst("itemname").ToString, rst("itemcode").ToString))
        End While
        rst.Close()
        txtRemarks.Text = ""
        txtAmount.Text = "0.00"

        txtGLItem.Text = defaultCombobox(txtGLItem, Me, False)
        itemcode.Text = defaultCombobox(txtGLItem, Me, True)

        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
        LoadSystemCashEnd()
    End Sub

    Public Sub LoadSystemCashEnd()
        com.CommandText = "call sp_salesremittance('CONSOLIDATED','" & globalSalesTrnCOde & "','')" : com.ExecuteNonQuery()
        com.CommandText = "select * from tmpconsolidateddetails where trntype='cash'" : rst = com.ExecuteReader
        While rst.Read
            txtCurrentCash.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()
    End Sub

    Public Sub FilterTransaction()
        dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select id,datetrn, (select itemname from tblglitem where itemcode=tblexpenses.glitemcode) as 'Description', Remarks,  Amount, ornumber as 'OR Number', datetrn as 'Date Post' from tblexpenses where duefromcode = '" & globalSalesTrnCOde & "' and cancelled=0 union all " _
                                    + " select '',current_timestamp, '', 'Total', sum(amount),'', '' from tblexpenses where duefromcode = '" & globalSalesTrnCOde & "' and tblexpenses.cancelled=0) as s order by datetrn asc", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Remarks").Width = 500
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("datetrn").Visible = False
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridColumnAlignment(MyDataGridView, {"OR Number"}, DataGridViewContentAlignment.MiddleCenter)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtGLItem.Text = "" Then
            MessageBox.Show("Please select expense type", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGLItem.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        ElseIf Val(CC(txtAmount.Text)) <= 0 Then
            MessageBox.Show("Please enter proper amount", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmount.Focus()
            Exit Sub
            'ElseIf ckAffectCash.Checked = True And Val(CC(txtAmount.Text)) > Val(CC(txtCurrentCash.Text)) Then
            '    MessageBox.Show("Insufficient current cash", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txtAmount.Focus()
            '    Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SaveDefaultComboItem(txtGLItem, txtGLItem.Text, DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue(), Me)
            com.CommandText = "insert into tblexpenses set officeid='" & compOfficeid & "', datetrn=current_timestamp, glitemcode='" & itemcode.Text & "',duefromcode='" & globalSalesTrnCOde & "',amount='" & Val(CC(txtAmount.Text)) & "', remarks='" & rchar(txtRemarks.Text) & "', ornumber='" & txtORNumber.Text & "', affectcash='" & ckAffectCash.CheckState & "',trnby='" & globaluserid & "', postransaction=1" : com.ExecuteNonQuery()
            If ckQuotation.Checked = True Then
                If AddAttachmentPackage(qrysingledata("id", "id", "tblexpenses where trnby='" & globaluserid & "'  order by id desc limit 1"), "sales_expenses", {txtattached1.Text}) = False Then
                    Exit Sub
                End If
            End If
            MsgBox("Expenses Successfully saved!", MsgBoxStyle.Information)

            FilterTransaction()
            txtRemarks.Text = ""
            txtAmount.Text = "0.00"
        End If
    End Sub

    Private Sub txtGLItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGLItem.SelectedIndexChanged
        If txtGLItem.Text <> "" Then
            itemcode.Text = DirectCast(txtGLItem.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            itemcode.Text = ""
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        InputNumberOnly(txtAmount, e)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblexpenses set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub
   
    Private Sub txtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Process.Start(Application.StartupPath & "\attachment.pdf")
    End Sub

    Private Sub ckQuotation_CheckedChanged(sender As Object, e As EventArgs) Handles ckQuotation.CheckedChanged
        If ckQuotation.Checked = True Then
            cmda1.Enabled = True
        Else
            txtattached1.Text = ""
            cmda1.Enabled = False
        End If
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

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If Val(CC(txtAmount.Text)) > 0 Then
            Me.AcceptButton = cmdConfirm
        End If
    End Sub
End Class