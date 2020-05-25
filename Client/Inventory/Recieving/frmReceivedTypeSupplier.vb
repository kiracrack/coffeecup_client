Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports DevExpress.XtraSplashScreen

Public Class frmReceivedTypeSupplier

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdConsumable.Click
        If compAllowreceivedpurchases = False Then
            MessageBox.Show("You are not allowed to received any purchased!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If compInventoryMethod = "" Then
            MessageBox.Show("Your office have not set inventory method, please contact your administrator!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReceivedConsumable.ckAssets.Checked = False
        frmReceivedConsumable.Show()
        SplashScreenManager.CloseForm()
        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdFFE.Click
        If compAllowreceivedpurchases = False Then
            MessageBox.Show("You are not allowed to received any purchased!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If compInventoryMethod = "" Then
            MessageBox.Show("Your office have not set inventory method, please contact your administrator!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReceivedConsumable.ckAssets.Checked = True
        frmReceivedConsumable.Show()
        SplashScreenManager.CloseForm()
        Me.Close()
    End Sub

    Private Sub frmReceivedType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim consumable As Integer = 0
        com.CommandText = "select count(*) as cnt from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where catid in (select catid from tblprocategory where consumable=1) and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanagconsumableotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") & " and (select companyid from tblcompoffice where officeid=a.officeid)='" & GlobalCompanyid & "' group by b.ponumber order by a.datetrn asc;" : rst = com.ExecuteReader
        While rst.Read
            consumable += 1
        End While
        rst.Close()

        If consumable > 0 Then
            If compAllowreceivedpurchases = True Then
                cmdConsumable.Text = "Consumable Stock (" & consumable & ")"
                cmdConsumable.ForeColor = Color.Red
            Else
                cmdConsumable.Text = "Consumable Stock"
                cmdConsumable.ForeColor = DefaultForeColor
            End If
        Else
            cmdConsumable.Text = "Consumable Stock"
            cmdConsumable.ForeColor = DefaultForeColor
        End If

        Dim ffe As Integer = 0
        com.CommandText = "select count(*) as cnt from tblpurchaseorder as a inner join tblpurchaseorderitem as b on a.ponumber = b.ponumber where catid in (select catid from tblprocategory where ffe=1) and verified=1 and forpo=1 and a.cancelled=0 and a.delivered=0 and expired=0 " & If(compallowmanageffeotheroffice = True, "", "and a.officeid='" & compOfficeid & "'") & " and (select companyid from tblcompoffice where officeid=a.officeid)='" & GlobalCompanyid & "' group by b.ponumber order by a.datetrn asc;" : rst = com.ExecuteReader
        While rst.Read
            ffe += 1
        End While
        rst.Close()

        If ffe > 0 Then
            If compAllowreceivedpurchases = True Then
                cmdFFE.Text = "Fixed Assets (" & ffe & ")"
                cmdFFE.ForeColor = Color.Red
            Else
                cmdFFE.Text = "Fixed Assets"
                cmdFFE.ForeColor = DefaultForeColor
            End If
        Else
            cmdFFE.Text = "Fixed Assets"
            cmdFFE.ForeColor = DefaultForeColor
        End If
    End Sub

End Class