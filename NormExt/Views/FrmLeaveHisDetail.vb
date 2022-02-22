Public Class frmLeaveHisDetail
    Dim res As DataTable
    Public docNo As String = ""
    Private Sub frmLvHisDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            res = NormingDB.SelectField("*", "PSA66.[dbo].[VIEW_LvDetails]", "DocNo = '" & docNo & "' ORDER BY ProcessDate DESC ", NormingExtension.DataConnector.SelectedReturnType.DataTable)
            gcLvHisDetail.DataSource = res
        Catch ex As Exception
            MsgBox("Something wrong", MsgBoxStyle.Critical, AppName)
            GetLog(ex.Message)
        End Try
    End Sub
End Class