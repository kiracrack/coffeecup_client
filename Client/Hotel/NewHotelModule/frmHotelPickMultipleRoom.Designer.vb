<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelPickMultipleRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelPickMultipleRoom))
        Me.hotelcif = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.MyDataGridView_room = New System.Windows.Forms.DataGridView()
        Me.cmd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.ckChangeDate = New System.Windows.Forms.CheckBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdNewCheckinGuest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView_room, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'hotelcif
        '
        Me.hotelcif.Location = New System.Drawing.Point(449, 229)
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
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(412, 518)
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
        Me.MyDataGridView_room.ContextMenuStrip = Me.cmd
        Me.MyDataGridView_room.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_room.Location = New System.Drawing.Point(9, 87)
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
        Me.MyDataGridView_room.Size = New System.Drawing.Size(979, 424)
        Me.MyDataGridView_room.TabIndex = 760
        '
        'cmd
        '
        Me.cmd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmd.Name = "ContextMenuStrip1"
        Me.cmd.Size = New System.Drawing.Size(186, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.Money_Hot1
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ToolStripMenuItem1.Text = "Multiple Rate Update"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(509, 229)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(54, 22)
        Me.mode.TabIndex = 761
        Me.mode.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label10.Location = New System.Drawing.Point(8, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 801
        Me.Label10.Text = "Search Room Type"
        '
        'roomtype
        '
        Me.roomtype.Location = New System.Drawing.Point(569, 229)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(54, 22)
        Me.roomtype.TabIndex = 802
        Me.roomtype.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label14.Location = New System.Drawing.Point(460, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 17)
        Me.Label14.TabIndex = 811
        Me.Label14.Text = "Departure Date"
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtdateCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateCheckout.Location = New System.Drawing.Point(460, 58)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.Size = New System.Drawing.Size(220, 24)
        Me.txtdateCheckout.TabIndex = 809
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label13.Location = New System.Drawing.Point(236, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 17)
        Me.Label13.TabIndex = 810
        Me.Label13.Text = "Arrival Date"
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(235, 58)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(220, 24)
        Me.txtDateArival.TabIndex = 808
        '
        'BackgroundWorker1
        '
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foliono.Location = New System.Drawing.Point(58, 197)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(70, 22)
        Me.foliono.TabIndex = 826
        Me.foliono.Visible = False
        '
        'ckChangeDate
        '
        Me.ckChangeDate.AutoSize = True
        Me.ckChangeDate.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.ckChangeDate.Location = New System.Drawing.Point(686, 60)
        Me.ckChangeDate.Name = "ckChangeDate"
        Me.ckChangeDate.Size = New System.Drawing.Size(206, 19)
        Me.ckChangeDate.TabIndex = 827
        Me.ckChangeDate.Text = "Change Date for Current Selection"
        Me.ckChangeDate.UseVisualStyleBackColor = True
        '
        'guestid
        '
        Me.guestid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestid.Location = New System.Drawing.Point(134, 197)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(70, 22)
        Me.guestid.TabIndex = 828
        Me.guestid.Visible = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblCount.Location = New System.Drawing.Point(11, 516)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 17)
        Me.lblCount.TabIndex = 830
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewCheckinGuest, Me.ToolStripSeparator1})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(999, 31)
        Me.ToolStrip3.TabIndex = 829
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdNewCheckinGuest
        '
        Me.cmdNewCheckinGuest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCheckinGuest.ForeColor = System.Drawing.Color.White
        Me.cmdNewCheckinGuest.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdNewCheckinGuest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewCheckinGuest.Name = "cmdNewCheckinGuest"
        Me.cmdNewCheckinGuest.Size = New System.Drawing.Size(105, 24)
        Me.cmdNewCheckinGuest.Text = "Close Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'txtRoomType
        '
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.Location = New System.Drawing.Point(9, 58)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(223, 24)
        Me.txtRoomType.TabIndex = 831
        '
        'frmHotelPickMultipleRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(999, 560)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.ckChangeDate)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.MyDataGridView_room)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.hotelcif)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelPickMultipleRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Available Rooms"
        CType(Me.MyDataGridView_room, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hotelcif As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView_room As System.Windows.Forms.DataGridView
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents ckChangeDate As System.Windows.Forms.CheckBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents cmd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents cmdNewCheckinGuest As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblCount As Label
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
End Class
