Public Class Attendace
    Private _workday As String
    Private _empid As String
    Private _shiftcode As String
    Private _shiftstart As String
    Private _shiftend As String
    Private _ischeckin As Boolean
    Private _checkintime As String
    Private _ischeckout As Boolean
    Private _checkouttime As String
    Private _checkinrv As Boolean
    Private _rvcheckintime As String
    Private _checkinrvby As String
    Private _checkoutrv As Boolean
    Private _rvcheckouttime As String
    Private _checkoutrvby As String
    Private _checkinapprovestatus As Integer
    Private _checkoutapprovestatus As Integer

    Sub New()
        _workday = ""
        _empid = ""
        _shiftcode = ""
        _shiftstart = ""
        _shiftend = ""
        _ischeckin = False
        _checkintime = ""
        _ischeckout = False
        _checkouttime = ""
        _checkinrv = False
        _rvcheckintime = ""
        _checkinrvby = ""
        _checkoutrv = False
        _rvcheckouttime = ""
        _checkoutrvby = ""
        _checkinapprovestatus = 0
        _checkoutapprovestatus = 0
    End Sub

    Sub New(ByVal ID As String)
        Dim tbl As DataTable = ExtensionDB.SelectField("*", "tbl_attendace", "EmpID='" + ID + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)

        If Not IsNothing(tbl) And tbl.Rows.Count > 0 Then
            _workday = tbl.Rows(0).Item("WorkDay").ToString.Trim
            _empid = tbl.Rows(0).Item("EmpID").ToString.Trim
            _shiftcode = tbl.Rows(0).Item("ShiftCode").ToString.Trim
            _shiftstart = tbl.Rows(0).Item("ShiftStrat").ToString.Trim
            _shiftend = tbl.Rows(0).Item("ShiftEnd").ToString.Trim
            _ischeckin = tbl.Rows(0).Item("IsCheckIn").ToString.Trim
            _checkintime = tbl.Rows(0).Item("CheckInTime").ToString.Trim
            _ischeckout = tbl.Rows(0).Item("IsCheckOut").ToString.Trim
            _checkouttime = tbl.Rows(0).Item("CheckOutTime").ToString.Trim
            _checkinrv = tbl.Rows(0).Item("CheckInRevised").ToString.Trim
            _rvcheckintime = tbl.Rows(0).Item("RvCheckInTime").ToString.Trim
            _checkinrvby = tbl.Rows(0).Item("CheckInRvBy").ToString.Trim
            _checkoutrv = tbl.Rows(0).Item("CheckOutRv").ToString.Trim
            _rvcheckouttime = tbl.Rows(0).Item("RvCheckOutTime").ToString.Trim
            _checkoutrvby = tbl.Rows(0).Item("CheckOutRvBy").ToString.Trim
            _checkinapprovestatus = tbl.Rows(0).Item("CheckInApproveStatus")
            _checkoutapprovestatus = tbl.Rows(0).Item("CheckOutApproveStatus")
        Else
            _workday = ""
            _empid = ""
            _shiftcode = ""
            _shiftstart = ""
            _shiftend = ""
            _ischeckin = False
            _checkintime = ""
            _ischeckout = False
            _checkouttime = ""
            _checkinrv = False
            _rvcheckintime = ""
            _checkinrvby = ""
            _checkoutrv = False
            _rvcheckouttime = ""
            _checkoutrvby = ""
            _checkinapprovestatus = 0
            _checkoutapprovestatus = 0
        End If
    End Sub

    Property WorkDay As String
        Set(value As String)
            _workday = value
        End Set
        Get
            Return _workday
        End Get
    End Property
    Property EmpID As String
        Set(value As String)
            _empid = value
        End Set
        Get
            Return _empid
        End Get
    End Property
    Property ShiftCode As String
        Set(value As String)
            _shiftcode = value
        End Set
        Get
            Return _shiftcode
        End Get
    End Property

    Property ShiftStart As String
        Set(value As String)
            _shiftstart = value
        End Set
        Get
            Return _shiftstart
        End Get
    End Property
    Property ShiftEnd As String
        Set(value As String)
            _shiftend = value
        End Set
        Get
            Return _shiftend
        End Get
    End Property
    Property IsCheckIn As Boolean
        Set(value As Boolean)
            _ischeckin = False
        End Set
        Get
            Return _ischeckin
        End Get
    End Property
    Property CheckInTime As String
        Set(value As String)
            _checkintime = value
        End Set
        Get
            Return _checkintime
        End Get
    End Property
    Property IsCheckOut As Boolean
        Set(value As Boolean)
            _ischeckout = False
        End Set
        Get
            Return _ischeckout
        End Get
    End Property
    Property CheckOutTime As String
        Set(value As String)
            _checkouttime = value
        End Set
        Get
            Return _checkouttime
        End Get
    End Property
    Property CheckInRv As Boolean
        Set(value As Boolean)
            _checkinrv = False
        End Set
        Get
            Return _checkinrv
        End Get
    End Property
    Property RvCheckInTime As String
        Set(value As String)
            _rvcheckintime = value
        End Set
        Get
            Return _rvcheckintime
        End Get
    End Property
    Property CheckInRvBy As String
        Set(value As String)
            _checkinrvby = value
        End Set
        Get

        End Get
    End Property

End Class
