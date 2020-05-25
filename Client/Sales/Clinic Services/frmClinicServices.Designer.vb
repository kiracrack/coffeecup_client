<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClinicServices))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MustaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdStatement = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.ck_Landscape = New System.Windows.Forms.CheckBox()
        Me.ck_legall = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdScheduleReminder = New System.Windows.Forms.ToolStripButton()
        Me.lineScheduleReminder = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtClinic = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNewCheckinGuest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPending = New System.Windows.Forms.TabPage()
        Me.clinicid = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.tabClosed = New System.Windows.Forms.TabPage()
        Me.tabCancelled = New System.Windows.Forms.TabPage()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPending.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'HiToolStripMenuItem
        '
        Me.HiToolStripMenuItem.Name = "HiToolStripMenuItem"
        Me.HiToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HiToolStripMenuItem.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HelloToolStripMenuItem.Text = "View Remarks"
        '
        'MustaToolStripMenuItem
        '
        Me.MustaToolStripMenuItem.Name = "MustaToolStripMenuItem"
        Me.MustaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MustaToolStripMenuItem.Text = "Edit "
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.Size = New System.Drawing.Size(1143, 571)
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(878, 69)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(260, 23)
        Me.txtsearch.TabIndex = 276
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(832, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 277
        Me.Label3.Text = "Search"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSelectedToolStripMenuItem, Me.cmdStatement, Me.ViewStatementToolStripMenuItem, Me.cmdCancel, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(205, 120)
        '
        'EditSelectedToolStripMenuItem
        '
        Me.EditSelectedToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
        Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.EditSelectedToolStripMenuItem.Text = "Edit Package"
        '
        'cmdStatement
        '
        Me.cmdStatement.Image = Global.CoffeecupClient.My.Resources.Resources.calendar_blue
        Me.cmdStatement.Name = "cmdStatement"
        Me.cmdStatement.Size = New System.Drawing.Size(204, 22)
        Me.cmdStatement.Text = "Package Schedule"
        '
        'ViewStatementToolStripMenuItem
        '
        Me.ViewStatementToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_next
        Me.ViewStatementToolStripMenuItem.Name = "ViewStatementToolStripMenuItem"
        Me.ViewStatementToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ViewStatementToolStripMenuItem.Text = "View Package Statement"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(204, 22)
        Me.cmdCancel.Text = "Cancel Selected Package"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(201, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(204, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Location = New System.Drawing.Point(96, 430)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(100, 23)
        Me.mode.TabIndex = 291
        Me.mode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdlogin)
        Me.GroupBox1.Controls.Add(Me.ckasof)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtfrmdate)
        Me.GroupBox1.Controls.Add(Me.ck_Landscape)
        Me.GroupBox1.Controls.Add(Me.ck_legall)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1142, 103)
        Me.GroupBox1.TabIndex = 342
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters and Printing Setup"
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(435, 48)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 296
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'ckasof
        '
        Me.ckasof.AutoSize = True
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(110, 75)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(129, 19)
        Me.ckasof.TabIndex = 295
        Me.ckasof.Text = "Use as of Date Filter"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(283, 49)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 23)
        Me.txttodate.TabIndex = 293
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 292
        Me.Label1.Text = "Date Filter From"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(110, 49)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 23)
        Me.txtfrmdate.TabIndex = 291
        '
        'ck_Landscape
        '
        Me.ck_Landscape.AutoSize = True
        Me.ck_Landscape.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ck_Landscape.ForeColor = System.Drawing.Color.Black
        Me.ck_Landscape.Location = New System.Drawing.Point(283, 24)
        Me.ck_Landscape.Name = "ck_Landscape"
        Me.ck_Landscape.Size = New System.Drawing.Size(110, 19)
        Me.ck_Landscape.TabIndex = 290
        Me.ck_Landscape.Text = "Print Landscape"
        Me.ck_Landscape.UseVisualStyleBackColor = True
        '
        'ck_legall
        '
        Me.ck_legall.AutoSize = True
        Me.ck_legall.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ck_legall.ForeColor = System.Drawing.Color.Black
        Me.ck_legall.Location = New System.Drawing.Point(110, 25)
        Me.ck_legall.Name = "ck_legall"
        Me.ck_legall.Size = New System.Drawing.Size(138, 19)
        Me.ck_legall.TabIndex = 289
        Me.ck_legall.Text = "Print Paper Size Legal"
        Me.ck_legall.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "Printing Setup"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(262, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 294
        Me.Label4.Text = "To"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1142, 30)
        Me.Panel2.TabIndex = 311
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdScheduleReminder, Me.lineScheduleReminder, Me.ToolStripLabel1, Me.txtClinic, Me.ToolStripSeparator1, Me.cmdNewCheckinGuest, Me.ToolStripSeparator7, Me.cmdPrint, Me.ToolStripSeparator3, Me.cmdClose})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1142, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdScheduleReminder
        '
        Me.cmdScheduleReminder.ForeColor = System.Drawing.Color.White
        Me.cmdScheduleReminder.Image = Global.CoffeecupClient.My.Resources.Resources.Time_Hot
        Me.cmdScheduleReminder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdScheduleReminder.Name = "cmdScheduleReminder"
        Me.cmdScheduleReminder.Size = New System.Drawing.Size(129, 24)
        Me.cmdScheduleReminder.Text = "Schedule Reminder"
        '
        'lineScheduleReminder
        '
        Me.lineScheduleReminder.Name = "lineScheduleReminder"
        Me.lineScheduleReminder.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(41, 24)
        Me.ToolStripLabel1.Text = "Select "
        '
        'txtClinic
        '
        Me.txtClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClinic.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.txtClinic.Name = "txtClinic"
        Me.txtClinic.Size = New System.Drawing.Size(221, 27)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cmdNewCheckinGuest
        '
        Me.cmdNewCheckinGuest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCheckinGuest.ForeColor = System.Drawing.Color.White
        Me.cmdNewCheckinGuest.Image = Global.CoffeecupClient.My.Resources.Resources.user__plus1
        Me.cmdNewCheckinGuest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewCheckinGuest.Name = "cmdNewCheckinGuest"
        Me.cmdNewCheckinGuest.Size = New System.Drawing.Size(147, 24)
        Me.cmdNewCheckinGuest.Text = "New Package Service"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(90, 24)
        Me.cmdPrint.Text = "Print Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'cmdClose
        '
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.CoffeecupClient.My.Resources.Resources.slash
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 24)
        Me.cmdClose.Text = "Close Window"
        '
        'updates
        '
        Me.updates.BackColor = System.Drawing.Color.Transparent
        Me.updates.ForeColor = System.Drawing.Color.White
        Me.updates.Name = "updates"
        Me.updates.Size = New System.Drawing.Size(0, 24)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabPending)
        Me.TabControl1.Controls.Add(Me.tabClosed)
        Me.TabControl1.Controls.Add(Me.tabCancelled)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 146)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1142, 544)
        Me.TabControl1.TabIndex = 344
        '
        'tabPending
        '
        Me.tabPending.Controls.Add(Me.clinicid)
        Me.tabPending.Controls.Add(Me.MyDataGridView)
        Me.tabPending.Location = New System.Drawing.Point(4, 24)
        Me.tabPending.Name = "tabPending"
        Me.tabPending.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPending.Size = New System.Drawing.Size(1134, 516)
        Me.tabPending.TabIndex = 1
        Me.tabPending.Text = "Pending Services"
        Me.tabPending.UseVisualStyleBackColor = True
        '
        'clinicid
        '
        Me.clinicid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.clinicid.ForeColor = System.Drawing.Color.Black
        Me.clinicid.Location = New System.Drawing.Point(364, 70)
        Me.clinicid.Margin = New System.Windows.Forms.Padding(4)
        Me.clinicid.Name = "clinicid"
        Me.clinicid.ReadOnly = True
        Me.clinicid.Size = New System.Drawing.Size(49, 22)
        Me.clinicid.TabIndex = 1017
        Me.clinicid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clinicid.Visible = False
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(1128, 510)
        Me.MyDataGridView.TabIndex = 343
        '
        'tabClosed
        '
        Me.tabClosed.Location = New System.Drawing.Point(4, 24)
        Me.tabClosed.Name = "tabClosed"
        Me.tabClosed.Size = New System.Drawing.Size(1134, 516)
        Me.tabClosed.TabIndex = 3
        Me.tabClosed.Text = "Closed Services"
        Me.tabClosed.UseVisualStyleBackColor = True
        '
        'tabCancelled
        '
        Me.tabCancelled.Location = New System.Drawing.Point(4, 24)
        Me.tabCancelled.Name = "tabCancelled"
        Me.tabCancelled.Size = New System.Drawing.Size(1134, 516)
        Me.tabCancelled.TabIndex = 2
        Me.tabCancelled.Text = "Cancelled Services"
        Me.tabCancelled.UseVisualStyleBackColor = True
        '
        'frmClinicServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1166, 702)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(897, 679)
        Me.Name = "frmClinicServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spa & Services"
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPending.ResumeLayout(False)
        Me.tabPending.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MustaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    'Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents updates As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ck_Landscape As System.Windows.Forms.CheckBox
    Friend WithEvents ck_legall As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPending As System.Windows.Forms.TabPage
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents cmdNewCheckinGuest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdStatement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabClosed As System.Windows.Forms.TabPage
    Friend WithEvents tabCancelled As System.Windows.Forms.TabPage
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EditSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtClinic As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents clinicid As System.Windows.Forms.TextBox
    Friend WithEvents ViewStatementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdScheduleReminder As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineScheduleReminder As System.Windows.Forms.ToolStripSeparator
End Class
