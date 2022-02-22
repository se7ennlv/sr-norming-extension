<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHrAttdAppr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHrAttdAppr))
        Me.btnReject = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalRecord = New DevExpress.XtraEditors.LabelControl()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OpenDia = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDia = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReject
        '
        Me.btnReject.Image = CType(resources.GetObject("btnReject.Image"), System.Drawing.Image)
        Me.btnReject.Location = New System.Drawing.Point(5, 34)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(114, 23)
        Me.btnReject.TabIndex = 1
        Me.btnReject.Text = "Reject"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.btnReject)
        Me.PanelControl1.Controls.Add(Me.btnApprove)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(1437, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(124, 546)
        Me.PanelControl1.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(5, 63)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(113, 23)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export To Excel"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.lblTotalRecord)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 510)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(120, 34)
        Me.PanelControl2.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(50, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Records"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblTotalRecord.Location = New System.Drawing.Point(16, 11)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalRecord.TabIndex = 2
        Me.lblTotalRecord.Text = "(0)"
        '
        'btnApprove
        '
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.Location = New System.Drawing.Point(5, 5)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(114, 23)
        Me.btnApprove.TabIndex = 0
        Me.btnApprove.Text = "Verify"
        '
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.gc)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1437, 546)
        Me.PanelControl4.TabIndex = 5
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(2, 2)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(1433, 542)
        Me.gc.TabIndex = 4
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col0, Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8, Me.col9, Me.col10, Me.col11, Me.col12, Me.col13, Me.col14, Me.col15, Me.col16, Me.col17, Me.col18, Me.col19, Me.col20, Me.col21, Me.col22, Me.col23, Me.col24, Me.col25})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsBehavior.ReadOnly = True
        Me.gv.OptionsFind.AlwaysVisible = True
        Me.gv.OptionsSelection.MultiSelect = True
        Me.gv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gv.OptionsView.ColumnAutoWidth = False
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowIndicator = False
        '
        'col0
        '
        Me.col0.Caption = "Doc No"
        Me.col0.FieldName = "DocNo"
        Me.col0.Name = "col0"
        Me.col0.ToolTip = "Document Number"
        Me.col0.Visible = True
        Me.col0.VisibleIndex = 1
        Me.col0.Width = 96
        '
        'col1
        '
        Me.col1.Caption = "Wk Date"
        Me.col1.FieldName = "WorkDay"
        Me.col1.Name = "col1"
        Me.col1.ToolTip = "Work Date"
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 2
        Me.col1.Width = 81
        '
        'col2
        '
        Me.col2.Caption = "Grp Code"
        Me.col2.FieldName = "GroupCode"
        Me.col2.Name = "col2"
        Me.col2.ToolTip = "Group Code"
        Me.col2.Visible = True
        Me.col2.VisibleIndex = 3
        '
        'col3
        '
        Me.col3.Caption = "Emp ID"
        Me.col3.FieldName = "EmpID"
        Me.col3.Name = "col3"
        Me.col3.ToolTip = "Employee ID"
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 4
        Me.col3.Width = 71
        '
        'col4
        '
        Me.col4.Caption = "Emp Name"
        Me.col4.FieldName = "EmpName"
        Me.col4.Name = "col4"
        Me.col4.ToolTip = "Employee Name"
        Me.col4.Visible = True
        Me.col4.VisibleIndex = 5
        Me.col4.Width = 129
        '
        'col5
        '
        Me.col5.AppearanceCell.Options.UseTextOptions = True
        Me.col5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col5.Caption = "Shift Code"
        Me.col5.FieldName = "ShiftCode"
        Me.col5.Name = "col5"
        Me.col5.ToolTip = "Shift Code"
        Me.col5.Visible = True
        Me.col5.VisibleIndex = 6
        Me.col5.Width = 65
        '
        'col6
        '
        Me.col6.AppearanceCell.Options.UseTextOptions = True
        Me.col6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col6.Caption = "Shift Start"
        Me.col6.FieldName = "ShiftStart"
        Me.col6.Name = "col6"
        Me.col6.ToolTip = "Shift Start"
        Me.col6.Visible = True
        Me.col6.VisibleIndex = 7
        Me.col6.Width = 64
        '
        'col7
        '
        Me.col7.AppearanceCell.Options.UseTextOptions = True
        Me.col7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col7.Caption = "Shift End"
        Me.col7.FieldName = "ShiftEnd"
        Me.col7.Name = "col7"
        Me.col7.ToolTip = "Shift End"
        Me.col7.Visible = True
        Me.col7.VisibleIndex = 8
        Me.col7.Width = 64
        '
        'col8
        '
        Me.col8.Caption = "Is Chk-In"
        Me.col8.FieldName = "IsCheckIn"
        Me.col8.Name = "col8"
        Me.col8.ToolTip = "Is Check-In"
        Me.col8.Visible = True
        Me.col8.VisibleIndex = 9
        Me.col8.Width = 57
        '
        'col9
        '
        Me.col9.Caption = "Chk-In Time"
        Me.col9.DisplayFormat.FormatString = "HH:mm:ss"
        Me.col9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col9.FieldName = "CheckInTime"
        Me.col9.Name = "col9"
        Me.col9.ToolTip = "Check-In Time"
        Me.col9.Visible = True
        Me.col9.VisibleIndex = 10
        Me.col9.Width = 111
        '
        'col10
        '
        Me.col10.Caption = "Is Chk-Out"
        Me.col10.FieldName = "IsCheckOut"
        Me.col10.Name = "col10"
        Me.col10.ToolTip = "Is Check-Out"
        Me.col10.Visible = True
        Me.col10.VisibleIndex = 11
        Me.col10.Width = 61
        '
        'col11
        '
        Me.col11.Caption = "Chk-Out Time"
        Me.col11.DisplayFormat.FormatString = "HH:mm:ss"
        Me.col11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col11.FieldName = "CheckOutTime"
        Me.col11.Name = "col11"
        Me.col11.ToolTip = "Check-Out Time"
        Me.col11.Visible = True
        Me.col11.VisibleIndex = 12
        Me.col11.Width = 111
        '
        'col12
        '
        Me.col12.Caption = "Req Chg Time-In"
        Me.col12.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col12.FieldName = "RqCheckInTime"
        Me.col12.Name = "col12"
        Me.col12.ToolTip = "Request Change Time-In"
        Me.col12.Visible = True
        Me.col12.VisibleIndex = 13
        Me.col12.Width = 111
        '
        'col13
        '
        Me.col13.Caption = "Req Chg Time-Out"
        Me.col13.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col13.FieldName = "RqCheckOutTime"
        Me.col13.Name = "col13"
        Me.col13.ToolTip = "Request Change Time-Out"
        Me.col13.Visible = True
        Me.col13.VisibleIndex = 14
        Me.col13.Width = 111
        '
        'col14
        '
        Me.col14.Caption = "Req Chg Shift Code"
        Me.col14.FieldName = "RqShiftCode"
        Me.col14.Name = "col14"
        Me.col14.ToolTip = "Request Change Shift Code"
        Me.col14.Visible = True
        Me.col14.VisibleIndex = 15
        Me.col14.Width = 104
        '
        'col15
        '
        Me.col15.Caption = "Reason"
        Me.col15.FieldName = "RvReason"
        Me.col15.Name = "col15"
        Me.col15.ToolTip = "Reason"
        Me.col15.Visible = True
        Me.col15.VisibleIndex = 16
        Me.col15.Width = 125
        '
        'col16
        '
        Me.col16.Caption = "Reason Desc"
        Me.col16.FieldName = "Remark"
        Me.col16.Name = "col16"
        Me.col16.ToolTip = "Reson Description"
        Me.col16.Visible = True
        Me.col16.VisibleIndex = 17
        Me.col16.Width = 211
        '
        'col17
        '
        Me.col17.Caption = "Revised By"
        Me.col17.FieldName = "RvBy"
        Me.col17.Name = "col17"
        Me.col17.ToolTip = "Revised By"
        Me.col17.Visible = True
        Me.col17.VisibleIndex = 18
        Me.col17.Width = 68
        '
        'col18
        '
        Me.col18.Caption = "Rev Chk-In Sub Date"
        Me.col18.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col18.FieldName = "RvCheckInTime"
        Me.col18.Name = "col18"
        Me.col18.ToolTip = "Revised Check-In Submitted Date"
        Me.col18.Visible = True
        Me.col18.VisibleIndex = 19
        Me.col18.Width = 111
        '
        'col19
        '
        Me.col19.Caption = "Rev Chk-Out Sub Date"
        Me.col19.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col19.FieldName = "RvCheckOutTime"
        Me.col19.Name = "col19"
        Me.col19.ToolTip = "Revised Check-Out Submitted Date"
        Me.col19.Visible = True
        Me.col19.VisibleIndex = 20
        Me.col19.Width = 123
        '
        'col20
        '
        Me.col20.Caption = "Rev Chk-Out At"
        Me.col20.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col20.FieldName = "RvCheckOutTime"
        Me.col20.Name = "col20"
        Me.col20.ToolTip = "Revied Check-Out At"
        Me.col20.Visible = True
        Me.col20.VisibleIndex = 21
        Me.col20.Width = 111
        '
        'col21
        '
        Me.col21.Caption = "Revied Chk-In At"
        Me.col21.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col21.FieldName = "RvCheckInTime"
        Me.col21.Name = "col21"
        Me.col21.ToolTip = "Revied Check-In At"
        Me.col21.Visible = True
        Me.col21.VisibleIndex = 22
        Me.col21.Width = 111
        '
        'col22
        '
        Me.col22.AppearanceCell.Options.UseTextOptions = True
        Me.col22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col22.Caption = "HOD Action By"
        Me.col22.FieldName = "HodActionBy"
        Me.col22.Name = "col22"
        Me.col22.ToolTip = "HOD Action By"
        Me.col22.Visible = True
        Me.col22.VisibleIndex = 23
        Me.col22.Width = 79
        '
        'col23
        '
        Me.col23.Caption = "HOD Action At"
        Me.col23.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col23.FieldName = "HodActionAt"
        Me.col23.Name = "col23"
        Me.col23.ToolTip = "HOD Action At"
        Me.col23.Visible = True
        Me.col23.VisibleIndex = 24
        Me.col23.Width = 111
        '
        'col24
        '
        Me.col24.Caption = "CheckInApproveStatus"
        Me.col24.FieldName = "CheckInApproveStatus"
        Me.col24.Name = "col24"
        Me.col24.Width = 123
        '
        'col25
        '
        Me.col25.Caption = "CheckOutApproveStatus"
        Me.col25.FieldName = "CheckOutApproveStatus"
        Me.col25.Name = "col25"
        Me.col25.Width = 154
        '
        'OpenDia
        '
        Me.OpenDia.FileName = "OpenFileDialog1"
        Me.OpenDia.Filter = "Excel 2007 | *.xlsx"
        '
        'SaveDia
        '
        Me.SaveDia.Filter = "Excel 2007 | *.xlsx"
        '
        'frmHrAttdAppr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1561, 546)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmHrAttdAppr"
        Me.Text = "WAITING VERIFY (HR ATTENDANCE)"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalRecord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenDia As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDia As System.Windows.Forms.SaveFileDialog
End Class
