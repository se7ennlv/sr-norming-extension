Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmLeaveHisRpt
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtDocNo.EditValue.ToString.Trim.Length <= 0 Then
                MsgBox("Please input document number!", MsgBoxStyle.Critical, AppName)
            Else
                Dim lvRpt As New ReportDocument()

                lvRpt.Load(Application.StartupPath + "\Reports\LeaveRpt.rpt")
                lvRpt.SetDatabaseLogon("norming", "n0rm1ng")

                CrystalReportViewer1.ReportSource = lvRpt
                CrystalReportViewer1.SelectionFormula = "{LVLEAVEREQ.LVLEAVEREQ_REQID} = '" & txtDocNo.EditValue.ToString.Trim & "' "
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try

    End Sub

End Class