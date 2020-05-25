<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvanceSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvanceSearch))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearchOption = New System.Windows.Forms.ComboBox()
        Me.lblcontactperson = New System.Windows.Forms.Label()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(65, 40)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(446, 35)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to search through online product list, current request a" & _
    "pproval etc.."
        Me.lbldescription.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(7, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(518, 15)
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
        Me.lbltitle.Location = New System.Drawing.Point(63, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(108, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Advance Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtSearchOption)
        Me.GroupBox1.Controls.Add(Me.lblcontactperson)
        Me.GroupBox1.Controls.Add(Me.txtfilter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.picicon)
        Me.GroupBox1.Controls.Add(Me.lbltitle)
        Me.GroupBox1.Controls.Add(Me.lbldescription)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 139)
        Me.GroupBox1.TabIndex = 337
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advance Search"
        '
        'txtSearchOption
        '
        Me.txtSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSearchOption.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSearchOption.ForeColor = System.Drawing.Color.Black
        Me.txtSearchOption.FormattingEnabled = True
        Me.txtSearchOption.ItemHeight = 13
        Me.txtSearchOption.Items.AddRange(New Object() {"Particular Item", "Request Status"})
        Me.txtSearchOption.Location = New System.Drawing.Point(106, 108)
        Me.txtSearchOption.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchOption.Name = "txtSearchOption"
        Me.txtSearchOption.Size = New System.Drawing.Size(226, 21)
        Me.txtSearchOption.TabIndex = 353
        '
        'lblcontactperson
        '
        Me.lblcontactperson.AutoSize = True
        Me.lblcontactperson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcontactperson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcontactperson.Location = New System.Drawing.Point(20, 110)
        Me.lblcontactperson.Name = "lblcontactperson"
        Me.lblcontactperson.Size = New System.Drawing.Size(82, 15)
        Me.lblcontactperson.TabIndex = 354
        Me.lblcontactperson.Text = "Search Option"
        '
        'txtfilter
        '
        Me.txtfilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfilter.Location = New System.Drawing.Point(106, 81)
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(411, 23)
        Me.txtfilter.TabIndex = 337
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Search Keyworks"
        '
        'MyDataGridView
        '
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
        Me.MyDataGridView.Location = New System.Drawing.Point(7, 149)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(524, 360)
        Me.MyDataGridView.TabIndex = 342
        '
        'picicon
        '
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 19)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(54, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'frmAdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(539, 516)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdvanceSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchOption As System.Windows.Forms.ComboBox
    Friend WithEvents lblcontactperson As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
End Class
