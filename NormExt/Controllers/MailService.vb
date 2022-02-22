Imports System.Net.Mail
Imports NormExt.NormingExtension
Public Class MailService

    Dim mailclient As SmtpClient
    Dim email As MailMessage
    Sub New()
        mailclient = New SmtpClient
        mailclient.UseDefaultCredentials = False
        mailclient.Credentials = New Net.NetworkCredential(ConfigurationInfo.SmtpLogin, ConfigurationInfo.SmtpPassword)
        mailclient.Port = ConfigurationInfo.SmtpPort
        mailclient.EnableSsl = False
        mailclient.Host = ConfigurationInfo.SmtpServer
    End Sub

    Sub SendMail(ByVal Subject As String, ByVal ToEmail As String, ByVal EmailBody As String)
        email = New MailMessage
        email.From = New MailAddress("normingadmin@savanresorts.com", "Norming Administrator")
        'email.To.Add(ToEmail)
        If ToEmail.Length > 0 Then
            If ToEmail.Contains(";") = True Then
                Dim strMail() As String

                strMail = ToEmail.Split(";")

                If strMail(0).Length > 0 Then
                    email.To.Add(New MailAddress(strMail(0)))
                Else
                    'email.To.Add(New MailAddress("it.help@savanvegas.com"))
                End If

                Dim i As Integer

                For i = 1 To strMail.Length - 1
                    If strMail(i).Length > 0 Then
                        email.CC.Add(New MailAddress(strMail(i)))
                    End If
                Next
            Else
                email.To.Add(New MailAddress(ToEmail))
            End If
        Else
            email.To.Add(New MailAddress("sev.nin@savanresorts.com"))
        End If

        email.Subject = Subject
        email.IsBodyHtml = True
        email.Body = EmailBody
        mailclient.Send(email)
    End Sub

  
End Class