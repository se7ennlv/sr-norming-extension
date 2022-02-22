Public Class frmDept 
    Dim dep As Department
    Dim tblblnkgrp As DataTable
    Dim tblblnkeml As DataTable
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tblgrp As DataTable = NormingDB.SelectField("ATSHIFTGRP_CODE,ATSHIFTGRP_DESC", "ATSHIFTGRP", "", NormingExtension.DataConnector.SelectedReturnType.DataTable)

        lstShiftGroup.Properties.DataSource = tblgrp
        tblblnkgrp = ExtensionDB.SelectField("GroupCode", "tbl_deptshiftgrp", "0=1", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        tblblnkeml = ExtensionDB.SelectField("Email", "tbl_deptemail", "0=1", NormingExtension.DataConnector.SelectedReturnType.DataTable)
    End Sub

    Private Sub txtDept_EditValueChanged(sender As Object, e As EventArgs) Handles txtDept.EditValueChanged
        If txtDept.EditValue.ToString.Trim.Length > 0 Then
            dep = New Department(txtDept.EditValue.ToString)

            If dep.ID = "" Then
                gcDept.DataSource = tblblnkgrp
                txtDeptName.EditValue = ""
                txtHodId1.EditValue = ""
                txtHodId2.EditValue = ""
                gcDept.DataSource = tblblnkgrp
                gcEmail.DataSource = tblblnkeml
            Else
                txtDeptName.EditValue = dep.Name
                txtHodId1.EditValue = dep.HodEmpID1
                txtHodId2.EditValue = dep.HodEmpID2
                gcDept.DataSource = ExtensionDB.SelectField("GroupCode", "tbl_deptshiftgrp", "DeptID='" + dep.ID + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)
                gcEmail.DataSource = ExtensionDB.SelectField("Email", "tbl_deptemail", "DeptID='" + dep.ID + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dep.ID = "" And txtDeptName.EditValue.ToString.Trim.Length > 0 And txtDept.EditValue.ToString.Trim.Length > 0 Then
            ExtensionDB.InitInsertCommand("tbl_departments")
            ExtensionDB.InsertField("DeptID", txtDept.EditValue.ToString.Trim)
            ExtensionDB.InsertField("DeptName", txtDeptName.EditValue.ToString.Trim)
            ExtensionDB.InsertField("HodID1", txtHodId1.EditValue.ToString)
            ExtensionDB.InsertField("HodID2", txtHodId2.EditValue.ToString)
            ExtensionDB.ExecuteInsertCommand()
            MsgBox("New Department has been created.", MsgBoxStyle.Information, AppName)
        Else
            ExtensionDB.InitUpdateCommand("tbl_departments")
            ExtensionDB.SetWhereField("DeptID", txtDept.EditValue.ToString.Trim)
            ExtensionDB.SetUpdateField("DeptName", txtDeptName.EditValue.ToString.Trim)
            ExtensionDB.SetUpdateField("HodID1", txtHodId1.EditValue.ToString)
            ExtensionDB.SetUpdateField("HodID2", txtHodId2.EditValue.ToString)
            ExtensionDB.ExecuteUpdateCommand()
            MsgBox("New Department has been updated.", MsgBoxStyle.Information, AppName)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dep.ID.Length > 0 Then
            Try
                ExtensionDB.InitInsertCommand("tbl_deptshiftgrp")
                ExtensionDB.InsertField("DeptID", dep.ID)
                ExtensionDB.InsertField("GroupCode", lstShiftGroup.EditValue.ToString.Trim)
                ExtensionDB.ExecuteInsertCommand()
                Call txtDept_EditValueChanged(Nothing, Nothing)
            Catch ex As Exception

            End Try
        Else
            MsgBox("You can only add Shift Group to an existing department.", MsgBoxStyle.Critical, AppName)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dep.ID.Length > 0 Then
            Dim res As MsgBoxResult = MsgBox("Are you sure to remove the shift group from " + dep.Name + "?", MsgBoxStyle.YesNo, AppName)
            If res = MsgBoxResult.Yes Then
                Try
                    Dim grp As String = gvDept.GetRowCellValue(gvDept.FocusedRowHandle, "DeptID").ToString.Trim
                    ExtensionDB.InitDeleteCommand("tbl_deptshiftgrp")
                    ExtensionDB.SetWhereField("DeptID", grp)
                    ExtensionDB.SetWhereField("GroupCode", gvDept.GetRowCellValue(gvDept.FocusedRowHandle, colGroupCode).ToString.Trim)
                    ExtensionDB.ExecuteDeleteCommand()
                Catch ex As Exception
                    MsgBox("Something wrong please contact developer", MsgBoxStyle.Critical, AppName)
                    GetLog(ex.Message)
                End Try

                Call txtDept_EditValueChanged(Nothing, Nothing)
            End If


        End If
    End Sub

    Private Sub txtHodId1_EditValueChanged(sender As Object, e As EventArgs) Handles txtHodId1.EditValueChanged
        Try
            txtHodName1.EditValue = NormingDB.SelectField("HREMP_FNAME + ' ' + HREMP_LNAME", "HREMP", "HREMP_EMPCODE = '" + txtHodId1.EditValue.ToString.Trim + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
        Catch ex As Exception
            txtHodName1.EditValue = ""
        End Try

    End Sub
    Private Sub txtHodId2_EditValueChanged(sender As Object, e As EventArgs) Handles txtHodId2.EditValueChanged
        Try
            txtHodName2.EditValue = NormingDB.SelectField("HREMP_FNAME + ' ' + HREMP_LNAME", "HREMP", "HREMP_EMPCODE = '" + txtHodId2.EditValue.ToString.Trim + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
        Catch ex As Exception
            txtHodName2.EditValue = ""
        End Try

    End Sub

    Private Sub btnAddEmail_Click(sender As Object, e As EventArgs) Handles btnAddEmail.Click
        If dep.ID.Length > 0 Then
            Try
                Dim email As String = txtEmail.EditValue.ToString.Trim
                If email.Contains(".") = True And email.Contains("@") = True Then
                    ExtensionDB.InitInsertCommand("tbl_deptemail")
                    ExtensionDB.InsertField("DeptID", dep.ID)
                    ExtensionDB.InsertField("Email", email)
                    ExtensionDB.ExecuteInsertCommand()

                    Call txtDept_EditValueChanged(Nothing, Nothing)
                Else
                    MsgBox("Incorrect email address.", MsgBoxStyle.Critical, AppName)
                End If
            Catch ex As Exception
                GetLog(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRemoveEmail_Click(sender As Object, e As EventArgs) Handles btnRemoveEmail.Click
        If dep.ID.Length > 0 Then
            Try
                Dim email As String = gvEmail.GetRowCellValue(gvEmail.FocusedRowHandle, "Email").ToString.Trim
                If email.Contains(".") = True And email.Contains("@") = True Then
                    ExtensionDB.InitDeleteCommand("tbl_deptemail")
                    ExtensionDB.SetWhereField("DeptID", dep.ID)
                    ExtensionDB.SetWhereField("Email", email)
                    ExtensionDB.ExecuteDeleteCommand()
                    Call txtDept_EditValueChanged(Nothing, Nothing)
                Else
                    MsgBox("Incorrect email address.", MsgBoxStyle.Critical, AppName)
                End If
            Catch ex As Exception
                MsgBox("Something wrong please contact developer", MsgBoxStyle.Critical, AppName)
                GetLog(ex.Message)
            End Try
        End If
    End Sub
End Class