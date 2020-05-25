Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSCouponCharge
    Public TransactionDone As Boolean = False
    Dim DefaultglItemLocation As String
    Dim defaultglCode As String
    Dim defaultglItem As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSDueTo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionInformation()

    End Sub
 
    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Transaction Reference # " & txtBatchcode.Text & ")"
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and tblsalestransaction.cancelled=0")), 2)
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If countqry("tblsalescoupon", "couponcode='" & txtCouponCode.Text & "' and verified=1") > 0 Then
            MsgBox("Coupon code already in used!", MsgBoxStyle.Exclamation, "Error Message")
            txtCouponCode.Focus()
            Me.AcceptButton = Nothing
            Exit Sub
        ElseIf countqry("tblsalescoupon", "couponcode='" & txtCouponCode.Text & "' and verified=0") = 0 Then
            MsgBox("Coupon code not found!", MsgBoxStyle.Exclamation, "Error Message")
            txtCouponCode.Focus()
            Me.AcceptButton = Nothing
            Exit Sub
        End If
        If Val(CC(txtTotalOnScreen.Text)) <> Val(CC(txtCouponAmount.Text)) Then
            MsgBox("Total transaction amount did not match to the coupon amount!", MsgBoxStyle.Exclamation, "Error Message")
            txtCouponCode.Focus()
            Me.AcceptButton = Nothing
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblsalescoupon set verified=1, verifiedby='" & globaluserid & "', dateverified=current_timestamp, verifiedoffice='" & compOfficeid & "',verifiedbatchcode='" & txtBatchcode.Text & "', verifiedtrnsumcode='" & globalSalesTrnCOde & "' where couponcode='" & txtCouponCode.Text & "'" : com.ExecuteNonQuery()

            Dim seriesno As String = GetPOSSeriesNumber(compOfficeid)
            com.CommandText = "update tblsalesbatch set amounttendered='" & Val(CC(txtTotalOnScreen.Text)) & "',seriesno='" & seriesno & "', paymenttype='coupon', amountchange=0, floattrn=0, processed=1, dateprocess=current_timestamp where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            If globalEnablePosPrinter = True Then
                If MessageBox.Show("Do you want to print acknowledgement receipt? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    PrintPOSCouponVerified(txtBatchcode.Text, txtCouponCode.Text, txtTotalOnScreen.Text, frmPointOfSale.MyDataGridView)
                End If
            End If
            TransactionDone = True
            Me.Close()
        End If
    End Sub

    Private Sub txtInvoiceNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCouponCode.KeyPress
        If e.KeyChar = Chr(13) Then
            If countqry("tblsalescoupon", "couponcode='" & txtCouponCode.Text & "' and verified=1") > 0 Then
                MsgBox("Coupon code already in used!", MsgBoxStyle.Exclamation, "Error Message")
                txtCouponCode.Focus()
                Me.AcceptButton = Nothing
                Exit Sub
            ElseIf countqry("tblsalescoupon", "couponcode='" & txtCouponCode.Text & "' and verified=0") = 0 Then
                MsgBox("Coupon code not found!", MsgBoxStyle.Exclamation, "Error Message")
                txtCouponCode.Focus()
                Me.AcceptButton = Nothing
                Exit Sub
            End If
            ShowCouponInfo()
        Else
            InputNumberOnly(txtCouponCode, e)
        End If
    End Sub
    Public Sub ShowCouponInfo()
        com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product from tblsalescoupon where couponcode='" & txtCouponCode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtCouponDetails.Text = rst("product").ToString
            txtCouponAmount.Text = FormatNumber(Val(rst("total").ToString), 2)
        End While
        rst.Close()
        Me.AcceptButton = cmdConfirmPayment
    End Sub

   
End Class