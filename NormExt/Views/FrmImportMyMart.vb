Imports System.ComponentModel

Public Class FrmImportMyMart
    Dim fDate As Date
    Dim tDate As Date
    Dim payGroup As String

    Dim totalEmp As Integer
    Dim nextEmp As Integer
    Dim empState As String
    Dim resultState As String
    Dim empCreditList As New DataTable
    Dim bgCommand As Integer = 0

    Private Sub FrmImportMyMart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        bgWorker = New BackgroundWorker

        Dim lakRate As Double = MyMartDB.SelectField("THBToCurrencyRate", "ExchangeRate", "Currency = 'KIP' ", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
        Dim usdRate As Double = MyMartDB.SelectField("THBToCurrencyRate", "ExchangeRate", "Currency = 'USD' ", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

        txtLak.EditValue = lakRate
        txtUsd.EditValue = usdRate
        GroupControl1.Enabled = False

        Dim periodList As DataTable = NormingDB.SelectField("FORMAT(PRSCHED_PDATESTART, 'yyyy-MM-dd') + ' - ' + FORMAT(PRSCHED_PDATEEND, 'yyyy-MM-dd') AS 'PayPeriod' ", "PRSCHED", "PRSCHED_SCHEDYEAR = '" + Now.Year.ToString() + "' ORDER BY PRSCHED_PERIOD", NormingExtension.DataConnector.SelectedReturnType.DataTable)

        lueGroup.Properties.DataSource = NormingDB.SelectField("PRGROUP_GROUPNAME, PRGROUP_CURRENCY", "PRGROUP", "PRGROUP_STATUS = 0", NormingExtension.DataConnector.SelectedReturnType.DataTable)
        lueGroup.EditValue = lueGroup.Properties.GetDataSourceValue(lueGroup.Properties.ValueMember, 0)
    End Sub


    Sub LoadData()
        fDate = CDate(deFrom.EditValue)
        tDate = CDate(deTo.EditValue)

        Dim currency As String = lueGroup.EditValue.ToString
        Dim selectStr As String = "EmpID, EmpCode, FullName, Dept, Positions, SUM(TranAfterDisc) AS [CreditBalance], emp.Currency, emp.PayCode, THBToCurrencyRate, CASE WHEN emp.Currency = 'USD' THEN CAST(SUM(TranAfterDisc / THBToCurrencyRate)AS DECIMAL(10,2)) ELSE CAST(SUM(TranAfterDisc * THBToCurrencyRate) AS DECIMAL(10,2)) END AS AfterExchange"
        Dim fromStr As String = "Transactions INNER JOIN Employees emp ON TranCustID = EmpCode INNER JOIN ExchangeRate rate ON emp.Currency = rate.Currency"
        Dim whereStr As String = "TranIsPaid = 0 AND CONVERT(DATE, TranCreatedAt) BETWEEN '" + fDate.ToString("yyyy-MM-dd") + "' AND '" + tDate.ToString("yyyy-MM-dd") + "' AND emp.PayCode = '" + currency + "' GROUP BY EmpID, EmpCode, FullName, Dept, Positions, emp.Currency, emp.PayCode, THBToCurrencyRate"

        empCreditList = MyMartDB.SelectField(selectStr, fromStr, whereStr, NormingExtension.DataConnector.SelectedReturnType.DataTable)

    End Sub

    Sub ImportData()
        Try
            payGroup = lueGroup.EditValue.ToString

            empState = "Checking and preparing data to import..."

            Dim btchCount As Integer = NormingDB.SelectField("COUNT(*)", "PRTCB", "PRTCB_BATCHDESC = 'Mart Timecard - " + fDate.ToString("dd-MM-yy") + " to " + tDate.ToString("dd-MM-yy") + " - " + payGroup + "'", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

            If btchCount = 0 Then
                Dim currencyCode As String = lueGroup.EditValue.ToString
                Dim selectStr As String = "EmpID, EmpCode, FullName, Dept, Positions, SUM(TranAfterDisc) AS [CreditBalance], emp.Currency, emp.PayCode, THBToCurrencyRate, CASE WHEN emp.Currency = 'USD' THEN CAST(SUM(TranAfterDisc / THBToCurrencyRate)AS DECIMAL(10,2)) ELSE CAST(SUM(TranAfterDisc * THBToCurrencyRate) AS DECIMAL(10,2)) END AS AfterExchange"
                Dim fromStr As String = "Transactions INNER JOIN Employees emp ON TranCustID = EmpCode INNER JOIN ExchangeRate rate ON emp.Currency = rate.Currency"
                Dim whereStr As String = "TranIsPaid = 0 AND CONVERT(DATE, TranCreatedAt) BETWEEN '" + fDate.ToString("yyyy-MM-dd") + "' AND '" + tDate.ToString("yyyy-MM-dd") + "' AND emp.PayCode = '" + currencyCode + "' GROUP BY EmpID, EmpCode, FullName, Dept, Positions, emp.Currency, emp.PayCode, THBToCurrencyRate"

                empCreditList = MyMartDB.SelectField(selectStr, fromStr, whereStr, NormingExtension.DataConnector.SelectedReturnType.DataTable)

                If empCreditList.Rows.Count > 0 Then
                    empState = "Creating Timecard Batch...."

                    Dim batchNo As Integer = NormingDB.SelectField("MAX(PRTCB_BATCHNO) + 1", "PRTCB", "", NormingExtension.DataConnector.SelectedReturnType.SignleValue)
                    Dim batDesc As String = "Mart Timecard - " + fDate.ToString("dd-MM-yy") + " to " + tDate.ToString("dd-MM-yy") + " - " + payGroup
                    Dim entryCnt As Integer = empCreditList.Rows.Count

                    NormingDB.InitInsertCommand("PRTCB")
                    NormingDB.InsertField("PRTCB_BATCHNO", batchNo)
                    NormingDB.InsertField("PRTCB_BATCHDESC", batDesc)
                    NormingDB.InsertField("PRTCB_BATCHDATE", Now())
                    NormingDB.InsertField("PRTCB_ENTITY", 2)
                    NormingDB.InsertField("PRTCB_BTCHTYPE", 1)
                    NormingDB.InsertField("PRTCB_PAYGROUP", payGroup)
                    NormingDB.InsertField("PRTCB_PEREND", tDate.ToString("yyyy-MM-dd 00:00:00.000"))
                    NormingDB.ExecuteInsertCommand()

                    totalEmp = empCreditList.Rows.Count

                    For i As Integer = 0 To empCreditList.Rows.Count - 1
                        Dim empID As String = empCreditList.Rows(i)("EmpID").ToString.Trim()
                        Dim empCode As String = empCreditList.Rows(i)("EmpCode").ToString.Trim()
                        Dim currency As String = empCreditList.Rows(i)("Currency").ToString.Trim()

                        empState = "Creating Timecard for " + empCode + " - " + empCreditList.Rows(i)("FullName").ToString.Trim()

                        nextEmp = i + 1

                        '****** Insert Main transaction to the table PRTCH *****
                        NormingDB.InitInsertCommand("PRTCH")
                        NormingDB.InsertField("PRTCH_EMPLOYEE", empID)
                        NormingDB.InsertField("PRTCH_PEREND", tDate.ToString("yyyy-MM-dd 00:00:00.000"))
                        NormingDB.InsertField("PRTCH_TIMECARD", "MART" + payGroup + tDate.ToString("yyyyMM") + (i + 1).ToString("00#"))
                        NormingDB.InsertField("PRTCH_CREATEDT", Now.Date.ToString("yyyy-MM-dd 00:00:00.000"))
                        NormingDB.InsertField("PRTCH_CREATEBY", "ADMIN")
                        NormingDB.InsertField("PRTCH_BATCHNO", batchNo)
                        NormingDB.InsertField("PRTCH_DESC", "MART Deduction for " + tDate.ToString("MMM-yy"))
                        NormingDB.InsertField("PRTCH_STARTDATE", Now.Date.ToString("yyyy-MM-dd 00:00:00.000"))
                        NormingDB.InsertField("PRTCH_PAYCUR", currency)
                        NormingDB.InsertField("PRTCH_LSTMNTBY", "ADMIN")
                        NormingDB.ExecuteInsertCommand()


                        '****** Insert Detail to the table PRTCD *****
                        NormingDB.InitInsertCommand("PRTCD")
                        NormingDB.InsertField("PRTCD_EMPLOYEE", empID)
                        NormingDB.InsertField("PRTCD_PEREND", tDate.ToString("yyyy-MM-dd 00:00:00.000"))
                        NormingDB.InsertField("PRTCD_TIMECARD", "MART" + payGroup + tDate.ToString("yyyyMM") + (i + 1).ToString("00#"))

                        Dim unique As Integer = NormingDB.SelectField("MAX(PRTCD_UNIQUE) + 1", "PRTCD", "", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

                        NormingDB.InsertField("PRTCD_UNIQUE", unique)
                        NormingDB.InsertField("PRTCD_BATCHNO", batchNo)
                        NormingDB.InsertField("PRTCD_EARNDED", "OTHDED")
                        NormingDB.InsertField("PRTCD_CATEGORY", 3)
                        NormingDB.InsertField("PRTCD_CALCMETH", 2)
                        NormingDB.InsertField("PRTCD_PAYCURR", currency)
                        NormingDB.InsertField("PRTCD_PAYRATETYPE", "")
                        NormingDB.InsertField("PRTCD_ALLOCSET", "")
                        NormingDB.InsertField("PRTCD_SRCCUR", currency)
                        NormingDB.InsertField("PRTCD_SOURCETYPE", "PR")
                        NormingDB.InsertField("PRTCD_RATE", empCreditList.Rows(i)("AfterExchange"))
                        NormingDB.InsertField("PRTCD_SRCRATE", empCreditList.Rows(i)("AfterExchange"))
                        NormingDB.ExecuteInsertCommand()

                    Next

                    resultState = "Import Completed."

                Else
                    resultState = "There is no record available for this selection criteria"
                End If
            Else
                resultState = "Mart Deduction from " + fDate.ToString("dd-MM-yy") + " to " + tDate.ToString("dd-MM-yy") + " for " + payGroup + " is already exist."
            End If

        Catch ex As Exception
            MsgBox("Something went wrong, Please contact developer", MsgBoxStyle.Information, AppName)
            GetLog(ex.Message)
        End Try
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If SplashScreenManager1.IsSplashFormVisible = False Then
            SplashScreenManager1.ShowWaitForm()
        End If

        If bgCommand = 1 Then
            SplashScreenManager1.SetWaitFormDescription("Loading data...")
            LoadData()
        Else
            SplashScreenManager1.SetWaitFormDescription("Importing data...")

            ImportData()
        End If
        
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If bgCommand = 1 Then
            gcEmpCreditList.DataSource = empCreditList
        Else
            nextEmp = 0
            totalEmp = 0
            progBar.Value = 0
            progBar.Maximum = 0
            lblState.Text = ""
            lblState.Visible = False

            MsgBox(resultState)

            GroupControl3.Enabled = True
            GroupControl4.Enabled = True
            Timer1.Enabled = False
        End If

        SplashScreenManager1.CloseWaitForm()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progBar.Maximum = totalEmp
        progBar.Value = nextEmp
        lblState.Text = empState
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Try
        '    Dim lakRate As Double = CDbl(txtLak.EditValue)
        '    Dim usdRate As Double = CDbl(txtUsd.EditValue)
        '    Dim countRows As Integer = MyMartDB.SelectField("COUNT(*)", "ExchangeRate", "", NormingExtension.DataConnector.SelectedReturnType.SignleValue)

        '    If countRows > 0 Then
        '        MyMartDB.InitUpdateCommand("ExchangeRate")
        '        MyMartDB.SetUpdateField("LAKToTHB", lakRate)
        '        MyMartDB.SetUpdateField("USDToTHB", usdRate)
        '        MyMartDB.ExecuteUpdateCommand()
        '    Else
        '        MyMartDB.InitInsertCommand("ExchangeRate")
        '        MyMartDB.InsertField("LAKToTHB", lakRate)
        '        MyMartDB.InsertField("USDToTHB", usdRate)
        '        MyMartDB.ExecuteInsertCommand()
        '    End If

        '    MsgBox("Save", MsgBoxStyle.Information, SoftName)
        'Catch ex As Exception
        'MsgBox("Something went wrong, Please contact developer", MsgBoxStyle.Information, SoftName)
        '    GetLog(ex.Message)
        'End Try
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        bgCommand = 1

        If deFrom.EditValue = Nothing Or deTo.EditValue = Nothing Then
            MsgBox("Please enter date period to correctly", MsgBoxStyle.Critical, AppName)
        Else
            GroupControl1.Enabled = True

            If bgWorker.IsBusy <> True Then
                bgWorker.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btnImport_Click_1(sender As Object, e As EventArgs) Handles btnImport.Click
        bgCommand = 2

        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True

        GroupControl3.Enabled = False
        GroupControl4.Enabled = False
        lblState.Visible = True
        Timer1.Enabled = True

        If bgWorker.IsBusy <> True Then
            bgWorker.RunWorkerAsync()
        End If
    End Sub

   
End Class