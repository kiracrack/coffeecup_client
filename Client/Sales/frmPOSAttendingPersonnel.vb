Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSAttendingPersonnel
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
      
        End If
        Return ProcessCmdKey
    End Function
 
    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadSalesPerson()
      
    End Sub
 
    Public Sub loadSalesPerson()
        txtSalesPerson.Items.Clear()
       com.CommandText = "select distinct accountid, if(nickname is null or nickname ='' ,fullname,ucase(nickname))  as 'name' from tblaccounts order by fullname  asc" : rst = com.ExecuteReader
        While rst.Read
            txtSalesPerson.Items.Add(New ComboBoxItem(rst("name").ToString, rst("accountid").ToString))
        End While
        rst.Close()
    End Sub

    Private Sub txtSalesPerson_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSalesPerson.KeyDown
        salesid.Text = ""
        If e.KeyData = Keys.Enter Then
            If txtSalesPerson.Text = "" Or txtSalesPerson.Text = "%" Then Exit Sub
            If countqry("tblaccounts", " if(nickname is null or nickname ='' ,fullname,ucase(nickname)) = '" & txtSalesPerson.Text & "'") = 0 Then
                com.CommandText = "select distinct accountid, if(nickname is null or nickname ='' ,fullname,ucase(nickname))  as 'name' from tblaccounts where coffeecupposition in (select authcode from tbluserauthority where pointofsaleassistant=1) " & If(Globaldefaultsalespersonpermission = "", "", " or coffeecupposition = '" & Globaldefaultsalespersonpermission & "'") & " order by if(nickname is null or nickname ='' ,fullname,ucase(nickname)) asc" : rst = com.ExecuteReader
                While rst.Read
                    txtSalesPerson.Items.Add(New ComboBoxItem(rst("name").ToString, rst("accountid").ToString))
                End While
                rst.Close()
            Else
                salesid.Text = DirectCast(txtSalesPerson.SelectedItem, ComboBoxItem).HiddenValue()
                validateTransaction()
            End If
        End If
    End Sub

    Private Sub salesid_TextChanged(sender As Object, e As EventArgs) Handles salesid.TextChanged
        validateTransaction()
    End Sub

    Private Sub txtPaymentAmount_TextChanged(sender As Object, e As EventArgs)
        validateTransaction()
    End Sub

    Public Sub validateTransaction()
        If salesid.Text = "" Then
            cmdConfirmPayment.Enabled = False
            Me.AcceptButton = Nothing
        Else
            cmdConfirmPayment.Enabled = True
            Me.AcceptButton = cmdConfirmPayment
        End If
    End Sub

    Private Sub txtSalesPerson_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtSalesPerson.SelectedValueChanged
        salesid.Text = DirectCast(txtSalesPerson.SelectedItem, ComboBoxItem).HiddenValue()
        validateTransaction()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If salesid.Text = "" Then
            MsgBox("Please enter attending personnel!", MsgBoxStyle.Exclamation, "Error Message")
            Exit Sub
        End If
        Me.Close()
    End Sub
End Class