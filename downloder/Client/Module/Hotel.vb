Imports MySql.Data.MySqlClient

Module Hotel
    Public BookingNo As String = ""
    Public Bookingday As Date = Nothing
    Public BookingCheckoutday As Date = Nothing
    Public HotelOperationMode As Boolean

    Public Function TrapRoomQuery(ByVal dtfrom As Date, ByVal dtto As Date) As String
        Dim datTim1 As Date = CDate(dtfrom).ToShortDateString
        Dim datTim2 As Date = CDate(dtto).ToShortDateString
        Dim daycount As Integer = DateDiff(DateInterval.Day, CDate(datTim1), CDate(datTim2))
        Dim grouped As String = ""
        If daycount > 1 Then
            For i = 0 To Val(CC(daycount)) - 1
                grouped = grouped + " '" & ConvertDate(CDate(dtfrom.AddDays(i)).ToShortDateString) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) or "
            Next
        Else
            grouped = " '" & ConvertDate(CDate(dtfrom).ToShortDateString) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) or "
        End If

        Dim value As String = ""
        If grouped.Length > 0 Then
            grouped = grouped.Remove(grouped.Length - 3, 3)
        End If
        Return grouped
    End Function
    Public Function TrapRoomMaintainanceQuery(ByVal dtfrom As Date, ByVal dtto As Date) As String
        Dim datTim1 As Date = CDate(dtfrom).ToShortDateString
        Dim datTim2 As Date = CDate(dtto).ToShortDateString
        Dim daycount As Integer = DateDiff(DateInterval.Day, CDate(datTim1), CDate(datTim2))
        Dim TrapRoom As String = ""
        If daycount > 1 Then
            For i = 0 To Val(CC(daycount)) - 1
                TrapRoom = TrapRoom + " concat('" & ConvertDate(CDate(dtfrom.AddDays(i)).ToShortDateString) & "',' ',current_time) between startdate and enddate or "
            Next
        Else
            TrapRoom = " concat('" & ConvertDate(CDate(dtfrom).ToShortDateString) & "',' ',current_time) between startdate and enddate or "
        End If
        
        If TrapRoom.Length > 0 Then
            TrapRoom = TrapRoom.Remove(TrapRoom.Length - 3, 3)
        End If
        Return TrapRoom
    End Function
   
    Public Function CreateGuestID()
        Dim strng = ""
        If CInt(countrecord("tblhotelguest")) = 0 Then
            strng = "G100000001"
        Else
            com.CommandText = "select guestid from tblhotelguest order by right(guestid,9) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "G".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("guestid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = "G" & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function

    Public Function getPOSHotelTransactionSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GLobalhotelfoliosequence = True Then
            com.CommandText = "select hotelfoliosequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("hotelfoliosequence").ToString.Length
                strng = Val(rst("hotelfoliosequence").ToString) + 1
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
        com.CommandText = "UPDATE tblgeneralsettings set hotelfoliosequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function


    Public Function getPOSHotelFolioNo(ByVal hotelcif As String)
        UpdateLastFolio(hotelcif)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select foliono from tblhotelfolioseries where hotelcif='" & hotelcif & "'" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("foliono").ToString.Length
            strng = Val(rst("foliono").ToString) + 1
        End While
        rst.Close()
        If NumberLen = 0 Then
            NumberLen = 4
            strng = 1
        End If
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
        com.CommandText = "UPDATE tblhotelfolioseries set foliono='" & newNumber & "' where hotelcif='" & hotelcif & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Sub UpdateLastFolio(ByVal hotelcif As String)
        If countqry("tblhotelfolioseries", "hotelcif='" & hotelcif & "'") = 0 Then
            If countqry("tblhotelroomtransaction", "hotelcif='" & hotelcif & "'") = 0 Then
                com.CommandText = "insert into tblhotelfolioseries set hotelcif='" & hotelcif & "'" : com.ExecuteNonQuery()
            Else
                Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
                com.CommandText = "select foliono from tblhotelroomtransaction where hotelcif='" & hotelcif & "' order by cast(foliono as unsigned) desc limit 1 " : rst = com.ExecuteReader()
                While rst.Read
                    NumberLen = rst("foliono").ToString.Length
                    strng = Val(rst("foliono").ToString) + 1
                End While
                rst.Close()
                If NumberLen = 0 Then
                    NumberLen = 4
                    strng = 1
                End If
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
                com.CommandText = "insert into tblhotelfolioseries set hotelcif='" & hotelcif & "', foliono='" & newNumber & "'" : com.ExecuteNonQuery()
            End If
        End If
    End Sub

    Public Function getPOSBookingNo()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select bookingnoseries from tblgeneralsettings " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("bookingnoseries").ToString.Length
            strng = Val(rst("bookingnoseries").ToString) + 1
        End While
        rst.Close()
        If NumberLen = 0 Then
            NumberLen = 4
            strng = 1
        End If
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
        com.CommandText = "UPDATE tblgeneralsettings set bookingnoseries='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function


    Public Function getPOSHotelReceiptSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        If GLobalhotelreceiptsequence = True Then
            com.CommandText = "select hotelreceiptsequence from tblgeneralsettings " : rst = com.ExecuteReader()
            While rst.Read
                NumberLen = rst("hotelreceiptsequence").ToString.Length
                strng = Val(rst("hotelreceiptsequence").ToString) + 1
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

    Public Function getDiscountCode()
        Dim intval As Integer = 0
        If CInt(countrecord("tblhotelroomsdiscount")) = 0 Then
            intval = 100
        Else
            com.CommandText = "select discode from tblhotelroomsdiscount order by discode desc limit 1" : rst = com.ExecuteReader()
            While rst.Read
                intval = Val(rst("discode").ToString) + 1
            End While
            rst.Close()
        End If
        Return intval.ToString
    End Function

    'Public Sub UpdateFolioSummary(ByVal bookingno As String)
    '    com.CommandText = "DELETE from tblhotelfolioroomsummary where foliono='" & bookingno & "' and folioid in (select folioid from tblhotelfolioroom where foliono='" & bookingno & "' and newroom=1)" : com.ExecuteNonQuery()

    '    da = Nothing : st = New DataSet
    '    da = New MySqlDataAdapter("select * from tblhotelfolioroom where foliono='" & bookingno & "' and newroom=1", conn)
    '    da.Fill(st, 0)
    '    For nt = 0 To st.Tables(0).Rows.Count - 1
    '        Dim xAdultRate As Double = 0
    '        Dim xChildRate As Double = 0
    '        Dim xExtraRate As Double = 0
    '        Dim AdultDayRate As Integer = 0 : Dim ChildDayRate As Integer = 0 : Dim XtraDayRate As Integer = 0

    '        Dim datTim1 As Date = CDate(st.Tables(0).Rows(nt)("arival").ToString())
    '        Dim datTim2 As Date = CDate(st.Tables(0).Rows(nt)("departure").ToString())
    '        Dim nights As Integer = DateDiff(DateInterval.Day, datTim1, datTim2)
    '        For x = 0 To nights - 1

    '            Dim adultRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='roomrate'"))
    '            Dim childRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='child'"))
    '            Dim extraRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='extra'"))

    '            If adultRate > 0 Then
    '                AdultDayRate = x
    '                xAdultRate = adultRate
    '            End If
    '            If childRate > 0 Then
    '                ChildDayRate = x
    '                xChildRate = childRate
    '            End If
    '            If extraRate > 0 Then
    '                XtraDayRate = x
    '                xExtraRate = extraRate
    '            End If
    '            Dim totalAdultRate As Double = If(CBool(st.Tables(0).Rows(nt)("chargepernight").ToString()) = True, xAdultRate, xAdultRate * Val(st.Tables(0).Rows(nt)("pax").ToString()))
    '            Dim totalChildRate As Double = xChildRate * Val(st.Tables(0).Rows(nt)("child").ToString())
    '            Dim totalExtraRate As Double = xExtraRate * Val(st.Tables(0).Rows(nt)("extra").ToString())
    '            Dim totaltrn As Double = totalAdultRate + totalChildRate + totalExtraRate
    '            Dim roomtrncode As String = bookingno & "-" & st.Tables(0).Rows(nt)("folioid").ToString() & "-" & x
    '            com.CommandText = "insert into tblhotelfolioroomsummary set folioid='" & st.Tables(0).Rows(nt)("folioid").ToString() & "', foliono='" & bookingno & "', " _
    '                        + " hotelcif='" & st.Tables(0).Rows(nt)("hotelcif").ToString() & "', " _
    '                        + " arival='" & ConvertDate(st.Tables(0).Rows(nt)("arival").ToString()) & "', " _
    '                        + " departure='" & ConvertDate(st.Tables(0).Rows(nt)("departure").ToString()) & "', " _
    '                        + " roomtrncode='" & roomtrncode & "', " _
    '                        + " dayno='" & x & "', " _
    '                        + " datetrn='" & ConvertDate(datTim1.AddDays(x)) & "', " _
    '                        + " roomid='" & st.Tables(0).Rows(nt)("roomid").ToString() & "', " _
    '                        + " roomno='" & st.Tables(0).Rows(nt)("roomno").ToString() & "', " _
    '                        + " roomtype='" & st.Tables(0).Rows(nt)("roomtype").ToString() & "', " _
    '                        + " roomdesc='" & st.Tables(0).Rows(nt)("description").ToString() & "', " _
    '                        + " nightcharge=" & CBool(st.Tables(0).Rows(nt)("chargepernight").ToString()) & ", " _
    '                        + " rateid='" & st.Tables(0).Rows(nt)("rateid").ToString() & "', " _
    '                        + " adult='" & st.Tables(0).Rows(nt)("pax").ToString() & "', " _
    '                        + " adultrate='" & xAdultRate & "', " _
    '                        + " child='" & st.Tables(0).Rows(nt)("child").ToString() & "', " _
    '                        + " childrate='" & If(Val(st.Tables(0).Rows(nt)("child").ToString()) = 0, 0, xChildRate) & "', " _
    '                        + " extra='" & st.Tables(0).Rows(nt)("extra").ToString() & "', " _
    '                        + " extrarate='" & If(Val(st.Tables(0).Rows(nt)("extra").ToString()) = 0, 0, xExtraRate) & "', " _
    '                        + " total='" & totaltrn & "'" : com.ExecuteNonQuery()
    '        Next
    '    Next
    'End Sub


    Public Sub UpdateFolioSummary(ByVal bookingno As String)
        com.CommandText = "DELETE from tblhotelfolioroomsummary where foliono='" & bookingno & "' and (folioid not in (select folioid from tblhotelfolioroom where foliono='" & bookingno & "') or folioid in (select folioid from tblhotelfolioroom where foliono='" & bookingno & "'))" : com.ExecuteNonQuery()
        com.CommandText = "Delete from tblhotelfolioroombreakdown where foliono='" & bookingno & "' and (folioid not in (select folioid from tblhotelfolioroom where foliono='" & bookingno & "') or folioid in (select folioid from tblhotelfolioroom where foliono='" & bookingno & "'))" : com.ExecuteNonQuery()

        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tblhotelfolioroom where foliono='" & bookingno & "'", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            Dim xAdultRate As Double = 0
            Dim xChildRate As Double = 0
            Dim xExtraRate As Double = 0
            Dim AdultDayRate As Integer = 0 : Dim ChildDayRate As Integer = 0 : Dim XtraDayRate As Integer = 0

            Dim datTim1 As Date = CDate(st.Tables(0).Rows(nt)("arival").ToString())
            Dim datTim2 As Date = CDate(st.Tables(0).Rows(nt)("departure").ToString())
            Dim nights As Integer = DateDiff(DateInterval.Day, datTim1, datTim2)
            For x = 0 To nights - 1

                Dim adultRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='roomrate'"))
                Dim childRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='child'"))
                Dim extraRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='extra'"))

                If adultRate > 0 Then
                    AdultDayRate = x
                    xAdultRate = adultRate
                End If
                If childRate > 0 Then
                    ChildDayRate = x
                    xChildRate = childRate
                End If
                If extraRate > 0 Then
                    XtraDayRate = x
                    xExtraRate = extraRate
                End If

                Dim totalAdultRate As Double = If(CBool(st.Tables(0).Rows(nt)("chargepernight").ToString()) = True, xAdultRate, xAdultRate * Val(st.Tables(0).Rows(nt)("pax").ToString()))
                Dim totalChildRate As Double = xChildRate * Val(st.Tables(0).Rows(nt)("child").ToString())
                Dim totalExtraRate As Double = xExtraRate * Val(st.Tables(0).Rows(nt)("extra").ToString())
                Dim totaltrn As Double = totalAdultRate + totalChildRate + totalExtraRate
                Dim roomtrncode As String = bookingno & "-" & st.Tables(0).Rows(nt)("folioid").ToString() & "-" & x
                com.CommandText = "insert into tblhotelfolioroomsummary set folioid='" & st.Tables(0).Rows(nt)("folioid").ToString() & "', foliono='" & bookingno & "', " _
                            + " hotelcif='" & st.Tables(0).Rows(nt)("hotelcif").ToString() & "', " _
                            + " arival='" & ConvertDate(st.Tables(0).Rows(nt)("arival").ToString()) & "', " _
                            + " departure='" & ConvertDate(st.Tables(0).Rows(nt)("departure").ToString()) & "', " _
                            + " roomtrncode='" & roomtrncode & "', " _
                            + " dayno='" & x & "', " _
                            + " datetrn='" & ConvertDate(datTim1.AddDays(x)) & "', " _
                            + " trnby='" & globaluserid & "', " _
                            + " roomid='" & st.Tables(0).Rows(nt)("roomid").ToString() & "', " _
                            + " roomno='" & st.Tables(0).Rows(nt)("roomno").ToString() & "', " _
                            + " roomtype='" & st.Tables(0).Rows(nt)("roomtype").ToString() & "', " _
                            + " roomdesc='" & st.Tables(0).Rows(nt)("description").ToString() & "', " _
                            + " nightcharge=" & CBool(st.Tables(0).Rows(nt)("chargepernight").ToString()) & ", " _
                            + " rateid='" & st.Tables(0).Rows(nt)("rateid").ToString() & "', " _
                            + " adult='" & st.Tables(0).Rows(nt)("pax").ToString() & "', " _
                            + " adultrate='" & xAdultRate & "', " _
                            + " child='" & st.Tables(0).Rows(nt)("child").ToString() & "', " _
                            + " childrate='" & If(Val(st.Tables(0).Rows(nt)("child").ToString()) = 0, 0, xChildRate) & "', " _
                            + " extra='" & st.Tables(0).Rows(nt)("extra").ToString() & "', " _
                            + " extrarate='" & If(Val(st.Tables(0).Rows(nt)("extra").ToString()) = 0, 0, xExtraRate) & "', " _
                            + " total='" & totaltrn & "'" : com.ExecuteNonQuery()

                If xAdultRate > 0 Then
                    com.CommandText = "insert into tblhotelfolioroombreakdown (foliono,folioid,roomid,roomtrncode,dayno,ratecode,breakdowntype,itemcode,itemname,amount) select '" & bookingno & "','" & st.Tables(0).Rows(nt)("folioid").ToString() & "','" & st.Tables(0).Rows(nt)("roomid").ToString() & "','" & roomtrncode & "'," & x & ",ratecode,breakdowntype,itemcode,itemname,amount from tblhotelratesbreakdown where dayrate='" & AdultDayRate & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='roomrate'" : com.ExecuteNonQuery()
                End If
                If xChildRate > 0 And Val(st.Tables(0).Rows(nt)("child").ToString()) > 0 Then
                    com.CommandText = "insert into tblhotelfolioroombreakdown (foliono,folioid,roomid,roomtrncode,dayno,ratecode,breakdowntype,itemcode,itemname,amount) select '" & bookingno & "','" & st.Tables(0).Rows(nt)("folioid").ToString() & "','" & st.Tables(0).Rows(nt)("roomid").ToString() & "','" & roomtrncode & "'," & x & ",ratecode,breakdowntype,itemcode,itemname,amount from tblhotelratesbreakdown where dayrate='" & ChildDayRate & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='child'" : com.ExecuteNonQuery()
                End If
                If xExtraRate > 0 And Val(st.Tables(0).Rows(nt)("extra").ToString()) > 0 Then
                    com.CommandText = "insert into tblhotelfolioroombreakdown (foliono,folioid,roomid,roomtrncode,dayno,ratecode,breakdowntype,itemcode,itemname,amount) select '" & bookingno & "','" & st.Tables(0).Rows(nt)("folioid").ToString() & "','" & st.Tables(0).Rows(nt)("roomid").ToString() & "','" & roomtrncode & "'," & x & ",ratecode,breakdowntype,itemcode,itemname,amount from tblhotelratesbreakdown where dayrate='" & XtraDayRate & "' and ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and breakdowntype='extra'" : com.ExecuteNonQuery()
                End If
                com.CommandText = "CALL sp_acct_entries('" & roomtrncode & "','', 'HOTEL_CHECK_IN','')" : com.ExecuteNonQuery()
            Next
        Next
        ' UpdateFolioInhouseBreakdown(bookingno)
    End Sub

    Public Sub UpdateFolioInhouseBreakdowns(ByVal bookingno As String)
        com.CommandText = "Delete from tblhotelfolioroombreakdown where foliono='" & bookingno & "' and  folioid in (select folioid from tblhotelfolioroom where foliono='" & bookingno & "' and inhouse=1)" : com.ExecuteNonQuery()
        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tblhotelfolioroom where foliono='" & bookingno & "' and inhouse=1", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            Dim xAdultRate As Double = 0
            Dim xChildRate As Double = 0
            Dim xExtraRate As Double = 0
            Dim rateid As String = "" : Dim x As Integer = 0
            Dim AdultDayRate As Integer = 0 : Dim ChildDayRate As Integer = 0 : Dim XtraDayRate As Integer = 0
            com.CommandText = "Delete from tblhotelfolioroomsummary where folioid='" & st.Tables(0).Rows(nt)("folioid").ToString() & "' and datetrn>='" & ConvertDate(st.Tables(0).Rows(nt)("departure").ToString()) & "'" : com.ExecuteNonQuery()
            msda = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblhotelfolioroomsummary where folioid='" & st.Tables(0).Rows(nt)("folioid").ToString() & "' order by datetrn asc", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                If rateid <> dst.Tables(0).Rows(cnt)("rateid").ToString() Then
                    rateid = dst.Tables(0).Rows(cnt)("rateid").ToString()
                    x = 0
                Else
                    x += 1
                End If

                Dim adultRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & rateid & "' and breakdowntype='roomrate'"))
                Dim childRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & rateid & "' and breakdowntype='child'"))
                Dim extraRate As Double = Val(qrysingledata("ttl", " ifnull(sum(amount),0) as ttl", "tblhotelratesbreakdown where dayrate='" & x & "' and ratecode='" & rateid & "' and breakdowntype='extra'"))

                If adultRate > 0 Then
                    AdultDayRate = x
                    xAdultRate = adultRate
                End If
                If childRate > 0 Then
                    ChildDayRate = x
                    xChildRate = childRate
                End If
                If extraRate > 0 Then
                    XtraDayRate = x
                    xExtraRate = extraRate
                End If

                Dim totalAdultRate As Double = If(CBool(dst.Tables(0).Rows(cnt)("nightcharge").ToString()) = True, xAdultRate, xAdultRate * Val(dst.Tables(0).Rows(cnt)("adult").ToString()))
                Dim totalChildRate As Double = xChildRate * Val(dst.Tables(0).Rows(cnt)("child").ToString())
                Dim totalExtraRate As Double = xExtraRate * Val(dst.Tables(0).Rows(cnt)("extra").ToString())
                Dim totaltrn As Double = totalAdultRate + totalChildRate + totalExtraRate
                Dim roomtrncode As String = bookingno & "-" & dst.Tables(0).Rows(cnt)("folioid").ToString() & "-" & dst.Tables(0).Rows(cnt)("dayno").ToString()
                com.CommandText = "UPDATE tblhotelfolioroomsummary set trnby='" & globaluserid & "', adultrate='" & xAdultRate & "',childrate='" & If(Val(dst.Tables(0).Rows(cnt)("child").ToString()) = 0, 0, xChildRate) & "', extrarate='" & If(Val(dst.Tables(0).Rows(cnt)("extra").ToString()) = 0, 0, xExtraRate) & "',  total='" & totaltrn & "' where id='" & dst.Tables(0).Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()


                If xAdultRate > 0 Then
                    com.CommandText = "insert into tblhotelfolioroombreakdown (foliono,folioid,roomid,roomtrncode,dayno,ratecode,breakdowntype,itemcode,itemname,amount) select '" & bookingno & "','" & dst.Tables(0).Rows(cnt)("folioid").ToString() & "','" & dst.Tables(0).Rows(cnt)("roomid").ToString() & "','" & roomtrncode & "'," & dst.Tables(0).Rows(cnt)("dayno").ToString() & ",ratecode,breakdowntype,itemcode,itemname,amount from tblhotelratesbreakdown where dayrate='" & AdultDayRate & "' and ratecode='" & rateid & "' and breakdowntype='roomrate'" : com.ExecuteNonQuery()
                End If
                If xChildRate > 0 And Val(dst.Tables(0).Rows(cnt)("child").ToString()) > 0 Then
                    com.CommandText = "insert into tblhotelfolioroombreakdown (foliono,folioid,roomid,roomtrncode,dayno,ratecode,breakdowntype,itemcode,itemname,amount) select '" & bookingno & "','" & dst.Tables(0).Rows(cnt)("folioid").ToString() & "','" & dst.Tables(0).Rows(cnt)("roomid").ToString() & "','" & roomtrncode & "'," & dst.Tables(0).Rows(cnt)("dayno").ToString() & ",ratecode,breakdowntype,itemcode,itemname,amount from tblhotelratesbreakdown where dayrate='" & ChildDayRate & "' and ratecode='" & rateid & "' and breakdowntype='child'" : com.ExecuteNonQuery()
                End If
                If xExtraRate > 0 And Val(dst.Tables(0).Rows(cnt)("extra").ToString()) > 0 Then
                    com.CommandText = "insert into tblhotelfolioroombreakdown (foliono,folioid,roomid,roomtrncode,dayno,ratecode,breakdowntype,itemcode,itemname,amount) select '" & bookingno & "','" & dst.Tables(0).Rows(cnt)("folioid").ToString() & "','" & dst.Tables(0).Rows(cnt)("roomid").ToString() & "','" & roomtrncode & "'," & dst.Tables(0).Rows(cnt)("dayno").ToString() & ",ratecode,breakdowntype,itemcode,itemname,amount from tblhotelratesbreakdown where dayrate='" & XtraDayRate & "' and ratecode='" & rateid & "' and breakdowntype='extra'" : com.ExecuteNonQuery()
                End If
                com.CommandText = "CALL sp_acct_entries('" & roomtrncode & "','', 'HOTEL_CHECK_IN','')" : com.ExecuteNonQuery()
            Next
        Next
    End Sub


End Module
