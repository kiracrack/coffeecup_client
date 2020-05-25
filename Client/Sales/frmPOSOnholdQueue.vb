Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSOnholdQueue
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select item to continue!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ' where queuecode not in (select onholdqueuecode from tblsalesbatch where onhold=1 and void=0)
        Dim QueueCategory As String = ""
        If GlobalQueuingProductCategory.Length > 0 Then
            For Each word In GlobalQueuingProductCategory.Split(New Char() {","c})
                If word.Length > 1 Then
                    QueueCategory = QueueCategory + " catid='" & word & "' or "
                End If
            Next
            QueueCategory = QueueCategory.Remove(QueueCategory.Length - 3, 3)
        End If
 
        For Each itm As ListViewItem In ListView1.Items
            If itm.Selected Then
                If countqry("tblsalesbatch", "onholdqueuecode='" & itm.SubItems(1).Text & "' and onhold=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 Then
                    If MessageBox.Show("Are you sure you want to add this current transaction to " & itm.SubItems(0).Text & "? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        Dim oldbatchcode As String = qrysingledata("batchcode", "batchcode", "tblsalesbatch where onholdqueuecode='" & itm.SubItems(1).Text & "' and  onhold=1 and void=0 and officeid='" & compOfficeid & "'")
                        'print transaction to next pos printer
                        If countqry("tblsalestransaction", "batchcode='" & batchcode.Text & "' and (" & QueueCategory & ") and cancelled=0 and void=0") > 0 Then
                            If compposproductioncopy = True Then
                                PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, oldbatchcode, QueueCategory, "PRODUCTION COPY", globalAssistantFullName, True)
                            End If
                            If compposfoodcheckercopy = True Then
                                PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, oldbatchcode, QueueCategory, "FOOD CHECKER COPY", globalAssistantFullName, True)
                            End If
                            If compposbutcherycopy = True Then
                                PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, oldbatchcode, QueueCategory, "BUTCHERY COPY", globalAssistantFullName, True)
                            End If
                            If compposcustomercopy = True Then
                                PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, oldbatchcode, QueueCategory, "CUSTOMER COPY", globalAssistantFullName, True)
                            End If
                            If compposcashiercopy = True Then
                                PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, oldbatchcode, QueueCategory, "CASHIERS COPY", globalAssistantFullName, False)
                            End If
                             
                        End If
                        If countqry("tblsalescoupon", "batchcode='" & batchcode.Text & "' and cancelled=0 and printed=0") > 0 Then
                            Dim CouponList As String = ""
                            com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product from tblsalescoupon where batchcode='" & batchcode.Text & "' and cancelled=0" : rst = com.ExecuteReader
                            While rst.Read
                                CouponList += rst("couponcode").ToString & " - " & rst("product") & vbTab & FormatNumber(Val(rst("total").ToString), 2).ToString & Environment.NewLine
                            End While
                            rst.Close()
                            If MessageBox.Show("Your transaction contains coupon! Do you want to print coupon ticket?" & Environment.NewLine & Environment.NewLine & CouponList, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                                PrintCoupon(batchcode.Text)
                            End If
                        End If

                        com.CommandText = "update tblsalesbatch set onholdname='" & itm.SubItems(0).Text & "',onholdqueuecode='" & itm.SubItems(1).Text & "', onhold=1, advancepayment='0', processed=1, dateprocess=current_timestamp, datetrn=current_timestamp where batchcode='" & oldbatchcode & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsalestransaction set onhold=1, batchcode='" & oldbatchcode & "' where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
                        DeleteBatchSalesTransaction(batchcode.Text)

                        frmPointOfSale.BeginNewTransaction()
                        MsgBox("Transaction successfully added to " & itm.SubItems(0).Text & "!", MsgBoxStyle.Information)
                        Me.Close()
                    End If
                Else
                    If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        com.CommandText = "update tblsalesbatch set onholdname='" & itm.SubItems(0).Text & "',onholdqueuecode='" & itm.SubItems(1).Text & "', onhold=1, advancepayment='0', processed=1, dateprocess=current_timestamp, datetrn=current_timestamp where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblsalestransaction set onhold=1 where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()

                        If onholdqueuecode.Text = "" Then
                            If countqry("tblsalestransaction", "batchcode='" & batchcode.Text & "' and (" & QueueCategory & ")  and cancelled=0 and void=0") > 0 Then
                                If compposproductioncopy = True Then
                                    PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, batchcode.Text, QueueCategory, "PRODUCTION COPY", globalAssistantFullName, True)
                                End If
                                If compposfoodcheckercopy = True Then
                                    PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, batchcode.Text, QueueCategory, "FOOD CHECKER COPY", globalAssistantFullName, True)
                                End If
                                If compposbutcherycopy = True Then
                                    PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, batchcode.Text, QueueCategory, "BUTCHERY COPY", globalAssistantFullName, True)
                                End If
                                If compposcustomercopy = True Then
                                    PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, batchcode.Text, QueueCategory, "CUSTOMER COPY", globalAssistantFullName, True)
                                End If
                                If compposcashiercopy = True Then
                                    PrintPOSQueueSlip(itm.SubItems(0).Text, batchcode.Text, batchcode.Text, QueueCategory, "CASHIERS COPY", globalAssistantFullName, False)
                                End If
                                 
                            End If
                        End If

                        If countqry("tblsalescoupon", "batchcode='" & batchcode.Text & "' and cancelled=0 and printed=0") > 0 Then
                            Dim CouponList As String = ""
                            com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product from tblsalescoupon where batchcode='" & batchcode.Text & "' and cancelled=0" : rst = com.ExecuteReader
                            While rst.Read
                                CouponList += rst("couponcode").ToString & " - " & rst("product") & vbTab & FormatNumber(Val(rst("total").ToString), 2).ToString & Environment.NewLine
                            End While
                            rst.Close()
                            If MessageBox.Show("Your transaction contains coupon! Do you want to print coupon ticket?" & Environment.NewLine & Environment.NewLine & CouponList, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                                PrintCoupon(batchcode.Text)
                            End If
                        End If
                        frmPointOfSale.BeginNewTransaction()
                        MsgBox(batchcode.Text & " successfully put on hold!", MsgBoxStyle.Information)
                        Me.Close()
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        com.CommandText = "select * from tblsalesbatch where batchcode='" & batchcode.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            onholdqueuecode.Text = rst("onholdqueuecode").ToString
        End While
        rst.Close()

        ImageMenu.Images.Clear()
        ListView1.Items.Clear()
        ImageMenu.ImageSize = New Size(40, 40)
        com.CommandText = "select * from tblsalesqueuingslip where groupcode='" & qrysingledata("groupcode", "groupcode", "tblsalesqueuingfilter where permissioncode='" & globalAuthcode & "'") & "' " & If(globalAssistantUserId = "", "", "  and queuecode not in (select onholdqueuecode from tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=1 and void=0 and attendingperson<>'" & globalAssistantUserId & "') ") : rst = com.ExecuteReader
        While rst.Read
            ImageMenu.Images.Add(ConvertImage("icon"))
        End While
        rst.Close()

        com.CommandText = "select * from tblsalesqueuingslip  where groupcode='" & qrysingledata("groupcode", "groupcode", "tblsalesqueuingfilter where permissioncode='" & globalAuthcode & "'") & "' " & If(globalAssistantUserId = "", "", "and queuecode not in  (select onholdqueuecode from tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=1 and void=0 and attendingperson <> '" & globalAssistantUserId & "')") : rst = com.ExecuteReader
        While rst.Read
            ImageMenu.Images.Add(ConvertImage("icon"))
        End While
        rst.Close()

        ListView1.View = View.SmallIcon
        ListView1.Columns.Add("Description", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("queuecode", 0, HorizontalAlignment.Left)
        ListView1.SmallImageList = ImageMenu
        Dim cnt As Integer = 0
        com.CommandText = "select * from tblsalesqueuingslip where groupcode='" & qrysingledata("groupcode", "groupcode", "tblsalesqueuingfilter where permissioncode='" & globalAuthcode & "'") & "' " & If(globalAssistantUserId = "", "", " and queuecode not in  (select onholdqueuecode from tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and onhold=1 and void=0 and attendingperson<>'" & globalAssistantUserId & "')") : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("description").ToString, cnt)
            item1.SubItems.Add(rst("queuecode").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
            cnt = cnt + 1
        End While
        rst.Close()

        cmdConfirmPayment.Text = "Confirm Hold " & GlobalQueuingSlipType
        Me.Text = "On Hold " & GlobalQueuingSlipType

        If ListView1.Items Is Nothing Then Exit Sub
        For Each lvi As ListViewItem In ListView1.Items
            If countqry("tblsalesbatch", "onholdqueuecode='" & lvi.SubItems(1).Text & "' and onhold=1 and void=0 and trnsumcode='" & globalSalesTrnCOde & "'") > 0 Then
                lvi.ForeColor = Color.Red
                lvi.Font = New Font("Arial", 10, FontStyle.Bold)
            Else
                lvi.ForeColor = Color.Gray
            End If
        Next

        For Each lvi As ListViewItem In ListView1.Items
            If lvi.SubItems(1).Text = onholdqueuecode.Text Then
                lvi.Selected = True
                lvi.Focused = True
                lvi.Font = New Font("Arial", 13, FontStyle.Bold)
                lvi.ForeColor = Color.Blue
            End If
        Next
        ListView1.Focus()

    End Sub
End Class