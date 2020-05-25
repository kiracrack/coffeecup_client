Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmSeparationOfQuantity

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSeparationOfQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub txtFFECode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFFECode.KeyPress
        If e.KeyChar() = Chr(13) Then
            FFEDetails()
        End If
    End Sub
    Public Sub FFEDetails()
        If countqry("tblinventoryffe", "ffecode='" & txtFFECode.Text & "' and officeid='" & officeid_from.Text & "'") > 0 Then
            com.CommandText = "select *,(select description from tblinventoryffetype where code = tblinventoryffe.ffetype) as 'ffetypedescription' from tblinventoryffe where ffecode='" & txtFFECode.Text & "' and officeid='" & officeid_from.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtProductName.Text = rst("productname").ToString
                txtFFEType.Text = rst("ffetypedescription").ToString
                txtQuantity.Text = rst("quantity").ToString
            End While
            rst.Close()
        Else
            MessageBox.Show("FFE unit not found!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFFEType.Text = ""
            txtFFECode.Text = ""
            txtFFECode.Focus()
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If countqry("tblinventoryffe", "ffecode='" & txtFFECode.Text & "' and officeid='" & officeid_from.Text & "'") = 0 Then
            MessageBox.Show("FFE unit not found!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ckDevideAll.Checked = True Then
                For i = 0 To Val(txtQuantity.Text) - 2
                    Dim newFFEcode As String = getInventoryFFECodeSequence()
                    com.CommandText = "INSERT INTO `tblinventoryffe` (ffecode,ffetype,reference,officeid,stockhouseid,productid,productname,catid,categoryname,quantity,unit,unitcost,totalamount,vendorid,datepurchased,warranty,warrantydate,manualdepreciation,age,bookvalue,monthlydepreciation,lastdepreciationdate,acctablepersonid,acctableperson,acctdateissued,trnby,datetrn,disposalrequested,disposalrequestcorporatelevel,disposaldaterequested,disposalrequestedby,disposalapproved,disposaldateapproved,disposed,datedisposed,disposedby,attachedimage,flaged,flagedreason,blocked,lockedediting) " _
                             + " SELECT '" & newFFEcode & "',ffetype,reference,officeid,stockhouseid,productid,productname,catid,categoryname,1,unit,unitcost,unitcost,vendorid,datepurchased,warranty,warrantydate,manualdepreciation,age,bookvalue,monthlydepreciation,lastdepreciationdate,acctablepersonid,acctableperson,acctdateissued,trnby,datetrn,disposalrequested,disposalrequestcorporatelevel,disposaldaterequested,disposalrequestedby,disposalapproved,disposaldateapproved,disposed,datedisposed,disposedby,attachedimage,flaged,flagedreason,blocked,lockedediting FROM `tblinventoryffe` where ffecode='" & txtFFECode.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblinventoryffe set quantity=1,totalamount=unitcost where ffecode='" & txtFFECode.Text & "'" : com.ExecuteNonQuery()
                Next
                LogFFEHistory(txtFFECode.Text, "Original Quantity: " & txtQuantity.Text & " - devide all as individual quantity (" & rchar(txtRemarks.Text) & ")")
            Else
                Dim newFFEcode As String = getInventoryFFECodeSequence()
                com.CommandText = "INSERT INTO `tblinventoryffe` (ffecode,ffetype,reference,officeid,stockhouseid,productid,productname,catid,categoryname,quantity,unit,unitcost,totalamount,vendorid,datepurchased,warranty,warrantydate,manualdepreciation,age,bookvalue,monthlydepreciation,lastdepreciationdate,acctablepersonid,acctableperson,acctdateissued,trnby,datetrn,disposalrequested,disposalrequestcorporatelevel,disposaldaterequested,disposalrequestedby,disposalapproved,disposaldateapproved,disposed,datedisposed,disposedby,attachedimage,flaged,flagedreason,blocked,lockedediting) " _
                           + " SELECT '" & newFFEcode & "',ffetype,reference,officeid,stockhouseid,productid,productname,catid,categoryname," & Val(txtNewQuantity.Text) & ",unit,unitcost,unitcost*" & Val(txtNewQuantity.Text) & ",vendorid,datepurchased,warranty,warrantydate,manualdepreciation,age,bookvalue,monthlydepreciation,lastdepreciationdate,acctablepersonid,acctableperson,acctdateissued,trnby,datetrn,disposalrequested,disposalrequestcorporatelevel,disposaldaterequested,disposalrequestedby,disposalapproved,disposaldateapproved,disposed,datedisposed,disposedby,attachedimage,flaged,flagedreason,blocked,lockedediting FROM `tblinventoryffe` where ffecode='" & txtFFECode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblinventoryffe set quantity=quantity-" & Val(txtNewQuantity.Text) & ",totalamount=unitcost*(quantity-" & Val(txtNewQuantity.Text) & ") where ffecode='" & txtFFECode.Text & "'" : com.ExecuteNonQuery()

                LogFFEHistory(txtFFECode.Text, "Original Quantity: " & txtQuantity.Text & " - separate to " & txtNewQuantity.Text & " (" & rchar(txtRemarks.Text) & ")")
            End If
            txtFFEType.Text = "" : txtFFECode.Text = "" : txtProductName.Text = "" : txtRemarks.Text = "" : txtFFECode.ReadOnly = False : txtFFECode.Focus()
            MessageBox.Show("FFE successfully devided!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ckDevideAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckDevideAll.CheckedChanged
        If ckDevideAll.Checked = True Then
            txtNewQuantity.Enabled = False
        Else
            txtNewQuantity.Enabled = True
        End If
    End Sub
End Class