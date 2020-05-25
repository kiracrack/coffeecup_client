Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmTransferProcessingDescripancyItem_temp
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ViewLocalparticulars()
    End Sub
    Public Sub ViewLocalparticulars()
        LoadXgrid("select date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction',(select officename from tblcompoffice where officeid=a.officeid) as 'Office', " _
                        + " (select itemname from tblglobalproducts where productid=a.productid) as 'Particular', " _
                        + " a.Debit, " _
                        + " a.Credit, trntype as 'Transaction Type', a.remarks as 'Remarks', trnby as 'Transaction By'" _
                        + " FROM tblinventoryledger as a where referenceno='" & Batchcode.Text & "' and (trntype='Transfer stock' or trntype='Direct Issuance (RR)' or trntype='Transfer cancelled')", "tblinventoryledger", Em, GridView1)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst2, "tblinventoryledger")
        XgridColCurrency({"Debit", "Credit", "Cost"}, GridView1)
        XgridGeneralSummaryCurrency({"Debit", "Credit"}, GridView1)
        XgridColAlign({"Date Transaction", "Office"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewLocalparticulars()
    End Sub
 
End Class