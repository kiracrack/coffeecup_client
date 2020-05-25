<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceivedReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtCompanyNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCompanyName = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportHeader = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgReportFooter = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtRequestingOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRRDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDirectIssue = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rxrRRnumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.txtSupplier = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtpurchasetype = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtRRNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.txtValidDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPosition1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.imgPrepareby = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtPosition3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtPosition2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSignatory2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtPayAs = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTotalVat = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVatableSales = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTotalAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCompanyNumber, Me.txtCompanyAddress, Me.txtCompanyName, Me.imgReportHeader})
        Me.TopMargin.HeightF = 125.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyNumber.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 93.25!)
        Me.txtCompanyNumber.Name = "txtCompanyNumber"
        Me.txtCompanyNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyNumber.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyNumber.StylePriority.UseFont = False
        Me.txtCompanyNumber.StylePriority.UseTextAlignment = False
        Me.txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCompanyAddress.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 71.375!)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyAddress.SizeF = New System.Drawing.SizeF(719.0001!, 21.875!)
        Me.txtCompanyAddress.StylePriority.UseFont = False
        Me.txtCompanyAddress.StylePriority.UseTextAlignment = False
        Me.txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 49.5!)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCompanyName.SizeF = New System.Drawing.SizeF(718.0419!, 21.875!)
        Me.txtCompanyName.StylePriority.UseFont = False
        Me.txtCompanyName.StylePriority.UseTextAlignment = False
        Me.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgReportHeader
        '
        Me.imgReportHeader.BorderWidth = 0.0!
        Me.imgReportHeader.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportHeader.KeepTogether = False
        Me.imgReportHeader.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportHeader.Name = "imgReportHeader"
        Me.imgReportHeader.SizeF = New System.Drawing.SizeF(727.0833!, 122.9167!)
        Me.imgReportHeader.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.imgReportHeader.StylePriority.UseBorderWidth = False
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtCopyright, Me.imgReportFooter})
        Me.BottomMargin.HeightF = 136.917!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(22.2501!, 118.5!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(707.7499!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.txtCopyright.Visible = False
        '
        'imgReportFooter
        '
        Me.imgReportFooter.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.imgReportFooter.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.imgReportFooter.Name = "imgReportFooter"
        Me.imgReportFooter.SizeF = New System.Drawing.SizeF(730.0!, 118.5!)
        Me.imgReportFooter.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtRequestingOffice, Me.XrLabel13, Me.txtRRDate, Me.XrLabel11, Me.XrLabel6, Me.txtDirectIssue, Me.XrLabel8, Me.rxrRRnumber, Me.XrLabel1, Me.XrBarCode1, Me.txtSupplier, Me.txtpurchasetype, Me.txtRRNumber, Me.txtNote, Me.txtPayAs, Me.XrLabel10, Me.XrLabel9, Me.txtTotalVat, Me.XrLabel5, Me.txtVatableSales, Me.txtTotalAmount, Me.XrLabel2})
        Me.ReportHeader.HeightF = 134.6248!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtRequestingOffice
        '
        Me.txtRequestingOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtRequestingOffice.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 31.54154!)
        Me.txtRequestingOffice.Name = "txtRequestingOffice"
        Me.txtRequestingOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRequestingOffice.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtRequestingOffice.StylePriority.UseFont = False
        Me.txtRequestingOffice.StylePriority.UseTextAlignment = False
        Me.txtRequestingOffice.Text = " "
        Me.txtRequestingOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(377.7498!, 31.54154!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Requesting Office:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtRRDate
        '
        Me.txtRRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtRRDate.LocationFloat = New DevExpress.Utils.PointFloat(101.0!, 49.41652!)
        Me.txtRRDate.Name = "txtRRDate"
        Me.txtRRDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRRDate.SizeF = New System.Drawing.SizeF(243.7382!, 15.625!)
        Me.txtRRDate.StylePriority.UseFont = False
        Me.txtRRDate.StylePriority.UseTextAlignment = False
        Me.txtRRDate.Text = " "
        Me.txtRRDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.9999956!, 49.41652!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "RR DATE:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 47.16654!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Direct Issue To:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtDirectIssue
        '
        Me.txtDirectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtDirectIssue.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 47.16654!)
        Me.txtDirectIssue.Name = "txtDirectIssue"
        Me.txtDirectIssue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDirectIssue.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.txtDirectIssue.StylePriority.UseFont = False
        Me.txtDirectIssue.StylePriority.UseTextAlignment = False
        Me.txtDirectIssue.Text = " "
        Me.txtDirectIssue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 62.79154!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Issue Reference"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rxrRRnumber
        '
        Me.rxrRRnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.rxrRRnumber.LocationFloat = New DevExpress.Utils.PointFloat(473.7497!, 62.79154!)
        Me.rxrRRnumber.Name = "rxrRRnumber"
        Me.rxrRRnumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.rxrRRnumber.SizeF = New System.Drawing.SizeF(179.7501!, 15.625!)
        Me.rxrRRnumber.StylePriority.UseFont = False
        Me.rxrRRnumber.StylePriority.UseTextAlignment = False
        Me.rxrRRnumber.Text = " "
        Me.rxrRRnumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 31.91662!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "RR NUMBER:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.BorderWidth = 0.0!
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(660.375!, 11.79171!)
        Me.XrBarCode1.Module = 4.0!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(66.62!, 66.62482!)
        Me.XrBarCode1.StylePriority.UseBorderWidth = False
        Me.XrBarCode1.StylePriority.UsePadding = False
        QrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.XrBarCode1.Symbology = QrCodeGenerator1
        Me.XrBarCode1.Text = "10001"
        '
        'txtSupplier
        '
        Me.txtSupplier.AutoWidth = True
        Me.txtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSupplier.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 9.999974!)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSupplier.SizeF = New System.Drawing.SizeF(364.8752!, 21.91666!)
        Me.txtSupplier.StylePriority.UseFont = False
        Me.txtSupplier.StylePriority.UseTextAlignment = False
        Me.txtSupplier.Text = "SUPPLIER NAME"
        Me.txtSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtpurchasetype
        '
        Me.txtpurchasetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchasetype.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 7.999992!)
        Me.txtpurchasetype.Name = "txtpurchasetype"
        Me.txtpurchasetype.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpurchasetype.SizeF = New System.Drawing.SizeF(275.7502!, 22.58333!)
        Me.txtpurchasetype.StylePriority.UseFont = False
        Me.txtpurchasetype.StylePriority.UseTextAlignment = False
        Me.txtpurchasetype.Text = "RECEIVING REPORT"
        Me.txtpurchasetype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtRRNumber
        '
        Me.txtRRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtRRNumber.LocationFloat = New DevExpress.Utils.PointFloat(101.0!, 31.91662!)
        Me.txtRRNumber.Name = "txtRRNumber"
        Me.txtRRNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtRRNumber.SizeF = New System.Drawing.SizeF(243.7382!, 15.625!)
        Me.txtRRNumber.StylePriority.UseFont = False
        Me.txtRRNumber.StylePriority.UseTextAlignment = False
        Me.txtRRNumber.Text = " "
        Me.txtRRNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.LocationFloat = New DevExpress.Utils.PointFloat(377.7497!, 82.41656!)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNote.SizeF = New System.Drawing.SizeF(349.3336!, 45.12495!)
        Me.txtNote.StylePriority.UseFont = False
        Me.txtNote.StylePriority.UseTextAlignment = False
        Me.txtNote.Text = "SAMPLE TEXT"
        Me.txtNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtValidDate, Me.txtTitle1, Me.txtLine1, Me.txtPosition1, Me.txtSignatory1, Me.XrPictureBox3, Me.imgPrepareby, Me.txtPosition3, Me.txtTitle3, Me.txtSignatory3, Me.txtLine3, Me.txtLine2, Me.txtPosition2, Me.txtSignatory2, Me.txtTitle2, Me.XrPictureBox1})
        Me.ReportFooter.HeightF = 366.2916!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtValidDate
        '
        Me.txtValidDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtValidDate.ForeColor = System.Drawing.Color.Red
        Me.txtValidDate.LocationFloat = New DevExpress.Utils.PointFloat(22.2501!, 349.2083!)
        Me.txtValidDate.Name = "txtValidDate"
        Me.txtValidDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtValidDate.SizeF = New System.Drawing.SizeF(707.7498!, 13.83334!)
        Me.txtValidDate.StylePriority.UseFont = False
        Me.txtValidDate.StylePriority.UseForeColor = False
        Me.txtValidDate.StylePriority.UseTextAlignment = False
        Me.txtValidDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitle1
        '
        Me.txtTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 15.0!)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle1.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle1.StylePriority.UseFont = False
        Me.txtTitle1.StylePriority.UseTextAlignment = False
        Me.txtTitle1.Text = "Prepared by"
        Me.txtTitle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtLine1
        '
        Me.txtLine1.ForeColor = System.Drawing.Color.Gray
        Me.txtLine1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 66.50002!)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine1.StylePriority.UseForeColor = False
        '
        'txtPosition1
        '
        Me.txtPosition1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 91.50002!)
        Me.txtPosition1.Name = "txtPosition1"
        Me.txtPosition1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition1.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition1.StylePriority.UseFont = False
        Me.txtPosition1.StylePriority.UseTextAlignment = False
        Me.txtPosition1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtSignatory1
        '
        Me.txtSignatory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory1.LocationFloat = New DevExpress.Utils.PointFloat(9.250099!, 74.99991!)
        Me.txtSignatory1.Name = "txtSignatory1"
        Me.txtSignatory1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory1.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory1.StylePriority.UseFont = False
        Me.txtSignatory1.StylePriority.UseTextAlignment = False
        Me.txtSignatory1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(493.5795!, 19.16656!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(225.42!, 82.33321!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox3.Visible = False
        '
        'imgPrepareby
        '
        Me.imgPrepareby.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 19.16656!)
        Me.imgPrepareby.Name = "imgPrepareby"
        Me.imgPrepareby.SizeF = New System.Drawing.SizeF(225.42!, 81.45332!)
        Me.imgPrepareby.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.imgPrepareby.Visible = False
        '
        'txtPosition3
        '
        Me.txtPosition3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition3.LocationFloat = New DevExpress.Utils.PointFloat(492.8295!, 91.4998!)
        Me.txtPosition3.Name = "txtPosition3"
        Me.txtPosition3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition3.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition3.StylePriority.UseFont = False
        Me.txtPosition3.StylePriority.UseTextAlignment = False
        Me.txtPosition3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition3.Visible = False
        '
        'txtTitle3
        '
        Me.txtTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle3.LocationFloat = New DevExpress.Utils.PointFloat(492.8295!, 14.16658!)
        Me.txtTitle3.Name = "txtTitle3"
        Me.txtTitle3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle3.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle3.StylePriority.UseFont = False
        Me.txtTitle3.StylePriority.UseTextAlignment = False
        Me.txtTitle3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle3.Visible = False
        '
        'txtSignatory3
        '
        Me.txtSignatory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory3.LocationFloat = New DevExpress.Utils.PointFloat(492.8295!, 73.99986!)
        Me.txtSignatory3.Name = "txtSignatory3"
        Me.txtSignatory3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory3.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory3.StylePriority.UseFont = False
        Me.txtSignatory3.StylePriority.UseTextAlignment = False
        Me.txtSignatory3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory3.Visible = False
        '
        'txtLine3
        '
        Me.txtLine3.ForeColor = System.Drawing.Color.Gray
        Me.txtLine3.LocationFloat = New DevExpress.Utils.PointFloat(492.8295!, 65.49976!)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine3.StylePriority.UseForeColor = False
        Me.txtLine3.Visible = False
        '
        'txtLine2
        '
        Me.txtLine2.ForeColor = System.Drawing.Color.Gray
        Me.txtLine2.LocationFloat = New DevExpress.Utils.PointFloat(247.5798!, 65.66658!)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.SizeF = New System.Drawing.SizeF(225.42!, 7.29!)
        Me.txtLine2.StylePriority.UseForeColor = False
        Me.txtLine2.Visible = False
        '
        'txtPosition2
        '
        Me.txtPosition2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtPosition2.LocationFloat = New DevExpress.Utils.PointFloat(247.5798!, 90.6666!)
        Me.txtPosition2.Name = "txtPosition2"
        Me.txtPosition2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPosition2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtPosition2.StylePriority.UseFont = False
        Me.txtPosition2.StylePriority.UseTextAlignment = False
        Me.txtPosition2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtPosition2.Visible = False
        '
        'txtSignatory2
        '
        Me.txtSignatory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.txtSignatory2.LocationFloat = New DevExpress.Utils.PointFloat(247.5798!, 74.1665!)
        Me.txtSignatory2.Name = "txtSignatory2"
        Me.txtSignatory2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSignatory2.SizeF = New System.Drawing.SizeF(225.42!, 15.62!)
        Me.txtSignatory2.StylePriority.UseFont = False
        Me.txtSignatory2.StylePriority.UseTextAlignment = False
        Me.txtSignatory2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtSignatory2.Visible = False
        '
        'txtTitle2
        '
        Me.txtTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtTitle2.LocationFloat = New DevExpress.Utils.PointFloat(247.5798!, 14.16658!)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle2.SizeF = New System.Drawing.SizeF(147.1251!, 18.74999!)
        Me.txtTitle2.StylePriority.UseFont = False
        Me.txtTitle2.StylePriority.UseTextAlignment = False
        Me.txtTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.txtTitle2.Visible = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(249.3298!, 19.16656!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(225.42!, 81.45332!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.XrPictureBox1.Visible = False
        '
        'txtPayAs
        '
        Me.txtPayAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtPayAs.LocationFloat = New DevExpress.Utils.PointFloat(101.0!, 111.9165!)
        Me.txtPayAs.Name = "txtPayAs"
        Me.txtPayAs.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPayAs.SizeF = New System.Drawing.SizeF(243.7382!, 15.625!)
        Me.txtPayAs.StylePriority.UseFont = False
        Me.txtPayAs.StylePriority.UseTextAlignment = False
        Me.txtPayAs.Text = " "
        Me.txtPayAs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0.9999752!, 111.9165!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "PAY AS:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.9999752!, 96.29152!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "TOTAL VAT:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTotalVat
        '
        Me.txtTotalVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtTotalVat.LocationFloat = New DevExpress.Utils.PointFloat(101.0!, 96.29152!)
        Me.txtTotalVat.Name = "txtTotalVat"
        Me.txtTotalVat.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalVat.SizeF = New System.Drawing.SizeF(243.7382!, 15.625!)
        Me.txtTotalVat.StylePriority.UseFont = False
        Me.txtTotalVat.StylePriority.UseTextAlignment = False
        Me.txtTotalVat.Text = " "
        Me.txtTotalVat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.9999752!, 80.66652!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "VATABLE SALES:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtVatableSales
        '
        Me.txtVatableSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtVatableSales.LocationFloat = New DevExpress.Utils.PointFloat(101.0!, 80.66652!)
        Me.txtVatableSales.Name = "txtVatableSales"
        Me.txtVatableSales.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVatableSales.SizeF = New System.Drawing.SizeF(243.7382!, 15.625!)
        Me.txtVatableSales.StylePriority.UseFont = False
        Me.txtVatableSales.StylePriority.UseTextAlignment = False
        Me.txtVatableSales.Text = " "
        Me.txtVatableSales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.txtTotalAmount.LocationFloat = New DevExpress.Utils.PointFloat(101.0!, 65.04151!)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalAmount.SizeF = New System.Drawing.SizeF(243.7382!, 15.625!)
        Me.txtTotalAmount.StylePriority.UseFont = False
        Me.txtTotalAmount.StylePriority.UseTextAlignment = False
        Me.txtTotalAmount.Text = " "
        Me.txtTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 65.04151!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(96.0!, 15.62501!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "TOTAL AMOUNT:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptReceivedReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 125, 137)
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txtRRNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportHeader As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtpurchasetype As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCompanyName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPosition1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtValidDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgReportFooter As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtSupplier As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDirectIssue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rxrRRnumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRRDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtRequestingOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents imgPrepareby As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtPosition3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtPosition2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtSignatory2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtPayAs As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTotalVat As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVatableSales As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTotalAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
