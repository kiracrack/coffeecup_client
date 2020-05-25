Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSTagtoRoomTransaction
    Public TransactionDone As Boolean = False
    Dim DefaultglItemLocation As String
    Dim defaultglCode As String
    Dim defaultglItem As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadTransactionInformation()
        folioid.Text = ""
        txtRoomNumber.Text = ""
        guestid.Text = ""
        txtGuestName.Text = ""
        If Globalhotelitemizedcharge = True Then
            lblremarks.Text = "Remarks"
            txtRemarks.Location = New Point(135, txtRemarks.Location.Y)
            txtRemarks.Size = New Size(295, txtRemarks.Height)
        Else
            lblremarks.Text = "Guest Check No."
            txtRemarks.Location = New Point(210, txtRemarks.Location.Y)
            txtRemarks.Size = New Size(219, txtRemarks.Height)
        End If
    End Sub

    Private Sub txtRoomNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoomNumber.KeyPress
        If e.KeyChar = Chr(13) Then
            If countqry("tblhotelfolioroom", "roomno='" & rchar(txtRoomNumber.Text) & "' and inhouse=1 and checkout=0 and cancelled=0") = 0 Then
                MessageBox.Show("Room Not found", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                roomid.Text = ""
                txtGuestName.Text = ""
                txtRoomNumber.Focus()
                Exit Sub
            End If
            ShowRoomInfo()
        End If
    End Sub

    Public Sub ShowRoomInfo()
        Dim ratingsid As String = ""
        com.CommandText = "select *,(select fullname from tblhotelguest where guestid = tblhotelfolioroom.guestid) as 'guest',(select ratings from tblhotelguest where guestid = tblhotelfolioroom.guestid) as 'ratings',  " _
            + " (select (select companyid from tblcompoffice where officeid=tblhotelgroup.officeid) from tblhotelgroup where hotelcif=tblhotelfolioroom.hotelcif) as company " _
            + " from  tblhotelfolioroom where roomno='" & rchar(txtRoomNumber.Text) & "' and inhouse=1 and checkout=0 and closed=0 and cancelled=0" : rst = com.ExecuteReader
        While rst.Read
            folioid.Text = rst("folioid").ToString
            foliono.Text = rst("foliono").ToString
            guestid.Text = rst("guestid").ToString
            roomid.Text = rst("roomid").ToString
            txtGuestName.Text = rst("guest").ToString
            companyid.Text = rst("company").ToString
            ratingsid = rst("ratings").ToString
        End While
        rst.Close()

        If ratingsid.Length > 0 Then
            com.CommandText = "select * from tblhotelguestratings where code='" & ratingsid & "'" : rst = com.ExecuteReader
            While rst.Read
                txtRatings.Text = rst("ratingsname").ToString
                txtRewardPrevileges.Text = rst("description").ToString
                ChangeColor(txtRatings, rst("colorback").ToString, rst("colorfont").ToString)
            End While
            rst.Close()
        Else
            txtRatings.Text = "UNRATED LEVEL"
            txtRatings.ForeColor = DefaultForeColor
            txtRatings.BackColor = DefaultBackColor
        End If

        If Globalhotelitemizedcharge = True Then
            txtRemarks.Focus()
        Else
            txtGuestCheckno.Focus()
        End If
        Me.AcceptButton = cmdConfirmPayment
    End Sub

    Public Sub ChangeColor(ByVal lbl As Label, ByVal backcolor As String, ByVal fontcolor As String)
        Dim RGBback As String() = backcolor.Split(",")
        Dim RGBfont As String() = fontcolor.Split(",")

        If backcolor.Length > 0 Then
            lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGBback(0)), Byte), Integer), CType(CType(Val(RGBback(1)), Byte), Integer), CType(CType(Val(RGBback(2)), Byte), Integer))
            lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGBfont(0)), Byte), Integer), CType(CType(Val(RGBfont(1)), Byte), Integer), CType(CType(Val(RGBfont(2)), Byte), Integer))
        Else
            lbl.BackColor = DefaultBackColor : lbl.ForeColor = DefaultForeColor
        End If

    End Sub

    Public Sub LoadTransactionInformation()
        lblTransaction.Text = "Transaction Reference # " & txtBatchcode.Text & ")"
        txtTotalOnScreen.Text = FormatNumber(Val(qrysingledata("total", "sum(total) as 'total'", "tblsalestransaction where batchcode='" & txtBatchcode.Text & "' and tblsalestransaction.cancelled=0")), 2)
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If folioid.Text = "" Then
            MsgBox("Please enter valid check-in guest room number!", MsgBoxStyle.Exclamation, "Error Message")
            txtRoomNumber.Focus()
            Exit Sub

        ElseIf countqry("tblsalestransaction", "total<0 and adjoveride=0 and  batchcode='" & txtBatchcode.Text & "' and cancelled=0 and void=0") > 0 Then
            MessageBox.Show("Your transaction contains adjustment or discount currently for approval!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmdConfirmPayment.Focus()
            Exit Sub

        End If
        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If countqry("tblhotelcashtransaction", "batchcode='" & txtBatchcode.Text & "' and foliono='" & foliono.Text & "'") > 0 Then
                com.CommandText = "DELETE from tblhotelcashtransaction where batchcode='" & txtBatchcode.Text & "' and foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            End If
            com.CommandText = "insert into tblhotelcashtransaction set batchcode='" & txtBatchcode.Text & "', folioid='" & folioid.Text & "', foliono='" & foliono.Text & "', hotelcifid='" & hotelcifid.Text & "', guestid='" & guestid.Text & "', roomid='" & roomid.Text & "', roomno='" & txtRoomNumber.Text & "', trnsumcode='" & globalSalesTrnCOde & "',officeid='" & compOfficeid & "', guestcheckno='" & txtGuestCheckno.Text & "', remarks='" & rchar(txtRemarks.Text) & "',amount='" & Val(CC(txtTotalOnScreen.Text)) & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            MessageBox.Show("Transaction successfully tag to room number " & txtRoomNumber.Text & "!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub txtGuestCheckno_TextChanged(sender As Object, e As EventArgs) Handles txtGuestCheckno.TextChanged
        txtRemarks.Text = "Guest Check# " & txtGuestCheckno.Text
    End Sub

    Private Sub txtRoomNumber_GotFocus(sender As Object, e As EventArgs) Handles txtRoomNumber.GotFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub frmPOSChargetoHotelAcct_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        '  Dispose()
    End Sub
End Class