Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Module MailService
    Public Function FormattingEmailBody(ByVal value As String) As String
        'value = value.Replace(vbCrLf, "<br/>")
        value = value.Replace(vbCr, "")
        value = value.Replace("Ñ", "&Ntilde;")
        value = value.Replace("ñ", "&ntilde;")
        value = value.Replace("  -  ", "&nbsp; &nbsp; - &nbsp; &nbsp;")
        Return value
    End Function

    Public Sub InsertEmailNotification(ByVal trntype As String, ByVal receiver As String, ByVal subject As String, emailbody As String, ByVal message As String)
        If receiver.Length > 5 Then
            com.CommandText = "insert into tblemailnotification set trntype='" & trntype & "',receiver='" & receiver & "', subject='" & Trim(rchar(subject)) & "', emailbody='" & EncryptTripleDES(FormattingEmailBody(emailbody & "<br/><br/>" & message & "<br/><br/><br/><b>" + globalfullname + "</b><br/>" + globalposition + "<br/>" + globalEmailaddress + "<br/><br/>" _
                                 + "<em color=""grey"">*This is a coffeecup system generated email and use for notification only. To view full transaction, please login on coffeecup system. thank you*</em>")) & "'" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub InsertEmailSalesBlotter(ByVal trntype As String, ByVal receiver As String, ByVal subject As String, emailbody As String, ByVal message As String)
        If receiver.Length > 5 Then
            com.CommandText = "insert into tblemailnotification set trntype='" & trntype & "',receiver='" & receiver & "', subject='" & Trim(rchar(subject)) & "', emailbody='" & EncryptTripleDES(FormattingEmailBody(emailbody)) & "'" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub InsertEmailNotificationClient(ByVal trntype As String, ByVal receiver As String, ByVal subject As String, emailbody As String)
        If receiver.Length > 5 Then
            com.CommandText = "insert into tblemailnotification set trntype='" & trntype & "',receiver='" & receiver & "',replyto='" & If(GlobalOrganizationEmail = "", "", GlobalOrganizationEmail) & "', subject='" & Trim(rchar(subject)) & "', emailbody='" & EncryptTripleDES(FormattingEmailBody(emailbody)) & "'" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Function getEmailAccount(ByVal userid As String) As String
        getEmailAccount = qrysingledata("emailaddress", "emailaddress", "tblaccounts where accountid='" & userid & "'")
        Return getEmailAccount
    End Function

    Public Function getOfficeEmail(ByVal officeid As String) As String
        getOfficeEmail = qrysingledata("officeemail", "officeemail", "tblcompoffice where officeid='" & officeid & "'")
        Return getOfficeEmail
    End Function


    Public Function FormatingEmailRequisition(ByVal pid As String, ByVal RequestTitle As String) As String
        Dim rowRowTable As String = ""
        FormatingEmailRequisition = ""
        com.CommandText = "select *, " _
                    + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as 'office', " _
                    + " (select fullname from tblaccounts where accountid = tblrequisitions.requestby) as 'requester' , " _
                    + " (select DESCRIPTION from tblrequesttype where potypeid=tblrequisitions.potypeid) as 'RequestType', " _
                    + " date_format(DATEREQUEST,'%Y-%m-%d %r') as 'DateRequest', " _
                    + " case when corporatelevel=1 then 'CORPORATE LEVEL' else 'BRANCH LEVEL ' end as 'approvinglevel', " _
                    + " (select fullname from tblhotelguest where guestid=tblrequisitions.allocatedexpense) as allocated, " _
                    + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'TotalAmount' " _
                    + " from tblrequisitions where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            FormatingEmailRequisition = "Requisition #: " & rst("pid").ToString _
                           + "<br/>Office: " & rst("office").ToString _
                           + "<br/>Request By: " & rst("requester").ToString _
                           + "<br/>Request Type: " & rst("RequestType").ToString _
                           + "<br/>Date Request: " & rst("DateRequest").ToString _
                           + "<br/>Allocated Expense: " & rst("allocated").ToString _
                           + "<br/>Approving Level: " & rst("approvinglevel").ToString _
                           + "<br/>Total Amount: " & FormatNumber(rst("TotalAmount").ToString, 2) _
                           + "<br/>Request Justification: " & rst("details").ToString _
                           + "<br/>" _
                           + "<br/>Transaction Details: " & RequestTitle & "" _
                           + "<br/>Reference #: " & rst("trnrefno").ToString & "" _
                           + "<br/><br/>"
        End While
        rst.Close()

        FormatingEmailRequisition += "<table " & If(compkb = "1", "", "border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'") & " > " _
                                        + " <tr> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Particular</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Category</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Quantity</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Unit</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Unit Cost</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Total Cost</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Remarks</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Vendor</th> " _
                                        + " </tr>"

        com.CommandText = "Select  *, (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionsitem.CATID ) as 'Category', " _
                                + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
                                + " from tblrequisitionsitem " _
                                + " where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("Particular").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("Category").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='center'>" & rst("QUANTITY").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='center'>" & rst("UNIT").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='right'>" & FormatNumber(rst("COST").ToString, 2) & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='right'>" & FormatNumber(rst("TOTAL").ToString, 2) & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("Remarks").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("Vendor").ToString & "</td> " _
                                       + " </tr>"
        End While
        rst.Close()
        FormatingEmailRequisition += rowRowTable + "</table>"
        Return FormatingEmailRequisition
    End Function

    Public Function FormatingEmailPurchaseOrder(ByVal ponumber As String) As String
        Dim rowRowTable As String = ""
        FormatingEmailPurchaseOrder = ""

        com.CommandText = "select *, (select officename from tblcompoffice where officeid =tblpurchaseorder.officeid ) as 'office', " _
                                 + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                                 + " (select sum(total) from tblpurchaseorderitem where ponumber=tblpurchaseorder.ponumber) as 'Total' " _
                                 + " from tblpurchaseorder where ponumber='" & ponumber & "'" : rst = com.ExecuteReader
        While rst.Read
            FormatingEmailPurchaseOrder = "<br/>PO NUmber: " & ponumber _
                           + "<br/>Office: " & rst("office").ToString _
                           + "<br/>Supplier: " & rst("Supplier").ToString _
                           + "<br/>Total Amount: " & FormatNumber(rst("Total").ToString, 2) _
                           + "<br/>" _
                           + "<br/>Request Reference #: " & rst("requestref").ToString _
                           + "<br/><br/>"
        End While
        rst.Close()
        FormatingEmailPurchaseOrder += "<table " & If(compkb = "1", "", "border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'") & " > " _
                                        + " <tr> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Particular</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Category</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Quantity</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Unit</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Unit Cost</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Total Cost</th> " _
                                            + " <th style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>Remarks</th> " _
                                        + " </tr>"

        com.CommandText = "Select *,(select description from tblprocategory where CATID = tblpurchaseorderitem.catid) as category from tblpurchaseorderitem where ponumber='" & ponumber & "'" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("itemname").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("category").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='center'>" & rst("quantity").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='center'>" & rst("unit").ToString & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='right'>" & FormatNumber(rst("cost").ToString, 2) & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "' align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                                           + " <td style='" & If(compkb = "1", "border: 1px solid black; padding: 0 5px", "padding: 0 5px") & "'>" & rst("remarks").ToString & "</td> " _
                                       + " </tr>"
        End While
        rst.Close()
        FormatingEmailPurchaseOrder += rowRowTable + "</table>"
        Return FormatingEmailPurchaseOrder
    End Function

    Public Function FormatingEmailAccountsPayable(ByVal voucherno As String) As String
        Dim rowRowTable As String = ""
        FormatingEmailAccountsPayable = ""
        Dim ca As Boolean = False
        com.CommandText = "select *,(select officename from tblcompoffice where officeid =tbldisbursementvoucher.officeid ) as 'office', " _
                                 + " if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Supplier', " _
                                 + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as fund " _
                                 + " from tbldisbursementvoucher where voucherno='" & voucherno & "'" : rst = com.ExecuteReader
        While rst.Read
            ca = CBool(rst("ca"))
            FormatingEmailAccountsPayable = "<br/>Request No: " & voucherno _
                           + "<br/>Office: " & rst("office").ToString _
                           + "<br/>Claimant: " & rst("Supplier").ToString _
                           + "<br/>Total Amount: " & FormatNumber(rst("amount").ToString, 2) _
                           + "<br/>Source of Fund: " & rst("fund").ToString _
                           + "<br/>Note: " & rst("note").ToString _
                           + "<br/><br/>"
        End While
        rst.Close()
        FormatingEmailAccountsPayable += "<table " & If(compkb = "1", "", "border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'") & " > " _
                                        + " <tr> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Date</th> " _
                                            + If(ca = True, " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Supplier</th> ", "") _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>PO Number</th> " _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px'>Note</th> " _
                                            + If(ca = True, "", " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Invoice No.</th> ") _
                                            + " <th style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>Amount</th> " _
                                        + " </tr>"
        Dim Total As Double = 0

        com.CommandText = "select *, date_format(datetrn,'%Y-%m-%d') as 'Date' from tbldisbursementdetails where voucherno='" & voucherno & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("Date").ToString & "</td> " _
                                + If(ca = True, " <td style='border: 1px solid #d1d1d1; padding: 0 5px'>" & StrConv(rst("supplier").ToString, VbStrConv.ProperCase) & "</td> ", "") _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("ponumber").ToString & "</td> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px; width: 300px'>" & rst("note").ToString & "</td> " _
                                + If(ca = True, "", " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("invoiceno").ToString & "</td> ") _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                        + " </tr>"
            Total = Total + Val(rst("amount").ToString)
        End While
        rst.Close()
        com.CommandText = "select *,date_format(datetrn,'%Y-%m-%d') as 'Date',(select itemname from tblglitem where itemcode=tbldisbursementexpense.itemcode) as item from tbldisbursementexpense where voucherno='" & voucherno & "' order by datetrn asc" : rst = com.ExecuteReader
        While rst.Read
            rowRowTable += "<tr> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='center'>" & rst("Date").ToString & "</td> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px; width: 300px' colspan='3'>" & StrConv(rst("item").ToString, VbStrConv.ProperCase) & " - " & rst("remarks").ToString & "</td> " _
                                + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                        + " </tr>"
            Total = Total + Val(rst("amount").ToString)
        End While
        rst.Close()

        rowRowTable += "<tr> " _
                              + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right' colspan='4'>TOTAL</td> " _
                              + " <td style='border: 1px solid #d1d1d1; padding: 0 5px' align='right'>" & FormatNumber(Total, 2) & "</td> " _
                      + " </tr>"
        FormatingEmailAccountsPayable += rowRowTable + "</table>"
        Return FormatingEmailAccountsPayable
    End Function


    Public Function SendServiceAutoOpenReport(ByVal refno As String)
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", "tblaccounts where notifyautoservices=1")
        Dim EmailReports As String = ""
        If EmailList.Length > 0 Then
            dst = New DataSet
            msda = New MySqlDataAdapter("select *, " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as customername, " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as address, " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as contactnumber, " _
                           + " date_format(datetrn, '%M %d, %Y %r') as transactiondate, " _
                           + " date_format(datetrn, '%Y-%m-%d') as trndate " _
                           + " from tblsalesautoservices where trncode='" & refno & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    EmailReports = ""
                    EmailReports = "Service #: " & .Rows(cnt)("trncode").ToString() _
                            + "<br/>Customer Name: " & .Rows(cnt)("customername").ToString() _
                            + "<br/>Address: " & .Rows(cnt)("address").ToString() _
                            + "<br/>Contact Number: " & .Rows(cnt)("contactnumber").ToString() _
                            + "<br/> " _
                            + "<br/>Car Model: " & .Rows(cnt)("carmodel").ToString() _
                            + "<br/>Plate Number: " & .Rows(cnt)("platenumber").ToString() _
                            + "<br/>Mileage: " & .Rows(cnt)("odometer").ToString() _
                            + "<br/>Attending Mechanics: " & .Rows(cnt)("attmechanics").ToString() _
                            + "<br/>Recomendation: " & .Rows(cnt)("recomendation").ToString() _
                            + "<br/><br/>"
                    InsertEmailNotification("SERVICES", EmailList, "New service center customer " & StrConv(.Rows(cnt)("customername").ToString(), vbProperCase), EmailReports, "")
                End With
            Next
        End If
        Return True
    End Function

    Public Function SendServiceAutoClosedReport(ByVal refno As String)
        Dim SalesReports As String = ""
        Dim EmailList As String = qrysingledata("emails", "group_concat(emailaddress) as emails", " tblaccounts where notifyautoservices=1")
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableServiceTransaction As String = "" : Dim TablePartsTransaction As String = "" : Dim Total As Double = 0
        If EmailList.Length > 0 Then
            dst = New DataSet
            msda = New MySqlDataAdapter("select *, " _
                           + " (select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as customername, " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as address, " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as contactnumber, " _
                           + " date_format(datetrn, '%M %d, %Y %r') as transactiondate, " _
                           + " date_format(datetrn, '%Y-%m-%d') as trndate " _
                           + " from tblsalesautoservices where trncode='" & refno & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    SalesReports = ""
                    SalesReports = "Service #: " & .Rows(cnt)("trncode").ToString() _
                            + "<br/>Customer Name: " & .Rows(cnt)("customername").ToString() _
                            + "<br/>Address: " & .Rows(cnt)("address").ToString() _
                            + "<br/>Contact Number: " & .Rows(cnt)("contactnumber").ToString() _
                            + "<br/> " _
                            + "<br/>Car Model: " & .Rows(cnt)("carmodel").ToString() _
                            + "<br/>Plate Number: " & .Rows(cnt)("platenumber").ToString() _
                            + "<br/>Mileage: " & .Rows(cnt)("odometer").ToString() _
                            + "<br/>Attending Mechanics: " & .Rows(cnt)("attmechanics").ToString() _
                            + "<br/><br/>"

                    'Create services transaction
                    TableHead = "" : TableRow = "" : TableFooter = "" : Total = 0
                    TableHead = "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                        + " <tr> " _
                                            + " <td colspan='4' align='center'><b>Job order transaction</b></td> " _
                                        + " </tr> " & Chr(13) _
                                        + " <tr> " _
                                            + " <th>Quantity</th> " _
                                            + " <th>Particular</th> " _
                                            + " <th>Unit Cost</th> " _
                                            + " <th>Total</th> " _
                                        + " </tr> " & Chr(13)

                    com.CommandText = "Select tblsalestransaction.* from tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                            + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode " _
                                            + " where tblsalesautotransaction.trncode='" & .Rows(cnt)("trncode").ToString() & "' and cancelled=0 and void=0 and forcontract=1" : rst = com.ExecuteReader
                    While rst.Read
                        TableRow += "<tr> " _
                                       + " <td align='center'>" & rst("quantity").ToString & "</td> " _
                                       + " <td width='400'>" & rst("productname").ToString & "</td> " _
                                       + " <td align='right'>" & FormatNumber(rst("sellprice").ToString, 2) & "</td> " _
                                       + " <td align='right'>" & FormatNumber(rst("total").ToString, 2) & "</td> " _
                                 + " </tr> " & Chr(13)
                        Total = Total + rst("total")
                    End While
                    rst.Close()

                    TableRow += "<tr><td align='right' colspan='3'>Total</td><td align='right'><strong>" & FormatNumber(Total, 2) & "</strong></td></tr> " & Chr(13)
                    TableFooter = "</table>"
                    TableServiceTransaction = TableHead + TableRow + TableFooter


                    'Create parts transaction
                    TableHead = "" : TableRow = "" : TableFooter = "" : Total = 0
                    TableHead = "<table border='1' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                        + " <tr> " _
                                            + " <td colspan='5' align='center'><b>Parts installed transaction</b></td> " _
                                        + " </tr> " & Chr(13) _
                                        + " <tr> " _
                                            + " <th>Quantity</th> " _
                                            + " <th>Unit</th> " _
                                            + " <th>Particular</th> " _
                                            + " <th>Unit Cost</th> " _
                                            + " <th>Total</th> " _
                                        + " </tr> " & Chr(13)

                    com.CommandText = "Select tblsalestransaction.* from tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                            + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode " _
                                            + " where tblsalesautotransaction.trncode='" & .Rows(cnt)("trncode").ToString() & "' and cancelled=0 and void=0 and forcontract=0" : rst = com.ExecuteReader
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

                    TableRow += "<tr><td align='right' colspan='4'>Total</td><td align='right'><strong>" & FormatNumber(Total, 2) & "</strong></td></tr> " & Chr(13)
                    TableFooter = "</table>"
                    TablePartsTransaction = TableHead + TableRow + TableFooter
                    SalesReports += TableServiceTransaction + "<br/>" + TablePartsTransaction + "<br/><br/>"
                    InsertEmailNotification("SERVICES", EmailList, "Closed service center customer " & StrConv(.Rows(cnt)("customername").ToString(), vbProperCase), SalesReports, "")
                End With
            Next
        End If
        Return True
    End Function

End Module
