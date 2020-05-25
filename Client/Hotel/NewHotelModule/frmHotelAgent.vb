Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmHotelAgent
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtAgentName.Text = "" Then
            MessageBox.Show("Please provide agent name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAgentName.Focus()
            Exit Sub
        ElseIf countqry("tblhotelagent", "agentname='" & rchar(txtAgentName.Text) & "'") > 0 Then
            MessageBox.Show("Agent name already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAgentName.SelectAll()
            txtAgentName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim code As String = getcodeid("code", "tblhotelagent", "100")
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), frmHotelCheckInTransactionV2.foliono.Text, "Added new agent " & txtAgentName.Text)
            com.CommandText = "INSERT into tblhotelagent set code='" & code & "',  agentname='" & UCase(txtAgentName.Text) & "'" : com.ExecuteNonQuery()
            LoadAgent()
            txtAgentName.Text = ""
            MsgBox("Agent successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmHotelAddAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadAgent()
    End Sub
    Public Sub LoadAgent()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT code, agentname as 'Agent Name' FROM `tblhotelagent` order by agentname asc;", conn)
        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"code"})
    End Sub

End Class
