Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmInventoryLockCutoff
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
     
    Private Sub frmInventoryLockCutoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOnhand.Text = FormatNumber(qrysingledata("total", "ifnull(sum(quantity*purchasedprice),0) as total", "tblinventory where prepaid=0 and purchasedprice>0 and officeid='" & compOfficeid & "'"), 2)
        txtPrepaid.Text = FormatNumber(qrysingledata("total", "ifnull(sum(quantity*purchasedprice),0) as total", "tblinventory where prepaid=1 and purchasedprice>0 and officeid='" & compOfficeid & "'"), 2)
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to lock current inventory?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO tblinventorylocked (cutoff,officeid,stockhouseid,catid,categoryname,productid,productname,prepaid,quantity,unit,purchasedprice,calcsellrate,sellingprice,lastupdate,lasttrnby,dateinventory) " _
                               + " SELECT '" & ConvertDate(txttodate.Value) & "',officeid,stockhouseid,catid,categoryname,productid,productname,prepaid,quantity,unit,purchasedprice,calcsellrate,sellingprice,lastupdate,lasttrnby,dateinventory FROM tblinventory where officeid='" & compOfficeid & "'" : com.ExecuteNonQuery()
            frmInventorySummary.CheckInventoryLockedStatus()
            MessageBox.Show("Inventory successfully locked!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class