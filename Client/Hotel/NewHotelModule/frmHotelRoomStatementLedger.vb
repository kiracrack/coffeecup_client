Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmHotelRoomStatementLedger
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelGuestStatementLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ShowRoomInfo(folioid.Text)
    End Sub

    Public Sub ShowRoomInfo(ByVal folioid As String)
        com.CommandText = "SELECT *,date_format(current_timestamp, '%M %d, %Y %r') as 'dateledger',date_format(arival, '%M %d, %Y') as 'checkindate', date_format(timecheckin, '%r') as 'checkintime',date_format(departure, '%M %d, %Y') as 'checkoutdate', date_format(timecheckout, '%r') as 'timecheckout' FROM tblhotelfolioroom where folioid='" & folioid & "'" : rst = com.ExecuteReader
        While rst.Read
            foliono.Text = rst("foliono").ToString
            txtGuest.Text = rst("roomno").ToString & " - " & rst("description").ToString
            txtDateCheckinOut.Text = rst("checkindate").ToString + " - " + rst("checkoutdate").ToString
            txtCurrentCheckout.Value = rst("departure").ToString

            ckPerRoom.Checked = CBool(rst("chargepernight"))
            If CBool(rst("inhouse")) = True Then
                If CBool(rst("checkout")) = True Then
                    DisableButton(True)
                Else
                    DisableButton(False)
                End If
            Else
              DisableButton(True)
            End If
        End While
        rst.Close()

        LoadRoomConsolidated(folioid)
        LoadRoomTransaction(folioid)
        LoadPOSTransaction(folioid)
        LoadPaymentTransaction(folioid)
    End Sub
    Public Sub DisableButton(ByVal disable As Boolean)
        If disable = True Then
            cmdExtend.Visible = False
            lineExtend.Visible = False
            cmdCheckout.Visible = False
            lineCheckOut.Visible = False
        Else
            cmdExtend.Visible = True
            lineExtend.Visible = True
            cmdCheckout.Visible = True
            lineCheckOut.Visible = True
        End If
    End Sub

    Public Sub LoadRoomConsolidated(ByVal folioid As String)
        LoadXgrid("call sp_folio_roomstatement('" & folioid & "')", "call sp_folio_roomstatement('" & folioid & "')", Em, GridView_consolidated)
        XgridColCurrency({"Debit (Charges)", "Credit (Payments)", "Running Balance"}, GridView_consolidated)
        XgridColAlign({"Date", "ChargeFrom"}, GridView_consolidated, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Debit (Charges)", "Credit (Payments)"}, GridView_consolidated)
        XgridColWidth({"Debit (Charges)", "Credit (Payments)", "Running Balance"}, GridView_consolidated, 120)

        For Each col In GridView_consolidated.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next
    End Sub
    Public Sub LoadRoomTransaction(ByVal folioid As String)
        LoadXgrid("SELECT date_format(datetrn,'%Y-%m-%d')  as Date, Adult, AdultRate as " & If(ckPerRoom.Checked = True, "'Room Rate'", "'Pax Rate'") & ",Child,ChildRate as 'Child Rate',Extra as 'Extra Person',extraRate as 'Extra Person Rate',Total FROM `tblhotelfolioroomsummary` where folioid='" & folioid & "'", "tblhotelfolioroomsummary", Em_rooms, GridView_rooms)
        XgridColCurrency({If(ckPerRoom.Checked = True, "Room Rate", "Pax Rate"), "Child Rate", "Extra Person Rate", "Total"}, GridView_rooms)
        XgridColAlign({"Date", "Adult", "Child", "Extra Person"}, GridView_rooms, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView_rooms)
        XgridColWidth({"Date", "Total"}, GridView_rooms, 120)

        For Each col In GridView_rooms.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next
    End Sub

    Public Sub LoadPOSTransaction(ByVal folioid As String)
        LoadXgrid("select date_format(datetrn, '%Y-%m-%d') as 'Date',(select officename from tblcompoffice where officeid=tblhotelfoliotransaction.officeid) as 'Charge From', concat('#',referenceno) as 'Reference', Remarks, debit as Amount, (select fullname from tblaccounts where accountid=tblhotelfoliotransaction.trnby) as 'Transaction By'  from tblhotelfoliotransaction where folioid='" & folioid & "' and chargefrompos=1 and cancelled=0 order by datetrn asc", "tblhotelfoliotransaction", Em_POS, GridView_POS)
        XgridColCurrency({"Amount"}, GridView_POS)
        XgridColAlign({"Date", "Reference"}, GridView_POS, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_POS)
        XgridGroupSummaryCurrency({"Amount"}, GridView_POS)
        XgridColWidth({"Amount"}, GridView_POS, 120)

        For Each col In GridView_POS.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next
    End Sub


    Public Sub LoadPaymentTransaction(ByVal folioid As String)
        LoadXgrid("select trnid,referenceno, datetrn as 'Date Posted',  Remarks, credit as Amount,concat('#',referenceno) as 'Reference', (select fullname from tblaccounts where accountid=tblhotelfoliotransaction.trnby) as 'Transaction By'  from tblhotelfoliotransaction where folioid='" & folioid & "' and paymenttrn=1 and cancelled=0 order by datetrn asc", "tblhotelfoliotransaction", Em_Payment, GridView_Payment)
        XgridHideColumn({"trnid", "referenceno"}, GridView_Payment)
        XgridColCurrency({"Amount"}, GridView_Payment)
        XgridColAlign({"Date Posted", "Reference"}, GridView_Payment, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_Payment)
        XgridColWidth({"Amount"}, GridView_Payment, 120)

        For Each col In GridView_POS.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next
    End Sub

    Private Sub cmdPrintStatement_Click(sender As Object, e As EventArgs) Handles cmdPrintStatement.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Print room " & GetRoomFolioInfo(folioid.Text, "roomno") & " " & TabControl1.SelectedTab.Text & " tab")
        If TabControl1.SelectedTab Is tabConsolidated Then
            GenerateLXRoomStatement(folioid.Text, TabControl1.SelectedTab.Text, GridView_consolidated, Me)
        ElseIf TabControl1.SelectedTab Is tabRoomCharges Then
            GenerateLXRoomStatement(folioid.Text, TabControl1.SelectedTab.Text, GridView_rooms, Me)
        ElseIf TabControl1.SelectedTab Is tabPOSTransaction Then
            GenerateLXRoomStatement(folioid.Text, TabControl1.SelectedTab.Text, GridView_POS, Me)
        ElseIf TabControl1.SelectedTab Is tabPayment Then
            GenerateLXRoomStatement(folioid.Text, TabControl1.SelectedTab.Text, GridView_Payment, Me)
        End If

    End Sub

    Private Sub cmdCheckout_Click(sender As Object, e As EventArgs) Handles cmdCheckout.Click
        If MessageBox.Show("Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Check-out room " & GetRoomFolioInfo(folioid.Text, "roomno"))
            com.CommandText = "update tblhotelfolioroom set checkout=1 ,timecheckout=current_time where folioid='" & folioid.Text & "'" : com.ExecuteNonQuery()
            ShowRoomInfo(folioid.Text)
            MessageBox.Show("Room successfull checkout!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdExtend_Click(sender As Object, e As EventArgs) Handles cmdExtend.Click
        frmHotelAddExtraNight.foliono.Text = foliono.Text
        frmHotelAddExtraNight.folioid.Text = folioid.Text
        frmHotelAddExtraNight.currentCheckout.Value = txtCurrentCheckout.Value
        frmHotelAddExtraNight.txtdateCheckout.MinDate = txtCurrentCheckout.Value.AddDays(1)
        frmHotelAddExtraNight.Show(Me)
    End Sub
End Class