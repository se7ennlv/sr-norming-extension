
Imports NormExt.NormingExtension
Public Class LoginSession
    Private _connected As Boolean
    Private _user As User

    Sub New()
        _connected = False
        _user = New User()

    End Sub

    Sub Open(ByVal UserID As String, ByVal Password As String)
        Try
            Dim tbl As DataTable = ExtensionDB.SelectField("*", "tbl_users", "UserID='" + UserID + "' AND UserPwd = '" + Cryptology.EncryptText(Password) + "' AND IsActive = 1 ", DataConnector.SelectedReturnType.DataTable)
            If Not IsNothing(tbl) Then
                _connected = True
                _user = New User(tbl.Rows(0)("UserID").ToString.Trim)
            End If
        Catch ex As Exception
            _connected = False
        End Try
    End Sub

    ReadOnly Property Connected As Boolean
        Get
            Return _connected
        End Get
    End Property
    ReadOnly Property User As User
        Get
            Return _user
        End Get
    End Property

End Class
