Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPOSCloseCashierTransaction
    Public TransactionDone As Boolean = False
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Control) + Keys.B Then
            frmPOScashDonimination.Show(Me)
        ElseIf keyData = (Keys.Control) + Keys.P Then
            EditChapterToolStripMenuItem.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSCloseTransaction_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadCashDenomination()
    End Sub
    Private Sub frmPOSCloseTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtDateFrom.Text = globalTransactionDate.ToString("MMMM dd, yyyy")
        LoadCashDenomination()
        If GLobalEnableViewSalesCashendreport = True Then
            txtSystemCashEnd.Visible = True
            lblSystemCashEnd.Visible = True
        Else
            txtSystemCashEnd.Visible = False
            lblSystemCashEnd.Visible = False
        End If
        LoadSystemCashEnd()
    End Sub

    Public Sub LoadSystemCashEnd()
        com.CommandText = "call sp_salesremittance('CONSOLIDATED','" & globalSalesTrnCOde & "','')" : com.ExecuteNonQuery()
        com.CommandText = "select * from tmpconsolidateddetails where trntype='cash'" : rst = com.ExecuteReader
        While rst.Read
            txtSystemCashEnd.Text = FormatNumber(rst("amount").ToString, 2)
        End While
        rst.Close()
    End Sub

    Public Sub LoadCashDenomination()
        com.CommandText = "select ifnull(sum(totalamount),0) as ttlamount,ifnull(sum(totalbills),0) as ttlbills, ifnull(sum(totalcoins),0) as ttlcoins from tblsalescashdenomination where trnsumcode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
        While rst.Read
            txt_ActualCashOnHand.Text = FormatNumber(rst("ttlamount"), 2)
            txt_TotalBill.Text = FormatNumber(rst("ttlbills"), 2)
            txt_TotalCoins.Text = FormatNumber(rst("ttlcoins"), 2)
        End While
        rst.Close()
    End Sub

