<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportAttdRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportAttdRecord))
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.progBar2 = New System.Windows.Forms.ProgressBar()
        Me.progBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.deTo = New DevExpress.XtraEditors.DateEdit()
        Me.deFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.deTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(72, 163)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 28
        Me.LabelControl4.Text = "LabelControl4"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(72, 121)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl3.TabIndex = 27
        Me.LabelControl3.Text = "LabelControl3"
        '
        'progBar2
        '
        Me.progBar2.Location = New System.Drawing.Point(72, 176)
        Me.progBar2.Name = "progBar2"
        Me.progBar2.Size = New System.Drawing.Size(299, 23)
        Me.progBar2.TabIndex = 26
        '
        'progBar1
        '
        Me.progBar1.Location = New System.Drawing.Point(72, 134)
        Me.progBar1.Name = "progBar1"
        Me.progBar1.Size = New System.Drawing.Size(299, 23)
        Me.progBar1.TabIndex = 25
        '
        'btnImport
        '
        Me.btnImport.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Appearance.Options.UseFont = True
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.Location = New System.Drawing.Point(258, 50)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(113, 43)
        Me.btnImport.TabIndex = 24
        Me.btnImport.Text = "Import"
        '
        'deTo
        '
        Me.deTo.EditValue = Nothing
        Me.deTo.Location = New System.Drawing.Point(72, 73)
        Me.deTo.Name = "deTo"
        Me.deTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTo.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.deTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTo.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.deTo.Size = New System.Drawing.Size(134, 20)
        Me.deTo.TabIndex = 23
        '
        'deFrom
        '
        Me.deFrom.EditValue = Nothing
        Me.deFrom.Location = New System.Drawing.Point(72, 47)
        Me.deFrom.Name = "deFrom"
        Me.deFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFrom.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFrom.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        Me.deFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFrom.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.deFrom.Size = New System.Drawing.Size(134, 20)
        Me.deFrom.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(54, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "To"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(42, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "From"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.progBar2)
        Me.PanelControl1.Controls.Add(Me.progBar1)
        Me.PanelControl1.Controls.Add(Me.btnImport)
        Me.PanelControl1.Controls.Add(Me.deTo)
        Me.PanelControl1.Controls.Add(Me.deFrom)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(436, 270)
        Me.PanelControl1.TabIndex = 29
        '
        'Timer1
        '
        '
        'bgWorker
        '
        '
        'FrmImportAttdRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 270)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportAttdRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Attendance Record to Normng"
        CType(Me.deTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents progBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents progBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
End Class
