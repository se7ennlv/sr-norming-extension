Imports NormExt.NormingExtension

Public Class FrmImportAttdRecord
    Dim fromDate As Date
    Dim toDate As Date
    Dim totalDate As Integer
    Dim totalEmp As Integer
    Dim nextDate As Integer
    Dim nextEmp As Integer
    Dim dateStat As String
    Dim empStat As String
    Dim shift As New DataTable

    Private Sub FrmImportAttdRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deFrom.EditValue = Now.Date
        deTo.EditValue = Now.Date
        LabelControl3.Text = ""
        LabelControl4.Text = ""
        shift = NormingDB.SelectField("*", "ASSHIFT", "", DataConnector.SelectedReturnType.DataTable)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        btnImport.Enabled = False
        deFrom.Enabled = False
        deTo.Enabled = False
        Timer1.Enabled = True
        fromDate = CDate(deFrom.EditValue)
        toDate = CDate(deTo.EditValue)

        bgWorker.RunWorkerAsync()
    End Sub

    Function ShiftStartTime(ByVal ShiftCode As String, ByVal Workdate As Date) As DateTime
        Dim valDate As DateTime

        Dim tblShift As DataTable = NormingDB.SelectField("*", "ASSHIFT", "ASSHIFT_SHIFTCODE='" + ShiftCode + "'", DataConnector.SelectedReturnType.DataTable)
        valDate = CDate(Format(Workdate, "yyyy-MM-dd") + " " + tblShift.Rows(0)("ASSHIFT_FROMHOUR").ToString.Trim() + ":00.000")

        Return valDate
    End Function

    Function ShiftEndTime(ByVal ShiftCode As String, ByVal Workdate As Date) As DateTime
        Dim valDate As DateTime

        Dim tblShift As DataTable = NormingDB.SelectField("*", "ASSHIFT", "ASSHIFT_SHIFTCODE='" + ShiftCode + "'", DataConnector.SelectedReturnType.DataTable)
        Dim newWorkDate As Date
        If tblShift.Rows(0)("ASSHIFT_CROSSDAY") = 0 Then
            newWorkDate = Workdate
        Else
            newWorkDate = DateAdd(DateInterval.Day, 1, Workdate)
        End If

        valDate = CDate(Format(newWorkDate, "yyyy-MM-dd") + " " + tblShift.Rows(0)("ASSHIFT_TOHOUR").ToString.Trim() + ":00.000")


        Return valDate
    End Function

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Try
            totalDate = CInt(DateDiff(DateInterval.Day, fromDate, toDate) + 1)
            dateStat = "Collecting data......"
            empStat = "Collecting data......"

            Dim tblAttendance As DataTable = ExtensionDB.SelectField("*", "tbl_attendance", "WorkDay between '" + fromDate.ToString("yyyy-MM-dd") + "' and '" + toDate.ToString("yyyy-MM-dd") + "' and IsImport=0 and ShiftCode like 'C%' or ShiftCode='AB' ", DataConnector.SelectedReturnType.DataTable)
            Dim MasterEmployee As DataTable = NormingDB.SelectField("*", "HREMP", "HREMP_STATUS = 1 or HREMP_TERMDAY >='" + toDate.Date.ToString("yyyy-MM-dd 00:00:00.000") + "'", DataConnector.SelectedReturnType.DataTable)
            '--Dim ShiftGroup As DataTable = NormingDB.SelectField("*", "ATSHIFTGRPE", "", DataConnector.SelectedReturnType.DataTable)
            Dim ShiftGroup As DataTable = NormingDB.SelectField("*", "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID", "", DataConnector.SelectedReturnType.DataTable)
            Dim ExemptedEmp As DataTable = ExtensionDB.SelectField("*", "tbl_exempted", "", DataConnector.SelectedReturnType.DataTable)

            For j As Integer = 0 To DateDiff(DateInterval.Day, fromDate, toDate)
                dateStat = "Processing Data for: " + DateAdd(DateInterval.Day, j, fromDate).Date.ToString("dd-MMM-yyyy")
                nextDate = j + 1

                Dim tblAtt As DataRow() = tblAttendance.Select("WorkDay = '" + DateAdd(DateInterval.Day, j, fromDate).Date.ToString("yyyy-MM-dd") + "'")

                totalEmp = tblAtt.Count

                For i As Integer = 0 To tblAtt.Count - 1

                    Dim workDay As Date = tblAtt(i)("WorkDay")
                    Dim empId As String = tblAtt(i)("EmpID").ToString.Trim()
                    Dim validEmp As Integer = MasterEmployee.Select("HREMP_EMPCODE = '" + empId + "'").Count
                    Dim exempted As Integer = ExemptedEmp.Select("ExemID='" + empId + "'").Count

                    nextEmp = i + 1
                    empStat = "Importing Attendance for : " + empId + " - " + tblAtt(i)("EmpName").ToString.Trim()

                    If exempted = 0 And validEmp = 1 Then
                        'Dim entity As Integer = NormingDB.SelectField("HREMP_ORG", "HREMP", "HREMP_EMPCODE='" + empid + "'", DataConnector.SelectedReturnType.SignleValue)
                        Dim entity As Integer = MasterEmployee.Select("HREMP_EMPCODE = '" + empId + "'")(0)("HREMP_ORG")
                        'Dim shiftgrp As String = NormingDB.SelectField("ATSHIFTGRPE_GRPCODE", "ATSHIFTGRPE", "ATSHIFTGRPE_EMPID='" + empid + "'", DataConnector.SelectedReturnType.SignleValue).ToString.Trim()
                        '--Dim shiftgrp As String = ShiftGroup.Select("ATSHIFTGRPE_EMPID = '" + empid + "'")(0)("ATSHIFTGRPE_GRPCODE").ToString.Trim()
                        Dim shiftGrp As String = ShiftGroup.Select("HREMP_EMPCODE = '" + empId + "'")(0)("ATSHIFTGRPE_GRPCODE").ToString.Trim()
                        Dim loginTime As DateTime
                        Dim logoutTime As DateTime
                        Dim shiftCode As String = tblAtt(i)("ShiftCode").ToString.Trim()
                        Dim shiftStart As DateTime = ShiftStartTime(shiftCode, workDay)
                        Dim shiftEnd As DateTime = ShiftEndTime(shiftCode, workDay)

                        If shiftCode = "AB" Then
                            loginTime = shiftStart
                            logoutTime = shiftEnd
                        Else
                            If tblAtt(i)("IsCheckIn") = True And tblAtt(i)("IsCheckOut") = True Then 'Employee has fingerprint in and out.
                                loginTime = CDate(tblAtt(i)("CheckInTime"))
                                logoutTime = CDate(tblAtt(i)("CheckOutTime"))
                            ElseIf tblAtt(i)("IsCheckIn") = True And tblAtt(i)("IsCheckOut") = False Then 'Employee has fingerprint in but not out.
                                loginTime = CDate(tblAtt(i)("CheckInTime"))
                                logoutTime = DateAdd(DateInterval.Minute, -30, shiftEnd)
                            ElseIf tblAtt(i)("IsCheckIn") = False And tblAtt(i)("IsCheckOut") = True Then 'Employee has fingerprint out but not in.

                                loginTime = DateAdd(DateInterval.Minute, 30, shiftStart)
                                logoutTime = CDate(tblAtt(i)("CheckOutTime"))

                            Else 'Employee didn't fingerprint at all.
                                loginTime = DateAdd(DateInterval.Minute, 30, shiftStart)
                                logoutTime = DateAdd(DateInterval.Minute, -30, shiftEnd)
                            End If
                        End If


                        '***Import the Check-In Reocord
                        NormingDB.InitInsertCommand("ATBD")
                        NormingDB.InsertField("ATBD_UUID", empId + "-" + Format(workDay, "yyyyyMMdd") + "-In")
                        NormingDB.InsertField("ATBD_CREATEBY", "ADMIN")
                        NormingDB.InsertField("ATBD_EMPID", empId)
                        NormingDB.InsertField("ATBD_DATE", loginTime.ToString("yyyy-MM-dd HH:mm:00.000"))
                        NormingDB.InsertField("ATBD_TYPE", 0) '0= Login, 1=Logout
                        NormingDB.InsertField("ATBD_TIME", loginTime.ToString("HH:mm"))
                        NormingDB.InsertField("ATBD_COMMENTS", "Check-In record for " + workDay.ToString("yyyy-MM-dd"))
                        NormingDB.InsertField("ATBD_BYUSER", "ADMIN")
                        NormingDB.InsertField("ATBD_DATAFROM", 1)
                        NormingDB.InsertField("ATBD_ENTITY", entity)
                        NormingDB.InsertField("ATBD_SHIFTGRP", shiftGrp)
                        NormingDB.ExecuteInsertCommand()

                        '***Import the Check-Out Reocord
                        NormingDB.InitInsertCommand("ATBD")
                        NormingDB.InsertField("ATBD_UUID", empId + "-" + Format(workDay, "yyyyyMMdd") + "-Out")
                        NormingDB.InsertField("ATBD_CREATEBY", "ADMIN")
                        NormingDB.InsertField("ATBD_EMPID", empId)
                        NormingDB.InsertField("ATBD_DATE", logoutTime.ToString("yyyy-MM-dd HH:mm:00.000"))
                        NormingDB.InsertField("ATBD_TYPE", 1) '0= Login, 1=Logout
                        NormingDB.InsertField("ATBD_TIME", logoutTime.ToString("HH:mm"))
                        NormingDB.InsertField("ATBD_COMMENTS", "Check-Out record for " + workDay.ToString("yyyy-MM-dd"))
                        NormingDB.InsertField("ATBD_BYUSER", "ADMIN")
                        NormingDB.InsertField("ATBD_DATAFROM", 1)
                        NormingDB.InsertField("ATBD_ENTITY", entity)
                        NormingDB.InsertField("ATBD_SHIFTGRP", shiftGrp)
                        NormingDB.ExecuteInsertCommand()

                    End If

                    ExtensionDB.InitUpdateCommand("tbl_attendance")
                    ExtensionDB.SetWhereField("WorkDay", DateAdd(DateInterval.Day, j, fromDate).Date.ToString("yyyy-MM-dd"))
                    ExtensionDB.SetWhereField("EmpID", empId)
                    ExtensionDB.SetUpdateField("IsImport", True)
                    ExtensionDB.ExecuteUpdateCommand()

                Next
            Next

            MsgBox("Import is completed.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        Timer1.Enabled = False
        progBar1.Value = 0
        progBar2.Value = 0
        nextDate = 0
        nextEmp = 0
        LabelControl3.Text = ""
        LabelControl4.Text = ""
        totalDate = 0
        totalEmp = 0
        btnImport.Enabled = True
        deFrom.Enabled = True
        deTo.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            progBar1.Maximum = totalDate
            progBar2.Maximum = totalEmp
            progBar1.Value = nextDate
            progBar2.Value = nextEmp

            LabelControl3.Text = dateStat
            LabelControl4.Text = empStat
        Catch ex As Exception
            MsgBox(ex.Message)
            GetLog(ex.Message)
        End Try
    End Sub
End Class