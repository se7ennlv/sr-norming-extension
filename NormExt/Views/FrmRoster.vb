Imports NormExt.NormingExtension
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Public Class FrmRoster
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim selectGrp As String = ""
    Dim fromDate As Date
    Dim toDate As Date
    Dim empCode As String = ""
    Dim tblRoster As DataTable
    Dim bgStep As Integer
    Dim bgMax As Integer
    Dim bgStat As String
    Dim tblShfEmp As DataTable
    Dim enablEdit As Boolean = False
    Dim Rosters As List(Of RosterInfo)
    Dim bgCommand As Integer = 0
    Dim importRoster As DataTable
    Private Sub FrmRoster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Rosters = New List(Of RosterInfo)

        Dim tblgrp As DataTable
        Dim deptUnder = CurrentSession.User.DeptUnder
        Dim deptId As String = CurrentSession.User.WorkingDepartment.ID

        If CurrentSession.User.ID = "admin" Or deptId = "IT" Or deptId = "HR" Then
            tblgrp = NormingDB.SelectField("ATSHIFTGRP_CODE as 'GroupCode'", "ATSHIFTGRP", "", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        Else
            tblgrp = NormingDB.SelectField("ATSHIFTGRP_CODE as 'GroupCode'", "ATSHIFTGRP", "ATSHIFTGRP_CODE IN (" + deptUnder + ")", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        End If

        If CurrentSession.User.ID = "admin" Then
            btnImport.Enabled = True
        Else
            btnImport.Enabled = True

            '-- for only during Covid-19
            'If CurrentSession.User.AccessAnyTime = False Then
            '    Dim dy As Integer = CInt(Format(Now(), "dd"))

            '    If CurrentSession.User.RosterAccessLevel > 1 And dy > 20 And dy <= 20 + ConfigurationInfo.RosterImportAllowDay Then
            '        btnImport.Enabled = True
            '    Else
            '        btnImport.Enabled = False
            '        End If
            '    Else
            '        btnImport.Enabled = True
            'End If
        End If

        lstShiftGroup.Properties.DataSource = tblgrp

        If tblgrp.Rows.Count > 0 Then
            lstShiftGroup.EditValue = tblgrp.Rows(0)(0).ToString.Trim
        End If

        dtFrom.EditValue = Now().Date
        dtTo.EditValue = DateAdd(DateInterval.Day, 1, Now.Date)
        txtEmpCode.EditValue = ""
        lstShiftDay.EditValue = 1
        lstShiftCode.Properties.DataSource = NormingDB.SelectField("rtrim(ASSHIFT_SHIFTCODE) as 'ASSHIFT_SHIFTCODE',rtrim(ASSHIFT_SHIFTDESC) as 'ASSHIFT_SHIFTDESC'", "ASSHIFT", "", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        lstShiftCode.EditValue = "C0800"
        swDayOff.EditValue = False

        If CurrentSession.User.RosterAccessLevel <= 1 Then ' Readonly
            btnEnableEdit.Enabled = False
            enablEdit = False
            PanelControl3.Enabled = False
        Else
            btnEnableEdit.Enabled = True
            enablEdit = False

            PanelControl3.Enabled = True
        End If

    End Sub
    Private Sub btnShowRtAndShift_Click(sender As Object, e As EventArgs) Handles btnShowRtAndShift.Click
        bgWorker = New BackgroundWorker()
        bgWorker.WorkerSupportsCancellation = True
        bgCommand = 1 'Show the roster template and shift code

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
            btnShowRtAndShift.Enabled = False
            btnNewTemp.Enabled = False
            '--btnImport.Enabled = False
        End If

        Try
            gvRoster.Columns.Clear()
            tblRoster = New DataTable
            tblShfEmp = New DataTable
            fromDate = dtFrom.EditValue
            toDate = dtTo.EditValue
            empCode = txtEmpCode.EditValue.ToString.Trim
            selectGrp = lstShiftGroup.EditValue.ToString.Trim

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Private Sub btnNewTemp_Click(sender As Object, e As EventArgs) Handles btnNewTemp.Click
        bgWorker = New BackgroundWorker()
        bgWorker.WorkerSupportsCancellation = True
        bgCommand = 2

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
            btnShowRtAndShift.Enabled = False
            btnNewTemp.Enabled = False
            '--btnImport.Enabled = False
        End If

        Try
            gvRoster.Columns.Clear()
            tblRoster = New DataTable
            tblShfEmp = New DataTable
            fromDate = dtFrom.EditValue
            toDate = dtTo.EditValue
            empCode = txtEmpCode.EditValue.ToString.Trim
            selectGrp = lstShiftGroup.EditValue.ToString.Trim

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub btnEnableEdit_Click(sender As Object, e As EventArgs) Handles btnEnableEdit.Click
        If enablEdit = False Then
            btnEnableEdit.Text = "Disable Edit"
            btnEnableEdit.ForeColor = Color.Red
            enablEdit = True
        Else
            btnEnableEdit.Text = "Enable Edit"
            btnEnableEdit.ForeColor = Color.Black
            enablEdit = False
        End If
    End Sub

    Private Sub ShowRosterAndShift()
        Try
            tblRoster = Nothing
            tblRoster = New DataTable
            Dim col1 As New DataColumn
            col1.ColumnName = "EMPCODE"
            col1.Caption = "EMP CODE"
            col1.DataType = GetType(String)
            tblRoster.Columns.Add(col1)
            Dim col2 As New DataColumn
            col2.ColumnName = "EMPNAME"
            col2.Caption = "EMP NAME"
            col2.DataType = GetType(String)
            tblRoster.Columns.Add(col2)
            Dim col3 As New DataColumn
            col3.ColumnName = "JOBTITLE"
            col3.Caption = "JOB TITLE"
            col3.DataType = GetType(String)
            tblRoster.Columns.Add(col3)
            Dim col4 As New DataColumn
            col4.ColumnName = "HIREDAY"
            col4.Caption = "HIRED DAY"
            col4.DataType = GetType(Date)
            tblRoster.Columns.Add(col4)

            Dim k As Integer = DateDiff(DateInterval.Day, fromDate, toDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

            For i As Integer = 0 To k
                Dim mycol As New DataColumn
                mycol.ColumnName = Format(DateAdd(DateInterval.Day, i, dtFrom.EditValue), "ddMMyyyy")
                mycol.Caption = Format(DateAdd(DateInterval.Day, i, dtFrom.EditValue), "dd-MM-yy")
                mycol.DataType = GetType(String)
                tblRoster.Columns.Add(mycol)
            Next

            If lstShiftGroup.EditValue.ToString.Trim = "GAMING" Then
                If lstSup.EditValue.ToString.Trim.Length > 0 Then

                    If empCode = "" Then
                        Dim sqlSelect As String = "HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME', HREMP_SUVISOR2 AS 'SupId'"
                        Dim sqlFrom As String = "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID"
                        Dim sqlWhere As String = "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 AND HREMP_SUVISOR2 = '" + lstSup.EditValue.ToString.Trim + "' ORDER BY HREMP_EMPCODE"

                        tblShfEmp = NormingDB.SelectField(sqlSelect, sqlFrom, sqlWhere, NormingExtension.DataConnector.SelectedReturnType.DataTable)

                        For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                            Dim myRow As DataRow = tblRoster.NewRow()

                            myRow.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                            myRow.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                            Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                            myRow.Item("JOBTITLE") = emp.JobTitle
                            myRow.Item("HIREDAY") = emp.HireDate

                            For j As Integer = 0 To k
                                Dim curdate As Date = DateAdd(DateInterval.Day, j, fromDate)
                                Dim wkDate As String = Format(curdate, "yyyy-MM-dd")

                                Dim shiftCode As Object = NormingDB.SelectField("ATWKCALDEMP_SHIFTCODE", "ATWKCALDEMP", "ATWKCALDEMP_EMPID = '" + tblShfEmp.Rows(i)("EMPCODE").ToString.Trim + "' AND CONVERT(DATE, ATWKCALDEMP_WKDATE) = '" & wkDate & "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

                                If IsNothing(shiftCode) Then
                                    myRow.Item(Format(curdate, "ddMMyyyy")) = ""
                                Else
                                    myRow.Item(Format(curdate, "ddMMyyyy")) = shiftCode.ToString.Trim
                                End If

                            Next

                            tblRoster.Rows.Add(myRow)
                        Next
                    Else
                        Dim sqlSelect As String = "HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME', HREMP_SUVISOR2 AS 'SupId'"
                        Dim sqlFrom As String = "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID"
                        Dim sqlWhere As String = "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 AND HREMP_SUVISOR2 = '" + lstSup.EditValue.ToString.Trim + "' AND HREMP_EMPCODE='" + empCode + "' ORDER BY HREMP_EMPCODE "

                        tblShfEmp = NormingDB.SelectField(sqlSelect, sqlFrom, sqlWhere, NormingExtension.DataConnector.SelectedReturnType.DataTable)

                        For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                            Dim myRow As DataRow = tblRoster.NewRow()

                            myRow.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                            myRow.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                            Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                            myRow.Item("JOBTITLE") = emp.JobTitle
                            myRow.Item("HIREDAY") = emp.HireDate

                            For j As Integer = 0 To k
                                Dim curdate As Date = DateAdd(DateInterval.Day, j, fromDate)
                                Dim wkDate As String = Format(curdate, "yyyy-MM-dd")

                                Dim shiftCode As Object = NormingDB.SelectField("ATWKCALDEMP_SHIFTCODE", "ATWKCALDEMP", "ATWKCALDEMP_EMPID = '" + tblShfEmp.Rows(i)("EMPCODE").ToString.Trim + "' AND CONVERT(DATE, ATWKCALDEMP_WKDATE) = '" & wkDate & "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

                                If IsNothing(shiftCode) Then
                                    myRow.Item(Format(curdate, "ddMMyyyy")) = ""
                                Else
                                    myRow.Item(Format(curdate, "ddMMyyyy")) = shiftCode.ToString.Trim
                                End If

                            Next

                            tblRoster.Rows.Add(myRow)
                        Next
                    End If
                End If
            Else
                If empCode = "" Then
                    tblShfEmp = NormingDB.SelectField("HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME'", "ATSHIFTGRPE INNER JOIN HREMP on ATSHIFTGRPE_EMPID = HREMP_EMPID", "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 ORDER BY HREMP_EMPCODE ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

                    For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                        Dim myRow As DataRow = tblRoster.NewRow()

                        myRow.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                        myRow.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                        Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                        myRow.Item("JOBTITLE") = emp.JobTitle
                        myRow.Item("HIREDAY") = emp.HireDate

                        For j As Integer = 0 To k
                            Dim curdate As Date = DateAdd(DateInterval.Day, j, fromDate)
                            Dim wkDate As String = Format(curdate, "yyyy-MM-dd")

                            Dim shiftcode As Object = NormingDB.SelectField("ATWKCALDEMP_SHIFTCODE", "ATWKCALDEMP", "ATWKCALDEMP_EMPID = '" & tblShfEmp.Rows(i)("EMPCODE").ToString.Trim & "' AND CONVERT(DATE, ATWKCALDEMP_WKDATE) = '" & wkDate & "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

                            If IsNothing(shiftcode) Then
                                myRow.Item(Format(curdate, "ddMMyyyy")) = ""
                            Else
                                myRow.Item(Format(curdate, "ddMMyyyy")) = shiftcode.ToString.Trim
                            End If

                        Next

                        tblRoster.Rows.Add(myRow)
                    Next
                Else
                    tblShfEmp = NormingDB.SelectField("HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME'", "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID", "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 AND HREMP_EMPCODE ='" + empCode + "' ORDER BY HREMP_EMPCODE", NormingExtension.DataConnector.SelectedReturnType.DataTable)

                    For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                        Dim myRow As DataRow = tblRoster.NewRow()

                        myRow.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                        myRow.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                        Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                        myRow.Item("JOBTITLE") = emp.JobTitle
                        myRow.Item("HIREDAY") = emp.HireDate

                        For j As Integer = 0 To k
                            Dim curDate As Date = DateAdd(DateInterval.Day, j, fromDate)
                            Dim wkDate As String = Format(curDate, "yyyy-MM-dd")

                            Dim shiftCode As Object = NormingDB.SelectField("ATWKCALDEMP_SHIFTCODE", "ATWKCALDEMP", "ATWKCALDEMP_EMPID = '" + tblShfEmp.Rows(i)("EMPCODE").ToString.Trim + "' AND CONVERT(DATE, ATWKCALDEMP_WKDATE) = '" & wkDate & "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

                            If IsNothing(shiftCode) Then
                                myRow.Item(Format(curDate, "ddMMyyyy")) = ""
                            Else
                                myRow.Item(Format(curDate, "ddMMyyyy")) = shiftCode.ToString.Trim
                            End If
                        Next

                        tblRoster.Rows.Add(myRow)
                    Next

                End If
            End If

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Private Sub NewTemp()
        Try
            tblRoster = Nothing
            tblRoster = New DataTable
            Dim col1 As New DataColumn
            col1.ColumnName = "EMPCODE"
            col1.Caption = "EMP CODE"
            col1.DataType = GetType(String)
            tblRoster.Columns.Add(col1)
            Dim col2 As New DataColumn
            col2.ColumnName = "EMPNAME"
            col2.Caption = "EMP NAME"
            col2.DataType = GetType(String)
            tblRoster.Columns.Add(col2)
            Dim col3 As New DataColumn
            col3.ColumnName = "JOBTITLE"
            col3.Caption = "JOB TITLE"
            col3.DataType = GetType(String)
            tblRoster.Columns.Add(col3)
            Dim col4 As New DataColumn
            col4.ColumnName = "HIREDAY"
            col4.Caption = "HIRED DAY"
            col4.DataType = GetType(Date)
            tblRoster.Columns.Add(col4)

            Dim k As Integer = DateDiff(DateInterval.Day, fromDate, toDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

            For i As Integer = 0 To k
                Dim myCol As New DataColumn
                myCol.ColumnName = Format(DateAdd(DateInterval.Day, i, dtFrom.EditValue), "ddMMyyyy")
                myCol.Caption = Format(DateAdd(DateInterval.Day, i, dtFrom.EditValue), "dd-MM-yy")
                myCol.DataType = GetType(String)
                tblRoster.Columns.Add(myCol)
            Next

            If lstShiftGroup.EditValue.ToString.Trim = "GAMING" Then
                If lstSup.EditValue.ToString.Trim.Length > 0 Then
                    Dim sqlSelect As String = "HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME', HREMP_SUVISOR2 AS 'SupId'"
                    Dim sqlFrom As String = "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID"
                    Dim sqlWhere As String = "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 AND HREMP_SUVISOR2 = '" + lstSup.EditValue.ToString.Trim + "' ORDER BY HREMP_EMPCODE"

                    tblShfEmp = NormingDB.SelectField(sqlSelect, sqlFrom, sqlWhere, NormingExtension.DataConnector.SelectedReturnType.DataTable)

                    For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                        Dim row As DataRow = tblRoster.NewRow()

                        row.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                        row.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                        Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                        row.Item("JOBTITLE") = emp.JobTitle
                        row.Item("HIREDAY") = emp.HireDate

                        tblRoster.Rows.Add(row)
                    Next
                End If
            Else
                If empCode = "" Then
                    tblShfEmp = NormingDB.SelectField("HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME'", "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID", "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 ORDER BY HREMP_EMPCODE", NormingExtension.DataConnector.SelectedReturnType.DataTable)

                    For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                        Dim row As DataRow = tblRoster.NewRow()

                        row.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                        row.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                        Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                        row.Item("JOBTITLE") = emp.JobTitle
                        row.Item("HIREDAY") = emp.HireDate

                        tblRoster.Rows.Add(row)
                    Next
                Else
                    tblShfEmp = NormingDB.SelectField("HREMP_EMPID AS 'EMPID', HREMP_EMPCODE AS 'EMPCODE', HREMP_FNAME +' '+ HREMP_LNAME AS 'EMPNAME'", "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID", "ATSHIFTGRPE_GRPCODE = '" + selectGrp + "' AND HREMP_STATUS = 1 AND HREMP_EMPCODE = '" + empCode + "' ORDER BY HREMP_EMPCODE", NormingExtension.DataConnector.SelectedReturnType.DataTable)

                    For i As Integer = 0 To tblShfEmp.Rows.Count - 1
                        Dim row As DataRow = tblRoster.NewRow()

                        row.Item("EMPCODE") = tblShfEmp.Rows(i)("EMPCODE").ToString.Trim
                        row.Item("EMPNAME") = tblShfEmp.Rows(i)("EMPNAME").ToString.Trim

                        Dim emp As New Employee(tblShfEmp.Rows(i)("EMPID").ToString.Trim)

                        row.Item("JOBTITLE") = emp.JobTitle
                        row.Item("HIREDAY") = emp.HireDate

                        tblRoster.Rows.Add(row)
                    Next

                End If
            End If

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Private Sub ImportRosterData()
        Try
            Rosters.Clear()

            For i As Integer = 0 To importRoster.Rows.Count - 1

                If importRoster.Rows(i)(0).ToString.Trim.Length > 0 Then
                    Dim empCode As String = importRoster.Rows(i)(0).ToString.Trim
                    Dim empId As String = NormingDB.SelectField("HREMP_EMPID", "HREMP", "HREMP_EMPCODE = '" + empCode + "' ORDER BY HREMP_EMPCODE", DataConnector.SelectedReturnType.SignleValue)

                    Dim emp As New Employee(empId)

                    If emp.ID.Length > 0 And emp.ShiftGroup = selectGrp Then
                        For j As Integer = 4 To importRoster.Columns.Count - 1
                            Dim dateStr() As String = importRoster.Columns(j).Caption.Trim.Split("-")
                            Dim rosterDate As Date = DateSerial(CInt("20" + dateStr(2)), CInt(dateStr(1)), CInt(dateStr(0)))
                            Dim shiftCode As String = importRoster.Rows(i)(j).ToString.Trim
                            Dim allowDate As Date = DateSerial(CInt(Format(Now.Date(), "yyyy")), CInt(Format(Now.Date(), "MM")), 21)

                            If shiftCode.Length > 0 Then
                                If CurrentSession.User.AccessAnyTime = True Then
                                    Dim myRoster As New RosterInfo

                                    myRoster.EmployeeID = empCode
                                    myRoster.DateString = Format(rosterDate, "ddMMyyyy")
                                    myRoster.ShiftCode = shiftCode
                                    myRoster.ShiftGroup = selectGrp
                                    Rosters.Add(myRoster)
                                Else
                                    'If rosterDate >= allowDate Then '-- the orgiginal and working fine, need to return to use after the COVID-19
                                    '    Dim myRoster As New RosterInfo

                                    '    myRoster.EmployeeID = empCode
                                    '    myRoster.DateString = Format(rosterDate, "ddMMyyyy")
                                    '    myRoster.ShiftCode = shiftCode
                                    '    myRoster.ShiftGroup = selectGrp
                                    '    Rosters.Add(myRoster)
                                    'Else
                                    '    MsgBox("You are not allowed to change the roster for the selected date.", MsgBoxStyle.Critical, SoftName)
                                    'End If

                                    Dim myRoster As New RosterInfo

                                    myRoster.EmployeeID = empCode
                                    myRoster.DateString = Format(rosterDate, "ddMMyyyy")
                                    myRoster.ShiftCode = shiftCode
                                    myRoster.ShiftGroup = selectGrp
                                    Rosters.Add(myRoster)
                                End If
                            End If
                        Next
                    End If
                End If
            Next

            If Rosters.Count > 0 Then
                SaveRoster()

                MsgBox("Successfully", MsgBoxStyle.Information, AppName)
            End If

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        SplashScreenManager1.ShowWaitForm()

        If bgCommand = 1 Then '-- Show the Roster and shift code
            ShowRosterAndShift()
        ElseIf bgCommand = 2 Then '-- Import the only empty template
            SplashScreenManager1.SetWaitFormDescription("Creating...")

            NewTemp()
        Else '-- Import the roster
            SplashScreenManager1.SetWaitFormDescription("Importing...")

            ImportRosterData()
        End If
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        btnShowRtAndShift.Enabled = True
        btnNewTemp.Enabled = True
        '--btnImport.Enabled = True

        If bgCommand = 1 Or bgCommand = 2 Then
            gcRoster.DataSource = tblRoster
            gvRoster.Columns.Item("EMPCODE").OptionsColumn.FixedWidth = True
            gvRoster.Columns.Item("EMPCODE").Width = 60
            gvRoster.Columns.Item("EMPCODE").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

            gvRoster.Columns.Item("EMPCODE").AppearanceCell.BackColor = Color.GreenYellow
            gvRoster.Columns.Item("EMPNAME").OptionsColumn.FixedWidth = True
            gvRoster.Columns.Item("EMPNAME").Width = 170
            gvRoster.Columns.Item("EMPNAME").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            gvRoster.Columns.Item("EMPNAME").AppearanceCell.BackColor = Color.GreenYellow
            gvRoster.Columns.Item("JOBTITLE").OptionsColumn.FixedWidth = True
            gvRoster.Columns.Item("JOBTITLE").Width = 200
            gvRoster.Columns.Item("JOBTITLE").AppearanceCell.BackColor = Color.GreenYellow
            gvRoster.Columns.Item("HIREDAY").OptionsColumn.FixedWidth = True
            gvRoster.Columns.Item("HIREDAY").Width = 80
            gvRoster.Columns.Item("HIREDAY").AppearanceCell.BackColor = Color.GreenYellow

            For i As Integer = 4 To gvRoster.Columns.Count - 1
                gvRoster.Columns.Item(i).OptionsColumn.FixedWidth = True
                gvRoster.Columns.Item(i).Width = 60
                gvRoster.Columns.Item(i).AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                gvRoster.Columns.Item(i).AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                gvRoster.Columns.Item(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.VertAlignment.Center
                gvRoster.Columns.Item(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.VertAlignment.Center
            Next

            lblShowEmp.Text = "[ " + gvRoster.RowCount.ToString.Trim() + " ]"
        Else
            Call FrmRoster_Load(Nothing, Nothing)
        End If

    End Sub

    Private Sub gvRoster_DoubleClick(sender As Object, e As EventArgs) Handles gvRoster.DoubleClick
        Try
            If gvRoster.FocusedColumn.FieldName <> "EMPCODE" And gvRoster.FocusedColumn.FieldName <> "EMPNAME" And gvRoster.FocusedColumn.FieldName <> "HIREDAY" And gvRoster.FocusedColumn.FieldName <> "JOBTITLE" And enablEdit = True Then
                Dim rowidx As Integer = gvRoster.FocusedRowHandle
                Dim colidx As Integer = gvRoster.FocusedColumn.VisibleIndex
                Dim rosterdate As Date = GetDate(gvRoster.Columns.Item(colidx).FieldName)
                Dim allowdate As Date = DateAdd(DateInterval.Day, 0 - ConfigurationInfo.RosterEditAllowDay, Now.Date)

                If CurrentSession.User.AccessAnyTime = True Then
                    Dim shift As String = lstShiftCode.EditValue.ToString.Trim
                    Dim k As Integer = lstShiftDay.EditValue

                    For i As Integer = 0 To k - 1
                        gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + i), shift)
                        Dim myroster As New RosterInfo
                        myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                        myroster.ShiftGroup = selectGrp
                        myroster.DateString = gvRoster.Columns.Item(colidx + i).FieldName
                        myroster.ShiftCode = shift
                        Rosters.Add(myroster)
                    Next
                    If swDayOff.EditValue = True Then
                        gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + k), "DO")
                        Dim myroster As New RosterInfo
                        myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                        myroster.ShiftGroup = selectGrp
                        myroster.DateString = gvRoster.Columns.Item(colidx + k).FieldName
                        myroster.ShiftCode = "DO"
                        Rosters.Add(myroster)

                    End If
                Else
                    If rosterdate >= allowdate Then
                        Dim shift As String = lstShiftCode.EditValue.ToString.Trim
                        Dim k As Integer = lstShiftDay.EditValue

                        For i As Integer = 0 To k - 1
                            gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + i), shift)
                            Dim myroster As New RosterInfo
                            myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                            myroster.ShiftGroup = selectGrp
                            myroster.DateString = gvRoster.Columns.Item(colidx + i).FieldName
                            myroster.ShiftCode = shift
                            Rosters.Add(myroster)
                        Next
                        If swDayOff.EditValue = True Then
                            gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + k), "DO")
                            Dim myroster As New RosterInfo
                            myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                            myroster.ShiftGroup = selectGrp
                            myroster.DateString = gvRoster.Columns.Item(colidx + k).FieldName
                            myroster.ShiftCode = "DO"
                            Rosters.Add(myroster)

                        End If
                    Else
                        MsgBox("Cannot change shift code for this day, because over 3 days, please contact to HR", MsgBoxStyle.Critical, AppName)
                    End If
                End If

            End If

            If gvRoster.FocusedColumn.FieldName = "HIREDAY" And CurrentSession.User.RosterAccessLevel > 1 Then
                Dim rowidx As Integer = gvRoster.FocusedRowHandle
                Dim colidx As Integer = gvRoster.FocusedColumn.VisibleIndex
                Dim empid As String = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item("EMPCODE")).ToString.Trim
                Dim hireday As Date = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item("HIREDAY"))

                Dim frm As New frmHireDay
                frm.txtEmpID.EditValue = empid
                frm.dtHire.EditValue = hireday
                frm.ShowDialog()

            End If

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try

        SaveRoster()

    End Sub
    Sub setCellValue()
        Dim rowidx As Integer = gvRoster.FocusedRowHandle
        Dim colidx As Integer = gvRoster.FocusedColumn.VisibleIndex
        Dim rosterdate As Date = GetDate(gvRoster.Columns.Item(colidx).FieldName)
        Dim allowdate As Date = DateAdd(DateInterval.Day, 0 - ConfigurationInfo.RosterEditAllowDay, Now.Date)

        If CurrentSession.User.AccessAnyTime = True Then
            Dim shift As String = lstShiftCode.EditValue.ToString.Trim
            Dim k As Integer = lstShiftDay.EditValue

            For i As Integer = 0 To k - 1
                gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + i), shift)
                Dim myroster As New RosterInfo
                myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                myroster.ShiftGroup = selectGrp
                myroster.DateString = gvRoster.Columns.Item(colidx + i).FieldName
                myroster.ShiftCode = shift
                Rosters.Add(myroster)
            Next

            If swDayOff.EditValue = True Then
                gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + k), "DO")

                Dim myroster As New RosterInfo
                myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                myroster.ShiftGroup = selectGrp
                myroster.DateString = gvRoster.Columns.Item(colidx + k).FieldName
                myroster.ShiftCode = "DO"
                Rosters.Add(myroster)

            End If
        Else
            If rosterdate >= allowdate Then
                Dim shift As String = lstShiftCode.EditValue.ToString.Trim
                Dim k As Integer = lstShiftDay.EditValue

                For i As Integer = 0 To k - 1
                    gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + i), shift)
                    Dim myroster As New RosterInfo
                    myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                    myroster.ShiftGroup = selectGrp
                    myroster.DateString = gvRoster.Columns.Item(colidx + i).FieldName
                    myroster.ShiftCode = shift
                    Rosters.Add(myroster)
                Next
                If swDayOff.EditValue = True Then
                    gvRoster.SetRowCellValue(rowidx, gvRoster.Columns.Item(colidx + k), "DO")
                    Dim myroster As New RosterInfo
                    myroster.EmployeeID = gvRoster.GetRowCellValue(rowidx, gvRoster.Columns.Item(0)).ToString.Trim
                    myroster.ShiftGroup = selectGrp
                    myroster.DateString = gvRoster.Columns.Item(colidx + k).FieldName
                    myroster.ShiftCode = "DO"
                    Rosters.Add(myroster)

                End If
            Else
                MsgBox("You are not allowed to change the roster for the selected date.", MsgBoxStyle.Critical, AppName)
            End If
        End If

    End Sub

    Sub SaveRoster()
        If Rosters.Count > 0 Then
            For i As Integer = 0 To Rosters.Count - 1
                Dim myRoster As RosterInfo = Rosters(i)
                Dim uuId As String = Cryptology.EncryptText(myRoster.ShiftGroup + myRoster.ShiftCode + myRoster.EmployeeID + myRoster.DateString)

                uuId = If(uuId.Length > 36, uuId.Substring(0, 36), uuId)

                Dim currDate As Date = GetDate(myRoster.DateString)
                Dim wkDate As String = Format(currDate, "yyyy-MM-dd")
                Dim wkYear As Integer = CInt(Format(currDate, "yyyy"))
                Dim wkMonth As Integer = CInt(Format(currDate, "MM"))
                Dim wkDay As Integer = CInt(Format(currDate, "dd"))
                Dim shift As New ShiftCode(myRoster.ShiftCode)
                Dim empId As String = myRoster.EmployeeID

                Dim k As Integer = NormingDB.SelectField("COUNT(*)", "ATWKCALDEMP", "ATWKCALDEMP_EMPID = '" + empId + "' AND CONVERT(DATE, ATWKCALDEMP_WKDATE) =  '" & wkDate & "'", DataConnector.SelectedReturnType.SignleValue)

                If k = 0 Then ' No Roster record found then insert it.
                    NormingDB.InitInsertCommand("ATWKCALDEMP")
                    NormingDB.InsertField("ATWKCALDEMP_UUID", uuId)
                    NormingDB.InsertField("ATWKCALDEMP_CREATEDT", Now())
                    NormingDB.InsertField("ATWKCALDEMP_CREATEBY", "")
                    NormingDB.InsertField("ATWKCALDEMP_EMPID", empId)
                    NormingDB.InsertField("ATWKCALDEMP_WKCALID", "DEF")
                    NormingDB.InsertField("ATWKCALDEMP_WKDATE", currDate)
                    NormingDB.InsertField("ATWKCALDEMP_LINENOTES", "")
                    NormingDB.InsertField("ATWKCALDEMP_WKYEAR", wkYear)
                    NormingDB.InsertField("ATWKCALDEMP_WKMONTH", wkMonth)
                    NormingDB.InsertField("ATWKCALDEMP_WKDAY", wkDay)
                    NormingDB.InsertField("ATWKCALDEMP_WORKTYPE", 0)
                    NormingDB.InsertField("ATWKCALDEMP_SHIFTCODE", shift.Code)
                    NormingDB.InsertField("ATWKCALDEMP_FROMHOUR", shift.FromHour)
                    NormingDB.InsertField("ATWKCALDEMP_TOHOUR", shift.ToHour)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMEF", shift.BreakFromTime)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMET", shift.BreakToTime)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMEF2", shift.BreakFromTime)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMET2", shift.BreakToTime)
                    NormingDB.InsertField("ATWKCALDEMP_WORKHOURS", shift.WorkHours)
                    NormingDB.InsertField("ATWKCALDEMP_LSTMNTDT", Now())
                    NormingDB.InsertField("ATWKCALDEMP_LSTMNTBY", "")
                    NormingDB.ExecuteInsertCommand()
                Else
                    NormingDB.InitUpdateCommand("ATWKCALDEMP")
                    NormingDB.SetWhereField("ATWKCALDEMP_EMPID", empId)
                    NormingDB.SetWhereField("CONVERT(DATE, ATWKCALDEMP_WKDATE)", wkDate)
                    NormingDB.SetUpdateField("ATWKCALDEMP_SHIFTCODE", shift.Code)
                    NormingDB.SetUpdateField("ATWKCALDEMP_FROMHOUR", shift.FromHour)
                    NormingDB.SetUpdateField("ATWKCALDEMP_TOHOUR", shift.ToHour)
                    NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMEF", shift.BreakFromTime)
                    NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMET", shift.BreakToTime)
                    NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMEF2", shift.BreakFromTime)
                    NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMET2", shift.BreakToTime)
                    NormingDB.SetUpdateField("ATWKCALDEMP_WORKHOURS", shift.WorkHours)
                    NormingDB.SetUpdateField("ATWKCALDEMP_LSTMNTDT", Now())
                    NormingDB.ExecuteUpdateCommand()
                End If
            Next

            Rosters.Clear()
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        bgCommand = 3 'Import the roster
        importRoster = New DataTable
        selectGrp = lstShiftGroup.EditValue.ToString.Trim
        diaOpen.ShowDialog()

        If IsNothing(diaOpen.FileName) = False And diaOpen.FileName.Length > 0 Then
            Dim cnn As New OleDb.OleDbConnection()

            cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + diaOpen.FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'"
            cnn.Open()

            Dim dap As New OleDb.OleDbDataAdapter("SELECT * FROM [Sheet$]", cnn)

            dap.Fill(importRoster)
            cnn.Close()

            If bgWorker.IsBusy <> True Then
                bgWorker.RunWorkerAsync()
                btnShowRtAndShift.Enabled = False
                btnNewTemp.Enabled = False
                btnImport.Enabled = False
            End If

        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            diaSave.ShowDialog()

            If Not IsNothing(diaSave.FileName) Then
                Dim options As DevExpress.XtraPrinting.XlsxExportOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx()

                options.ExportType = DevExpress.Export.ExportType.WYSIWYG
                gcRoster.ExportToXlsx(diaSave.FileName, options)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub gvRoster_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvRoster.RowCellStyle
        Dim view As GridView = sender
        Dim k As Integer = DateDiff(DateInterval.Day, fromDate, toDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

        If bgCommand = 1 Then
            For i As Integer = 0 To tblShfEmp.Rows.Count - 1

                For j As Integer = 0 To k
                    Dim curDate As Date = DateAdd(DateInterval.Day, j, fromDate)
                    Dim wkDate As String = Format(curDate, "yyyy-MM-dd")
                    Dim wkYear As String = Format(curDate, "yyyy")
                    Dim wkMonth As String = CInt(Format(curDate, "MM")).ToString
                    Dim wkDay As String = CInt(Format(curDate, "dd")).ToString

                    Dim empID As String = gvRoster.GetRowCellValue(e.RowHandle, "EMPCODE").ToString.Trim

                    If (e.Column.FieldName = Format(curDate, "ddMMyyyy").ToString) Then
                        Dim cellValue As String = view.GetRowCellValue(e.RowHandle, view.Columns(Format(curDate, "ddMMyyyy").ToString))
                        If (cellValue = "DO") Then
                            e.Appearance.BackColor = Color.Gray
                            e.Appearance.ForeColor = Color.White
                        ElseIf Not cellValue.StartsWith("C") = True And cellValue.Length > 0 Then
                            e.Appearance.BackColor = Color.LightSeaGreen
                            e.Appearance.ForeColor = Color.White
                        End If
                    End If

                Next
            Next
        End If

    End Sub

    Private Sub lstShiftGroup_EditValueChanged(sender As Object, e As EventArgs) Handles lstShiftGroup.EditValueChanged
        Dim shiftGrp As String = lstShiftGroup.EditValue.ToString.Trim

        If shiftGrp = "GAMING" Then
            lblEmpGrp.Visible = True
            lstSup.Visible = True

            Dim tblSup As DataTable = NormingDB.SelectField("HREMP.HREMP_EMPCODE AS [SupID], HREMP.HREMP_FNAME AS [SupName]", "HREMP", "HREMP.HREMP_EMPCODE IN(SELECT DISTINCT(HREMP.HREMP_SUVISOR2) FROM HREMP WHERE HREMP.HREMP_ORG = 3)", DataConnector.SelectedReturnType.DataTable)

            lstSup.Properties.DataSource = tblSup
            lstSup.EditValue = lstSup.Properties.GetDataSourceValue(lstSup.Properties.ValueMember, 0)
        Else
            lblEmpGrp.Visible = False
            lstSup.Visible = False
            'NormingDB.Close()
        End If

    End Sub


End Class