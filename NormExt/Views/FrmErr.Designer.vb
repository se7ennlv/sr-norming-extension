<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErr))
        Me.groupReason = New DevExpress.XtraEditors.GroupControl()
        Me.txtExplanation = New DevExpress.XtraEditors.MemoEdit()
        Me.rdoReson = New DevExpress.XtraEditors.RadioGroup()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtShiftName = New DevExpress.XtraEditors.TextEdit()
        Me.txtShiftCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmpName = New DevExpress.XtraEditors.TextEdit()
        Me.dtWorkDay = New DevExpress.XtraEditors.DateEdit()
        Me.txtEmpCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lstShift = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCheckOutTime = New DevExpress.XtraEditors.TimeEdit()
        Me.txtCheckInTime = New DevExpress.XtraEditors.TimeEdit()
        Me.chkChgShf = New DevExpress.XtraEditors.CheckEdit()
        Me.dtCheckOut = New DevExpress.XtraEditors.DateEdit()
        Me.chkChgOutTime = New DevExpress.XtraEditors.CheckEdit()
        Me.chkChgInTime = New DevExpress.XtraEditors.CheckEdit()
        Me.dtCheckIn = New DevExpress.XtraEditors.DateEdit()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblApprMail = New DevExpress.XtraEditors.LabelControl()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.NormExt.WaitForm), False, False)
        CType(Me.groupReason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupReason.SuspendLayout()
        CType(Me.txtExplanation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoReson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtShiftName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShiftCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtWorkDay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtWorkDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.lstShift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckOutTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckInTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChgShf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCheckOut.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCheckOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChgOutTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChgInTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCheckIn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCheckIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupReason
        '
        Me.groupReason.Controls.Add(Me.txtExplanation)
        Me.groupReason.Controls.Add(Me.rdoReson)
        Me.groupReason.Location = New System.Drawing.Point(547, 13)
        Me.groupReason.Name = "groupReason"
        Me.groupReason.Size = New System.Drawing.Size(345, 294)
        Me.groupReason.TabIndex = 19
        Me.groupReason.Text = "Reason"
        '
        'txtExplanation
        '
        Me.txtExplanation.Location = New System.Drawing.Point(16, 185)
        Me.txtExplanation.Name = "txtExplanation"
        Me.txtExplanation.Size = New System.Drawing.Size(313, 90)
        Me.txtExplanation.TabIndex = 1
        Me.txtExplanation.Visible = False
        '
        'rdoReson
        '
        Me.rdoReson.Location = New System.Drawing.Point(16, 35)
        Me.rdoReson.Name = "rdoReson"
        Me.rdoReson.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Global.Microsoft.VisualBasic.ChrW(49), "Forgot to Fingerprint"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Global.Microsoft.VisualBasic.ChrW(50), "Fingerprint System Broken"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Global.Microsoft.VisualBasic.ChrW(51), "Punch but no record"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Global.Microsoft.VisualBasic.ChrW(52), "Other [Explanation]")})
        Me.rdoReson.Size = New System.Drawing.Size(164, 144)
        Me.rdoReson.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtShiftName)
        Me.GroupControl2.Controls.Add(Me.txtShiftCode)
        Me.GroupControl2.Controls.Add(Me.txtEmpName)
        Me.GroupControl2.Controls.Add(Me.dtWorkDay)
        Me.GroupControl2.Controls.Add(Me.txtEmpCode)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(529, 126)
        Me.GroupControl2.TabIndex = 20
        Me.GroupControl2.Text = "Attendance Info"
        '
        'txtShiftName
        '
        Me.txtShiftName.Location = New System.Drawing.Point(267, 85)
        Me.txtShiftName.Name = "txtShiftName"
        Me.txtShiftName.Properties.ReadOnly = True
        Me.txtShiftName.Size = New System.Drawing.Size(198, 20)
        Me.txtShiftName.TabIndex = 27
        '
        'txtShiftCode
        '
        Me.txtShiftCode.Location = New System.Drawing.Point(136, 85)
        Me.txtShiftCode.Name = "txtShiftCode"
        Me.txtShiftCode.Properties.ReadOnly = True
        Me.txtShiftCode.Size = New System.Drawing.Size(125, 20)
        Me.txtShiftCode.TabIndex = 26
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(267, 59)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Properties.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(198, 20)
        Me.txtEmpName.TabIndex = 25
        '
        'dtWorkDay
        '
        Me.dtWorkDay.EditValue = Nothing
        Me.dtWorkDay.Location = New System.Drawing.Point(136, 33)
        Me.dtWorkDay.Name = "dtWorkDay"
        Me.dtWorkDay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtWorkDay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtWorkDay.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtWorkDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtWorkDay.Properties.ReadOnly = True
        Me.dtWorkDay.Size = New System.Drawing.Size(125, 20)
        Me.dtWorkDay.TabIndex = 24
        '
        'txtEmpCode
        '
        Me.txtEmpCode.Location = New System.Drawing.Point(136, 59)
        Me.txtEmpCode.Name = "txtEmpCode"
        Me.txtEmpCode.Properties.ReadOnly = True
        Me.txtEmpCode.Size = New System.Drawing.Size(125, 20)
        Me.txtEmpCode.TabIndex = 22
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(25, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Shift Code"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Emp Code"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Work Day"
        '
        'MemoEdit2
        '
        Me.MemoEdit2.EditValue = "Process is that this request will go from admin to scheduler in department(if hav" & _
    "e), then do HOD, then to HR tbl_attendance officer then to HR Director"
        Me.MemoEdit2.Location = New System.Drawing.Point(12, 330)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.ReadOnly = True
        Me.MemoEdit2.Size = New System.Drawing.Size(529, 43)
        Me.MemoEdit2.TabIndex = 37
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 311)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "* Note"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.lstShift)
        Me.GroupControl3.Controls.Add(Me.txtCheckOutTime)
        Me.GroupControl3.Controls.Add(Me.txtCheckInTime)
        Me.GroupControl3.Controls.Add(Me.chkChgShf)
        Me.GroupControl3.Controls.Add(Me.dtCheckOut)
        Me.GroupControl3.Controls.Add(Me.chkChgOutTime)
        Me.GroupControl3.Controls.Add(Me.chkChgInTime)
        Me.GroupControl3.Controls.Add(Me.dtCheckIn)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 144)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(529, 161)
        Me.GroupControl3.TabIndex = 39
        Me.GroupControl3.Text = "Modify Attendance Record"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(217, 103)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(294, 16)
        Me.LabelControl6.TabIndex = 44
        Me.LabelControl6.Text = "Please be careful about shift times between AM/PM"
        '
        'lstShift
        '
        Me.lstShift.Location = New System.Drawing.Point(25, 66)
        Me.lstShift.Name = "lstShift"
        Me.lstShift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstShift.Properties.DisplayMember = "ASSHIFT_SHIFTCODE"
        Me.lstShift.Properties.NullText = ""
        Me.lstShift.Properties.ValueMember = "ASSHIFT_SHIFTCODE"
        Me.lstShift.Size = New System.Drawing.Size(78, 20)
        Me.lstShift.TabIndex = 43
        Me.lstShift.Visible = False
        '
        'txtCheckOutTime
        '
        Me.txtCheckOutTime.EditValue = New Date(2018, 6, 11, 0, 0, 0, 0)
        Me.txtCheckOutTime.Location = New System.Drawing.Point(287, 66)
        Me.txtCheckOutTime.Name = "txtCheckOutTime"
        Me.txtCheckOutTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckOutTime.Properties.Mask.EditMask = "HH:mm:ss"
        Me.txtCheckOutTime.Properties.ReadOnly = True
        Me.txtCheckOutTime.Size = New System.Drawing.Size(100, 20)
        Me.txtCheckOutTime.TabIndex = 40
        '
        'txtCheckInTime
        '
        Me.txtCheckInTime.EditValue = New Date(2018, 6, 11, 0, 0, 0, 0)
        Me.txtCheckInTime.Location = New System.Drawing.Point(287, 38)
        Me.txtCheckInTime.Name = "txtCheckInTime"
        Me.txtCheckInTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckInTime.Properties.Mask.EditMask = "HH:mm:ss"
        Me.txtCheckInTime.Properties.ReadOnly = True
        Me.txtCheckInTime.Size = New System.Drawing.Size(100, 20)
        Me.txtCheckInTime.TabIndex = 39
        '
        'chkChgShf
        '
        Me.chkChgShf.Location = New System.Drawing.Point(25, 38)
        Me.chkChgShf.Name = "chkChgShf"
        Me.chkChgShf.Properties.Caption = "Change Shift Code"
        Me.chkChgShf.Size = New System.Drawing.Size(115, 19)
        Me.chkChgShf.TabIndex = 42
        '
        'dtCheckOut
        '
        Me.dtCheckOut.EditValue = Nothing
        Me.dtCheckOut.Location = New System.Drawing.Point(393, 64)
        Me.dtCheckOut.Name = "dtCheckOut"
        Me.dtCheckOut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCheckOut.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCheckOut.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtCheckOut.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtCheckOut.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.dtCheckOut.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtCheckOut.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtCheckOut.Size = New System.Drawing.Size(118, 20)
        Me.dtCheckOut.TabIndex = 38
        '
        'chkChgOutTime
        '
        Me.chkChgOutTime.Location = New System.Drawing.Point(146, 64)
        Me.chkChgOutTime.Name = "chkChgOutTime"
        Me.chkChgOutTime.Properties.Caption = "Change Check-out Time"
        Me.chkChgOutTime.Size = New System.Drawing.Size(142, 19)
        Me.chkChgOutTime.TabIndex = 36
        '
        'chkChgInTime
        '
        Me.chkChgInTime.Location = New System.Drawing.Point(146, 38)
        Me.chkChgInTime.Name = "chkChgInTime"
        Me.chkChgInTime.Properties.Caption = "Change Check-in Time"
        Me.chkChgInTime.Size = New System.Drawing.Size(135, 19)
        Me.chkChgInTime.TabIndex = 35
        '
        'dtCheckIn
        '
        Me.dtCheckIn.EditValue = Nothing
        Me.dtCheckIn.Location = New System.Drawing.Point(393, 38)
        Me.dtCheckIn.Name = "dtCheckIn"
        Me.dtCheckIn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCheckIn.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCheckIn.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.dtCheckIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtCheckIn.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.dtCheckIn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtCheckIn.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.dtCheckIn.Size = New System.Drawing.Size(118, 20)
        Me.dtCheckIn.TabIndex = 37
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(466, 390)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel"
        '
        'btnSubmit
        '
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.Location = New System.Drawing.Point(385, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 35
        Me.btnSubmit.Text = "Submit"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 400)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 40
        Me.LabelControl5.Text = "Approvers:"
        '
        'lblApprMail
        '
        Me.lblApprMail.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblApprMail.Location = New System.Drawing.Point(72, 400)
        Me.lblApprMail.Name = "lblApprMail"
        Me.lblApprMail.Size = New System.Drawing.Size(43, 13)
        Me.lblApprMail.TabIndex = 41
        Me.lblApprMail.Text = "HOD Mail"
        '
        'bgWorker
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmErr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 471)
        Me.Controls.Add(Me.lblApprMail)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.MemoEdit2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.groupReason)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXCEPTION RECTIFICATION REQUEST (ERR)"
        CType(Me.groupReason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupReason.ResumeLayout(False)
        CType(Me.txtExplanation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoReson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtShiftName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShiftCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtWorkDay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtWorkDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.lstShift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckOutTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckInTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChgShf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCheckOut.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCheckOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChgOutTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChgInTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCheckIn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCheckIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupReason As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtShiftName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtShiftCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmpName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtWorkDay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEmpCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdoReson As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtExplanation As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkChgOutTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkChgInTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtCheckIn As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtCheckOut As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCheckInTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtCheckOutTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents chkChgShf As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lstShift As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblApprMail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
