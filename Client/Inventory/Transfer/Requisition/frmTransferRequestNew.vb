Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmTransferRequestNew

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
        Me.Cursor = Cursors.WaitCursor
        LoadToComboBoxDB("select * from tblcompoffice where officeid<>'" & compOfficeid & "' order by officename asc", "officename", "officeid", txtOffice)
        LoadToComboBoxDB("select * from tblaccounts where officeid='" & compOfficeid & "' and deleted=0 order by fullname asc", "fullname", "accountid", txtrequester)
        loadTempParticular()
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub loadTempParticular()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trnid, itemid,(select itemname from tblglobalproducts where productid=tbltransferrequestitem.itemid) as 'Product Name', Quantity,Unit,Remarks from tbltransferrequestitem where trnby='" & globaluserid & "' and processed=-1", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"trnid", "itemid"})
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Quantity"}, 4)
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        If txtOffice.Text = "" Then
            MessageBox.Show("Please select office!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        End If
        frmTransferRequestSelectParticular.officeid.Text = DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue
        frmTransferRequestSelectParticular.Show(Me)
    End Sub

    Private Sub cmdPrintPreview_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If CheckSelectedRow(MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            If MessageBox.Show("Are you sure you want to permanently delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "delete from tbltransferrequestitem where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                loadTempParticular()
            End If
        End If
    End Sub

    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete.PerformClick()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If txtOffice.Text = "" Then
            MessageBox.Show("Please select office!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.Focus()
            Exit Sub
        ElseIf txtrequester.Text = "" Then
            MessageBox.Show("Please select request by!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtrequester.Focus()
            Exit Sub
        ElseIf txtMessage.Text = "" Or txtMessage.Text = "Please enter message.." Then
            MessageBox.Show("Please enter message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMessage.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to send your request? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Batchcode As String = getStockRequestTransferSequenceNo()
            com.CommandText = "insert into tbltransferrequest set reqcode='" & Batchcode & "', " _
                                                + " inventory_from='" & DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue & "', " _
                                                + " inventory_to='" & compOfficeid & "', " _
                                                + " message='" & rchar(txtMessage.Text) & "', " _
                                                + " requestby='" & DirectCast(txtrequester.SelectedItem, ComboBoxItem).HiddenValue & "', " _
                                                + " daterequest=current_timestamp, " _
                                                + " trnby='" & globaluserid & "' " _
                                                + If(Globalenablestocktransferclearing = False, ", cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp ", "") : com.ExecuteNonQuery()

            com.CommandText = "INSERT INTO tbltransferrequestitemlogs (reqcode,itemid,quantity,unit,remarks,trnby,datetrn) select '" & Batchcode & "', itemid,quantity,unit,remarks,trnby,datetrn from tbltransferrequestitem where trnby='" & globaluserid & "' and processed=-1" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tbltransferrequestitem set reqcode='" & Batchcode & "', processed=0 where trnby='" & globaluserid & "' and processed=-1" : com.ExecuteNonQuery()

            com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & Batchcode & "', n_title='New transfer request', n_description='from " & StrConv(compOfficename, vbProperCase) & " to " & StrConv(txtOffice.Text, vbProperCase) & "', n_type='transfer', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0"
            com.ExecuteNonQuery()

            frmTransferRequisition.tabColumnOption()
            MessageBox.Show("Your request was successfully sent! " & Environment.NewLine & Environment.NewLine _
                            & "Batch No#: " & Batchcode & Environment.NewLine _
                            & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                            & "Please check your receiving of good inventory transfer regulary to monitor your request!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub bid_SelectedIndexChanged(sender As Object, e As EventArgs)
        loadTempParticular()
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdAddProduct_Click(sender As Object, e As EventArgs) Handles cmdAddProduct.Click
        frmProductRequest.Show(Me)
    End Sub
    Private Sub txtMessage_LostFocus(sender As Object, e As EventArgs) Handles txtMessage.LostFocus
        If txtMessage.Text = "" Then
            txtMessage.Text = "Please enter message.."
        End If
    End Sub
    Private Sub txtMessage_GotFocus(sender As Object, e As EventArgs) Handles txtMessage.GotFocus
        If txtMessage.Text = "Please enter message.." Then
            txtMessage.Text = ""
        End If
    End Sub


End Class