Module gl
    Public GlobalGLitemname As String = "if(a.level=0, a.itemname,if(a.level=1,concat('   ',a.itemname),if(a.level=2,concat('           ',a.itemname),if(a.level=3,concat('                  ',a.itemname),concat('                         ',a.itemname)))))"
    Public Function GetGLTransactionCode(ByVal trncode As String, ByVal debit As Boolean) As String
        GetGLTransactionCode = ""
        com.CommandText = "select * from tbltransactioncode where itemcode='" & trncode & "'" : rst = com.ExecuteReader
        While rst.Read
            If debit = True Then
                GetGLTransactionCode = rst("gldebit").ToString
            Else
                GetGLTransactionCode = rst("glcredit").ToString
            End If
        End While
        rst.Close()
        Return GetGLTransactionCode
    End Function
    Public Function CreateGLTicketToken(ByVal referenceno As String, trnby As String) As String
        CreateGLTicketToken = ""
        com.CommandText = "select md5(concat('" & referenceno & "',current_timestamp,'" & trnby & "')) as token" : rst = com.ExecuteReader
        While rst.Read
            CreateGLTicketToken = rst("token").ToString
        End While
        rst.Close()
        Return CreateGLTicketToken
    End Function
    Public Function glticket(ByVal reference As String, ByVal officeid As String, ByVal itemcode As String, ByVal debit As Double, ByVal credit As Double, ByVal remarks As String, ByVal datetrn As String, ByVal trnby As String)
        Dim getGroup As String = qrysingledata("groupcode", "groupcode", "tblglitem where itemcode='" & itemcode & "'")
        Dim getItemname As String = qrysingledata("itemname", "itemname", "tblglitem where itemcode='" & itemcode & "'")
        com.CommandText = "insert into tblglticket set gltoken='" & reference & "', officeid='" & officeid & "', groupcode='" & getGroup & "', itemcode='" & itemcode & "', itemname='" & rchar(getItemname) & "',debit=" & debit & ",credit=" & credit & ", remarks='" & rchar(remarks) & "',datetrn='" & ConvertDate(datetrn) & "', trnby='" & trnby & "', cleared=1, datecleared=current_timestamp,clearedby='" & globalfullname & "'" : com.ExecuteNonQuery()
        Return True
    End Function

    Public Function getTicketNumberSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select ticketsequence from tblglsettings" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("ticketsequence").ToString.Length
            strng = Val(rst("ticketsequence").ToString) + 1
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
        com.CommandText = "UPDATE tblglsettings set ticketsequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function
End Module
