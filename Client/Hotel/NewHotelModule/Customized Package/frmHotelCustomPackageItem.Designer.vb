<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCustomPackageItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCustomPackageItem))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_packages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddnew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.roomrate = New System.Windows.Forms.TabPage()
        Me.ratecode = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.child = New System.Windows.Forms.TabPage()
        Me.extra = New System.Windows.Forms.TabPage()
        Me.bookingno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNight = New System.Windows.Forms.ComboBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_packages.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.roomrate.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_packages
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(420, 344)
        Me.MyDataGridView.TabIndex = 0
        '
        'cms_packages
        '
        Me.cms_packages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddnew, Me.cmdEditSelected, Me.cmdRemoveSelected, Me.ToolStripSeparator2, Me.cmdRefreshCompanion})
        Me.cms_packages.Name = "ContextMenuStrip1"
        Me.cms_packages.Size = New System.Drawing.Size(165, 98)
        '
        'cmdAddnew
        '
        Me.cmdAddnew.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddnew.Name = "cmdAddnew"
        Me.cmdAddnew.Size = New System.Drawing.Size(164, 22)
        Me.cmdAddnew.Text = "Add New"
        '
        'cmdEditSelected
        '
        Me.cmdEditSelected.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditSelected.Name = "cmdEditSelected"
        Me.cmdEditSelected.Size = New System.Drawing.Size(164, 22)
        Me.cmdEditSelected.Text = "Edit Selected"
        '
        'cmdRemoveSelected
        '
        Me.cmdRemoveSelected.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveSelected.Name = "cmdRemoveSelected"
        Me.cmdRemoveSelected.Size = New System.Drawing.Size(164, 22)
        Me.cmdRemoveSelected.Text = "Remove Selected"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'cmdRefreshCompanion
        '
        Me.cmdRefreshCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshCompanion.Name = "cmdRefreshCompanion"
        Me.cmdRefreshCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdRefreshCompanion.Tag = "1"
        Me.cmdRefreshCompanion.Text = "Refresh Data"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.roomrate)
        Me.TabControl1.Controls.Add(Me.child)
        Me.TabControl1.Controls.Add(Me.extra)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(434, 380)
        Me.TabControl1.TabIndex = 412
        '
        'roomrate
        '
        Me.roomrate.Controls.Add(Me.ratecode)
        Me.roomrate.Controls.Add(Me.roomtype)
        Me.roomrate.Controls.Add(Me.MyDataGridView)
        Me.roomrate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.roomrate.Location = New System.Drawing.Point(4, 26)
        Me.roomrate.Name = "roomrate"
        Me.roomrate.Padding = New System.Windows.Forms.Padding(3)
        Me.roomrate.Size = New System.Drawing.Size(426, 350)
        Me.roomrate.TabIndex = 0
        Me.roomrate.Text = "Adult Rate/Room Rate"
        Me.roomrate.UseVisualStyleBackColor = True
        '
        'ratecode
        '
        Me.ratecode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ratecode.ForeColor = System.Drawing.Color.Black
        Me.ratecode.Location = New System.Drawing.Point(309, 137)
        Me.ratecode.Margin = New System.Windows.Forms.Padding(5)
        Me.ratecode.Name = "ratecode"
        Me.ratecode.Size = New System.Drawing.Size(57, 23)
        Me.ratecode.TabIndex = 806
        Me.ratecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ratecode.Visible = False
        '
        'roomtype
        '
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(229, 137)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(57, 23)
        Me.roomtype.TabIndex = 805
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtype.Visible = False
        '
        'child
        '
        Me.child.Location = New System.Drawing.Point(4, 26)
        Me.child.Name = "child"
        Me.child.Padding = New System.Windows.Forms.Padding(3)
        Me.child.Size = New System.Drawing.Size(426, 350)
        Me.child.TabIndex = 1
        Me.child.Text = "Child Rate"
        Me.child.UseVisualStyleBackColor = True
        '
        'extra
        '
        Me.extra.Location = New System.Drawing.Point(4, 26)
        Me.extra.Name = "extra"
        Me.extra.Padding = New System.Windows.Forms.Padding(3)
        Me.extra.Size = New System.Drawing.Size(426, 350)
        Me.extra.TabIndex = 2
        Me.extra.Text = "Extra Person Rate"
        Me.extra.UseVisualStyleBackColor = True
        '
        'bookingno
        '
        Me.bookingno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bookingno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.bookingno.ForeColor = System.Drawing.Color.Black
        Me.bookingno.Location = New System.Drawing.Point(444, 211)
        Me.bookingno.Margin = New System.Windows.Forms.Padding(4)
        Me.bookingno.Name = "bookingno"
        Me.bookingno.Size = New System.Drawing.Size(50, 22)
        Me.bookingno.TabIndex = 411
        Me.bookingno.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 801
        Me.Label10.Text = "Select Day"
        '
        'txtNight
        '
        Me.txtNight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtNight.DropDownHeight = 130
        Me.txtNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtNight.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtNight.ForeColor = System.Drawing.Color.Black
        Me.txtNight.FormattingEnabled = True
        Me.txtNight.IntegralHeight = False
        Me.txtNight.ItemHeight = 19
        Me.txtNight.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.txtNight.Location = New System.Drawing.Point(91, 8)
        Me.txtNight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNight.MaxDropDownItems = 7
        Me.txtNight.Name = "txtNight"
        Me.txtNight.Size = New System.Drawing.Size(77, 27)
        Me.txtNight.TabIndex = 800
        '
        'frmHotelCustomPackageItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(434, 422)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNight)
        Me.Controls.Add(Me.bookingno)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHotelCustomPackageItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customized Packages"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_packages.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.roomrate.ResumeLayout(False)
        Me.roomrate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents roomrate As System.Windows.Forms.TabPage
    Friend WithEvents child As System.Windows.Forms.TabPage
    Friend WithEvents bookingno As System.Windows.Forms.TextBox
    Friend WithEvents extra As System.Windows.Forms.TabPage
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents ratecode As System.Windows.Forms.TextBox
    Friend WithEvents cms_packages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddnew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNight As System.Windows.Forms.ComboBox
End Class
