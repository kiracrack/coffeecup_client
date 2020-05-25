Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmHotelPackageSelection
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelRoomTypeSelection_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CheckUnprocessedRooms()
    End Sub

    Private Sub frmHotelEditFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ListView1.View = View.Details

        ListView1.Columns.Add("Package Name", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Room Rate", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Child Rate", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Extra Person Rate", -2, HorizontalAlignment.Right)
        ListView1.Columns.Add("Code", -2, HorizontalAlignment.Center)

        ListView1.Columns(0).Width = 150
        ListView1.Columns(1).Width = 80
        ListView1.Columns(2).Width = 80
        ListView1.Columns(3).Width = 80
        ListView1.Columns(4).Width = 0
        LoadRoomType()
        CheckUnprocessedRooms()
    End Sub

    Public Sub LoadRoomType()
        LoadToComboBoxDB("select code, ucase(description) as room_type from tblhotelroomtype where hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') ", "room_type", "code", txtRoomType)
    End Sub

    Public Sub LoadRates()
        ListView1.Items.Clear()
        If txtRoomType.Text = "" Then Exit Sub
        com.CommandText = "select *, ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='roomrate' and dayrate=0),0) as roomrate, " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='child' and dayrate=0),0) as childrate, " _
                                                + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='extra' and dayrate=0),0) as extraperson " _
                                                + " from tblhotelroomrates as a where actived=1 and lockrate=1 and temporaryrate=0 and roomtype='" & roomtype.Text & "' and deleted=0 order by description asc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("description").ToString, 0)
            item1.SubItems.Add(FormatNumber(rst("roomrate").ToString, 2))
            item1.SubItems.Add(FormatNumber(rst("childrate").ToString, 2))
            item1.SubItems.Add(FormatNumber(rst("extraperson").ToString, 2))
            item1.SubItems.Add(rst("ratecode").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub


    Private Sub txtRoomType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomType.SelectedValueChanged
        roomtype.Text = DirectCast(txtRoomType.SelectedItem, ComboBoxItem).HiddenValue()
        LoadRates()
    End Sub

    Private Sub cmdRoomTariff_Click(sender As Object, e As EventArgs) Handles cmdRoomTariff.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each itm As ListViewItem In ListView1.CheckedItems
                If countqry("tblhotelroomrates", "originrate='" & itm.SubItems(4).Text & "' and bookingno='" & foliono.Text & "' and temporaryrate=1") = 0 Then

                    Dim rateid As String = qrysingledata("newratecode", "ratecode+1 as newratecode", "tblhotelroomrates order by ratecode desc limit 1")

                    com.CommandText = "INSERT INTO tblhotelroomrates set ratecode='" & rateid & "', roomtype='" & roomtype.Text & "',description='" & rchar(itm.SubItems(0).Text) & "',allowzerorate=0,actived=1,lockrate=0,temporaryrate=1,originrate='" & itm.SubItems(4).Text & "', onlinerate=0,packagedetails='',bookingno='" & foliono.Text & "', addedby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO tblhotelratesbreakdown (roomtype,ratecode,dayrate,breakdowntype,itemcode,itemname,amount) " _
                                           + " SELECT '" & roomtype.Text & "','" & rateid & "',dayrate,breakdowntype,itemcode,itemname,amount FROM tblhotelratesbreakdown where ratecode='" & itm.SubItems(4).Text & "'" : com.ExecuteNonQuery()

                End If
            Next
            frmHotelCustomPackage.foliono.Text = foliono.Text
            frmHotelCustomPackage.ShowDialog(Me)
        End If

      

    End Sub

    Private Sub cmdTemporaryRoomLogs_Click(sender As Object, e As EventArgs) Handles cmdTemporaryRoomLogs.Click
        frmHotelTemporaryRoom.foliono.Text = foliono.Text
        frmHotelTemporaryRoom.ShowDialog(Me)
    End Sub

    Public Sub CheckUnprocessedRooms()
        If frmHotelTemporaryRoom.MyDataGridView.RowCount > 0 Then
            lineViewUnprocessedRoom.Visible = True
            cmdTemporaryRoomLogs.Visible = True
            cmdTemporaryRoomLogs.Text = "View Unprocessed Rooms (" & frmHotelTemporaryRoom.MyDataGridView.RowCount & ")"
        Else
            lineViewUnprocessedRoom.Visible = False
            cmdTemporaryRoomLogs.Visible = False
        End If
    End Sub

    Private Sub cmdRoomSelection_Click(sender As Object, e As EventArgs) Handles cmdRoomSelection.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each itm As ListViewItem In ListView1.CheckedItems
                If countqry("tblhotelroomrates", "originrate='" & itm.SubItems(4).Text & "' and bookingno='" & foliono.Text & "' and temporaryrate=1") = 0 Then

                    Dim rateid As String = qrysingledata("newratecode", "ratecode+1 as newratecode", "tblhotelroomrates order by ratecode desc limit 1")

                    com.CommandText = "INSERT INTO tblhotelroomrates set ratecode='" & rateid & "', roomtype='" & roomtype.Text & "',description='" & rchar(itm.SubItems(0).Text) & "',allowzerorate=0,actived=1,lockrate=0,temporaryrate=1,originrate='" & itm.SubItems(4).Text & "', onlinerate=0,packagedetails='',bookingno='" & foliono.Text & "', addedby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO tblhotelratesbreakdown (roomtype,ratecode,dayrate,breakdowntype,itemcode,itemname,amount) " _
                                           + " SELECT '" & roomtype.Text & "','" & rateid & "',dayrate,breakdowntype,itemcode,itemname,amount FROM tblhotelratesbreakdown where ratecode='" & itm.SubItems(4).Text & "'" : com.ExecuteNonQuery()

                End If
            Next
            Me.Hide()
            frmHotelPickMultipleRoom.guestid.Text = guestid.Text
            frmHotelPickMultipleRoom.foliono.Text = foliono.Text
            frmHotelPickMultipleRoom.txtDateArival.Value = frmHotelCheckInTransactionV2.txtDateArival.Value
            frmHotelPickMultipleRoom.txtdateCheckout.Value = frmHotelCheckInTransactionV2.txtDeparture.Value
            frmHotelPickMultipleRoom.roomtype.Text = roomtype.Text
            frmHotelPickMultipleRoom.txtRoomType.Text = txtRoomType.Text

            If frmHotelPickMultipleRoom.Visible = True Then
                frmHotelPickMultipleRoom.Focus()
            Else
                frmHotelPickMultipleRoom.Show(frmHotelCheckInTransactionV2)
            End If
        End If

    End Sub
End Class