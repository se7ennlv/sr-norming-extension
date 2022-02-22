Imports System.ComponentModel

Public Class frmHrAttdAppr
    Dim bgCommand As Integer = 0
    Dim tbl As DataTable
    Public Sub RefreshData()
        Call frmHrAttdAppr_Load(Nothing, Nothing)
    End Sub

    Private Sub frmHrAttdAppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        bgWorker = New BackgroundWorker()
        bgCommand = 1

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim i As Integer = gv.SelectedRowsCount - 1

        If i < 0 Then
            MsgBox("Please select an item from the list", MsgBoxStyle.Exclamation, AppName)

            Exit Sub
        Else
            Dim res As MsgBoxResult = MsgBox("Confirm Your Verifying?", MsgBoxStyle.YesNo, AppName)

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
        Dim i As Integer = gv.SelectedRowsCount - 1

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
        tbl = New DataTable
        tbl = CType(ExtensionDB.SelectField("*", "SevenAttdApprList", "CheckInApproveStatus = '2' OR CheckOutApproveStatus = '2' ", NormingExtension.DataConnector.SelectedReturnType.DataTable), DataTable)
    End Sub
    Sub HrAttdApprove()
        Try
            Dim selectedRowHandles As Int32() = gv.GetSelectedRows()

            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(i)

                Dim workDay As Date = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("WorkDay"))
                Dim empID As String = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("EmpID")).ToString.Trim

                If (gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("RqCheckInTime")) IsNot DBNull.Value) Then
                    Dim rqChkInTime As Date = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("RqCheckInTime"))
                End If

                If (gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("RqCheckOutTime")) IsNot DBNull.Value) Then
                    Dim rqChkOutTime As Date = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("RqCheckOutTime"))
                End If

                Dim chkInApprStatus As Boolean = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("CheckInApproveStatus"))
                Dim chkOutApprStatus As Boolean = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("CheckOutApproveStatus"))

                ExtensionDB.InitUpdateCommand("tbl_attendance")
                ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                ExtensionDB.SetWhereField("EmpID", empID)

                If (chkInApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckInApproveStatus", 3)
                End If

                If (chkOutApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckOutApproveStatus", 3)
                End If

                ExtensionDB.SetUpdateField("VerifiedBy", CurrentSession.User.ID)
                ExtensionDB.SetUpdateField("VerifiedAt", Now())

                ExtensionDB.ExecuteUpdateCommand()
            Next

            MsgBox("Verified (" & gv.SelectedRowsCount & ") Items", MsgBoxStyle.Information, AppName)

            Me.RefreshData()
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub
    Sub HrAttdReject()
        Try
            Dim selectedRowHandles As Int32() = gv.GetSelectedRows()

            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(i)

                Dim workDay As Date = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("WorkDay"))
                Dim empID As String = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("EmpID")).ToString.Trim
                Dim chkInApprStatus As Boolean = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("CheckInApproveStatus"))
                Dim chkOutApprStatus As Boolean = gv.GetRowCellValue(selectedRowHandle, gv.Columns.Item("CheckOutApproveStatus"))

                ExtensionDB.InitUpdateCommand("tbl_attendance")
                ExtensionDB.SetWhereField("WorkDay", Format(workDay, "yyyy-MM-dd"))
                ExtensionDB.SetWhereField("EmpID", empID)

                If (chkInApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckInApproveStatus", 5)
                End If

                If (chkOutApprStatus = True) Then
                    ExtensionDB.SetUpdateField("CheckOutApproveStatus", 5)
                End If

                ExtensionDB.SetUpdateField("VerifiedBy", CurrentSession.User.ID)
                ExtensionDB.SetUpdateField("VerifiedAt", Now())

                ExtensionDB.ExecuteUpdateCommand()
            Next

            MsgBox("Rejected (" & gv.SelectedRowsCount & ") Item", MsgBoxStyle.Information, AppName)

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
            SplashScreenManager1.SetWaitFormDescription("Loading...")

            ShowData()
        ElseIf bgCommand = 2 Then
            SplashScreenManager1.SetWaitFormDescription("Working...")

            HrAttdApprove()
        Else
            SplashScreenManager1.SetWaitFormDescription("Working...")

            HrAttdReject()
        End If
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        If bgCommand = 1 Then
            gc.DataSource = tbl
        End If

        lblTotalRecord.Text = "(" & gv.RowCount.ToString.Trim & ")"
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            SaveDia.ShowDialog()
            If Not IsNothing(SaveDia.FileName) Then
                Dim options As DevExpress.XtraPrinting.XlsxExportOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx()
                options.ExportType = DevExpress.Export.ExportType.WYSIWYG
                gc.ExportToXlsx(SaveDia.FileName, options)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

End Class