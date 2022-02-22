Imports System.ComponentModel
Imports NormExt.NormingExtension

Public Class FrmManalyser
    Dim dept As DataTable
    Dim orgID As Integer

    Dim fromDate As Date
    Dim toDate As Date
    Dim gapHour As Integer
    Dim StaTus As Integer = 0
    Dim DepartChaneg As Integer
    Dim dateStatus As String
    Dim empStatus As String
    Dim dateTotal As Integer
    Dim shiftTotal As Integer
    Dim nextDate As Integer
    Dim nextShift As Integer

    Dim MasterFingerPrint As New DataTable
    Dim MasterShiftList As New DataTable
    Dim MasterRoster As New DataTable
    Dim MasterShiftGroup As New DataTable
    Dim MasterAttedance As New DataTable
    Dim empRoster As DataRow()

    Private Sub FrmManalyser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStop.Enabled = False

        Try
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

            ReadConfigFile()

            Dim fromTime As Date = DateAdd(DateInterval.Day, -1, Now())
            Dim toTime As Date = DateAdd(DateInterval.Day, 0, Now())
            Dim getOrgIDSession As String = CurrentSession.User.WorkingDepartment.OrgId
            Dim getDeptSession As String = CurrentSession.User.WorkingDepartment.Name

            dtFrom.EditValue = Format(fromTime, "yyyy-MM-dd") + " 00:00:00 AM"
            dtTo.EditValue = Format(toTime, "yyyy-MM-dd") + " 09:00:00 AM"

            dept = New DataTable
            dept = ExtensionDB.SelectField("OrgID, DeptName", "tbl_departments ORDER BY OrgID ASC", "", DataConnector.SelectedReturnType.DataTable)


            If CurrentSession.User.ID = "admin" Or CurrentSession.User.AccessAnyTime = True Then
                lstDept.Properties.DataSource = dept
            Else
                lstDept.Properties.DataSource = dept
                lstDept.ItemIndex = lstDept.Properties.GetDataSourceRowIndex(lstDept.Properties.ValueMember, getOrgIDSession)
                lstDept.Enabled = False
            End If


            lblDate.Text = ""
            lblShift.Text = ""
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Function CheckInShiftList(ByVal runningTime As DateTime) As DataRow()
        Dim shiftHour As String = DateAdd(DateInterval.Hour, -2, runningTime).ToString("HH")
        Dim shifts As DataRow() = MasterShiftList.Select("ASSHIFT_FROMHOUR LIKE '" + shiftHour + ":%' AND ASSHIFT_SHIFTCODE LIKE 'C%'")

        Return shifts
    End Function

    Function CheckOutShiftList(ByVal runningTime As DateTime) As DataRow()
        Dim shiftHour As String = DateAdd(DateInterval.Hour, -2, runningTime).ToString("HH")
        Dim shifts As DataRow() = MasterShiftList.Select("ASSHIFT_TOHOUR LIKE '" + shiftHour + ":%' AND ASSHIFT_SHIFTCODE LIKE 'C%'")

        Return shifts
    End Function

    Sub AnalyzeCheckIn(ByVal shiftCode As String, ByVal runningTime As DateTime)
        Try
            Dim shiftInOutTime As Date = DateAdd(DateInterval.Hour, -2, runningTime)
            Dim empRoster As DataRow() = MasterRoster.Select("ATWKCALDEMP_WKDATE = '" + shiftInOutTime.ToString("yyyy-MM-dd 00:00:00.000") + "' AND ATWKCALDEMP_SHIFTCODE = '" + shiftCode + "'")

            For i As Integer = 0 To empRoster.Count - 1
                Dim empId As String = empRoster(i)("ATWKCALDEMP_EMPID").ToString.Trim()
                Dim cnt As Integer = ExtensionDB.SelectField("COUNT(*)", "tbl_attendance", "WorkDay = '" + shiftInOutTime.ToString("yyyy-MM-dd") + "' AND EmpID = '" + empId + "'", DataConnector.SelectedReturnType.SignleValue)
                Dim myFingerprint As DataRow() = MasterFingerPrint.Select("EmpID = '" + empId + "' AND LoginTime >= '" + DateAdd(DateInterval.Hour, -4, runningTime).ToString("yyyy-MM-dd HH:mm:ss") + ".000' AND LoginTime <= '" + runningTime.ToString("yyyy-MM-dd HH:mm:ss") + ".000'")
                Dim empName As String = empRoster(i)("EmpName").ToString.Trim()
                Dim cntShiftGrp As Integer = NormingDB.SelectField("COUNT(*)", "ATSHIFTGRPE grp INNER JOIN HREMP emp ON grp.ATSHIFTGRPE_EMPID = emp.HREMP_EMPID", "HREMP_EMPCODE = '" + empId + "' ", DataConnector.SelectedReturnType.SignleValue)


                If cntShiftGrp > 0 Then
                    Dim shiftGrp As String = MasterShiftGroup.Select("HREMP_EMPCODE = '" + empId + "'")(0)("ATSHIFTGRPE_GRPCODE").ToString.Trim
                    Dim FromTime As String = MasterShiftList.Select("ASSHIFT_SHIFTCODE = '" + shiftCode + "'")(0)("ASSHIFT_FROMHOUR").ToString.Trim
                    Dim ToTime As String = MasterShiftList.Select("ASSHIFT_SHIFTCODE = '" + shiftCode + "'")(0)("ASSHIFT_TOHOUR").ToString.Trim

                    If cnt = 0 Then
                        If myFingerprint.Count > 0 Then
                            ExtensionDB.InitInsertCommand("tbl_attendance")
                            ExtensionDB.InsertField("WorkDay", Format(shiftInOutTime, "yyyy-MM-dd"))
                            ExtensionDB.InsertField("EmpID", empId)
                            ExtensionDB.InsertField("EmpName", empName)
                            ExtensionDB.InsertField("ShiftGroup", shiftGrp)
                            ExtensionDB.InsertField("ShiftCode", shiftCode)
                            ExtensionDB.InsertField("ShiftStart", FromTime)
                            ExtensionDB.InsertField("ShiftEnd", ToTime)
                            ExtensionDB.InsertField("IsCheckIn", 1)
                            ExtensionDB.InsertField("CheckInTime", myFingerprint(0)("LoginTime"))
                            ExtensionDB.ExecuteInsertCommand()
                        Else
                            ExtensionDB.InitInsertCommand("tbl_attendance")
                            ExtensionDB.InsertField("WorkDay", Format(shiftInOutTime, "yyyy-MM-dd"))
                            ExtensionDB.InsertField("EmpID", empId)
                            ExtensionDB.InsertField("EmpName", empName)
                            ExtensionDB.InsertField("ShiftGroup", shiftGrp)
                            ExtensionDB.InsertField("ShiftCode", shiftCode)
                            ExtensionDB.InsertField("ShiftStart", FromTime)
                            ExtensionDB.InsertField("ShiftEnd", ToTime)
                            ExtensionDB.InsertField("IsCheckIn", 0)
                            ExtensionDB.InsertField("CheckInTime", "1900-01-01 00:00:00.00")
                            ExtensionDB.ExecuteInsertCommand()
                        End If

                    Else
                        Dim cntFromMaster As Integer = MasterAttedance.Select("WorkDay = '" + shiftInOutTime.ToString("yyyy-MM-dd") + "' AND EmpID = '" + empId + "'").Count

                        If cntFromMaster > 0 Then
                            If myFingerprint.Count > 0 Then
                                ExtensionDB.InitUpdateCommand("tbl_attendance")
                                ExtensionDB.SetWhereField("WorkDay", Format(shiftInOutTime, "yyyy-MM-dd"))
                                ExtensionDB.SetWhereField("EmpID", empId)
                                ExtensionDB.SetUpdateField("EmpName", empName)
                                ExtensionDB.SetUpdateField("ShiftGroup", shiftGrp)
                                ExtensionDB.SetUpdateField("ShiftCode", shiftCode)
                                ExtensionDB.SetUpdateField("ShiftStart", FromTime)
                                ExtensionDB.SetUpdateField("ShiftEnd", ToTime)
                                ExtensionDB.SetUpdateField("IsCheckIn", 1)
                                ExtensionDB.SetUpdateField("CheckInTime", myFingerprint(0)("LoginTime"))
                                ExtensionDB.ExecuteUpdateCommand()
                            Else
                                ExtensionDB.InitUpdateCommand("tbl_attendance")
                                ExtensionDB.SetWhereField("WorkDay", Format(shiftInOutTime, "yyyy-MM-dd"))
                                ExtensionDB.SetWhereField("EmpID", empId)
                                ExtensionDB.SetUpdateField("EmpName", empName)
                                ExtensionDB.SetUpdateField("ShiftGroup", shiftGrp)
                                ExtensionDB.SetUpdateField("ShiftCode", shiftCode)
                                ExtensionDB.SetUpdateField("ShiftStart", FromTime)
                                ExtensionDB.SetUpdateField("ShiftEnd", ToTime)
                                ExtensionDB.SetUpdateField("IsCheckIn", 0)
                                ExtensionDB.SetUpdateField("CheckInTime", "1900-01-01 00:00:00.00")
                                ExtensionDB.ExecuteUpdateCommand()
                            End If
                        End If
                    End If

                Else
                    MsgBox("No shift group for " + empId, MsgBoxStyle.Exclamation, AppName)
                End If

            Next
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Sub AnalyzeCheckOut(ByVal shiftCode As String, ByVal runningTime As DateTime)
        Try
            Dim workHours As Integer = CInt(MasterShiftList.Select("ASSHIFT_SHIFTCODE = '" + shiftCode + "'")(0)("ASSHIFT_WORKHOURS"))
            Dim shiftInOutTime As Date = DateAdd(DateInterval.Hour, -2, runningTime)
            Dim workDay As Date = DateAdd(DateInterval.Hour, -workHours, shiftInOutTime)
            Dim empRoster As DataRow() = MasterRoster.Select("ATWKCALDEMP_WKDATE = '" + workDay.ToString("yyyy-MM-dd 00:00:00.000") + "' AND ATWKCALDEMP_SHIFTCODE = '" + shiftCode + "'")

            For i As Integer = 0 To empRoster.Count - 1
                Dim empID As String = empRoster(i)("ATWKCALDEMP_EMPID").ToString.Trim()
                Dim cnt As Integer = MasterAttedance.Select("WorkDay = '" + workDay.ToString("yyyy-MM-dd") + "' AND EmpID = '" + empID + "'").Count
                Dim myFingerprint As DataRow() = MasterFingerPrint.Select("EmpID = '" + empID + "' AND LoginTime >= '" + DateAdd(DateInterval.Hour, -4, runningTime).ToString("yyyy-MM-dd HH:mm:ss") + ".000' AND LoginTime <= '" + runningTime.ToString("yyyy-MM-dd HH:mm:ss") + ".000'")

                If cnt > 0 Then
                    If myFingerprint.Count > 0 Then
                        ExtensionDB.InitUpdateCommand("tbl_attendance")
                        ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                        ExtensionDB.SetWhereField("EmpID", empID)
                        ExtensionDB.SetUpdateField("IsCheckOut", 1)
                        ExtensionDB.SetUpdateField("CheckOutTime", myFingerprint(myFingerprint.Count - 1)("LoginTime"))
                        ExtensionDB.ExecuteUpdateCommand()
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Sub ClearInPending()
        Try
            Dim orgId As Integer = CInt(lstDept.EditValue)
            Dim fDate As Date = CDate(dtFrom.EditValue.ToString)
            Dim tDate As Date = CDate(dtTo.EditValue.ToString)
            Dim empCode As String

            If (orgId > 0) Then
                If txtEmpCode.EditValue = "" Then
                    empCode = ""
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckInApproveStatus = 6, CheckInRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.LateCheckIn IS NULL) AND (raw.CheckInRv = 1) AND attd.CheckInApproveStatus NOT IN(4,6) AND raw.OrgID = '" + orgId.ToString + "' ")
                Else
                    empCode = txtEmpCode.EditValue.ToString
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckInApproveStatus = 6, CheckInRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.LateCheckIn IS NULL) AND (raw.CheckInRv = 1) AND attd.CheckInApproveStatus NOT IN(4,6) AND raw.OrgID = '" + orgId.ToString + "' AND attd.EmpID = '" + empCode + "' ")
                End If
            Else
                If txtEmpCode.EditValue = "" Then
                    empCode = ""
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckInApproveStatus = 6, CheckInRv = 2  FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.LateCheckIn IS NULL) AND (raw.CheckInRv = 1) AND attd.CheckInApproveStatus NOT IN(4,6) ")
                Else
                    empCode = txtEmpCode.EditValue.ToString
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckInApproveStatus = 6, CheckInRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.LateCheckIn IS NULL) AND (raw.CheckInRv = 1) AND attd.CheckInApproveStatus NOT IN(4,6) AND attd.EmpID = '" + empCode + "' ")
                End If
            End If

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Sub ClearOutPending()
        Try
            Dim orgId As Integer = CInt(lstDept.EditValue)
            Dim fDate As Date = CDate(dtFrom.EditValue.ToString)
            Dim tDate As Date = CDate(dtTo.EditValue.ToString)
            Dim empCode As String

            If (orgId > 0) Then
                If txtEmpCode.EditValue = "" Then
                    empCode = ""
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckOutApproveStatus = 6, CheckOutRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.EarlyCheckOut IS NULL) AND (raw.CheckOutRv = 1) AND attd.CheckOutApproveStatus NOT IN(4,6) AND raw.OrgID = '" + orgId.ToString + "' ")
                Else
                    empCode = txtEmpCode.EditValue.ToString
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckOutApproveStatus = 6, CheckOutRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.EarlyCheckOut IS NULL) AND (raw.CheckOutRv = 1) AND attd.CheckOutApproveStatus NOT IN(4,6) AND raw.OrgID = '" + orgId.ToString + "' AND attd.EmpID = '" + empCode + "' ")
                End If
            Else
                If txtEmpCode.EditValue = "" Then
                    empCode = ""
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckOutApproveStatus = 6, CheckOutRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.EarlyCheckOut IS NULL) AND (raw.CheckOutRv = 1) AND attd.CheckOutApproveStatus NOT IN(4,6) ")
                Else
                    empCode = txtEmpCode.EditValue.ToString
                    ExtensionDB.RunDML("UPDATE tbl_attendance SET CheckOutApproveStatus = 6, CheckOutRv = 2 FROM SevenAttdRawData raw INNER JOIN tbl_attendance attd ON raw.WorkDay = attd.WorkDay AND raw.EmpCode = attd.EmpID WHERE (raw.WorkDay BETWEEN '" + Format(fDate, "yyyy-MM-dd") + "' AND '" + Format(tDate, "yyyy-MM-dd") + "') AND (raw.EarlyCheckOut IS NULL) AND (raw.CheckOutRv = 1) AND attd.CheckOutApproveStatus NOT IN(4,6) AND attd.EmpID = '" + empCode + "' ")
                End If
            End If
            
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        Try
            dateStatus = "Initializing Data..."
            empStatus = "Initializing Data..."

            fromDate = CDate(dtFrom.EditValue)
            toDate = CDate(dtTo.EditValue)

            MasterShiftList = NormingDB.SelectField("*", "ASSHIFT", "", DataConnector.SelectedReturnType.DataTable)
            MasterShiftGroup = NormingDB.SelectField("grp.*, HREMP_EMPCODE", "ATSHIFTGRPE grp INNER JOIN HREMP emp ON grp.ATSHIFTGRPE_EMPID = emp.HREMP_EMPID", "emp.HREMP_STATUS = 1", DataConnector.SelectedReturnType.DataTable)

            Dim totalPeriod As Integer = NormingDB.SelectField("MAX(ASSHIFT_WORKHOURS) + 4", "ASSHIFT", "ASSHIFT_SHIFTCODE LIKE 'C%' ", DataConnector.SelectedReturnType.SignleValue)

            Dim k As Integer = CInt(DateDiff(DateInterval.Hour, fromDate, toDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek))
            Dim orgID As Integer = CInt(lstDept.EditValue)

            dateTotal = k + 1

            For j As Integer = 0 To k

                If worker.CancellationPending = True Then
                    e.Cancel = True

                    Exit For
                Else
                    nextDate = j + 1
                    dateStatus = "Processing... on: " + Format(DateAdd(DateInterval.Hour, j, fromDate), "yyyy-MM-dd HH:mm:ss tt")

                    Dim runTime As DateTime = CDate(Format(DateAdd(DateInterval.Hour, j, fromDate), "yyyy-MM-dd HH:mm:ss tt"))

                    Dim rosterStrSelect As String = "rter.ATWKCALDEMP_EMPID, rter.ATWKCALDEMP_WKDATE, rter.ATWKCALDEMP_SHIFTCODE, rter.ATWKCALDEMP_FROMHOUR, rter.ATWKCALDEMP_TOHOUR, emp.HREMP_FNAME + ' ' + emp.HREMP_LNAME AS 'EmpName', emp.HREMP_EMPCODE, emp.HREMP_EMPCODE, emp.HREMP_ORG, exem.ExemStatus"
                    Dim rosterStrFrom As String = "ATWKCALDEMP rter INNER JOIN HREMP emp ON rter.ATWKCALDEMP_EMPID = emp.HREMP_EMPCODE LEFT JOIN EXEMPTED exem ON emp.HREMP_EMPCODE = exem.ExemID"
                    Dim rosterStrWhere As String = ""
                    Dim attdStrWhere As String = ""
                    Dim fpStrWhere As String = ""

                    If orgID > 0 Then
                        Dim empCode As String

                        If txtEmpCode.EditValue = "" Then
                            empCode = ""
                            rosterStrWhere = "exem.ExemStatus IS NULL AND emp.HREMP_STATUS = '1' AND emp.HREMP_ORG = '" & orgID & "' AND rter.ATWKCALDEMP_WKDATE BETWEEN '" + DateAdd(DateInterval.Day, -1, runTime).ToString("yyyy-MM-dd 00:00:00.000") + "' AND '" + runTime.Date.ToString("yyyy-MM-dd 00:00:00.000") + "' ORDER BY rter.ATWKCALDEMP_EMPID ASC"
                            attdStrWhere = "WorkDay >= '" + DateAdd(DateInterval.Day, -1, runTime).ToString("yyyy-MM-dd") + "' AND dept.OrgID = '" & orgID & "' AND (CheckInApproveStatus <> 4 AND CheckOutApproveStatus <> 4 )"
                            fpStrWhere = "LoginTime BETWEEN '" + DateAdd(DateInterval.Hour, -totalPeriod, runTime).ToString("yyyy-MM-dd HH:mm:ss") + ".000' AND '" + runTime.ToString("yyyy-MM-dd HH:mm:ss") + ".000' ORDER BY  EmpID, LoginTime ASC"
                        Else
                            empCode = txtEmpCode.EditValue.ToString.Trim
                            rosterStrWhere = "exem.ExemStatus IS NULL AND emp.HREMP_STATUS = '1' AND emp.HREMP_ORG = '" & orgID & "' AND emp.HREMP_EMPCODE = '" + empCode + "' AND rter.ATWKCALDEMP_WKDATE BETWEEN '" + DateAdd(DateInterval.Day, -1, runTime).ToString("yyyy-MM-dd 00:00:00.000") + "' AND '" + runTime.Date.ToString("yyyy-MM-dd 00:00:00.000") + "' ORDER BY rter.ATWKCALDEMP_EMPID ASC"
                            attdStrWhere = "WorkDay >= '" + DateAdd(DateInterval.Day, -1, runTime).ToString("yyyy-MM-dd") + "' AND dept.OrgID = '" & orgID & "' AND attd.EmpID = '" + empCode + "' AND (CheckInApproveStatus <> 4 AND CheckOutApproveStatus <> 4 )"
                            fpStrWhere = "LoginTime BETWEEN '" + DateAdd(DateInterval.Hour, -totalPeriod, runTime).ToString("yyyy-MM-dd HH:mm:ss") + ".000' AND '" + runTime.ToString("yyyy-MM-dd HH:mm:ss") + ".000' AND EmpID = '" + empCode + "' ORDER BY  EmpID, LoginTime ASC"
                        End If

                    Else
                        fpStrWhere = "LoginTime BETWEEN '" + DateAdd(DateInterval.Hour, -totalPeriod, runTime).ToString("yyyy-MM-dd HH:mm:ss") + ".000' AND '" + runTime.ToString("yyyy-MM-dd HH:mm:ss") + ".000' ORDER BY  EmpID, LoginTime ASC"

                        If txtEmpCode.EditValue = "" Then
                            rosterStrWhere = "exem.ExemStatus IS NULL AND emp.HREMP_STATUS = '1' AND rter.ATWKCALDEMP_WKDATE BETWEEN '" + DateAdd(DateInterval.Day, -1, runTime).ToString("yyyy-MM-dd 00:00:00.000") + "' AND '" + runTime.Date.ToString("yyyy-MM-dd 00:00:00.000") + "' ORDER BY rter.ATWKCALDEMP_EMPID ASC"
                            attdStrWhere = "WorkDay >= '" + DateAdd(DateInterval.Day, -1, runTime).ToString("yyyy-MM-dd") + "' AND (CheckInApproveStatus <> 4 AND CheckOutApproveStatus <> 4 )"
                        Else
                            MsgBox("Please select department", MsgBoxStyle.Critical, AppName)

                            Exit Sub
                        End If
                    End If

                    MasterRoster = NormingDB.SelectField(rosterStrSelect, rosterStrFrom, rosterStrWhere, DataConnector.SelectedReturnType.DataTable)
                    MasterFingerPrint = FingerDB.SelectField("*", "FingerPrintData", fpStrWhere, DataConnector.SelectedReturnType.DataTable)
                    MasterAttedance = ExtensionDB.SelectField("dept.OrgID, attd.*", "tbl_attendance attd INNER JOIN tbl_deptshiftgrp grp ON attd.ShiftGroup = grp.GroupCode INNER JOIN tbl_departments dept ON grp.DeptID = dept.DeptID", attdStrWhere, DataConnector.SelectedReturnType.DataTable)

                    Dim shiftIN As DataRow() = CheckInShiftList(runTime)
                    Dim shiftOUT As DataRow() = CheckOutShiftList(runTime)

                    shiftTotal = shiftIN.Count

                    For i As Integer = 0 To shiftIN.Count - 1
                        nextShift = i + 1
                        empStatus = "Processing... on Shift: " + shiftIN(i)("ASSHIFT_SHIFTCODE").ToString.Trim()

                        AnalyzeCheckIn(shiftIN(i)("ASSHIFT_SHIFTCODE").ToString.Trim(), runTime)
                    Next

                    For n As Integer = 0 To shiftOUT.Count - 1
                        AnalyzeCheckOut(shiftOUT(n)("ASSHIFT_SHIFTCODE").ToString.Trim(), runTime)
                    Next

                End If

            Next

            ClearInPending()
            ClearOutPending()

            MsgBox("Completed.", MsgBoxStyle.Information, AppName)

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        Timer1.Enabled = False
        dateTotal = 0
        nextDate = 0
        shiftTotal = 0
        nextShift = 0
        lblDate.Text = ""
        lblShift.Text = ""

        progBar1.Value = 0
        progBar2.Value = 0

        btnStart.Enabled = True
        dtFrom.Enabled = True
        dtTo.Enabled = True
        lstDept.Enabled = True
        combGapHour.Enabled = True

        btnStop.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progBar1.Maximum = dateTotal
        progBar1.Value = nextDate
        lblDate.Text = dateStatus

        progBar2.Maximum = shiftTotal
        progBar2.Value = nextShift
        lblShift.Text = empStatus
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True

        btnStart.Enabled = False
        dtFrom.Enabled = False
        dtTo.Enabled = False
        lstDept.Enabled = False
        combGapHour.Enabled = False
        btnStop.Enabled = True

        orgID = CInt(lstDept.EditValue)
        fromDate = CDate(dtFrom.EditValue)
        toDate = CDate(dtTo.EditValue)
        gapHour = CInt(combGapHour.EditValue)

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If

        Timer1.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If bgWorker.WorkerSupportsCancellation = True Then
            bgWorker.CancelAsync()
        End If
    End Sub

End Class