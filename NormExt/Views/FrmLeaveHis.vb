Imports NormExt.NormingExtension
Public Class frmLeaveHis
    Dim tblLeave As DataTable
    Public docNum As String

    Private Sub frmLeaveHis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tblLeave = NormingDB.SelectField("*", "[PSA66].[dbo].[VIEW_LvHis]", "([EmpSta] = 1) AND ([EmpID] = '" + FrmLeaveRequest.txtEmpCode.EditValue.ToString.Trim + "')", NormingExtension.DataConnector.SelectedReturnType.DataTable)
            gcLeaveHis.DataSource = tblLeave
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            diaSave.ShowDialog()
            If Not IsNothing(diaSave.FileName) Then
                gcLeaveHis.ExportToXlsx(diaSave.FileName)
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub gvLeaveHis_DoubleClick(sender As Object, e As EventArgs) Handles gvLeaveHis.DoubleClick
        Dim i As Integer = gvLeaveHis.FocusedRowHandle
        docNum = gvLeaveHis.GetRowCellValue(i, gvLeaveHis.Columns.Item("DocNo")).ToString.Trim
        Dim frm As New frmLeaveHisDetail
        frm.docNo = docNum

        frm.ShowDialog()
    End Sub

 
End Class