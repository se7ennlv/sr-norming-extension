Imports System.ComponentModel

Public Class FrmErrUsed
    Dim tbl As DataTable
    Private Sub FrmErrUsed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgWorker = New BackgroundWorker

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            saveDia.ShowDialog()
            If Not IsNothing(saveDia.FileName) Then
                gvErrUsed.ExportToXlsx(saveDia.FileName)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        Try
            Dim dtFrom As Date = CDate(fromDate.EditValue)
            Dim dtTo As Date = CDate(toDate.EditValue)

            tbl = New DataTable
            tbl = ExtensionDB.SelectField("*", "SevenERRUsed", "(WorkDay BETWEEN '" & Format(dtFrom, "yyyy-MM-dd") & "' AND '" & Format(dtTo, "yyyy-MM-dd") & "')  ", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        Catch ex As Exception
            MsgBox("Something wrong please contact developer", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        gcErrUsed.DataSource = tbl
        lblTotal.Text = "(" + gvErrUsed.RowCount.ToString.Trim + ")"
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub fromDate_EditValueChanged(sender As Object, e As EventArgs) Handles fromDate.EditValueChanged
        Try
            If fromDate.EditValue > toDate.EditValue Then
                toDate.EditValue = CDate(fromDate.EditValue)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub toDate_EditValueChanged(sender As Object, e As EventArgs) Handles toDate.EditValueChanged
        Try
            If toDate.EditValue < fromDate.EditValue Then
                fromDate.EditValue = CDate(toDate.EditValue)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub
End Class