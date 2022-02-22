Imports System.ComponentModel

Public Class frmErr
    Dim tblShf As DataTable
    Public empId As String = ""

    Private Sub frmErr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--Dim emp As New Employee(txtEmpCode.EditValue.ToString.Trim)
        Dim emp As New Employee(empId)

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Dim shiftCode As String = txtShiftCode.EditValue.ToString.Trim

        If shiftCode.StartsWith("C00") Then
            dtCheckIn.EditValue = DateAdd(DateInterval.Day, -1, dtWorkDay.EditValue)
        End If

        lblApprMail.Text = emp.SupervisorEmail

        If emp.SupervisorEmail.ToString.Trim.Length <= 0 Then
            MsgBox("No approver for (" + txtEmpCode.EditValue.ToString.Trim + ") or HR has not assigned to his/her manager yet, Please contact to HR for checking this case.", MsgBoxStyle.Critical, AppName)

            btnSubmit.Enabled = False
        End If

    End Sub
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub rdoReson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdoReson.SelectedIndexChanged
        Dim resSelected As Object = rdoReson.EditValue

        If resSelected = "4" Then
            txtExplanation.Visible = True
            txtExplanation.Focus()
        Else
            txtExplanation.Visible = False
        End If
    End Sub

    Private Sub chkChgInTime_CheckedChanged(sender As Object, e As EventArgs) Handles chkChgInTime.CheckedChanged
        If chkChgInTime.Checked = True Then
            txtCheckInTime.ReadOnly = False
            txtCheckInTime.Focus()
        Else
            txtCheckInTime.EditValue = "00:00:00"
            txtCheckInTime.ReadOnly = True
        End If
    End Sub

    Private Sub chkChgOutTime_CheckedChanged(sender As Object, e As EventArgs) Handles chkChgOutTime.CheckedChanged
        If chkChgOutTime.Checked = True Then
            txtCheckOutTime.ReadOnly = False
            txtCheckOutTime.Focus()
        Else
            txtCheckOutTime.EditValue = "00:00:00"
            txtCheckOutTime.ReadOnly = True
        End If
    End Sub
    Sub Submition()
        Try
            ExtensionDB.InitUpdateCommand("tbl_attendance")
            ExtensionDB.SetWhereField("WorkDay", Format(dtWorkDay.EditValue, "yyyy-MM-dd"))
            ExtensionDB.SetWhereField("EmpID", txtEmpCode.EditValue.ToString.Trim)

            If chkChgInTime.Checked = True Then
                ExtensionDB.SetUpdateField("CheckInRv", 1)
                ExtensionDB.SetUpdateField("RvCheckInTime", Now)
                ExtensionDB.SetUpdateField("CheckInApproveStatus", 1)

                If chkChgShf.Checked = True Then
                    If lstShift.EditValue.ToString.Trim.StartsWith("C") = False Then
                        ExtensionDB.SetUpdateField("RqCheckInTime", "1900-01-01 00:00:00")
                    Else
                        ExtensionDB.SetUpdateField("RqCheckInTime", Format(dtCheckIn.EditValue, "yyyy-MM-dd") + " " + Format(txtCheckInTime.EditValue, "HH:mm:ss"))
                    End If
                Else
                    ExtensionDB.SetUpdateField("RqCheckInTime", Format(dtCheckIn.EditValue, "yyyy-MM-dd") + " " + Format(txtCheckInTime.EditValue, "HH:mm:ss"))
                End If
            End If

            If chkChgOutTime.Checked = True Then
                ExtensionDB.SetUpdateField("CheckOutRv", 1)
                ExtensionDB.SetUpdateField("RvCheckOutTime", Now)
                ExtensionDB.SetUpdateField("CheckOutApproveStatus", 1)

                If chkChgShf.Checked = True Then
                    If lstShift.EditValue.ToString.Trim.StartsWith("C") = False Then
                        ExtensionDB.SetUpdateField("RqCheckOutTime", "1900-01-01 00:00:00")
                    Else
                        ExtensionDB.SetUpdateField("RqCheckOutTime", Format(dtCheckOut.EditValue, "yyyy-MM-dd") + " " + Format(txtCheckOutTime.EditValue, "HH:mm:ss"))
                    End If
                Else
                    ExtensionDB.SetUpdateField("RqCheckOutTime", Format(dtCheckOut.EditValue, "yyyy-MM-dd") + " " + Format(txtCheckOutTime.EditValue, "HH:mm:ss"))
                End If

            End If

            If chkChgShf.Checked = True Then
                ExtensionDB.SetUpdateField("RqShiftCode", lstShift.EditValue.ToString.Trim)
            End If

            ExtensionDB.SetUpdateField("RvBy", CurrentSession.User.ID)
            ExtensionDB.SetUpdateField("RvReason", rdoReson.EditValue)

            If rdoReson.SelectedIndex = 3 Then
                ExtensionDB.SetUpdateField("Remark", txtExplanation.EditValue.ToString.Trim)
            End If

            ExtensionDB.ExecuteUpdateCommand()

            '-- Dim emp As New Employee(txtEmpCode.EditValue.ToString.Trim)
            Dim emp As New Employee(empId)
            Dim email As String = "Dear HOD,<br>"

            email = email + "Please kindly check and approve the request of attendance record change for the following detail:<br>"
            email = email + "Employee ID: " + emp.ID + "<br>"
            email = email + "Employee Name: " + emp.FirstName + " " + emp.LastName + "<br>"
            email = email + "For Work Day: " + Format(dtWorkDay.EditValue, "yyyy-MM-dd") + "<br>"

            If txtCheckInTime.Enabled = True Then
                email = email + "Check-in Time Changed: " + Format(dtCheckIn.EditValue, "yyyy-MM-dd") + " " + Format(txtCheckInTime.EditValue, "HH:mm:ss") + "<br>"
            End If

            If txtCheckOutTime.Enabled = True Then
                email = email + "Check-out Time Changed: " + Format(dtCheckOut.EditValue, "yyyy-MM-dd") + " " + Format(txtCheckOutTime.EditValue, "HH:mm:ss") + "<br>"
            End If

            email = email + "Regards,<br>"

            If emp.SupervisorEmail.Trim.Length > 0 Then
                MailSender.SendMail("Attendance Record Change Request:" + txtEmpCode.EditValue.ToString.Trim, emp.SupervisorEmail, email)
            End If

            MsgBox("Submitted.", MsgBoxStyle.Information, AppName)

            Me.Close()
            'frmAttd.RefreshData()

        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If chkChgInTime.Checked = False And chkChgOutTime.Checked = False Then
            MsgBox("Please insert check-in or check-out time", MsgBoxStyle.Critical, AppName)
        Else
            If rdoReson.SelectedIndex < 0 Then
                MsgBox("Please select the reason!", MsgBoxStyle.Critical, AppName)

                txtExplanation.Focus()
            Else
                If rdoReson.SelectedIndex = 3 Then
                    If txtExplanation.EditValue = "" Then
                        MsgBox("Please insert comment", MsgBoxStyle.Critical, AppName)
                    Else
                        Dim res As MsgBoxResult = MsgBox("Confirm Your Submission?", MsgBoxStyle.YesNo, AppName)

                        If res = MsgBoxResult.Yes Then
                            bgWorker = New BackgroundWorker

                            If bgWorker.IsBusy <> True Then
                                bgWorker.RunWorkerAsync()
                            End If
                        End If

                    End If

                Else
                    Dim res As MsgBoxResult = MsgBox("Confirm Your Submission?", MsgBoxStyle.YesNo, AppName)

                    If res = MsgBoxResult.Yes Then
                        bgWorker = New BackgroundWorker

                        If bgWorker.IsBusy <> True Then
                            bgWorker.RunWorkerAsync()
                        End If
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub chkChgShf_CheckedChanged(sender As Object, e As EventArgs) Handles chkChgShf.CheckedChanged
        If chkChgShf.Checked = True Then
            lstShift.Visible = True

            tblShf = New DataTable
            tblShf = NormingDB.SelectField("RTRIM(ASSHIFT_SHIFTCODE) AS 'ASSHIFT_SHIFTCODE', RTRIM(ASSHIFT_SHIFTDESC) AS 'ASSHIFT_SHIFTDESC'", "ASSHIFT", "", NormingExtension.DataConnector.SelectedReturnType.DataTable)
            lstShift.Properties.DataSource = tblShf
            lstShift.EditValue = lstShift.Properties.GetDataSourceValue(lstShift.Properties.ValueMember, 0)
        Else
            lstShift.Visible = False
        End If
    End Sub

    Private Sub lstShift_EditValueChanged(sender As Object, e As EventArgs) Handles lstShift.EditValueChanged
        Try
            Dim shiftCode As String = lstShift.EditValue.ToString.Trim
            Dim chkCrossDay As Integer = NormingDB.SelectField("ASSHIFT_CROSSDAY", "ASSHIFT", "ASSHIFT_SHIFTCODE = '" + shiftCode + "' ", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

            If shiftCode.StartsWith("C") = False Then
                chkChgInTime.Checked = True
                chkChgOutTime.Checked = True
                txtCheckInTime.EditValue = "00:00:00"
                txtCheckOutTime.EditValue = "00:00:00"
                dtCheckIn.EditValue = "1900-01-01"
                dtCheckOut.EditValue = "1900-01-01"

                chkChgInTime.Enabled = False
                chkChgOutTime.Enabled = False
                txtCheckInTime.Enabled = False
                txtCheckOutTime.Enabled = False
                '--dtCheckIn.Enabled = False
                '--dtCheckOut.Enabled = False
            Else
                chkChgInTime.Checked = False
                chkChgOutTime.Checked = False
                txtCheckInTime.EditValue = "00:00:00"
                txtCheckOutTime.EditValue = "00:00:00"

                If chkCrossDay = 1 Then
                    dtCheckIn.EditValue = dtWorkDay.EditValue
                    dtCheckOut.EditValue = Format(DateAdd(DateInterval.Day, 1, dtWorkDay.EditValue), "yyyy-MM-dd")
                ElseIf chkCrossDay = 0 And shiftCode.StartsWith("C00") = True Then
                    dtCheckIn.EditValue = Format(DateAdd(DateInterval.Day, -1, dtWorkDay.EditValue), "yyyy-MM-dd")
                    dtCheckOut.EditValue = dtWorkDay.EditValue
                Else
                    dtCheckIn.EditValue = dtWorkDay.EditValue
                    dtCheckOut.EditValue = dtWorkDay.EditValue
                End If

                chkChgInTime.Enabled = True
                chkChgOutTime.Enabled = True
                txtCheckInTime.Enabled = True
                txtCheckOutTime.Enabled = True
                '--dtCheckIn.Enabled = True
                '--dtCheckOut.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub


    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()

            SplashScreenManager1.SetWaitFormDescription("Submitting...")
        End If

        Submition()
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()

    End Sub

End Class