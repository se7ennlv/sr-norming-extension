<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoster))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.gcRoster = New DevExpress.XtraGrid.GridControl()
        Me.gvRoster = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnGetTmp = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.lblShowEmp = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEnableEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.lstShiftCode = New DevExpress.XtraEditors.LookUpEdit()
        Me.swDayOff = New DevExpress.XtraEditors.CheckEdit()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.lstShiftDay = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnNewTemp = New DevExpress.XtraEditors.SimpleButton()
        Me.lstSup = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEmpGrp = New DevExpress.XtraEditors.LabelControl()
        Me.btnShowRtAndShift = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmpCode = New DevExpress.XtraEditors.TextEdit()
        Me.dtTo = New DevExpress.XtraEditors.DateEdit()
        Me.dtFrom = New DevExpress.XtraEditors.DateEdit()
        Me.lstShiftGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.diaSave = New System.Windows.Forms.SaveFileDialog()
        Me.diaOpen = New System.Windows.Forms.OpenFileDialog()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.gcRoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGetTmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lstShiftCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swDayOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstShiftDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.lstSup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstShiftGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1195, 532)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.gcRoster)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(2, 143)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1191, 387)
        Me.PanelControl4.TabIndex = 2
        '
        'gcRoster
        '
        Me.gcRoster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcRoster.Location = New System.Drawing.Point(2, 2)
        Me.gcRoster.MainView = Me.gvRoster
        Me.gcRoster.Name = "gcRoster"
        Me.gcRoster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnGetTmp})
        Me.gcRoster.Size = New System.Drawing.Size(1187, 383)
        Me.gcRoster.TabIndex = 0
        Me.gcRoster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRoster})
        '
        'gvRoster
        '
        Me.gvRoster.GridControl = Me.gcRoster
        Me.gvRoster.Name = "gvRoster"
        Me.gvRoster.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvRoster.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvRoster.OptionsBehavior.Editable = False
        Me.gvRoster.OptionsBehavior.ReadOnly = True
        Me.gvRoster.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.gvRoster.OptionsView.ColumnAutoWidth = False
        Me.gvRoster.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvRoster.OptionsView.ShowGroupPanel = False
        Me.gvRoster.OptionsView.ShowIndicator = False
        Me.gvRoster.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'btnGetTmp
        '
        Me.btnGetTmp.AutoHeight = False
        Me.btnGetTmp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnGetTmp.Name = "btnGetTmp"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lblShowEmp)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.btnExport)
        Me.PanelControl3.Controls.Add(Me.btnEnableEdit)
        Me.PanelControl3.Controls.Add(Me.lstShiftCode)
        Me.PanelControl3.Controls.Add(Me.swDayOff)
        Me.PanelControl3.Controls.Add(Me.btnImport)
        Me.PanelControl3.Controls.Add(Me.lstShiftDay)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(2, 66)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1191, 77)
        Me.PanelControl3.TabIndex = 1
        '
        'lblShowEmp
        '
        Me.lblShowEmp.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblShowEmp.Location = New System.Drawing.Point(89, 48)
        Me.lblShowEmp.Name = "lblShowEmp"
        Me.lblShowEmp.Size = New System.Drawing.Size(20, 13)
        Me.lblShowEmp.TabIndex = 16
        Me.lblShowEmp.Text = "[ 0 ]"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(26, 48)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Showing"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.TextBox1)
        Me.GroupControl1.Controls.Add(Me.TextBox2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(1030, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(159, 73)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Status"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(26, 50)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl8.TabIndex = 6
        Me.LabelControl8.Text = "= Leave Code"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(26, 25)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl7.TabIndex = 5
        Me.LabelControl7.Text = "= Day Off"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(5, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(15, 16)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(5, 48)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(15, 16)
        Me.TextBox2.TabIndex = 3
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(712, 42)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(79, 23)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export"
        '
        'btnEnableEdit
        '
        Me.btnEnableEdit.Location = New System.Drawing.Point(530, 43)
        Me.btnEnableEdit.Name = "btnEnableEdit"
        Me.btnEnableEdit.Size = New System.Drawing.Size(85, 23)
        Me.btnEnableEdit.TabIndex = 13
        Me.btnEnableEdit.Text = "Enable Edit"
        '
        'lstShiftCode
        '
        Me.lstShiftCode.Location = New System.Drawing.Point(530, 11)
        Me.lstShiftCode.Name = "lstShiftCode"
        Me.lstShiftCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstShiftCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ASSHIFT_SHIFTCODE", 30, "Shift Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ASSHIFT_SHIFTDESC", 150, "Description")})
        Me.lstShiftCode.Properties.DisplayMember = "ASSHIFT_SHIFTDESC"
        Me.lstShiftCode.Properties.NullText = "Select Shift Code Here"
        Me.lstShiftCode.Properties.PopupFormMinSize = New System.Drawing.Size(350, 550)
        Me.lstShiftCode.Properties.PopupWidth = 300
        Me.lstShiftCode.Properties.ShowFooter = False
        Me.lstShiftCode.Properties.ValueMember = "ASSHIFT_SHIFTCODE"
        Me.lstShiftCode.Size = New System.Drawing.Size(261, 20)
        Me.lstShiftCode.TabIndex = 2
        '
        'swDayOff
        '
        Me.swDayOff.Location = New System.Drawing.Point(359, 12)
        Me.swDayOff.Name = "swDayOff"
        Me.swDayOff.Properties.Caption = "Day Off with Shift Code:"
        Me.swDayOff.Size = New System.Drawing.Size(149, 19)
        Me.swDayOff.TabIndex = 1
        '
        'btnImport
        '
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.Location = New System.Drawing.Point(621, 42)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(85, 23)
        Me.btnImport.TabIndex = 4
        Me.btnImport.Text = "Import"
        '
        'lstShiftDay
        '
        Me.lstShiftDay.Location = New System.Drawing.Point(86, 6)
        Me.lstShiftDay.Name = "lstShiftDay"
        Me.lstShiftDay.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(12, Short), "12 Days"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(6, Short), "6 Days"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "1 Day")})
        Me.lstShiftDay.Size = New System.Drawing.Size(255, 31)
        Me.lstShiftDay.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(344, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "+"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(37, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Insert"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnNewTemp)
        Me.PanelControl2.Controls.Add(Me.lstSup)
        Me.PanelControl2.Controls.Add(Me.lblEmpGrp)
        Me.PanelControl2.Controls.Add(Me.btnShowRtAndShift)
        Me.PanelControl2.Controls.Add(Me.txtEmpCode)
        Me.PanelControl2.Controls.Add(Me.dtTo)
        Me.PanelControl2.Controls.Add(Me.dtFrom)
        Me.PanelControl2.Controls.Add(Me.lstShiftGroup)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1191, 64)
        Me.PanelControl2.TabIndex = 0
        '
        'btnNewTemp
        '
        Me.btnNewTemp.Image = CType(resources.GetObject("btnNewTemp.Image"), System.Drawing.Image)
        Me.btnNewTemp.Location = New System.Drawing.Point(530, 34)
        Me.btnNewTemp.Name = "btnNewTemp"
        Me.btnNewTemp.Size = New System.Drawing.Size(176, 23)
        Me.btnNewTemp.TabIndex = 14
        Me.btnNewTemp.Text = "Create New Template"
        Me.btnNewTemp.ToolTip = "Get empty template for insert new roster"
        '
        'lstSup
        '
        Me.lstSup.Location = New System.Drawing.Point(86, 36)
        Me.lstSup.Name = "lstSup"
        Me.lstSup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstSup.Properties.DisplayMember = "SupName"
        Me.lstSup.Properties.NullText = "Select Supervisor"
        Me.lstSup.Properties.ValueMember = "SupID"
        Me.lstSup.Size = New System.Drawing.Size(136, 20)
        Me.lstSup.TabIndex = 13
        Me.lstSup.Visible = False
        '
        'lblEmpGrp
        '
        Me.lblEmpGrp.Location = New System.Drawing.Point(12, 39)
        Me.lblEmpGrp.Name = "lblEmpGrp"
        Me.lblEmpGrp.Size = New System.Drawing.Size(52, 13)
        Me.lblEmpGrp.TabIndex = 12
        Me.lblEmpGrp.Text = "Emp Under"
        Me.lblEmpGrp.Visible = False
        '
        'btnShowRtAndShift
        '
        Me.btnShowRtAndShift.Image = CType(resources.GetObject("btnShowRtAndShift.Image"), System.Drawing.Image)
        Me.btnShowRtAndShift.Location = New System.Drawing.Point(530, 8)
        Me.btnShowRtAndShift.Name = "btnShowRtAndShift"
        Me.btnShowRtAndShift.Size = New System.Drawing.Size(176, 23)
        Me.btnShowRtAndShift.TabIndex = 11
        Me.btnShowRtAndShift.Text = "Show Roster and Shift Code"
        '
        'txtEmpCode
        '
        Me.txtEmpCode.Location = New System.Drawing.Point(282, 10)
        Me.txtEmpCode.Name = "txtEmpCode"
        Me.txtEmpCode.Size = New System.Drawing.Size(59, 20)
        Me.txtEmpCode.TabIndex = 10
        Me.txtEmpCode.ToolTip = "Keep blank to select all employee."
        '
        'dtTo
        '
        Me.dtTo.EditValue = Nothing
        Me.dtTo.Location = New System.Drawing.Point(408, 32)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTo.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtTo.Size = New System.Drawing.Size(100, 20)
        Me.dtTo.TabIndex = 9
        '
        'dtFrom
        '
        Me.dtFrom.EditValue = Nothing
        Me.dtFrom.Location = New System.Drawing.Point(408, 10)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFrom.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtFrom.TabIndex = 8
        '
        'lstShiftGroup
        '
        Me.lstShiftGroup.Location = New System.Drawing.Point(86, 10)
        Me.lstShiftGroup.Name = "lstShiftGroup"
        Me.lstShiftGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstShiftGroup.Properties.DisplayMember = "GroupCode"
        Me.lstShiftGroup.Properties.NullText = "Select Your Shift Group"
        Me.lstShiftGroup.Properties.ShowFooter = False
        Me.lstShiftGroup.Properties.ShowHeader = False
        Me.lstShiftGroup.Properties.ShowLines = False
        Me.lstShiftGroup.Properties.ValueMember = "GroupCode"
        Me.lstShiftGroup.Size = New System.Drawing.Size(136, 20)
        Me.lstShiftGroup.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(359, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(228, 13)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Emp Code"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(359, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "From"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 13)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Shift Group"
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'diaSave
        '
        Me.diaSave.Filter = "Excel 2007 | *.xlsx"
        '
        'diaOpen
        '
        Me.diaOpen.Filter = "Excel 2007 | *.xlsx"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'FrmRoster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 532)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRoster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROSTER MANAGEMENT"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.gcRoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGetTmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.lstShiftCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swDayOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstShiftDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.lstSup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstShiftGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcRoster As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRoster As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lstShiftGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGetTmp As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnShowRtAndShift As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmpCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnEnableEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstShiftCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents swDayOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lstShiftDay As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents diaSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents diaOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstSup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEmpGrp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lblShowEmp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNewTemp As DevExpress.XtraEditors.SimpleButton
End Class
