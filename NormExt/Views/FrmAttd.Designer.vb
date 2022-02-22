<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttd
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttd))
        Me.openDia = New System.Windows.Forms.OpenFileDialog()
        Me.saveDia = New System.Windows.Forms.SaveFileDialog()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.btnRequest = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalRecord = New DevExpress.XtraEditors.LabelControl()
        Me.gvAttd = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.docNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.wkDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftStart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isChkIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkInTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isChkOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkOutTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.eChkIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lChkIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.eChkOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkInRv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqInTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.inApprState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkOutRv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rqOutTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rqShiftCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.outApprState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.resDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rvBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rvInAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rvOutAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hodBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hodAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.verBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.verAy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hrBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hrAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAttd = New DevExpress.XtraGrid.GridControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.radOption = New DevExpress.XtraEditors.RadioGroup()
        Me.lstEmpUnder = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEmpUnder = New DevExpress.XtraEditors.LabelControl()
        Me.dtTo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnShowData = New DevExpress.XtraEditors.SimpleButton()
        Me.dtFrom = New DevExpress.XtraEditors.DateEdit()
        Me.lstDept = New DevExpress.XtraEditors.LookUpEdit()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gvAttd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAttd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.radOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstEmpUnder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openDia
        '
        Me.openDia.FileName = "OpenFileDialog1"
        Me.openDia.Filter = "Excel 2007 | *.xlsx"
        '
        'saveDia
        '
        Me.saveDia.Filter = "Excel 2007 | *.xlsx"
        '
        'bgWorker
        '
        '
        'btnRequest
        '
        Me.btnRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRequest.Enabled = False
        Me.btnRequest.Image = CType(resources.GetObject("btnRequest.Image"), System.Drawing.Image)
        Me.btnRequest.Location = New System.Drawing.Point(2, 2)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(115, 41)
        Me.btnRequest.TabIndex = 0
        Me.btnRequest.Text = "Edit Request"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.btnRequest)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(1425, 170)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(119, 415)
        Me.PanelControl2.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.lblTotalRecord)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(2, 368)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(115, 45)
        Me.PanelControl3.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(52, 22)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Records"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblTotalRecord.Location = New System.Drawing.Point(21, 22)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalRecord.TabIndex = 12
        Me.lblTotalRecord.Text = "(0)"
        '
        'gvAttd
        '
        Me.gvAttd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.docNo, Me.wkDate, Me.grpCode, Me.empId, Me.empCode, Me.empName, Me.shiftCode, Me.shiftStart, Me.shiftEnd, Me.isChkIn, Me.chkInTime, Me.isChkOut, Me.chkOutTime, Me.eChkIn, Me.lChkIn, Me.eChkOut, Me.chkInRv, Me.RqInTime, Me.inApprState, Me.chkOutRv, Me.rqOutTime, Me.rqShiftCode, Me.outApprState, Me.reason, Me.resDesc, Me.rvBy, Me.rvInAt, Me.rvOutAt, Me.hodBy, Me.hodAt, Me.verBy, Me.verAy, Me.hrBy, Me.hrAt, Me.col33, Me.col34})
        Me.gvAttd.GridControl = Me.gcAttd
        Me.gvAttd.Name = "gvAttd"
        Me.gvAttd.OptionsBehavior.Editable = False
        Me.gvAttd.OptionsBehavior.ReadOnly = True
        Me.gvAttd.OptionsCustomization.AllowColumnMoving = False
        Me.gvAttd.OptionsFind.AlwaysVisible = True
        Me.gvAttd.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvAttd.OptionsView.ColumnAutoWidth = False
        Me.gvAttd.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gvAttd.OptionsView.ShowGroupPanel = False
        Me.gvAttd.OptionsView.ShowIndicator = False
        '
        'docNo
        '
        Me.docNo.Caption = "DocNo"
        Me.docNo.FieldName = "DocNo"
        Me.docNo.Name = "docNo"
        Me.docNo.ToolTip = "Document Number"
        Me.docNo.Visible = True
        Me.docNo.VisibleIndex = 0
        Me.docNo.Width = 92
        '
        'wkDate
        '
        Me.wkDate.AppearanceHeader.Options.UseTextOptions = True
        Me.wkDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.wkDate.Caption = "Wk-Date"
        Me.wkDate.DisplayFormat.FormatString = "yyyy-mm-dd"
        Me.wkDate.FieldName = "WorkDay"
        Me.wkDate.Name = "wkDate"
        Me.wkDate.ToolTip = "Work Date"
        Me.wkDate.Visible = True
        Me.wkDate.VisibleIndex = 1
        Me.wkDate.Width = 74
        '
        'grpCode
        '
        Me.grpCode.Caption = "Grp Code"
        Me.grpCode.FieldName = "GroupCode"
        Me.grpCode.Name = "grpCode"
        Me.grpCode.ToolTip = "Group Code"
        Me.grpCode.Visible = True
        Me.grpCode.VisibleIndex = 2
        Me.grpCode.Width = 74
        '
        'empId
        '
        Me.empId.Caption = "EmpID"
        Me.empId.FieldName = "EmpID"
        Me.empId.Name = "empId"
        '
        'empCode
        '
        Me.empCode.AppearanceHeader.Options.UseTextOptions = True
        Me.empCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.empCode.Caption = "Emp Code"
        Me.empCode.FieldName = "EmpCode"
        Me.empCode.Name = "empCode"
        Me.empCode.ToolTip = "Employee ID"
        Me.empCode.Visible = True
        Me.empCode.VisibleIndex = 3
        Me.empCode.Width = 57
        '
        'empName
        '
        Me.empName.AppearanceHeader.Options.UseTextOptions = True
        Me.empName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.empName.Caption = "Emp Name"
        Me.empName.FieldName = "EmpName"
        Me.empName.Name = "empName"
        Me.empName.ToolTip = "Employee Name"
        Me.empName.Visible = True
        Me.empName.VisibleIndex = 4
        Me.empName.Width = 143
        '
        'shiftCode
        '
        Me.shiftCode.AppearanceHeader.Options.UseTextOptions = True
        Me.shiftCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.shiftCode.Caption = "Shift Code"
        Me.shiftCode.FieldName = "ShiftCode"
        Me.shiftCode.Name = "shiftCode"
        Me.shiftCode.ToolTip = "Shift Code"
        Me.shiftCode.Visible = True
        Me.shiftCode.VisibleIndex = 5
        Me.shiftCode.Width = 59
        '
        'shiftStart
        '
        Me.shiftStart.AppearanceCell.Options.UseTextOptions = True
        Me.shiftStart.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.shiftStart.AppearanceHeader.Options.UseTextOptions = True
        Me.shiftStart.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.shiftStart.Caption = "Shift Start"
        Me.shiftStart.FieldName = "ShiftStart"
        Me.shiftStart.Name = "shiftStart"
        Me.shiftStart.ToolTip = "Shift Start"
        Me.shiftStart.Visible = True
        Me.shiftStart.VisibleIndex = 6
        Me.shiftStart.Width = 57
        '
        'shiftEnd
        '
        Me.shiftEnd.AppearanceCell.Options.UseTextOptions = True
        Me.shiftEnd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.shiftEnd.AppearanceHeader.Options.UseTextOptions = True
        Me.shiftEnd.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.shiftEnd.Caption = "Shift End"
        Me.shiftEnd.FieldName = "ShiftEnd"
        Me.shiftEnd.Name = "shiftEnd"
        Me.shiftEnd.ToolTip = "Shif End"
        Me.shiftEnd.Visible = True
        Me.shiftEnd.VisibleIndex = 7
        Me.shiftEnd.Width = 51
        '
        'isChkIn
        '
        Me.isChkIn.AppearanceHeader.Options.UseTextOptions = True
        Me.isChkIn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.isChkIn.Caption = "Is Chk-In"
        Me.isChkIn.FieldName = "IsCheckIn"
        Me.isChkIn.Name = "isChkIn"
        Me.isChkIn.ToolTip = "Is Check-In"
        Me.isChkIn.Visible = True
        Me.isChkIn.VisibleIndex = 8
        Me.isChkIn.Width = 52
        '
        'chkInTime
        '
        Me.chkInTime.AppearanceHeader.Options.UseTextOptions = True
        Me.chkInTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.chkInTime.Caption = "Chk-In Time"
        Me.chkInTime.DisplayFormat.FormatString = "d"
        Me.chkInTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.chkInTime.FieldName = "CheckInTime"
        Me.chkInTime.Name = "chkInTime"
        Me.chkInTime.ToolTip = "Check-In Time"
        Me.chkInTime.Visible = True
        Me.chkInTime.VisibleIndex = 9
        Me.chkInTime.Width = 111
        '
        'isChkOut
        '
        Me.isChkOut.AppearanceHeader.Options.UseTextOptions = True
        Me.isChkOut.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.isChkOut.Caption = "Is Chk-Out"
        Me.isChkOut.FieldName = "IsCheckOut"
        Me.isChkOut.Name = "isChkOut"
        Me.isChkOut.ToolTip = "Is Check-Out"
        Me.isChkOut.Visible = True
        Me.isChkOut.VisibleIndex = 10
        Me.isChkOut.Width = 60
        '
        'chkOutTime
        '
        Me.chkOutTime.AppearanceHeader.Options.UseTextOptions = True
        Me.chkOutTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.chkOutTime.Caption = "Chk-Out Time"
        Me.chkOutTime.DisplayFormat.FormatString = "d"
        Me.chkOutTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.chkOutTime.FieldName = "CheckOutTime"
        Me.chkOutTime.Name = "chkOutTime"
        Me.chkOutTime.ToolTip = "Check-Out Time"
        Me.chkOutTime.Visible = True
        Me.chkOutTime.VisibleIndex = 11
        Me.chkOutTime.Width = 111
        '
        'eChkIn
        '
        Me.eChkIn.AppearanceCell.Options.UseTextOptions = True
        Me.eChkIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.eChkIn.Caption = "E Chk-In"
        Me.eChkIn.FieldName = "EarlyCheckIn"
        Me.eChkIn.Name = "eChkIn"
        Me.eChkIn.ToolTip = "Early Check-In"
        Me.eChkIn.Visible = True
        Me.eChkIn.VisibleIndex = 12
        Me.eChkIn.Width = 49
        '
        'lChkIn
        '
        Me.lChkIn.AppearanceCell.Options.UseTextOptions = True
        Me.lChkIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lChkIn.Caption = "L Chk-In"
        Me.lChkIn.FieldName = "LateCheckIn"
        Me.lChkIn.Name = "lChkIn"
        Me.lChkIn.ToolTip = "Late Check-In"
        Me.lChkIn.Visible = True
        Me.lChkIn.VisibleIndex = 13
        Me.lChkIn.Width = 49
        '
        'eChkOut
        '
        Me.eChkOut.AppearanceCell.Options.UseTextOptions = True
        Me.eChkOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.eChkOut.Caption = "E Chk-Out"
        Me.eChkOut.FieldName = "EarlyCheckOut"
        Me.eChkOut.Name = "eChkOut"
        Me.eChkOut.ToolTip = "Early Check-Out"
        Me.eChkOut.Visible = True
        Me.eChkOut.VisibleIndex = 14
        Me.eChkOut.Width = 60
        '
        'chkInRv
        '
        Me.chkInRv.AppearanceHeader.Options.UseTextOptions = True
        Me.chkInRv.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.chkInRv.Caption = "Chk-In Rev"
        Me.chkInRv.FieldName = "CheckInRv"
        Me.chkInRv.Name = "chkInRv"
        Me.chkInRv.ToolTip = "Check-In Revised"
        Me.chkInRv.Visible = True
        Me.chkInRv.VisibleIndex = 15
        Me.chkInRv.Width = 63
        '
        'RqInTime
        '
        Me.RqInTime.AppearanceHeader.Options.UseTextOptions = True
        Me.RqInTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RqInTime.Caption = "Req Chk-In Time"
        Me.RqInTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RqInTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RqInTime.FieldName = "RqCheckInTime"
        Me.RqInTime.Name = "RqInTime"
        Me.RqInTime.ToolTip = "Request Change Time-In"
        Me.RqInTime.Visible = True
        Me.RqInTime.VisibleIndex = 16
        Me.RqInTime.Width = 111
        '
        'inApprState
        '
        Me.inApprState.AppearanceHeader.Options.UseTextOptions = True
        Me.inApprState.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.inApprState.Caption = "Chk-In Appr State"
        Me.inApprState.FieldName = "CheckInApproveStatus"
        Me.inApprState.Name = "inApprState"
        Me.inApprState.ToolTip = "Check-In Approve Status"
        Me.inApprState.Visible = True
        Me.inApprState.VisibleIndex = 17
        Me.inApprState.Width = 99
        '
        'chkOutRv
        '
        Me.chkOutRv.AppearanceHeader.Options.UseTextOptions = True
        Me.chkOutRv.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.chkOutRv.Caption = "Chk-Out Rev"
        Me.chkOutRv.FieldName = "CheckOutRv"
        Me.chkOutRv.Name = "chkOutRv"
        Me.chkOutRv.ToolTip = "Check-Out Revised"
        Me.chkOutRv.Visible = True
        Me.chkOutRv.VisibleIndex = 18
        Me.chkOutRv.Width = 74
        '
        'rqOutTime
        '
        Me.rqOutTime.AppearanceHeader.Options.UseTextOptions = True
        Me.rqOutTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.rqOutTime.Caption = "Req Chk-Out Time"
        Me.rqOutTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.rqOutTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rqOutTime.FieldName = "RqCheckOutTime"
        Me.rqOutTime.Name = "rqOutTime"
        Me.rqOutTime.ToolTip = "Request Change Time-Out"
        Me.rqOutTime.Visible = True
        Me.rqOutTime.VisibleIndex = 19
        Me.rqOutTime.Width = 111
        '
        'rqShiftCode
        '
        Me.rqShiftCode.Caption = "Req Shift Code"
        Me.rqShiftCode.FieldName = "RqShiftCode"
        Me.rqShiftCode.Name = "rqShiftCode"
        Me.rqShiftCode.ToolTip = "Request Change Shift Code"
        Me.rqShiftCode.Visible = True
        Me.rqShiftCode.VisibleIndex = 20
        Me.rqShiftCode.Width = 80
        '
        'outApprState
        '
        Me.outApprState.AppearanceHeader.Options.UseTextOptions = True
        Me.outApprState.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.outApprState.Caption = "Chk-Out Appr State"
        Me.outApprState.FieldName = "CheckOutApproveStatus"
        Me.outApprState.Name = "outApprState"
        Me.outApprState.ToolTip = "Check-Out Approve Status"
        Me.outApprState.Visible = True
        Me.outApprState.VisibleIndex = 21
        Me.outApprState.Width = 109
        '
        'reason
        '
        Me.reason.AppearanceHeader.Options.UseTextOptions = True
        Me.reason.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.reason.Caption = "Reason"
        Me.reason.FieldName = "RvReason"
        Me.reason.Name = "reason"
        Me.reason.Visible = True
        Me.reason.VisibleIndex = 22
        '
        'resDesc
        '
        Me.resDesc.AppearanceHeader.Options.UseTextOptions = True
        Me.resDesc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.resDesc.Caption = "Reason Desc"
        Me.resDesc.FieldName = "Remark"
        Me.resDesc.Name = "resDesc"
        Me.resDesc.ToolTip = "Reason Description"
        Me.resDesc.Visible = True
        Me.resDesc.VisibleIndex = 23
        Me.resDesc.Width = 189
        '
        'rvBy
        '
        Me.rvBy.AppearanceHeader.Options.UseTextOptions = True
        Me.rvBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.rvBy.Caption = "Rev By"
        Me.rvBy.FieldName = "RvBy"
        Me.rvBy.Name = "rvBy"
        Me.rvBy.ToolTip = "Revised By"
        Me.rvBy.Visible = True
        Me.rvBy.VisibleIndex = 24
        Me.rvBy.Width = 52
        '
        'rvInAt
        '
        Me.rvInAt.Caption = "Rev Chk-In At"
        Me.rvInAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.rvInAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rvInAt.FieldName = "RvCheckInTime"
        Me.rvInAt.Name = "rvInAt"
        Me.rvInAt.ToolTip = "Revised Check-In At"
        Me.rvInAt.Visible = True
        Me.rvInAt.VisibleIndex = 25
        Me.rvInAt.Width = 111
        '
        'rvOutAt
        '
        Me.rvOutAt.Caption = "Rev Chk-Out At"
        Me.rvOutAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.rvOutAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rvOutAt.FieldName = "RvCheckOutTime"
        Me.rvOutAt.Name = "rvOutAt"
        Me.rvOutAt.ToolTip = "Revised Chk-Out At"
        Me.rvOutAt.Visible = True
        Me.rvOutAt.VisibleIndex = 26
        Me.rvOutAt.Width = 111
        '
        'hodBy
        '
        Me.hodBy.Caption = "HOD Action By"
        Me.hodBy.FieldName = "HodActionBy"
        Me.hodBy.Name = "hodBy"
        Me.hodBy.ToolTip = "HOD Action By"
        Me.hodBy.Visible = True
        Me.hodBy.VisibleIndex = 27
        Me.hodBy.Width = 86
        '
        'hodAt
        '
        Me.hodAt.Caption = "HOD Action At"
        Me.hodAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.hodAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.hodAt.FieldName = "HodActionAt"
        Me.hodAt.Name = "hodAt"
        Me.hodAt.ToolTip = "HOD Action At"
        Me.hodAt.Visible = True
        Me.hodAt.VisibleIndex = 28
        Me.hodAt.Width = 111
        '
        'verBy
        '
        Me.verBy.Caption = "Verified By"
        Me.verBy.FieldName = "VerifiedBy"
        Me.verBy.Name = "verBy"
        Me.verBy.ToolTip = "Verified By"
        Me.verBy.Visible = True
        Me.verBy.VisibleIndex = 29
        '
        'verAy
        '
        Me.verAy.Caption = "Verified At"
        Me.verAy.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.verAy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.verAy.FieldName = "VerifiedAt"
        Me.verAy.Name = "verAy"
        Me.verAy.ToolTip = "Verified At"
        Me.verAy.Visible = True
        Me.verAy.VisibleIndex = 30
        Me.verAy.Width = 111
        '
        'hrBy
        '
        Me.hrBy.Caption = "HR Action By"
        Me.hrBy.FieldName = "HrActionBy"
        Me.hrBy.Name = "hrBy"
        Me.hrBy.ToolTip = "HR Manager Action By"
        Me.hrBy.Visible = True
        Me.hrBy.VisibleIndex = 31
        '
        'hrAt
        '
        Me.hrAt.Caption = "HR Action At"
        Me.hrAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.hrAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.hrAt.FieldName = "HrActionAt"
        Me.hrAt.Name = "hrAt"
        Me.hrAt.ToolTip = "HR Manager Action At"
        Me.hrAt.Visible = True
        Me.hrAt.VisibleIndex = 32
        Me.hrAt.Width = 111
        '
        'col33
        '
        Me.col33.Caption = "CheckInApprState"
        Me.col33.FieldName = "CheckInApprState"
        Me.col33.Name = "col33"
        Me.col33.ToolTip = "CheckInApprState"
        '
        'col34
        '
        Me.col34.Caption = "CheckOutApprState"
        Me.col34.FieldName = "CheckOutApprState"
        Me.col34.Name = "col34"
        Me.col34.ToolTip = "CheckOutApprState"
        '
        'gcAttd
        '
        Me.gcAttd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAttd.Location = New System.Drawing.Point(0, 170)
        Me.gcAttd.MainView = Me.gvAttd
        Me.gcAttd.Name = "gcAttd"
        Me.gcAttd.Size = New System.Drawing.Size(1425, 415)
        Me.gcAttd.TabIndex = 2
        Me.gcAttd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAttd})
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1544, 170)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnRefresh)
        Me.GroupControl1.Controls.Add(Me.radOption)
        Me.GroupControl1.Controls.Add(Me.lstEmpUnder)
        Me.GroupControl1.Controls.Add(Me.lblEmpUnder)
        Me.GroupControl1.Controls.Add(Me.dtTo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.btnExport)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnShowData)
        Me.GroupControl1.Controls.Add(Me.dtFrom)
        Me.GroupControl1.Controls.Add(Me.lstDept)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(842, 141)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Main Assignments"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(650, 75)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(87, 23)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        '
        'radOption
        '
        Me.radOption.Location = New System.Drawing.Point(12, 31)
        Me.radOption.Name = "radOption"
        Me.radOption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Show All"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Show Only Not Check-In Or Not Check-Out Or Both"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Show Only Late Check-In Or Early Check-Out")})
        Me.radOption.Size = New System.Drawing.Size(283, 96)
        Me.radOption.TabIndex = 17
        '
        'lstEmpUnder
        '
        Me.lstEmpUnder.Location = New System.Drawing.Point(369, 77)
        Me.lstEmpUnder.Name = "lstEmpUnder"
        Me.lstEmpUnder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstEmpUnder.Properties.DisplayMember = "SupName"
        Me.lstEmpUnder.Properties.NullText = ""
        Me.lstEmpUnder.Properties.ValueMember = "SupID"
        Me.lstEmpUnder.Size = New System.Drawing.Size(132, 20)
        Me.lstEmpUnder.TabIndex = 10
        '
        'lblEmpUnder
        '
        Me.lblEmpUnder.Location = New System.Drawing.Point(311, 80)
        Me.lblEmpUnder.Name = "lblEmpUnder"
        Me.lblEmpUnder.Size = New System.Drawing.Size(52, 13)
        Me.lblEmpUnder.TabIndex = 9
        Me.lblEmpUnder.Text = "EMP Under"
        '
        'dtTo
        '
        Me.dtTo.EditValue = Nothing
        Me.dtTo.Location = New System.Drawing.Point(708, 31)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTo.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtTo.Size = New System.Drawing.Size(120, 20)
        Me.dtTo.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(690, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(517, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "From"
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(743, 75)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(85, 23)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(306, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Department"
        '
        'btnShowData
        '
        Me.btnShowData.Image = CType(resources.GetObject("btnShowData.Image"), System.Drawing.Image)
        Me.btnShowData.Location = New System.Drawing.Point(547, 75)
        Me.btnShowData.Name = "btnShowData"
        Me.btnShowData.Size = New System.Drawing.Size(97, 23)
        Me.btnShowData.TabIndex = 2
        Me.btnShowData.Text = "Show Data"
        '
        'dtFrom
        '
        Me.dtFrom.EditValue = Nothing
        Me.dtFrom.Location = New System.Drawing.Point(547, 31)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFrom.Properties.EditFormat.FormatString = "dd-MMM-yyyy"
        Me.dtFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFrom.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtFrom.Size = New System.Drawing.Size(120, 20)
        Me.dtFrom.TabIndex = 1
        '
        'lstDept
        '
        Me.lstDept.Location = New System.Drawing.Point(369, 31)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstDept.Properties.DisplayMember = "DeptName"
        Me.lstDept.Properties.NullText = "Select Department"
        Me.lstDept.Properties.ShowFooter = False
        Me.lstDept.Properties.ShowHeader = False
        Me.lstDept.Properties.ShowLines = False
        Me.lstDept.Properties.ValueMember = "GroupCode"
        Me.lstDept.Size = New System.Drawing.Size(132, 20)
        Me.lstDept.TabIndex = 0
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmAttd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1544, 585)
        Me.Controls.Add(Me.gcAttd)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmAttd"
        Me.Text = "ATTENDANCE REPORTS"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.gvAttd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAttd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.radOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstEmpUnder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openDia As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveDia As System.Windows.Forms.SaveFileDialog
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnRequest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gvAttd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents docNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents wkDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents isChkIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkInTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents isChkOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkOutTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkInRv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqInTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents inApprState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkOutRv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rqOutTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rqShiftCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents outApprState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rvBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents resDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hodBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hodAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents verBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents verAy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hrBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hrAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAttd As DevExpress.XtraGrid.GridControl
    Friend WithEvents lblTotalRecord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents radOption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents eChkIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lChkIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eChkOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rvInAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rvOutAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstEmpUnder As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEmpUnder As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnShowData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lstDept As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents empId As DevExpress.XtraGrid.Columns.GridColumn
End Class
