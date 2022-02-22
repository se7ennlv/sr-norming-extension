Imports NormExt.NormingExtension

Public Class FrmSysCtrl
    Private Sub FrmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckSysState()
    End Sub

    Sub CheckSysState()
        Dim chkNormExtState As Integer = ExtensionDB.SelectField("SysStatus", "tbl_system_control", "SysID = 1", DataConnector.SelectedReturnType.SignleValue)
        Dim chkRmsState As Integer = ExtensionDB.SelectField("SysStatus", "tbl_system_control", "SysID = 2", DataConnector.SelectedReturnType.SignleValue)

        If chkNormExtState = 0 Then
            btnNormExtCtrl.Text = "Enable The Program Norming Extension"
            btnNormExtCtrl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnNormExtCtrl.Appearance.ForeColor = System.Drawing.Color.Green
        Else
            btnNormExtCtrl.Text = "Disable The Program Norming Extension"
            btnNormExtCtrl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnNormExtCtrl.Appearance.ForeColor = System.Drawing.Color.Red
        End If

        If chkRmsState = 0 Then
            btnRmsCtrl.Text = "Enable The RMS System"

            btnRmsCtrl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnRmsCtrl.Appearance.ForeColor = System.Drawing.Color.Green
        Else
            btnRmsCtrl.Text = "Disable The RMS System"

            btnRmsCtrl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnRmsCtrl.Appearance.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Private Sub btnNormExtCtrl_Click(sender As Object, e As EventArgs) Handles btnNormExtCtrl.Click
        Dim chkNormExtState As Integer = ExtensionDB.SelectField("SysStatus", "tbl_system_control", "SysID = 1", DataConnector.SelectedReturnType.SignleValue)

        If chkNormExtState = 0 Then
            ExtensionDB.InitUpdateCommand("tbl_system_control")
            ExtensionDB.SetWhereField("SysID", 1)
            ExtensionDB.SetUpdateField("SysStatus", 1)
            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("The Program Norming Extension is enabled", MsgBoxStyle.Information, AppName)

            CheckSysState()
        Else
            ExtensionDB.InitUpdateCommand("tbl_system_control")
            ExtensionDB.SetWhereField("SysID", 1)
            ExtensionDB.SetUpdateField("SysStatus", 0)
            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("The Program Norming Extension is disabled", MsgBoxStyle.Information, AppName)

            CheckSysState()
        End If
    End Sub

    Private Sub btnRmsCtrl_Click(sender As Object, e As EventArgs) Handles btnRmsCtrl.Click
        Dim chkRmsState As Integer = ExtensionDB.SelectField("SysStatus", "tbl_system_control", "SysID = 2", DataConnector.SelectedReturnType.SignleValue)

        If chkRmsState = 0 Then
            ExtensionDB.InitUpdateCommand("tbl_system_control")
            ExtensionDB.SetWhereField("SysID", 2)
            ExtensionDB.SetUpdateField("SysStatus", 1)
            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("The RMS System is enabled", MsgBoxStyle.Information, AppName)

            CheckSysState()
        Else
            ExtensionDB.InitUpdateCommand("tbl_system_control")
            ExtensionDB.SetWhereField("SysID", 2)
            ExtensionDB.SetUpdateField("SysStatus", 0)
            ExtensionDB.ExecuteUpdateCommand()

            MsgBox("The RMS System is disabled", MsgBoxStyle.Information, AppName)

            CheckSysState()
        End If
    End Sub


End Class