<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelGuestPreviousTransaction
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabRoomInfo = New System.Windows.Forms.TabPage()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Room = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabPOSTransaction = New System.Windows.Forms.TabPage()
        Me.Em_POS = New DevExpress.XtraGrid.GridControl()
        Me.GridView_POS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.TabControl1.SuspendLayout()
        Me.tabRoomInfo.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPOSTransaction.SuspendLayout()
        CType(Me.Em_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabRoomInfo)
        Me.TabControl1.Controls.Add(Me.tabPOSTransaction)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(824, 396)
        Me.TabControl1.TabIndex = 821
        '
        'tabRoomInfo
        '
        Me.tabRoomInfo.Controls.Add(Me.guestid)
        Me.tabRoomInfo.Controls.Add(Me.Em)
        Me.tabRoomInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.tabRoomInfo.Location = New System.Drawing.Point(4, 26)
        Me.tabRoomInfo.Name = "tabRoomInfo"
        Me.tabRoomInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRoomInfo.Size = New System.Drawing.Size(816, 366)
        Me.tabRoomInfo.TabIndex = 0
        Me.tabRoomInfo.Text = "Room Charge Information"
        Me.tabRoomInfo.UseVisualStyleBackColor = True
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(887, 98)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(55, 23)
        Me.guestid.TabIndex = 824
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(3, 3)
        Me.Em.MainView = Me.GridView_Room
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(810, 360)
        Me.Em.TabIndex = 820
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Room})
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
        'tabPOSTransaction
        '
        Me.tabPOSTransaction.Controls.Add(Me.Em_POS)
        Me.tabPOSTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPOSTransaction.Location = New System.Drawing.Point(4, 26)
        Me.tabPOSTransaction.Name = "tabPOSTransaction"
        Me.tabPOSTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPOSTransaction.Size = New System.Drawing.Size(816, 366)
        Me.tabPOSTransaction.TabIndex = 6
        Me.tabPOSTransaction.Text = "POS / Other Charges "
        Me.tabPOSTransaction.UseVisualStyleBackColor = True
        '
        'Em_POS
        '
        Me.Em_POS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_POS.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_POS.Location = New System.Drawing.Point(3, 3)
        Me.Em_POS.MainView = Me.GridView_POS
        Me.Em_POS.Name = "Em_POS"
        Me.Em_POS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.Em_POS.Size = New System.Drawing.Size(810, 360)
        Me.Em_POS.TabIndex = 822
        Me.Em_POS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_POS})
        '
        'GridView_POS
        '
        Me.GridView_POS.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_POS.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_POS.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_POS.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_POS.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_POS.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.Row.Options.UseFont = True
        Me.GridView_POS.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_POS.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_POS.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_POS.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_POS.GridControl = Me.Em_POS
        Me.GridView_POS.Name = "GridView_POS"
        Me.GridView_POS.OptionsBehavior.Editable = False
        Me.GridView_POS.OptionsSelection.MultiSelect = True
        Me.GridView_POS.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_POS.OptionsView.ColumnAutoWidth = False
        Me.GridView_POS.OptionsView.RowAutoHeight = True
        Me.GridView_POS.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'frmHotelGuestPreviousTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 396)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelGuestPreviousTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Top 10 Previous Transaction"
        Me.TabControl1.ResumeLayout(False)
        Me.tabRoomInfo.ResumeLayout(False)
        Me.tabRoomInfo.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPOSTransaction.ResumeLayout(False)
        CType(Me.Em_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRoomInfo As System.Windows.Forms.TabPage
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Room As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents tabPOSTransaction As System.Windows.Forms.TabPage
    Friend WithEvents Em_POS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_POS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

End Class
