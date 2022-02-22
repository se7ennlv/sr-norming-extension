<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManalyser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManalyser))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpCode = New DevExpress.XtraEditors.TextEdit()
        Me.lblShift = New DevExpress.XtraEditors.LabelControl()
        Me.dtTo = New DevExpress.XtraEditors.DateEdit()
        Me.dtFrom = New DevExpress.XtraEditors.DateEdit()
        Me.progBar2 = New System.Windows.Forms.ProgressBar()
        Me.progBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.combGapHour = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lstDept = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnStop = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStart = New DevExpress.XtraEditors.SimpleButton()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtEmpCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combGapHour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(64, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 86
        Me.LabelControl1.Text = "EMP ID:"
        '
        'txtEmpCode
        '
        Me.txtEmpCode.Location = New System.Drawing.Point(114, 79)
        Me.txtEmpCode.Name = "txtEmpCode"
        Me.txtEmpCode.Properties.NullText = "Keep blank to include all staff"
        Me.txtEmpCode.Size = New System.Drawing.Size(159, 20)
        Me.txtEmpCode.TabIndex = 85
        '
        'lblShift
        '
        Me.lblShift.Location = New System.Drawing.Point(114, 232)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(42, 13)
        Me.lblShift.TabIndex = 83
        Me.lblShift.Text = "Progress"
        '
        'dtTo
        '
        Me.dtTo.EditValue = Nothing
        Me.dtTo.Location = New System.Drawing.Point(114, 133)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss tt"
        Me.dtTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTo.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss tt"
        Me.dtTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTo.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss tt"
        Me.dtTo.Size = New System.Drawing.Size(159, 20)
        Me.dtTo.TabIndex = 81
        '
        'dtFrom
        '
        Me.dtFrom.EditValue = Nothing
        Me.dtFrom.Location = New System.Drawing.Point(114, 107)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss tt"
        Me.dtFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFrom.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss tt"
        Me.dtFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFrom.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss tt"
        Me.dtFrom.Size = New System.Drawing.Size(159, 20)
        Me.dtFrom.TabIndex = 80
        '
        'progBar2
        '
        Me.progBar2.Location = New System.Drawing.Point(114, 248)
        Me.progBar2.Name = "progBar2"
        Me.progBar2.Size = New System.Drawing.Size(400, 23)
        Me.progBar2.TabIndex = 79
        '
        'progBar1
        '
        Me.progBar1.Location = New System.Drawing.Point(114, 186)
        Me.progBar1.Name = "progBar1"
        Me.progBar1.Size = New System.Drawing.Size(400, 23)
        Me.progBar1.TabIndex = 78
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(114, 167)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 13)
        Me.lblDate.TabIndex = 82
        Me.lblDate.Text = "Progress"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(74, 110)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 72
        Me.LabelControl3.Text = "From:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(86, 136)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl4.TabIndex = 73
        Me.LabelControl4.Text = "To:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(41, 47)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 76
        Me.LabelControl6.Text = "Department:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(366, 47)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl5.TabIndex = 74
        Me.LabelControl5.Text = " Gap Hour"
        Me.LabelControl5.Visible = False
        '
        'combGapHour
        '
        Me.combGapHour.EditValue = "2"
        Me.combGapHour.Location = New System.Drawing.Point(292, 44)
        Me.combGapHour.Name = "combGapHour"
        Me.combGapHour.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.combGapHour.Properties.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.combGapHour.Size = New System.Drawing.Size(57, 20)
        Me.combGapHour.TabIndex = 75
        Me.combGapHour.Visible = False
        '
        'lstDept
        '
        Me.lstDept.Location = New System.Drawing.Point(114, 44)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstDept.Properties.DisplayMember = "DeptName"
        Me.lstDept.Properties.NullText = "Select DEPT"
        Me.lstDept.Properties.ValueMember = "OrgID"
        Me.lstDept.Size = New System.Drawing.Size(159, 20)
        Me.lstDept.TabIndex = 77
        '
        'btnStop
        '
        Me.btnStop.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Appearance.Options.UseFont = True
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(403, 109)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(111, 44)
        Me.btnStop.TabIndex = 84
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Appearance.Options.UseFont = True
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(292, 109)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(105, 44)
        Me.btnStart.TabIndex = 71
        Me.btnStart.Text = "Start"
        '
        'bgWorker
        '
        '
        'Timer1
        '
        '
        'FrmManalyser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 354)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtEmpCode)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.progBar2)
        Me.Controls.Add(Me.progBar1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.combGapHour)
        Me.Controls.Add(Me.lstDept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmManalyser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fingerprint Manually Analyser"
        CType(Me.txtEmpCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combGapHour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblShift As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents progBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents progBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnStart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents combGapHour As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lstDept As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
