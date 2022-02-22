Imports NormExt.NormingExtension
Public Class frmConfig

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ExtensionDB.InitUpdateCommand("tbl_config")
            ExtensionDB.SetWhereField("checksum", "A")
            ExtensionDB.SetUpdateField("smtpserver", txtSmtpServer.EditValue.ToString.Trim)
            ExtensionDB.SetUpdateField("smtpport", txtSmtpPort.EditValue)
            ExtensionDB.SetUpdateField("smtplogin", txtSmtpLogin.EditValue.ToString.Trim)
            ExtensionDB.SetUpdateField("smtppwd", txtSmtpPwd.EditValue.ToString.Trim)
            ExtensionDB.SetUpdateField("editallowday", txtEditAllowDay.EditValue.ToString.Trim)
            ExtensionDB.SetUpdateField("importallowday", txtImportAllowDay.EditValue.ToString.Trim)
            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("Configuration has been updated.", MsgBoxStyle.Information, AppName)
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
        
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSmtpServer.EditValue = ConfigurationInfo.SmtpServer
        txtSmtpPort.EditValue = ConfigurationInfo.SmtpPort
        txtSmtpLogin.EditValue = ConfigurationInfo.SmtpLogin
        txtSmtpPwd.EditValue = ConfigurationInfo.SmtpPassword
        txtEditAllowDay.EditValue = ConfigurationInfo.RosterEditAllowDay
        txtImportAllowDay.EditValue = ConfigurationInfo.RosterImportAllowDay
    End Sub
End Class