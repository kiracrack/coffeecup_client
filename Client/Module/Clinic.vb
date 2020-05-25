Module Clinic
    Public Function getPOSClinicSequenceNumber(ByVal clinicid As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select servicecode from tblclinicservices where clinicid='" & clinicid & "' order by cast(servicecode as unsigned) desc limit 1 " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("servicecode").ToString.Length
            strng = Val(rst("servicecode").ToString) + 1
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
        Return newNumber
    End Function

    Public Sub GenerateLXClinicService(ByVal trnid As String, ByVal form As Form)
        Dim TableRow As String = "" : Dim TableTransaction As String = "" : Dim Total As Double = 0
        CreateHTMLReportTemplate("ClinicServices.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\ClinicServices.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\Clinic\Clinic Services-" & trnid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        com.CommandText = "select *, id,productid, date_format(schedule,'%M %d, %Y') as 'Schedule', Productname as 'Product Schedule',(select group_concat(fullname separator ';') from tblclinicsattending where schedid=tblclinicschedule.id) as 'Attending Personnel',if(Cleared=1,'YES','-') as Cleared, date_format(datecleared,'%Y-%m-%d') as 'Date Cleared', clearedby as 'Cleared By'  from tblclinicschedule where trnid='" & trnid & "' and cancelled=0 order by date_format(schedule,'%Y-%m-%d') asc" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center'>" & rst("Schedule").ToString & "</td> " _
                           + " <td align='left'>" & rst("Product Schedule").ToString & "</td> " _
                           + " <td align='center'>" & rst("Cleared").ToString & "</td> " _
                           + " <td align='center'>" & rst("Date Cleared").ToString & "</td> " _
                           + " <td align='left'>" & rst("Attending Personnel").ToString.Replace(";", "<br/>") & "</td> " _
                     + " </tr> " & Chr(13)
        End While
        rst.Close()

        TableTransaction = TableRow
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString & "\Logo\logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", "SERVICE PACKAGE"), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", Now.ToShortDateString), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[transaction]", TableTransaction), False)

        com.CommandText = "select *,date_format(current_timestamp, '%M %d, %Y %r') as 'dateledger', date_format(datetrn, '%M %d, %Y') as 'datetransaction', " _
                           + " (select companyname from tblclientaccounts where cifid=tblclinicservices.clientcif) as 'client', " _
                           + " (select compadd from tblclientaccounts where cifid=tblclinicservices.clientcif) as 'address' " _
                           + " from tblclinicservices where trnid='" & trnid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[package]", rst("packagename").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[service no]", rst("servicecode").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client name]", rst("client").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[client address]", rst("address").ToString), False)
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
    End Sub

End Module
