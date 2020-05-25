Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSReviseCurrentInvoice
    Dim DefaultglItemLocation As String
    Dim defaultglCode As String
    Dim defaultglItem As String
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

    End Sub

    Public Sub FilterTransaction(ByVal batchcode As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select datetrn, productname as 'Particular', sum(Quantity) as 'Quantity', Unit, sellprice as 'Unit Price'," & If(Globalenablechittransaction = True, "chitsellprice as 'Chit Price',", "") & " distotal as 'Discount', subtotal as 'Sub Total',  " & If(Globalenablechittransaction = True, "chittotal as 'Total Chit',", "") & "total as 'Total Amount' from tblsalestransaction where batchcode='" & batchcode & "' group by batchcode,productid union all " _
                                            + " select current_timestamp,'',null,'',null," & If(Globalenablechittransaction = True, "null,", "") & " null,null," & If(Globalenablechittransaction = True, "null,", "") & "sum(total) from tblsalestransaction where batchcode='" & batchcode & "') as s  order by datetrn asc;", conn)

        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"datetrn"})
        GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Price", "Discount", "Sub Total", "Total Amount", If(Globalenablechittransaction = True, "Chit Price", Nothing), If(Globalenablechittransaction = True, "Total Chit", Nothing)})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit", "Unit Price"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Discount", "Sub Total", "Total Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub


    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalAmount.KeyPress
        InputNumberOnly(txtTotalAmount, e)
    End Sub

    Private Sub batchcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferenceNumber.KeyPress
        If e.KeyChar() = Chr(13) Then
            ValiidateTransaction()
        End If
    End Sub
    Public Sub ValiidateTransaction()
        If countqry("tblsalesclientcharges", "(batchcode='" & txtReferenceNumber.Text & "' or invoiceno='" & txtReferenceNumber.Text & "') and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 Then
            Dim getBatchCode As String = qrysingledata("batchcode", "batchcode", "tblsalesclientcharges where (batchcode='" & txtReferenceNumber.Text & "' or invoiceno='" & txtReferenceNumber.Text & "') and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'")
            If countqry("tblsalesbatch", "userid='" & globalAssistantUserId & "' and batchcode='" & getBatchCode & "'") > 0 Then
                com.CommandText = "select *,(select companyname from tblclientaccounts where cifid=tblsalesclientcharges.accountno) as client from tblsalesclientcharges where (batchcode='" & txtReferenceNumber.Text & "' or invoiceno='" & txtReferenceNumber.Text & "') and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
                While rst.Read
                    txtBatchcode.Text = rst("batchcode").ToString
                    txtTotalAmount.Text = FormatNumber(rst("amount").ToString, 2)
                    txtClientName.Text = rst("client").ToString
                End While
                rst.Close()
                FilterTransaction(txtBatchcode.Text)
                cmdConfirm.Enabled = True
                Me.AcceptButton = cmdConfirm
            Else
                MsgBox("Only user " & StrConv(qrysingledata("transactionby", "(select fullname from tblaccounts where accountid=tblsalesbatch.userid) as transactionby", "tblsalesbatch where batchcode='" & getBatchCode & "'"), vbProperCase) & " is allowed to revise this transaction!", MsgBoxStyle.Exclamation)
                txtBatchcode.Text = "" : txtTotalAmount.Text = "0.00"
                Me.AcceptButton = Nothing
                cmdConfirm.Enabled = False
            End If
        Else
            txtBatchcode.Text = "" : txtTotalAmount.Text = "0.00"
            MsgBox("Record not found!", MsgBoxStyle.Exclamation)
            Me.AcceptButton = Nothing
            cmdConfirm.Enabled = False
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If MessageBox.Show("This transaction needs an administrative login approval! Are you sure you want to revise current transaction?  " & Environment.NewLine & Environment.NewLine & "NOTE: Previous invoice will be cancelled! are you sure you  want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                VoidForReviseTransaction(txtBatchcode.Text)
                com.CommandText = "update tblsalesbatch set floattrn=1 where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                frmPointOfSale.cifid.Text = qrysingledata("val", "cifid as 'val'", "tblsalesbatch where batchcode='" & txtBatchcode.Text & "'")
                frmPointOfSale.txtClient.Text = qrysingledata("val", "(select companyname from tblclientaccounts where cifid=tblsalesbatch.cifid) as 'val'", "tblsalesbatch where batchcode='" & txtBatchcode.Text & "'")
                 
                frmPointOfSale.txtBatchcode.Text = txtBatchcode.Text
                frmPointOfSale.ValidatePOSTransaction(txtBatchcode.Text)
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
                Me.Close()
            End If
        Else
            MsgBox("Current transaction was locked by another user!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class