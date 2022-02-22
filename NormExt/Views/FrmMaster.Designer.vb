Partial Public Class FrmMaster
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaster))
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.mnuSetup = New DevExpress.XtraBars.BarButtonItem()
        Me.settingPopup = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mnuDept = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuUser = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuSmtp = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDb = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuRoster = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuLeave = New DevExpress.XtraBars.BarButtonItem()
        Me.leavePopup = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mnuRequestLeave = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuApproveLeave = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuAttd = New DevExpress.XtraBars.BarButtonItem()
        Me.attdPopup = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mnuAttdRp = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuHodAppr = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuHrAttdAppr = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuHrDirAppr = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuSysCtrl = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuFpTran = New DevExpress.XtraBars.BarButtonItem()
        Me.fingerprintPopup = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mnuAnalyser = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuBackupFp = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuPayroll = New DevExpress.XtraBars.BarButtonItem()
        Me.payrollPopup = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mnuImpAttd = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuImpTimeCard = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuImpMyMart = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuAdminRpt = New DevExpress.XtraBars.BarButtonItem()
        Me.reportPopup = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mnuWaitHod = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuErrUsed = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuManual = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuExit = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem9 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem10 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem11 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDecrypt = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingPopup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leavePopup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.attdPopup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fingerprintPopup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollPopup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportPopup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarSubItem6, Me.mnuRoster, Me.BarSubItem7, Me.mnuLeave, Me.BarSubItem8, Me.mnuAttd, Me.BarSubItem9, Me.mnuManual, Me.BarSubItem10, Me.mnuExit, Me.BarButtonItem6, Me.mnuSetup, Me.mnuDept, Me.mnuUser, Me.mnuSmtp, Me.mnuDb, Me.mnuAttdRp, Me.mnuHodAppr, Me.mnuHrDirAppr, Me.mnuHrAttdAppr, Me.BarSubItem11, Me.BarButtonItem1, Me.mnuDecrypt, Me.BarButtonItem2, Me.BarButtonItem3, Me.mnuAdminRpt, Me.mnuWaitHod, Me.mnuErrUsed, Me.mnuSysCtrl, Me.mnuFpTran, Me.mnuBackupFp, Me.BarButtonItem5, Me.mnuAnalyser, Me.BarButtonItem7, Me.mnuPayroll, Me.BarButtonItem10, Me.mnuImpAttd, Me.mnuImpTimeCard, Me.mnuImpMyMart, Me.BarButtonItem4, Me.BarButtonItem9, Me.BarButtonItem11, Me.mnuRequestLeave, Me.mnuApproveLeave})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 49
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuSetup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuRoster, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuLeave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuAttd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuSysCtrl, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuFpTran, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuPayroll, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuAdminRpt, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuManual, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'mnuSetup
        '
        Me.mnuSetup.ActAsDropDown = True
        Me.mnuSetup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuSetup.Caption = "Settings"
        Me.mnuSetup.DropDownControl = Me.settingPopup
        Me.mnuSetup.Glyph = CType(resources.GetObject("mnuSetup.Glyph"), System.Drawing.Image)
        Me.mnuSetup.Id = 16
        Me.mnuSetup.LargeGlyph = CType(resources.GetObject("mnuSetup.LargeGlyph"), System.Drawing.Image)
        Me.mnuSetup.Name = "mnuSetup"
        '
        'settingPopup
        '
        Me.settingPopup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDept), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuUser), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuSmtp), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDb)})
        Me.settingPopup.Manager = Me.BarManager1
        Me.settingPopup.Name = "settingPopup"
        '
        'mnuDept
        '
        Me.mnuDept.Caption = "Department Management"
        Me.mnuDept.Id = 17
        Me.mnuDept.Name = "mnuDept"
        '
        'mnuUser
        '
        Me.mnuUser.Caption = "User Management"
        Me.mnuUser.Id = 18
        Me.mnuUser.Name = "mnuUser"
        '
        'mnuSmtp
        '
        Me.mnuSmtp.Caption = "SMTP Management"
        Me.mnuSmtp.Id = 19
        Me.mnuSmtp.Name = "mnuSmtp"
        '
        'mnuDb
        '
        Me.mnuDb.Caption = "Database Management"
        Me.mnuDb.Id = 20
        Me.mnuDb.Name = "mnuDb"
        '
        'mnuRoster
        '
        Me.mnuRoster.Caption = "Roster"
        Me.mnuRoster.Glyph = CType(resources.GetObject("mnuRoster.Glyph"), System.Drawing.Image)
        Me.mnuRoster.Id = 6
        Me.mnuRoster.LargeGlyph = CType(resources.GetObject("mnuRoster.LargeGlyph"), System.Drawing.Image)
        Me.mnuRoster.Name = "mnuRoster"
        '
        'mnuLeave
        '
        Me.mnuLeave.ActAsDropDown = True
        Me.mnuLeave.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuLeave.Caption = "Leave"
        Me.mnuLeave.DropDownControl = Me.leavePopup
        Me.mnuLeave.Glyph = CType(resources.GetObject("mnuLeave.Glyph"), System.Drawing.Image)
        Me.mnuLeave.Id = 8
        Me.mnuLeave.LargeGlyph = CType(resources.GetObject("mnuLeave.LargeGlyph"), System.Drawing.Image)
        Me.mnuLeave.Name = "mnuLeave"
        '
        'leavePopup
        '
        Me.leavePopup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuRequestLeave), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuApproveLeave)})
        Me.leavePopup.Manager = Me.BarManager1
        Me.leavePopup.Name = "leavePopup"
        '
        'mnuRequestLeave
        '
        Me.mnuRequestLeave.Caption = "Request Leave"
        Me.mnuRequestLeave.Id = 47
        Me.mnuRequestLeave.Name = "mnuRequestLeave"
        '
        'mnuApproveLeave
        '
        Me.mnuApproveLeave.Caption = "Approve Leave"
        Me.mnuApproveLeave.Id = 48
        Me.mnuApproveLeave.Name = "mnuApproveLeave"
        Me.mnuApproveLeave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'mnuAttd
        '
        Me.mnuAttd.ActAsDropDown = True
        Me.mnuAttd.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuAttd.Caption = "Attendance"
        Me.mnuAttd.DropDownControl = Me.attdPopup
        Me.mnuAttd.Glyph = CType(resources.GetObject("mnuAttd.Glyph"), System.Drawing.Image)
        Me.mnuAttd.Id = 10
        Me.mnuAttd.LargeGlyph = CType(resources.GetObject("mnuAttd.LargeGlyph"), System.Drawing.Image)
        Me.mnuAttd.Name = "mnuAttd"
        '
        'attdPopup
        '
        Me.attdPopup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuAttdRp), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuHodAppr), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuHrAttdAppr), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuHrDirAppr)})
        Me.attdPopup.Manager = Me.BarManager1
        Me.attdPopup.Name = "attdPopup"
        '
        'mnuAttdRp
        '
        Me.mnuAttdRp.Caption = "Attendance Report"
        Me.mnuAttdRp.Id = 21
        Me.mnuAttdRp.Name = "mnuAttdRp"
        '
        'mnuHodAppr
        '
        Me.mnuHodAppr.Caption = "HOD Approval"
        Me.mnuHodAppr.Id = 22
        Me.mnuHodAppr.Name = "mnuHodAppr"
        '
        'mnuHrAttdAppr
        '
        Me.mnuHrAttdAppr.Caption = "HR Attendance Verify"
        Me.mnuHrAttdAppr.Id = 24
        Me.mnuHrAttdAppr.Name = "mnuHrAttdAppr"
        '
        'mnuHrDirAppr
        '
        Me.mnuHrDirAppr.Caption = "HR Manager Approval"
        Me.mnuHrDirAppr.Id = 23
        Me.mnuHrDirAppr.Name = "mnuHrDirAppr"
        '
        'mnuSysCtrl
        '
        Me.mnuSysCtrl.Caption = "Systems Control"
        Me.mnuSysCtrl.Glyph = CType(resources.GetObject("mnuSysCtrl.Glyph"), System.Drawing.Image)
        Me.mnuSysCtrl.Id = 33
        Me.mnuSysCtrl.LargeGlyph = CType(resources.GetObject("mnuSysCtrl.LargeGlyph"), System.Drawing.Image)
        Me.mnuSysCtrl.Name = "mnuSysCtrl"
        '
        'mnuFpTran
        '
        Me.mnuFpTran.ActAsDropDown = True
        Me.mnuFpTran.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuFpTran.Caption = "FP Transaction"
        Me.mnuFpTran.DropDownControl = Me.fingerprintPopup
        Me.mnuFpTran.Glyph = CType(resources.GetObject("mnuFpTran.Glyph"), System.Drawing.Image)
        Me.mnuFpTran.Id = 34
        Me.mnuFpTran.LargeGlyph = CType(resources.GetObject("mnuFpTran.LargeGlyph"), System.Drawing.Image)
        Me.mnuFpTran.Name = "mnuFpTran"
        '
        'fingerprintPopup
        '
        Me.fingerprintPopup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuAnalyser), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuBackupFp)})
        Me.fingerprintPopup.Manager = Me.BarManager1
        Me.fingerprintPopup.Name = "fingerprintPopup"
        '
        'mnuAnalyser
        '
        Me.mnuAnalyser.Caption = "Manually Analyser"
        Me.mnuAnalyser.Id = 37
        Me.mnuAnalyser.Name = "mnuAnalyser"
        '
        'mnuBackupFp
        '
        Me.mnuBackupFp.Caption = "Backup FP Data"
        Me.mnuBackupFp.Id = 35
        Me.mnuBackupFp.Name = "mnuBackupFp"
        Me.mnuBackupFp.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'mnuPayroll
        '
        Me.mnuPayroll.ActAsDropDown = True
        Me.mnuPayroll.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuPayroll.Caption = "Payroll Add-on"
        Me.mnuPayroll.DropDownControl = Me.payrollPopup
        Me.mnuPayroll.Glyph = CType(resources.GetObject("mnuPayroll.Glyph"), System.Drawing.Image)
        Me.mnuPayroll.Id = 39
        Me.mnuPayroll.LargeGlyph = CType(resources.GetObject("mnuPayroll.LargeGlyph"), System.Drawing.Image)
        Me.mnuPayroll.Name = "mnuPayroll"
        Me.mnuPayroll.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'payrollPopup
        '
        Me.payrollPopup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuImpAttd, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuImpTimeCard), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuImpMyMart)})
        Me.payrollPopup.Manager = Me.BarManager1
        Me.payrollPopup.Name = "payrollPopup"
        '
        'mnuImpAttd
        '
        Me.mnuImpAttd.Caption = "Import Attendance Records"
        Me.mnuImpAttd.Id = 41
        Me.mnuImpAttd.Name = "mnuImpAttd"
        '
        'mnuImpTimeCard
        '
        Me.mnuImpTimeCard.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.mnuImpTimeCard.Caption = "Import Attendance Timecard"
        Me.mnuImpTimeCard.Id = 42
        Me.mnuImpTimeCard.Name = "mnuImpTimeCard"
        '
        'mnuImpMyMart
        '
        Me.mnuImpMyMart.Caption = "Import MyMart Timecard"
        Me.mnuImpMyMart.Id = 43
        Me.mnuImpMyMart.Name = "mnuImpMyMart"
        '
        'mnuAdminRpt
        '
        Me.mnuAdminRpt.ActAsDropDown = True
        Me.mnuAdminRpt.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuAdminRpt.Caption = "Admin Reports"
        Me.mnuAdminRpt.DropDownControl = Me.reportPopup
        Me.mnuAdminRpt.Glyph = CType(resources.GetObject("mnuAdminRpt.Glyph"), System.Drawing.Image)
        Me.mnuAdminRpt.Id = 30
        Me.mnuAdminRpt.LargeGlyph = CType(resources.GetObject("mnuAdminRpt.LargeGlyph"), System.Drawing.Image)
        Me.mnuAdminRpt.Name = "mnuAdminRpt"
        Me.mnuAdminRpt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'reportPopup
        '
        Me.reportPopup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuWaitHod), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuErrUsed)})
        Me.reportPopup.Manager = Me.BarManager1
        Me.reportPopup.Name = "reportPopup"
        '
        'mnuWaitHod
        '
        Me.mnuWaitHod.Caption = "Waiting HOD Approve"
        Me.mnuWaitHod.Id = 31
        Me.mnuWaitHod.Name = "mnuWaitHod"
        '
        'mnuErrUsed
        '
        Me.mnuErrUsed.Caption = "ERR Used"
        Me.mnuErrUsed.Id = 32
        Me.mnuErrUsed.Name = "mnuErrUsed"
        '
        'mnuManual
        '
        Me.mnuManual.Caption = "User Manual "
        Me.mnuManual.Glyph = CType(resources.GetObject("mnuManual.Glyph"), System.Drawing.Image)
        Me.mnuManual.Id = 12
        Me.mnuManual.LargeGlyph = CType(resources.GetObject("mnuManual.LargeGlyph"), System.Drawing.Image)
        Me.mnuManual.Name = "mnuManual"
        Me.mnuManual.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'mnuExit
        '
        Me.mnuExit.Caption = "Exit "
        Me.mnuExit.Glyph = CType(resources.GetObject("mnuExit.Glyph"), System.Drawing.Image)
        Me.mnuExit.Id = 14
        Me.mnuExit.LargeGlyph = CType(resources.GetObject("mnuExit.LargeGlyph"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem6, DevExpress.XtraBars.BarItemPaintStyle.Caption)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.AllowDrawArrow = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarSubItem1.Caption = "Version 2.0.6.9"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.ItemInMenuAppearance.Normal.Options.UseTextOptions = True
        Me.BarSubItem1.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem6.AllowDrawArrow = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarSubItem6.Caption = "Developed by IT"
        Me.BarSubItem6.Id = 5
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1161, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 544)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1161, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 515)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1161, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 515)
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "|"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Develop By Seven and Jim"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = """&"""
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Develop By Seven and Jim"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "|"
        Me.BarSubItem7.Id = 7
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "|"
        Me.BarSubItem8.Id = 9
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'BarSubItem9
        '
        Me.BarSubItem9.Caption = "|"
        Me.BarSubItem9.Id = 11
        Me.BarSubItem9.Name = "BarSubItem9"
        '
        'BarSubItem10
        '
        Me.BarSubItem10.Caption = "|"
        Me.BarSubItem10.Id = 13
        Me.BarSubItem10.Name = "BarSubItem10"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Exit"
        Me.BarButtonItem6.Id = 15
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarSubItem11
        '
        Me.BarSubItem11.Caption = "BarSubItem11"
        Me.BarSubItem11.Id = 25
        Me.BarSubItem11.Name = "BarSubItem11"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Connection status"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 26
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'mnuDecrypt
        '
        Me.mnuDecrypt.Caption = "Decrypt"
        Me.mnuDecrypt.Id = 27
        Me.mnuDecrypt.Name = "mnuDecrypt"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 28
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Total Waiting HOD"
        Me.BarButtonItem3.Id = 29
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 36
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Payroll Processing"
        Me.BarButtonItem7.Id = 38
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "BarButtonItem10"
        Me.BarButtonItem10.Id = 40
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 44
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "BarButtonItem9"
        Me.BarButtonItem9.Id = 45
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "BarButtonItem11"
        Me.BarButtonItem11.Id = 46
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.ActAsDropDown = True
        Me.BarButtonItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem8.Caption = "FP Transaction"
        Me.BarButtonItem8.DropDownControl = Me.fingerprintPopup
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 34
        Me.BarButtonItem8.LargeGlyph = CType(resources.GetObject("BarButtonItem8.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'FrmMaster
        '
        Me.Appearance.Options.UseFont = True
        Me.ClientSize = New System.Drawing.Size(1161, 569)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Name = "FrmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingPopup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leavePopup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.attdPopup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fingerprintPopup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollPopup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportPopup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuRoster As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuLeave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuAttd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem9 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuManual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem10 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuSetup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents settingPopup As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuDept As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuSmtp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuDb As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents attdPopup As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuAttdRp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuHodAppr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuHrDirAppr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuHrAttdAppr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem11 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuDecrypt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuAdminRpt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents reportPopup As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuWaitHod As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuErrUsed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuSysCtrl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuFpTran As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents fingerprintPopup As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuBackupFp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuAnalyser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuPayroll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents payrollPopup As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuImpAttd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuImpTimeCard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuImpMyMart As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents leavePopup As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuRequestLeave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuApproveLeave As DevExpress.XtraBars.BarButtonItem

#End Region

End Class
