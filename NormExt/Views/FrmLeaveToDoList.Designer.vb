<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveToDoList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeaveToDoList))
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DocNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LastApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequestedAt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LeaveCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LeaveType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FromDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LeaveDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmpCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dept = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Notes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequesterComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReject = New DevExpress.XtraEditors.SimpleButton()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(1554, 510)
        Me.gc.TabIndex = 5
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DocNo, Me.LastApproved, Me.RequestedAt, Me.LeaveCode, Me.LeaveType, Me.FromDate, Me.ToDate, Me.LeaveDay, Me.EmpCode, Me.EmpName, Me.dept, Me.Notes, Me.RequesterComment, Me.Status})
        Me.gv.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsBehavior.ReadOnly = True
        Me.gv.OptionsFind.AlwaysVisible = True
        Me.gv.OptionsSelection.MultiSelect = True
        Me.gv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gv.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.gv.OptionsView.ColumnAutoWidth = False
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowIndicator = False
        '
        'DocNo
        '
        Me.DocNo.AppearanceCell.Options.UseTextOptions = True
        Me.DocNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DocNo.Caption = "Doc No"
        Me.DocNo.FieldName = "DocNo"
        Me.DocNo.Name = "DocNo"
        Me.DocNo.ToolTip = "Document Number"
        Me.DocNo.Visible = True
        Me.DocNo.VisibleIndex = 1
        Me.DocNo.Width = 65
        '
        'LastApproved
        '
        Me.LastApproved.AppearanceCell.Options.UseTextOptions = True
        Me.LastApproved.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LastApproved.Caption = "Last Approved"
        Me.LastApproved.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm tt"
        Me.LastApproved.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LastApproved.FieldName = "LastApproved"
        Me.LastApproved.Name = "LastApproved"
        Me.LastApproved.ToolTip = "Last Approved"
        Me.LastApproved.Visible = True
        Me.LastApproved.VisibleIndex = 2
        Me.LastApproved.Width = 115
        '
        'RequestedAt
        '
        Me.RequestedAt.AppearanceCell.Options.UseTextOptions = True
        Me.RequestedAt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RequestedAt.Caption = "Requested At"
        Me.RequestedAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm tt"
        Me.RequestedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RequestedAt.FieldName = "RequestedAt"
        Me.RequestedAt.Name = "RequestedAt"
        Me.RequestedAt.Visible = True
        Me.RequestedAt.VisibleIndex = 3
        Me.RequestedAt.Width = 115
        '
        'LeaveCode
        '
        Me.LeaveCode.AppearanceCell.Options.UseTextOptions = True
        Me.LeaveCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LeaveCode.Caption = "Leave Code"
        Me.LeaveCode.FieldName = "LeaveCode"
        Me.LeaveCode.Name = "LeaveCode"
        Me.LeaveCode.Visible = True
        Me.LeaveCode.VisibleIndex = 4
        Me.LeaveCode.Width = 69
        '
        'LeaveType
        '
        Me.LeaveType.Caption = "Leave Type"
        Me.LeaveType.FieldName = "LeaveType"
        Me.LeaveType.Name = "LeaveType"
        Me.LeaveType.Visible = True
        Me.LeaveType.VisibleIndex = 5
        Me.LeaveType.Width = 108
        '
        'FromDate
        '
        Me.FromDate.AppearanceCell.Options.UseTextOptions = True
        Me.FromDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FromDate.Caption = "From Date"
        Me.FromDate.FieldName = "FromDate"
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Visible = True
        Me.FromDate.VisibleIndex = 6
        '
        'ToDate
        '
        Me.ToDate.AppearanceCell.Options.UseTextOptions = True
        Me.ToDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ToDate.Caption = "To Date"
        Me.ToDate.FieldName = "ToDate"
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Visible = True
        Me.ToDate.VisibleIndex = 7
        '
        'LeaveDay
        '
        Me.LeaveDay.AppearanceCell.Options.UseTextOptions = True
        Me.LeaveDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LeaveDay.Caption = "Leave Day"
        Me.LeaveDay.FieldName = "LeaveDay"
        Me.LeaveDay.Name = "LeaveDay"
        Me.LeaveDay.Visible = True
        Me.LeaveDay.VisibleIndex = 8
        Me.LeaveDay.Width = 63
        '
        'EmpCode
        '
        Me.EmpCode.Caption = "Emp ID"
        Me.EmpCode.FieldName = "EmpCode"
        Me.EmpCode.Name = "EmpCode"
        Me.EmpCode.Visible = True
        Me.EmpCode.VisibleIndex = 9
        Me.EmpCode.Width = 58
        '
        'EmpName
        '
        Me.EmpName.Caption = "Emp Name"
        Me.EmpName.FieldName = "EmpName"
        Me.EmpName.Name = "EmpName"
        Me.EmpName.ToolTip = "Name"
        Me.EmpName.Visible = True
        Me.EmpName.VisibleIndex = 10
        Me.EmpName.Width = 142
        '
        'dept
        '
        Me.dept.Caption = "Department"
        Me.dept.FieldName = "Dept"
        Me.dept.Name = "dept"
        Me.dept.Visible = True
        Me.dept.VisibleIndex = 11
        Me.dept.Width = 119
        '
        'Notes
        '
        Me.Notes.Caption = "Notes"
        Me.Notes.FieldName = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.Visible = True
        Me.Notes.VisibleIndex = 12
        Me.Notes.Width = 170
        '
        'RequesterComment
        '
        Me.RequesterComment.Caption = "Requester Comments"
        Me.RequesterComment.FieldName = "RequesterComment"
        Me.RequesterComment.Name = "RequesterComment"
        Me.RequesterComment.Visible = True
        Me.RequesterComment.VisibleIndex = 13
        Me.RequesterComment.Width = 215
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 14
        Me.Status.Width = 246
        '
        'btnApprove
        '
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.Location = New System.Drawing.Point(513, 12)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(79, 23)
        Me.btnApprove.TabIndex = 6
        Me.btnApprove.Text = "Approve"
        '
        'btnReject
        '
        Me.btnReject.Image = CType(resources.GetObject("btnReject.Image"), System.Drawing.Image)
        Me.btnReject.Location = New System.Drawing.Point(598, 12)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(79, 23)
        Me.btnReject.TabIndex = 7
        Me.btnReject.Text = "Reject"
        '
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'FrmLeaveToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 510)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.gc)
        Me.Name = "FrmLeaveToDoList"
        Me.Text = "LEAVE APPROVAL"
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DocNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LastApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents EmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequestedAt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LeaveType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FromDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LeaveDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Notes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequesterComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LeaveCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dept As DevExpress.XtraGrid.Columns.GridColumn
End Class
