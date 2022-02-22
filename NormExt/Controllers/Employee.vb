Public Class Employee
    Private _id As String
    Private _fname As String
    Private _lname As String
    Private _hireday As Date
    Private _lhireday As Date
    Private _jobTitle As String
    Private _shiftGroup As String
    Private _email As String
    Private _lvwf As String
    Private _orgId As Integer
    Private _deptCode As String
    Private _hodEmpId As String
    Private _supervisor1 As String
    Private _sup1Email As String = ""


    Sub New(ByVal empId As String)
        Try
            Dim emp As DataTable = NormingDB.SelectField("*", "HREMP", "HREMP_EMPID = '" + empId + "' ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

            If Not IsNothing(emp) Then
                _id = empId
                _fname = emp.Rows(0)("HREMP_FNAME").ToString.Trim
                _lname = emp.Rows(0)("HREMP_LNAME").ToString.Trim
                _hireday = emp.Rows(0)("HREMP_HIREDAY")
                _lhireday = emp.Rows(0)("HREMP_LHIREDAY")

                Dim jobId As String = emp.Rows(0)("HREMP_JOBID").ToString.Trim()

                _jobTitle = NormingDB.SelectField("HRJOB_JOBNAME", "HRJOB", "HRJOB_JOBID = '" + jobId + "' AND HRJOB_STATUS = 1", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                _shiftGroup = NormingDB.SelectField("ATSHIFTGRPE_GRPCODE", "ATSHIFTGRPE", "ATSHIFTGRPE_EMPID = '" + _id + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                _email = emp.Rows(0)("HREMP_EMAIL").ToString.Trim
                _lvwf = "LEAVE_" + NormingDB.SelectField("HREMPWF_LVWF", "HREMPWF", "HREMPWF_EMPID = '" & _id & "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                _deptCode = emp.Rows(0)("HREMP_DEPT").ToString.Trim
                _orgId = emp.Rows(0)("HREMP_ORG").ToString.Trim
                _hodEmpId = NormingDB.SelectField("ASORG_MANAGER", "ASORG", "ASORG_ORGID = " + _orgId.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                _supervisor1 = NormingDB.SelectField("HREMP_SUVISOR1", "HREMP", "HREMP_EMPID = '" + _id + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
                _sup1Email = NormingDB.SelectField("HREMP_EMAIL", "HREMP", "HREMP_EMPID = '" + _hodEmpId + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
            Else
                _id = ""
                _fname = ""
                _lname = ""
                _hireday = New Date()
                _lhireday = New Date()
                _jobTitle = ""
                _shiftGroup = ""
                _email = ""
                _lvwf = ""
                _orgId = 0
                _deptCode = ""
                _hodEmpId = ""
                _supervisor1 = ""
                _sup1Email = ""
            End If
        Catch ex As Exception
            MsgBox("Something went wrong, please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)

        End Try
    End Sub

    ReadOnly Property HODEmployeeID As String
        Get
            Return _hodEmpId
        End Get
    End Property

    ReadOnly Property SupervisorEmail As String
        Get
            Return _sup1Email
        End Get
    End Property
    ReadOnly Property OrganizationID As Integer
        Get
            Return _orgId
        End Get
    End Property
    ReadOnly Property OrganizationCode As String
        Get
            Return _deptCode
        End Get
    End Property

    ReadOnly Property ID As String
        Get
            Return _id
        End Get
    End Property
    ReadOnly Property FirstName As String
        Get
            Return _fname
        End Get
    End Property

    ReadOnly Property LastName As String
        Get
            Return _lname
        End Get
    End Property
    ReadOnly Property HireDate As Date
        Get
            Return _hireday
        End Get
    End Property
    ReadOnly Property LastHireDate As Date
        Get
            Return _lhireday
        End Get
    End Property
    ReadOnly Property JobTitle As String
        Get
            Return _jobTitle
        End Get
    End Property
    ReadOnly Property ShiftGroup As String
        Get
            Return _shiftGroup
        End Get
    End Property
    ReadOnly Property EmailAddress As String
        Get
            Return _email
        End Get
    End Property

    ReadOnly Property LeavWorkFlow As String
        Get
            Return _lvwf
        End Get
    End Property

    Function LeaveAvailableDay(ByVal LeaveCode As String) As Double
        Try
            Dim i As Double = NormingDB.SelectField("sum(LVEMPLEAVE_LEAVEDAYS)", "LVEMPLEAVE", "LVEMPLEAVE_EMPID=" + _id + " AND LVEMPLEAVE_LEAVECODE='" + LeaveCode + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
            Return i
        Catch ex As Exception
            Return 0
        End Try

    End Function

End Class
