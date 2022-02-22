Public Class frmChangPwd 

   
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            If txtNewPwd.EditValue = txtConfirmNewPwd.EditValue And txtNewPwd.EditValue.ToString.Trim.Length > 0 Then
                CurrentSession.User.ChangePassword(txtOldPwd.EditValue.ToString.Trim, txtNewPwd.EditValue.ToString.Trim)
                Me.Close()
            End If
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
        
    End Sub
End Class