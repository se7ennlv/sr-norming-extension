<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFpLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFpLog))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.usedShifTime = New System.Windows.Forms.CheckBox()
        Me.chkMakeNull = New System.Windows.Forms.CheckBox()
        Me.btnUpdateOut = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpdateIn = New DevExpress.XtraEditors.SimpleButton()
        Me.gcFpLog = New DevExpress.XtraGrid.GridControl()
        Me.gvFpLpog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcFpLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFpLpog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.gcFpLog)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1017, 309)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.usedShifTime)
        Me.PanelControl2.Controls.Add(Me.chkMakeNull)
        Me.PanelControl2.Controls.Add(Me.btnUpdateOut)
        Me.PanelControl2.Controls.Add(Me.btnUpdateIn)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 246)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1013, 61)
        Me.PanelControl2.TabIndex = 1
        '
        'usedShifTime
        '
        Me.usedShifTime.AutoSize = True
        Me.usedShifTime.Location = New System.Drawing.Point(469, 27)
        Me.usedShifTime.Name = "usedShifTime"
        Me.usedShifTime.Size = New System.Drawing.Size(94, 17)
        Me.usedShifTime.TabIndex = 3
        Me.usedShifTime.Text = "Use Shift Time"
        Me.usedShifTime.UseVisualStyleBackColor = True
        '
        'chkMakeNull
        '
        Me.chkMakeNull.AutoSize = True
        Me.chkMakeNull.Location = New System.Drawing.Point(383, 27)
        Me.chkMakeNull.Name = "chkMakeNull"
        Me.chkMakeNull.Size = New System.Drawing.Size(80, 17)
        Me.chkMakeNull.TabIndex = 2
        Me.chkMakeNull.Text = "Make it Null"
        Me.chkMakeNull.UseVisualStyleBackColor = True
        '
        'btnUpdateOut
        '
        Me.btnUpdateOut.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOut.Appearance.Options.UseFont = True
        Me.btnUpdateOut.Image = CType(resources.GetObject("btnUpdateOut.Image"), System.Drawing.Image)
        Me.btnUpdateOut.Location = New System.Drawing.Point(197, 17)
        Me.btnUpdateOut.Name = "btnUpdateOut"
        Me.btnUpdateOut.Size = New System.Drawing.Size(171, 34)
        Me.btnUpdateOut.TabIndex = 1
        Me.btnUpdateOut.Text = "Update Check-Out Time"
        '
        'btnUpdateIn
        '
        Me.btnUpdateIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateIn.Appearance.Options.UseFont = True
        Me.btnUpdateIn.Image = CType(resources.GetObject("btnUpdateIn.Image"), System.Drawing.Image)
        Me.btnUpdateIn.Location = New System.Drawing.Point(10, 17)
        Me.btnUpdateIn.Name = "btnUpdateIn"
        Me.btnUpdateIn.Size = New System.Drawing.Size(171, 34)
        Me.btnUpdateIn.TabIndex = 0
        Me.btnUpdateIn.Text = "Update Check-In Time"
        '
        'gcFpLog
        '
        Me.gcFpLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcFpLog.Location = New System.Drawing.Point(2, 2)
        Me.gcFpLog.MainView = Me.gvFpLpog
        Me.gcFpLog.Name = "gcFpLog"
        Me.gcFpLog.Size = New System.Drawing.Size(1013, 238)
        Me.gcFpLog.TabIndex = 0
        Me.gcFpLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFpLpog})
        '
        'gvFpLpog
        '
        Me.gvFpLpog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col0, Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6})
        Me.gvFpLpog.GridControl = Me.gcFpLog
        Me.gvFpLpog.Name = "gvFpLpog"
        Me.gvFpLpog.OptionsBehavior.Editable = False
        Me.gvFpLpog.OptionsView.ColumnAutoWidth = False
        Me.gvFpLpog.OptionsView.ShowGroupPanel = False
        '
        'col0
        '
        Me.col0.Caption = "Device Name"
        Me.col0.FieldName = "Station"
        Me.col0.Name = "col0"
        Me.col0.Visible = True
        Me.col0.VisibleIndex = 0
        Me.col0.Width = 140
        '
        'col1
        '
        Me.col1.Caption = "Department"
        Me.col1.FieldName = "Department"
        Me.col1.Name = "col1"
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 1
        Me.col1.Width = 141
        '
        'col2
        '
        Me.col2.Caption = "Emp ID"
        Me.col2.FieldName = "EmpID"
        Me.col2.Name = "col2"
        Me.col2.Visible = True
        Me.col2.VisibleIndex = 2
        Me.col2.Width = 86
        '
        'col3
        '
        Me.col3.Caption = "Emp Name"
        Me.col3.FieldName = "EmpName"
        Me.col3.Name = "col3"
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 3
        Me.col3.Width = 172
        '
        'col4
        '
        Me.col4.Caption = "Date Scan"
        Me.col4.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.col4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col4.FieldName = "Date"
        Me.col4.Name = "col4"
        Me.col4.Visible = True
        Me.col4.VisibleIndex = 4
        Me.col4.Width = 78
        '
        'col5
        '
        Me.col5.Caption = "Time Scan"
        Me.col5.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col5.FieldName = "Time"
        Me.col5.Name = "col5"
        Me.col5.Visible = True
        Me.col5.VisibleIndex = 5
        Me.col5.Width = 77
        '
        'col6
        '
        Me.col6.Caption = "Device Zone"
        Me.col6.FieldName = "DeviceZone"
        Me.col6.Name = "col6"
        Me.col6.Visible = True
        Me.col6.VisibleIndex = 6
        Me.col6.Width = 175
        '
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'FrmFpLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 309)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFpLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FINGERPRINT RAW DATA"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.gcFpLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFpLpog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcFpLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFpLpog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUpdateIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdateOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkMakeNull As System.Windows.Forms.CheckBox
    Friend WithEvents usedShifTime As System.Windows.Forms.CheckBox
End Class
