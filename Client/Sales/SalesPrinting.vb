Imports System.IO
Imports MySql.Data.MySqlClient

Module SalesPrinting

#Region "POS PRINT"
    Public Sub OpenCashDrawer()
        Dim details As String = ""
        Dim salefilelocation As String = System.IO.Path.GetTempPath
        details = Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(250)
        If System.IO.File.Exists(salefilelocation & "\" & globaluserid & ".txt") = True Then
            System.IO.File.Delete(salefilelocation & "\" & globaluserid & ".txt")
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(salefilelocation & "\" & globaluserid & ".txt", True)
        detailsFile.WriteLine(details)
        detailsFile.Close()
        PrintTextFile(salefilelocation & "\" & globaluserid & ".txt")
    End Sub

    Public Function PrintPOSReciept(ByVal print As Boolean, ByVal claimsop As Boolean, ByVal batchcode As String, ByVal seriesno As String, ByVal customer As String, ByVal trntype As String, ByVal vatTotal As Double, ByVal ServiceCharge As Double, ByVal totaldeposit As Double, ByVal totalAmount As Double, ByVal cash As Double, ByVal change As Double, ByVal gridview As DataGridView) As String
        Dim details As String = "" : Dim BalanceSheet As String = ""
        details = PageHeader2(print)
        details += PrintCenterText("SALES INVOICE") & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Customer: " & customer) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        details += PrintLeftText("Cashier: " & If(globalNickName = "", globalfullname, globalNickName)) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN Code: " & batchcode) & Environment.NewLine
        details += PrintLeftText("TRN Series: " & seriesno) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        If Globalenablechittransaction = True Then
            If claimsop = False Then
                For i = 0 To gridview.RowCount - 1
                    If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                        details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
                    Else
                        details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
                        details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())) + Val(CC(gridview.Item("SOP", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())) + Val(CC(gridview.Item("TOTAL SOP", i).Value())), 2)) & Environment.NewLine
                    End If
                Next
            Else
                For i = 0 To gridview.RowCount - 1
                    If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                        details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
                    Else
                        details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
                        details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
                    End If
                Next
            End If
        Else
            For i = 0 To gridview.RowCount - 1
                If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                    details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase) & If(gridview.Item("REMARKS", i).Value().ToString = "", "", " - " & StrConv(gridview.Item("REMARKS", i).Value(), vbProperCase)), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
                Else
                    details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase) & If(gridview.Item("REMARKS", i).Value().ToString = "", "", " - " & StrConv(gridview.Item("REMARKS", i).Value(), vbProperCase))) & Environment.NewLine
                    details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
                End If
            Next
        End If


        details += Environment.NewLine
        If GlobalTaxAddtoTotal = True Then
            details += PrintLeftRigthText("VAT " & GlobalTaxRate & "%", FormatNumber(vatTotal, 2)) & Environment.NewLine
        End If
        If GlobalTaxAddtoTotal = True Then
            details += PrintLeftRigthText("SVC " & GlobalServiceChargeRate & "%", FormatNumber(ServiceCharge, 2)) & Environment.NewLine
        End If
        details += Environment.NewLine
        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine
        If totaldeposit > 0 Then
            details += PrintLeftRigthText("DEPOSIT", FormatNumber(totaldeposit, 2)) & Environment.NewLine
        End If
        details += PrintLeftRigthText(trntype, FormatNumber(cash, 2)) & Environment.NewLine
        details += PrintLeftRigthText("CHANGE", FormatNumber(change, 2)) & Environment.NewLine


        details += Environment.NewLine & Environment.NewLine
        For Each word In GlobalPosReceiptType.Split(New Char() {vbCrLf})
            Dim str As String = RTrim(LTrim(Trim(word)))
            details += PrintCenterText(str.Replace(vbLf, "")) & Environment.NewLine
        Next
        details += Environment.NewLine & PrintCenterText("CUSTOMER REMINDER") & Environment.NewLine
        details += PrintCenterText("This is not an Official Receipt ") & Environment.NewLine
        details += PrintCenterText("PLEASE ALWAYS ASK FOR BIR OFFICIAL RECEIPT! ") & Environment.NewLine
        details += LastPagepaper()

        com.CommandText = "update tblsalesbatch set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        If print = True Then
            If Globalenableprintrecieptcashier = True Then
                POSPrint(details, batchcode, "RECEIPT")
            End If
            Return True
        Else
            Return details
        End If
        Return details
    End Function

    Public Function PrintPOSChitReciept(ByVal print As Boolean, ByVal batchcode As String, ByVal customer As String, ByVal trntype As String, ByVal chitcustomer As String, ByVal sop As Double, ByVal payabletax As Double, ByVal netsop As Double, ByVal gridview As DataGridView) As String
        Dim details As String = "" : Dim BalanceSheet As String = ""

        details = PageHeader()
        details += PrintCenterText("Customer: " & customer) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        details += PrintLeftText("Cashier: " & If(globalNickName = "", globalfullname, globalNickName)) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN: " & batchcode) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        For i = 0 To gridview.RowCount - 1
            details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
            details += PrintLeftRigthText("  - " & gridview.Item("QTY", i).Value() & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(gridview.Item("SOP", i).Value(), 2), FormatNumber(gridview.Item("TOTAL SOP", i).Value(), 2)) & Environment.NewLine
        Next
        details += Environment.NewLine

        details += PrintLeftRigthText("TOTAL SOP", FormatNumber(sop, 2)) & Environment.NewLine
        details += PrintLeftRigthText("TAX", FormatNumber(payabletax, 2)) & Environment.NewLine
        details += PrintLeftRigthText("NET SOP", FormatNumber(netsop, 2)) & Environment.NewLine

        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(StrConv(chitcustomer, vbProperCase)) & Environment.NewLine & PrintCenterText("Customer Signature")
        details += LastPagepaper()

        com.CommandText = "update tblsalesbatch set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        If print = True Then
            If Globalenableprintrecieptcashier = True Then
                POSPrint(details, batchcode, "SOP")
            End If
            Return True
        Else
            Return details
        End If
    End Function

    Public Sub PrintCancelledItem(ByVal gridview As DataGridView, ByVal batchcode As String, ByVal cancelledby As String, ByVal cancelledremarks As String)
        Dim details As String = ""
        If countqry("tblsalesbatch", "batchcode='" & batchcode & "' and processed=1 and void=0") > 0 Then
            Dim salesPerson As String = ""
            com.CommandText = "select *,(select if(nickname='',fullname,nickname) from tblaccounts where accountid=tblsalesbatch.attendingperson) as attperson from tblsalesbatch where batchcode='" & batchcode & "'" : rst = com.ExecuteReader
            While rst.Read
                salesPerson = rst("attperson").ToString
            End While
            rst.Close()

            details = PageHeader()
            details = If(globalposEnableCashDrawer = True, (27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")
            details += Environment.NewLine & PrintCenterText("CANCELLED ITEM") & Environment.NewLine & Environment.NewLine

            details += PrintLeftText("Waiter: " & salesPerson) & Environment.NewLine
            details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
            details += PrintLeftText("TRN: " & batchcode) & Environment.NewLine
            details += PrintSpaceLine() & Environment.NewLine

            For Each rw As DataGridViewRow In gridview.SelectedRows
                details += PrintLeftText(rw.Cells("QTY").Value.ToString & " - " & StrConv(rw.Cells("PARTICULAR").Value.ToString, vbProperCase)) & Environment.NewLine
            Next

            details += Environment.NewLine
            details += PrintLeftText("Note: " & cancelledremarks)
            details += Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(qrysingledata("fullname", "fullname", "tblaccounts where accountid='" & cancelledby & "'")) & Environment.NewLine
            details += PrintCenterText("(Signature)")
            details += LastPagepaper()

            If globalPosSecondaryPrinterDevice <> "" Then
                POSQueuePrint(details)
            Else
                Dim Print As New POSDirectPrinter
                POSPrint(details, batchcode, "CANCELLED")
            End If
        End If
    End Sub

    Public Sub PrintPOSOrderSlipCashierAssistant(ByVal trntype As String, ByVal batchcode As String, ByVal CashierName As String, ByVal SalesPersonName As String, ByVal ProcessorName As String, ByVal totalAmount As Double, ByVal amounttender As Double, ByVal gridview As DataGridView)
        Dim details As String = "" : Dim BalanceSheet As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText(trntype) & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Sales Person: " & SalesPersonName) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN Code: " & batchcode) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        For i = 0 To gridview.RowCount - 1
            If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            Else
                details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
                details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            End If
        Next
        details += Environment.NewLine

        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine
        details += PrintLeftRigthText("PAYMENT", FormatNumber(amounttender, 2)) & Environment.NewLine

        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(globalAssistantFullName) & Environment.NewLine
        details += PrintCenterText("(Signature)")
        details += LastPagepaper()

        POSPrint(details, batchcode, "ORDER SLIP")
    End Sub

    Public Sub PrintPOSQueueSlip(ByVal QueueTitle As String, ByVal batchcode As String, ByVal oldbatchcode As String, ByVal category As String, ByVal Note As String, ByVal processby As String, ByVal secondaryPrinter As Boolean)
        Dim details As String = "" : Dim BalanceSheet As String = ""

        details = If(globalposEnableCashDrawer = True, (27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")
        details += Environment.NewLine & PrintCenterText(QueueTitle) & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN Code: " & oldbatchcode) & Environment.NewLine
        details += PrintLeftText("Waiter: " & processby) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblsalestransaction where batchcode='" & batchcode & "' and (" & category & ") and cancelled=0 and void=0", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                details += PrintLeftText(.Rows(cnt)("quantity").ToString() & " " & StrConv(.Rows(cnt)("productname").ToString() & If(.Rows(cnt)("remarks").ToString() <> "", " - " & .Rows(cnt)("remarks").ToString(), ""), vbProperCase)) & Environment.NewLine
                com.CommandText = "select * from tblsalesproductcustomorder where postrn='" & .Rows(cnt)("id").ToString() & "' and void=0" : rst = com.ExecuteReader
                While rst.Read
                    details += PrintLeftText("  - " & rst("quantity").ToString & "  " & StrConv(rst("productname").ToString, vbProperCase)) & Environment.NewLine
                End While
                rst.Close()
            End With
        Next
        details += Environment.NewLine
        details += PrintCenterText(Note)
        details += Environment.NewLine
        details += LastPagepaper()

        If secondaryPrinter = True Then
            If globalPosSecondaryPrinterDevice <> "" Then
                POSQueuePrint(details)
            Else
                Dim Print As New POSDirectPrinter
                POSPrint(details, batchcode, "QUEUING")
            End If
        Else
            Dim Print As New POSDirectPrinter
            POSPrint(details, batchcode, "QUEUING")
        End If
    End Sub

    Public Sub PrintCoupon(ByVal batchcode As String)
        Dim couponqry As String = ""
        com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product,(select officename from tblcompoffice where officeid = tblsalescoupon.centerofficeid) as outlet from tblsalescoupon where batchcode='" & batchcode & "' and cancelled=0" : rst = com.ExecuteReader
        While rst.Read
            Dim details As String = ""
            details = PrintCenterText(GlobalOrganizationName) & Environment.NewLine & Environment.NewLine
            details += PrintCenterText("C O U P O N   T I C K E T") & Environment.NewLine & Environment.NewLine

            details += PrintLeftRigthText("Date: " & rst("coupondate").ToString, "Code: " & rst("couponcode").ToString) & Environment.NewLine
            details += PrintLeftText("Outlet: " & rst("outlet").ToString) & Environment.NewLine
            details += PrintSpaceLine() & Environment.NewLine


            details += PrintLeftText(StrConv(rst("product").ToString, vbProperCase)) & Environment.NewLine
            details += PrintLeftRigthText("  - " & rst("quantity").ToString & " " & rst("unit").ToString & " @" & FormatNumber(Val(rst("unitprice").ToString), 2), FormatNumber(Val(rst("total").ToString), 2)) & Environment.NewLine
            details += LastPagepaper()

            POSPrint(details, rst("couponcode").ToString, "COUPON")
            couponqry = "update tblsalescoupon set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "', printed=1 where couponcode='" & rst("couponcode").ToString & "';" & Chr(13)
        End While
        rst.Close()
        If couponqry.Length > 0 Then
            couponqry = couponqry.Remove(couponqry.Length - 1, 1)
            com.CommandText = couponqry : com.ExecuteNonQuery()
        End If
    End Sub


    Public Sub PrintPOSCashDenomination(ByVal onethousand As String, ByVal fivehundred As String, ByVal twohundred As String, ByVal onehundred As String, ByVal fifty As String, ByVal twenty As String, ByVal ten As String, ByVal five As String, ByVal one As String, ByVal others As Double, ByVal totalbill As Double, ByVal totalcoin As Double, ByVal totalamount As Double)
        Dim details As String = "" : Dim BalanceSheet As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("CASH COUNT BLOTTER") & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Transaction #: " & globalSalesTrnCOde) & Environment.NewLine
        details += PrintLeftText("Office: " & compOfficename) & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("Date: " & Now.ToString) & Environment.NewLine

        details += PrintSpaceLine() & Environment.NewLine

        details += PrintLeftRigthText(" QTY " & "  " & "DENOMINATION", "TOTAL") & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(onethousand) & "   " & "@ 1,000.00", FormatNumber(1000 * onethousand, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(fivehundred) & "   " & "@ 500.00", FormatNumber(500 * fivehundred, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(twohundred) & "   " & "@ 200.00", FormatNumber(200 * twohundred, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(onehundred) & "   " & "@ 100.00", FormatNumber(100 * onehundred, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(fifty) & "   " & "@ 50.00", FormatNumber(50 * fifty, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(twenty) & "   " & "@ 20.00", FormatNumber(20 * twenty, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(ten) & "   " & "@ 10.00", FormatNumber(10 * ten, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(five) & "   " & "@ 5.00", FormatNumber(5 * five, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace(one) & "   " & "@ 1.00", FormatNumber(1 * one, 2)) & Environment.NewLine
        details += PrintLeftRigthText(GetQuantitySpace("-") & "   " & "@ Other", FormatNumber(others, 2)) & Environment.NewLine
        details += Environment.NewLine

        details += PrintLeftRigthText("TOTAL BILL", FormatNumber(totalbill, 2)) & Environment.NewLine
        details += PrintLeftRigthText("TOTAL COIN", FormatNumber(totalcoin, 2)) & Environment.NewLine
        details += PrintLeftRigthText("TOTAL REMITTED", FormatNumber(totalamount, 2)) & Environment.NewLine

        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(globalfullname) & Environment.NewLine
        details += PrintCenterText("(Signature)")
        details += LastPagepaper()

        com.CommandText = "update tblsalescashdenomination set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where trnsumcode='" & globalSalesTrnCOde & "' order by timeposted desc limit 1" : com.ExecuteNonQuery()
        If globalPosCustomFont = True Then
            globalPosCustomFont = False
            POSPrint(details, globalSalesTrnCOde & "-denomination", "BLOTTER")
            globalPosCustomFont = True
        Else
            POSPrint(details, globalSalesTrnCOde & "-denomination", "BLOTTER")
        End If
    End Sub

    Public Sub RePrintPOSTransaction(ByVal reference As String, ByVal table As String, ByVal id As String, ByVal reportcolumn As String)
        Dim details As String = ""
        com.CommandText = "select * from " & table & " where " & id & "='" & reference & "'" : rst = com.ExecuteReader
        While rst.Read
            details = rst(reportcolumn).ToString
        End While
        rst.Close()
        If Globalenableprintrecieptcashier = True Then
            POSPrint(details, reference, "RECEIPT")
        End If
    End Sub

   

    Public Sub PrintPOSOderSlip(ByVal batchcode As String, ByVal customer As String, ByVal waiter As String)
        Dim details As String = "" : Dim BalanceSheet As String = ""

        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("CUSTOMER BILL") & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Customer: " & customer) & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN: " & batchcode) & Environment.NewLine
        details += PrintLeftText(waiter) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine


        Dim totalAmount As Double = 0 : Dim vat As Double = 0 : Dim svc As Double = 0
        com.CommandText = "select * from tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0 and void=0" : rst = com.ExecuteReader
        While rst.Read
            If Val(rst("total").ToString) < 0 Then
                details += PrintLeftRigthText(StrConv(rst("productname").ToString, vbProperCase), FormatNumber(Val(rst("total").ToString), 2)) & Environment.NewLine
            Else
                details += PrintLeftText(StrConv(rst("productname").ToString, vbProperCase)) & Environment.NewLine
                details += PrintLeftRigthText("  - " & rst("quantity").ToString & " " & rst("unit").ToString & " @" & FormatNumber(Val(rst("sellprice").ToString), 2), FormatNumber(Val(rst("total").ToString), 2)) & Environment.NewLine
            End If
           
            totalAmount = totalAmount + Val(rst("total").ToString)
            vat = vat + Val(rst("taxtotal").ToString)
            svc = svc + Val(rst("svchargetotal").ToString)
        End While
        rst.Close()

        If GlobalTaxAddtoTotal = True Then
            details += Environment.NewLine
            details += PrintLeftRigthText("VAT " & GlobalTaxRate & "%", FormatNumber(vat, 2)) & Environment.NewLine
        End If
        If GlobalTaxAddtoTotal = True Then
            details += PrintLeftRigthText("SVC " & GlobalServiceChargeRate & "%", FormatNumber(svc, 2)) & Environment.NewLine
        End If

        details += Environment.NewLine
        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine
        com.CommandText = "select * from tblsalesbatch where batchcode='" & batchcode & "'" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftRigthText("DEPOSIT", FormatNumber(rst("advancepayment"), 2)) & Environment.NewLine
            details += PrintLeftRigthText("BALANCE", FormatNumber(totalAmount - Val(rst("advancepayment")), 2)) & Environment.NewLine
        End While
        rst.Close()

        details += Environment.NewLine & Environment.NewLine
        For Each word In GlobalPosReceiptType.Split(New Char() {vbCrLf})
            Dim str As String = RTrim(LTrim(Trim(word)))
            details += PrintCenterText(str.Replace(vbLf, "")) & Environment.NewLine
        Next

        details += Environment.NewLine & PrintCenterText("THIS SERVE AS YOUR ORDER SLIP") & Environment.NewLine
        details += LastPagepaper()
        POSPrint(details, batchcode, "ORDER SLIP")
    End Sub

    Public Sub PrintPOSChargeInvoiceReceipt(ByVal title As String, ByVal batchcode As String, ByVal acctName As String, ByVal totalAmount As Double, ByVal remarks As String, ByVal gridview As DataGridView, ByVal PrintMerchantCopy As Boolean)
        Dim details As String = "" : Dim BalanceSheet As String = "" : Dim printBatchcode As String = ""

        If PrintMerchantCopy = True Then
            printBatchcode = batchcode & "-M"
        Else
            printBatchcode = batchcode & "-C"
        End If
        details = PageHeader()
        details += PrintCenterText(title) & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("Office: " & compOfficename) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN: " & batchcode) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        For i = 0 To gridview.RowCount - 1
            If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            Else
                details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
                details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            End If
        Next
        details += Environment.NewLine
        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine

        If remarks <> "" Then
            details += PrintCenterText(remarks) & Environment.NewLine
        End If

        details += Environment.NewLine & Environment.NewLine
        If PrintMerchantCopy = True Then
            details += PrintCenterText("MERCHANT COPY") & Environment.NewLine
        Else
            details += PrintCenterText("CUSTOMER COPY") & Environment.NewLine
        End If
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(acctName) & Environment.NewLine & PrintCenterText("Customer Signature")
        details += LastPagepaper()

        com.CommandText = "update tblsalesbatch set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        POSPrint(details, printBatchcode, "INVOICE")
    End Sub

    Public Sub PrintPOSChargeToRoomReceipt(ByVal title As String, ByVal roomno As String, ByVal batchcode As String, ByVal acctName As String, ByVal totalAmount As Double, ByVal remarks As String, ByVal gridview As DataGridView, ByVal PrintMerchantCopy As Boolean)
        Dim details As String = "" : Dim printBatchcode As String = ""

        If PrintMerchantCopy = True Then
            printBatchcode = batchcode & "-M"
        Else
            printBatchcode = batchcode & "-C"
        End If
        details = PageHeader()
        details += PrintCenterText(title) & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Room No.: " & roomno) & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("Office: " & compOfficename) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN: " & batchcode) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        For i = 0 To gridview.RowCount - 1
            If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            Else
                details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
                details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            End If
        Next
        details += Environment.NewLine
        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine

        If remarks <> "" Then
            details += PrintCenterText(remarks) & Environment.NewLine
        End If

        details += Environment.NewLine & Environment.NewLine
        If PrintMerchantCopy = True Then
            details += PrintCenterText("MERCHANT COPY") & Environment.NewLine
        Else
            details += PrintCenterText("CUSTOMER COPY") & Environment.NewLine
        End If
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(acctName) & Environment.NewLine & PrintCenterText("Customer Signature")
        details += LastPagepaper()

        com.CommandText = "update tblsalesbatch set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        POSPrint(details, printBatchcode, "ROOM CHARGE")
    End Sub

    Public Sub PrintPOSDue(ByVal batchcode As String, ByVal ReportTitle As String, ByVal DueToOffice As String, ByVal totalAmount As Double, ByVal remarks As String, ByVal gridview As DataGridView, ByVal PrintMerchantCopy As Boolean)
        Dim details As String = "" : Dim BalanceSheet As String = "" : Dim printBatchcode As String = ""

        If PrintMerchantCopy = True Then
            printBatchcode = batchcode & "-M"
        Else
            printBatchcode = batchcode & "-C"
        End If

        details = PageHeader()
        details += PrintCenterText(ReportTitle) & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("TRN: " & batchcode) & Environment.NewLine
        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("Due From: " & compOfficename) & Environment.NewLine
        details += PrintLeftText("Due to: " & DueToOffice) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("Note: " & remarks) & Environment.NewLine

        details += PrintSpaceLine() & Environment.NewLine

        For i = 0 To gridview.RowCount - 1
            If Val(CC(gridview.Item("TOTAL", i).Value())) < 0 Then
                details += PrintLeftRigthText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            Else
                details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
                details += PrintLeftRigthText("  - " & Val(CC(gridview.Item("QTY", i).Value())) & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(Val(CC(gridview.Item("UNIT PRICE", i).Value())), 2), FormatNumber(Val(CC(gridview.Item("TOTAL", i).Value())), 2)) & Environment.NewLine
            End If
        Next
        details += Environment.NewLine
        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine


        details += Environment.NewLine & Environment.NewLine
        If PrintMerchantCopy = True Then
            details += PrintCenterText("MERCHANT COPY") & Environment.NewLine
        Else
            details += PrintCenterText("CUSTOMER COPY") & Environment.NewLine
        End If
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText("Customer Signature")
        details += LastPagepaper()

        com.CommandText = "update tblsalesbatch set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        POSPrint(details, printBatchcode, "ITER-OFFICE")
    End Sub

    Public Sub PrintPOSCouponVerified(ByVal batchcode As String, ByVal couponcode As String, ByVal totalAmount As Double, ByVal gridview As DataGridView)
        Dim details As String = "" : Dim BalanceSheet As String = ""

        details = PageHeader()
        details += PrintCenterText("ACKNOWLEDGEMENT") & Environment.NewLine & Environment.NewLine

        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine

        details += PrintSpaceLine() & Environment.NewLine

        For i = 0 To gridview.RowCount - 1
            details += PrintLeftText(StrConv(gridview.Item("PARTICULAR", i).Value(), vbProperCase)) & Environment.NewLine
            details += PrintLeftRigthText("  - " & gridview.Item("QTY", i).Value() & " " & gridview.Item("UNIT", i).Value() & " @" & FormatNumber(gridview.Item("UNIT PRICE", i).Value(), 2), FormatNumber(gridview.Item("TOTAL", i).Value(), 2)) & Environment.NewLine
        Next
        details += Environment.NewLine
        details += PrintLeftRigthText("TOTAL", FormatNumber(totalAmount, 2)) & Environment.NewLine
        details += PrintLeftRigthText("PAYMENT TYPE", "Coupon") & Environment.NewLine
        details += PrintLeftRigthText("COUPON CODE", couponcode) & Environment.NewLine
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        com.CommandText = "update tblsalesbatch set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        POSPrint(details, couponcode, "COUPON")
    End Sub


    Public Sub PrintPOSClientJournalReceipt(ByVal reference As String, ByVal acctName As String, ByVal particular As String, ByVal remarks As String, ByVal totalAmount As Double, ByVal PrintMerchantCopy As Boolean)
        Dim details As String = "" : Dim filename As String = ""

        If PrintMerchantCopy = True Then
            filename = reference & "-M"
        Else
            filename = reference & "-C"
        End If

        details = PageHeader()

        details += Environment.NewLine & PrintCenterText(Globalclientjournaltitle) & Environment.NewLine

        details += PrintLeftText("Cashier: " & globalfullname) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN: " & reference) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintLeftText(StrConv(particular, vbProperCase)) & Environment.NewLine
        details += PrintLeftRigthText(remarks, FormatNumber(totalAmount)) & Environment.NewLine & Environment.NewLine

        If PrintMerchantCopy = True Then
            details += PrintCenterText("MERCHANT COPY") & Environment.NewLine
        Else
            details += PrintCenterText("CUSTOMER COPY") & Environment.NewLine
        End If
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(acctName) & Environment.NewLine & PrintCenterText("Customer Signature")
        details += LastPagepaper()

        POSPrint(details, reference, "JOURNAL")
    End Sub

    Public Sub PrintPOSDeliverySlip(ByVal trnrefno As String, ByVal acctName As String, ByVal location As String, ByVal ls As ListView, ByVal PrintMerchantCopy As Boolean)
        Dim details As String = "" : Dim printrefno As String

        If PrintMerchantCopy = True Then
            printrefno = trnrefno & "-M"
        Else
            printrefno = trnrefno & "-C"
        End If
        details = PageHeader()

        details += Environment.NewLine & PrintCenterText(Globalsalesdeliverytitle) & Environment.NewLine & Environment.NewLine
        details += PrintLeftText("Branch: " & location) & Environment.NewLine
        details += PrintLeftText("Date: " & Format(Now)) & Environment.NewLine
        details += PrintLeftText("TRN: " & trnrefno) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        For Each itm As ListViewItem In ls.CheckedItems
            details += PrintLeftRigthText(StrConv(itm.SubItems(0).Text, vbProperCase), itm.SubItems(2).Text & " " & UCase(itm.SubItems(3).Text)) & Environment.NewLine
        Next

        details += Environment.NewLine & Environment.NewLine
        If PrintMerchantCopy = True Then
            details += PrintCenterText("MERCHANT COPY") & Environment.NewLine
        Else
            details += PrintCenterText("CUSTOMER COPY") & Environment.NewLine
        End If
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText(UCase(acctName)) & Environment.NewLine & PrintCenterText("Customer Signature") & Environment.NewLine

        details += Environment.NewLine & PrintCenterText("RELEASED BY") & Environment.NewLine
        details += Environment.NewLine & Environment.NewLine & Environment.NewLine & PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()
        com.CommandText = "update tblsalesdeliveryslip set receipt='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where refcode='" & trnrefno & "'" : com.ExecuteNonQuery()
        POSPrint(details, printrefno, "DELIVERY")
    End Sub

    Public Sub PrintCheckoutSlip(ByVal folioid As String)
        Dim details As String = ""
        com.CommandText = "select *,(select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as guest from tblhotelfolioroom where folioid='" & folioid & "'" : rst = com.ExecuteReader
        While rst.Read
            details = PrintCenterText(GlobalOrganizationName) & Environment.NewLine & Environment.NewLine
            details += PrintCenterText("CHECK-OUT SLIP") & Environment.NewLine & Environment.NewLine

            details += PrintLeftText("Guest Name: " & rst("guest").ToString) & Environment.NewLine
            details += PrintLeftText("Folio No: " & rst("foliono").ToString) & Environment.NewLine
            details += PrintLeftText("Room No: " & rst("roomno").ToString) & Environment.NewLine
            details += PrintLeftText("Checkout: " & Now.ToString) & Environment.NewLine
            details += PrintLeftText("Status: CLEARED") & Environment.NewLine & Environment.NewLine
            details += PrintLeftText("Front Desk Officer On-duty: ") & Environment.NewLine & Environment.NewLine

            details += PrintSpaceLine() & Environment.NewLine & Environment.NewLine

            details += PrintCenterText("Thank you for staying with us!") & Environment.NewLine & Environment.NewLine
            details += PrintCenterText("PLEASE GIVE THE SLIP TO THE GUARD")
        End While
        rst.Close()
        POSPrint(details, folioid, "FOLIO")
    End Sub

    Public Sub PrintProduct()
        Dim details As String = ""
        details += PrintCenterText("PRODUCT LIST") & Environment.NewLine & Environment.NewLine
        com.CommandText = "select * from tblglobalproducts where enablesell=1 and deleted=0 order by itemname asc" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftRigthText(rst("itemname").ToString & " " & rst("unit").ToString & " @" & FormatNumber(rst("sellingprice").ToString, 2), "_______") & Environment.NewLine
        End While
        details += PrintCenterText("END OF PRODUCT LIST")
        POSPrint(details, getGlobalTrnid("p", "d"), "Product")
    End Sub
#End Region

#Region "LX PRINT"
    Public Sub GenerateLXChargeInvoice(ByVal batchcode As String, ByVal clienname As String, ByVal clientaddress As String, ByVal invoicenumber As String, ByVal partialPayment As Double, ByVal remarks As String, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        'CreateHTMLReportTemplate("ReceiptTemplate.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\ReceiptTemplate.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVOICE\" & invoicenumber & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        TableHead = "<table border='1'> " _
                            + " <tr> " _
                                + " <th>Quantity</th> " _
                                + " <th>Unit</th> " _
                                + " <th>Particular</th> " _
                                + " <th>Unit Cost</th> " _
                                + " <th>Total</th> " _
                            + " </tr> " & Chr(13)

        com.CommandText = "select *,sum(quantity) as totalquantity,sum(total) as totaltrn from tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0 and void=0 group by productid order by datetrn asc " : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("totalquantity").ToString & "</td> " _
                           + " <td align='center'>" & rst("unit").ToString & "</td> " _
                           + " <td width='400'>" & rst("productname").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("sellprice").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("totaltrn").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Total = Total + rst("totaltrn")
        End While
        rst.Close()

        TableRow += "<tr><td align='right' colspan='4'>Total</td><td align='right'><strong>" & FormatNumber(Total, 2) & "</strong></td></tr> " & Chr(13)
        If partialPayment > 0 Then
            TableRow += "<tr><td align='right' colspan='4'>" & If((Total - partialPayment) = 0, "PAID", "Less Partial Payment") & "</td><td align='right'>" & FormatNumber(partialPayment, 2) & "</td></tr> " & Chr(13)
            TableRow += "<tr><td align='right' colspan='4'>Balance</td><td align='right'>" & FormatNumber(Total - partialPayment, 2) & "</td></tr> " & Chr(13)
        End If

        TableFooter = "</table>"

        TableTransaction = TableHead + TableRow + TableFooter
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company name]", UCase(GlobalOrganizationName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company address]", GlobalOrganizationAddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company number]", GlobalOrganizationContactNumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", Globalchargeinvoicettitle), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", clienname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", clientaddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", remarks), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[invoice]", invoicenumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", If(globalBackDateTransaction = True, globalBackDate.ToShortDateString, Now.ToShortDateString)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        com.CommandText = "select *, ifnull((select fullname from tblaccounts where accountid=tblsalesbatch.trnby),' ') as 'trnfullname',ifnull((select designation from tblaccounts where accountid=tblsalesbatch.trnby),' ')  as 'trnposition' from tblsalesbatch where batchcode='" & batchcode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared name]", UCase(rst("trnfullname"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(rst("trnposition"))), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXClientJournal(ByVal clienname As String, ByVal clientaddress As String, ByVal particular As String, ByVal remarks As String, ByVal amount As Double, ByVal refnumber As String, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        'CreateHTMLReportTemplate("ClientJournal.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\ClientJournal.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\JOURNAL\" & refnumber & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        TableTransaction = TableHead + TableRow + TableFooter

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", Globalclientjournaltitle), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company name]", UCase(GlobalOrganizationName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company address]", GlobalOrganizationAddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company number]", GlobalOrganizationContactNumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", clienname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", clientaddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reference]", refnumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[particular]", remarks), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[details]", NumToWords(amount)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount]", FormatNumber(amount, 2)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared name]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated by]", UCase(GlobalApproverName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated position]", UCase(GlobalApproverPosition)), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXSalesDelivery(ByVal trntype As Integer, ByVal refcode As String, ByVal clienname As String, ByVal address As String, ByVal Refnumber As String, ByVal branch As String, ByVal remarks As String, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = ""
        Dim Template As String = ""
        If trntype = 0 Then
            CreateHTMLReportTemplate("SalesDelivery1.html")
            Template = Application.StartupPath.ToString & "\Templates\SalesDelivery1.html"
        Else
            CreateHTMLReportTemplate("SalesDelivery2.html")
            Template = Application.StartupPath.ToString & "\Templates\SalesDelivery2.html"
        End If
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\DELIVERY\" & Refnumber & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        TableHead = "<table border='1'> " _
                            + " <tr> " _
                                + " <th>Quantity</th> " _
                                + " <th>Quantity In-Words</th> " _
                                + " <th>Unit</th> " _
                                + " <th>Particular</th> " _
                            + " </tr> " & Chr(13)

        com.CommandText = "select * from tblsalestransaction inner join tblsalesdeliveryitem on tblsalestransaction.id = tblsalesdeliveryitem.refitem where refcode='" & refcode & "'" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'>" & NumToWords(Val(rst("quantity").ToString)) & "</td> " _
                           + " <td align='center'>" & rst("unit").ToString & "</td> " _
                           + " <td width='400'>" & rst("productname").ToString & "</td> " _
                     + " </tr> " & Chr(13)

        End While
        rst.Close()

        TableFooter = "</table>"

        TableTransaction = TableHead + TableRow + TableFooter
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company name]", UCase(GlobalOrganizationName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company address]", GlobalOrganizationAddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company number]", GlobalOrganizationContactNumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(remarks)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[branch]", UCase(branch)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", clienname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", address), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reference]", Refnumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        com.CommandText = "select *, (select fullname from tblaccounts where accountid=tblsalesdeliveryslip.createdby) as 'trnfullname', " _
                                + " (select designation from tblaccounts where accountid=tblsalesdeliveryslip.createdby) as 'trnposition' from tblsalesdeliveryslip where refcode='" & refcode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared name]", UCase(rst("trnfullname"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(rst("trnposition"))), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated position]", UCase(globalposition)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated position]", UCase(globalposition)), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXChargeHotel(ByVal batchcode As String, ByVal clienname As String, ByVal clientaddress As String, ByVal invoicenumber As String, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        CreateHTMLReportTemplate("HotelCharges.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelCharges.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\INVOICE\" & invoicenumber & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        TableHead = "<table border='1'> " _
                            + " <tr> " _
                                + " <th>Quantity</th> " _
                                + " <th>Unit</th> " _
                                + " <th>Particular</th> " _
                                + " <th>Unit Cost</th> " _
                                + " <th>Total</th> " _
                            + " </tr> " & Chr(13)

        com.CommandText = "select * from tblsalestransaction where batchcode='" & batchcode & "' and cancelled=0 and void=0 order by datetrn asc " : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                           + " <td align='center'>" & rst("unit").ToString & "</td> " _
                           + " <td width='400'>" & rst("productname").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("sellprice").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Total = Total + rst("total")
        End While
        rst.Close()

        TableRow += "<tr> " _
                        + " <td align='right' colspan='4'>Total</td> " _
                        + " <td align='right'>" & FormatNumber(Total, 2) & "</td> " _
                 + " </tr> " & Chr(13)
        TableFooter = "</table>"

        TableTransaction = TableHead + TableRow + TableFooter
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company name]", UCase(GlobalOrganizationName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company address]", GlobalOrganizationAddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company number]", GlobalOrganizationContactNumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", Globalchargeinvoicettitle), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", clienname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", clientaddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[invoice]", invoicenumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXRoomStatement(ByVal folioid As String, ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        'CreateHTMLReportTemplate("HotelStatementOfAccount.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelStatementOfAccount.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\FOLIO\" & folioid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)


        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", "STATEMENT OF ACCOUNT"), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", DXSetupTheGridviewPrinter(TableTitle, gv)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        Dim foliono As String = ""
        com.CommandText = "SELECT *,date_format(current_timestamp, '%M %d, %Y %r') as 'dateledger',date_format(arival, '%M %d, %Y') as 'checkindate',date_format(departure, '%M %d, %Y') as 'datecheckout', date_format(timecheckin, '%r') as 'checkintime' FROM tblhotelfolioroom where folioid='" & folioid & "'" : rst = com.ExecuteReader
        While rst.Read
            foliono = rst("foliono").ToString
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room no]", rst("roomno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room type]", UCase(rst("description").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[details]", "Adult " & rst("pax").ToString & " Child " & rst("child").ToString & " Extra Person " & rst("extra").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date checkin]", rst("checkindate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date checkout]", rst("datecheckout").ToString), False)
        End While
        rst.Close()

        com.CommandText = "SELECT *,(select fullname from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'guest', (select address from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'guestaddress' FROM tblhotelfolioguest where foliono='" & foliono & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", UCase(rst("guest").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", StrConv(rst("guestaddress").ToString, VbStrConv.ProperCase)), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateMasterFolio(ByVal consolidate As Boolean, ByVal referenceno As String, ByVal viewall As Boolean, ByVal trndate As String, ByVal form As Form)
        CreateHTMLReportTemplate("HotelMasterFolio.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelMasterFolio.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\MASTER\info-" & referenceno & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        If consolidate = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report_title]", "MASTER FOLIO SUMMARY"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report_title]", "ROOM FOLIO SUMMARY"), False)
        End If
        Dim foliono As String = "" : Dim folioid As String = "" : Dim cntCompanion As Integer = 0
        If consolidate = False Then
            com.CommandText = "select *, " _
                              + " (select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=tblhotelfolioroom.foliono) as agent, " _
                              + " (select (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) from tblhotelfolioguest where foliono=tblhotelfolioroom.foliono) as guest_type, " _
                              + " (select flight from tblhotelfolioguest where foliono=tblhotelfolioroom.foliono) as flight, " _
                              + " (select remarks from tblhotelfolioguest where foliono=tblhotelfolioroom.foliono) as remarks, " _
                              + " (select count(*) from tblhotelguestcompanion where folioid=tblhotelfolioroom.folioid) as companion, date_format(arival, '%M %d, %Y') as checkin, date_format(departure, '%M %d, %Y') as check_out, (select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as 'Guest', " _
                              + " (select address from tblhotelguest where guestid=tblhotelfolioroom.guestid) as 'address' , " _
                              + " (select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid) as 'Package' from tblhotelfolioroom where folioid='" & referenceno & "'" : rst = com.ExecuteReader
            While rst.Read
                foliono = rst("foliono").ToString : folioid = rst("folioid").ToString : cntCompanion = Val(rst("companion").ToString)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[foliono]", rst("foliono").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guesttype]", rst("guest_type").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guest]", rst("Guest").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("address").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkin]", UCase(rst("checkin").ToString)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomtype]", rst("description").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[package]", rst("Package").ToString), False)

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[flight]", rst("flight").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[agent]", rst("agent").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("remarks").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomno]", rst("roomno").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[package]", rst("Package").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", UCase(rst("check_out").ToString)), False)
            End While
            rst.Close()
        Else
            com.CommandText = "select *, " _
                              + " (select agentname from tblhotelagent where code=a.agentcode) as agent, " _
                              + " (select description from tblhotelguesttype where code=a.guesttype) as guest_type, " _
                              + " flight, " _
                              + " Remarks, " _
                              + " (select count(*) from tblhotelguestcompanion where bookno=a.foliono) as companion, date_format(arival, '%M %d, %Y') as checkin, " _
                              + " date_format(departure, '%M %d, %Y') as check_out, (select fullname from tblhotelguest where guestid=a.guestid) as 'Guest', " _
                              + " (select address from tblhotelguest where guestid=a.guestid) as 'address' , " _
                              + " 'CONSOLIDATED FOLIO' as 'Package' from tblhotelfolioguest as a where foliono='" & referenceno & "'" : rst = com.ExecuteReader
            While rst.Read
                foliono = rst("foliono").ToString : folioid = rst("folioid").ToString : cntCompanion = Val(rst("companion").ToString)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[foliono]", rst("foliono").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guesttype]", rst("guest_type").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guest]", rst("Guest").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("address").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkin]", UCase(rst("checkin").ToString)), False)

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[package]", rst("Package").ToString), False)

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[flight]", rst("flight").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[agent]", rst("agent").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("remarks").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[package]", rst("Package").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", UCase(rst("check_out").ToString)), False)
            End While
            rst.Close()

            Dim RoomType As String = ""
            com.CommandText = "SELECT concat(count(*),' - ',description) as room_type FROM `tblhotelfolioroom` where foliono='" & referenceno & "' group by roomtype;" : rst = com.ExecuteReader()
            While rst.Read
                If rst("room_type").ToString <> "" Then
                    RoomType += rst("room_type").ToString & "</br>"
                End If

            End While
            rst.Close()

            Dim roomno As String = ""
            com.CommandText = "SELECT group_concat(roomno separator ', ') as room FROM `tblhotelfolioroom` where foliono='" & referenceno & "' and roomno<>'' group by roomtype;" : rst = com.ExecuteReader()
            While rst.Read
                If rst("room").ToString <> "" Then
                    roomno += rst("room").ToString & "</br>"
                End If
            End While
            rst.Close()

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomtype]", RoomType), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomno]", roomno), False)
        End If


        Dim DailyTransaction As String = ""
        If consolidate = False Then
            Dim Companion As String = ""
            com.CommandText = "select * from tblhotelguestcompanion where folioid='" & referenceno & "'" : rst = com.ExecuteReader
            While rst.Read
                Companion += " - " & rst("fullname").ToString & "</br>"
            End While
            rst.Close()

            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("SELECT *, RateID, date_format(datetrn,'%M %d, %Y') as trndate,(select description from tblhotelroomrates where ratecode=tblhotelfolioroomsummary.rateid) as package FROM `tblhotelfolioroomsummary` where foliono='" & foliono & "' and folioid='" & folioid & "' " & If(viewall = True, "", " and datetrn='" & trndate & "'"), conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    Dim RoomDetails As String = ""
                    Dim RoomRateTitle As String = "" : Dim RoomRateContent As String = "" : Dim RoomRateTable As String = "" : Dim TotalTransaction As Double = 0
                    Dim RateTitle As String = ""
                    If CBool(.Rows(cnt)("nightcharge").ToString()) = True Then
                        RateTitle = "Night"
                    Else
                        RateTitle = "Pax"
                    End If
                    RoomDetails = "<table border='1' id='tabl'><tr style=' border-bottom: 1px solid #d1d1d1;'><td colspan='2' align='left' class='info' style='padding-top:10px;'><b>DAY " & (Val(.Rows(cnt)("dayno").ToString()) + 1) & " - " & UCase(.Rows(cnt)("trndate").ToString()) & "</b></td></tr>" _
                                          + "<tr style='border-bottom: 1px solid #d1d1d1; margin: 1px'>" _
                                               + "<td style='margin:0; padding: 10px;vertical-align:top;' width='45%'>" _
                                                   + "<table border='0' id='tabl_sub' width='100%' cellspacing='0' cellpadding='0'> " _
                                                           + "<tr><td>Transaction Code: " & .Rows(cnt)("roomtrncode").ToString() & "</td></td></tr> " _
                                                           + "<tr><td>Package: " & .Rows(cnt)("package").ToString() & "</td></td></tr> " _
                                                           + "<tr><td>Room Rate: " & FormatNumber(.Rows(cnt)("adultrate").ToString(), 2) & " / " & RateTitle & "</td></td></tr> " _
                                                           + If(Val(.Rows(cnt)("extra").ToString()) > 0, "<tr><td>Extra Person Rate: " & FormatNumber(Val(.Rows(cnt)("extrarate").ToString()), 2) & " / Pax</td></td></tr> ", "") _
                                                           + If(Val(.Rows(cnt)("child").ToString()) > 0, "<tr><td>Child Rate: " & FormatNumber(Val(.Rows(cnt)("childrate").ToString()), 2) & " / Child</td></td></tr> ", "") _
                                                           + If(Val(.Rows(cnt)("child").ToString()) > 0 Or Val(.Rows(cnt)("extra").ToString()) > 0, "<tr><td>&nbsp;</td></td></tr> ", "") _
                                                           + If(Val(.Rows(cnt)("adult").ToString()) > 0, "<tr><td>Adult: " & .Rows(cnt)("adult").ToString() & "</td></td></tr> ", "") _
                                                           + If(Val(.Rows(cnt)("child").ToString()) > 0, "<tr><td>Child: " & .Rows(cnt)("child").ToString() & "</td></td></tr> ", "") _
                                                           + If(Val(.Rows(cnt)("extra").ToString()) > 0, "<tr><td>Extra Person: " & .Rows(cnt)("extra").ToString() & "</td></td></tr> ", "") _
                                                           + If(cntCompanion > 0, "<tr><td>&nbsp;</td></td></tr><tr><td>Guest Companion:</td></td></tr> ", "") _
                                                           + If(cntCompanion > 0, "<tr><td>" & Companion.Remove(Companion.Length - 5, 5) & "</td></td></tr> ", "") _
                                                   + "</table>" _
                                               + "</td>"


                    'ROOM RATE
                    RoomRateTitle = " <td style='margin:0; padding: 10px;vertical-align:top;'> " _
                                            + "<table  border='0' id='tabl_sub_border' width='100%'  cellspacing='0' cellpadding='0'> " _
                                                + "<tr align='center' style='font-weight: bold;text-decoration: underline;'><td align='center' >QTY</td><td>Breakdown</td><td>Amount</td><td>Total</td></tr>" _
                                                + "<tr><td colspan='4' style='font-weight: bold;'>" & If(CBool(.Rows(cnt)("nightcharge").ToString()) = True, "ROOM", "PER PAX") & " RATE</td></tr>"
                    RoomRateContent = ""
                    com.CommandText = "select itemname , Amount from tblhotelfolioroombreakdown where roomtrncode='" & .Rows(cnt)("roomtrncode").ToString() & "' and breakdowntype='roomrate'" : rst = com.ExecuteReader
                    While rst.Read
                        RoomRateContent += "<tr><td align='center'>" & If(CBool(.Rows(cnt)("nightcharge").ToString()) = True, "", .Rows(cnt)("adult").ToString()) & "</td><td>" & rst("itemname").ToString & "</td><td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td><td align='right'>" & If(CBool(.Rows(cnt)("nightcharge").ToString()) = True, FormatNumber(rst("amount").ToString, 2), FormatNumber(Val(rst("amount").ToString) * Val(.Rows(cnt)("adult").ToString()), 2)) & "</td></tr>"
                        If CBool(.Rows(cnt)("nightcharge").ToString()) = True Then
                            TotalTransaction = TotalTransaction + Val(rst("amount").ToString)
                        Else
                            TotalTransaction = TotalTransaction + (Val(rst("amount").ToString) * Val(.Rows(cnt)("adult").ToString()))
                        End If

                    End While
                    rst.Close()
                    RoomRateTable += RoomRateTitle + RoomRateContent


                    'CHILD
                    RoomRateTitle = "<tr><td colspan='4' style='font-weight: bold;'>CHILD RATE</td></tr>"
                    RoomRateContent = ""
                    com.CommandText = "select itemname , Amount from tblhotelfolioroombreakdown where roomtrncode='" & .Rows(cnt)("roomtrncode").ToString() & "' and breakdowntype='child'" : rst = com.ExecuteReader
                    While rst.Read
                        RoomRateContent += "<tr><td align='center'>" & .Rows(cnt)("child").ToString() & "</td><td>" & rst("itemname").ToString & "</td><td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td><td align='right'>" & FormatNumber(Val(rst("amount").ToString) * Val(.Rows(cnt)("child").ToString()), 2) & "</td></tr>"
                        TotalTransaction = TotalTransaction + (Val(rst("amount").ToString) * Val(.Rows(cnt)("child").ToString()))
                    End While
                    rst.Close()
                    If RoomRateContent.Length > 0 Then
                        RoomRateTable += RoomRateTitle + RoomRateContent
                    End If



                    'EXTRA PERSON
                    RoomRateTitle = "<td colspan='4' style='font-weight: bold;'>EXTRA PERSON RATE</td></tr>"
                    RoomRateContent = ""
                    com.CommandText = "select itemname , Amount from tblhotelfolioroombreakdown where roomtrncode='" & .Rows(cnt)("roomtrncode").ToString() & "' and breakdowntype='extra'" : rst = com.ExecuteReader
                    While rst.Read
                        RoomRateContent += "<tr><td align='center'>" & .Rows(cnt)("extra").ToString() & "</td><td>" & rst("itemname").ToString & "</td><td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td><td align='right'>" & FormatNumber(Val(rst("amount").ToString) * Val(.Rows(cnt)("extra").ToString()), 2) & "</td></tr>"
                        TotalTransaction = TotalTransaction + (Val(rst("amount").ToString) * Val(.Rows(cnt)("extra").ToString()))
                    End While
                    rst.Close()
                    If RoomRateContent.Length > 0 Then
                        RoomRateTable += RoomRateTitle + RoomRateContent
                    End If

                    RoomRateTable += "<tr style='font-weight:bold' align='right'><td colspan='3'>TOTAL</td><td>" & FormatNumber(TotalTransaction, 2) & "</td></tr>"

                    DailyTransaction += RoomDetails + RoomRateTable + "</table></td></tr></table>"
                End With
            Next
        End If

        Dim SummaryRow As String = "" : Dim totalSummary As Double = 0
        If consolidate = True Then
            com.CommandText = "SELECT a.itemname,sum(case when a.breakdowntype='roomrate' then if(b.nightcharge=1, a.amount,(b.adult*a.amount)) when a.breakdowntype='child' then (b.child*a.amount) when a.breakdowntype='extra' then (b.extra * a.amount) end)  as total FROM `tblhotelfolioroombreakdown` as a inner join tblhotelfolioroomsummary as b on a.roomtrncode=b.roomtrncode where b.foliono='" & foliono & "' group by a.itemcode;" : rst = com.ExecuteReader
        Else
            com.CommandText = "SELECT a.itemname,sum(case when a.breakdowntype='roomrate' then if(b.nightcharge=1, a.amount,(b.adult*a.amount)) when a.breakdowntype='child' then (b.child*a.amount) when a.breakdowntype='extra' then (b.extra * a.amount) end)  as total FROM `tblhotelfolioroombreakdown` as a inner join tblhotelfolioroomsummary as b on a.roomtrncode=b.roomtrncode where b.foliono='" & foliono & "' and b.folioid='" & folioid & "' group by a.itemcode;" : rst = com.ExecuteReader
        End If

        While rst.Read
            SummaryRow += "<tr><td>" & rst("itemname").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("total").ToString), 2) & "</td></tr>"
            totalSummary = totalSummary + Val(rst("total").ToString)
        End While
        rst.Close()

        SummaryRow += "<tr style='font-weight:bold;font-size:15px' align='right'><td>TOTAL</td><td style='background-color:yellow;'>" & FormatNumber(totalSummary, 2) & "</td></tr>"

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[summary]", SummaryRow), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[table]", DailyTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function GenerateGuestEmailNotification(ByVal bookno As String, ByVal preview As Boolean) As String
        Dim FileDetails As String = ""
        FileDetails = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Templates\Email\HotelFolioGuestNitification.html")

        FileDetails = FileDetails.Replace("{companyname}", UCase(GlobalOrganizationName))
        FileDetails = FileDetails.Replace("{companyaddress}", GlobalOrganizationAddress)
        FileDetails = FileDetails.Replace("{hotelurl}", GlobalOrganizationWebsite)
        FileDetails = FileDetails.Replace("{hotelemail}", GlobalOrganizationEmail)
        FileDetails = FileDetails.Replace("{hotelphone}", GlobalOrganizationContactNumber)

        If preview = True Then
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                FileDetails = FileDetails.Replace("{logo}", "<div align='center'><img src='" & Application.StartupPath.ToString & "\Logo\logo.png" & "'></div><br/>")
            Else
                FileDetails = FileDetails.Replace("{logo}", "")
            End If
        Else
            If GlobalOrganizationLogoURL.Length > 5 Then
                FileDetails = FileDetails.Replace("{logo}", "<div align='center'><img src='" & GlobalOrganizationLogoURL & "'></div><br/>")
            Else
                FileDetails = FileDetails.Replace("{logo}", "")
            End If
        End If
      
        com.CommandText = " select *,date_format(arival, '%M %d, %Y') as arivals, date_format(departure, '%M %d, %Y') as checkout,datediff(departure,arival) as nodays, " _
                        + " (select countryname from tblcountries where countrycode = tblhotelguest.countrycode) as 'country', " _
                        + " (select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, " _
                        + " (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as agent, " _
                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0) as deposit, " _
                        + " (select group_concat(remarks) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as paymenttype, " _
                        + " (select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono) as TotalRoom, " _
                        + " flight, Remarks " _
                        + " from tblhotelfolioguest inner join tblhotelguest on tblhotelfolioguest.guestid = tblhotelguest.guestid where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read

            FileDetails = FileDetails.Replace("{name}", rst("fullname").ToString)

            FileDetails = FileDetails.Replace("{reservationno}", rst("foliono").ToString)
            FileDetails = FileDetails.Replace("{checkindate}", rst("arivals").ToString)
            FileDetails = FileDetails.Replace("{checkoutdate}", rst("checkout").ToString)
            FileDetails = FileDetails.Replace("[nodays]", rst("nodays").ToString)

            FileDetails = FileDetails.Replace("{bookingamount}", FormatNumber(rst("TotalRoom").ToString, 2))
            FileDetails = FileDetails.Replace("{totalpaid}", FormatNumber(rst("deposit").ToString, 2))
            FileDetails = FileDetails.Replace("{paymenttype}", rst("paymenttype").ToString)
        End While
        rst.Close()

        Dim RoomType As String = ""
        com.CommandText = "SELECT concat(count(*),' - ',description) as room_type FROM `tblhotelfolioroom` where foliono='" & bookno & "' group by roomtype;" : rst = com.ExecuteReader()
        While rst.Read
            If rst("room_type").ToString <> "" Then
                RoomType += rst("room_type").ToString & "</br>"
            End If

        End While
        rst.Close()

        Dim roomno As String = ""
        com.CommandText = "SELECT group_concat(roomno separator ', ') as room FROM `tblhotelfolioroom` where foliono='" & bookno & "' and roomno<>'' group by roomtype;" : rst = com.ExecuteReader()
        While rst.Read
            If rst("room").ToString <> "" Then
                roomno += rst("room").ToString & "</br>"
            End If
        End While
        rst.Close()

        FileDetails = FileDetails.Replace("{roomtype}", RoomType)
        FileDetails = FileDetails.Replace("{roomno}", roomno)

        com.CommandText = "select sum(pax) as ttlpax,sum(child) as ttlchild, sum(extra) as ttlextra from tblhotelfolioroom where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            FileDetails = FileDetails.Replace("{adult}", rst("ttlpax").ToString)
            FileDetails = FileDetails.Replace("{child}", rst("ttlchild").ToString)
            FileDetails = FileDetails.Replace("{extra}", rst("ttlextra").ToString)
        End While
        rst.Close()

        FileDetails = FileDetails.Replace("{preparedby}", UCase(globalfullname))
        FileDetails = FileDetails.Replace("{preparedposition}", UCase(globalposition))


        'If System.IO.File.Exists(Application.StartupPath & "\FileDetails.html") = True Then
        '    System.IO.File.Delete(Application.StartupPath & "\FileDetails.html")
        'End If

        'Dim detailsFile As StreamWriter = Nothing
        'detailsFile = New StreamWriter(Application.StartupPath.ToString & "\FileDetails.html", True)
        'detailsFile.WriteLine(FileDetails)
        'detailsFile.Close()

        'Process.Start(Application.StartupPath & "\FileDetails.html")

        'PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
        Return FileDetails
    End Function

    Public Sub GenerateGuestFolio(ByVal bookno As String, ByVal form As Form)
        'CreateHTMLReportTemplate("HotelGuestFolio.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelGuestFolio.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\FOLIO\info-" & bookno & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        com.CommandText = " select *,date_format(arival, '%M %d, %Y') as arivals, date_format(departure, '%M %d, %Y') as checkout,datediff(departure,arival) as nodays, " _
                        + " (select countryname from tblcountries where countrycode = tblhotelguest.countrycode) as 'country', " _
                        + " (select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, " _
                        + " (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as agent, " _
                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0) as deposit, " _
                        + " (select group_concat(remarks) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as paymenttype, " _
                        + " (select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono) as TotalRoom, " _
                        + " (select sum(debit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0) as TotalPOS, " _
                        + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as TotalPaymentRoom, " _
                        + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as TotalPaymentFolio, " _
                        + " flight, Remarks " _
                        + " from tblhotelfolioguest inner join tblhotelguest on tblhotelfolioguest.guestid = tblhotelguest.guestid where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            End If
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToString("MMMM dd, yyyy")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guest]", rst("fullname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birth date]", rst("birthdate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[gender]", rst("gender").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[country]", rst("country").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nationality]", rst("nationality").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[contact]", rst("contactnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[email]", rst("emailadd").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[arival]", rst("arivals").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", rst("checkout").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nodays]", rst("nodays").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("EXTRA NIGHT RATE", ""), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment amount]", FormatNumber(rst("deposit").ToString, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment type]", rst("paymenttype").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[flight]", rst("flight").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("remarks").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[agent]", rst("agent").ToString), False)

        End While
        rst.Close()

        Dim RoomType As String = ""
        com.CommandText = "SELECT concat(count(*),' - ',description) as room_type FROM `tblhotelfolioroom` where foliono='" & bookno & "' group by roomtype;" : rst = com.ExecuteReader()
        While rst.Read
            If rst("room_type").ToString <> "" Then
                RoomType += rst("room_type").ToString & "</br>"
            End If

        End While
        rst.Close()

        Dim roomno As String = ""
        com.CommandText = "SELECT group_concat(roomno separator ', ') as room FROM `tblhotelfolioroom` where foliono='" & bookno & "' and roomno<>'' group by roomtype;" : rst = com.ExecuteReader()
        While rst.Read
            If rst("room").ToString <> "" Then
                roomno += rst("room").ToString & "</br>"
            End If
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomtype]", RoomType), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomnumber]", roomno), False)

        com.CommandText = "select sum(pax) as ttlpax,sum(child) as ttlchild, sum(extra) as ttlextra from tblhotelfolioroom where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[adult]", rst("ttlpax").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[child]", rst("ttlchild").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[extra]", rst("ttlextra").ToString), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateGuestFolioStatement(ByVal bookno As String, ByVal form As Form)
        'CreateHTMLReportTemplate("HotelGuestFolio.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelGuestFolioMainStatement.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\STATEMENT\info-" & bookno & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim totalPOS As Double = 0 : Dim totalPayment As Double = 0
        com.CommandText = " select *,date_format(arival, '%M %d, %Y') as arivals, date_format(departure, '%M %d, %Y') as checkout,datediff(departure,arival) as nodays, " _
                        + " (select countryname from tblcountries where countrycode = tblhotelguest.countrycode) as 'country', " _
                        + " (select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, " _
                        + " (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as agent, " _
                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0) as deposit, " _
                        + " (select group_concat(remarks) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as paymenttype, " _
                        + " (select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono) as TotalRoom, " _
                        + " (select sum(debit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0) as TotalPOS, " _
                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0) as 'Discount', " _
                        + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as TotalPaymentRoom, " _
                        + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as TotalPaymentFolio, " _
                        + " flight, Remarks " _
                        + " from tblhotelfolioguest inner join tblhotelguest on tblhotelfolioguest.guestid = tblhotelguest.guestid where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            End If
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToString("MMMM dd, yyyy")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guest]", rst("fullname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birth date]", rst("birthdate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[gender]", rst("gender").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[country]", rst("country").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nationality]", rst("nationality").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[contact]", rst("contactnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[email]", rst("emailadd").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[arival]", rst("arivals").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", rst("checkout").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nodays]", rst("nodays").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("EXTRA NIGHT RATE", ""), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[flight]", rst("flight").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("remarks").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[agent]", rst("agent").ToString), False)

            Dim totalCharges As Double = 0 : Dim Discount As Double = 0
            totalCharges = Val(rst("TotalRoom").ToString) + Val(rst("TotalPOS").ToString)
            Discount = Val(rst("Discount").ToString)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalrooms]", FormatNumber(Val(rst("TotalRoom").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalpos]", FormatNumber(Val(rst("TotalPOS").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalcharges]", FormatNumber(totalCharges, 2)), False)
            If Discount > 0 Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[discount]", "<tr><td >ROOM DISCOUNT</td><td class='info'>" & FormatNumber(Discount, 2) & "</td></tr>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[discount]", ""), False)
            End If
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment amount]", FormatNumber(rst("deposit").ToString, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment type]", rst("paymenttype").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[balancedue]", FormatNumber(totalCharges - (Val(rst("deposit").ToString) + Discount), 2)), False)
            totalPOS = Val(rst("TotalPOS").ToString)
            totalPayment = Val(rst("deposit").ToString)
        End While
        rst.Close()

        Dim RoomDetails As String = "" : Dim cnt As Integer = 0 : Dim totalAdult As Integer = 0 : Dim totalChild As Integer = 0 : Dim totalExtra As Integer = 0 : Dim total As Double = 0
        com.CommandText = "select *, roomno , description, ifnull((select adultrate from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid and dayno=0),0) as 'PackageRate', " _
                                        + " datediff(departure,arival) as 'NoDay', " _
                                        + " ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0) as 'RoomCharges' from tblhotelfolioroom where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            RoomDetails += "<tr><td align='center'>" & rst("roomno").ToString & "</td><td>" & rst("description").ToString & "</td><td align='center'>" & rst("NoDay").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("PackageRate").ToString), 2) & "</td><td align='center'>" & rst("Pax").ToString & "</td><td align='center'>" & rst("child").ToString & "</td><td align='center'>" & rst("extra").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("RoomCharges").ToString), 2) & "</td></tr>"
            total = total + Val(rst("RoomCharges").ToString)
            totalAdult = totalAdult + Val(rst("pax").ToString)
            totalChild = totalChild + Val(rst("child").ToString)
            totalExtra = totalExtra + Val(rst("extra").ToString)
            cnt = cnt + 1
        End While
        rst.Close()
        RoomDetails += "<tr style='font-weight:bold'> <td align='center'>" & cnt & " Room(s)</td><td></td><td align='center'></td><td align='right'></td><td align='center'>" & totalAdult.ToString & "</td><td align='center'>" & totalChild.ToString & "</td><td align='center'>" & totalExtra.ToString & "</td><td align='right'>" & FormatNumber(total, 2) & "</td></tr>"

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room]", RoomDetails), False)

        Dim POSTransaction As String = "" : Dim POSDetails As String = "" : Dim totalPOSTransaction As Double = 0
        If totalPOS > 0 Then
            POSTransaction = "<br/> " _
                  + " <table  border='0' id='tabl_sub_border' width='100%'  cellspacing='0' cellpadding='0'>" _
                     + " <tr style=' border-bottom: 1px solid #d1d1d1;'><td colspan='8' align='center' class='info' style='padding-top:10px;'><b>POS / OTHER CHARGES</b></td></tr>" _
                     + " <tr align='center' style='font-weight: bold;'><td>DATE POSTED</td><td>CHARGE FROM</td><td>CTR</td><td>REFERENCE</td><td>REMARKS</td><td>AMOUNT</td></tr>"

            com.CommandText = "select datetrn,(select officename from tblcompoffice where officeid=tblhotelfoliotransaction.officeid) as 'ChargeFrom', roomno,concat('#',referenceno) as 'Reference', Remarks, debit from tblhotelfoliotransaction where foliono='" & bookno & "' and chargefrompos=1 and cancelled=0 order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                POSDetails += "<tr><td align='center'>" & rst("datetrn").ToString & "</td><td>" & rst("ChargeFrom").ToString & "</td><td align='center'>" & rst("roomno").ToString & "</td><td align='center'>" & rst("Reference").ToString & "</td><td>" & rst("Remarks").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("debit").ToString), 2) & "</td></tr>"
                totalPOSTransaction = totalPOSTransaction + Val(rst("debit").ToString)
            End While
            rst.Close()
            POSDetails += "<tr style='font-weight:bold'><td></td><td></td><td></td><td></td><td></td><td align='right'>" & FormatNumber(totalPOSTransaction, 2) & "</td></tr>"
            POSTransaction += POSDetails & "</table>"
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pos]", POSTransaction), False)

        Dim PaymentTransaction As String = "" : Dim PaymentDetails As String = "" : Dim totalPaymentTransaction As Double = 0
        If totalPayment > 0 Then
            PaymentTransaction = "<br/> " _
                  + " <table  border='0' id='tabl_sub_border' width='100%'  cellspacing='0' cellpadding='0'>" _
                     + " <tr style=' border-bottom: 1px solid #d1d1d1;'><td colspan='8' align='center' class='info' style='padding-top:10px;'><b>PAYMENT TRANSACTION</b></td></tr>" _
                     + " <tr align='center' style='font-weight: bold;'><td>DATE POSTED</td><td>PAYMENT FOR ROOM</td><td>REFERENCE</td><td>REMARKS</td><td>AMOUNT</td></tr>"

            com.CommandText = "select trnid,referenceno, datetrn,if(roomno='','-',roomno) as 'PaymentForRoom', Remarks, credit,concat('#',referenceno) as 'Reference' from tblhotelfoliotransaction where foliono='" & bookno & "' and paymenttrn=1 and cancelled=0 order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                PaymentDetails += "<tr><td align='center'>" & rst("datetrn").ToString & "</td><td align='center'>" & rst("PaymentForRoom").ToString & "</td><td align='center'>" & rst("Reference").ToString & "</td><td>" & rst("Remarks").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("credit").ToString), 2) & "</td></tr>"
                totalPaymentTransaction = totalPaymentTransaction + Val(rst("credit").ToString)
            End While
            rst.Close()
            PaymentDetails += "<tr style='font-weight:bold'><td></td><td></td><td></td><td></td><td align='right'>" & FormatNumber(totalPaymentTransaction, 2) & "</td></tr>"
            PaymentTransaction += PaymentDetails & "</table>"
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pos]", POSTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment]", PaymentTransaction), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateGuestFolioStatementModified(ByVal bookno As String, ByVal roomcharges As Double, ByVal totalcharges As Double, ByVal poscharges As Double, ByVal payment As Double, ByVal balancedue As Double, ByVal form As Form)
        'CreateHTMLReportTemplate("HotelGuestFolio.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelGuestFolioMainStatement.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\STATEMENT\info-" & bookno & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim totalPOS As Double = 0 : Dim totalPayment As Double = 0 : Dim customPos As Boolean = False
        com.CommandText = " select *,date_format(arival, '%M %d, %Y') as arivals, date_format(departure, '%M %d, %Y') as checkout,datediff(departure,arival) as nodays, " _
                        + " (select countryname from tblcountries where countrycode = tblhotelguest.countrycode) as 'country', " _
                        + " (select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, " _
                        + " (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as agent, " _
                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0) as deposit, " _
                        + " (select group_concat(remarks) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as paymenttype, " _
                        + " (select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono) as TotalRoom, " _
                        + " (select sum(debit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0) as TotalPOS, " _
                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0) as 'Discount', " _
                        + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as TotalPaymentRoom, " _
                        + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0) as TotalPaymentFolio, " _
                        + " flight, Remarks " _
                        + " from tblhotelfolioguest inner join tblhotelguest on tblhotelfolioguest.guestid = tblhotelguest.guestid where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            End If
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToString("MMMM dd, yyyy")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guest]", rst("fullname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birth date]", rst("birthdate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[gender]", rst("gender").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[country]", rst("country").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nationality]", rst("nationality").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[contact]", rst("contactnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[email]", rst("emailadd").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[arival]", rst("arivals").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", rst("checkout").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nodays]", rst("nodays").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("EXTRA NIGHT RATE", ""), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[flight]", rst("flight").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("remarks").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[agent]", rst("agent").ToString), False)

            Dim Discount As Double = 0

            Discount = Val(rst("Discount").ToString)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalrooms]", FormatNumber(roomcharges, 2)), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalcharges]", FormatNumber(totalcharges, 2)), False)
            If Discount > 0 Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[discount]", "<tr><td >ROOM DISCOUNT</td><td class='info'>" & FormatNumber(Discount, 2) & "</td></tr>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[discount]", ""), False)
            End If
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment amount]", FormatNumber(payment, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment type]", rst("paymenttype").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[balancedue]", FormatNumber(totalcharges - (payment + Discount), 2)), False)
            If poscharges <> Val(rst("TotalPOS").ToString) Then
                totalPOS = poscharges
                customPos = True
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalpos]", FormatNumber(poscharges, 2)), False)
            Else
                totalPOS = Val(rst("TotalPOS").ToString)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalpos]", FormatNumber(Val(rst("TotalPOS").ToString), 2)), False)
            End If

            totalPayment = Val(rst("deposit").ToString)
        End While
        rst.Close()

        Dim RoomDetails As String = "" : Dim cnt As Integer = 0 : Dim totalAdult As Integer = 0 : Dim totalChild As Integer = 0 : Dim totalExtra As Integer = 0 : Dim total As Double = 0
        com.CommandText = "select *, roomno , description, ifnull((select adultrate from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid and dayno=0),0) as 'PackageRate', " _
                                        + " datediff(departure,arival) as 'NoDay', " _
                                        + " ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0) as 'RoomCharges' from tblhotelfolioroom where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            RoomDetails += "<tr><td align='center'>" & rst("roomno").ToString & "</td><td>" & rst("description").ToString & "</td><td align='center'>" & rst("NoDay").ToString & "</td><td align='right'-</td><td align='center'>" & rst("Pax").ToString & "</td><td align='center'>" & rst("child").ToString & "</td><td align='center'>" & rst("extra").ToString & "</td><td align='right'>-</td></tr>"
            total = total + Val(rst("RoomCharges").ToString)
            totalAdult = totalAdult + Val(rst("pax").ToString)
            totalChild = totalChild + Val(rst("child").ToString)
            totalExtra = totalExtra + Val(rst("extra").ToString)
            cnt = cnt + 1
        End While
        rst.Close()
        RoomDetails += "<tr style='font-weight:bold'> <td align='center'>" & cnt & " Room(s)</td><td></td><td align='center'></td><td align='right'></td><td align='center'>" & totalAdult.ToString & "</td><td align='center'>" & totalChild.ToString & "</td><td align='center'>" & totalExtra.ToString & "</td><td align='right'>" & FormatNumber(roomcharges, 2) & "</td></tr>"

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[room]", RoomDetails), False)

        Dim POSTransaction As String = "" : Dim POSDetails As String = "" : Dim totalPOSTransaction As Double = 0

        If totalPOS > 0 Then
            POSTransaction = "<br/> " _
                  + " <table  border='0' id='tabl_sub_border' width='100%'  cellspacing='0' cellpadding='0'>" _
                     + " <tr style=' border-bottom: 1px solid #d1d1d1;'><td colspan='8' align='center' class='info' style='padding-top:10px;'><b>POS / OTHER CHARGES</b></td></tr>" _
                     + " <tr align='center' style='font-weight: bold;'><td>DATE POSTED</td><td>CHARGE FROM</td><td>CTR</td><td>REFERENCE</td><td>REMARKS</td><td>AMOUNT</td></tr>"

            com.CommandText = "select datetrn,(select officename from tblcompoffice where officeid=tblhotelfoliotransaction.officeid) as 'ChargeFrom', roomno,concat('#',referenceno) as 'Reference', Remarks, debit from tblhotelfoliotransaction where foliono='" & bookno & "' and chargefrompos=1 and cancelled=0 order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                POSDetails += "<tr><td align='center'>" & rst("datetrn").ToString & "</td><td>" & rst("ChargeFrom").ToString & "</td><td align='center'>" & rst("roomno").ToString & "</td><td align='center'>" & rst("Reference").ToString & "</td><td>" & rst("Remarks").ToString & "</td><td align='right'>" & If(customPos = True, "-", FormatNumber(Val(rst("debit").ToString), 2)) & "</td></tr>"
                totalPOSTransaction = totalPOSTransaction + Val(rst("debit").ToString)
            End While
            rst.Close()
            POSDetails += "<tr style='font-weight:bold'><td></td><td></td><td></td><td></td><td></td><td align='right'>" & If(customPos = True, FormatNumber(totalPOS, 2), FormatNumber(totalPOSTransaction, 2)) & "</td></tr>"
            POSTransaction += POSDetails & "</table>"
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pos]", POSTransaction), False)

        Dim PaymentTransaction As String = "" : Dim PaymentDetails As String = "" : Dim totalPaymentTransaction As Double = 0
        If totalPayment > 0 Then
            PaymentTransaction = "<br/> " _
                  + " <table  border='0' id='tabl_sub_border' width='100%'  cellspacing='0' cellpadding='0'>" _
                     + " <tr style=' border-bottom: 1px solid #d1d1d1;'><td colspan='8' align='center' class='info' style='padding-top:10px;'><b>PAYMENT TRANSACTION</b></td></tr>" _
                     + " <tr align='center' style='font-weight: bold;'><td>DATE POSTED</td><td>PAYMENT FOR ROOM</td><td>REFERENCE</td><td>REMARKS</td><td>AMOUNT</td></tr>"

            com.CommandText = "select trnid,referenceno, datetrn,if(roomno='','-',roomno) as 'PaymentForRoom', Remarks, credit,concat('#',referenceno) as 'Reference' from tblhotelfoliotransaction where foliono='" & bookno & "' and paymenttrn=1 and cancelled=0 order by datetrn asc" : rst = com.ExecuteReader
            While rst.Read
                PaymentDetails += "<tr><td align='center'>" & rst("datetrn").ToString & "</td><td align='center'>" & rst("PaymentForRoom").ToString & "</td><td align='center'>" & rst("Reference").ToString & "</td><td>" & rst("Remarks").ToString & "</td><td align='right'>-</td></tr>"
                totalPaymentTransaction = totalPaymentTransaction + Val(rst("credit").ToString)
            End While
            rst.Close()
            PaymentDetails += "<tr style='font-weight:bold'><td></td><td></td><td></td><td></td><td align='right'>" & FormatNumber(payment, 2) & "</td></tr>"
            PaymentTransaction += PaymentDetails & "</table>"
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pos]", POSTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payment]", PaymentTransaction), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateGuestFolioTransaction(ByVal bookno As String, ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        'CreateHTMLReportTemplate("HotelGuestFolio.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelGuestFolioTransaction.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\STATEMENT\TRN-" & bookno & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim totalPOS As Double = 0 : Dim totalPayment As Double = 0
        com.CommandText = " select *,date_format(arival, '%M %d, %Y') as arivals, date_format(departure, '%M %d, %Y') as checkout,datediff(departure,arival) as nodays, " _
                        + " (select countryname from tblcountries where countrycode = tblhotelguest.countrycode) as 'country', " _
                        + " (select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, " _
                        + " (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as agent, " _
                        + " flight, Remarks " _
                        + " from tblhotelfolioguest inner join tblhotelguest on tblhotelfolioguest.guestid = tblhotelguest.guestid where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            End If
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToString("MMMM dd, yyyy")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[guest]", rst("fullname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birth date]", rst("birthdate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[gender]", rst("gender").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[country]", rst("country").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nationality]", rst("nationality").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[contact]", rst("contactnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[email]", rst("emailadd").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[folio]", rst("foliono").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[arival]", rst("arivals").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", rst("checkout").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nodays]", rst("nodays").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[flight]", rst("flight").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("remarks").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[agent]", rst("agent").ToString), False)
        End While
        rst.Close()

        Dim RoomType As String = ""
        com.CommandText = "SELECT concat(count(*),' - ',description) as room_type FROM `tblhotelfolioroom` where foliono='" & bookno & "' group by roomtype;" : rst = com.ExecuteReader()
        While rst.Read
            If rst("room_type").ToString <> "" Then
                RoomType += rst("room_type").ToString & "</br>"
            End If

        End While
        rst.Close()

        Dim roomno As String = ""
        com.CommandText = "SELECT group_concat(roomno separator ', ') as room FROM `tblhotelfolioroom` where foliono='" & bookno & "' and roomno<>'' group by roomtype;" : rst = com.ExecuteReader()
        While rst.Read
            If rst("room").ToString <> "" Then
                roomno += rst("room").ToString & "</br>"
            End If
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomtype]", RoomType), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[roomnumber]", roomno), False)

        com.CommandText = "select sum(pax) as ttlpax,sum(child) as ttlchild, sum(extra) as ttlextra from tblhotelfolioroom where foliono='" & bookno & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[adult]", rst("ttlpax").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[child]", rst("ttlchild").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[extra]", rst("ttlextra").ToString), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", DXSetupTheGridviewPrinter(TableTitle, gv)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateRoomAvailabity(ByVal roomtype As String, ByVal title As String, ByVal datefrom As Date, ByVal dateto As Date, ByVal form As Form)
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelCalendar.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\CALENDAR\calendar" & globaluserid & " " & ConvertDate(datefrom) & "-" & ConvertDate(dateto) & " .html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToString("MMMM dd, yyyy")), False)

        Dim HotelAvailabilityTable As String = ""
        Dim ColumnHeader As String = "" : Dim ColumnRow As String = ""
        Dim countday As Integer = DateDiff(DateInterval.Day, datefrom, dateto)
        For i = 0 To countday
            Dim rptdate As Date = datefrom
            ColumnRow += "<th align='center'>" & ConvertDate(rptdate.AddDays(i)) & "<br/>" & rptdate.AddDays(i).ToString("dddd") & "</th>"
        Next
        ColumnHeader = Environment.NewLine & "<tr><th align='center'>Room Number</th>" & ColumnRow & "</tr>" & Environment.NewLine
        Dim TableHeader As String = "" : Dim TableRow As String = ""
        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tblhotelrooms where roomtype='" & roomtype & "' order by roomnumber asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            Dim RowTD As String = ""
            RowTD += "<td><b>" & st.Tables(0).Rows(nt)("roomnumber").ToString() & "</b></td>"
            For i = 0 To countday
                Dim rptdate As Date = datefrom
                com.CommandText = "select *, ifnull((select fullname from tblhotelguest where guestid = b.guestid),'')  as 'Guest' from tblhotelfolioroomsummary as a inner join tblhotelfolioroom  as b on a.folioid=b.folioid  where (a.cancelled=0 or b.cancelled) and a.datetrn='" & ConvertDate(rptdate.AddDays(i)) & "' and a.roomid='" & st.Tables(0).Rows(nt)("roomid").ToString() & "' limit 1" : rst = com.ExecuteReader
                If rst.HasRows = True Then
                    While rst.Read
                        RowTD += "<td><h3>" & rst("foliono").ToString & "</h3>" & rst("Guest").ToString & "</td>"
                    End While
                Else
                    RowTD += "<td>VACANT</td>"
                End If
                rst.Close()

            Next
            TableRow += "<tr align='center'>" & RowTD & "</tr>" & Environment.NewLine
        Next

        HotelAvailabilityTable = "<table>" & ColumnHeader & TableRow & "</table>"

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", title & "<br/><b>Room Avalaibility</b>"), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[table]", HotelAvailabilityTable), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function GenerateLXCashiersBlotter(ByVal trnsumcode As String, ByVal form As Form, ByVal PrintBlotter As Boolean) As String
        Dim TableTransaction As String = ""
        Dim TotalCash As Double = 0 : Dim TotalCheck As Double = 0 : Dim TotalCard As Double = 0 : Dim TotalOnline As Double = 0 : Dim TotalVoucher As Double = 0 : Dim TotalCTR As Double = 0 : Dim TotalCTA As Double = 0 : Dim TotalComplimentary As Double = 0 : Dim TotalInterOffice As Double = 0
        'CreateHTMLReportTemplate("CashiersRemittance.html")
        Dim Template As String = ""
        If PrintBlotter = True Then
            Template = Application.StartupPath.ToString & "\Templates\CashiersBlotter.html"
        Else
            Template = Application.StartupPath.ToString & "\Templates\Email\CahiersBlotterMail.html"
        End If

        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\BLOTTER\" & trnsumcode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        'LOAD CASH REPORT
        Dim cash As Boolean = False : Dim TableCash As String = ""
        Dim table_left As String = "" : Dim table_right As String = ""

        com.CommandText = "call sp_salesremittance('CONSOLIDATED','" & trnsumcode & "','');" : com.ExecuteNonQuery()

        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tmpconsolidated order by id asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            If CBool(st.Tables(0).Rows(nt)("rptviewleft").ToString()) = True Then
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_left += "<tr><td colspan='2'><b>" & st.Tables(0).Rows(nt)("title").ToString() & "</b></td></tr>"
                End If
                com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
                While rst.Read
                    table_left += "<tr><td>" & rst("details").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("amount").ToString), 2) & "</td></tr>"
                End While
                rst.Close()
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_left += "<tr><td></td><td align='right'><u><b>" & FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2) & "</b></u></td></tr>"
                End If
            Else
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_right += "<tr><td colspan='2'><b>" & st.Tables(0).Rows(nt)("title").ToString() & "</b></td></tr>"
                End If
                com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
                While rst.Read
                    table_right += "<tr><td>" & rst("details").ToString & "</td><td align='right'>" & FormatNumber(Val(rst("amount").ToString), 2) & "</td></tr>"
                End While
                rst.Close()
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_right += "<tr><td></td><td align='right'><u><b>" & FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2) & "</b></u></td></tr>"
                End If
            End If
        Next

        If PrintBlotter = True Then
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            End If
        Else
            If GlobalOrganizationLogoURL.Length > 5 Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img src='" & GlobalOrganizationLogoURL & "'></div>"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            End If
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[left_transaction]", table_left), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[right_transaction]", table_right), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[trnsumcode]", trnsumcode), False)

        com.CommandText = "select *,date_format(dateclose, '%M %d, %Y %r') as DateClosed, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as cashier,(select designation from tblaccounts where accountid=tblsalessummary.userid) as position,(select officename from tblcompoffice where officeid=tblsalessummary.officeid) as office from tblsalessummary where trncode='" & trnsumcode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashier]", rst("cashier").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datetrn]", CDate(rst("dateopen").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashbeg]", FormatNumber(Val(rst("begcash").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash]", FormatNumber(Val(rst("begcash").ToString) + TotalCash, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("office").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", "<b>" & UCase(rst("cashier").ToString & "</b>")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", StrConv(rst("position").ToString, vbProperCase)), False)

            If rst("DateClosed").ToString <> "" Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", CDate(rst("DateClosed").ToString)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(Now)), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", CDate(Now)), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(Now)), False)
            End If
        End While
        rst.Close()
        If PrintBlotter = True Then
            PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
            Return True
        Else
            GenerateLXCashiersBlotter = My.Computer.FileSystem.ReadAllText(SaveLocation)
            Return GenerateLXCashiersBlotter
        End If
    End Function

    Public Sub GenerateLXHotelSummary(ByVal DateFrom As Date, ByVal DateTo As Date, ByVal form As Form)
        Dim TableTransaction As String = ""
        Dim TotalCash As Double = 0 : Dim TotalCheck As Double = 0 : Dim TotalCard As Double = 0 : Dim TotalOnline As Double = 0 : Dim TotalVoucher As Double = 0 : Dim TotalCTR As Double = 0 : Dim TotalCTA As Double = 0 : Dim TotalComplimentary As Double = 0 : Dim TotalInterOffice As Double = 0
        'CreateHTMLReportTemplate("CashiersRemittance.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelSummaryReports.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HOTEL SUMMARY\" & globaluserid & " - " & globalusername & " .html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        'LOAD CASH REPORT
        Dim cash As Boolean = False : Dim TableCash As String = ""
        Dim table_left As String = "" : Dim table_right As String = ""

        com.CommandText = "call sp_salesremittance('HOTEL','and b.hotelcif in (select hotelcif from tblhotelfilter where permissioncode=''" & globalAuthcode & "'') and datetrn between ''" & ConvertDate(DateFrom) & "'' and ''" & ConvertDate(DateTo) & "''','datetrn between ''" & ConvertDate(DateFrom) & "'' and ''" & ConvertDate(DateTo) & "''')" : com.ExecuteNonQuery()

        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tmpconsolidated order by id asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            If CBool(st.Tables(0).Rows(nt)("rptviewleft").ToString()) = True Then
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_left += "<tr><td colspan='2'><b>" & st.Tables(0).Rows(nt)("title").ToString() & "</b></td></tr>"
                End If
                com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
                While rst.Read
                    table_left += "<tr><td>" & rst("details").ToString & "</td><td align='right'>" & If(CBool(st.Tables(0).Rows(nt)("numbertype").ToString()) = True, FormatNumber(Val(rst("amount").ToString), 2), Val(rst("amount").ToString)) & "</td></tr>"
                End While
                rst.Close()
                If CBool(st.Tables(0).Rows(nt)("showtotal").ToString()) = True Then
                    table_left += "<tr><td></td><td align='right'><u><b>" & If(CBool(st.Tables(0).Rows(nt)("numbertype").ToString()) = True, FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2), Val(st.Tables(0).Rows(nt)("total").ToString())) & "</b></u></td></tr>"
                End If
            Else
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    table_right += "<tr><td colspan='2'><b>" & st.Tables(0).Rows(nt)("title").ToString() & "</b></td></tr>"
                End If
                com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
                While rst.Read
                    table_right += "<tr><td>" & rst("details").ToString & "</td><td align='right'>" & If(CBool(st.Tables(0).Rows(nt)("numbertype").ToString()) = True, FormatNumber(Val(rst("amount").ToString), 2), Val(rst("amount").ToString)) & "</td></tr>"
                End While
                rst.Close()
                If CBool(st.Tables(0).Rows(nt)("showtotal").ToString()) = True Then
                    table_right += "<tr><td></td><td align='right'><u><b>" & If(CBool(st.Tables(0).Rows(nt)("numbertype").ToString()) = True, FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2), Val(st.Tables(0).Rows(nt)("total").ToString())) & "</b></u></td></tr>"
                End If
            End If

        Next

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[left_transaction]", table_left), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[right_transaction]", table_right), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", compOfficename), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datefrom]", CDate(DateFrom).ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateto]", CDate(DateTo).ToShortDateString), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXDakakHotelReport(ByVal datefrom As Date, ByVal dateto As Date, ByVal title As String, ByVal form As Form)
        Dim TableTransaction As String = ""
        Dim TotalCash As Double = 0
        'CreateHTMLReportTemplate("CashiersRemittance.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReports.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HOTEL\" & form.Name & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        'LOAD POS TRANSACTION REPORT
        com.CommandText = "call sp_salesremittance('DAKAK', '','and date_format(datetrn,''%Y-%m-%d'') between ''" & ConvertDate(datefrom) & "'' and ''" & ConvertDate(dateto) & "'' ');" : com.ExecuteNonQuery()

        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
        Dim TableDakakTransaction As String = "" : Dim Dakakquantity As Double = 0 : Dim DakakTransaction As Double = 0
        TableHead = "<table border='1' style='width:600px'> " _
                     + " <tr> " _
                         + " <th>DAKAK DAY/NIGHT TOUR</th> " _
                         + " <th>NO. OF GUESTS</th> " _
                         + " <th>VALUE</th> " _
                     + " </tr> " & Chr(13)

        com.CommandText = "select * from tmppostransactiondakak" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td>" & rst("productname").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("quantity").ToString, 0) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Dakakquantity = Dakakquantity + Val(rst("quantity").ToString)
            DakakTransaction = DakakTransaction + Val(rst("total").ToString)
        End While
        rst.Close()

        TableRow += "<tr> " _
                  + " <td align='right'><b>TOTAL</b></td> " _
                  + " <td align='center'><b>" & FormatNumber(Dakakquantity, 0) & "</b></td> " _
                  + " <td align='right'><b>" & FormatNumber(DakakTransaction, 2) & "</b></td> " _
           + " </tr> " & Chr(13)
        TableFooter = "</table>"
        TableDakakTransaction = TableHead + TableRow + TableFooter

        'DAKAK HOTEL TRANSACTION REPORT
        TableHead = "" : TableRow = "" : TableFooter = ""
        Dim TableDakakHotel As String = "" : Dim Dakakroom As Double = 0 : Dim Dakakguest As Double = 0 : Dim Dakakhotel As Double = 0
        TableHead = "<table border='1' style='width:600px'> " _
                     + " <tr> " _
                         + " <th>DAKAK ROOM TYPE</th> " _
                         + " <th>TOTAL ROOM OCCUPIED</th> " _
                         + " <th>NO. OF GUEST</th> " _
                         + " <th>VALUE</th> " _
                     + " </tr> " & Chr(13)

        com.CommandText = "select * from tmphotelsummary where hotelcif='CIF1000002';" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td>" & rst("details").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("rooms").ToString, 0) & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("pax").ToString, 0) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Dakakroom = Dakakroom + Val(rst("rooms").ToString)
            Dakakguest = Dakakguest + Val(rst("pax").ToString)
            Dakakhotel = Dakakhotel + Val(rst("amount").ToString)
        End While
        rst.Close()

        TableRow += "<tr> " _
                  + " <td align='right'><b>TOTAL</b></td> " _
                  + " <td align='center'><b>" & FormatNumber(Dakakroom, 0) & "</b></td> " _
                  + " <td align='center'><b>" & FormatNumber(Dakakguest, 0) & "</b></td> " _
                  + " <td align='right'><b>" & FormatNumber(Dakakhotel, 2) & "</b></td> " _
           + " </tr> " & Chr(13)
        TableFooter = "</table>"
        TableDakakHotel = TableHead + TableRow + TableFooter



        'VILLA POS TRANASCTION
        TableHead = "" : TableRow = "" : TableFooter = ""
        Dim TableVillaTransaction As String = "" : Dim Villaquantity As Double = 0 : Dim VillaTransaction As Double = 0
        TableHead = "<table border='1' style='width:600px'> " _
                     + " <tr> " _
                         + " <th>VILLA DAY TOUR</th> " _
                         + " <th>NO. OF GUESTS</th> " _
                         + " <th>VALUE</th> " _
                     + " </tr> " & Chr(13)

        com.CommandText = "select * from tmppostransactionvilla" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td>" & rst("productname").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("quantity").ToString, 0) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Villaquantity = Villaquantity + Val(rst("quantity").ToString)
            VillaTransaction = VillaTransaction + Val(rst("total").ToString)
        End While
        rst.Close()

        TableRow += "<tr> " _
                  + " <td align='right'><b>TOTAL</b></td> " _
                  + " <td align='center'><b>" & FormatNumber(Villaquantity, 0) & "</b></td> " _
                  + " <td align='right'><b>" & FormatNumber(VillaTransaction, 2) & "</b></td> " _
           + " </tr> " & Chr(13)
        TableFooter = "</table>"
        TableVillaTransaction = TableHead + TableRow + TableFooter


        'VILLA HOTEL TRANSACTION REPORT
        TableHead = "" : TableRow = "" : TableFooter = ""
        Dim TableVillaHotel As String = "" : Dim villaroom As Double = 0 : Dim villaguest As Double = 0 : Dim villahotel As Double = 0
        TableHead = "<table border='1' style='width:600px'> " _
                     + " <tr> " _
                         + " <th>VILLA ROOM TYPE</th> " _
                         + " <th>TOTAL ROOM OCCUPIED</th> " _
                         + " <th>NO. OF GUEST</th> " _
                         + " <th>VALUE</th> " _
                     + " </tr> " & Chr(13)

        com.CommandText = "select * from tmphotelsummary where hotelcif='CIF1000003';" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td>" & rst("details").ToString & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("rooms").ToString, 0) & "</td> " _
                           + " <td align='center'>" & FormatNumber(rst("pax").ToString, 0) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            villaroom = villaroom + Val(rst("rooms").ToString)
            villaguest = villaguest + Val(rst("pax").ToString)
            villahotel = villahotel + Val(rst("amount").ToString)
        End While
        rst.Close()

        TableRow += "<tr> " _
                  + " <td align='right'><b>TOTAL</b></td> " _
                  + " <td align='center'><b>" & FormatNumber(villaroom, 0) & "</b></td> " _
                  + " <td align='center'><b>" & FormatNumber(villaguest, 0) & "</b></td> " _
                  + " <td align='right'><b>" & FormatNumber(villahotel, 2) & "</b></td> " _
           + " </tr> " & Chr(13)
        TableFooter = "</table>"
        TableVillaHotel = TableHead + TableRow + TableFooter


        TableTransaction = If(TableDakakTransaction.Length > 0, TableDakakTransaction & "</br>", "") _
                         & If(TableDakakHotel.Length > 0, TableDakakHotel & "</br>", "") _
                         & If(TableVillaTransaction.Length > 0, TableVillaTransaction & "</br>", "") _
                         & If(TableVillaHotel.Length > 0, TableVillaHotel & "</br>", "")


        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", title), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", "Date Filter: " & datefrom & " to " & dateto & "<br/><br/>"), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub


    Public Sub GenerateLXCashiersRemittance(ByVal trnsumcode As String, ByVal form As Form)
        Dim TableTransaction As String = ""
        Dim TotalCash As Double = 0 : Dim TotalExpense As Double = 0 : Dim TotalCheck As Double = 0 : Dim TotalCard As Double = 0 : Dim TotalOnline As Double = 0 : Dim TotalVoucher As Double = 0 : Dim TotalCTR As Double = 0 : Dim TotalCTA As Double = 0 : Dim TotalComplimentary As Double = 0 : Dim TotalInterOffice As Double = 0
        'CreateHTMLReportTemplate("CashiersRemittance.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\CashiersRemittance.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\FOLIO\" & trnsumcode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        'LOAD CASH REPORT
        Dim cash As Boolean = False : Dim TableCash As String = ""
        com.CommandText = "call sp_salesremittance('CASH','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            cash = True
        End If
        rst.Close()
        If cash = True Then
            Dim TablCashHead As String = "" : Dim TableCashRow As String = "" : Dim TableCashFooter As String = ""
            TablCashHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='4'>CASH TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>" & If(EnableModuleHotel = True, "Guest", "Customer Name") & "</th> " _
                             + If(globalAuthHotelManagement = True, " <th>Folio</th> ", "") _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CASH','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableCashRow += "<tr> " _
                               + " <td align='center'>" & rst("reference").ToString & "</td> " _
                               + " <td >" & rst("guest").ToString & "</td> " _
                               + If(globalAuthHotelManagement = True, " <td align='center'>" & rst("folio").ToString & "</td> ", "") _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCash = TotalCash + Val(rst("amount").ToString)
            End While
            rst.Close()

            TableCashRow += "<tr> " _
                            + " <td align='right' colspan='2'>Total</td> " _
                            + " <td align='right'>" & FormatNumber(TotalCash, 2) & "</td> " _
                            + " <td></td> " _
                     + " </tr> " & Chr(13)
            TableCashFooter = "</table>"
            TableCash = TablCashHead + TableCashRow + TableCashFooter
        End If

        'LOAD EXPENSE REPORT
        Dim expense As Boolean = False : Dim TableExpense As String = ""
        com.CommandText = "call sp_salesremittance('EXPENSE','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            expense = True
        End If
        rst.Close()
        If expense = True Then
            Dim TablExpenseHead As String = "" : Dim TableExpenseRow As String = "" : Dim TableExpenseFooter As String = ""
            TablExpenseHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>POS EXPENSE</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction Name</th> " _
                             + " <th align='center'>OR Number</th> " _
                             + " <th>Amount</th> " _
                             + " <th align='center'>Affect Cash</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('EXPENSE','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableExpenseRow += "<tr> " _
                               + " <td>" & rst("itemname").ToString & "</td> " _
                               + " <td align='center'>" & rst("ornumber").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td align='center'>" & If(CBool(rst("affectcash")) = True, "YES", "No") & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalExpense = TotalExpense + Val(rst("amount").ToString)
            End While
            rst.Close()

            TableExpenseRow += "<tr> " _
                            + " <td align='right' colspan='3'>Total</td> " _
                            + " <td align='right'>" & FormatNumber(TotalExpense, 2) & "</td> " _
                            + " <td></td> " _
                     + " </tr> " & Chr(13)
            TableExpenseFooter = "</table>"
            TableExpense = TablExpenseHead + TableExpenseRow + TableExpenseFooter
        End If

        'LOAD CHECK REPORT
        Dim check As Boolean = False : Dim TableCheck As String = ""
        com.CommandText = "call sp_salesremittance('CHECK','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            check = True
        End If
        rst.Close()
        If check = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='7'>CHECK TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>Client</th> " _
                             + " <th>Check No</th> " _
                             + " <th>Bank Check</th> " _
                             + " <th>Check Date</th> " _
                             + " <th>Account Name</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CHECK','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("reference").ToString & "</td> " _
                               + " <td >" & rst("client").ToString & "</td> " _
                               + " <td align='center'>" & rst("checkno").ToString & "</td> " _
                               + " <td align='center'>" & rst("bankcheck").ToString & "</td> " _
                               + " <td align='center'>" & rst("checkdate").ToString & "</td> " _
                               + " <td >" & rst("accountname").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCheck = TotalCheck + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='6'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCheck, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCheck = TableHead + TableRow + TableFooter
        End If


        'LOAD CARD REPORT
        Dim card As Boolean = False : Dim TableCard As String = ""
        com.CommandText = "call sp_salesremittance('CARD','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            card = True
        End If
        rst.Close()
        If card = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>CARD TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>Card Type</th> " _
                             + " <th>Trace No</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CARD','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                               + " <td align='center'>" & rst("carddetails").ToString & "</td> " _
                               + " <td align='center'>" & rst("tracenumber").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td >" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCard = TotalCard + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCard, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCard = TableHead + TableRow + TableFooter
        End If

        'LOAD ONLINE REPORT
        Dim online As Boolean = False : Dim TableOnline As String = ""
        com.CommandText = "call sp_salesremittance('ONLINE','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            online = True
        End If
        rst.Close()
        If online = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>ONLINE TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>" & If(EnableModuleHotel = True, "Guest", "Customer Name") & "</th> " _
                             + " <th>Account</th> " _
                             + " <th>Reference No.</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('ONLINE','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("transaction").ToString & "</td> " _
                               + " <td>" & rst("guest").ToString & "</td> " _
                               + " <td align='center'>" & rst("account").ToString & "</td> " _
                               + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalOnline = TotalOnline + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='4'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalOnline, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableOnline = TableHead + TableRow + TableFooter
        End If

        'LOAD VOUCHER PAYMENT REPORT
        Dim voucher As Boolean = False : Dim TableVoucher As String = ""
        com.CommandText = "call sp_salesremittance('VOUCHER','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            voucher = True
        End If
        rst.Close()
        If voucher = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>VOUCHER PAYMENT TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>" & If(EnableModuleHotel = True, "Guest", "Customer Name") & "</th> " _
                             + " <th>Voucher No.</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('VOUCHER','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("transaction").ToString & "</td> " _
                               + " <td>" & rst("guest").ToString & "</td> " _
                               + " <td align='center'>" & rst("voucherno").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalVoucher = TotalVoucher + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalVoucher, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableVoucher = TableHead + TableRow + TableFooter
        End If

        'LOAD CTR REPORT
        Dim ctr As Boolean = False : Dim TableCTR As String = ""
        com.CommandText = "call sp_salesremittance('CTR','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            ctr = True
        End If
        rst.Close()
        If ctr = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>CHARGE TO ROOM TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th width='100'>Reference</th> " _
                             + " <th>Room Number</th> " _
                             + " <th>Guest</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CTR','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("referenceno").ToString & "</td> " _
                               + " <td align='center'>" & rst("roomno").ToString & "</td> " _
                               + " <td>" & rst("guest").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCTR = TotalCTR + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCTR, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCTR = TableHead + TableRow + TableFooter
        End If

        'LOAD CTA REPORT
        Dim cta As Boolean = False : Dim TableCTA As String = ""
        com.CommandText = "call sp_salesremittance('CTA','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            cta = True
        End If
        rst.Close()
        If cta = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='5'>CHARGE TO ACCOUNT TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>Invoice No.</th> " _
                             + " <th>Account</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('CTA','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("transaction").ToString & "</td> " _
                               + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                               + " <td align='center'>" & rst("account").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalCTA = TotalCTA + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td align='right' colspan='3'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalCTA, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableCTA = TableHead + TableRow + TableFooter
        End If


        'LOAD COMPLIMENTARY REPORT
        Dim complimentary As Boolean = False : Dim TableComplimentary As String = ""
        com.CommandText = "call sp_salesremittance('COMPLIMENTARY','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            complimentary = True
        End If
        rst.Close()
        If complimentary = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='4'>COMPLIMENTARY TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Transaction</th> " _
                             + " <th>Remarks</th> " _
                             + " <th>Amount</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('COMPLIMENTARY','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("batchcode").ToString & "</td> " _
                               + " <td>" & rst("complimentaryremarks").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                TotalComplimentary = TotalComplimentary + Val(rst("total").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td colspan='2' align='right'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalComplimentary, 2) & "</td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableComplimentary = TableHead + TableRow + TableFooter
        End If


        'LOAD INTER OFFICE TRANSACTION
        Dim interoffice As Boolean = False : Dim TableInterOffice As String = ""
        com.CommandText = "call sp_salesremittance('IO','" & trnsumcode & "','');" : rst = com.ExecuteReader
        If rst.HasRows = True Then
            interoffice = True
        End If
        rst.Close()
        If interoffice = True Then
            Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = ""
            TableHead = "<table border='1'> " _
                         + " <tr> " _
                             + " <th style='padding: 10px' colspan='6'>INTER OFFICE TRANSACTION</th> " _
                         + " </tr> " _
                         + " <tr> " _
                             + " <th>Reference</th> " _
                             + " <th>Transaction Name</th> " _
                             + " <th>Details</th> " _
                             + " <th>Amount</th> " _
                             + " <th>Remarks</th> " _
                         + " </tr> " & Chr(13)

            com.CommandText = "call sp_salesremittance('IO','" & trnsumcode & "','');" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("trnno").ToString & "</td> " _
                               + " <td>" & rst("itemname").ToString & "</td> " _
                               + " <td>" & rst("due").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                               + " <td>" & rst("remarks").ToString & "</td> " _
                         + " </tr> " & Chr(13)
                TotalInterOffice = TotalInterOffice + Val(rst("amount").ToString)
            End While
            rst.Close()
            TableRow += "<tr> " _
                      + " <td colspan='3' align='right'>Total</td> " _
                      + " <td align='right'>" & FormatNumber(TotalInterOffice, 2) & "</td> " _
                      + " <td></td> " _
               + " </tr> " & Chr(13)
            TableFooter = "</table>"
            TableInterOffice = TableHead + TableRow + TableFooter
        End If

        TableTransaction = If(TableCash.Length > 0, TableCash & "</br>", "") _
                            & If(TableExpense.Length > 0, TableExpense & "</br>", "") _
                            & If(TableCheck.Length > 0, TableCheck & "</br>", "") _
                            & If(TableCard.Length > 0, TableCard & "</br>", "") _
                            & If(TableOnline.Length > 0, TableOnline & "</br>", "") _
                            & If(TableVoucher.Length > 0, TableVoucher & "</br>", "") _
                            & If(TableCTR.Length > 0, TableCTR & "</br>", "") _
                            & If(TableCTA.Length > 0, TableCTA & "</br>", "") _
                            & If(TableComplimentary.Length > 0, TableComplimentary & "</br>", "") _
                            & If(TableInterOffice.Length > 0, TableInterOffice & "</br>", "")

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashier]", globalfullname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[trnsumcode]", trnsumcode), False)
        com.CommandText = "select * from tblsalessummary where trncode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datetrn]", rst("dateopen").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cashbeg]", FormatNumber(Val(rst("begcash").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash]", FormatNumber(Val(rst("begcash").ToString) + TotalCash, 2)), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateclosed]", CDate(Now)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXHotelGuestList(ByVal hotelcif As String, ByVal title As String, ByVal datefilter As Date, ByVal form As Form)
        Dim TableRow_inhouse As String = "" : Dim inhouse As String = "" : Dim sumRow_inhouse As String = "" : Dim inhouse_pax As Integer = 0 : Dim inhouse_child As Integer = 0
        Dim TableRow_arrival As String = "" : Dim arrival As String = "" : Dim sumRow_arrival As String = "" : Dim arrival_pax As Integer = 0 : Dim arrival_child As Integer = 0
        Dim TableRow_checkout As String = "" : Dim checkout As String = "" : Dim sumRow_checkout As String = "" : Dim checkout_pax As Integer = 0 : Dim checkout_child As Integer = 0
        Dim TableRow_noshow As String = "" : Dim noshow As String = "" : Dim sumRow_noshow As String = "" : Dim noshow_pax As Integer = 0 : Dim noshow_child As Integer = 0
        'CreateHTMLReportTemplate("HotelGuestList.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HotelGuestList.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HOTEL\HotelGuestList " & ConvertDate(datefilter) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        Dim companyid As String = ""
        com.CommandText = "SELECT (select companyid from tblcompoffice where officeid=tblhotelgroup.officeid) as 'companyid' FROM `tblhotelgroup` where hotelcif='" & hotelcif & "';" : rst = com.ExecuteReader
        While rst.Read
            companyid = rst("companyid").ToString
        End While
        rst.Close()
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim totalinhouse As Integer = countqry("`tblhotelfolioroom`", "inhouse=1 and hotelcif='" & hotelcif & "' and cancelled=0 and '" & ConvertDate(datefilter) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) ")
        Dim totalarival As Integer = countqry("`tblhotelfolioroom`", "hotelcif='" & hotelcif & "' and cancelled=0 and arival='" & ConvertDate(datefilter.AddDays(1)) & "'")
        Dim totalCheckout As Integer = countqry("`tblhotelfolioroom`", "inhouse=1 and hotelcif='" & hotelcif & "' and cancelled=0 and departure='" & ConvertDate(datefilter.AddDays(1)) & "'")
        Dim totalNoShow As Integer = countqry("`tblhotelfolioroom`", "inhouse=0 and hotelcif='" & hotelcif & "' and cancelled=0 and arival='" & ConvertDate(datefilter.AddDays(-1)) & "'")

        com.CommandText = "SELECT (select group_concat(shortcode separator ' ') from view_folio_shortcode where foliono=a.foliono) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '</br>') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where inhouse=1 and hotelcif='" & hotelcif & "' and cancelled=0 and '" & ConvertDate(datefilter) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) group by foliono order by roomno" : rst = com.ExecuteReader
        While rst.Read
            Dim roomStr As String = "" : Dim cnt As Integer = 0
            For Each word In rst("RoomNumber").ToString.Split(New Char() {","c})
                If cnt = 4 Then
                    roomStr = roomStr & word & "</br>"
                    cnt = 0
                Else
                    roomStr = roomStr & word & ","
                End If
                cnt += 1
            Next
            If roomStr.Length > 0 Then
                roomStr = roomStr.Remove(roomStr.Length - 1, 1)
            End If
            TableRow_inhouse += "<tr> " _
                           + " <td align='center'>" & If(rst("shortcode").ToString = "", "", rst("shortcode").ToString & "</br></br>") & roomStr & "</td> " _
                           + " <td>" & rst("Guest").ToString & "</td> " _
                           + " <td align='center'>" & rst("Adults").ToString & "</td> " _
                           + " <td align='center'>" & rst("Child").ToString & "</td> " _
                           + " <td align='center'>" & rst("Package").ToString & "</td> " _
                           + " <td>" & rst("Agent").ToString & "</td> " _
                           + " <td align='center' width='60'>" & rst("Stay").ToString & "</td> " _
                           + " <td>" & rst("Flight").ToString & "</td> " _
                           + " <td>" & rst("Remarks").ToString & "</td> " _
                     + " </tr> " & Chr(13)
            inhouse_pax = inhouse_pax + Val(rst("Adults").ToString)
            inhouse_child = inhouse_child + Val(rst("Child").ToString)
        End While
        rst.Close()
        sumRow_inhouse = "<tr><td align='center'>" & totalinhouse & " Rooms</td><td></td><td align='center'>" & inhouse_pax & "</td><td align='center'>" & inhouse_child & "</td> <td colspan='5'></td></tr>"
        inhouse = TableRow_inhouse + sumRow_inhouse

        'com.CommandText = "select ifnull((select group_concat(rooms) from tempbooking where foliono=tblhotelfolioguest.foliono),'') as RoomNumber,(select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, (select sum(pax+extra) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and cancelled=0) as Adults,(select sum(child) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and cancelled=0) as Child,(select group_concat(distinct((select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid))) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and cancelled=0) as Package,(select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as Agent,concat(date_format(arival, '%M %d'),'-',date_format(departure,'%d')) as 'Stay', flight as 'Flight',  Remarks from tblhotelfolioguest where foliono in (select foliono from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and cancelled=0 ) and arival='" & ConvertDate(datefilter.AddDays(1)) & "' and cancelled=0" : rst = com.ExecuteReader
        com.CommandText = "SELECT (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '</br>') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where hotelcif='" & hotelcif & "' and cancelled=0 and arival='" & ConvertDate(datefilter.AddDays(1)) & "' group by foliono order by roomno" : rst = com.ExecuteReader
        While rst.Read
            Dim roomStr As String = "" : Dim cnt As Integer = 0
            For Each word In rst("RoomNumber").ToString.Split(New Char() {","c})
                If cnt = 4 Then
                    roomStr = roomStr & word & "</br>"
                    cnt = 0
                Else
                    roomStr = roomStr & word & ","
                End If
                cnt += 1
            Next
            If roomStr.Length > 0 Then
                roomStr = roomStr.Remove(roomStr.Length - 1, 1)
            End If
            TableRow_arrival += "<tr> " _
                           + " <td align='center'>" & If(rst("shortcode").ToString = "", "", rst("shortcode").ToString & "</br></br>") & roomStr & "</td> " _
                           + " <td>" & rst("Guest").ToString & "</td> " _
                           + " <td align='center'>" & rst("Adults").ToString & "</td> " _
                           + " <td align='center'>" & rst("Child").ToString & "</td> " _
                           + " <td align='center'>" & rst("Package").ToString & "</td> " _
                           + " <td>" & rst("Agent").ToString & "</td> " _
                           + " <td align='center' width='60'>" & rst("Stay").ToString & "</td> " _
                           + " <td>" & rst("Flight").ToString & "</td> " _
                           + " <td>" & rst("Remarks").ToString & "</td> " _
                     + " </tr> " & Chr(13)
            arrival_pax = arrival_pax + Val(rst("Adults").ToString)
            arrival_child = arrival_child + Val(rst("Child").ToString)
        End While
        rst.Close()
        sumRow_arrival = "<tr><td align='center'>" & totalarival & " Rooms</td><td></td></td><td align='center'>" & arrival_pax & "</td><td align='center'>" & arrival_child & "</td> <td colspan='5'></td></tr>"
        arrival = TableRow_arrival + sumRow_arrival

        'com.CommandText = "select concat(ifnull((select group_concat(rooms) from tempcheckoutroom where foliono=tblhotelfolioguest.foliono),''),'|',(select group_concat(distinct(roomno)) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and confirmed=1 and cancelled=0)) as RoomNumber,(select fullname from tblhotelguest where guestid = tblhotelfolioguest.guestid) as Guest, (select sum(pax+extra) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and confirmed=1 and cancelled=0) as Adults,(select sum(child) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and confirmed=1 and cancelled=0) as Child,(select group_concat(distinct((select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid))) from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and cancelled=0) as Package,(select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) as Agent,concat(date_format(arival, '%M %d'),'-',date_format(departure,'%d')) as 'Stay', flight as 'Flight',  Remarks from tblhotelfolioguest where confirmed=1 and foliono in (select foliono from tblhotelfolioroom where hotelcif='" & hotelcif & "' and foliono=tblhotelfolioguest.foliono and confirmed=1 and cancelled=0) and cancelled=0 and departure='" & ConvertDate(datefilter.AddDays(1)) & "' " : rst = com.ExecuteReader
        com.CommandText = "SELECT (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '</br>') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where inhouse=1 and hotelcif='" & hotelcif & "' and cancelled=0 and departure='" & ConvertDate(datefilter.AddDays(1)) & "' group by foliono order by roomno" : rst = com.ExecuteReader
        While rst.Read
            Dim roomStr As String = "" : Dim cnt As Integer = 0
            For Each word In rst("RoomNumber").ToString.Split(New Char() {","c})
                If cnt = 4 Then
                    roomStr = roomStr & word & "</br>"
                    cnt = 0
                Else
                    roomStr = roomStr & word & ","
                End If
                cnt += 1
            Next
            If roomStr.Length > 0 Then
                roomStr = roomStr.Remove(roomStr.Length - 1, 1)
            End If

            TableRow_checkout += "<tr> " _
                           + " <td align='center'>" & If(rst("shortcode").ToString = "", "", rst("shortcode").ToString & "</br></br>") & roomStr & "</td> " _
                           + " <td>" & rst("Guest").ToString & "</td> " _
                           + " <td align='center'>" & rst("Adults").ToString & "</td> " _
                           + " <td align='center'>" & rst("Child").ToString & "</td> " _
                           + " <td align='center'>" & rst("Package").ToString & "</td> " _
                           + " <td>" & rst("Agent").ToString & "</td> " _
                           + " <td align='center' width='60'>" & rst("Stay").ToString & "</td> " _
                           + " <td>" & rst("Flight").ToString & "</td> " _
                           + " <td>" & rst("Remarks").ToString & "</td> " _
                     + " </tr> " & Chr(13)
            checkout_pax = checkout_pax + Val(rst("Adults").ToString)
            checkout_child = checkout_child + Val(rst("Child").ToString)
        End While
        rst.Close()
        sumRow_checkout = "<tr><td align='center'>" & totalCheckout & " Rooms</td><td></td></td><td align='center'>" & checkout_pax & "</td><td align='center'>" & checkout_child & "</td> <td colspan='5'></td></tr>"
        checkout = TableRow_checkout + sumRow_checkout

        com.CommandText = "SELECT (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '</br>') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where inhouse=0 and hotelcif='" & hotelcif & "' and cancelled=0 and arival='" & ConvertDate(datefilter.AddDays(-1)) & "' group by foliono order by roomno" : rst = com.ExecuteReader
        While rst.Read
            Dim roomStr As String = "" : Dim cnt As Integer = 0
            For Each word In rst("RoomNumber").ToString.Split(New Char() {","c})
                If cnt = 4 Then
                    roomStr = roomStr & word & "</br>"
                    cnt = 0
                Else
                    roomStr = roomStr & word & ","
                End If
                cnt += 1
            Next
            If roomStr.Length > 0 Then
                roomStr = roomStr.Remove(roomStr.Length - 1, 1)
            End If
            TableRow_noshow += "<tr> " _
                           + " <td align='center'>" & If(rst("shortcode").ToString = "", "", rst("shortcode").ToString & "</br></br>") & roomStr & "</td> " _
                           + " <td>" & rst("Guest").ToString & "</td> " _
                           + " <td align='center'>" & rst("Adults").ToString & "</td> " _
                           + " <td align='center'>" & rst("Child").ToString & "</td> " _
                           + " <td align='center'>" & rst("Package").ToString & "</td> " _
                           + " <td>" & rst("Agent").ToString & "</td> " _
                           + " <td align='center' width='60'>" & rst("Stay").ToString & "</td> " _
                           + " <td>" & rst("Flight").ToString & "</td> " _
                           + " <td>" & rst("Remarks").ToString & "</td> " _
                     + " </tr> " & Chr(13)
            noshow_pax = noshow_pax + Val(rst("Adults").ToString)
            noshow_child = noshow_child + Val(rst("Child").ToString)
        End While
        rst.Close()
        sumRow_noshow = "<tr><td align='center'>" & totalNoShow & "</td><td></td><td align='center'>" & noshow_pax & "</td><td align='center'>" & noshow_child & "</td> <td colspan='5'></td></tr>"
        noshow = TableRow_noshow + sumRow_noshow


        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\" & companyid & ".png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/" & companyid & ".png'>"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", SetupCompanyHeader(companyid, False)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", SetupCompanyHeader(companyid, True)), False)
        End If

        'If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
        '    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        'Else
        '    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        'End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", "<font size='2'>GUEST LIST SUMMARY REPORT</font></br>" & title & ""), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", CDate(Now)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datefilter]", datefilter.ToString("MM/dd/yyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datefilter1]", datefilter.AddDays(-1).ToString("MM/dd/yyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datefilter2]", datefilter.AddDays(1).ToString("MM/dd/yyy")), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[inhouse]", inhouse), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[arrival]", arrival), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkout]", checkout), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noshow]", noshow), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalrooms]", totalinhouse + totalarival - totalCheckout), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalpax]", inhouse_pax + arrival_pax - checkout_pax), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalchild]", inhouse_child + arrival_child - checkout_child), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub GenerateLXHotelForecast(ByVal title As String, ByVal hotelcif As String, ByVal datefrom As Date, ByVal dateto As Date, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = ""
        'CreateHTMLReportTemplate("hotelForecast.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\hotelForecast.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HOTEL\FORECAST " & ConvertDate(datefrom) & " " & ConvertDate(dateto) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        Dim tableHeader As String = ""
        Dim columnHeader As String = ""

        Dim RoomType As String = ""


        Dim fullrow As String = "" : Dim rowHeader As String = "" : Dim lastColumn As String = "" : Dim rowfooter As String = ""
        Dim totalRoomType As Integer = qrysingledata("cnt", "count(distinct(shortcode)) as cnt", "tblhotelroomtype where hotelcif='" & hotelcif & "' and shortcode<>''")
        Dim roomtypeSettings(totalRoomType - 1) As String
        tableHeader = "<table border='1'> "

        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select distinct shortcode from tblhotelroomtype where hotelcif='" & hotelcif & "' and shortcode<>'' order by sortorder asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            RoomType += "<th align='center'>" & st.Tables(0).Rows(nt)("shortcode").ToString() & "</th> "
            roomtypeSettings(nt) = st.Tables(0).Rows(nt)("shortcode").ToString()
        Next
        columnHeader = " <tr><th></th><th colspan='" & totalRoomType + 1 & "'>ARRIVALS</th><th colspan='" & totalRoomType + 1 & "'>DEPARTURE</th><th colspan='" & totalRoomType + 1 & "'>INHOUSE GUEST</th><th></th></tr>" _
                     + " <tr><th>DATE</th>" & RoomType & "<th align='center'>PAX</th>" & RoomType & "<th align='center'>PAX</th>" & RoomType & "<th align='center'>PAX</th><th>DATE</th></tr>"

        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tempforecast group by reportdate order by id asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            rowHeader = "<tr " & If(CDate(st.Tables(0).Rows(nt)("reportdate").ToString()).ToString("MM/dd/yyyy ddd").ToString.Contains("Sat"), "style='background-color:yellow'", "") & " ><td style='width:100px;'>" & CDate(st.Tables(0).Rows(nt)("reportdate").ToString()).ToString("MM/dd/yyyy ddd") & "</td>"
            lastColumn = "<td style='width:100px;'>" & CDate(st.Tables(0).Rows(nt)("reportdate").ToString()).ToString("MM/dd/yyyy ddd") & "</td>"


            Dim a_tf As String = "" : Dim arival As String = ""
            Dim d_tf As String = "" : Dim departure As String = ""
            Dim i_tf As String = "" : Dim inhouse As String = ""

            'arrival
            com.CommandText = "select * from tempforecast where reportdate='" & ConvertDate(st.Tables(0).Rows(nt)("reportdate").ToString()) & "' and reportype='arrival'" : rst = com.ExecuteReader
            While rst.Read

                For Each arr In roomtypeSettings
                    arival += "<td align='center'>" & rst(arr).ToString & "</td>"
                Next
                a_tf += "<td align='center' style='background-color:Red;color:White'>" & rst("pax").ToString & "</td>"
            End While
            rst.Close()

            'departure
            com.CommandText = "select * from tempforecast where reportdate='" & ConvertDate(st.Tables(0).Rows(nt)("reportdate").ToString()) & "' and reportype='departure'" : rst = com.ExecuteReader
            While rst.Read
                For Each arr In roomtypeSettings
                    departure += "<td align='center'>" & rst(arr).ToString & "</td>"
                Next
                d_tf += "<td align='center' style='background-color:Red;color:White'>" & rst("pax").ToString & "</td>"
            End While
            rst.Close()

            'inhouse
            com.CommandText = "select * from tempforecast where reportdate='" & ConvertDate(st.Tables(0).Rows(nt)("reportdate").ToString()) & "' and reportype='inhouse'" : rst = com.ExecuteReader
            While rst.Read
                For Each arr In roomtypeSettings
                    inhouse += "<td align='center'>" & rst(arr).ToString & "</td>"
                Next
                i_tf += "<td align='center' style='background-color:Red;color:White'>" & rst("pax").ToString & "</td>"
            End While
            rst.Close()

            rowfooter = "</tr>"
            fullrow += rowHeader + arival + a_tf + departure + d_tf + inhouse + i_tf + lastColumn + rowfooter
        Next
        Dim ForcastRoomSummary As String = ""
        TableTransaction = tableHeader + columnHeader + fullrow + "</table>"
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", "FORECAST SUMMARY REPORT</br><h3> " & title & " </h3>"), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToString("MM/dd/yyyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dt]", Now), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[fromdate]", CDate(datefrom).ToString("MM/dd/yyyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[todate]", CDate(dateto).ToString("MM/dd/yyyy")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub AutoServicesAgreement(ByVal clienname As String, ByVal clientaddress As String, ByVal clienttelephone As String, ByVal carmodel As String, ByVal platenumber As String, ByVal odometer As String, ByVal mechanics As String, ByVal recomendation As String, ByVal refnumber As String, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        'CreateHTMLReportTemplate("AutoServicesAgreement.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\AutoServicesAgreement.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\Auto Services\" & refnumber & ".html"
        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\Auto Services") = True Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\Auto Services")
        End If
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        TableTransaction = TableHead + TableRow + TableFooter
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company name]", UCase(GlobalOrganizationName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company address]", GlobalOrganizationAddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company number]", GlobalOrganizationContactNumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", Globalclientjournaltitle), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", clienname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", clientaddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client telephone]", clienttelephone), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reference]", refnumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[car model]", carmodel), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[plate number]", platenumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mileage]", odometer), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mechanics]", mechanics), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[recomendation]", recomendation.Replace(vbCrLf, "<br/>")), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared name]", If(globalAssistantFullName = "", UCase(globalfullname), UCase(globalAssistantFullName))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", If(globalAssistantFullName = "", UCase(globalposition), qrysingledata("designation", "designation", "tblaccounts where accountid='" & globalAssistantUserId & "'"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated by]", UCase(GlobalApproverName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated position]", UCase(GlobalApproverPosition)), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub AutoServicesClosed(ByVal clienname As String, ByVal clientaddress As String, ByVal clienttelephone As String, ByVal carmodel As String, ByVal platenumber As String, ByVal odometer As String, ByVal mechanics As String, ByVal recomendation As String, ByVal refnumber As String, ByVal form As Form)
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableServiceTransaction As String = "" : Dim TablePartsTransaction As String = "" : Dim Total As Double = 0
        'CreateHTMLReportTemplate("AutoServicesClosed.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\AutoServicesClosed.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\Auto Services\" & refnumber & ".html"
        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\Auto Services") = True Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\Auto Services")
        End If
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company name]", UCase(GlobalOrganizationName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company address]", GlobalOrganizationAddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[company number]", GlobalOrganizationContactNumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", Globalclientjournaltitle), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", clienname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", clientaddress), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client telephone]", clienttelephone), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reference]", refnumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[car model]", carmodel), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[plate number]", platenumber), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mileage]", odometer), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mechanics]", mechanics), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[recomendation]", recomendation.Replace(vbCrLf, "<br/>")), False)

        'Create services transaction
        TableHead = "" : TableRow = "" : TableFooter = "" : Total = 0
        TableHead = "<table border='1'> " _
                            + " <tr> " _
                                + " <td colspan='4'><b>Job order transaction</b></td> " _
                            + " </tr> " & Chr(13) _
                            + " <tr> " _
                                + " <th>Quantity</th> " _
                                + " <th>Particular</th> " _
                                + " <th>Unit Cost</th> " _
                                + " <th>Total</th> " _
                            + " </tr> " & Chr(13)

        com.CommandText = "Select tblsalestransaction.*,sum(quantity) as 'totalquantity', sum(total) as 'totaltrn' from tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode " _
                                + " where tblsalesautotransaction.trncode='" & refnumber & "' and cancelled=0 and void=0 and forcontract=1 group by tblsalestransaction.productid" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("totalquantity").ToString & "</td> " _
                           + " <td width='400'>" & rst("productname").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("sellprice").ToString, 2) & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("totaltrn").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            Total = Total + rst("total")
        End While
        rst.Close()

        TableRow += "<tr><td align='right' colspan='3'>Total</td><td align='right'><strong>" & FormatNumber(Total, 2) & "</strong></td></tr> " & Chr(13)
        TableFooter = "</table>"
        TableServiceTransaction = TableHead + TableRow + TableFooter
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction_services]", TableServiceTransaction), False)

        If countqry("tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode", "tblsalesautotransaction.trncode='" & refnumber & "' and cancelled=0 and void=0 and forcontract=0") > 0 Then
            'Create parts transaction
            TableHead = "" : TableRow = "" : TableFooter = "" : Total = 0
            TableHead = "<table border='1'> " _
                                + " <tr> " _
                                    + " <td colspan='5'><b>Parts installed transaction</b></td> " _
                                + " </tr> " & Chr(13) _
                                + " <tr> " _
                                    + " <th>Quantity</th> " _
                                    + " <th>Unit</th> " _
                                    + " <th>Particular</th> " _
                                    + " <th>Unit Cost</th> " _
                                    + " <th>Total</th> " _
                                + " </tr> " & Chr(13)

            com.CommandText = "Select tblsalestransaction.*,sum(quantity) as 'totalquantity', sum(total) as 'totaltrn' from tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                    + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode " _
                                    + " where tblsalesautotransaction.trncode='" & refnumber & "' and cancelled=0 and void=0 and forcontract=0 group by tblsalestransaction.productid" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr> " _
                               + " <td align='center'>" & rst("totalquantity").ToString & "</td> " _
                               + " <td align='center'>" & rst("unit").ToString & "</td> " _
                               + " <td width='400'>" & rst("productname").ToString & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("sellprice").ToString, 2) & "</td> " _
                               + " <td align='right'>" & FormatNumber(rst("totaltrn").ToString, 2) & "</td> " _
                         + " </tr> " & Chr(13)
                Total = Total + rst("total")
            End While
            rst.Close()

            TableRow += "<tr><td align='right' colspan='4'>Total</td><td align='right'><strong>" & FormatNumber(Total, 2) & "</strong></td></tr> " & Chr(13)
            TableFooter = "</table>"
            TablePartsTransaction = TableHead + TableRow + TableFooter
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction_parts]", TablePartsTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared name]", If(globalAssistantFullName = "", UCase(globalfullname), UCase(globalAssistantFullName))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", If(globalAssistantFullName = "", UCase(globalposition), qrysingledata("designation", "designation", "tblaccounts where accountid='" & globalAssistantUserId & "'"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated by]", UCase(GlobalApproverName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[validated position]", UCase(GlobalApproverPosition)), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintLXReceipt(ByVal location As String, ByVal form As Form)
        Dim printProcess As New Diagnostics.ProcessStartInfo()
        printProcess.FileName = location
        Try
            Process.Start(printProcess)
            ' form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!",
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Public Function GetQuantitySpace(ByVal value As String) As String
        GetQuantitySpace = ""
        Dim ttlquan As String = value
        If ttlquan.Length = 1 Then
            ttlquan = "   " & ttlquan
        ElseIf ttlquan.Length = 2 Then
            ttlquan = "  " & ttlquan
        ElseIf ttlquan.Length = 3 Then
            ttlquan = " " & ttlquan
        Else
            ttlquan = ttlquan
        End If
        Return ttlquan
    End Function

End Module

