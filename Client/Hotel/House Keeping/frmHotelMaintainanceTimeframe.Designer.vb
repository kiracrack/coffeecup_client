<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelMaintainanceTimeframe
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
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoomDetails = New System.Windows.Forms.TextBox()
        Me.roomid = New System.Windows.Forms.TextBox()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.txtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtRoomStatus = New System.Windows.Forms.ComboBox()
        Me.roomstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.hotelcif = New System.Windows.Forms.TextBox()
        Me.hotelname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(152, 236)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(139, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Save Timeframe"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Room Details"
        '
        'txtRoomDetails
        '
        Me.txtRoomDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRoomDetails.ForeColor = System.Drawing.Color.Black
        Me.txtRoomDetails.Location = New System.Drawing.Point(176, 13)
        Me.txtRoomDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomDetails.Name = "txtRoomDetails"
        Me.txtRoomDetails.ReadOnly = True
        Me.txtRoomDetails.Size = New System.Drawing.Size(216, 25)
        Me.txtRoomDetails.TabIndex = 411
        Me.txtRoomDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'roomid
        '
        Me.roomid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.roomid.ForeColor = System.Drawing.Color.Black
        Me.roomid.Location = New System.Drawing.Point(397, 248)
        Me.roomid.Margin = New System.Windows.Forms.Padding(5)
        Me.roomid.Name = "roomid"
        Me.roomid.Size = New System.Drawing.Size(38, 22)
        Me.roomid.TabIndex = 410
        Me.roomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomid.Visible = False
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRoomNumber.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNumber.Location = New System.Drawing.Point(111, 13)
        Me.txtRoomNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(61, 25)
        Me.txtRoomNumber.TabIndex = 412
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDateFrom.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.txtDateFrom.CustomFormat = "MMMM dd, yyyy hh:mm tt"
        Me.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateFrom.Location = New System.Drawing.Point(111, 41)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(281, 23)
        Me.txtDateFrom.TabIndex = 413
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(29, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 414
        Me.Label2.Text = "Starting Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 416
        Me.Label3.Text = "Ending Date"
        '
        'txtDateTo
        '
        Me.txtDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDateTo.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.txtDateTo.CustomFormat = "MMMM dd, yyyy hh:mm tt"
        Me.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTo.Location = New System.Drawing.Point(111, 67)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(281, 23)
        Me.txtDateTo.TabIndex = 415
        '
        'txtRoomStatus
        '
        Me.txtRoomStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRoomStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoomStatus.DropDownHeight = 130
        Me.txtRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomStatus.ForeColor = System.Drawing.Color.Black
        Me.txtRoomStatus.FormattingEnabled = True
        Me.txtRoomStatus.IntegralHeight = False
        Me.txtRoomStatus.ItemHeight = 15
        Me.txtRoomStatus.Location = New System.Drawing.Point(176, 94)
        Me.txtRoomStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomStatus.MaxDropDownItems = 7
        Me.txtRoomStatus.Name = "txtRoomStatus"
        Me.txtRoomStatus.Size = New System.Drawing.Size(216, 23)
        Me.txtRoomStatus.TabIndex = 477
        '
        'roomstatus
        '
        Me.roomstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomstatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomstatus.ForeColor = System.Drawing.Color.Black
        Me.roomstatus.Location = New System.Drawing.Point(111, 94)
        Me.roomstatus.Margin = New System.Windows.Forms.Padding(5)
        Me.roomstatus.Name = "roomstatus"
        Me.roomstatus.ReadOnly = True
        Me.roomstatus.Size = New System.Drawing.Size(61, 23)
        Me.roomstatus.TabIndex = 479
        Me.roomstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(29, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 478
        Me.Label5.Text = "Room Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(62, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 15)
        Me.Label10.TabIndex = 812
        Me.Label10.Text = "Room Maintainace Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(64, 147)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(328, 81)
        Me.txtRemarks.TabIndex = 811
        '
        'hotelcif
        '
        Me.hotelcif.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.hotelcif.ForeColor = System.Drawing.Color.Black
        Me.hotelcif.Location = New System.Drawing.Point(362, 249)
        Me.hotelcif.Margin = New System.Windows.Forms.Padding(5)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Size = New System.Drawing.Size(38, 22)
        Me.hotelcif.TabIndex = 813
        Me.hotelcif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.hotelcif.Visible = False
        '
        'hotelname
        '
        Me.hotelname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.hotelname.ForeColor = System.Drawing.Color.Black
        Me.hotelname.Location = New System.Drawing.Point(322, 249)
        Me.hotelname.Margin = New System.Windows.Forms.Padding(5)
        Me.hotelname.Name = "hotelname"
        Me.hotelname.Size = New System.Drawing.Size(38, 22)
        Me.hotelname.TabIndex = 814
        Me.hotelname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.hotelname.Visible = False
        '
        'frmHotelMaintainanceTimeframe
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(439, 285)
        Me.Controls.Add(Me.hotelname)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtRoomStatus)
        Me.Controls.Add(Me.roomstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.txtRoomDetails)
        Me.Controls.Add(Me.roomid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmHotelMaintainanceTimeframe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Maintainance Timeframe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoomDetails As System.Windows.Forms.TextBox
    Friend WithEvents roomid As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRoomStatus As System.Windows.Forms.ComboBox
    Friend WithEvents roomstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents hotelcif As System.Windows.Forms.TextBox
    Friend WithEvents hotelname As System.Windows.Forms.TextBox
End Class
