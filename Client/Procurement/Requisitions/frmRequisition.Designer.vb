<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisition
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequisition))
        Me.potypeid = New System.Windows.Forms.TextBox()
        Me.Stop_Button = New System.Windows.Forms.Button()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabRequest = New System.Windows.Forms.TabPage()
        Me.allocatedid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtlink = New System.Windows.Forms.LinkLabel()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pid = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.txtApprovingLevel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRequestJustification = New System.Windows.Forms.RichTextBox()
        Me.cmda1 = New System.Windows.Forms.Button()
        Me.txtattached1 = New System.Windows.Forms.TextBox()
        Me.txtPriority = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrequester = New System.Windows.Forms.ComboBox()
        Me.lblcontactperson = New System.Windows.Forms.Label()
        Me.txtPurchaseType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblunderchapter = New System.Windows.Forms.Label()
        Me.ckQuotation = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtSelectOffice = New System.Windows.Forms.ComboBox()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdFind = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.reqid = New System.Windows.Forms.TextBox()
        Me.My_BgWorker = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDateNeeded = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.tabRequest.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'potypeid
        '
        Me.potypeid.Enabled = False
        Me.potypeid.Location = New System.Drawing.Point(12, 434)
        Me.potypeid.Name = "potypeid"
        Me.potypeid.ReadOnly = True
        Me.potypeid.Size = New System.Drawing.Size(88, 22)
        Me.potypeid.TabIndex = 248
        Me.potypeid.Visible = False
        '
        'Stop_Button
        '
        Me.Stop_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Stop_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Stop_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Stop_Button.Location = New System.Drawing.Point(508, 421)
        Me.Stop_Button.Name = "Stop_Button"
        Me.Stop_Button.Size = New System.Drawing.Size(99, 30)
        Me.Stop_Button.TabIndex = 8
        Me.Stop_Button.Text = "Cancel"
        Me.Stop_Button.UseVisualStyleBackColor = True
        '
        'Start_Button
        '
        Me.Start_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Start_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Start_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Start_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Start_Button.Location = New System.Drawing.Point(245, 421)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(152, 30)
        Me.Start_Button.TabIndex = 7
        Me.Start_Button.Text = "Submit for Approval"
        Me.Start_Button.UseVisualStyleBackColor = False
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
        Me.lbldescription.Text = "You can use this service to create request and send to main server"
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
        Me.Label6.Text = "_________________________________________________________________________________" &
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
        Me.lbltitle.Size = New System.Drawing.Size(173, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Request Information Form"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabRequest)
        Me.TabControl1.Controls.Add(Me.tabParticular)
        Me.TabControl1.Location = New System.Drawing.Point(9, 56)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(724, 295)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(846, 359)
        Me.TabControl1.TabIndex = 260
        '
        'tabRequest
        '
        Me.tabRequest.Controls.Add(Me.Label7)
        Me.tabRequest.Controls.Add(Me.txtDateNeeded)
        Me.tabRequest.Controls.Add(Me.txtMessage)
        Me.tabRequest.Controls.Add(Me.Label1)
        Me.tabRequest.Controls.Add(Me.LinkLabel1)
        Me.tabRequest.Controls.Add(Me.txtlink)
        Me.tabRequest.Controls.Add(Me.Lbl_Status)
        Me.tabRequest.Controls.Add(Me.ProgressBar1)
        Me.tabRequest.Controls.Add(Me.pid)
        Me.tabRequest.Controls.Add(Me.cmdCancel)
        Me.tabRequest.Controls.Add(Me.lblAttachment)
        Me.tabRequest.Controls.Add(Me.txtApprovingLevel)
        Me.tabRequest.Controls.Add(Me.Label4)
        Me.tabRequest.Controls.Add(Me.Label3)
        Me.tabRequest.Controls.Add(Me.GroupBox1)
        Me.tabRequest.Controls.Add(Me.cmda1)
        Me.tabRequest.Controls.Add(Me.txtattached1)
        Me.tabRequest.Controls.Add(Me.txtPriority)
        Me.tabRequest.Controls.Add(Me.Label2)
        Me.tabRequest.Controls.Add(Me.txtrequester)
        Me.tabRequest.Controls.Add(Me.lblcontactperson)
        Me.tabRequest.Controls.Add(Me.txtPurchaseType)
        Me.tabRequest.Controls.Add(Me.Label13)
        Me.tabRequest.Controls.Add(Me.lblunderchapter)
        Me.tabRequest.Controls.Add(Me.ckQuotation)
        Me.tabRequest.Controls.Add(Me.CheckBox1)
        Me.tabRequest.Controls.Add(Me.txtSelectOffice)
        Me.tabRequest.Location = New System.Drawing.Point(4, 22)
        Me.tabRequest.Name = "tabRequest"
        Me.tabRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRequest.Size = New System.Drawing.Size(838, 333)
        Me.tabRequest.TabIndex = 0
        Me.tabRequest.Text = "Request Information"
        Me.tabRequest.UseVisualStyleBackColor = True
        '
        'allocatedid
        '
        Me.allocatedid.Enabled = False
        Me.allocatedid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.allocatedid.ForeColor = System.Drawing.Color.Black
        Me.allocatedid.Location = New System.Drawing.Point(172, 463)
        Me.allocatedid.Margin = New System.Windows.Forms.Padding(4)
        Me.allocatedid.Name = "allocatedid"
        Me.allocatedid.ReadOnly = True
        Me.allocatedid.Size = New System.Drawing.Size(58, 23)
        Me.allocatedid.TabIndex = 387
        Me.allocatedid.Visible = False
        '
        'mode
        '
        Me.mode.Enabled = False
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(106, 463)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(58, 23)
        Me.mode.TabIndex = 384
        Me.mode.Visible = False
        '
        'officeid
        '
        Me.officeid.Enabled = False
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(16, 463)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(88, 23)
        Me.officeid.TabIndex = 383
        Me.officeid.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.Location = New System.Drawing.Point(370, 247)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(457, 39)
        Me.txtMessage.TabIndex = 381
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(367, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 372
        Me.Label1.Text = "Message to Approver"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(252, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(108, 13)
        Me.LinkLabel1.TabIndex = 380
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View History"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtlink
        '
        Me.txtlink.AutoSize = True
        Me.txtlink.Location = New System.Drawing.Point(215, 212)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(146, 13)
        Me.txtlink.TabIndex = 378
        Me.txtlink.TabStop = True
        Me.txtlink.Text = "How to compress your files"
        '
        'Lbl_Status
        '
        Me.Lbl_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Status.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Status.Location = New System.Drawing.Point(367, 313)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(463, 13)
        Me.Lbl_Status.TabIndex = 377
        Me.Lbl_Status.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(370, 289)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(457, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 376
        Me.ProgressBar1.Visible = False
        '
        'pid
        '
        Me.pid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.pid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.pid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.ForeColor = System.Drawing.Color.Black
        Me.pid.FormattingEnabled = True
        Me.pid.ItemHeight = 13
        Me.pid.Location = New System.Drawing.Point(117, 29)
        Me.pid.Margin = New System.Windows.Forms.Padding(4)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(215, 21)
        Me.pid.TabIndex = 368
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources._150
        Me.cmdCancel.Location = New System.Drawing.Point(334, 28)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(26, 23)
        Me.cmdCancel.TabIndex = 375
        Me.cmdCancel.UseCompatibleTextRendering = True
        Me.cmdCancel.Visible = False
        '
        'lblAttachment
        '
        Me.lblAttachment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttachment.ForeColor = System.Drawing.Color.Red
        Me.lblAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAttachment.Location = New System.Drawing.Point(37, 255)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(323, 43)
        Me.lblAttachment.TabIndex = 373
        '
        'txtApprovingLevel
        '
        Me.txtApprovingLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtApprovingLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtApprovingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtApprovingLevel.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtApprovingLevel.ForeColor = System.Drawing.Color.Black
        Me.txtApprovingLevel.FormattingEnabled = True
        Me.txtApprovingLevel.ItemHeight = 19
        Me.txtApprovingLevel.Items.AddRange(New Object() {"BRANCH LEVEL", "CORPORATE LEVEL"})
        Me.txtApprovingLevel.Location = New System.Drawing.Point(117, 53)
        Me.txtApprovingLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApprovingLevel.Name = "txtApprovingLevel"
        Me.txtApprovingLevel.Size = New System.Drawing.Size(243, 27)
        Me.txtApprovingLevel.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(31, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 371
        Me.Label4.Text = "Request Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(42, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 369
        Me.Label3.Text = "Batch Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtRequestJustification)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(367, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 218)
        Me.GroupBox1.TabIndex = 364
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complete Request Justification"
        '
        'txtRequestJustification
        '
        Me.txtRequestJustification.AutoWordSelection = True
        Me.txtRequestJustification.BackColor = System.Drawing.Color.White
        Me.txtRequestJustification.BulletIndent = 10
        Me.txtRequestJustification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRequestJustification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRequestJustification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestJustification.Location = New System.Drawing.Point(3, 19)
        Me.txtRequestJustification.Name = "txtRequestJustification"
        Me.txtRequestJustification.ShowSelectionMargin = True
        Me.txtRequestJustification.Size = New System.Drawing.Size(457, 196)
        Me.txtRequestJustification.TabIndex = 364
        Me.txtRequestJustification.Text = ""
        '
        'cmda1
        '
        Me.cmda1.Enabled = False
        Me.cmda1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmda1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmda1.Location = New System.Drawing.Point(37, 229)
        Me.cmda1.Name = "cmda1"
        Me.cmda1.Size = New System.Drawing.Size(78, 22)
        Me.cmda1.TabIndex = 360
        Me.cmda1.Text = "Browse"
        Me.cmda1.UseCompatibleTextRendering = True
        '
        'txtattached1
        '
        Me.txtattached1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtattached1.ForeColor = System.Drawing.Color.Black
        Me.txtattached1.Location = New System.Drawing.Point(117, 229)
        Me.txtattached1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtattached1.Name = "txtattached1"
        Me.txtattached1.ReadOnly = True
        Me.txtattached1.Size = New System.Drawing.Size(243, 22)
        Me.txtattached1.TabIndex = 353
        '
        'txtPriority
        '
        Me.txtPriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPriority.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPriority.ForeColor = System.Drawing.Color.Black
        Me.txtPriority.FormattingEnabled = True
        Me.txtPriority.ItemHeight = 13
        Me.txtPriority.Items.AddRange(New Object() {"Low", "Normal", "High", "Emergency"})
        Me.txtPriority.Location = New System.Drawing.Point(117, 155)
        Me.txtPriority.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(243, 21)
        Me.txtPriority.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(65, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "Priority"
        '
        'txtrequester
        '
        Me.txtrequester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtrequester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtrequester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtrequester.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtrequester.ForeColor = System.Drawing.Color.Black
        Me.txtrequester.FormattingEnabled = True
        Me.txtrequester.ItemHeight = 13
        Me.txtrequester.Location = New System.Drawing.Point(117, 131)
        Me.txtrequester.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrequester.Name = "txtrequester"
        Me.txtrequester.Size = New System.Drawing.Size(243, 21)
        Me.txtrequester.TabIndex = 1
        '
        'lblcontactperson
        '
        Me.lblcontactperson.AutoSize = True
        Me.lblcontactperson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcontactperson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcontactperson.Location = New System.Drawing.Point(45, 134)
        Me.lblcontactperson.Name = "lblcontactperson"
        Me.lblcontactperson.Size = New System.Drawing.Size(65, 15)
        Me.lblcontactperson.TabIndex = 350
        Me.lblcontactperson.Text = "Request By"
        '
        'txtPurchaseType
        '
        Me.txtPurchaseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPurchaseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtPurchaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPurchaseType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPurchaseType.ForeColor = System.Drawing.Color.Black
        Me.txtPurchaseType.FormattingEnabled = True
        Me.txtPurchaseType.ItemHeight = 13
        Me.txtPurchaseType.Location = New System.Drawing.Point(117, 107)
        Me.txtPurchaseType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPurchaseType.Name = "txtPurchaseType"
        Me.txtPurchaseType.Size = New System.Drawing.Size(243, 21)
        Me.txtPurchaseType.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(36, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Office Name"
        '
        'lblunderchapter
        '
        Me.lblunderchapter.AutoSize = True
        Me.lblunderchapter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblunderchapter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblunderchapter.Location = New System.Drawing.Point(33, 110)
        Me.lblunderchapter.Name = "lblunderchapter"
        Me.lblunderchapter.Size = New System.Drawing.Size(77, 15)
        Me.lblunderchapter.TabIndex = 343
        Me.lblunderchapter.Text = "Request Type"
        '
        'ckQuotation
        '
        Me.ckQuotation.AutoSize = True
        Me.ckQuotation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckQuotation.ForeColor = System.Drawing.Color.Black
        Me.ckQuotation.Location = New System.Drawing.Point(38, 210)
        Me.ckQuotation.Name = "ckQuotation"
        Me.ckQuotation.Size = New System.Drawing.Size(114, 19)
        Me.ckQuotation.TabIndex = 356
        Me.ckQuotation.Text = "Add Attachment"
        Me.ckQuotation.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(117, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox1.TabIndex = 379
        Me.CheckBox1.Text = "Select from draft list"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtSelectOffice
        '
        Me.txtSelectOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSelectOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtSelectOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSelectOffice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSelectOffice.ForeColor = System.Drawing.Color.Black
        Me.txtSelectOffice.FormattingEnabled = True
        Me.txtSelectOffice.ItemHeight = 13
        Me.txtSelectOffice.Location = New System.Drawing.Point(117, 83)
        Me.txtSelectOffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSelectOffice.Name = "txtSelectOffice"
        Me.txtSelectOffice.Size = New System.Drawing.Size(243, 21)
        Me.txtSelectOffice.TabIndex = 382
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.Panel2)
        Me.tabParticular.Controls.Add(Me.MyDataGridView)
        Me.tabParticular.Location = New System.Drawing.Point(4, 22)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(838, 333)
        Me.tabParticular.TabIndex = 1
        Me.tabParticular.Text = "Particular Entries"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(923, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFind, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.cmdDelete})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(923, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdFind
        '
        Me.cmdFind.ForeColor = System.Drawing.Color.White
        Me.cmdFind.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(130, 24)
        Me.cmdFind.Text = "Find Particular Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Orange
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.receipt__plus
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(202, 24)
        Me.ToolStripButton1.Text = "If the product not exist, click here"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdDelete
        '
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = Global.CoffeecupClient.My.Resources.Resources.application_form_delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(107, 24)
        Me.cmdDelete.Text = "Delete Selected"
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(832, 298)
        Me.MyDataGridView.TabIndex = 342
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditItemToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(169, 76)
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditItemToolStripMenuItem.Text = "Edit Selected Item"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(165, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(168, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'reqid
        '
        Me.reqid.Enabled = False
        Me.reqid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.reqid.ForeColor = System.Drawing.Color.Black
        Me.reqid.Location = New System.Drawing.Point(107, 434)
        Me.reqid.Margin = New System.Windows.Forms.Padding(4)
        Me.reqid.Name = "reqid"
        Me.reqid.ReadOnly = True
        Me.reqid.Size = New System.Drawing.Size(88, 23)
        Me.reqid.TabIndex = 270
        Me.reqid.Visible = False
        '
        'My_BgWorker
        '
        Me.My_BgWorker.WorkerReportsProgress = True
        Me.My_BgWorker.WorkerSupportsCancellation = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(403, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 30)
        Me.Button1.TabIndex = 337
        Me.Button1.Text = "Save as Draft"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.Paper_pencil
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(16, 6)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(44, 43)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 388
        Me.Label7.Text = "Date Needed"
        '
        'txtDateNeeded
        '
        Me.txtDateNeeded.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateNeeded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateNeeded.Location = New System.Drawing.Point(117, 180)
        Me.txtDateNeeded.Name = "txtDateNeeded"
        Me.txtDateNeeded.Size = New System.Drawing.Size(168, 22)
        Me.txtDateNeeded.TabIndex = 387
        '
        'frmRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(866, 458)
        Me.Controls.Add(Me.allocatedid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.Stop_Button)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.potypeid)
        Me.Controls.Add(Me.reqid)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(882, 497)
        Me.Name = "frmRequisition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Information"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.tabRequest.ResumeLayout(False)
        Me.tabRequest.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents potypeid As System.Windows.Forms.TextBox
    Friend WithEvents Stop_Button As System.Windows.Forms.Button
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRequest As System.Windows.Forms.TabPage
    Friend WithEvents reqid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblunderchapter As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseType As System.Windows.Forms.ComboBox
    Friend WithEvents txtrequester As System.Windows.Forms.ComboBox
    Friend WithEvents lblcontactperson As System.Windows.Forms.Label
    Friend WithEvents txtPriority As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtattached1 As System.Windows.Forms.TextBox
    Friend WithEvents ckQuotation As System.Windows.Forms.CheckBox
    Friend WithEvents cmda1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRequestJustification As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApprovingLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents My_BgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtlink As System.Windows.Forms.LinkLabel
    Friend WithEvents pid As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSelectOffice As System.Windows.Forms.ComboBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents allocatedid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDateNeeded As DateTimePicker
End Class
