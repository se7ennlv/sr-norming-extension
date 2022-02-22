Public Class LeaveApprove
    Public approvalComments As String
    Dim nextApprovers As DataTable

    Sub initNextApprovers()
        nextApprovers = New DataTable
        Dim whereCondition As String = ""


        If CurrentSession.User.RoleID = 2 Then
            whereCondition = "HR_ATTENDANCE"
        ElseIf CurrentSession.User.RoleID = 3 Then
            whereCondition = "HR_MANAGER"
        End If

        nextApprovers = CType(NormingDB.SelectField("HREMPGRPD_EMPID", "HREMPGRPD", "HREMPGRPD_GRPCODE = '" + whereCondition + "' ", NormingExtension.DataConnector.SelectedReturnType.DataTable), DataTable)
    End Sub

    Sub insertWorkFlowStep(ByVal docNo As String, ByVal submitBy As String, ByVal approverId As String, ByVal action As Integer, ByVal stepMsg As String, ByVal memo As String, ByVal reqtComnt As String)
        Dim userId As String = CurrentSession.User.ID.ToString
        Dim rowId As String = (Guid.NewGuid().ToString()).ToUpper
        Dim currentTime As String = Now.ToString("hh:mm:ss")

        NormingDB.InitInsertCommand("ASWFSTEP")
        NormingDB.InsertField("ASWFSTEP_LINEID", rowId)
        NormingDB.InsertField("ASWFSTEP_CREATEBY", userId)
        NormingDB.InsertField("ASWFSTEP_DOCID", docNo)
        NormingDB.InsertField("ASWFSTEP_SUBMITBY", submitBy)
        NormingDB.InsertField("ASWFSTEP_BUSID", "LEAVE")
        NormingDB.InsertField("ASWFSTEP_USERID", userId)
        NormingDB.InsertField("ASWFSTEP_ACTION", action)
        NormingDB.InsertField("ASWFSTEP_STEP", stepMsg)
        NormingDB.InsertField("ASWFSTEP_TIME", currentTime)
        NormingDB.InsertField("ASWFSTEP_MEMO", memo)
        NormingDB.InsertField("ASWFSTEP_LSTMNTBY", userId)
        NormingDB.InsertField("ASWFSTEP_APPROVER", approverId)
        NormingDB.InsertField("ASWFSTEP_PROCESSTIME", currentTime)
        NormingDB.InsertField("ASWFSTEP_DOCIDDISP", docNo)
        NormingDB.InsertField("ASWFSTEP_DOCDESC", reqtComnt)
        NormingDB.ExecuteInsertCommand()
    End Sub

    Sub deleteWorkFlowStep(ByVal docNo As String)
        Try
            NormingDB.RunDML("DELETE FROM ASWFSTEP WHERE ASWFSTEP_DOCID = '" + docNo + "' AND ASWFSTEP_ACTION = 7 ")
        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Sub deleteToDoList(ByVal docNo As String)
        Try
            NormingDB.RunDML("DELETE FROM ASTDLIST WHERE ASTDLIST_DOCID = '" + docNo + "' ")
        Catch ex As Exception
            MsgBox("Something went wrong please contact IT", MsgBoxStyle.Critical, AppName)

            GetLog(ex.Message)
        End Try
    End Sub

    Sub insertToDoList(ByVal docNo As String, ByVal empId As String, ByVal leaveDesc As String)
        Try
            deleteToDoList(docNo)

            For i As Integer = 0 To nextApprovers.Rows.Count - 1
                Dim approverId As String = nextApprovers(i)("HREMPGRPD_EMPID").ToString
                Dim rowId As String = (Guid.NewGuid().ToString()).ToUpper

                NormingDB.InitInsertCommand("ASTDLIST")
                NormingDB.InsertField("ASTDLIST_LINEID", rowId)
                NormingDB.InsertField("ASTDLIST_TYPEID", 1)
                NormingDB.InsertField("ASTDLIST_BUSID", "LEAVE")
                NormingDB.InsertField("ASTDLIST_APPROVER", approverId)
                NormingDB.InsertField("ASTDLIST_DOCID", docNo)
                NormingDB.InsertField("ASTDLIST_DOCDESC", leaveDesc)
                NormingDB.InsertField("ASTDLIST_EMPID", empId)
                NormingDB.InsertField("ASTDLIST_DOCIDDISP", docNo)
                NormingDB.ExecuteInsertCommand()
            Next

        Catch ex As Exception
            GetLog(ex.Message)
        End Try
    End Sub

    Sub insertLeaveBank(ByVal docNo As String, ByVal fromDate As Date, ByVal toDate As Date, ByVal empId As String, ByVal leaveCode As String, ByVal actDay As Integer, ByVal lineNotes As String)

        Dim k As Integer = CInt(DateDiff(DateInterval.Day, fromDate, toDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek))

        For i As Integer = 0 To k
            Dim maxLineID = NormingDB.SelectField("MAX(LVLEAVEBANK_LINEID)", "LVLEAVEBANK", "LVLEAVEBANK_EMPID = '" & empId & "' AND LVLEAVEBANK_LEAVECODE = '" & leaveCode & "'  ", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
            Dim itemDate = Format(DateAdd(DateInterval.Day, i, fromDate), "yyyy-MM-dd")
            Dim lineId As Integer = (CInt(maxLineID) + 1)
            Dim currentDate As Date = CDate(Now.ToString("yyyy-MM-dd"))
            Dim actHours As Integer = (actDay * 8)
            Dim actMinutes As Integer = (actHours * 8)

            NormingDB.InitInsertCommand("LVLEAVEBANK")
            NormingDB.InsertField("LVLEAVEBANK_EMPID", empId)
            NormingDB.InsertField("LVLEAVEBANK_LEAVECODE", leaveCode)
            NormingDB.InsertField("LVLEAVEBANK_LINEID", lineId)
            NormingDB.InsertField("LVLEAVEBANK_CREATEBY", empId)
            NormingDB.InsertField("LVLEAVEBANK_ACTDATE", itemDate)
            NormingDB.InsertField("LVLEAVEBANK_ACTDAY", 1)
            NormingDB.InsertField("LVLEAVEBANK_ACTHOUR", actHours)
            NormingDB.InsertField("LVLEAVEBANK_TYPE", 2)
            NormingDB.InsertField("LVLEAVEBANK_REQID", docNo)
            NormingDB.InsertField("LVLEAVEBANK_LINENOTES", lineNotes)
            NormingDB.InsertField("LVLEAVEBANK_PAYDATE", currentDate)
            NormingDB.InsertField("LVLEAVEBANK_PERIODEND", currentDate)
            NormingDB.InsertField("LVLEAVEBANK_LSTMNTDT", currentDate)
            NormingDB.InsertField("LVLEAVEBANK_LSTMNTBY", empId)
            NormingDB.InsertField("LVLEAVEBANK_ACTIONBY", empId)
            NormingDB.InsertField("LVLEAVEBANK_ACTMINUTES", actMinutes)
            NormingDB.ExecuteInsertCommand()
        Next
    End Sub
    Sub doApprove(ByVal docNo As String, ByVal empId As String, ByVal leaveCode As String, ByVal reqtComnt As String, ByVal leaveDay As Integer, ByVal fromDate As Date, ByVal toDate As Date, ByVal payAount As Double)
        initNextApprovers()

        Dim userId As String = CurrentSession.User.ID.ToString

        If CurrentSession.User.RoleID = 4 Then
            insertWorkFlowStep(docNo, userId, userId, 1, "" & userId & " Approve", approvalComments, reqtComnt)

            deleteWorkFlowStep(docNo)

            insertLeaveBank(docNo, fromDate, toDate, empId, leaveCode, leaveDay, reqtComnt)

            deleteToDoList(docNo)

            NormingDB.RunDML("UPDATE LVEMPLEAVE SET LVEMPLEAVE_LEAVEDAYS = (LVEMPLEAVE_LEAVEDAYS - " & leaveDay & ") WHERE LVEMPLEAVE_EMPID = '" + empId + "' AND  LVEMPLEAVE_LEAVECODE = '" + leaveCode + "' ")
            NormingDB.RunDML("UPDATE LVLEAVEREQ SET LVLEAVEREQ_STATUS = 2 WHERE LVLEAVEREQ_REQID = '" + docNo + "' ")
        Else
            insertWorkFlowStep(docNo, userId, userId, 1, "" & userId & " Approve", approvalComments, reqtComnt)
            deleteWorkFlowStep(docNo)

            For i As Integer = 0 To nextApprovers.Rows.Count - 1
                Dim approveId As String = nextApprovers(i)("HREMPGRPD_EMPID").ToString

                insertWorkFlowStep(docNo, empId, approveId, 7, "", "", "")
            Next

            insertToDoList(docNo, empId, reqtComnt)
        End If

    End Sub

    Sub doReject(ByVal docNo As String, ByVal empId As String, ByVal reqtComnt As String)
        Dim userId As String = CurrentSession.User.ID.ToString

        insertWorkFlowStep(docNo, empId, userId, 2, "" + userId + " Reject", approvalComments, reqtComnt)
        deleteWorkFlowStep(docNo)
        deleteToDoList(docNo)

        NormingDB.RunDML("UPDATE LVLEAVEREQ SET LVLEAVEREQ_STATUS = 3 WHERE LVLEAVEREQ_REQID = '" + docNo + "' ")
    End Sub

End Class
