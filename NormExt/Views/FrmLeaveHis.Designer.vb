<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaveHis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeaveHis))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gcLeaveHis = New DevExpress.XtraGrid.GridControl()
        Me.gvLeaveHis = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.diaSave = New System.Windows.Forms.SaveFileDialog()
        Me.diaOpen = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gcLeaveHis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLeaveHis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExport)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1072, 44)
        Me.PanelControl1.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(12, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(115, 23)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export To Excel"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gcLeaveHis)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 44)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1072, 495)
        Me.PanelControl2.TabIndex = 1
        '
        'gcLeaveHis
        '
        Me.gcLeaveHis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLeaveHis.Location = New System.Drawing.Point(2, 2)
        Me.gcLeaveHis.MainView = Me.gvLeaveHis
        Me.gcLeaveHis.Name = "gcLeaveHis"
        Me.gcLeaveHis.Size = New System.Drawing.Size(1068, 491)
        Me.gcLeaveHis.TabIndex = 1
        Me.gcLeaveHis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLeaveHis})
        '
        'gvLeaveHis
        '
        Me.gvLeaveHis.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8, Me.col9, Me.col10})
        Me.gvLeaveHis.GridControl = Me.gcLeaveHis
        Me.gvLeaveHis.Name = "gvLeaveHis"
        Me.gvLeaveHis.OptionsBehavior.Editable = False
        Me.gvLeaveHis.OptionsFind.AlwaysVisible = True
        Me.gvLeaveHis.OptionsView.ColumnAutoWidth = False
        Me.gvLeaveHis.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLeaveHis.OptionsView.ShowGroupPanel = False
        '
        'col1
        '
        Me.col1.Caption = "Created By"
        Me.col1.FieldName = "CreateBy"
        Me.col1.Name = "col1"
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 0
        Me.col1.Width = 98
        '
        'col2
        '
        Me.col2.Caption = "Emp ID"
        Me.col2.FieldName = "EmpID"
        Me.col2.Name = "col2"
        Me.col2.Visible = True
        Me.col2.VisibleIndex = 1
        Me.col2.Width = 95
        '
        'col3
        '
        Me.col3.Caption = "Emp Name"
        Me.col3.FieldName = "EmpName"
        Me.col3.Name = "col3"
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 2
        Me.col3.Width = 223
        '
        'col4
        '
        Me.col4.Caption = "Doc No"
        Me.col4.FieldName = "DocNo"
        Me.col4.Name = "col4"
        Me.col4.Visible = True
        Me.col4.VisibleIndex = 3
        Me.col4.Width = 103
        '
        'col5
        '
        Me.col5.Caption = "Leave Code"
        Me.col5.FieldName = "LeaveCode"
        Me.col5.Name = "col5"
        Me.col5.Visible = True
        Me.col5.VisibleIndex = 4
        Me.col5.Width = 100
        '
        'col6
        '
        Me.col6.Caption = "Status"
        Me.col6.FieldName = "STATUS"
        Me.col6.Name = "col6"
        Me.col6.Visible = True
        Me.col6.VisibleIndex = 5
        Me.col6.Width = 107
        '
        'col7
        '
        Me.col7.Caption = "Request Date"
        Me.col7.FieldName = "RequestDate"
        Me.col7.Name = "col7"
        Me.col7.Visible = True
        Me.col7.VisibleIndex = 6
        Me.col7.Width = 112
        '
        'col8
        '
        Me.col8.Caption = "Begin Date"
        Me.col8.FieldName = "BeginDate"
        Me.col8.Name = "col8"
        Me.col8.Visible = True
        Me.col8.VisibleIndex = 7
        Me.col8.Width = 109
        '
        'col9
        '
        Me.col9.Caption = "End Date"
        Me.col9.FieldName = "EndDate"
        Me.col9.Name = "col9"
        Me.col9.Visible = True
        Me.col9.VisibleIndex = 8
        Me.col9.Width = 116
        '
        'col10
        '
        Me.col10.Caption = "Note"
        Me.col10.FieldName = "Note"
        Me.col10.Name = "col10"
        Me.col10.Visible = True
        Me.col10.VisibleIndex = 9
        Me.col10.Width = 358
        '
        'diaSave
        '
        Me.diaSave.Filter = "Excel 2007 | *.xlsx"
        '
        'diaOpen
        '
        Me.diaOpen.Filter = "Excel 2007 | *.xlsx"
        '
        'frmLeaveHis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 539)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLeaveHis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LEAVE HISTORY"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gcLeaveHis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLeaveHis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents diaSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents diaOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gcLeaveHis As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLeaveHis As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10 As DevExpress.XtraGrid.Columns.GridColumn
End Class
