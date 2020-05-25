Imports System.Globalization

Public Class frmProductRegistration
  Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtProductName.Text = "" Then
            MessageBox.Show("Please provide product name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProductName.Focus()
            Exit Sub
        ElseIf txtcategory.Text = "" Then
            MessageBox.Show("Please select category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcategory.Focus()
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            MessageBox.Show("Please select unit type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub

        ElseIf countqry("tblglobalproducts", "ITEMNAME='" & rchar(txtProductName.Text) & "'") > 0 Then
            MessageBox.Show("Product item name already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductName.SelectAll()
            txtProductName.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim ProductCode As String = getproid()
            com.CommandText = "INSERT into tblglobalproducts set productid='" & ProductCode & "', catid='" & catid.Text & "', itemname='" & UCase(txtProductName.Text) & "', unit='" & UCase(txtUnit.Text) & "', entryby='" & globaluserid & "',dateentered=current_timestamp " : com.ExecuteNonQuery()
            MsgBox("Product successfully saved!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loaddata()
    End Sub
    Public Sub loaddata()
        txtProductName.Text = ""
        LoadToComboBoxDB("SELECT * FROM  tblprocategory where ffe=1 order by description asc;", "description", "catid", txtcategory)
        LoadToComboBoxDB("SELECT distinct(unit) as 'unittype' from tblglobalproducts", "unittype", "unittype", txtUnit)
        txtProductName.Focus()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtUnit.DropDownStyle = ComboBoxStyle.DropDown
        Else
            txtUnit.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub txtcategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtcategory.SelectedValueChanged
        If txtcategory.Text <> "" Then
            catid.Text = DirectCast(txtcategory.SelectedItem, ComboBoxItem).HiddenValue()
        End If
    End Sub
End Class
