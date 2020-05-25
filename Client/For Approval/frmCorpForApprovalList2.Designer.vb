<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorpForApprovalList2
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorpForApprovalList2))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.MyDataGridView_Requisitions = New System.Windows.Forms.DataGridView()
        Me.Tabcontrol1 = New System.Windows.Forms.TabControl()
        Me.tabHotelDiscount = New System.Windows.Forms.TabPage()
        Me.DataGridView_hoteldiscount = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDisapproved = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabDiscount = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Discounts = New System.Windows.Forms.DataGridView()
        Me.tabRequisitions = New System.Windows.Forms.TabPage()
        Me.tabPurchaseOrder = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_PurchaseOrder = New System.Windows.Forms.DataGridView()
        Me.tabAccountsPayable = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_AccountsPayable = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabFFEforDisposal = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_FFE = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdHotel = New System.Windows.Forms.ToolStripButton()
        Me.lineHotel = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalesDiscount = New System.Windows.Forms.ToolStripButton()
        Me.lineSales = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRequisition = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPurchaseOrder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPaymentRequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdFFEDisposal = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGridView_Requisitions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabcontrol1.SuspendLayout()
        Me.tabHotelDiscount.SuspendLayout()
        CType(Me.DataGridView_hoteldiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.tabDiscount.SuspendLayout()
        CType(Me.MyDataGridView_Discounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRequisitions.SuspendLayout()
        Me.tabPurchaseOrder.SuspendLayout()
        CType(Me.MyDataGridView_PurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAccountsPayable.SuspendLayout()
        CType(Me.MyDataGridView_AccountsPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tabFFEforDisposal.SuspendLayout()
        CType(Me.MyDataGridView_FFE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(56, 40)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(446, 22)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to approve or disapprove request"
        Me.lbldescription.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(510, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "______________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(54, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(184, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "List of for Approval Request"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtfilter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.picicon)
        Me.GroupBox1.Controls.Add(Me.lbltitle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbldescription)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 105)
        Me.GroupBox1.TabIndex = 337
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "For Approval List"
        '
        'txtfilter
        '
        Me.txtfilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfilter.Location = New System.Drawing.Point(106, 76)
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(411, 23)
        Me.txtfilter.TabIndex = 337
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Search Keyworks"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.List
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 19)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(40, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'MyDataGridView_Requisitions
        '
        Me.MyDataGridView_Requisitions.AllowUserToAddRows = False
        Me.MyDataGridView_Requisitions.AllowUserToDeleteRows = False
        Me.MyDataGridView_Requisitions.AllowUserToResizeColumns = False
        Me.MyDataGridView_Requisitions.AllowUserToResizeRows = False
        Me.MyDataGridView_Requisitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Requisitions.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Requisitions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Requisitions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Requisitions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Requisitions.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Requisitions.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView_Requisitions.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Requisitions.MultiSelect = False
        Me.MyDataGridView_Requisitions.Name = "MyDataGridView_Requisitions"
        Me.MyDataGridView_Requisitions.ReadOnly = True
        Me.MyDataGridView_Requisitions.RowHeadersVisible = False
        Me.MyDataGridView_Requisitions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Requisitions.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Requisitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Requisitions.Size = New System.Drawing.Size(904, 330)
        Me.MyDataGridView_Requisitions.TabIndex = 342
        '
        'Tabcontrol1
        '
        Me.Tabcontrol1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabcontrol1.Controls.Add(Me.tabHotelDiscount)
        Me.Tabcontrol1.Controls.Add(Me.tabDiscount)
        Me.Tabcontrol1.Controls.Add(Me.tabRequisitions)
        Me.Tabcontrol1.Controls.Add(Me.tabPurchaseOrder)
        Me.Tabcontrol1.Controls.Add(Me.tabAccountsPayable)
        Me.Tabcontrol1.Controls.Add(Me.tabFFEforDisposal)
        Me.Tabcontrol1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Tabcontrol1.Location = New System.Drawing.Point(7, 121)
        Me.Tabcontrol1.Multiline = True
        Me.Tabcontrol1.Name = "Tabcontrol1"
        Me.Tabcontrol1.SelectedIndex = 0
        Me.Tabcontrol1.ShowToolTips = True
        Me.Tabcontrol1.Size = New System.Drawing.Size(912, 358)
        Me.Tabcontrol1.TabIndex = 343
        '
        'tabHotelDiscount
        '
        Me.tabHotelDiscount.Controls.Add(Me.DataGridView_hoteldiscount)
        Me.tabHotelDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabHotelDiscount.Location = New System.Drawing.Point(4, 24)
        Me.tabHotelDiscount.Name = "tabHotelDiscount"
        Me.tabHotelDiscount.Size = New System.Drawing.Size(904, 330)
        Me.tabHotelDiscount.TabIndex = 6
        Me.tabHotelDiscount.Text = "Hotel Discount"
        Me.tabHotelDiscount.UseVisualStyleBackColor = True
        '
        'DataGridView_hoteldiscount
        '
        Me.DataGridView_hoteldiscount.AllowUserToAddRows = False
        Me.DataGridView_hoteldiscount.AllowUserToDeleteRows = False
        Me.DataGridView_hoteldiscount.AllowUserToResizeColumns = False
        Me.DataGridView_hoteldiscount.AllowUserToResizeRows = False
        Me.DataGridView_hoteldiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView_hoteldiscount.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_hoteldiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView_hoteldiscount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView_hoteldiscount.ContextMenuStrip = Me.cms_em
        Me.DataGridView_hoteldiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_hoteldiscount.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView_hoteldiscount.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_hoteldiscount.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView_hoteldiscount.Name = "DataGridView_hoteldiscount"
        Me.DataGridView_hoteldiscount.ReadOnly = True
        Me.DataGridView_hoteldiscount.RowHeadersVisible = False
        Me.DataGridView_hoteldiscount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView_hoteldiscount.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_hoteldiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_hoteldiscount.Size = New System.Drawing.Size(904, 330)
        Me.DataGridView_hoteldiscount.TabIndex = 345
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData, Me.cmdDisapproved, Me.RefreshToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(170, 70)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(169, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Override Discount"
        '
        'cmdDisapproved
        '
        Me.cmdDisapproved.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdDisapproved.Name = "cmdDisapproved"
        Me.cmdDisapproved.Size = New System.Drawing.Size(169, 22)
        Me.cmdDisapproved.Text = "Disapprove"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'tabDiscount
        '
        Me.tabDiscount.Controls.Add(Me.MyDataGridView_Discounts)
        Me.tabDiscount.Location = New System.Drawing.Point(4, 24)
        Me.tabDiscount.Name = "tabDiscount"
        Me.tabDiscount.Size = New System.Drawing.Size(904, 330)
        Me.tabDiscount.TabIndex = 4
        Me.tabDiscount.Text = "Sales Discounts"
        Me.tabDiscount.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Discounts
        '
        Me.MyDataGridView_Discounts.AllowUserToAddRows = False
        Me.MyDataGridView_Discounts.AllowUserToDeleteRows = False
        Me.MyDataGridView_Discounts.AllowUserToResizeColumns = False
        Me.MyDataGridView_Discounts.AllowUserToResizeRows = False
        Me.MyDataGridView_Discounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Discounts.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Discounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Discounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Discounts.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Discounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Discounts.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Discounts.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView_Discounts.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Discounts.Name = "MyDataGridView_Discounts"
        Me.MyDataGridView_Discounts.ReadOnly = True
        Me.MyDataGridView_Discounts.RowHeadersVisible = False
        Me.MyDataGridView_Discounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Discounts.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView_Discounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Discounts.Size = New System.Drawing.Size(904, 330)
        Me.MyDataGridView_Discounts.TabIndex = 344
        '
        'tabRequisitions
        '
        Me.tabRequisitions.Controls.Add(Me.MyDataGridView_Requisitions)
        Me.tabRequisitions.Location = New System.Drawing.Point(4, 24)
        Me.tabRequisitions.Name = "tabRequisitions"
        Me.tabRequisitions.Size = New System.Drawing.Size(904, 330)
        Me.tabRequisitions.TabIndex = 0
        Me.tabRequisitions.Text = "For Approval Requisition"
        Me.tabRequisitions.UseVisualStyleBackColor = True
        '
        'tabPurchaseOrder
        '
        Me.tabPurchaseOrder.Controls.Add(Me.MyDataGridView_PurchaseOrder)
        Me.tabPurchaseOrder.Location = New System.Drawing.Point(4, 24)
        Me.tabPurchaseOrder.Name = "tabPurchaseOrder"
        Me.tabPurchaseOrder.Size = New System.Drawing.Size(904, 330)
        Me.tabPurchaseOrder.TabIndex = 2
        Me.tabPurchaseOrder.Text = "Purchase Order Request"
        Me.tabPurchaseOrder.UseVisualStyleBackColor = True
        '
        'MyDataGridView_PurchaseOrder
        '
        Me.MyDataGridView_PurchaseOrder.AllowUserToAddRows = False
        Me.MyDataGridView_PurchaseOrder.AllowUserToDeleteRows = False
        Me.MyDataGridView_PurchaseOrder.AllowUserToResizeColumns = False
        Me.MyDataGridView_PurchaseOrder.AllowUserToResizeRows = False
        Me.MyDataGridView_PurchaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_PurchaseOrder.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_PurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_PurchaseOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_PurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_PurchaseOrder.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_PurchaseOrder.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView_PurchaseOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_PurchaseOrder.MultiSelect = False
        Me.MyDataGridView_PurchaseOrder.Name = "MyDataGridView_PurchaseOrder"
        Me.MyDataGridView_PurchaseOrder.ReadOnly = True
        Me.MyDataGridView_PurchaseOrder.RowHeadersVisible = False
        Me.MyDataGridView_PurchaseOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_PurchaseOrder.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MyDataGridView_PurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_PurchaseOrder.Size = New System.Drawing.Size(904, 330)
        Me.MyDataGridView_PurchaseOrder.TabIndex = 343
        '
        'tabAccountsPayable
        '
        Me.tabAccountsPayable.Controls.Add(Me.MyDataGridView_AccountsPayable)
        Me.tabAccountsPayable.Location = New System.Drawing.Point(4, 24)
        Me.tabAccountsPayable.Name = "tabAccountsPayable"
        Me.tabAccountsPayable.Size = New System.Drawing.Size(904, 330)
        Me.tabAccountsPayable.TabIndex = 3
        Me.tabAccountsPayable.Text = "Request for Payment (AP)"
        Me.tabAccountsPayable.UseVisualStyleBackColor = True
        '
        'MyDataGridView_AccountsPayable
        '
        Me.MyDataGridView_AccountsPayable.AllowUserToAddRows = False
        Me.MyDataGridView_AccountsPayable.AllowUserToDeleteRows = False
        Me.MyDataGridView_AccountsPayable.AllowUserToResizeColumns = False
        Me.MyDataGridView_AccountsPayable.AllowUserToResizeRows = False
        Me.MyDataGridView_AccountsPayable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_AccountsPayable.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_AccountsPayable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_AccountsPayable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_AccountsPayable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_AccountsPayable.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_AccountsPayable.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView_AccountsPayable.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_AccountsPayable.MultiSelect = False
        Me.MyDataGridView_AccountsPayable.Name = "MyDataGridView_AccountsPayable"
        Me.MyDataGridView_AccountsPayable.ReadOnly = True
        Me.MyDataGridView_AccountsPayable.RowHeadersVisible = False
        Me.MyDataGridView_AccountsPayable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_AccountsPayable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MyDataGridView_AccountsPayable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_AccountsPayable.Size = New System.Drawing.Size(904, 330)
        Me.MyDataGridView_AccountsPayable.TabIndex = 344
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdViewProfile, Me.ToolStripSeparator4, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(167, 22)
        Me.cmdEdit.Text = "Confirm Request"
        '
        'cmdViewProfile
        '
        Me.cmdViewProfile.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list
        Me.cmdViewProfile.Name = "cmdViewProfile"
        Me.cmdViewProfile.Size = New System.Drawing.Size(167, 22)
        Me.cmdViewProfile.Text = "View Asset Profile"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(164, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem1.Tag = "1"
        Me.ToolStripMenuItem1.Text = "Refresh Data"
        '
        'tabFFEforDisposal
        '
        Me.tabFFEforDisposal.Controls.Add(Me.MyDataGridView_FFE)
        Me.tabFFEforDisposal.Location = New System.Drawing.Point(4, 24)
        Me.tabFFEforDisposal.Name = "tabFFEforDisposal"
        Me.tabFFEforDisposal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFFEforDisposal.Size = New System.Drawing.Size(904, 330)
        Me.tabFFEforDisposal.TabIndex = 5
        Me.tabFFEforDisposal.Text = "FFE for Disposal"
        Me.tabFFEforDisposal.UseVisualStyleBackColor = True
        '
        'MyDataGridView_FFE
        '
        Me.MyDataGridView_FFE.AllowUserToAddRows = False
        Me.MyDataGridView_FFE.AllowUserToDeleteRows = False
        Me.MyDataGridView_FFE.AllowUserToResizeColumns = False
        Me.MyDataGridView_FFE.AllowUserToResizeRows = False
        Me.MyDataGridView_FFE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_FFE.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_FFE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_FFE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_FFE.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MyDataGridView_FFE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_FFE.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_FFE.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_FFE.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_FFE.MultiSelect = False
        Me.MyDataGridView_FFE.Name = "MyDataGridView_FFE"
        Me.MyDataGridView_FFE.ReadOnly = True
        Me.MyDataGridView_FFE.RowHeadersVisible = False
        Me.MyDataGridView_FFE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_FFE.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.MyDataGridView_FFE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_FFE.Size = New System.Drawing.Size(898, 324)
        Me.MyDataGridView_FFE.TabIndex = 346
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHotel, Me.lineHotel, Me.cmdSalesDiscount, Me.lineSales, Me.cmdRequisition, Me.ToolStripSeparator1, Me.cmdPurchaseOrder, Me.ToolStripSeparator3, Me.cmdPaymentRequest, Me.ToolStripSeparator7, Me.cmdFFEDisposal})
        Me.ToolStrip3.Location = New System.Drawing.Point(8, 113)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(911, 32)
        Me.ToolStrip3.TabIndex = 344
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdHotel
        '
        Me.cmdHotel.ForeColor = System.Drawing.Color.White
        Me.cmdHotel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHotel.Name = "cmdHotel"
        Me.cmdHotel.Size = New System.Drawing.Size(90, 25)
        Me.cmdHotel.Text = "Hotel Discount"
        '
        'lineHotel
        '
        Me.lineHotel.Name = "lineHotel"
        Me.lineHotel.Size = New System.Drawing.Size(6, 28)
        '
        'cmdSalesDiscount
        '
        Me.cmdSalesDiscount.ForeColor = System.Drawing.Color.White
        Me.cmdSalesDiscount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalesDiscount.Name = "cmdSalesDiscount"
        Me.cmdSalesDiscount.Size = New System.Drawing.Size(87, 25)
        Me.cmdSalesDiscount.Text = "Sales Discount"
        '
        'lineSales
        '
        Me.lineSales.Name = "lineSales"
        Me.lineSales.Size = New System.Drawing.Size(6, 28)
        '
        'cmdRequisition
        '
        Me.cmdRequisition.ForeColor = System.Drawing.Color.White
        Me.cmdRequisition.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRequisition.Name = "cmdRequisition"
        Me.cmdRequisition.Size = New System.Drawing.Size(70, 25)
        Me.cmdRequisition.Text = "Requisition"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'cmdPurchaseOrder
        '
        Me.cmdPurchaseOrder.ForeColor = System.Drawing.Color.White
        Me.cmdPurchaseOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPurchaseOrder.Name = "cmdPurchaseOrder"
        Me.cmdPurchaseOrder.Size = New System.Drawing.Size(92, 25)
        Me.cmdPurchaseOrder.Text = "Purchase Order"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'cmdPaymentRequest
        '
        Me.cmdPaymentRequest.ForeColor = System.Drawing.Color.White
        Me.cmdPaymentRequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPaymentRequest.Name = "cmdPaymentRequest"
        Me.cmdPaymentRequest.Size = New System.Drawing.Size(130, 25)
        Me.cmdPaymentRequest.Text = "Disbursement Voucher"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 28)
        '
        'cmdFFEDisposal
        '
        Me.cmdFFEDisposal.ForeColor = System.Drawing.Color.White
        Me.cmdFFEDisposal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFFEDisposal.Name = "cmdFFEDisposal"
        Me.cmdFFEDisposal.Size = New System.Drawing.Size(76, 25)
        Me.cmdFFEDisposal.Text = "FFE Disposal"
        '
        'frmCorpForApprovalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(927, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Tabcontrol1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCorpForApprovalList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Approval Request (Corporate Level)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGridView_Requisitions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabcontrol1.ResumeLayout(False)
        Me.tabHotelDiscount.ResumeLayout(False)
        CType(Me.DataGridView_hoteldiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.tabDiscount.ResumeLayout(False)
        CType(Me.MyDataGridView_Discounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRequisitions.ResumeLayout(False)
        Me.tabPurchaseOrder.ResumeLayout(False)
        CType(Me.MyDataGridView_PurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAccountsPayable.ResumeLayout(False)
        CType(Me.MyDataGridView_AccountsPayable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tabFFEforDisposal.ResumeLayout(False)
        CType(Me.MyDataGridView_FFE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView_Requisitions As System.Windows.Forms.DataGridView
    Friend WithEvents Tabcontrol1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRequisitions As System.Windows.Forms.TabPage
    Friend WithEvents tabPurchaseOrder As System.Windows.Forms.TabPage
    Friend WithEvents tabAccountsPayable As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_PurchaseOrder As System.Windows.Forms.DataGridView
    Friend WithEvents MyDataGridView_AccountsPayable As System.Windows.Forms.DataGridView
    Friend WithEvents tabDiscount As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Discounts As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabFFEforDisposal As System.Windows.Forms.TabPage
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView_FFE As System.Windows.Forms.DataGridView
    Friend WithEvents tabHotelDiscount As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_hoteldiscount As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents lineHotel As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalesDiscount As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineSales As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRequisition As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdHotel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPurchaseOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPaymentRequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdFFEDisposal As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDisapproved As System.Windows.Forms.ToolStripMenuItem
End Class
