Module Procurement
    Public Sub PrintLiquidationReport(ByVal vouchercode As String, ByVal form As Form, ByVal PrintFile As Boolean)
        Dim TableRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DisbursementLiquidation.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\LIQUIDITION\" & vouchercode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        Dim supplierid As String = "" : Dim ca As Boolean = False
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center'><img  style='float: left' src='" & Application.StartupPath.ToString & "\Logo\logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        com.CommandText = "select *,(select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company', date_format(voucherdate,'%M %d, %Y') as trndate,date_format(dateliquidated,'%M %d, %Y') as dateliquidate from tbldisbursementvoucher where voucherno='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            supplierid = rst("vendorid").ToString : ca = CBool(rst("ca").ToString)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[companyname]", rst("Company").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", rst("dateliquidate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_voucher]", FormatNumber(Val(rst("amount").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_spent]", FormatNumber(Val(rst("amountspend").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_refund]", FormatNumber(Val(rst("amountrefunded").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amount_reimbursed]", FormatNumber(Val(rst("amountreimbursed").ToString), 2)), False)
        End While
        rst.Close()

        'supplier
        If ca = True Then
            com.CommandText = "select *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office from tblaccounts where accountid='" & supplierid & "'" : rst = com.ExecuteReader
            While rst.Read
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[claimant]", rst("fullname").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position]", rst("designation").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[department]", rst("office").ToString), False)
            End While
            rst.Close()
        End If


        'Voucher Item
        TableRow = "" : Dim total As Double = 0 : Dim cnt As Integer = 0
        TableRow += "<tr> " _
                    + " <td style='padding: 5px' align='center' width='15%'><b>Date</b></td> " _
                    + " <td style='padding: 5px' align='center' ><b>Supplier</b></td>" _
                    + " <td style='padding: 5px' align='center' width='15%'><b>PO Number</b></td> " _
                    + " <td style='padding: 5px' align='center' width='15%'><b>Invoice No</b></td>" _
                    + " <td style='padding: 5px' align='right'  width='18%'><b>Actual Spend</b></td> " _
                + " </tr>"
        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid) as 'Supplier' from tblpurchaseorder where paymentrefnumber='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("date").ToString & "</td> " _
                           + " <td style='padding: 5px'>" & StrConv(rst("Supplier").ToString, VbStrConv.ProperCase) & "</td>" _
                           + " <td align='center'>" & rst("ponumber").ToString & "</td> " _
                           + " <td align='center'>" & rst("invoiceno").ToString & "</td>" _
                           + " <td align='right'>" & FormatNumber(rst("totalamount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("totalamount").ToString)
            cnt += 1
        End While
        rst.Close()

        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode) as item from tbldisbursementexpense where voucherno='" & vouchercode & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("date").ToString & "</td> " _
                          + " <td style='padding: 5px' colspan='2'>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & " - " & rst("remarks").ToString & "</td>" _
                           + " <td align='center'>" & rst("invoiceno").ToString & "</td> " _
                           + " <td align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("amount").ToString)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 6 - cnt
            TableRow += "<tr> " _
                         + " <td style='padding: 5px'>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                   + " </tr> " & Chr(13)
        Next
        TableRow += "<tr> " _
                       + " <td colspan='4' style='padding:10px 5px'><b>" & StrConv(NumToWords(total), VbStrConv.Uppercase) & "</b></td> " _
                       + " <td align='right' style='padding:5px; font-weight:bold;font-size: 14px;'>" & FormatNumber(total, 2) & "</td> " _
                 + " </tr> " & Chr(13)

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)

        If PrintFile = True Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        End If
    End Sub

    Public Sub PrintAccountingDisbursementVoucher(ByVal vouchercode As String, ByVal form As Form)
        Dim PayableROw As String = "" : Dim AccountingRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\DisbursementVoucherAccounting.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\VOUCHER\" & vouchercode & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        com.CommandText = "select *,(select companyname from tblcompany where code=a.companyid) as 'Company',  date_format(voucherdate,'%M %d, %Y') as trndate, " _
            + " (select companyname from tblglobalvendor where vendorid=a.vendorid) as vendor, " _
            + " (select compadd from tblglobalvendor where vendorid=a.vendorid) as address, " _
            + " (select fullname from tblaccounts where accountid=a.trnby) as trnname, " _
            + " (select designation from tblaccounts where accountid=a.trnby) as trnposition " _
            + "  from tbldisbursementvoucher as a where voucherno='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[companyname]", rst("Company").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("vendor").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("address").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[clasification]", If(CBool(rst("check").ToString) = True, "CHECK DISBURSEMENT VOUCHER", "CASH DISBURSEMENT VOUCHER")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalamount]", FormatNumber(Val(rst("amount").ToString), 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amountinwords]", NumToWords(Val(rst("amount").ToString))), False)

            'Prepared Signatories
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(rst("trnname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedposition]", StrConv(rst("trnposition").ToString, VbStrConv.ProperCase)), False)

        End While
        rst.Close()

        'Voucher Item
        PayableROw = "" : Dim cnt As Integer = 0
        com.CommandText = "select *,date_format(datetrn,'%M %d, %Y') as dt from tbldisbursementdetails where voucherno='" & vouchercode & "' order by id asc" : rst = com.ExecuteReader
        While rst.Read
            PayableROw += "<tr><td align='center'>" & rst("dt").ToString & "</td><td>" & rst("description").ToString & "</td><td>" & rst("Note").ToString & "</td><td align='center'>" & rst("invoiceno").ToString & "</td><td align='right'>" & FormatNumber(rst("amount"), 2) & "</td></tr> " & Chr(13)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 10 - cnt
            PayableROw += "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" & Chr(13)
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payable_item]", PayableROw), False)


        'accounting
        Dim cnt2 As Integer = 0
        com.CommandText = "select * from tblgljournalitems where ticketno='" & vouchercode & "' order by id asc" : rst = com.ExecuteReader
        While rst.Read
            AccountingRow += "<tr><td>" & rst("itemname").ToString & "</td><td align='right'>" & FormatNumber(rst("debitamount"), 2) & "</td><td align='right'>" & FormatNumber(rst("creditamount"), 2) & "</td></tr> " & Chr(13)
            cnt2 += 1
        End While
        rst.Close()

        For I = 0 To 3 - cnt2
            AccountingRow += "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" & Chr(13)
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_item]", AccountingRow), False)


        com.CommandText = "SELECT *,left(applevel,1) as level,(select digitalsign from tblaccounts where accountid=a.authorizedid) as signature,(select fullname from tblaccounts where accountid=a.authorizedid) as name, " _
            + " (select designation from tblaccounts where accountid=a.authorizedid) as position FROM `tblapprovermainprocess` as a where apptype='voucher-signatories' and customized=0 order by left(applevel,1) asc;" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvertitle" & rst("level").ToString & "]", rst("apptitle").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approvername" & rst("level").ToString & "]", UCase(rst("name").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approverposition" & rst("level").ToString & "]", StrConv(rst("position").ToString, VbStrConv.ProperCase)), False)
        End While
        rst.Close()

        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub
End Module
