Imports DevExpress.XtraEditors
Imports System.IO
Imports MySql.Data.MySqlClient

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Dim features As String = ""

    Public Sub SystemDatabaseUpdater()
        On Error Resume Next
        Dim updateVersion As String = "" : Dim updateDescription As String = ""

        updateVersion = "2018-06-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelfolioguest` ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `closedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemailnotification` ADD COLUMN `replyto` VARCHAR(1024) NOT NULL DEFAULT '' AFTER `receiver`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `logourl` TEXT AFTER `telephone`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-10"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalessummary` MODIFY COLUMN `openby` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If System.IO.File.Exists(file_conn) = True Then
                System.IO.File.Delete(file_conn)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(file_conn, True)
            detailsFile.WriteLine(EncryptTripleDES(sqlserver & "," & sqlport & "," & sqluser & "," & sqlpass & "," & sqldatabase & ",filedir"))
            detailsFile.Close()
            engineupdated = True
        End If

        updateVersion = "2018-08-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblchatlogs` ADD COLUMN `r_deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `dateread`, ADD COLUMN `s_deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `r_deleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-08-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblchatlogs` ADD COLUMN `isnotified` BOOLEAN NOT NULL DEFAULT 0 AFTER `isread`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        

        Dim fileSystemInfo As System.IO.FileSystemInfo
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(Application.StartupPath.ToString)
        For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
            If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                If fileSystemInfo.Name.Contains("v15.1") Then
                    System.IO.File.Delete(fileSystemInfo.Name)
                    engineupdated = True
                End If
            End If
        Next
        
        If engineupdated = True Then
            Dim dversion As Date = updateVersion
            MessageBox.Show("Your database engine was updated to Build Version v" & dversion.ToString("yy.M.d") & Environment.NewLine, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub

    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs set databaseversion='" & nVersions & "',dateupdate=current_timestamp,appliedquery='" & strQuery & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

  
End Module
