Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Namespace NormingExtension
    Friend Class Cryptology
        Shared fsInput As System.IO.FileStream
        Shared fsOutput As System.IO.FileStream
        Shared syspwd As String = "s0ph3@k@pr0n0mt3ch2018"
        Shared syskey As String = "sc0tt@s@vanl3g3nd2018"


        Private Shared Function CreateKey(ByVal strPassword As String, ByVal strVerifyKey As String) As Byte()
            Dim bytKey As Byte()
            Dim bytSalt As Byte() = System.Text.Encoding.ASCII.GetBytes(strVerifyKey)
            Dim pdb As New PasswordDeriveBytes(strPassword, bytSalt)
            bytKey = pdb.GetBytes(32)
            Return bytKey
        End Function
        Private Shared Function CreateIV(ByVal strPassword As String, ByVal strVerifyKey As String) As Byte()
            Dim bytIV As Byte()
            Dim bytSalt As Byte() = System.Text.Encoding.ASCII.GetBytes(strVerifyKey)
            Dim pdb As New PasswordDeriveBytes(strPassword, bytSalt)
            bytIV = pdb.GetBytes(16)
            Return bytIV
        End Function

        Shared Function EncryptText(ByVal TextToEncrypt As String) As String
            Dim Results As Byte()
            Dim UTF8 As New System.Text.UTF8Encoding
            Dim HashProvider As New MD5CryptoServiceProvider
            Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(syspwd))
            Dim TDESAlgorithm As New TripleDESCryptoServiceProvider
            TDESAlgorithm.Key = TDESKey
            TDESAlgorithm.Mode = CipherMode.ECB
            TDESAlgorithm.Padding = PaddingMode.PKCS7
            Dim DataToEncrypt As Byte() = UTF8.GetBytes(TextToEncrypt)
            Try
                Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
            Catch ex As Exception
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try
            Return Convert.ToBase64String(Results)
        End Function
        Shared Function DecryptText(ByVal TextToDecrypt As String) As String
            Dim res As Byte()
            Dim UTF8 As New System.Text.UTF8Encoding
            Dim HashProvider As New MD5CryptoServiceProvider
            Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(syspwd))
            Dim TDESAlgorithm As New TripleDESCryptoServiceProvider
            TDESAlgorithm.Key = TDESKey
            TDESAlgorithm.Mode = CipherMode.ECB
            TDESAlgorithm.Padding = PaddingMode.PKCS7
            Dim DataToDecrypt As Byte() = Convert.FromBase64String(TextToDecrypt)
            Try
                Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
                res = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
            Catch ex As Exception
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try
            Return UTF8.GetString(res)


        End Function

        Shared Sub EncryptFile(ByVal strInputFile As String, ByVal strOutputFile As String)
            Try
                fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
                fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
                fsOutput.SetLength(0)
                Dim bytBuffer(4096) As Byte
                Dim lngBytesProcessed As Long = 0
                Dim lngFileLength As Long = fsInput.Length
                Dim intBytesInCurrentBlock As Integer
                Dim csCryptoStream As CryptoStream
                Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
                Dim bytKey As Byte() = CreateKey(syspwd, syskey)
                Dim bytIV As Byte() = CreateIV(syspwd, syskey)
                csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
                While lngBytesProcessed < lngFileLength
                    intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                    lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                End While
                csCryptoStream.Close()
                fsInput.Close()
                fsOutput.Close()
                Dim fileOriginal As New FileInfo(strInputFile)
                fileOriginal.Delete()
            Catch When Err.Number = 53
                MsgBox("Please check to make sure the path and filename" + "are correct and if the file exists.", MsgBoxStyle.Exclamation, "Invalid Path or Filename")
            Catch
                fsInput.Close()
                fsOutput.Close()
                Dim fileDelete As New FileInfo(strOutputFile)
                fileDelete.Delete()
            End Try
        End Sub

        Shared Sub DecryptFile(ByVal strInputFile As String, ByVal strOutputFile As String)
            Try
                fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
                fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
                fsOutput.SetLength(0)
                Dim bytBuffer(4096) As Byte
                Dim lngBytesProcessed As Long = 0
                Dim lngFileLength As Long = fsInput.Length
                Dim intBytesInCurrentBlock As Integer
                Dim csCryptoStream As CryptoStream
                Dim bytKey As Byte() = CreateKey(syspwd, syskey)
                Dim bytIV As Byte() = CreateIV(syspwd, syskey)
                Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
                csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
                While lngBytesProcessed < lngFileLength
                    intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                    lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                End While
                csCryptoStream.Close()
                fsInput.Close()
                fsOutput.Close()
                Dim fileEncrypted As New FileInfo(strInputFile)
                fileEncrypted.Delete()
            Catch When Err.Number = 53
                MsgBox("Please check to make sure the path and filename" + "are correct and if the file exists.", MsgBoxStyle.Exclamation, "Invalid Path or Filename")
            Catch
                fsInput.Close()
                fsOutput.Close()
                Dim fileDelete As New FileInfo(strOutputFile)
                fileDelete.Delete()
                MsgBox("Please check to make sure that you entered the correct" + "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            End Try
        End Sub

    End Class
End Namespace

