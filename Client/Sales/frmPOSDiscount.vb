Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSDiscount
    Public ConfirmedEdit As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSEditLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionInformation()
        LoadToComboBoxDB("select * from tblglobalproducts where allownegativeinputs=1 " & If(GlobalenableProductFilter = True, " and catid in (select categorycode from tblproductfilter where permissioncode='" & globalAuthcode & "')", "") & " and deleted=0 order by itemname asc", "itemname", "productid", txtDiscountType)
        txtDiscountType.Text = defaultCombobox(txtDiscountType, Me, False)
        productid.Text = defaultCombobox(txtDiscountType, Me, True)
        txtAmount.Text = ""
    End Sub
    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Transaction Reference # " & txtBatchcode.Text & ")"
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0")), 2)
        txtDiscountedAmount.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0")), 2)
    End Sub
    Public Sub ComputeTransaction()
        If txtTotalOnScreen.Text = "" Then Exit Sub
        txtAmount.Text = FormatNumber(Val(CC(txtDiscountedAmount.Text)) * (Val(CC(txtDiscountRate.Text)) / 100), 2)
        If Val(CC(txtAmount.Text)) > 0 Then
            Me.AcceptButton = cmdConfirm
        End If
    End Sub

    Private Sub productid_TextChanged(sender As Object, e As EventArgs) Handles productid.TextChanged
        If productid.Text = "" Then Exit Sub
        com.CommandText = "select * from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDiscountRate.Text = FormatNumber(rst("sellingprice").ToString, 2)
            If Val(rst("sellingprice").ToString) = 0 Then
                txtAmount.ReadOnly = False
                Me.AcceptButton = Nothing
            Else
                txtAmount.ReadOnly = True
                Me.AcceptButton = cmdConfirm
            End If
        End While
        rst.Close()
        ComputeTransaction()
    End Sub

    Private Sub txtDiscountType_DropDownClosed(sender As Object, e As EventArgs) Handles txtDiscountType.DropDownClosed
        txtAmount.Focus()
        txtAmount.SelectAll()
    End Sub

    Private Sub txtDiscountType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountType.KeyPress
        If e.KeyChar() = Chr(13) Then
            If Val(CC(txtAmount.Text)) = 0 Then
                txtAmount.Focus()
            End If
        End If
    End Sub
 
    Private Sub txtDiscountType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDiscountType.SelectedValueChanged
        If txtDiscountType.Text = "" Then Exit Sub
        productid.Text = DirectCast(txtDiscountType.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtDiscountType.Text = "" Then
            MsgBox("Please select discount type!", MsgBoxStyle.Exclamation, "Error Message")
            txtDiscountType.Focus()
            Exit Sub
        End If
        Dim discountOveride As String = ""
        If MessageBox.Show("Posting discount requires an administrative approval! " & Environment.NewLine & Environment.NewLine & "If you want to overide current discount click YES to enter autorized account or NO to submit it as for approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                discountOveride = ", adjoveride=1, adjoverideby='" & frmPOSAdminConfirmation.userid.Text & "' "
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If
        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmPointOfSale.PostSalesTransaction(False, productid.Text, 1, -Val(CC(txtAmount.Text)), 0, discountOveride)
            Me.Close()
        End If
    End Sub

    Private Sub txtDiscountRate_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountRate.TextChanged
        ComputeTransaction()
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If Val(CC(txtAmount.Text)) > 0 Then
            Me.AcceptButton = cmdConfirm
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub txtDiscountedAmount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountedAmount.TextChanged
        ComputeTransaction()
    End Sub
End Class