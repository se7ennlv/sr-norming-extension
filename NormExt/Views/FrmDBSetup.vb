Imports NormExt.NormingExtension
Public Class frmDBSetup

    Private Sub frmDBSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IO.File.Exists(".\system.conf") Then
                Dim reader As New IO.StreamReader(".\system.conf")

                txtExtServer.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtExtDb.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtExtLogin.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtExtPwd.EditValue = Cryptology.DecryptText(reader.ReadLine())

                txtNmgServer.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtNmgDb.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtNmgLogin.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtNmgPwd.EditValue = Cryptology.DecryptText(reader.ReadLine())

                txtAttdServer.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtAttdDb.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtAttdLogin.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtAttdPwd.EditValue = Cryptology.DecryptText(reader.ReadLine())

                txtMartServer.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtMartDB.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtMartLogin.EditValue = Cryptology.DecryptText(reader.ReadLine())
                txtMartPwd.EditValue = Cryptology.DecryptText(reader.ReadLine())

                reader.Close()
            End If
        Catch ex As Exception
            txtExtServer.EditValue = ""
            txtExtDb.EditValue = ""
            txtExtLogin.EditValue = ""
            txtExtPwd.EditValue = ""

            txtNmgServer.EditValue = ""
            txtNmgDb.EditValue = ""
            txtNmgLogin.EditValue = ""
            txtNmgPwd.EditValue = ""

            txtAttdServer.EditValue = ""
            txtAttdDb.EditValue = ""
            txtAttdLogin.EditValue = ""
            txtAttdPwd.EditValue = ""

            txtMartServer.EditValue = ""
            txtMartDB.EditValue = ""
            txtMartLogin.EditValue = ""
            txtMartPwd.EditValue = ""

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim writer As New IO.StreamWriter(".\system.conf", False)
            writer.WriteLine(Cryptology.EncryptText(txtExtServer.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtExtDb.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtExtLogin.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtExtPwd.EditValue.ToString.Trim))

            writer.WriteLine(Cryptology.EncryptText(txtNmgServer.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtNmgDb.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtNmgLogin.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtNmgPwd.EditValue.ToString.Trim))

            writer.WriteLine(Cryptology.EncryptText(txtAttdServer.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtAttdDb.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtAttdLogin.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtAttdPwd.EditValue.ToString.Trim))

            writer.WriteLine(Cryptology.EncryptText(txtMartServer.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtMartDB.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtMartLogin.EditValue.ToString.Trim))
            writer.WriteLine(Cryptology.EncryptText(txtMartPwd.EditValue.ToString.Trim))

            writer.Close()
            MsgBox("Database Connection has been made.", MsgBoxStyle.Information, AppName)
            ReadConfigFile()
            Me.Close()
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
        
    End Sub
End Class