Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPOSPrinterSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSPrinterSettings_Script_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateInstalledPrintersCombo()
        BindCombo()
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            Dim PrinterType As String = ""
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            PrinterType = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In PrinterType.Split(New Char() {","c})
                If cnt = 0 Then
                    globalPosPrintingType = word
                End If
                cnt = cnt + 1
            Next
        End If
        If globalPosPrintingType = Nothing Then Exit Sub
        If globalPosPrintingType = "script" Or globalPosPrintingType = "manual" Then
            TabControl1.SelectTab(globalPosPrintingType)
            PrinterOption()
        End If
       
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        PrinterOption()
    End Sub
    Public Sub PrinterOption()
        If TabControl1.SelectedTab Is script Then
            If globalPosPrintingType = "script" Then
                LoadScriptPrinting()
            End If
        Else
            If globalPosPrintingType = "manual" Then
                LoadManualPrinting()
            End If

        End If
    End Sub

#Region "MANUAL PRINTER"

    Public Sub LoadManualPrinting()
      
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            ckManualPrinter.Checked = True
            panelScript.Enabled = False
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 1 Then
                    txtPrinterName.Text = word

                ElseIf cnt = 2 Then
                    txtSecondaryPrinter.Text = word

                ElseIf cnt = 3 Then
                    ckSEnableCashDrawer.Checked = CBool(word)

                ElseIf cnt = 4 Then
                    txtSPaperWidth.Text = word

                ElseIf cnt = 5 Then
                    txtSMarginLeft.Text = word

                ElseIf cnt = 6 Then
                    txtSMarginBottom.Text = word

                ElseIf cnt = 7 Then
                    ckEnableCustomFont.Checked = CBool(word)

                ElseIf cnt = 8 Then
                    txtFontName.Text = word

                ElseIf cnt = 9 Then
                    txtFontSize.Text = word

                ElseIf cnt = 10 Then
                    txtSAutoCut.Text = word

                ElseIf cnt = 11 Then
                    ckSTemporaryOffline.Checked = CBool(word)

                End If
                cnt = cnt + 1
            Next
        Else
            panelScript.Enabled = True
            ckScriptPOSPrinter.Checked = False
        End If
    End Sub

    Private Sub BindCombo()
        For Each oFont As FontFamily In FontFamily.Families
            txtFontName.Items.Add(oFont.Name)
        Next
    End Sub

    Private Sub PopulateInstalledPrintersCombo()
        Dim i As Integer
        txtPrinterName.Items.Clear()
        txtSecondaryPrinter.Items.Clear()
        Dim pkInstalledPrinters As String
        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            txtPrinterName.Items.Add(pkInstalledPrinters)
            txtSecondaryPrinter.Items.Add(pkInstalledPrinters)
        Next
    End Sub

    Private Sub comboInstalledPrinters_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrinterDevice.SelectedIndexChanged
        If txtPrinterDevice.SelectedIndex <> -1 Then
        End If
    End Sub

    Private Sub cmdSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveSettings.Click
        If txtPrinterName.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please select printer device!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrinterDevice.Focus()
            Exit Sub

        ElseIf txtPaperWidth.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter paper width!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPaperWidth.Focus()
            Exit Sub
        ElseIf txtMarginLeft.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter left margin!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMarginLeft.Focus()
            Exit Sub

        ElseIf txtMarginBottom.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter bottom margin!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMarginLeft.Focus()
            Exit Sub

        End If
        If MessageBox.Show("Are you sure you want to save settings? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While

            Try
                If ckManualPrinter.Checked = True Then
                    If System.IO.File.Exists(file_PrinterSettings) = True Then
                        System.IO.File.Delete(file_PrinterSettings)
                    End If
                    Dim detailsFile As StreamWriter = Nothing
                    detailsFile = New StreamWriter(file_PrinterSettings, True)
                    detailsFile.WriteLine(EncryptTripleDES(TabControl1.SelectedTab.Name & "," & txtPrinterName.Text & "," & txtSecondaryPrinter.Text & "," & ckSEnableCashDrawer.CheckState & "," & txtSPaperWidth.Text & "," & txtSMarginLeft.Text & "," & txtSMarginBottom.Text & "," & ckEnableCustomFont.CheckState & "," & txtFontName.Text & "," & txtFontSize.Text & "," & txtSAutoCut.Text & "," & ckTemporaryOffline.CheckState))
                    detailsFile.Close()
                    If ckManualPrinter.Checked = True Then
                        LoadPOSPrinterSetup()
                    End If

                Else
                    If System.IO.File.Exists(file_PrinterSettings) = True Then
                        System.IO.File.Delete(file_PrinterSettings)
                    End If
                  
                End If
                LoadManualPrinting()
                MessageBox.Show("your settings successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    Private Sub ckEnableCustomFont_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableCustomFont.CheckedChanged
        If ckEnableCustomFont.Checked = True Then
            txtFontName.Enabled = True
            txtFontSize.Enabled = True
        Else
            txtFontName.Enabled = False
            txtFontSize.Enabled = False
        End If
    End Sub
#End Region


#Region "SCRIP PRINTING"
    Public Sub LoadScriptPrinting()
        Me.Icon = ico
        Dim strSetup As String = ""
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            ckScriptPOSPrinter.Checked = True
            panelManual.Enabled = False
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 0 Then
                    TabControl1.SelectedTab.Name = word
                ElseIf cnt = 1 Then
                    txtPrinterDevice.Text = word
                ElseIf cnt = 2 Then
                    If word <> "" Then
                        txtMappingScript.Text = word
                    End If
                ElseIf cnt = 3 Then
                    ckEnableCashdrawer.Checked = CBool(word)
                ElseIf cnt = 4 Then
                    txtPaperWidth.Text = word
                ElseIf cnt = 5 Then
                    txtMarginLeft.Text = word
                ElseIf cnt = 6 Then
                    txtMarginBottom.Text = word
                ElseIf cnt = 7 Then
                    txtAutocutPrinter.Text = word
                ElseIf cnt = 8 Then
                    ckTemporaryOffline.Checked = CBool(word)
                End If
                cnt = cnt + 1
            Next
        Else
            panelManual.Enabled = True
            ckScriptPOSPrinter.Checked = False
        End If
    End Sub
    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtPrinterDevice.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please select printer device!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrinterDevice.Focus()
            Exit Sub
        ElseIf txtMappingScript.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter printer mapping script!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMappingScript.Focus()
            Exit Sub
        ElseIf txtPaperWidth.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter paper width!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPaperWidth.Focus()
            Exit Sub
        ElseIf txtMarginLeft.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter left margin!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMarginLeft.Focus()
            Exit Sub

        ElseIf txtMarginBottom.Text = "" And ckScriptPOSPrinter.Checked = True Then
            MessageBox.Show("Please enter bottom margin!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMarginLeft.Focus()
            Exit Sub

        End If
        If MessageBox.Show("Are you sure you want to save settings? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While

            Try
                If ckScriptPOSPrinter.Checked = True Then
                    If System.IO.File.Exists(file_PrinterSettings) = True Then
                        System.IO.File.Delete(file_PrinterSettings)
                    End If
                    Dim detailsFile As StreamWriter = Nothing
                    detailsFile = New StreamWriter(file_PrinterSettings, True)
                    detailsFile.WriteLine(EncryptTripleDES(TabControl1.SelectedTab.Name.ToString & "," & txtPrinterDevice.Text & "," & txtMappingScript.Text & "," & ckEnableCashdrawer.CheckState & "," & txtPaperWidth.Text & "," & txtMarginLeft.Text & "," & txtMarginBottom.Text & "," & txtAutocutPrinter.Text & "," & ckTemporaryOffline.CheckState))
                    detailsFile.Close()
                    If ckScriptPOSPrinter.Checked = True Then
                        LoadPOSPrinterSetup()
                    End If
                Else
                    If System.IO.File.Exists(file_PrinterSettings) = True Then
                        System.IO.File.Delete(file_PrinterSettings)
                    End If
                End If
                LoadScriptPrinting()
                MessageBox.Show("your settings successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        OpenCashDrawer()
        Dim details As String = "" : Dim BalanceSheet As String = ""
        Dim salefilelocation As String = System.IO.Path.GetTempPath

        details = PageHeader()
        details += PrintCenterText("POS PRINT TEST") & Environment.NewLine & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        com.CommandText = "select * from tblaccounts where accountid='" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftText("Office: " & compOfficename) & Environment.NewLine
            details += PrintLeftText("Fullname: " & rst("fullname").ToString) & Environment.NewLine
            details += PrintLeftText("Position: " & rst("designation").ToString) & Environment.NewLine
            details += PrintLeftText("Email: " & rst("emailaddress").ToString) & Environment.NewLine
        End While
        rst.Close()
        details += PrintLeftText("System Date: " & Format(CDate(qryDate("dt", "current_timestamp as dt")))) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintCenterText("- Print test end -") & Environment.NewLine & Environment.NewLine
        'For Each word In GlobalPosReceiptType.Split(New Char() {vbCrLf})
        '    details += PrintCenterText(Trim(word)) & Environment.NewLine
        'Next
        details += LastPagepaper()
        POSPrint(details, "pos-print-test", "")
    End Sub
 
End Class