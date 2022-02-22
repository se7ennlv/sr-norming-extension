<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHodAppr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHodAppr))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalRecord = New DevExpress.XtraEditors.LabelControl()
        Me.btnReject = New DevExpress.XtraEditors.SimpleButton()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.gcHodAppr = New DevExpress.XtraGrid.GridControl()
        Me.gvHodAppr = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.gcHodAppr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHodAppr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.btnReject)
        Me.PanelControl1.Controls.Add(Me.btnApprove)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(1422, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(124, 608)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.lblTotalRecord)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 573)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(120, 33)
        Me.PanelControl2.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(71, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Records"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblTotalRecord.Location = New System.Drawing.Point(25, 10)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalRecord.TabIndex = 0
        Me.lblTotalRecord.Text = "(0)"
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
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.gcHodAppr)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1422, 608)
        Me.PanelControl4.TabIndex = 5
        '
        'gcHodAppr
        '
        Me.gcHodAppr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcHodAppr.Location = New System.Drawing.Point(2, 2)
        Me.gcHodAppr.MainView = Me.gvHodAppr
        Me.gcHodAppr.Name = "gcHodAppr"
        Me.gcHodAppr.Size = New System.Drawing.Size(1418, 604)
        Me.gcHodAppr.TabIndex = 2
        Me.gcHodAppr.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHodAppr})
        '
        'gvHodAppr
        '
        Me.gvHodAppr.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col0, Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8, Me.col9, Me.col10, Me.col11, Me.col12, Me.col13, Me.col14, Me.col15, Me.col16, Me.col17, Me.col18, Me.col19})
        Me.gvHodAppr.GridControl = Me.gcHodAppr
        Me.gvHodAppr.Name = "gvHodAppr"
        Me.gvHodAppr.OptionsBehavior.Editable = False
        Me.gvHodAppr.OptionsBehavior.ReadOnly = True
        Me.gvHodAppr.OptionsCustomization.AllowColumnMoving = False
        Me.gvHodAppr.OptionsFind.AlwaysVisible = True
        Me.gvHodAppr.OptionsSelection.MultiSelect = True
        Me.gvHodAppr.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvHodAppr.OptionsView.ColumnAutoWidth = False
        Me.gvHodAppr.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvHodAppr.OptionsView.ShowGroupPanel = False
        Me.gvHodAppr.OptionsView.ShowIndicator = False
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
        Me.col1.Caption = "Wk-Date"
        Me.col1.FieldName = "WorkDay"
        Me.col1.Name = "col1"
        Me.col1.ToolTip = "Work Date"
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 2
        Me.col1.Width = 68
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
        Me.col3.Width = 58
        '
        'col4
        '
        Me.col4.Caption = "Emp Name"
        Me.col4.FieldName = "EmpName"
        Me.col4.Name = "col4"
        Me.col4.ToolTip = "Employee Name"
        Me.col4.Visible = True
        Me.col4.VisibleIndex = 5
        Me.col4.Width = 108
        '
        'col5
        '
        Me.col5.Caption = "Shift Code"
        Me.col5.FieldName = "ShiftCode"
        Me.col5.Name = "col5"
        Me.col5.ToolTip = "Shift Code"
        Me.col5.Visible = True
        Me.col5.VisibleIndex = 6
        Me.col5.Width = 58
        '
        'col6
        '
        Me.col6.Caption = "Shift Start"
        Me.col6.FieldName = "ShiftStart"
        Me.col6.Name = "col6"
        Me.col6.ToolTip = "Shift Start"
        Me.col6.Visible = True
        Me.col6.VisibleIndex = 7
        Me.col6.Width = 57
        '
        'col7
        '
        Me.col7.Caption = "Shift End"
        Me.col7.FieldName = "ShiftEnd"
        Me.col7.Name = "col7"
        Me.col7.ToolTip = "Shift End"
        Me.col7.Visible = True
        Me.col7.VisibleIndex = 8
        Me.col7.Width = 53
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
        Me.col10.Caption = "Req Chg Time-In"
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
        Me.col11.Caption = "Rev Time-In Sub Date"
        Me.col11.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col11.FieldName = "RvCheckInTime"
        Me.col11.Name = "col11"
        Me.col11.ToolTip = "Revised Time-In Submitted Date"
        Me.col11.Visible = True
        Me.col11.VisibleIndex = 12
        Me.col11.Width = 111
        '
        'col12
        '
        Me.col12.Caption = "Req Chg Time-Out"
        Me.col12.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col12.FieldName = "RqCheckOutTime"
        Me.col12.Name = "col12"
        Me.col12.ToolTip = "Request Change Time-Out"
        Me.col12.Visible = True
        Me.col12.VisibleIndex = 13
        Me.col12.Width = 111
        '
        'col13
        '
        Me.col13.Caption = "Rev Time-Out Sub Date"
        Me.col13.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col13.FieldName = "RvCheckOutTime"
        Me.col13.Name = "col13"
        Me.col13.ToolTip = "Revised Time-Out Submitted Date"
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
        Me.col14.Width = 103
        '
        'col15
        '
        Me.col15.Caption = "Revised By"
        Me.col15.FieldName = "RvBy"
        Me.col15.Name = "col15"
        Me.col15.ToolTip = "Revised By"
        Me.col15.Visible = True
        Me.col15.VisibleIndex = 16
        Me.col15.Width = 69
        '
        'col16
        '
        Me.col16.Caption = "Reason"
        Me.col16.FieldName = "RvReason"
        Me.col16.Name = "col16"
        Me.col16.ToolTip = "Reason"
        Me.col16.Visible = True
        Me.col16.VisibleIndex = 17
        Me.col16.Width = 103
        '
        'col17
        '
        Me.col17.Caption = "Reason Desc"
        Me.col17.FieldName = "Remark"
        Me.col17.Name = "col17"
        Me.col17.ToolTip = "Reason Description"
        Me.col17.Visible = True
        Me.col17.VisibleIndex = 18
        Me.col17.Width = 301
        '
        'col18
        '
        Me.col18.Caption = "CheckInApproveStatus"
        Me.col18.FieldName = "CheckInApproveStatus"
        Me.col18.Name = "col18"
        Me.col18.Width = 101
        '
        'col19
        '
        Me.col19.Caption = "CheckOutApproveStatus"
        Me.col19.FieldName = "CheckOutApproveStatus"
        Me.col19.Name = "col19"
        Me.col19.Width = 144
        '
        'frmHodAppr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1546, 608)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHodAppr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WAITING APPROVAL (HOD)"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.gcHodAppr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHodAppr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalRecord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcHodAppr As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvHodAppr As DevExpress.XtraGrid.Views.Grid.GridView
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
End Class
