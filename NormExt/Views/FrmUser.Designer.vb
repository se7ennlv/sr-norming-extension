<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.txtUname = New DevExpress.XtraEditors.TextEdit()
        Me.txtPwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.comboPrvRoster = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.comboPrvLeave = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.comboPrvAttd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUserID = New DevExpress.XtraEditors.TextEdit()
        Me.lstDepartment = New DevExpress.XtraEditors.LookUpEdit()
        Me.lstRosterAccess = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lstLeaveAccess = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lstAttdAccess = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.swAnyTime = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpId = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.comboPrvAdminRpt = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.comboPrvHrDirect = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.comboHrAttdApprLevel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.comboPrvHod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.txtUname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPrvRoster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPrvLeave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPrvAttd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstRosterAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstLeaveAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstAttdAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swAnyTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.comboPrvAdminRpt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPrvHrDirect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboHrAttdApprLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPrvHod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(120, 97)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(270, 20)
        Me.txtUname.TabIndex = 3
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(120, 123)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Properties.UseSystemPasswordChar = True
        Me.txtPwd.Size = New System.Drawing.Size(270, 20)
        Me.txtPwd.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.EditValue = ""
        Me.txtPhone.Location = New System.Drawing.Point(120, 175)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.NullText = "+856-xx-xxxxxxxx"
        Me.txtPhone.Size = New System.Drawing.Size(270, 20)
        Me.txtPhone.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.EditValue = ""
        Me.txtEmail.Location = New System.Drawing.Point(120, 149)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.NullText = "email@domain.com"
        Me.txtEmail.Size = New System.Drawing.Size(270, 20)
        Me.txtEmail.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(74, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "User ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(39, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "User Full Name:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(64, 126)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Password:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(86, 152)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Email:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(80, 178)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Phone:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(53, 204)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Department:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(35, 50)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "Roster Privilege:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(38, 76)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Leave Privilege:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(11, 102)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Attendance Privilege:"
        '
        'comboPrvRoster
        '
        Me.comboPrvRoster.EditValue = "Select Previlledge Level"
        Me.comboPrvRoster.Location = New System.Drawing.Point(120, 47)
        Me.comboPrvRoster.Name = "comboPrvRoster"
        Me.comboPrvRoster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboPrvRoster.Properties.Items.AddRange(New Object() {"No Access", "Read Only", "Edit", "Insert", "Delete"})
        Me.comboPrvRoster.Properties.NullText = "Please select a previlledge"
        Me.comboPrvRoster.Size = New System.Drawing.Size(270, 20)
        Me.comboPrvRoster.TabIndex = 8
        '
        'comboPrvLeave
        '
        Me.comboPrvLeave.EditValue = "Select Previlledge Level"
        Me.comboPrvLeave.Location = New System.Drawing.Point(120, 73)
        Me.comboPrvLeave.Name = "comboPrvLeave"
        Me.comboPrvLeave.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboPrvLeave.Properties.Items.AddRange(New Object() {"No Access", "Read Only", "Edit", "Insert", "Delete"})
        Me.comboPrvLeave.Properties.NullText = "Please select a previlledge"
        Me.comboPrvLeave.Size = New System.Drawing.Size(270, 20)
        Me.comboPrvLeave.TabIndex = 10
        '
        'comboPrvAttd
        '
        Me.comboPrvAttd.EditValue = "Select Previlledge Level"
        Me.comboPrvAttd.Location = New System.Drawing.Point(120, 99)
        Me.comboPrvAttd.Name = "comboPrvAttd"
        Me.comboPrvAttd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboPrvAttd.Properties.Items.AddRange(New Object() {"No Access", "Read Only", "Edit", "Insert", "Delete"})
        Me.comboPrvAttd.Properties.NullText = "Please select a previlledge"
        Me.comboPrvAttd.Size = New System.Drawing.Size(270, 20)
        Me.comboPrvAttd.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(234, 42)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(120, 44)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(108, 20)
        Me.txtUserID.TabIndex = 1
        '
        'lstDepartment
        '
        Me.lstDepartment.Location = New System.Drawing.Point(120, 201)
        Me.lstDepartment.Name = "lstDepartment"
        Me.lstDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstDepartment.Properties.DisplayMember = "DeptName"
        Me.lstDepartment.Properties.NullText = "Select Department"
        Me.lstDepartment.Properties.ShowFooter = False
        Me.lstDepartment.Properties.ShowHeader = False
        Me.lstDepartment.Properties.ShowLines = False
        Me.lstDepartment.Properties.ValueMember = "DeptID"
        Me.lstDepartment.Size = New System.Drawing.Size(270, 20)
        Me.lstDepartment.TabIndex = 7
        '
        'lstRosterAccess
        '
        Me.lstRosterAccess.Enabled = False
        Me.lstRosterAccess.Location = New System.Drawing.Point(396, 47)
        Me.lstRosterAccess.Name = "lstRosterAccess"
        Me.lstRosterAccess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstRosterAccess.Properties.Items.AddRange(New Object() {"Own Department", "All Departments"})
        Me.lstRosterAccess.Size = New System.Drawing.Size(100, 20)
        Me.lstRosterAccess.TabIndex = 9
        '
        'lstLeaveAccess
        '
        Me.lstLeaveAccess.Enabled = False
        Me.lstLeaveAccess.Location = New System.Drawing.Point(396, 73)
        Me.lstLeaveAccess.Name = "lstLeaveAccess"
        Me.lstLeaveAccess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstLeaveAccess.Properties.Items.AddRange(New Object() {"Own Department", "All Departments"})
        Me.lstLeaveAccess.Size = New System.Drawing.Size(100, 20)
        Me.lstLeaveAccess.TabIndex = 11
        '
        'lstAttdAccess
        '
        Me.lstAttdAccess.Enabled = False
        Me.lstAttdAccess.Location = New System.Drawing.Point(396, 99)
        Me.lstAttdAccess.Name = "lstAttdAccess"
        Me.lstAttdAccess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstAttdAccess.Properties.Items.AddRange(New Object() {"Own Department", "All Departments"})
        Me.lstAttdAccess.Size = New System.Drawing.Size(100, 20)
        Me.lstAttdAccess.TabIndex = 13
        '
        'swAnyTime
        '
        Me.swAnyTime.Location = New System.Drawing.Point(120, 229)
        Me.swAnyTime.Name = "swAnyTime"
        Me.swAnyTime.Properties.Caption = "Access Any Time"
        Me.swAnyTime.Size = New System.Drawing.Size(109, 19)
        Me.swAnyTime.TabIndex = 18
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(79, 74)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl10.TabIndex = 36
        Me.LabelControl10.Text = "EmpID:"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(120, 71)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Properties.ReadOnly = True
        Me.txtEmpId.Size = New System.Drawing.Size(270, 20)
        Me.txtEmpId.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.comboPrvAdminRpt)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.comboPrvHrDirect)
        Me.GroupControl1.Controls.Add(Me.comboHrAttdApprLevel)
        Me.GroupControl1.Controls.Add(Me.comboPrvHod)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.swAnyTime)
        Me.GroupControl1.Controls.Add(Me.lstAttdAccess)
        Me.GroupControl1.Controls.Add(Me.lstLeaveAccess)
        Me.GroupControl1.Controls.Add(Me.lstRosterAccess)
        Me.GroupControl1.Controls.Add(Me.comboPrvAttd)
        Me.GroupControl1.Controls.Add(Me.comboPrvLeave)
        Me.GroupControl1.Controls.Add(Me.comboPrvRoster)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 271)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(529, 272)
        Me.GroupControl1.TabIndex = 37
        Me.GroupControl1.Text = "Roles and privilege to access menu"
        '
        'comboPrvAdminRpt
        '
        Me.comboPrvAdminRpt.EditValue = "Select Role"
        Me.comboPrvAdminRpt.Location = New System.Drawing.Point(120, 203)
        Me.comboPrvAdminRpt.Name = "comboPrvAdminRpt"
        Me.comboPrvAdminRpt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboPrvAdminRpt.Properties.Items.AddRange(New Object() {"Not Allow", "Allow"})
        Me.comboPrvAdminRpt.Properties.NullText = "Please select a previlledge"
        Me.comboPrvAdminRpt.Size = New System.Drawing.Size(270, 20)
        Me.comboPrvAdminRpt.TabIndex = 17
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(40, 206)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl14.TabIndex = 42
        Me.LabelControl14.Text = "Admin Reports:"
        '
        'comboPrvHrDirect
        '
        Me.comboPrvHrDirect.EditValue = "Select Role"
        Me.comboPrvHrDirect.Location = New System.Drawing.Point(120, 177)
        Me.comboPrvHrDirect.Name = "comboPrvHrDirect"
        Me.comboPrvHrDirect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboPrvHrDirect.Properties.Items.AddRange(New Object() {"Not Allow", "Allow"})
        Me.comboPrvHrDirect.Properties.NullText = "Please select a previlledge"
        Me.comboPrvHrDirect.Size = New System.Drawing.Size(270, 20)
        Me.comboPrvHrDirect.TabIndex = 16
        '
        'comboHrAttdApprLevel
        '
        Me.comboHrAttdApprLevel.EditValue = "Select Role"
        Me.comboHrAttdApprLevel.Location = New System.Drawing.Point(120, 151)
        Me.comboHrAttdApprLevel.Name = "comboHrAttdApprLevel"
        Me.comboHrAttdApprLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboHrAttdApprLevel.Properties.Items.AddRange(New Object() {"Not Allow", "Allow"})
        Me.comboHrAttdApprLevel.Properties.NullText = "Please select a previlledge"
        Me.comboHrAttdApprLevel.Size = New System.Drawing.Size(270, 20)
        Me.comboHrAttdApprLevel.TabIndex = 15
        '
        'comboPrvHod
        '
        Me.comboPrvHod.EditValue = "Select Role"
        Me.comboPrvHod.Location = New System.Drawing.Point(120, 125)
        Me.comboPrvHod.Name = "comboPrvHod"
        Me.comboPrvHod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboPrvHod.Properties.Items.AddRange(New Object() {"Not Allow", "Allow"})
        Me.comboPrvHod.Properties.NullText = "Please select a previlledge"
        Me.comboPrvHod.Size = New System.Drawing.Size(270, 20)
        Me.comboPrvHod.TabIndex = 14
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(5, 180)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "HR Manager Approval:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(23, 154)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl12.TabIndex = 39
        Me.LabelControl12.Text = "Attendance Verify:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(42, 128)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl13.TabIndex = 38
        Me.LabelControl13.Text = "HOD Approval:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.txtEmpId)
        Me.GroupControl2.Controls.Add(Me.lstDepartment)
        Me.GroupControl2.Controls.Add(Me.txtUserID)
        Me.GroupControl2.Controls.Add(Me.btnSave)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.txtPhone)
        Me.GroupControl2.Controls.Add(Me.txtEmail)
        Me.GroupControl2.Controls.Add(Me.txtPwd)
        Me.GroupControl2.Controls.Add(Me.txtUname)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(419, 238)
        Me.GroupControl2.TabIndex = 38
        Me.GroupControl2.Text = "General"
        '
        'frmUser
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 555)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmUser"
        Me.Text = "USERS"
        CType(Me.txtUname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPrvRoster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPrvLeave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPrvAttd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstRosterAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstLeaveAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstAttdAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swAnyTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.comboPrvAdminRpt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPrvHrDirect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboHrAttdApprLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPrvHod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents comboPrvRoster As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents comboPrvLeave As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents comboPrvAttd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUserID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lstDepartment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lstRosterAccess As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lstLeaveAccess As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lstAttdAccess As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents swAnyTime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents comboPrvHrDirect As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents comboHrAttdApprLevel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents comboPrvHod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents comboPrvAdminRpt As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
End Class
