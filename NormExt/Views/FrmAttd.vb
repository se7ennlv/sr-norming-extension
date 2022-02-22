Imports System.ComponentModel
Imports NormExt.NormingExtension
Public Class frmAttd
    Dim tblAttd As DataTable
    Dim tblPeriod As DataTable

    Public Sub refreshData()
        Call frmAttd_Load(Nothing, Nothing)
    End Sub


    Private Sub frmAttd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            bgWorker = New BackgroundWorker

            radOption.SelectedIndex = 0
            dtTo.Properties.MaxValue = Date.Now

            Dim tbl As New DataTable


            '--If CurrentSession.User.ID = "admin" Or CurrentSession.User.AttendaceAccess = 1 Then
            If CurrentSession.User.ID = "admin" Or CurrentSession.User.AccessAnyTime = True Then
                tbl = CType(ExtensionDB.SelectField("RTRIM(shtGrp.GroupCode) AS [GroupCode], RTRIM(dept.DeptName) AS [DeptName]", "tbl_departments dept INNER JOIN tbl_deptshiftgrp shtGrp ON dept.DeptID = shtGrp.DeptID", "", DataConnector.SelectedReturnType.DataTable), DataTable)
                lstDept.Properties.DataSource = tbl
                lstDept.EditValue = tbl.Rows(0)("GroupCode").ToString.Trim
            ElseIf CurrentSession.User.WorkingDepartment.ID = "ADMIN" Then
                tbl = CType(ExtensionDB.SelectField("RTRIM(shtGrp.GroupCode) AS [GroupCode], RTRIM(dept.DeptName) AS [DeptName]", "tbl_departments dept INNER JOIN tbl_deptshiftgrp shtGrp ON dept.DeptID = shtGrp.DeptID", "GroupCode IN ('ADMIN', 'FO')", DataConnector.SelectedReturnType.DataTable), DataTable)
                lstDept.Properties.DataSource = tbl
                lstDept.EditValue = tbl.Rows(0)("GroupCode").ToString.Trim
            Else
                tbl = CType(ExtensionDB.SelectField("RTRIM(shtGrp.GroupCode) AS [GroupCode], RTRIM(dept.DeptName) AS [DeptName]", "tbl_departments dept INNER JOIN tbl_deptshiftgrp shtGrp ON dept.DeptID = shtGrp.DeptID", "dept.DeptID = '" + CurrentSession.User.WorkingDepartment.ID + "'", DataConnector.SelectedReturnType.DataTable), DataTable)
                lstDept.Properties.DataSource = tbl
                lstDept.EditValue = tbl.Rows(0)("GroupCode").ToString.Trim
            End If

            tblPeriod = New DataTable
            tblPeriod = CType(NormingDB.SelectField("CONVERT(DATE, PRSCHED_PDATESTART) AS [FromDate], CONVERT(DATE, DATEADD(D, -1, GETDATE())) AS [ToDate] ", "PRSCHED", "PRSCHED_SCHEDYEAR = YEAR(GETDATE()) AND MONTH(PRSCHED_PDATESTART) = MONTH(DATEADD(M, -1, GETDATE()))", DataConnector.SelectedReturnType.DataTable), DataTable)

            dtFrom.EditValue = CDate(tblPeriod(0)("FromDate"))
            dtTo.EditValue = CDate(tblPeriod(0)("ToDate"))

            Call btnShowData_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub btnShowData_Click(sender As Object, e As EventArgs) Handles btnShowData.Click
        bgWorker = New BackgroundWorker

        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Try
            Dim i As Integer = gvAttd.FocusedRowHandle
            Dim empId As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("EmpID")).ToString.Trim
            Dim empCode As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("EmpCode")).ToString.Trim
            Dim empName As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("EmpName")).ToString.Trim
            Dim shfCode As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("ShiftCode")).ToString.Trim
            Dim WorkDay As Date = CDate(gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("WorkDay")))
            Dim IsCheckIn As Boolean = CBool(gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("IsCheckIn")))
            Dim IsCheckOut As Boolean = CBool(gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("IsCheckOut")))

            Dim shift As New ShiftCode(shfCode)
            Dim frm As New frmErr

            frm.empId = empId.ToString.Trim
            frm.txtEmpCode.EditValue = empCode
            frm.txtEmpName.EditValue = empName
            frm.txtShiftCode.EditValue = shfCode
            frm.txtShiftName.EditValue = shift.Description
            frm.dtWorkDay.EditValue = WorkDay
            frm.dtCheckIn.EditValue = WorkDay

            If shfCode.StartsWith("C16") Or shfCode.StartsWith("C17") Or shfCode.StartsWith("C18") Or shfCode.StartsWith("C19") Or shfCode.StartsWith("C20") Or shfCode.StartsWith("C21") Or shfCode.StartsWith("C22") Or shfCode.StartsWith("C23") Then
                frm.dtCheckOut.EditValue = DateAdd(DateInterval.Day, 1, WorkDay)
            Else
                frm.dtCheckOut.EditValue = WorkDay
            End If

            Dim tblShift As DataTable = CType(NormingDB.SelectField("rtrim(ASSHIFT_SHIFTCODE) as ASSHIFT_SHIFTCODE,ASSHIFT_SHIFTDESC", "ASSHIFT", "", DataConnector.SelectedReturnType.DataTable), DataTable)

            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Function ShiftStartTime(ByVal ShiftCode As String, ByVal Workdate As Date) As DateTime
        Dim valdate As DateTime

        Dim tblshift As DataTable = CType(NormingDB.SelectField("*", "ASSHIFT", "ASSHIFT_SHIFTCODE='" + ShiftCode + "'", DataConnector.SelectedReturnType.DataTable), DataTable)
        valdate = CDate(Format(Workdate, "yyyy-MM-dd") + " " + tblshift.Rows(0)("ASSHIFT_FROMHOUR").ToString.Trim() + ":00.000")

        Return valdate
    End Function

    Function ShiftEndTime(ByVal ShiftCode As String, ByVal Workdate As Date) As DateTime
        Dim valdate As DateTime

        Dim tblshift As DataTable = CType(NormingDB.SelectField("*", "ASSHIFT", "ASSHIFT_SHIFTCODE='" + ShiftCode + "'", DataConnector.SelectedReturnType.DataTable), DataTable)
        Dim newWorkdate As Date

        If tblshift.Rows(0)("ASSHIFT_CROSSDAY") = 0 Then
            newWorkdate = Workdate
        Else
            newWorkdate = DateAdd(DateInterval.Day, 1, Workdate)
        End If

        valdate = CDate(Format(newWorkdate, "yyyy-MM-dd") + " " + tblshift.Rows(0)("ASSHIFT_TOHOUR").ToString.Trim() + ":00.000")


        Return valdate
    End Function
    Private Sub gvAttd_DoubleClick(sender As Object, e As EventArgs) Handles gvAttd.DoubleClick
        Dim i As Integer = gvAttd.FocusedRowHandle
        Dim empId As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("EmpCode")).ToString.Trim
        Dim wkDate As Date = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("WorkDay"))
        Dim shiftcode As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("ShiftCode")).ToString.Trim

        Dim frm As New FrmFpLog
        frm.empCode = empId
        frm.wkDate = wkDate
        frm.shiftstart = ShiftStartTime(shiftcode, wkDate)
        frm.shiftend = ShiftEndTime(shiftcode, wkDate)
        frm.ShowDialog()
    End Sub

    Private Sub gvAttd_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvAttd.RowClick
        Try
            Dim i As Integer = gvAttd.FocusedRowHandle
            Dim isCheckIn As Boolean = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("IsCheckIn"))
            Dim isCheckOut As Boolean = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("IsCheckOut"))
            Dim itemDept As String = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("GroupCode"))
            Dim chkInRv As Boolean = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("CheckInRv"))
            Dim chkOutRv As Boolean = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("CheckOutRv"))
            Dim chkInApprState As Integer = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("CheckInApprState"))
            Dim chkOutApprState As Integer = gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("CheckOutApprState"))
            Dim wkDay As Date = CDate(gvAttd.GetRowCellValue(i, gvAttd.Columns.Item("WorkDay")))
            Dim diff As Integer = DateDiff(DateInterval.Day, wkDay, Now.Date(), FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)


            If CurrentSession.User.ID = "admin" Then
                btnRequest.Enabled = True
            Else
                If CurrentSession.User.AccessAnyTime = False Then
                    If Now.Day > 21 And wkDay < New Date(Now.Year, Now.Month, 20) Then
                        btnRequest.Enabled = False
                    Else
                        If diff >= 0 And diff <= NormingExtension.ConfigurationInfo.RosterEditAllowDay Then
                            If (chkInApprState > 1 And chkInApprState < 5) Or (chkOutApprState > 1 And chkInApprState < 5) Then
                                btnRequest.Enabled = False
                            Else
                                btnRequest.Enabled = True
                            End If
                        Else
                            btnRequest.Enabled = False
                        End If
                    End If
                Else
                    btnRequest.Enabled = True
                End If
            End If

        Catch ex As Exception
            GetLog(ex.Message)

            btnRequest.Enabled = False
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            saveDia.ShowDialog()
            If Not IsNothing(saveDia.FileName) Then
                gvAttd.ExportToXlsx(saveDia.FileName)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub dtFrom_EditValueChanged(sender As Object, e As EventArgs) Handles dtFrom.EditValueChanged
        Try
            If dtFrom.EditValue > dtTo.EditValue Then
                dtTo.EditValue = CDate(dtFrom.EditValue)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub
    Public Sub LoadData()
        Try
            If Not IsNothing(lstDept.EditValue) Then
                tblAttd = New DataTable
                Dim whereStr As String = ""

                If radOption.SelectedIndex = 0 Then
                    If lstDept.EditValue.ToString.Trim = "GAMING" Then
                        whereStr = "GroupCode = '" + lstDept.EditValue.ToString.Trim + "'  AND EmpUnder = '" + lstEmpUnder.EditValue.ToString.Trim + "' AND WorkDay BETWEEN CONVERT(DATE,'" + Format(dtFrom.EditValue, "yyyy-MM-dd") + "')  AND CONVERT(DATE,'" + Format(dtTo.EditValue, "yyyy-MM-dd") + "') AND ShiftCode LIKE 'C%' AND Exempted IS NULL AND ((IsCheckIn = '0' OR IsCheckIn IS NULL) OR (IsCheckOut = '0' OR IsCheckOut IS NULL) OR (LateCheckIn IS NOT NULL OR EarlyCheckOut IS NOT NULL)) AND EmpStatus = 1 "
                        tblAttd = CType(ExtensionDB.SelectField("*", "SevenAttdRawData", whereStr, DataConnector.SelectedReturnType.DataTable), DataTable)
                    Else
                        whereStr = "GroupCode = '" + lstDept.EditValue.ToString.Trim + "' AND WorkDay BETWEEN CONVERT(DATE,'" + Format(dtFrom.EditValue, "yyyy-MM-dd") + "')  AND CONVERT(DATE,'" + Format(dtTo.EditValue, "yyyy-MM-dd") + "') AND ShiftCode LIKE 'C%' AND Exempted IS NULL AND ((IsCheckIn = '0' OR IsCheckIn IS NULL) OR (IsCheckOut = '0' OR IsCheckOut IS NULL) OR (LateCheckIn IS NOT NULL OR EarlyCheckOut IS NOT NULL)) AND EmpStatus = 1"
                        tblAttd = CType(ExtensionDB.SelectField("*", "SevenAttdRawData", whereStr, DataConnector.SelectedReturnType.DataTable), DataTable)
                    End If
                ElseIf radOption.SelectedIndex = 1 Then
                    If lstDept.EditValue.ToString.Trim = "GAMING" Then
                        whereStr = "GroupCode = '" + lstDept.EditValue.ToString.Trim + "'  AND EmpUnder = '" + lstEmpUnder.EditValue.ToString.Trim + "' AND WorkDay BETWEEN CONVERT(DATE,'" + Format(dtFrom.EditValue, "yyyy-MM-dd") + "')  AND CONVERT(DATE,'" + Format(dtTo.EditValue, "yyyy-MM-dd") + "') AND ShiftCode LIKE 'C%' AND Exempted IS NULL AND ((IsCheckIn = '0' OR IsCheckIn IS NULL) OR (IsCheckOut = '0' OR IsCheckOut IS NULL)) AND EmpStatus = 1"
                        tblAttd = CType(ExtensionDB.SelectField("*", "SevenAttdRawData", whereStr, DataConnector.SelectedReturnType.DataTable), DataTable)
                    Else
                        whereStr = "GroupCode = '" + lstDept.EditValue.ToString.Trim + "' AND WorkDay BETWEEN CONVERT(DATE,'" + Format(dtFrom.EditValue, "yyyy-MM-dd") + "')  AND CONVERT(DATE,'" + Format(dtTo.EditValue, "yyyy-MM-dd") + "') AND ShiftCode LIKE 'C%' AND Exempted IS NULL AND ((IsCheckIn = '0' OR IsCheckIn IS NULL) OR (IsCheckOut = '0' OR IsCheckOut IS NULL)) AND EmpStatus = 1"
                        tblAttd = CType(ExtensionDB.SelectField("*", "SevenAttdRawData", whereStr, DataConnector.SelectedReturnType.DataTable), DataTable)
                    End If
                Else
                    If lstDept.EditValue.ToString.Trim = "GAMING" Then
                        whereStr = "GroupCode = '" + lstDept.EditValue.ToString.Trim + "'  AND EmpUnder = '" + lstEmpUnder.EditValue.ToString.Trim + "' AND WorkDay BETWEEN CONVERT(DATE,'" + Format(dtFrom.EditValue, "yyyy-MM-dd") + "')  AND CONVERT(DATE,'" + Format(dtTo.EditValue, "yyyy-MM-dd") + "') AND ShiftCode LIKE 'C%' AND Exempted IS NULL AND ((IsCheckIn = '1' AND IsCheckOut = '1') AND (LateCheckIn IS NOT NULL OR EarlyCheckOut IS NOT NULL)) AND EmpStatus = 1"
                        tblAttd = CType(ExtensionDB.SelectField("*", "SevenAttdRawData", whereStr, DataConnector.SelectedReturnType.DataTable), DataTable)
                    Else
                        whereStr = "GroupCode = '" + lstDept.EditValue.ToString.Trim + "' AND WorkDay BETWEEN CONVERT(DATE,'" + Format(dtFrom.EditValue, "yyyy-MM-dd") + "')  AND CONVERT(DATE,'" + Format(dtTo.EditValue, "yyyy-MM-dd") + "') AND ShiftCode LIKE 'C%' AND Exempted IS NULL AND ((IsCheckIn = '1' AND IsCheckOut = '1') AND (LateCheckIn IS NOT NULL OR EarlyCheckOut IS NOT NULL)) AND EmpStatus = 1"
                        tblAttd = CType(ExtensionDB.SelectField("*", "SevenAttdRawData", whereStr, DataConnector.SelectedReturnType.DataTable), DataTable)
                    End If
                End If

                btnRequest.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Something went wrong, please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        LoadData()
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        gcAttd.DataSource = tblAttd
        lblTotalRecord.Text = "(" + gvAttd.RowCount.ToString.Trim + ")"
    End Sub


    Private Sub lstDept_EditValueChanged(sender As Object, e As EventArgs) Handles lstDept.EditValueChanged
        If lstDept.EditValue.ToString.Trim = "GAMING" Then
            lblEmpUnder.Visible = True
            lstEmpUnder.Visible = True

            Dim tblSup As DataTable = CType(NormingDB.SelectField("HREMP.HREMP_EMPCODE AS [SupID], HREMP.HREMP_FNAME AS [SupName]", "HREMP", "HREMP.HREMP_EMPCODE IN(SELECT DISTINCT(HREMP.HREMP_SUVISOR2) FROM HREMP WHERE HREMP.HREMP_ORG = 3)", DataConnector.SelectedReturnType.DataTable), DataTable)

            lstEmpUnder.Properties.DataSource = tblSup
            lstEmpUnder.EditValue = lstEmpUnder.Properties.GetDataSourceValue(lstEmpUnder.Properties.ValueMember, 0)
        Else
            lblEmpUnder.Visible = False
            lstEmpUnder.Visible = False
        End If
        
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bgWorker = New BackgroundWorker

        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub dtTo_EditValueChanged(sender As Object, e As EventArgs) Handles dtTo.EditValueChanged
        Try
            If CDate(dtTo.EditValue) < CDate(dtFrom.EditValue) Then
                dtFrom.EditValue = CDate(dtTo.EditValue)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub


End Class