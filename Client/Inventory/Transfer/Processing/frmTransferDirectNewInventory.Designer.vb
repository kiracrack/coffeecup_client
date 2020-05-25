<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferDirectNewInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferDirectNewInventory))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdFind = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAddProduct = New System.Windows.Forms.ToolStripButton()
        Me.separatorProduct = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtOffice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtrequester = New System.Windows.Forms.ComboBox()
        Me.lblcontactperson = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.txtbid = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbldescription.Text = "You can use this form to direct  stock transfer inventory "
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
        Me.lbltitle.Size = New System.Drawing.Size(152, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Stock Transfer Request"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(21, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Batch Code"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFind, Me.ToolStripSeparator1, Me.cmdAddProduct, Me.separatorProduct, Me.cmdDelete, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(711, 31)
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
        'cmdAddProduct
        '
        Me.cmdAddProduct.ForeColor = System.Drawing.Color.Orange
        Me.cmdAddProduct.Image = Global.CoffeecupClient.My.Resources.Resources.receipt__plus
        Me.cmdAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddProduct.Name = "cmdAddProduct"
        Me.cmdAddProduct.Size = New System.Drawing.Size(202, 24)
        Me.cmdAddProduct.Text = "If the product not exist, click here"
        '
        'separatorProduct
        '
        Me.separatorProduct.Name = "separatorProduct"
        Me.separatorProduct.Size = New System.Drawing.Size(6, 27)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.email_go
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(169, 24)
        Me.ToolStripButton1.Text = "Confirm Inventory Transfer"
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(12, 165)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(710, 310)
        Me.MyDataGridView.TabIndex = 342
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(165, 48)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.application_task
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditChapterToolStripMenuItem.Text = "Column Chooser"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(164, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtOffice
        '
        Me.txtOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtOffice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOffice.ForeColor = System.Drawing.Color.Black
        Me.txtOffice.FormattingEnabled = True
        Me.txtOffice.ItemHeight = 13
        Me.txtOffice.Location = New System.Drawing.Point(97, 82)
        Me.txtOffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(248, 21)
        Me.txtOffice.TabIndex = 368
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Transfer to"
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(584, 265)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(104, 22)
        Me.officeid.TabIndex = 370
        Me.officeid.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.Location = New System.Drawing.Point(349, 58)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(374, 69)
        Me.txtMessage.TabIndex = 382
        Me.txtMessage.Text = "Please enter message.."
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
        Me.txtrequester.Location = New System.Drawing.Point(97, 106)
        Me.txtrequester.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrequester.Name = "txtrequester"
        Me.txtrequester.Size = New System.Drawing.Size(248, 21)
        Me.txtrequester.TabIndex = 383
        '
        'lblcontactperson
        '
        Me.lblcontactperson.AutoSize = True
        Me.lblcontactperson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcontactperson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcontactperson.Location = New System.Drawing.Point(24, 108)
        Me.lblcontactperson.Name = "lblcontactperson"
        Me.lblcontactperson.Size = New System.Drawing.Size(65, 15)
        Me.lblcontactperson.TabIndex = 384
        Me.lblcontactperson.Text = "Request By"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.LoadStocks_Load
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(16, 6)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(49, 43)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'txtbid
        '
        Me.txtbid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtbid.ForeColor = System.Drawing.Color.Black
        Me.txtbid.Location = New System.Drawing.Point(97, 58)
        Me.txtbid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbid.Name = "txtbid"
        Me.txtbid.ReadOnly = True
        Me.txtbid.Size = New System.Drawing.Size(248, 22)
        Me.txtbid.TabIndex = 388
        Me.txtbid.Text = "SYSTEM GENERATED"
        Me.txtbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTransferDirectNewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(735, 486)
        Me.Controls.Add(Me.txtbid)
        Me.Controls.Add(Me.txtrequester)
        Me.Controls.Add(Me.lblcontactperson)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.officeid)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransferDirectNewInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Item"
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAddProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents separatorProduct As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtOffice As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtrequester As System.Windows.Forms.ComboBox
    Friend WithEvents lblcontactperson As System.Windows.Forms.Label
    Friend WithEvents txtbid As System.Windows.Forms.TextBox
End Class
