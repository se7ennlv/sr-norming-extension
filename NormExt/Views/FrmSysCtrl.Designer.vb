<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSysCtrl
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRmsCtrl = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNormExtCtrl = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(519, 276)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.btnRmsCtrl)
        Me.GroupControl2.Controls.Add(Me.btnNormExtCtrl)
        Me.GroupControl2.Location = New System.Drawing.Point(36, 36)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(427, 185)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "System Control"
        '
        'btnRmsCtrl
        '
        Me.btnRmsCtrl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRmsCtrl.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnRmsCtrl.Appearance.Options.UseFont = True
        Me.btnRmsCtrl.Appearance.Options.UseForeColor = True
        Me.btnRmsCtrl.Location = New System.Drawing.Point(23, 108)
        Me.btnRmsCtrl.Name = "btnRmsCtrl"
        Me.btnRmsCtrl.Size = New System.Drawing.Size(379, 50)
        Me.btnRmsCtrl.TabIndex = 1
        Me.btnRmsCtrl.Text = "RMS Controller"
        '
        'btnNormExtCtrl
        '
        Me.btnNormExtCtrl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNormExtCtrl.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnNormExtCtrl.Appearance.Options.UseFont = True
        Me.btnNormExtCtrl.Appearance.Options.UseForeColor = True
        Me.btnNormExtCtrl.Location = New System.Drawing.Point(23, 37)
        Me.btnNormExtCtrl.Name = "btnNormExtCtrl"
        Me.btnNormExtCtrl.Size = New System.Drawing.Size(379, 50)
        Me.btnNormExtCtrl.TabIndex = 0
        Me.btnNormExtCtrl.Text = "Norming Extension Controller"
        '
        'FrmSysCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 276)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSysCtrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SYSTEMS CONTROL"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNormExtCtrl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRmsCtrl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
