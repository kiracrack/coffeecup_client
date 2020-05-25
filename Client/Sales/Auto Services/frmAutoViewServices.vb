Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmAutoViewServices
   Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmAutoViewServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadServicesInfo()
        tabFilter()
    End Sub
    Public Sub LoadServicesInfo()
        com.CommandText = "select *,(select companyname from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'customer', " _
                           + " (select compadd from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'address', " _
                           + " (select telephone from tblclientaccounts where cifid  = tblsalesautoservices.cifid) as 'number' " _
                           + " from tblsalesautoservices where trncode='" & txtReference.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtClient.Text = rst("customer").ToString
            txtAddress.Text = rst("address").ToString
            txtContactNumber.Text = rst("number").ToString
            cifid.Text = rst("cifid").ToString
            txtCarModel.Text = rst("carmodel").ToString
            txtPlateNumber.Text = rst("platenumber").ToString
            txtRecomendation.Text = rst("recomendation").ToString
            txtOdoMeter.Text = FormatNumber(rst("odometer").ToString)
            txtMechanics.Text = rst("attmechanics").ToString
        End While
        rst.Close()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub
    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabJobOrder Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            LoadJobOrder()
        ElseIf TabControl1.SelectedTab Is tabProducts Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            LoadPartsInstalled()
        End If
    End Sub
    Public Sub LoadJobOrder()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select productname as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where catid = tblsalestransaction.catid) as 'Category', " _
                                + " sum(quantity) as 'Quantity'," _
                                + " tblsalestransaction.Unit, " _
                                + " sellprice as 'Unit Cost', " _
                                + " sum(total) as 'Total' " _
                                + " from tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode " _
                                + " where tblsalesautotransaction.trncode='" & txtReference.Text & "' and cancelled=0 and void=0 and forcontract=1 group by tblsalestransaction.productid", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost", "Total"})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Unit Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        'If MyDataGridView.RowCount - 1 > 0 Then
        '    Dim totalsum As Double = 0
        '    For i = 0 To MyDataGridView.RowCount - 1
        '        totalsum = totalsum + Val(CC(MyDataGridView.Rows(i).Cells("Total").Value()))
        '    Next
        '    ' MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Unit Cost").Value = "Total"
        '    MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Total").Value = FormatNumber(totalsum, 2)
        '    MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        '    MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'End If
    End Sub

    Public Sub LoadPartsInstalled()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select productname as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where catid = tblsalestransaction.catid) as 'Category', " _
                                + " sum(quantity) as 'Quantity'," _
                                + " tblsalestransaction.Unit, " _
                                + " sellprice as 'Unit Cost', " _
                                + " sum(total) as 'Total' " _
                                + " from tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid inner join " _
                                + " tblsalesautotransaction on tblsalesautotransaction.batchcode = tblsalestransaction.batchcode " _
                                + " where tblsalesautotransaction.trncode='" & txtReference.Text & "' and cancelled=0 and void=0 and forcontract=0 group by tblsalestransaction.productid", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost", "Total"})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Unit Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        'If MyDataGridView.RowCount - 1 > 0 Then
        '    Dim totalsum As Double = 0
        '    For i = 0 To MyDataGridView.RowCount - 1
        '        totalsum = totalsum + Val(CC(MyDataGridView.Rows(i).Cells("Total").Value()))
        '    Next
        '    ' MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Unit Cost").Value = "Total"
        '    MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Total").Value = FormatNumber(totalsum, 2)
        '    MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
        '    MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        'End If
    End Sub
    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdAddTransaction.Click
        frmAutoAddTransaction.txtReference.Text = txtReference.Text
        frmAutoAddTransaction.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdClosedService.Click
        If MessageBox.Show("Are you sure you want to continue confirm transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If GLobalEmailNotifyAutoServices = True Then
                SendServiceAutoClosedReport(txtReference.Text)
            End If
            com.CommandText = "update tblsalesautoservices set closed=1, closedby='" & globaluserid & "', dateclosed=current_timestamp where trncode='" & txtReference.Text & "'" : com.ExecuteNonQuery()
            frmAutoServices.tabFilter()
            MsgBox("Service successfully closed!", MsgBoxStyle.Information, "Message")
            Me.Close()
        End If
    End Sub

    Private Sub cmdPrintAgreement_Click(sender As Object, e As EventArgs) Handles cmdPrintAgreement.Click
        AutoServicesClosed(txtClient.Text, qrysingledata("compadd", "compadd", "tblclientaccounts where cifid='" & cifid.Text & "'"), qrysingledata("telephone", "telephone", "tblclientaccounts where cifid='" & cifid.Text & "'"), txtCarModel.Text, txtPlateNumber.Text, txtOdoMeter.Text, txtMechanics.Text, txtRecomendation.Text, txtReference.Text, Me)
    End Sub
End Class