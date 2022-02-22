Imports System.ComponentModel

Public Class FrmLeaveToDoList
    Dim bgCommand As Integer = 0
    Dim dataSource As DataTable
    Dim approvalComment As Object
    Private Sub FrmLeaveToDoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        startBgWorker(1)
    End Sub


    Sub startBgWorker(ByVal subIndex As Integer)
        bgWorker = New BackgroundWorker()
        bgCommand = subIndex

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If
    End Sub

    Sub setBusy(ByVal message As String)
        SplashScreenManager1.SetWaitFormDescription(message)
    End Sub
    Sub doLoadData()
        Try
            Dim approver As String = CurrentSession.User.EmpID.ToString.Trim
            Dim whereStr = "Approver = '" + approver + "' ORDER BY DocNo "

            dataSource = New DataTable
            dataSource = CType(NormingDB.SelectField("*", "LeaveToDoList", whereStr, NormingExtension.DataConnector.SelectedReturnType.DataTable), DataTable)
        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Sub onApprove()
        Try
            Dim selectedRows As Integer() = gv.GetSelectedRows()

            For i As Integer = 0 To selectedRows.Length - 1
                Dim itemRow As DataRow = gv.GetDataRow(i)

                Dim docNo As String = itemRow("DocNo").ToString
                Dim empId As String = itemRow("EmpID").ToString
                Dim leaveCode As String = itemRow("LeaveCode").ToString
                Dim reqtComnt As String = itemRow("RequesterComment").ToString
                Dim leaveDay As Integer = CInt(itemRow("LeaveDay"))
                Dim fromDate As Date = CDate(itemRow("FromDate"))
                Dim toDate As Date = CDate(itemRow("ToDate"))
                Dim payAmount As Double = CDbl(itemRow("PayAmount"))

                Dim controller As New LeaveApprove
                controller.approvalComments = approvalComment.ToString
                controller.doApprove(docNo, empId, leaveCode, reqtComnt, leaveDay, fromDate, toDate, payAmount)
            Next

            MsgBox("Approved (" & gv.SelectedRowsCount & ") Items", MsgBoxStyle.Information, AppName)
        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Sub onReject()
        Try
            Dim selectedRows As Integer() = gv.GetSelectedRows()

            For i As Integer = 0 To selectedRows.Length - 1
                Dim itemRow As DataRow = gv.GetDataRow(i)

                Dim docNo As String = itemRow("DocNo").ToString
                Dim empId As String = itemRow("EmpID").ToString
                Dim reqtComnt As String = itemRow("RequesterComment").ToString

                Dim controller As New LeaveApprove
                controller.approvalComments = approvalComment.ToString
                controller.doReject(docNo, empId, reqtComnt)
            Next

            MsgBox("Rejected (" & gv.SelectedRowsCount & ") Items", MsgBoxStyle.Information, AppName)
        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim selectedItem As Integer = gv.SelectedRowsCount - 1

        If selectedItem < 0 Then
            MsgBox("Please select at least one item.", MsgBoxStyle.Exclamation, AppName)

            Exit Sub
        Else
            approvalComment = InputBox("Please enter comments and click OK to confirm", AppName, "")

            If approvalComment.ToString.Length > 0 Then
                startBgWorker(2)
            End If
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim selectedItem As Integer = gv.SelectedRowsCount - 1

        If selectedItem < 0 Then
            MsgBox("Please select at least one item.", MsgBoxStyle.Exclamation, AppName)

            Exit Sub
        Else
            approvalComment = InputBox("Please enter comments and click OK to confirm", AppName, "")

            If approvalComment.ToString.Length > 0 Then
                startBgWorker(3)
            End If
        End If
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        If bgCommand = 1 Then
            setBusy("Loading...")
            doLoadData()
        ElseIf bgCommand = 2 Then
            setBusy("Processing...")
            onApprove()
        Else
            setBusy("Processing...")
            onReject()
        End If
    End Sub
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

        If bgCommand = 1 Then
            gc.DataSource = dataSource
        Else
            startBgWorker(1)
        End If
    End Sub
End Class