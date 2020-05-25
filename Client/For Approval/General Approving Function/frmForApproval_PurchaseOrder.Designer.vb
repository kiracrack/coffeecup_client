<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForApproval_PurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForApproval_PurchaseOrder))
        Me.MyDataGridView_Particular = New System.Windows.Forms.DataGridView()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.ponumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtoffice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdatereq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdDisapproved = New System.Windows.Forms.Button()
        Me.cmdApproved = New System.Windows.Forms.Button()
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
        Me.ckCorporate = New System.Windows.Forms.CheckBox()
        Me.ckFinalApprover = New System.Windows.Forms.CheckBox()
        Me.requestby = New System.Windows.Forms.TextBox()
        Me.txtRequestby = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.ckCustom = New System.Windows.Forms.CheckBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MyDataGridView_Particular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Particular.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Particular.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Particular.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Particular.MultiSelect = False
        Me.MyDataGridView_Particular.Name = "MyDataGridView_Particular"
        Me.MyDataGridView_Particular.ReadOnly = True
        Me.MyDataGridView_Particular.RowHeadersVisible = False
        Me.MyDataGridView_Particular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Particular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Particular.Size = New System.Drawing.Size(607, 317)
        Me.MyDataGridView_Particular.TabIndex = 342
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtStatus.Location = New System.Drawing.Point(109, 6)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(195, 31)
        Me.txtStatus.TabIndex = 343
        Me.txtStatus.Text = "FOR APPROVAL"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ponumber
        '
        Me.ponumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ponumber.Location = New System.Drawing.Point(109, 40)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.ReadOnly = True
        Me.ponumber.Size = New System.Drawing.Size(195, 23)
        Me.ponumber.TabIndex = 345
        Me.ponumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "PO Number"
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtoffice.Location = New System.Drawing.Point(109, 66)
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
        Me.Label2.Location = New System.Drawing.Point(64, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 348
        Me.Label2.Text = "Office"
        '
        'txtdatereq
        '
        Me.txtdatereq.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdatereq.Location = New System.Drawing.Point(109, 118)
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
        Me.Label5.Location = New System.Drawing.Point(27, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 354
        Me.Label5.Text = "Date Request"
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSupplier.Location = New System.Drawing.Point(109, 144)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(195, 23)
        Me.txtSupplier.TabIndex = 355
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(53, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 356
        Me.Label6.Text = "Supplier"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalAmount.Location = New System.Drawing.Point(109, 170)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(195, 23)
        Me.txtTotalAmount.TabIndex = 357
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 358
        Me.Label7.Text = "Total Amount"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNote.Location = New System.Drawing.Point(109, 196)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ReadOnly = True
        Me.txtNote.Size = New System.Drawing.Size(195, 51)
        Me.txtNote.TabIndex = 359
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(70, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 360
        Me.Label8.Text = "Note"
        '
        'cmdDisapproved
        '
        Me.cmdDisapproved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDisapproved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDisapproved.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdDisapproved.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisapproved.Location = New System.Drawing.Point(750, 417)
        Me.cmdDisapproved.Name = "cmdDisapproved"
        Me.cmdDisapproved.Size = New System.Drawing.Size(180, 30)
        Me.cmdDisapproved.TabIndex = 361
        Me.cmdDisapproved.Text = "Disapproved"
        Me.cmdDisapproved.UseVisualStyleBackColor = False
        '
        'cmdApproved
        '
        Me.cmdApproved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdApproved.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdApproved.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdApproved.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdApproved.Location = New System.Drawing.Point(567, 417)
        Me.cmdApproved.Name = "cmdApproved"
        Me.cmdApproved.Size = New System.Drawing.Size(180, 30)
        Me.cmdApproved.TabIndex = 362
        Me.cmdApproved.Text = "Approve"
        Me.cmdApproved.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(309, 362)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(621, 51)
        Me.txtRemarks.TabIndex = 364
        Me.txtRemarks.Text = "Please enter message"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAttachment.Location = New System.Drawing.Point(109, 249)
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
        Me.Label9.Location = New System.Drawing.Point(33, 256)
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
        Me.TabControl1.Location = New System.Drawing.Point(309, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(621, 351)
        Me.TabControl1.TabIndex = 0
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.MyDataGridView_Particular)
        Me.tabParticular.Location = New System.Drawing.Point(4, 24)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(613, 323)
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
        Me.tabApprovalHistory.Size = New System.Drawing.Size(613, 323)
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
        Me.MyDataGridView_Approval.Size = New System.Drawing.Size(607, 317)
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
        'ckCorporate
        '
        Me.ckCorporate.AutoSize = True
        Me.ckCorporate.Location = New System.Drawing.Point(109, 324)
        Me.ckCorporate.Name = "ckCorporate"
        Me.ckCorporate.Size = New System.Drawing.Size(78, 17)
        Me.ckCorporate.TabIndex = 370
        Me.ckCorporate.Text = "Corporate"
        Me.ckCorporate.UseVisualStyleBackColor = True
        Me.ckCorporate.Visible = False
        '
        'ckFinalApprover
        '
        Me.ckFinalApprover.AutoSize = True
        Me.ckFinalApprover.Location = New System.Drawing.Point(109, 347)
        Me.ckFinalApprover.Name = "ckFinalApprover"
        Me.ckFinalApprover.Size = New System.Drawing.Size(101, 17)
        Me.ckFinalApprover.TabIndex = 377
        Me.ckFinalApprover.Text = "Final Approver"
        Me.ckFinalApprover.UseVisualStyleBackColor = True
        Me.ckFinalApprover.Visible = False
        '
        'requestby
        '
        Me.requestby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.requestby.Location = New System.Drawing.Point(261, 308)
        Me.requestby.Name = "requestby"
        Me.requestby.ReadOnly = True
        Me.requestby.Size = New System.Drawing.Size(33, 23)
        Me.requestby.TabIndex = 378
        Me.requestby.Visible = False
        '
        'txtRequestby
        '
        Me.txtRequestby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestby.Location = New System.Drawing.Point(109, 92)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.ReadOnly = True
        Me.txtRequestby.Size = New System.Drawing.Size(195, 23)
        Me.txtRequestby.TabIndex = 379
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 380
        Me.Label3.Text = "Requested By"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Location = New System.Drawing.Point(261, 337)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(33, 23)
        Me.mode.TabIndex = 381
        Me.mode.Visible = False
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pid.Location = New System.Drawing.Point(261, 282)
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(33, 23)
        Me.pid.TabIndex = 346
        Me.pid.Visible = False
        '
        'ckCustom
        '
        Me.ckCustom.AutoSize = True
        Me.ckCustom.Location = New System.Drawing.Point(109, 370)
        Me.ckCustom.Name = "ckCustom"
        Me.ckCustom.Size = New System.Drawing.Size(63, 17)
        Me.ckCustom.TabIndex = 382
        Me.ckCustom.Text = "custom"
        Me.ckCustom.UseVisualStyleBackColor = True
        Me.ckCustom.Visible = False
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.Location = New System.Drawing.Point(261, 366)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(33, 23)
        Me.officeid.TabIndex = 383
        Me.officeid.Visible = False
        '
        'frmForApproval_PurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(937, 451)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.ckCustom)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtRequestby)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.requestby)
        Me.Controls.Add(Me.ckFinalApprover)
        Me.Controls.Add(Me.ckCorporate)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cmdApproved)
        Me.Controls.Add(Me.cmdDisapproved)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdatereq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(931, 490)
        Me.Name = "frmForApproval_PurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order for Approval"
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ponumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtoffice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdatereq As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdDisapproved As System.Windows.Forms.Button
    Friend WithEvents cmdApproved As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents tabApprovalHistory As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Approval As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckCorporate As System.Windows.Forms.CheckBox
    Friend WithEvents ckFinalApprover As System.Windows.Forms.CheckBox
    Friend WithEvents requestby As System.Windows.Forms.TextBox
    Friend WithEvents txtRequestby As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents ckCustom As System.Windows.Forms.CheckBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
End Class
