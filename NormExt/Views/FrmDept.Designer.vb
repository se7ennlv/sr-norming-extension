<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDept))
        Me.txtDeptName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDept = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lstShiftGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.gcDept = New DevExpress.XtraGrid.GridControl()
        Me.gvDept = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGroupCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.gcEmail = New DevExpress.XtraGrid.GridControl()
        Me.gvEmail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnRemoveEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHodId1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtHodName1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtHodName2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtHodId2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtDeptName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstShiftGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHodId1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHodName1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHodName2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHodId2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDeptName
        '
        Me.txtDeptName.Location = New System.Drawing.Point(117, 53)
        Me.txtDeptName.Name = "txtDeptName"
        Me.txtDeptName.Size = New System.Drawing.Size(304, 20)
        Me.txtDeptName.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Department Name"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(346, 25)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(117, 27)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Size = New System.Drawing.Size(108, 20)
        Me.txtDept.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Department ID"
        '
        'lstShiftGroup
        '
        Me.lstShiftGroup.Location = New System.Drawing.Point(44, 38)
        Me.lstShiftGroup.Name = "lstShiftGroup"
        Me.lstShiftGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lstShiftGroup.Properties.DisplayMember = "ATSHIFTGRP_DESC"
        Me.lstShiftGroup.Properties.NullText = "Select Shift Group"
        Me.lstShiftGroup.Properties.ShowFooter = False
        Me.lstShiftGroup.Properties.ShowHeader = False
        Me.lstShiftGroup.Properties.ShowLines = False
        Me.lstShiftGroup.Properties.ValueMember = "ATSHIFTGRP_CODE"
        Me.lstShiftGroup.Size = New System.Drawing.Size(223, 20)
        Me.lstShiftGroup.TabIndex = 6
        '
        'gcDept
        '
        Me.gcDept.Location = New System.Drawing.Point(44, 64)
        Me.gcDept.MainView = Me.gvDept
        Me.gcDept.Name = "gcDept"
        Me.gcDept.Size = New System.Drawing.Size(223, 167)
        Me.gcDept.TabIndex = 7
        Me.gcDept.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDept})
        '
        'gvDept
        '
        Me.gvDept.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGroupCode})
        Me.gvDept.GridControl = Me.gcDept
        Me.gvDept.Name = "gvDept"
        Me.gvDept.OptionsView.ShowGroupPanel = False
        Me.gvDept.OptionsView.ShowIndicator = False
        '
        'colGroupCode
        '
        Me.colGroupCode.Caption = "Shift Group Code"
        Me.colGroupCode.FieldName = "GroupCode"
        Me.colGroupCode.Name = "colGroupCode"
        Me.colGroupCode.OptionsColumn.AllowEdit = False
        Me.colGroupCode.OptionsColumn.ReadOnly = True
        Me.colGroupCode.Visible = True
        Me.colGroupCode.VisibleIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(273, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        '
        'btnRemove
        '
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(273, 65)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(20, 181)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(694, 391)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.lstShiftGroup)
        Me.XtraTabPage1.Controls.Add(Me.btnRemove)
        Me.XtraTabPage1.Controls.Add(Me.gcDept)
        Me.XtraTabPage1.Controls.Add(Me.btnAdd)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(688, 421)
        Me.XtraTabPage1.Text = "Shift Group"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.gcEmail)
        Me.XtraTabPage2.Controls.Add(Me.btnRemoveEmail)
        Me.XtraTabPage2.Controls.Add(Me.btnAddEmail)
        Me.XtraTabPage2.Controls.Add(Me.txtEmail)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(688, 363)
        Me.XtraTabPage2.Text = "Group Email"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(66, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Email"
        '
        'gcEmail
        '
        Me.gcEmail.Location = New System.Drawing.Point(96, 56)
        Me.gcEmail.MainView = Me.gvEmail
        Me.gcEmail.Name = "gcEmail"
        Me.gcEmail.Size = New System.Drawing.Size(310, 205)
        Me.gcEmail.TabIndex = 3
        Me.gcEmail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmail})
        '
        'gvEmail
        '
        Me.gvEmail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmail})
        Me.gvEmail.GridControl = Me.gcEmail
        Me.gvEmail.Name = "gvEmail"
        Me.gvEmail.OptionsView.ShowGroupPanel = False
        Me.gvEmail.OptionsView.ShowIndicator = False
        '
        'colEmail
        '
        Me.colEmail.Caption = "Email Address"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 0
        '
        'btnRemoveEmail
        '
        Me.btnRemoveEmail.Image = CType(resources.GetObject("btnRemoveEmail.Image"), System.Drawing.Image)
        Me.btnRemoveEmail.Location = New System.Drawing.Point(441, 56)
        Me.btnRemoveEmail.Name = "btnRemoveEmail"
        Me.btnRemoveEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveEmail.TabIndex = 2
        Me.btnRemoveEmail.Text = "Remove"
        '
        'btnAddEmail
        '
        Me.btnAddEmail.Image = CType(resources.GetObject("btnAddEmail.Image"), System.Drawing.Image)
        Me.btnAddEmail.Location = New System.Drawing.Point(441, 27)
        Me.btnAddEmail.Name = "btnAddEmail"
        Me.btnAddEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnAddEmail.TabIndex = 1
        Me.btnAddEmail.Text = "Add"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 29)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(310, 20)
        Me.txtEmail.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(65, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "HOD ID1"
        '
        'txtHodId1
        '
        Me.txtHodId1.Location = New System.Drawing.Point(117, 82)
        Me.txtHodId1.Name = "txtHodId1"
        Me.txtHodId1.Size = New System.Drawing.Size(108, 20)
        Me.txtHodId1.TabIndex = 12
        '
        'txtHodName1
        '
        Me.txtHodName1.Location = New System.Drawing.Point(231, 82)
        Me.txtHodName1.Name = "txtHodName1"
        Me.txtHodName1.Properties.ReadOnly = True
        Me.txtHodName1.Size = New System.Drawing.Size(190, 20)
        Me.txtHodName1.TabIndex = 13
        '
        'txtHodName2
        '
        Me.txtHodName2.Location = New System.Drawing.Point(231, 108)
        Me.txtHodName2.Name = "txtHodName2"
        Me.txtHodName2.Properties.ReadOnly = True
        Me.txtHodName2.Size = New System.Drawing.Size(190, 20)
        Me.txtHodName2.TabIndex = 16
        '
        'txtHodId2
        '
        Me.txtHodId2.Location = New System.Drawing.Point(117, 108)
        Me.txtHodId2.Name = "txtHodId2"
        Me.txtHodId2.Size = New System.Drawing.Size(108, 20)
        Me.txtHodId2.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(65, 111)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "HOD ID2"
        '
        'frmDept
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 712)
        Me.Controls.Add(Me.txtHodName2)
        Me.Controls.Add(Me.txtHodId2)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtHodName1)
        Me.Controls.Add(Me.txtHodId1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDeptName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEPARTMENTS"
        CType(Me.txtDeptName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstShiftGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.gcEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHodId1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHodName1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHodName2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHodId2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDeptName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDept As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstShiftGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcDept As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDept As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGroupCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcEmail As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnRemoveEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHodId1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHodName1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtHodName2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHodId2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
