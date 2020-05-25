Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmHotelGroupStatement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F3 Then
            cmdDiscount.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelGuestStatementLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        FilterDetails(txtBookingno.Text)
        ShowGuestInfo(txtBookingno.Text)
        If mode.Text = "view" Then
            cmdPayment.Visible = False
            linePayment.Visible = False
            cmdDiscount.Visible = False
            lineDiscount.Visible = False
            cmdChargetoAccount.Visible = False
            lineChargetoAccount.Visible = False
            cmdCheckout.Visible = False
            lineCheckOut.Visible = False
           
        End If
        For Each col In MyDataGridView.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub ShowGuestInfo(ByVal bookingno As String)
        com.CommandText = "select *,date_format(arival, '%M %d, %Y') as 'dt1', date_format(departure, '%M %d, %Y') as 'dt2', " _
                            + " (select agentname from tblhotelagent where code=tblhotelfolio.agentcode) as 'agent' from tblhotelfolio where bookno='" & bookingno & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDateArival.Text = rst("dt1").ToString
            txtdateCheckout.Text = rst("dt2").ToString
            guestid.Text = rst("guestid").ToString
            txtTotalDebit.Text = FormatNumber(rst("totalpackage").ToString, 2)
            txtAgent.Text = rst("agent").ToString
            txtFlight.Text = rst("flight").ToString
            txtRemarks.Text = rst("remarks").ToString
            If CBool(rst("closed")) = True Or CBool(rst("cancelled")) = True Then
                cmdPayment.Visible = False
                linePayment.Visible = False
                cmdDiscount.Visible = False
                lineDiscount.Visible = False
                cmdChargetoAccount.Visible = False
                lineChargetoAccount.Visible = False
                cmdCheckout.Visible = False
                lineCheckOut.Visible = False
                If CBool(rst("cancelled")) = True Then
                    cmdPrintStatement.Visible = False
                Else
                    cmdPrintStatement.Visible = True
                End If
            Else
                cmdPayment.Visible = True
                linePayment.Visible = True
                cmdDiscount.Visible = True
                lineDiscount.Visible = True
                If CBool(rst("confirmed")) = True Then
                    cmdChargetoAccount.Visible = True
                    lineChargetoAccount.Visible = True
                    cmdCheckout.Visible = True
                    lineCheckOut.Visible = True
                Else
                    cmdChargetoAccount.Visible = False
                    lineChargetoAccount.Visible = False
                    cmdCheckout.Visible = False
                    lineCheckOut.Visible = False
                End If
              End If
        End While
        rst.Close()

        com.CommandText = "select *,(select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as country  from tblhotelguest where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtGuest.Text = rst("fullname").ToString
            txtCountry.Text = rst("country").ToString
            txtAddress.Text = StrConv(rst("address").ToString, vbProperCase)
            txtBirthdate.Text = rst("birthdate").ToString
            txtGender.Text = rst("gender").ToString
            txtNationality.Text = rst("nationality").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmail.Text = rst("emailadd").ToString
        End While
        rst.Close()
        txtTotalDebit.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(debit),0) as ttl", "coffeecup_reports.tblbooking_" & bookingno), 2)
        txtTotalCredit.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(credit),0) as ttl", "coffeecup_reports.tblbooking_" & bookingno), 2)
        txtBalance.Text = FormatNumber(Val(CC(txtTotalDebit.Text)) - Val(CC(txtTotalCredit.Text)), 2)
        FilterCompanion()
    End Sub
    Public Sub FilterDetails(ByVal bookingno As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("call sp_bookingstatement('" & bookingno & "')", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id", "trnid"})
        GridColumnAlignment(MyDataGridView, {"Date Transaction", "Transaction Type", "Reference No."}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Debit (Charges)", "Credit (Payments)", "Running Balance"})

    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdPrintStatement_Click(sender As Object, e As EventArgs) Handles cmdPrintStatement.Click
        'GenerateLXGuestGroupStatement(txtBookingno.Text, MyDataGridView, Me)
    End Sub


    Private Sub cmdCheckout_Click(sender As Object, e As EventArgs) Handles cmdCheckout.Click
        If Val(CC(txtBalance.Text)) <> 0 Then
            MessageBox.Show("Transaction cannot proceed checkout! Please pay remaining balance to continue checkout", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Globalhotelmaintainancedefaultstatus = "" Then
            MessageBox.Show("Transaction cannot proceed checkout! Default house keeping checkout currently not configured", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If CDate(Now.ToShortDateString) < CDate(txtdateCheckout.Text) Then
            MessageBox.Show("You are about to perform early guest checkout! this required an administrative for approval", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then

                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("SELECT *,(ifnull((select sum(debit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0  and appliedcoupon=0),0) - ifnull((select sum(credit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0),0)) as 'bal' FROM `tblhotelroomtransaction` where bookingref='" & txtBookingno.Text & "' and closed=0 and cancelled=0;", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                If Val(CC(st.Tables(0).Rows(nt)("bal").ToString())) > 0 Then
                    com.CommandText = "insert into tblhoteltransaction set folioid='" & st.Tables(0).Rows(nt)("folioid").ToString() & "', guestid='" & guestid.Text & "', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', remarks='Paid by group folio# " & txtBookingno.Text & "', credit='" & Val(CC(st.Tables(0).Rows(nt)("bal").ToString())) & "',offsetpayment=1, datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    com.CommandText = "Update tblhotelroomtransaction set datecheckout=current_date, timecheckout=current_time, totalamount='" & Val(CC(st.Tables(0).Rows(nt)("bal").ToString())) & "', offsetbalance='" & Val(CC(st.Tables(0).Rows(nt)("bal").ToString())) & "', closed=1, dateclosed=current_timestamp where folioid='" & st.Tables(0).Rows(nt)("folioid").ToString() & "'" : com.ExecuteNonQuery()
                End If
                If Globalenablehotelmaintainanceuponcheckout = True Then
                    com.CommandText = "update tblhotelrooms set occupied=0, maintainance=1, roomstatus='" & Globalhotelmaintainancedefaultstatus & "',remarks='CHECK OUT' where roomid='" & st.Tables(0).Rows(nt)("roomid").ToString() & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "Update tblhotelrooms set occupied=0 where roomid='" & st.Tables(0).Rows(nt)("roomid").ToString() & "'" : com.ExecuteNonQuery()
                End If
            Next
            com.CommandText = "Update tblhotelfolio set closed=1, dateclosed=current_timestamp, closedby='" & globaluserid & "' where bookno='" & txtBookingno.Text & "'" : com.ExecuteNonQuery()
            frmHotelManagement.tabFilter()
            'PrintCheckoutSlipGroup(txtBookingno.Text)
            MessageBox.Show("Transaction successfully checked out", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    'Private Sub cmdPostPayment_Click(sender As Object, e As EventArgs) Handles cmdDiscount.Click
    '    frmHotelDiscount.bookingno.Text = txtBookingno.Text
    '    frmHotelDiscount.mode.Text = guestid.Text
    '    frmHotelDiscount.txtRoomNo.Text = txtBalance.Text
    '    frmHotelDiscount.Show(Me)
    'End Sub

    'Private Sub cmdCancelTransaction_Click(sender As Object, e As EventArgs) Handles cmdCancelTransaction.Click
    '    If Val(CC(MyDataGridView.Item("Credit (Payments)", MyDataGridView.CurrentRow.Index).Value().ToString)) = 0 Then
    '        MessageBox.Show("Cancellation of debit transaction are not allowed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Exit Sub
    '    End If
    '    If MessageBox.Show("Cancelling transaction needs an administrative approval. Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
    '        frmPOSAdminConfirmation.ShowDialog(Me)
    '        If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
    '            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
    '                If rw.Cells("Transaction Type").Value.ToString = "PAYMENT" Then
    '                    com.CommandText = "UPDATE tblhoteltransaction set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp,approvedcancelledby='" & frmPOSAdminConfirmation.userid.Text & "' where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
    '                ElseIf rw.Cells("Transaction Type").Value.ToString = "DISCOUNT" Then
    '                    com.CommandText = "DELETE FROM tblhotelroomsdiscounttransaction where id='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
    '                End If

    '            Next
    '            FilterDetails(txtBookingno.Text)
    '            ShowGuestInfo(txtBookingno.Text)
    '            MessageBox.Show("Transaction successfully cencelled", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            frmPOSAdminConfirmation.ApprovedConfirmation = False
    '            frmPOSAdminConfirmation.Dispose()
    '        End If
    '    End If
    'End Sub


    Private Sub cmdChargetoAccount_Click(sender As Object, e As EventArgs) Handles cmdChargetoAccount.Click
        If CDate(Now.ToShortDateString) < CDate(txtdateCheckout.Text) Then
            MessageBox.Show("You are about to perform early guest checkout! this required an administrative for approval", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then

                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Exit Sub
            End If
        End If
        'If MessageBox.Show("Please print guest statement of account for billing attachment! If done click YES", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
        '    frmHotelChargeAccount.foliono.Text = txtBookingno.Text
        '    frmHotelChargeAccount.guestid.Text = guestid.Text
        '    frmHotelChargeAccount.ckGroup.Checked = True
        '    frmHotelChargeAccount.txtAmountTender.Text = txtBalance.Text
        '    frmHotelChargeAccount.txtRemarks.Text = "Folio#" & txtBookingno.Text & " Date Check-in: " & CDate(txtDateArival.Text).ToString("M/dd/yyyy")
        '    frmHotelChargeAccount.Show(Me)
        'End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles cmdPayment.Click
        'frmHotelPaymentPosting.foliono.Text = txtBookingno.Text
        frmHotelPaymentPosting.txtAmountTender.Text = txtBalance.Text
        frmHotelPaymentPosting.Show(Me)
    End Sub

    Private Sub ViewFolioStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFolioStatementToolStripMenuItem.Click
        If MyDataGridView.Item("Transaction Type", MyDataGridView.CurrentRow.Index).Value().ToString <> "FOLIO" Then
            MessageBox.Show("Only folio transaction can be view!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmHotelGuestStatementLedger.Folioid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        If frmHotelGuestStatementLedger.Visible = False Then
            frmHotelGuestStatementLedger.Show(Me)
        Else
            frmHotelGuestStatementLedger.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterDetails(txtBookingno.Text)
        ShowGuestInfo(txtBookingno.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDate.Text = CDate(Now).ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

#Region "COMPANION"
    Public Sub FilterCompanion()
        MyDataGridView_Companion.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select id, Fullname, Age from tblhotelguestcompanion where bookno='" & txtBookingNo.Text & "'", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Companion.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Companion, {"id"})
        GridColumnAlignment(MyDataGridView_Companion, {"Age"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnWidth(MyDataGridView_Companion, {"Fullname"}, 300)
        GridColumnWidth(MyDataGridView_Companion, {"Age"}, 60)
    End Sub
    Private Sub cmdAddCompanion_Click(sender As Object, e As EventArgs) Handles cmdAddCompanion.Click
        BookingNo = txtBookingNo.Text
        frmHotelGuestCompanion.Show(Me)
    End Sub
    Private Sub cmdEditCompanion_Click(sender As Object, e As EventArgs) Handles cmdEditCompanion.Click
        BookingNo = txtBookingNo.Text
        frmHotelGuestCompanion.id.Text = MyDataGridView_Companion.Item("id", MyDataGridView_Companion.CurrentRow.Index).Value().ToString
        frmHotelGuestCompanion.mode.Text = "edit"
        frmHotelGuestCompanion.Show(Me)
    End Sub
    Private Sub MyDataGridView_Companion_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Companion.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Companion.CurrentCell = Me.MyDataGridView_Companion.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdRemoveCompanion_Click(sender As Object, e As EventArgs) Handles cmdRemoveCompanion.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "DELETE from tblhotelguestcompanion where id='" & MyDataGridView_Companion.Item("id", MyDataGridView_Companion.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterCompanion()
        End If
    End Sub
    Private Sub cmdRefreshCompanion_Click(sender As Object, e As EventArgs) Handles cmdRefreshCompanion.Click
        FilterCompanion()
    End Sub
#End Region
End Class