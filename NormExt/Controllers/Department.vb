Public Class Department
    Private _orgId As String
    Private _id As String
    Private _name As String
    Private _shiftgroups As List(Of ShiftGroup)
    Private _hodid1 As String
    Private _hodid2 As String
    Sub New()
        _orgId = ""
        _id = ""
        _name = ""
        _shiftgroups = New List(Of ShiftGroup)
        _hodid1 = ""
        _hodid2 = ""
    End Sub
    Sub New(ByVal ID As String)
        Dim tbl As DataTable = ExtensionDB.SelectField("*", "tbl_departments", "DeptID = '" + ID + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)

        If Not IsNothing(tbl) And tbl.Rows.Count > 0 Then
            _orgId = tbl.Rows(0).Item("OrgID").ToString.Trim()
            _id = tbl.Rows(0).Item("DeptID").ToString.Trim()
            _name = tbl.Rows(0).Item("DeptName").ToString.Trim()
            _hodid1 = ""
            _hodid2 = ""

            Try
                _hodid1 = tbl.Rows(0).Item("HodID1").ToString.Trim()
                _hodid2 = tbl.Rows(0).Item("HodID2").ToString.Trim()
            Catch ex As Exception

            End Try

            Dim tblgrp As DataTable = ExtensionDB.SelectField("GroupCode", "tbl_deptshiftgrp", "DeptID='" + ID + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)

            Dim grp As ShiftGroup

            If tblgrp.Rows.Count > 0 Then
                grp = New ShiftGroup(tblgrp.Rows(0)("GroupCode").ToString.Trim)
                _shiftgroups = New List(Of ShiftGroup)
                _shiftgroups.Add(grp)
            End If

        Else
            _orgId = ""
            _id = ""
            _name = ""
            _shiftgroups = New List(Of ShiftGroup)
            _hodid1 = ""
            _hodid2 = ""
        End If
    End Sub
    Property OrgId As String
        Set(value As String)
            _orgId = value
        End Set
        Get
            Return _orgId
        End Get
    End Property
    Property ID As String
        Set(value As String)
            _id = value
        End Set
        Get
            Return _id
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
    ReadOnly Property ShiftGroups As List(Of ShiftGroup)
        Get
            Return _shiftgroups
        End Get
    End Property
    ReadOnly Property HodEmpID1 As String
        Get
            Return _hodid1
        End Get
    End Property
    ReadOnly Property HodEmpID2 As String
        Get
            Return _hodid2
        End Get
    End Property

End Class
