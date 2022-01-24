Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports System.Drawing.Text

Public Class frmPointOfSale
    Public getProductid As String
    Public walkinEnable As Boolean

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            txtBarCode.Focus()

        ElseIf keyData = Keys.Control + Keys.F12 Then
            OpenCashDrawer()

        ElseIf keyData = Keys.Control + Keys.B Then
            frmPOScashDonimination.Show(Me)

        ElseIf keyData = Keys.F1 Then
            cmdPendingOrderSlip.PerformClick()

        ElseIf keyData = Keys.F2 Then
            cmdOnholdTransaction.PerformClick()

        ElseIf keyData = Keys.F3 Then
            cmdProductSearch.PerformClick()

        ElseIf keyData = Keys.F4 Then
            cmdRecoveredTransaction.PerformClick()

        ElseIf keyData = Keys.F5 Then
            cmdNewClient.PerformClick()


        ElseIf keyData = Keys.F6 Then
            If globalAuthPointofSaleAssistant = False Then
                cmdTransactionHistory.PerformClick()
            End If

        ElseIf keyData = Keys.F7 Then
            cmdDiscount.PerformClick()
        
        ElseIf keyData = Keys.F8 Then
            cmdCancelLine.PerformClick()

        ElseIf keyData = Keys.F9 Then
            cmdEditLine.PerformClick()

        ElseIf keyData = Keys.F10 Then
            cmdHold.PerformClick()

        ElseIf keyData = Keys.F11 Then
            cmdVoidTransaction.PerformClick()

        ElseIf keyData = Keys.Tab And txtClient.Focused = True Then
            txtBarCode.Focus()

        ElseIf keyData = Keys.F12 Then
            cmdChargeClientAccount.PerformClick()

        ElseIf keyData = Keys.Up And txtBarCode.Focused = True Then
            txtQuantity.Focus()
            txtBarCode.Text = ""

        ElseIf keyData = Keys.Down And txtQuantity.Focused = True Then
            If txtBarCode.Text = "" Then
                txtBarCode.Focus()
            End If

        ElseIf keyData = Keys.Alt + Keys.T Then
            MyDataGridView.Focus()

        ElseIf keyData = Keys.Alt + Keys.Q Then
            txtQuantity.Focus()

        ElseIf keyData = Keys.Space Then
            If txtBarCode.Focus = False Then
                txtBarCode.Focus()
            End If

        ElseIf keyData = Keys.Alt + Keys.R Then
            cmdDiscount.PerformClick()

        ElseIf keyData = Keys.Alt + Keys.V Then
            On Error Resume Next
            Dim colname As String = ""
            For i = 0 To MyDataGridView.ColumnCount - 1
                colname += MyDataGridView.Columns(i).Name & ","
            Next
            frmColumnChooser.txttype.Text = Me.Name
            frmColumnChooser.init_grid(MyDataGridView)
            frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
            frmColumnChooser.Show(Me)

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPointOfSale_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim orderslip As Integer = countqry("tblsalesbatch", "forcashiertrn=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "'")
        If orderslip > 0 Then
            If globalFontColor = "LIGHT" Then
                cmdPendingOrderSlip.ForeColor = Color.Gold
            Else
                cmdPendingOrderSlip.ForeColor = Color.Red
            End If
            cmdPendingOrderSlip.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            cmdPendingOrderSlip.Text = "Pending Order Slip F1 (" & orderslip & ")"
        Else
            If globalFontColor = "LIGHT" Then
                cmdPendingOrderSlip.ForeColor = Color.LightGray
            Else
                cmdPendingOrderSlip.ForeColor = Color.Black
            End If
            '  cmdPendingOrderSlip.ForeColor = Color.White
            cmdPendingOrderSlip.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            cmdPendingOrderSlip.Text = "Pending Order Slip F1"
        End If

        Dim onholdtrn As Integer = 0
        If Globalallowaccessallonhold = True Then
            onholdtrn = countqry("tblsalesbatch", "onhold=1 and void=0")
        Else
            onholdtrn = countqry("tblsalesbatch", "onhold=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "' " & If(globalAssistantUserId = "", "", " and attendingperson='" & globalAssistantUserId & "'"))
        End If

        If onholdtrn > 0 Then
            If globalFontColor = "LIGHT" Then
                cmdOnholdTransaction.ForeColor = Color.Gold
            Else
                cmdOnholdTransaction.ForeColor = Color.Red
            End If
            cmdOnholdTransaction.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            If GlobalEnableQueuingSlip = True And countqry("tblsalesqueuingfilter", "permissioncode='" & globalAuthcode & "'") > 0 Then
                cmdOnholdTransaction.Text = GlobalQueuingSlipType + " F2 (" & onholdtrn & ")"
            Else
                cmdOnholdTransaction.Text = "On Hold F2 (" & onholdtrn & ")"
            End If
        Else
            If globalFontColor = "LIGHT" Then
                cmdOnholdTransaction.ForeColor = Color.LightGray
            Else
                cmdOnholdTransaction.ForeColor = Color.Black
            End If
            cmdOnholdTransaction.Font = New Font("Segoe UI", 9, FontStyle.Regular)

            If GlobalEnableQueuingSlip = True And countqry("tblsalesqueuingfilter", "permissioncode='" & globalAuthcode & "'") > 0 Then
                cmdOnholdTransaction.Text = GlobalQueuingSlipType + " F2"
            Else
                cmdOnholdTransaction.Text = "On Hold F2"
            End If
        End If
        grpBarcode.Focus()
        If txtBarCode.Text = "" Then
            txtBarCode.Focus()
        End If
        showCreditLimit()
    End Sub

    Public Sub showCreditLimit()
        If countqry("tblclientaccounts", "cifid='" & cifid.Text & "' and creditlimit=1") > 0 Then
            lblCreditLimit.Visible = True
            Dim remainingcredit As Double = Val(qrysingledata("creditlimitamount", "creditlimitamount", "tblclientaccounts where cifid='" & cifid.Text & "'")) - (Val(qrysingledata("totaldue", "sum(debit)-sum(credit) as totaldue", "tblglaccountledger where accountno='" & cifid.Text & "' and cancelled=0")) + Val(qrysingledata("amount", "amount", "tblsalesclientcharges where accountno='" & cifid.Text & "' and verified=0 and cancelled=0")))
            lblCreditLimit.Text = "Credit Limit: " & FormatNumber(remainingcredit, 2)
        Else
            lblCreditLimit.Visible = False
        End If
    End Sub

    Private Sub frmPointOfSale_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPointOfSale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Val(txtTotalItem.Text) > 0 Then
            If MessageBox.Show("System found current transaction is not validated yet! are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSVoidConfirmation.ShowDialog(Me)
                If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                    VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                    BeginNewTransaction()
                    MsgBox("Transaction Successfully Void!", MsgBoxStyle.Information)
                    frmPOSVoidConfirmation.ApprovedConfirmation = False
                    frmPOSVoidConfirmation.Dispose()
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        MyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        If Globalenableposviewrowborder = False Then
            MyDataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
            MyDataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        End If
        If Globalenableposviewcolborder = False Then
            MyDataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
            MyDataGridView.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        End If
        If Globalenableclientfilter = True Then
            If countqry("tblclientaccounts", "walkinaccount=1  and groupcode in (select clientgroup from tblclientfilter where permissioncode='" & globalAuthcode & "')") > 0 Then
                walkinEnable = True
            Else
                walkinEnable = False
            End If
        Else
            walkinEnable = True
        End If

        Me.Text = Me.Text + " (SHIFT TRANSACTION CODE: " & globalSalesTrnCOde & ")"
        lblVat.Text = "VAT " & GlobalTaxRate & "%"
        lblSVC.Text = "SVC " & GlobalServiceChargeRate & "%"
        'Me.Size = New Size(1034, 616) ' load default size standard for small screen

        lblDigitalHeader.Text = UCase(GlobalOrganizationName.Replace("&", "&&")) & Chr(13) & "Coffeecup Computing System"
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\pos.png") = True Then
            PictureEdit1.Image = Image.FromFile(Application.StartupPath.ToString & "\Logo\pos.png")
        End If
        If globalBackDateTransaction = True Then
            txtDateTransaction.Text = Format(globalBackDate.ToString("MMMM dd, yyyy")) & " " & Format(Now.ToString("hh:mm:ss tt"))
        Else
            txtDateTransaction.Text = Format(Now.ToString("MMMM dd, yyyy hh:mm:ss tt"))
        End If
        txtTellerAccount.Text = "CASHIER: " & globalfullname


        If globalAuthPointofSaleAssistant = True Then
            cmdPendingOrderSlip.Visible = False
            lineOrderSlip.Visible = False

            lblProcessor.Visible = True
            lblProcessor.Text = "PROCESSOR: " & UCase(globalAssistantFullName)

            cmdClosedAccount.Visible = False
            lineCloseAccount.Visible = False

            cmdReturnCurrentInvoice.Visible = True
            lineReturnCurrentInvoice.Visible = True

            If Globalallowprocessorcreateclientaccounts = True And GlobalEnableClientAccounts = True Then
                cmdNewClient.Visible = True
                lineNewClient.Visible = True
            Else
                cmdNewClient.Visible = False
                lineNewClient.Visible = False
            End If

            cmdTransactionHistory.Visible = False
            lineTransactionHistory.Visible = False

            cmdTraceTransaction.Visible = False
            lineTraceTransaction.Visible = False

            cmdRecoveredTransaction.Visible = False
            lineRecoverd.Visible = False
        Else
            cmdPendingOrderSlip.Visible = True
            lineOrderSlip.Visible = True
            lblProcessor.Visible = False

            cmdClosedAccount.Visible = True
            lineCloseAccount.Visible = True

            cmdReturnCurrentInvoice.Visible = False
            lineReturnCurrentInvoice.Visible = False

            If GlobalEnableClientAccounts = True Then
                cmdNewClient.Visible = True
                lineNewClient.Visible = True
            Else
                cmdNewClient.Visible = False
                lineNewClient.Visible = False
            End If

            cmdTransactionHistory.Visible = True
            lineTransactionHistory.Visible = True

            'If GlobalEnableCashierReportSummaryView = True Then
            '    cmdTransactionHistory.Visible = True
            '    lineTransactionHistory.Visible = True
            'Else
            '    cmdTransactionHistory.Visible = False
            '    lineTransactionHistory.Visible = False
            'End If

            cmdTraceTransaction.Visible = True
            lineTraceTransaction.Visible = True

            cmdRecoveredTransaction.Visible = True
            lineRecoverd.Visible = True
        End If

        LoadClient()
        BeginNewTransaction()
        CheckQueuingSlip()
        GridColumnChoosed(MyDataGridView, Me.Name)

        If Globalenablechittransaction = True Then
            lblChit.Visible = True
            txtTotalChit.Visible = True
        Else
            lblChit.Visible = False
            txtTotalChit.Visible = False
        End If

    End Sub

    'Public Sub POSFontAppearance()
    '    Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
    '    privateFonts.AddFontFile(Application.StartupPath.ToString & "\Font\AGENCYB.TTF")
    '    txtTotalOnScreen.Font = New System.Drawing.Font(privateFonts.Families(0), 32.25, FontStyle.Bold)
    '    txtTotalTax.Font = New System.Drawing.Font(privateFonts.Families(0), 16.25)
    'End Sub

    Public Sub CheckQueuingSlip()
        If GlobalEnableQueuingSlip = True And countqry("tblsalesqueuingfilter", "permissioncode='" & globalAuthcode & "'") > 0 Then
            cmdOnholdTransaction.Text = GlobalQueuingSlipType + "  F2"
            cmdHold.Text = "Hold " + GlobalQueuingSlipType + Chr(13) + "F10"
        Else
            cmdOnholdTransaction.Text = "On Hold F2"
            cmdHold.Text = "Hold Transaction" + Chr(13) + "F10"
        End If
    End Sub
    Public Sub LoadClient()
        txtClient.Items.Clear()
        If walkinEnable = True Then
            txtClient.Items.Add(New ComboBoxItem(qrysingledata("companyname", "companyname", "tblclientaccounts where walkinaccount=1"), qrysingledata("cifid", "cifid", "tblclientaccounts where walkinaccount=1")))
        End If
        If Globalenableclientfilter = True Then
            com.CommandText = "select * from tblclientaccounts where groupcode in (select clientgroup from tblclientfilter where permissioncode='" & globalAuthcode & "') and walkinaccount=0 and approved=1 and deleted=0 and blocked=0 and (vip=0 or (vip=1 and vipactivated=1)) order by companyname asc" : rst = com.ExecuteReader
        Else
            com.CommandText = "select * from tblclientaccounts where approved=1 and walkinaccount=0 and deleted=0 and blocked=0 and (vip=0 or (vip=1 and vipactivated=1)) order by companyname asc" : rst = com.ExecuteReader
        End If
        While rst.Read
            txtClient.Items.Add(New ComboBoxItem(rst("companyname").ToString, rst("cifid").ToString))
        End While
        rst.Close()
    End Sub

    Private Sub txtClient_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtClient.SelectedValueChanged
        If txtClient.Text <> "" Then
            cifid.Text = DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue()
            com.CommandText = "update tblsalesbatch set cifid='" & cifid.Text & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblsalestransaction set cifid='" & cifid.Text & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
            cmdInfo.Enabled = True
        Else
            cifid.Text = ""
            cmdInfo.Enabled = False
        End If
        If walkinEnable = False Then
            SaveDefaultComboItem(txtClient, txtClient.Text, DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        End If
        showCreditLimit()
    End Sub

    Public Sub BeginNewTransaction()
        Dim newBatchcode As String = getPOSBatchCode() + "-" + globaluserid
        If countqry("tblsalesbatch", "batchcode='" & newBatchcode & "'") > 0 Then
            newBatchcode = getPOSBatchCode() + "-" + globaluserid
        End If
        txtBatchcode.Text = newBatchcode
        ValidatePOSTransaction(txtBatchcode.Text)
        txtuserid.Text = globalTransactionUserid
        LoadDefaultClient()
        ClearForm()
    End Sub

    Public Sub LoadDefaultClient()
        If walkinEnable = True Then
            txtClient.SelectedIndex = -1
            cifid.Text = qrysingledata("cifid", "cifid", "tblclientaccounts where walkinaccount=1")
            txtClient.Text = qrysingledata("companyname", "companyname", "tblclientaccounts where walkinaccount=1")
        Else
            txtClient.Text = defaultCombobox(txtClient, Me, False)
            cifid.Text = defaultCombobox(txtClient, Me, True)
        End If
    End Sub

    Public Sub ClearForm()
        txtQuantity.Text = "1"
        txtBarCode.Text = ""
        txtBarCode.Focus()
        ckNonInventoryItem.Checked = False
        getProductid = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If globalBackDateTransaction = True Then
            txtDateTransaction.Text = Format(globalBackDate.ToString("MMMM dd, yyyy")) & " " & Format(Now.ToString("hh:mm:ss tt"))
        Else
            txtDateTransaction.Text = Format(Now.ToString("MMMM dd, yyyy hh:mm:ss tt"))
        End If
    End Sub

    Public Function TrapTransaction(ByVal productid As String) As Boolean
        '#filter if transaction already void
        If countqry("tblsalesbatch", "batchcode='" & txtBatchcode.Text & "' and void") > 0 Then
            MsgBox("Error accessing this transaction! " & Chr(13) & Chr(13) & "Transaction already void by " & qrysingledata("name", "(select fullname from tblaccounts where accountid=tblsalesbatch.userid) as name", "tblsalesbatch where batchcode='" & txtBatchcode.Text & "'") & "! Your transaction will be cancelled.", MsgBoxStyle.Critical, "Error Message")
            txtBarCode.Focus()
            BeginNewTransaction()
            Return False

            '#filter someone accessing this transaction
        ElseIf countqry("tblsalesbatch", "userid='" & globalTransactionUserid & "' and batchcode='" & txtBatchcode.Text & "'") = 0 And Val(txtTotalItem.Text) > 0 Then
            MsgBox("This transaction is locked! " & Chr(13) & Chr(13) & " It was currently on processing by " & qrysingledata("name", "(select fullname from tblaccounts where accountid=tblsalesbatch.userid) as name", "tblsalesbatch where batchcode='" & txtBatchcode.Text & "'") & "! Your transaction will be cancelled.", MsgBoxStyle.Critical, "Error Message")
            txtBarCode.Focus()
            BeginNewTransaction()
            Return False

            '#FIlter Fuel Products
        ElseIf countqry("tblsalesfuelpump", "productid = '" & productid & "'") > 0 And countqry("tblclientaccounts", "cifid='" & cifid.Text & "' and walkinaccount=1") > 0 And EnableModuleFuel = True Then
            MsgBox("Fuel transaction not allowed for walk-in client!", MsgBoxStyle.Exclamation, "Error Message")
            txtBarCode.Focus()
            Return False

            '#Check if product access available
        ElseIf countqry("tblglobalproducts inner join tblproductfilter on tblglobalproducts.catid = tblproductfilter.categorycode", "tblproductfilter.permissioncode='" & globalAuthcode & "' and deleted=0 and tblglobalproducts.productid='" & productid & "' and enablesell=1") = 0 And GlobalenableProductFilter = True Then
            MsgBox("Product access denied! Please contact your system administrator!", MsgBoxStyle.Exclamation, "Error Message")
            txtBarCode.Focus()
            Return False

            '#Check product inventory
        ElseIf countqry("tblinventory", "productid='" & productid & "' and officeid='" & compOfficeid & "'") = 0 And countqry("tblglobalproducts", "productid='" & productid & "' and forcontract=0") > 0 And compEnableInventory = True Then
            MsgBox("Product inventory not available!", MsgBoxStyle.Exclamation, "Error Message")
            txtBarCode.Focus()
            Return False

            '#Check inventory quantity
        ElseIf countqry("tblinventory", "quantity >= " & txtQuantity.Text & " and productid='" & productid & "' and officeid='" & compOfficeid & "'") = 0 And countqry("tblglobalproducts", "productid='" & productid & "' and forcontract=0") > 0 And compEnableInventory = True Then
            MsgBox("Maximum of Product quantity is " & qrysingledata("quantity", "quantity", "tblinventory where productid='" & productid & "'  and officeid='" & compOfficeid & "'") & "!", MsgBoxStyle.Exclamation, "Error Message")
            txtBarCode.Focus()
            Return False
        End If

        If countqry("tblglobalproducts", "productid='" & productid & "' and forcontract=1 and menuitem=1 ") > 0 Then
            '#Check product memu maker inventory
            If countqry("tblglobalproducts", "productid='" & productid & "' and forcontract=1 and menuitem=1 ") > 0 And countqry("tblproductmenuitem", "source_productid='" & productid & "'") = 0 Then
                MsgBox("Product menu item not available or currently not configured!", MsgBoxStyle.Exclamation, "Error Message")
                txtBarCode.Focus()
                Return False
            End If
            If GlobalEnableStrictMenuMakerInventory = True Then
                Dim ProductTrap As String = ""
                msda = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblproductmenuitem where source_productid='" & productid & "'", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If Val(qrysingledata("ttlquantity", "sum(quantity) as ttlquantity", "tblinventory where productid='" & .Rows(cnt)("productid").ToString() & "' and officeid='" & compOfficeid & "'")) < (Val(.Rows(cnt)("quantity").ToString()) * Val(txtQuantity.Text)) Then
                            ProductTrap = ProductTrap + (Val(.Rows(cnt)("quantity").ToString()) * Val(txtQuantity.Text)).ToString + " " + .Rows(cnt)("unit").ToString() + " - " + qrysingledata("itemname", "itemname", "tblglobalproducts where productid='" & .Rows(cnt)("productid").ToString() & "'") + Chr(13)
                        End If
                    End With
                Next

                If ProductTrap.Length > 0 Then
                    MessageBox.Show("Some product menu item inventory not available or insufficient! " & Environment.NewLine & Environment.NewLine & "Required details below: " & Environment.NewLine & Environment.NewLine + ProductTrap, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBarCode.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Sub txtBarCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarCode.KeyDown
        If e.KeyCode() = Keys.Down Then
            MyDataGridView.Focus()
        End If
    End Sub

    Private Sub txtBarCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarCode.KeyPress
        If e.KeyChar = Chr(13) Then
            If cifid.Text = "" Then
                MsgBox("Please select client!", MsgBoxStyle.Exclamation, "Error Message")
                txtClient.Focus()
                Exit Sub
            End If

            If txtBarCode.Text = "" And Val(txtTotalItem.Text) > 0 Then
                PostPayment() ' Proceed payment transaction
            Else
                If txtQuantity.Text = "" Then
                    MsgBox("Please enter quantity!", MsgBoxStyle.Exclamation, "Error Search")
                    txtQuantity.Focus()
                    Exit Sub
                ElseIf txtBarCode.Text = "" Then
                    MsgBox("Please enter barcode!", MsgBoxStyle.Exclamation, "Error Search")
                    txtBarCode.Focus()
                    Exit Sub
                ElseIf Val(txtQuantity.Text) <= 0 Then
                    MsgBox("Please enter quantity!", MsgBoxStyle.Exclamation, "Error Search")
                    txtQuantity.Focus()
                    Exit Sub
                ElseIf txtuserid.Text <> globalTransactionUserid Then
                    MessageBox.Show("Modifying other user transaction is not allowed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If countqry("tblglobalproducts", "deleted=0 and (barcode='" & rchar(txtBarCode.Text) & "' or productid='" & rchar(txtBarCode.Text) & "')") > 0 Then
                    Dim unit As String = "" : Dim unitcost As Double = 0
                    com.CommandText = "select * from tblglobalproducts where deleted=0 and (barcode='" & rchar(txtBarCode.Text) & "' or productid='" & rchar(txtBarCode.Text) & "')" : rst = com.ExecuteReader
                    While rst.Read
                        getProductid = rst("productid").ToString
                        unit = rst("unit").ToString
                        unitcost = Val(rst("sellingprice").ToString)
                    End While
                    rst.Close()
                    frmPOSProductSearch.ExecuteOtherProduct(getProductid, unit, unitcost)
                Else
                    getProductid = qrysingledata("productid", "productid", "tblglobalproducts where deleted=0 and productid='" & rchar(txtBarCode.Text) & "' or barcode='" & rchar(txtBarCode.Text) & "' ")
                    If getProductid = "" Then
                        If txtBarCode.Text.Length < 2 Then
                            MsgBox("Please enter keyword at least 2 characters to continue search!", MsgBoxStyle.Exclamation, "Error Search")
                            txtBarCode.Focus()
                            Exit Sub
                        End If
                        frmPOSProductSearch.txtSearchBox.Text = txtBarCode.Text
                        frmPOSProductSearch.SearchProduct(txtBarCode.Text)
                        'frmPOSProductSearch.MyDataGridView.Focus()
                        If frmPOSProductSearch.Visible = True Then
                            frmPOSProductSearch.Focus()
                        Else
                            frmPOSProductSearch.ShowDialog(Me)
                        End If
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cmdPayment_Click(sender As Object, e As EventArgs) Handles cmdPayment.Click
        PostPayment()
    End Sub
    Public Sub PostPayment()
        If cifid.Text = "" Then
            MessageBox.Show("Please select client!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If globalAuthPointofSaleAssistant = True Then
            frmPOSProcessOrderSlip.txtBatchcode.Text = txtBatchcode.Text
            frmPOSProcessOrderSlip.Show(Me)
        Else
            If countqry("tblclientaccounts", "hotelclient=1 and cifid='" & cifid.Text & "'") > 0 Then
                If MessageBox.Show("Are you sure you want to charge hotel transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmPOSChargetoHotelAcct.hotelcifid.Text = cifid.Text
                    frmPOSChargetoHotelAcct.txtBatchcode.Text = txtBatchcode.Text
                    frmPOSChargetoHotelAcct.ShowDialog(Me)
                    If frmPOSChargetoHotelAcct.TransactionDone = True Then
                        BeginNewTransaction()
                        MessageBox.Show("Transaction successfully completed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmPOSChargetoHotelAcct.TransactionDone = False
                        frmPOSChargetoHotelAcct.Dispose()
                    Else
                        frmPOSChargetoHotelAcct.Dispose()
                    End If
                End If
            Else
                frmPOSPaymentConfirmation.txtBatchcode.Text = txtBatchcode.Text
                frmPOSPaymentConfirmation.ShowDialog(Me)
                If frmPOSPaymentConfirmation.TransactionDone = True Then
                    BeginNewTransaction()
                    frmPOSPaymentChangeCaption.txtChange.Text = frmPOSPaymentConfirmation.txtPaymentChange.Text
                    frmPOSPaymentChangeCaption.ShowDialog(Me)

                    frmPOSPaymentConfirmation.TransactionDone = False
                    frmPOSPaymentConfirmation.Dispose()
                End If
            End If
        End If
    End Sub
    
    Public Sub PostSalesTransaction(ByVal ExecutedBarcode As Boolean, ByVal productid As String, ByVal quantity As Double, ByVal unitprice As Double, ByVal chitprice As Double, ByVal parameter As String)
        If TrapTransaction(productid) = True Then
            If compEnableInventory = True Then
                ckNonInventoryItem.Checked = CBool(qrysingledata("forcontract", "forcontract", "tblglobalproducts where productid='" & productid & "'"))
            Else
                ckNonInventoryItem.Checked = True
            End If

            Dim remquantity As Double = 0
            msda = Nothing : dst = New DataSet
            If ckNonInventoryItem.Checked = True Then
                msda = New MySqlDataAdapter("select *,if(servicemenuproduct=1,ifnull((select sum(amount) from tblproductserviceitem where source_productid=tblglobalproducts.productid),sellingprice),sellingprice) as sellprice, itemname as productname from tblglobalproducts where productid='" & productid & "'", conn)
            Else
                msda = New MySqlDataAdapter("select *,(select allownegativeinputs from tblglobalproducts where productid=tblinventory.productid) as allownegativeinputs, (select salemode from tblglobalproducts where productid=tblinventory.productid) as salemode,(select allowinputdiscountedamount from tblglobalproducts where productid=tblinventory.productid) as allowinputdiscountedamount, sellingprice as sellprice from tblinventory where productid='" & productid & "'  and officeid='" & compOfficeid & "' and quantity > 0 order by dateinventory,trnid", conn)
            End If
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If ExecutedBarcode = True Then
                        unitprice = Val(.Rows(cnt)("sellprice").ToString())
                    End If
                    'automatic compute quantity base on amount
                    If .Rows(cnt)("salemode").ToString() = "esba" And CBool(.Rows(cnt)("allownegativeinputs").ToString()) = False Then
                        If Val(.Rows(cnt)("sellprice").ToString()) <> Val(CC(unitprice)) And CBool(.Rows(cnt)("allowinputdiscountedamount").ToString()) = False And Val(.Rows(cnt)("sellprice").ToString()) > 0 Then
                            quantity = Val(CC(unitprice)) / Val(.Rows(cnt)("sellprice").ToString())
                        End If
                    End If
                    'FILTER DISCOUNT
                    Dim Discount As Double = 0 : Dim Charges As Double = 0
                    If countqry("tblproductchargesfilter", "officeid='" & compOfficeid & "'") > 0 Then
                        Charges = GetChargeValue(.Rows(cnt)("catid").ToString(), Val(.Rows(cnt)("sellprice").ToString()))
                    End If

                    Discount = GetTotalDiscount(.Rows(cnt)("catid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(quantity)), Val(.Rows(cnt)("sellprice").ToString()), Val(CC(unitprice)), cifid.Text, qrysingledata("salemode", "salemode", "tblglobalproducts where productid='" & productid & "'"))
                    'FILTER CHARGES SETTINGS
                    If Discount < 0 Then
                        Charges = Charges + Val(Discount.ToString.Replace("-", ""))
                        Discount = 0
                    End If

                    Dim prevQuantity As Double = 0
                    If ckNonInventoryItem.Checked = False Then
                        prevQuantity = Val(.Rows(cnt)("quantity").ToString())

                        If Val(.Rows(cnt)("sellprice").ToString()) = 0 Then
                            com.CommandText = "update tblglobalproducts set sellingprice='" & Val(CC(unitprice)) & "' where productid='" & .Rows(cnt)("productid").ToString() & "' limit 1" : com.ExecuteNonQuery()
                            com.CommandText = "update tblinventory set sellingprice='" & Val(CC(unitprice)) & "' where trnid='" & .Rows(cnt)("trnid").ToString() & "' limit 1" : com.ExecuteNonQuery()
                        End If

                        If remquantity = 0 Then
                            If Val(CC(quantity)) > Val(.Rows(cnt)("quantity").ToString()) Then
                                remquantity = Val(CC(quantity)) - Val(.Rows(cnt)("quantity").ToString())
                                InsertSalesTransaction(True, .Rows(cnt)("trnid").ToString(), "", "", .Rows(cnt)("productid").ToString(), rchar(.Rows(cnt)("productname").ToString()), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(prevQuantity)), .Rows(cnt)("catid").ToString(), .Rows(cnt)("unit").ToString(), .Rows(cnt)("purchasedprice").ToString(), chitprice, .Rows(cnt)("sellprice").ToString(), (Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount, Discount, Discount * Val(.Rows(cnt)("quantity").ToString()), Charges, Charges * Val(CC(.Rows(cnt)("quantity").ToString())), GlobalTaxRate, ((GlobalTaxRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(.Rows(cnt)("quantity").ToString())), GlobalServiceChargeRate, ((GlobalServiceChargeRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(.Rows(cnt)("quantity").ToString())), Val(.Rows(cnt)("sellprice").ToString()) * Val(.Rows(cnt)("quantity").ToString()), ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(.Rows(cnt)("quantity").ToString()), (((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(.Rows(cnt)("quantity").ToString())) - (Val(.Rows(cnt)("purchasedprice").ToString()) * Val(.Rows(cnt)("quantity").ToString())), parameter)
                            Else
                                InsertSalesTransaction(True, .Rows(cnt)("trnid").ToString(), "", "", .Rows(cnt)("productid").ToString(), rchar(.Rows(cnt)("productname").ToString()), Val(CC(quantity)), Val(CC(prevQuantity)), .Rows(cnt)("catid").ToString(), .Rows(cnt)("unit").ToString(), .Rows(cnt)("purchasedprice").ToString(), chitprice, .Rows(cnt)("sellprice").ToString(), (Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount, Discount, Discount * Val(quantity), Charges, Charges * Val(CC(quantity)), GlobalTaxRate, ((GlobalTaxRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(quantity)), GlobalServiceChargeRate, ((GlobalServiceChargeRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(quantity)), Val(.Rows(cnt)("sellprice").ToString()) * Val(quantity), ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(quantity), (((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(quantity)) - (Val(.Rows(cnt)("purchasedprice").ToString()) * Val(quantity)), parameter)
                                Exit For
                            End If
                        Else
                            If remquantity > Val(.Rows(cnt)("quantity").ToString()) Then
                                remquantity = remquantity - Val(.Rows(cnt)("quantity").ToString())
                                InsertSalesTransaction(True, .Rows(cnt)("trnid").ToString(), "", "", .Rows(cnt)("productid").ToString(), rchar(.Rows(cnt)("productname").ToString()), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(prevQuantity)), .Rows(cnt)("catid").ToString(), .Rows(cnt)("unit").ToString(), .Rows(cnt)("purchasedprice").ToString(), chitprice, .Rows(cnt)("sellprice").ToString(), (Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount, Discount, Discount * Val(.Rows(cnt)("quantity").ToString()), Charges, Charges * Val(CC(.Rows(cnt)("quantity").ToString())), GlobalTaxRate, ((GlobalTaxRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(.Rows(cnt)("quantity").ToString())), GlobalServiceChargeRate, ((GlobalServiceChargeRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(.Rows(cnt)("quantity").ToString())), Val(.Rows(cnt)("sellprice").ToString()) * Val(.Rows(cnt)("quantity").ToString()), ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(.Rows(cnt)("quantity").ToString()), (((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(.Rows(cnt)("quantity").ToString())) - (Val(.Rows(cnt)("purchasedprice").ToString()) * Val(.Rows(cnt)("quantity").ToString())), parameter)
                            Else
                                InsertSalesTransaction(True, .Rows(cnt)("trnid").ToString(), "", "", .Rows(cnt)("productid").ToString(), rchar(.Rows(cnt)("productname").ToString()), Val(CC(remquantity)), Val(CC(prevQuantity)), .Rows(cnt)("catid").ToString(), .Rows(cnt)("unit").ToString(), .Rows(cnt)("purchasedprice").ToString(), chitprice, .Rows(cnt)("sellprice").ToString(), (Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount, Discount, Discount * Val(remquantity), Charges, Charges * Val(CC(remquantity)), GlobalTaxRate, ((GlobalTaxRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(remquantity)), GlobalServiceChargeRate, ((GlobalServiceChargeRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(remquantity)), Val(.Rows(cnt)("sellprice").ToString()) * Val(remquantity), ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(remquantity), (((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(remquantity)) - (Val(.Rows(cnt)("purchasedprice").ToString()) * Val(remquantity)), parameter)
                                Exit For
                            End If
                        End If
                    Else
                        Dim TotalPurchasePrice As Double = 0
                        If CBool(.Rows(cnt)("menuitem").ToString()) = True Or CBool(.Rows(cnt)("servicemenuproduct").ToString()) = True Then
                            'process menumaker services item
                            Dim menumakerrefService As String = ""
                            If CBool(.Rows(cnt)("servicemenuproduct").ToString()) = True Then
                                menumakerrefService = getManuMakerServiceSequence()
                                da = Nothing : st = New DataSet
                                da = New MySqlDataAdapter("select *,(select itemname from tblglobalproducts where productid=tblproductserviceitem.productid) as 'itemname', " _
                                                          + " ifnull((select enablecoupon from tblglobalproducts where productid=tblproductserviceitem.productid),0) as enablecoupon, " _
                                                          + " (select unit from tblglobalproducts where productid=tblproductserviceitem.productid) as unit, " _
                                                          + " (select officecenter from tblglobalproducts where productid=tblproductserviceitem.productid) as officecenter " _
                                                          + " from tblproductserviceitem where source_productid='" & .Rows(cnt)("productid").ToString() & "'", conn)
                                da.Fill(st, 0)
                                For nt = 0 To st.Tables(0).Rows.Count - 1
                                    com.CommandText = "insert into tblsalesmenumakerservice set officeid='" & compOfficeid & "', refnumber='" & menumakerrefService & "',productid='" & st.Tables(0).Rows(nt)("productid").ToString() & "', productname='" & rchar(st.Tables(0).Rows(nt)("itemname").ToString()) & "', quantity='" & Val(quantity) & "', amount='" & st.Tables(0).Rows(nt)("amount").ToString() & "', total='" & Val(st.Tables(0).Rows(nt)("amount").ToString()) * Val(quantity) & "', salesofficeid='" & If(st.Tables(0).Rows(nt)("officecenter").ToString() = "", compOfficeid, st.Tables(0).Rows(nt)("officecenter").ToString()) & "'" : com.ExecuteNonQuery()
                                    If CBool(st.Tables(0).Rows(nt)("enablecoupon").ToString()) = True Then
                                        InsertProductCoupon("POS", txtBatchcode.Text, If(st.Tables(0).Rows(nt)("officecenter").ToString() = "", compOfficeid, st.Tables(0).Rows(nt)("officecenter").ToString()), st.Tables(0).Rows(nt)("productid").ToString(), Val(quantity), st.Tables(0).Rows(nt)("unit").ToString(), st.Tables(0).Rows(nt)("amount").ToString(), Val(st.Tables(0).Rows(nt)("amount").ToString()) * Val(quantity), CDate(Now.ToShortDateString))
                                    End If
                                Next
                            End If

                            'process menumaker inventory item
                            Dim menumakerrefItem As String = ""
                            If CBool(.Rows(cnt)("menuitem").ToString()) = True Then
                                menumakerrefItem = getManuMakerSequence()
                                da_manumaker = Nothing : st_menumaker = New DataSet
                                da_manumaker = New MySqlDataAdapter("select *,(select itemname from tblglobalproducts where productid=tblproductmenuitem.productid) as productname from tblproductmenuitem where source_productid='" & .Rows(cnt)("productid").ToString() & "'", conn)
                                da_manumaker.Fill(st_menumaker, 0)
                                For nt = 0 To st_menumaker.Tables(0).Rows.Count - 1
                                    remquantity = 0 : Dim purchasePrice As Double = 0
                                    If Globalenablemenumakerinventory = True Then
                                        Dim deductQuantity As Double = st_menumaker.Tables(0).Rows(nt)("quantity").ToString() * Val(quantity)
                                        msda2 = Nothing : dst2 = New DataSet
                                        msda2 = New MySqlDataAdapter("select * from tblinventory where officeid='" & compOfficeid & "'  and productid='" & st_menumaker.Tables(0).Rows(nt)("productid").ToString() & "' and quantity>0 order by dateinventory,trnid", conn)
                                        msda2.Fill(dst2, 0)
                                        Dim xnt = 0
                                        For xnt = 0 To dst2.Tables(0).Rows.Count - 1
                                            If remquantity = 0 Then
                                                If deductQuantity > Val(dst2.Tables(0).Rows(xnt)("quantity").ToString()) Then
                                                    remquantity = deductQuantity - Val(dst2.Tables(0).Rows(xnt)("quantity").ToString())
                                                    'remquantity = 0
                                                    purchasePrice += dst2.Tables(0).Rows(xnt)("purchasedprice").ToString() * Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString()))
                                                    com.CommandText = "insert into tblsalesmenumakerstockout set  trnsumcode='" & globalSalesTrnCOde & "', postingdate='" & ConvertDate(globalTransactionDate) & "',batchcode='" & Trim(txtBatchcode.Text) & "', officeid='" & compOfficeid & "', refnumber='" & menumakerrefItem & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "', productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & deductQuantity & "',unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "', purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                                                    StockoutInventory("POS Sold", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), deductQuantity, Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "#" + txtBatchcode.Text + " (" & dst2.Tables(0).Rows(xnt)("productname").ToString() & ")", txtBatchcode.Text, "")
                                                Else
                                                    purchasePrice += dst2.Tables(0).Rows(xnt)("purchasedprice").ToString() * deductQuantity
                                                    com.CommandText = "insert into tblsalesmenumakerstockout set trnsumcode='" & globalSalesTrnCOde & "',postingdate='" & ConvertDate(globalTransactionDate) & "',batchcode='" & Trim(txtBatchcode.Text) & "', officeid='" & compOfficeid & "', refnumber='" & menumakerrefItem & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "', productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & deductQuantity & "', unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "',  purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                                                    StockoutInventory("POS Sold", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), deductQuantity, Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "#" + txtBatchcode.Text + " (" & dst2.Tables(0).Rows(xnt)("productname").ToString() & ")", txtBatchcode.Text, "")
                                                    Exit For
                                                End If
                                            Else
                                                If remquantity > Val(dst2.Tables(0).Rows(xnt)("quantity").ToString()) Then
                                                    remquantity = remquantity - Val(dst2.Tables(0).Rows(xnt)("quantity").ToString())
                                                    purchasePrice += dst2.Tables(0).Rows(xnt)("purchasedprice").ToString() * Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString()))
                                                    com.CommandText = "insert into tblsalesmenumakerstockout set trnsumcode='" & globalSalesTrnCOde & "',postingdate='" & ConvertDate(globalTransactionDate) & "',batchcode='" & Trim(txtBatchcode.Text) & "', officeid='" & compOfficeid & "', refnumber='" & menumakerrefItem & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "', productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString())) & "', unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "', purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                                                    StockoutInventory("POS Sold", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString())), Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "#" + txtBatchcode.Text + " (" & dst2.Tables(0).Rows(xnt)("productname").ToString() & ")", txtBatchcode.Text, "")
                                                Else
                                                    purchasePrice += dst2.Tables(0).Rows(xnt)("purchasedprice").ToString() * remquantity
                                                    com.CommandText = "insert into tblsalesmenumakerstockout set trnsumcode='" & globalSalesTrnCOde & "',postingdate='" & ConvertDate(globalTransactionDate) & "',batchcode='" & Trim(txtBatchcode.Text) & "', officeid='" & compOfficeid & "', refnumber='" & menumakerrefItem & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "',productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & remquantity & "',unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "', purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                                                    StockoutInventory("POS Sold", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), remquantity, Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "#" + txtBatchcode.Text + " (" & dst2.Tables(0).Rows(xnt)("productname").ToString() & ")", txtBatchcode.Text, "")
                                                    Exit For
                                                End If
                                            End If
                                        Next
                                    Else
                                        purchasePrice += st_menumaker.Tables(0).Rows(nt)("cost").ToString() * Val(CC(st_menumaker.Tables(0).Rows(nt)("quantity").ToString()))
                                        com.CommandText = "insert into tblsalesmenumakerstockout set trnsumcode='" & globalSalesTrnCOde & "',postingdate='" & ConvertDate(globalTransactionDate) & "',batchcode='" & Trim(txtBatchcode.Text) & "', officeid='" & compOfficeid & "', refnumber='" & menumakerrefItem & "', stockno='-', productid='" & st_menumaker.Tables(0).Rows(nt)("productid").ToString() & "', productname='" & st_menumaker.Tables(0).Rows(nt)("productname").ToString() & "', quantity='" & st_menumaker.Tables(0).Rows(nt)("quantity").ToString() & "',unit='" & st_menumaker.Tables(0).Rows(nt)("unit").ToString() & "', purchasedprice='" & Val(CC(st_menumaker.Tables(0).Rows(nt)("cost").ToString())) & "'" : com.ExecuteNonQuery()
                                    End If
                                    TotalPurchasePrice += purchasePrice
                                Next
                            End If

                            TotalPurchasePrice = TotalPurchasePrice / Val(quantity)
                            InsertSalesTransaction(False, "0", menumakerrefItem, menumakerrefService, .Rows(cnt)("productid").ToString(), rchar(.Rows(cnt)("productname").ToString()), Val(CC(quantity)), "0", .Rows(cnt)("catid").ToString(), .Rows(cnt)("unit").ToString(), TotalPurchasePrice, chitprice, .Rows(cnt)("sellprice").ToString(), (Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount, Discount, Discount * Val(quantity), Charges, Charges * Val(CC(quantity)), GlobalTaxRate, ((GlobalTaxRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(quantity)), GlobalServiceChargeRate, ((GlobalServiceChargeRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(quantity)), Val(.Rows(cnt)("sellprice").ToString()) * Val(quantity), ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(quantity), (((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(quantity)) - (Val(TotalPurchasePrice) * Val(quantity)), parameter)
                        Else
                            InsertSalesTransaction(False, "0", "", "", .Rows(cnt)("productid").ToString(), rchar(.Rows(cnt)("productname").ToString()), Val(CC(quantity)), Val(CC(prevQuantity)), .Rows(cnt)("catid").ToString(), .Rows(cnt)("unit").ToString(), .Rows(cnt)("purchasedprice").ToString(), chitprice, .Rows(cnt)("sellprice").ToString(), (Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount, Discount, Discount * Val(quantity), Charges, Charges * Val(CC(quantity)), GlobalTaxRate, ((GlobalTaxRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(quantity)), GlobalServiceChargeRate, ((GlobalServiceChargeRate / 100) * ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount)) * Val(CC(quantity)), Val(.Rows(cnt)("sellprice").ToString()) * Val(quantity), ((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(quantity), (((Val(.Rows(cnt)("sellprice").ToString()) + Charges) - Discount) * Val(quantity)) - (Val(.Rows(cnt)("purchasedprice").ToString()) * Val(quantity)), parameter)
                        End If
                    End If
                End With
            Next
            ValidatePOSTransaction(txtBatchcode.Text)
        End If
    End Sub
    Public Function InsertSalesTransaction(ByVal deductInventory As Boolean, ByVal inventorytrnid As String, ByVal menumakerstockref As String, ByVal menumakerserviceref As String, ByVal productid As String, _
                                                                                ByVal productname As String, ByVal quantity As Double, ByVal prevquantity As Double, ByVal catid As String, _
                                                                                ByVal unit As String, ByVal purchasedprice As Double, Chitprice As Double, ByVal originalsellprice As Double, ByVal sellprice As Double, ByVal disrate As Double, _
                                                                                ByVal distotal As Double, ByVal chargerate As Double, ByVal chargetotal As Double, ByVal taxrate As Double, ByVal taxtotal As Double, _
                                                                                ByVal svchargerate As Double, svchargetotal As Double, ByVal subtotal As Double, ByVal total As Double, ByVal income As Double, ByVal parameter As String)
        Dim vatitem As Boolean = False
        Dim svcitem As Boolean = False
        Dim enableofficecenter As Boolean = False
        Dim officecenter As String = ""
        Dim enableCoupon As Boolean = False
        Dim customproductorder As Boolean = False
        Dim requiredattendingpersonnel As Boolean = False
        Dim updaterequired As Boolean = False
        com.CommandText = "select * from tblglobalproducts where productid='" & productid & "' limit 1" : rst = com.ExecuteReader
        While rst.Read
            vatitem = rst("vatableitem")
            svcitem = rst("svchargeitem")
            enableofficecenter = rst("enablecenter")
            officecenter = rst("officecenter").ToString
            enableCoupon = rst("enablecoupon")
            customproductorder = rst("customproductorder")
            requiredattendingpersonnel = rst("requiredattendingpersonnel")
            updaterequired = rst("updaterequired")
        End While
        rst.Close()

        If vatitem = False Then
            taxtotal = 0
        End If

        If svcitem = False Then
            svchargetotal = 0
        End If

        Dim attendingPerson As String = ""
        If requiredattendingpersonnel = True Then
            frmPOSAttendingPersonnel.ShowDialog(Me)
            attendingPerson = frmPOSAttendingPersonnel.salesid.Text
        Else
            If globalAssistantUserId <> "" Then
                attendingPerson = globalAssistantUserId
            End If
        End If

        If countqry("tblclientaccounts", "cifid='" & cifid.Text & "' and creditlimit=1") > 0 Then
            Dim remainingcredit As Double = Val(qrysingledata("creditlimitamount", "creditlimitamount", "tblclientaccounts where cifid='" & cifid.Text & "'")) - (Val(qrysingledata("totaldue", "sum(debit)-sum(credit) as totaldue", "tblglaccountledger where accountno='" & cifid.Text & "' and cancelled=0")) + Val(qrysingledata("amount", "amount", "tblsalesclientcharges where accountno='" & cifid.Text & "' and verified=0 and cancelled=0")) + Val(qrysingledata("ttl", "sum(total) as ttl", "tblsalestransaction where cifid='" & cifid.Text & "' and cancelled=0 and void=0 and batchcode='" & txtBatchcode.Text & "'")))
            If remainingcredit < sellprice Then
                MessageBox.Show(txtClient.Text & " has only " & FormatNumber(remainingcredit, 2) & " available from credit limit! Transaction cannot be continue", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            ElseIf remainingcredit < Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and tblsalestransaction.cancelled=0")) Then
                MessageBox.Show(txtClient.Text & " has only " & FormatNumber(remainingcredit, 2) & " available from credit limit! Transaction cannot be continue", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        com.CommandText = "insert into tblsalestransaction set trnsumcode='" & globalSalesTrnCOde & "', " _
                                  + " postingdate='" & ConvertDate(globalTransactionDate) & "', " _
                                  + " inventory=" & deductInventory & ", " _
                                  + " inventorytrnid='" & inventorytrnid & "', " _
                                  + " menumakerstockref='" & menumakerstockref & "', " _
                                  + " menumakerserviceref='" & menumakerserviceref & "', " _
                                  + " userid='" & globalTransactionUserid & "', " _
                                  + " batchcode='" & Trim(txtBatchcode.Text) & "', " _
                                  + " officeid='" & compOfficeid & "', " _
                                  + " cifid='" & cifid.Text & "', " _
                                  + " productid='" & productid & "', " _
                                  + " productname='" & productname & "', " _
                                  + " customproductorder=" & customproductorder & "," _
                                  + " quantity='" & quantity & "', " _
                                  + " prevquantity='" & prevquantity & "', " _
                                  + " catid='" & catid & "', " _
                                  + " unit='" & rchar(unit) & "', " _
                                  + " purchasedprice=" & purchasedprice & ", " _
                                  + " originalsellprice=" & originalsellprice & ", " _
                                  + " chitsellprice=" & If(Chitprice > 0, Val(CC(Chitprice)) - sellprice, 0) & ", " _
                                  + " sellprice=" & sellprice & ", " _
                                  + " disrate=" & disrate & ", " _
                                  + " distotal=" & If(sellprice < 0, 0, distotal) & ", " _
                                  + " chargerate='" & chargerate & "', " _
                                  + " chargetotal='" & chargetotal & "', " _
                                  + " taxrate=" & taxrate & ", " _
                                  + " taxtotal=" & taxtotal & ", " _
                                  + " svchargerate='" & svchargerate & "', " _
                                  + " svchargetotal='" & svchargetotal & "', " _
                                  + " subtotal=" & subtotal & ", " _
                                  + " chittotal=" & If(Chitprice > 0, (Val(CC(Chitprice)) * Val(quantity)) - (total + If(GlobalTaxAddtoTotal = True, taxtotal, 0) + If(GlobalSvAddtoTotal = True, svchargetotal, 0)), 0) & ", " _
                                  + " total='" & total + If(GlobalTaxAddtoTotal = True, taxtotal, 0) + If(GlobalSvAddtoTotal = True, svchargetotal, 0) & "'," _
                                  + " income=" & If(purchasedprice = 0, total + If(GlobalTaxAddtoTotal = True, taxtotal, 0) + If(GlobalSvAddtoTotal = True, svchargetotal, 0), income) & ", " _
                                  + " attendingperson='" & attendingPerson & "', " _
                                  + " datetrn=" & If(globalBackDateTransaction = True, "concat('" & ConvertDate(globalBackDate) & "',' ',current_time)", "current_timestamp") _
                                  + parameter : com.ExecuteNonQuery()

        'If updaterequired = True Or originalsellprice = 0 And total > 0 Then
        '    com.CommandText = "Update tblglobalproducts set sellingprice='" & Val(CC(sellprice)) & "',allowinputdiscountedamount=0, updaterequired=0,dateupdated=current_timestamp,updatedby='" & globaluserid & "' where productid='" & productid & "' and deleted=0 " : com.ExecuteNonQuery()
        '    com.CommandText = "update tblinventory set sellingprice='" & Val(CC(sellprice)) & "' where productid='" & productid & "' and quantity > 0 " : com.ExecuteNonQuery()
        'End If

        frmPOSAttendingPersonnel.salesid.Text = ""
        frmPOSAttendingPersonnel.txtSalesPerson.Text = ""
        frmPOSAttendingPersonnel.Dispose()
        'End If
        If enableofficecenter = True Then
            If enableCoupon = True Then
                If officecenter <> compOfficeid Then
                    InsertProductCoupon("POS", txtBatchcode.Text, officecenter, productid, quantity, unit, sellprice, total + If(GlobalTaxAddtoTotal = True, taxtotal, 0) + If(GlobalSvAddtoTotal = True, svchargetotal, 0), CDate(Now.ToShortDateString))
                End If
            End If
        End If

        '#update inventory
        If deductInventory = True Then
            StockoutInventory("POS Sold", inventorytrnid, compOfficeid, productid, quantity, purchasedprice, "Sales Batchcode #" + txtBatchcode.Text, txtBatchcode.Text, "")
        End If
        Return True
    End Function
    Public Function GetTotalDiscount(ByVal catid As String, ByVal productid As String, ByVal quant As Double, ByRef originalSellingCost As Double, ByVal AmountTender As Double, ByVal clientid As String, ByVal salemode As String) As Double
        GetTotalDiscount = 0
        If CBool(qrysingledata("skipdiscount", "skipdiscount", "tblclientaccounts where cifid='" & cifid.Text & "'")) = False Then
            Dim allowinputdiscountedamount As Boolean = CBool(qrysingledata("allowinputdiscountedamount", "allowinputdiscountedamount", "tblglobalproducts where productid='" & rchar(productid) & "'"))
            Dim GetCIFGroup As String = qrysingledata("groupcode", "groupcode", "tblclientaccounts where cifid='" & cifid.Text & "'")
            If countqry("tblclientdiscounts", "catid='" & catid & "' and cifid='" & GetCIFGroup & "'") > 0 Or countqry("tblproductdiscounts", "productid='" & productid & "'") > 0 Then
                GetTotalDiscount = GetDiscountValue(cifid.Text, GetCIFGroup, catid, productid, originalSellingCost, originalSellingCost * quant)
            Else
                If allowinputdiscountedamount = True Or GlobalProductTemplate = 4 Or salemode = "esba" Then
                    GetTotalDiscount = originalSellingCost - Val(CC(AmountTender))
                End If
            End If
        End If

        Return GetTotalDiscount
    End Function
    Public Function ComputeTotalVat(ByVal sales As Double, ByVal vatfactor As Double, ByVal taxrate As Double) As Double
        ComputeTotalVat = (sales / vatfactor) * (GlobalTaxRate / 100)
        Return ComputeTotalVat
    End Function

    Public Sub ValidatePOSTransaction(ByVal batchcode As String)
        txtTotalItem.Text = countqry("tblsalestransaction", "batchcode='" & batchcode & "' and cancelled=0")
        txtTotalCancelled.Text = FormatNumber(Val(qrysingledata("ttl", "count(*) as 'ttl'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=1")), 2)
        txtTotalDiscount.Text = FormatNumber(Val(qrysingledata("total", "sum(distotal) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)
        txtTotalCharge.Text = FormatNumber(Val(qrysingledata("total", "sum(chargetotal) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)
        txtTotalTax.Text = FormatNumber(Val(qrysingledata("total", "sum(taxtotal) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)
        txtServiceCharge.Text = FormatNumber(Val(qrysingledata("total", "sum(svchargetotal) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)
        txtSubTotal.Text = FormatNumber(Val(qrysingledata("total", "sum(subtotal) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)
        txtTotalChit.Text = FormatNumber(Val(qrysingledata("total", "sum(chittotal) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0")), 2)

        If Globalenablecombinepossalesquantity = True Then
            MyDataGridView.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select ID,PRODUCTID, productname as 'PARTICULAR', " _
                                        + " sum(quantity) as QTY, UNIT, sellprice as 'UNIT PRICE', " & If(Globalenablechittransaction = True, "chitsellprice as 'CHIT PRICE',", "") & " sum(chargetotal) as 'CHARGES',  disrate as 'DISCOUNT RATE', sum(distotal) as 'DISCOUNT', sum(subtotal) as 'SUB TOTAL',  " & If(Globalenablechittransaction = True, "sum(chittotal) as 'TOTAL CHIT',", "") & " sum(total) as 'TOTAL',REMARKS from tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and cancelled=0 group by productid order by datetrn asc ", conn)
        Else
            MyDataGridView.DataSource = Nothing : dst = New DataSet
            If Globalenablechittransaction = True Then
                msda = New MySqlDataAdapter("select * from (select ID,0 as SUBID,PRODUCTID,productname as 'PARTICULAR',quantity as QTY,UNIT,sellprice as 'UNIT PRICE',chitsellprice as 'SOP',chargetotal as 'CHARGES',distotal as 'DISCOUNT',subtotal as 'SUB TOTAL', TOTAL, chittotal as 'TOTAL SOP', REMARKS from tblsalestransaction where batchcode='" & batchcode & "'  and cancelled=0  union all " _
                                          + " select postrn as ID, ID as SUBID,PRODUCTID, concat('      - ',productname),quantity,unit,0,0,0,0,0,0,0,'' from tblsalesproductcustomorder where postrn in (select id from tblsalestransaction where batchcode='" & batchcode & "'  and void=0 )) as a order by ID,SUBID desc;", conn)
            Else
                msda = New MySqlDataAdapter("select * from (select ID,0 as SUBID,PRODUCTID,productname as 'PARTICULAR',quantity as QTY,UNIT,sellprice as 'UNIT PRICE',chargetotal as 'CHARGES',distotal as 'DISCOUNT',subtotal as 'SUB TOTAL', TOTAL,REMARKS from tblsalestransaction where batchcode='" & batchcode & "'  and cancelled=0  union all " _
                                          + " select postrn as ID, ID as SUBID,PRODUCTID, concat('      - ',productname),quantity,unit,0,0,0,0,0,'' from tblsalesproductcustomorder where postrn in (select id from tblsalestransaction where batchcode='" & batchcode & "'  and void=0 )) as a order by ID,SUBID desc;", conn)
            End If

          
        End If

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"ID", "SUBID", "PRODUCTID"})
        GridCurrencyColumn(MyDataGridView, {"QTY", "UNIT PRICE", "CHARGES", "DISCOUNT", "SUB TOTAL", "TOTAL", "SOP", "TOTAL SOP"})

        GridColumnAlignment(MyDataGridView, {"ID", "PRODUCTID", "DISCOUNT RATE", "UNIT", "QTY"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"UNIT PRICE", "CHARGES", "DISCOUNT", "TOTAL", "SUB TOTAL", "SOP", "TOTAL SOP"}, DataGridViewContentAlignment.MiddleRight)

        PaintColumnFormat()

        GridColumnChoosed(MyDataGridView, Me.Name)
        If MyDataGridView.Rows.Count > 1 Then
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Selected = True
            MyDataGridView.FirstDisplayedScrollingRowIndex = MyDataGridView.RowCount - 1
        End If

        If Val(txtTotalItem.Text) > 0 Then
            cmdRemarks.Enabled = True
            cmdAddCharges.Enabled = True
            cmdVoidTransaction.Enabled = True
            cmdCancelLine.Enabled = True
            cmdPayment.Enabled = True
            cmdHold.Enabled = True
            cmdChargeClientAccount.Enabled = True
            cmdEditLine.Enabled = True
            cmdDiscount.Enabled = True
            cmdPrintOrderSlip.Enabled = True
            cmdInterOffice.Enabled = True
            cmdCouponCharge.Enabled = True
            UpdateTransactionHeader()

     
            If globalAuthPointofSaleAssistant = True Then
                cmdPayment.Enabled = False
                cmdChargeClientAccount.Enabled = False
            Else
                cmdPayment.Enabled = True
                cmdChargeClientAccount.Enabled = True
            End If
        Else
            cmdRemarks.Enabled = False
            cmdAddCharges.Enabled = False
            cmdVoidTransaction.Enabled = False
            cmdCancelLine.Enabled = False
            cmdPayment.Enabled = False
            cmdHold.Enabled = False
            cmdPrintOrderSlip.Enabled = False
            cmdChargeClientAccount.Enabled = False
            cmdEditLine.Enabled = False
            cmdDiscount.Enabled = False
            cmdInterOffice.Enabled = False
            cmdCouponCharge.Enabled = False
            
        End If
        ClearForm()
    End Sub

    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"ID", "SUBID", "PRODUCTID"}, 0)
        GridColumAutonWidth(MyDataGridView, {"PARTICULAR", "UNIT", "QTY"})
        GridColumnWidth(MyDataGridView, {"UNIT PRICE", "CHARGES", "DISCOUNT", "DISCOUNT RATE", "SUB TOTAL", "SOP PRICE", "TOTAL SOP", "TOTAL"}, 80)

        Dim column As Array = {"ID", "SUBID", "PARTICULAR", "PRODUCTID", "QTY", "UNIT", "UNIT PRICE", "CHARGES", "DISCOUNT RATE", "DISCOUNT", "SOP PRICE", "TOTAL SOP", "SUB TOTAL", "TOTAL"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        GridColumnWidth(MyDataGridView, {"PARTICULAR"}, MyDataGridView.Width - TotalVisibleColumn)
    End Sub

    Private Sub MyDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles MyDataGridView.CellPainting

        'If e.RowIndex = 0 Then

        '    If (MyDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString() = MyDataGridView.Rows(e.RowIndex + 1).Cells(0).Value.ToString()) Then
        '        If (e.ColumnIndex = 3) Then
        '            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        '        End If
        '    End If

        'End If

        'If e.RowIndex > 0 Then
        '    If e.RowIndex < MyDataGridView.Rows.Count - 2 Then
        '        If (MyDataGridView.Rows(e.RowIndex - 1).Cells(0).Value.ToString() = MyDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString()) Then
        '            If (e.ColumnIndex = 3) Then
        '                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        '            End If
        '        End If

        '        If (MyDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString() = MyDataGridView.Rows(e.RowIndex + 1).Cells(0).Value.ToString()) Then
        '            If (e.ColumnIndex = 3) Then
        '                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        '            End If
        '        End If
        '    End If

        'End If


    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Public Sub UpdateTransactionHeader()
        Dim netincome As Double = qrysingledata("totalincome", "ifnull(sum(income),0) as 'totalincome'", "tblsalestransaction where batchcode='" & Trim(txtBatchcode.Text) & "' and void=0 and cancelled=0")
        Dim chittotal As Double = qrysingledata("chit_total", "ifnull(sum(chittotal),0) as 'chit_total'", "tblsalestransaction where batchcode='" & Trim(txtBatchcode.Text) & "' and void=0 and cancelled=0")
        If countqry("tblsalesbatch", "batchcode='" & Trim(txtBatchcode.Text) & "'") = 0 Then
            com.CommandText = "insert into tblsalesbatch set trnsumcode='" & globalSalesTrnCOde & "', " _
                                    + " userid='" & globalTransactionUserid & "', " _
                                    + " batchcode='" & Trim(txtBatchcode.Text) & "', " _
                                    + " officeid='" & compOfficeid & "', " _
                                    + " cifid='" & cifid.Text & "', " _
                                    + " totalitem='" & Val(CC(txtTotalItem.Text)) & "', " _
                                    + " totalitemcancelled='" & Val(CC(txtTotalCancelled.Text)) & "', " _
                                    + " totaldiscount='" & Val(CC(txtTotalDiscount.Text)) & "', " _
                                    + " totalcharge='" & Val(CC(txtTotalCharge.Text)) & "', " _
                                    + " totaltax='" & Val(CC(txtTotalTax.Text)) & "', " _
                                    + " totalsvcharge='" & Val(CC(txtServiceCharge.Text)) & "', " _
                                    + " subtotal='" & Val(CC(txtSubTotal.Text)) & "', " _
                                    + " chittotal=" & chittotal & "," _
                                    + If(chittotal > 0, "chittrn=1,", "chittrn=0, ") _
                                    + " total='" & Val(CC(txtTotalOnScreen.Text)) & "', " _
                                    + " totalincome='" & netincome & "', " _
                                    + " floattrn=1, " _
                                    + " attendingperson = '" & globalAssistantUserId & "', " _
                                    + " datetrn=" & If(globalBackDateTransaction = True, "concat('" & ConvertDate(globalBackDate) & "',' ',current_time)", "current_timestamp") & "" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblsalesbatch set trnsumcode='" & globalSalesTrnCOde & "', " _
                                   + " officeid='" & compOfficeid & "', " _
                                   + " cifid='" & cifid.Text & "', " _
                                   + " totalitem='" & Val(CC(txtTotalItem.Text)) & "', " _
                                   + " totalitemcancelled='" & Val(CC(txtTotalCancelled.Text)) & "', " _
                                   + " totaldiscount='" & Val(CC(txtTotalDiscount.Text)) & "', " _
                                   + " totalcharge='" & Val(CC(txtTotalCharge.Text)) & "', " _
                                   + " totaltax='" & Val(CC(txtTotalTax.Text)) & "', " _
                                   + " totalsvcharge='" & Val(CC(txtServiceCharge.Text)) & "', " _
                                   + " subtotal='" & Val(CC(txtSubTotal.Text)) & "', " _
                                   + " chittotal=" & chittotal & "," _
                                   + If(chittotal > 0, "chittrn=1,", "chittrn=0, ") _
                                   + " total='" & Val(CC(txtTotalOnScreen.Text)) & "', " _
                                   + " totalincome='" & netincome & "', " _
                                   + " floattrn=1, " _
                                   + " attendingperson = '" & globalAssistantUserId & "', " _
                                   + " datetrn=" & If(globalBackDateTransaction = True, "concat('" & ConvertDate(globalBackDate) & "',' ',current_time)", "current_timestamp") & " " _
                                   + " where batchcode='" & Trim(txtBatchcode.Text) & "'" : com.ExecuteNonQuery()
        End If
        txtuserid.Text = qrysingledata("userid", "userid", "tblsalesbatch where batchcode='" & txtBatchcode.Text & "'")
    End Sub

    Public Sub CancelSelectedTransaction(ByVal userid As String, ByVal remarks As String)
        com.CommandText = "update tblsalestransaction set cancelled=1, cancelledby='" & userid & "',cancelremarks='" & rchar(remarks) & "' where id='" & MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescoupon set cancelled=1, cancelledby='" & userid & "',datecancelled=current_timestamp where batchcode='" & txtBatchcode.Text & "' and productid='" & MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesproductcustomorder set void=1 where postrn='" & MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()

        '#update inventory rollback quantity of void item
        '--->
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblsalestransaction where id='" & MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                'Filter if the product is fuel
                Dim FuelProduct As Boolean = False
                If countqry("tblsalesfuelpump", "productid = '" & .Rows(cnt)("productid").ToString() & "'") > 0 Then
                    FuelProduct = True
                End If

                '#update inventory
                If FuelProduct = False And CBool(.Rows(cnt)("inventory").ToString()) = True Then
                    StockinInventory("POS Cancelled", .Rows(cnt)("inventorytrnid").ToString(), compOfficeid, .Rows(cnt)("productid").ToString(), .Rows(cnt)("quantity").ToString(), .Rows(cnt)("purchasedprice").ToString(), "transaction Cancelled #" + txtBatchcode.Text, "", txtBatchcode.Text, "")
                Else
                    If .Rows(cnt)("menumakerserviceref").ToString() <> "" Then
                        da = Nothing : st = New DataSet
                        da = New MySqlDataAdapter("select * from tblsalesmenumakerservice where refnumber='" & .Rows(cnt)("menumakerserviceref").ToString() & "'", conn)
                        da.Fill(st, 0)
                        For nt = 0 To st.Tables(0).Rows.Count - 1
                            com.CommandText = "UPDATE tblsalesmenumakerservice set void=1 where id='" & st.Tables(0).Rows(nt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Next
                    End If

                    If .Rows(cnt)("menumakerstockref").ToString() <> "" Then
                        da = Nothing : st = New DataSet
                        da = New MySqlDataAdapter("select * from tblsalesmenumakerstockout where refnumber='" & .Rows(cnt)("menumakerstockref").ToString() & "'", conn)
                        da.Fill(st, 0)
                        For nt = 0 To st.Tables(0).Rows.Count - 1
                            StockinInventory("POS Cancelled", st.Tables(0).Rows(nt)("stockno").ToString(), compOfficeid, st.Tables(0).Rows(nt)("productid").ToString(), st.Tables(0).Rows(nt)("quantity").ToString(), st.Tables(0).Rows(nt)("purchasedprice").ToString(), "Item Cancelled #" + txtBatchcode.Text, "", txtBatchcode.Text, "")
                            com.CommandText = "UPDATE tblsalesmenumakerstockout set void=1 where id='" & st.Tables(0).Rows(nt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Next
                    End If
                End If
            End With
        Next
        ValidatePOSTransaction(txtBatchcode.Text)
        'If countqry("tblsalestransaction", "batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0") = 0 Then
        '    com.CommandText = "update tblsalesbatch set void=1, voidby='" & globalTransactionUserid & "' where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
        '    BeginNewTransaction()
        'End If
        MsgBox("Transaction Successfully Cancelled!", MsgBoxStyle.Information)
        ClearForm()
    End Sub

    Private Sub txtQuantity_GotFocus(sender As Object, e As EventArgs) Handles txtQuantity.GotFocus
        txtQuantity.SelectAll()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBarCode.Focus()
        Else
            InputNumberOnly(txtQuantity, e)
        End If
    End Sub

    Private Sub cmdCancelLine_Click(sender As Object, e As EventArgs) Handles cmdCancelLine.Click
        MyDataGridView.Focus()
        If txtuserid.Text <> globalTransactionUserid Then
            MessageBox.Show("Modifying other user transaction is not allowed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to cancel selected transaction? " & Environment.NewLine & Environment.NewLine & "Note: Cancelling transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                PrintCancelledItem(MyDataGridView, txtBatchcode.Text, frmPOSVoidConfirmation.userid.Text, frmPOSVoidConfirmation.txtReason.Text)
                CancelSelectedTransaction(frmPOSVoidConfirmation.userid.Text, frmPOSVoidConfirmation.txtReason.Text)
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
        txtBarCode.Focus()
    End Sub

    Private Sub Stop_Button_Click(sender As Object, e As EventArgs) Handles cmdVoidTransaction.Click
        If MessageBox.Show("Are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                BeginNewTransaction()
                MsgBox("Transaction Successfully Void!", MsgBoxStyle.Information)
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
        txtBarCode.Focus()
    End Sub



    Private Sub cmdHold_Click(sender As Object, e As EventArgs) Handles cmdHold.Click
        If GlobalEnableQueuingSlip = True And countqry("tblsalesqueuingfilter", "permissioncode='" & globalAuthcode & "'") > 0 Then
            If countqry("tblsalesqueuingslip", "groupcode='" & qrysingledata("groupcode", "groupcode", "tblsalesqueuingfilter where permissioncode='" & globalAuthcode & "'") & "'") = 0 Then
                MessageBox.Show("Your account does'nt have queuing table permission!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            frmPOSOnholdQueue.batchcode.Text = txtBatchcode.Text
            frmPOSOnholdQueue.ShowDialog(Me)
        Else
            frmPOSOnholdConfirmation.batchcode.Text = txtBatchcode.Text
            frmPOSOnholdConfirmation.ShowDialog(Me)
        End If
        txtBarCode.Focus()
    End Sub

    Private Sub cmdChargeClientAccount_Click(sender As Object, e As EventArgs) Handles cmdChargeClientAccount.Click
        If GlobalEnableClientAccounts = False Then
            MessageBox.Show("Module charge to client accounts or client invoice is disabled or not subscribed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If countqry("tblclientaccounts", "cifid='" & cifid.Text & "' and walkinaccount=1") > 0 Then
            MessageBox.Show(txtClient.Text & " not allowed for this transaction!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf countqry("tblclientaccounts", "cifid='" & cifid.Text & "' and creditlimit=1") > 0 Then
            Dim remainingcredit As Double = Val(qrysingledata("creditlimitamount", "creditlimitamount", "tblclientaccounts where cifid='" & cifid.Text & "'")) - (Val(qrysingledata("totaldue", "sum(debit)-sum(credit) as totaldue", "tblglaccountledger where accountno='" & cifid.Text & "' and cancelled=0")) + Val(qrysingledata("amount", "amount", "tblsalesclientcharges where accountno='" & cifid.Text & "' and verified=0 and cancelled=0")))
            If remainingcredit < Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and tblsalestransaction.cancelled=0")) Then
                MessageBox.Show(txtClient.Text & " has only " & FormatNumber(remainingcredit, 2) & " available from credit limit! Transaction cannot be continue", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        If countqry("tblclientaccounts", "hotelclient=1 and cifid='" & cifid.Text & "'") > 0 Then
            If MessageBox.Show("Are you sure you want to charge hotel transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSChargetoHotelAcct.hotelcifid.Text = cifid.Text
                frmPOSChargetoHotelAcct.txtBatchcode.Text = txtBatchcode.Text
                frmPOSChargetoHotelAcct.ShowDialog(Me)
                If frmPOSChargetoHotelAcct.TransactionDone = True Then
                    BeginNewTransaction()
                    MessageBox.Show("Transaction successfully completed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmPOSChargetoHotelAcct.TransactionDone = False
                    frmPOSChargetoHotelAcct.Dispose()
                End If
            End If
        Else
            If MessageBox.Show("Are you sure you want to charge current transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSChargetoClientAcct.cifid.Text = cifid.Text
                frmPOSChargetoClientAcct.txtClientName.Text = txtClient.Text
                frmPOSChargetoClientAcct.txtBatchcode.Text = txtBatchcode.Text
                frmPOSChargetoClientAcct.ShowDialog(Me)
                If frmPOSChargetoClientAcct.TransactionDone = True Then
                    BeginNewTransaction()
                    MessageBox.Show("Transaction successfully completed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmPOSChargetoClientAcct.TransactionDone = False
                    frmPOSChargetoClientAcct.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdEditLine.Click
        MyDataGridView.Focus()
        If txtuserid.Text <> globalTransactionUserid Then
            MessageBox.Show("Modifying other user transaction is not allowed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MyDataGridView.Item("PARTICULAR", MyDataGridView.CurrentRow.Index).Value().ToString() = "" Then
            MsgBox("No Item Selected!", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf countqry("tblglobalproducts", " productid='" & MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString() & "' and menuitem=1") > 0 Then
            MsgBox("Product item from menu maker is not allowed! please use cancel line", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf countqry("tblglobalproducts", " productid='" & MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString() & "' and servicemenuproduct=1") > 0 Then
            MsgBox("Product item from menu maker is not allowed! please use cancel line", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        frmPOSEditLine.txtBatchCode.Text = txtBatchcode.Text
        frmPOSEditLine.cifid.Text = cifid.Text
        frmPOSEditLine.trnid.Text = MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtBarCode.Text = MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtQuantity.Text = MyDataGridView.Item("QTY", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtOriginalQuantity.Text = MyDataGridView.Item("QTY", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtSellPrice.Text = MyDataGridView.Item("UNIT PRICE", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtAmount.Text = MyDataGridView.Item("SUB TOTAL", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtCompanyName.Text = MyDataGridView.Item("PARTICULAR", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmPOSEditLine.txtRemarks.Text = MyDataGridView.Item("REMARKS", MyDataGridView.CurrentRow.Index).Value().ToString()

        If compEnableInventory = True Then
            frmPOSEditLine.ckContractMode.Checked = CBool(qrysingledata("forcontract", "forcontract", "tblglobalproducts where productid='" & MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString() & "'"))
        Else
            frmPOSEditLine.ckContractMode.Checked = True
        End If

        If qrysingledata("salemode", "salemode", "tblglobalproducts where productid='" & MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString() & "'") = "esbq" Then
            frmPOSEditLine.mode.Text = "EQ"
        Else
            frmPOSEditLine.mode.Text = "EA"
        End If

        frmPOSEditLine.ShowDialog(Me)
        If frmPOSEditLine.ConfirmedEdit = True Then
            ValidatePOSTransaction(txtBatchcode.Text)
            frmPOSEditLine.ConfirmedEdit = False
            frmPOSEditLine.Dispose()
            grpBarcode.Focus()
        Else
            Exit Sub
        End If
        txtBarCode.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdRecoveredTransaction.Click
        If Val(txtTotalItem.Text) > 0 Then
            If MessageBox.Show("System found current transaction is not validated yet! are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSVoidConfirmation.ShowDialog(Me)
                If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                    VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                    BeginNewTransaction()
                    MsgBox("Transaction Successfully Void!", MsgBoxStyle.Information)
                    frmPOSVoidConfirmation.ApprovedConfirmation = False
                    frmPOSVoidConfirmation.Dispose()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
        frmPOSOnHoldAndFloatTransaction.mode.Text = "floattrn"
        frmPOSOnHoldAndFloatTransaction.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles cmdOnholdTransaction.Click
        If Val(txtTotalItem.Text) > 0 Then
            If MessageBox.Show("System found current transaction is not validated yet! are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSVoidConfirmation.ShowDialog(Me)
                If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                    VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                    BeginNewTransaction()
                    MsgBox("Transaction Successfully Void!", MsgBoxStyle.Information)
                    frmPOSVoidConfirmation.ApprovedConfirmation = False
                    frmPOSVoidConfirmation.Dispose()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
        If GlobalEnableQueuingSlip = True And countqry("tblsalesqueuingfilter", "permissioncode='" & globalAuthcode & "'") > 0 Then
            frmPOSQueueOrderSlip.ShowDialog(Me)
        Else
            frmPOSOnHoldAndFloatTransaction.mode.Text = "onhold"
            frmPOSOnHoldAndFloatTransaction.ShowDialog(Me)
        End If
    End Sub

    Private Sub frmPointOfSale_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Me.FormBorderStyle = FormBorderStyle.None
        End If
        PaintColumnFormat()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles cmdNewClient.Click
        frmPOSClientInformation.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles cmdTransactionHistory.Click
        frmPOSTransactionsHistory.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdProductSearch.Click
        If cifid.Text = "" Then
            MessageBox.Show("Please select client!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtuserid.Text <> globalTransactionUserid Then
            frmPOSProductSearch.mode.Text = "searchmode"
            frmPOSProductSearch.ShowDialog(Me)
        Else
            If frmPOSProductSearch.Visible = True Then
                frmPOSProductSearch.Focus()
            Else
                frmPOSProductSearch.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub cmdClosedAccount_Click(sender As Object, e As EventArgs) Handles cmdClosedAccount.Click
        If Val(txtTotalItem.Text) > 0 Then
            If MessageBox.Show("System found current transaction is not validated yet! are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSVoidConfirmation.ShowDialog(Me)
                If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                    VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                    BeginNewTransaction()
                    MsgBox("Transaction Successfully Void!", MsgBoxStyle.Information)
                    frmPOSVoidConfirmation.ApprovedConfirmation = False
                    frmPOSVoidConfirmation.Dispose()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        ElseIf countqry("tblsalesbatch", "floattrn=1 and onhold=0 and void=0 and forcashiertrn=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 Then
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

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs)
        frmPOSQueueOrderSlip.Show(Me)
    End Sub

#Region "PRINTING"
    'Public Sub PrintTransaction(ByVal trntype As String, ByVal cash As Double, ByVal change As Double)
    '    Dim details As String = "" : Dim BalanceSheet As String = ""
    '    Dim salefilelocation As String = Application.StartupPath.ToString & "\Transaction\" & globalfullname & "\" & CDate(Now.ToShortDateString()).ToString("yyyy-MM-dd") & "\POS\" & globalSalesTrnCOde
    '    details = Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(250)
    '    details += If(GlobalTinNumber.Length > 0, PrintCenterText(GlobalOrganizationName) & Environment.NewLine, "")
    '    details += If(GlobalTinNumber.Length > 0, PrintCenterText("TIN# " & GlobalTinNumber) & Environment.NewLine, "")
    '    details += If(GlobalOrganizationAddress.Length > 0, PrintCenterText(GlobalOrganizationAddress) & Environment.NewLine, "")
    '    details += If(GlobalOrganizationContactNumber.Length > 0, PrintCenterText("Tell.#: " & GlobalOrganizationContactNumber) & Environment.NewLine, "")
    '    details += If(GlobalPermitNumber.Length > 0, PrintCenterText("Permit#: " & GlobalPermitNumber) & Environment.NewLine, "")
    '    details += If(GlobalMiNumber.Length > 0, PrintCenterText("M.I.#: " & GlobalMiNumber) & Environment.NewLine, "")
    '    details += If(GlobalSNumber.Length > 0, PrintCenterText("S.N: " & GlobalSNumber) & Environment.NewLine & Environment.NewLine, "")


    '    details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
    '    details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
    '    details += PrintLeftText("TRN: " & txtBatchcode.Text) & Environment.NewLine
    '    details += PrintSpaceLine() & Environment.NewLine


    '    For i = 0 To MyDataGridView.RowCount - 1
    '        details += PrintLeftText(StrConv(MyDataGridView.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
    '        details += PrintLeftRigthText("  - " & MyDataGridView.Item("QTY", i).Value() & " " & MyDataGridView.Item("UNIT", i).Value() & " @" & FormatNumber(MyDataGridView.Item("UNIT PRICE", i).Value(), 2), FormatNumber(MyDataGridView.Item("TOTAL", i).Value(), 2)) & Environment.NewLine
    '    Next
    '    details += Environment.NewLine

    '    details += PrintLeftRigthText("TOTAL", txtTotalOnScreen.Text) & Environment.NewLine
    '    details += PrintLeftRigthText(trntype, FormatNumber(cash, 2)) & Environment.NewLine
    '    details += PrintLeftRigthText("CHANGE", FormatNumber(change, 2)) & Environment.NewLine


    '    details += Environment.NewLine & Environment.NewLine
    '    If GlobalPosReceiptType = "OFFICIAL" Then
    '        details += PrintCenterText("THIS SERVE AS YOUR OFFICIAL RECEIPT") & Environment.NewLine
    '    ElseIf GlobalPosReceiptType = "NOT OFFICIAL" Then
    '        details += PrintCenterText("THIS IS NOT AN OFFICIAL RECEIPT") & Environment.NewLine
    '    ElseIf GlobalPosReceiptType = "TEMPORARY" Then
    '        details += PrintCenterText("THIS SERVE AS YOUR TEMPORARY RECEIPT") & Environment.NewLine
    '    End If
    '    details += PrintCenterText("Thank You and Please Come Again!")
    '    details += LastPagepaper()

    '    If (Not System.IO.Directory.Exists(salefilelocation)) Then
    '        System.IO.Directory.CreateDirectory(salefilelocation)
    '    End If

    '    If System.IO.File.Exists(salefilelocation & "\" & txtBatchcode.Text & ".txt") = True Then
    '        System.IO.File.Delete(salefilelocation & "\" & txtBatchcode.Text & ".txt")
    '    End If

    '    Dim detailsFile As StreamWriter = Nothing
    '    detailsFile = New StreamWriter(salefilelocation & "\" & txtBatchcode.Text & ".txt", True)
    '    detailsFile.WriteLine(details)
    '    detailsFile.Close()
    '    PrintTextFile(salefilelocation & "\" & txtBatchcode.Text & ".txt")
    'End Sub

    'Public Sub PrintTemporaryTransaction()
    '    Dim details As String = "" : Dim BalanceSheet As String = ""
    '    Dim salefilelocation As String = Application.StartupPath.ToString & "\Transaction\" & globalfullname & "\" & CDate(Now.ToShortDateString()).ToString("yyyy-MM-dd") & "\POS\" & globalSalesTrnCOde
    '    details = If(GlobalTinNumber.Length > 0, PrintCenterText(GlobalOrganizationName) & Environment.NewLine, "")
    '    details += If(GlobalTinNumber.Length > 0, PrintCenterText("TIN# " & GlobalTinNumber) & Environment.NewLine, "")
    '    details += If(GlobalOrganizationAddress.Length > 0, PrintCenterText(GlobalOrganizationAddress) & Environment.NewLine, "")
    '    details += If(GlobalOrganizationContactNumber.Length > 0, PrintCenterText("Tell.#: " & GlobalOrganizationContactNumber) & Environment.NewLine, "")
    '    details += If(GlobalPermitNumber.Length > 0, PrintCenterText("Permit#: " & GlobalPermitNumber) & Environment.NewLine, "")
    '    details += If(GlobalMiNumber.Length > 0, PrintCenterText("M.I.#: " & GlobalMiNumber) & Environment.NewLine, "")
    '    details += If(GlobalSNumber.Length > 0, PrintCenterText("S.N: " & GlobalSNumber) & Environment.NewLine & Environment.NewLine, "")

    '    details += Environment.NewLine & PrintCenterText("ORDER SLIP") & Environment.NewLine & Environment.NewLine

    '    details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
    '    details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
    '    details += PrintLeftText("TRN: " & txtBatchcode.Text) & Environment.NewLine
    '    details += PrintSpaceLine() & Environment.NewLine


    '    For i = 0 To MyDataGridView.RowCount - 1
    '        details += PrintLeftText(StrConv(MyDataGridView.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
    '        details += PrintLeftRigthText("  - " & MyDataGridView.Item("QTY", i).Value() & " " & MyDataGridView.Item("UNIT", i).Value() & " @" & FormatNumber(MyDataGridView.Item("UNIT PRICE", i).Value(), 2), FormatNumber(MyDataGridView.Item("TOTAL", i).Value(), 2)) & Environment.NewLine
    '    Next
    '    details += Environment.NewLine

    '    details += PrintLeftRigthText("TOTAL", txtTotalOnScreen.Text) & Environment.NewLine

    '    details += Environment.NewLine & Environment.NewLine
    '    details += PrintCenterText("THIS SERVE AS YOUR ORDER SLIP") & Environment.NewLine
    '    details += PrintCenterText("Thank You and Please Come Again!")
    '    details += LastPagepaper()

    '    If (Not System.IO.Directory.Exists(salefilelocation)) Then
    '        System.IO.Directory.CreateDirectory(salefilelocation)
    '    End If

    '    If System.IO.File.Exists(salefilelocation & "\" & txtBatchcode.Text & ".txt") = True Then
    '        System.IO.File.Delete(salefilelocation & "\" & txtBatchcode.Text & ".txt")
    '    End If

    '    Dim detailsFile As StreamWriter = Nothing
    '    detailsFile = New StreamWriter(salefilelocation & "\" & txtBatchcode.Text & ".txt", True)
    '    detailsFile.WriteLine(details)
    '    detailsFile.Close()
    '    PrintTextFile(salefilelocation & "\" & txtBatchcode.Text & ".txt")
    'End Sub
#End Region

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdDiscount.Click
        frmPOSDiscount.txtBatchcode.Text = txtBatchcode.Text
        frmPOSDiscount.ShowDialog(Me)
        txtBarCode.Focus()
        'RePrintPOSReceipt(qrysingledata("batchcode", "batchcode", "tblsalesbatch where onhold=0 and void=0 and trnsumcode='" & globalSalesTrnCOde & "' order by datetrn desc limit 1"))
    End Sub

    Private Sub cmdPrintOrderSlip_Click(sender As Object, e As EventArgs) Handles cmdPrintOrderSlip.Click
        If MessageBox.Show("Are you sure you want to print selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            PrintPOSOderSlip(txtBatchcode.Text, txtClient.Text, globalfullname)
        End If
    End Sub

    Private Sub ToolStripButton2_Click_2(sender As Object, e As EventArgs) Handles cmdPendingOrderSlip.Click
        If Val(txtTotalItem.Text) > 0 Then
            If MessageBox.Show("System found current transaction is not validated yet! are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSVoidConfirmation.ShowDialog(Me)
                If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                    VoidBatchSalesTransaction(txtBatchcode.Text, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                    BeginNewTransaction()
                    MsgBox("Transaction Successfully Void!", MsgBoxStyle.Information)
                    frmPOSVoidConfirmation.ApprovedConfirmation = False
                    frmPOSVoidConfirmation.Dispose()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
        frmPOSOnHoldAndFloatTransaction.mode.Text = "orderslip"
        frmPOSOnHoldAndFloatTransaction.ShowDialog(Me)
    End Sub

    Private Sub cmdTraceTransaction_Click(sender As Object, e As EventArgs) Handles cmdTraceTransaction.Click
        frmPOSTraceTransactionOption.Show(Me)
    End Sub

    Private Sub cmdReturnCurrentInvoice_Click(sender As Object, e As EventArgs) Handles cmdReturnCurrentInvoice.Click
        frmPOSReviseCurrentInvoice.Show(Me)
    End Sub

    Private Sub cmdDueto_Click(sender As Object, e As EventArgs) Handles cmdInterOffice.Click
        If MessageBox.Show("Are you sure you want to due current transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSInterOffice.txtBatchcode.Text = txtBatchcode.Text
            frmPOSInterOffice.ShowDialog(Me)
            If frmPOSInterOffice.TransactionDone = True Then
                BeginNewTransaction()
                MessageBox.Show("Transaction successfully completed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmPOSInterOffice.TransactionDone = False
                frmPOSInterOffice.Dispose()
            End If
        End If
    End Sub

    Private Sub cmdCouponCharge_Click(sender As Object, e As EventArgs) Handles cmdCouponCharge.Click
        If MessageBox.Show("Are you sure you want to due current transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSCouponCharge.txtBatchcode.Text = txtBatchcode.Text
            frmPOSCouponCharge.ShowDialog(Me)
            If frmPOSCouponCharge.TransactionDone = True Then
                BeginNewTransaction()
                MessageBox.Show("Transaction successfully completed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmPOSCouponCharge.TransactionDone = False
                frmPOSCouponCharge.Dispose()
            End If
        End If
    End Sub

   
    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode() = Keys.Insert Then
            If countqry("tblsalestransaction", "id='" & MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString & "' and customproductorder=1") > 0 Then
                For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                    frmPOSCustomOrderItemized.productid.Text = MyDataGridView.Item("PRODUCTID", MyDataGridView.CurrentRow.Index).Value().ToString
                    frmPOSCustomOrderItemized.txtBatchcode.Text = txtBatchcode.Text
                    frmPOSCustomOrderItemized.postrn.Text = rw.Cells("ID").Value.ToString
                    If frmPOSCustomOrderItemized.Visible = True Then
                        frmPOSCustomOrderItemized.Focus()
                    Else
                        frmPOSCustomOrderItemized.ShowDialog(Me)
                    End If
                Next

               
            End If
        ElseIf e.KeyCode() = Keys.R Then
            ValidatePOSTransaction(txtBatchcode.Text)
        End If
    End Sub
 
    Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click
        If countqry("tblclientaccounts", "cifid='" & cifid.Text & "' and walkinaccount=1") > 0 Then
            MessageBox.Show(txtClient.Text & " not allowed for this transaction!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmPOSClientInformation.mode.Text = "view"
        frmPOSClientInformation.id.Text = cifid.Text
        frmPOSClientInformation.Show(Me)
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        frmPOSClientSearch.Show(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRemarks.Click
        MyDataGridView.Focus()
        frmPOSAddRemarks.trnid.Text = MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPOSAddRemarks.txtBatchcode.Text = txtBatchcode.Text
        frmPOSAddRemarks.ShowDialog()
        txtBarCode.Focus()
    End Sub

    Private Sub MyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentClick
        Dim RemarksColumnVisible As Boolean = False
        If e.ColumnIndex = MyDataGridView.Columns("REMARKS").Index Then
            RemarksColumnVisible = True
        End If
        If RemarksColumnVisible = False Then Exit Sub
        frmPOSAddRemarks.trnid.Text = MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPOSAddRemarks.txtBatchcode.Text = txtBatchcode.Text
        frmPOSAddRemarks.txtRemarks.Text = MyDataGridView.Item("REMARKS", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPOSAddRemarks.ShowDialog()
    End Sub

    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        Dim RemarksColumnVisible As Boolean = False
        If e.ColumnIndex = MyDataGridView.Columns("REMARKS").Index Then
            RemarksColumnVisible = True
        End If
        If RemarksColumnVisible = False Then Exit Sub
        frmPOSAddRemarks.trnid.Text = MyDataGridView.Item("ID", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPOSAddRemarks.txtBatchcode.Text = txtBatchcode.Text
        frmPOSAddRemarks.ShowDialog()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles cmdAddCharges.Click
        frmPOSCharges.txtBatchcode.Text = txtBatchcode.Text
        frmPOSCharges.ShowDialog(Me)
        txtBarCode.Focus()
    End Sub
End Class