Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmGLJournalDetails
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLJournalDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmGLJournalDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadItem()

        If mode.Text = "edit" Then
            showItemTicketItemInfo()
        End If
    End Sub
    Public Sub LoadItem()
        LoadXgridLookupSearch("select if(sl=1,itemcode,'') as itemcode,  if(sl=1,itemname,'') as itemname, " & GlobalGLitemname & " as 'Item Name', debit,if(a.sl=1,1,0) as sl from tblglitem as a", "tblglitem", txtItem, gridItem)
        XgridHideColumn({"itemcode", "itemname", "debit", "sl"}, gridItem)
    End Sub

    Private Sub gridItem_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridItem.RowCellStyle
        Dim View As GridView = sender
        Dim sl As Boolean = CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sl")))
        If sl = False Then
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
        End If
    End Sub

    Private Sub txtItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtItem.Properties.View.FocusedRowHandle.ToString)
        ItemCode.Text = txtItem.Properties.View.GetFocusedRowCellValue("itemcode").ToString()
        ckDebit.Checked = CBool(txtItem.Properties.View.GetFocusedRowCellValue("debit").ToString())
        txtNote.Focus()
    End Sub

    Public Sub showItemTicketItemInfo()
        com.CommandText = "select * from tblgljournalitems where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtItem.Text = rst("itemcode").ToString
            ItemCode.Text = rst("itemcode").ToString
            txtNote.Text = rst("remarks").ToString
            txtDebit.Text = rst("debitamount").ToString
            txtCredit.Text = rst("creditamount").ToString
            ckDebit.Checked = CBool(rst("debit"))
        End While
        rst.Close()
    End Sub


    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtItem.Text = "" Then
            MessageBox.Show("Please select item name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Exit Sub
        ElseIf txtNote.Text = "" Then
            MessageBox.Show("Please enter remarks!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNote.Focus()
            Exit Sub
        ElseIf Val(CC(txtDebit.Text)) = 0 And Val(CC(txtCredit.Text)) = 0 Then
            MessageBox.Show("Please enter either credit or debit amount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Val(CC(txtDebit.Text)) > 0 And Val(CC(txtCredit.Text)) > 0 Then
            MessageBox.Show("Please enter only either credit or debit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblgljournalitems set  " _
                         + " itemcode='" & ItemCode.Text & "', " _
                         + " itemname='" & rchar(txtItem.Text) & "', " _
                         + " debitamount='" & Val(CC(txtDebit.Text)) & "', " _
                         + " creditamount='" & Val(CC(txtCredit.Text)) & "', " _
                         + " remarks='" & rchar(txtNote.Text) & "',debit=" & ckDebit.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
            If frmGLJournalInformation.Visible = True Then
                frmGLJournalInformation.LoadTickets()
            End If
            If frmAcctVoucherInfo.Visible = True Then
                frmAcctVoucherInfo.LoadAccountingEntries()
            End If
            Me.Close()
        Else
            com.CommandText = "insert into tblgljournalitems set ticketno='" & If(txtTicketNo.Text = "", globaluserid & "-temp", txtTicketNo.Text) & "', " _
                         + " itemcode='" & ItemCode.Text & "', " _
                         + " itemname='" & rchar(txtItem.Text) & "', " _
                         + " debitamount='" & Val(CC(txtDebit.Text)) & "', " _
                         + " creditamount='" & Val(CC(txtCredit.Text)) & "', " _
                         + " remarks='" & rchar(txtNote.Text) & "', debit=" & ckDebit.CheckState & " " : com.ExecuteNonQuery()
            txtDebit.EditValue = "0" : txtCredit.EditValue = "0"
            txtItem.Focus()
            txtItem.ShowPopup()
            If frmGLJournalInformation.Visible = True Then
                frmGLJournalInformation.LoadTickets()
            End If
            If frmAcctVoucherInfo.Visible = True Then
                frmAcctVoucherInfo.LoadAccountingEntries()
            End If
        End If

    End Sub

    Private Sub txtDebit_GotFocus(sender As Object, e As EventArgs) Handles txtDebit.GotFocus
        Me.AcceptButton = cmdOk
    End Sub

    Private Sub txtCredit_GotFocus(sender As Object, e As EventArgs) Handles txtCredit.GotFocus
        Me.AcceptButton = cmdOk
    End Sub

    Private Sub value_EditValueChanged(sender As Object, e As EventArgs) Handles txtCredit.EditValueChanged, txtDebit.EditValueChanged
        If Val(CC(txtDebit.Text)) > 0 Then
            txtCredit.ReadOnly = True
        ElseIf Val(CC(txtCredit.Text)) > 0 Then
            txtDebit.ReadOnly = True
        Else
            txtDebit.ReadOnly = False
            txtCredit.ReadOnly = False
        End If
    End Sub

End Class