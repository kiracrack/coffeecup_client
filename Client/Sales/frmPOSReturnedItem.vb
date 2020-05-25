Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmPOSReturnedItem
    Dim DefaultglItemLocation As String
    Dim defaultglCode As String
    Dim defaultglItem As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
         
        TabControl1.SelectedTab = tabTransaction
        FilterTransaction()
        TabControl1.SelectedTab = tabPost
    End Sub

    Public Sub FilterTransaction()
        dst = New DataSet
        msda = New MySqlDataAdapter("select s.* from (select id,inventorytrnid,batchrefcode,datereturn,salestrnid,returnreference,productid,batchrefcode as 'Batchcode', (select itemname from tblglobalproducts where productid = tblsalesreturneditem.productid) as 'Particular',Quantity,Unit,unitcost as 'Unit Cost', totalcost as 'Total',Remarks,if(returntoinventory=1,'YES','NO') as 'Return to Inventory',if(affectcash=1,'YES','NO') as 'Refund Cash'  from tblsalesreturneditem where trnsumcode = '" & globalSalesTrnCOde & "' and cancelled=0 union all " _
                                    + " select '','','',current_timestamp,'','','','','Total','','',null, sum(totalcost), '','','' from tblsalesreturneditem where trnsumcode = '" & globalSalesTrnCOde & "' and cancelled=0) as s order by datereturn asc", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Remarks").Width = 500
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("inventorytrnid").Visible = False
        MyDataGridView.Columns("datereturn").Visible = False
        MyDataGridView.Columns("productid").Visible = False
        MyDataGridView.Columns("salestrnid").Visible = False
        MyDataGridView.Columns("returnreference").Visible = False
        MyDataGridView.Columns("batchrefcode").Visible = False

        GridCurrencyColumn(MyDataGridView, {"Quantity", "Unit Cost", "Total"})
        GridColumnAlignment(MyDataGridView, {"Batchcode", "Unit", "Quantity", "Return to Inventory", "Refund Cash"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Unit Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblsalesreturneditem set cancelled=1, cancelledby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()

                If countqry("tblsalesclientcharges", "batchcode='" & rw.Cells("batchrefcode").Value.ToString & "' and paymentupdated=0") > 0 Then
                    'replace transaction client charges summary
                    com.CommandText = "DELETE from tblsalesclientcharges where batchcode='" & rw.Cells("batchrefcode").Value.ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO  `tblsalesclientcharges` (trnsumcode,accountno,batchcode,glitemcode,invoiceno,remarks,amount,datetrn,trnby,verified,verifiedby,dateverified,cancelled,cancelledby,datecancelled,paymentupdated,paymentrefnumber)  " _
                               + " SELECT trnsumcode,accountno,batchcode,glitemcode,invoiceno,remarks,amount,datetrn,trnby,verified,verifiedby,dateverified,cancelled,cancelledby,datecancelled,paymentupdated,paymentrefnumber FROM `tblsalesreturnedclientcharges` where returnreference='" & rw.Cells("returnreference").Value.ToString & "'" : com.ExecuteNonQuery()

                    'backup transaction client charges details
                    com.CommandText = "DELETE from tblsalesclientchargesitem where id='" & rw.Cells("salestrnid").Value.ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO `tblsalesclientchargesitem` (id,trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn) " _
                               + " SELECT '" & rw.Cells("salestrnid").Value.ToString & "',trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn FROM  `tblsalesreturnedclientchargesitem` where returnreference='" & rw.Cells("returnreference").Value.ToString & "'" : com.ExecuteNonQuery()

                    com.CommandText = "update tblsalesclientcharges set amount=(select sum(total) from tblsalesclientchargesitem where batchcode = tblsalesclientcharges.batchcode and cancelled=0)  where batchcode='" & rw.Cells("batchrefcode").Value.ToString & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblsalesclientcharges set cancelled=0  where batchcode='" & rw.Cells("batchrefcode").Value.ToString & "' and amount>0" : com.ExecuteNonQuery()
                    If countqry("tblglaccountledger", "batchcode='" & rw.Cells("batchrefcode").Value.ToString & "'") > 0 Then
                        com.CommandText = "update tblglaccountledger set debit=(select sum(total) from tblsalesclientchargesitem where batchcode = tblglaccountledger.batchcode and cancelled=0)  where batchcode='" & rw.Cells("batchrefcode").Value.ToString & "'" : com.ExecuteNonQuery()
                    End If

                End If
                If rw.Cells("Return to Inventory").Value.ToString = "YES" Then
                    StockoutInventory("POS Return", rw.Cells("inventorytrnid").Value.ToString, compOfficeid, rw.Cells("productid").Value.ToString, Val(CC(rw.Cells("Quantity").Value.ToString)), 0, "cancelled return batchcode#" + rw.Cells("batchrefcode").Value.ToString, rw.Cells("batchrefcode").Value.ToString, "")
                End If
            Next
            FilterTransaction()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If referencenumber.Text = "" Then
            MessageBox.Show("Please select Reference Code", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            referencenumber.Focus()
            Exit Sub
        ElseIf countqry("tblsalesbatch", "(batchcode='" & rchar(referencenumber.Text) & "' or invoiceno='" & rchar(referencenumber.Text) & "') and void=0 and onhold=0 and floattrn=0") = 0 And countqry("tblsalesclientcharges", "invoiceno='" & rchar(referencenumber.Text) & "' and cancelled=0 ") = 0 Then
            MessageBox.Show("Please enter valid reference code", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            referencenumber.Focus()
            Exit Sub
        ElseIf Val(CC(txtQuantity.Text)) <= 0 Or txtQuantity.Text = "" Then
            MessageBox.Show("Please enter quantity", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtQuantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            MessageBox.Show("You have entered exceeded maximum of quantity", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub

        End If

        If MessageBox.Show("Are you sure you want to continue return item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Dim ReturnCode As String = getGlobalid()
            com.CommandText = "insert into tblsalesreturneditem set inventorytrnid='" & inventorytrnid.Text & "',returnreference='" & ReturnCode & "', salestrnid='" & trnid.Text & "', officeid='" & compOfficeid & "', trnsumcode='" & globalSalesTrnCOde & "',trnsumrefcode='" & trnsumrefcode.Text & "',batchrefcode='" & txtBatchcode.Text & "', productid='" & productid.Text & "',originalquantity='" & Val(CC(txtAvailableQuantity.Text)) & "', quantity='" & Val(CC(txtQuantity.Text)) & "',unit='" & unit.Text & "', unitcost='" & Val(CC(txtUnitCost.Text)) & "',totalcost='" & Val(CC(txtTotal.Text)) & "',returntoinventory=" & ckReturnInventory.CheckState & ", remarks='" & rchar(txtRemarks.Text) & "',affectcash=" & If(ckChargeAccount.Checked = False, ckRefundCash.CheckState, If(ckPaymentUpdated.Checked = True, True, False)) & ",trnby='" & globaluserid & "', datereturn=current_timestamp,verified=1,verifiedby='" & frmPOSAdminConfirmation.userid.Text & "', dateverified=current_timestamp" : com.ExecuteNonQuery()

            If countqry("tblsalesclientcharges", "batchcode='" & txtBatchcode.Text & "' and paymentupdated=0") > 0 Then
                'backup transaction client charges summary
                com.CommandText = "INSERT INTO  `tblsalesreturnedclientcharges` (trnsumcode,accountno,batchcode,glitemcode,invoiceno,remarks,amount,datetrn,trnby,verified,verifiedby,dateverified,cancelled,cancelledby,datecancelled,paymentupdated,paymentrefnumber,returnreference)  " _
                           + " SELECT trnsumcode,accountno,batchcode,glitemcode,invoiceno,remarks,amount,datetrn,trnby,verified,verifiedby,dateverified,cancelled,cancelledby,datecancelled,paymentupdated,paymentrefnumber,'" & ReturnCode & "'  FROM `tblsalesclientcharges` where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                'backup transaction client charges details
                com.CommandText = "INSERT INTO `tblsalesreturnedclientchargesitem` (trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn,returnreference) " _
                           + " SELECT trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn,'" & ReturnCode & "' FROM  `tblsalesclientchargesitem` where id='" & trnid.Text & "'" : com.ExecuteNonQuery()

                'deduct transaction client charges details
                com.CommandText = "update tblsalesclientchargesitem set quantity=quantity-" & Val(CC(txtQuantity.Text)) & ", " _
                        + " distotal=distotal-((distotal/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " chargetotal=chargetotal-((chargetotal/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " taxtotal=taxtotal-((taxtotal/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " subtotal=subtotal-((subtotal/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " chittotal=chittotal-((chittotal/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " total=total-((total/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " income=income-((income/" & Val(CC(txtAvailableQuantity.Text)) & ")*" & Val(CC(txtQuantity.Text)) & "), " _
                        + " returnquantity='" & Val(CC(txtQuantity.Text)) & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()

                'Update client chrages summary
                com.CommandText = "update tblsalesclientcharges set amount=(select sum(total) from tblsalesclientchargesitem where batchcode = tblsalesclientcharges.batchcode and cancelled=0)  where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblsalesclientcharges set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where batchcode='" & txtBatchcode.Text & "' and amount=0" : com.ExecuteNonQuery()

                'Update journal entries summary
                If countqry("tblglaccountledger", "accountno='" & cifid.Text & "' and batchcode='" & txtBatchcode.Text & "'") > 0 Then
                    com.CommandText = "update tblglaccountledger set debit=(select sum(total) from tblsalesclientchargesitem where batchcode = tblglaccountledger.batchcode and cancelled=0)  where batchcode='" & txtBatchcode.Text & "'" : com.ExecuteNonQuery()
                End If
            End If
            If ckReturnInventory.Checked = True Then
                StockinInventory("POS Return", inventorytrnid.Text, compOfficeid, productid.Text, Val(CC(txtQuantity.Text)), 0, "return item batchcode#" + txtBatchcode.Text, "", txtBatchcode.Text, "")
            End If
            MsgBox("Return item Successfully posted!", MsgBoxStyle.Information)
            FilterTransaction()
            trnid.Text = ""
            invoiceno.Text = ""
            txtBatchcode.Text = ""
            txtTransactionBy.Text = ""
            txtProduct.Items.Clear()
            txtProduct.Text = ""
            txtQuantity.Text = "0"
            txtAvailableQuantity.Text = "0"
            txtUnitCost.Text = "0.00"
            txtTotal.Text = "0.00"
            productid.Text = ""
            unit.Text = ""
            txtRemarks.Text = ""
            ValidateProduct()
            txtProduct.DroppedDown = True
            txtProduct.Focus()

            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        InputNumberOnly(txtTotal, e)
    End Sub

    Private Sub batchcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles referencenumber.KeyPress
        If e.KeyChar() = Chr(13) Then
            ValidateProduct()
        End If
    End Sub
    Public Sub ValidateProduct()
        txtProduct.Items.Clear()
        Dim batch_code As String = ""
        If countqry("tblsalesclientcharges", "(batchcode='" & rchar(referencenumber.Text) & "' or invoiceno='" & rchar(referencenumber.Text) & "') and trnsumcode='" & globalSalesTrnCOde & "' and cancelled=0") > 0 Then
            MessageBox.Show("Invoice is current date transaction! please use Revise Invoice Transaction function", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            referencenumber.Focus()
            Exit Sub
        End If
        If countqry("tblsalesbatch", "(batchcode='" & rchar(referencenumber.Text) & "' or invoiceno='" & rchar(referencenumber.Text) & "') and void=0 and onhold=0 and floattrn=0") = 0 And countqry("tblsalesclientcharges", "invoiceno='" & rchar(referencenumber.Text) & "' and cancelled=0 ") = 0 Then
            MsgBox("Reference code was not found in the system! Please try again..", MsgBoxStyle.Exclamation)
            referencenumber.SelectAll()
            referencenumber.Focus()
            Exit Sub
        Else
            If countqry("tblsalesbatch", "(batchcode='" & rchar(referencenumber.Text) & "' or invoiceno='" & rchar(referencenumber.Text) & "') and void=0 and onhold=0 and floattrn=0") > 0 Then
                batch_code = qrysingledata("batchcode", "batchcode", "tblsalesbatch where (batchcode='" & rchar(referencenumber.Text) & "' or invoiceno='" & rchar(referencenumber.Text) & "') ")
            Else
                batch_code = qrysingledata("batchcode", "batchcode", "tblsalesclientcharges where invoiceno='" & rchar(referencenumber.Text) & "'")
            End If
        End If

        If countqry("tblsalesclientcharges", "batchcode='" & batch_code & "'") > 0 Then
            dst = New DataSet
            msda = New MySqlDataAdapter("select id,productname from tblsalesclientchargesitem where batchcode='" & batch_code & "' and cancelled=0", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If .Rows(cnt)("productname").ToString() <> "" Then
                        txtProduct.Items.Add(New ComboBoxItem(.Rows(cnt)("id").ToString() & "-" & .Rows(cnt)("productname").ToString(), .Rows(cnt)("id").ToString()))
                    End If
                End With
            Next
            txtProduct.DroppedDown = True
            txtProduct.Focus()
            ShowClientChargesInfo(batch_code)
        Else
            dst = New DataSet
            msda = New MySqlDataAdapter("select id,productname from tblsalestransaction where batchcode='" & batch_code & "'  and cancelled=0 and void=0", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If .Rows(cnt)("productname").ToString() <> "" Then
                        txtProduct.Items.Add(New ComboBoxItem(.Rows(cnt)("id").ToString() & "-" & .Rows(cnt)("productname").ToString(), .Rows(cnt)("id").ToString()))
                    End If
                End With
            Next
            txtProduct.DroppedDown = True
            txtProduct.Focus()
            ckChargeAccount.Checked = False
        End If
    End Sub
    Public Function ShowClientChargesInfo(ByVal batchcode As String)
        com.CommandText = "select * from tblsalesclientcharges where batchcode='" & batchcode & "'" : rst = com.ExecuteReader
        While rst.Read
            ckChargeAccount.Checked = True
            If CBool(rst("paymentupdated")) = True And rst("paymentrefnumber").ToString <> "" Then
                ckPaymentUpdated.Checked = True
                lblWarning.Visible = True
            Else
                ckPaymentUpdated.Checked = False
                lblWarning.Visible = False
            End If
        End While
        rst.Close()
        Return 0
    End Function
    Private Sub txtProduct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProduct.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQuantity.Focus()
            Me.AcceptButton = cmdConfirm
        End If
    End Sub


    Private Sub txtProduct_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedValueChanged
        Dim existingQuantityReturn As Double = 0 : Dim QuantityReturn As Double = 0
        If ckChargeAccount.Checked = True Then
            ckRefundCash.Visible = False
            com.CommandText = "select *,(select fullname from tblaccounts where accountid = tblsalesclientchargesitem.userid) as 'transactionby',(select invoiceno from tblsalesclientcharges where batchcode=tblsalesclientchargesitem.batchcode) as 'invoice' from tblsalesclientchargesitem  where id='" & DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue() & "' and cancelled=0 and quantity>0" : rst = com.ExecuteReader
        Else
            ckRefundCash.Visible = True
            com.CommandText = "select *,(select fullname from tblaccounts where accountid = tblsalestransaction.userid) as 'transactionby',(select invoiceno from tblsalesbatch where batchcode=tblsalestransaction.batchcode) as 'invoice' from tblsalestransaction where id='" & DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
        End If

        While rst.Read
            inventorytrnid.Text = rst("inventorytrnid").ToString
            trnid.Text = rst("id").ToString
            cifid.Text = rst("cifid").ToString
            invoiceno.Text = rst("invoice").ToString
            trnsumrefcode.Text = rst("trnsumcode").ToString
            txtBatchcode.Text = rst("batchcode").ToString
            txtTransactionBy.Text = rst("transactionby").ToString
            productid.Text = rst("productid").ToString()
            unit.Text = rst("unit").ToString()
            QuantityReturn = rst("quantity").ToString
            txtAvailableQuantity.Text = rst("quantity").ToString
            txtQuantity.Text = FormatNumber(rst("quantity").ToString, 2)
            txtUnitCost.Text = FormatNumber(rst("sellprice").ToString, 2)
            txtTotal.Text = FormatNumber(Val(rst("sellprice").ToString) * Val(rst("quantity").ToString), 2)
        End While
        rst.Close()

        If ckChargeAccount.Checked = False Then
            com.CommandText = "select * from tblsalesreturneditem where salestrnid='" & trnid.Text & "' and cancelled=0" : rst = com.ExecuteReader
            While rst.Read
                existingQuantityReturn = rst("quantity").ToString
            End While
            rst.Close()
            If existingQuantityReturn > 0 Then
                txtAvailableQuantity.Text = QuantityReturn - existingQuantityReturn
                txtQuantity.Text = FormatNumber(QuantityReturn - existingQuantityReturn, 2)
            End If
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        txtTotal.Text = FormatNumber(Val(CC(txtUnitCost.Text)) * Val(CC(txtQuantity.Text)), 2)
        If Val(CC(txtQuantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            txtQuantity.BackColor = Color.Red
            txtQuantity.ForeColor = Color.White
        Else
            txtQuantity.BackColor = Color.White
            txtQuantity.ForeColor = Color.Black
        End If
    End Sub
 
    Private Sub txtProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedIndexChanged
        lblItemName.Text = txtProduct.Text
    End Sub

    Private Sub referencenumber_TextChanged(sender As Object, e As EventArgs) Handles referencenumber.TextChanged
        Me.AcceptButton = Nothing
    End Sub
End Class