Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmProductRequest
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Cursor = Cursors.WaitCursor
        LoadProductUnit()
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub LoadProductUnit()
        LoadToComboBoxDB("select unitname from tblproductunit order by unitname asc", "unitname", "unitname", txtUnit)
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        If txtProductname.Text = "" Then
            MessageBox.Show("Please enter particular name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProductname.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            MessageBox.Show("Please select unit!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub

        ElseIf txtmessage.Text = "" Then
            MessageBox.Show("Please enter message!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmessage.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue send request?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If GlobalProcurementEmailAddress <> "" Then
                InsertEmailNotification("product-request", GlobalProcurementEmailAddress, "Request for item registration", "<b>Request for item registration</b><br/>Item Name: " & txtProductname.Text & "<br/>Unit Type: " & txtUnit.Text & "<br/><br/>", txtmessage.Text)
            End If
            com.CommandText = "insert into tblproductrequest set itemname='" & rchar(txtProductname.Text) & "', " _
                                                   + " unit='" & txtUnit.Text & "', " _
                                                   + " message='" & txtmessage.Text & "', " _
                                                   + " requestid = '" & globaluserid & "', " _
                                                   + " officeid='" & compOfficeid & "', " _
                                                   + " daterequest=CURRENT_TIMESTAMP" : com.ExecuteNonQuery()
            MessageBox.Show("Item successfully submitted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


End Class