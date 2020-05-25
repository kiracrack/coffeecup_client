Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptReceivedReport
    Private Sub rptApprovedPO_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
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
        com.CommandText = "select * from tblaccounts where accountid='" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSignatory1.Text = rst("fullname").ToString
            txtPosition1.Text = rst("designation").ToString
        End While
        rst.Close()
        DXShowReportSignature(globaluserid, imgPrepareby)


        Dim cntApprover As Integer = countqry("tblapprovermainprocess", "apptype='receiving-report'")
        If cntApprover > 0 Then
            Dim cnt As Integer = 1
            Dim ctrTitle() As DevExpress.XtraReports.UI.XRLabel = {txtTitle2, txtTitle3}
            For Each cont As XRLabel In ctrTitle
                cont.Visible = True
                cont.Text = qrysingledata("apptitle", "apptitle", "tblapprovermainprocess where left(applevel,1) = '" & cnt & "' and apptype='receiving-report'")
                If cnt = cntApprover Then
                    Exit For
                End If
                cnt = cnt + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt2 As Integer = 1
            Dim ctrLine() As DevExpress.XtraReports.UI.XRLine = {txtLine2, txtLine3}
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
            Dim ctrSignatory() As DevExpress.XtraReports.UI.XRLabel = {txtSignatory2, txtSignatory3}
            For Each cont As XRLabel In ctrSignatory
                cont.Visible = True
                cont.Text = qrysingledata("confirmby", "(select fullname from tblaccounts where accountid=tblapprovermainprocess.authorizedid) as confirmby", "tblapprovermainprocess where left(applevel,1) = '" & cnt3 & "' and apptype='receiving-report'")
                If cnt3 = cntApprover Then
                    Exit For
                End If
                cnt3 = cnt3 + 1
            Next
        End If

        If cntApprover > 0 Then
            Dim cnt4 As Integer = 1
            Dim ctrPosition() As DevExpress.XtraReports.UI.XRLabel = {txtPosition2, txtPosition3}
            For Each cont As XRLabel In ctrPosition
                cont.Visible = True
                cont.Text = qrysingledata("confirmby", "(select designation from tblaccounts where accountid=tblapprovermainprocess.authorizedid) as confirmby", "tblapprovermainprocess where left(applevel,1) = '" & cnt4 & "' and apptype='receiving-report'")
                If cnt4 = cntApprover Then
                    Exit For
                End If
                cnt4 = cnt4 + 1
            Next
        End If

        'If cntApprover > 0 Then
        '    Dim cnt5 As Integer = 1
        '    Dim ctrPicture() As DevExpress.XtraReports.UI.XRPictureBox = {XrPictureBox1, XrPictureBox3}
        '    For Each cont As XRPictureBox In ctrPicture
        '        cont.Visible = True
        '        cont.Image = Nothing
        '        ShowReportSignature(qrysingledata("authorizedid", "authorizedid", "where left(applevel,1) = '" & cnt5 & "' and apptype='receiving-report'", "tblapprovermainprocess"), cont)
        '        If cnt5 = cntApprover Then
        '            Exit For
        '        End If
        '        cnt5 = cnt5 + 1
        '    Next
        'End If
    End Sub
End Class