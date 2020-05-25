Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmUnitConverterInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadProduct()
        clearFields()
    End Sub
    Public Sub loadProduct()
        If GlobalenableProductFilter = True Then
            LoadToComboBoxDB("select productid,itemname from tblglobalproducts where catid in (select categorycode from tblproductfilter where permissioncode='" & globalAuthcode & "')  order by itemname asc", "itemname", "productid", txtProduct)
        Else
            LoadToComboBoxDB("select productid,itemname from tblglobalproducts order by itemname asc", "itemname", "productid", txtProduct)
        End If
    End Sub
    Public Sub clearFields()
        If mode.Text <> "edit" Then
            id.Text = getIncrementID("tblunitconverter")
        Else
            LoadDetails()
        End If
        FilterDetails(id.Text)
    End Sub
    Public Sub LoadDetails()
        Dim proname As String = ""
        com.CommandText = "select *,(select ITEMNAME from tblglobalproducts where productid = tblunitconverter.productid) as 'itemname', " _
                            + " (select unit from tblglobalproducts where productid = tblunitconverter.productid) as 'unit', " _
                            + " (select sellingprice from tblglobalproducts where productid = tblunitconverter.productid) as 'sellingprice' " _
                            + " from tblunitconverter where convcode='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            productid.Text = rst("productid").ToString
            proname = rst("itemname").ToString
            txtUnit.Text = rst("unit").ToString
        End While
        rst.Close()
        txtProduct.Text = proname
    End Sub

    Public Sub FilterDetails(ByVal strid As String)
        If mode.Text = "edit" Then
            MyDataGridView.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("Select trnid, (select itemname from tblglobalproducts where productid = tblunitconverterdetails.productid ) as 'Particular', Quantity from tblunitconverterdetails " _
                                        + " where convcode='" & id.Text & "'", conn)

            msda.Fill(dst, 0)
            MyDataGridView.DataSource = dst.Tables(0)
            GridHideColumn(MyDataGridView, {"trnid"})
        Else
            MyDataGridView.Rows.Clear()
            MyDataGridView.ColumnCount = 3
            MyDataGridView.ColumnHeadersVisible = True

            MyDataGridView.Columns(0).Name = "productid"
            MyDataGridView.Columns(1).Name = "Particular"
            MyDataGridView.Columns(2).Name = "Quantity"
            GridHideColumn(MyDataGridView, {"productid"})
        End If
        GridColumnAlignment(MyDataGridView, {"Quantity"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub AddnewItemFromSource(ByVal productid As String, ByVal productname As String, ByVal quantity As Double)
        MyDataGridView.Rows.Add(productid, productname, quantity)
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblunitconverter set officeid='" & compOfficeid & "', productid='" & productid.Text & "', quantity='" & Val(CC(txtQuantity.Text)) & "' where convcode='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "DELETE from tblunitconverterdetails where convcode='" & id.Text & "'" : com.ExecuteNonQuery()
            For i = 0 To MyDataGridView.RowCount - 1
                com.CommandText = "insert into tblunitconverterdetails set convcode='" & id.Text & "',productid='" & MyDataGridView.Item("productid", i).Value().ToString & "', quantity='" & Val(CC(txtQuantity.Text)) & "'" : com.ExecuteNonQuery()
            Next
            com.CommandText = "INSERT INTO tblunitconverter set convcode='" & id.Text & "', officeid='" & compOfficeid & "', productid='" & productid.Text & "', quantity='" & Val(CC(txtQuantity.Text)) & "' " : com.ExecuteNonQuery()
        End If
        MessageBox.Show("Product conversion settings successfuly saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Not IsNothing(e.Value) And e.ColumnIndex > 1 Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
            End If
        End If
    End Sub

    Private Sub cmdSendOfficialReceipt_Click(sender As Object, e As EventArgs) Handles cmdSendOfficialReceipt.Click
        frmUnitConverterAddItem.id.Text = id.Text
        frmUnitConverterAddItem.ShowDialog(Me)
    End Sub

    Private Sub txtProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedIndexChanged
        productid.Text = DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue()
        txtUnit.Text = qrysingledata("unit", "unit", "tblglobalproducts where productid='" & productid.Text & "'")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If mode.Text = "edit" Then
                com.CommandText = "Delete from tblunitconverterdetails where trnid='" & rw.Cells("trnid").Value.ToString & "'" : com.ExecuteNonQuery()
                FilterDetails(id.Text)
            Else
                MyDataGridView.Rows.Remove(rw)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmUnitConverterAddItem.id.Text = id.Text
        frmUnitConverterAddItem.ShowDialog(Me)
    End Sub
End Class