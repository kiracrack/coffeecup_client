Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmRequisitionsView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        TabControl1.SelectedTab = tabOriginal
        ShowOriginalItems()

        TabControl1.SelectedTab = tabParticular
        ShowParticularsItems()
    End Sub

    Private Sub pid_TextChanged(sender As Object, e As EventArgs) Handles pid.TextChanged
        loaddetails(pid.Text)

        TabControl1.SelectedTab = tabOriginal
        ShowOriginalItems()

        TabControl1.SelectedTab = tabParticular
        ShowParticularsItems()
    End Sub
    Public Function loaddetails(ByVal id As String)
        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblrequisitions.officeid ) as 'office', " _
                                 + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'REQUEST', " _
                                 + " (select DESCRIPTION from tblrequesttype where POTYPEID = tblrequisitions.POTYPEID) as 'POTYPE', " _
                                 + " (select designation from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'DESIGNATION', " _
                                 + " (select fullname from tblhotelguest where guestid=tblrequisitions.allocatedexpense) as allocated, " _
                                 + " case when corporatelevel=1 then 'CORPORATE LEVEL' else 'BRANCH LEVEL' end as applevel," _
                                 + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from "  & sqlfiledir & ".tblattachmentlogs where refnumber = tblrequisitions.pid),'-') as 'Attachment' " _
                                 + " from tblrequisitions where PID='" & id & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtoffice.Text = rst("office").ToString
            txtRequestby.Text = rst("REQUEST").ToString
            txtDesignation.Text = rst("DESIGNATION").ToString
            txtdatereq.Text = rst("DATEREQUEST").ToString
            txtdetails.Text = rst("DETAILS").ToString
            txtpotype.Text = rst("POTYPE").ToString
            txtDisbursement.Text = rst("applevel").ToString
            txtAllocated.Text = rst("allocated").ToString
            If rst("revised") = True Then
                If TabControl1.TabPages.Contains(tabOriginal) = False Then
                    TabControl1.TabPages.Add(tabOriginal)
                End If
            Else
                TabControl1.TabPages.Remove(tabOriginal)
            End If
            If rst("Attachment").ToString = "-" Then
                cmdAttachment.Enabled = False
                cmdAttachment.Text = "Not Availaible"
            Else
                cmdAttachment.Enabled = True
                cmdAttachment.Text = rst("Attachment").ToString
            End If
        End While
        rst.Close()
        TextBoxColorCode(txtStatus)
        Return 0
    End Function

    Public Sub ShowParticularsItems()
        MyDataGridView_Particular.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionsitem.CATID ) as 'Category', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionsitem " _
                                + " where pid='" & pid.Text & "' order by (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Particular.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_Particular, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Particular, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        If MyDataGridView_Particular.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView_Particular.RowCount - 1
                totalsum = totalsum + MyDataGridView_Particular.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).Cells("Cost").Value = "Total"
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).Cells("Total").Value = totalsum
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView_Particular.Rows(MyDataGridView_Particular.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
        filterApprovalLogs(True, {pid.Text}, "", MyDataGridView_Approval)
    End Sub

    Public Sub ShowOriginalItems()
        MyDataGridView_Original.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionslogsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionslogsitem.CATID ) as 'Category', " _
                                + " QUANTITY as 'Quantity'," _
                                + " UNIT as 'Unit', " _
                                + " COST as 'Cost', " _
                                + " TOTAL as 'Total', " _
                                + " Remarks, " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionslogsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionslogsitem " _
                                + " where pid='" & pid.Text & "' order by (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionslogsitem.PRODUCTID )  asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView_Original.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_Original, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Original, {"Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        If MyDataGridView_Original.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView_Original.RowCount - 1
                totalsum = totalsum + MyDataGridView_Original.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView_Original.Rows(MyDataGridView_Original.RowCount - 1).Cells("Cost").Value = "Total"
            MyDataGridView_Original.Rows(MyDataGridView_Original.RowCount - 1).Cells("Total").Value = totalsum
            MyDataGridView_Original.Rows(MyDataGridView_Original.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView_Original.Rows(MyDataGridView_Original.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
        filterApprovalLogs(True, {pid.Text}, "", MyDataGridView_Approval)
    End Sub
    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView_Particular.CellFormatting
        On Error Resume Next
        Dim colCurrency As Array = {"Cost", "Total"}
        If Not IsNothing(e.Value) Then
            If IsNumeric(e.Value) Then
                For Each valueArr As String In colCurrency
                    If e.ColumnIndex = MyDataGridView_Particular.Columns(valueArr).Index Then
                        e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub MyDataGridView_Original_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView_Original.CellFormatting
        On Error Resume Next
        Dim colCurrency As Array = {"Cost", "Total"}
        If Not IsNothing(e.Value) Then
            If IsNumeric(e.Value) Then
                For Each valueArr As String In colCurrency
                    If e.ColumnIndex = MyDataGridView_Original.Columns(valueArr).Index Then
                        e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        ViewAttachmentPackage_Database({pid.Text}, "")
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        PrintDatagridview("Requisition Approval History<br/><strong>" & pid.Text & "</strong>", "Requisition Approval History", "Office: " & txtoffice.Text & "<br/>Requested By: " & txtRequestby.Text & "<br/>Request Type: " & txtpotype.Text, MyDataGridView_Approval, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        filterApprovalLogs(True, {pid.Text}, "", MyDataGridView_Approval)
    End Sub
End Class