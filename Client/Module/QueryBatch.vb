Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Module QueryBatch
    Public PurchaseOrderStatus As String
    Public RequisitionCorporateStatus As String
    Public Sub loadBatchQuery()
        PurchaseOrderStatus = "case when tblpurchaseorder.cancelled=1 and tblpurchaseorder.expired=0 then 'CANCELLED' " _
                                           + " when tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=1 then 'EXPIRED' " _
                                           + " when tblpurchaseorder.verified=0 and tblpurchaseorder.delivered=0 and tblpurchaseorder.paymentrequested=0 and tblpurchaseorder.paymentupdated=0 and tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=0 then 'FOR APPROVAL' " _
                                           + " when tblpurchaseorder.verified=1 and tblpurchaseorder.delivered=0 and tblpurchaseorder.paymentrequested=0 and tblpurchaseorder.paymentupdated=0 and tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=0 then 'APPROVED' " _
                                           + " when tblpurchaseorder.verified=1 and tblpurchaseorder.paymentrequested=0 and tblpurchaseorder.paymentupdated=0 and tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=0 then 'DELIVERED' " _
                                           + " when tblpurchaseorder.verified=1 and tblpurchaseorder.paymentrequested=1 and tblpurchaseorder.paymentupdated=0 and tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=0 then 'PENDING PAYMENT' " _
                                           + " when tblpurchaseorder.verified=1 and tblpurchaseorder.paymentrequested=1 and tblpurchaseorder.paymentupdated=1 and closed=0 and tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=0 then 'DISBURSED' " _
                                           + " when tblpurchaseorder.verified=1 and tblpurchaseorder.paymentrequested=1 and tblpurchaseorder.paymentupdated=1 and closed=1 and tblpurchaseorder.cancelled=0 and tblpurchaseorder.expired=0 then 'CLOSED' end as 'Status', "

        RequisitionCorporateStatus = "case when cancelled=1 and disapproved=0 then 'CANCELLED' " _
                                         + " when cancelled=0 and disapproved=1 then 'DISAPPROVED' " _
                                         + " when hold=1 then 'On Hold' " _
                                         + " when approvedbranch=0 then 'FOR APPROVAL' " _
                                         + " when approvedbranch=1 and approvedcorporate=0 then 'FOR APPROVAL' " _
                                         + " else 'APPROVED' end as 'Status', "

    End Sub

    Public Function TextBoxColorCode(ByVal txtbox As System.Windows.Forms.TextBox)
        If txtbox.Text = "APPROVED" Then
            txtbox.BackColor = Color.Lime
            txtbox.ForeColor = Color.Black

        ElseIf txtbox.Text = "CLOSED" Then
            txtbox.BackColor = Color.Gold
            txtbox.ForeColor = Color.Black

        ElseIf txtbox.Text = "FOR APPROVAL" Or txtbox.Text = "ON HOLD" Or txtbox.Text = "PENDING PAYMENT" Then
            txtbox.BackColor = Color.DarkOrange
            txtbox.ForeColor = Color.Black

        ElseIf txtbox.Text = "DISAPPROVED" Or txtbox.Text = "CANCELLED" Then
            txtbox.BackColor = Color.Red
            txtbox.ForeColor = Color.White

        ElseIf txtbox.Text = "DELIVERED" Or txtbox.Text = "DISBURSED" Then
            txtbox.BackColor = Color.LightSeaGreen
            txtbox.ForeColor = Color.Black
        End If
        Return 0
    End Function

    Public Function filterApprovalLogs(ByVal viewbymainreference As Boolean, ByVal refnumber As Array, ByVal transactiontype As String, ByVal gridview As System.Windows.Forms.DataGridView)
        Dim refno As String = ""
        If viewbymainreference = True Then
            For Each str As String In refnumber
                refno += "mainreference = '" & str & "' or "
            Next
        Else
            For Each str As String In refnumber
                refno += "referenceno = '" & str & "' or "
            Next
        End If

        If refno <> "" Then
            refno = refno.Remove(refno.Length - 3, 3)
        End If
        gridview.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select CONFIRMBY as 'Confirmed by', " _
                      + " Position, " _
                      + " tblapprovalhistory.REMARKS as 'Remarks', " _
                      + " CONCAT(UCASE(SUBSTRING(tblapprovalhistory.`status`, 1, 1)),LOWER(SUBSTRING(tblapprovalhistory.`status`, 2)))  as 'Status', " _
                      + " appdescription as 'Transaction Type'," _
                      + " date_format(DATECONFIRM,'%Y-%m-%d %r') as 'Date Confirmed' " _
                      + " from tblapprovalhistory WHERE " & refno & If(transactiontype = "", "", " and appdescription='" & transactiontype & "'") & "  order by dateconfirm asc", conn)

        msda.Fill(dst, 0)
        gridview.DataSource = dst.Tables(0)
        GridColumnAlignment(gridview, {"Transaction Type", "Status"}, DataGridViewContentAlignment.MiddleCenter)
        Return 0
    End Function

    Public Function filterApprovalLogsGridview(ByVal viewbymainreference As Boolean, ByVal refnumber As Array, ByVal transactiontype As String, ByVal Em As GridControl, ByVal grv As GridView)
        Dim refno As String = ""
        If viewbymainreference = True Then
            For Each str As String In refnumber
                refno += "mainreference = '" & str & "' or "
            Next
        Else
            For Each str As String In refnumber
                refno += "referenceno = '" & str & "' or "
            Next
        End If

        If refno <> "" Then
            refno = refno.Remove(refno.Length - 3, 3)
        End If

        LoadXgrid("select CONFIRMBY as 'Confirmed by', " _
                      + " Position, " _
                      + " tblapprovalhistory.REMARKS as 'Remarks', " _
                      + " CONCAT(UCASE(SUBSTRING(tblapprovalhistory.`status`, 1, 1)),LOWER(SUBSTRING(tblapprovalhistory.`status`, 2)))  as 'Status', " _
                      + " appdescription as 'Transaction Type'," _
                      + " date_format(DATECONFIRM,'%Y-%m-%d %r') as 'Date Confirmed' " _
                      + " from tblapprovalhistory WHERE " & refno & If(transactiontype = "", "", " and appdescription='" & transactiontype & "'") & "  order by dateconfirm asc", "tblapprovalhistory", Em, grv)


        XgridColAlign({"Transaction Type", "Status"}, grv, DevExpress.Utils.HorzAlignment.Center)
         
        Return 0
    End Function

End Module

