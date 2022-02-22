Imports System.ComponentModel

Public Class FrmWaitHod
    Dim tbl As DataTable

    Private Sub FrmWaitHod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgWorker = New BackgroundWorker
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        Try
            Dim dtFrom As Date = CDate(txtDateFrom.EditValue)
            Dim dtTo As Date = CDate(txtDateTo.EditValue)

            tbl = New DataTable

            Dim selectStr = "WorkDay, EmpID, EmpName, ShiftGroup, ShiftCode, ShiftStart, ShiftEnd, CASE WHEN YEAR(CheckInTime) LIKE '1%' THEN NULL ELSE FORMAT(CheckInTime, 'yyyy-MM-dd HH:mm:ss') END AS [CheckInTime], CASE WHEN YEAR(CheckOutTime) LIKE '1%' THEN NULL ELSE FORMAT(CheckOutTime, 'yyyy-MM-dd HH:mm:ss') END AS [CheckOutTime], CASE WHEN YEAR(RqCheckInTime) LIKE '1%' THEN NULL ELSE FORMAT(RqCheckInTime, 'yyyy-MM-dd HH:mm:ss') END AS [RqCheckInTime], CASE WHEN YEAR(RqCheckOutTime) LIKE '1%' THEN NULL ELSE FORMAT(RqCheckOutTime, 'yyyy-MM-dd HH:mm:ss') END AS [RqCheckOutTime], RqShiftCode, RvBy, CASE CheckInApproveStatus WHEN 1 THEN 'Awaiting HOD Approval' WHEN 2 THEN 'Awaiting HR Attd Verify' WHEN 3 THEN 'Awaiting HR Manager Approval' WHEN 4 THEN 'Approved' WHEN 5 THEN 'Rejected' ELSE '' END AS CheckInApproveStatus, CASE CheckOutApproveStatus WHEN 1 THEN 'Awaiting HOD Approval' WHEN 2 THEN 'Awaiting HR Attd Verify' WHEN 3 THEN 'Awaiting HR Manager Approval' WHEN 4 THEN 'Approved' WHEN 5 THEN 'Rejected' ELSE '' END AS CheckOutApproveStatus "
            Dim fromStr = "tbl_attendance"
            Dim whereStr = "(WorkDay BETWEEN '" & Format(dtFrom, "yyyy-MM-dd") & "' AND '" & Format(dtTo, "yyyy-MM-dd") & "' ) AND (CheckInApproveStatus = '1' OR CheckOutApproveStatus = '1')"

            tbl = ExtensionDB.SelectField(selectStr, fromStr, whereStr, NormingExtension.DataConnector.SelectedReturnType.DataTable)
        Catch ex As Exception
            MsgBox("Something wrong please contact developer", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        gcWaitHoD.DataSource = tbl
        lblTotal.Text = "(" + gvWaitHoD.RowCount.ToString.Trim + ")"
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        bgWorker.RunWorkerAsync()

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            saveDia.ShowDialog()
            If Not IsNothing(saveDia.FileName) Then
                gvWaitHoD.ExportToXlsx(saveDia.FileName)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub
End Class