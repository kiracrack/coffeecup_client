<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferRequestReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferRequestReview))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdChangeQuantity = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessSelectedItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdNotAvailable = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRestoreDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtOfficeName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtDateRequested = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRequestedBy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Batchcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtreqid = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.tabApproval = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Approval = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        Me.tabApproval.SuspendLayout()
        CType(Me.MyDataGridView_Approval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(64, 32)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(462, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this tool to view stock transfer request from other offices"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 37)
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
        Me.lbltitle.Location = New System.Drawing.Point(64, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(230, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Stock Transfer Request Information"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(811, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.cmdDelete})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(811, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Hot
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(137, 24)
        Me.ToolStripButton1.Text = "Print Requested Item"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'cmdDelete
        '
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = Global.CoffeecupClient.My.Resources.Resources.Close2
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(108, 24)
        Me.cmdDelete.Text = "Cancel Request"
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
        Me.MyDataGridView.Size = New System.Drawing.Size(576, 283)
        Me.MyDataGridView.TabIndex = 0
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.cmdChangeQuantity, Me.ProcessSelectedItemToolStripMenuItem, Me.cmdNotAvailable, Me.cmdRestoreDefault, Me.ToolStripSeparator2, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(191, 142)
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddItemToolStripMenuItem.Text = "Add New Item"
        '
        'cmdChangeQuantity
        '
        Me.cmdChangeQuantity.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdChangeQuantity.Name = "cmdChangeQuantity"
        Me.cmdChangeQuantity.Size = New System.Drawing.Size(190, 22)
        Me.cmdChangeQuantity.Text = "Change Quantity"
        '
        'ProcessSelectedItemToolStripMenuItem
        '
        Me.ProcessSelectedItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.ProcessSelectedItemToolStripMenuItem.Name = "ProcessSelectedItemToolStripMenuItem"
        Me.ProcessSelectedItemToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ProcessSelectedItemToolStripMenuItem.Text = "Process Selected Item"
        '
        'cmdNotAvailable
        '
        Me.cmdNotAvailable.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdNotAvailable.Name = "cmdNotAvailable"
        Me.cmdNotAvailable.Size = New System.Drawing.Size(190, 22)
        Me.cmdNotAvailable.Text = "Not Include (Remove)"
        '
        'cmdRestoreDefault
        '
        Me.cmdRestoreDefault.Image = Global.CoffeecupClient.My.Resources.Resources.notebook_sticky_note
        Me.cmdRestoreDefault.Name = "cmdRestoreDefault"
        Me.cmdRestoreDefault.Size = New System.Drawing.Size(190, 22)
        Me.cmdRestoreDefault.Text = "Restore Default"
        Me.cmdRestoreDefault.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(190, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtOfficeName
        '
        Me.txtOfficeName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOfficeName.ForeColor = System.Drawing.Color.Black
        Me.txtOfficeName.Location = New System.Drawing.Point(12, 150)
        Me.txtOfficeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOfficeName.Name = "txtOfficeName"
        Me.txtOfficeName.ReadOnly = True
        Me.txtOfficeName.Size = New System.Drawing.Size(214, 22)
        Me.txtOfficeName.TabIndex = 347
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(9, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 345
        Me.Label10.Text = "Message"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(9, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 15)
        Me.Label13.TabIndex = 346
        Me.Label13.Text = "Office Requestor"
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.Location = New System.Drawing.Point(12, 194)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(214, 95)
        Me.txtMessage.TabIndex = 344
        '
        'txtDateRequested
        '
        Me.txtDateRequested.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateRequested.ForeColor = System.Drawing.Color.Black
        Me.txtDateRequested.Location = New System.Drawing.Point(12, 313)
        Me.txtDateRequested.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateRequested.Name = "txtDateRequested"
        Me.txtDateRequested.ReadOnly = True
        Me.txtDateRequested.Size = New System.Drawing.Size(214, 22)
        Me.txtDateRequested.TabIndex = 349
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 348
        Me.Label1.Text = "Date Requested"
        '
        'txtRequestedBy
        '
        Me.txtRequestedBy.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRequestedBy.ForeColor = System.Drawing.Color.Black
        Me.txtRequestedBy.Location = New System.Drawing.Point(12, 356)
        Me.txtRequestedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRequestedBy.Name = "txtRequestedBy"
        Me.txtRequestedBy.ReadOnly = True
        Me.txtRequestedBy.Size = New System.Drawing.Size(214, 22)
        Me.txtRequestedBy.TabIndex = 351
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(9, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 350
        Me.Label2.Text = "Requested By"
        '
        'Batchcode
        '
        Me.Batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Batchcode.ForeColor = System.Drawing.Color.Black
        Me.Batchcode.Location = New System.Drawing.Point(13, 108)
        Me.Batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.Batchcode.Name = "Batchcode"
        Me.Batchcode.ReadOnly = True
        Me.Batchcode.Size = New System.Drawing.Size(214, 22)
        Me.Batchcode.TabIndex = 353
        Me.Batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 352
        Me.Label3.Text = "Reference Number"
        '
        'txtreqid
        '
        Me.txtreqid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtreqid.ForeColor = System.Drawing.Color.Black
        Me.txtreqid.Location = New System.Drawing.Point(310, 199)
        Me.txtreqid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreqid.Name = "txtreqid"
        Me.txtreqid.ReadOnly = True
        Me.txtreqid.Size = New System.Drawing.Size(64, 22)
        Me.txtreqid.TabIndex = 354
        Me.txtreqid.Visible = False
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFrom.ForeColor = System.Drawing.Color.Black
        Me.txtFrom.Location = New System.Drawing.Point(385, 199)
        Me.txtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.ReadOnly = True
        Me.txtFrom.Size = New System.Drawing.Size(64, 22)
        Me.txtFrom.TabIndex = 355
        Me.txtFrom.Visible = False
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTo.ForeColor = System.Drawing.Color.Black
        Me.txtTo.Location = New System.Drawing.Point(457, 199)
        Me.txtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(64, 22)
        Me.txtTo.TabIndex = 356
        Me.txtTo.Visible = False
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.LoadStocks_Load
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(12, 1)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(48, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabParticular)
        Me.TabControl1.Controls.Add(Me.tabApproval)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(233, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 317)
        Me.TabControl1.TabIndex = 357
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.MyDataGridView)
        Me.tabParticular.Location = New System.Drawing.Point(4, 24)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(582, 289)
        Me.tabParticular.TabIndex = 0
        Me.tabParticular.Text = "Particular Entries"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'tabApproval
        '
        Me.tabApproval.Controls.Add(Me.MyDataGridView_Approval)
        Me.tabApproval.Location = New System.Drawing.Point(4, 24)
        Me.tabApproval.Name = "tabApproval"
        Me.tabApproval.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApproval.Size = New System.Drawing.Size(582, 289)
        Me.tabApproval.TabIndex = 1
        Me.tabApproval.Text = "Approval History"
        Me.tabApproval.UseVisualStyleBackColor = True
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
        Me.MyDataGridView_Approval.Size = New System.Drawing.Size(576, 283)
        Me.MyDataGridView_Approval.TabIndex = 344
        '
        'frmStockTransferDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(835, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtreqid)
        Me.Controls.Add(Me.Batchcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRequestedBy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDateRequested)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOfficeName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockTransferDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Requisition"
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        Me.tabApproval.ResumeLayout(False)
        CType(Me.MyDataGridView_Approval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdChangeQuantity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNotAvailable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtOfficeName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtDateRequested As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRequestedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Batchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdRestoreDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtreqid As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ProcessSelectedItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents tabApproval As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Approval As System.Windows.Forms.DataGridView
End Class
