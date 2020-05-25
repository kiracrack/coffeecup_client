<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomAvailability
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cmd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Room = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.txtdateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdEditGuest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd.SuspendLayout()
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cmd
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 110)
        Me.Em.MainView = Me.GridView_Room
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(544, 352)
        Me.Em.TabIndex = 820
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Room})
        '
        'cmd
        '
        Me.cmd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmd.Name = "ContextMenuStrip1"
        Me.cmd.Size = New System.Drawing.Size(189, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.calendar_blue
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem1.Text = "Show Room Calendar"
        '
        'GridView_Room
        '
        Me.GridView_Room.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Room.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Room.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Room.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Room.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Room.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.Row.Options.UseFont = True
        Me.GridView_Room.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Room.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Room.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Room.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Room.GridControl = Me.Em
        Me.GridView_Room.Name = "GridView_Room"
        Me.GridView_Room.OptionsBehavior.Editable = False
        Me.GridView_Room.OptionsSelection.MultiSelect = True
        Me.GridView_Room.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Room.OptionsView.ColumnAutoWidth = False
        Me.GridView_Room.OptionsView.RowAutoHeight = True
        Me.GridView_Room.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(29, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 822
        Me.Label8.Text = "Select Date Arrival"
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(135, 12)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(155, 22)
        Me.txtDateArival.TabIndex = 821
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdateCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateCheckout.Location = New System.Drawing.Point(135, 37)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.Size = New System.Drawing.Size(155, 22)
        Me.txtdateCheckout.TabIndex = 823
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 824
        Me.Label1.Text = "Select Date Departure"
        '
        'cmdEditGuest
        '
        Me.cmdEditGuest.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_1
        Me.cmdEditGuest.Location = New System.Drawing.Point(295, 12)
        Me.cmdEditGuest.Name = "cmdEditGuest"
        Me.cmdEditGuest.Size = New System.Drawing.Size(37, 47)
        Me.cmdEditGuest.TabIndex = 825
        Me.cmdEditGuest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 13)
        Me.Label2.TabIndex = 826
        Me.Label2.Text = "Right click on specific room type to view vacant rooms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(473, 13)
        Me.Label3.TabIndex = 827
        Me.Label3.Text = "Note: This widll be accurate if reserved guest is already assigned to a specific " & _
    "room number"
        '
        'frmHotelRoomAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdEditGuest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.Em)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelRoomAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Availability"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd.ResumeLayout(False)
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Room As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdEditGuest As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
