Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading.Tasks
Imports System.Drawing.Printing

Public Class frmRequisition

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmRequisition()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region

    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Dim RequestSent As Boolean = False
    Dim m_CountTo As Integer = 0 ' How many time to loop.
    Dim requestno As String = ""
    Dim send_retry As Integer = 1

    Delegate Sub SetLabelText_Delegate(ByVal [Label] As Label, ByVal [text] As String)
    Private Sub SetLabelText_ThreadSafe(ByVal [Label] As Label, ByVal [text] As String)
        If [Label].InvokeRequired Then
            Dim MyDelegate As New SetLabelText_Delegate(AddressOf SetLabelText_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[Label], [text]})
        Else
            [Label].Text = [text]
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F3 Then
            cmdFind.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Cursor = Cursors.WaitCursor
        txtDateNeeded.Value = Now
        'txtDateNeeded.MinDate = Now
        ApplySystemTheme(ToolStrip3)
        LoadOffice()
        If compallowcreaterequestforotheroffice = True Then
            officeid.Text = ""
        Else
            txtSelectOffice.Text = compOfficename
            officeid.Text = compOfficeid
            LoadRequestBy()
        End If
        LoadToComboBoxDB("select * from tblrequesttype order by description asc", "description", "potypeid", txtPurchaseType)
        ' LoadToComboBoxDB("select * from tblhotelguest where  order by fullname asc", "fullname", "guestid", txtAllocatedExpense)
        If mode.Text = "edit" Then
            LoadRequestInfo()
            pid.Enabled = True
            pid.Size = New Size(215, 21)
            cmdCancel.Visible = True
        Else
            requestno = ""
            loadTempParticular()

            If GlobalDirectApprovedPr = True Or compCorporateoffice = True Then
                txtApprovingLevel.SelectedIndex = 1
                txtApprovingLevel.Enabled = False
            Else
                txtApprovingLevel.SelectedIndex = -1
                txtApprovingLevel.Enabled = True
            End If
            txtPriority.SelectedIndex = 1
            pid.Items.Add(getGlobalTrnid(compOfficeid, globaluserid))
            pid.SelectedIndex = 0
            pid.Enabled = False
            pid.Size = New Size(243, 21)
            cmdCancel.Visible = False

            'Dim forrevision As Integer = countqry("tblrequisitions", "officeid='" & officeid.text & "' and approvedbranch=0 and hold=1")
            'If forrevision > 0 Then
            '    LinkLabel1.Text = "For revision (" & forrevision & ")"
            '    LinkLabel1.LinkColor = Color.Red
            'Else
            '    LinkLabel1.Text = "View History"
            '    LinkLabel1.LinkColor = Color.Blue
            'End If
        End If
       

        lblAttachment.Text = "Please attach files not more than " & GlobalAllowableAttachSize / 1024 & " KB or " & (GlobalAllowableAttachSize / 1024) / 1024 & " MB. For multiple files please compress to ZIP files. Please Click ""How to compress your files"" to view tutorial"
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub LoadOffice()
        If compallowcreaterequestforotheroffice = True Then
            LoadToComboBoxDB("select * from tblcompoffice where deleted=0 order by officename asc", "officename", "officeid", txtSelectOffice)
        Else
            LoadToComboBoxDB("select * from tblcompoffice where deleted=0 and officeid='" & compOfficeid & "' order by officename asc", "officename", "officeid", txtSelectOffice)
        End If

    End Sub

    Private Sub txtSelectOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSelectOffice.SelectedValueChanged
        If txtSelectOffice.Text = "" Then Exit Sub
        officeid.Text = DirectCast(txtSelectOffice.SelectedItem, ComboBoxItem).HiddenValue
        LoadRequestBy()
    End Sub

    Public Sub LoadRequestBy()
        LoadToComboBoxDB("select * from tblaccounts where username<>'ROOT' and officeid='" & officeid.Text & "' and deleted=0 order by fullname asc", "fullname", "accountid", txtrequester)
    End Sub
    Public Sub FillComboFromFile()
        Dim path As String = Application.StartupPath.ToString & "\Resources\Draft"
        If CheckBox1.Checked = True Then
            pid.Items.Clear()
            For Each file As String In System.IO.Directory.GetFiles(path)
                pid.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next
            loadTempParticular()
        End If
    End Sub
    Public Sub loadTempParticular()
        Dim path As String = Application.StartupPath.ToString & "\Resources\Particular Items\" & pid.Text & ".txt"
        MyDataGridView.Rows.Clear()
        MyDataGridView.ColumnCount = 12
        MyDataGridView.ColumnHeadersVisible = True

        MyDataGridView.Columns(0).Name = "Particular"
        MyDataGridView.Columns(1).Name = "Quantity"
        MyDataGridView.Columns(2).Name = "Unit"
        MyDataGridView.Columns(3).Name = "Unit Cost"
        MyDataGridView.Columns(4).Name = "Total"
        MyDataGridView.Columns(5).Name = "Remarks"
        MyDataGridView.Columns(6).Name = "Supplier"
        MyDataGridView.Columns(7).Name = "trnid"
        MyDataGridView.Columns(8).Name = "purchaseid"
        MyDataGridView.Columns(9).Name = "productid"
        MyDataGridView.Columns(10).Name = "catid"
        MyDataGridView.Columns(11).Name = "vendorid"

        If File.Exists(path) = True Then
            Dim sr As StreamReader = New StreamReader(path)
            Do While sr.Peek() >= 0
                Dim arr() As String = sr.ReadLine().Split(New Char() {"|"c})
                MyDataGridView.Rows.Add(arr)
            Loop
            sr.Close()
        End If
        GridHideColumn(MyDataGridView, {"trnid", "purchaseid", "productid", "catid", "vendorid"})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit", "Last Update"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Unit Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        If MyDataGridView.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView.RowCount - 1
                totalsum = totalsum + MyDataGridView.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Unit").Value = "Total"
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Total").Value = totalsum
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
            txtPurchaseType.Enabled = False
        Else
            txtPurchaseType.Enabled = True
        End If
    End Sub


    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        If Not IsNothing(e.Value) And e.ColumnIndex > 2 Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
            End If
            'If e.ColumnIndex = MyDataGridView.Columns("Remarks").Index Then
            '    e.Value = e.Value.ToString.Replace("\n", vbCrLf)
            'End If
        End If
    End Sub
    Private Sub MyDataGridView_quotation_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Not IsNothing(e.Value) And e.ColumnIndex > 2 Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
            End If
        End If
    End Sub
    Private Sub txtPurchaseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtPurchaseType.SelectedValueChanged
        If txtPurchaseType.Text = "" Then Exit Sub
        potypeid.Text = DirectCast(txtPurchaseType.SelectedItem, ComboBoxItem).HiddenValue
    End Sub

    Private Sub txtrequester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtrequester.SelectedValueChanged
        If txtrequester.Text = "" Then Exit Sub
        reqid.Text = DirectCast(txtrequester.SelectedItem, ComboBoxItem).HiddenValue
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        If txtPurchaseType.Text = "" Then
            MessageBox.Show("Please select request type!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtPurchaseType.Focus()
            Exit Sub
        End If
        frmSelectParticular.potypeid.Text = potypeid.Text
        frmSelectParticular.pid.Text = pid.Text
        frmSelectParticular.Show(Me)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub


    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete.PerformClick()
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        If GlobalStrictApproverSignature = True And qrysingledata("digitalsign", "digitalsign", "tblaccounts where accountid='" & reqid.Text & "'").ToString.Length = 0 Then
            MessageBox.Show("Selected requestor name  """ & txtrequester.Text & """ has no digital signature! Please contact IT Department and follow instruction below: " & Environment.NewLine & Environment.NewLine & "1. Submit your signature on clean white paper with your fullname" & Environment.NewLine & "2. Scan it and Email to IT Department" & Environment.NewLine & "3. wait for IT confirmation, then you can proceed your transaction", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf pid.Text = "" And CheckBox1.Checked = True Then
            MessageBox.Show("Please select request from draft list!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            pid.Focus()
            Exit Sub
        ElseIf txtApprovingLevel.Text = "" Then
            MessageBox.Show("Please select Approving Level!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtApprovingLevel.Focus()
            Exit Sub
        ElseIf txtPurchaseType.Text = "" Then
            MessageBox.Show("Please select Request Type!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtPurchaseType.Focus()
            Exit Sub
        ElseIf txtrequester.Text = "" Then
            MessageBox.Show("Please select Request by!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtrequester.Focus()
            Exit Sub

        ElseIf MyDataGridView.RowCount <= 1 Then
            MessageBox.Show("There's no particular item to send!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 1
            Exit Sub
        ElseIf txtRequestJustification.Text.Length <= 2 Then
            MessageBox.Show("Please enter your request justification!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtRequestJustification.Focus()
            Exit Sub
        ElseIf txtMessage.Text.Length <= 2 Then
            MessageBox.Show("Please enter your message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtMessage.Focus()
            Exit Sub
        End If
        TabControl1.SelectedIndex = 0
        If ckQuotation.Checked = True Then
            If txtattached1.Text = "" Then
                MessageBox.Show("Please attach document atleast one!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtattached1.Focus()
                Exit Sub
            ElseIf checkAttachment(txtattached1.Text) = False Then
                MessageBox.Show("Your attachment is greater than system attachment allowable limit!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtattached1.Focus()
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are you sure you want to send this request? " & Environment.NewLine & Environment.NewLine & "Note: Sending with attachment file may take a while, depending on the amount of data and internet or VPN connectivity.  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim path As String = Application.StartupPath.ToString & "\Resources\Draft\" & pid.Text & ".txt"
            System.IO.File.Delete(path)
            Dim sw As StreamWriter = File.AppendText(path)
            sw.WriteLine(potypeid.Text & "|" & txtPurchaseType.Text & "|" & reqid.Text & "|" & txtrequester.Text & "|" & txtPriority.Text & "|" & allocatedid.Text & "|" & ConvertDate(txtDateNeeded.Value) & "|" & txtApprovingLevel.Text & "|" & ckQuotation.CheckState & "|" & txtattached1.Text & "|" & EncryptTripleDES(txtRequestJustification.Text))
            sw.Close()

            send_retry = 1
            Me.Start_Button.Enabled = False
            Me.Stop_Button.Enabled = True
            ProgressBar1.Visible = True
            Lbl_Status.Visible = True
            ProgressBar1.Value = 0
            MainForm.Timer1.Stop()
            MainForm.BackgroundWorker1.CancelAsync()
            My_BgWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub ckQuotation_CheckedChanged(sender As Object, e As EventArgs) Handles ckQuotation.CheckedChanged
        If ckQuotation.Checked = True Then
            cmda1.Enabled = True
        Else
            txtattached1.Text = ""
            cmda1.Enabled = False
        End If
    End Sub

    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmda1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "All Types (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'txtattached1.Text = objOpenFileDialog.FileName
                If checkAttachment(objOpenFileDialog.FileName) = False Then
                    txtattached1.BackColor = Color.Red
                Else
                    txtattached1.BackColor = Color.White
                    If (Not System.IO.Directory.Exists(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")) Then
                        System.IO.Directory.CreateDirectory(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")
                    End If
                    System.IO.File.Delete(file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                    System.IO.File.Copy(objOpenFileDialog.FileName, file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                End If
                txtattached1.Text = file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName)
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub


    Private Sub pid_SelectedValueChanged(sender As Object, e As EventArgs) Handles pid.SelectedValueChanged
        LoadRequestInfo()
    End Sub
    Public Sub LoadRequestInfo()
        ' Try
        If pid.Text <> "" And CheckBox1.Checked = True Then
            Dim sr As StreamReader = File.OpenText(Application.StartupPath.ToString & "\Resources\Draft\" & pid.Text & ".txt")
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim cnt As Integer = 0
            For Each word In br.Split(New Char() {"|"c})
                If cnt = 0 Then
                    officeid.Text = word
                ElseIf cnt = 1 Then
                    txtSelectOffice.Text = word
                ElseIf cnt = 2 Then
                    potypeid.Text = word
                ElseIf cnt = 3 Then
                    txtPurchaseType.Text = word
                ElseIf cnt = 4 Then
                    reqid.Text = word
                ElseIf cnt = 5 Then
                    txtrequester.Text = word
                ElseIf cnt = 6 Then
                    txtPriority.Text = word
                ElseIf cnt = 7 Then
                    allocatedid.Text = word
                ElseIf cnt = 8 Then
                    txtDateNeeded.Value = CDate(word)
                ElseIf cnt = 9 Then
                    txtApprovingLevel.Text = word
                ElseIf cnt = 10 Then
                    ckQuotation.Checked = CInt(word)
                ElseIf cnt = 11 Then
                    txtattached1.Text = word
                ElseIf cnt = 12 Then
                    txtRequestJustification.Text = DecryptTripleDES(word)
                End If
                cnt = cnt + 1
            Next
        End If
        'Catch ex As Exception
        '    MsgBox("Old draft data not compatible to the new update. please remove to prevent system error", MsgBoxStyle.Critical)
        'End Try
        loadTempParticular()
    End Sub
    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles Stop_Button.Click
        If My_BgWorker.IsBusy Then
            If My_BgWorker.WorkerSupportsCancellation Then
                My_BgWorker.CancelAsync()
            End If
            Me.Start_Button.Enabled = True
            Me.Stop_Button.Enabled = False
        Else
            Me.Close()
        End If
    End Sub
    Private Sub DoThreadedStuff()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() DoTheCode())
        Else
            DoTheCode()
        End If
    End Sub
    Private Sub My_BgWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles My_BgWorker.DoWork
        ' Has the background worker be told to stop?
        If My_BgWorker.CancellationPending Then
            ' Set Cancel to True
            e.Cancel = True
        End If
        System.Threading.Thread.Sleep(1000) ' Sleep for 1 Second
        DoThreadedStuff()
    End Sub
    Public Sub DoTheCode()
        'RUN LARGE PROCESS
        While MainForm.BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While
        Try
            Me.Lbl_Status.Text = "Connecting to server.."
            If CheckConnectionServer() = True Then
                My_BgWorker.ReportProgress(20)
                Me.Lbl_Status.Text = "Creating request number.."
                Dim path As String = Application.StartupPath.ToString & "\Resources\Draft\" & pid.Text & ".txt"
                Dim seq As Integer = 0

                '#CLEAR EXISTING REQUEST IF ERROR OCCURE
                com.CommandText = "DELETE FROM tblrequisitionsitem where trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "DELETE FROM tblrequisitionslogsitem where trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()


                '#CREATING REQUEST NUMBER
                If Val(qrysingledata("p", "CONVERT(SUBSTRING_INDEX( `pid` , '-', -1 ),UNSIGNED INTEGER) AS p", "tblrequisitions order by p desc limit 1;")) = 0 Then 'if the request start from 0
                    seq = countrecord("tblrequisitions") + 1
                Else
                    seq = Val(qrysingledata("p", "CONVERT(SUBSTRING_INDEX( `pid` , '-', -1 ),UNSIGNED INTEGER) AS p", "tblrequisitions order by p desc limit 1;")) + 1
                End If

                If countqry("tblrequisitions", "trnrefno='" & pid.Text & "'") = 0 Then
                    requestno = getGlobalRequestid("R" & globaluserid, seq)
                Else
                    requestno = qrysingledata("pid", "pid", "tblrequisitions where trnrefno='" & pid.Text & "'")
                End If

                My_BgWorker.ReportProgress(40)
                '#--

                If ckQuotation.Checked = True Then
                    Me.Lbl_Status.Text = "Uploading attachment.."
                    If countqry("tblrequisitions", "trnrefno='" & pid.Text & "'") > 0 Then
                        requestno = qrysingledata("pid", "pid", "tblrequisitions where trnrefno='" & pid.Text & "'")
                    End If
                    If AddAttachmentPackage(requestno, "requisition", {txtattached1.Text}) = True Then
                        My_BgWorker.ReportProgress(60)
                        CompletingRequest()
                    Else
                        RequestSent = False
                    End If
                Else
                    CompletingRequest()
                End If
            Else
                RequestSent = False
            End If
        Catch ex As SqlException
            RequestSent = False
            MessageBox.Show("Your request was not sent due to connection error! please try again.")
        End Try
    End Sub

    Public Sub CompletingRequest()
        Dim totalsum As Double = 0
        For i = 0 To MyDataGridView.RowCount - 1
            totalsum = totalsum + MyDataGridView.Rows(i).Cells("Total").Value()
        Next
        Me.Lbl_Status.Text = "Sending your request.."

        SendRequisition(requestno)

        '#Record requisition logs
        com.CommandText = "delete from tblrequisitionslogs where pid='" & requestno & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblrequisitionslogs set pid='" & requestno & "', " _
                             + " trnrefno='" & pid.Text & "', " _
                             + " REQUESTBY=" & reqid.Text & ", " _
                             + " officeid='" & officeid.Text & "'," _
                             + " POTYPEID='" & potypeid.Text & "', " _
                             + " DETAILS='" & rchar(txtRequestJustification.Text) & "', " _
                             + " DATEREQUEST=current_timestamp, " _
                             + " dateneeded='" & ConvertDate(txtDateNeeded.Text) & "', " _
                             + " approvinglevel='" & txtApprovingLevel.Text & "', " _
                             + " priority='" & txtPriority.Text & "',  " _
                             + " allocatedexpense='" & allocatedid.Text & "', " _
                             + " attachmentpath='" & rchar(txtattached1.Text) & "', " _
                             + " requesttrnby='" & globaluserid & "'" : com.ExecuteNonQuery()


        RecordApprovingHistory("requisition", requestno, requestno, "Processed", txtMessage.Text)
        My_BgWorker.ReportProgress(80)
        Me.Lbl_Status.Text = "Finilizing your request in few seconds remaining.."

        NextEmailBranchLevelRequisitionApprover(requestno, txtPurchaseType.Text, txtMessage.Text)
        My_BgWorker.ReportProgress(100)
        RequestSent = True
    End Sub

    Public Sub SendRequisition(ByVal requestpid As String)
        If countqry("tblrequisitions", "trnrefno='" & pid.Text & "'") = 0 Then
            com.CommandText = "insert into tblrequisitions set pid='" & requestpid & "', " _
                           + " requestby=" & reqid.Text & ", " _
                           + " officeid='" & officeid.Text & "'," _
                           + " potypeid='" & potypeid.Text & "', " _
                           + " priority='" & txtPriority.Text & "',  " _
                           + " dateneeded='" & ConvertDate(txtDateNeeded.Value) & "', " _
                           + " allocatedexpense='', " _
                           + " details='" & rchar(txtRequestJustification.Text) & "', " _
                           + " trnby=" & globaluserid & ", " _
                           + " corporatelevel='" & txtApprovingLevel.SelectedIndex & "', " _
                           + " hold=false, " _
                           + " daterequest=current_timestamp, " _
                           + " trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblrequisitions set requestby=" & reqid.Text & ", " _
                            + " officeid='" & officeid.Text & "'," _
                            + " potypeid='" & potypeid.Text & "', " _
                            + " priority='" & txtPriority.Text & "',  " _
                            + " dateneeded='" & ConvertDate(txtDateNeeded.Value) & "', " _
                            + " allocatedexpense='', " _
                            + " details='" & rchar(txtRequestJustification.Text) & "', " _
                            + " trnby=" & globaluserid & ", " _
                            + " corporatelevel='" & txtApprovingLevel.SelectedIndex & "', " _
                            + " hold=false " _
                            + " where trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()
        End If

        If GlobalDirectApprovedPr = True Then
            com.CommandText = "update tblrequisitions set approvedbranch=1, dateapproved=current_timestamp where trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()
        End If

        Dim rpid As String = qrysingledata("pid", "pid", "tblrequisitions where trnrefno='" & pid.Text & "'")
        For cnt = 0 To MyDataGridView.RowCount - 1
            With MyDataGridView
                If .Item("trnid", cnt).Value <> "" Then
                    'record requisition item
                    com.CommandText = "insert into tblrequisitionsitem set " _
                                             + " pid='" & rpid & "', " _
                                             + " officeid='" & officeid.text & "', " _
                                             + " productid = '" & .Item("productid", cnt).Value & "', " _
                                             + " catid = '" & .Item("catid", cnt).Value & "', " _
                                             + " vendorid = '" & .Item("vendorid", cnt).Value & "', " _
                                             + " quantity = '" & CC(.Item("Quantity", cnt).Value) & "', " _
                                             + " unit = '" & .Item("Unit", cnt).Value & "', " _
                                             + " cost = '" & CC(.Item("Unit Cost", cnt).Value) & "', " _
                                             + " total = '" & CC(.Item("Total", cnt).Value) & "', " _
                                             + " remarks = '" & rchar(.Item("Remarks", cnt).Value) & "', " _
                                             + " trnby='" & globaluserid & "', " _
                                             + " datetrn=current_timestamp, " _
                                             + " trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()

                    'record requisition item as logs
                    com.CommandText = "insert into tblrequisitionslogsitem set " _
                                            + " pid='" & rpid & "', " _
                                            + " officeid='" & officeid.text & "', " _
                                            + " productid = '" & .Item("productid", cnt).Value & "', " _
                                            + " catid = '" & .Item("catid", cnt).Value & "', " _
                                            + " vendorid = '" & .Item("vendorid", cnt).Value & "', " _
                                            + " quantity = '" & CC(.Item("Quantity", cnt).Value) & "', " _
                                            + " unit = '" & .Item("Unit", cnt).Value & "', " _
                                            + " cost = '" & CC(.Item("Unit Cost", cnt).Value) & "', " _
                                            + " total = '" & CC(.Item("Total", cnt).Value) & "', " _
                                            + " remarks = '" & rchar(.Item("Remarks", cnt).Value) & "', " _
                                            + " trnby='" & globaluserid & "', " _
                                            + " datetrn=current_timestamp, " _
                                            + " trnrefno='" & pid.Text & "'" : com.ExecuteNonQuery()
                End If
            End With
        Next
    End Sub

    Private Sub My_BgWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles My_BgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            Me.Lbl_Status.Text = "Cancelled"
            ProgressBar1.Visible = False
            Lbl_Status.Visible = False
            Start_Button.Text = "Send Request"
            Me.Start_Button.Enabled = True
            Me.Stop_Button.Enabled = False
            MainForm.Timer1.Start()
            RequestSent = False
        Else
            Dim path As String = Application.StartupPath.ToString & "\Resources\Draft\" & pid.Text & ".txt"
            Dim approvedPath As String = Application.StartupPath.ToString & "\Resources\Request Sent\" & pid.Text & ".txt"
            If RequestSent = True Then
                Me.Lbl_Status.Text = "Request sent.."
                MessageBox.Show("Your request was successfully sent! " & Environment.NewLine & Environment.NewLine _
                                & "Request Number: " & requestno & Environment.NewLine _
                                & "Date/time Sent: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt") & Environment.NewLine & Environment.NewLine _
                                & "Note: You will receive notification via email if the procurement officer recieved your request!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                System.IO.File.Delete(approvedPath)
                System.IO.File.Copy(path, approvedPath)
                System.IO.File.Delete(path)

                FillComboFromFile()
                ProgressBar1.Visible = False
                Lbl_Status.Visible = False

                Me.Start_Button.Enabled = True
                Me.Stop_Button.Enabled = False
                Start_Button.Text = "Send Request"
                MainForm.Timer1.Start()
                RequestSent = False
                Me.Close()
            Else
                send_retry = send_retry + 1
                If send_retry >= 20 Then
                    ProgressBar1.Visible = False
                    Lbl_Status.Visible = False
                    Start_Button.Text = "Send Request"
                    ProgressBar1.Value = 0
                    Me.Start_Button.Enabled = True
                    Me.Stop_Button.Enabled = False
                    MainForm.Timer1.Start()
                    RequestSent = False
                    MessageBox.Show("Your request was not sent due to connection error! Please try again later.", _
                                                    "Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.Lbl_Status.Text = send_retry.ToString & " times! Trying to connect server.."
                    ProgressBar1.Value = send_retry
                    MainForm.Timer1.Stop()
                    MainForm.BackgroundWorker1.CancelAsync()
                    My_BgWorker.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub My_BgWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles My_BgWorker.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If pid.Text = "" Then
            MessageBox.Show("Please select Request batch!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pid.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to delete this request? " & Environment.NewLine, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            System.IO.File.Delete(Application.StartupPath.ToString & "\Resources\Draft\" & pid.Text & ".txt")
            System.IO.File.Delete(Application.StartupPath.ToString & "\Resources\Particular Items\" & pid.Text & ".txt")
            FillComboFromFile()

            potypeid.Text = ""
            txtPurchaseType.SelectedIndex = -1
            reqid.Text = ""
            txtrequester.SelectedIndex = -1
            txtPriority.SelectedIndex = -1
            txtApprovingLevel.SelectedIndex = -1
            ckQuotation.Checked = False
            txtattached1.Text = ""
            txtRequestJustification.Text = ""
            loadTempParticular()
        End If
    End Sub


    Private Sub txtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Process.Start(Application.StartupPath & "\attachment.pdf")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to save as draft current request? " & Environment.NewLine, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim path As String = Application.StartupPath.ToString & "\Resources\Draft\" & pid.Text & ".txt"
            System.IO.File.Delete(path)
            Dim sw As StreamWriter = File.AppendText(path)
            sw.WriteLine(officeid.Text & "|" & txtSelectOffice.Text & "|" & potypeid.Text & "|" & txtPurchaseType.Text & "|" & reqid.Text & "|" & txtrequester.Text & "|" & txtPriority.Text & "|" & allocatedid.Text & "|" & ConvertDate(txtDateNeeded.Value) & "|" & txtApprovingLevel.Text & "|" & ckQuotation.CheckState & "|" & txtattached1.Text & "|" & EncryptTripleDES(txtRequestJustification.Text))
            sw.Close()
            MessageBox.Show("Your request was successfully saved! " & Environment.NewLine & Environment.NewLine _
                               & "Reference Number: " & pid.Text & Environment.NewLine _
                               & "Date/time saved: " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt"), GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            FillComboFromFile()
            pid.Enabled = True
            pid.Size = New Size(215, 21)
            cmdCancel.Visible = True
        Else
            pid.Items.Clear()
            pid.Items.Add(getGlobalTrnid(compOfficeid, globaluserid))
            pid.SelectedIndex = 0
            pid.Enabled = False
            pid.Size = New Size(243, 21)
            cmdCancel.Visible = False

            potypeid.Text = ""
            txtPurchaseType.SelectedIndex = -1
            reqid.Text = ""
            txtrequester.SelectedIndex = -1
            txtPriority.SelectedIndex = -1
            'txtApprovingLevel.SelectedIndex = -1
            ckQuotation.Checked = False
            txtattached1.Text = ""
            txtRequestJustification.Text = ""
            loadTempParticular()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmProductRequest.Show(Me)
    End Sub

   
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmRequestHistory.ShowDialog(Me)
        FillComboFromFile()
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        frmRequestQuantitySelect.mode.Text = "edit"
        frmRequestQuantitySelect.pid.Text = pid.Text
        frmRequestQuantitySelect.editindex.Text = MyDataGridView.CurrentRow.Index.ToString
        frmRequestQuantitySelect.editRef.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString

        frmRequestQuantitySelect.txtquan.Text = MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.productid.Text = MyDataGridView.Item("productid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.catid.Text = MyDataGridView.Item("catid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtunit.Text = MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtProductName.Text = MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtsti.Text = FormatNumber(MyDataGridView.Item("Unit Cost", MyDataGridView.CurrentRow.Index).Value().ToString)
        frmRequestQuantitySelect.txtvendor.Text = MyDataGridView.Item("Supplier", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.vendorid.Text = MyDataGridView.Item("vendorid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtdetails.Text = MyDataGridView.Item("Remarks", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.Show(Me)
    End Sub

    Private Sub MyDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentDoubleClick
        EditItemToolStripMenuItem.PerformClick()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        loadTempParticular()
    End Sub

    
    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If CheckSelectedRow(MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString) = True Then
            If MessageBox.Show("Are you sure you want to permanently delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim path As String = Application.StartupPath.ToString & "\Resources\Particular Items\" & pid.Text & ".txt"
                Dim lines As New List(Of String)
                Using sr As New StreamReader(path)
                    While Not sr.EndOfStream
                        lines.Add(sr.ReadLine)
                    End While
                End Using

                For Each line As String In lines
                    If line.Contains(MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString) Then
                        lines.Remove(line)
                        Exit For 'must exit as we changed the iteration 
                    End If
                Next

                Using sw As New StreamWriter(path)
                    For Each line As String In lines
                        sw.WriteLine(line)
                    Next
                End Using
                loadTempParticular()
            End If
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        DeleteSelectedToolStripMenuItem.PerformClick()
    End Sub

    'Private Sub txtAllocatedExpense_SelectedValueChanged(sender As Object, e As EventArgs)
    '    If txtAllocatedExpense.Text = "" Then Exit Sub
    '    allocatedid.Text = DirectCast(txtAllocatedExpense.SelectedItem, ComboBoxItem).HiddenValue
    'End Sub
End Class