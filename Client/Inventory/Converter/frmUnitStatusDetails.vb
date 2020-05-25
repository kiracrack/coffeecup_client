Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmUnitStatusDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FilterDetails()
    End Sub
   

    Public Sub FilterDetails()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  tblglobalproducts.ITEMNAME  as 'Particular', " _
                                    + " quantity as 'Required Quantity', " _
                                    + " ifnull((select quantity from tblinventory where productid=tblunitconverterdetails.productid and officeid='" & compOfficeid & "'),'Inventory not found') as 'Available Quantity' " _
                                    + " from tblunitconverterdetails inner join tblglobalproducts on tblunitconverterdetails.productid = tblglobalproducts.productid and forcontract=0  inner join tblprocategory on tblglobalproducts.catid = tblprocategory.catid and consumable = 1  where convcode='" & id.Text & "'", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Required Quantity", "Available Quantity"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
   
End Class