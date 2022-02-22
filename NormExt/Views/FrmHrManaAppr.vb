Imports System.ComponentModel

Public Class FrmHrManaAppr
    Dim tbl As DataTable
    Dim tblShfTime As DataTable
    Dim bgCommand As Integer = 0
    Dim getOldData As DataTable
    Public Sub RefreshData()
        Call frmHrDirectAppr_Load(Nothing, Nothing)
    End Sub
    Private Sub frmHrDirectAppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        bgWorker = New BackgroundWorker
        bgCommand = 1

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim i As Integer = gvHrDirectAppr.SelectedRowsCount - 1

        If i < 0 Then
            MsgBox("Please select an item from the list", MsgBoxStyle.Exclamation, AppName)

            Exit Sub
        Else
            Dim res As MsgBoxResult = MsgBox("Confirm Your Approval?", MsgBoxStyle.YesNo, AppName)

            If res = MsgBoxResult.Yes Then
                bgWorker = New BackgroundWorker()
                bgCommand = 2

                If bgWorker.IsBusy <> True Then
                    bgWorker.RunWorkerAsync()
                End If
            End If

        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim i As Integer = gvHrDirectAppr.SelectedRowsCount - 1

        If i < 0 Then
            MsgBox("Please select an item from the list", MsgBoxStyle.Exclamation, AppName)
            Exit Sub
        Else
            Dim res As MsgBoxResult = MsgBox("Confirm Your Rejection?", MsgBoxStyle.YesNo, AppName)

            If res = MsgBoxResult.Yes Then
                bgWorker = New BackgroundWorker()
                bgCommand = 3

                If bgWorker.IsBusy <> True Then
                    bgWorker.RunWorkerAsync()
                End If
            End If

        End If

    End Sub
    Sub ShowData()
        Try
            tbl = New DataTable
            tbl = ExtensionDB.SelectField("*", "SevenAttdApprList", "CheckInApproveStatus = '3' OR CheckOutApproveStatus = '3' ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Sub HrManagerApprove()
        Try
            Dim selectedRowHandles As Int32() = gvHrDirectAppr.GetSelectedRows()

            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(i)

                Dim workDay As Date = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("WorkDay"))
                Dim empID As String = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("EmpID")).ToString.Trim
                Dim chkInApprStatus As Boolean = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("CheckInApproveStatus"))
                Dim chkOutApprStatus As Boolean = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("CheckOutApproveStatus"))

                '-- get original data from attendance
                Dim getOldData = New DataTable
                getOldData = ExtensionDB.SelectField("WorkDay, EmpID, ShiftCode, CheckInTime, CheckOutTime", "tbl_attendance", "WorkDay = '" + Format(workDay, "yyyy-MM-dd") + "' AND EmpID = '" + empID + "' ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

                '-- insert attendance data into table history before update
                For j As Integer = 0 To getOldData.Rows.Count - 1
                    ExtensionDB.InitInsertCommand("tbl_attd_history")
                    ExtensionDB.InsertField("WorkDay", getOldData.Rows(j)(0))
                    ExtensionDB.InsertField("EmpID", getOldData.Rows(j)(1))
                    ExtensionDB.InsertField("ShiftCode", getOldData.Rows(j)(2))
                    ExtensionDB.InsertField("CheckInTime", getOldData.Rows(j)(3))
                    ExtensionDB.InsertField("CheckOutTime", getOldData.Rows(j)(4))
                    ExtensionDB.ExecuteInsertCommand()
                Next

                '-- update new requert
                ExtensionDB.InitUpdateCommand("tbl_attendance")
                ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                ExtensionDB.SetWhereField("EmpID", empID)

                If (chkInApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckInApproveStatus", 4)

                    Dim shfCode As String = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqShiftCode")).ToString.Trim

                    If shfCode.ToString.Trim.StartsWith("C") Or shfCode.Length <= 0 Then
                        Dim reqChkInTime As Date

                        If (gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqCheckInTime")) IsNot DBNull.Value) Then
                            reqChkInTime = CDate(gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqCheckInTime")))
                        Else
                            reqChkInTime = CDate("1900-01-01 00:00:00")
                        End If

                        ExtensionDB.SetUpdateField("IsCheckIn", 1)
                        ExtensionDB.SetUpdateField("CheckInTime", reqChkInTime)
                    Else
                        ExtensionDB.SetUpdateField("CheckInTime", "1900-01-01 00:00:00")
                    End If

                End If

                If (chkOutApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckOutApproveStatus", 4)

                    Dim shfCode As String = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqShiftCode")).ToString.Trim

                    If shfCode.ToString.Trim.StartsWith("C") Or shfCode.Length <= 0 Then
                        Dim reqChkOutTime As Date

                        If (gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqCheckOutTime")) IsNot DBNull.Value) Then
                            reqChkOutTime = CDate(gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqCheckOutTime")))
                        Else
                            reqChkOutTime = CDate("1900-01-01 00:00:00")
                        End If

                        ExtensionDB.SetUpdateField("IsCheckOut", 1)
                        ExtensionDB.SetUpdateField("CheckOutTime", reqChkOutTime)
                    Else
                        ExtensionDB.SetUpdateField("CheckOutTime", "1900-01-01 00:00:00")
                    End If

                End If

                Dim chkShfCode As String = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("RqShiftCode")).ToString.Trim

                If chkShfCode.Length > 0 Then
                    tblShfTime = New DataTable
                    tblShfTime = NormingDB.SelectField("ASSHIFT_FROMHOUR, ASSHIFT_TOHOUR", "ASSHIFT", "ASSHIFT_SHIFTCODE = '" + chkShfCode + "' ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

                    For j As Integer = 0 To tblShfTime.Rows.Count - 1
                        ExtensionDB.SetUpdateField("ShiftCode", chkShfCode.ToString.Trim)
                        ExtensionDB.SetUpdateField("ShiftStart", tblShfTime.Rows(j)(0).ToString.Trim)
                        ExtensionDB.SetUpdateField("ShiftEnd", tblShfTime.Rows(j)(1).ToString.Trim)
                    Next

                    UpdateRoster(empID, workDay, chkShfCode)
                End If

                ExtensionDB.SetUpdateField("HrActionBy", CurrentSession.User.ID)
                ExtensionDB.SetUpdateField("HrActionAt", Now())
                ExtensionDB.ExecuteUpdateCommand()
            Next

            MsgBox("Approved (" & gvHrDirectAppr.SelectedRowsCount & ") Item", MsgBoxStyle.Information, AppName)

            Me.RefreshData()

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Sub UpdateRoster(ByVal empId As String, ByRef wkDate As Date, ByVal shfCode As String)
        Try
            Dim strQuery As String = "ASSHIFT_FROMHOUR, ASSHIFT_TOHOUR, ASSHIFT_BREAKTIMEF, ASSHIFT_BREAKTIMET, ASSHIFT_BREAKTIMEF2, ASSHIFT_BREAKTIMET2, ASSHIFT_WORKHOURS"
            Dim shiftInfo As DataTable = NormingDB.SelectField(strQuery, "[dbo].[ASSHIFT]", "ASSHIFT_SHIFTCODE = '" + shfCode + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)

            For i As Integer = 0 To shiftInfo.Rows.Count - 1
                NormingDB.InitUpdateCommand("[PSA66].[dbo].[ATWKCALDEMP]")
                NormingDB.SetWhereField("ATWKCALDEMP_EMPID", empId)
                NormingDB.SetWhereField("CONVERT(DATE, ATWKCALDEMP_WKDATE)", Format(wkDate, "yyyy-MM-dd"))
                NormingDB.SetUpdateField("ATWKCALDEMP_SHIFTCODE", shfCode)
                NormingDB.SetUpdateField("ATWKCALDEMP_FROMHOUR", shiftInfo(i)(0).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_TOHOUR", shiftInfo(i)(1).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMEF", shiftInfo(i)(2).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMET", shiftInfo(i)(3).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMEF2", shiftInfo(i)(4).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_BREAKTIMET2", shiftInfo(i)(5).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_WORKHOURS", shiftInfo(i)(6).ToString.Trim)
                NormingDB.SetUpdateField("ATWKCALDEMP_LSTMNTDT", Now())
                NormingDB.ExecuteUpdateCommand()
            Next
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Sub HrManagerReject()
        Try
            Dim selectedRowHandles As Int32() = gvHrDirectAppr.GetSelectedRows()

            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(i)

                Dim workDay As Date = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("WorkDay"))
                Dim empID As String = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("EmpID")).ToString.Trim
                Dim chkInApprStatus As Boolean = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("CheckInApproveStatus"))
                Dim chkOutApprStatus As Boolean = gvHrDirectAppr.GetRowCellValue(selectedRowHandle, gvHrDirectAppr.Columns.Item("CheckOutApproveStatus"))

                ExtensionDB.InitUpdateCommand("tbl_attendance")
                ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                ExtensionDB.SetWhereField("EmpID", empID)

                If (chkInApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckInApproveStatus", 5)
                End If

                If (chkOutApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckOutApproveStatus", 5)
                End If

                ExtensionDB.SetUpdateField("HrActionBy", CurrentSession.User.ID)
                ExtensionDB.SetUpdateField("HrActionAt", Now())

                ExtensionDB.ExecuteUpdateCommand()
            Next

            MsgBox("Rejected (" & gvHrDirectAppr.SelectedRowsCount & ") Item", MsgBoxStyle.Information, AppName)

            Me.RefreshData()
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        If bgCommand = 1 Then
            ShowData()
        ElseIf bgCommand = 2 Then
            SplashScreenManager1.SetWaitFormDescription("Working...")

            HrManagerApprove()
        Else
            SplashScreenManager1.SetWaitFormDescription("Working...")

            HrManagerReject()
        End If
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        If bgCommand = 1 Then
            gcHrDirectAppr.DataSource = tbl
        End If

        lblTotalRecord.Text = "(" & gvHrDirectAppr.RowCount.ToString.Trim & ")"
    End Sub

End Class