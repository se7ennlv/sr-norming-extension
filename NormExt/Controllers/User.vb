Imports NormExt.NormingExtension
Public Class User
    Private _id As String
    Private _empId As String
    Private _name As String
    Private _password As String
    Private _phone As String
    Private _email As String
    Private _dep As Department
    Private _deptUnder As String
    Private _roleId As Integer
    Private _rosterprevil As Integer
    Private _leaveprevil As Integer
    Private _attdprevil As Integer
    Private _attdHodApprPrevil As Integer
    Private _attdHrAttdApprPrevil As Integer
    Private _attdHrDirectApprPrevil As Integer
    Private _attdAdminReport As Integer
    Private _attdPayroll As Integer
    Private _rosteraccess As Integer
    Private _leaveaccess As Integer
    Private _attdaccess As Integer
    Private _anytime As Boolean
    Sub New()
        _id = ""
        _empId = ""
        _name = ""
        _password = ""
        _phone = ""
        _email = ""
        _dep = New Department
        _deptUnder = ""
        _roleId = 0
        _rosterprevil = 0
        _leaveprevil = 0
        _attdprevil = 0
        _attdHodApprPrevil = 0
        _attdHrAttdApprPrevil = 0
        _attdHrDirectApprPrevil = 0
        _attdAdminReport = 0
        _attdPayroll = 0
        _rosteraccess = 0
        _leaveaccess = 0
        _attdaccess = 0
        _anytime = False
    End Sub

    Sub New(ByVal UserID As String)
        Dim sqlWhere = "UserID = '" + UserID + "'"
        Dim tbl As DataTable = ExtensionDB.SelectField("*", "tbl_users", sqlWhere, DataConnector.SelectedReturnType.DataTable)

        If Not IsNothing(tbl) And tbl.Rows.Count > 0 Then
            _id = tbl.Rows(0)("UserID").ToString.Trim
            _empId = tbl.Rows(0)("EmpID").ToString.Trim
            _name = tbl.Rows(0)("Username").ToString.Trim
            _password = tbl.Rows(0)("UserPwd").ToString.Trim
            _email = tbl.Rows(0)("UserEmail").ToString.Trim
            _phone = tbl.Rows(0)("UserPhone").ToString.Trim
            _dep = New Department(tbl.Rows(0)("UserDept").ToString.Trim)
            _deptUnder = tbl.Rows(0)("DeptUnder").ToString.Trim
            _roleId = tbl.Rows(0)("RoleID")
            _rosterprevil = tbl.Rows(0)("PrvRoster")
            _leaveprevil = tbl.Rows(0)("PrvLeave")
            _attdprevil = tbl.Rows(0)("PrvAttd")
            _attdHodApprPrevil = tbl.Rows(0)("PrvHodAppr")
            _attdHrAttdApprPrevil = tbl.Rows(0)("PrvHrAttdAppr")
            _attdHrDirectApprPrevil = tbl.Rows(0)("PrvHrDirectAppr")
            _attdAdminReport = tbl.Rows(0)("PrvAdminReport")
            _attdPayroll = tbl.Rows(0)("PrvPayroll")
            _rosteraccess = tbl.Rows(0)("RosterAccess")
            _leaveaccess = tbl.Rows(0)("LeaveAccess")
            _attdaccess = tbl.Rows(0)("AttdAccess")
            _anytime = tbl.Rows(0)("AccessAnyTime")
        Else
            _id = ""
            _empId = ""
            _name = ""
            _password = ""
            _phone = ""
            _email = ""
            _dep = New Department
            _deptUnder = ""
            _roleId = 0
            _rosterprevil = 0
            _leaveprevil = 0
            _attdprevil = 0
            _attdHodApprPrevil = 0
            _attdHrAttdApprPrevil = 0
            _attdHrDirectApprPrevil = 0
            _attdAdminReport = 0
            _attdPayroll = 0
            _rosteraccess = 0
            _leaveaccess = 0
            _attdaccess = 0
            _anytime = False
        End If
    End Sub
    Sub ChangePassword(ByVal OldPassword As String, ByVal NewPasswrod As String)
        ExtensionDB.InitUpdateCommand("tbl_users")
        ExtensionDB.SetWhereField("UserID", _id)
        ExtensionDB.SetUpdateField("UserPwd", Cryptology.EncryptText(NewPasswrod))
        ExtensionDB.ExecuteUpdateCommand()
        MsgBox("Password is has been changed.", MsgBoxStyle.Information, AppName)
    End Sub
    Property ID As String
        Set(value As String)
            _id = value
        End Set
        Get
            Return _id
        End Get
    End Property

    Property EmpID As String
        Set(value As String)
            _empId = value
        End Set
        Get
            Return _empId
        End Get
    End Property
    Property Name As String
        Set(value As String)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property
    Property Password As String
        Set(value As String)
            _password = value
        End Set
        Get
            Return _password
        End Get
    End Property
    Property PhoneNumber As String
        Set(value As String)
            _phone = value
        End Set
        Get
            Return _phone
        End Get
    End Property

    Property EmailAddress As String
        Set(value As String)
            _email = value
        End Set
        Get
            Return _email
        End Get
    End Property

    Property WorkingDepartment As Department
        Set(value As Department)
            _dep = value
        End Set
        Get
            Return _dep
        End Get
    End Property

    Property DeptUnder As String
        Set(value As String)
            _deptUnder = value
        End Set
        Get
            Return _deptUnder
        End Get
    End Property

    Property RoleID As Integer
        Set(value As Integer)
            _roleId = value
        End Set
        Get
            Return _roleId
        End Get
    End Property

    Property RosterAccessLevel As Integer
        Set(value As Integer)
            _rosterprevil = value
        End Set
        Get
            Return _rosterprevil
        End Get
    End Property

    Property LeaveAccessLevel As Integer
        Set(value As Integer)
            _leaveprevil = value
        End Set
        Get
            Return _leaveprevil
        End Get
    End Property

    Property tbl_attendanceAccessLevel As Integer
        Set(value As Integer)
            _attdprevil = value
        End Set
        Get
            Return _attdprevil
        End Get
    End Property

    Property RosterAccess As Integer
        Set(value As Integer)
            _rosteraccess = value
        End Set
        Get
            Return _rosteraccess
        End Get
    End Property

    Property LeaveAccess As Integer
        Set(value As Integer)
            _leaveaccess = value
        End Set
        Get
            Return _leaveaccess
        End Get
    End Property

    Property AttendaceAccess As Integer
        Set(value As Integer)
            _attdaccess = value
        End Set
        Get
            Return _attdaccess
        End Get
    End Property
    Property HodApprLevel As Integer
        Set(value As Integer)
            _attdHodApprPrevil = value
        End Set
        Get
            Return _attdHodApprPrevil
        End Get
    End Property
    Property HrAttdApprLevel As Integer
        Set(value As Integer)
            _attdHrAttdApprPrevil = value
        End Set
        Get
            Return _attdHrAttdApprPrevil
        End Get
    End Property
    Property HrDirectApprLevel As Integer
        Set(value As Integer)
            _attdHrDirectApprPrevil = value
        End Set
        Get
            Return _attdHrDirectApprPrevil
        End Get
    End Property
    Property AccessAdminReport As Integer
        Set(value As Integer)
            _attdAdminReport = value
        End Set
        Get
            Return _attdAdminReport
        End Get
    End Property
    Property AccessPayroll As Integer
        Set(value As Integer)
            _attdPayroll = value
        End Set
        Get
            Return _attdPayroll
        End Get
    End Property

    Property AccessAnyTime As Boolean
        Set(value As Boolean)
            _anytime = value
        End Set
        Get
            Return _anytime
        End Get
    End Property

End Class
