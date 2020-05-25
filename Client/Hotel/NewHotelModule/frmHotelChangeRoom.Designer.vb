<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelChangeRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelChangeRoom))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.txtCurrroomtype = New System.Windows.Forms.TextBox()
        Me.txtCurrRoomNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtfolioid = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.txtDeparture = New System.Windows.Forms.DateTimePicker()
        Me.newroomid = New System.Windows.Forms.TextBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPackageRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.fromroomid = New System.Windows.Forms.TextBox()
        Me.txtPackageName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridPackage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.hotelcifid = New System.Windows.Forms.TextBox()
        CType(Me.txtPackageName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(241, 263)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(145, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Guest Name"
        '
        'txtGuest
        '
        Me.txtGuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGuest.ForeColor = System.Drawing.Color.Black
        Me.txtGuest.Location = New System.Drawing.Point(108, 23)
        Me.txtGuest.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.ReadOnly = True
        Me.txtGuest.Size = New System.Drawing.Size(278, 25)
        Me.txtGuest.TabIndex = 411
        Me.txtGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomType
        '
        Me.txtRoomType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.Location = New System.Drawing.Point(206, 125)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(180, 23)
        Me.txtRoomType.TabIndex = 458
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomNumber.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNumber.Location = New System.Drawing.Point(145, 125)
        Me.txtRoomNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(59, 23)
        Me.txtRoomNumber.TabIndex = 0
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrroomtype
        '
        Me.txtCurrroomtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrroomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCurrroomtype.ForeColor = System.Drawing.Color.Black
        Me.txtCurrroomtype.Location = New System.Drawing.Point(184, 51)
        Me.txtCurrroomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCurrroomtype.Name = "txtCurrroomtype"
        Me.txtCurrroomtype.ReadOnly = True
        Me.txtCurrroomtype.Size = New System.Drawing.Size(202, 23)
        Me.txtCurrroomtype.TabIndex = 464
        '
        'txtCurrRoomNo
        '
        Me.txtCurrRoomNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrRoomNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCurrRoomNo.ForeColor = System.Drawing.Color.Black
        Me.txtCurrRoomNo.Location = New System.Drawing.Point(108, 51)
        Me.txtCurrRoomNo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCurrRoomNo.Name = "txtCurrRoomNo"
        Me.txtCurrRoomNo.ReadOnly = True
        Me.txtCurrRoomNo.Size = New System.Drawing.Size(73, 23)
        Me.txtCurrRoomNo.TabIndex = 463
        Me.txtCurrRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 465
        Me.Label2.Text = "Current Room"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label20.Location = New System.Drawing.Point(67, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(193, 20)
        Me.Label20.TabIndex = 466
        Me.Label20.Text = "Upgrade Room Information"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(85, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 15)
        Me.Label19.TabIndex = 757
        Me.Label19.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(145, 151)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(241, 57)
        Me.txtRemarks.TabIndex = 756
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LinkLabel1.Location = New System.Drawing.Point(56, 129)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel1.TabIndex = 813
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Room Number"
        '
        'txtfolioid
        '
        Me.txtfolioid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfolioid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfolioid.ForeColor = System.Drawing.Color.Black
        Me.txtfolioid.Location = New System.Drawing.Point(88, 603)
        Me.txtfolioid.Margin = New System.Windows.Forms.Padding(5)
        Me.txtfolioid.Name = "txtfolioid"
        Me.txtfolioid.Size = New System.Drawing.Size(59, 23)
        Me.txtfolioid.TabIndex = 814
        Me.txtfolioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'roomtype
        '
        Me.roomtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(88, 629)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(59, 23)
        Me.roomtype.TabIndex = 815
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(155, 604)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(225, 22)
        Me.txtDateArival.TabIndex = 816
        '
        'txtDeparture
        '
        Me.txtDeparture.CustomFormat = "MMMM dd, yyyy"
        Me.txtDeparture.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDeparture.Location = New System.Drawing.Point(155, 629)
        Me.txtDeparture.Name = "txtDeparture"
        Me.txtDeparture.Size = New System.Drawing.Size(225, 22)
        Me.txtDeparture.TabIndex = 817
        '
        'newroomid
        '
        Me.newroomid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.newroomid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.newroomid.ForeColor = System.Drawing.Color.Black
        Me.newroomid.Location = New System.Drawing.Point(88, 575)
        Me.newroomid.Margin = New System.Windows.Forms.Padding(5)
        Me.newroomid.Name = "newroomid"
        Me.newroomid.Size = New System.Drawing.Size(59, 23)
        Me.newroomid.TabIndex = 818
        Me.newroomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'guestid
        '
        Me.guestid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(88, 548)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(59, 23)
        Me.guestid.TabIndex = 819
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(52, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 821
        Me.Label3.Text = "Select Package"
        '
        'txtPackageRate
        '
        Me.txtPackageRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPackageRate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPackageRate.ForeColor = System.Drawing.Color.Black
        Me.txtPackageRate.Location = New System.Drawing.Point(241, 235)
        Me.txtPackageRate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPackageRate.Name = "txtPackageRate"
        Me.txtPackageRate.ReadOnly = True
        Me.txtPackageRate.Size = New System.Drawing.Size(145, 25)
        Me.txtPackageRate.TabIndex = 822
        Me.txtPackageRate.Text = "0.00"
        Me.txtPackageRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(158, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 823
        Me.Label4.Text = "Select Rate"
        '
        'rateid
        '
        Me.rateid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rateid.ForeColor = System.Drawing.Color.Black
        Me.rateid.Location = New System.Drawing.Point(88, 522)
        Me.rateid.Margin = New System.Windows.Forms.Padding(5)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(59, 23)
        Me.rateid.TabIndex = 825
        Me.rateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(88, 495)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(59, 23)
        Me.foliono.TabIndex = 826
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fromroomid
        '
        Me.fromroomid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fromroomid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fromroomid.ForeColor = System.Drawing.Color.Black
        Me.fromroomid.Location = New System.Drawing.Point(88, 468)
        Me.fromroomid.Margin = New System.Windows.Forms.Padding(5)
        Me.fromroomid.Name = "fromroomid"
        Me.fromroomid.Size = New System.Drawing.Size(59, 23)
        Me.fromroomid.TabIndex = 827
        Me.fromroomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPackageName
        '
        Me.txtPackageName.EditValue = ""
        Me.txtPackageName.Location = New System.Drawing.Point(145, 210)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPackageName.Properties.Appearance.Options.UseFont = True
        Me.txtPackageName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPackageName.Properties.DisplayMember = "Package"
        Me.txtPackageName.Properties.NullText = ""
        Me.txtPackageName.Properties.PopupView = Me.gridPackage
        Me.txtPackageName.Properties.ValueMember = "ratecode"
        Me.txtPackageName.Size = New System.Drawing.Size(241, 22)
        Me.txtPackageName.TabIndex = 828
        '
        'gridPackage
        '
        Me.gridPackage.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridPackage.Name = "gridPackage"
        Me.gridPackage.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridPackage.OptionsView.ShowGroupPanel = False
        '
        'hotelcifid
        '
        Me.hotelcifid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.hotelcifid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hotelcifid.ForeColor = System.Drawing.Color.Black
        Me.hotelcifid.Location = New System.Drawing.Point(157, 468)
        Me.hotelcifid.Margin = New System.Windows.Forms.Padding(5)
        Me.hotelcifid.Name = "hotelcifid"
        Me.hotelcifid.Size = New System.Drawing.Size(59, 23)
        Me.hotelcifid.TabIndex = 829
        Me.hotelcifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmHotelChangeRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(429, 317)
        Me.Controls.Add(Me.hotelcifid)
        Me.Controls.Add(Me.txtPackageName)
        Me.Controls.Add(Me.fromroomid)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.rateid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPackageRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.newroomid)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.txtDeparture)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.txtfolioid)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrroomtype)
        Me.Controls.Add(Me.txtCurrRoomNo)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelChangeRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upgrade Room"
        CType(Me.txtPackageName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPackage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGuest As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrroomtype As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtfolioid As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents newroomid As System.Windows.Forms.TextBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPackageRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rateid As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents fromroomid As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridPackage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents hotelcifid As System.Windows.Forms.TextBox
End Class
