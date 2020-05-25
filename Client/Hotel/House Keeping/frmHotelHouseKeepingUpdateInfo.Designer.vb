<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelHouseKeepingUpdateInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelHouseKeepingUpdateInfo))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckMaintainance = New System.Windows.Forms.CheckBox()
        Me.ckAllowCheckin = New System.Windows.Forms.CheckBox()
        Me.ckupdateRoom = New System.Windows.Forms.CheckBox()
        Me.txtRoomStatus = New System.Windows.Forms.ComboBox()
        Me.roomstatus = New System.Windows.Forms.TextBox()
        Me.hotelcif = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckHouserKeeper = New System.Windows.Forms.CheckedListBox()
        Me.txtRemarks = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(191, 270)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 32)
        Me.cmdConfirm.TabIndex = 6
        Me.cmdConfirm.Text = "Update"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(132, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 400
        Me.Label2.Text = "Remarks"
        '
        'ckMaintainance
        '
        Me.ckMaintainance.AutoSize = True
        Me.ckMaintainance.Location = New System.Drawing.Point(504, 106)
        Me.ckMaintainance.Name = "ckMaintainance"
        Me.ckMaintainance.Size = New System.Drawing.Size(107, 17)
        Me.ckMaintainance.TabIndex = 479
        Me.ckMaintainance.Text = "ckMaintainance"
        Me.ckMaintainance.UseVisualStyleBackColor = True
        Me.ckMaintainance.Visible = False
        '
        'ckAllowCheckin
        '
        Me.ckAllowCheckin.AutoSize = True
        Me.ckAllowCheckin.Location = New System.Drawing.Point(504, 83)
        Me.ckAllowCheckin.Name = "ckAllowCheckin"
        Me.ckAllowCheckin.Size = New System.Drawing.Size(107, 17)
        Me.ckAllowCheckin.TabIndex = 478
        Me.ckAllowCheckin.Text = "ckAllowCheckin"
        Me.ckAllowCheckin.UseVisualStyleBackColor = True
        Me.ckAllowCheckin.Visible = False
        '
        'ckupdateRoom
        '
        Me.ckupdateRoom.AutoSize = True
        Me.ckupdateRoom.Location = New System.Drawing.Point(504, 60)
        Me.ckupdateRoom.Name = "ckupdateRoom"
        Me.ckupdateRoom.Size = New System.Drawing.Size(104, 17)
        Me.ckupdateRoom.TabIndex = 477
        Me.ckupdateRoom.Text = "ckupdateRoom"
        Me.ckupdateRoom.UseVisualStyleBackColor = True
        Me.ckupdateRoom.Visible = False
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
        Me.txtRoomStatus.Location = New System.Drawing.Point(239, 27)
        Me.txtRoomStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomStatus.MaxDropDownItems = 7
        Me.txtRoomStatus.Name = "txtRoomStatus"
        Me.txtRoomStatus.Size = New System.Drawing.Size(235, 23)
        Me.txtRoomStatus.TabIndex = 1
        '
        'roomstatus
        '
        Me.roomstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomstatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomstatus.ForeColor = System.Drawing.Color.Black
        Me.roomstatus.Location = New System.Drawing.Point(191, 27)
        Me.roomstatus.Margin = New System.Windows.Forms.Padding(5)
        Me.roomstatus.Name = "roomstatus"
        Me.roomstatus.ReadOnly = True
        Me.roomstatus.Size = New System.Drawing.Size(45, 23)
        Me.roomstatus.TabIndex = 476
        Me.roomstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hotelcif
        '
        Me.hotelcif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.hotelcif.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hotelcif.ForeColor = System.Drawing.Color.Black
        Me.hotelcif.Location = New System.Drawing.Point(504, 30)
        Me.hotelcif.Margin = New System.Windows.Forms.Padding(5)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Size = New System.Drawing.Size(73, 23)
        Me.hotelcif.TabIndex = 475
        Me.hotelcif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.hotelcif.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(66, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 15)
        Me.Label5.TabIndex = 467
        Me.Label5.Text = "Change Room Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(104, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 466
        Me.Label1.Text = "House Keeper"
        '
        'ckHouserKeeper
        '
        Me.ckHouserKeeper.CheckOnClick = True
        Me.ckHouserKeeper.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckHouserKeeper.FormattingEnabled = True
        Me.ckHouserKeeper.Location = New System.Drawing.Point(191, 82)
        Me.ckHouserKeeper.Name = "ckHouserKeeper"
        Me.ckHouserKeeper.Size = New System.Drawing.Size(283, 184)
        Me.ckHouserKeeper.TabIndex = 3
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRemarks.DropDownHeight = 130
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.FormattingEnabled = True
        Me.txtRemarks.IntegralHeight = False
        Me.txtRemarks.ItemHeight = 15
        Me.txtRemarks.Location = New System.Drawing.Point(191, 54)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.MaxDropDownItems = 7
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(283, 23)
        Me.txtRemarks.TabIndex = 2
        '
        'frmHotelHouseKeepingUpdateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(671, 329)
        Me.Controls.Add(Me.ckMaintainance)
        Me.Controls.Add(Me.ckAllowCheckin)
        Me.Controls.Add(Me.ckupdateRoom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRoomStatus)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.roomstatus)
        Me.Controls.Add(Me.hotelcif)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckHouserKeeper)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(687, 368)
        Me.Name = "frmHotelHouseKeepingUpdateInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "House Keeping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckHouserKeeper As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents hotelcif As System.Windows.Forms.TextBox
    Friend WithEvents roomstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ckMaintainance As System.Windows.Forms.CheckBox
    Friend WithEvents ckAllowCheckin As System.Windows.Forms.CheckBox
    Friend WithEvents ckupdateRoom As System.Windows.Forms.CheckBox
End Class
