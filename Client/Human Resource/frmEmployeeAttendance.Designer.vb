<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeAttendance))
        Me.employeeid = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.payrollcode = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pic_morning_1 = New System.Windows.Forms.PictureBox()
        Me.pic_overtime_2 = New System.Windows.Forms.PictureBox()
        Me.pic_morning_2 = New System.Windows.Forms.PictureBox()
        Me.pic_overtime_1 = New System.Windows.Forms.PictureBox()
        Me.pic_afternoon_1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_afternoon_2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pic_morning_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_overtime_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_morning_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_overtime_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_afternoon_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_afternoon_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employeeid
        '
        Me.employeeid.Location = New System.Drawing.Point(744, 569)
        Me.employeeid.Name = "employeeid"
        Me.employeeid.Size = New System.Drawing.Size(54, 22)
        Me.employeeid.TabIndex = 393
        Me.employeeid.Visible = False
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(570, 524)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(163, 34)
        Me.cmdConfirmPayment.TabIndex = 698
        Me.cmdConfirmPayment.Text = "Confirm Overide"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(890, 513)
        Me.MyDataGridView.TabIndex = 760
        '
        'payrollcode
        '
        Me.payrollcode.Location = New System.Drawing.Point(684, 567)
        Me.payrollcode.Name = "payrollcode"
        Me.payrollcode.Size = New System.Drawing.Size(54, 22)
        Me.payrollcode.TabIndex = 761
        Me.payrollcode.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MyDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_morning_1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_overtime_2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_morning_2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_overtime_1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_afternoon_1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_afternoon_2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1106, 513)
        Me.SplitContainer1.SplitterDistance = 890
        Me.SplitContainer1.TabIndex = 762
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(7, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 17)
        Me.Label4.TabIndex = 399
        Me.Label4.Text = "Morning Session"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 17)
        Me.Label2.TabIndex = 405
        Me.Label2.Text = "Overtime Session"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic_morning_1
        '
        Me.pic_morning_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_morning_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_morning_1.Location = New System.Drawing.Point(10, 24)
        Me.pic_morning_1.Name = "pic_morning_1"
        Me.pic_morning_1.Size = New System.Drawing.Size(93, 81)
        Me.pic_morning_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_morning_1.TabIndex = 397
        Me.pic_morning_1.TabStop = False
        '
        'pic_overtime_2
        '
        Me.pic_overtime_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_overtime_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_overtime_2.Location = New System.Drawing.Point(109, 248)
        Me.pic_overtime_2.Name = "pic_overtime_2"
        Me.pic_overtime_2.Size = New System.Drawing.Size(93, 81)
        Me.pic_overtime_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_overtime_2.TabIndex = 404
        Me.pic_overtime_2.TabStop = False
        '
        'pic_morning_2
        '
        Me.pic_morning_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_morning_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_morning_2.Location = New System.Drawing.Point(109, 24)
        Me.pic_morning_2.Name = "pic_morning_2"
        Me.pic_morning_2.Size = New System.Drawing.Size(93, 81)
        Me.pic_morning_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_morning_2.TabIndex = 398
        Me.pic_morning_2.TabStop = False
        '
        'pic_overtime_1
        '
        Me.pic_overtime_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_overtime_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_overtime_1.Location = New System.Drawing.Point(10, 248)
        Me.pic_overtime_1.Name = "pic_overtime_1"
        Me.pic_overtime_1.Size = New System.Drawing.Size(93, 81)
        Me.pic_overtime_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_overtime_1.TabIndex = 403
        Me.pic_overtime_1.TabStop = False
        '
        'pic_afternoon_1
        '
        Me.pic_afternoon_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_afternoon_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_afternoon_1.Location = New System.Drawing.Point(10, 135)
        Me.pic_afternoon_1.Name = "pic_afternoon_1"
        Me.pic_afternoon_1.Size = New System.Drawing.Size(93, 81)
        Me.pic_afternoon_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_afternoon_1.TabIndex = 400
        Me.pic_afternoon_1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 17)
        Me.Label1.TabIndex = 402
        Me.Label1.Text = "Afternoon Session"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic_afternoon_2
        '
        Me.pic_afternoon_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_afternoon_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_afternoon_2.Location = New System.Drawing.Point(109, 135)
        Me.pic_afternoon_2.Name = "pic_afternoon_2"
        Me.pic_afternoon_2.Size = New System.Drawing.Size(93, 81)
        Me.pic_afternoon_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_afternoon_2.TabIndex = 401
        Me.pic_afternoon_2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(550, 41)
        Me.Label3.TabIndex = 763
        Me.Label3.Text = "NOTE: This approval form is limited due to restriction of accounting office. Plea" & _
    "se fill in or state in the remarks field your explanation each login descripanci" & _
    "es"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(736, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 34)
        Me.Button1.TabIndex = 764
        Me.Button1.Text = "Close Form"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmEmployeeAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1115, 568)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.payrollcode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.employeeid)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmployeeAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pic_morning_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_overtime_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_morning_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_overtime_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_afternoon_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_afternoon_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeid As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents payrollcode As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pic_morning_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_overtime_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_morning_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_overtime_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_afternoon_1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic_afternoon_2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
