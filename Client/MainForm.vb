Imports System.Windows.Forms
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports DevExpress.LookAndFeel

Public Class MainForm
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Private checkupdate As Boolean = True
    Dim bw As BackgroundWorker = New BackgroundWorker

    Sub New()
        InitSkins()
        InitializeComponent()
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
   
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.F12 Then
            If LCase(globalusername) = "root" Then
                frmSystemUpdate.ShowDialog()
            Else
                MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf keyData = (Keys.Control) + Keys.F11 Then
            If LCase(globalusername) = "root" Then
                frmAdminChangeUser.Show()
            End If
        ElseIf keyData = Keys.F12 Then
            Dim a As String = InputBox("Please enter transfer batchcode to revert inventory!", "Input")

            If a <> "" Then
                If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    MsgBox(DecryptTripleDES(a))
                End If
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Timer1.Start()
        PendingTransactionCount()
    End Sub

    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Timer1.Stop()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ForceCloseSystem = False Then
            frmUserlogoff.ShowDialog()
            If formclose = False Then
                e.Cancel = True
                Exit Sub
            End If
            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i
            com.CommandText = "update tbllogin set outtime=current_timestamp  where userid='" & globaluserid & "' and outtime is null" : com.ExecuteNonQuery()
            CloseSystemDeclaration()
            frmLogin.Show()
        End If
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico

        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        'End declaration

        LoadMainSystemSettings()

        ToolStrip.Top = 0
        ToolStrip.Left = 0
        ToolStrip.Width = XtraScrollableControl1.Width - 20
        XtraScrollableControl1.HorizontalScroll.Visible = False

        PendingTransactionCount()
        txtVersion.Text = "Coffeecup " & fversion
        If globalUserRequiredUpdateInfo = True Then
            MessageBox.Show("New system update features can customized your own system prefered color, icons and profile picture, Please update your account information", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChangeAccountPasswordToolStripMenuItem.PerformClick()
        End If
        AutoExecuteQuery()
        NotifyIcon1.Icon = Me.Icon

        If compLowConnectionTagging = True Then
            If Not bw.IsBusy = True Then
                bw.RunWorkerAsync()
            End If
        End If

    End Sub

    Public Sub AutoExecuteQuery()
        If Globaldefaultroomoccupieddirty <> "" Then
            If countqry("tblcommandexecuter", "commanddate=current_date and commandcode='HOUSEKEEPING'") = 0 Then
                com.CommandText = "UPDATE tblhotelrooms set roomstatus='" & Globaldefaultroomoccupieddirty & "', remarks='FOR CLEANING' where roomid in (select roomid from tblhotelroomtransaction where inhouse=1 and closed=0 and cancelled=0)" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblcommandexecuter set commanddate=current_date,commandcode='HOUSEKEEPING', commandquery='" & rchar(com.CommandText) & "',executed=1,dateexecuted=current_timestamp" : com.ExecuteNonQuery()
            End If
        End If
        com.CommandText = "delete FROM `tblemailnotification` where notified=1" : com.ExecuteNonQuery()
    End Sub

    Public Sub LoadSystemAppearance(ByVal iconf As String, ByVal bgcolor As String, ByVal fontcolor As String)
        If Not ImageProfile Is Nothing Then
            Dim wd As Integer = ImageProfile.Height
            Dim CropRect As New Rectangle((ImageProfile.Width / 2) - (wd / 2), 0, wd, ImageProfile.Height)
            Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
            Using grp = Graphics.FromImage(CropImage)
                grp.DrawImage(ImageProfile, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
            End Using
            Profileimg.Image = CropImage
        Else
            Profileimg.Image = Nothing
        End If

        If iconf = "" Then
            iconf = "default"
        End If
        For Each ctrl In ToolStrip.Items
            If IO.File.Exists(Application.StartupPath.ToString & "\icon\" & iconf & "\" & ctrl.Name & ".png") = True Then
                ctrl.Image = Image.FromFile(Application.StartupPath.ToString & "\icon\" & iconf & "\" & ctrl.Name & ".png")
            ElseIf IO.File.Exists(Application.StartupPath.ToString & "\icon\default\" & ctrl.Name & ".png") = True Then
                ctrl.Image = Image.FromFile(Application.StartupPath.ToString & "\icon\default\" & ctrl.Name & ".png")
            Else

            End If
        Next

        If bgcolor = "" Then
            bgcolor = "34,34,34"
        End If
        'remove white line of main menu
        Dim RGB As String() = bgcolor.Split(",")
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        XtraScrollableControl1.Appearance.ForeColor = Me.BackColor
        XtraScrollableControl1.Appearance.BackColor = Me.BackColor
        XtraScrollableControl1.Appearance.BackColor2 = Me.BackColor
        XtraScrollableControl1.LookAndFeel.SkinMaskColor = Me.BackColor
        XtraScrollableControl1.LookAndFeel.SkinMaskColor2 = Me.BackColor
        With Panel1
            .Width = XtraScrollableControl1.Width
            .Left = 0
            .Parent = XtraScrollableControl1
            .Height = 2
            .BackColor = Me.BackColor
            .BringToFront()
        End With

        If fontcolor = "" Then
            fontcolor = "LIGHT"
        End If
        LoadSystemDefaultColor(fontcolor)
    End Sub

    Public Sub LoadSystemDefaultColor(ByVal c As String)
        If c = "LIGHT" Then
            txtfullname.ForeColor = Color.White
            txtOffice.ForeColor = Color.LightGray
            txtPosition.ForeColor = Color.LightGray
            txtDateLogin.ForeColor = Color.LightGray
            txtVersion.ForeColor = Color.DimGray
            txtDeveloper.ForeColor = Color.DimGray
            For Each ctrl In ToolStrip.Items
                ctrl.ForeColor = Color.LightGray
            Next
            XtraScrollableControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Else
            txtfullname.ForeColor = Color.Black
            txtOffice.ForeColor = Color.Black
            txtPosition.ForeColor = Color.Black
            txtDateLogin.ForeColor = Color.Black
            txtVersion.ForeColor = Color.Black
            txtDeveloper.ForeColor = Color.Black
            For Each ctrl In ToolStrip.Items
                ctrl.ForeColor = Color.Black
            Next
            XtraScrollableControl1.LookAndFeel.SkinName = "DevExpress Style"

        End If
    End Sub
    Public Sub LoadMainSystemSettings()
        Me.Cursor = Cursors.WaitCursor
        loadBatchQuery()
        hideAllMenu(False)
        LoadFormAreaSize()
        'If (countqry("tblcompoffice", "officeid='" & compOfficeid & "' and (officeemail='' or officeemail is null)") > 0 Or countqry("tblaccounts", "accountid='" & globaluserid & "' and (emailaddress='' or emailaddress is null)") > 0) And globalEmailNotification = True Then
        '    frmAccountInformation.mode.Text = "startup"
        '    frmAccountInformation.ShowDialog(Me)
        'End If

        '#Validate Security for module
        'If LCase(globalusername) = "root" Then
        '    hideAllMenu(True)
        'Else
        '    ValidateModule()
        'End If
        ValidateModule()
        '---
        'If GlobalEnableQueuingSlip = True And countqry("tblsalesqueuingfilter", "permissioncode='" & globalAuthcode & "'") > 0 Then
        '    cmdQueuePrinterSettings.Visible = True
        'Else
        '    cmdQueuePrinterSettings.Visible = False
        'End If

        'If (countqry("tblcompoffice", "officeid='" & compOfficeid & "' and (officeemail='' or officeemail is null)") > 0 Or countqry("tblaccounts", "accountid='" & globaluserid & "' and (emailaddress='' or emailaddress is null)") > 0) And globalEmailNotification = True Then
        '    If cmdnewRequest.Visible = True Then
        '        cmdnewRequest.Enabled = False
        '    End If
        'Else
        '    cmdnewRequest.Enabled = True
        'End If

        ValidateUserAccounts()
        txtConnectedHost.Text = "Connected: " & sqlserver
        Me.Cursor = Cursors.Default
        Timer1.Enabled = True
    End Sub

    Public Sub PendingTransactionCount()
        LoadSystemDefaultColor(globalFontColor)
        If globalAuthForApproval = True Then
            Dim forapproval As Integer = 0
            If globalCorporateApprover = True Then

                'count for sales discounts
                'Dim salesDiscount As Integer = countqry("tblsalestransaction", "cancelled=0 and void=0  and total < 0 and adjoveride=0 ")
                'If salesDiscount > 0 Then
                '    forapproval += salesDiscount
                '    frmCorpForApprovalList.cmdSalesDiscount.Text = "Sales Discount (" & salesDiscount & ")"
                '    If globalFontColor = "LIGHT" Then
                '        frmCorpForApprovalList.cmdSalesDiscount.ForeColor = Color.Gold
                '    Else
                '        frmCorpForApprovalList.cmdSalesDiscount.ForeColor = Color.Red
                '    End If
                'Else
                '    frmCorpForApprovalList.cmdSalesDiscount.Text = "Sales Discount"
                'End If

                'Hotel discount
                'Dim HotelDiscount As Integer = countqry("tblhotelroomsdiscounttransaction", "discountoveride=0 and disapproved=0")
                'If HotelDiscount > 0 Then
                '    forapproval += HotelDiscount
                '    frmCorpForApprovalList.cmdHotel.Text = "Hotel Discount (" & HotelDiscount & ")"
                '    If globalFontColor = "LIGHT" Then
                '        frmCorpForApprovalList.cmdHotel.ForeColor = Color.Gold
                '    Else
                '        frmCorpForApprovalList.cmdHotel.ForeColor = Color.Red
                '    End If
                'Else
                '    frmCorpForApprovalList.cmdHotel.Text = "Hotel Discount"
                'End If


                com.CommandText = "call sp_forapproval(true, 'PR'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
                Dim Requisition As Integer = countrecord("tmpforapprovalprview")
                If Requisition > 0 Then
                    forapproval += Requisition
                End If

                com.CommandText = "call sp_forapproval(true, 'PO'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
                Dim PurchaseOrder As Integer = countrecord("tmpforapprovalpoview")
                If PurchaseOrder > 0 Then
                    forapproval += PurchaseOrder
                End If

                com.CommandText = "call sp_forapproval(true, 'DV'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
                Dim DisbursementVoucher As Integer = countrecord("tmpforapprovaldvview")
                If DisbursementVoucher > 0 Then
                    forapproval += DisbursementVoucher
                End If

                'count for approval corporate disbursement voucher
                '    Dim voucher As Integer = countqry("tbldisbursementvoucher", " cancelled=0 and corporatelevel=1 and verified=0 and hold=0 and (select concat(count(*)+1) from tblapprovalhistory where referenceno=tbldisbursementvoucher.voucherno and (status='approved' or status='disbursed')  and applevel<>'-' and approvaltype='voucher') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='voucher-signatories') ")
                '    If voucher > 0 Then
                '        forapproval += voucher
                '        frmCorpForApprovalList.cmdPaymentRequest.Text = "Disbursement Voucher (" & voucher & ")"
                '        If globalFontColor = "LIGHT" Then
                '            frmCorpForApprovalList.cmdPaymentRequest.ForeColor = Color.Gold
                '        Else
                '            frmCorpForApprovalList.cmdPaymentRequest.ForeColor = Color.Red
                '        End If
                '    Else
                '        frmCorpForApprovalList.cmdPaymentRequest.Text = "Disbursement Voucher"
                '    End If

                '    'count for approval ffe disposal
                '    Dim FFEdisposal As Integer = countqry("tblinventoryffe", "disposalrequested=1 and disposalrequestcorporatelevel=1 and disposalapproved=0 and (select concat(count(*)+1) from tblapprovalhistory where referenceno=tblinventoryffe.ffecode and status='approved' and applevel<>'-' and approvaltype='ffe-for-disposal') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='ffe-for-disposal')  ")
                '    If FFEdisposal > 0 Then
                '        forapproval += FFEdisposal
                '        frmCorpForApprovalList.cmdFFEDisposal.Text = "FFE Disposal (" & FFEdisposal & ")"
                '        If globalFontColor = "LIGHT" Then
                '            frmCorpForApprovalList.cmdFFEDisposal.ForeColor = Color.Gold
                '        Else
                '            frmCorpForApprovalList.cmdFFEDisposal.ForeColor = Color.Red
                '        End If
                '    Else
                '        frmCorpForApprovalList.cmdFFEDisposal.Text = "FFE Disposal"
                '    End If
            End If

            If globalBranchApprover = True Or globalapproveanyoffices = True Then
                'count for stock transfer request
                If countqry("tbltransferrequest", "cleared=0 and confirmed=0 and cancelled=0") > 0 Then
                    forapproval += countqry("tbltransferrequest", "cleared=0 and confirmed=0 and cancelled=0 and (select concat(count(*)+1) from tblapprovalhistory where referenceno=tbltransferrequest.reqcode and status='approved' and applevel<>'-' and approvaltype='stock-transfer-signatories') = (select left(applevel,1) from tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='stock-transfer-signatories') ")
                End If

                'count for approval branch requisition 
                com.CommandText = "call sp_forapproval(FALSE, 'PR'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
                Dim Requisition As Integer = countrecord("tmpforapprovalprview")
                If Requisition > 0 Then
                    forapproval += Requisition
                End If


                'count for approval branch purchase order 
                com.CommandText = "call sp_forapproval(FALSE, 'PO'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
                Dim PurchaseOrder As Integer = countrecord("tmpforapprovalpoview")
                If PurchaseOrder > 0 Then
                    forapproval += PurchaseOrder
                End If

                'count for approval branch accounts payable
                com.CommandText = "call sp_forapproval(FALSE, 'DV'," & globaluserid & ",'%%')" : com.ExecuteNonQuery()
                Dim DisbursementVoucher As Integer = countrecord("tmpforapprovaldvview")
                If DisbursementVoucher > 0 Then
                    forapproval += DisbursementVoucher
                End If

                'count for approval ffe disposal
                If countqry("tblinventoryffe", "disposalrequested=1 and disposalrequestcorporatelevel=0 and disposalapproved=0") > 0 Then
                    forapproval += countqry("tblinventoryffe", "disposalrequested=1 and disposalrequestcorporatelevel=0 and disposalapproved=0 and  " _
                + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tblinventoryffe.ffecode and status='approved' and applevel<>'-' and approvaltype='ffe-for-disposal') = (select left(applevel,1) from tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='ffe-for-disposal') ")
                End If
            End If

            If forapproval > 0 Then
                cmdforapproval.Text = "For Approval Request (" & forapproval & ")"
                If globalFontColor = "LIGHT" Then
                    cmdforapproval.ForeColor = Color.Gold
                Else
                    cmdforapproval.ForeColor = Color.Red
                End If
            Else
                cmdforapproval.Text = "For Approval Request"
            End If
        End If

        If globalAuthNewRequisition = True Then
            Dim forrevision As Integer = countqry("tblrequisitions", "officeid='" & compOfficeid & "' and hold=1 and cancelled=0")
            If forrevision > 0 Then
                cmdRequestManagement.Text = "Requisition Management (" & forrevision & ")"
                If globalFontColor = "LIGHT" Then
                    cmdRequestManagement.ForeColor = Color.Gold
                Else
                    cmdRequestManagement.ForeColor = Color.Red
                End If

            Else
                cmdRequestManagement.Text = "Requisition Management"
            End If
        End If

        If globalAuthAccountsPayable = True Then
            Dim vouchercaption As String = ""
            If Globalenablebybranchvoucher = True Then
                vouchercaption = "Accounts Payable"
            Else
                vouchercaption = "Disbursement Voucher"
            End If
            If GlobalEnableAccountingVoucher = True Then
                Dim forPaymentRequest As Integer = countqry("tbldisbursementvoucher", "cleared=0 and cancelled=0")
                If forPaymentRequest > 0 Then
                    cmdAccountsPayable.Text = vouchercaption & " (" & forPaymentRequest & ")"
                    If globalFontColor = "LIGHT" Then
                        cmdAccountsPayable.ForeColor = Color.Gold
                    Else
                        cmdAccountsPayable.ForeColor = Color.Red
                    End If
                Else
                    cmdAccountsPayable.Text = vouchercaption
                End If
            Else
                If Globalenablebybranchvoucher = True Then
                    Dim forPaymentRequest As Integer = countqry("tblpurchaseorder", "corporatelevel=0 and verified=1 and forwarded=1 and paymentrequested=0 and officeid='" & compOfficeid & "' and cancelled=0") + countqry("tbldisbursementvoucher", "hold=1 and officeid='" & compOfficeid & "' and cancelled=0")
                    If forPaymentRequest > 0 Then
                        cmdAccountsPayable.Text = vouchercaption & " (" & forPaymentRequest & ")"
                        If globalFontColor = "LIGHT" Then
                            cmdAccountsPayable.ForeColor = Color.Gold
                        Else
                            cmdAccountsPayable.ForeColor = Color.Red
                        End If
                    Else
                        cmdAccountsPayable.Text = vouchercaption
                    End If
                Else
                    Dim forPaymentRequest As Integer = countqry("tbldisbursementvoucher", "cleared=1 and cancelled=0 and downloaded=0") + countqry("tbldisbursementvoucher", "cleared=1 and ca=1 and liquidated=0 and cancelled=0")
                    If forPaymentRequest > 0 Then
                        cmdAccountsPayable.Text = vouchercaption & " (" & forPaymentRequest & ")"
                        If globalFontColor = "LIGHT" Then
                            cmdAccountsPayable.ForeColor = Color.Gold
                        Else
                            cmdAccountsPayable.ForeColor = Color.Red
                        End If
                    Else
                        cmdAccountsPayable.Text = vouchercaption
                    End If
                End If
            End If
            
        End If

        If globalAuthPurchaseOrder = True Then
            Dim purchaseorder As Integer = countqry("tblpurchaseorder", " verified=1 and forpo=1 and cancelled=0 and delivered=0 and officeid='" & compOfficeid & "'")
            If purchaseorder > 0 Then
                cmdPurchaseOrder.Text = "Purchase Order (" & purchaseorder & ")"
                If globalFontColor = "LIGHT" Then
                    cmdPurchaseOrder.ForeColor = Color.Gold
                Else
                    cmdPurchaseOrder.ForeColor = Color.Red
                End If
            Else
                cmdPurchaseOrder.Text = "Purchase Order"
            End If
        End If

        If globalAuthReceivingofGoods = True And compAllowreceivedpurchases = True Then
            Dim consumable As Integer = 0
            com.CommandText = "select count(*) as cnt from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where catid in (select catid from tblprocategory where consumable=1) and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") & " " & If(GLobalEnableCentralStockReceiving = True, "", " and (select companyid from tblcompoffice where officeid=a.officeid)='" & GlobalCompanyid & "' ") & " group by b.ponumber order by a.datetrn asc;" : rst = com.ExecuteReader
            While rst.Read
                consumable += 1
            End While
            rst.Close()

            Dim FFE As Integer = 0
            com.CommandText = "select count(*) as cnt from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where catid in (select catid from tblprocategory where ffe=1) and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanageffeotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") & "  " & If(GLobalEnableCentralStockReceiving = True, "", " and (select companyid from tblcompoffice where officeid=a.officeid)='" & GlobalCompanyid & "' ") & "  group by b.ponumber order by a.datetrn asc;" : rst = com.ExecuteReader
            While rst.Read
                FFE += 1
            End While
            rst.Close()

            Dim forRecievingGoods As Integer = consumable + FFE
            If forRecievingGoods > 0 Then
                cmdReceivingofGoods.Text = "Receiving of Goods (" & forRecievingGoods & ")" & Environment.NewLine & "Supplier "
                If globalFontColor = "LIGHT" Then
                    cmdReceivingofGoods.ForeColor = Color.Gold
                Else
                    cmdReceivingofGoods.ForeColor = Color.Red
                End If
            Else
                cmdReceivingofGoods.Text = "Receiving of Goods (Supplier)"
            End If
        End If

        If globalAuthReceivingTransfer = True Then
            Dim forRecievingGoods As Integer = countqry("tbltransferbatch", "confirmed=0 and cancelled=0 and inventory_to='" & compOfficeid & "'") + countqry("tblinventoryffetransfer", "received=0 and cancelled=0 and  officeid_to='" & compOfficeid & "'")
            If forRecievingGoods > 0 Then
                cmdReceivingTransfer.Text = "Receiving of Goods Transfer (" & forRecievingGoods & ")"
                If globalFontColor = "LIGHT" Then
                    cmdReceivingTransfer.ForeColor = Color.Gold
                Else
                    cmdReceivingTransfer.ForeColor = Color.Red
                End If
            Else
                cmdReceivingTransfer.Text = "Receiving of Goods (Transfer)"
            End If
        End If

        If globalAuthTransferManagement = True Then
            Dim forTransferReq As Integer = countqry("tbltransferrequest", " cleared=1 and  confirmed=0 and cancelled=0 and (inventory_to='" & compOfficeid & "' or inventory_from='" & compOfficeid & "')") + countqry("tbltransferbatch", " confirmed=0 and cancelled=0 and inventory_from='" & compOfficeid & "'")
            If forTransferReq > 0 Then
                cmdTransferMgt.Text = "Transfer Management (" & forTransferReq & ")"
                If globalFontColor = "LIGHT" Then
                    cmdTransferMgt.ForeColor = Color.Gold
                Else
                    cmdTransferMgt.ForeColor = Color.Red
                End If
            Else
                cmdTransferMgt.Text = "Transfer Management"
            End If
        End If


        If globalAuthClinicServices = True Then
            Dim reminder As Integer = countqry("tblclinicschedule as a inner join tblclinicservices as b on b.trnid = a.trnid", "b.officeid='" & compOfficeid & "' and date_format(schedule,'%Y-%m-%d') <= '" & ConvertDate(CDate(Now.AddDays(1).ToShortDateString)) & "' and a.cancelled=0 and cleared=0")
            If reminder > 0 Then
                cmdClinicServices.Text = "Spa && Services (" & reminder & ")"
                If globalFontColor = "LIGHT" Then
                    cmdClinicServices.ForeColor = Color.Gold
                Else
                    cmdClinicServices.ForeColor = Color.Red
                End If
            Else
                cmdClinicServices.Text = "Spa && Services"
            End If
        End If


        If globalAuthAssetsManagement = True Then
            Dim flagedFFE As Integer = countqry("tblinventoryffe", "flaged=1 and officeid='" & compOfficeid & "'")
            If flagedFFE > 0 Then
                cmdAssetsManagement.Text = "Fixed Asset Management (" & flagedFFE & ")"
                If globalFontColor = "LIGHT" Then
                    cmdAssetsManagement.ForeColor = Color.Gold
                Else
                    cmdAssetsManagement.ForeColor = Color.Red
                End If
            Else
                cmdAssetsManagement.Text = "Fixed Asset Management"
            End If
        End If

        If globalAuthHouseKeeping = True Then
            Dim Maintainance As Integer = countqry("tblhotelroommaintainance", "enddate<current_timestamp and closed=0")
            If Maintainance > 0 Then
                cmdHouseKeeping.Text = "House Keeping (" & Maintainance & ")"
                If globalFontColor = "LIGHT" Then
                    cmdHouseKeeping.ForeColor = Color.Gold
                Else
                    cmdHouseKeeping.ForeColor = Color.Red
                End If
            Else
                cmdHouseKeeping.Text = "House Keeping"
            End If
        End If
        If globalAuthVIP = True Then
            Dim vip As Integer = countqry("tblsalesvipguest", "checkin=1 and checkout=0")
            If vip > 0 Then
                cmdVIP.Text = "VIP Guest List (" & vip & ")"
                If globalFontColor = "LIGHT" Then
                    cmdVIP.ForeColor = Color.Gold
                Else
                    cmdVIP.ForeColor = Color.Red
                End If
            Else
                cmdVIP.Text = "VIP Guest List"
            End If
        End If

        If globalAuthRoomAppInquiries = True Then
            Dim inq As Integer = countqry("tbltvroominquiries", "cleared=0")
            If inq > 0 Then
                cmdRoomAppInquiries.Text = "Room App Inquiries (" & inq & ")"
                If globalFontColor = "LIGHT" Then
                    cmdRoomAppInquiries.ForeColor = Color.Gold
                Else
                    cmdRoomAppInquiries.ForeColor = Color.Red
                End If
            Else
                cmdRoomAppInquiries.Text = "Room App Inquiries"
            End If
        End If

        If compLowConnectionTagging = True Then
            If Not bw.IsBusy = True Then
                bw.RunWorkerAsync()
            End If
        End If
    End Sub

    Public Sub LoadFormAreaSize()
        Me.Size = New Size(270, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MaximumSize = New Size(270, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MinimumSize = New Size(270, Screen.PrimaryScreen.WorkingArea.Height)
        Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInventoryManagement.Click
        If frmInventorySummary.Visible = False Then
            frmInventorySummary.Show(Me)
        Else
            frmInventorySummary.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewRequest.Click
        If GlobalEnableProcurementPolicy = True Then
            Dim ErrorPolicy As String = "" : Dim errNumber As Integer = 0
            com.CommandText = "CALL sp_procurementpolicy('" & compOfficeid & "')" : rst = com.ExecuteReader
            While rst.Read
                If rst("remarks").ToString.Length > 0 Then
                    errNumber = errNumber + 1
                    ErrorPolicy += errNumber & ". " & rst("remarks").ToString & Environment.NewLine
                End If
            End While
            rst.Close()
            If errNumber > 0 Then
                MessageBox.Show("System disable your requisition because of the following reason:" & Environment.NewLine & Environment.NewLine & ErrorPolicy, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
        'If countqry("tblpurchaseorder", "verified=1 and forpo=1 and tblpurchaseorder.cancelled=0 and delivered=1 and paymentupdated=0 and officeid='" & compOfficeid & "'") > 10 Then
        '    MessageBox.Show("There are 10 pending payable's of your purchase order or payment request! to continue your request please update your payable's first.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If frmRequisition.Visible = False Then
            frmRequisition.Show(Me)
        Else
            frmRequisition.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles cmdRequestManagement.Click
        If frmRequestManagement.Visible = False Then
            frmRequestManagement.Show(Me)
        Else
            frmRequestManagement.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdStockoutManagement.Click
        If frmStockoutsMain.Visible = False Then
            frmStockoutsMain.Show(Me)
        Else
            frmStockoutsMain.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdReceivingofGoods.Click
        frmReceivedTypeSupplier.Show()
    End Sub

    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        ' (max size 163x163 png files)
        If MessageBox.Show("Please use PNG or GIF image file. (Max Resolution 163x163 Pixel size!). Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim objOpenFileDialog As New OpenFileDialog
            'Set the Open dialog properties
            With objOpenFileDialog
                ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
                .Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            'Show the Open dialog and if the user clicks the Open button,
            'load the file
            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim allText As String
                Try
                    'Read the contents of the file
                    allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                    loadimage.ImageLocation = objOpenFileDialog.FileName
                Catch fileException As Exception
                    Throw fileException
                End Try
            End If

            'Clean up
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub mainname_Click(sender As Object, e As EventArgs) Handles lblSystemName.Click
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        frmChatBoxMain.Show()
        'If compEmailaddress = "" Then
        '    MessageBox.Show("You cant use this service, because you have no registered email address in your office account! in order to use this service please contact your procurement officer for your email address and try again. thank you", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        'frmSendMessage.Show(Me)
    End Sub


    Private Sub AboutCoffeecupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCoffeecupToolStripMenuItem.Click
        While BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub ConnectionSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSetupToolStripMenuItem.Click
        If LCase(globalusername) = "root" Then
            frmConnectionSetup.ShowDialog()
        Else
            MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        If frmChatBoxMain.Visible = False Then
            frmChatBoxMain.Show()
        Else
            frmChatBoxMain.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub DoThreadedStuff()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() CheckChatNotification())
        Else
            CheckChatNotification()
        End If
    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        For i = 1 To 1
            Timer1.Stop()
            If bw.CancellationPending = True Then
                e.Cancel = True
                Exit For
            End If
            DoThreadedStuff()
            'System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    Public Sub CheckChatNotification()
        dst2 = New DataSet : dst2.Clear()
        msda2 = New MySqlDataAdapter("select id, message,isnotified,(select fullname from tblaccounts where accountid=tblchatlogs.sender) as namesender from tblchatlogs where receiver='" & globaluserid & "' and isread=0", conn)
        msda2.SelectCommand.CommandTimeout = 6000000
        msda2.Fill(dst2, 0)

        For cnt = 0 To dst2.Tables(0).Rows.Count - 1
            If CBool(dst2.Tables(0).Rows(cnt)("isnotified").ToString()) = False Then
                com.CommandText = "update tblchatlogs set isnotified=1 where id='" & dst2.Tables(0).Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                If frmChatBoxMain.Visible = False Or frmChatBoxMain.WindowState = FormWindowState.Minimized Then
                    NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                    NotifyIcon1.BalloonTipTitle = dst2.Tables(0).Rows(cnt)("namesender").ToString()
                    NotifyIcon1.BalloonTipText = dst2.Tables(0).Rows(cnt)("message").ToString() & Environment.NewLine & "Click here to view chat box.."
                    NotifyIcon1.ShowBalloonTip(1000)
                End If
            End If
        Next

        Dim msg As Integer = dst2.Tables(0).Rows.Count
        If msg > 0 Then
            cmdContexChatBox.Text = "Chat Box (" & msg & ")"
            cmdChatbox.Text = "Chat Box (" & msg & ")"
            cmdChatbox.ForeColor = Color.Red
            cmdContexChatBox.ForeColor = Color.Red

        Else
            cmdContexChatBox.Text = "Show Chat Box"
            cmdChatbox.Text = "Chat Box"
            cmdChatbox.ForeColor = DefaultForeColor
            cmdContexChatBox.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Error IsNot Nothing Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error
            NotifyIcon1.BalloonTipTitle = "Cannot connect to server"
            NotifyIcon1.BalloonTipText = e.Result.ToString
            NotifyIcon1.ShowBalloonTip(1000)
        End If
        Timer1.Start()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If frmSystemInfo.Visible = False Then
            frmSystemInfo.ShowDialog()
        Else
            frmSystemInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If compLowConnectionTagging = False Then
            If Not bw.IsBusy = True Then
                bw.RunWorkerAsync()
            End If
        End If
       
    End Sub


    Private Sub ChangeAccountPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeAccountPasswordToolStripMenuItem.Click
        While BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While
        If frmAccountInformation.Visible = False Then
            frmAccountInformation.Show(Me)
        Else
            frmAccountInformation.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles cmdAdvanceSearch.Click
        If frmPOSProductSearch.Visible = False Then
            frmPOSProductSearch.mode.Text = "searchmode"
            frmPOSProductSearch.Show()
        Else
            frmPOSProductSearch.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtConnectedHost.LinkClicked
        'Process.Start("www.coffeecupsoft.com")
    End Sub

    Private Sub RequestHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRequestHistory.Click
        If frmRequestHistory.Visible = False Then
            frmRequestHistory.Show(Me)
        Else
            frmRequestHistory.WindowState = FormWindowState.Normal
        End If
    End Sub

    'Private Sub cmdSupplierManagement_Click(sender As Object, e As EventArgs)
    '    'If frmSupplierManagement.Visible = False Then
    '    '    frmSupplierManagement.Show(Me)
    '    'Else
    '    '    frmSupplierManagement.WindowState = FormWindowState.Normal
    '    'End If
    'End Sub

    Private Sub cmdPurchaseOrder_Click(sender As Object, e As EventArgs) Handles cmdPurchaseOrder.Click
        If frmPurchaseOrderList.Visible = False Then
            frmPurchaseOrderList.Show()
        Else
            frmPurchaseOrderList.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub cmdAccountsPayable_Click(sender As Object, e As EventArgs) Handles cmdAccountsPayable.Click
        If GlobalEnableAccountingVoucher = True Then
            If frmAcctVoucherList.Visible = False Then
                frmAcctVoucherList.Show()
            Else
                frmAcctVoucherList.WindowState = FormWindowState.Normal
            End If
        Else
            If Globalenablebybranchvoucher = True Then
                If frmAccountsPayable.Visible = False Then
                    frmAccountsPayable.Show()
                Else
                    frmAccountsPayable.WindowState = FormWindowState.Normal
                End If
            Else
                If frmAPDisbursementVoucher.Visible = False Then
                    frmAPDisbursementVoucher.Show()
                Else
                    frmAPDisbursementVoucher.WindowState = FormWindowState.Normal
                End If
            End If

        End If
       
    End Sub
    Private Sub cmdPOS_Click(sender As Object, e As EventArgs) Handles cmdPOS.Click
        Dim overideCurrentTransaction As Boolean = False : Dim tempadmin As Boolean = False
        If Globalrequiredpostoclosed = True And globalTransactionDate <> CDate(Now.ToShortDateString) And Now.ToShortTimeString > "3:00:00" Then
            If MessageBox.Show("Your transaction is need to closed due to system new date! this is to prevent your transaction from erroneous reporting and unproperly sequence. " & Environment.NewLine & Environment.NewLine & "Note: if you want to use your existing transaction, System will ask an administrative approval to overide your request!  " & Environment.NewLine & Environment.NewLine & "Select YES to use current actived transaction." & Environment.NewLine & "Select NO to close current actived transaction.", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                If GlobalStrictadminconfirmed = False Then
                    GlobalStrictadminconfirmed = True
                    tempadmin = True
                End If
                frmPOSAdminConfirmation.ShowDialog(Me)
                If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                    If countrecord("tblsalesbatchsequence") = 0 Then
                        MsgBox("Transaction Batch Code not configure! Please contact your system administrator!", MsgBoxStyle.Exclamation, "Error Message")
                        Exit Sub
                    End If
                    If globalAuthPointofSaleAssistant = True Then
                        frmPOSSalesSelectCashier.ShowDialog()
                        If frmPOSSalesSelectCashier.SelectDone = True Then
                            frmPointOfSale.Show()
                            frmPOSSalesSelectCashier.SelectDone = False
                        End If
                    Else
                        frmPointOfSale.Show()
                    End If
                    frmPOSAdminConfirmation.ApprovedConfirmation = False
                    frmPOSAdminConfirmation.Dispose()
                End If
                If tempadmin = True Then
                    GlobalStrictadminconfirmed = False
                End If
            Else
                If countqry("tblsalesbatch", "trnsumcode='" & globalSalesTrnCOde & "' and floattrn=0 and onhold=0 and void=0 and round(total,2)-(select round(sum(tblsalestransaction.total),2) from tblsalestransaction where batchcode = tblsalesbatch.batchcode and cancelled=0 and void=0) > 0") > 0 Then
                    MessageBox.Show("System found discrepancy transaction on your account please check and correct to prevent system erroneous!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    frmPOSErrorBatchChecker.ShowDialog(Me)
                    Exit Sub
                End If
                If Globalenableposcashdrawer = True Then
                    OpenCashDrawer()
                End If
                frmPOSCloseCashierTransaction.ShowDialog(Me)
                If frmPOSCloseCashierTransaction.TransactionDone = True Then
                    MessageBox.Show("Account transaction successfully closed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmPOSCloseCashierTransaction.TransactionDone = False
                    frmPOSCloseCashierTransaction.Dispose()
                    LoadAccountDetails(globaluserid)
                    Me.Close()
                End If
            End If
        Else
            If countrecord("tblsalesbatchsequence") = 0 Then
                MsgBox("Transaction Batch Code not configure! Please contact your system administrator!", MsgBoxStyle.Exclamation, "Error Message")
                Exit Sub
            End If
            If globalAuthPointofSaleAssistant = True Then
                frmPOSSalesSelectCashier.ShowDialog()
                If frmPOSSalesSelectCashier.SelectDone = True Then
                    frmPointOfSale.Show()
                    frmPOSSalesSelectCashier.SelectDone = False
                End If
            Else
                frmPointOfSale.Show()
            End If
        End If
    End Sub

    Private Sub cmdPumpReading_Click(sender As Object, e As EventArgs) Handles cmdPumpReading.Click
        frmFuelPumpReading.ShowDialog(Me)
    End Sub

    Private Sub NewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdNewTransaction.Click
        If globalBegginingCash > 0 Then
            If MessageBox.Show("Are you sure you want to create new sale transaction?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "insert into tblsalessummary set companyid='" & GlobalCompanyid & "', officeid='" & compOfficeid & "', userid='" & globaluserid & "', " _
                                + " begcash='" & globalBegginingCash & "', " _
                                + " cashfrom='', " _
                                + " dateopen=current_timestamp, " _
                                + " openby='" & globaluserid & "'" : com.ExecuteNonQuery()
                LoadAccountDetails(globaluserid)
                ValidateModule()
                MessageBox.Show("Transaction successfully open!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            frmPOSNewTransaction.ShowDialog()
        End If
    End Sub

    Private Sub cmdChecktoCash_Click(sender As Object, e As EventArgs) Handles cmdChecktoCash.Click
        If frmPOSCheckEncashment.Visible = False Then
            frmPOSCheckEncashment.Show()
        Else
            frmPOSCheckEncashment.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdPostExpense_Click(sender As Object, e As EventArgs) Handles cmdPostExpense.Click
        If frmPOSExpense.Visible = False Then
            frmPOSExpense.Show()
        Else
            frmPOSExpense.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdOtherTransaction_Click(sender As Object, e As EventArgs) Handles cmdOtherTransaction.Click
        If frmPOSOtherTransaction.Visible = False Then
            frmPOSOtherTransaction.Show()
        Else
            frmPOSOtherTransaction.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdCancelTransaction_Click(sender As Object, e As EventArgs) Handles cmdCancelTransaction.Click
        If MessageBox.Show("Are you sure you want to cancel current transaction?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                RollBackInventory()
                com.CommandText = "UPDATE tblsalessummary set openfortrn=0, cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where trncode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "DELETE from tblsalesfuelreading where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalestransaction set cancelled=1, cancelledby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblexpenses set cancelled=1, cancelledby='" & globaluserid & "' where duefromcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "DELETE from tblsalesfuelsold where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesaccounttransaction set cancelled=1, cancelledby='" & globaluserid & "'  where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesothertransaction set cancelled=1, cancelledby='" & globaluserid & "'  where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesreturneditem set cancelled=1, cancelledby='" & globaluserid & "'  where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesbatch set void=1, voidby='" & globaluserid & "'  where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesclientcharges set cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsaleschecktransaction set cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsaleschecktocash set cancelled=1, cancelledby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalescardtransaction set cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalesdepositpaymenttransaction set cancelled=1, datecancelled=current_timestamp, cancelledby='" & globaluserid & "' where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsaleschitbatch set void=1, voidby='" & globaluserid & "'  where trnsumcode='" & globalSalesTrnCOde & "';" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblsalescashpayment set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where trnsumcode='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblpaymenttransactions set cancelled=1, cancelledby='" & globaluserid & "',datecancelled=current_timestamp where depositto='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblsalesclientcharges inner join tblpaymenttransactions on tblsalesclientcharges.paymentrefnumber = tblpaymenttransactions.trnid set paymentupdated=0, paymentrefnumber='' where depositto='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()

                globalSalesOpentrn = False
                ValidateModule()
                MessageBox.Show("Your transaction was successfully cancelled!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If
    End Sub
    Public Sub RollBackInventory()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblsalestransaction where trnsumcode='" & globalSalesTrnCOde & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                StockinInventory("POS Adjustment", .Rows(cnt)("inventorytrnid").ToString(), compOfficeid, .Rows(cnt)("productid").ToString(), .Rows(cnt)("quantity").ToString(), .Rows(cnt)("purchasedprice").ToString(), "cancelled cashier transaction #" + globalSalesTrnCOde, "", "", "")
            End With
        Next
    End Sub
    Public Sub ValidateUserAccounts()
        txtfullname.Text = globalfullname
        txtOffice.Text = compOfficename
        txtPosition.Text = globalposition
        txtDateLogin.Text = Format(Now, "MMMM dd, yyyy hh:mm:ss tt")
        lblSystemName.Text = "Coffeecup v" & fversion

        If LCase(globalusername) = "root" Then
            cmdChangeUserAccounts.Visible = True
        Else
            cmdChangeUserAccounts.Visible = False
        End If

        If EnableModuleSales = True Then
            cmdUserSettings.Visible = True
        Else
            cmdUserSettings.Visible = False
        End If

        If countqry("tblaccountaccess", "userid='" & globaluserid & "'") > 1 Then
            cmdChangeUserAccess.Visible = True
        Else
            cmdChangeUserAccess.Visible = False
        End If
    End Sub

    Public Sub ValidateModule()
        'Advance Search
        If globalAuthAdvanceSearch = True Then
            cmdAdvanceSearch.Visible = True
            lineSearch.Visible = True
        Else
            cmdAdvanceSearch.Visible = False
            lineSearch.Visible = False
        End If

        'Advance Search
        If globalAuthReminders = True Then
            cmdReminders.Visible = True
            lineReminders.Visible = True
        Else
            cmdReminders.Visible = False
            lineReminders.Visible = False
        End If

        'for approval
        If globalAuthForApproval = True Then
            cmdforapproval.Visible = True
            lineforapproval.Visible = True
        Else
            cmdforapproval.Visible = False
            lineforapproval.Visible = False
        End If

        'Approval History
        If globalAuthApprovalHistory = True Then
            cmdApprovalHistory.Visible = True
            lineApprovalHistory.Visible = True
        Else
            cmdApprovalHistory.Visible = False
            lineApprovalHistory.Visible = False
        End If

        'void transaction
        If globalAuthVoidTransaction = True Then
            cmdVoidTransaction.Visible = True
            lineVoidTransaction.Visible = True
        Else
            cmdVoidTransaction.Visible = False
            lineVoidTransaction.Visible = False
        End If

        'Point of Sale
        If globalAuthPointofSale = True Then
            cmdPOS.Visible = True
            linePOS.Visible = True
        Else
            cmdPOS.Visible = False
            linePOS.Visible = False
        End If

        'Point of Sale
        If globalAuthVIP = True Then
            cmdVIP.Visible = True
            lineVip.Visible = True
        Else
            cmdVIP.Visible = False
            lineVip.Visible = False
        End If

        'Cash Change
        If globalAuthCashChange = True Then
            cmdChecktoCash.Visible = True
            lineCheckToCash.Visible = True
        Else
            cmdChecktoCash.Visible = False
            lineCheckToCash.Visible = False
        End If

        'Post Expense
        If globalAuthPostExpense = True Then
            cmdPostExpense.Visible = True
            linePostExpense.Visible = True
        Else
            cmdPostExpense.Visible = False
            linePostExpense.Visible = False
        End If

        'Client Accounts Transaction
        If globalAuthAccountsJournalEntries = True Then
            cmdAccountJournal.Visible = True
            lineAccountJournal.Visible = True
        Else
            cmdAccountJournal.Visible = False
            lineAccountJournal.Visible = False
        End If

        'Client Accounts Transaction
        If globalAuthClientAccountsTransaction = True Then
            cmdClientJournal.Visible = True
            lineClientJournal.Visible = True
        Else
            cmdClientJournal.Visible = False
            lineClientJournal.Visible = False
        End If

        'journal entries
        If globalAuthJournalEntries = True Then
            cmdJournalEntries.Visible = True
            lineJournalEntries.Visible = True
        Else
            cmdJournalEntries.Visible = False
            lineJournalEntries.Visible = False
        End If

        'Client Accounts Payments
        If globalAuthClientAccountsPayment = True Then
            cmdClientPayment.Visible = True
            lineClientPayment.Visible = True
        Else
            cmdClientPayment.Visible = False
            lineClientPayment.Visible = False
        End If

        'Delivery
        If globalAuthsalesdelivery = True Then
            cmdDeliverySlip.Visible = True
            lineDeliverySlip.Visible = True
        Else
            cmdDeliverySlip.Visible = False
            lineDeliverySlip.Visible = False
        End If

        'Other Transaction
        If globalAuthOtherTransaction = True Then
            cmdOtherTransaction.Visible = True
            lineOtherTransaction.Visible = True
        Else
            cmdOtherTransaction.Visible = False
            lineOtherTransaction.Visible = False
        End If

        'Return Item
        If globalAuthReturnitem = True Then
            cmdReturnItem.Visible = True
            lineReturnItem.Visible = True
        Else
            cmdReturnItem.Visible = False
            lineReturnItem.Visible = False
        End If

        'Auto Services
        If globalAuthAutoServices = True Then
            cmdAutoServices.Visible = True
            lineAutoServices.Visible = True
        Else
            cmdAutoServices.Visible = False
            lineAutoServices.Visible = False
        End If

        'clinic Services
        If globalAuthClinicServices = True Then
            cmdClinicServices.Visible = True
            lineClinicServices.Visible = True
        Else
            cmdClinicServices.Visible = False
            lineClinicServices.Visible = False
        End If

        'Pump Reading
        If globalAuthPumpReading = True Then
            cmdPumpReading.Visible = True
            linePumpReading.Visible = True
        Else
            cmdPumpReading.Visible = False
            linePumpReading.Visible = False
        End If

        'employee attendance
        If globalAuthEmployeeAttendance = True Then
            cmdEmployeeAttendance.Visible = True
            lineEmployeeAttendance.Visible = True
        Else
            cmdEmployeeAttendance.Visible = False
            lineEmployeeAttendance.Visible = False
        End If

        'employee attendance
        If globalAuthComplaintBox = True Then
            cmdComplaintBox.Visible = True
            lineComplaintBox.Visible = True
        Else
            cmdComplaintBox.Visible = False
            lineComplaintBox.Visible = False
        End If

        'New Requisition
        If globalAuthNewRequisition = True Then
            cmdnewRequest.Visible = True
            lineNewRequisition.Visible = True
            cmdRequestHistory.Visible = True
        Else
            cmdnewRequest.Visible = False
            lineNewRequisition.Visible = False
            cmdRequestHistory.Visible = False
        End If

        'Purchase order
        If globalAuthPurchaseOrder = True Then
            cmdPurchaseOrder.Visible = True
            linePurchaseOrder.Visible = True
        Else
            cmdPurchaseOrder.Visible = False
            linePurchaseOrder.Visible = False
        End If

        If globalAuthReceivingReport = True Then
            cmdReceivingReport.Visible = True
            lineReceivingReport.Visible = True
        Else
            cmdReceivingReport.Visible = False
            lineReceivingReport.Visible = False
        End If


        'Accounts payable
        If globalAuthAccountsPayable = True Then
            cmdAccountsPayable.Visible = True
            lineAccountsPayable.Visible = True
        Else
            cmdAccountsPayable.Visible = False
            lineAccountsPayable.Visible = False
        End If

        'receiving of goods
        If globalAuthReceivingofGoods = True Then
            cmdReceivingofGoods.Visible = True
            lineReceivingofGoods.Visible = True
        Else
            cmdReceivingofGoods.Visible = False
            lineReceivingofGoods.Visible = False
        End If

        If globalAuthReceivingTransfer = True Then
            cmdReceivingTransfer.Visible = True
            lineReceivingTransfer.Visible = True
        Else
            cmdReceivingTransfer.Visible = False
            lineReceivingTransfer.Visible = False
        End If

        'requisition management
        If globalAuthRequisitionManagement = True Then
            cmdRequestManagement.Visible = True
            lineRequestManagement.Visible = True
        Else
            cmdRequestManagement.Visible = False
            lineRequestManagement.Visible = False
        End If

        'inventory management
        If globalAuthInventoryManagement = True Then
            cmdInventoryManagement.Visible = True
            lineInventoryManagement.Visible = True
        Else
            cmdInventoryManagement.Visible = False
            lineInventoryManagement.Visible = False
        End If

        'Transfer management
        If globalAuthTransferManagement = True Then
            cmdTransferMgt.Visible = True
            lineTransferMgt.Visible = True
        Else
            cmdTransferMgt.Visible = False
            lineTransferMgt.Visible = False
        End If

        'stockout management
        If globalAuthStockoutManagement = True Then
            cmdStockoutManagement.Visible = True
            lineStockOutManagement.Visible = True
        Else
            cmdStockoutManagement.Visible = False
            lineStockOutManagement.Visible = False
        End If

        'assets management
        If globalAuthAssetsManagement = True Then
            cmdAssetsManagement.Visible = True
            lineAssestManagement.Visible = True
        Else
            cmdAssetsManagement.Visible = False
            lineAssestManagement.Visible = False
        End If

        'Hotel Room App Inquiries
        If globalAuthRoomAppInquiries = True Then
            cmdRoomAppInquiries.Visible = True
            lineRoomAppInquiries.Visible = True
        Else
            cmdRoomAppInquiries.Visible = False
            lineRoomAppInquiries.Visible = False
        End If

        'Hotel Reservation
        If globalAuthHotelReservation = True Then
            cmdHotelReservation.Visible = True
            lineHotelReservation.Visible = True
        Else
            cmdHotelReservation.Visible = False
            lineHotelReservation.Visible = False
        End If

        'Hotel Management
        If globalAuthHotelManagement = True Then
            cmdHotelMgt.Visible = True
            lineHotelMgt.Visible = True
        Else
            cmdHotelMgt.Visible = False
            lineHotelMgt.Visible = False
        End If

        'House Keeping Management
        If globalAuthHouseKeeping = True Then
            cmdHouseKeeping.Visible = True
            lineHouseKeeping.Visible = True
        Else
            cmdHouseKeeping.Visible = False
            lineHouseKeeping.Visible = False
        End If

        'Tables and Cottages
        If globalAuthTablesAndCottages = True Then
            cmdTablesAndCottages.Visible = True
            lineTablesAndCottages.Visible = True
        Else
            cmdTablesAndCottages.Visible = False
            lineTablesAndCottages.Visible = False
        End If

        'Room Occupancy
        If globalAuthRoomOccupancy = True Then
            cmdRoomOccupancy.Visible = True
            lineRoomOccupancy.Visible = True
        Else
            cmdRoomOccupancy.Visible = False
            lineRoomOccupancy.Visible = False
        End If

        'Report Generator
        If globalAuthReportGenerator = True Then
            cmdReportGenerator.Visible = True
            lineReportGenerator.Visible = True
        Else
            cmdReportGenerator.Visible = False
            lineReportGenerator.Visible = False
        End If

        Dim PanelHeight As Double = 0
        For Each itm In ToolStrip.Items
            If TypeOf itm Is ToolStripButton Or TypeOf itm Is ToolStripSeparator Then
                If itm.Visible = True Then
                    PanelHeight += itm.Height + itm.Padding.Top + itm.Padding.Bottom + itm.Margin.Top + itm.Margin.Bottom
                End If
            End If
        Next
        ToolStrip.Height = PanelHeight
        Panel1.Top = PanelHeight - 2

        If EnableModuleSales = True Then
            VerifyOpenTransaction()
        End If
    End Sub

    Public Sub VerifyOpenTransaction()
        If globalSalesOpentrn = True Then
            If globalAuthPointofSaleAssistant = True Then
                cmdCancelTransaction.Visible = False
                cmdCloseTransaction.Visible = False
            Else
                cmdCancelTransaction.Visible = True
                cmdCloseTransaction.Visible = True
            End If

            'SALES MODULE
            cmdPOS.Enabled = True
            cmdPumpReading.Enabled = True
            cmdChecktoCash.Enabled = True
            cmdPostExpense.Enabled = True
            cmdAccountJournal.Enabled = True
            cmdClientJournal.Enabled = True
            cmdClientPayment.Enabled = True
            cmdDeliverySlip.Enabled = True

            'HOTEL MODULE
            cmdTablesAndCottages.Enabled = True
            cmdRoomOccupancy.Enabled = True

            cmdOtherTransaction.Enabled = True
            cmdReturnItem.Enabled = True
            cmdNewTransaction.Visible = False
            cmdBackdateTransaction.Visible = False
        Else
            If globalAuthPointofSaleAssistant = True Then
                cmdPOS.Enabled = True
                cmdNewTransaction.Visible = False
                cmdBackdateTransaction.Visible = False
            Else
                cmdPOS.Enabled = False
                If globalAuthPointofSale = True Then
                    cmdNewTransaction.Visible = True
                    If Globalenablebackdatetrn = True Then
                        cmdBackdateTransaction.Visible = True
                    Else
                        cmdBackdateTransaction.Visible = False
                    End If
                Else
                    cmdNewTransaction.Visible = False
                    cmdBackdateTransaction.Visible = False
                End If
            End If
            'SALES MODULE
            cmdPumpReading.Enabled = False
            cmdChecktoCash.Enabled = False
            cmdPostExpense.Enabled = False
            cmdAccountJournal.Enabled = False
            cmdClientJournal.Enabled = False
            cmdClientPayment.Enabled = False
            cmdDeliverySlip.Enabled = False
            cmdOtherTransaction.Enabled = False
            cmdReturnItem.Enabled = False

            'HOTEL MODULE
            'cmdTablesAndCottages.Enabled = False
            'cmdRoomOccupancy.Enabled = False
            cmdCloseTransaction.Visible = False
            cmdCancelTransaction.Visible = False
        End If
    End Sub


    Public Sub hideAllMenu(ByVal showMenu As Boolean)
        cmdNewTransaction.Visible = showMenu
        cmdCloseTransaction.Visible = showMenu
        cmdCancelTransaction.Visible = showMenu
        cmdRequestHistory.Visible = showMenu

        cmdAdvanceSearch.Visible = showMenu
        lineSearch.Visible = showMenu
        cmdReminders.Visible = showMenu
        lineReminders.Visible = showMenu
        cmdPOS.Visible = showMenu
        linePOS.Visible = showMenu
        cmdVIP.Visible = showMenu
        lineVip.Visible = showMenu
        cmdPumpReading.Visible = showMenu
        linePumpReading.Visible = showMenu
        cmdChecktoCash.Visible = showMenu
        lineCheckToCash.Visible = showMenu
        cmdPostExpense.Visible = showMenu
        linePostExpense.Visible = showMenu
        cmdAccountJournal.Visible = showMenu
        lineAccountJournal.Visible = showMenu
        cmdClientJournal.Visible = showMenu
        lineClientJournal.Visible = showMenu
        cmdJournalEntries.Visible = showMenu
        lineJournalEntries.Visible = showMenu
        cmdClientPayment.Visible = showMenu
        lineClientPayment.Visible = showMenu
        cmdDeliverySlip.Visible = showMenu
        lineDeliverySlip.Visible = showMenu
        cmdOtherTransaction.Visible = showMenu
        lineOtherTransaction.Visible = showMenu
        cmdReturnItem.Visible = showMenu
        lineReturnItem.Visible = showMenu
        cmdAutoServices.Visible = showMenu
        lineAutoServices.Visible = showMenu
        cmdClinicServices.Visible = showMenu
        lineClinicServices.Visible = showMenu
        cmdnewRequest.Visible = showMenu
        lineNewRequisition.Visible = showMenu
        cmdforapproval.Visible = showMenu
        lineforapproval.Visible = showMenu
        cmdApprovalHistory.Visible = showMenu
        lineApprovalHistory.Visible = showMenu
        cmdVoidTransaction.Visible = showMenu
        lineVoidTransaction.Visible = showMenu
        cmdPurchaseOrder.Visible = showMenu
        linePurchaseOrder.Visible = showMenu
        cmdReceivingReport.Visible = showMenu
        lineReceivingReport.Visible = showMenu
        cmdAccountsPayable.Visible = showMenu
        lineAccountsPayable.Visible = showMenu
        cmdReceivingofGoods.Visible = showMenu
        lineReceivingofGoods.Visible = showMenu
        cmdReceivingTransfer.Visible = showMenu
        lineReceivingTransfer.Visible = showMenu
        cmdTransferMgt.Visible = showMenu
        lineTransferMgt.Visible = showMenu
        cmdRequestManagement.Visible = showMenu
        lineRequestManagement.Visible = showMenu
        cmdInventoryManagement.Visible = showMenu
        lineInventoryManagement.Visible = showMenu
        cmdStockoutManagement.Visible = showMenu
        lineStockOutManagement.Visible = showMenu
        cmdAssetsManagement.Visible = showMenu
        lineAssestManagement.Visible = showMenu
        cmdRoomAppInquiries.Visible = showMenu
        lineRoomAppInquiries.Visible = showMenu
        cmdHotelReservation.Visible = showMenu
        lineHotelReservation.Visible = showMenu
        cmdHotelMgt.Visible = showMenu
        lineHotelMgt.Visible = showMenu
        cmdHouseKeeping.Visible = showMenu
        lineHouseKeeping.Visible = showMenu
        cmdRoomOccupancy.Visible = showMenu
        lineRoomOccupancy.Visible = showMenu
        cmdTablesAndCottages.Visible = showMenu
        lineTablesAndCottages.Visible = showMenu
        cmdEmployeeAttendance.Visible = showMenu
        lineEmployeeAttendance.Visible = showMenu
        cmdComplaintBox.Visible = showMenu
        lineComplaintBox.Visible = showMenu
        cmdReportGenerator.Visible = showMenu
        lineReportGenerator.Visible = showMenu
    End Sub

    Private Sub ProcessFlowAndFeaturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessFlowAndFeaturesToolStripMenuItem.Click
        Dim whats_new_location As String = Application.StartupPath.ToString & "\processflow.pdf"
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(whats_new_location)
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub

    Private Sub cmdforapproval_Click(sender As Object, e As EventArgs) Handles cmdforapproval.Click
        If globalCorporateApprover = True And globalBranchApprover = True And globalapproveanyoffices = True Then
            If frmApprovingType.Visible = False Then
                frmApprovingType.Show(Me)
            Else
                frmApprovingType.WindowState = FormWindowState.Normal
            End If

        ElseIf globalCorporateApprover = True Then
            If frmCorpForApprovalList.Visible = False Then
                frmCorpForApprovalList.Show(Me)
            Else
                frmCorpForApprovalList.WindowState = FormWindowState.Normal
            End If

        ElseIf globalBranchApprover = True Or globalapproveanyoffices = True Then
            If frmBranchForApprovalList.Visible = False Then
                frmBranchForApprovalList.Show(Me)
            Else
                frmBranchForApprovalList.WindowState = FormWindowState.Normal
            End If
        Else
            MessageBox.Show("You are not authorized to approved any request!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub


    Private Sub cmdApprovalHistory_Click(sender As Object, e As EventArgs) Handles cmdApprovalHistory.Click
        If frmApprovalHistory.Visible = False Then
            frmApprovalHistory.Show(Me)
        Else
            frmApprovalHistory.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdUserSettings_Click(sender As Object, e As EventArgs) Handles cmdUserSettings.Click
        frmPOSPrinterSettings.ShowDialog(Me)
    End Sub

    Private Sub cmdSudgestionBox_Click(sender As Object, e As EventArgs) Handles cmdSudgestionBox.Click
        frmSudgestionBox.Show(Me)
    End Sub

    Private Sub cmdAssetsManagement_Click(sender As Object, e As EventArgs) Handles cmdAssetsManagement.Click
        frmInventoryFFE.Show(Me)
    End Sub

    Private Sub cmdTablesAndCottages_Click(sender As Object, e As EventArgs) Handles cmdTablesAndCottages.Click

        If frmHotelCottagesSummary.Visible = False Then
            frmHotelCottagesSummary.Show()
        Else
            frmHotelCottagesSummary.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdTransferMgt_Click(sender As Object, e As EventArgs) Handles cmdTransferMgt.Click
        frmTransferType.Show(Me)
    End Sub

    Private Sub cmdReturnItem_Click(sender As Object, e As EventArgs) Handles cmdReturnItem.Click
        If frmPOSReturnedItem.Visible = False Then
            frmPOSReturnedItem.Show()
        Else
            frmPOSReturnedItem.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdAccountTransaction_Click(sender As Object, e As EventArgs) Handles cmdClientJournal.Click
        If frmPOSClientAccountTransaction.Visible = False Then
            frmPOSClientAccountTransaction.Show()
        Else
            frmPOSClientAccountTransaction.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdClientPayment_Click(sender As Object, e As EventArgs) Handles cmdClientPayment.Click
        If frmPOSClientAccountPayment.Visible = False Then
            frmPOSClientAccountPayment.Show()
        Else
            frmPOSClientAccountPayment.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdDeliverySlip_Click(sender As Object, e As EventArgs) Handles cmdDeliverySlip.Click
        If frmPOSDeliverySlip.Visible = False Then
            frmPOSDeliverySlip.Show()
        Else
            frmPOSDeliverySlip.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdCheckin_Click(sender As Object, e As EventArgs) Handles cmdHotelMgt.Click
        If countqry("tblgeneralsettings", "tempdisablehotel=1") > 0 And LCase(globalusername) <> "root" Then
            MessageBox.Show("Hotel management and reservation currently migrating database. please wait a couple of minutes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If countqry(" tblhotelfilter ", "permissioncode='" & globalAuthcode & "'") = 0 Then
            MessageBox.Show("Your account currently not assign to a room filter! Please contact your system administrator", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        HotelOperationMode = True
        If frmHotelManagementv2.Visible = False Then
            frmHotelManagementv2.Show()
        Else
            frmHotelManagementv2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdRoomOccupancy_Click(sender As Object, e As EventArgs) Handles cmdRoomOccupancy.Click
        If countqry("tblgeneralsettings", "tempdisablehotel=1") > 0 And LCase(globalusername) <> "root" Then
            MessageBox.Show("Hotel management and reservation currently migrating database. please wait a couple of minutes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If frmHotelRoomOccupancy.Visible = False Then
            frmHotelRoomOccupancy.Show()
        Else
            frmHotelRoomOccupancy.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdChangeUserAccess_Click(sender As Object, e As EventArgs) Handles cmdChangeUserAccess.Click
        frmChangeUserAccess.Show()
    End Sub

    Private Sub cmdBackdateTransaction_Click(sender As Object, e As EventArgs)
        frmPOSNewTransaction.ShowDialog()
    End Sub

    Private Sub cmdReminders_Click(sender As Object, e As EventArgs) Handles cmdReminders.Click
        frmReminders.Show()
    End Sub

    Private Sub cmdAccountJournal_Click(sender As Object, e As EventArgs) Handles cmdAccountJournal.Click
        If frmPOSAccountJournal.Visible = False Then
            frmPOSAccountJournal.Show()
        Else
            frmPOSAccountJournal.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdAutoServices_Click(sender As Object, e As EventArgs) Handles cmdAutoServices.Click
        If frmAutoServices.Visible = False Then
            frmAutoServices.Show()
        Else
            frmAutoServices.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub cmdBackdateTransaction_Click_1(sender As Object, e As EventArgs) Handles cmdBackdateTransaction.Click
        frmPOSBackdateTransaction.ShowDialog()
    End Sub

    Private Sub cmdJournalEntries_Click(sender As Object, e As EventArgs) Handles cmdJournalEntries.Click
        If frmGLJournalInformation.Visible = False Then
            frmGLJournalInformation.Show()
        Else
            frmGLJournalInformation.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdHouseKeeping_Click(sender As Object, e As EventArgs) Handles cmdHouseKeeping.Click
        If Globalenablehousekeepingmonitoring = False Then
            MessageBox.Show("House keeping function currently disabled! Please contact your system administrator", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If frmHotelRoomForHouseKeeping.Visible = False Then
                frmHotelRoomForHouseKeeping.Show()
            Else
                frmHotelRoomForHouseKeeping.WindowState = FormWindowState.Normal
            End If
            If countqry("tblhotelroommaintainance", "enddate<current_timestamp and closed=0") > 0 Then
                frmHotelRoomForHouseKeeping.TabControl1.SelectedTab = frmHotelRoomForHouseKeeping.tabMaintainance
            End If

        End If
    End Sub

    Private Sub cmdVoidTransaction_Click(sender As Object, e As EventArgs) Handles cmdVoidTransaction.Click
        If frmPOSVoidTransaction.Visible = False Then
            frmPOSVoidTransaction.Show()
        Else
            frmPOSVoidTransaction.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdChangeUserAccounts_Click(sender As Object, e As EventArgs) Handles cmdChangeUserAccounts.Click
        If frmAdminChangeUser.Visible = False Then
            frmAdminChangeUser.Show()
        Else
            frmAdminChangeUser.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub cmdClinicServices_Click(sender As Object, e As EventArgs) Handles cmdClinicServices.Click
        If frmClinicServices.Visible = False Then
            frmClinicServices.Show(Me)
        Else
            frmClinicServices.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub POSPoleDisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSPoleDisplayToolStripMenuItem.Click
        If frmPOSPoleDisplaySettings.Visible = False Then
            frmPOSPoleDisplaySettings.Show(Me)
        Else
            frmPOSPoleDisplaySettings.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdHotelReservation_Click(sender As Object, e As EventArgs) Handles cmdHotelReservation.Click
        If countqry("tblgeneralsettings", "tempdisablehotel=1") > 0 And LCase(globalusername) <> "root" Then
            MessageBox.Show("Hotel management and reservation currently migrating database. please wait a couple of minutes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If countqry(" tblhotelfilter ", "permissioncode='" & globalAuthcode & "'") = 0 Then
            MessageBox.Show("Your account currently not assign to a room filter! Please contact your system administrator", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        HotelOperationMode = False
        If frmHotelManagementv2.Visible = False Then
            frmHotelManagementv2.Show()
        Else
            frmHotelManagementv2.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub cmdEmployeeAttendance_Click(sender As Object, e As EventArgs) Handles cmdEmployeeAttendance.Click
        If frmEmployeeList.Visible = False Then
            frmEmployeeList.Show(Me)
        Else
            frmEmployeeList.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CloseTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCloseTransaction.Click
        If countqry("tblsalesbatch", "floattrn=1 and onhold=0 and void=0 and forcashiertrn=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 Then
            MessageBox.Show("System found an recovered transaction was not validated yet!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf countqry("tblsalesbatch", "forcashiertrn=1 and trnsumcode='" & globalSalesTrnCOde & "' and void=0") > 0 Then
            MessageBox.Show("System found pending order slip transaction was not validated yet!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf countqry("tblsalesbatch", "trnsumcode='" & globalSalesTrnCOde & "' and floattrn=0 and onhold=0 and  void=0 and round(total,2)-(select round(sum(tblsalestransaction.total),2) from tblsalestransaction where batchcode = tblsalesbatch.batchcode and cancelled=0 and void=0) > 0") > 0 Then
            MessageBox.Show("System found discrepancy transaction on your account please check and correct to prevent system erroneous!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            frmPOSErrorBatchChecker.ShowDialog(Me)
            Exit Sub
        End If
        If Globalenableposcashdrawer = True Then
            OpenCashDrawer()
        End If
        frmPOSCloseCashierTransaction.ShowDialog(Me)
        If frmPOSCloseCashierTransaction.TransactionDone = True Then
            MessageBox.Show("Account transaction successfully closed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPOSCloseCashierTransaction.TransactionDone = False
            frmPOSCloseCashierTransaction.Dispose()
            LoadAccountDetails(globaluserid)
            Me.Close()
        End If
    End Sub

    Private Sub cmdReportGenerator_Click(sender As Object, e As EventArgs) Handles cmdReportGenerator.Click
        If frmReportType.Visible = False Then
            frmReportType.Show(Me)
        Else
            frmReportType.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdComplaintBox_Click(sender As Object, e As EventArgs) Handles cmdComplaintBox.Click
        If frmComplaintBox.Visible = False Then
            frmComplaintBox.Show(Me)
        Else
            frmComplaintBox.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdVIP_Click(sender As Object, e As EventArgs) Handles cmdVIP.Click
        If frmVIPOnline.Visible = False Then
            frmVIPOnline.Show(Me)
        Else
            frmVIPOnline.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdReceivingTransfer_Click(sender As Object, e As EventArgs) Handles cmdReceivingTransfer.Click
        frmReceivedTypeTransfer.Show()
    End Sub

    Private Sub Profileimg_Click(sender As Object, e As EventArgs) Handles Profileimg.Click
        If frmAccountInformation.Visible = True Then
            frmAccountInformation.Focus()
        Else
            frmAccountInformation.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdChatbox_Click(sender As Object, e As EventArgs) Handles cmdChatbox.Click
        If frmChatBoxMain.Visible = True Then
            frmChatBoxMain.Focus()
        Else
            frmChatBoxMain.Show()
        End If
        frmChatBoxMain.ListControl1.Focus()
    End Sub

    Private Sub settingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdContexChatBox.Click
        If frmChatBoxMain.Visible = True Then
            frmChatBoxMain.Focus()
        Else
            frmChatBoxMain.Show()
        End If
        frmChatBoxMain.ListControl1.Focus()
    End Sub

    Private Sub cmdRoomAppInquiries_Click(sender As Object, e As EventArgs) Handles cmdRoomAppInquiries.Click
        If frmHotelAppInquiries.Visible = True Then
            frmHotelAppInquiries.Focus()
        Else
            frmHotelAppInquiries.Show()
        End If
    End Sub

    Private Sub cmdReceivingReport_Click(sender As Object, e As EventArgs) Handles cmdReceivingReport.Click
        If frmReceivingReport.Visible = True Then
            frmReceivingReport.Focus()
        Else
            frmReceivingReport.Show()
        End If
    End Sub

End Class
