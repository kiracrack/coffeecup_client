Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSPoleDisplaySettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim strSetup As String = ""
        If System.IO.File.Exists(file_PoleDisplaySettings) = True Then
            ckEnablePoleDisplay.Checked = True
            Dim sr As StreamReader = File.OpenText(file_PoleDisplaySettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 0 Then
                    txtPrinterDevice.Text = word
                ElseIf cnt = 1 Then
                    If word <> "" Then
                        txtBaudRate.Text = word
                    End If
                ElseIf cnt = 2 Then
                    txtDataBits.Text = word
                ElseIf cnt = 3 Then
                    txtTestDisplay.Text = word
                End If
                cnt = cnt + 1
            Next

        Else
            ckEnablePoleDisplay.Checked = False
        End If
    End Sub

    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtPrinterDevice.Text = "" And ckEnablePoleDisplay.Checked = True Then
            MessageBox.Show("Please select port device!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrinterDevice.Focus()
            Exit Sub

        ElseIf txtBaudRate.Text = "" And ckEnablePoleDisplay.Checked = True Then
            MessageBox.Show("Please boudrate!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBaudRate.Focus()
            Exit Sub
        ElseIf txtDataBits.Text = "" And ckEnablePoleDisplay.Checked = True Then
            MessageBox.Show("Please data bits!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDataBits.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to save settings? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While

            Try
                If ckEnablePoleDisplay.Checked = True Then
                    If System.IO.File.Exists(file_PoleDisplaySettings) = True Then
                        System.IO.File.Delete(file_PoleDisplaySettings)
                    End If
                    Dim detailsFile As StreamWriter = Nothing
                    detailsFile = New StreamWriter(file_PoleDisplaySettings, True)
                    detailsFile.WriteLine(EncryptTripleDES(txtPrinterDevice.Text & "," & txtBaudRate.Text & "," & txtDataBits.Text & "," & txtTestDisplay.Text))
                    detailsFile.Close()
                    'If ckEnablePoleDisplay.Checked = True Then
                    '    LoadPOSPoleDisplaySetup()
                    'End If

                    MessageBox.Show("your settings successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    If System.IO.File.Exists(file_PoleDisplaySettings) = True Then
                        System.IO.File.Delete(file_PoleDisplaySettings)
                    End If
                End If
            Catch errMYSQL As MySqlException
                MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                                & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Catch errMS As Exception
                MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sp.Write(Convert.ToString(Chr(12)))
        sp.WriteLine(txtTestDisplay.Text)
        sp.WriteLine(txtTestDisplay.Text)
        'sp.Close()
        'sp.Dispose()
        'sp = Nothing
    End Sub
End Class