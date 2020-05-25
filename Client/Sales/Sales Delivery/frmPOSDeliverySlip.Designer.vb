<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSDeliverySlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSDeliverySlip))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabSeparator = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTransactionType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txttrnsumcode = New System.Windows.Forms.TextBox()
        Me.txtbatchcode = New System.Windows.Forms.TextBox()
        Me.txtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSearchCode = New System.Windows.Forms.TextBox()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewItemTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprintTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTraceTransactionDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHistoryBatchcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClientHistoryName = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CorrectTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabSeparator.SuspendLayout()
        Me.tabPost.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.tabHistory.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(509, 359)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 38)
        Me.cmdConfirm.TabIndex = 5
        Me.cmdConfirm.Text = "Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(287, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 400
        Me.Label2.Text = "Transaction Type"
        '
        'txtBranch
        '
        Me.txtBranch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBranch.DropDownHeight = 130
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtBranch.ForeColor = System.Drawing.Color.Black
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.IntegralHeight = False
        Me.txtBranch.ItemHeight = 15
        Me.txtBranch.Location = New System.Drawing.Point(388, 306)
        Me.txtBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBranch.MaxDropDownItems = 7
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(258, 23)
        Me.txtBranch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(296, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "Select Location"
        '
        'tabSeparator
        '
        Me.tabSeparator.Controls.Add(Me.tabPost)
        Me.tabSeparator.Controls.Add(Me.tabTransaction)
        Me.tabSeparator.Controls.Add(Me.tabHistory)
        Me.tabSeparator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSeparator.Location = New System.Drawing.Point(0, 0)
        Me.tabSeparator.Name = "tabSeparator"
        Me.tabSeparator.SelectedIndex = 0
        Me.tabSeparator.Size = New System.Drawing.Size(854, 437)
        Me.tabSeparator.TabIndex = 410
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.Label4)
        Me.tabPost.Controls.Add(Me.txtAddress)
        Me.tabPost.Controls.Add(Me.txtTransactionType)
        Me.tabPost.Controls.Add(Me.Label3)
        Me.tabPost.Controls.Add(Me.txtClientName)
        Me.tabPost.Controls.Add(Me.officeid)
        Me.tabPost.Controls.Add(Me.txttrnsumcode)
        Me.tabPost.Controls.Add(Me.txtbatchcode)
        Me.tabPost.Controls.Add(Me.txtReferenceNumber)
        Me.tabPost.Controls.Add(Me.Label6)
        Me.tabPost.Controls.Add(Me.Label13)
        Me.tabPost.Controls.Add(Me.txtSearchCode)
        Me.tabPost.Controls.Add(Me.ckasof)
        Me.tabPost.Controls.Add(Me.ListView1)
        Me.tabPost.Controls.Add(Me.cmdConfirm)
        Me.tabPost.Controls.Add(Me.Label2)
        Me.tabPost.Controls.Add(Me.txtBranch)
        Me.tabPost.Controls.Add(Me.Label1)
        Me.tabPost.Location = New System.Drawing.Point(4, 22)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(846, 411)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Post Transaction"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(300, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 726
        Me.Label4.Text = "Client Address"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(388, 281)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(258, 22)
        Me.txtAddress.TabIndex = 2
        '
        'txtTransactionType
        '
        Me.txtTransactionType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTransactionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTransactionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtTransactionType.DropDownHeight = 130
        Me.txtTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTransactionType.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtTransactionType.ForeColor = System.Drawing.Color.Black
        Me.txtTransactionType.FormattingEnabled = True
        Me.txtTransactionType.IntegralHeight = False
        Me.txtTransactionType.ItemHeight = 15
        Me.txtTransactionType.Location = New System.Drawing.Point(388, 332)
        Me.txtTransactionType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionType.MaxDropDownItems = 7
        Me.txtTransactionType.Name = "txtTransactionType"
        Me.txtTransactionType.Size = New System.Drawing.Size(258, 23)
        Me.txtTransactionType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(310, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 724
        Me.Label3.Text = "Client Name"
        '
        'txtClientName
        '
        Me.txtClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtClientName.ForeColor = System.Drawing.Color.Black
        Me.txtClientName.Location = New System.Drawing.Point(388, 256)
        Me.txtClientName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(258, 22)
        Me.txtClientName.TabIndex = 1
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(779, 323)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(58, 22)
        Me.officeid.TabIndex = 722
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'txttrnsumcode
        '
        Me.txttrnsumcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txttrnsumcode.ForeColor = System.Drawing.Color.Black
        Me.txttrnsumcode.Location = New System.Drawing.Point(779, 353)
        Me.txttrnsumcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txttrnsumcode.Name = "txttrnsumcode"
        Me.txttrnsumcode.Size = New System.Drawing.Size(58, 22)
        Me.txttrnsumcode.TabIndex = 721
        Me.txttrnsumcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttrnsumcode.Visible = False
        '
        'txtbatchcode
        '
        Me.txtbatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtbatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtbatchcode.Location = New System.Drawing.Point(779, 380)
        Me.txtbatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbatchcode.Name = "txtbatchcode"
        Me.txtbatchcode.Size = New System.Drawing.Size(58, 22)
        Me.txtbatchcode.TabIndex = 720
        Me.txtbatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbatchcode.Visible = False
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReferenceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtReferenceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtReferenceNumber.Location = New System.Drawing.Point(510, 231)
        Me.txtReferenceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Size = New System.Drawing.Size(136, 22)
        Me.txtReferenceNumber.TabIndex = 718
        Me.txtReferenceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(415, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 719
        Me.Label6.Text = "Transaction No."
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(294, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 15)
        Me.Label13.TabIndex = 717
        Me.Label13.Text = "Please Enter Transaction Reference Code"
        '
        'txtSearchCode
        '
        Me.txtSearchCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearchCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearchCode.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCode.Location = New System.Drawing.Point(275, 43)
        Me.txtSearchCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchCode.Name = "txtSearchCode"
        Me.txtSearchCode.Size = New System.Drawing.Size(258, 29)
        Me.txtSearchCode.TabIndex = 0
        Me.txtSearchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckasof
        '
        Me.ckasof.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckasof.AutoSize = True
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(163, 229)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(76, 19)
        Me.ckasof.TabIndex = 700
        Me.ckasof.Text = "Check All"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(163, 79)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(483, 147)
        Me.ListView1.TabIndex = 697
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.MyDataGridView)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(846, 411)
        Me.tabTransaction.TabIndex = 1
        Me.tabTransaction.Text = "View Transaction"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
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
        Me.MyDataGridView.Size = New System.Drawing.Size(840, 405)
        Me.MyDataGridView.TabIndex = 394
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewItemTransactionToolStripMenuItem, Me.ReprintTransactionToolStripMenuItem, Me.ToolStripSeparator1, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(191, 76)
        '
        'ViewItemTransactionToolStripMenuItem
        '
        Me.ViewItemTransactionToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list
        Me.ViewItemTransactionToolStripMenuItem.Name = "ViewItemTransactionToolStripMenuItem"
        Me.ViewItemTransactionToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ViewItemTransactionToolStripMenuItem.Text = "View Item Transaction"
        '
        'ReprintTransactionToolStripMenuItem
        '
        Me.ReprintTransactionToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Hot
        Me.ReprintTransactionToolStripMenuItem.Name = "ReprintTransactionToolStripMenuItem"
        Me.ReprintTransactionToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ReprintTransactionToolStripMenuItem.Text = "Re-print Transaction"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(190, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Cancel Transaction"
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.Label5)
        Me.tabHistory.Controls.Add(Me.txtTraceTransactionDate)
        Me.tabHistory.Controls.Add(Me.Label8)
        Me.tabHistory.Controls.Add(Me.txtHistoryBatchcode)
        Me.tabHistory.Controls.Add(Me.Label7)
        Me.tabHistory.Controls.Add(Me.txtClientHistoryName)
        Me.tabHistory.Controls.Add(Me.DataGridView1)
        Me.tabHistory.Location = New System.Drawing.Point(4, 22)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistory.Size = New System.Drawing.Size(846, 411)
        Me.tabHistory.TabIndex = 2
        Me.tabHistory.Text = "Trace Transaction History"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(19, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 727
        Me.Label5.Text = "Transaction Date"
        '
        'txtTraceTransactionDate
        '
        Me.txtTraceTransactionDate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTraceTransactionDate.ForeColor = System.Drawing.Color.Black
        Me.txtTraceTransactionDate.Location = New System.Drawing.Point(124, 38)
        Me.txtTraceTransactionDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTraceTransactionDate.Name = "txtTraceTransactionDate"
        Me.txtTraceTransactionDate.ReadOnly = True
        Me.txtTraceTransactionDate.Size = New System.Drawing.Size(181, 22)
        Me.txtTraceTransactionDate.TabIndex = 726
        Me.txtTraceTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(19, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 725
        Me.Label8.Text = "Transaction Code"
        '
        'txtHistoryBatchcode
        '
        Me.txtHistoryBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtHistoryBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtHistoryBatchcode.Location = New System.Drawing.Point(124, 63)
        Me.txtHistoryBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHistoryBatchcode.Name = "txtHistoryBatchcode"
        Me.txtHistoryBatchcode.ReadOnly = True
        Me.txtHistoryBatchcode.Size = New System.Drawing.Size(181, 22)
        Me.txtHistoryBatchcode.TabIndex = 724
        Me.txtHistoryBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(11, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 723
        Me.Label7.Text = "Select Client Name"
        '
        'txtClientHistoryName
        '
        Me.txtClientHistoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClientHistoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClientHistoryName.DropDownHeight = 130
        Me.txtClientHistoryName.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtClientHistoryName.ForeColor = System.Drawing.Color.Black
        Me.txtClientHistoryName.FormattingEnabled = True
        Me.txtClientHistoryName.IntegralHeight = False
        Me.txtClientHistoryName.ItemHeight = 15
        Me.txtClientHistoryName.Location = New System.Drawing.Point(124, 12)
        Me.txtClientHistoryName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientHistoryName.MaxDropDownItems = 7
        Me.txtClientHistoryName.Name = "txtClientHistoryName"
        Me.txtClientHistoryName.Size = New System.Drawing.Size(258, 23)
        Me.txtClientHistoryName.TabIndex = 722
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 95)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(840, 313)
        Me.DataGridView1.TabIndex = 720
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorrectTransactionToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(216, 48)
        '
        'CorrectTransactionToolStripMenuItem
        '
        Me.CorrectTransactionToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.clipboard_sign_out
        Me.CorrectTransactionToolStripMenuItem.Name = "CorrectTransactionToolStripMenuItem"
        Me.CorrectTransactionToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CorrectTransactionToolStripMenuItem.Text = "Correct All Transaction"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow1
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(215, 22)
        Me.ToolStripMenuItem3.Tag = "1"
        Me.ToolStripMenuItem3.Text = "Correct Selected Item Only"
        '
        'frmPOSDeliverySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(854, 437)
        Me.Controls.Add(Me.tabSeparator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(870, 476)
        Me.Name = "frmPOSDeliverySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Delivery Slip"
        Me.tabSeparator.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabSeparator As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSearchCode As System.Windows.Forms.TextBox
    Friend WithEvents txtReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txttrnsumcode As System.Windows.Forms.TextBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents ViewItemTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents ReprintTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtTransactionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents tabHistory As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtClientHistoryName As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHistoryBatchcode As TextBox
    Friend WithEvents CorrectTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTraceTransactionDate As TextBox
End Class
