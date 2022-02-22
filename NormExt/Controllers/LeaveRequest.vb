Public Class LeaveRequest
    Private _lvcode As String
    Private _requdate As Date
    Private _empid As String
    Private _reqfrom As Date
    Private _reqto As Date
    Private _note As String
    Private _lvday As Double
    Private _docnum As String
    Private _sucess As Boolean
    Private _holType As String

    Dim emp As Employee

    Sub New()

    End Sub
    ReadOnly Property DocumentNumber As String
        Get
            Return _docnum
        End Get
    End Property
    ReadOnly Property Sucess As Boolean
        Get
            Return _sucess
        End Get
    End Property
    Property LeaveDay As Double
        Set(value As Double)
            _lvday = value
        End Set
        Get
            Return _lvday
        End Get
    End Property
    Property Note As String
        Set(value As String)
            _note = value
        End Set
        Get
            Return _note
        End Get
    End Property
    Property LeaveCode As String
        Set(value As String)
            _lvcode = value
        End Set
        Get
            Return _lvcode
        End Get
    End Property
    Property RequestDate As Date
        Set(value As Date)
            _requdate = value
        End Set
        Get
            Return _requdate
        End Get
    End Property
    Property EmployeeID As String
        Set(value As String)
            _empid = value
            emp = New Employee(_empid)
        End Set
        Get
            Return _empid
        End Get
    End Property
    Property FromDate As Date
        Set(value As Date)
            _reqfrom = value
        End Set
        Get
            Return _reqfrom
        End Get
    End Property
    Property ToDate As Date
        Set(value As Date)
            _reqto = value
        End Set
        Get
            Return _reqto
        End Get
    End Property
    Property HolType As String
        Set(value As String)
            _holType = value
        End Set
        Get
            Return _holType
        End Get
    End Property
    Private Function GetLvRequestNo() As String
        Dim docset As DataTable = NormingDB.SelectField("*", "ASNOPT", "ASNOPT_MODTYPE = 7 AND ASNOPT_ENTITY = 1", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        Dim docnum As Integer = docset.Rows(0)("ASNOPT_NEXTNUM")
        Dim prefix As String = docset.Rows(0)("ASNOPT_PREFIX").ToString.Trim
        Dim doclen As Integer = docset.Rows(0)("ASNOPT_NUMLENGTH")
        Dim usedate As Integer = docset.Rows(0)("ASNOPT_USEDATE")
        Dim dtformat As String = docset.Rows(0)("ASNOPT_DATEFMT").ToString.Trim
        Dim zerstr As String = ""

        For i As Integer = 0 To doclen - docnum.ToString.Length - 1
            zerstr = zerstr + "0"
        Next

        Return prefix + If(usedate = 1, Format(Now.Date, "yyyyMMdd"), "") + zerstr + docnum.ToString
    End Function

    Private Sub SetNextNumber()
        '--ExtensionDB.RunDML("Update ASNOPT set NEXTNUM=NEXTNUM+1 where ENTITY=1 and MODTYPE=7")
        NormingDB.RunDML("UPDATE [ASNOPT] SET [ASNOPT_NEXTNUM] = [ASNOPT_NEXTNUM] + 1 WHERE [ASNOPT_ENTITY] = 1 AND [ASNOPT_MODTYPE] = 7")
    End Sub

    Sub Submit()
        Dim docno As String = GetLvRequestNo()

        NormingDB.InitInsertCommand("LVLEAVEREQ")
        NormingDB.InsertField("LVLEAVEREQ_REQID", docno)
        NormingDB.InsertField("LVLEAVEREQ_CREATEBY", CurrentSession.User.ID)
        NormingDB.InsertField("LVLEAVEREQ_DATE", _requdate)
        NormingDB.InsertField("LVLEAVEREQ_STATUS", 1)
        NormingDB.InsertField("LVLEAVEREQ_EMPID", _empid)
        NormingDB.InsertField("LVLEAVEREQ_DEPTID", emp.OrganizationID.ToString)
        NormingDB.InsertField("LVLEAVEREQ_LEAVECODE", _lvcode)
        NormingDB.InsertField("LVLEAVEREQ_BDATE", _reqfrom)
        NormingDB.InsertField("LVLEAVEREQ_BHOURS", 8.0)
        NormingDB.InsertField("LVLEAVEREQ_BTYPE", 1)
        NormingDB.InsertField("LVLEAVEREQ_EDATE", _reqto)
        NormingDB.InsertField("LVLEAVEREQ_EHOURS", 8.0)
        NormingDB.InsertField("LVLEAVEREQ_ETYPE", 1)
        NormingDB.InsertField("LVLEAVEREQ_LINENOTES", _note)
        NormingDB.InsertField("LVLEAVEREQ_APPLYLEAVE", 1)
        NormingDB.InsertField("LVLEAVEREQ_TOTALHOURS", CDec(_lvday * 8))
        NormingDB.InsertField("LVLEAVEREQ_USELEAVEHOURS", CDec(_lvday * 8))
        NormingDB.InsertField("LVLEAVEREQ_LSTMNTBY", "VB ESS")
        NormingDB.InsertField("LVLEAVEREQ_BSTIME", "09:00")
        NormingDB.InsertField("LVLEAVEREQ_BFTIME", "18:00")
        NormingDB.InsertField("LVLEAVEREQ_ESTIME", "09:00")
        NormingDB.InsertField("LVLEAVEREQ_EFTIME", "18:00")
        NormingDB.InsertField("LVLEAVEREQ_TOTALMINUTES", CDec(_lvday * 8 * 60))
        NormingDB.InsertField("LVLEAVEREQ_BMINUTES", CDec(_lvday * 8 * 60))
        NormingDB.InsertField("LVLEAVEREQ_EMINUTES", CDec(_lvday * 8 * 60))
        NormingDB.InsertField("LVLEAVEREQ_PHID", _holType)
        NormingDB.ExecuteInsertCommand()
        _docnum = docno

        '-- Put code for workflow and todo list here
        CreateWorkFlowStep(0, emp.HODEmployeeID, _docnum, _note, 0, 0, _empid, "Sumbit", "")
        CreateTokenVariableMap(emp.HODEmployeeID, _lvcode, _docnum)

        SetNextNumber()
        _sucess = True

    End Sub

    Private Sub CreateWorkFlowStep(ByVal ActionCode As Integer, ByVal ApproverID As String, ByVal LvRequestNo As String, ByVal Note As String, ByVal PID As Integer, ByVal TID As Int64, ByVal LeaveEmpID As String, ByVal LvReqMemo As String, ByVal WorkFlowRole As String)
        'Submit_ASWFSTEP from Old Code
        NormingDB.InitInsertCommand("ASWFSTEP")
        NormingDB.InsertField("ASWFSTEP_LINEID", System.Guid.NewGuid.ToString().ToUpper())
        NormingDB.InsertField("ASWFSTEP_CREATEBY", LeaveEmpID)
        NormingDB.InsertField("ASWFSTEP_DOCID", LvRequestNo)
        NormingDB.InsertField("ASWFSTEP_SUBMITBY", LeaveEmpID)
        NormingDB.InsertField("ASWFSTEP_BUSID", "LEAVE")
        NormingDB.InsertField("ASWFSTEP_USERID", CurrentSession.User.ID)
        NormingDB.InsertField("ASWFSTEP_ACTION", ActionCode)
        NormingDB.InsertField("ASWFSTEP_STEP", CurrentSession.User.ID + " Submit")
        NormingDB.InsertField("ASWFSTEP_DATE", Now.Date())
        NormingDB.InsertField("ASWFSTEP_TIME", Format(Now(), "HH:mm:ss"))
        NormingDB.InsertField("ASWFSTEP_MEMO", LvReqMemo)
        NormingDB.InsertField("ASWFSTEP_LSTMNTBY", LeaveEmpID)
        NormingDB.InsertField("ASWFSTEP_APPROVER", ApproverID)
        NormingDB.InsertField("ASWFSTEP_ROLE", WorkFlowRole)
        NormingDB.InsertField("ASWFSTEP_PROCESSDATE", Now.Date())
        NormingDB.InsertField("ASWFSTEP_PROCESSTIME", Format(Now(), "HH:mm:ss"))
        NormingDB.InsertField("PID", PID)
        NormingDB.InsertField("TID", TID)
        NormingDB.InsertField("ASWFSTEP_DOCIDDISP", LvRequestNo)
        NormingDB.InsertField("ASWFSTEP_DOCDESC", Note)
        NormingDB.ExecuteInsertCommand()
    End Sub

    Private Function _JBPM_PROCESSDEFINITION_ID(ByVal WorkFlowCode As String) As String
        Dim _ID As String = ""
        _ID = NormingDB.SelectField("MAX(ID_)", "JBPM_PROCESSDEFINITION", "NAME_='" + WorkFlowCode + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
        Return _ID
    End Function
    Private Function NODE_ID(ByVal ProcessID As String) As String
        Dim VAL As String = NormingDB.SelectField("ID_", "JBPM_NODE", "NAME_='task-node1' AND PROCESSDEFINITION_=" + ProcessID, NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
        Return VAL
    End Function

    Private Sub CreateToDoList(ByVal ApproverID As String, ByVal LvReqNo As String, ByVal Note As String, ByVal TID As Int64, ByVal EmployeeID As String)
        'Former Submit_ASTDLIST
        NormingDB.InitInsertCommand("ASTDLIST")
        NormingDB.InsertField("ASTDLIST_LINEID", System.Guid.NewGuid.ToString().ToUpper())
        NormingDB.InsertField("ASTDLIST_CREATEBY", EmployeeID)
        NormingDB.InsertField("ASTDLIST_TYPEID", 1)
        NormingDB.InsertField("ASTDLIST_BUSID", "LEAVE")
        NormingDB.InsertField("ASTDLIST_APPROVER", ApproverID)
        NormingDB.InsertField("ASTDLIST_DOCID", LvReqNo)
        NormingDB.InsertField("ASTDLIST_DOCDESC", Note)
        NormingDB.InsertField("TID", TID)
        NormingDB.InsertField("ASTDLIST_PRJID", LvReqNo)
        NormingDB.InsertField("ASTDLIST_EMPID", EmployeeID)
        NormingDB.InsertField("ASTDLIST_LSTMNTBY", EmployeeID)
        NormingDB.InsertField("ASTDLIST_DOCIDDISP", LvReqNo)
        NormingDB.ExecuteInsertCommand()
    End Sub

    Private Sub CreateTokenVariableMap(ByVal ApproverID As String, ByVal LeaveCode As String, ByVal LvRequestNo As String)
        'Former JBPM_TOKENVARIABLEMAP
        Dim _EMPWF As String = emp.LeavWorkFlow
        Dim _PROCESSDEFINITIONID = _JBPM_PROCESSDEFINITION_ID(_EMPWF)
        'Insert Process Instance
        NormingDB.InitInsertCommand("JBPM_PROCESSINSTANCE")
        NormingDB.InsertField("VERSION_", 1)
        NormingDB.InsertField("ISSUSPENDED_", 0)
        NormingDB.InsertField("PROCESSDEFINITION_", _PROCESSDEFINITIONID)
        NormingDB.ExecuteInsertCommand()

        Dim JBPM_PROCESSINSTANCE_ID As Integer = NormingDB.SelectField("MAX(ID_)", "JBPM_PROCESSINSTANCE", "", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
        Dim NODEID_ As String = NODE_ID(_PROCESSDEFINITIONID)

        'Insert Token
        NormingDB.InitInsertCommand("JBPM_TOKEN")
        NormingDB.InsertField("VERSION_", 1)
        NormingDB.InsertField("NEXTLOGINDEX_", 18)
        NormingDB.InsertField("ISABLETOREACTIVATEPARENT_", 1)
        NormingDB.InsertField("ISTERMINATIONIMPLICIT_", 0)
        NormingDB.InsertField("ISSUSPENDED_", 0)
        NormingDB.InsertField("NODE_", NODEID_)
        NormingDB.InsertField("PROCESSINSTANCE_", JBPM_PROCESSINSTANCE_ID)
        NormingDB.ExecuteInsertCommand()


        Dim ROOTTOKEN_ As Integer = NormingDB.SelectField("ID_", "JBPM_TOKEN", "PROCESSINSTANCE_=" + JBPM_PROCESSINSTANCE_ID.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue)

        'Update Process Instance
        NormingDB.InitUpdateCommand("JBPM_PROCESSINSTANCE")
        NormingDB.SetWhereField("ID_", JBPM_PROCESSINSTANCE_ID)
        NormingDB.SetUpdateField("ROOTTOKEN_", ROOTTOKEN_)
        NormingDB.ExecuteUpdateCommand()

        'Insert Module Instance
        NormingDB.InitInsertCommand("JBPM_MODULEINSTANCE")
        NormingDB.InsertField("CLASS_", "C")
        NormingDB.InsertField("PROCESSINSTANCE_", JBPM_PROCESSINSTANCE_ID)
        NormingDB.InsertField("NAME_", "org.jbpm.context.exe.ContextInstance")
        NormingDB.ExecuteInsertCommand()

        NormingDB.InitInsertCommand("JBPM_MODULEINSTANCE")
        NormingDB.InsertField("CLASS_", "T")
        NormingDB.InsertField("PROCESSINSTANCE_", JBPM_PROCESSINSTANCE_ID)
        NormingDB.InsertField("TASKMGMTDEFINITION_", 40)
        NormingDB.InsertField("NAME_", "org.jbpm.taskmgmt.exe.TaskMgmtInstance")
        NormingDB.ExecuteInsertCommand()

        Dim INSTANCE_C As Integer = NormingDB.SelectField("TOP 1 [ID_]", "JBPM_MODULEINSTANCE", "CLASS_='C' AND PROCESSINSTANCE_ =" + JBPM_PROCESSINSTANCE_ID.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue)
        Dim INSTANCE_T As Integer = NormingDB.SelectField("TOP 1 [ID_]", "JBPM_MODULEINSTANCE", "CLASS_='T' AND PROCESSINSTANCE_ =" + JBPM_PROCESSINSTANCE_ID.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue)

        'Insert TokenVariableMap
        NormingDB.InitInsertCommand("JBPM_TOKENVARIABLEMAP")
        NormingDB.InsertField("TOKEN_", ROOTTOKEN_)
        NormingDB.InsertField("CONTEXTINSTANCE_", INSTANCE_C)
        NormingDB.ExecuteInsertCommand()

        NormingDB.InitUpdateCommand("LVLEAVEREQ")
        NormingDB.SetWhereField("LVLEAVEREQ_REQID", LvRequestNo)
        NormingDB.SetUpdateField("PID", JBPM_PROCESSINSTANCE_ID)
        NormingDB.ExecuteUpdateCommand()

        'Inser Log
        NormingDB.InitInsertCommand("JBPM_LOG")
        NormingDB.InsertField("CLASS_", "I")
        NormingDB.InsertField("INDEX_", 0)
        NormingDB.InsertField("TOKEN_", ROOTTOKEN_)
        NormingDB.ExecuteInsertCommand()
        Dim TASK_ As String = NormingDB.SelectField("ID_", "JBPM_TASK", "PROCESSDEFINITION_=" + _PROCESSDEFINITIONID.ToString + " AND TASKNODE_ =" + NODEID_, NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim

        'geting approver type
        ' employeeGroup
        ' role="depManager" empgrp="ITAPP"

        Dim DEFVAL As String = NormingDB.SelectField("TOP 1  [ASWFDEF_DEFVAL]", "ASWFDEF", "ASWFDEF_DEFID='" + _EMPWF + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim
        Dim doc = XDocument.Parse(DEFVAL)
        Dim product = doc.Root.Elements("task-node").FirstOrDefault(Function(x) x.Attribute("name").Value = "task-node1")
        Dim ROLE_ As String = product.Attribute("role").Value
        Dim EMPGRP_ As String = product.Attribute("empgrp").Value

        If ROLE_ = "employeeGroup" Then
            Dim DT As DataTable = NormingDB.SelectField("HREMPGRPD_EMPID", "HREMPGRPD", "HREMPGRPD_GRPCODE='" + EMPGRP_ + "'", NormingExtension.DataConnector.SelectedReturnType.DataTable)
            If DT.Rows.Count <> 0 Then
                For i As Integer = 0 To DT.Rows.Count - 1
                    'Insert Task Instance
                    NormingDB.InitInsertCommand("JBPM_TASKINSTANCE")
                    NormingDB.InsertField("CLASS_", "T")
                    NormingDB.InsertField("NAME_", "task-node1")
                    NormingDB.InsertField("ACTORID_", DT.Rows(i).Item(0).ToString.Trim)
                    NormingDB.InsertField("ROLE_", "employeeGroup")
                    NormingDB.InsertField("PRIORITY_", 3)
                    NormingDB.InsertField("ISCANCELLED_", 0)
                    NormingDB.InsertField("ISSUSPENDED_", 0)
                    NormingDB.InsertField("ISOPEN_", 1)
                    NormingDB.InsertField("ISSIGNALLING_", 1)
                    NormingDB.InsertField("ISBLOCKING_", 0)
                    NormingDB.InsertField("TASK_", TASK_)
                    NormingDB.InsertField("TOKEN_", ROOTTOKEN_)
                    NormingDB.InsertField("TASKMGMTINSTANCE_", INSTANCE_T)
                    NormingDB.ExecuteInsertCommand()

                    Dim TID As String = NormingDB.SelectField("ID_", "JBPM_TASKINSTANCE", "ACTORID_ ='" + DT.Rows(i).Item(0).ToString.Trim + "' and TOKEN_ =" + ROOTTOKEN_.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim

                    CreateWorkFlowStep(7, DT.Rows(i).Item(0).ToString.Trim, _docnum, "-", ROOTTOKEN_, TID, _empid, "Approve", "employeeGroup") ' To Approve
                    CreateToDoList(DT.Rows(i).Item(0).ToString.Trim, _docnum, _note, TID, _empid) ' INSERT INTO [dbo].[ASTDLIST]
                Next
            Else
                NormingDB.InitInsertCommand("JBPM_TASKINSTANCE")
                NormingDB.InsertField("CLASS_", "T")
                NormingDB.InsertField("NAME_", "task-node1")
                NormingDB.InsertField("ACTORID_", ApproverID)
                NormingDB.InsertField("ROLE_", "depManager")
                NormingDB.InsertField("PRIORITY_", 3)
                NormingDB.InsertField("ISCANCELLED_", 0)
                NormingDB.InsertField("ISSUSPENDED_", 0)
                NormingDB.InsertField("ISOPEN_", 1)
                NormingDB.InsertField("ISSIGNALLING_", 1)
                NormingDB.InsertField("ISBLOCKING_", 0)
                NormingDB.InsertField("TASK_", TASK_)
                NormingDB.InsertField("TOKEN_", ROOTTOKEN_)
                NormingDB.InsertField("TASKMGMTINSTANCE_", INSTANCE_T)
                NormingDB.ExecuteInsertCommand()

                Dim TID As String = NormingDB.SelectField("ID_", "JBPM_TASKINSTANCE", "ACTORID_='" + ApproverID + "' and TOKEN_ =" + ROOTTOKEN_, NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim

                CreateWorkFlowStep(7, ApproverID, _docnum, "-", ROOTTOKEN_, TID, _empid, "Approve", "depManager") ' To Approve
                CreateToDoList(ApproverID, _docnum, _note, TID, _empid) ' INSERT INTO [dbo].[ASTDLIST]
            End If
        Else
            NormingDB.InitInsertCommand("JBPM_TASKINSTANCE")
            NormingDB.InsertField("CLASS_", "T")
            NormingDB.InsertField("NAME_", "task-node1")
            NormingDB.InsertField("ACTORID_", ApproverID)
            NormingDB.InsertField("ROLE_", "depManager")
            NormingDB.InsertField("PRIORITY_", 3)
            NormingDB.InsertField("ISCANCELLED_", 0)
            NormingDB.InsertField("ISSUSPENDED_", 0)
            NormingDB.InsertField("ISOPEN_", 1)
            NormingDB.InsertField("ISSIGNALLING_", 1)
            NormingDB.InsertField("ISBLOCKING_", 0)
            NormingDB.InsertField("TASK_", TASK_)
            NormingDB.InsertField("TOKEN_", ROOTTOKEN_)
            NormingDB.InsertField("TASKMGMTINSTANCE_", INSTANCE_T)
            NormingDB.ExecuteInsertCommand()

            Dim TID As String = NormingDB.SelectField("ID_", "JBPM_TASKINSTANCE", "ACTORID_='" + ApproverID + "' and TOKEN_ =" + ROOTTOKEN_.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue).ToString.Trim

            CreateWorkFlowStep(7, ApproverID, _docnum, "-", ROOTTOKEN_, TID, _empid, "Approve", "depManager") ' 7 To Approve

            CreateToDoList(ApproverID, _docnum, _note, TID, _empid) ' INSERT INTO [dbo].[ASTDLIST]
        End If

        'UPDATE HERE task-node1 FROM ACTION34 employeeGroup
        Dim ID_ As Integer = NormingDB.SelectField("ID_", "JBPM_TOKENVARIABLEMAP", "TOKEN_ =" + ROOTTOKEN_.ToString, NormingExtension.DataConnector.SelectedReturnType.SignleValue)

        Dim Str As String = "INSERT INTO [dbo].[JBPM_VARIABLEINSTANCE] ([CLASS_] ,[NAME_] ,[CONVERTER_] ,[TOKEN_] ,[TOKENVARIABLEMAP_] ,[PROCESSINSTANCE_]  ,[DOUBLEVALUE_]   ,[STRINGVALUE_])" _
        & "VALUES('S','document',NULL," & ROOTTOKEN_ & "," & ID_ & "," & JBPM_PROCESSINSTANCE_ID.ToString & ",NULL,'" & LvRequestNo & "')" _
        & ",('O','YEARTOTALLEAVEDAYS',NULL," & ROOTTOKEN_ & "," & ID_ & "," & JBPM_PROCESSINSTANCE_ID.ToString & ",0,NULL)" _
        & ",('O','LEAVEDAYS',NULL," & ROOTTOKEN_ & "," & ID_ & "," & JBPM_PROCESSINSTANCE_ID.ToString & ",1,NULL)" _
        & ",('S','LEAVECODE',NULL," & ROOTTOKEN_ & "," & ID_ & "," & JBPM_PROCESSINSTANCE_ID.ToString & ",NULL,'" & LeaveCode & "')" _
        & ",('S','rejected','B'," & ROOTTOKEN_ & "," & ID_ & "," & JBPM_PROCESSINSTANCE_ID.ToString & ",NULL,'F')" _
        & ",('S','type',NULL," & ROOTTOKEN_ & "," & ID_ & "," & JBPM_PROCESSINSTANCE_ID.ToString & ",NULL,'LEAVE')"

        Dim k As Integer = NormingDB.RunDML(Str)

    End Sub

End Class
