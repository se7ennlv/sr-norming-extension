Imports NormExt.NormingExtension
Imports System.ComponentModel

Public Class FrmLeaveRequest
    Dim myLeave As Leave
    Dim shiftGroup As String = ""
    Dim bgCommand As Integer = 0

    Private Sub FrmLeaveRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        ClearCtrlData()

        Dim deptUnder = CurrentSession.User.DeptUnder
        Dim depts As New DataTable

        Dim selectFields As String = "ATSHIFTGRP_CODE AS GroupCode, ATSHIFTGRP_DESC AS GroupDesc"
        Dim deptId As String = CurrentSession.User.WorkingDepartment.ID

        If CurrentSession.User.ID = "admin" Or deptId = "IT" Or deptId = "HR" Then
            depts = CType(NormingDB.SelectField(selectFields, "ATSHIFTGRP", "", NormingExtension.DataConnector.SelectedReturnType.DataTable), DataTable)
        Else
            Dim where As String = "ATSHIFTGRP_CODE IN (" + deptUnder + ")"
            depts = CType(NormingDB.SelectField(selectFields, "ATSHIFTGRP", where, NormingExtension.DataConnector.SelectedReturnType.DataTable), DataTable)
        End If


        lstDept.Properties.DataSource = depts
        lstDept.EditValue = lstDept.Properties.GetDataSourceValue(lstDept.Properties.ValueMember, 0)

        Dim tbllv As DataTable = NormingDB.SelectField("LVLEAVE_LEAVECODE as 'LVCODE', LVLEAVE_LEAVEDESC as 'LVDESC'", "LVLEAVE", "", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        lstLeaveCode.Properties.DataSource = tbllv

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearCtrlData()

        PanelControl2.Enabled = True
        lstLeaveCode.Enabled = False
    End Sub
    Private Sub ClearCtrlData()
        txtRequestNo.EditValue = "***NEW***"
        txtEmpCode.EditValue = ""
        txtEmpName.EditValue = ""
        dtLvReq.EditValue = Now.Date()
        lstLeaveCode.EditValue = DBNull.Value
        txtAvailable.EditValue = 0
        dtFrom.EditValue = Now.Date()
        dtTo.EditValue = Now.Date()
        txtFor.EditValue = 1
        txtNote.EditValue = ""
        txtComment.EditValue = ""

        dtMinAvali.EditValue = ""
        dtMaxAvali.EditValue = ""
    End Sub

    Private Sub lstDept_EditValueChanged(sender As Object, e As EventArgs) Handles lstDept.EditValueChanged
        Try
            Dim groupCode As String = lstDept.EditValue.ToString.Trim

            Dim selectFields As String = "HREMP_EMPID AS EmpID, HREMP_EMPCODE AS EmpCode, HREMP_FNAME +' '+ HREMP_LNAME AS EmpName, HREMP_NATION AS NationCode, HREMP_GENDER AS Gender"
            Dim from As String = "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID"
            Dim where As String = "ATSHIFTGRPE_GRPCODE IN('" + groupCode + "') AND HREMP_STATUS = 1"

            Dim tblEmp As DataTable = NormingDB.SelectField(selectFields, from, where, NormingExtension.DataConnector.SelectedReturnType.DataTable)
            gcEmp.DataSource = tblEmp

            If lstDept.EditValue.ToString.Trim = "GAMING" Then
                lblEmpUnder.Visible = True
                lstSup.Visible = True

                Dim tblSup As DataTable = NormingDB.SelectField("HREMP.HREMP_EMPCODE As [SupID], HREMP.HREMP_FNAME As [SupName]", "HREMP", "HREMP.HREMP_EMPCODE In(Select DISTINCT(HREMP.HREMP_SUVISOR2) FROM HREMP WHERE HREMP.HREMP_ORG = 3)", DataConnector.SelectedReturnType.DataTable)

                lstSup.Properties.DataSource = tblSup
                lstSup.EditValue = DBNull.Value
                'lstSup.EditValue = lstSup.Properties.GetDataSourceValue(lstSup.Properties.ValueMember, 0)
            Else
                lblEmpUnder.Visible = False
                lstSup.Visible = False

            End If

            lblTotal.Text = "[ " + gvEmp.RowCount.ToString.Trim() + " ]"
        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub gcEmp_DoubleClick(sender As Object, e As EventArgs) Handles gcEmp.DoubleClick
        Try
            Dim i As Integer = gvEmp.FocusedRowHandle
            Dim chkEmp As Integer = gvEmp.RowCount

            If chkEmp <= 0 Then
                MsgBox("No Employee", MsgBoxStyle.Critical, AppName)

                Exit Sub
            Else
                txtEmpCode.EditValue = gvEmp.GetRowCellValue(i, gvEmp.Columns.Item("EmpCode")).ToString.Trim
                txtEmpName.EditValue = gvEmp.GetRowCellValue(i, gvEmp.Columns.Item("EmpName")).ToString.Trim
                lblNationCode.Text = gvEmp.GetRowCellValue(i, gvEmp.Columns.Item("NationCode")).ToString.Trim
                txtGender.EditValue = gvEmp.GetRowCellValue(i, gvEmp.Columns.Item("Gender")).ToString.Trim
                txtEmpID.EditValue = gvEmp.GetRowCellValue(i, gvEmp.Columns.Item("EmpID"))
                dtLvReq.Enabled = True
                dtLvReq.EditValue = Now.Date
                dtFrom.Enabled = True
                dtTo.Enabled = True
                lstLeaveCode.Enabled = True
                lstLeaveCode.EditValue = DBNull.Value
            End If
        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try

        If txtEmpCode.ToString.Trim.Length > 0 Then
            If EmployeeWf(txtEmpCode.EditValue) <> String.Empty Then
                Try
                    approverMail = ApproverMailList("203738")
                    lblApprMail.Text = approverMail
                Catch ex As Exception
                    txtEmpCode.EditValue = ""
                End Try
            Else
                MsgBox("This employee Not yet Set leave workflow, Please contact HR To update", MsgBoxStyle.Critical, AppName)
            End If
        Else
            txtAvailable.EditValue = 0
        End If
    End Sub
    Function EmployeeWf(ByVal empId As String) As String
        Dim wfCode As String = ""

        wfCode = NormingDB.SelectField("HREMPWF_LVWF", "HREMPWF INNER JOIN HREMP On HREMPWF_EMPID = HREMP_EMPID", "HREMP_EMPCODE = '" & empId & "'", DataConnector.SelectedReturnType.SignleValue)

        Return wfCode
    End Function
    Function ApproverMailList(ByVal empId As String) As String
        Dim mailStr As String = approverMail ' entity manager email

        Try
            Dim empWf As String = EmployeeWf(txtEmpCode.EditValue)
            Dim val As String = NormingDB.SelectField("TOP 1  [ASWFDEF_DEFVAL]", "[ASWFDEF]", "[ASWFDEF_DEFID]='LEAVE_" & empWf & "'", DataConnector.SelectedReturnType.SignleValue)
            Dim doc = XDocument.Parse(val)
            Dim product = doc.Root.Elements("task-node").FirstOrDefault(Function(x) x.Attribute("name").Value = "task-node1")
            Dim role As String = product.Attribute("role").Value
            Dim empGrp As String = product.Attribute("empgrp").Value

            If role = "employeeGroup" Then
                Dim tbl As DataTable = NormingDB.SelectField("[HREMPGRPD_EMPID]", "[HREMPGRPD]", "[HREMPGRPD_GRPCODE]='" & empGrp & "'", DataConnector.SelectedReturnType.DataTable)

                If tbl.Rows.Count <> 0 Then
                    mailStr = ""
                    For i As Integer = 0 To tbl.Rows.Count - 1
                        mailStr = mailStr & NormingDB.SelectField("[HREMP_EMAIL] + ';'", "HREMP", "HREMP_EMPID = '" & tbl.Rows(i).Item(0).ToString.Trim & "'", DataConnector.SelectedReturnType.SignleValue)
                        'mailStr = mailStr
                    Next
                    mailStr = mailStr.Remove(mailStr.Length - 1) ' remove last ;
                Else
                    MsgBox("No approver in employee group :" & empGrp, MsgBoxStyle.Critical, AppName)
                    txtAvailable.EditValue = 0
                    txtEmpCode.EditValue = ""
                End If
            ElseIf role = "depManager" Then
                mailStr = approverMail
            Else
                MsgBox("This system support only 'Employee group' 'Entity Manager1'", MsgBoxStyle.Critical)
                txtAvailable.EditValue = 0
            End If

        Catch ex As Exception
            txtAvailable.EditValue = 0
            MsgBox("Please update or change to other Workflow for this employee", MsgBoxStyle.Critical)
            GetLog(ex.Message)
        End Try

        Return mailStr

    End Function
    Private Sub txtEmpID_EditValueChanged(sender As Object, e As EventArgs) Handles txtEmpCode.EditValueChanged
        If txtEmpCode.EditValue.ToString.Trim.Length = 0 Then
            dtLvReq.Enabled = False
            dtFrom.Enabled = False
            dtTo.Enabled = False
        Else
            dtLvReq.Enabled = True
            dtFrom.Enabled = True
            dtTo.Enabled = True
        End If
    End Sub

    Private Sub lstLeaveCode_EditValueChanged(sender As Object, e As EventArgs) Handles lstLeaveCode.EditValueChanged
        Dim chkLvCode = lstLeaveCode.EditValue.ToString.Trim()

        myLeave = New Leave(lstLeaveCode.EditValue.ToString.Trim)
        txtNote.EditValue = myLeave.Note
        dtFrom.EditValue = Now.Date()
        dtTo.EditValue = Now.Date()

        If txtEmpCode.EditValue.ToString.Trim.Length > 0 And chkLvCode = "PH" Then
            txtAvailable.EditValue = 1

            lblPeriod.Visible = True
            dtMinAvali.Visible = True
            dtMaxAvali.Visible = True

            Dim empGender As Integer = CInt(txtGender.EditValue.ToString.Trim)
            Dim tblNation As DataTable

            Dim empId As String = txtEmpID.EditValue.ToString.Trim
            Dim empCode As String = txtEmpCode.EditValue.ToString.Trim
            Dim nationCode As String = lblNationCode.Text.ToString.Trim
            Dim strWhere As String = ""

            If empGender = 0 Then
                strWhere = " IsAvailable = 1 AND LineNotes IN('public', '" + nationCode + "', '0', 'LS') AND PHID NOT IN((SELECT LVLEAVEREQ_PHID FROM LVLEAVEREQ WHERE (LVLEAVEREQ_PHID IS NOT NULL) AND LVLEAVEREQ_EMPID = '" + empId + "' AND YEAR(LVLEAVEREQ_CREATEDT) BETWEEN YEAR(GETUTCDATE()) - 1 AND YEAR(GETUTCDATE()) AND LVLEAVEREQ_LEAVECODE = 'PH' AND LVLEAVEREQ_STATUS NOT IN(3, 4, 5))) AND PHID NOT IN((SELECT PHID FROM ATWKCALDEMP INNER JOIN HREMP ON ATWKCALDEMP_EMPID = HREMP_EMPCODE INNER JOIN PHAvailable ON CONVERT(DATE, ATWKCALDEMP_WKDATE) = NationDay WHERE ATWKCALDEMP_SHIFTCODE = 'PH' AND HREMP_EMPCODE = '" + empId + "'))"
            Else
                strWhere = "IsAvailable = 1 AND  LineNotes IN('public', '" + nationCode + "', 'LS') AND PHID NOT IN((SELECT LVLEAVEREQ_PHID FROM LVLEAVEREQ WHERE (LVLEAVEREQ_PHID IS NOT NULL) AND LVLEAVEREQ_EMPID = '" + empId + "' AND YEAR(LVLEAVEREQ_CREATEDT) BETWEEN YEAR(GETUTCDATE()) - 1 AND YEAR(GETUTCDATE()) AND LVLEAVEREQ_LEAVECODE = 'PH' AND LVLEAVEREQ_STATUS NOT IN(3, 4, 5))) AND PHID NOT IN((SELECT PHID FROM ATWKCALDEMP INNER JOIN HREMP ON ATWKCALDEMP_EMPID = HREMP_EMPCODE INNER JOIN PHAvailable ON CONVERT(DATE, ATWKCALDEMP_WKDATE) = NationDay WHERE ATWKCALDEMP_SHIFTCODE = 'PH' AND HREMP_EMPCODE = '" + empId + "'))"
            End If

            tblNation = NormingDB.SelectField("*", "PHAvailable", strWhere, NormingExtension.DataConnector.SelectedReturnType.DataTable)

            lstNationDay.Visible = True
            lstNationDay.Properties.DataSource = tblNation
            lstNationDay.EditValue = lstNationDay.Properties.GetDataSourceValue(lstNationDay.Properties.ValueMember, -1)
        Else
            txtAvailable.EditValue = myLeave.LeaveAvailableDay(txtEmpCode.EditValue.ToString.Trim)
            lstNationDay.Visible = False
            lblPeriod.Visible = False
            dtMinAvali.Visible = False
            dtMaxAvali.Visible = False
            txtComment.EditValue = ""
            lblHolType.Text = ""
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        bgWorker = New BackgroundWorker()

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtFrom_EditValueChanged(sender As Object, e As EventArgs) Handles dtFrom.EditValueChanged
        Try
            If dtFrom.EditValue > dtTo.EditValue Then
                dtTo.EditValue = CDate(dtFrom.EditValue)
            End If

            If lstLeaveCode.EditValue.ToString.Trim = "PH" Then
                If dtFrom.EditValue > dtMaxAvali.EditValue Then
                    dtFrom.EditValue = dtMaxAvali.EditValue
                    dtTo.EditValue = dtMaxAvali.EditValue
                End If
            End If

            txtFor.EditValue = 1 + DateDiff(DateInterval.Day, dtFrom.EditValue, dtTo.EditValue, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)
        Catch ex As Exception
            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub dtTo_EditValueChanged(sender As Object, e As EventArgs) Handles dtTo.EditValueChanged
        Try
            If dtTo.EditValue < dtFrom.EditValue Then
                dtFrom.EditValue = CDate(dtTo.EditValue)
            End If
            txtFor.EditValue = 1 + DateDiff(DateInterval.Day, dtFrom.EditValue, dtTo.EditValue, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub dtLvReq_EditValueChanged(sender As Object, e As EventArgs) Handles dtLvReq.EditValueChanged
        dtFrom.EditValue = dtLvReq.EditValue
        dtTo.EditValue = dtLvReq.EditValue
    End Sub

    Private Sub txtFor_EditValueChanged(sender As Object, e As EventArgs) Handles txtFor.EditValueChanged
        If txtFor.EditValue > 0 And txtAvailable.EditValue > 0 Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub txtAvailable_EditValueChanged(sender As Object, e As EventArgs) Handles txtAvailable.EditValueChanged
        If txtFor.EditValue > 0 And txtAvailable.EditValue > 0 Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub btnLeaveHis_Click(sender As Object, e As EventArgs) Handles btnLeaveHis.Click
        If txtEmpCode.EditValue.ToString.Trim.Length > 0 Then
            Dim frm As New frmLeaveHis
            frm.ShowDialog()
        Else
            MsgBox("Please select employee!", MsgBoxStyle.Critical, AppName)
        End If

    End Sub

    Private Sub lstNationDay_EditValueChanged(sender As Object, e As EventArgs) Handles lstNationDay.EditValueChanged
        Try
            Dim maxDate As Date = CDate(lstNationDay.EditValue)
            Dim minDate As Date = CDate(lstNationDay.EditValue)
            Dim getDesc As String = lstNationDay.Properties.GetDisplayText(lstNationDay.EditValue)

            If lstNationDay.ItemIndex > -1 Then
                minDate = minDate.AddDays(-30)
                maxDate = maxDate.AddDays(150)

                dtMinAvali.EditValue = Format(minDate, "yyyy-MM-dd")
                dtMaxAvali.EditValue = Format(maxDate, "yyyy-MM-dd")

                txtComment.EditValue = getDesc

                lblHolType.Text = lstNationDay.GetColumnValue("PHID").ToString
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim docNumber As String = txtRequestNo.EditValue.ToString.Trim

        Dim frm As New frmLeaveHisRpt
        frm.txtDocNo.EditValue = docNumber
        frm.Show()
    End Sub

    Private Sub lstEmpGrp_EditValueChanged(sender As Object, e As EventArgs) Handles lstSup.EditValueChanged
        Try
            Dim sqlSelect As String = "HREMP_EMPID AS EmpID, HREMP_EMPCODE AS 'EmpCode', HREMP_NAME as 'EmpName', HREMP_NATION as 'NationCode', HREMP_GENDER as 'Gender', HREMP_SUVISOR1 AS 'Suv1', HREMP_SUVISOR2 AS 'SupID'"
            Dim sqlFrom As String = "ATSHIFTGRPE INNER JOIN HREMP ON ATSHIFTGRPE_EMPID = HREMP_EMPID"
            Dim sqlWhere As String = "ATSHIFTGRPE_GRPCODE IN ('GAMING') AND HREMP_SUVISOR2 = '" + lstSup.EditValue.ToString.Trim + "' AND HREMP_STATUS = 1"
            Dim tblEmp As DataTable = NormingDB.SelectField(sqlSelect, sqlFrom, sqlWhere, NormingExtension.DataConnector.SelectedReturnType.DataTable)

            gcEmp.DataSource = tblEmp

            lblTotal.Text = "[ " + gvEmp.RowCount.ToString.Trim() + " ]"

        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Exclamation, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
            SplashScreenManager1.SetWaitFormDescription("Submiting...")
        End If

        Try
            Dim comment As String = txtComment.EditValue.ToString.Trim.Replace("'", " ")
            Dim reqDate As Date = Now.Date
            Dim fromDate As Date = CDate(dtFrom.EditValue)
            Dim limitFiveDay As Double = DateDiff(DateInterval.Day, reqDate, fromDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)
            Dim chkLvCode As String = lstLeaveCode.EditValue.ToString.Trim()

            If chkLvCode = "PH" Then
                Dim getMinDate As Date
                Dim getMaxDate As Date

                If lstNationDay.ItemIndex <= -1 Then
                    MsgBox("Please select PH", MsgBoxStyle.Critical, AppName)

                    Exit Sub
                Else
                    getMinDate = CDate(dtMinAvali.EditValue)
                    getMaxDate = CDate(dtMaxAvali.EditValue)
                End If

                If Not CDate(dtFrom.EditValue) >= getMinDate And CDate(dtTo.EditValue) <= getMaxDate Then
                    MsgBox("Day requested is without period available", MsgBoxStyle.Critical, AppName)

                    Exit Sub
                End If

                If lblHolType.Text.ToString.Trim.Length <= 0 Or lblHolType.Text.ToString.Trim = "0" Then
                    MsgBox("Holiday Type Cannot be null", MsgBoxStyle.Critical, AppName)

                    Exit Sub
                End If


            ElseIf chkLvCode = "AL" Or chkLvCode = "UL" Then
                '- unused for covit time
                'If CurrentSession.User.AccessAnyTime <> True Then
                '    If limitFiveDay < 5 Then
                '        MsgBox("Not allow for request more then " & limitFiveDay & " days", MsgBoxStyle.Critical, AppName)

                '        Exit Sub
                '    End If
                'End If
                '- end

                If txtAvailable.EditValue = 0 Or txtFor.EditValue = 0 Then
                    MsgBox("Cannot submit leave because day available is zero.", MsgBoxStyle.Critical, AppName)

                    Exit Sub
                End If
                '- unused for covit time
                'If txtFor.EditValue > myLeave.MaximumDays Then
                '    MsgBox("Not allow for request more then " + myLeave.MaximumDays.ToString + " days", MsgBoxStyle.Critical, AppName)

                '    Exit Sub
                'End If
                '- end
            ElseIf chkLvCode = "NDL" Then
                If txtFor.EditValue > 3 Then
                    MsgBox("The maximum of NDL per time request is 3 days", MsgBoxStyle.Critical, AppName)

                    Exit Sub
                End If
            End If

            If txtAvailable.EditValue < txtFor.EditValue Then
                MsgBox("Day request must be less than day available", MsgBoxStyle.Critical, AppName)

                Exit Sub
            End If

            If txtComment.EditValue.ToString.Trim.Length <= 0 Then
                MsgBox("Comment box is not allow null!", MsgBoxStyle.Critical, AppName)

                txtComment.Focus()

                Exit Sub
            End If

            '--Send email to HOD
            Dim req As New LeaveRequest()
            '--req.EmployeeID = txtEmpCode.EditValue.ToString.Trim
            req.EmployeeID = txtEmpID.EditValue.ToString.Trim
            req.RequestDate = CDate(dtLvReq.EditValue)
            req.FromDate = dtFrom.EditValue
            req.ToDate = dtTo.EditValue
            req.LeaveCode = lstLeaveCode.EditValue.ToString.Trim
            req.Note = comment
            req.HolType = lblHolType.Text
            req.LeaveDay = txtFor.EditValue
            req.Submit()

            txtRequestNo.EditValue = req.DocumentNumber

            Dim msgtext As String = " <span style='font-size: 14pt; font-family: 'times new roman', times, serif; color: #003366;'> Norming PSA Leave Request.: <BR>" _
        & " Doc No  : " & req.DocumentNumber & " <BR>" _
        & " Employee : " & req.EmployeeID & "( " & txtEmpName.EditValue.ToString.Trim & " ) <BR>" _
        & " Requested : " & req.RequestDate.ToShortDateString() & "<BR>" _
        & " Period : " & req.LeaveDay.ToString & " day" & If(req.LeaveDay > 1, "s", "") & "<BR>" _
        & " Leave Code : " & req.LeaveCode & "<BR>" _
        & " Note :" & req.Note & "<BR>" _
        & " Run the Norming Extension program to find approve menu "
            Dim emp As New Employee(req.EmployeeID)

            MailSender.SendMail("Leave Request: " + req.DocumentNumber, approverMail, msgtext)

            MsgBox("Your leave request is successfully posted.", MsgBoxStyle.Information, AppName)
            PanelControl2.Enabled = False
            btnSubmit.Enabled = False

            '-- Update the roster
            Dim dateFrom As Date = dtFrom.EditValue
            Dim dateTo As Date = dtTo.EditValue

            Dim k As Integer = DateDiff(DateInterval.Day, dateFrom, dateTo, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

            For i As Integer = 0 To k
                Dim wkDate As Date = DateAdd(DateInterval.Day, i, dtFrom.EditValue)
                Dim wkYear As Integer = CInt(Format(wkDate, "yyyy"))
                Dim wkMonth As Integer = CInt(Format(wkDate, "MM"))
                Dim wkDay As Integer = CInt(Format(wkDate, "dd"))

                Dim chkRt As Integer = NormingDB.SelectField("COUNT(ATWKCALDEMP_SHIFTCODE) AS res", "ATWKCALDEMP", "ATWKCALDEMP_EMPID = '" + txtEmpCode.EditValue + "' AND CONVERT(DATE, ATWKCALDEMP_WKDATE) = '" & Format(wkDate, "yyyy-MM-dd") & "' ", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

                If (chkRt >= 1) Then
                    ExtensionDB.InitUpdateCommand("[PSA66].[dbo].[ATWKCALDEMP]")
                    ExtensionDB.SetWhereField("ATWKCALDEMP_EMPID", txtEmpCode.EditValue)
                    ExtensionDB.SetWhereField("CONVERT(DATE, ATWKCALDEMP_WKDATE)", wkDate)
                    ExtensionDB.SetUpdateField("ATWKCALDEMP_SHIFTCODE", lstLeaveCode.EditValue.ToString.Trim)
                    ExtensionDB.ExecuteUpdateCommand()
                Else
                    Dim uuidStr As String = Cryptology.EncryptText(lstDept.EditValue.ToString.Trim + txtEmpCode.EditValue + dtLvReq.EditValue + Format(wkDate, "dd"))
                    Dim uuId As String

                    If uuidStr.ToString.Length > 36 Then
                        uuId = uuidStr.Substring(0, 36)
                    Else
                        uuId = uuidStr
                    End If

                    Dim shift As New ShiftCode(lstLeaveCode.EditValue.ToString.Trim)

                    NormingDB.InitInsertCommand("[PSA66].[dbo].[ATWKCALDEMP]")
                    NormingDB.InsertField("ATWKCALDEMP_UUID", uuId)
                    NormingDB.InsertField("ATWKCALDEMP_CREATEDT", Now())
                    NormingDB.InsertField("ATWKCALDEMP_CREATEBY", "")
                    NormingDB.InsertField("ATWKCALDEMP_EMPID", txtEmpCode.EditValue)
                    NormingDB.InsertField("ATWKCALDEMP_WKCALID", "DEF")
                    NormingDB.InsertField("ATWKCALDEMP_WKDATE", Format(wkDate, "yyyy-MM-dd"))
                    NormingDB.InsertField("ATWKCALDEMP_LINENOTES", "")
                    NormingDB.InsertField("ATWKCALDEMP_WKYEAR", wkYear)
                    NormingDB.InsertField("ATWKCALDEMP_WKMONTH", wkMonth)
                    NormingDB.InsertField("ATWKCALDEMP_WKDAY", wkDay)
                    NormingDB.InsertField("ATWKCALDEMP_WORKTYPE", 0)
                    NormingDB.InsertField("ATWKCALDEMP_SHIFTCODE", lstLeaveCode.EditValue.ToString.Trim)
                    NormingDB.InsertField("ATWKCALDEMP_FROMHOUR", shift.FromHour)
                    NormingDB.InsertField("ATWKCALDEMP_TOHOUR", shift.ToHour)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMEF", shift.BreakFromTime)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMET", shift.BreakToTime)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMEF2", shift.BreakFromTime)
                    NormingDB.InsertField("ATWKCALDEMP_BREAKTIMET2", shift.BreakToTime)
                    NormingDB.InsertField("ATWKCALDEMP_WORKHOURS", shift.WorkHours)
                    NormingDB.InsertField("ATWKCALDEMP_LSTMNTDT", Now())
                    NormingDB.InsertField("ATWKCALDEMP_LSTMNTBY", "")
                    NormingDB.ExecuteInsertCommand()
                End If
            Next

            MsgBox("Update Shift code on the roster successfully from '" & Format(dateFrom, "yyyy-MM-dd") & "' to '" & Format(dateTo, "yyyy-MM-dd") & "' ", MsgBoxStyle.Information, AppName)

        Catch ex As Exception
            MsgBox("Something went wrong", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        SplashScreenManager1.CloseWaitForm()
    End Sub


End Class