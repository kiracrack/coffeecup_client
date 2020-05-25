<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelAddExtraNight
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.txtExtraNightCount = New System.Windows.Forms.TextBox()
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.currentCheckout = New System.Windows.Forms.DateTimePicker()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPackageRate = New System.Windows.Forms.TextBox()
        Me.txtRoomPackageRate = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPackage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        CType(Me.txtRoomPackageRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(34, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 437
        Me.Label13.Text = "Date Checkout"
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdateCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateCheckout.Location = New System.Drawing.Point(180, 25)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.Size = New System.Drawing.Size(165, 22)
        Me.txtdateCheckout.TabIndex = 14
        '
        'txtExtraNightCount
        '
        Me.txtExtraNightCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExtraNightCount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtExtraNightCount.ForeColor = System.Drawing.Color.Black
        Me.txtExtraNightCount.Location = New System.Drawing.Point(123, 25)
        Me.txtExtraNightCount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtExtraNightCount.Name = "txtExtraNightCount"
        Me.txtExtraNightCount.ReadOnly = True
        Me.txtExtraNightCount.Size = New System.Drawing.Size(55, 22)
        Me.txtExtraNightCount.TabIndex = 503
        Me.txtExtraNightCount.Text = "0"
        Me.txtExtraNightCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(200, 106)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(145, 34)
        Me.cmdProceed.TabIndex = 19
        Me.cmdProceed.Text = "Confirm"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'currentCheckout
        '
        Me.currentCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.currentCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.currentCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.currentCheckout.Location = New System.Drawing.Point(151, 228)
        Me.currentCheckout.Name = "currentCheckout"
        Me.currentCheckout.Size = New System.Drawing.Size(141, 22)
        Me.currentCheckout.TabIndex = 504
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(167, 197)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(57, 23)
        Me.folioid.TabIndex = 824
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.folioid.Visible = False
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(235, 197)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(57, 23)
        Me.foliono.TabIndex = 825
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(164, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 843
        Me.Label7.Text = "Rate"
        '
        'txtPackageRate
        '
        Me.txtPackageRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPackageRate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPackageRate.ForeColor = System.Drawing.Color.Black
        Me.txtPackageRate.Location = New System.Drawing.Point(200, 78)
        Me.txtPackageRate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPackageRate.Name = "txtPackageRate"
        Me.txtPackageRate.ReadOnly = True
        Me.txtPackageRate.Size = New System.Drawing.Size(145, 23)
        Me.txtPackageRate.TabIndex = 842
        Me.txtPackageRate.Text = "0.00"
        Me.txtPackageRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoomPackageRate
        '
        Me.txtRoomPackageRate.EditValue = ""
        Me.txtRoomPackageRate.Location = New System.Drawing.Point(123, 52)
        Me.txtRoomPackageRate.Name = "txtRoomPackageRate"
        Me.txtRoomPackageRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomPackageRate.Properties.Appearance.Options.UseFont = True
        Me.txtRoomPackageRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRoomPackageRate.Properties.DisplayMember = "Package"
        Me.txtRoomPackageRate.Properties.NullText = ""
        Me.txtRoomPackageRate.Properties.PopupView = Me.gridPackage
        Me.txtRoomPackageRate.Properties.ValueMember = "ratecode"
        Me.txtRoomPackageRate.Size = New System.Drawing.Size(222, 22)
        Me.txtRoomPackageRate.TabIndex = 841
        '
        'gridPackage
        '
        Me.gridPackage.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPackage.Name = "gridPackage"
        Me.gridPackage.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPackage.OptionsView.ShowGroupPanel = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(66, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 840
        Me.Label6.Text = "Package"
        '
        'rateid
        '
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rateid.ForeColor = System.Drawing.Color.Black
        Me.rateid.Location = New System.Drawing.Point(100, 197)
        Me.rateid.Margin = New System.Windows.Forms.Padding(5)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(57, 23)
        Me.rateid.TabIndex = 844
        Me.rateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rateid.Visible = False
        '
        'roomtype
        '
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(37, 197)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(57, 23)
        Me.roomtype.TabIndex = 845
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtype.Visible = False
        '
        'frmHotelAddExtraNight
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(373, 163)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.rateid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPackageRate)
        Me.Controls.Add(Me.txtRoomPackageRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.currentCheckout)
        Me.Controls.Add(Me.txtExtraNightCount)
        Me.Controls.Add(Me.cmdProceed)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelAddExtraNight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extra Night"
        CType(Me.txtRoomPackageRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPackage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtExtraNightCount As System.Windows.Forms.TextBox
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents currentCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPackageRate As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomPackageRate As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPackage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rateid As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
End Class
