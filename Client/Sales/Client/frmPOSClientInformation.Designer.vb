<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSClientInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSClientInformation))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientGroup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupcode = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtVIPno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(158, 246)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(181, 38)
        Me.cmdConfirm.TabIndex = 6
        Me.cmdConfirm.Text = "Submit for Approval"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(159, 16)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(136, 22)
        Me.id.TabIndex = 397
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(96, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 396
        Me.Label4.Text = "CIF Code"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.Location = New System.Drawing.Point(159, 41)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(262, 22)
        Me.txtCompanyName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Client/Company Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(47, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 400
        Me.Label2.Text = "Complete Address"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(159, 66)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(262, 47)
        Me.txtAddress.TabIndex = 1
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(159, 116)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(262, 22)
        Me.txtContactNumber.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(25, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Mobile/Telephone No."
        '
        'txtClientGroup
        '
        Me.txtClientGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClientGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClientGroup.DropDownHeight = 130
        Me.txtClientGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClientGroup.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtClientGroup.ForeColor = System.Drawing.Color.Black
        Me.txtClientGroup.FormattingEnabled = True
        Me.txtClientGroup.IntegralHeight = False
        Me.txtClientGroup.ItemHeight = 15
        Me.txtClientGroup.Location = New System.Drawing.Point(159, 219)
        Me.txtClientGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientGroup.MaxDropDownItems = 7
        Me.txtClientGroup.Name = "txtClientGroup"
        Me.txtClientGroup.Size = New System.Drawing.Size(262, 23)
        Me.txtClientGroup.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(77, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 404
        Me.Label5.Text = "Client Group"
        '
        'groupcode
        '
        Me.groupcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.groupcode.ForeColor = System.Drawing.Color.Black
        Me.groupcode.Location = New System.Drawing.Point(13, 256)
        Me.groupcode.Margin = New System.Windows.Forms.Padding(4)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.ReadOnly = True
        Me.groupcode.Size = New System.Drawing.Size(60, 22)
        Me.groupcode.TabIndex = 405
        Me.groupcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.groupcode.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(159, 168)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(181, 22)
        Me.txtEmail.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(115, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 407
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(92, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 409
        Me.Label7.Text = "Birth Date"
        '
        'txtBirthdate
        '
        Me.txtBirthdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBirthdate.Location = New System.Drawing.Point(159, 141)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(181, 23)
        Me.txtBirthdate.TabIndex = 3
        '
        'txtVIPno
        '
        Me.txtVIPno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtVIPno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVIPno.ForeColor = System.Drawing.Color.Black
        Me.txtVIPno.Location = New System.Drawing.Point(159, 193)
        Me.txtVIPno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVIPno.Name = "txtVIPno"
        Me.txtVIPno.Size = New System.Drawing.Size(181, 22)
        Me.txtVIPno.TabIndex = 410
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(105, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 411
        Me.Label8.Text = "VIP No."
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(80, 256)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(60, 22)
        Me.mode.TabIndex = 412
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'frmPOSClientInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(463, 299)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtVIPno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClientGroup)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSClientInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClientGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVIPno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
End Class
