Imports System.IO
Imports MySql.Data.MySqlClient

Module POSmodule
    Public Function GetDiscountValue(ByVal cifid As String, ByVal cifgroup As String, ByVal catid As String, ByVal productid As String, ByVal sellingprice As Double, ByVal totalamount As Double)
        Dim strTotalDiscount As Double = 0
        'check the default client discount
       
        If countqry("tblclientdiscounts", "catid='" & catid & "' and cifid='" & cifgroup & "'") > 0 Then
            'check discount if the product discount are affect to the client
            If countqry("tblproductdiscounts", "productid='" & productid & "' and affectclient=1") > 0 Then
                'processesing default product discount
                com.CommandText = "select * from tblproductdiscounts where productid='" & productid & "'" : rst = com.ExecuteReader()
                While rst.Read
                    If rst("incondition") = True Then
                        If Val(totalamount) >= Val(rst("amount").ToString) Then
                            If LCase(rst("discounttype").ToString) = "percent" Then
                                strTotalDiscount = (Val(rst("discountrate").ToString) / 100) * sellingprice
                            Else
                                strTotalDiscount = rst("discountrate").ToString
                            End If
                        End If
                    Else
                        If LCase(rst("discounttype").ToString) = "percent" Then
                            strTotalDiscount = (Val(rst("discountrate").ToString) / 100) * sellingprice
                        Else
                            strTotalDiscount = rst("discountrate").ToString
                        End If
                    End If
                End While
                rst.Close()
            Else
                'processesing client product discount
                com.CommandText = "select * from tblclientdiscounts where catid='" & catid & "' and cifid='" & cifgroup & "'" : rst = com.ExecuteReader()
                While rst.Read
                    If LCase(rst("discounttype").ToString) = "percent" Then
                        strTotalDiscount = (Val(rst("discountrate").ToString) / 100) * sellingprice
                    Else
                        strTotalDiscount = rst("discountrate").ToString
                    End If
                End While
                rst.Close()
            End If
        Else
            If countqry("tblclientaccounts", "cifid='" & cifid & "' and walkinaccount=1") = 0 Then
                If countqry("tblproductdiscounts", "productid='" & productid & "'") > 0 Then
                    'processesing client product discount
                    com.CommandText = "select * from tblproductdiscounts where productid='" & productid & "'" : rst = com.ExecuteReader()
                    While rst.Read
                        If rst("incondition") = True Then
                            If Val(totalamount) >= Val(rst("amount").ToString) Then
                                If LCase(rst("discounttype").ToString) = "percent" Then
                                    strTotalDiscount = (Val(rst("discountrate").ToString) / 100) * sellingprice
                                Else
                                    strTotalDiscount = rst("discountrate").ToString
                                End If
                            End If
                        Else
                            If LCase(rst("discounttype").ToString) = "percent" Then
                                strTotalDiscount = (Val(rst("discountrate").ToString) / 100) * sellingprice
                            Else
                                strTotalDiscount = rst("discountrate").ToString
                            End If
                        End If
                    End While
                    rst.Close()
                End If
            End If
        End If
        Return strTotalDiscount
    End Function

    Public Function GetChargeValue(ByVal catid As String, ByVal sellingprice As Double)
        Dim strTotalCharges As Double = 0
        'check the default client discount
        If countqry("tblclientcharges", "catid='" & catid & "'  and enable=1") > 0 Then
            'processesing client product charges
            com.CommandText = "select * from tblclientcharges inner join tblproductchargesfilter on tblclientcharges.chargesid=tblproductchargesfilter.chargesid where officeid='" & compOfficeid & "' and catid='" & catid & "' and enable=1" : rst = com.ExecuteReader()
            While rst.Read
                If LCase(rst("chargestype").ToString) = "percent" Then
                    strTotalCharges += (Val(rst("chargesrate").ToString) / 100) * sellingprice
                Else
                    strTotalCharges += rst("chargesrate").ToString
                End If
            End While
            rst.Close()
        End If
        Return strTotalCharges
    End Function

    Public Function ReadFile(ByVal path As String)
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        Return oReader.ReadToEnd
    End Function

    Public Function VoidBatchSalesTransaction(ByVal batchcode As String, ByVal reason As String, ByVal voidby As String)
        RollBackInventory(batchcode)


        If qrysingledata("seriesno", "seriesno", "tblsalesbatch where  batchcode='" & batchcode & "'") = "" Then
            Dim seriesno As String = GetPOSSeriesNumber(compOfficeid)
            com.CommandText = "update tblsalesbatch set seriesno='" & seriesno & "', void=1,floattrn=0,voidby='" & voidby & "',voidreason='" & rchar(reason) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblsalesbatch set void=1,floattrn=0,voidby='" & voidby & "',voidreason='" & rchar(reason) & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        End If

        com.CommandText = "update tblsalestransaction set void=1, voidby='" & voidby & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "update tblsalesclientcharges set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesclientchargesitem set cancelled=1, cancelledby='" & voidby & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "update tblhoteltransaction set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsaleschecktransaction set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescardtransaction set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesdepositpaymenttransaction set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalespaymentvoucher set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesticketpaymenttransaction set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "update tblsalescashpayment set cancelled=1,cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblglaccountledger set cancelled=1, cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescoupon set cancelled=1, cancelledby='" & voidby & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescoupon set verified=0, verifiedby='', verifiedoffice=0, dateverified=null, verifiedoffice='',verifiedbatchcode='',verifiedtrnsumcode='' where verifiedbatchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesproductcustomorder set void=1 where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesinteroffice set cancelled=1 where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "UPDATE tblhotelfoliotransaction set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where referenceno='" & batchcode & "' and chargefrompos=1" : com.ExecuteNonQuery()
        com.CommandText = "update tblsaleschitbatch set void=1, voidby='" & voidby & "' where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        Return 0
    End Function
    Public Function DeleteBatchSalesTransaction(ByVal batchcode As String)
        RollBackInventory(batchcode)
        com.CommandText = "DELETE from tblsalesbatch where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalestransaction where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "DELETE from tblsalesclientcharges where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalesclientchargesitem  where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "DELETE from tblhoteltransaction where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsaleschecktransaction where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalescardtransaction where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalesdepositpaymenttransaction where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalespaymentvoucher where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalesticketpaymenttransaction where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "DELETE from tblsalescashpayment where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblglaccountledger where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalescoupon where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalescoupon where verifiedbatchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalesproductcustomorder where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalesinteroffice where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsaleschitbatch where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

    Public Function VoidForReviseTransaction(ByVal batchcode As String)
        com.CommandText = "DELETE FROM tblsalesclientcharges where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tblsalesclientchargesitem where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "DELETE FROM tblsaleschecktransaction where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tblsalescardtransaction where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tblsalesdepositpaymenttransaction where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tblsalespaymentvoucher where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tblsalesticketpaymenttransaction where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        com.CommandText = "DELETE FROM tblsalescashpayment where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tblglaccountledger where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()

        Return 0
    End Function

    Public Function CancelPaymentTransaction(ByVal batchcode As String)
        com.CommandText = "update tblsaleschecktransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescardtransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesdepositpaymenttransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalespaymentvoucher set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesticketpaymenttransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescashpayment set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

    Public Function CancelNonCashTransaction(ByVal batchcode As String)
        com.CommandText = "update tblsaleschecktransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalescardtransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where referenceno='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesdepositpaymenttransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalespaymentvoucher set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        com.CommandText = "update tblsalesticketpaymenttransaction set cancelled=1,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "',datecancelled=current_timestamp where batchcode='" & batchcode & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

    Public Function RollBackInventory(ByVal batchcode As String)
        msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblsalestransaction where batchcode='" & batchcode & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                'Filter if the product is fuel
                Dim FuelProduct As Boolean = False
                If countqry("tblsalesfuelpump", "productid = '" & .Rows(cnt)("productid").ToString() & "'") > 0 Then
                    FuelProduct = True
                End If

                'Filter if the product is contract

                '#update inventory
                If FuelProduct = False And CBool(.Rows(cnt)("inventory").ToString()) = True Then
                    StockinInventory("POS Void", .Rows(cnt)("inventorytrnid").ToString(), compOfficeid, .Rows(cnt)("productid").ToString(), .Rows(cnt)("quantity").ToString(), .Rows(cnt)("purchasedprice").ToString(), "transaction void #" + batchcode, "", batchcode, "")
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
                            StockinInventory("POS Void", st.Tables(0).Rows(nt)("stockno").ToString(), compOfficeid, st.Tables(0).Rows(nt)("productid").ToString(), st.Tables(0).Rows(nt)("quantity").ToString(), st.Tables(0).Rows(nt)("purchasedprice").ToString(), "transaction void #" + batchcode, "", batchcode, "")
                            com.CommandText = "UPDATE tblsalesmenumakerstockout set void=1 where id='" & st.Tables(0).Rows(nt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Next
                    End If
                End If
            End With
        Next
        Return 0
    End Function

    Public Sub CouponCheck(ByVal trntype As String, ByVal referenceno As String, ByVal productid As String, ByVal quantity As Integer, ByVal coupondate As String)
        Dim enableofficecenter As Boolean = False : Dim officecenter As String = "" : Dim enableCoupon As Boolean = False : Dim unit As String = "" : Dim sellprice As Double = 0
        Dim MenumakerService As Boolean = False
        com.CommandText = "select * from tblglobalproducts where productid='" & productid & "' limit 1" : rst = com.ExecuteReader
        While rst.Read
            enableofficecenter = rst("enablecenter")
            officecenter = rst("officecenter").ToString
            enableCoupon = rst("enablecoupon")
            unit = rst("unit").ToString
            sellprice = rst("sellingprice")
            MenumakerService = rst("servicemenuproduct")
        End While
        rst.Close()

        If enableCoupon = True Then
            If officecenter <> compOfficeid Then
                InsertProductCoupon(trntype, referenceno, If(enableofficecenter = True, officecenter, compOfficeid), productid, quantity, unit, sellprice * quantity, sellprice, coupondate)
            End If
        End If

        If MenumakerService = True Then
            coupon_adapter = Nothing : coupon_dst = New DataSet
            coupon_adapter = New MySqlDataAdapter("select *,(select itemname from tblglobalproducts where productid=tblproductserviceitem.productid) as 'itemname', " _
                                      + " ifnull((select enablecoupon from tblglobalproducts where productid=tblproductserviceitem.productid),0) as enablecoupon, " _
                                      + " (select unit from tblglobalproducts where productid=tblproductserviceitem.productid) as unit, " _
                                      + " (select officecenter from tblglobalproducts where productid=tblproductserviceitem.productid) as officecenter " _
                                      + " from tblproductserviceitem where source_productid='" & productid & "'", conn)
            coupon_adapter.Fill(coupon_dst, 0)
            For nt = 0 To coupon_dst.Tables(0).Rows.Count - 1
                If CBool(coupon_dst.Tables(0).Rows(nt)("enablecoupon").ToString()) = True Then
                    InsertProductCoupon(trntype, referenceno, If(coupon_dst.Tables(0).Rows(nt)("officecenter").ToString() = "", compOfficeid, coupon_dst.Tables(0).Rows(nt)("officecenter").ToString()), coupon_dst.Tables(0).Rows(nt)("productid").ToString(), Val(quantity), coupon_dst.Tables(0).Rows(nt)("unit").ToString(), coupon_dst.Tables(0).Rows(nt)("amount").ToString(), Val(coupon_dst.Tables(0).Rows(nt)("amount").ToString()) * Val(quantity), coupondate)
                End If
            Next
        End If
    End Sub

    Public Sub Coupon(ByVal folio As String)
        If countqry("tblsalescoupon", "batchcode='" & folio & "' and cancelled=0") > 0 Then
            Dim CouponList As String = ""
            com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product from tblsalescoupon where batchcode='" & folio & "' and cancelled=0" : rst = com.ExecuteReader
            While rst.Read
                CouponList += rst("couponcode").ToString & " - " & rst("product") & vbTab & FormatNumber(Val(rst("total").ToString), 2).ToString & Environment.NewLine
            End While
            rst.Close()
            If MessageBox.Show("Your transaction contains coupon! Do you want to print coupon ticket?" & Environment.NewLine & Environment.NewLine & CouponList, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                PrintCoupon(folio)
            End If
        End If
    End Sub

    Public Sub InsertProductCoupon(ByVal trntype As String, ByVal batchcode As String, ByVal centerofficeid As String, ByVal productid As String, ByVal quantity As Double, ByVal unit As String, ByVal unitprice As String, ByVal total As String, ByVal coupondate As String)
        com.CommandText = "insert into tblsalescoupon set couponcode='" & getCouponSequence() & "', trntype ='" & trntype & "', trnsumcode='" & globalSalesTrnCOde & "', batchcode='" & batchcode & "', trnofficeid='" & compOfficeid & "', centerofficeid='" & centerofficeid & "', productid='" & productid & "', quantity='" & quantity & "', unit='" & unit & "', unitprice='" & unitprice & "', total='" & total & "',coupondate='" & ConvertDate(coupondate) & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
    End Sub

    Public Function getPOSBatchCode()
        Dim strng As Integer = 0 : Dim newBatch As String = ""
        If CInt(countrecord("tblsalesbatchsequence")) = 0 Then
            MsgBox("Transaction Batch Not Set please contact your system administrator")
            Return False
        Else
            com.CommandText = "select batchcode from tblsalesbatchsequence" : rst = com.ExecuteReader()
            While rst.Read
                strng = Val(rst("batchcode").ToString) + 1
            End While
            rst.Close()
        End If
        com.CommandText = "UPDATE tblsalesbatchsequence set batchcode='" & strng & "'" : com.ExecuteNonQuery()
        newBatch = strng.ToString
        Return newBatch
    End Function

    Public Function getPOSChargeInvoiceSecquence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GLobalchargeinvoicessequence = True Then
            com.CommandText = "select chargeinvoicessequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("chargeinvoicessequence").ToString.Length
                strng = Val(rst("chargeinvoicessequence").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
            End If
        End If
        Return newNumber
    End Function

    Public Function getStockTransferSequenceNo()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select stocktransfersequence from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("stocktransfersequence").ToString.Length
            strng = Val(rst("stocktransfersequence").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set stocktransfersequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getStockRequestTransferSequenceNo()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select stockrequestsequence from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("stockrequestsequence").ToString.Length
            strng = Val(rst("stockrequestsequence").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set stockrequestsequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function


    Public Function getPOSClientJournalSecquence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GLobalclientjournalsequence = True Then
            com.CommandText = "select clientjournalsequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("clientjournalsequence").ToString.Length
                strng = Val(rst("clientjournalsequence").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
            End If
        End If
        Return newNumber
    End Function

    Public Function getPOSSalesDeliverySequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GLobalsalesdeliverysequence = True Then
            com.CommandText = "select salesdeliverysequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("salesdeliverysequence").ToString.Length
                strng = Val(rst("salesdeliverysequence").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 6 Then
                    newNumber = "000000" & strng
                ElseIf a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
            End If
        End If
        Return newNumber
    End Function

    Public Function getManuMakerSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select menumakerreferenceno from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
            NumberLen = rst("menumakerreferenceno").ToString.Length
            strng = Val(rst("menumakerreferenceno").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 6 Then
                    newNumber = "000000" & strng
                ElseIf a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set menumakerreferenceno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getManuMakerServiceSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select menumakerservicereferenceno from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("menumakerservicereferenceno").ToString.Length
            strng = Val(rst("menumakerservicereferenceno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set menumakerservicereferenceno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getAutoServicesNumberSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GLobalAutoServicesSequence = True Then
            com.CommandText = "select autoservicessequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("autoservicessequence").ToString.Length
                strng = Val(rst("autoservicessequence").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 6 Then
                    newNumber = "000000" & strng
                ElseIf a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
            End If
        End If
        Return newNumber
    End Function

    Public Function getVourcherNumberSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GlobalEnableVouchernumbersequence = True Then
            com.CommandText = "select vouchernosequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("vouchernosequence").ToString.Length
                strng = Val(rst("vouchernosequence").ToString) + 1
            End While
            rst.Close()
            If NumberLen > strng.ToString.Length Then
                Dim a As Integer = NumberLen - strng.ToString.Length
                If a = 6 Then
                    newNumber = "000000" & strng
                ElseIf a = 5 Then
                    newNumber = "00000" & strng
                ElseIf a = 4 Then
                    newNumber = "0000" & strng
                ElseIf a = 3 Then
                    newNumber = "000" & strng
                ElseIf a = 2 Then
                    newNumber = "00" & strng
                ElseIf a = 1 Then
                    newNumber = "0" & strng
                Else
                    newNumber = strng
                End If
            Else
                newNumber = strng
            End If
        End If
        Return newNumber
    End Function

    Public Function getAccountingVoucherSequence(ByVal fieldname As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "CREATE TABLE if not exists `tblsequencevoucher` (`id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT, `batchcode` varchar(20) NOT NULL DEFAULT '00000',  `fieldname` varchar(10) NOT NULL,   PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery()
        If countqry("tblsequencevoucher", "fieldname='" & fieldname & "'") = 0 Then
            com.CommandText = "insert into tblsequencevoucher set batchcode='00000', fieldname='" & fieldname & "'" : com.ExecuteNonQuery()
        End If
        com.CommandText = "select batchcode from tblsequencevoucher where fieldname='" & fieldname & "'" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("batchcode").ToString.Length
            strng = Val(rst("batchcode").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblsequencevoucher set batchcode='" & newNumber & "' where fieldname='" & fieldname & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getStockoutBatchSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select stockoutbatchsequence from tblgeneralsettings" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("stockoutbatchsequence").ToString.Length
            strng = Val(rst("stockoutbatchsequence").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set stockoutbatchsequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getDuetoSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select duetosequenceno from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("duetosequenceno").ToString.Length
            strng = Val(rst("duetosequenceno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set duetosequenceno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getCouponSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select couponseriesno from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("couponseriesno").ToString.Length
            strng = Val(rst("couponseriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set couponseriesno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function GetBIRORNumber()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select bir_or_number from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("bir_or_number").ToString.Length
            strng = Val(rst("bir_or_number").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set bir_or_number='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function GetRRNumber()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select rrnumberseries from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("rrnumberseries").ToString.Length
            strng = Val(rst("rrnumberseries").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblgeneralsettings set rrnumberseries='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function GetPOSSeriesNumber(ByVal officeid As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If countqry("tblsalesposseries", "officeid='" & officeid & "'") = 0 Then
            com.CommandText = "insert into tblsalesposseries set officeid='" & officeid & "', seriesno='0000'" : com.ExecuteNonQuery()
        End If
        com.CommandText = "select seriesno from tblsalesposseries where officeid='" & officeid & "'" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblsalesposseries set seriesno='" & newNumber & "' where officeid='" & officeid & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function EncrypGridColumnNumbers(ByVal ColumnValue As String, ByVal ColumnName As String) As String
        If GlobalEnableEncryptNumbers = True Then
            EncrypGridColumnNumbers = ", replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(cast(format(" & ColumnValue & ",2) as char(200)),'1','" & GlobalEncrptVal1 & "'),'2','" & GlobalEncrptVal2 & "'),'3','" & GlobalEncrptVal3 & "'),'4','" & GlobalEncrptVal4 & "'),'5','" & GlobalEncrptVal5 & "'),'6','" & GlobalEncrptVal6 & "'),'7','" & GlobalEncrptVal7 & "'),'8','" & GlobalEncrptVal8 & "'),'9','" & GlobalEncrptVal9 & "'),'0','" & GlobalEncrptVal0 & "') as '" & ColumnName & "' "
        Else
            EncrypGridColumnNumbers = ""
        End If
        Return EncrypGridColumnNumbers
    End Function
End Module
