<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelGuestInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelGuestInfo))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.txtNationality = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.ComboBox()
        Me.countrycode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtGuestPreferences = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(66, 124)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(48, 13)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(123, 120)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(219, 22)
        Me.txtAddress.TabIndex = 2
        '
        'txtContactNumber
        '
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(123, 218)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(219, 22)
        Me.txtContactNumber.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Contact Number"
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(491, 363)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(57, 23)
        Me.guestid.TabIndex = 410
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 415
        Me.Label2.Text = "Guest Name"
        '
        'txtBirthdate
        '
        Me.txtBirthdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtBirthdate.Enabled = False
        Me.txtBirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBirthdate.Location = New System.Drawing.Point(123, 145)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(149, 22)
        Me.txtBirthdate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 419
        Me.Label4.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtGender.DropDownHeight = 130
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.Black
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.IntegralHeight = False
        Me.txtGender.ItemHeight = 13
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(123, 170)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGender.MaxDropDownItems = 7
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(87, 21)
        Me.txtGender.TabIndex = 4
        '
        'txtNationality
        '
        Me.txtNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtNationality.DropDownHeight = 130
        Me.txtNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtNationality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationality.ForeColor = System.Drawing.Color.Black
        Me.txtNationality.FormattingEnabled = True
        Me.txtNationality.IntegralHeight = False
        Me.txtNationality.ItemHeight = 13
        Me.txtNationality.Location = New System.Drawing.Point(123, 194)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNationality.MaxDropDownItems = 7
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(218, 21)
        Me.txtNationality.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(123, 243)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 22)
        Me.txtEmail.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(65, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 21)
        Me.Label9.TabIndex = 427
        Me.Label9.Text = "Guest Information"
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(123, 381)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(132, 30)
        Me.cmdProceed.TabIndex = 8
        Me.cmdProceed.Text = "Save"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'txtGuest
        '
        Me.txtGuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuest.ForeColor = System.Drawing.Color.Black
        Me.txtGuest.Location = New System.Drawing.Point(123, 71)
        Me.txtGuest.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(219, 22)
        Me.txtGuest.TabIndex = 0
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(342, 447)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(57, 23)
        Me.mode.TabIndex = 429
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'txtCountry
        '
        Me.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCountry.DropDownHeight = 130
        Me.txtCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.ForeColor = System.Drawing.Color.Black
        Me.txtCountry.FormattingEnabled = True
        Me.txtCountry.IntegralHeight = False
        Me.txtCountry.ItemHeight = 13
        Me.txtCountry.Location = New System.Drawing.Point(123, 96)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCountry.MaxDropDownItems = 7
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(219, 21)
        Me.txtCountry.TabIndex = 1
        '
        'countrycode
        '
        Me.countrycode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.countrycode.ForeColor = System.Drawing.Color.Black
        Me.countrycode.Location = New System.Drawing.Point(491, 396)
        Me.countrycode.Margin = New System.Windows.Forms.Padding(5)
        Me.countrycode.Name = "countrycode"
        Me.countrycode.Size = New System.Drawing.Size(57, 23)
        Me.countrycode.TabIndex = 431
        Me.countrycode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.countrycode.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 432
        Me.Label7.Text = "Country"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitConsoleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(372, 24)
        Me.MenuStrip1.TabIndex = 475
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitConsoleToolStripMenuItem
        '
        Me.ExitConsoleToolStripMenuItem.Name = "ExitConsoleToolStripMenuItem"
        Me.ExitConsoleToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ExitConsoleToolStripMenuItem.Text = "Exit Form"
        '
        'txtGuestPreferences
        '
        Me.txtGuestPreferences.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtGuestPreferences.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestPreferences.ForeColor = System.Drawing.Color.Black
        Me.txtGuestPreferences.Location = New System.Drawing.Point(58, 290)
        Me.txtGuestPreferences.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuestPreferences.Multiline = True
        Me.txtGuestPreferences.Name = "txtGuestPreferences"
        Me.txtGuestPreferences.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGuestPreferences.Size = New System.Drawing.Size(284, 86)
        Me.txtGuestPreferences.TabIndex = 478
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 479
        Me.Label8.Text = "Guest Preferences"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(36, 147)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(78, 19)
        Me.CheckBox1.TabIndex = 480
        Me.CheckBox1.Text = "Birth Date"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(49, 196)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 15)
        Me.LinkLabel1.TabIndex = 481
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nationality"
        '
        'frmHotelGuestInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(372, 426)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtGuestPreferences)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.countrycode)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.cmdProceed)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblTransaction)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelGuestInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtNationality As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents txtGuest As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.ComboBox
    Friend WithEvents countrycode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtGuestPreferences As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
