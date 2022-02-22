Imports NormExt.NormingExtension

Public Class FrmFpLog
    Dim tblFpLog As DataTable
    Public empCode As String
    Public wkDate As Date
    Public shiftstart As Date
    Public shiftend As Date

    Private Sub FrmFpLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        bgWorker = New System.ComponentModel.BackgroundWorker

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If

        If CurrentSession.User.ID <> "admin" Then
            btnUpdateIn.Visible = False
            btnUpdateOut.Visible = False
            chkMakeNull.Visible = False
            usedShifTime.Visible = False
        End If

    End Sub
    Sub LoadData()
        Try
            tblFpLog = New DataTable
            'Dim strWhere As String = "EmpID = '" + empId + "' AND CONVERT(DATE, [Date]) = '" + Format(wkDate, "yyyy-MM-dd") + "' AND (Station LIKE '%IN%' OR Station LIKE '%OUT%' OR Station LIKE '%Welcome%') ORDER BY EmpID, [Date], CONVERT(TIME, [Time]) ASC"
            Dim strWhere As String = "EmpID = '" + empCode + "' AND CONVERT(DATE, [Date]) BETWEEN '" + Format(DateAdd(DateInterval.Hour, -4, shiftstart), "yyyy-MM-dd HH:mm:ss tt") + "' AND '" + Format(DateAdd(DateInterval.Hour, 4, shiftend), "yyyy-MM-dd HH:mm:ss tt") + "' AND (Station LIKE '%IN%' OR Station LIKE '%OUT%' OR Station LIKE '%Welcome%') ORDER BY EmpID, CONVERT(DATE, [Date]), CONVERT(TIME, [Time]) ASC"

            tblFpLog = FingerDB.SelectField("*", "RawData", strWhere, DataConnector.SelectedReturnType.DataTable)
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

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

        gcFpLog.DataSource = tblFpLog
    End Sub

    Private Sub btnUpdateIn_Click(sender As Object, e As EventArgs) Handles btnUpdateIn.Click
        Try

            ExtensionDB.InitUpdateCommand("tbl_attendance")
            ExtensionDB.SetWhereField("WorkDay", wkDate.Date.ToString("yyyy-MM-dd"))
            ExtensionDB.SetWhereField("EmpID", empCode)

            If chkMakeNull.Checked = True Then
                ExtensionDB.SetUpdateField("IsCheckIn", 0)
                ExtensionDB.SetUpdateField("CheckInTime", "1900-01-01 00:00:00.000")
            Else
                If usedShifTime.Checked = True Then
                    ExtensionDB.SetUpdateField("IsCheckIn", 1)
                    ExtensionDB.SetUpdateField("CheckInTime", shiftstart)
                Else 'Use the time from the raw data
                    Dim timescan As Date = CDate(gvFpLpog.GetRowCellValue(gvFpLpog.FocusedRowHandle, col4).ToString() + " " + gvFpLpog.GetRowCellValue(gvFpLpog.FocusedRowHandle, col5).ToString())
                    ExtensionDB.SetUpdateField("IsCheckIn", 1)
                    ExtensionDB.SetUpdateField("CheckInTime", timescan)
                End If
            End If
            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("Done", MsgBoxStyle.Information, AppName)
            Me.Dispose()

            frmAttd.LoadData()
        Catch ex As Exception
            MsgBox("Something went wrong, please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateOut_Click(sender As Object, e As EventArgs) Handles btnUpdateOut.Click
        Try

            ExtensionDB.InitUpdateCommand("tbl_attendance")
            ExtensionDB.SetWhereField("WorkDay", wkDate.Date.ToString("yyyy-MM-dd"))
            ExtensionDB.SetWhereField("EmpID", empCode)
            If chkMakeNull.Checked = True Then
                ExtensionDB.SetUpdateField("IsCheckOut", 0)
                ExtensionDB.SetUpdateField("CheckOutTime", "1900-01-01 00:00:00.000")
            Else
                If usedShifTime.Checked = True Then
                    ExtensionDB.SetUpdateField("IsCheckOut", 1)
                    ExtensionDB.SetUpdateField("CheckOutTime", shiftend)
                Else
                    Dim timescan As Date = CDate(gvFpLpog.GetRowCellValue(gvFpLpog.FocusedRowHandle, col4).ToString() + " " + gvFpLpog.GetRowCellValue(gvFpLpog.FocusedRowHandle, col5).ToString())
                    ExtensionDB.SetUpdateField("IsCheckOut", 1)
                    ExtensionDB.SetUpdateField("CheckOutTime", timescan)
                End If

            End If

            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("Done", MsgBoxStyle.Information, AppName)
            Me.Dispose()

            frmAttd.LoadData()
        Catch ex As Exception
            MsgBox("Something went wrong, please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub chkMakeNull_CheckedChanged(sender As Object, e As EventArgs) Handles chkMakeNull.CheckedChanged
        If chkMakeNull.Checked = True Then
            usedShifTime.Checked = False
        End If
    End Sub

    Private Sub usedShifTime_CheckedChanged(sender As Object, e As EventArgs) Handles usedShifTime.CheckedChanged
        If usedShifTime.Checked = True Then
            chkMakeNull.Checked = False
        End If
    End Sub
End Class