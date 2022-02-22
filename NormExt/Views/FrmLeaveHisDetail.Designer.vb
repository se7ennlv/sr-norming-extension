<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaveHisDetail
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
        Me.gcLvHisDetail = New DevExpress.XtraGrid.GridControl()
        Me.gvLvHisDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcLvHisDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLvHisDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gcLvHisDetail)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(776, 390)
        Me.PanelControl1.TabIndex = 0
        '
        'gcLvHisDetail
        '
        Me.gcLvHisDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLvHisDetail.Location = New System.Drawing.Point(2, 2)
        Me.gcLvHisDetail.MainView = Me.gvLvHisDetail
        Me.gcLvHisDetail.Name = "gcLvHisDetail"
        Me.gcLvHisDetail.Size = New System.Drawing.Size(772, 386)
        Me.gcLvHisDetail.TabIndex = 0
        Me.gcLvHisDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLvHisDetail})
        '
        'gvLvHisDetail
        '
        Me.gvLvHisDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col0, Me.col1, Me.col2, Me.col3, Me.col4})
        Me.gvLvHisDetail.GridControl = Me.gcLvHisDetail
        Me.gvLvHisDetail.Name = "gvLvHisDetail"
        Me.gvLvHisDetail.OptionsBehavior.Editable = False
        Me.gvLvHisDetail.OptionsView.ShowGroupPanel = False
        '
        'col0
        '
        Me.col0.Caption = "Doc No"
        Me.col0.FieldName = "DocNo"
        Me.col0.Name = "col0"
        Me.col0.ToolTip = "Document Number"
        Me.col0.Visible = True
        Me.col0.VisibleIndex = 0
        '
        'col1
        '
        Me.col1.Caption = "Process Date"
        Me.col1.FieldName = "ProcessDate"
        Me.col1.Name = "col1"
        Me.col1.ToolTip = "Process Date"
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 1
        '
        'col2
        '
        Me.col2.Caption = "Actions"
        Me.col2.FieldName = "ACTIONS"
        Me.col2.Name = "col2"
        Me.col2.ToolTip = "Actions"
        Me.col2.Visible = True
        Me.col2.VisibleIndex = 2
        '
        'col3
        '
        Me.col3.Caption = "Action By"
        Me.col3.FieldName = "ActionBy"
        Me.col3.Name = "col3"
        Me.col3.ToolTip = "Action By"
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 3
        '
        'col4
        '
        Me.col4.Caption = "Comment"
        Me.col4.FieldName = "Comment"
        Me.col4.Name = "col4"
        Me.col4.Visible = True
        Me.col4.VisibleIndex = 4
        '
        'frmLeaveHisDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 390)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.Name = "frmLeaveHisDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LEAVE HISTORY DETAIL"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gcLvHisDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLvHisDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcLvHisDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLvHisDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
