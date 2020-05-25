<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelGroupStatement
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelGroupStatement))
        Me.txtAddress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdPayment = New System.Windows.Forms.ToolStripButton()
        Me.linePayment = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDiscount = New System.Windows.Forms.ToolStripButton()
        Me.lineDiscount = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChargetoAccount = New System.Windows.Forms.ToolStripButton()
        Me.lineChargetoAccount = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCheckout = New System.Windows.Forms.ToolStripButton()
        Me.lineCheckOut = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintStatement = New System.Windows.Forms.ToolStripButton()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewFolioStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.roomid = New System.Windows.Forms.TextBox()
        Me.checkoutdate = New System.Windows.Forms.TextBox()
        Me.txtTotalDebit = New System.Windows.Forms.TextBox()
        Me.txtTotalCredit = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtdateCheckout = New System.Windows.Forms.TextBox()
        Me.txtDateArival = New System.Windows.Forms.TextBox()
        Me.txtBookingno = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabStatement = New System.Windows.Forms.TabPage()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.tabGuestCompanion = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Companion = New System.Windows.Forms.DataGridView()
        Me.cmd_companion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.txtFlight = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.txtAgent = New System.Windows.Forms.TextBox()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabStatement.SuspendLayout()
        Me.tabGuestCompanion.SuspendLayout()
        CType(Me.MyDataGridView_Companion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd_companion.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Gray
        Me.txtAddress.Location = New System.Drawing.Point(52, 62)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(203, 15)
        Me.txtAddress.TabIndex = 334
        Me.txtAddress.Text = "Dipolog City, Zamboanga del Norte"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(12, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "________________________________________________________________________________" & _
    "____________________________"
        '
        'txtGuest
        '
        Me.txtGuest.AutoSize = True
        Me.txtGuest.BackColor = System.Drawing.Color.Transparent
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtGuest.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtGuest.Location = New System.Drawing.Point(52, 43)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(149, 19)
        Me.txtGuest.TabIndex = 333
        Me.txtGuest.Text = "WINTER S. BUGAHOD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(973, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPayment, Me.linePayment, Me.cmdDiscount, Me.lineDiscount, Me.cmdChargetoAccount, Me.lineChargetoAccount, Me.cmdCheckout, Me.lineCheckOut, Me.cmdPrintStatement})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(973, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdPayment
        '
        Me.cmdPayment.ForeColor = System.Drawing.Color.White
        Me.cmdPayment.Image = Global.CoffeecupClient.My.Resources.Resources.money__plus
        Me.cmdPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(100, 24)
        Me.cmdPayment.Text = "Post Payment"
        '
        'linePayment
        '
        Me.linePayment.Name = "linePayment"
        Me.linePayment.Size = New System.Drawing.Size(6, 27)
        '
        'cmdDiscount
        '
        Me.cmdDiscount.ForeColor = System.Drawing.Color.White
        Me.cmdDiscount.Image = Global.CoffeecupClient.My.Resources.Resources.tag__plus
        Me.cmdDiscount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(100, 24)
        Me.cmdDiscount.Text = "Post Discount"
        '
        'lineDiscount
        '
        Me.lineDiscount.Name = "lineDiscount"
        Me.lineDiscount.Size = New System.Drawing.Size(6, 27)
        '
        'cmdChargetoAccount
        '
        Me.cmdChargetoAccount.ForeColor = System.Drawing.Color.White
        Me.cmdChargetoAccount.Image = Global.CoffeecupClient.My.Resources.Resources.building__arrow
        Me.cmdChargetoAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChargetoAccount.Name = "cmdChargetoAccount"
        Me.cmdChargetoAccount.Size = New System.Drawing.Size(233, 24)
        Me.cmdChargetoAccount.Text = "Charge to Client Account && Check-out"
        '
        'lineChargetoAccount
        '
        Me.lineChargetoAccount.Name = "lineChargetoAccount"
        Me.lineChargetoAccount.Size = New System.Drawing.Size(6, 27)
        '
        'cmdCheckout
        '
        Me.cmdCheckout.ForeColor = System.Drawing.Color.White
        Me.cmdCheckout.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow1
        Me.cmdCheckout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCheckout.Name = "cmdCheckout"
        Me.cmdCheckout.Size = New System.Drawing.Size(116, 24)
        Me.cmdCheckout.Text = "Check-out Guest"
        '
        'lineCheckOut
        '
        Me.lineCheckOut.Name = "lineCheckOut"
        Me.lineCheckOut.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrintStatement
        '
        Me.cmdPrintStatement.ForeColor = System.Drawing.Color.White
        Me.cmdPrintStatement.Image = Global.CoffeecupClient.My.Resources.Resources.printer
        Me.cmdPrintStatement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintStatement.Name = "cmdPrintStatement"
        Me.cmdPrintStatement.Size = New System.Drawing.Size(109, 24)
        Me.cmdPrintStatement.Text = "Print Statement"
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
        Me.MyDataGridView.Size = New System.Drawing.Size(658, 376)
        Me.MyDataGridView.TabIndex = 342
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewFolioStatementToolStripMenuItem, Me.ToolStripSeparator2, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(211, 54)
        '
        'ViewFolioStatementToolStripMenuItem
        '
        Me.ViewFolioStatementToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_next
        Me.ViewFolioStatementToolStripMenuItem.Name = "ViewFolioStatementToolStripMenuItem"
        Me.ViewFolioStatementToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ViewFolioStatementToolStripMenuItem.Text = "View Sub-Folio Statement"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(207, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(210, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(388, 286)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(57, 23)
        Me.guestid.TabIndex = 461
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDate.Location = New System.Drawing.Point(706, 39)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(252, 15)
        Me.txtDate.TabIndex = 460
        Me.txtDate.Text = "December 13, 2015 4:00pm"
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'roomid
        '
        Me.roomid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomid.ForeColor = System.Drawing.Color.Black
        Me.roomid.Location = New System.Drawing.Point(455, 286)
        Me.roomid.Margin = New System.Windows.Forms.Padding(5)
        Me.roomid.Name = "roomid"
        Me.roomid.Size = New System.Drawing.Size(57, 23)
        Me.roomid.TabIndex = 463
        Me.roomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomid.Visible = False
        '
        'checkoutdate
        '
        Me.checkoutdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.checkoutdate.ForeColor = System.Drawing.Color.Black
        Me.checkoutdate.Location = New System.Drawing.Point(321, 286)
        Me.checkoutdate.Margin = New System.Windows.Forms.Padding(5)
        Me.checkoutdate.Name = "checkoutdate"
        Me.checkoutdate.Size = New System.Drawing.Size(57, 23)
        Me.checkoutdate.TabIndex = 508
        Me.checkoutdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.checkoutdate.Visible = False
        '
        'txtTotalDebit
        '
        Me.txtTotalDebit.BackColor = System.Drawing.Color.White
        Me.txtTotalDebit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalDebit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalDebit.Location = New System.Drawing.Point(122, 373)
        Me.txtTotalDebit.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalDebit.Name = "txtTotalDebit"
        Me.txtTotalDebit.ReadOnly = True
        Me.txtTotalDebit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTotalDebit.Size = New System.Drawing.Size(162, 23)
        Me.txtTotalDebit.TabIndex = 511
        Me.txtTotalDebit.Text = "0.00"
        Me.txtTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalDebit.WordWrap = False
        '
        'txtTotalCredit
        '
        Me.txtTotalCredit.BackColor = System.Drawing.Color.White
        Me.txtTotalCredit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalCredit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalCredit.Location = New System.Drawing.Point(122, 395)
        Me.txtTotalCredit.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalCredit.Name = "txtTotalCredit"
        Me.txtTotalCredit.ReadOnly = True
        Me.txtTotalCredit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTotalCredit.Size = New System.Drawing.Size(162, 23)
        Me.txtTotalCredit.TabIndex = 512
        Me.txtTotalCredit.Text = "0.00"
        Me.txtTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCredit.WordWrap = False
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBalance.Location = New System.Drawing.Point(122, 417)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBalance.Size = New System.Drawing.Size(162, 23)
        Me.txtBalance.TabIndex = 513
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBalance.WordWrap = False
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.BackColor = System.Drawing.Color.White
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdateCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdateCheckout.Location = New System.Drawing.Point(122, 268)
        Me.txtdateCheckout.Margin = New System.Windows.Forms.Padding(5)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.ReadOnly = True
        Me.txtdateCheckout.Size = New System.Drawing.Size(162, 23)
        Me.txtdateCheckout.TabIndex = 516
        '
        'txtDateArival
        '
        Me.txtDateArival.BackColor = System.Drawing.Color.White
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateArival.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDateArival.Location = New System.Drawing.Point(122, 246)
        Me.txtDateArival.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.ReadOnly = True
        Me.txtDateArival.Size = New System.Drawing.Size(162, 23)
        Me.txtDateArival.TabIndex = 515
        '
        'txtBookingno
        '
        Me.txtBookingno.BackColor = System.Drawing.Color.White
        Me.txtBookingno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBookingno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBookingno.Location = New System.Drawing.Point(122, 92)
        Me.txtBookingno.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBookingno.Name = "txtBookingno"
        Me.txtBookingno.ReadOnly = True
        Me.txtBookingno.Size = New System.Drawing.Size(162, 23)
        Me.txtBookingno.TabIndex = 514
        Me.txtBookingno.Text = "XD32223"
        Me.txtBookingno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(14, 373)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(109, 23)
        Me.TextBox1.TabIndex = 517
        Me.TextBox1.Text = "Balance Due"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.WordWrap = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox2.Location = New System.Drawing.Point(14, 395)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(109, 23)
        Me.TextBox2.TabIndex = 518
        Me.TextBox2.Text = "Total Payment"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox2.WordWrap = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox3.Location = New System.Drawing.Point(14, 417)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(109, 23)
        Me.TextBox3.TabIndex = 519
        Me.TextBox3.Text = "Current Balance"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox3.WordWrap = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox4.Location = New System.Drawing.Point(14, 268)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(109, 23)
        Me.TextBox4.TabIndex = 522
        Me.TextBox4.Text = "Date Departure"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox4.WordWrap = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox5.Location = New System.Drawing.Point(14, 246)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(109, 23)
        Me.TextBox5.TabIndex = 521
        Me.TextBox5.Text = "Date Arival"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox5.WordWrap = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox6.Location = New System.Drawing.Point(14, 92)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(109, 23)
        Me.TextBox6.TabIndex = 520
        Me.TextBox6.Text = "Main Folio No."
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox6.WordWrap = False
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.Color.White
        Me.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCountry.Location = New System.Drawing.Point(122, 114)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(162, 23)
        Me.txtCountry.TabIndex = 825
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.White
        Me.txtGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGender.Location = New System.Drawing.Point(122, 158)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(162, 23)
        Me.txtGender.TabIndex = 824
        '
        'txtNationality
        '
        Me.txtNationality.BackColor = System.Drawing.Color.White
        Me.txtNationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNationality.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNationality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNationality.Location = New System.Drawing.Point(122, 180)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.ReadOnly = True
        Me.txtNationality.Size = New System.Drawing.Size(162, 23)
        Me.txtNationality.TabIndex = 823
        '
        'txtBirthdate
        '
        Me.txtBirthdate.BackColor = System.Drawing.Color.White
        Me.txtBirthdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBirthdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirthdate.Location = New System.Drawing.Point(122, 136)
        Me.txtBirthdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.ReadOnly = True
        Me.txtBirthdate.Size = New System.Drawing.Size(162, 23)
        Me.txtBirthdate.TabIndex = 822
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(122, 224)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(162, 23)
        Me.txtEmail.TabIndex = 821
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.White
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContactNumber.Location = New System.Drawing.Point(122, 202)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(162, 23)
        Me.txtContactNumber.TabIndex = 820
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(14, 202)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(109, 23)
        Me.TextBox7.TabIndex = 820
        Me.TextBox7.Text = "Contact Number"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.Location = New System.Drawing.Point(14, 224)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(109, 23)
        Me.TextBox8.TabIndex = 821
        Me.TextBox8.Text = "Email"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox9.Location = New System.Drawing.Point(14, 136)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(109, 23)
        Me.TextBox9.TabIndex = 822
        Me.TextBox9.Text = "Birth Date"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox10.Location = New System.Drawing.Point(14, 180)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(109, 23)
        Me.TextBox10.TabIndex = 823
        Me.TextBox10.Text = "Nationality"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox11.Location = New System.Drawing.Point(14, 158)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(109, 23)
        Me.TextBox11.TabIndex = 824
        Me.TextBox11.Text = "Gender"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox12.Location = New System.Drawing.Point(14, 114)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(109, 23)
        Me.TextBox12.TabIndex = 825
        Me.TextBox12.Text = "Country"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabStatement)
        Me.TabControl1.Controls.Add(Me.tabGuestCompanion)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(292, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(672, 410)
        Me.TabControl1.TabIndex = 826
        '
        'tabStatement
        '
        Me.tabStatement.Controls.Add(Me.mode)
        Me.tabStatement.Controls.Add(Me.MyDataGridView)
        Me.tabStatement.Location = New System.Drawing.Point(4, 24)
        Me.tabStatement.Name = "tabStatement"
        Me.tabStatement.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStatement.Size = New System.Drawing.Size(664, 382)
        Me.tabStatement.TabIndex = 0
        Me.tabStatement.Text = "Statement of Account"
        Me.tabStatement.UseVisualStyleBackColor = True
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(304, 180)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(57, 23)
        Me.mode.TabIndex = 464
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'tabGuestCompanion
        '
        Me.tabGuestCompanion.Controls.Add(Me.MyDataGridView_Companion)
        Me.tabGuestCompanion.Location = New System.Drawing.Point(4, 24)
        Me.tabGuestCompanion.Name = "tabGuestCompanion"
        Me.tabGuestCompanion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGuestCompanion.Size = New System.Drawing.Size(664, 382)
        Me.tabGuestCompanion.TabIndex = 1
        Me.tabGuestCompanion.Text = "Guest Companion"
        Me.tabGuestCompanion.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Companion
        '
        Me.MyDataGridView_Companion.AllowUserToAddRows = False
        Me.MyDataGridView_Companion.AllowUserToDeleteRows = False
        Me.MyDataGridView_Companion.AllowUserToResizeColumns = False
        Me.MyDataGridView_Companion.AllowUserToResizeRows = False
        Me.MyDataGridView_Companion.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Companion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Companion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Companion.ContextMenuStrip = Me.cmd_companion
        Me.MyDataGridView_Companion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Companion.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Companion.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Companion.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Companion.Name = "MyDataGridView_Companion"
        Me.MyDataGridView_Companion.ReadOnly = True
        Me.MyDataGridView_Companion.RowHeadersVisible = False
        Me.MyDataGridView_Companion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Companion.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView_Companion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Companion.Size = New System.Drawing.Size(658, 376)
        Me.MyDataGridView_Companion.TabIndex = 343
        '
        'cmd_companion
        '
        Me.cmd_companion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddCompanion, Me.cmdEditCompanion, Me.cmdRemoveCompanion, Me.ToolStripSeparator3, Me.cmdRefreshCompanion})
        Me.cmd_companion.Name = "ContextMenuStrip1"
        Me.cmd_companion.Size = New System.Drawing.Size(165, 98)
        '
        'cmdAddCompanion
        '
        Me.cmdAddCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddCompanion.Name = "cmdAddCompanion"
        Me.cmdAddCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdAddCompanion.Text = "Add New"
        '
        'cmdEditCompanion
        '
        Me.cmdEditCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditCompanion.Name = "cmdEditCompanion"
        Me.cmdEditCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdEditCompanion.Text = "Edit Selected"
        '
        'cmdRemoveCompanion
        '
        Me.cmdRemoveCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveCompanion.Name = "cmdRemoveCompanion"
        Me.cmdRemoveCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdRemoveCompanion.Text = "Remove Selected"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'cmdRefreshCompanion
        '
        Me.cmdRefreshCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshCompanion.Name = "cmdRefreshCompanion"
        Me.cmdRefreshCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdRefreshCompanion.Tag = "1"
        Me.cmdRefreshCompanion.Text = "Refresh Data"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox13.Location = New System.Drawing.Point(14, 312)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox13.Size = New System.Drawing.Size(109, 23)
        Me.TextBox13.TabIndex = 830
        Me.TextBox13.Text = "Remarks"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox13.WordWrap = False
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox14.Location = New System.Drawing.Point(14, 290)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox14.Size = New System.Drawing.Size(109, 23)
        Me.TextBox14.TabIndex = 829
        Me.TextBox14.Text = "Flight"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox14.WordWrap = False
        '
        'txtFlight
        '
        Me.txtFlight.BackColor = System.Drawing.Color.White
        Me.txtFlight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFlight.Location = New System.Drawing.Point(122, 290)
        Me.txtFlight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFlight.Name = "txtFlight"
        Me.txtFlight.ReadOnly = True
        Me.txtFlight.Size = New System.Drawing.Size(162, 23)
        Me.txtFlight.TabIndex = 827
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRemarks.Location = New System.Drawing.Point(122, 312)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(162, 23)
        Me.txtRemarks.TabIndex = 828
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox17.Location = New System.Drawing.Point(14, 334)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox17.Size = New System.Drawing.Size(109, 23)
        Me.TextBox17.TabIndex = 832
        Me.TextBox17.Text = "Agent"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox17.WordWrap = False
        '
        'txtAgent
        '
        Me.txtAgent.BackColor = System.Drawing.Color.White
        Me.txtAgent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAgent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAgent.Location = New System.Drawing.Point(122, 334)
        Me.txtAgent.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAgent.Name = "txtAgent"
        Me.txtAgent.ReadOnly = True
        Me.txtAgent.Size = New System.Drawing.Size(162, 23)
        Me.txtAgent.TabIndex = 831
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.UserGroup_32x32__2_
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(12, 43)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(35, 33)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'frmHotelGroupStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(973, 451)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.txtAgent)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.txtFlight)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtTotalCredit)
        Me.Controls.Add(Me.txtTotalDebit)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.checkoutdate)
        Me.Controls.Add(Me.roomid)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBookingno)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelGroupStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statement of Account (Master Folio)"
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabStatement.ResumeLayout(False)
        Me.tabStatement.PerformLayout()
        Me.tabGuestCompanion.ResumeLayout(False)
        CType(Me.MyDataGridView_Companion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd_companion.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents txtAddress As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdCheckout As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineDiscount As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDiscount As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtGuest As System.Windows.Forms.Label
    Friend WithEvents lineCheckOut As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintStatement As System.Windows.Forms.ToolStripButton
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents roomid As System.Windows.Forms.TextBox
    Friend WithEvents cmdChargetoAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineChargetoAccount As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents checkoutdate As System.Windows.Forms.TextBox
    Friend WithEvents cmdPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents linePayment As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewFolioStatementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTotalDebit As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtdateCheckout As System.Windows.Forms.TextBox
    Friend WithEvents txtDateArival As System.Windows.Forms.TextBox
    Friend WithEvents txtBookingno As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthdate As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabStatement As System.Windows.Forms.TabPage
    Friend WithEvents tabGuestCompanion As System.Windows.Forms.TabPage
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents txtFlight As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents MyDataGridView_Companion As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_companion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mode As System.Windows.Forms.TextBox
End Class
