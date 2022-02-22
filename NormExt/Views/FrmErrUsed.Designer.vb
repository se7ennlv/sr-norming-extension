<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmErrUsed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmErrUsed))
        Me.openDia = New System.Windows.Forms.OpenFileDialog()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.RvOutAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RvInAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RvBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqShift = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqChkOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkOutRv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqChkIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkInRv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShfEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShfStart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShfCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.saveDia = New System.Windows.Forms.SaveFileDialog()
        Me.EmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WkDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvErrUsed = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EmpID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FChkIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LChkOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RvReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkInApprState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkOutApprState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcErrUsed = New DevExpress.XtraGrid.GridControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.toDate = New DevExpress.XtraEditors.DateEdit()
        Me.fromDate = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gvErrUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcErrUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.toDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fromDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'openDia
        '
        Me.openDia.FileName = "OpenFileDialog1"
        Me.openDia.Filter = "Excel 2007 | *.xlsx"
        '
        'bgWorker
        '
        '
        'RvOutAt
        '
        Me.RvOutAt.AppearanceHeader.Options.UseTextOptions = True
        Me.RvOutAt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RvOutAt.Caption = "Rv Chk-Out At"
        Me.RvOutAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RvOutAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RvOutAt.FieldName = "RvCheckOutTime"
        Me.RvOutAt.Name = "RvOutAt"
        Me.RvOutAt.ToolTip = "Revised Check-Out At"
        Me.RvOutAt.Visible = True
        Me.RvOutAt.VisibleIndex = 15
        Me.RvOutAt.Width = 111
        '
        'RvInAt
        '
        Me.RvInAt.AppearanceHeader.Options.UseTextOptions = True
        Me.RvInAt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RvInAt.Caption = "Rv Chk-In At"
        Me.RvInAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RvInAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RvInAt.FieldName = "RvCheckInTime"
        Me.RvInAt.Name = "RvInAt"
        Me.RvInAt.ToolTip = "Revised Check-In At"
        Me.RvInAt.Visible = True
        Me.RvInAt.VisibleIndex = 14
        Me.RvInAt.Width = 111
        '
        'RvBy
        '
        Me.RvBy.AppearanceCell.Options.UseTextOptions = True
        Me.RvBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RvBy.AppearanceHeader.Options.UseTextOptions = True
        Me.RvBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RvBy.Caption = "Revised By"
        Me.RvBy.FieldName = "RvBy"
        Me.RvBy.Name = "RvBy"
        Me.RvBy.ToolTip = "Revised By"
        Me.RvBy.Visible = True
        Me.RvBy.VisibleIndex = 16
        Me.RvBy.Width = 66
        '
        'RqShift
        '
        Me.RqShift.AppearanceCell.Options.UseTextOptions = True
        Me.RqShift.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RqShift.AppearanceHeader.Options.UseTextOptions = True
        Me.RqShift.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RqShift.Caption = "Rq Shift Code"
        Me.RqShift.FieldName = "RqShiftCode"
        Me.RqShift.Name = "RqShift"
        Me.RqShift.ToolTip = "Request Shift Code"
        Me.RqShift.Visible = True
        Me.RqShift.VisibleIndex = 13
        Me.RqShift.Width = 87
        '
        'RqChkOut
        '
        Me.RqChkOut.AppearanceHeader.Options.UseTextOptions = True
        Me.RqChkOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RqChkOut.Caption = "Rq Chk-Out Time"
        Me.RqChkOut.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RqChkOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RqChkOut.FieldName = "RqCheckOutTime"
        Me.RqChkOut.Name = "RqChkOut"
        Me.RqChkOut.ToolTip = "Request Check-Out Time"
        Me.RqChkOut.Visible = True
        Me.RqChkOut.VisibleIndex = 12
        Me.RqChkOut.Width = 111
        '
        'ChkOutRv
        '
        Me.ChkOutRv.AppearanceCell.Options.UseTextOptions = True
        Me.ChkOutRv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChkOutRv.AppearanceHeader.Options.UseTextOptions = True
        Me.ChkOutRv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChkOutRv.Caption = "Chk-Out Rv"
        Me.ChkOutRv.FieldName = "CheckOutRv"
        Me.ChkOutRv.Name = "ChkOutRv"
        Me.ChkOutRv.ToolTip = "Check-Out Revised"
        Me.ChkOutRv.Visible = True
        Me.ChkOutRv.VisibleIndex = 10
        Me.ChkOutRv.Width = 69
        '
        'RqChkIn
        '
        Me.RqChkIn.AppearanceHeader.Options.UseTextOptions = True
        Me.RqChkIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RqChkIn.Caption = "Rq Chk-In Time"
        Me.RqChkIn.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RqChkIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RqChkIn.FieldName = "RqCheckInTime"
        Me.RqChkIn.Name = "RqChkIn"
        Me.RqChkIn.ToolTip = "Request Check-In Time"
        Me.RqChkIn.Visible = True
        Me.RqChkIn.VisibleIndex = 11
        Me.RqChkIn.Width = 111
        '
        'ChkInRv
        '
        Me.ChkInRv.AppearanceCell.Options.UseTextOptions = True
        Me.ChkInRv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChkInRv.AppearanceHeader.Options.UseTextOptions = True
        Me.ChkInRv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChkInRv.Caption = "Check-In Rv"
        Me.ChkInRv.FieldName = "CheckInRv"
        Me.ChkInRv.Name = "ChkInRv"
        Me.ChkInRv.ToolTip = "Check-In Revised"
        Me.ChkInRv.Visible = True
        Me.ChkInRv.VisibleIndex = 9
        Me.ChkInRv.Width = 72
        '
        'ShfEnd
        '
        Me.ShfEnd.AppearanceCell.Options.UseTextOptions = True
        Me.ShfEnd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ShfEnd.AppearanceHeader.Options.UseTextOptions = True
        Me.ShfEnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ShfEnd.Caption = "Shift End"
        Me.ShfEnd.FieldName = "ShiftEnd"
        Me.ShfEnd.Name = "ShfEnd"
        Me.ShfEnd.ToolTip = "Shift End"
        Me.ShfEnd.Visible = True
        Me.ShfEnd.VisibleIndex = 6
        Me.ShfEnd.Width = 59
        '
        'ShfStart
        '
        Me.ShfStart.AppearanceCell.Options.UseTextOptions = True
        Me.ShfStart.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ShfStart.AppearanceHeader.Options.UseTextOptions = True
        Me.ShfStart.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ShfStart.Caption = "Shift Start"
        Me.ShfStart.FieldName = "ShiftStart"
        Me.ShfStart.Name = "ShfStart"
        Me.ShfStart.ToolTip = "Shift Strat"
        Me.ShfStart.Visible = True
        Me.ShfStart.VisibleIndex = 5
        Me.ShfStart.Width = 65
        '
        'ShfCode
        '
        Me.ShfCode.AppearanceCell.Options.UseTextOptions = True
        Me.ShfCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ShfCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ShfCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ShfCode.Caption = "Shift Code"
        Me.ShfCode.FieldName = "ShiftCode"
        Me.ShfCode.Name = "ShfCode"
        Me.ShfCode.ToolTip = "Shift Code"
        Me.ShfCode.Visible = True
        Me.ShfCode.VisibleIndex = 4
        Me.ShfCode.Width = 67
        '
        'saveDia
        '
        Me.saveDia.Filter = "Excel 2007 | *.xlsx"
        '
        'EmpName
        '
        Me.EmpName.AppearanceHeader.Options.UseTextOptions = True
        Me.EmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmpName.Caption = "Emp Name"
        Me.EmpName.FieldName = "EmpName"
        Me.EmpName.Name = "EmpName"
        Me.EmpName.ToolTip = "Employee Name"
        Me.EmpName.Visible = True
        Me.EmpName.VisibleIndex = 2
        Me.EmpName.Width = 153
        '
        'GrpCode
        '
        Me.GrpCode.AppearanceHeader.Options.UseTextOptions = True
        Me.GrpCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GrpCode.Caption = "Department"
        Me.GrpCode.FieldName = "ShiftGroup"
        Me.GrpCode.Name = "GrpCode"
        Me.GrpCode.ToolTip = "Department"
        Me.GrpCode.Visible = True
        Me.GrpCode.VisibleIndex = 3
        Me.GrpCode.Width = 80
        '
        'WkDay
        '
        Me.WkDay.AppearanceCell.Options.UseTextOptions = True
        Me.WkDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WkDay.AppearanceHeader.Options.UseTextOptions = True
        Me.WkDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WkDay.Caption = "Work Day"
        Me.WkDay.FieldName = "WorkDay"
        Me.WkDay.Name = "WkDay"
        Me.WkDay.Visible = True
        Me.WkDay.VisibleIndex = 0
        '
        'gvErrUsed
        '
        Me.gvErrUsed.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WkDay, Me.EmpID, Me.EmpName, Me.GrpCode, Me.ShfCode, Me.ShfStart, Me.ShfEnd, Me.FChkIn, Me.LChkOut, Me.ChkInRv, Me.ChkOutRv, Me.RqChkIn, Me.RqChkOut, Me.RqShift, Me.RvInAt, Me.RvOutAt, Me.RvBy, Me.RvReason, Me.Remark, Me.ChkInApprState, Me.ChkOutApprState})
        Me.gvErrUsed.GridControl = Me.gcErrUsed
        Me.gvErrUsed.Name = "gvErrUsed"
        Me.gvErrUsed.OptionsBehavior.Editable = False
        Me.gvErrUsed.OptionsView.ColumnAutoWidth = False
        Me.gvErrUsed.OptionsView.ShowGroupPanel = False
        '
        'EmpID
        '
        Me.EmpID.AppearanceCell.Options.UseTextOptions = True
        Me.EmpID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmpID.AppearanceHeader.Options.UseTextOptions = True
        Me.EmpID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmpID.Caption = "Emp ID"
        Me.EmpID.FieldName = "EmpID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.ToolTip = "Employee ID"
        Me.EmpID.Visible = True
        Me.EmpID.VisibleIndex = 1
        Me.EmpID.Width = 57
        '
        'FChkIn
        '
        Me.FChkIn.Caption = "F Chk-In"
        Me.FChkIn.FieldName = "FirstCheckIn"
        Me.FChkIn.Name = "FChkIn"
        Me.FChkIn.ToolTip = "First Check-In"
        Me.FChkIn.Visible = True
        Me.FChkIn.VisibleIndex = 7
        Me.FChkIn.Width = 111
        '
        'LChkOut
        '
        Me.LChkOut.Caption = "L Chk-Out"
        Me.LChkOut.FieldName = "LastCheckOut"
        Me.LChkOut.Name = "LChkOut"
        Me.LChkOut.ToolTip = "Last Check-Out"
        Me.LChkOut.Visible = True
        Me.LChkOut.VisibleIndex = 8
        Me.LChkOut.Width = 111
        '
        'RvReason
        '
        Me.RvReason.AppearanceHeader.Options.UseTextOptions = True
        Me.RvReason.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RvReason.Caption = "Rv Reason"
        Me.RvReason.FieldName = "RvReason"
        Me.RvReason.Name = "RvReason"
        Me.RvReason.ToolTip = "Revised Reason"
        Me.RvReason.Visible = True
        Me.RvReason.VisibleIndex = 17
        Me.RvReason.Width = 134
        '
        'ChkInApprState
        '
        Me.ChkInApprState.Caption = "Chk-In Appr State"
        Me.ChkInApprState.FieldName = "ChkInApprState"
        Me.ChkInApprState.Name = "ChkInApprState"
        Me.ChkInApprState.ToolTip = "Check-In Approve Status"
        Me.ChkInApprState.Visible = True
        Me.ChkInApprState.VisibleIndex = 19
        Me.ChkInApprState.Width = 98
        '
        'ChkOutApprState
        '
        Me.ChkOutApprState.Caption = "ChkOutApprState"
        Me.ChkOutApprState.FieldName = "ChkOutApprState"
        Me.ChkOutApprState.Name = "ChkOutApprState"
        Me.ChkOutApprState.ToolTip = "Check-Out Approve Status"
        Me.ChkOutApprState.Visible = True
        Me.ChkOutApprState.VisibleIndex = 20
        Me.ChkOutApprState.Width = 95
        '
        'gcErrUsed
        '
        Me.gcErrUsed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcErrUsed.Location = New System.Drawing.Point(2, 2)
        Me.gcErrUsed.MainView = Me.gvErrUsed
        Me.gcErrUsed.Name = "gcErrUsed"
        Me.gcErrUsed.Size = New System.Drawing.Size(1186, 554)
        Me.gcErrUsed.TabIndex = 0
        Me.gcErrUsed.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvErrUsed})
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcErrUsed)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1190, 558)
        Me.PanelControl2.TabIndex = 3
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(586, 15)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(513, 20)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Records"
        '
        'lblTotal
        '
        Me.lblTotal.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(471, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(6, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "0"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(401, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Showing"
        '
        'btnGo
        '
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.Location = New System.Drawing.Point(253, 10)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(69, 23)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(129, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "To"
        '
        'toDate
        '
        Me.toDate.EditValue = Nothing
        Me.toDate.Location = New System.Drawing.Point(147, 12)
        Me.toDate.Name = "toDate"
        Me.toDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.toDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.toDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.toDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.toDate.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.toDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.toDate.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.toDate.Size = New System.Drawing.Size(100, 20)
        Me.toDate.TabIndex = 1
        '
        'fromDate
        '
        Me.fromDate.EditValue = Nothing
        Me.fromDate.Location = New System.Drawing.Point(23, 12)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fromDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.fromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fromDate.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.fromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fromDate.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.fromDate.Size = New System.Drawing.Size(100, 20)
        Me.fromDate.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.lblTotal)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.btnGo)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.toDate)
        Me.PanelControl1.Controls.Add(Me.fromDate)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1190, 48)
        Me.PanelControl1.TabIndex = 2
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'Remark
        '
        Me.Remark.Caption = "Reason Desc"
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 18
        '
        'FrmErrUsed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 606)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmErrUsed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERR USED"
        CType(Me.gvErrUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcErrUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.toDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fromDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openDia As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RvOutAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RvInAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RvBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqShift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqChkOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkOutRv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqChkIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkInRv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShfEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShfStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShfCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saveDia As System.Windows.Forms.SaveFileDialog
    Friend WithEvents EmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WkDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvErrUsed As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmpID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcErrUsed As DevExpress.XtraGrid.GridControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents toDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents fromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RvReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents FChkIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LChkOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkInApprState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkOutApprState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
End Class
