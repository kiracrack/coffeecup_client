Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmPOSDirectProductAdd2
#Region "Call Data Reload Function"


#End Region

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Cursor = Cursors.WaitCursor

        LoadToComboBoxDB("select distinct ucase(unit) as 'unit' from tblglobalproducts order by unit asc", "unit", "unit", txtUnit)
        LoadToComboBoxDB("select distinct ucase(description) as 'category',catid from tblprocategory order by description asc", "category", "catid", txtCategory)

        If mode.Text = "new" Then
            productid.Text = getproid()
            ckBeginningInventory.Visible = True
            txtBeginningQuantity.Visible = True
            lblbeginningInventory.Visible = True
        Else
            showProductInfo()
            ckBeginningInventory.Visible = False
            txtBeginningQuantity.Visible = False
            lblbeginningInventory.Visible = False
        End If

        txtProductName.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub showProductInfo()
        Dim category As String = ""
        com.CommandText = "select *, (select description from tblprocategory where catid = tblglobalproducts.catid) as catproduct  from tblglobalproducts where productid='" & productid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            category = rst("catproduct").ToString
            catid.Text = rst("catid").ToString
            txtBarcode.Text = rst("barcode").ToString
            txtProductName.Text = rst("itemname").ToString
            txtUnit.Text = rst("unit").ToString
            ckService.Checked = rst("forcontract")
            txtPurchasePrice.Value = rst("purchasedprice")
            txtSellingCost.Value = rst("sellingprice")
        End While
        rst.Close()
        txtCategory.Text = category
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If productid.Text.Contains(" ") = True Then
            MessageBox.Show("Please enter itemcode without space!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            productid.SelectAll()
            productid.Focus()
            Exit Sub
        ElseIf txtCategory.Text = "" Then
            MessageBox.Show("Please select category!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCategory.Focus()
            Exit Sub
        ElseIf txtProductName.Text = "" Then
            MessageBox.Show("Please provide particular name!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProductName.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            MessageBox.Show("Please select unit!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "barcode='" & txtBarcode.Text & "' and productid<>'" & productid.Text & "'") > 0 And txtBarcode.Text <> "" Then
            MessageBox.Show("Barcode already exists!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBarcode.SelectAll()
            txtBarcode.Focus()
            Exit Sub
        ElseIf countqry("tblglobalproducts", "itemname='" & rchar(txtProductName.Text) & "' and unit='" & txtUnit.Text & "'  and productid<>'" & productid.Text & "' and deleted=0") > 0 Then
            MessageBox.Show("Duplicate particular item name!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductName.SelectAll()
            txtProductName.Focus()
            Exit Sub
        End If
        Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtCategory.Name, True)
        detailsFile.WriteLine(EncryptTripleDES(txtCategory.Text & "," & catid.Text))
        detailsFile.Close()

        Dim detailsFile2 = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtUnit.Name, True)
        detailsFile2.WriteLine(EncryptTripleDES(txtUnit.Text & "," & txtUnit.Text))
        detailsFile2.Close()


        If countqry("tblglobalproducts", "productid='" & productid.Text & "'") = 0 Then
            com.CommandText = "insert into tblglobalproducts set barcode='" & txtBarcode.Text & "', productid='" & productid.Text & "',catid='" & catid.Text & "',itemname='" & rchar(txtProductName.Text) & "', unit='" & txtUnit.Text & "',enablesell=1, vatableitem=1,allowinputdiscountedamount=1,purchasedprice='" & Val(CC(txtPurchasePrice.Value)) & "', sellingprice='" & Val(CC(txtSellingCost.Text)) & "',salemode='" & If(ckService.Checked = True, "esba", "esbq") & "', forcontract='" & If(ckService.Checked = True, "1", "0") & "', entryby='" & globaluserid & "',dateentered=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblglobalproducts set barcode='" & txtBarcode.Text & "', catid='" & catid.Text & "',itemname='" & rchar(txtProductName.Text) & "',  unit='" & txtUnit.Text & "',enablesell=1, vatableitem=1,allowinputdiscountedamount=1,purchasedprice='" & Val(CC(txtPurchasePrice.Value)) & "', sellingprice='" & Val(CC(txtSellingCost.Text)) & "',salemode='" & If(ckService.Checked = True, "esba", "esbq") & "', forcontract='" & If(ckService.Checked = True, "1", "0") & "', entryby='" & globaluserid & "' where productid='" & productid.Text & "'" : com.ExecuteNonQuery()
        End If

        If ckBeginningInventory.Checked = True Then
            If countqry("tblinventory", "productid='" & productid.Text & "'") = 0 Then
                UpdateInventory("Beginning Inventory", "", compOfficeid, "", "", productid.Text, Val(CC(txtBeginningQuantity.Value)), Val(CC(txtPurchasePrice.Value)), "pos manual stocking", "", "")
            End If
        End If

        frmPOSProductSearch.SearchProduct(txtProductName.Text)
        productid.Text = getproid() : txtBarcode.Text = "" : txtProductName.Text = "" : txtPurchasePrice.Value = 0 : txtSellingCost.Value = 0 : txtBeginningQuantity.Value = 0 : txtProductName.Focus()
        MessageBox.Show("Product Successfull saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        If mode.Text = "edit" Then
            Me.Close()
        End If
    End Sub


    Private Sub txtCategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCategory.SelectedValueChanged
        catid.Text = DirectCast(txtCategory.SelectedItem, ComboBoxItem).HiddenValue()
        If CBool(qrysingledata("noninventory", "noninventory", "tblprocategory where catid='" & catid.Text & "'")) = True Then
            ckBeginningInventory.Enabled = False
            ckBeginningInventory.Checked = False
            ckService.Checked = True
        Else
            ckService.Checked = False
            ckBeginningInventory.Enabled = True
            ckBeginningInventory.Checked = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtUnit.DropDownStyle = ComboBoxStyle.DropDownList
        Else
            txtUnit.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub

    Private Sub ckBeginningInventory_CheckedChanged(sender As Object, e As EventArgs) Handles ckBeginningInventory.CheckedChanged
        If ckBeginningInventory.Checked = True Then
            txtBeginningQuantity.Enabled = True
        Else
            txtBeginningQuantity.Enabled = False
        End If
    End Sub

    Private Sub txtSellingCost_GotFocus(sender As Object, e As EventArgs) Handles txtSellingCost.GotFocus
        Me.AcceptButton = cmdSave
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

End Class