Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmManualInventory

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmManualInventory()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region

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
        txtoffice.Text = compOfficename
        If GlobalDirectProductRegistration = True Then
            cmdAddProduct.Visible = True
            separatorProduct.Visible = True
        Else
            cmdAddProduct.Visible = False
            separatorProduct.Visible = False
        End If
        FillComboFromFile()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub FillComboFromFile()
        bid.Items.Clear()
        If bid.Text = "" Then
            bid.Items.Add(getGlobalTrnid(compOfficeid, globaluserid))
            bid.SelectedIndex = 0
        End If
        bid.SelectedIndex = 0
        loadTempParticular()
    End Sub
    Public Sub loadTempParticular()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select id,productid as 'Product ID', " _
                           + " (select itemname from tblglobalproducts where productid=tblinventorylogs.productid) as 'Particular', " _
                           + " Quantity, " _
                           + " Unit, " _
                           + " unitcost as 'Unit Cost', " _
                           + " Total " _
                           + " from tblinventorylogs where confirmed=0 and officeid='" & compOfficeid & "' order by datetrn asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        GridHideColumn(MyDataGridView, {"id"})
        GridColumnAlignment(MyDataGridView, {"Product ID", "Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost", "Total"})

    End Sub
    
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        If BeginningVendor = True Then
            frmInventorySelectParticular.Show(Me)
        Else
            MsgBox("beginning inventory not available at this time. please contact your procurement officer for setting up beginning vendor settings")
        End If
      
    End Sub

    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete.PerformClick()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show("Are you sure you want to confirm this batch inventory? " & Environment.NewLine & Environment.NewLine & "Note: Manual inventory will no longer available after confiming your transaction", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            Me.Cursor = Cursors.WaitCursor

            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("Select * from tblinventorylogs where confirmed=0 and officeid='" & compOfficeid & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    UpdateInventory("Manual Stock-In", "", .Rows(cnt)("officeid").ToString(), .Rows(cnt)("vendorid").ToString(), "", .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("unitcost").ToString())), .Rows(cnt)("remarks").ToString(), "", "")
                End With
            Next
            com.CommandText = "update tblinventorylogs set confirmed=1, batchcode='" & bid.Text & "' where confirmed=0 and officeid='" & compOfficeid & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & bid.Text & "', n_title='New uploaded inventory', n_description='" & bid.Text & " from " & StrConv(compOfficename, vbProperCase) & "', n_type='request', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
            com.CommandText = "update tblcompoffice set allowbeggininginventory=0 where officeid='" & compOfficeid & "'" : com.ExecuteNonQuery()

            allowbegginingInventory = False

            Me.Cursor = Cursors.Default
            If LCase(globalusername) = "root" Or allowbegginingInventory = True Then
                frmInventorySummary.cmdManualInventory.Visible = True
                frmInventorySummary.ToolStripSeparator7.Visible = True
            Else
                frmInventorySummary.cmdManualInventory.Visible = False
                frmInventorySummary.ToolStripSeparator7.Visible = False
            End If

            frmInventorySummary.tabFilter()
            loadTempParticular()
            MessageBox.Show("Your inventory was successfully updated! " & Environment.NewLine & Environment.NewLine _
                            & "Batch No#: " & bid.Text & Environment.NewLine _
                            & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                            & "You will check your inventory summary!" & Environment.NewLine & "Note: Please download or synch inventory to get updated data!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            FillComboFromFile()
        End If
    End Sub

    Private Sub bid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bid.SelectedIndexChanged
        loadTempParticular()
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    
    Private Sub cmdAddProduct_Click(sender As Object, e As EventArgs) Handles cmdAddProduct.Click
        frmProductRegistration.ShowDialog(Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "delete from tblinventorylogs where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            loadTempParticular()
        End If
    End Sub
End Class