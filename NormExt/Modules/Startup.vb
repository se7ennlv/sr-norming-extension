Imports NormExt.NormingExtension
Imports System.Text
Imports System.IO

Module Startup
    Public AppName As String = "Norming Extension"

    Public NormingDB As DataConnector
    Public ExtensionDB As DataConnector
    Public FingerDB As DataConnector
    Public MyMartDB As DataConnector

    Public CurrentSession As LoginSession
    Public MailSender As MailService
    Public approver, approverMail As String ' Entity Manager 1
    Sub ReadConfigFile()
        Dim reader As New IO.StreamReader(".\system.conf")
        Dim extServer As String = Cryptology.DecryptText(reader.ReadLine())
        Dim extDb As String = Cryptology.DecryptText(reader.ReadLine())
        Dim extLogin As String = Cryptology.DecryptText(reader.ReadLine())
        Dim extPwd As String = Cryptology.DecryptText(reader.ReadLine())

        Dim nmgServer As String = Cryptology.DecryptText(reader.ReadLine())
        Dim nmgDb As String = Cryptology.DecryptText(reader.ReadLine())
        Dim nmgLogin As String = Cryptology.DecryptText(reader.ReadLine())
        Dim nmgPwd As String = Cryptology.DecryptText(reader.ReadLine())

        Dim attServer As String = Cryptology.DecryptText(reader.ReadLine())
        Dim attDb As String = Cryptology.DecryptText(reader.ReadLine())
        Dim attLogin As String = Cryptology.DecryptText(reader.ReadLine())
        Dim attPwd As String = Cryptology.DecryptText(reader.ReadLine())

        Dim martServer As String = Cryptology.DecryptText(reader.ReadLine())
        Dim martDB As String = Cryptology.DecryptText(reader.ReadLine())
        Dim martLogin As String = Cryptology.DecryptText(reader.ReadLine())
        Dim martPwd As String = Cryptology.DecryptText(reader.ReadLine())

        reader.Close()

        NormingDB = New DataConnector(nmgServer, nmgDb, nmgLogin, nmgPwd)
        ExtensionDB = New DataConnector(extServer, extDb, extLogin, extPwd)
        FingerDB = New DataConnector(attServer, attDb, attLogin, attPwd)
        MyMartDB = New DataConnector(martServer, martDB, martLogin, martPwd)
    End Sub

    Function GetDate(ByVal DateString As String) As Date
        Dim dy As Integer = CInt(DateString.Substring(0, 2))
        Dim mt As Integer = CInt(DateString.Substring(2, 2))
        Dim yr As Integer = CInt(DateString.Substring(4, 4))
        Return DateSerial(yr, mt, dy)
    End Function
    Sub ShowForm(ByVal childForm As DevExpress.XtraEditors.XtraForm)
        childForm.MdiParent = FrmMaster
        childForm.Show()
    End Sub

    Sub GetLog(ByVal errTxt As String)
        File.AppendAllText(".\log\log.txt", String.Format("{0}{1}", Environment.NewLine, "---------------------------------------------------" & Environment.NewLine & Format(Now, "dd-MM-yyyy HH:mm:ss tt") & "" & Environment.NewLine & errTxt))
    End Sub

End Module
