<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateTransferFFE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateTransferFFE))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFFECode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFFEType = New System.Windows.Forms.TextBox()
        Me.officeid_to = New System.Windows.Forms.TextBox()
        Me.txtOfficeName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.officeid_from = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.White
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(117, 193)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(199, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Confirm Transfer"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(117, 38)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(351, 22)
        Me.txtProductName.TabIndex = 360
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(55, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 359
        Me.Label13.Text = "FFE Code"
        '
        'txtFFECode
        '
        Me.txtFFECode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFFECode.ForeColor = System.Drawing.Color.Black
        Me.txtFFECode.Location = New System.Drawing.Point(117, 13)
        Me.txtFFECode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFFECode.Name = "txtFFECode"
        Me.txtFFECode.ReadOnly = True
        Me.txtFFECode.Size = New System.Drawing.Size(114, 22)
        Me.txtFFECode.TabIndex = 361
        Me.txtFFECode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(19, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "Unit Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(58, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 364
        Me.Label2.Text = "FFE Type"
        '
        'txtFFEType
        '
        Me.txtFFEType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFFEType.ForeColor = System.Drawing.Color.Black
        Me.txtFFEType.Location = New System.Drawing.Point(117, 63)
        Me.txtFFEType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFFEType.Name = "txtFFEType"
        Me.txtFFEType.ReadOnly = True
        Me.txtFFEType.Size = New System.Drawing.Size(199, 22)
        Me.txtFFEType.TabIndex = 363
        '
        'officeid_to
        '
        Me.officeid_to.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid_to.ForeColor = System.Drawing.Color.Black
        Me.officeid_to.Location = New System.Drawing.Point(684, 224)
        Me.officeid_to.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid_to.Name = "officeid_to"
        Me.officeid_to.Size = New System.Drawing.Size(69, 22)
        Me.officeid_to.TabIndex = 415
        Me.officeid_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid_to.Visible = False
        '
        'txtOfficeName
        '
        Me.txtOfficeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOfficeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtOfficeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtOfficeName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOfficeName.ForeColor = System.Drawing.Color.Black
        Me.txtOfficeName.FormattingEnabled = True
        Me.txtOfficeName.ItemHeight = 13
        Me.txtOfficeName.Location = New System.Drawing.Point(117, 88)
        Me.txtOfficeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOfficeName.Name = "txtOfficeName"
        Me.txtOfficeName.Size = New System.Drawing.Size(306, 21)
        Me.txtOfficeName.TabIndex = 416
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(48, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 417
        Me.Label3.Text = "Transfer to"
        '
        'officeid_from
        '
        Me.officeid_from.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid_from.ForeColor = System.Drawing.Color.Black
        Me.officeid_from.Location = New System.Drawing.Point(607, 224)
        Me.officeid_from.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid_from.Name = "officeid_from"
        Me.officeid_from.Size = New System.Drawing.Size(69, 22)
        Me.officeid_from.TabIndex = 419
        Me.officeid_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid_from.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(58, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 418
        Me.Label4.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.Location = New System.Drawing.Point(117, 113)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(306, 78)
        Me.txtMessage.TabIndex = 2
        '
        'frmCreateTransferFFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(523, 236)
        Me.Controls.Add(Me.officeid_from)
        Me.Controls.Add(Me.officeid_to)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFFECode)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtFFEType)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtOfficeName)
        Me.Controls.Add(Me.Label13)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreateTransferFFE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFE Transfer Management"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFFECode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFFEType As System.Windows.Forms.TextBox
    Friend WithEvents officeid_to As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents officeid_from As System.Windows.Forms.TextBox
End Class
