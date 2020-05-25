<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSPoleDisplaySettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSPoleDisplaySettings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckEnablePoleDisplay = New System.Windows.Forms.CheckBox()
        Me.txtPrinterDevice = New System.Windows.Forms.ComboBox()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBaudRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataBits = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTestDisplay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTestDisplay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDataBits)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ckEnablePoleDisplay)
        Me.GroupBox1.Controls.Add(Me.txtPrinterDevice)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 172)
        Me.GroupBox1.TabIndex = 386
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POS Pole Display Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(30, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 358
        Me.Label3.Text = "Port Number"
        '
        'ckEnablePoleDisplay
        '
        Me.ckEnablePoleDisplay.AutoSize = True
        Me.ckEnablePoleDisplay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnablePoleDisplay.ForeColor = System.Drawing.Color.Black
        Me.ckEnablePoleDisplay.Location = New System.Drawing.Point(113, 34)
        Me.ckEnablePoleDisplay.Name = "ckEnablePoleDisplay"
        Me.ckEnablePoleDisplay.Size = New System.Drawing.Size(128, 19)
        Me.ckEnablePoleDisplay.TabIndex = 355
        Me.ckEnablePoleDisplay.Text = "Enable Pole Display"
        Me.ckEnablePoleDisplay.UseVisualStyleBackColor = True
        '
        'txtPrinterDevice
        '
        Me.txtPrinterDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPrinterDevice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPrinterDevice.ForeColor = System.Drawing.Color.Black
        Me.txtPrinterDevice.FormattingEnabled = True
        Me.txtPrinterDevice.ItemHeight = 13
        Me.txtPrinterDevice.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
        Me.txtPrinterDevice.Location = New System.Drawing.Point(113, 54)
        Me.txtPrinterDevice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrinterDevice.Name = "txtPrinterDevice"
        Me.txtPrinterDevice.Size = New System.Drawing.Size(100, 21)
        Me.txtPrinterDevice.TabIndex = 354
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(197, 188)
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
        Me.Button1.Location = New System.Drawing.Point(61, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 30)
        Me.Button1.TabIndex = 387
        Me.Button1.Text = "Display Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(46, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 382
        Me.Label1.Text = "Baud Rate"
        '
        'txtBaudRate
        '
        Me.txtBaudRate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBaudRate.ForeColor = System.Drawing.Color.Black
        Me.txtBaudRate.Location = New System.Drawing.Point(113, 78)
        Me.txtBaudRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBaudRate.Name = "txtBaudRate"
        Me.txtBaudRate.Size = New System.Drawing.Size(100, 22)
        Me.txtBaudRate.TabIndex = 381
        Me.txtBaudRate.Text = "9600"
        Me.txtBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(53, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 384
        Me.Label2.Text = "Data Bits"
        '
        'txtDataBits
        '
        Me.txtDataBits.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDataBits.ForeColor = System.Drawing.Color.Black
        Me.txtDataBits.Location = New System.Drawing.Point(113, 103)
        Me.txtDataBits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(100, 22)
        Me.txtDataBits.TabIndex = 383
        Me.txtDataBits.Text = "8"
        Me.txtDataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(219, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 385
        Me.Label4.Text = "Standard rate 9600"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 7.5!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(219, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 386
        Me.Label7.Text = "Standard bits 8"
        '
        'txtTestDisplay
        '
        Me.txtTestDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTestDisplay.ForeColor = System.Drawing.Color.Black
        Me.txtTestDisplay.Location = New System.Drawing.Point(113, 128)
        Me.txtTestDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTestDisplay.Name = "txtTestDisplay"
        Me.txtTestDisplay.Size = New System.Drawing.Size(243, 22)
        Me.txtTestDisplay.TabIndex = 387
        Me.txtTestDisplay.Text = "This is coffeecup system pole display test.."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(37, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 388
        Me.Label5.Text = "Test Display"
        '
        'frmPOSPoleDisplaySettings
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(399, 237)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSPoleDisplaySettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "POS Pole Display Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtPrinterDevice As System.Windows.Forms.ComboBox
    Friend WithEvents ckEnablePoleDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataBits As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTestDisplay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
