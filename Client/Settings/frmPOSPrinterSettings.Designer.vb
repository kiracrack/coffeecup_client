<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSPrinterSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSPrinterSettings))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMarginBottom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAutocutPrinter = New System.Windows.Forms.ComboBox()
        Me.ckTemporaryOffline = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarginLeft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPaperWidth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMappingScript = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckScriptPOSPrinter = New System.Windows.Forms.CheckBox()
        Me.txtPrinterDevice = New System.Windows.Forms.ComboBox()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.script = New System.Windows.Forms.TabPage()
        Me.ckEnableCashdrawer = New System.Windows.Forms.CheckBox()
        Me.manual = New System.Windows.Forms.TabPage()
        Me.ckEnableCustomFont = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdSaveSettings = New System.Windows.Forms.Button()
        Me.txtFontSize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFontName = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSecondaryPrinter = New System.Windows.Forms.ComboBox()
        Me.ckSEnableCashDrawer = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSMarginBottom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSAutoCut = New System.Windows.Forms.ComboBox()
        Me.ckSTemporaryOffline = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSMarginLeft = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSPaperWidth = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ckManualPrinter = New System.Windows.Forms.CheckBox()
        Me.txtPrinterName = New System.Windows.Forms.ComboBox()
        Me.panelScript = New System.Windows.Forms.Panel()
        Me.panelManual = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.script.SuspendLayout()
        Me.manual.SuspendLayout()
        Me.panelScript.SuspendLayout()
        Me.panelManual.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(267, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 392
        Me.Label9.Text = "Default 8 spaces"
        '
        'txtMarginBottom
        '
        Me.txtMarginBottom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMarginBottom.ForeColor = System.Drawing.Color.Black
        Me.txtMarginBottom.Location = New System.Drawing.Point(177, 206)
        Me.txtMarginBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarginBottom.Name = "txtMarginBottom"
        Me.txtMarginBottom.Size = New System.Drawing.Size(82, 22)
        Me.txtMarginBottom.TabIndex = 390
        Me.txtMarginBottom.Text = "8"
        Me.txtMarginBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(82, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "Margin Bottom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(54, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 389
        Me.Label6.Text = "Autocut Printer Type"
        '
        'txtAutocutPrinter
        '
        Me.txtAutocutPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAutocutPrinter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAutocutPrinter.ForeColor = System.Drawing.Color.Black
        Me.txtAutocutPrinter.FormattingEnabled = True
        Me.txtAutocutPrinter.ItemHeight = 13
        Me.txtAutocutPrinter.Items.AddRange(New Object() {"Epson", "Standard", "China Printer"})
        Me.txtAutocutPrinter.Location = New System.Drawing.Point(177, 232)
        Me.txtAutocutPrinter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAutocutPrinter.Name = "txtAutocutPrinter"
        Me.txtAutocutPrinter.Size = New System.Drawing.Size(145, 21)
        Me.txtAutocutPrinter.TabIndex = 388
        '
        'ckTemporaryOffline
        '
        Me.ckTemporaryOffline.AutoSize = True
        Me.ckTemporaryOffline.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckTemporaryOffline.ForeColor = System.Drawing.Color.Black
        Me.ckTemporaryOffline.Location = New System.Drawing.Point(175, 260)
        Me.ckTemporaryOffline.Name = "ckTemporaryOffline"
        Me.ckTemporaryOffline.Size = New System.Drawing.Size(175, 19)
        Me.ckTemporaryOffline.TabIndex = 387
        Me.ckTemporaryOffline.Text = "Set temporary printer offline"
        Me.ckTemporaryOffline.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(266, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 386
        Me.Label7.Text = "Default 2 spaces"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(266, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 385
        Me.Label4.Text = "Default 40 Standard POS paper"
        '
        'txtMarginLeft
        '
        Me.txtMarginLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMarginLeft.ForeColor = System.Drawing.Color.Black
        Me.txtMarginLeft.Location = New System.Drawing.Point(177, 181)
        Me.txtMarginLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarginLeft.Name = "txtMarginLeft"
        Me.txtMarginLeft.Size = New System.Drawing.Size(82, 22)
        Me.txtMarginLeft.TabIndex = 383
        Me.txtMarginLeft.Text = "2"
        Me.txtMarginLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(102, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 384
        Me.Label2.Text = "Margin Left"
        '
        'txtPaperWidth
        '
        Me.txtPaperWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPaperWidth.ForeColor = System.Drawing.Color.Black
        Me.txtPaperWidth.Location = New System.Drawing.Point(177, 156)
        Me.txtPaperWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaperWidth.Name = "txtPaperWidth"
        Me.txtPaperWidth.Size = New System.Drawing.Size(82, 22)
        Me.txtPaperWidth.TabIndex = 381
        Me.txtPaperWidth.Text = "40"
        Me.txtPaperWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(60, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 382
        Me.Label1.Text = "Paper width Length"
        '
        'txtMappingScript
        '
        Me.txtMappingScript.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMappingScript.ForeColor = System.Drawing.Color.Black
        Me.txtMappingScript.Location = New System.Drawing.Point(177, 64)
        Me.txtMappingScript.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMappingScript.Multiline = True
        Me.txtMappingScript.Name = "txtMappingScript"
        Me.txtMappingScript.Size = New System.Drawing.Size(243, 59)
        Me.txtMappingScript.TabIndex = 379
        Me.txtMappingScript.Text = "net use lpt1: /delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "net use lpt1: \\localhost\pos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(82, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 380
        Me.Label5.Text = "Mapping Script"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(90, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 358
        Me.Label3.Text = "Printer Device"
        '
        'ckScriptPOSPrinter
        '
        Me.ckScriptPOSPrinter.AutoSize = True
        Me.ckScriptPOSPrinter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckScriptPOSPrinter.ForeColor = System.Drawing.Color.Black
        Me.ckScriptPOSPrinter.Location = New System.Drawing.Point(177, 19)
        Me.ckScriptPOSPrinter.Name = "ckScriptPOSPrinter"
        Me.ckScriptPOSPrinter.Size = New System.Drawing.Size(164, 19)
        Me.ckScriptPOSPrinter.TabIndex = 355
        Me.ckScriptPOSPrinter.Text = "Enable POS Script Printing"
        Me.ckScriptPOSPrinter.UseVisualStyleBackColor = True
        '
        'txtPrinterDevice
        '
        Me.txtPrinterDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPrinterDevice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPrinterDevice.ForeColor = System.Drawing.Color.Black
        Me.txtPrinterDevice.FormattingEnabled = True
        Me.txtPrinterDevice.ItemHeight = 13
        Me.txtPrinterDevice.Items.AddRange(New Object() {"LPT1", "LPT2", "LPT3", "COM1", "COM2", "COM3"})
        Me.txtPrinterDevice.Location = New System.Drawing.Point(177, 39)
        Me.txtPrinterDevice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrinterDevice.Name = "txtPrinterDevice"
        Me.txtPrinterDevice.Size = New System.Drawing.Size(100, 21)
        Me.txtPrinterDevice.TabIndex = 354
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(262, 304)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(134, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Save Settings"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(126, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 30)
        Me.Button1.TabIndex = 387
        Me.Button1.Text = "Print Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.script)
        Me.TabControl1.Controls.Add(Me.manual)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(518, 409)
        Me.TabControl1.TabIndex = 388
        '
        'script
        '
        Me.script.Controls.Add(Me.panelScript)
        Me.script.Location = New System.Drawing.Point(4, 24)
        Me.script.Name = "script"
        Me.script.Padding = New System.Windows.Forms.Padding(3)
        Me.script.Size = New System.Drawing.Size(510, 381)
        Me.script.TabIndex = 0
        Me.script.Text = "Script Printing Settings"
        Me.script.UseVisualStyleBackColor = True
        '
        'ckEnableCashdrawer
        '
        Me.ckEnableCashdrawer.AutoSize = True
        Me.ckEnableCashdrawer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableCashdrawer.ForeColor = System.Drawing.Color.Black
        Me.ckEnableCashdrawer.Location = New System.Drawing.Point(177, 137)
        Me.ckEnableCashdrawer.Name = "ckEnableCashdrawer"
        Me.ckEnableCashdrawer.Size = New System.Drawing.Size(126, 19)
        Me.ckEnableCashdrawer.TabIndex = 416
        Me.ckEnableCashdrawer.Text = "Enable Cashdrawer"
        Me.ckEnableCashdrawer.UseVisualStyleBackColor = True
        '
        'manual
        '
        Me.manual.Controls.Add(Me.panelManual)
        Me.manual.Location = New System.Drawing.Point(4, 24)
        Me.manual.Name = "manual"
        Me.manual.Padding = New System.Windows.Forms.Padding(3)
        Me.manual.Size = New System.Drawing.Size(510, 381)
        Me.manual.TabIndex = 1
        Me.manual.Text = "Manual Printer Settings"
        Me.manual.UseVisualStyleBackColor = True
        '
        'ckEnableCustomFont
        '
        Me.ckEnableCustomFont.AutoSize = True
        Me.ckEnableCustomFont.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableCustomFont.ForeColor = System.Drawing.Color.Black
        Me.ckEnableCustomFont.Location = New System.Drawing.Point(177, 198)
        Me.ckEnableCustomFont.Name = "ckEnableCustomFont"
        Me.ckEnableCustomFont.Size = New System.Drawing.Size(133, 19)
        Me.ckEnableCustomFont.TabIndex = 424
        Me.ckEnableCustomFont.Text = "Enable Custom Font"
        Me.ckEnableCustomFont.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(133, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 423
        Me.Button2.Text = "Print Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdSaveSettings
        '
        Me.cmdSaveSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSaveSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSaveSettings.Location = New System.Drawing.Point(239, 329)
        Me.cmdSaveSettings.Name = "cmdSaveSettings"
        Me.cmdSaveSettings.Size = New System.Drawing.Size(111, 30)
        Me.cmdSaveSettings.TabIndex = 422
        Me.cmdSaveSettings.Text = "Save Settings"
        Me.cmdSaveSettings.UseVisualStyleBackColor = True
        '
        'txtFontSize
        '
        Me.txtFontSize.Enabled = False
        Me.txtFontSize.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFontSize.ForeColor = System.Drawing.Color.Black
        Me.txtFontSize.Location = New System.Drawing.Point(177, 243)
        Me.txtFontSize.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(82, 22)
        Me.txtFontSize.TabIndex = 420
        Me.txtFontSize.Text = "9"
        Me.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(116, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 15)
        Me.Label11.TabIndex = 421
        Me.Label11.Text = "Font Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(104, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 419
        Me.Label10.Text = "Font Name"
        '
        'txtFontName
        '
        Me.txtFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFontName.Enabled = False
        Me.txtFontName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFontName.ForeColor = System.Drawing.Color.Black
        Me.txtFontName.FormattingEnabled = True
        Me.txtFontName.ItemHeight = 13
        Me.txtFontName.Location = New System.Drawing.Point(177, 219)
        Me.txtFontName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(224, 21)
        Me.txtFontName.TabIndex = 418
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(70, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 417
        Me.Label12.Text = "Secondary Printer"
        '
        'txtSecondaryPrinter
        '
        Me.txtSecondaryPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSecondaryPrinter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSecondaryPrinter.ForeColor = System.Drawing.Color.Black
        Me.txtSecondaryPrinter.FormattingEnabled = True
        Me.txtSecondaryPrinter.ItemHeight = 13
        Me.txtSecondaryPrinter.Location = New System.Drawing.Point(177, 64)
        Me.txtSecondaryPrinter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecondaryPrinter.Name = "txtSecondaryPrinter"
        Me.txtSecondaryPrinter.Size = New System.Drawing.Size(224, 21)
        Me.txtSecondaryPrinter.TabIndex = 416
        '
        'ckSEnableCashDrawer
        '
        Me.ckSEnableCashDrawer.AutoSize = True
        Me.ckSEnableCashDrawer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckSEnableCashDrawer.ForeColor = System.Drawing.Color.Black
        Me.ckSEnableCashDrawer.Location = New System.Drawing.Point(177, 97)
        Me.ckSEnableCashDrawer.Name = "ckSEnableCashDrawer"
        Me.ckSEnableCashDrawer.Size = New System.Drawing.Size(126, 19)
        Me.ckSEnableCashDrawer.TabIndex = 415
        Me.ckSEnableCashDrawer.Text = "Enable Cashdrawer"
        Me.ckSEnableCashDrawer.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(267, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 414
        Me.Label13.Text = "Default 8 spaces"
        '
        'txtSMarginBottom
        '
        Me.txtSMarginBottom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSMarginBottom.ForeColor = System.Drawing.Color.Black
        Me.txtSMarginBottom.Location = New System.Drawing.Point(177, 169)
        Me.txtSMarginBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSMarginBottom.Name = "txtSMarginBottom"
        Me.txtSMarginBottom.Size = New System.Drawing.Size(82, 22)
        Me.txtSMarginBottom.TabIndex = 412
        Me.txtSMarginBottom.Text = "8"
        Me.txtSMarginBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(82, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 15)
        Me.Label14.TabIndex = 413
        Me.Label14.Text = "Margin Bottom"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(54, 271)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 15)
        Me.Label15.TabIndex = 411
        Me.Label15.Text = "Autocut Printer Type"
        '
        'txtSAutoCut
        '
        Me.txtSAutoCut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSAutoCut.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSAutoCut.ForeColor = System.Drawing.Color.Black
        Me.txtSAutoCut.FormattingEnabled = True
        Me.txtSAutoCut.ItemHeight = 13
        Me.txtSAutoCut.Items.AddRange(New Object() {"Epson", "Standard", "China Printer"})
        Me.txtSAutoCut.Location = New System.Drawing.Point(177, 268)
        Me.txtSAutoCut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSAutoCut.Name = "txtSAutoCut"
        Me.txtSAutoCut.Size = New System.Drawing.Size(145, 21)
        Me.txtSAutoCut.TabIndex = 410
        '
        'ckSTemporaryOffline
        '
        Me.ckSTemporaryOffline.AutoSize = True
        Me.ckSTemporaryOffline.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckSTemporaryOffline.ForeColor = System.Drawing.Color.Black
        Me.ckSTemporaryOffline.Location = New System.Drawing.Point(175, 295)
        Me.ckSTemporaryOffline.Name = "ckSTemporaryOffline"
        Me.ckSTemporaryOffline.Size = New System.Drawing.Size(175, 19)
        Me.ckSTemporaryOffline.TabIndex = 409
        Me.ckSTemporaryOffline.Text = "Set temporary printer offline"
        Me.ckSTemporaryOffline.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(266, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 408
        Me.Label16.Text = "Default 2 spaces"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(266, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 13)
        Me.Label17.TabIndex = 407
        Me.Label17.Text = "Default 40 Standard POS paper"
        '
        'txtSMarginLeft
        '
        Me.txtSMarginLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSMarginLeft.ForeColor = System.Drawing.Color.Black
        Me.txtSMarginLeft.Location = New System.Drawing.Point(177, 144)
        Me.txtSMarginLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSMarginLeft.Name = "txtSMarginLeft"
        Me.txtSMarginLeft.Size = New System.Drawing.Size(82, 22)
        Me.txtSMarginLeft.TabIndex = 405
        Me.txtSMarginLeft.Text = "2"
        Me.txtSMarginLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(102, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 15)
        Me.Label18.TabIndex = 406
        Me.Label18.Text = "Margin Left"
        '
        'txtSPaperWidth
        '
        Me.txtSPaperWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSPaperWidth.ForeColor = System.Drawing.Color.Black
        Me.txtSPaperWidth.Location = New System.Drawing.Point(177, 119)
        Me.txtSPaperWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSPaperWidth.Name = "txtSPaperWidth"
        Me.txtSPaperWidth.Size = New System.Drawing.Size(82, 22)
        Me.txtSPaperWidth.TabIndex = 403
        Me.txtSPaperWidth.Text = "40"
        Me.txtSPaperWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(60, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 15)
        Me.Label19.TabIndex = 404
        Me.Label19.Text = "Paper width Length"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(90, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 15)
        Me.Label20.TabIndex = 402
        Me.Label20.Text = "Printer Device"
        '
        'ckManualPrinter
        '
        Me.ckManualPrinter.AutoSize = True
        Me.ckManualPrinter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckManualPrinter.ForeColor = System.Drawing.Color.Black
        Me.ckManualPrinter.Location = New System.Drawing.Point(177, 19)
        Me.ckManualPrinter.Name = "ckManualPrinter"
        Me.ckManualPrinter.Size = New System.Drawing.Size(167, 19)
        Me.ckManualPrinter.TabIndex = 401
        Me.ckManualPrinter.Text = "Enable POS Manual Printer"
        Me.ckManualPrinter.UseVisualStyleBackColor = True
        '
        'txtPrinterName
        '
        Me.txtPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPrinterName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPrinterName.ForeColor = System.Drawing.Color.Black
        Me.txtPrinterName.FormattingEnabled = True
        Me.txtPrinterName.ItemHeight = 13
        Me.txtPrinterName.Location = New System.Drawing.Point(177, 39)
        Me.txtPrinterName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.Size = New System.Drawing.Size(224, 21)
        Me.txtPrinterName.TabIndex = 400
        '
        'panelScript
        '
        Me.panelScript.Controls.Add(Me.Label9)
        Me.panelScript.Controls.Add(Me.Button1)
        Me.panelScript.Controls.Add(Me.ckScriptPOSPrinter)
        Me.panelScript.Controls.Add(Me.txtMarginBottom)
        Me.panelScript.Controls.Add(Me.cmdset)
        Me.panelScript.Controls.Add(Me.txtPrinterDevice)
        Me.panelScript.Controls.Add(Me.Label8)
        Me.panelScript.Controls.Add(Me.Label3)
        Me.panelScript.Controls.Add(Me.Label6)
        Me.panelScript.Controls.Add(Me.Label5)
        Me.panelScript.Controls.Add(Me.txtAutocutPrinter)
        Me.panelScript.Controls.Add(Me.txtMappingScript)
        Me.panelScript.Controls.Add(Me.ckTemporaryOffline)
        Me.panelScript.Controls.Add(Me.Label1)
        Me.panelScript.Controls.Add(Me.Label7)
        Me.panelScript.Controls.Add(Me.txtPaperWidth)
        Me.panelScript.Controls.Add(Me.Label4)
        Me.panelScript.Controls.Add(Me.Label2)
        Me.panelScript.Controls.Add(Me.txtMarginLeft)
        Me.panelScript.Controls.Add(Me.ckEnableCashdrawer)
        Me.panelScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelScript.Location = New System.Drawing.Point(3, 3)
        Me.panelScript.Name = "panelScript"
        Me.panelScript.Size = New System.Drawing.Size(504, 375)
        Me.panelScript.TabIndex = 417
        '
        'panelManual
        '
        Me.panelManual.Controls.Add(Me.ckEnableCustomFont)
        Me.panelManual.Controls.Add(Me.Button2)
        Me.panelManual.Controls.Add(Me.cmdSaveSettings)
        Me.panelManual.Controls.Add(Me.txtFontSize)
        Me.panelManual.Controls.Add(Me.Label11)
        Me.panelManual.Controls.Add(Me.Label10)
        Me.panelManual.Controls.Add(Me.txtFontName)
        Me.panelManual.Controls.Add(Me.Label12)
        Me.panelManual.Controls.Add(Me.txtSecondaryPrinter)
        Me.panelManual.Controls.Add(Me.ckSEnableCashDrawer)
        Me.panelManual.Controls.Add(Me.Label13)
        Me.panelManual.Controls.Add(Me.txtSMarginBottom)
        Me.panelManual.Controls.Add(Me.Label14)
        Me.panelManual.Controls.Add(Me.Label15)
        Me.panelManual.Controls.Add(Me.txtSAutoCut)
        Me.panelManual.Controls.Add(Me.ckSTemporaryOffline)
        Me.panelManual.Controls.Add(Me.Label16)
        Me.panelManual.Controls.Add(Me.Label17)
        Me.panelManual.Controls.Add(Me.txtSMarginLeft)
        Me.panelManual.Controls.Add(Me.Label18)
        Me.panelManual.Controls.Add(Me.txtSPaperWidth)
        Me.panelManual.Controls.Add(Me.Label19)
        Me.panelManual.Controls.Add(Me.Label20)
        Me.panelManual.Controls.Add(Me.ckManualPrinter)
        Me.panelManual.Controls.Add(Me.txtPrinterName)
        Me.panelManual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelManual.Location = New System.Drawing.Point(3, 3)
        Me.panelManual.Name = "panelManual"
        Me.panelManual.Size = New System.Drawing.Size(504, 375)
        Me.panelManual.TabIndex = 425
        '
        'frmPOSPrinterSettings
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(541, 434)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSPrinterSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "POS Printer Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.script.ResumeLayout(False)
        Me.manual.ResumeLayout(False)
        Me.panelScript.ResumeLayout(False)
        Me.panelScript.PerformLayout()
        Me.panelManual.ResumeLayout(False)
        Me.panelManual.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtPrinterDevice As System.Windows.Forms.ComboBox
    Friend WithEvents ckScriptPOSPrinter As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMappingScript As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMarginLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPaperWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ckTemporaryOffline As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAutocutPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMarginBottom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents script As System.Windows.Forms.TabPage
    Friend WithEvents manual As System.Windows.Forms.TabPage
    Friend WithEvents txtFontSize As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFontName As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSecondaryPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents ckSEnableCashDrawer As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSMarginBottom As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSAutoCut As System.Windows.Forms.ComboBox
    Friend WithEvents ckSTemporaryOffline As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSMarginLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSPaperWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ckManualPrinter As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrinterName As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdSaveSettings As System.Windows.Forms.Button
    Friend WithEvents ckEnableCustomFont As System.Windows.Forms.CheckBox
    Friend WithEvents ckEnableCashdrawer As System.Windows.Forms.CheckBox
    Friend WithEvents panelScript As System.Windows.Forms.Panel
    Friend WithEvents panelManual As System.Windows.Forms.Panel
End Class
