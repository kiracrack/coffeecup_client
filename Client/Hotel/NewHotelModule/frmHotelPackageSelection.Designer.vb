<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelPackageSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelPackageSelection))
        Me.cmdRoomSelection = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdNewCheckinGuest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRoomTariff = New System.Windows.Forms.ToolStripButton()
        Me.lineViewUnprocessedRoom = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdTemporaryRoomLogs = New System.Windows.Forms.ToolStripButton()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdRoomSelection
        '
        Me.cmdRoomSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdRoomSelection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdRoomSelection.ForeColor = System.Drawing.Color.Black
        Me.cmdRoomSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRoomSelection.Location = New System.Drawing.Point(462, 413)
        Me.cmdRoomSelection.Name = "cmdRoomSelection"
        Me.cmdRoomSelection.Size = New System.Drawing.Size(195, 34)
        Me.cmdRoomSelection.TabIndex = 19
        Me.cmdRoomSelection.Text = "Proceed Room Selection"
        Me.cmdRoomSelection.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label20.Location = New System.Drawing.Point(11, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 20)
        Me.Label20.TabIndex = 466
        Me.Label20.Text = "Select Room Type"
        '
        'txtRoomType
        '
        Me.txtRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoomType.DropDownHeight = 130
        Me.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.FormattingEnabled = True
        Me.txtRoomType.IntegralHeight = False
        Me.txtRoomType.ItemHeight = 20
        Me.txtRoomType.Location = New System.Drawing.Point(13, 61)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomType.MaxDropDownItems = 7
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Size = New System.Drawing.Size(335, 28)
        Me.txtRoomType.TabIndex = 805
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 94)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(645, 302)
        Me.ListView1.TabIndex = 806
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'roomtype
        '
        Me.roomtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomtype.Location = New System.Drawing.Point(512, 156)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(70, 22)
        Me.roomtype.TabIndex = 827
        Me.roomtype.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewCheckinGuest, Me.ToolStripSeparator1, Me.cmdRoomTariff, Me.lineViewUnprocessedRoom, Me.cmdTemporaryRoomLogs})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(674, 31)
        Me.ToolStrip3.TabIndex = 830
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
        'cmdRoomTariff
        '
        Me.cmdRoomTariff.ForeColor = System.Drawing.Color.White
        Me.cmdRoomTariff.Image = Global.CoffeecupClient.My.Resources.Resources.folder_bookmark
        Me.cmdRoomTariff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRoomTariff.Name = "cmdRoomTariff"
        Me.cmdRoomTariff.Size = New System.Drawing.Size(163, 24)
        Me.cmdRoomTariff.Text = "Create or Update Package"
        '
        'lineViewUnprocessedRoom
        '
        Me.lineViewUnprocessedRoom.Name = "lineViewUnprocessedRoom"
        Me.lineViewUnprocessedRoom.Size = New System.Drawing.Size(6, 27)
        '
        'cmdTemporaryRoomLogs
        '
        Me.cmdTemporaryRoomLogs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTemporaryRoomLogs.ForeColor = System.Drawing.Color.Yellow
        Me.cmdTemporaryRoomLogs.Image = Global.CoffeecupClient.My.Resources.Resources.clipboard_list
        Me.cmdTemporaryRoomLogs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTemporaryRoomLogs.Name = "cmdTemporaryRoomLogs"
        Me.cmdTemporaryRoomLogs.Size = New System.Drawing.Size(171, 24)
        Me.cmdTemporaryRoomLogs.Text = "View Unprocessed Rooms"
        Me.cmdTemporaryRoomLogs.ToolTipText = "Please select exact date above to filter records"
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foliono.Location = New System.Drawing.Point(436, 156)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(70, 22)
        Me.foliono.TabIndex = 831
        Me.foliono.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(13, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 833
        Me.Label2.Text = "Coffeecup Update Note"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label1.Location = New System.Drawing.Point(13, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 37)
        Me.Label1.TabIndex = 832
        Me.Label1.Text = "Please check any of the package rates above before continue on room selection. th" & _
    "is will automatically duplicate from the standard package to be use in this foli" & _
    "o"
        '
        'guestid
        '
        Me.guestid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestid.Location = New System.Drawing.Point(360, 156)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(70, 22)
        Me.guestid.TabIndex = 834
        Me.guestid.Visible = False
        '
        'frmHotelRoomTypeSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(674, 467)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmdRoomSelection)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelRoomTypeSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Type Selection"
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdRoomSelection As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdNewCheckinGuest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRoomTariff As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineViewUnprocessedRoom As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdTemporaryRoomLogs As System.Windows.Forms.ToolStripButton
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guestid As System.Windows.Forms.TextBox
End Class
