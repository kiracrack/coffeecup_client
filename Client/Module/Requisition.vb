Imports System.IO

Module Requisition
    Public Function DownloadRequest(ByVal referenceno As String, ByVal filename As String)
        Dim path As String = Application.StartupPath.ToString & "\Resources\Draft\" & filename & ".txt"
        If IO.File.Exists(path) = True Then
            IO.File.Delete(path)
        End If

        Dim sw As StreamWriter = File.AppendText(path)

        '#create copy request details
        com.CommandText = "select *,(select description from tblrequesttype where potypeid = tblrequisitionslogs.potypeid) as 'reqtype', " _
                    + " (select officename from tblcompoffice where officeid=tblrequisitionslogs.officeid) as office, " _
                    + " (select fullname from tblhotelguest where guestid=tblrequisitionslogs.allocatedexpense) as allocated, " _
                    + " (select fullname from tblaccounts where accountid =tblrequisitionslogs.requestby) as 'reqby' " _
                    + " from tblrequisitionslogs where trnrefno ='" & referenceno & "'" : rst = com.ExecuteReader
        While rst.Read
            Dim dir As String = ""
            If System.IO.File.Exists(rst("attachmentpath").ToString) = True Then
                dir = rst("attachmentpath").ToString
            End If
            sw.WriteLine(rst("officeid").ToString & "|" & rst("office").ToString & "|" & rst("potypeid").ToString & "|" & rst("reqtype").ToString & "|" & rst("requestby").ToString & "|" & rst("reqby").ToString & "|" & rst("priority").ToString & "|" & rst("allocatedexpense").ToString & "|" & ConvertDate(Now.ToShortDateString) & "|" & rst("approvinglevel").ToString & "|" & If(dir = "", "0", "1") & "|" & dir & "|" & EncryptTripleDES(rst("details").ToString))
        End While
        rst.Close()
        sw.Close()

        '#create copy item details
        Dim pathitem As String = Application.StartupPath.ToString & "\Resources\Particular Items\" & filename & ".txt"
        If IO.File.Exists(pathitem) = True Then
            IO.File.Delete(pathitem)
        End If

        Dim switem As StreamWriter = File.AppendText(pathitem)
        com.CommandText = "Select *, (select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as 'Particular', " _
                                    + " (select DESCRIPTION from tblprocategory where CATID = tblrequisitionsitem.CATID ) as 'Category', " _
                                        + " (select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as 'Vendor' " _
                                        + " from tblrequisitionsitem " _
                                        + " where trnrefno='" & referenceno & "'" : rst = com.ExecuteReader
        While rst.Read
            switem.WriteLine(rst("Particular").ToString & "|" & rst("quantity").ToString & "|" & rst("unit").ToString & "|" & rst("cost").ToString & "|" & rst("Total").ToString & "|" & rst("Remarks").ToString & "|" & rst("Vendor").ToString & "|" & rst("trnid").ToString & "|" & filename & "|" & rst("productid").ToString & "|" & rst("catid").ToString & "|" & rst("vendorid").ToString)
        End While
        rst.Close()
        switem.Close()
        Return 0
    End Function
End Module
