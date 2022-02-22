
Public Class Leave
    Private _code As String
    Private _desc As String
    Private _paycode As String
    'Private _bankOT As Boolean
    'Private _optional As Boolean
    Private _maxavailday As Double
    'Private _level As Integer
    'Private _includeWD As Boolean
    'Private _allowtype As Integer '0 = All Day, 1 = Available Day
    Private _minhours As Double
    'Private _restrictrequest As Boolean
    'Private _reqleaveschedule As Boolean
    'Private _resettype As Integer '0=No Reset, 1=Weekly, 2=Monthly, 3=Quaterly, 4=Yearly
    Private _note As String
    Sub New(ByVal LeaveCode As String)
        Dim tbllv As DataTable = NormingDB.SelectField("*", "LVLEAVE", "LVLEAVE_LEAVECODE = '" + LeaveCode + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        If tbllv.Rows.Count > 0 Then
            _code = LeaveCode
            _desc = tbllv.Rows(0)("LVLEAVE_LEAVEDESC").ToString.Trim()
            _paycode = tbllv.Rows(0)("LVLEAVE_EARNCODE").ToString.Trim
            _maxavailday = tbllv.Rows(0)("LVLEAVE_MAXDAYS")
            _minhours = tbllv.Rows(0)("LVLEAVE_MINILVHOURS")
            _note = tbllv.Rows(0)("LVLEAVE_NOTE").ToString.Trim
        Else
            _code = ""
            _desc = ""
            _paycode = ""
            _maxavailday = 0
            _minhours = 0
            _note = ""
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

    ReadOnly Property Note As String
        Get
            Return _note
        End Get
    End Property
    ReadOnly Property PayCode As String
        Get
            Return _paycode
        End Get
    End Property
    ReadOnly Property MaximumDays As Double
        Get
            Return _maxavailday
        End Get
    End Property
    ReadOnly Property MinimumLeaveHours As Double
        Get
            Return _minhours
        End Get
    End Property

    Function LeaveAvailableDay(ByVal empId As String) As Double
        Try
            Dim i As Double = NormingDB.SelectField("SUM(lv.LVEMPLEAVE_LEAVEDAYS)", "LVEMPLEAVE lv INNER JOIN HREMP emp ON lv.LVEMPLEAVE_EMPID = emp.HREMP_EMPID", "emp.HREMP_EMPCODE = '" + empId + "' AND LVEMPLEAVE_LEAVECODE = '" + _code + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
            Return i
        Catch ex As Exception
            Return 0
        End Try

    End Function

End Class
