Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmClinicNewPackage
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmAutoNewServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text <> "edit" Then
            txtReference.Text = getPOSClinicSequenceNumber(clinicid.Text)
        Else
            LoadServicesInfo()
            txtReference.ReadOnly = False
        End If
    End Sub
    Public Sub LoadServicesInfo()
        Dim ref As String = "" : Dim salesid As String = "" : Dim salesProduct As String = ""
        com.CommandText = "select *, (select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'customer' " _
                           + " from tblclinicservices where trnid='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtReference.Text = rst("servicecode").ToString
            txtClientName.Text = rst("customer").ToString
            cifid.Text = rst("clientcif").ToString
            ref = rst("batchcode").ToString
            txtTotal.Text = FormatNumber(rst("amount").ToString, 2)
            txtRemarks.Text = rst("remarks").ToString

            salesid = rst("salestrnid").ToString
            salesProduct = rst("salestrnid").ToString & "-" & rst("packagename").ToString
        End While
        rst.Close()

        txtBatchcodeRef.Text = ref
        ValidateProduct()
        salestrnid.Text = salesid
        txtProduct.Text = salesProduct
    End Sub
  
    Private Sub batchcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBatchcodeRef.KeyPress
        If e.KeyChar() = Chr(13) Then
            ValidateProduct()
        End If
    End Sub
    Public Sub ValidateProduct()
        txtProduct.Items.Clear()
        Dim batch_code As String = ""
        If countqry("tblsalesbatch", "(batchcode='" & rchar(txtBatchcodeRef.Text) & "' or invoiceno='" & rchar(txtBatchcodeRef.Text) & "') and void=0 and onhold=0 and floattrn=0") = 0 And countqry("tblsalesclientcharges", "invoiceno='" & rchar(txtBatchcodeRef.Text) & "' and cancelled=0 ") = 0 Then
            MsgBox("Reference code was not found in the system! Please try again..", MsgBoxStyle.Exclamation)
            txtBatchcodeRef.SelectAll()
            txtBatchcodeRef.Focus()
            Exit Sub
        Else
            If countqry("tblsalesbatch", "(batchcode='" & rchar(txtBatchcodeRef.Text) & "' or invoiceno='" & rchar(txtBatchcodeRef.Text) & "') and void=0 and onhold=0 and floattrn=0") > 0 Then
                batch_code = qrysingledata("batchcode", "batchcode", "tblsalesbatch where (batchcode='" & rchar(txtBatchcodeRef.Text) & "' or invoiceno='" & rchar(txtBatchcodeRef.Text) & "') ")
            Else
                batch_code = qrysingledata("batchcode", "batchcode", "tblsalesclientcharges where invoiceno='" & rchar(txtBatchcodeRef.Text) & "'")
            End If
            batchcode.Text = batch_code
        End If

        dst = New DataSet
        msda = New MySqlDataAdapter("select id,productname from tblsalestransaction where batchcode='" & batch_code & "' and catid in (select catid from tblprocategory where noninventory=1) and cancelled=0 and void=0", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If .Rows(cnt)("productname").ToString() <> "" Then
                    txtProduct.Items.Add(New ComboBoxItem(.Rows(cnt)("id").ToString() & "-" & .Rows(cnt)("productname").ToString(), .Rows(cnt)("id").ToString()))
                End If
            End With
        Next
        txtProduct.DroppedDown = True
        txtProduct.Focus()
    End Sub
    Private Sub txtProduct_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedValueChanged
        salestrnid.Text = DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue()
        ViewSalesTransactionInfor()
    End Sub

    Public Sub ViewSalesTransactionInfor()
        com.CommandText = "select *, (select companyname from tblclientaccounts where cifid  = tblsalestransaction.cifid) as 'client' from tblsalestransaction where id='" & salestrnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cifid.Text = rst("cifid").ToString
            txtClientName.Text = rst("client").ToString
            txtTotal.Text = FormatNumber(Val(rst("total").ToString), 2)
        End While
        rst.Close()
    End Sub
    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtProduct.Text = "" Then
            MsgBox("Please select package!", MsgBoxStyle.Exclamation, "Error Message")
            txtProduct.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "Enter service remarks.." Or txtRemarks.Text = "" Then
            MsgBox("Please enter service recomendation!", MsgBoxStyle.Exclamation, "Error Message")
            txtRemarks.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblclinicservices set servicecode='" & txtReference.Text & "', clinicid='" & clinicid.Text & "',  officeid='" & compOfficeid & "',clientcif='" & cifid.Text & "', batchcode='" & batchcode.Text & "',salestrnid='" & salestrnid.Text & "',packagename='" & rchar(txtProduct.Text.Replace(salestrnid.Text & "-", "")) & "',amount='" & Val(CC(txtTotal.Text)) & "', remarks='" & rchar(txtRemarks.Text) & "'  where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO tblclinicservices set servicecode='" & txtReference.Text & "', clinicid='" & clinicid.Text & "',  officeid='" & compOfficeid & "',clientcif='" & cifid.Text & "', batchcode='" & batchcode.Text & "',salestrnid='" & salestrnid.Text & "',packagename='" & rchar(txtProduct.Text.Replace(salestrnid.Text & "-", "")) & "',amount='" & Val(CC(txtTotal.Text)) & "', remarks='" & rchar(txtRemarks.Text) & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                'If GLobalEmailNotifyAutoServices = True Then
                '    SendServiceAutoOpenReport(txtReference.Text)
                'End If
            End If
            frmAutoServices.tabFilter()
            MsgBox("Service successfully saved!", MsgBoxStyle.Information, "Message")
            Me.Close()
        End If
    End Sub

    Private Sub txtRecomendation_GotFocus(sender As Object, e As EventArgs) Handles txtRemarks.GotFocus
        If txtRemarks.Text = "Enter service remarks.." Then
            txtRemarks.Text = ""
        End If
    End Sub

    Private Sub txtRecomendation_LostFocus(sender As Object, e As EventArgs) Handles txtRemarks.LostFocus
        If txtRemarks.Text = "" Then
            txtRemarks.Text = "Enter service remarks.."
        End If
    End Sub
   
End Class