<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountInformation))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckChangePassword = New System.Windows.Forms.CheckBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtSystemIcon = New System.Windows.Forms.ComboBox()
        Me.lblcontactperson = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.txtBgColor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFontColor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.imgProfile = New DevExpress.XtraEditors.PictureEdit()
        Me.ckPicChanged = New DevExpress.XtraEditors.CheckEdit()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.imgProfile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckPicChanged.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(191, 358)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(200, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Update Information"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(192, 87)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(198, 22)
        Me.txtPosition.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(134, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(100, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "New Password"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(192, 62)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(198, 22)
        Me.txtName.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(97, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Account Name"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(192, 313)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtNewPassword.ReadOnly = True
        Me.txtNewPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtNewPassword.TabIndex = 5
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(192, 290)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtCurrentPassword.ReadOnly = True
        Me.txtCurrentPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtCurrentPassword.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(84, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 370
        Me.Label1.Text = "Current Password"
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(192, 336)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtVerifyPassword.ReadOnly = True
        Me.txtVerifyPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtVerifyPassword.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(95, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Verify Password"
        '
        'ckChangePassword
        '
        Me.ckChangePassword.AutoSize = True
        Me.ckChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckChangePassword.ForeColor = System.Drawing.Color.Black
        Me.ckChangePassword.Location = New System.Drawing.Point(192, 270)
        Me.ckChangePassword.Name = "ckChangePassword"
        Me.ckChangePassword.Size = New System.Drawing.Size(120, 19)
        Me.ckChangePassword.TabIndex = 3
        Me.ckChangePassword.Text = "Change Password"
        Me.ckChangePassword.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(192, 137)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(198, 22)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmail.Location = New System.Drawing.Point(45, 140)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(139, 15)
        Me.lblEmail.TabIndex = 376
        Me.lblEmail.Text = "Email Address"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNickname
        '
        Me.txtNickname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNickname.ForeColor = System.Drawing.Color.Black
        Me.txtNickname.Location = New System.Drawing.Point(192, 112)
        Me.txtNickname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(198, 22)
        Me.txtNickname.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(123, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 378
        Me.Label5.Text = "Nickname"
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(55, 33)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(355, 15)
        Me.lbldescription.TabIndex = 382
        Me.lbldescription.Text = "Please update your account information to activate coffeecup."
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(55, 14)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(139, 19)
        Me.lbltitle.TabIndex = 381
        Me.lbltitle.Text = "Account Information"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.osmo
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(11, 4)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(48, 51)
        Me.picicon.TabIndex = 384
        Me.picicon.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(43, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(349, 15)
        Me.Label6.TabIndex = 383
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(27, 344)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(52, 22)
        Me.mode.TabIndex = 385
        Me.mode.Visible = False
        '
        'txtSystemIcon
        '
        Me.txtSystemIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSystemIcon.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSystemIcon.ForeColor = System.Drawing.Color.Black
        Me.txtSystemIcon.FormattingEnabled = True
        Me.txtSystemIcon.ItemHeight = 13
        Me.txtSystemIcon.Location = New System.Drawing.Point(192, 187)
        Me.txtSystemIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSystemIcon.Name = "txtSystemIcon"
        Me.txtSystemIcon.Size = New System.Drawing.Size(199, 21)
        Me.txtSystemIcon.TabIndex = 386
        '
        'lblcontactperson
        '
        Me.lblcontactperson.AutoSize = True
        Me.lblcontactperson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcontactperson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcontactperson.Location = New System.Drawing.Point(113, 189)
        Me.lblcontactperson.Name = "lblcontactperson"
        Me.lblcontactperson.Size = New System.Drawing.Size(71, 15)
        Me.lblcontactperson.TabIndex = 387
        Me.lblcontactperson.Text = "System Icon"
        '
        'txtBgColor
        '
        Me.txtBgColor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBgColor.ForeColor = System.Drawing.Color.Black
        Me.txtBgColor.Location = New System.Drawing.Point(192, 211)
        Me.txtBgColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBgColor.Name = "txtBgColor"
        Me.txtBgColor.ReadOnly = True
        Me.txtBgColor.Size = New System.Drawing.Size(31, 22)
        Me.txtBgColor.TabIndex = 388
        Me.txtBgColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(103, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 389
        Me.Label8.Text = "Color Scheme"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(225, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 24)
        Me.Button1.TabIndex = 390
        Me.Button1.Text = "Pick Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFontColor
        '
        Me.txtFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFontColor.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFontColor.ForeColor = System.Drawing.Color.Black
        Me.txtFontColor.FormattingEnabled = True
        Me.txtFontColor.ItemHeight = 13
        Me.txtFontColor.Items.AddRange(New Object() {"DARK", "LIGHT"})
        Me.txtFontColor.Location = New System.Drawing.Point(192, 236)
        Me.txtFontColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFontColor.Name = "txtFontColor"
        Me.txtFontColor.Size = New System.Drawing.Size(144, 21)
        Me.txtFontColor.TabIndex = 391
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(121, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 392
        Me.Label9.Text = "Font Color"
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Controls.Add(Me.imgProfile)
        Me.GroupControl5.GroupStyle = DevExpress.Utils.GroupStyle.Title
        Me.GroupControl5.Location = New System.Drawing.Point(398, 62)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(202, 202)
        Me.GroupControl5.TabIndex = 862
        Me.GroupControl5.Text = "Right click to take picture"
        '
        'imgProfile
        '
        Me.imgProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgProfile.Location = New System.Drawing.Point(0, 19)
        Me.imgProfile.Name = "imgProfile"
        Me.imgProfile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.imgProfile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.imgProfile.Size = New System.Drawing.Size(202, 183)
        Me.imgProfile.TabIndex = 775
        '
        'ckPicChanged
        '
        Me.ckPicChanged.Location = New System.Drawing.Point(471, 289)
        Me.ckPicChanged.Name = "ckPicChanged"
        Me.ckPicChanged.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPicChanged.Properties.Appearance.Options.UseFont = True
        Me.ckPicChanged.Properties.Caption = "Pic Change"
        Me.ckPicChanged.Size = New System.Drawing.Size(89, 19)
        Me.ckPicChanged.TabIndex = 863
        Me.ckPicChanged.Visible = False
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(192, 162)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(198, 22)
        Me.txtContactNumber.TabIndex = 864
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(45, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 15)
        Me.Label10.TabIndex = 865
        Me.Label10.Text = "Contact Number"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmAccountInformation
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(612, 419)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ckPicChanged)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.txtFontColor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBgColor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSystemIcon)
        Me.Controls.Add(Me.lblcontactperson)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNickname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.ckChangePassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAccountInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Account Info."
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.imgProfile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckPicChanged.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckChangePassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtNickname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtSystemIcon As System.Windows.Forms.ComboBox
    Friend WithEvents lblcontactperson As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents txtBgColor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFontColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents imgProfile As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ckPicChanged As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
