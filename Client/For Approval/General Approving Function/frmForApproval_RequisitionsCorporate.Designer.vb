<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForApproval_RequisitionsCorporate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForApproval_RequisitionsCorporate))
        Me.MyDataGridView_Particular = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdChangeAmount = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtoffice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRequestby = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdatereq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDisbursement = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpotype = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdetails = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdDisapprove = New System.Windows.Forms.Button()
        Me.cmdApprove = New System.Windows.Forms.Button()
        Me.cmdHold = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cmdAttachment = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.tabApprovalHistory = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Approval = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.potypeid = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.ckCustom = New System.Windows.Forms.CheckBox()
        Me.requestby = New System.Windows.Forms.TextBox()
        Me.txtDateNeeded = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        Me.tabApprovalHistory.SuspendLayout()
        CType(Me.MyDataGridView_Approval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView_Particular
        '
        Me.MyDataGridView_Particular.AllowUserToDeleteRows = False
        Me.MyDataGridView_Particular.AllowUserToResizeColumns = False
        Me.MyDataGridView_Particular.AllowUserToResizeRows = False
        Me.MyDataGridView_Particular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Particular.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Particular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Particular.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MyDataGridView_Particular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Particular.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Particular.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Particular.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Particular.Name = "MyDataGridView_Particular"
        Me.MyDataGridView_Particular.ReadOnly = True
        Me.MyDataGridView_Particular.RowHeadersVisible = False
        Me.MyDataGridView_Particular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Particular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Particular.Size = New System.Drawing.Size(624, 336)
        Me.MyDataGridView_Particular.TabIndex = 342
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdChangeAmount, Me.ChangeSupplierToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(260, 98)
        '
        'cmdChangeAmount
        '
        Me.cmdChangeAmount.Image = Global.CoffeecupClient.My.Resources.Resources.money__arrow
        Me.cmdChangeAmount.Name = "cmdChangeAmount"
        Me.cmdChangeAmount.Size = New System.Drawing.Size(259, 22)
        Me.cmdChangeAmount.Text = "Update Selected Item"
        '
        'ChangeSupplierToolStripMenuItem
        '
        Me.ChangeSupplierToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.truck__arrow
        Me.ChangeSupplierToolStripMenuItem.Name = "ChangeSupplierToolStripMenuItem"
        Me.ChangeSupplierToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ChangeSupplierToolStripMenuItem.Text = "Change Supplier for Selected Item"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.page_white_go
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(259, 22)
        Me.ToolStripMenuItem1.Text = "View Previous Request for this item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(256, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(259, 22)
        Me.ToolStripMenuItem2.Tag = "1"
        Me.ToolStripMenuItem2.Text = "Refresh Data"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtStatus.Location = New System.Drawing.Point(123, 6)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(195, 31)
        Me.txtStatus.TabIndex = 343
        Me.txtStatus.Text = "FOR APPROVAL"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pid.Location = New System.Drawing.Point(123, 40)
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(195, 23)
        Me.pid.TabIndex = 345
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(57, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Request #"
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtoffice.Location = New System.Drawing.Point(123, 66)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.ReadOnly = True
        Me.txtoffice.Size = New System.Drawing.Size(195, 23)
        Me.txtoffice.TabIndex = 347
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(72, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 348
        Me.Label2.Text = "Branch"
        '
        'txtRequestby
        '
        Me.txtRequestby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestby.Location = New System.Drawing.Point(123, 92)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.ReadOnly = True
        Me.txtRequestby.Size = New System.Drawing.Size(195, 23)
        Me.txtRequestby.TabIndex = 349
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 350
        Me.Label3.Text = "Requested By"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDesignation.Location = New System.Drawing.Point(123, 118)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(195, 23)
        Me.txtDesignation.TabIndex = 351
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(66, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 352
        Me.Label4.Text = "Position"
        '
        'txtdatereq
        '
        Me.txtdatereq.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdatereq.Location = New System.Drawing.Point(123, 144)
        Me.txtdatereq.Name = "txtdatereq"
        Me.txtdatereq.ReadOnly = True
        Me.txtdatereq.Size = New System.Drawing.Size(195, 23)
        Me.txtdatereq.TabIndex = 353
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 354
        Me.Label5.Text = "Date Requested"
        '
        'txtDisbursement
        '
        Me.txtDisbursement.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDisbursement.Location = New System.Drawing.Point(123, 170)
        Me.txtDisbursement.Name = "txtDisbursement"
        Me.txtDisbursement.ReadOnly = True
        Me.txtDisbursement.Size = New System.Drawing.Size(195, 23)
        Me.txtDisbursement.TabIndex = 355
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(37, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 356
        Me.Label6.Text = "Request Level"
        '
        'txtpotype
        '
        Me.txtpotype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpotype.Location = New System.Drawing.Point(123, 196)
        Me.txtpotype.Name = "txtpotype"
        Me.txtpotype.ReadOnly = True
        Me.txtpotype.Size = New System.Drawing.Size(195, 23)
        Me.txtpotype.TabIndex = 357
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 358
        Me.Label7.Text = "Request Type"
        '
        'txtdetails
        '
        Me.txtdetails.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdetails.Location = New System.Drawing.Point(123, 248)
        Me.txtdetails.Multiline = True
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.ReadOnly = True
        Me.txtdetails.Size = New System.Drawing.Size(195, 51)
        Me.txtdetails.TabIndex = 359
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(74, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 360
        Me.Label8.Text = "Details"
        '
        'cmdDisapprove
        '
        Me.cmdDisapprove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDisapprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDisapprove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdDisapprove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisapprove.Location = New System.Drawing.Point(785, 436)
        Me.cmdDisapprove.Name = "cmdDisapprove"
        Me.cmdDisapprove.Size = New System.Drawing.Size(180, 30)
        Me.cmdDisapprove.TabIndex = 361
        Me.cmdDisapprove.Text = "Disapprove"
        Me.cmdDisapprove.UseVisualStyleBackColor = False
        '
        'cmdApprove
        '
        Me.cmdApprove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdApprove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdApprove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdApprove.Location = New System.Drawing.Point(602, 436)
        Me.cmdApprove.Name = "cmdApprove"
        Me.cmdApprove.Size = New System.Drawing.Size(180, 30)
        Me.cmdApprove.TabIndex = 362
        Me.cmdApprove.Text = "Approve"
        Me.cmdApprove.UseVisualStyleBackColor = False
        '
        'cmdHold
        '
        Me.cmdHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHold.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdHold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHold.Location = New System.Drawing.Point(419, 436)
        Me.cmdHold.Name = "cmdHold"
        Me.cmdHold.Size = New System.Drawing.Size(180, 30)
        Me.cmdHold.TabIndex = 363
        Me.cmdHold.Text = "Hold"
        Me.cmdHold.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(327, 382)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(638, 51)
        Me.txtRemarks.TabIndex = 364
        Me.txtRemarks.Text = "Please enter message"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAttachment.Location = New System.Drawing.Point(123, 301)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(196, 30)
        Me.cmdAttachment.TabIndex = 365
        Me.cmdAttachment.Text = "Attachment"
        Me.cmdAttachment.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(46, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 366
        Me.Label9.Text = "Attachment"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabParticular)
        Me.TabControl1.Controls.Add(Me.tabApprovalHistory)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(327, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(638, 370)
        Me.TabControl1.TabIndex = 0
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.MyDataGridView_Particular)
        Me.tabParticular.Location = New System.Drawing.Point(4, 24)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(630, 342)
        Me.tabParticular.TabIndex = 0
        Me.tabParticular.Text = "Particular Entries"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'tabApprovalHistory
        '
        Me.tabApprovalHistory.Controls.Add(Me.MyDataGridView_Approval)
        Me.tabApprovalHistory.Location = New System.Drawing.Point(4, 24)
        Me.tabApprovalHistory.Name = "tabApprovalHistory"
        Me.tabApprovalHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApprovalHistory.Size = New System.Drawing.Size(630, 342)
        Me.tabApprovalHistory.TabIndex = 1
        Me.tabApprovalHistory.Text = "Approval History"
        Me.tabApprovalHistory.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Approval
        '
        Me.MyDataGridView_Approval.AllowUserToAddRows = False
        Me.MyDataGridView_Approval.AllowUserToDeleteRows = False
        Me.MyDataGridView_Approval.AllowUserToResizeColumns = False
        Me.MyDataGridView_Approval.AllowUserToResizeRows = False
        Me.MyDataGridView_Approval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Approval.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Approval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Approval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Approval.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Approval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Approval.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Approval.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Approval.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Approval.MultiSelect = False
        Me.MyDataGridView_Approval.Name = "MyDataGridView_Approval"
        Me.MyDataGridView_Approval.ReadOnly = True
        Me.MyDataGridView_Approval.RowHeadersVisible = False
        Me.MyDataGridView_Approval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Approval.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView_Approval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Approval.Size = New System.Drawing.Size(624, 336)
        Me.MyDataGridView_Approval.TabIndex = 343
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditItemToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(192, 54)
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditItemToolStripMenuItem.Text = "Print Approval History"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(191, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'potypeid
        '
        Me.potypeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.potypeid.Location = New System.Drawing.Point(109, 406)
        Me.potypeid.Name = "potypeid"
        Me.potypeid.ReadOnly = True
        Me.potypeid.Size = New System.Drawing.Size(44, 23)
        Me.potypeid.TabIndex = 367
        Me.potypeid.Visible = False
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.Location = New System.Drawing.Point(159, 406)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(44, 23)
        Me.officeid.TabIndex = 368
        Me.officeid.Visible = False
        '
        'ckCustom
        '
        Me.ckCustom.AutoSize = True
        Me.ckCustom.Location = New System.Drawing.Point(209, 409)
        Me.ckCustom.Name = "ckCustom"
        Me.ckCustom.Size = New System.Drawing.Size(82, 17)
        Me.ckCustom.TabIndex = 369
        Me.ckCustom.Text = "CheckBox1"
        Me.ckCustom.UseVisualStyleBackColor = True
        Me.ckCustom.Visible = False
        '
        'requestby
        '
        Me.requestby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.requestby.Location = New System.Drawing.Point(109, 435)
        Me.requestby.Name = "requestby"
        Me.requestby.ReadOnly = True
        Me.requestby.Size = New System.Drawing.Size(44, 23)
        Me.requestby.TabIndex = 370
        Me.requestby.Visible = False
        '
        'txtDateNeeded
        '
        Me.txtDateNeeded.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateNeeded.Location = New System.Drawing.Point(123, 222)
        Me.txtDateNeeded.Name = "txtDateNeeded"
        Me.txtDateNeeded.ReadOnly = True
        Me.txtDateNeeded.Size = New System.Drawing.Size(195, 23)
        Me.txtDateNeeded.TabIndex = 371
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(41, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 372
        Me.Label10.Text = "Date Needed"
        '
        'frmForApproval_RequisitionsCorporate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(972, 471)
        Me.Controls.Add(Me.txtDateNeeded)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.requestby)
        Me.Controls.Add(Me.ckCustom)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.potypeid)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cmdHold)
        Me.Controls.Add(Me.cmdApprove)
        Me.Controls.Add(Me.cmdDisapprove)
        Me.Controls.Add(Me.txtdetails)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpotype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDisbursement)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdatereq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRequestby)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(988, 490)
        Me.Name = "frmForApproval_RequisitionsCorporate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Approval Request (Corporate)"
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        Me.tabApprovalHistory.ResumeLayout(False)
        CType(Me.MyDataGridView_Approval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView_Particular As System.Windows.Forms.DataGridView
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtoffice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRequestby As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdatereq As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDisbursement As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpotype As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdetails As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdDisapprove As System.Windows.Forms.Button
    Friend WithEvents cmdApprove As System.Windows.Forms.Button
    Friend WithEvents cmdHold As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents tabApprovalHistory As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Approval As System.Windows.Forms.DataGridView
    Friend WithEvents potypeid As System.Windows.Forms.TextBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents ckCustom As System.Windows.Forms.CheckBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents requestby As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdChangeAmount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDateNeeded As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
