Imports NormExt.NormingExtension

Public Class FrmLogin
    Inherits DevExpress.XtraEditors.XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtUname.EditValue = ""
            txtPwd.EditValue = ""

            If IO.File.Exists(".\system.conf") Then
                ReadConfigFile()

            Else
                Dim fm As New frmDBSetup
                fm.ShowDialog()
            End If

            MailSender = New MailService()
        Catch ex As Exception
            GetLog(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        NormingDB.Close()
        ExtensionDB.Close()
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPwd.EditValue.ToString.Trim.Length > 0 And txtUname.EditValue.ToString.Trim.Length > 0 Then
            CurrentSession = New LoginSession()
            CurrentSession.Open(txtUname.EditValue.ToString.Trim, txtPwd.EditValue.ToString.Trim)

            If CurrentSession.Connected = False Then
                MsgBox("Invalid User ID or Password. Please check again", MsgBoxStyle.Critical, AppName)
            Else
                Dim chkDept As String = CurrentSession.User.WorkingDepartment.ID.ToString.Trim
                Dim chkNormExtState As Integer = ExtensionDB.SelectField("SysStatus", "tbl_system_control", "SysID = 1", DataConnector.SelectedReturnType.SignleValue)

                If chkNormExtState = 0 And (chkDept <> "IT" And chkDept <> "HR") Then
                    MsgBox("Sorry we are running the payroll, The system will be available after running the payroll complete", MsgBoxStyle.Critical, AppName)
                    '--MsgBox("Sorry we are updating system, The system will be available soon", MsgBoxStyle.Critical, SoftName)

                    Application.Exit()
                Else
                    FrmMaster.Show()
                    Me.Hide()
                End If

                txtPwd.EditValue = ""
                txtUname.EditValue = ""
            End If
        Else
            MsgBox("Please input your id and password!", MsgBoxStyle.Critical, AppName)
        End If
    End Sub

    Private Sub btnChangePwd_Click(sender As Object, e As EventArgs) Handles btnChangePwd.Click
        If txtPwd.EditValue.ToString.Trim.Length > 0 And txtUname.EditValue.ToString.Trim.Length > 0 Then
            CurrentSession = New LoginSession()
            CurrentSession.Open(txtUname.EditValue.ToString.Trim, txtPwd.EditValue.ToString.Trim)
            If CurrentSession.Connected = False Then
                MsgBox("Invalid User ID or Password. Please check again", MsgBoxStyle.Critical, AppName)
            Else
                Dim frm As New frmChangPwd
                frm.txtOldPwd.EditValue = Cryptology.DecryptText(CurrentSession.User.Password)
                frm.txtNewPwd.EditValue = ""
                frm.txtConfirmNewPwd.EditValue = ""
                frm.ShowDialog()

            End If
        Else
            MsgBox("You don't enter User ID or Password. Please check again", MsgBoxStyle.Critical, AppName)
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

    End Sub
End Class