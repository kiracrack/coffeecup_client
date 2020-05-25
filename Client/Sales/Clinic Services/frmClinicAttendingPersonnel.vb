Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmClinicAttendingPersonnel
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClinicAttendingPersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadPersonnel()
    End Sub
    Public Sub LoadPersonnel()
        ckAttendingPersonnel.Items.Clear()
        com.CommandText = "select * from tblaccounts where officeid='" & compOfficeid & "' and deleted=0" : rst = com.ExecuteReader()
        While rst.Read
            ckAttendingPersonnel.Items.Add(rst("fullname"))
        End While
        rst.Close()
    End Sub
  
    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If ckAttendingPersonnel.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select atleast one attending personnel", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'If countqry("tblglobalproducts", "productid='" & productid.Text & "' and forcontract=1 and menuitem=1 ") > 0 And countqry("tblproductmenuitem", "source_productid='" & productid.Text & "'") = 0 Then
        '    MsgBox("Product menu item not available or currently not configured!", MsgBoxStyle.Exclamation, "Error Message")
        '    Exit Sub
        'End If
        If GlobalEnableStrictMenuMakerInventory = True Then
            Dim ProductTrap As String = ""
            msda = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblproductmenuitem where source_productid='" & productid.Text & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If Val(qrysingledata("ttlquantity", "sum(quantity) as ttlquantity", "tblinventory where productid='" & .Rows(cnt)("productid").ToString() & "' and officeid='" & compOfficeid & "'")) < Val(.Rows(cnt)("quantity").ToString()) Then
                        ProductTrap = ProductTrap + .Rows(cnt)("quantity").ToString() + " " + .Rows(cnt)("unit").ToString() + " - " + qrysingledata("itemname", "itemname", "tblglobalproducts where productid='" & .Rows(cnt)("productid").ToString() & "'") + Chr(13)
                    End If
                End With
            Next

            If ProductTrap.Length > 0 Then
                MessageBox.Show("Some product menu item inventory not available or insufficient! " & Environment.NewLine & Environment.NewLine & "Required details below: " & Environment.NewLine & Environment.NewLine + ProductTrap, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are you sure you want to Continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For i = 0 To ckAttendingPersonnel.Items.Count - 1
                If ckAttendingPersonnel.GetItemChecked(i) = True Then
                    Dim getuserid As String = qrysingledata("accountid", "accountid", "tblaccounts where fullname='" & ckAttendingPersonnel.Items(i).ToString & "'")
                    com.CommandText = "insert into tblclinicsattending set schedid='" & schedid.Text & "', userid='" & getuserid & "',fullname='" & ckAttendingPersonnel.Items(i).ToString & "'" : com.ExecuteNonQuery()
                End If
            Next
            Dim remquantity As Double = 0
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select * from tblproductmenuitem where source_productid='" & productid.Text & "'", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                remquantity = 0
                Dim deductQuantity As Double = st.Tables(0).Rows(nt)("quantity").ToString() * 1
                msda2 = Nothing : dst2 = New DataSet
                msda2 = New MySqlDataAdapter("select * from tblinventory where officeid='" & compOfficeid & "'  and productid='" & st.Tables(0).Rows(nt)("productid").ToString() & "' and quantity > 0 order by dateinventory,trnid", conn)
                msda2.Fill(dst2, 0)
                Dim xnt = 0
                For xnt = 0 To dst2.Tables(0).Rows.Count - 1
                    If remquantity = 0 Then
                        If deductQuantity > Val(dst2.Tables(0).Rows(xnt)("quantity").ToString()) Then
                            remquantity = deductQuantity - Val(dst2.Tables(0).Rows(xnt)("quantity").ToString())
                            com.CommandText = "insert into tblclinicstockout set serviceid='" & serviceid.Text & "', officeid='" & compOfficeid & "', refnumber='" & schedid.Text & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "', productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString())) & "',unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "', purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                            StockoutInventory("Clinic Service Stockout", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString())), Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "Service #" + serviceno.Text + " (Menu maker Item)", "", "")
                        Else
                            com.CommandText = "insert into tblclinicstockout set serviceid='" & serviceid.Text & "', officeid='" & compOfficeid & "', refnumber='" & schedid.Text & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "', productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & deductQuantity & "', unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "',  purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                            StockoutInventory("Clinic Service Stockout", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), deductQuantity, Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "Service #" + serviceno.Text + " (Menu maker Item)", "", "")
                            Exit For
                        End If
                    Else
                        If remquantity > Val(dst2.Tables(0).Rows(xnt)("quantity").ToString()) Then
                            remquantity = remquantity - Val(dst2.Tables(0).Rows(xnt)("quantity").ToString())
                            com.CommandText = "insert into tblclinicstockout set serviceid='" & serviceid.Text & "', officeid='" & compOfficeid & "', refnumber='" & schedid.Text & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "', productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString())) & "', unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "', purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                            StockoutInventory("Clinic Service Stockout", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), Val(CC(dst2.Tables(0).Rows(xnt)("quantity").ToString())), Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "Service #" + serviceno.Text + " (Menu maker Item)", "", "")
                        Else
                            com.CommandText = "insert into tblclinicstockout set serviceid='" & serviceid.Text & "', officeid='" & compOfficeid & "', refnumber='" & schedid.Text & "', stockno='" & dst2.Tables(0).Rows(xnt)("trnid").ToString() & "', productid='" & dst2.Tables(0).Rows(xnt)("productid").ToString() & "',productname='" & dst2.Tables(0).Rows(xnt)("productname").ToString() & "', quantity='" & remquantity & "',unit='" & dst2.Tables(0).Rows(xnt)("unit").ToString() & "', purchasedprice='" & Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())) & "'" : com.ExecuteNonQuery()
                            StockoutInventory("Clinic Service Stockout", dst2.Tables(0).Rows(xnt)("trnid").ToString(), compOfficeid, dst2.Tables(0).Rows(xnt)("productid").ToString(), remquantity, Val(CC(dst2.Tables(0).Rows(xnt)("purchasedprice").ToString())), "Service #" + serviceno.Text + " (Menu maker Item)", "", "")
                            Exit For
                        End If
                    End If
                Next
            Next
            com.CommandText = "update tblclinicschedule set cleared=1, datecleared=current_timestamp,clearedby='" & globalfullname & "' where id='" & schedid.Text & "'" : com.ExecuteNonQuery()
            frmClinicStatementLedger.FilterDetails(serviceid.Text)
            If frmClinicScheduleReminder.Visible = True Then
                frmClinicScheduleReminder.ViewSchedule()
            End If
            MessageBox.Show("Schedule successfully cleared", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class