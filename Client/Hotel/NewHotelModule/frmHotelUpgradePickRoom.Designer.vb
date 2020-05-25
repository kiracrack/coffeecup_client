<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelUpgradePickRoom
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelUpgradePickRoom))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.txtdateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(7, 62)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(744, 506)
        Me.MyDataGridView.TabIndex = 392
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(6, 19)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(732, 23)
        Me.txtsearch.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Command - Press F3 to enter command search | Press ENTER key to validate "
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(323, 263)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(168, 22)
        Me.txtDateArival.TabIndex = 394
        Me.txtDateArival.Visible = False
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdateCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateCheckout.Location = New System.Drawing.Point(323, 288)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.Size = New System.Drawing.Size(168, 22)
        Me.txtdateCheckout.TabIndex = 395
        Me.txtdateCheckout.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(449, 229)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(54, 22)
        Me.mode.TabIndex = 393
        Me.mode.Visible = False
        '
        'folioid
        '
        Me.folioid.Location = New System.Drawing.Point(389, 229)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(54, 22)
        Me.folioid.TabIndex = 396
        Me.folioid.Visible = False
        '
        'roomtype
        '
        Me.roomtype.Location = New System.Drawing.Point(323, 229)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(54, 22)
        Me.roomtype.TabIndex = 397
        Me.roomtype.Visible = False
        '
        'frmHotelPickRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(757, 572)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelPickRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room List"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
End Class
