Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmHotelGuestCompanion
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFullname.Text = "" Then
            MessageBox.Show("Please provide companion name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf txtRoomNo.Text = "" Then
            MessageBox.Show("Please select room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoomNo.Focus()
            Exit Sub
        ElseIf countqry("tblhotelguestcompanion", "fullname='" & rchar(txtFullname.Text) & "' and bookno='" & BookingNo & "' and id<>'" & id.Text & "'") > 0 Then
            MessageBox.Show("Companion name already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullname.SelectAll()
            txtFullname.Focus()
            Exit Sub
        End If

        ' If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblhotelguestcompanion set bookno='" & foliono.Text & "', folioid='" & folioid.Text & "', fullname='" & UCase(txtFullname.Text) & "', age='" & If(UCase(txtAge.Text) = "AGE", "", txtAge.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Added room companion " & txtFullname.Text & " (" & txtAge.Text & ")")
            com.CommandText = "INSERT into tblhotelguestcompanion set bookno='" & foliono.Text & "', folioid='" & folioid.Text & "', fullname='" & UCase(txtFullname.Text) & "', age='" & If(UCase(txtAge.Text) = "AGE", "", txtAge.Text) & "'" : com.ExecuteNonQuery()
        End If
        txtFullname.Text = "" : txtAge.Text = "" : mode.Text = "" : id.Text = "" : txtFullname.Focus()
        If frmHotelCheckInTransactionV2.Visible = True Then
            frmHotelCheckInTransactionV2.FilterCompanion()
        End If
        ' MsgBox("Companion name successfully saved!", MsgBoxStyle.Information)
        ' End If
    End Sub

    Private Sub frmHotelAddAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If txtRoomNo.Items.Count = 0 Then
            LoadRoom()
        End If
        If mode.Text = "edit" Then
            ShowInfo()
        End If
    End Sub
    Public Sub LoadRoom()
        LoadToComboBoxDB("select * from tblhotelfolioroom where foliono='" & foliono.Text & "' order by roomno asc", "roomno", "folioid", txtRoomNo)
    End Sub
    Public Sub ShowInfo()
        com.CommandText = "select *,(select roomno from tblhotelfolioroom where folioid=tblhotelguestcompanion.folioid) as roomno from tblhotelguestcompanion where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            folioid.Text = rst("folioid").ToString
            txtFullname.Text = rst("fullname").ToString
            txtAge.Text = rst("age").ToString
            txtRoomNo.Text = rst("roomno").ToString
        End While
        rst.Close()
    End Sub
    Private Sub txtFullname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullname.KeyDown
        If e.KeyCode() = Keys.Enter Then
            If txtAge.Text = "" Then
                txtAge.Focus()
            End If
        End If
    End Sub

    Private Sub txtAge_GotFocus(sender As Object, e As EventArgs) Handles txtAge.GotFocus
        Me.AcceptButton = Button1
    End Sub
     
  
    Private Sub txtRoomNo_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomNo.SelectedValueChanged
        If txtRoomNo.Text <> "" Then
            folioid.Text = DirectCast(txtRoomNo.SelectedItem, ComboBoxItem).HiddenValue()
        End If
    End Sub
End Class
