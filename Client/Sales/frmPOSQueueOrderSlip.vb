Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSQueueOrderSlip

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = (Keys.Enter) Then
            For Each itm As ListViewItem In ListView1.Items
                If itm.Selected Then
                    If MessageBox.Show("Are you sure you want to restore selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        com.CommandText = "update tblsalesbatch set userid='" & globalTransactionUserid & "', trnsumcode='" & globalSalesTrnCOde & "' , onhold=0 where batchcode='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsalestransaction set trnsumcode='" & globalSalesTrnCOde & "',onhold=0 where batchcode='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                        frmPointOfSale.cifid.Text = qrysingledata("val", "cifid as 'val'", "tblsalesbatch where batchcode='" & itm.SubItems(1).Text & "'")
                        frmPointOfSale.txtClient.Text = qrysingledata("val", "(select companyname from tblclientaccounts where cifid=tblsalesbatch.cifid) as 'val'", "tblsalesbatch where batchcode='" & itm.SubItems(1).Text & "'")
                        frmPointOfSale.txtBatchcode.Text = itm.SubItems(1).Text
                        frmPointOfSale.ValidatePOSTransaction(itm.SubItems(1).Text)
                        Me.Close()
                    End If
                End If
            Next
        ElseIf keyData = (Keys.Control) + Keys.P Then
            If globalAssistantUserId = "" Then
                For Each itm As ListViewItem In ListView1.Items
                    If itm.Selected Then
                        If MessageBox.Show("Are you sure you want to print selected transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            PrintPOSOderSlip(itm.SubItems(1).Text, itm.SubItems(0).Text, itm.SubItems(4).Text)
                        End If
                    End If
                Next
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRestaurantTableQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Text = GlobalQueuingSlipType & " Views - Press Enter to Execute | Press F5 to Refresh List | Press Ctrl+P to Print Order Slip "
        ImageMenu.Images.Clear()
        ListView1.Items.Clear()
        ImageMenu.ImageSize = New Size(60, 60)
        com.CommandText = "select ifnull((select icon from tblsalesqueuingslip where queuecode=tblsalesbatch.onholdqueuecode),null) as ico from tblsalesbatch where onhold=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "' " & If(globalAssistantUserId = "", "", " and attendingperson='" & globalAssistantUserId & "'") & " order by onholdqueuecode asc" : rst = com.ExecuteReader
        While rst.Read
            If rst("ico").ToString <> "" Then
                ImageMenu.Images.Add(ConvertImage("ico"))
            End If
        End While
        rst.Close()
        ListView1.View = View.Tile
        ListView1.TileSize = New Size(250, 100)
        ListView1.Columns.Add("Name", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("batchcode", 0, HorizontalAlignment.Left)
        ListView1.Columns.Add("Items", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Balance", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Processed By", 100, HorizontalAlignment.Left)
        ListView1.LargeImageList = ImageMenu
        Dim cnt As Integer = 0
        com.CommandText = "select *, ifnull((select description from tblsalesqueuingslip where queuecode=tblsalesbatch.onholdqueuecode),'Missing Table') as queue,(select fullname from tblaccounts where accountid=tblsalesbatch.attendingperson) as 'SalesPerson', (select count(*) from tblsalestransaction where batchcode=tblsalesbatch.batchcode and cancelled=0 and void=0) as item, ifnull((select sum(total) from tblsalestransaction where batchcode=tblsalesbatch.batchcode and cancelled=0 and void=0),0) as ttl from tblsalesbatch where onhold=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "' " & If(globalAssistantUserId = "", "", " and attendingperson='" & globalAssistantUserId & "'") & " order by onholdqueuecode asc" : rst = com.ExecuteReader
        'com.CommandText = "select *, ifnull((select description from tblsalesqueuingslip where queuecode=tblsalesbatch.onholdqueuecode),'Missing Table') as queue,(select fullname from tblaccounts where accountid=tblsalesbatch.trnby) as 'SalesPerson', (select count(*) from tblsalestransaction where batchcode=tblsalesbatch.batchcode and cancelled=0 and void=0) as item, ifnull((select sum(total) from tblsalestransaction where batchcode=tblsalesbatch.batchcode and cancelled=0 and void=0),0) as ttl from tblsalesbatch where onhold=1 and void=0 " & If(Globalallowaccessallonhold = False, " and (userid='" & globaluserid & "'  or userid='" & globalAssistantUserId & "' or trnsumcode in (select trncode from tblsalessummary where userid='" & globaluserid & "' and openfortrn=1))", "") & " order by onholdqueuecode asc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("queue").ToString, cnt)
            item1.SubItems.Add(rst("batchcode").ToString)
            item1.SubItems.Add("Total Item Order: " & rst("item").ToString)
            item1.SubItems.Add("Total Amount: " & FormatNumber(rst("ttl").ToString, 2))
            item1.SubItems.Add("Processed By: " & rst("SalesPerson").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
            'ListView1.Items(cnt).SubItems(1).Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            cnt = cnt + 1
        End While
        rst.Close()
        ListView1.Focus()
    End Sub

End Class