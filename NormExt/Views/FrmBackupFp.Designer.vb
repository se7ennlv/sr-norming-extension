<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackupFp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBackupFp))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRestore = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBackup = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpId = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gcFpBackup = New DevExpress.XtraGrid.GridControl()
        Me.gvFpBackup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ULID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Years = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Months = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Days = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Actions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.JobCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Hours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Minutes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Seconds = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DevID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtEmpId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcFpBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFpBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnRestore)
        Me.PanelControl1.Controls.Add(Me.btnBackup)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtEmpId)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(251, 628)
        Me.PanelControl1.TabIndex = 0
        '
        'btnRestore
        '
        Me.btnRestore.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Appearance.Options.UseFont = True
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.Location = New System.Drawing.Point(65, 148)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(169, 39)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore FP Data"
        '
        'btnBackup
        '
        Me.btnBackup.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Appearance.Options.UseFont = True
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.Location = New System.Drawing.Point(65, 90)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(169, 39)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Backup FP Data"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "EMP ID:"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(65, 47)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Properties.MaxLength = 5
        Me.txtEmpId.Size = New System.Drawing.Size(169, 20)
        Me.txtEmpId.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcFpBackup)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(251, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1023, 628)
        Me.PanelControl2.TabIndex = 1
        '
        'gcFpBackup
        '
        Me.gcFpBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcFpBackup.Location = New System.Drawing.Point(2, 2)
        Me.gcFpBackup.MainView = Me.gvFpBackup
        Me.gcFpBackup.Name = "gcFpBackup"
        Me.gcFpBackup.Size = New System.Drawing.Size(1019, 624)
        Me.gcFpBackup.TabIndex = 0
        Me.gcFpBackup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFpBackup})
        '
        'gvFpBackup
        '
        Me.gvFpBackup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ULID, Me.WUserID, Me.Years, Me.Months, Me.Days, Me.Actions, Me.Status, Me.JobCode, Me.Hours, Me.Minutes, Me.Seconds, Me.DevID})
        Me.gvFpBackup.GridControl = Me.gcFpBackup
        Me.gvFpBackup.Name = "gvFpBackup"
        Me.gvFpBackup.OptionsBehavior.Editable = False
        Me.gvFpBackup.OptionsView.ShowGroupPanel = False
        '
        'ULID
        '
        Me.ULID.Caption = "ULID"
        Me.ULID.FieldName = "ULID"
        Me.ULID.Name = "ULID"
        Me.ULID.Visible = True
        Me.ULID.VisibleIndex = 0
        Me.ULID.Width = 150
        '
        'WUserID
        '
        Me.WUserID.Caption = "WUserID"
        Me.WUserID.FieldName = "WUserID"
        Me.WUserID.Name = "WUserID"
        Me.WUserID.Visible = True
        Me.WUserID.VisibleIndex = 1
        Me.WUserID.Width = 43
        '
        'Years
        '
        Me.Years.Caption = "Years"
        Me.Years.FieldName = "Years"
        Me.Years.Name = "Years"
        Me.Years.Visible = True
        Me.Years.VisibleIndex = 2
        Me.Years.Width = 43
        '
        'Months
        '
        Me.Months.Caption = "Months"
        Me.Months.FieldName = "Months"
        Me.Months.Name = "Months"
        Me.Months.Visible = True
        Me.Months.VisibleIndex = 3
        Me.Months.Width = 43
        '
        'Days
        '
        Me.Days.Caption = "Days"
        Me.Days.FieldName = "Days"
        Me.Days.Name = "Days"
        Me.Days.Visible = True
        Me.Days.VisibleIndex = 4
        Me.Days.Width = 43
        '
        'Actions
        '
        Me.Actions.Caption = "Actions"
        Me.Actions.FieldName = "Actions"
        Me.Actions.Name = "Actions"
        Me.Actions.Visible = True
        Me.Actions.VisibleIndex = 5
        Me.Actions.Width = 43
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 6
        Me.Status.Width = 43
        '
        'JobCode
        '
        Me.JobCode.Caption = "JobCode"
        Me.JobCode.Name = "JobCode"
        Me.JobCode.Visible = True
        Me.JobCode.VisibleIndex = 7
        Me.JobCode.Width = 43
        '
        'Hours
        '
        Me.Hours.Caption = "Hours"
        Me.Hours.FieldName = "Hours"
        Me.Hours.Name = "Hours"
        Me.Hours.Visible = True
        Me.Hours.VisibleIndex = 8
        Me.Hours.Width = 43
        '
        'Minutes
        '
        Me.Minutes.Caption = "Minutes"
        Me.Minutes.FieldName = "Minutes"
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Visible = True
        Me.Minutes.VisibleIndex = 9
        Me.Minutes.Width = 43
        '
        'Seconds
        '
        Me.Seconds.Caption = "Seconds"
        Me.Seconds.FieldName = "Seconds"
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Visible = True
        Me.Seconds.VisibleIndex = 10
        Me.Seconds.Width = 43
        '
        'DevID
        '
        Me.DevID.Caption = "DevID"
        Me.DevID.FieldName = "DevID"
        Me.DevID.Name = "DevID"
        Me.DevID.Visible = True
        Me.DevID.VisibleIndex = 11
        Me.DevID.Width = 150
        '
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'FrmBackupFp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 628)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmBackupFp"
        Me.Text = "BACKUP FINGERPRINT DATA"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtEmpId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gcFpBackup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFpBackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcFpBackup As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFpBackup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ULID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Years As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Months As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Days As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Actions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JobCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Hours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Minutes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Seconds As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DevID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRestore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
