Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmHotelTypeOfGuest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtdescription.Text = "" Then
            MessageBox.Show("Please provide type of guest!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdescription.Focus()
            Exit Sub
        ElseIf countqry("tblhotelguesttype", "description='" & rchar(txtdescription.Text) & "'") > 0 Then
            MessageBox.Show("type of guest already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdescription.SelectAll()
            txtdescription.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim code As String = getcodeid("code", "tblhotelguesttype", "100")
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), frmHotelCheckInTransactionV2.foliono.Text, "Added new guest type " & txtdescription.Text)
            com.CommandText = "INSERT into tblhotelguesttype set code='" & code & "',  description='" & UCase(txtdescription.Text) & "'" : com.ExecuteNonQuery()
            LoadAgent()
            txtdescription.Text = ""
            MsgBox("Agent successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmHotelAddAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadAgent()
    End Sub
    Public Sub LoadAgent()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT code, description as 'Type of Guest' FROM `tblhotelguesttype` order by description asc;", conn)
        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"code"})
    End Sub

End Class
