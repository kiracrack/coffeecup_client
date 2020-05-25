<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelReportingTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelReportingTool))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReportingType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(129, 130)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(151, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Generate Report"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label20.Location = New System.Drawing.Point(58, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(171, 20)
        Me.Label20.TabIndex = 466
        Me.Label20.Text = "Select Report Date Filter"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(129, 80)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(151, 22)
        Me.txtfrmdate.TabIndex = 816
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(129, 105)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(151, 22)
        Me.txttodate.TabIndex = 817
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(59, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 828
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(74, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 829
        Me.Label2.Text = "Date To"
        '
        'txtReportingType
        '
        Me.txtReportingType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtReportingType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtReportingType.DropDownHeight = 130
        Me.txtReportingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtReportingType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReportingType.ForeColor = System.Drawing.Color.Black
        Me.txtReportingType.FormattingEnabled = True
        Me.txtReportingType.IntegralHeight = False
        Me.txtReportingType.ItemHeight = 15
        Me.txtReportingType.Items.AddRange(New Object() {"Hotel Sales Summary (default)"})
        Me.txtReportingType.Location = New System.Drawing.Point(129, 53)
        Me.txtReportingType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReportingType.MaxDropDownItems = 7
        Me.txtReportingType.Name = "txtReportingType"
        Me.txtReportingType.Size = New System.Drawing.Size(268, 23)
        Me.txtReportingType.TabIndex = 833
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(51, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 834
        Me.Label4.Text = "Report Type"
        '
        'frmHotelReportingTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(489, 205)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReportingType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfrmdate)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelReportingTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Revenue Reporting Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReportingType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
