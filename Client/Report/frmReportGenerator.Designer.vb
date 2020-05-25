<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportGenerator))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.date_to = New System.Windows.Forms.DateTimePicker()
        Me.date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReportType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReportName = New System.Windows.Forms.ComboBox()
        Me.ckDateQuery = New System.Windows.Forms.CheckBox()
        Me.reportype = New System.Windows.Forms.TextBox()
        Me.txtquery = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cms_em.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ToolStripSeparator2, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(151, 54)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(150, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator3, Me.cmdPrint, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(861, 31)
        Me.ToolStrip3.TabIndex = 352
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
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(90, 24)
        Me.cmdPrint.Text = "Print Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(103, 24)
        Me.ToolStripButton1.Text = "Export to Excel"
        '
        'date_to
        '
        Me.date_to.CustomFormat = "MMMM dd, yyyy"
        Me.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_to.Location = New System.Drawing.Point(295, 85)
        Me.date_to.Name = "date_to"
        Me.date_to.Size = New System.Drawing.Size(150, 22)
        Me.date_to.TabIndex = 3
        '
        'date_from
        '
        Me.date_from.CustomFormat = "MMMM dd, yyyy"
        Me.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_from.Location = New System.Drawing.Point(122, 85)
        Me.date_from.Name = "date_from"
        Me.date_from.Size = New System.Drawing.Size(150, 22)
        Me.date_from.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(274, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Date Period From"
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(448, 84)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 4
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(48, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 812
        Me.Label7.Text = "Report Type"
        '
        'txtReportType
        '
        Me.txtReportType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtReportType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtReportType.DropDownHeight = 130
        Me.txtReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtReportType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtReportType.ForeColor = System.Drawing.Color.Black
        Me.txtReportType.FormattingEnabled = True
        Me.txtReportType.IntegralHeight = False
        Me.txtReportType.ItemHeight = 13
        Me.txtReportType.Location = New System.Drawing.Point(122, 35)
        Me.txtReportType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReportType.MaxDropDownItems = 7
        Me.txtReportType.Name = "txtReportType"
        Me.txtReportType.Size = New System.Drawing.Size(172, 21)
        Me.txtReportType.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 814
        Me.Label2.Text = "Report Name"
        '
        'txtReportName
        '
        Me.txtReportName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtReportName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtReportName.DropDownHeight = 130
        Me.txtReportName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtReportName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtReportName.ForeColor = System.Drawing.Color.Black
        Me.txtReportName.FormattingEnabled = True
        Me.txtReportName.IntegralHeight = False
        Me.txtReportName.ItemHeight = 13
        Me.txtReportName.Location = New System.Drawing.Point(122, 60)
        Me.txtReportName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReportName.MaxDropDownItems = 7
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(323, 21)
        Me.txtReportName.TabIndex = 1
        '
        'ckDateQuery
        '
        Me.ckDateQuery.AutoSize = True
        Me.ckDateQuery.Location = New System.Drawing.Point(677, 39)
        Me.ckDateQuery.Name = "ckDateQuery"
        Me.ckDateQuery.Size = New System.Drawing.Size(82, 17)
        Me.ckDateQuery.TabIndex = 816
        Me.ckDateQuery.Text = "CheckBox1"
        Me.ckDateQuery.UseVisualStyleBackColor = True
        Me.ckDateQuery.Visible = False
        '
        'reportype
        '
        Me.reportype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.reportype.ForeColor = System.Drawing.Color.Black
        Me.reportype.Location = New System.Drawing.Point(586, 124)
        Me.reportype.Margin = New System.Windows.Forms.Padding(4)
        Me.reportype.Name = "reportype"
        Me.reportype.ReadOnly = True
        Me.reportype.Size = New System.Drawing.Size(68, 22)
        Me.reportype.TabIndex = 350
        Me.reportype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.reportype.Visible = False
        '
        'txtquery
        '
        Me.txtquery.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtquery.ForeColor = System.Drawing.Color.Black
        Me.txtquery.Location = New System.Drawing.Point(586, 154)
        Me.txtquery.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquery.Name = "txtquery"
        Me.txtquery.ReadOnly = True
        Me.txtquery.Size = New System.Drawing.Size(68, 22)
        Me.txtquery.TabIndex = 358
        Me.txtquery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtquery.Visible = False
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(586, 184)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(68, 22)
        Me.id.TabIndex = 815
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.id.Visible = False
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(0, 115)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(861, 342)
        Me.Em.TabIndex = 817
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.Em
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsView.ColumnAutoWidth = False
        Me.gridview1.OptionsView.RowAutoHeight = True
        '
        'frmReportGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(861, 458)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.ckDateQuery)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReportName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReportType)
        Me.Controls.Add(Me.txtquery)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.date_to)
        Me.Controls.Add(Me.date_from)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.reportype)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Generator"
        Me.cms_em.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReportName As System.Windows.Forms.ComboBox
    Friend WithEvents ckDateQuery As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents reportype As System.Windows.Forms.TextBox
    Friend WithEvents txtquery As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
