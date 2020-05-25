<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierRegistration
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplierRegistration))
        Me.Stop_Button = New System.Windows.Forms.Button()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBankAccount = New System.Windows.Forms.ComboBox()
        Me.lblunderchapter = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtlink = New System.Windows.Forms.LinkLabel()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmessage = New System.Windows.Forms.RichTextBox()
        Me.cmda1 = New System.Windows.Forms.Button()
        Me.txtattached1 = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ckQuotation = New System.Windows.Forms.CheckBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdOnlineData = New System.Windows.Forms.ToolStripMenuItem()
        Me.My_BgWorker = New System.ComponentModel.BackgroundWorker()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stop_Button
        '
        Me.Stop_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Stop_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Stop_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Stop_Button.Location = New System.Drawing.Point(249, 477)
        Me.Stop_Button.Name = "Stop_Button"
        Me.Stop_Button.Size = New System.Drawing.Size(99, 30)
        Me.Stop_Button.TabIndex = 12
        Me.Stop_Button.Text = "Close"
        Me.Stop_Button.UseVisualStyleBackColor = True
        '
        'Start_Button
        '
        Me.Start_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Start_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Start_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Start_Button.Location = New System.Drawing.Point(91, 477)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(152, 30)
        Me.Start_Button.TabIndex = 11
        Me.Start_Button.Text = "Register Supplier"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(59, 32)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(362, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to register directly to the main server"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(412, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(59, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(206, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Supplier or Vendor Registration"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(367, 267)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(61, 22)
        Me.mode.TabIndex = 406
        Me.mode.Visible = False
        '
        'vendorid
        '
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(367, 237)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Size = New System.Drawing.Size(61, 22)
        Me.vendorid.TabIndex = 405
        Me.vendorid.Visible = False
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAccountNumber.ForeColor = System.Drawing.Color.Black
        Me.txtAccountNumber.Location = New System.Drawing.Point(141, 266)
        Me.txtAccountNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(209, 22)
        Me.txtAccountNumber.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(36, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 404
        Me.Label8.Text = "Account Number"
        '
        'txtBankAccount
        '
        Me.txtBankAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBankAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBankAccount.DropDownHeight = 130
        Me.txtBankAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBankAccount.ForeColor = System.Drawing.Color.Black
        Me.txtBankAccount.FormattingEnabled = True
        Me.txtBankAccount.IntegralHeight = False
        Me.txtBankAccount.ItemHeight = 13
        Me.txtBankAccount.Location = New System.Drawing.Point(141, 242)
        Me.txtBankAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBankAccount.Name = "txtBankAccount"
        Me.txtBankAccount.Size = New System.Drawing.Size(209, 21)
        Me.txtBankAccount.TabIndex = 6
        '
        'lblunderchapter
        '
        Me.lblunderchapter.AutoSize = True
        Me.lblunderchapter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblunderchapter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblunderchapter.Location = New System.Drawing.Point(54, 244)
        Me.lblunderchapter.Name = "lblunderchapter"
        Me.lblunderchapter.Size = New System.Drawing.Size(81, 15)
        Me.lblunderchapter.TabIndex = 402
        Me.lblunderchapter.Text = "Bank Account"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(139, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 15)
        Me.Label7.TabIndex = 400
        Me.Label7.Text = "*Red field are mandated to fill up"
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(141, 217)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(209, 22)
        Me.txtPosition.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(85, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 399
        Me.Label4.Text = "Position"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactPerson.ForeColor = System.Drawing.Color.Black
        Me.txtContactPerson.Location = New System.Drawing.Point(141, 192)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(209, 22)
        Me.txtContactPerson.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 397
        Me.Label3.Text = "Contact Person Name"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.Black
        Me.txtEmailAddress.Location = New System.Drawing.Point(141, 167)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(209, 22)
        Me.txtEmailAddress.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(54, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 395
        Me.Label2.Text = "Email Address"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(141, 142)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(209, 22)
        Me.txtContactNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(39, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 393
        Me.Label1.Text = "Contact Number"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(141, 99)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(284, 40)
        Me.txtAddress.TabIndex = 1
        '
        'txtlink
        '
        Me.txtlink.AutoSize = True
        Me.txtlink.Location = New System.Drawing.Point(199, 296)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(133, 13)
        Me.txtlink.TabIndex = 390
        Me.txtlink.TabStop = True
        Me.txtlink.Text = "How to compress your files"
        '
        'lblAttachment
        '
        Me.lblAttachment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttachment.ForeColor = System.Drawing.Color.Red
        Me.lblAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAttachment.Location = New System.Drawing.Point(49, 339)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(316, 34)
        Me.lblAttachment.TabIndex = 389
        '
        'Lbl_Status
        '
        Me.Lbl_Status.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Status.Location = New System.Drawing.Point(23, 454)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(405, 13)
        Me.Lbl_Status.TabIndex = 387
        Me.Lbl_Status.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 437)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(403, 14)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 386
        Me.ProgressBar1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(31, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 377
        Me.Label5.Text = "Complete Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmessage)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 58)
        Me.GroupBox1.TabIndex = 364
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notify message to procurement"
        '
        'txtmessage
        '
        Me.txtmessage.BackColor = System.Drawing.Color.White
        Me.txtmessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtmessage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmessage.Location = New System.Drawing.Point(3, 18)
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(397, 37)
        Me.txtmessage.TabIndex = 10
        Me.txtmessage.Text = ""
        '
        'cmda1
        '
        Me.cmda1.Enabled = False
        Me.cmda1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmda1.Location = New System.Drawing.Point(49, 314)
        Me.cmda1.Name = "cmda1"
        Me.cmda1.Size = New System.Drawing.Size(88, 22)
        Me.cmda1.TabIndex = 9
        Me.cmda1.Text = "Browse"
        Me.cmda1.UseCompatibleTextRendering = True
        '
        'txtattached1
        '
        Me.txtattached1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtattached1.ForeColor = System.Drawing.Color.Black
        Me.txtattached1.Location = New System.Drawing.Point(141, 314)
        Me.txtattached1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtattached1.Name = "txtattached1"
        Me.txtattached1.ReadOnly = True
        Me.txtattached1.Size = New System.Drawing.Size(209, 22)
        Me.txtattached1.TabIndex = 10
        '
        'txtCompanyName
        '
        Me.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.Location = New System.Drawing.Point(141, 74)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(209, 22)
        Me.txtCompanyName.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(41, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Company Name"
        '
        'ckQuotation
        '
        Me.ckQuotation.AutoSize = True
        Me.ckQuotation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckQuotation.ForeColor = System.Drawing.Color.Black
        Me.ckQuotation.Location = New System.Drawing.Point(50, 295)
        Me.ckQuotation.Name = "ckQuotation"
        Me.ckQuotation.Size = New System.Drawing.Size(151, 19)
        Me.ckQuotation.TabIndex = 8
        Me.ckQuotation.Text = "Add supplier document"
        Me.ckQuotation.UseVisualStyleBackColor = True
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.cmdLocalData, Me.ToolStripSeparator4, Me.cmdOnlineData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(194, 76)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.application_task
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EditChapterToolStripMenuItem.Text = "Column Chooser"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(193, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'cmdOnlineData
        '
        Me.cmdOnlineData.Image = Global.CoffeecupClient.My.Resources.Resources.Network_Drive_Connected__3_
        Me.cmdOnlineData.Name = "cmdOnlineData"
        Me.cmdOnlineData.Size = New System.Drawing.Size(193, 22)
        Me.cmdOnlineData.Tag = "0"
        Me.cmdOnlineData.Text = "Online Current Update"
        '
        'My_BgWorker
        '
        Me.My_BgWorker.WorkerReportsProgress = True
        Me.My_BgWorker.WorkerSupportsCancellation = True
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.Lorry
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 6)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(51, 43)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'frmSupplierRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(449, 515)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtBankAccount)
        Me.Controls.Add(Me.lblunderchapter)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Stop_Button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.ckQuotation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtattached1)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.cmda1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlink)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblAttachment)
        Me.Controls.Add(Me.Lbl_Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSupplierRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier or Vendor Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.cms_em.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Stop_Button As System.Windows.Forms.Button
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdOnlineData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtattached1 As System.Windows.Forms.TextBox
    Friend WithEvents ckQuotation As System.Windows.Forms.CheckBox
    Friend WithEvents cmda1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmessage As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents My_BgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents txtlink As System.Windows.Forms.LinkLabel
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblunderchapter As System.Windows.Forms.Label
    Friend WithEvents txtAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
End Class
