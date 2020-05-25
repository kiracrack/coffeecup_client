Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Data.OleDb

Public Class frmHotelTransactionsHistory
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
       
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSTransactionsHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        tabFilter()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub
    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabHotelCharges Then
            MyDataGridView_Detail.Parent = TabControl1.SelectedTab
            HotelCharges()
            MyDataGridView_Detail.ContextMenuStrip = cms_em
        ElseIf TabControl1.SelectedTab Is tabChargefromPOS Then
            MyDataGridView_Detail.Parent = TabControl1.SelectedTab
            ChargeFromPOS()
            MyDataGridView_Detail.ContextMenuStrip = Nothing
        ElseIf TabControl1.SelectedTab Is tabPayment Then
            MyDataGridView_Detail.Parent = TabControl1.SelectedTab
            PaymentTransaction()
            MyDataGridView_Detail.ContextMenuStrip = cms_em
        End If
    End Sub
   
    Public Sub HotelCharges()
        MyDataGridView_Detail.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select trnid,datetrn,datetrn as 'Date Transaction', foliono as 'Folio Number', " _
                                            + " (select fullname from tblhotelguest where guestid = tblhotelfoliotransaction.guestid) as 'Guest', " _
                                            + " (select roomno from tblhotelfolioroom where folioid = tblhotelfoliotransaction.folioid) as 'Room Number', " _
                                            + " (select description from tblhotelfolioroom where folioid = tblhotelfoliotransaction.folioid) as 'Room Type', " _
                                            + "  if(appliedcoupon=1,concat(remarks,' (Covered by Coupon)'),remarks)  as 'Description', debit as 'Amount' from tblhotelfoliotransaction where debit>0 and chargefrompos=0 and cancelled=0  and paymenttrn=0 and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select '',current_timestamp,null,'','','','','Total',sum(debit) from tblhotelfoliotransaction where debit>0 and chargefrompos=0 and cancelled=0 and paymenttrn=0 and trnsumcode='" & globalSalesTrnCOde & "') as s  order by datetrn asc;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Detail.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Detail, {"datetrn"})
        GridCurrencyColumn(MyDataGridView_Detail, {"Amount"})
        GridColumnAlignment(MyDataGridView_Detail, {"Folio Number", "Room Type", "Reference No.", "Room Number"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Detail, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub ChargeFromPOS()
        MyDataGridView_Detail.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select datetrn,datetrn as 'Date Transaction', foliono as 'Folio Number', " _
                                            + " (select fullname from tblhotelguest where guestid = tblhotelfoliotransaction.guestid) as 'Guest', " _
                                            + " (select roomno from tblhotelfolioroom where folioid = tblhotelfoliotransaction.folioid) as 'Room Number', " _
                                            + " referenceno as 'Reference No.',  if(appliedcoupon=1,concat(remarks,' (Covered by Coupon)'),remarks)  as 'Description', debit as 'Amount' from tblhotelfoliotransaction where debit>0 and chargefrompos=1 and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                            + " select current_timestamp,null,'', '', '','','Total',sum(debit) from tblhotelfoliotransaction where debit>0 and chargefrompos=1 and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "') as s  order by datetrn asc;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Detail.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Detail, {"datetrn"})

        GridCurrencyColumn(MyDataGridView_Detail, {"Amount"})
        GridColumnAlignment(MyDataGridView_Detail, {"Folio Number", "Reference No.", "Room Number"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Detail, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Public Sub PaymentTransaction()
        MyDataGridView_Detail.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  s.* from (select trnid,datetrn,datetrn as 'Date Transaction', foliono as 'Folio Number', " _
                                           + " (select fullname from tblhotelguest where guestid = tblhotelfoliotransaction.guestid) as 'Guest', " _
                                           + " (select roomno from tblhotelfolioroom where folioid = tblhotelfoliotransaction.folioid) as 'Room Number', " _
                                           + " referenceno as 'Reference No.',  if(appliedcoupon=1,concat(remarks,' (Covered by Coupon)'),remarks)  as 'Description', credit as 'Amount' from tblhotelfoliotransaction where credit>0 and paymenttrn=1 and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "' union all " _
                                           + " select '',current_timestamp,null,'', '', '','','Total',sum(credit)+ifnull((select sum(paymentdeposit) from tblhotelroomreservation where credit>0 and expired=0 and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "'),0) from tblhotelfoliotransaction where paymenttrn=1 and cancelled=0 and trnsumcode='" & globalSalesTrnCOde & "') as s  order by datetrn asc;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Detail.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Detail, {"datetrn", "trnid"})

        GridCurrencyColumn(MyDataGridView_Detail, {"Amount"})
        GridColumnAlignment(MyDataGridView_Detail, {"Folio Number", "Reference No.", "Room Number"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Detail, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView_Detail.Rows(MyDataGridView_Detail.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Detail.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Detail.CurrentCell = Me.MyDataGridView_Detail.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdClose_Click_1(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/><strong>" & TabControl1.SelectedTab.Text & "</strong>", TabControl1.SelectedTab.Text, "Cashier: " & globalfullname & "<br/>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy"), MyDataGridView_Detail, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Cancelling transaction needs an administrative approval. Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                If TabControl1.SelectedTab Is tabHotelCharges Then
                    com.CommandText = "UPDATE tblhotelfoliotransaction set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where trnid='" & MyDataGridView_Detail.Item("trnid", MyDataGridView_Detail.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()

                ElseIf TabControl1.SelectedTab Is tabPayment Then
                    CancelPaymentTransaction(MyDataGridView_Detail.Item("Reference No.", MyDataGridView_Detail.CurrentRow.Index).Value().ToString)
                    com.CommandText = "UPDATE tblhotelfoliotransaction set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where trnid='" & MyDataGridView_Detail.Item("trnid", MyDataGridView_Detail.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()

                End If

                MessageBox.Show("Transaction successfully cencelled", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                tabFilter()

                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Exit Sub
            End If
        End If
    End Sub
 
End Class