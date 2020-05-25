Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmAutoNewServices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmAutoNewServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadClient()
        If mode.Text <> "edit" Then
            txtClient.Enabled = True
            If GLobalAutoServicesSequence = True Then
                txtReference.ReadOnly = True
                txtReference.Text = getAutoServicesNumberSequence()
                com.CommandText = "UPDATE tblgeneralsettings set autoservicessequence='" & txtReference.Text & "'" : com.ExecuteNonQuery()
            Else
                txtReference.ReadOnly = False
            End If
        Else
            txtClient.Enabled = False
            LoadServicesInfo()
            txtReference.ReadOnly = False
        End If
       

    End Sub
    Public Sub LoadServicesInfo()
        com.CommandText = "select *,(select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'customer', " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'address', " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'number' " _
                           + " from tblsalesautoservices where trncode='" & txtReference.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtClient.Text = rst("customer").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNumber.Text = rst("number").ToString
            cifid.Text = rst("cifid").ToString
            txtCarModel.Text = rst("carmodel").ToString
            txtPlateNumber.Text = rst("platenumber").ToString
            txtOdoMeter.Text = FormatNumber(rst("odometer").ToString)
            txtMechanics.Text = rst("attmechanics").ToString
            txtRecomendation.Text = rst("recomendation").ToString
        End While
        rst.Close()

    End Sub
    Public Sub LoadClient()
        txtClient.Items.Clear()
        If Globalenableclientfilter = True Then
            com.CommandText = "select * from tblclientaccounts where groupcode in (select clientgroup from tblclientfilter where permissioncode='" & globalAuthcode & "') and walkinaccount=0 and deleted=0 order by companyname asc" : rst = com.ExecuteReader
        Else
            com.CommandText = "select * from tblclientaccounts where walkinaccount=0 and deleted=0  order by companyname asc" : rst = com.ExecuteReader
        End If
        While rst.Read
            txtClient.Items.Add(New ComboBoxItem(rst("companyname").ToString, rst("cifid").ToString))
        End While
        rst.Close()
    End Sub

    Private Sub txtClient_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClient.SelectedValueChanged
        If txtClient.Text <> "" And mode.Text <> "edit" Then
            cifid.Text = DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue()
            com.CommandText = "select * from tblclientaccounts where cifid='" & cifid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtAddress.Text = rst("compadd").ToString
                txtContactNumber.Text = rst("telephone").ToString
            End While
            rst.Close()
        Else
            cifid.Text = ""
        End If
    End Sub

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtClient.Text = "" Then
            MsgBox("Please select client!", MsgBoxStyle.Exclamation, "Error Message")
            txtClient.Focus()
            Exit Sub
        ElseIf txtCarModel.Text = "" Then
            MsgBox("Please enter car model!", MsgBoxStyle.Exclamation, "Error Message")
            txtCarModel.Focus()
            Exit Sub
        ElseIf txtPlateNumber.Text = "" Then
            MsgBox("Please enter plate number!", MsgBoxStyle.Exclamation, "Error Message")
            txtPlateNumber.Focus()
            Exit Sub
        ElseIf txtRecomendation.Text = "Enter service recomendation.." Or txtRecomendation.Text = "" Then
            MsgBox("Please enter service recomendation!", MsgBoxStyle.Exclamation, "Error Message")
            txtRecomendation.Focus()
            Exit Sub
        ElseIf txtOdoMeter.Text = "" Or txtOdoMeter.Text = "0" Then
            MsgBox("Please enter odo meter!", MsgBoxStyle.Exclamation, "Error Message")
            txtOdoMeter.Focus()
            Exit Sub
        ElseIf txtMechanics.Text = "" Then
            MsgBox("Please enter attending mechanics!", MsgBoxStyle.Exclamation, "Error Message")
            txtMechanics.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblsalesautoservices set cifid='" & cifid.Text & "', carmodel='" & rchar(txtCarModel.Text) & "', platenumber='" & rchar(txtPlateNumber.Text) & "',odometer='" & Val(CC(txtOdoMeter.Text)) & "', attmechanics='" & rchar(txtMechanics.Text) & "', recomendation='" & rchar(txtRecomendation.Text) & "' where trncode='" & txtReference.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO tblsalesautoservices set trncode='" & txtReference.Text & "', cifid='" & cifid.Text & "', carmodel='" & rchar(txtCarModel.Text) & "', odometer='" & Val(CC(txtOdoMeter.Text)) & "', attmechanics='" & rchar(txtMechanics.Text) & "', platenumber='" & rchar(txtPlateNumber.Text) & "', recomendation='" & rchar(txtRecomendation.Text) & "', datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                If GLobalEmailNotifyAutoServices = True Then
                    SendServiceAutoOpenReport(txtReference.Text)
                End If
            End If
            frmAutoServices.tabFilter()
            MsgBox("Service successfully saved!", MsgBoxStyle.Information, "Message")
            Me.Close()
        End If
    End Sub

    Private Sub txtRecomendation_GotFocus(sender As Object, e As EventArgs) Handles txtRecomendation.GotFocus
        If txtRecomendation.Text = "Enter service recomendation.." Then
            txtRecomendation.Text = ""
        End If
    End Sub

    Private Sub txtRecomendation_LostFocus(sender As Object, e As EventArgs) Handles txtRecomendation.LostFocus
        If txtRecomendation.Text = "" Then
            txtRecomendation.Text = "Enter service recomendation.."
        End If
    End Sub
  
    Private Sub cmdPrintAgreement_Click(sender As Object, e As EventArgs) Handles cmdPrintAgreement.Click
        AutoServicesAgreement(txtClient.Text, qrysingledata("compadd", "compadd", "tblclientaccounts where cifid='" & cifid.Text & "'"), qrysingledata("telephone", "telephone", "tblclientaccounts where cifid='" & cifid.Text & "'"), txtCarModel.Text, txtPlateNumber.Text, txtOdoMeter.Text, txtMechanics.Text, txtRecomendation.Text, txtReference.Text, Me)
    End Sub

    Private Sub cmdNewClient_Click(sender As Object, e As EventArgs) Handles cmdNewClient.Click
        frmPOSClientInformation.ShowDialog(Me)
        LoadClient()
    End Sub
End Class