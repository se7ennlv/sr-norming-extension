<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportMyMart
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lueGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.deFrom = New DevExpress.XtraEditors.DateEdit()
        Me.deTo = New DevExpress.XtraEditors.DateEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPreview = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsd = New DevExpress.XtraEditors.TextEdit()
        Me.txtLak = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.gcEmpCreditList = New DevExpress.XtraGrid.GridControl()
        Me.gvEmpCreditList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.position = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dept = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.creditBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.afterExchange = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.lblState = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.lueGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtUsd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gcEmpCreditList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmpCreditList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Period:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(210, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 89)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Pay Group:"
        '
        'lueGroup
        '
        Me.lueGroup.Location = New System.Drawing.Point(69, 86)
        Me.lueGroup.Name = "lueGroup"
        Me.lueGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueGroup.Properties.DisplayMember = "PRGROUP_GROUPNAME"
        Me.lueGroup.Properties.ValueMember = "PRGROUP_GROUPNAME"
        Me.lueGroup.Size = New System.Drawing.Size(120, 20)
        Me.lueGroup.TabIndex = 11
        '
        'deFrom
        '
        Me.deFrom.EditValue = Nothing
        Me.deFrom.Location = New System.Drawing.Point(69, 41)
        Me.deFrom.Name = "deFrom"
        Me.deFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFrom.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFrom.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.deFrom.Size = New System.Drawing.Size(120, 20)
        Me.deFrom.TabIndex = 12
        '
        'deTo
        '
        Me.deTo.EditValue = Nothing
        Me.deTo.Location = New System.Drawing.Point(243, 41)
        Me.deTo.Name = "deTo"
        Me.deTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTo.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.deTo.Size = New System.Drawing.Size(120, 20)
        Me.deTo.TabIndex = 13
        '
        'Timer1
        '
        '
        'bgWorker
        '
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.btnPreview)
        Me.GroupControl4.Controls.Add(Me.deTo)
        Me.GroupControl4.Controls.Add(Me.deFrom)
        Me.GroupControl4.Controls.Add(Me.lueGroup)
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.LabelControl2)
        Me.GroupControl4.Controls.Add(Me.LabelControl1)
        Me.GroupControl4.Location = New System.Drawing.Point(12, 170)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(375, 127)
        Me.GroupControl4.TabIndex = 17
        Me.GroupControl4.Text = "Step 2: Selection"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(243, 84)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(120, 23)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "Preview"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnSave)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.txtUsd)
        Me.GroupControl3.Controls.Add(Me.txtLak)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(375, 152)
        Me.GroupControl3.TabIndex = 16
        Me.GroupControl3.Text = "Setp 1: Exchange Rate"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(46, 99)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Change"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(152, 66)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "USD = 1 THB"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(152, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "LAK = 1 THB"
        '
        'txtUsd
        '
        Me.txtUsd.Location = New System.Drawing.Point(46, 63)
        Me.txtUsd.Name = "txtUsd"
        Me.txtUsd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUsd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUsd.Size = New System.Drawing.Size(100, 20)
        Me.txtUsd.TabIndex = 1
        '
        'txtLak
        '
        Me.txtLak.Location = New System.Drawing.Point(46, 37)
        Me.txtLak.Name = "txtLak"
        Me.txtLak.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLak.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLak.Size = New System.Drawing.Size(100, 20)
        Me.txtLak.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.gcEmpCreditList)
        Me.GroupControl2.Location = New System.Drawing.Point(393, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(904, 586)
        Me.GroupControl2.TabIndex = 17
        Me.GroupControl2.Text = "Preview Data"
        '
        'gcEmpCreditList
        '
        Me.gcEmpCreditList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEmpCreditList.Location = New System.Drawing.Point(2, 20)
        Me.gcEmpCreditList.MainView = Me.gvEmpCreditList
        Me.gcEmpCreditList.Name = "gcEmpCreditList"
        Me.gcEmpCreditList.Size = New System.Drawing.Size(900, 564)
        Me.gcEmpCreditList.TabIndex = 0
        Me.gcEmpCreditList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmpCreditList})
        '
        'gvEmpCreditList
        '
        Me.gvEmpCreditList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.empId, Me.empName, Me.position, Me.dept, Me.creditBalance, Me.currency, Me.rate, Me.afterExchange})
        Me.gvEmpCreditList.GridControl = Me.gcEmpCreditList
        Me.gvEmpCreditList.Name = "gvEmpCreditList"
        Me.gvEmpCreditList.OptionsBehavior.Editable = False
        Me.gvEmpCreditList.OptionsBehavior.ReadOnly = True
        Me.gvEmpCreditList.OptionsCustomization.AllowColumnMoving = False
        Me.gvEmpCreditList.OptionsFind.AlwaysVisible = True
        Me.gvEmpCreditList.OptionsView.ShowFooter = True
        Me.gvEmpCreditList.OptionsView.ShowGroupPanel = False
        '
        'empId
        '
        Me.empId.AppearanceCell.Options.UseTextOptions = True
        Me.empId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.empId.AppearanceHeader.Options.UseTextOptions = True
        Me.empId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.empId.Caption = "Emp ID"
        Me.empId.FieldName = "EmpCode"
        Me.empId.Name = "empId"
        Me.empId.Visible = True
        Me.empId.VisibleIndex = 0
        Me.empId.Width = 60
        '
        'empName
        '
        Me.empName.AppearanceHeader.Options.UseTextOptions = True
        Me.empName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.empName.Caption = "Emp Name"
        Me.empName.FieldName = "FullName"
        Me.empName.Name = "empName"
        Me.empName.Visible = True
        Me.empName.VisibleIndex = 1
        Me.empName.Width = 76
        '
        'position
        '
        Me.position.AppearanceHeader.Options.UseTextOptions = True
        Me.position.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.position.Caption = "Position"
        Me.position.FieldName = "Positions"
        Me.position.Name = "position"
        Me.position.Visible = True
        Me.position.VisibleIndex = 2
        Me.position.Width = 72
        '
        'dept
        '
        Me.dept.AppearanceCell.Options.UseTextOptions = True
        Me.dept.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dept.AppearanceHeader.Options.UseTextOptions = True
        Me.dept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dept.Caption = "Dept"
        Me.dept.FieldName = "Dept"
        Me.dept.Name = "dept"
        Me.dept.Visible = True
        Me.dept.VisibleIndex = 3
        Me.dept.Width = 65
        '
        'creditBalance
        '
        Me.creditBalance.AppearanceCell.Options.UseTextOptions = True
        Me.creditBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.creditBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.creditBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.creditBalance.Caption = "Credit Balance (THB)"
        Me.creditBalance.DisplayFormat.FormatString = "#,##0.00"
        Me.creditBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.creditBalance.FieldName = "CreditBalance"
        Me.creditBalance.Name = "creditBalance"
        Me.creditBalance.Visible = True
        Me.creditBalance.VisibleIndex = 4
        Me.creditBalance.Width = 109
        '
        'currency
        '
        Me.currency.AppearanceCell.Options.UseTextOptions = True
        Me.currency.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.currency.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.currency.AppearanceHeader.Options.UseTextOptions = True
        Me.currency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.currency.Caption = "Currency"
        Me.currency.FieldName = "Currency"
        Me.currency.Name = "currency"
        Me.currency.Visible = True
        Me.currency.VisibleIndex = 5
        Me.currency.Width = 53
        '
        'rate
        '
        Me.rate.AppearanceCell.Options.UseTextOptions = True
        Me.rate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rate.AppearanceHeader.Options.UseTextOptions = True
        Me.rate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rate.Caption = "Exchange Rate"
        Me.rate.DisplayFormat.FormatString = "#,##0.0000"
        Me.rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rate.FieldName = "THBToCurrencyRate"
        Me.rate.Name = "rate"
        Me.rate.Visible = True
        Me.rate.VisibleIndex = 6
        Me.rate.Width = 85
        '
        'afterExchange
        '
        Me.afterExchange.AppearanceCell.Options.UseTextOptions = True
        Me.afterExchange.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.afterExchange.AppearanceHeader.Options.UseTextOptions = True
        Me.afterExchange.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.afterExchange.Caption = "Credit Balance (After Exchange)"
        Me.afterExchange.DisplayFormat.FormatString = "#,##0.00"
        Me.afterExchange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.afterExchange.FieldName = "AfterExchange"
        Me.afterExchange.Name = "afterExchange"
        Me.afterExchange.Visible = True
        Me.afterExchange.VisibleIndex = 7
        Me.afterExchange.Width = 175
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.progBar)
        Me.GroupControl1.Controls.Add(Me.lblState)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.btnImport)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 303)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(375, 137)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "Step 3: Start Importing"
        '
        'progBar
        '
        Me.progBar.Location = New System.Drawing.Point(59, 74)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(294, 23)
        Me.progBar.TabIndex = 15
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(59, 103)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(68, 13)
        Me.lblState.TabIndex = 14
        Me.lblState.Text = "processing for"
        Me.lblState.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(7, 84)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Progress:"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(59, 36)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(294, 32)
        Me.btnImport.TabIndex = 7
        Me.btnImport.Text = "Import"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'FrmImportMyMart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 598)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportMyMart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import MyMart Deduction to Norming Timecard"
        CType(Me.lueGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtUsd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gcEmpCreditList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmpCreditList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcEmpCreditList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmpCreditList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents position As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dept As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents creditBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents afterExchange As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents progBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents currency As DevExpress.XtraGrid.Columns.GridColumn
End Class
