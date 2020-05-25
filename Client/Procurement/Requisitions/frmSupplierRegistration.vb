Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmSupplierRegistration
#Region "Call Data Reload Function"


#End Region
    Dim requestsend As Boolean = False
    Dim m_CountTo As Integer = 0 ' How many time to loop.
    Dim sendretry As Integer = 1
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Cursor = Cursors.WaitCursor
      
        LoadToComboBoxDB("select distinct bankaccount as 'bankaccount' from tblglobalvendor order by bankaccount asc", "bankaccount", "bankaccount", txtBankAccount)
        lblAttachment.Text = "Please attach files not more than " & GlobalAllowableAttachSize / 1024 & " KB or " & (GlobalAllowableAttachSize / 1024) / 1024 & " MB. For multiple files please compress to ZIP files. Please Click ""How to compress your files"" to view tutorial"
        Me.Cursor = Cursors.Default
        If mode.Text = "edit" Then
            Start_Button.Text = "Update Supplier"
            LoadSepplierDetails()
        Else
            Start_Button.Text = "Register Supplier"
        End If
    End Sub

    Public Sub LoadSepplierDetails()
        com.CommandText = "select * from tblglobalvendor where vendorid='" & vendorid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtCompanyName.Text = rst("COMPANYNAME").ToString
            txtAddress.Text = rst("COMPADD").ToString
            txtContactNumber.Text = rst("TELEPHONE").ToString
            txtEmailAddress.Text = rst("EMAIL").ToString
            txtContactPerson.Text = rst("CONTPERSON").ToString
            txtPosition.Text = rst("DESIGNATION").ToString
            txtBankAccount.Text = rst("bankaccount").ToString
            txtAccountNumber.Text = rst("accountnumber").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter particular name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("Please enter supplier address!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
            Exit Sub
        ElseIf txtContactNumber.Text = "" Then
            MessageBox.Show("Please enter contact number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactNumber.Focus()
            Exit Sub
        ElseIf txtContactPerson.Text = "" Then
            MessageBox.Show("Please enter contact person!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactPerson.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter Position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub

        ElseIf txtmessage.Text = "" Then
            MessageBox.Show("Please enter message!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmessage.Focus()
            Exit Sub
        End If

        If ckQuotation.Checked = True Then
            If txtattached1.Text = "" Then
                MessageBox.Show("Please attach document for supplier document!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtattached1.Focus()
                Exit Sub
            ElseIf checkAttachment(txtattached1.Text) = False Then
                MessageBox.Show("Your attachment is greater than system limit!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtattached1.Focus()
                Exit Sub
            End If
        End If

        If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            sendretry = 1
            Me.Start_Button.Enabled = False
            Me.Stop_Button.Enabled = True
            ProgressBar1.Visible = True
            Lbl_Status.Visible = True
            MainForm.Timer1.Stop()
            MainForm.BackgroundWorker1.CancelAsync()
            My_BgWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub DoThreadedStuff()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() DoTheWork())
        Else
            DoTheWork()
        End If
    End Sub

    Private Sub My_BgWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles My_BgWorker.DoWork
        If My_BgWorker.CancellationPending Then
            ' Set Cancel to True
            e.Cancel = True
        End If
        System.Threading.Thread.Sleep(500) ' Sleep for 1 Second
        DoThreadedStuff()
    End Sub

    Private Sub My_BgWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles My_BgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            Me.Lbl_Status.Text = "Cancelled"
            ProgressBar1.Visible = False
            Lbl_Status.Visible = False
            Start_Button.Text = "Try Again"
            Me.Start_Button.Enabled = True
            Me.Stop_Button.Enabled = False
            requestsend = False
            MainForm.Timer1.Start()
        Else
            If requestsend = True Then
                If mode.Text = "edit" Then
                    Me.Lbl_Status.Text = "Supplier successfully updated.."
                    MessageBox.Show("Supplier successfully updated! " & Environment.NewLine & Environment.NewLine & "Date/time Added: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt"), GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.Lbl_Status.Text = "Supplier successfully registered.."
                    MessageBox.Show("Supplier successfully registered! " & Environment.NewLine & Environment.NewLine & "Date/time Added: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt"), GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Me.Start_Button.Enabled = True
                Me.Stop_Button.Enabled = False
                Start_Button.Text = "Register Supplier"
                mode.Text = ""
                ProgressBar1.Visible = False
                Lbl_Status.Visible = False
                requestsend = False
                If frmSupplierManagement.Visible = True Then
                    frmSupplierManagement.ViewSupplierList()
                End If
                MainForm.Timer1.Start()
                Me.Close()
            Else
                sendretry = sendretry + 1
                If sendretry >= 20 Then
                    ProgressBar1.Visible = False
                    Lbl_Status.Visible = False
                    Start_Button.Text = "Try Again"
                    ProgressBar1.Value = 0
                    Me.Start_Button.Enabled = True
                    Me.Stop_Button.Enabled = False
                    requestsend = False
                    MainForm.Timer1.Start()
                    MessageBox.Show("Your registration was not sent due to connection error! Please try again later.", _
                                                    "Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.Lbl_Status.Text = sendretry.ToString & " times! Trying to connect server.."
                    ProgressBar1.Value = sendretry
                    MainForm.Timer1.Stop()
                    MainForm.BackgroundWorker1.CancelAsync()
                    My_BgWorker.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Public Sub DoTheWork()
        Try
            Me.Lbl_Status.Text = "Connecting to server.."
            If CheckConnectionServer() = True Then
                My_BgWorker.ReportProgress(40)
                Dim refno As String = getGlobalTrnid(compOfficeid, globaluserid)
                If ckQuotation.Checked = True Then
                    Me.Lbl_Status.Text = "Uploading your attachment.."
                    If AddAttachmentPackage(refno, "item_registration", {txtattached1.Text}) = True Then
                        My_BgWorker.ReportProgress(80)
                        completingRequest(refno)
                    End If
                Else
                    completingRequest(refno)
                End If
                requestsend = True
            Else
                requestsend = False
            End If
        Catch ex As Exception
            requestsend = False
            MessageBox.Show("Your registration was not sent due to connection error! please try again.")
        End Try
    End Sub
    
    Public Sub completingRequest(ByVal refno As String)
        Me.Lbl_Status.Text = "Finalizing your request.."
        InsertEmailNotification("Supplier", globalserverEmailAddress, "New Added Supplier", "<b>Suplier Details</b></br>Company Name: " & txtCompanyName.Text & "</br>Address: " & txtAddress.Text & "</br>Contact Number: " & txtContactNumber.Text & "</br>Email: " & txtEmailAddress.Text & "</br>Contact Person: " & txtContactPerson.Text & "</br>Position: " & txtPosition.Text & "</br>Bank Account: " & txtBankAccount.Text & "</br>Account Number: " & txtAccountNumber.Text & "</br></br>", txtmessage.Text)
        If mode.Text = "edit" Then
            com.CommandText = "update tblglobalvendor set COMPANYNAME='" & rchar(txtCompanyName.Text) & "', COMPADD='" & StrConv(rchar(txtAddress.Text), vbProperCase) & "', TELEPHONE='" & txtContactNumber.Text & "', EMAIL='" & LCase(txtEmailAddress.Text) & "', WEBSITE='', CONTPERSON='" & StrConv(txtContactPerson.Text, vbProperCase) & "', DESIGNATION='" & StrConv(txtPosition.Text, vbProperCase) & "',bankaccount='" & rchar(txtBankAccount.Text) & "',accountnumber='" & txtAccountNumber.Text & "' where vendorid='" & vendorid.text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & vendorid.Text & "', n_title='Supplier Edited', n_description='" & StrConv(rchar(txtCompanyName.Text), vbProperCase) & " from " & StrConv(compOfficename, vbProperCase) & Environment.NewLine & rchar(txtmessage.Text) & "',n_type='item', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
        Else
            Dim vendorid As String = getvendorid()
            com.CommandText = "insert into tblglobalvendor set vendorid='" & vendorid & "', COMPANYNAME='" & rchar(txtCompanyName.Text) & "', COMPADD='" & StrConv(rchar(txtAddress.Text), vbProperCase) & "', TELEPHONE='" & txtContactNumber.Text & "', EMAIL='" & LCase(txtEmailAddress.Text) & "', WEBSITE='', CONTPERSON='" & StrConv(txtContactPerson.Text, vbProperCase) & "', DESIGNATION='" & StrConv(txtPosition.Text, vbProperCase) & "',bankaccount='" & rchar(txtBankAccount.Text) & "',accountnumber='" & txtAccountNumber.Text & "', pmtinterval='0', rebaterate='0',entryby='" & globaluserid & "',dateentered=current_timestamp" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & vendorid & "', n_title='New Registered Supplier', n_description='" & StrConv(rchar(txtCompanyName.Text), vbProperCase) & " from " & StrConv(compOfficename, vbProperCase) & Environment.NewLine & rchar(txtmessage.Text) & "',n_type='item', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
        End If
        My_BgWorker.ReportProgress(100)
    End Sub

    Private Sub ckQuotation_CheckedChanged(sender As Object, e As EventArgs) Handles ckQuotation.CheckedChanged
        If ckQuotation.Checked = True Then
            cmda1.Enabled = True
        Else
            txtattached1.Text = ""
            cmda1.Enabled = False
        End If
    End Sub

    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmda1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "All Types (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'txtattached1.Text = objOpenFileDialog.FileName
                If checkAttachment(objOpenFileDialog.FileName) = False Then
                    txtattached1.BackColor = Color.Red
                Else
                    txtattached1.BackColor = Color.White
                    If (Not System.IO.Directory.Exists(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")) Then
                        System.IO.Directory.CreateDirectory(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")
                    End If
                    System.IO.File.Delete(file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                    System.IO.File.Copy(objOpenFileDialog.FileName, file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                End If
                txtattached1.Text = file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName)
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub
    Private Sub My_BgWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles My_BgWorker.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub
  

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles Stop_Button.Click
        If My_BgWorker.IsBusy Then
            If My_BgWorker.WorkerSupportsCancellation Then
                My_BgWorker.CancelAsync()
            End If
            Me.Start_Button.Enabled = True
            Me.Stop_Button.Enabled = False
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Process.Start(Application.StartupPath & "\attachment.pdf")
    End Sub
End Class