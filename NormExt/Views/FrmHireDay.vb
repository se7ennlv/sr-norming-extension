Public Class frmHireDay 

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        NormingDB.InitUpdateCommand("HREMP")
        NormingDB.SetWhereField("HREMP_EMPCODE", txtEmpID.EditValue.ToString.Trim)
        NormingDB.SetUpdateField("HREMP_HIREDAY", dtHire.EditValue)
        NormingDB.SetUpdateField("HREMP_LHIREDAY", dtHire.EditValue)
        NormingDB.ExecuteUpdateCommand()
        MsgBox("Hired Date is success.", MsgBoxStyle.Information, AppName)
    End Sub
End Class