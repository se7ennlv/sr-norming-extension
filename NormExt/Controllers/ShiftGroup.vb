Public Class ShiftGroup
    Private _code As String
    Private _name As String

    Sub New(ByVal GroupCode As String)
        _code = GroupCode
        _name = NormingDB.SelectField("ATSHIFTGRP_DESC", "ATSHIFTGRP", "ATSHIFTGRP_CODE='" + GroupCode + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
    End Sub
    ReadOnly Property Code As String
        Get
            Return _code
        End Get
    End Property

    ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

End Class
