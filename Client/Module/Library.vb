﻿Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Collections.Generic
Imports System.Text.RegularExpressions


Module library
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sqlcmd As New MySqlCommand
    Public sql As String
    Public arrImage() As Byte = Nothing
    Public proFileImg As Boolean
    Public TargetFile As String
    Public ico As Icon
    '----------------email variables ----------------
    Public SendTo(1) As String
    Public FileAttach(10) As String
    Public strSubject As String
    Public strMessage As String
    Public ForceCloseSystem As Boolean = False

    Public Sub ApplySystemTheme(ByVal toolstrp As ToolStrip)
        Dim RGB As String() = globalBgColor.Split(",")
        Try
            toolstrp.BackgroundImage = Nothing
            toolstrp.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
            toolstrp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            If globalFontColor = "LIGHT" Then
                For Each ctrl In toolstrp.Items
                    If Not (TypeOf ctrl Is ToolStripComboBox) And Not (TypeOf ctrl Is ToolStripTextBox) Then
                        ctrl.ForeColor = Color.LightGray
                    End If
                Next
            Else
                For Each ctrl In toolstrp.Items
                    ctrl.ForeColor = Color.Black
                Next
            End If
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function getServerDate() As Date
        Dim server_date As Date
        com.CommandText = "SELECT current_date as dt" : rst = com.ExecuteReader()
        While rst.Read
            server_date = CDate(rst("dt").ToString)
        End While
        rst.Close()
        Return server_date
    End Function

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function
    Public Sub loadIcons()
        TargetFile = Application.StartupPath + "\ico.ico"
        If File.Exists(TargetFile) = True Then
            ico = New Icon(TargetFile)
        End If
    End Sub
    Public Function Rowcount(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "SELECT count(*) as cnt from " & tbl : rst = com.ExecuteReader()
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function countqrybySpecificColumn(ByVal tbl As String, ByVal ColumnName As String, ByVal where As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(" & ColumnName & ") as cnt from " & tbl & " where " & where
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal tblandqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field).ToString
        End While
        rst.Close()
        Return def
    End Function

    Public Function qryDate(ByVal field As String, ByVal fqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field).ToString
        End While
        rst.Close()
        Return def
    End Function

    Public Function countqry(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where " & cond
        rst = com.ExecuteReader
        While rst.Read
            cnt = Val(rst("cnt").ToString)
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function CenterDashColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            If clm.Visible = True Then
                Dim visibility As Boolean = False
                For Each row As DataGridViewRow In grdView.Rows
                    If row.Cells(clm.Index).Value.ToString() = "-" Then
                        grdView.Columns(clm.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        grdView.Columns(clm.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Exit For
                    End If
                Next
            End If
        Next
        Return grdView
    End Function

    Public Function UpdateImage(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal format As System.Drawing.Imaging.ImageFormat, ByVal Ximg As DevExpress.XtraEditors.PictureEdit)
        arrImage = Nothing
        Try
            sqlcmd.Parameters.Clear()
            If Not Ximg.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Image.Save(mstream, format)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If
            If Not Ximg.Image Is Nothing Then
                If countqry(tbl, qry) = 0 Then
                    sql = "insert into " & tbl & " set " & qry & ",  " & fld & " = @file"
                Else
                    sql = "Update " & tbl & " set " & fld & " = @file where " & qry
                End If

                With sqlcmd
                    .CommandText = sql
                    .Connection = conn
                    .Parameters.AddWithValue("@file", arrImage)
                    .ExecuteNonQuery()
                End With
                sqlcmd.Parameters.Clear()
            Else
                If countqry(tbl, qry) = 0 Then
                    com.CommandText = "insert into " & tbl & " set " & qry & ",  " & fld & " = null" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "Update " & tbl & " set " & fld & " = null where " & qry : com.ExecuteNonQuery()
                End If
            End If

        Catch errMYSQL As MySqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return 0
    End Function

    Public Function ShowImage(ByVal fld As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                Ximg.Image = img
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function ConvertImage(ByVal fld As String) As Image
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                ConvertImage = img
            Else
                ConvertImage = Nothing
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ConvertImage
    End Function

    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function
    Public Function ConvertTime(ByVal d As Date)
        Return d.ToString("HH:mm:ss")
    End Function
    Public Function ConvertDateTime(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd HH:mm:ss")
    End Function
    Public Function countrecord(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function GridColumnAlignment(ByVal grdView As DataGridView, ByVal column As Array, ByVal alignment As DataGridViewContentAlignment) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).DefaultCellStyle.Alignment = alignment
                    grdView.Columns(i).HeaderCell.Style.Alignment = alignment
                End If
            Next
        Next
        Return grdView
    End Function

    Public Function GridDisableColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).ReadOnly = True
                    ' MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Rate Type").ReadOnly = False
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridColumAutoWidth(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For I = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(I).Name Then
                    grdView.Columns(I).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridClearCell(ByVal grdView As DataGridView, ByVal column As Array, ByVal row As Integer, ByVal valuenumeric As Boolean)
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    If valuenumeric = True Then
                        grdView.Item(i, row).Value = 0
                    Else
                        grdView.Item(i, row).Value = ""
                    End If
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridCurrencyColumnDecimalCount(ByVal grdView As DataGridView, ByVal column As Array, ByVal decimalplaces As Integer) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n" & decimalplaces
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridCurrencyColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n2"
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridColumnWidth(ByVal grdView As DataGridView, ByVal column As Array, ByVal width As Double) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Width = width
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridColumAutonWidth(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridNumberColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n0"
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridHideColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Visible = False
                End If
            Next
        Next
        Return grdView
    End Function
    Public Sub GridColumnChoosed(ByVal grdView As DataGridView, ByVal file_dir As String)
        If System.IO.File.Exists(Application.StartupPath & "\Config\" & file_dir) = True Then
            Dim sr As StreamReader = File.OpenText(Application.StartupPath & "\Config\" & file_dir)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                For Each col In grdView.Columns
                    If Not DecryptTripleDES(columnChoosed).Contains(col.Name) Then
                        col.Visible = False
                    End If
                Next
                sr.Close()
            Catch errMS As Exception
                ' System.IO.File.Delete(Application.StartupPath & "\" & file_dir)
            End Try
        End If
    End Sub
    Public Function LoadToComboBox(ByVal cb As ComboBox, ByVal path As String)
        Dim chpname As String = ""
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(path)
        Do While sr.Peek() >= 0
            Dim description As String = "" : Dim id As String = "" : Dim cnt As Integer = 0
            For Each word In sr.ReadLine().Split(New Char() {"|"c})
                If cnt = 0 Then
                    id = word
                ElseIf cnt = 1 Then
                    description = word
                End If
                cnt = cnt + 1
            Next
            If id <> "" Then
                cb.Items.Add(New ComboBoxItem(description, id))
            End If
        Loop
        sr.Close()
        Return 0
    End Function
    Public Function ShowGridTotalSummary(ByVal captionLocation As String, ByVal totalColumn As String, ByVal grdView As DataGridView)
        grdView.AllowUserToAddRows = True
        grdView.Columns(totalColumn).Width = 200
        If grdView.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To grdView.RowCount - 1
                totalsum = totalsum + grdView.Rows(i).Cells(totalColumn).Value()
            Next
            If captionLocation.Length > 0 Then
                grdView.Rows(grdView.RowCount - 1).Cells(captionLocation).Value = "Total"
            End If
            grdView.Rows(grdView.RowCount - 1).Cells(totalColumn).Value = totalsum
            grdView.Rows(grdView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            grdView.Rows(grdView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
    End Function
    Public Function LoadToComboBoxTxt(ByVal cb As ComboBox, ByVal path As String)
        Dim chpname As String = ""
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(path)
        cb.Items.Clear()
        Do While sr.Peek() >= 0
            For Each word In sr.ReadLine().Split(New Char() {vbCrLf})
                cb.Items.Add(word)
            Next
        Loop
        sr.Close()
        Return 0
    End Function
    Public Function LoadToComboBoxDBWithID(ByVal cb As ComboBox, ByVal path As String)
        Dim chpname As String = ""
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(path)
        cb.Items.Clear()
        Do While sr.Peek() >= 0
            For Each word In sr.ReadLine().Split(New Char() {vbCrLf})
                If word <> "" Then
                    cb.Items.Add(New ComboBoxItem(word.Split("|".ToCharArray)(0), word.Split("|".ToCharArray)(1)))
                End If
            Next
        Loop
        sr.Close()
        Return 0
    End Function
    Public Function LoadToComboBoxDB(ByVal query As String, ByVal fields As String, ByVal id As String, ByVal cb As ComboBox)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(New ComboBoxItem(rst(fields).ToString, rst(id.ToString)))
            End If
        End While
        rst.Close()
        Return 0
    End Function
    Public Function LoadToToolStripComboBox(ByVal query As String, ByVal fields As String, ByVal id As String, ByVal cb As ToolStripComboBox)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(New ComboBoxItem(rst(fields).ToString, rst(id.ToString)))
            End If
        End While
        rst.Close()
        Return 0
    End Function
    Public Function CC(ByVal m As String)
        If m <> "" Then
            CC = Val(m.Replace(",", ""))
        End If
        Return CC
    End Function
    Public Function CheckSelectedRow(ByVal value As String) As Boolean
        Try
            If value = "" Then
                MessageBox.Show("There is no item selected! make sure, the selection is on the list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckSelectedRow = False
            Else
                CheckSelectedRow = True
            End If
        Catch errMS As Exception
            MessageBox.Show("There is no item selected! make sure, the selection is on the list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CheckSelectedRow = False
        End Try
    End Function

    'Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal addwhere As String, ByVal tbl As String)
    '    Dim def As String = ""
    '    Try
    '        If countrecord(tbl) = 0 Then
    '            def = ""
    '        Else
    '            com.CommandText = "select " & fqry & " from " & tbl & " " & addwhere : rst = com.ExecuteReader
    '            While rst.Read
    '                def = rst(field).ToString
    '            End While
    '            rst.Close()
    '        End If
    '    Catch errMYSQL As MySqlException
    '        MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
    '                         & "Details:" & errMYSQL.StackTrace, _
    '                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    Catch errMS As Exception
    '        MessageBox.Show("Message:" & errMS.Message & vbCrLf _
    '                         & "Details:" & errMS.StackTrace, _
    '                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    Return def
    'End Function

    Public Function checkAttachment(ByVal dir As String) As Boolean
        Dim fs1 As FileStream
        Try
            If dir <> "" Then
                If System.IO.File.Exists(dir) = True Then
                    fs1 = New FileStream(dir, FileMode.OpenOrCreate, FileAccess.Read)
                    Dim iFileSize As UInt32
                    iFileSize = fs1.Length
                    'MsgBox(iFileSize & " Bytes" & Environment.NewLine & (iFileSize / 1024) & " KB" & Environment.NewLine & (iFileSize / 1024) / 1024 & " MB")
                    If iFileSize > GlobalAllowableAttachSize Then
                        Return False
                    End If
                End If
            End If
        Catch errMS As Exception
            MessageBox.Show("Module:" & "Image Attachment" & vbCrLf _
                               & "Message:" & errMS.Message, vbCrLf _
                               & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function
    Public Function LoadToGridComboBox(ByVal query As String, ByVal fields As String, ByVal cb As DataGridViewComboBoxColumn)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(rst(fields).ToString)
            End If
        End While
        rst.Close()
        Return 0
    End Function

    Public Function LoadToGridComboBoxCell(ByVal columnname As String, ByVal rowIndex As Integer, ByVal query As String, ByVal fields As String, ByVal allowBlankRow As Boolean, ByVal gridview As DataGridView)
        Dim dgvcc As New DataGridViewComboBoxCell
        dgvcc.Items.Clear()
        If allowBlankRow = True Then
            dgvcc.Items.Add("")
        End If
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                dgvcc.Items.Add(rst(fields).ToString)
            End If
        End While
        rst.Close()
        gridview.Item(columnname, rowIndex) = dgvcc
        Return 0
    End Function
    Public Function getStockhouseid()
        Dim strng = ""

        If CInt(countrecord("tblstockhouse")) = 0 Then
            strng = "H100001"
        Else
            com.CommandText = "select stockhouseid from tblstockhouse order by right(stockhouseid,6) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "H".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("stockhouseid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = "H" & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function
    Public Function getClientid()
        Dim compid = ""

        If CInt(countrecord("tblclientaccounts")) = 0 Then
            compid = "CIF1000001"
        Else
            com.CommandText = "select cifid from tblclientaccounts order by right(cifid,7) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ- ".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("cifid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            compid = "CIF" & Val(sb.ToString) + 1
        End If
        Return compid.ToString
    End Function

    Public Function getproid()
        Dim strng As Integer = 0 : Dim newprocode As String = ""
        If CInt(countrecord("tblglobalproductssequence")) = 0 Then
            If CInt(countrecord("tblglobalproducts")) = 0 Then
                strng = 1000001
            Else
                com.CommandText = "select productid from tblglobalproducts order by productid desc limit 1" : rst = com.ExecuteReader()
                While rst.Read
                    strng = Val(rst("productid").ToString) + 1
                End While
                rst.Close()
            End If
        Else
            com.CommandText = "select productid from tblglobalproductssequence" : rst = com.ExecuteReader()
            While rst.Read
                strng = Val(rst("productid").ToString) + 1
            End While
            rst.Close()
        End If
        com.CommandText = "delete from tblglobalproductssequence" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblglobalproductssequence set productid='" & strng & "'" : com.ExecuteNonQuery()
        newprocode = strng.ToString
        Return newprocode
    End Function

    Public Function InputNumberOnly(ByVal textbox As System.Windows.Forms.TextBox, e As KeyPressEventArgs)
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = textbox.Text
            Dim selectionStart = textbox.SelectionStart
            Dim selectionLength = textbox.SelectionLength
            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Function
    Public Function RemoveEmptyColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            Dim visibility As Boolean = False
            For Each row As DataGridViewRow In grdView.Rows
                If row.Cells(clm.Index).Value.ToString() <> String.Empty Or Val(row.Cells(clm.Index).Value.ToString()) <> 0 Then
                    visibility = True
                    Exit For
                End If
            Next
            ' MsgBox(clm.Name)
            If clm.Name <> "id" And clm.Name <> "productid" Then
                grdView.Columns(clm.Name).Visible = visibility
            End If
        Next
        Return grdView
    End Function


    Public Function getvendorid()
        Dim compid = ""
        If CInt(countrecord("tblglobalvendor")) = 0 Then
            compid = "SPR-1001"
        Else
            com.CommandText = "select vendorid from tblglobalvendor order by right(vendorid,4) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ- ".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("vendorid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            compid = "SPR-" & Val(sb.ToString) + 1
        End If
        Return compid.ToString
    End Function
    Public Function RecordApprovingHistory(ByVal approvalDescription As String, ByVal mainreference As String, ByVal refno As String, ByVal title As String, ByVal remarks As String)
        com.CommandText = "INSERT INTO `tblapprovalhistory` set approvaltype='-', " _
                                                                 + " appdescription='" & approvalDescription & "', " _
                                                                 + " mainreference='" & mainreference & "', " _
                                                                 + " referenceno='" & refno & "', " _
                                                                 + " status='" & rchar(title) & "', " _
                                                                 + " remarks='" & rchar(remarks) & "', " _
                                                                 + " apptitle='" & globalposition & "', " _
                                                                 + " applevel='-', " _
                                                                 + " confirmid='" & globaluserid & "', " _
                                                                 + " confirmby='" & globalfullname & "', " _
                                                                 + " position='" & globalposition & "', " _
                                                                 + " dateconfirm=current_timestamp, " _
                                                                 + " finalapprover=0 " : com.ExecuteNonQuery()
        Return 0
    End Function

    Public Function GetFFECode(ByVal officeid As String, ByVal ffecode As String)
        Dim strng = ""
        If CInt(countrecord("tblinventoryffe")) = 0 Then
            strng = ffecode & "100001"
        Else
            com.CommandText = "select ffecode from tblinventoryffe where officeid='" & officeid & "' order by right(ffecode,6) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("ffecode").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = ffecode & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function
    Public Function LessQuantityConsumable(ByVal productid As String, ByVal quantity As Double, ByVal officeid As String)
        Dim strquery As String = "" : Dim remquantity As Double = 0
        com.CommandText = "select * from tblinventory where productid='" & productid & "' order by dateinventory,trnid asc" : rst = com.ExecuteReader
        While rst.Read
            If remquantity = 0 Then
                If quantity > Val(rst("quantity").ToString) Then
                    remquantity = quantity - Val(rst("quantity").ToString)
                    strquery = "update tblinventory set quantity=quantity-" & Val(rst("quantity").ToString) & " where trnid='" & rst("trnid").ToString & "' and officeid='" & officeid & "';" & Chr(13)
                Else
                    strquery = "update tblinventory set quantity=quantity-" & quantity & " where trnid='" & rst("trnid").ToString & "' and officeid='" & officeid & "';" & Chr(13)
                End If
            Else
                If remquantity > Val(rst("quantity").ToString) Then
                    remquantity = remquantity - Val(rst("quantity").ToString)
                    strquery += "update tblinventory set quantity=quantity-" & Val(rst("quantity").ToString) & " where trnid='" & rst("trnid").ToString & "' and officeid='" & officeid & "';" & Chr(13)
                Else
                    strquery += "update tblinventory set quantity=quantity-" & remquantity & " where trnid='" & rst("trnid").ToString & "' and officeid='" & officeid & "';" & Chr(13)
                End If
            End If
        End While
        rst.Close()
        MsgBox(strquery)
        Return 0
    End Function

    Public Function defaultCombobox(ByVal combo As System.Windows.Forms.ComboBox, ByVal form As System.Windows.Forms.Form, ByVal showcode As Boolean)
        Dim DefaultglItemLocation As String = "" : Dim defaultCode As String = "" : Dim defaultItem As String = "" : Dim Result As String = ""
        If System.IO.File.Exists(Application.StartupPath & "\Config\" & EncryptFileName("default_" & form.Name & "_" & combo.Name)) = True Then
            DefaultglItemLocation = Application.StartupPath & "\Config\" & EncryptFileName("default_" & form.Name & "_" & combo.Name)
            Dim sr As StreamReader = File.OpenText(DefaultglItemLocation)
            Try
                Dim str As String = sr.ReadLine() : Dim cnt As Integer = 0
                For Each strresult In DecryptTripleDES(str).Split(New Char() {","c})
                    If cnt = 0 Then
                        defaultItem = strresult
                    ElseIf cnt = 1 Then
                        defaultCode = strresult
                    End If
                    cnt = cnt + 1
                Next
                sr.Close()
                sr.Dispose()
            Catch errMS As Exception
                sr.Close()
            End Try
            If showcode = True Then
                Result = defaultCode
            Else
                Result = defaultItem
            End If
            Return Result
        End If
    End Function
    Public Function SaveDefaultComboItem(ByVal combo As System.Windows.Forms.ComboBox, ByVal textvalue As String, ByVal codevalue As String, ByVal form As System.Windows.Forms.Form)
        If System.IO.File.Exists(Application.StartupPath & "\Config\" & EncryptFileName("default_" & form.Name & "_" & combo.Name)) = True Then
            System.IO.File.Delete(Application.StartupPath & "\Config\" & EncryptFileName("default_" & form.Name & "_" & combo.Name))
        End If
        Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\" & EncryptFileName("default_" & form.Name & "_" & combo.Name), True)
        detailsFile.WriteLine(EncryptTripleDES(textvalue & "," & codevalue))
        detailsFile.Close()
    End Function
    Public Function RemoveSpecialCharacter(ByVal str As String)
        Dim removechar As Char() = "!@#$%^&*()_+-={}|[]\:;'<>?/".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
    Public Function RemoveFilenameCharacter(ByVal str As String)
        Dim removechar As Char() = "!@#$%^&*+={}|[]\:;'<>?/".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
    Public Function PopulateGridViewControls(ByVal ColumnName As String, ByVal ColumnWidth As Double, ByVal ColumnType As String, ByVal gridview As DataGridView, ByVal visible As Boolean, ByVal readonlycolumn As Boolean)
        If ColumnType = "COMBO" Then
            Dim dgcmbcol As DataGridViewComboBoxColumn
            dgcmbcol = New DataGridViewComboBoxColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.ReadOnly = False
            dgcmbcol.AutoComplete = False
            dgcmbcol.FlatStyle = FlatStyle.System
            gridview.Columns.Add(dgcmbcol)

        ElseIf ColumnType = "CHECKBOX" Then
            Dim colCheckbox As New DataGridViewCheckBoxColumn()
            colCheckbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            colCheckbox.ThreeState = False
            colCheckbox.TrueValue = 1
            colCheckbox.FalseValue = 0
            colCheckbox.IndeterminateValue = System.DBNull.Value
            colCheckbox.HeaderText = ColumnName
            colCheckbox.Width = ColumnWidth
            colCheckbox.Name = ColumnName
            colCheckbox.ReadOnly = False
            gridview.Columns.Add(colCheckbox)
        Else
            Dim dgcmbcol As DataGridViewColumn
            dgcmbcol = New DataGridViewColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.CellTemplate = New DataGridViewTextBoxCell
            gridview.Columns.Add(dgcmbcol)
        End If
        gridview.Columns(ColumnName).Visible = visible
        If readonlycolumn = True Then
            gridview.Columns(ColumnName).ReadOnly = True
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.LemonChiffon
            gridview.Columns(ColumnName).DefaultCellStyle.SelectionBackColor = Color.LemonChiffon
        Else
            gridview.Columns(ColumnName).ReadOnly = False
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.White

        End If

        Return 0
    End Function


    Public Function PopulateGridViewColumns(ByVal ColumnName As String, ByVal ColumnWidth As Double, ByVal ComboBoxColumn As Boolean, ByVal gridview As DataGridView, ByVal visible As Boolean, ByVal readonlycolumn As Boolean)
        If ComboBoxColumn = True Then
            Dim dgcmbcol As DataGridViewComboBoxColumn
            dgcmbcol = New DataGridViewComboBoxColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.ReadOnly = False
            dgcmbcol.AutoComplete = False
            dgcmbcol.FlatStyle = FlatStyle.Flat
            gridview.Columns.Add(dgcmbcol)
        Else
            Dim dgcmbcol As DataGridViewColumn
            dgcmbcol = New DataGridViewColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.CellTemplate = New DataGridViewTextBoxCell
            gridview.Columns.Add(dgcmbcol)
        End If
        gridview.Columns(ColumnName).Visible = visible
        If readonlycolumn = True Then
            gridview.Columns(ColumnName).ReadOnly = True
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.LemonChiffon
            gridview.Columns(ColumnName).DefaultCellStyle.SelectionBackColor = Color.LemonChiffon

        Else
            gridview.Columns(ColumnName).ReadOnly = False
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.White
        End If

        Return 0
    End Function

    Public Function LoadComboSuggestion(ByVal ColumnName As String, ByVal gridview As DataGridView, ByVal suggestionQuery As String, ByVal suggestionValue As String)
        Dim dgvcc As DataGridViewComboBoxColumn
        dgvcc = gridview.Columns(ColumnName)
        If suggestionQuery <> "" Then
            LoadToGridComboBox(suggestionQuery, suggestionValue, dgvcc)
        End If
        Return 0
    End Function

    Public Sub ExportGridToExcel(ByVal filename As String, ByVal dst As DataSet)
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(filename) & ".xls")
                MessageBox.Show(LCase(filename) & ".xls successfully exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub ColumnGridSetup(ByVal setupName As String, ByVal gridview As DataGridView, ByVal form As Form)
        Dim colname As String = ""
        For i = 0 To gridview.ColumnCount - 1
            colname += gridview.Columns(i).Name & ","
        Next
        frmColumnChooser.txttype.Text = setupName
        frmColumnChooser.init_grid(gridview)
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
        frmColumnChooser.Show(form)
    End Sub

    Public Function getIncrementID(ByVal tableName As String) As String
        getIncrementID = ""
        com.CommandText = "SELECT `AUTO_INCREMENT` as ID FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" & sqldatabase & "' AND TABLE_NAME   = '" & tableName & "';" : rst = com.ExecuteReader
        While rst.Read
            getIncrementID = rst("ID").ToString
        End While
        rst.Close()
        com.CommandText = "ALTER TABLE `" & tableName & "` AUTO_INCREMENT = " & Val(getIncrementID) + 1 & ";" : com.ExecuteNonQuery()
        Return getIncrementID
    End Function
    Public Function getcodeid(ByVal code As String, ByVal table As String, ByVal initialcode As String)
        Dim strng = ""
        Try
            If CInt(countrecord(table)) = 0 Then
                strng = initialcode
            Else
                com.CommandText = "select (" & code & " + 1) as code from " & table & " order by " & code & " desc limit 1" : rst = com.ExecuteReader()
                While rst.Read
                    strng = rst("code").ToString
                End While
                rst.Close()
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return strng.ToString
    End Function

    Public Function RGBColorConverter(ByVal RGBString As String) As Color
        Dim RGB As String() = RGBString.Split(",")
        If RGBString.Length > 0 Then
            RGBColorConverter = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        Else
            RGBColorConverter = Color.Black
        End If
    End Function
    Public Function RemoveWhiteSpaces(ByVal str As String, ByVal removeSpecialChar As Boolean)
        Dim newStrstr As String = Regex.Replace(str, " {2,}", " ")
        If removeSpecialChar = True Then
            newStrstr = RemoveSpecialCharacter(newStrstr)
        Else
            newStrstr = newStrstr.Replace("'", "''")
            newStrstr = newStrstr.Replace("\", "\\")
        End If

        Return newStrstr
    End Function

    Public Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As MemoryStream = New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Public Function ConvertDatabaseImage(ByVal fld As String, ByVal picbox As System.Windows.Forms.PictureBox)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                picbox.Image = img

            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function ResizeImage(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal imgsize As Integer)
        Try
            If Not img.Image Is Nothing Then
                Dim Original As New Bitmap(img.Image)
                img.Image = Original

                Dim m As Int32 = imgsize
                Dim n As Int32 = m * Original.Height / Original.Width

                Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
                Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

                Dim g As Graphics = Graphics.FromImage(Thumb)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High
                g.DrawImage(Original, New Rectangle(0, 0, m, n))
                img.Image = Thumb
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return 0
    End Function

    Public Function ResizeBinaryImage(ByVal img As Image, ByVal imgsize As Integer)
        Try
            If Not img Is Nothing Then
                Dim Original As New Bitmap(img)
                img = Original

                Dim m As Int32 = imgsize
                Dim n As Int32 = m * Original.Height / Original.Width

                Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
                Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

                Dim g As Graphics = Graphics.FromImage(Thumb)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

                g.DrawImage(Original, New Rectangle(0, 0, m, n))
                img = Thumb
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return img
    End Function

    Public Function ConvertImageBinary(ByVal fld As String)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)

            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return img
    End Function

    Public Function SearchProductName(ByVal fieldname As String, ByVal strString As String)
        Dim StrQuery As String = ""
        If strString.Contains(" ") = True Then
            For Each word In strString.Split(New Char() {" "c})
                StrQuery += fieldname & " like '%" & word & "%' and "
            Next
            StrQuery = "(" & StrQuery.Remove(StrQuery.Length - 4, 4) & ")"
        Else
            StrQuery = fieldname & " like '%" & strString & "%'"
        End If
        Return StrQuery
    End Function

End Module
