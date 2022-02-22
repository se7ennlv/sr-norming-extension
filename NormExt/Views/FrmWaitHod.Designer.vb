<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWaitHod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWaitHod))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gcWaitHoD = New DevExpress.XtraGrid.GridControl()
        Me.gvWaitHoD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WkDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmpID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShfCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShfStart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShfEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RqShf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RvBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InApprState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OutApprState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), True, True)
        Me.saveDia = New System.Windows.Forms.SaveFileDialog()
        Me.openDia = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcWaitHoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWaitHoD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.lblTotal)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.btnGo)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtDateTo)
        Me.PanelControl1.Controls.Add(Me.txtDateFrom)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1150, 48)
        Me.PanelControl1.TabIndex = 0
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
        'txtDateTo
        '
        Me.txtDateTo.EditValue = Nothing
        Me.txtDateTo.Location = New System.Drawing.Point(147, 12)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.txtDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateTo.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.txtDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateTo.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.txtDateTo.Size = New System.Drawing.Size(100, 20)
        Me.txtDateTo.TabIndex = 1
        '
        'txtDateFrom
        '
        Me.txtDateFrom.EditValue = Nothing
        Me.txtDateFrom.Location = New System.Drawing.Point(23, 12)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.txtDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateFrom.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.txtDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateFrom.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.txtDateFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtDateFrom.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcWaitHoD)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1150, 518)
        Me.PanelControl2.TabIndex = 1
        '
        'gcWaitHoD
        '
        Me.gcWaitHoD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcWaitHoD.Location = New System.Drawing.Point(2, 2)
        Me.gcWaitHoD.MainView = Me.gvWaitHoD
        Me.gcWaitHoD.Name = "gcWaitHoD"
        Me.gcWaitHoD.Size = New System.Drawing.Size(1146, 514)
        Me.gcWaitHoD.TabIndex = 0
        Me.gcWaitHoD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWaitHoD})
        '
        'gvWaitHoD
        '
        Me.gvWaitHoD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WkDay, Me.EmpID, Me.EmpName, Me.GrpCode, Me.ShfCode, Me.ShfStart, Me.ShfEnd, Me.ChkIn, Me.ChkOut, Me.RqIn, Me.RqOut, Me.RqShf, Me.RvBy, Me.InApprState, Me.OutApprState})
        Me.gvWaitHoD.GridControl = Me.gcWaitHoD
        Me.gvWaitHoD.Name = "gvWaitHoD"
        Me.gvWaitHoD.OptionsBehavior.Editable = False
        Me.gvWaitHoD.OptionsView.ColumnAutoWidth = False
        Me.gvWaitHoD.OptionsView.ShowGroupPanel = False
        '
        'WkDay
        '
        Me.WkDay.Caption = "Work Day"
        Me.WkDay.FieldName = "WorkDay"
        Me.WkDay.Name = "WkDay"
        Me.WkDay.Visible = True
        Me.WkDay.VisibleIndex = 0
        '
        'GrpCode
        '
        Me.GrpCode.Caption = "Department"
        Me.GrpCode.FieldName = "ShiftGroup"
        Me.GrpCode.Name = "GrpCode"
        Me.GrpCode.Visible = True
        Me.GrpCode.VisibleIndex = 2
        Me.GrpCode.Width = 80
        '
        'EmpID
        '
        Me.EmpID.Caption = "Emp ID"
        Me.EmpID.FieldName = "EmpID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Visible = True
        Me.EmpID.VisibleIndex = 1
        '
        'EmpName
        '
        Me.EmpName.Caption = "Emp Name"
        Me.EmpName.FieldName = "EmpName"
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Visible = True
        Me.EmpName.VisibleIndex = 3
        Me.EmpName.Width = 116
        '
        'ShfCode
        '
        Me.ShfCode.Caption = "Shift Code"
        Me.ShfCode.FieldName = "ShiftCode"
        Me.ShfCode.Name = "ShfCode"
        Me.ShfCode.Visible = True
        Me.ShfCode.VisibleIndex = 4
        '
        'ShfStart
        '
        Me.ShfStart.Caption = "Shift Start"
        Me.ShfStart.FieldName = "ShiftStart"
        Me.ShfStart.Name = "ShfStart"
        Me.ShfStart.Visible = True
        Me.ShfStart.VisibleIndex = 5
        '
        'ShfEnd
        '
        Me.ShfEnd.Caption = "Shift End"
        Me.ShfEnd.FieldName = "ShiftEnd"
        Me.ShfEnd.Name = "ShfEnd"
        Me.ShfEnd.Visible = True
        Me.ShfEnd.VisibleIndex = 6
        '
        'ChkIn
        '
        Me.ChkIn.Caption = "Check-In Time"
        Me.ChkIn.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.ChkIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChkIn.FieldName = "CheckInTime"
        Me.ChkIn.Name = "ChkIn"
        Me.ChkIn.Visible = True
        Me.ChkIn.VisibleIndex = 7
        Me.ChkIn.Width = 111
        '
        'ChkOut
        '
        Me.ChkOut.Caption = "Check-Out Time"
        Me.ChkOut.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.ChkOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChkOut.FieldName = "CheckOutTime"
        Me.ChkOut.Name = "ChkOut"
        Me.ChkOut.Visible = True
        Me.ChkOut.VisibleIndex = 8
        Me.ChkOut.Width = 111
        '
        'RqIn
        '
        Me.RqIn.Caption = "Req Check-In Time"
        Me.RqIn.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RqIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RqIn.FieldName = "RqCheckInTime"
        Me.RqIn.Name = "RqIn"
        Me.RqIn.Visible = True
        Me.RqIn.VisibleIndex = 9
        Me.RqIn.Width = 111
        '
        'RqOut
        '
        Me.RqOut.Caption = "Req Check-Out Time"
        Me.RqOut.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.RqOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RqOut.FieldName = "RqCheckOutTime"
        Me.RqOut.Name = "RqOut"
        Me.RqOut.Visible = True
        Me.RqOut.VisibleIndex = 10
        Me.RqOut.Width = 111
        '
        'RqShf
        '
        Me.RqShf.Caption = "Req Chg Shift Code"
        Me.RqShf.FieldName = "RqShiftCode"
        Me.RqShf.Name = "RqShf"
        Me.RqShf.Visible = True
        Me.RqShf.VisibleIndex = 11
        Me.RqShf.Width = 115
        '
        'RvBy
        '
        Me.RvBy.Caption = "Revised By"
        Me.RvBy.FieldName = "RvBy"
        Me.RvBy.Name = "RvBy"
        Me.RvBy.Visible = True
        Me.RvBy.VisibleIndex = 12
        '
        'InApprState
        '
        Me.InApprState.Caption = "In Appr State"
        Me.InApprState.FieldName = "CheckInApproveStatus"
        Me.InApprState.Name = "InApprState"
        Me.InApprState.Visible = True
        Me.InApprState.VisibleIndex = 13
        Me.InApprState.Width = 125
        '
        'OutApprState
        '
        Me.OutApprState.Caption = "Out Appr Sate"
        Me.OutApprState.FieldName = "CheckOutApproveStatus"
        Me.OutApprState.Name = "OutApprState"
        Me.OutApprState.Visible = True
        Me.OutApprState.VisibleIndex = 14
        Me.OutApprState.Width = 122
        '
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'saveDia
        '
        Me.saveDia.Filter = "Excel 2007 | *.xlsx"
        '
        'openDia
        '
        Me.openDia.FileName = "OpenFileDialog1"
        Me.openDia.Filter = "Excel 2007 | *.xlsx"
        '
        'FrmWaitHod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 566)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmWaitHod"
        Me.Text = "ATTD WAITING HOD"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gcWaitHoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWaitHoD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcWaitHoD As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvWaitHoD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents WkDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShfCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShfStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShfEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RqShf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RvBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InApprState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OutApprState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveDia As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openDia As System.Windows.Forms.OpenFileDialog
End Class
