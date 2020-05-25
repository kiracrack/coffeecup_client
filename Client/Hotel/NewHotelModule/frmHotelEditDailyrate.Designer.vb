<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelEditDailyrate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelEditDailyrate))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtPax = New System.Windows.Forms.TextBox()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChild = New System.Windows.Forms.TextBox()
        Me.txtExtra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.txtRoomPackageRate = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPackage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPackageRate = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        CType(Me.txtRoomPackageRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(226, 180)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(145, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtPax
        '
        Me.txtPax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPax.ForeColor = System.Drawing.Color.Black
        Me.txtPax.Location = New System.Drawing.Point(268, 50)
        Me.txtPax.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPax.Name = "txtPax"
        Me.txtPax.Size = New System.Drawing.Size(103, 23)
        Me.txtPax.TabIndex = 0
        Me.txtPax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'folioid
        '
        Me.folioid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(127, 300)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(59, 23)
        Me.folioid.TabIndex = 827
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(65, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 828
        Me.Label1.Text = "Selected Date"
        '
        'txtChild
        '
        Me.txtChild.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChild.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChild.ForeColor = System.Drawing.Color.Black
        Me.txtChild.Location = New System.Drawing.Point(268, 76)
        Me.txtChild.Margin = New System.Windows.Forms.Padding(5)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(103, 23)
        Me.txtChild.TabIndex = 830
        Me.txtChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExtra
        '
        Me.txtExtra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExtra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtExtra.ForeColor = System.Drawing.Color.Black
        Me.txtExtra.Location = New System.Drawing.Point(268, 102)
        Me.txtExtra.Margin = New System.Windows.Forms.Padding(5)
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Size = New System.Drawing.Size(103, 23)
        Me.txtExtra.TabIndex = 831
        Me.txtExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(223, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 832
        Me.Label3.Text = "Adult"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(224, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 833
        Me.Label4.Text = "Child"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(188, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 834
        Me.Label5.Text = "Extra Person"
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(196, 300)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(59, 23)
        Me.foliono.TabIndex = 835
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomPackageRate
        '
        Me.txtRoomPackageRate.EditValue = ""
        Me.txtRoomPackageRate.Location = New System.Drawing.Point(149, 128)
        Me.txtRoomPackageRate.Name = "txtRoomPackageRate"
        Me.txtRoomPackageRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomPackageRate.Properties.Appearance.Options.UseFont = True
        Me.txtRoomPackageRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRoomPackageRate.Properties.DisplayMember = "Package"
        Me.txtRoomPackageRate.Properties.NullText = ""
        Me.txtRoomPackageRate.Properties.PopupView = Me.gridPackage
        Me.txtRoomPackageRate.Properties.ValueMember = "ratecode"
        Me.txtRoomPackageRate.Size = New System.Drawing.Size(222, 22)
        Me.txtRoomPackageRate.TabIndex = 837
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
        Me.Label6.Location = New System.Drawing.Point(92, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 836
        Me.Label6.Text = "Package"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(190, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 839
        Me.Label7.Text = "Rate"
        '
        'txtPackageRate
        '
        Me.txtPackageRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPackageRate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPackageRate.ForeColor = System.Drawing.Color.Black
        Me.txtPackageRate.Location = New System.Drawing.Point(226, 154)
        Me.txtPackageRate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPackageRate.Name = "txtPackageRate"
        Me.txtPackageRate.ReadOnly = True
        Me.txtPackageRate.Size = New System.Drawing.Size(145, 23)
        Me.txtPackageRate.TabIndex = 838
        Me.txtPackageRate.Text = "0.00"
        Me.txtPackageRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'roomtype
        '
        Me.roomtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(58, 300)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(59, 23)
        Me.roomtype.TabIndex = 840
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rateid
        '
        Me.rateid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rateid.ForeColor = System.Drawing.Color.Black
        Me.rateid.Location = New System.Drawing.Point(59, 333)
        Me.rateid.Margin = New System.Windows.Forms.Padding(5)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(59, 23)
        Me.rateid.TabIndex = 841
        Me.rateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Location = New System.Drawing.Point(149, 24)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(222, 23)
        Me.txtDate.TabIndex = 842
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trnid
        '
        Me.trnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(127, 333)
        Me.trnid.Margin = New System.Windows.Forms.Padding(5)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(59, 23)
        Me.trnid.TabIndex = 843
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmHotelEditDailyrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(406, 234)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.rateid)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPackageRate)
        Me.Controls.Add(Me.txtRoomPackageRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtExtra)
        Me.Controls.Add(Me.txtChild)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.txtPax)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelEditDailyrate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Daily Rate"
        CType(Me.txtRoomPackageRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPackage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtPax As System.Windows.Forms.TextBox
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChild As System.Windows.Forms.TextBox
    Friend WithEvents txtExtra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomPackageRate As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPackage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPackageRate As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents rateid As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
End Class