#Region "CLOSING TRANSACTION"

    Private Sub cmdCloseCashierTransaction_Click(sender As Object, e As EventArgs) Handles cmdCloseCashierTransaction.Click
        CloseCashierTransaction()
    End Sub
 
    Public Sub CloseCashierTransaction()
        If MessageBox.Show("Are you sure you want to continue close account transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If globalEnablePosPrinter = True Then
                If MessageBox.Show("Do you want to print sales blotter? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    PrintSalesBlotter()
                    'PrintSalesProductSummary()
                End If
            End If
            Dim Variance As Double = Val(CC(txt_ActualCashOnHand.Text)) - Val(CC(txtSystemCashEnd.Text))
            com.CommandText = "update tblsalessummary set dateclose=current_timestamp, " _
                                        + " closedby='" & globaluserid & "', " _
                                        + " cashend='" & Val(CC(txtSystemCashEnd.Text)) & "', " _
                                        + " cashonhand='" & Val(CC(txt_ActualCashOnHand.Text)) & "', " _
                                        + If(Variance > 0, " overages='" & Variance & "',", " shortages='" & Variance & "', ") _
                                        + " totalcash='" & Val(CC(txt_TotalBill.Text)) & "', " _
                                        + " totalcoins='" & Val(CC(txt_TotalCoins.Text)) & "', " _
                                        + " nextbeginningcash='" & Val(CC(txt_NextcashBeginning.Text)) & "', " _
                                        + " cashremitted='" & Val(CC(txt_CashRemitted.Text)) & "', " _
                                        + " openfortrn=0 where trncode='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()

            If globalBackDateTransaction = False Then
                com.CommandText = "update tblaccounts set cashbeggining='" & Val(CC(txt_NextcashBeginning.Text)) & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            SendSalesReport()
            TransactionDone = True
            LoadAccountDetails(globaluserid)
            MainForm.ValidateModule()
            Me.Close()
        End If
    End Sub
#End Region

    Public Sub PrintSalesBlotter()
        Dim details As String = ""
        details = PageHeader()
        details += PrintCenterText("SALES BLOTTER") & Environment.NewLine & Environment.NewLine
        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblsalessummary.userid) as cashier,date_format(dateopen,'%M %d, %Y %r') as opendate,date_format(dateclose,'%M %d, %Y %r') as closeddate from tblsalessummary where trncode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftText("Cashier: " & rst("cashier").ToString) & Environment.NewLine
            details += PrintLeftText("Blotter #: " & globalSalesTrnCOde) & Environment.NewLine
            details += PrintLeftText("From: " & rst("opendate").ToString) & Environment.NewLine
            details += PrintLeftText("To: " & If(rst("closeddate").ToString = "", Now.ToLongDateString, rst("closeddate").ToString)) & Environment.NewLine
        End While
        rst.Close()
        details += PrintSpaceLine() & Environment.NewLine

        com.CommandText = "call sp_salesremittance('CONSOLIDATED','" & globalSalesTrnCOde & "','');" : com.ExecuteNonQuery()
        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select * from tmpconsolidated order by id asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                details += PrintLeftText(st.Tables(0).Rows(nt)("title").ToString()) & Environment.NewLine
            End If
            com.CommandText = "select * from tmpconsolidateddetails where trntype='" & st.Tables(0).Rows(nt)("trntype").ToString() & "' and amount>0 order by id asc" : rst = com.ExecuteReader
            While rst.Read
                If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                    details += PrintLeftRigthText(StrConv(rst("details").ToString, VbStrConv.ProperCase), FormatNumber(Val(rst("amount").ToString), 2)) & Environment.NewLine
                Else
                    If rst("details").ToString <> "CASH" Then
                        details += Environment.NewLine
                        details += PrintLeftRigthText(StrConv(rst("details").ToString, VbStrConv.ProperCase), FormatNumber(Val(rst("amount").ToString), 2)) & Environment.NewLine
                    End If
                End If

            End While
            rst.Close()
            If CBool(st.Tables(0).Rows(nt)("haschild").ToString()) = True Then
                details += PrintLeftRigthText("", "-------------") & Environment.NewLine
                details += PrintLeftRigthText("", FormatNumber(Val(st.Tables(0).Rows(nt)("total").ToString()), 2)) & Environment.NewLine
            End If
        Next

        If GLobalEnableViewSalesCashendreport = True Then
            details += Environment.NewLine & PrintLeftRigthText("System Cash End", txtSystemCashEnd.Text) & Environment.NewLine
            details += PrintLeftRigthText("Shift Cash End", FormatNumber(txt_ActualCashOnHand.Text, 2)) & Environment.NewLine
            details += PrintLeftRigthText("Cash Variance", FormatNumber(Val(CC(txt_ActualCashOnHand.Text)) - Val(CC(txtSystemCashEnd.Text)), 2)) & Environment.NewLine
        Else
            details += Environment.NewLine & PrintLeftRigthText("Shift Cash End", FormatNumber(txt_ActualCashOnHand.Text, 2)) & Environment.NewLine
        End If

        details += PrintLeftRigthText("Total Bill", FormatNumber(txt_TotalBill.Text, 2)) & Environment.NewLine
        details += PrintLeftRigthText("Total Coins", txt_TotalCoins.Text) & Environment.NewLine

        details += Environment.NewLine & PrintLeftRigthText("Next Cash Begginning", FormatNumber(Val(CC(txt_NextcashBeginning.Text)), 2)) & Environment.NewLine
        details += PrintLeftRigthText("Total Cash Remitted", txt_CashRemitted.Text) & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        'If System.IO.File.Exists(Application.StartupPath & "\updateinfo.txt") = True Then
        '    System.IO.File.Delete(Application.StartupPath & "\updateinfo.txt")
        'End If
        'Dim detailsFile As StreamWriter = Nothing
        'detailsFile = New StreamWriter(Application.StartupPath.ToString & "\updateinfo.txt", True)
        'detailsFile.WriteLine(details)
        'detailsFile.Close()
        'Process.Start(Application.StartupPath & "\updateinfo.txt")

        com.CommandText = "update tblsalessummary set blotter='" & rchar(details.Replace((27) & Chr(112) & Chr(0) & Chr(25) & Chr(250), "")) & "' where trncode='" & globalSalesTrnCOde & "'" : com.ExecuteNonQuery()
        If globalPosCustomFont = True Then
            globalPosCustomFont = False
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
            globalPosCustomFont = True
        Else
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
        End If
    End Sub

    Public Sub PrintSalesProductSummary()
        Dim details As String = ""
        details = PageHeader()
        details += Environment.NewLine & PrintCenterText("PRODUCT SUMMARY") & Environment.NewLine & Environment.NewLine
        com.CommandText = "select *,(select fullname from tblaccounts where accountid=tblsalessummary.userid) as cashier,date_format(dateopen,'%M %d, %Y %r') as opendate,date_format(dateclose,'%M %d, %Y %r') as closeddate from tblsalessummary where trncode='" & globalSalesTrnCOde & "'" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftText("Cashier: " & rst("cashier").ToString) & Environment.NewLine
            details += PrintLeftText("Blotter #: " & globalSalesTrnCOde) & Environment.NewLine
            details += PrintLeftText("From: " & rst("opendate").ToString) & Environment.NewLine
            details += PrintLeftText("To: " & If(rst("closeddate").ToString = "", Now.ToLongDateString, rst("closeddate").ToString)) & Environment.NewLine
        End While
        rst.Close()
        details += PrintSpaceLine() & Environment.NewLine


        Dim total As Double = 0
        com.CommandText = "call sp_salesremittance('CATEGORYSUMMARY','" & globalSalesTrnCOde & "','');" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftRigthText(StrConv(rst("Category").ToString(), VbStrConv.ProperCase), FormatNumber(Val(rst("Total").ToString()), 2)) & Environment.NewLine
            total = total + Val(rst("Total").ToString())
        End While
        rst.Close()
        da.Fill(st, 0)
         

        details += Environment.NewLine & PrintLeftRigthText("TOTAL", FormatNumber(total, 2)) & Environment.NewLine & Environment.NewLine

        details += PrintCenterText("- E N D   R E P O R T -") & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine
        details += PrintCenterText("Signature Over Printed Name")
        details += LastPagepaper()

        'If System.IO.File.Exists(Application.StartupPath & "\updateinfo.txt") = True Then
        '    System.IO.File.Delete(Application.StartupPath & "\updateinfo.txt")
        'End If
        'Dim detailsFile As StreamWriter = Nothing
        'detailsFile = New StreamWriter(Application.StartupPath.ToString & "\updateinfo.txt", True)
        'detailsFile.WriteLine("Coffeecup Client Update Logs" & Environment.NewLine & Environment.NewLine & details & "Winter S. Bugahod" & Environment.NewLine & "IT-Devt. Katipunan Bank")
        'detailsFile.Close()
        'Process.Start(Application.StartupPath & "\updateinfo.txt")
        If globalPosCustomFont = True Then
            globalPosCustomFont = False
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
            globalPosCustomFont = True
        Else
            POSPrint(details, globalSalesTrnCOde & " - blotter", "BLOTTER")
        End If
    End Sub

#Region "CREATE EMAIL NOTIFICATION"
    Public Function SendSalesReport()
        Dim SalesReports As String = ""
        Dim EmailList As String = ""
        com.CommandText = "select * from tblaccounts where notifysales=1" : rst = com.ExecuteReader
        While rst.Read
            EmailList = EmailList + rst("emailaddress").ToString + ","
        End While
        rst.Close()

        If EmailList.Length > 0 Then
            EmailList = EmailList.Remove(EmailList.Length - 1, 1)
        End If
         
        '------------------------------------------------------------------------------
        InsertEmailSalesBlotter("SALES", EmailList, If(globalBackDateTransaction = True, StrConv(globalBackDateRemarks, vbProperCase) & " " & ConvertDate(globalBackDate), If(GlobalShowsalesreportemailcaptionasoffice = True, StrConv(compOfficename, VbStrConv.ProperCase) & " Sales ", "Coffeecup Sales Report ") & ConvertDate(txtDateFrom.Text)), GenerateLXCashiersBlotter(globalSalesTrnCOde, Me, False), "")
        Return True
    End Function
#End Region

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If globalEnablePosPrinter = True Then
            If MessageBox.Show("Do you want to print as POS receipt blotter? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                PrintSalesBlotter()
            Else
                GenerateLXCashiersBlotter(globalSalesTrnCOde, Me, True)
            End If
        Else
            GenerateLXCashiersBlotter(globalSalesTrnCOde, Me, True)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'PrintSalesProductSummary()
        GenerateLXCashiersRemittance(globalSalesTrnCOde, Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmPOScashDonimination.Show(Me)
    End Sub

    Private Sub txt_NextcashBeginning_TextChanged(sender As Object, e As EventArgs) Handles txt_NextcashBeginning.TextChanged
        CashCalculator()
    End Sub
    Public Sub CashCalculator()
        txt_CashRemitted.Text = FormatNumber(Val(CC(txt_ActualCashOnHand.Text)) - Val(CC(txt_NextcashBeginning.Text)), 2)
    End Sub

    Private Sub txt_ActualCashOnHand_TextChanged(sender As Object, e As EventArgs) Handles txt_ActualCashOnHand.TextChanged
        CashCalculator()
    End Sub
End Class