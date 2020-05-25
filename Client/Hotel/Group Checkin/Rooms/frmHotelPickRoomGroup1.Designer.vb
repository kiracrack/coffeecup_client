<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelPickRoomGroup1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelPickRoomGroup1))
        Me.hotelcif = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.MyDataGridView_room = New System.Windows.Forms.DataGridView()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.txtRoomType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.MyDataGridView_room, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hotelcif
        '
        Me.hotelcif.Location = New System.Drawing.Point(449, 231)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Size = New System.Drawing.Size(54, 22)
        Me.hotelcif.TabIndex = 393
        Me.hotelcif.Visible = False
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(471, 495)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(163, 34)
        Me.cmdConfirmPayment.TabIndex = 698
        Me.cmdConfirmPayment.Text = "Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'MyDataGridView_room
        '
        Me.MyDataGridView_room.AllowUserToAddRows = False
        Me.MyDataGridView_room.AllowUserToDeleteRows = False
        Me.MyDataGridView_room.AllowUserToResizeRows = False
        Me.MyDataGridView_room.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_room.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_room.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_room.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_room.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_room.Location = New System.Drawing.Point(9, 91)
        Me.MyDataGridView_room.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_room.MultiSelect = False
        Me.MyDataGridView_room.Name = "MyDataGridView_room"
        Me.MyDataGridView_room.RowHeadersVisible = False
        Me.MyDataGridView_room.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_room.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MyDataGridView_room.Size = New System.Drawing.Size(1098, 397)
        Me.MyDataGridView_room.TabIndex = 760
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(509, 231)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(54, 22)
        Me.mode.TabIndex = 761
        Me.mode.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(14, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 801
        Me.Label10.Text = "Search Room Type"
        '
        'roomtype
        '
        Me.roomtype.Location = New System.Drawing.Point(569, 228)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(54, 22)
        Me.roomtype.TabIndex = 802
        Me.roomtype.Visible = False
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
        Me.txtRoomType.Location = New System.Drawing.Point(120, 13)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomType.MaxDropDownItems = 7
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Size = New System.Drawing.Size(220, 21)
        Me.txtRoomType.TabIndex = 803
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(55, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 807
        Me.Label14.Text = "Departure"
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdateCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateCheckout.Location = New System.Drawing.Point(120, 62)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.Size = New System.Drawing.Size(220, 22)
        Me.txtdateCheckout.TabIndex = 805
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(79, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 806
        Me.Label13.Text = "Arival"
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(120, 37)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(220, 22)
        Me.txtDateArival.TabIndex = 804
        '
        'BackgroundWorker1
        '
        '
        'frmHotelPickRoomGroup1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1117, 535)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.MyDataGridView_room)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.hotelcif)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelPickRoomGroup1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Available Rooms"
        CType(Me.MyDataGridView_room, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hotelcif As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView_room As System.Windows.Forms.DataGridView
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
