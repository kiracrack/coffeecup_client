Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmFuelPumpReading
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
         
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadProduct()
    End Sub
    Public Sub LoadProduct()
        txtProduct.Items.Clear()
        If GlobalenableProductFilter = True Then
            com.CommandText = "select distinct tblsalesfuelpump.productid,(select itemname from tblglobalproducts  where actived = 1 and productid = tblsalesfuelpump.productid ) as 'product' from tblsalesfuelpump inner join tblproductfilter on tblsalesfuelpump.productid = tblproductfilter.productid where  tblproductfilter.userid='" & globaluserid & "'" : rst = com.ExecuteReader
        Else
            com.CommandText = "select distinct tblsalesfuelpump.productid,(select itemname from tblglobalproducts  where actived = 1 and productid = tblsalesfuelpump.productid ) as 'product' from tblsalesfuelpump" : rst = com.ExecuteReader
        End If

        While rst.Read
            txtProduct.Items.Add(New ComboBoxItem(rst("product").ToString, rst("productid").ToString))
        End While
        rst.Close()
    End Sub
    Private Sub txtClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedIndexChanged
        If txtProduct.Text <> "" Then
            productid.Text = DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue()
            ShowPumpInformation()
        Else
            productid.Text = ""
        End If

    End Sub
    Public Sub ShowPumpInformation()
        If countqry("tblsalesfuelreading", "trnsumcode='" & globalSalesTrnCOde & "' and productid='" & productid.Text & "'") = 0 Then
            MyDataGridView.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select pumpcode, description as 'Pump Name', 0.00 as Quantity from tblsalesfuelpump where productid='" & productid.Text & "'", conn)
            msda.Fill(dst, 0)
            MyDataGridView.DataSource = dst.Tables(0)
            MyDataGridView.ReadOnly = False
            MyDataGridView.Columns("Quantity").ReadOnly = False
            MyDataGridView.Columns("Pump Name").ReadOnly = True
            MyDataGridView.Columns("Quantity").Width = 60

            GridHideColumn(MyDataGridView, {"pumpcode"})
            GridColumnAlignment(MyDataGridView, {"Quantity"}, DataGridViewContentAlignment.MiddleRight)
            GridCurrencyColumn(MyDataGridView, {"Quantity"})
        Else
            MyDataGridView.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select pumpcode, (select description from tblsalesfuelpump where pumpcode = tblsalesfuelreading.pumpcode) as 'Pump Name', Quantity from tblsalesfuelreading where productid='" & productid.Text & "' and trnsumcode='" & globalSalesTrnCOde & "'", conn)
            msda.Fill(dst, 0)
            MyDataGridView.DataSource = dst.Tables(0)
            MyDataGridView.ReadOnly = False
            MyDataGridView.Columns("Quantity").ReadOnly = False
            MyDataGridView.Columns("Pump Name").ReadOnly = True
            MyDataGridView.Columns("Quantity").Width = 60

            GridHideColumn(MyDataGridView, {"pumpcode"})
            GridColumnAlignment(MyDataGridView, {"Quantity"}, DataGridViewContentAlignment.MiddleRight)
            GridCurrencyColumn(MyDataGridView, {"Quantity"})
        End If
        
    End Sub
    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles MyDataGridView.DataError
        If StrComp(e.Exception.Message, "Input string was not in a correct format.") = 0 Then
            MessageBox.Show("Please Enter a numeric Value only", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'This will change the number back to original
            MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = " "
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtProduct.Text = "" Then
            MessageBox.Show("Please Select Product!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProduct.Focus()
            Exit Sub
        End If
        For I = 0 To MyDataGridView.RowCount - 1
            If Val(CC(MyDataGridView.Item("Quantity", I).Value().ToString)) = 0 Then
                MessageBox.Show("Invalid quantity inputed!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblsalesfuelreading where trnsumcode='" & globalSalesTrnCOde & "' and productid='" & productid.Text & "'" : com.ExecuteNonQuery()
            Dim sellingprice As Double = Val(qrysingledata("sellingprice", "sellingprice", "tblinventory where productid='" & productid.Text & "' and officeid='" & compOfficeid & "'"))
            For I = 0 To MyDataGridView.RowCount - 1
                com.CommandText = "insert into tblsalesfuelreading set trnsumcode='" & globalSalesTrnCOde & "', productid='" & productid.Text & "', pumpcode='" & MyDataGridView.Item("pumpcode", I).Value().ToString & "', quantity='" & MyDataGridView.Item("Quantity", I).Value().ToString & "',unitprice='" & sellingprice & "',  dateentry=current_timestamp, entryby='" & globaluserid & "'" : com.ExecuteNonQuery()
            Next
            LoadProduct() : productid.Text = "" : ShowPumpInformation()
            MessageBox.Show("Pump reading successfully saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class