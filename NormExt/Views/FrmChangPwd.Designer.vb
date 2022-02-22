<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangPwd
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
        Me.txtOldPwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtNewPwd = New DevExpress.XtraEditors.TextEdit()
        Me.txtConfirmNewPwd = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtOldPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmNewPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOldPwd
        '
        Me.txtOldPwd.Location = New System.Drawing.Point(141, 23)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.Properties.ReadOnly = True
        Me.txtOldPwd.Properties.UseSystemPasswordChar = True
        Me.txtOldPwd.Size = New System.Drawing.Size(175, 20)
        Me.txtOldPwd.TabIndex = 0
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(141, 49)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.Properties.UseSystemPasswordChar = True
        Me.txtNewPwd.Size = New System.Drawing.Size(175, 20)
        Me.txtNewPwd.TabIndex = 1
        '
        'txtConfirmNewPwd
        '
        Me.txtConfirmNewPwd.Location = New System.Drawing.Point(141, 75)
        Me.txtConfirmNewPwd.Name = "txtConfirmNewPwd"
        Me.txtConfirmNewPwd.Properties.UseSystemPasswordChar = True
        Me.txtConfirmNewPwd.Size = New System.Drawing.Size(175, 20)
        Me.txtConfirmNewPwd.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(57, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Old Password:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(57, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "New Password:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Confirm New Password:"
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(141, 111)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 6
        Me.btnChange.Text = "Change"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(241, 111)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'frmChangPwd
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(351, 159)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtConfirmNewPwd)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.txtOldPwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangPwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE PASSWORD"
        CType(Me.txtOldPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmNewPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOldPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNewPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConfirmNewPwd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
