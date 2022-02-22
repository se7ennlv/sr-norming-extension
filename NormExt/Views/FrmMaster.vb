Imports DevExpress.XtraBars.BarItemVisibility

Partial Public Class FrmMaster
    Inherits DevExpress.XtraEditors.XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmMaster_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CurrentSession = New LoginSession()
        FrmLogin.Show()

    End Sub

    Private Sub FrmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = AppName + " | ( Logged User: " + CurrentSession.User.Name + ")"

        If CurrentSession.User.ID = "admin" Then
            mnuSetup.Visibility = Always
            mnuRoster.Enabled = True
            mnuLeave.Enabled = True
            mnuAttd.Enabled = True
            mnuAdminRpt.Visibility = Always
            mnuSysCtrl.Visibility = Always
            mnuFpTran.Visibility = Always
            mnuPayroll.Visibility = Always
        Else
            mnuSetup.Visibility = Never
            mnuRoster.Enabled = If(CurrentSession.User.RosterAccessLevel > 0, True, False)
            mnuLeave.Enabled = If(CurrentSession.User.LeaveAccessLevel > 0, True, False)
            mnuAttd.Enabled = If(CurrentSession.User.tbl_attendanceAccessLevel > 0, True, False)
            mnuHodAppr.Enabled = If(CurrentSession.User.HodApprLevel > 0, True, False)
            mnuHrAttdAppr.Enabled = If(CurrentSession.User.HrAttdApprLevel > 0, True, False)
            mnuHrDirAppr.Enabled = If(CurrentSession.User.HrDirectApprLevel > 0, True, False)
            mnuAdminRpt.Visibility = If(CurrentSession.User.AccessAdminReport > 0, Always, Never)
            mnuSysCtrl.Visibility = If(CurrentSession.User.AccessPayroll > 0, Always, Never)
        End If

        If CurrentSession.User.RoleID > 1 Then
            mnuApproveLeave.Visibility = Always
        End If

        If CurrentSession.User.WorkingDepartment.ID = "IT" Or CurrentSession.User.WorkingDepartment.ID = "HR" Then
            mnuBackupFp.Visibility = Always
        End If

    End Sub

    Private Sub mnuUser_Click(sender As Object, e As EventArgs)
        ShowForm(frmUser)
    End Sub

    Private Sub mnuDept_Click(sender As Object, e As EventArgs)
        ShowForm(frmDept)
    End Sub

    Private Sub ConfiguratonToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ShowForm(frmConfig)
    End Sub

    Private Sub DatabaseSetpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmDBSetup
        frm.ShowDialog()
    End Sub

    Private Sub mnuHodAppr_Click(sender As Object, e As EventArgs)
        ShowForm(frmHodAppr)
    End Sub

    Private Sub mnuAttdReport_Click(sender As Object, e As EventArgs)
        ShowForm(frmAttd)
    End Sub

    Private Sub mnuHodAppr_Click_1(sender As Object, e As EventArgs)
        ShowForm(frmHodAppr)
    End Sub


    Private Sub mnuHrAttdAppr_Click(sender As Object, e As EventArgs)
        ShowForm(frmHrAttdAppr)
    End Sub

    Private Sub mnuHrDirectAppr_Click(sender As Object, e As EventArgs)
        ShowForm(FrmHrManaAppr)
    End Sub


    Private Sub mnuDept_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDept.ItemClick
        ShowForm(frmDept)
    End Sub

    Private Sub mnuUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUser.ItemClick
        ShowForm(frmUser)
    End Sub

    Private Sub mnuSmtp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSmtp.ItemClick
        ShowForm(frmConfig)
    End Sub

    Private Sub mnuDb_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDb.ItemClick
        Dim frm As New frmDBSetup
        frm.ShowDialog()
    End Sub

    Private Sub mnuRoster_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuRoster.ItemClick
        ShowForm(FrmRoster)
    End Sub

    Private Sub mnuAttdRp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuAttdRp.ItemClick
        'MsgBox("Sorry!, We are updating this function will be can access again soon")
        ShowForm(frmAttd)
    End Sub

    Private Sub mnuHodAppr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuHodAppr.ItemClick
        ShowForm(frmHodAppr)
    End Sub

    Private Sub mnuHrAppr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuHrDirAppr.ItemClick
        ShowForm(FrmHrManaAppr)
    End Sub


    Private Sub mnuExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuExit.ItemClick
        Me.Close()
    End Sub

    Private Sub mnuHrAttdAppr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuHrAttdAppr.ItemClick
        ShowForm(frmHrAttdAppr)
    End Sub


    Private Sub mnuWaitHod_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuWaitHod.ItemClick
        ShowForm(FrmWaitHod)
    End Sub

    Private Sub mnuErrUsed_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuErrUsed.ItemClick
        ShowForm(FrmErrUsed)
    End Sub

    Private Sub mnuPayroll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSysCtrl.ItemClick
        ShowForm(FrmSysCtrl)
    End Sub

    Private Sub mnuBackupFp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuBackupFp.ItemClick
        ShowForm(FrmBackupFp)
    End Sub

    Private Sub mnuAnalyser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuAnalyser.ItemClick
        Dim frm As Form = New FrmManalyser
        frm.ShowDialog()
    End Sub



    Private Sub mnuImpMyMart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuImpMyMart.ItemClick
        Dim frm As Form = New FrmImportMyMart
        frm.ShowDialog()
    End Sub

    Private Sub mnuImpAttd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuImpAttd.ItemClick
        Dim frm As Form = New FrmImportAttdRecord
        frm.ShowDialog()
    End Sub

    Private Sub mnuRequestLeave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuRequestLeave.ItemClick
        ShowForm(FrmLeaveRequest)
    End Sub

    Private Sub mnuApproveLeave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuApproveLeave.ItemClick
        ShowForm(FrmLeaveToDoList)
    End Sub
End Class
