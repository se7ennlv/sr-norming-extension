Imports NormExt.NormingExtension
Public Class frmUser
    Dim theUser As User

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tbldep As DataTable = ExtensionDB.SelectField("rtrim(DeptID) as 'DeptID', DeptName", "tbl_departments", "", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        lstDepartment.Properties.DataSource = tbldep
        txtUserID.EditValue = ""
        txtUname.EditValue = ""
        txtPwd.EditValue = ""
        txtEmail.EditValue = ""
        txtPhone.EditValue = ""
        lstDepartment.EditValue = Nothing
        comboPrvRoster.SelectedIndex = 0
        comboPrvLeave.SelectedIndex = 0
        comboPrvAttd.SelectedIndex = 0
        comboPrvHod.SelectedIndex = 0
        comboHrAttdApprLevel.SelectedIndex = 0
        comboPrvHrDirect.SelectedIndex = 0
        comboPrvAdminRpt.SelectedIndex = 0
        lstRosterAccess.SelectedIndex = 0
        lstLeaveAccess.SelectedIndex = 0
        lstAttdAccess.SelectedIndex = 0

        swAnyTime.EditValue = False
    End Sub

    Private Sub txtUserID_EditValueChanged(sender As Object, e As EventArgs) Handles txtUserID.EditValueChanged

        If txtUserID.EditValue.ToString.Trim.Length > 0 Then
            theUser = New User(txtUserID.EditValue.ToString.Trim)
            Dim empId As String

            Try
                empId = NormingDB.SelectField("HREMP_EMPID", "HREMP", "HREMP_EMPCODE = '" + txtUserID.EditValue.ToString.Trim + "' ", DataConnector.SelectedReturnType.SignleValue).ToString
            Catch ex As Exception
                empId = ""
            End Try

            txtEmpId.EditValue = empId

            If theUser.ID.Length > 0 Then
                txtUname.EditValue = theUser.Name
                txtPwd.EditValue = Cryptology.DecryptText(theUser.Password)
                txtEmail.EditValue = theUser.EmailAddress
                txtPhone.EditValue = theUser.PhoneNumber

                'lstRosterAccess.SelectedIndex = theUser.RosterAccess
                'lstLeaveAccess.SelectedIndex = theUser.LeaveAccess
                'lstAttdAccess.SelectedIndex = theUser.AttendaceAccess


                lstRosterAccess.SelectedIndex = theUser.RosterAccess
                lstLeaveAccess.SelectedIndex = theUser.LeaveAccess
                lstAttdAccess.SelectedIndex = theUser.AttendaceAccess


                lstDepartment.EditValue = theUser.WorkingDepartment.ID
                comboPrvRoster.SelectedIndex = theUser.RosterAccessLevel
                comboPrvLeave.SelectedIndex = theUser.LeaveAccessLevel
                comboPrvAttd.SelectedIndex = theUser.tbl_attendanceAccessLevel
                comboPrvHod.SelectedIndex = theUser.HodApprLevel
                comboPrvHrDirect.SelectedIndex = theUser.HrDirectApprLevel
                comboHrAttdApprLevel.SelectedIndex = theUser.HrAttdApprLevel
                comboPrvAdminRpt.SelectedIndex = theUser.AccessAdminReport
                swAnyTime.EditValue = theUser.AccessAnyTime
            Else
                ClearCtrl()
            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If theUser.ID.Length = 0 And txtUserID.EditValue.ToString.Trim.Length > 0 Then
                ExtensionDB.InitInsertCommand("tbl_users")
                ExtensionDB.InsertField("UserID", txtUserID.EditValue.ToString.Trim)
                ExtensionDB.InsertField("EmpID", txtEmpId.EditValue.ToString.Trim)
                ExtensionDB.InsertField("Username", txtUname.EditValue.ToString.Trim)
                ExtensionDB.InsertField("UserPwd", Cryptology.EncryptText(txtPwd.EditValue.ToString.Trim))
                ExtensionDB.InsertField("UserEmail", txtEmail.EditValue.ToString.Trim)
                ExtensionDB.InsertField("UserPhone", txtPhone.EditValue.ToString.Trim)
                ExtensionDB.InsertField("UserDept", lstDepartment.EditValue.ToString.Trim)
                ExtensionDB.InsertField("PrvRoster", comboPrvRoster.SelectedIndex)
                ExtensionDB.InsertField("PrvLeave", comboPrvLeave.SelectedIndex)
                ExtensionDB.InsertField("PrvAttd", comboPrvAttd.SelectedIndex)
                ExtensionDB.InsertField("PrvHodAppr", comboPrvHod.SelectedIndex)
                ExtensionDB.InsertField("PrvHrAttdAppr", comboHrAttdApprLevel.SelectedIndex)
                ExtensionDB.InsertField("PrvHrDirectAppr", comboPrvHrDirect.SelectedIndex)
                ExtensionDB.InsertField("PrvAdminReport", comboPrvAdminRpt.SelectedIndex)
                ExtensionDB.InsertField("RosterAccess", lstRosterAccess.SelectedIndex)
                ExtensionDB.InsertField("LeaveAccess", lstLeaveAccess.SelectedIndex)
                ExtensionDB.InsertField("AttdAccess", lstAttdAccess.SelectedIndex)
                ExtensionDB.InsertField("AccessAnyTime", swAnyTime.EditValue)
                ExtensionDB.ExecuteInsertCommand()

                MsgBox("User has been created.", MsgBoxStyle.Information, AppName)

                ClearCtrl()
            Else
                ExtensionDB.InitUpdateCommand("tbl_users")
                ExtensionDB.SetWhereField("UserID", txtUserID.EditValue.ToString.Trim)
                ExtensionDB.SetUpdateField("EmpID", txtEmpId.EditValue.ToString.Trim)
                ExtensionDB.SetUpdateField("Username", txtUname.EditValue.ToString.Trim)
                ExtensionDB.SetUpdateField("UserPwd", Cryptology.EncryptText(txtPwd.EditValue.ToString.Trim))
                ExtensionDB.SetUpdateField("UserEmail", txtEmail.EditValue.ToString.Trim)
                ExtensionDB.SetUpdateField("UserPhone", txtPhone.EditValue.ToString.Trim)
                ExtensionDB.SetUpdateField("UserDept", lstDepartment.EditValue.ToString.Trim)
                ExtensionDB.SetUpdateField("PrvRoster", comboPrvRoster.SelectedIndex)
                ExtensionDB.SetUpdateField("PrvLeave", comboPrvLeave.SelectedIndex)
                ExtensionDB.SetUpdateField("PrvAttd", comboPrvAttd.SelectedIndex)
                ExtensionDB.SetUpdateField("PrvHodAppr", comboPrvHod.SelectedIndex)
                ExtensionDB.SetUpdateField("PrvHrAttdAppr", comboHrAttdApprLevel.SelectedIndex)
                ExtensionDB.SetUpdateField("PrvHrDirectAppr", comboPrvHrDirect.SelectedIndex)
                ExtensionDB.SetUpdateField("PrvAdminReport", comboPrvAdminRpt.SelectedIndex)
                ExtensionDB.SetUpdateField("RosterAccess", lstRosterAccess.SelectedIndex)
                ExtensionDB.SetUpdateField("LeaveAccess", lstLeaveAccess.SelectedIndex)
                ExtensionDB.SetUpdateField("AttdAccess", lstAttdAccess.SelectedIndex)
                ExtensionDB.SetUpdateField("AccessAnyTime", swAnyTime.EditValue)
                ExtensionDB.ExecuteUpdateCommand()

                MsgBox("User has been updated.", MsgBoxStyle.Information, AppName)

                ClearCtrl()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

            GetLog(ex.Message)
        End Try
    End Sub

    Sub ClearCtrl()
        txtUname.EditValue = ""
        '--txtEmpId.EditValue = ""
        txtPwd.EditValue = ""
        txtEmail.EditValue = ""
        txtPhone.EditValue = ""
        lstDepartment.EditValue = Nothing
        comboPrvRoster.SelectedIndex = 0
        comboPrvLeave.SelectedIndex = 0
        comboPrvAttd.SelectedIndex = 0
        comboPrvHod.SelectedIndex = 0
        comboHrAttdApprLevel.SelectedIndex = 0
        comboPrvHrDirect.SelectedIndex = 0
        comboPrvAdminRpt.SelectedIndex = 0
        lstRosterAccess.SelectedIndex = 0
        lstLeaveAccess.SelectedIndex = 0
        lstAttdAccess.SelectedIndex = 0
        swAnyTime.EditValue = False
    End Sub

    Private Sub comboPrvRoster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPrvRoster.SelectedIndexChanged
        lstRosterAccess.Enabled = If(comboPrvRoster.SelectedIndex > 0, True, False)
        'lstRosterAccess.SelectedIndex = 0
        'swAnyTime.EditValue = False
    End Sub

    Private Sub comboPrvLeave_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPrvLeave.SelectedIndexChanged
        lstLeaveAccess.Enabled = If(comboPrvLeave.SelectedIndex > 0, True, False)
        'lstLeaveAccess.SelectedIndex = 0
    End Sub

    Private Sub comboPrvAttd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPrvAttd.SelectedIndexChanged
        lstAttdAccess.Enabled = If(comboPrvAttd.SelectedIndex > 0, True, False)
        'lstAttdAccess.SelectedIndex = 0
    End Sub

End Class