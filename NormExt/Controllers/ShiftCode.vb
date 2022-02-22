Public Class ShiftCode
    Private _code As String
    Private _desc As String
    Private _fromhour As String
    Private _tohour As String
    Private _breakftime As String
    Private _breakttime As String
    Private _workhours As Double
    Private _crossday As Boolean

    Sub New(ByVal ShiftCode As String)
        Dim tblshif As DataTable = NormingDB.SelectField("*", "ASSHIFT", "ASSHIFT_SHIFTCODE='" + ShiftCode + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        If Not IsNothing(tblshif) Then
            _code = tblshif.Rows(0)("ASSHIFT_SHIFTCODE").ToString.Trim
            _desc = tblshif.Rows(0)("ASSHIFT_SHIFTDESC").ToString.Trim
            _fromhour = tblshif.Rows(0)("ASSHIFT_FROMHOUR").ToString.Trim
            _tohour = tblshif.Rows(0)("ASSHIFT_TOHOUR").ToString.Trim
            _breakftime = tblshif.Rows(0)("ASSHIFT_BREAKTIMEF").ToString.Trim
            _breakttime = tblshif.Rows(0)("ASSHIFT_BREAKTIMET").ToString.Trim
            _workhours = tblshif.Rows(0)("ASSHIFT_WORKHOURS")
            _crossday = CBool(tblshif.Rows(0)("ASSHIFT_CROSSDAY"))
        Else
            _code = ""
            _desc = ""
            _fromhour = ""
            _tohour = ""
            _breakftime = ""
            _breakttime = ""
            _workhours = 0
            _crossday = False
        End If


    End Sub

    ReadOnly Property Code As String
        Get
            Return _code
        End Get
    End Property
    ReadOnly Property Description As String
        Get
            Return _desc
        End Get
    End Property
    ReadOnly Property FromHour As String
        Get
            Return _fromhour
        End Get
    End Property
    ReadOnly Property ToHour As String
        Get
            Return _tohour
        End Get
    End Property
    ReadOnly Property BreakFromTime As String
        Get
            Return _breakftime
        End Get
    End Property
    ReadOnly Property BreakToTime As String
        Get
            Return _breakttime
        End Get
    End Property
    ReadOnly Property WorkHours As Double
        Get
            Return _workhours
        End Get
    End Property
    ReadOnly Property CrossDay As Boolean
        Get
            Return _crossday
        End Get
    End Property

End Class
