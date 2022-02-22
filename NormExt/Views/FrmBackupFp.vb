Imports System.ComponentModel

Public Class FrmBackupFp
    Dim tblShow As DataTable
    Dim tblBackup As DataTable
    Dim tblRestore As DataTable
    Dim bgCommand As Integer = 0

    Private Sub FrmBackupFp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        bgWorker = New BackgroundWorker
        bgWorker.WorkerSupportsCancellation = True
    End Sub

    Sub ShowData(ByVal getEmpId As String)
        Dim empId As String
        tblShow = New DataTable

        tblShow = FingerDB.SelectField("*", "TempBackupFpData", "WUserID = '" + getEmpId + "' ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

        gcFpBackup.DataSource = tblShow
    End Sub
    Sub BackupFpData(ByVal getEmpId As String)
        Try
            tblBackup = New DataTable

            tblBackup = FingerDB.SelectField("*", "UserLogInfo", "WUserID = '" + getEmpId + "' ", NormingExtension.DataConnector.SelectedReturnType.DataTable)

            Dim j As Integer = tblBackup.Rows.Count - 1

            For i As Integer = 0 To j
                FingerDB.InitInsertCommand("TempBackupFpData")
                FingerDB.InsertField("ULID", tblBackup.Rows(i)("ULID"))
                FingerDB.InsertField("WUserID", tblBackup.Rows(i)("WUserID"))
                FingerDB.InsertField("Years", tblBackup.Rows(i)("Years"))
                FingerDB.InsertField("Months", tblBackup.Rows(i)("Months"))
                FingerDB.InsertField("Days", tblBackup.Rows(i)("Days"))
                FingerDB.InsertField("Actions", tblBackup.Rows(i)("Actions"))
                FingerDB.InsertField("Status", tblBackup.Rows(i)("Status"))
                FingerDB.InsertField("JobCode", tblBackup.Rows(i)("JobCode"))
                FingerDB.InsertField("Hours", tblBackup.Rows(i)("Hours"))
                FingerDB.InsertField("Minutes", tblBackup.Rows(i)("Minutes"))
                FingerDB.InsertField("Seconds", tblBackup.Rows(i)("Seconds"))
                FingerDB.InsertField("DevID", tblBackup.Rows(i)("DevID"))
                FingerDB.ExecuteInsertCommand()
            Next

            MsgBox("Backup data completed.", MsgBoxStyle.Information, AppName)

        Catch ex As Exception
            MsgBox("Something went wrong, please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)

        End Try

    End Sub
    Sub RestoreData(ByVal getEmpId As String)
        Try
            tblRestore = New DataTable
            tblRestore = FingerDB.SelectField("*", "TempBackupFpData", "WUserID = '" + getEmpId + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)

            Dim j As Integer = tblRestore.Rows.Count - 1

            For i As Integer = 0 To j
                FingerDB.InitInsertCommand("UserLogInfo")
                FingerDB.InsertField("ULID", tblRestore.Rows(i)("ULID"))
                FingerDB.InsertField("WUserID", tblRestore.Rows(i)("WUserID"))
                FingerDB.InsertField("Years", tblRestore.Rows(i)("Years"))
                FingerDB.InsertField("Months", tblRestore.Rows(i)("Months"))
                FingerDB.InsertField("Days", tblRestore.Rows(i)("Days"))
                FingerDB.InsertField("Actions", tblRestore.Rows(i)("Actions"))
                FingerDB.InsertField("Status", tblRestore.Rows(i)("Status"))
                FingerDB.InsertField("JobCode", tblRestore.Rows(i)("JobCode"))
                FingerDB.InsertField("Hours", tblRestore.Rows(i)("Hours"))
                FingerDB.InsertField("Minutes", tblRestore.Rows(i)("Minutes"))
                FingerDB.InsertField("Seconds", tblRestore.Rows(i)("Seconds"))
                FingerDB.InsertField("DevID", tblRestore.Rows(i)("DevID"))
                FingerDB.ExecuteInsertCommand()
            Next

            FingerDB.InitDeleteCommand("TempBackupFpData")
            FingerDB.SetWhereField("WUserID", getEmpId)
            FingerDB.ExecuteDeleteCommand()

            MsgBox("Restore data completed", MsgBoxStyle.Information, AppName)
        Catch ex As Exception
            MsgBox("Something went wrong, please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        If bgCommand = 1 Then
            SplashScreenManager1.SetWaitFormDescription("Backing up data...")

            BackupFpData(txtEmpId.EditValue.ToString.Trim)
        Else
            SplashScreenManager1.SetWaitFormDescription("Restoring data...")

            RestoreData(txtEmpId.EditValue.ToString.Trim)
        End If

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        ShowData(txtEmpId.EditValue.ToString.Trim)
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim chkEmp As Integer = FingerDB.SelectField("COUNT(*)", "UserLogInfo", "WUserID = '" + txtEmpId.EditValue.ToString.Trim + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

        If chkEmp <= 0 Then
            MsgBox("Find not found for employee '" + txtEmpId.EditValue.ToString.Trim + "', Please check ID", MsgBoxStyle.Exclamation, AppName)
        Else
            bgCommand = 1

            If txtEmpId.EditValue IsNot Nothing Then
                If bgWorker.IsBusy <> True Then
                    bgWorker.RunWorkerAsync()
                End If
            Else
                MsgBox("Please enter emp id", MsgBoxStyle.Critical, AppName)
            End If
        End If

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        bgCommand = 2

        If txtEmpId.EditValue IsNot Nothing Then
            If bgWorker.IsBusy <> True Then
                bgWorker.RunWorkerAsync()
            End If
        Else
            MsgBox("Please enter emp id", MsgBoxStyle.Critical, AppName)
        End If

    End Sub

End Class