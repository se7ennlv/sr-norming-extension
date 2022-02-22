<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHrManaAppr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHrManaAppr))
        Me.btnReject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.gcHrDirectAppr = New DevExpress.XtraGrid.GridControl()
        Me.gvHrDirectAppr = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalRecord = New DevExpress.XtraEditors.LabelControl()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.gcHrDirectAppr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHrDirectAppr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
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
        'btnApprove
        '
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.Location = New System.Drawing.Point(5, 5)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(114, 23)
        Me.btnApprove.TabIndex = 0
        Me.btnApprove.Text = "Approve"
        '
        'gcHrDirectAppr
        '
        Me.gcHrDirectAppr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcHrDirectAppr.Location = New System.Drawing.Point(0, 0)
        Me.gcHrDirectAppr.MainView = Me.gvHrDirectAppr
        Me.gcHrDirectAppr.Name = "gcHrDirectAppr"
        Me.gcHrDirectAppr.Size = New System.Drawing.Size(1435, 579)
        Me.gcHrDirectAppr.TabIndex = 5
        Me.gcHrDirectAppr.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHrDirectAppr})
        '
        'gvHrDirectAppr
        '
        Me.gvHrDirectAppr.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col0, Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8, Me.col9, Me.col10, Me.col11, Me.col12, Me.col13, Me.col14, Me.col15, Me.col16, Me.col17, Me.col18, Me.col19, Me.col20, Me.col21})
        Me.gvHrDirectAppr.GridControl = Me.gcHrDirectAppr
        Me.gvHrDirectAppr.Name = "gvHrDirectAppr"
        Me.gvHrDirectAppr.OptionsBehavior.Editable = False
        Me.gvHrDirectAppr.OptionsBehavior.ReadOnly = True
        Me.gvHrDirectAppr.OptionsFind.AlwaysVisible = True
        Me.gvHrDirectAppr.OptionsSelection.MultiSelect = True
        Me.gvHrDirectAppr.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvHrDirectAppr.OptionsView.ColumnAutoWidth = False
        Me.gvHrDirectAppr.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvHrDirectAppr.OptionsView.ShowGroupPanel = False
        Me.gvHrDirectAppr.OptionsView.ShowIndicator = False
        '
        'col0
        '
        Me.col0.Caption = "Doc No"
        Me.col0.FieldName = "DocNo"
        Me.col0.Name = "col0"
        Me.col0.ToolTip = "Document Number"
        Me.col0.Visible = True
        Me.col0.VisibleIndex = 1
        Me.col0.Width = 90
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
        Me.col8.Caption = "Chk-In Time"
        Me.col8.DisplayFormat.FormatString = "HH:mm:ss"
        Me.col8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col8.FieldName = "CheckInTime"
        Me.col8.Name = "col8"
        Me.col8.ToolTip = "Check-In Time"
        Me.col8.Visible = True
        Me.col8.VisibleIndex = 9
        Me.col8.Width = 111
        '
        'col9
        '
        Me.col9.Caption = "Chk-Out Time"
        Me.col9.DisplayFormat.FormatString = "HH:mm:ss"
        Me.col9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col9.FieldName = "CheckOutTime"
        Me.col9.Name = "col9"
        Me.col9.ToolTip = "Check-Out Time"
        Me.col9.Visible = True
        Me.col9.VisibleIndex = 10
        Me.col9.Width = 111
        '
        'col10
        '
        Me.col10.Caption = "Req Chg Time In"
        Me.col10.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col10.FieldName = "RqCheckInTime"
        Me.col10.Name = "col10"
        Me.col10.ToolTip = "Request Change Time-In"
        Me.col10.Visible = True
        Me.col10.VisibleIndex = 11
        Me.col10.Width = 111
        '
        'col11
        '
        Me.col11.Caption = "Req Chg Time Out"
        Me.col11.DisplayFormat.FormatString = "yyy-MM-dd HH:mm:ss"
        Me.col11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col11.FieldName = "RqCheckOutTime"
        Me.col11.Name = "col11"
        Me.col11.ToolTip = "Request Change Time-Out"
        Me.col11.Visible = True
        Me.col11.VisibleIndex = 12
        Me.col11.Width = 111
        '
        'col12
        '
        Me.col12.Caption = "Req Chg Shift Code"
        Me.col12.FieldName = "RqShiftCode"
        Me.col12.Name = "col12"
        Me.col12.ToolTip = "Request Change Shift Code"
        Me.col12.Visible = True
        Me.col12.VisibleIndex = 13
        Me.col12.Width = 104
        '
        'col13
        '
        Me.col13.Caption = "Reason"
        Me.col13.FieldName = "RvReason"
        Me.col13.Name = "col13"
        Me.col13.ToolTip = "Reason"
        Me.col13.Visible = True
        Me.col13.VisibleIndex = 14
        Me.col13.Width = 125
        '
        'col14
        '
        Me.col14.Caption = "Reason Desc"
        Me.col14.FieldName = "Remark"
        Me.col14.Name = "col14"
        Me.col14.ToolTip = "Reason Description"
        Me.col14.Visible = True
        Me.col14.VisibleIndex = 15
        Me.col14.Width = 190
        '
        'col15
        '
        Me.col15.Caption = "Revised By"
        Me.col15.FieldName = "RvBy"
        Me.col15.Name = "col15"
        Me.col15.ToolTip = "Revised By"
        Me.col15.Visible = True
        Me.col15.VisibleIndex = 16
        Me.col15.Width = 68
        '
        'col16
        '
        Me.col16.Caption = "Rev Chk-In Sub Date"
        Me.col16.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col16.FieldName = "RvCheckInTime"
        Me.col16.Name = "col16"
        Me.col16.ToolTip = "Revised Chk-In Submitted Date"
        Me.col16.Visible = True
        Me.col16.VisibleIndex = 17
        Me.col16.Width = 111
        '
        'col17
        '
        Me.col17.Caption = "Rev Chk-Out Sub Date"
        Me.col17.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col17.FieldName = "RvCheckOutTime"
        Me.col17.Name = "col17"
        Me.col17.ToolTip = "Revised Chk-Out Submitted Date"
        Me.col17.Visible = True
        Me.col17.VisibleIndex = 18
        Me.col17.Width = 111
        '
        'col18
        '
        Me.col18.Caption = "HOD Action By"
        Me.col18.FieldName = "HodActionBy"
        Me.col18.Name = "col18"
        Me.col18.ToolTip = "HOD Action By"
        Me.col18.Visible = True
        Me.col18.VisibleIndex = 19
        Me.col18.Width = 81
        '
        'col19
        '
        Me.col19.Caption = "HOD Action At"
        Me.col19.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col19.FieldName = "HodActionAt"
        Me.col19.Name = "col19"
        Me.col19.ToolTip = "HOD Action At"
        Me.col19.Visible = True
        Me.col19.VisibleIndex = 20
        Me.col19.Width = 111
        '
        'col20
        '
        Me.col20.Caption = "CheckInApproveStatus"
        Me.col20.FieldName = "CheckInApproveStatus"
        Me.col20.Name = "col20"
        Me.col20.Width = 123
        '
        'col21
        '
        Me.col21.Caption = "CheckOutApproveStatus"
        Me.col21.FieldName = "CheckOutApproveStatus"
        Me.col21.Name = "col21"
        Me.col21.Width = 154
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.btnReject)
        Me.PanelControl1.Controls.Add(Me.btnApprove)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(1435, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(124, 579)
        Me.PanelControl1.TabIndex = 4
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.lblTotalRecord)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 545)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(120, 32)
        Me.PanelControl2.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(59, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Records"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblTotalRecord.Location = New System.Drawing.Point(20, 11)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalRecord.TabIndex = 0
        Me.lblTotalRecord.Text = "(0)"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'bgWorker
        '
        '
        'FrmHrManaAppr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1559, 579)
        Me.Controls.Add(Me.gcHrDirectAppr)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmHrManaAppr"
        Me.Text = "WAITING APPROVAL (HR MANAGER)"
        CType(Me.gcHrDirectAppr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHrDirectAppr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcHrDirectAppr As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvHrDirectAppr As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalRecord As DevExpress.XtraEditors.LabelControl
End Class
