<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovalHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApprovalHistory))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(720, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 30)
        Me.Button2.TabIndex = 361
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmdView
        '
        Me.cmdView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdView.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdView.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdView.Location = New System.Drawing.Point(537, 463)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(180, 30)
        Me.cmdView.TabIndex = 362
        Me.cmdView.Text = "View Details"
        Me.cmdView.UseVisualStyleBackColor = False
        '
        'ckasof
        '
        Me.ckasof.AutoSize = True
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(111, 38)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(107, 19)
        Me.ckasof.TabIndex = 369
        Me.ckasof.Text = "View all History"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(284, 12)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 22)
        Me.txttodate.TabIndex = 367
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 366
        Me.Label1.Text = "Date Filter From"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(111, 12)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 22)
        Me.txtfrmdate.TabIndex = 365
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(640, 32)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(260, 23)
        Me.txtsearch.TabIndex = 363
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(594, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 364
        Me.Label3.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(263, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 368
        Me.Label4.Text = "To"
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(436, 11)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 370
        Me.cmdlogin.UseVisualStyleBackColor = True
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
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(11, 62)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(889, 396)
        Me.MyDataGridView.TabIndex = 402
        '
        'frmApprovalHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(907, 498)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.ckasof)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfrmdate)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmApprovalHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Log History "
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
End Class
