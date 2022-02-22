Namespace NormingExtension
    Friend Class ConfigurationInfo
        Shared ReadOnly Property SmtpServer As String
            Get
                Return ExtensionDB.SelectField("smtpserver", "tbl_config", "checksum='A'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
            End Get
        End Property
        Shared ReadOnly Property SmtpPort As Integer
            Get
                Try
                    Return ExtensionDB.SelectField("smtpport", "tbl_config", "checksum='A'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
                Catch ex As Exception
                    Return 0
                End Try

            End Get
        End Property

        Shared ReadOnly Property SmtpLogin As String
            Get
                Try
                    Return ExtensionDB.SelectField("smtplogin", "tbl_config", "checksum='A'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
        Shared ReadOnly Property SmtpPassword As String
            Get
                Try
                    Return ExtensionDB.SelectField("smtppwd", "tbl_config", "checksum='A'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property

        Shared ReadOnly Property RosterEditAllowDay As Integer
            Get
                Try
                    Return ExtensionDB.SelectField("editallowday", "tbl_config", "checksum='A'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property

        Shared ReadOnly Property RosterImportAllowDay As Integer
            Get
                Try
                    Return ExtensionDB.SelectField("importallowday", "tbl_config", "checksum='A'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
                Catch ex As Exception
                    Return 0
                End Try
            End Get
        End Property

    End Class
End Namespace

