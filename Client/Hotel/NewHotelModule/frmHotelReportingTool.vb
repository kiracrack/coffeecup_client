Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelReportingTool
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelEditFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        If GlobalOrganizationInitialCode = "DR" Then
            txtReportingType.Items.Add("Hotel Sales Summary (Lana Report)")
        End If
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If txtReportingType.Text = "Hotel Sales Summary (default)" Then
            GenerateLXHotelSummary(txtfrmdate.Value, txttodate.Value, Me)
        ElseIf txtReportingType.Text = "Hotel Sales Summary (Lana Report)" Then
            GenerateLXDakakHotelReport(txtfrmdate.Value, txttodate.Value, txtReportingType.Text, Me)
        End If

    End Sub

End Class