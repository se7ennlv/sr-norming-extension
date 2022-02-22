Imports System.ComponentModel

Public Class frmHodAppr
    Dim bgCommand As Integer = 0
    Dim tblHodAppr As DataTable

    Public Sub RefreshData()
        Call frmHodAppr_Load(Nothing, Nothing)
    End Sub
    Private Sub frmHodAppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        bgWorker = New BackgroundWorker()

        bgCommand = 1

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If

    End Sub

    Sub ShowData()
        Dim HODId As String = CurrentSession.User.EmpID.ToString.Trim

        tblHodAppr = New DataTable
        tblHodAppr = ExtensionDB.SelectField("*", "SevenAttdApprList", "(CheckInApproveStatus = '1' OR CheckOutApproveStatus = '1') AND (Manager1 = '" + HODId + "' OR Supervisor1 = '" + HODId + "' OR Supervisor2 = '" + HODId + "') ", NormingExtension.DataConnector.SelectedReturnType.DataTable)
    End Sub

    Sub HodApprove()
        Try
            Dim selectedRowHandles As Int32() = gvHodAppr.GetSelectedRows()

            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(i)

                Dim workDay As Date = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("WorkDay"))
                Dim empID As String = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("EmpID")).ToString.Trim

                '--MsgBox(empID + "-" + workDay)

                If (gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("RqCheckInTime")) IsNot DBNull.Value) Then
                    Dim rqChkInTime As Date = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("RqCheckInTime"))
                End If

                If (gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("RqCheckOutTime")) IsNot DBNull.Value) Then
                    Dim rqChkOutTime As Date = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("RqCheckOutTime"))
                End If

                Dim chkInApprStatus As Boolean = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("CheckInApproveStatus"))
                Dim chkOutApprStatus As Boolean = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("CheckOutApproveStatus"))

                ExtensionDB.InitUpdateCommand("tbl_attendance")
                ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                ExtensionDB.SetWhereField("EmpID", empID)

                If (chkInApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckInApproveStatus", 2)
                End If

                If (chkOutApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckOutApproveStatus", 2)
                End If

                ExtensionDB.SetUpdateField("HodActionBy", CurrentSession.User.ID)
                ExtensionDB.SetUpdateField("HodActionAt", Now())

                ExtensionDB.ExecuteUpdateCommand()
            Next

            MsgBox("Approved (" & gvHodAppr.SelectedRowsCount & ") Item.", MsgBoxStyle.Information, AppName)

            ShowData()

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub
    Sub HodReject()
        Try
            Dim selectedRowHandles As Int32() = gvHodAppr.GetSelectedRows()

            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(i)

                Dim workDay As Date = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("WorkDay"))
                Dim empID As String = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("EmpID")).ToString.Trim
                Dim chkInApproveStatus As Boolean = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("CheckInApproveStatus"))
                Dim chkOutApproveStatus As Boolean = gvHodAppr.GetRowCellValue(selectedRowHandle, gvHodAppr.Columns.Item("CheckOutApproveStatus"))

                ExtensionDB.InitUpdateCommand("tbl_attendance")
                ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                ExtensionDB.SetWhereField("EmpID", empID)

                If (chkInApproveStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckInApproveStatus", 5)
                End If

                If (chkOutApproveStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckOutApproveStatus", 5)
                End If

                ExtensionDB.SetUpdateField("HodActionBy", CurrentSession.User.ID)
                ExtensionDB.SetUpdateField("HodActionAt", Now())

                ExtensionDB.ExecuteUpdateCommand()
            Next

            MsgBox("Rejected (" & gvHodAppr.SelectedRowsCount & ") Item.", MsgBoxStyle.Information, AppName)

            ShowData()

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub


    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim i As Integer = gvHodAppr.SelectedRowsCount - 1


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
        Dim i As Integer = gvHodAppr.SelectedRowsCount - 1

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

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        If bgCommand = 1 Then
            SplashScreenManager1.SetWaitFormDescription("Loading...")

            ShowData()
        ElseIf bgCommand = 2 Then
            SplashScreenManager1.SetWaitFormDescription("Working...")
            HodApprove()
        Else
            SplashScreenManager1.SetWaitFormDescription("Working...")
            HodReject()
        End If
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        gcHodAppr.DataSource = tblHodAppr
        lblTotalRecord.Text = "(" + gvHodAppr.RowCount.ToString.Trim + ")"
    End Sub


End Class