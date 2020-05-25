<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCustomPackage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCustomPackage))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.ComboBox()
        Me.txtPackagename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_packages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEditCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateStandardRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdConfirmedBooking = New System.Windows.Forms.Button()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_packages.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(16, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 799
        Me.Label10.Text = "Select Room Type"
        '
        'txtRoomType
        '
        Me.txtRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoomType.DropDownHeight = 130
        Me.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.FormattingEnabled = True
        Me.txtRoomType.IntegralHeight = False
        Me.txtRoomType.ItemHeight = 13
        Me.txtRoomType.Location = New System.Drawing.Point(118, 9)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomType.MaxDropDownItems = 7
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Size = New System.Drawing.Size(199, 21)
        Me.txtRoomType.TabIndex = 0
        '
        'txtPackagename
        '
        Me.txtPackagename.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPackagename.ForeColor = System.Drawing.Color.Black
        Me.txtPackagename.Location = New System.Drawing.Point(118, 33)
        Me.txtPackagename.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPackagename.Name = "txtPackagename"
        Me.txtPackagename.Size = New System.Drawing.Size(199, 22)
        Me.txtPackagename.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(30, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 801
        Me.Label3.Text = "Package Name"
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_packages
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(247, 311)
        Me.MyDataGridView.TabIndex = 802
        '
        'cms_packages
        '
        Me.cms_packages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEditCompanion, Me.DuplicateStandardRateToolStripMenuItem, Me.cmdRemoveCompanion, Me.ToolStripSeparator2, Me.cmdRefreshCompanion})
        Me.cms_packages.Name = "ContextMenuStrip1"
        Me.cms_packages.Size = New System.Drawing.Size(201, 98)
        '
        'cmdEditCompanion
        '
        Me.cmdEditCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditCompanion.Name = "cmdEditCompanion"
        Me.cmdEditCompanion.Size = New System.Drawing.Size(200, 22)
        Me.cmdEditCompanion.Text = "Edit Rate Name"
        '
        'DuplicateStandardRateToolStripMenuItem
        '
        Me.DuplicateStandardRateToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebooks
        Me.DuplicateStandardRateToolStripMenuItem.Name = "DuplicateStandardRateToolStripMenuItem"
        Me.DuplicateStandardRateToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DuplicateStandardRateToolStripMenuItem.Text = "Duplicate Standard Rate"
        '
        'cmdRemoveCompanion
        '
        Me.cmdRemoveCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveCompanion.Name = "cmdRemoveCompanion"
        Me.cmdRemoveCompanion.Size = New System.Drawing.Size(200, 22)
        Me.cmdRemoveCompanion.Text = "Remove Selected"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(197, 6)
        '
        'cmdRefreshCompanion
        '
        Me.cmdRefreshCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshCompanion.Name = "cmdRefreshCompanion"
        Me.cmdRefreshCompanion.Size = New System.Drawing.Size(200, 22)
        Me.cmdRefreshCompanion.Tag = "1"
        Me.cmdRefreshCompanion.Text = "Refresh Data"
        '
        'cmdConfirmedBooking
        '
        Me.cmdConfirmedBooking.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmedBooking.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdConfirmedBooking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmedBooking.Location = New System.Drawing.Point(117, 58)
        Me.cmdConfirmedBooking.Name = "cmdConfirmedBooking"
        Me.cmdConfirmedBooking.Size = New System.Drawing.Size(100, 32)
        Me.cmdConfirmedBooking.TabIndex = 803
        Me.cmdConfirmedBooking.Text = "Save Package"
        Me.cmdConfirmedBooking.UseVisualStyleBackColor = False
        '
        'roomtype
        '
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(371, 166)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(57, 23)
        Me.roomtype.TabIndex = 804
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtype.Visible = False
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(371, 195)
        Me.id.Margin = New System.Windows.Forms.Padding(5)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(57, 23)
        Me.id.TabIndex = 806
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(371, 225)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(57, 23)
        Me.mode.TabIndex = 807
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'rateid
        '
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rateid.ForeColor = System.Drawing.Color.Black
        Me.rateid.Location = New System.Drawing.Point(304, 225)
        Me.rateid.Margin = New System.Windows.Forms.Padding(5)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(57, 23)
        Me.rateid.TabIndex = 808
        Me.rateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rateid.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(506, 311)
        Me.DataGridView1.TabIndex = 810
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripSeparator1, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 76)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "Package Breakdown"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Tag = "1"
        Me.ToolStripMenuItem4.Text = "Refresh Data"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 118)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MyDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.roomtype)
        Me.SplitContainer1.Panel2.Controls.Add(Me.id)
        Me.SplitContainer1.Panel2.Controls.Add(Me.foliono)
        Me.SplitContainer1.Panel2.Controls.Add(Me.mode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.code)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rateid)
        Me.SplitContainer1.Size = New System.Drawing.Size(757, 311)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 811
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(438, 165)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(57, 23)
        Me.foliono.TabIndex = 813
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'code
        '
        Me.code.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.code.ForeColor = System.Drawing.Color.Black
        Me.code.Location = New System.Drawing.Point(304, 195)
        Me.code.Margin = New System.Windows.Forms.Padding(5)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(57, 23)
        Me.code.TabIndex = 812
        Me.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.code.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label1.Location = New System.Drawing.Point(325, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 88)
        Me.Label1.TabIndex = 814
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(325, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 815
        Me.Label2.Text = "Coffeecup Update Note"
        '
        'frmHotelCustomPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(778, 436)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmdConfirmedBooking)
        Me.Controls.Add(Me.txtPackagename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRoomType)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelCustomPackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Packages Management"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_packages.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPackagename As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdConfirmedBooking As System.Windows.Forms.Button
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents cms_packages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEditCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents rateid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents code As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents DuplicateStandardRateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
