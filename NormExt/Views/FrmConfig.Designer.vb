<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.txtSmtpServer = New DevExpress.XtraEditors.TextEdit()
        Me.txtSmtpLogin = New DevExpress.XtraEditors.TextEdit()
        Me.txtImportAllowDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditAllowDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtSmtpPwd = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSmtpPort = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txtSmtpServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImportAllowDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditAllowDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSmtpPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSmtpServer
        '
        Me.txtSmtpServer.Location = New System.Drawing.Point(144, 32)
        Me.txtSmtpServer.Name = "txtSmtpServer"
        Me.txtSmtpServer.Size = New System.Drawing.Size(196, 20)
        Me.txtSmtpServer.TabIndex = 1
        '
        'txtSmtpLogin
        '
        Me.txtSmtpLogin.Location = New System.Drawing.Point(144, 84)
        Me.txtSmtpLogin.Name = "txtSmtpLogin"
        Me.txtSmtpLogin.Size = New System.Drawing.Size(196, 20)
        Me.txtSmtpLogin.TabIndex = 3
        '
        'txtImportAllowDay
        '
        Me.txtImportAllowDay.Location = New System.Drawing.Point(144, 162)
        Me.txtImportAllowDay.Name = "txtImportAllowDay"
        Me.txtImportAllowDay.Size = New System.Drawing.Size(196, 20)
        Me.txtImportAllowDay.TabIndex = 6
        '
        'txtEditAllowDay
        '
        Me.txtEditAllowDay.Location = New System.Drawing.Point(144, 136)
        Me.txtEditAllowDay.Name = "txtEditAllowDay"
        Me.txtEditAllowDay.Size = New System.Drawing.Size(196, 20)
        Me.txtEditAllowDay.TabIndex = 5
        '
        'txtSmtpPwd
        '
        Me.txtSmtpPwd.Location = New System.Drawing.Point(144, 110)
        Me.txtSmtpPwd.Name = "txtSmtpPwd"
        Me.txtSmtpPwd.Properties.UseSystemPasswordChar = True
        Me.txtSmtpPwd.Size = New System.Drawing.Size(196, 20)
        Me.txtSmtpPwd.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(47, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Smtp Server"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(47, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Smtp Login"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(47, 61)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Smtp Port"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(47, 165)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Import Allow Day"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(47, 139)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Edit Allow Day"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(47, 113)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl8.TabIndex = 11
        Me.LabelControl8.Text = "Smtp Pwd"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(144, 188)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        '
        'txtSmtpPort
        '
        Me.txtSmtpPort.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSmtpPort.Location = New System.Drawing.Point(144, 58)
        Me.txtSmtpPort.Name = "txtSmtpPort"
        Me.txtSmtpPort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSmtpPort.Size = New System.Drawing.Size(196, 20)
        Me.txtSmtpPort.TabIndex = 15
        '
        'frmConfig
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 248)
        Me.Controls.Add(Me.txtSmtpPort)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtImportAllowDay)
        Me.Controls.Add(Me.txtEditAllowDay)
        Me.Controls.Add(Me.txtSmtpPwd)
        Me.Controls.Add(Me.txtSmtpLogin)
        Me.Controls.Add(Me.txtSmtpServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConfig"
        Me.Text = "CONFIG"
        CType(Me.txtSmtpServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImportAllowDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditAllowDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSmtpPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSmtpServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSmtpLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImportAllowDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditAllowDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSmtpPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSmtpPort As DevExpress.XtraEditors.SpinEdit
End Class
