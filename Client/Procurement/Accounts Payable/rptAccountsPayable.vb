Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptAccountsPayable
    Private Sub rptAccountsPayable_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If ReportHeaderImg Is Nothing Then
            imgReportHeader.Visible = False
            txtCompanyName.Text = GlobalOrganizationName
            txtCompanyAddress.Text = GlobalOrganizationAddress
            txtCompanyNumber.Text = GlobalOrganizationContactNumber
        Else
            imgReportHeader.Visible = True
            imgReportHeader.Image = ReportHeaderImg
        End If

        If ReportFooterImg Is Nothing Then
            imgReportFooter.Visible = False
        Else
            imgReportFooter.Visible = True
            imgReportFooter.Image = ReportFooterImg
        End If

        If Me.Landscape = True Then
            txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Else
            txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            txtCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            txtCompanyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        End If


        'PROCUREMENT OFFICER
        Dim procurementid As String = qrysingledata("trnby", "trnby", "tbldisbursementvoucher where voucherno='" & payableno.Text & "'")
        com.CommandText = "select * from tblaccounts where accountid='" & procurementid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSignatory1.Text = rst("fullname").ToString
            txtPosition1.Text = rst("designation").ToString
        End While
        rst.Close()
        DXShowReportSignature(procurementid, XrPictureBox1)

        ClearSignatories()
        Dim cntApprover As Integer = countqry("tblapprovalhistory", "referenceno='" & payableno.Text & "' and applevel<>'-' and appdescription='payable' and applevel<>'-'")
        If cntApprover > 0 Then
            Dim cnt As Integer = 1
            Dim ctrTitle() As DevExpress.XtraReports.UI.XRLabel = {txtTitle2, txtTitle3, txtTitle4, txtTitle5, txtTitle6}
            For Each cont As XRLabel In ctrTitle
                cont.Visible = True
                cont.Text = qrysingledata("apptitle", "apptitle", "tblapprovalhistory where left(applevel,1) = '" & cnt & "' and referenceno='" & payableno.Text & "' and applevel<>'-' and appdescription='payable'")
                If cnt = cntApprover Then
                    Exit For
                End If
                cnt = cnt + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt2 As Integer = 1
            Dim ctrLine() As DevExpress.XtraReports.UI.XRLine = {txtLine2, txtLine3, txtLine4, txtLine5, txtLine6}
            For Each cont As XRLine In ctrLine
                cont.Visible = True
                If cnt2 = cntApprover Then
                    Exit For
                End If
                cnt2 = cnt2 + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt3 As Integer = 1
            Dim ctrSignatory() As DevExpress.XtraReports.UI.XRLabel = {txtSignatory2, txtSignatory3, txtSignatory4, txtSignatory5, txtSignatory6}
            For Each cont As XRLabel In ctrSignatory
                cont.Visible = True
                cont.Text = qrysingledata("confirmby", "confirmby", "tblapprovalhistory where left(applevel,1) = '" & cnt3 & "' and  referenceno='" & payableno.Text & "' and applevel<>'-' and appdescription='payable'")
                If cnt3 = cntApprover Then
                    Exit For
                End If
                cnt3 = cnt3 + 1
            Next
        End If


        If cntApprover > 0 Then
            Dim cnt4 As Integer = 1
            Dim ctrPosition() As DevExpress.XtraReports.UI.XRLabel = {txtPosition2, txtPosition3, txtPosition4, txtPosition5, txtPosition6}
            For Each cont As XRLabel In ctrPosition
                cont.Visible = True
                cont.Text = UCase(qrysingledata("position", "position", "tblapprovalhistory where left(applevel,1) = '" & cnt4 & "'  and  referenceno='" & payableno.Text & "' and applevel<>'-' and appdescription='payable'"))
                If cnt4 = cntApprover Then
                    Exit For
                End If
                cnt4 = cnt4 + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt5 As Integer = 1
            Dim ctrPicture() As DevExpress.XtraReports.UI.XRPictureBox = {XrPictureBox2, XrPictureBox3, XrPictureBox4, XrPictureBox5, XrPictureBox6}
            For Each cont As XRPictureBox In ctrPicture
                cont.Visible = True
                cont.Image = Nothing
                DXShowReportSignature(qrysingledata("confirmid", "confirmid", "tblapprovalhistory where left(applevel,1) = '" & cnt5 & "'  and  referenceno='" & payableno.Text & "' and applevel<>'-' and appdescription='payable'"), cont)
                If cnt5 = cntApprover Then
                    Exit For
                End If
                cnt5 = cnt5 + 1
            Next
        End If


        txtNote.Text = "NOTE: This report and the signatures contained herein are generated electronically. All signatures are official and carry the full authority of the person(s) indicated"
         
    End Sub
    Public Sub ClearSignatories()
        Dim ctrPicture() As DevExpress.XtraReports.UI.XRPictureBox = {XrPictureBox2, XrPictureBox3, XrPictureBox4, XrPictureBox5, XrPictureBox6}
        For Each cont As XRPictureBox In ctrPicture
            cont.Image = Nothing
        Next

        Dim ctrTitle() As DevExpress.XtraReports.UI.XRLabel = {txtTitle2, txtTitle3, txtTitle4, txtTitle5, txtTitle6}
        For Each cont As XRLabel In ctrTitle
            cont.Text = ""
        Next

        Dim ctrSignatory() As DevExpress.XtraReports.UI.XRLabel = {txtSignatory2, txtSignatory3, txtSignatory4, txtSignatory5, txtSignatory6}
        For Each cont As XRLabel In ctrSignatory
            cont.Text = ""
        Next

        Dim ctrPosition() As DevExpress.XtraReports.UI.XRLabel = {txtPosition2, txtPosition3, txtPosition4, txtPosition5, txtPosition6}
        For Each cont As XRLabel In ctrPosition
            cont.Text = ""
        Next

        Dim ctrLine() As DevExpress.XtraReports.UI.XRLine = {txtLine2, txtLine3, txtLine4, txtLine5, txtLine6}
        For Each cont As XRLine In ctrLine
            cont.Visible = False
        Next

    End Sub


End Class