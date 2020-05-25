Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSCharges
    Public ConfirmedEdit As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSCharges_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub

    Private Sub frmPOSEditLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionInformation()
        LoadToComboBoxDB("select * from tblglobalproducts where chargesitem=1 and deleted=0 order by itemname asc", "itemname", "productid", txtDiscountType)
        txtDiscountType.Text = defaultCombobox(txtDiscountType, Me, False)
        productid.Text = defaultCombobox(txtDiscountType, Me, True)
        txtTotalCharges.Text = ""
    End Sub
    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Transaction Reference # " & txtBatchcode.Text & ")"
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0")), 2)
        txtTotalCharges.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0")), 2)
    End Sub
    Public Sub ComputeTransaction()
        If txtTotalOnScreen.Text = "" Then Exit Sub
        txtTotalCharges.Text = FormatNumber(Val(CC(txtTotalOnScreen.Text)) * (Val(CC(txtDiscountRate.Text)) / 100), 2)
        If Val(CC(txtTotalCharges.Text)) > 0 Then
            Me.AcceptButton = cmdConfirm
        End If
    End Sub

    Private Sub productid_TextChanged(sender As Object, e As EventArgs) Handles productid.TextChanged
        If productid.Text = "" Then Exit Sub
        com.CommandText = "select * from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDiscountRate.Text = FormatNumber(rst("sellingprice").ToString, 2)
            If Val(rst("sellingprice").ToString) = 0 Then
                Me.AcceptButton = Nothing
            Else
                Me.AcceptButton = cmdConfirm
            End If
        End While
        rst.Close()
        ComputeTransaction()
    End Sub

    Private Sub txtDiscountType_DropDownClosed(sender As Object, e As EventArgs) Handles txtDiscountType.DropDownClosed
        txtTotalCharges.Focus()
        txtTotalCharges.SelectAll()
    End Sub

    Private Sub txtDiscountType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountType.KeyPress
        If e.KeyChar() = Chr(13) Then
            If Val(CC(txtTotalCharges.Text)) = 0 Then
                txtTotalCharges.Focus()
            End If
        End If
    End Sub

    Private Sub txtDiscountType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDiscountType.SelectedValueChanged
        If txtDiscountType.Text = "" Then Exit Sub
        productid.Text = DirectCast(txtDiscountType.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtDiscountType.Text = "" Then
            MsgBox("Please select charges type!", MsgBoxStyle.Exclamation, "Error Message")
            txtDiscountType.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmPointOfSale.PostSalesTransaction(False, productid.Text, 1, Val(CC(txtTotalCharges.Text)), 0, "")
            Me.Close()
        End If
    End Sub

    Private Sub txtDiscountRate_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountRate.TextChanged
        ComputeTransaction()
    End Sub
 
    Private Sub txtDiscountedAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCharges.TextChanged
        ComputeTransaction()
    End Sub
End Class