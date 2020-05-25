Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmRequestQuantitySelect
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtquan.Select(0, txtquan.Text.Length)
        LoadToComboBoxDB("select * from tblglobalvendor where deleted=0 order by companyname asc", "companyname", "vendorid", txtvendor)
        clearFields()
    End Sub
    Private Sub txtvendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvendor.SelectedIndexChanged
        If txtvendor.Text <> "" Then
            vendorid.Text = DirectCast(txtvendor.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            vendorid.Text = ""
        End If
    End Sub

    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Not IsNothing(e.Value) And e.ColumnIndex > 3 Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
            End If
        End If
    End Sub

    Public Sub clearFields()
        id.Text = getGlobalTrnid(compOfficeid.Remove(2, compOfficeid.Length - 2), globaluserid)

    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If CC(txtquan.Text) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
            'ElseIf txtvendor.Text = "" Then
            '    MessageBox.Show("Please select vendor!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txtvendor.Focus()
            '    Exit Sub

            'ElseIf txtsti.Text = "" Then
            '    MessageBox.Show("Unit Cost missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txtsti.Focus()
            '    Exit Sub
        End If
        If countqry("tblitemvendor", " itemid='" & productid.Text & "' and vendorid = '" & vendorid.Text & "' and officeid='" & compOfficeid & "' ") = 0 Then
            com.CommandText = "INSERT INTO tblitemvendor set itemid='" & productid.Text & "', vendorid = '" & vendorid.Text & "', officeid='" & compOfficeid & "', unit='" & txtunit.Text & "', procost='" & Val(CC(txtsti.Text)) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblitemvendor set unit='" & txtunit.Text & "', procost='" & Val(CC(txtsti.Text)) & "', lastupdate=current_timestamp where itemid='" & productid.Text & "' and vendorid = '" & vendorid.Text & "' and officeid='" & compOfficeid & "'" : com.ExecuteNonQuery()
        End If
        com.CommandText = "update tblglobalproducts set purchasedprice='" & Val(CC(txtsti.Text)) & "' where productid='" & productid.Text & "'" : com.ExecuteNonQuery()

        If mode.Text = "edit" Then
            Dim path As String = Application.StartupPath.ToString & "\Resources\Particular Items\" & pid.Text & ".txt"
            Dim lines As New List(Of String)
            Using sr As New StreamReader(path)
                While Not sr.EndOfStream
                    lines.Add(sr.ReadLine)
                End While
            End Using

            For Each line As String In lines
                If line.Contains(editRef.Text) Then
                    lines.Remove(line)
                    lines.Insert(editindex.Text, txtProductName.Text & "|" & Val(CC(txtquan.Text)) & "|" & txtunit.Text & "|" & Val(CC(txtsti.Text)) & "|" & txttotal.Text & "|" & txtdetails.Text.Replace(vbCrLf, " ") & "|" & txtvendor.Text & "|" & id.Text & "|" & pid.Text & "|" & productid.Text & "|" & catid.Text & "|" & vendorid.Text)
                    Exit For 'must exit as we changed the iteration 
                End If
            Next

            Using sw As New StreamWriter(path)
                For Each line As String In lines
                    sw.WriteLine(line)
                Next
            End Using
            frmRequisition.loadTempParticular()
            Me.Close()
        Else
            Dim path As String = Application.StartupPath.ToString & "\Resources\Particular Items\" & pid.Text & ".txt"
            Dim sw As StreamWriter = File.AppendText(path)
            sw.WriteLine(txtProductName.Text & "|" & Val(CC(txtquan.Text)) & "|" & txtunit.Text & "|" & Val(CC(txtsti.Text)) & "|" & txttotal.Text & "|" & txtdetails.Text.Replace(vbCrLf, " ") & "|" & txtvendor.Text & "|" & id.Text & "|" & pid.Text & "|" & productid.Text & "|" & catid.Text & "|" & vendorid.Text)
            sw.Close()
            clearFields()
            frmRequisition.loadTempParticular()
            Me.Close()
        End If
      
       
    End Sub
 
    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = Val(CC(txtquan.Text))
        stm = Val(CC(txtsti.Text))
        ttl = Val(quan) * Val(stm)
        txttotal.Text = Format(ttl, "n")
    End Sub
 
    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub txtquan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquan.KeyPress
        If e.KeyChar = Chr(13) Then
            txtsti.Focus()
        Else
            InputNumberOnly(txtquan, e)
        End If
    End Sub

    Private Sub txtsti_GotFocus(sender As Object, e As EventArgs) Handles txtsti.GotFocus
        Me.AcceptButton = cmdset
    End Sub

    Private Sub txtsti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsti.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdset.PerformClick()
        Else
            InputNumberOnly(txtsti, e)
        End If
    End Sub

    Private Sub txtquan_TextChanged(sender As Object, e As EventArgs) Handles txtquan.TextChanged
        calctotal()
    End Sub

    Private Sub txtsti_LostFocus(sender As Object, e As EventArgs) Handles txtsti.LostFocus
        Me.AcceptButton = Nothing
    End Sub

  
    Private Sub txtsti_TextChanged(sender As Object, e As EventArgs) Handles txtsti.TextChanged
        calctotal()
    End Sub

  
    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    If MessageBox.Show("Do you want to synchronize list of supplier to your machine?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
    '        Me.UseWaitCursor = True
    '        Dim path As String = GlobalApplicationPath & "\Resources\Supplier File\" & pid.Text & ".txt"
    '        File.Delete(path)
    '        Dim sw As StreamWriter = File.AppendText(path) : Dim supplierList As String = ""
    '        com.CommandText = "select * from tblglobalvendor order by companyname asc" : rst = com.ExecuteReader
    '        While rst.Read
    '            supplierList += UCase(rst("companyname").ToString) & "|" & rst("vendorid").ToString & vbCrLf
    '        End While
    '        rst.Close()
    '        sw.WriteLine(supplierList)
    '        sw.Close()
    '        LoadToComboBoxDBWithID(txtvendor, GlobalApplicationPath & "\Resources\Supplier File\" & pid.Text & ".txt")
    '        Me.UseWaitCursor = False
    '        MessageBox.Show("supplier successfully synchronized!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

End Class