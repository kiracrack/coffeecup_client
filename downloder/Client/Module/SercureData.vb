﻿Imports System.Security.Cryptography
Module SercureData

    Public GlobalDisableSystem As Boolean
    Public GlobalDisableTrigger As String = ""
    Public GlobalDisableValue As String = ""

    Const sKey As String = "kira"

    Public Function EncryptTripleDES(ByVal sIn As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function DecryptTripleDES(ByVal sOut As String) As String
        Dim str As String = ""
        If sOut.Length > 1 Then
            Dim DES As New TripleDESCryptoServiceProvider()
            Dim hashMD5 As New MD5CryptoServiceProvider()

            ' Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
            ' Set the cipher mode.
            DES.Mode = CipherMode.ECB
            ' Create the decryptor.
            Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
            Dim Buffer As Byte() = Convert.FromBase64String(sOut)
            ' Transform and return the string.
            str = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        End If
        Return str
    End Function

    Public Function EncrytSpecialCharacter(ByVal Text As String) As String
        ' Encrypts/decrypts the passed string using 
        ' a simple ASCII value-swapping algorithm
        Dim strTempChar As String, i As Integer
        For i = 1 To Len(Text)
            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) + 128, String)
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) - 128, String)
            End If
            Mid$(Text, i, 1) = _
                Chr(CType(strTempChar, Integer))
        Next i
        Return Text
    End Function


    Public Function EncryptFileName(ByVal sIn As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return RemoveSpecialCharacter(Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length)))
    End Function

    Public Function EncryptCoffeecup(ByVal sIn As String, ByVal myKey As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(myKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function Decryptoffeecup(ByVal sOut As String, ByVal myKey As String) As String
        Try
            Dim DES As New TripleDESCryptoServiceProvider()
            Dim hashMD5 As New MD5CryptoServiceProvider()

            ' Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(myKey))
            ' Set the cipher mode.
            DES.Mode = CipherMode.ECB
            ' Create the decryptor.
            Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
            Dim Buffer As Byte() = Convert.FromBase64String(sOut)
            ' Transform and return the string.
            Return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch errMS As Exception

        End Try
    End Function


    Public Sub LoadGlobalLicense()
        'If countqry(" `mysql`.`help_topic`", "`help_topic_id`='467' and help_category_id=1") = 0 Then
        '    If countqry(" `mysql`.`help_topic`", "`help_topic_id`='467'") = 0 Then
        '        com.CommandText = "update `mysql`.`help_topic` set help_category_id=1 where `help_topic_id`='467';" : com.ExecuteNonQuery()
        '        GlobalDisableSystem = True
        '    Else
        '        com.CommandText = "select * from `mysql`.`help_topic` where help_topic_id='467'" : rst = com.ExecuteReader
        '        While rst.Read
        '            GlobalDisableTrigger = rst("example").ToString
        '        End While
        '        rst.Close()

        '        If GlobalDisableTrigger = "" Then
        '            com.CommandText = "update `mysql`.`help_topic` set help_category_id=1 where `help_topic_id`='467';" : com.ExecuteNonQuery()
        '            GlobalDisableSystem = True
        '        Else
        '            GlobalDisableValue = Decryptoffeecup(GlobalDisableTrigger, "a_zur_e")
        '        End If

        '        If GlobalDisableValue <> "FREE" Then
        '            If CDate(Now) > CDate(GlobalDisableValue) Then
        '                com.CommandText = "update `mysql`.`help_topic` set help_category_id=1 where `help_topic_id`='467';" : com.ExecuteNonQuery()
        '                GlobalDisableSystem = True
        '            End If
        '        End If
        '    End If
        'Else
        '    GlobalDisableSystem = True
        'End If

    End Sub
End Module
