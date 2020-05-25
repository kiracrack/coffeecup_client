<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomOccupancy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelRoomOccupancy))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHotel = New System.Windows.Forms.ComboBox()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.hotelcifid = New System.Windows.Forms.TextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.MyDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtHotel)
        Me.GroupBox1.Controls.Add(Me.txtDateTo)
        Me.GroupBox1.Controls.Add(Me.txtDateFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Command - Press F3 to enter command search"
        '
        'txtHotel
        '
        Me.txtHotel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtHotel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtHotel.DropDownHeight = 130
        Me.txtHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHotel.ForeColor = System.Drawing.Color.Black
        Me.txtHotel.FormattingEnabled = True
        Me.txtHotel.IntegralHeight = False
        Me.txtHotel.ItemHeight = 15
        Me.txtHotel.Location = New System.Drawing.Point(297, 20)
        Me.txtHotel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHotel.MaxDropDownItems = 7
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Size = New System.Drawing.Size(204, 23)
        Me.txtHotel.TabIndex = 474
        Me.txtHotel.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateTo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTo.Location = New System.Drawing.Point(152, 20)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(141, 22)
        Me.txtDateTo.TabIndex = 439
        Me.txtDateTo.Visible = False
        '
        'txtDateFrom
        '
        Me.txtDateFrom.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateFrom.Location = New System.Drawing.Point(7, 20)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(141, 22)
        Me.txtDateFrom.TabIndex = 438
        '
        'hotelcifid
        '
        Me.hotelcifid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hotelcifid.Location = New System.Drawing.Point(490, 296)
        Me.hotelcifid.Name = "hotelcifid"
        Me.hotelcifid.Size = New System.Drawing.Size(75, 23)
        Me.hotelcifid.TabIndex = 403
        Me.hotelcifid.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator3, Me.txtFilter, Me.ToolStripSeparator1, Me.cmdPrint})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1055, 31)
        Me.ToolStrip3.TabIndex = 393
        Me.ToolStrip3.Text = "ToolStrip3"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'txtFilter
        '
        Me.txtFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFilter.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.txtFilter.Items.AddRange(New Object() {"ARRIVAL LIST", "GUEST LIST", "FORECAST SUMMARY", "OCCUPANCY FORECAST", "ROOM OCCUPANCY", "INHOUSE GUEST"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(221, 27)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
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
        'MyDataGridView
        '
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.MyDataGridView.Location = New System.Drawing.Point(7, 93)
        Me.MyDataGridView.MainView = Me.GridView1
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.MyDataGridView.Size = New System.Drawing.Size(1042, 518)
        Me.MyDataGridView.TabIndex = 823
        Me.MyDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.MyDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'frmHotelRoomOccupancy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1055, 614)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.hotelcifid)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelRoomOccupancy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Occupancy"
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents hotelcifid As System.Windows.Forms.TextBox
    Friend WithEvents txtFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHotel As System.Windows.Forms.ComboBox
    Friend WithEvents MyDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
