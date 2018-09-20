Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Format Date Time Pickers
        dtNeedBy.Format = DateTimePickerFormat.Custom
        dtNeedBy.CustomFormat = "MM/dd/yyyy"
        dtNeedBy.Value = Now.Date
        dtIssue.Format = DateTimePickerFormat.Custom
        dtIssue.CustomFormat = "MM/dd/yyyy"
        dtIssue.Value = Now.Date
        dtReview.Format = DateTimePickerFormat.Custom
        dtReview.CustomFormat = "MM/dd/yyyy"
        dtReview.Value = Now.Date
        dtImplementation.Format = DateTimePickerFormat.Custom
        dtImplementation.CustomFormat = "MM/dd/yyyy"
        dtImplementation.Value = Now.Date
        dtVerfied.Format = DateTimePickerFormat.Custom
        dtVerfied.CustomFormat = "MM/dd/yyyy"
        dtVerfied.Value = Now.Date

        'Connection to SQL server
        sStr1 = System.Net.Dns.GetHostName
        sStr1 = "This"
        If sStr1 = "W7SP1_VM" Then
            myConn = New SqlConnection("Server=W7SP1_VM\SQLEXPRESS; Database = thermaltech; Integrated Security=true;")

        Else
            Try
                myConn = New SqlConnection("Server=TTL-FS1\THERMFS1SQL;Database=thermaltech;User Id=sa;Password=Therm_SQL")
                'myConn = New SqlConnection("Server=RODNEYF5D6\SQLExpress;Database=thermaltech;User Id=sa;Password=Therm_SQL")   ' for in house testing
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "SELECT Category FROM dbo.dwg_cat"
                myConn.Open()
                myReader = myCmd.ExecuteReader()
                sStr2 = myCmd.Connection.State
                myConn.Close()
            Catch ex As Exception
                MsgBox("Error while connecting to database" & ex.ToString, MsgBoxStyle.Critical, "Error !!")
                Exit Sub
            End Try
        End If

        'Get requestor name from username
        sStr1 = My.User.Name.ToString
        iInt1 = sStr1.IndexOf("\")
        txtReq.Text = Strings.Mid(sStr1, iInt1 + 2, sStr1.Length)



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        TabControl1.SelectedIndex = 0
        sStr1 = MsgBox("This will Create a New ECR number, Continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Create New Number")
        If sStr1 = vbYes Then


            'Create Command Object
            Try
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "SELECT MAX(ECRNo) FROM ecr_sheet1"

                'Open connection
                myConn.Open()
                myReader = myCmd.ExecuteReader()
                If myReader.Read Then iECRNo_old = myReader.GetValue(0)
                myReader.Close()
                myConn.Close()


            Catch ex As Exception
                MsgBox("Cannot connect to the database-1.", MsgBoxStyle.Critical, "Error!")
                Exit Sub
            End Try
        Else
            Exit Sub
        End If

        'New ECRNo 
        iECRNo_new = iECRNo_old + 1
        txtECRNo.Text = iECRNo_new

        myReader.Close()
        myConn.Close()
        Call Enable_All()

        sStatus = "P"
        lblStatus.Text = sStatus

        sPersonnel = Get_Personnel()

        If String.IsNullOrEmpty(txtJobNo.Text) Then
            sJobNum = "-"
        Else
            sJobNum = txtJobNo.Text
        End If



        '-----------------------------------------------------------------------------------------------'
        'Create row in ecr_sheet1
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO ecr_sheet1 (ECRNo,Status,Jobno,Requestor," &
                            "IssueDate,NeedByDate,Request,Cat,CompDate) VALUES('" & iECRNo_new & "','" &
                            sStatus & "','" & sJobNum & "','" & sPersonnel & "','" & dtIssue.Value.Date &
                            "','" & dtNeedBy.Value.Date & "','-','0','')"
            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox(iECRNo_new & " assigned.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "New ECR assigned")
        Catch ex As Exception
            MsgBox("Cannot connect to the database-2" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try

        '--------------------------------------------------------------------------------------------------'
        'Create row in ecr_approval
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO ecr_approval (ECRNo,Status,EnggRep,EnggDate,PurchRep,PurchDate,AccRep,AccDate," &
                            "QARep,QADate,LogRep,LogDate,ProdRep,ProdDate) VALUES ('" & iECRNo_new & "','" &
                            sStatus & "','','','','','','','','','','','','')"
            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()
        Catch ex As Exception
            MsgBox("Cannot connect to the database-3" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try

        '----------------------------------------------------------------------------------------------------'
        'Create row in ecr_sheet2
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO ecr_sheet2 (ECRNo,Reviewer,ReviewDate,Accept,Notes,VerBy,VerDate,PartsDate)" &
                            " VALUES ('" & iECRNo_new & "','" & sPersonnel & "','',3,'N/A','-','','')"
            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()
        Catch ex As Exception
            MsgBox("Cannot connect to the database-4" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try

        '-----------------------------------------------------------------------------------------------------'
        'Create row in dispo_table
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO dispo_parts (ECRNo,DispoCode,QuantityAffected,Units,ProdHrs,EnggHrs,CostofMat)" &
                                "VALUES ('" & iECRNo_new & "','','','','','','')"
            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()
        Catch ex As Exception
            MsgBox("Cannot connect to the database-5" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try
        '------------------------------------------------------------------------------------------------------'


    End Sub

    Private Sub btnClearECR_Click(sender As Object, e As EventArgs) Handles btnClearECR.Click
        txtJobNo.Text = ""
        txtReq.Text = ""
        dtIssue.Text = ""
        dtNeedBy.Text = ""
        txtDwgNo.Text = ""
        txtTitle.Text = ""
        lblStatus.Text = ""
        txtComments.Text = ""
        cboVerifiedBy.Text = ""

        lblEngg.Text = ""
        lblPurch.Text = ""
        lblAcc.Text = ""
        lblQuantity.Text = ""
        lblLogistics.Text = ""
        lblProd.Text = ""

        lblDEngg.Text = "Date:"
        lblDPurch.Text = "Date:"
        lblDAcc.Text = "Date:"
        lblDQuantity.Text = "Date:"
        lblDLogistics.Text = "Date:"
        lblDProd.Text = "Date:"

        chk1DwgErr.CheckState = CheckState.Unchecked
        chk2Cost.CheckState = CheckState.Unchecked
        chk3MfgImp.CheckState = CheckState.Unchecked
        chk4Change.CheckState = CheckState.Unchecked
        chk5Quality.CheckState = CheckState.Unchecked
        chk6Clari.CheckState = CheckState.Unchecked
        chk7Clerical.CheckState = CheckState.Unchecked
        chk8Design.CheckState = CheckState.Unchecked
        chk9Release.CheckState = CheckState.Unchecked
        chk10Reject.CheckState = CheckState.Unchecked

        cboReviewBy.Text = ""
        txtReviews.Text = ""
        rdoAccepted.Checked = False
        rdoNotAccepted.Checked = False
        rdoWithMods.Checked = False
        rdoUseAsIs.Checked = False
        rdoNoAffect.Checked = False
        rdoModify.Checked = False
        rdoScrap.Checked = False
        rdoRTV.Checked = False

        txtProdHrs.Text = ""
        txtEnggHrs.Text = ""
        txtCost.Text = ""
        txtQuantity.Text = ""
        cboUnits.SelectedText = ""
        cboVerifiedBy.SelectedText = ""




        txtECRNo.Text = ""
        txtRev.Text = ""
        gridDwgs.Rows.Clear()
        gridDwgs.Refresh()

        sStr1 = Get_Personnel()

        Call Disable_All()

    End Sub

    Public Sub btnSearchECR_Click(sender As Object, e As EventArgs) Handles btnSearchECR.Click

        'Search for ECR No in the database.
        If txtECRNo.Text = "" Then
            sStr1 = MsgBox("Search ECR No from List?", MsgBoxStyle.Question + vbYesNo, "Search ECR")
            If sStr1 = vbYes Then
                Call frmSearch.ShowDialog()
                If bCancel = True Then
                    txtECRNo.Focus()
                    bCancel = False
                    Exit Sub
                End If

            Else
                txtECRNo.Focus()
                Exit Sub
            End If
        End If


        Call Enable_All()
        iInt1 = txtECRNo.Text
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select * FROM ecr_sheet1 WHERE ECRNo = '" & iInt1 & "'"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            If myReader.Read Then
                If Not IsDBNull(myReader.GetValue(2)) Then sJobNum = myReader.GetValue(2) Else sJobNum = ""
                If Not IsDBNull(myReader.GetValue(3)) Then sPersonnel = myReader.GetValue(3) Else sPersonnel = ""
                If Not IsDBNull(myReader.GetValue(4)) Then sIssueDate = myReader.GetValue(4) Else sIssueDate = ""
                If Not IsDBNull(myReader.GetValue(5)) Then sNeedDate = myReader.GetValue(5) Else sNeedDate = ""
                If Not IsDBNull(myReader.GetValue(6)) Then sRequest = myReader.GetValue(6) Else sRequest = ""
                If Not IsDBNull(myReader.GetValue(7)) Then sCategory = myReader.GetValue(7) Else sCategory = ""
                If Not IsDBNull(myReader.GetValue(8)) Then sCompDate = myReader.GetValue(8) Else sCompDate = ""

                txtJobNo.Text = sJobNum
                txtReq.Text = sPersonnel
                dtIssue.Text = sIssueDate
                dtNeedBy.Text = sNeedDate
                txtComments.Text = sRequest
                Call Set_Checkboxes()
            Else
                Call Disable_All()
                MsgBox("ECR No doesn't exist", vbCritical, "Does not exist")

                txtECRNo.Clear()
                'txtECR2.Clear()
                txtECRNo.Focus()
                End If
            Catch ex As Exception
                MsgBox("Cannot connect to the database-6" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
                Exit Sub
            End Try

            myReader.Close()
            myConn.Close()

            Call Search_Drawings()

            '-------------------Fill up Approve tab-----------------------'
            Try
                'Read ecrsheet2
                myCmd.CommandText = "SELECT * FROM ecr_sheet2 WHERE ECRNo ='" & Trim(txtECRNo.Text) & "'"
                'Open connection
                myConn.Open()
                myReader = myCmd.ExecuteReader
                If myReader.Read Then
                    If Not IsDBNull(myReader.GetString(1)) Then cboReviewBy.Text = myReader.GetString(1)
                    If Not IsDBNull(myReader.GetDateTime(2)) Then dtReview.Text = myReader.GetDateTime(2) Else dtReview.Text = ""
                    If Not IsDBNull(myReader.GetString(3)) Then iAccept = myReader.GetString(3) Else iAccept = 0
                    If Not IsDBNull(myReader.GetString(4)) Then txtReviews.Text = myReader.GetString(4) Else txtReviews.Text = ""
                    If Not IsDBNull(myReader.GetString(5)) Then cboVerifiedBy.Text = myReader.GetString(5)
                    If Not IsDBNull(myReader.GetDateTime(6)) Then dtVerfied.Text = myReader.GetDateTime(6) Else dtVerfied.Text = ""
                    If Not IsDBNull(myReader.GetDateTime(7)) Then dtImplementation.Text = myReader.GetDateTime(7) Else dtImplementation.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Cannot connect to the database-7" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
                Exit Sub
            End Try

            myReader.Close()
            myConn.Close()

            If iAccept = 0 Then rdoAccepted.Checked = False And
                rdoWithMods.Checked = False And
                rdoNotAccepted.Checked = False
            If iAccept = 1 Then rdoAccepted.Checked = True
            If iAccept = 2 Then rdoWithMods.Checked = True
            If iAccept = 3 Then rdoNotAccepted.Checked = True

            'Read dispo_parts
            Try
                myCmd.CommandText = "SELECT * FROM dispo_parts WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"
                myConn.Open()
                myReader = myCmd.ExecuteReader
                If myReader.Read Then
                    If Not IsDBNull(myReader.GetValue(1)) Then iDispo = myReader.GetValue(1) Else iDispo = 0
                    If Not IsDBNull(myReader.GetValue(2)) Then txtQuantity.Text = myReader.GetValue(2) Else txtQuantity.Text = ""
                    If Not IsDBNull(myReader.GetValue(3)) Then cboUnits.Text = myReader.GetValue(3) Else cboUnits.Text = ""
                    If Not IsDBNull(myReader.GetValue(4)) Then txtProdHrs.Text = myReader.GetValue(4) Else txtProdHrs.Text = ""
                    If Not IsDBNull(myReader.GetValue(5)) Then txtEnggHrs.Text = myReader.GetValue(5) Else txtEnggHrs.Text = ""
                    If Not IsDBNull(myReader.GetValue(6)) Then txtCost.Text = myReader.GetValue(6) Else txtCost.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Cannot connect to the database-8" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
                Exit Sub
            End Try
            myReader.Close()
            myConn.Close()

            If iDispo = 0 Then rdoUseAsIs.Checked = False And
                rdoNoAffect.Checked = False And
                rdoModify.Checked = False And
                rdoModify.Checked = False And
                rdoScrap.Checked = False And
                rdoRTV.Checked = False

            If iDispo = 1 Then rdoUseAsIs.Checked = True
            If iDispo = 2 Then rdoNoAffect.Checked = True
            If iDispo = 3 Then rdoModify.Checked = True
            If iDispo = 4 Then rdoScrap.Checked = True
            If iDispo = 5 Then rdoRTV.Checked = True

            'Read ecr_approval
            Try
                myCmd.CommandText = "SELECT * FROM ecr_approval WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"
                myConn.Open()
                myReader = myCmd.ExecuteReader
                If myReader.Read Then
                    If Not IsDBNull(myReader.GetString(1)) Then lblStatus.Text = myReader.GetString(1) Else lblStatus.Text = ""
                    If Not IsDBNull(myReader.GetString(2)) Then lblEngg.Text = myReader.GetString(2) Else lblEngg.Text = ""
                    If Not IsDBNull(myReader.GetDateTime(3)) Then lblDEngg.Text = "Date: " & myReader.GetDateTime(3) Else lblDEngg.Text = "Date: "
                    If Not IsDBNull(myReader.GetString(4)) Then lblPurch.Text = myReader.GetString(4) Else lblPurch.Text = ""
                    If Not IsDBNull(myReader.GetDateTime(5)) Then lblDPurch.Text = "Date: " & myReader.GetDateTime(5) Else lblDPurch.Text = "Date: "
                    If Not IsDBNull(myReader.GetString(6)) Then lblAcc.Text = myReader.GetString(6)
                    If Not IsDBNull(myReader.GetDateTime(7)) Then lblDAcc.Text = "Date: " & myReader.GetDateTime(7) Else lblDAcc.Text = "Date: "
                    If Not IsDBNull(myReader.GetString(8)) Then lblQuantity.Text = myReader.GetString(8) Else lblQuantity.Text = ""
                    If Not IsDBNull(myReader.GetDateTime(9)) Then lblDQuantity.Text = "Date: " & myReader.GetDateTime(9) Else lblQuantity.Text = "Date: "
                    If Not IsDBNull(myReader.GetString(10)) Then lblLogistics.Text = myReader.GetString(10) Else lblLogistics.Text = ""
                    If Not IsDBNull(myReader.GetDateTime(11)) Then lblDLogistics.Text = "Date: " & myReader.GetDateTime(11) Else lblDLogistics.Text = "Date: "
                    If Not IsDBNull(myReader.GetString(12)) Then lblProd.Text = myReader.GetString(12) Else lblProd.Text = ""
                    If Not IsDBNull(myReader.GetDateTime(13)) Then lblDProd.Text = "Date: " & myReader.GetDateTime(13) Else lblDProd.Text = "Date: "
                End If

                If myReader.GetDateTime(3) = "1900-01-01" Then lblDEngg.Text = ""
                If myReader.GetDateTime(5) = "1900-01-01" Then lblDPurch.Text = ""
                If myReader.GetDateTime(7) = "1900-01-01" Then lblDAcc.Text = ""
                If myReader.GetDateTime(9) = "1900-01-01" Then lblDQuantity.Text = ""
                If myReader.GetDateTime(11) = "1900-01-01" Then lblDLogistics.Text = ""
                If myReader.GetDateTime(13) = "1900-01-01" Then lblDProd.Text = ""
            Catch ex As Exception
                MsgBox("Cannot connect to the database-9" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
                Exit Sub
            End Try

            myReader.Close()
            myConn.Close()


    End Sub

    Private Sub txtECRNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtECRNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSearchECR.PerformClick()
        End If
    End Sub

    Private Sub btnAddDwg_Click(sender As Object, e As EventArgs) Handles btnAddDwg.Click

        Dim sDwg_temp As String
        sDwg_temp = txtDwgNo.Text

        If Trim(txtDwgNo.Text) = "" Then
            MsgBox("Drawing number is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Drawing number")
            Exit Sub
        End If


        If sDwg_temp.StartsWith("T0") Or sDwg_temp.StartsWith("T1") Or
            sDwg_temp.StartsWith("T2") Or sDwg_temp.StartsWith("T3") Or
            sDwg_temp.StartsWith("T4") Or sDwg_temp.StartsWith("T5") Or
            sDwg_temp.StartsWith("T6") Or sDwg_temp.StartsWith("T7") Or
             sDwg_temp.StartsWith("T8") Or sDwg_temp.StartsWith("T9") Then
        Else

            MsgBox("Drawing number should start from T0,T1,T2,T3,T4,T5,T6,T7,T8,T9", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Drawing number")
            Exit Sub
        End If


        sDwg_temp = sDwg_temp.Replace("T", "")


        If sDwg_temp.Length <> 6 Then
            MsgBox("Enter correct drawing number", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Drawing Number")
            txtDwgNo.Text = ""
            txtRev.Text = ""
            Exit Sub
        End If

        If IsNumeric(CInt(sDwg_temp)) Then
        Else
            MsgBox("Enter correct drawing number", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Drawing Number")
            txtDwgNo.Text = ""
            txtRev.Text = ""
            Exit Sub
        End If

        If Trim(txtECRNo.Text) = "" Then
            MsgBox("ECRNo is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No ECR Number")
            txtDwgNo.Text = ""
            txtRev.Text = ""
            Exit Sub
        Else
            iECRNo_new = Trim(txtECRNo.Text)
        End If

        If Trim(txtRev.Text) = "" Then
            MsgBox("Revision No is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Revision Number")
            txtRev.Text = ""
            Exit Sub
        End If

        'Check if drawing no exists in the database
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM t_numbers WHERE DwgNum='" & "T" & sDwg_temp & "'"

            'Open connection
            myConn.Open()
            myReader = myCmd.ExecuteReader
            If myReader.Read Then
                If Not IsDBNull(myReader.GetString(1)) Then sStr1 = myReader.GetString(1) Else sStr1 = ""
                txtTitle.Text = sStr1
            Else
                MsgBox("Drawing no does not exist in the database." & vbCrLf &
                   "Create new number in the Drawing Assignment Program", MsgBoxStyle.Critical +
                   MsgBoxStyle.OkOnly, "Missing Drawing No")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Cannot connect to the database-10" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try
        myReader.Close()
        myConn.Close()

        If Trim(txtTitle.Text) = "" Then
            MsgBox("Title is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Missing Title")
            Exit Sub
        End If
        'myReader.Close()
        'myConn.Close()

        'Create Command Object
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "IF NOT EXISTS (SELECT DwgNo FROM ecr_drawings WHERE ECRNo = '" &
                                Trim(iECRNo_new) & "' AND DwgNo='" & Trim(txtDwgNo.Text) & "')" &
                                "INSERT INTO ecr_drawings(ECRNo,DwgNo,Title,Rev) " &
                                "VALUES ('" & iECRNo_new & "','" & Trim(txtDwgNo.Text) &
                                "','" & Trim(txtTitle.Text) & "','" & Trim(txtRev.Text) & "') "

            'Open connection
            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()

            If iInt1 > 0 Then
                txtDwgNo.Text = ""
                txtTitle.Text = ""
                txtRev.Text = ""
                Call Search_Drawings()
                MsgBox("Entry Successful ! !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success ! !")
            Else
                MsgBox("Drawing already exists ! !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Existing Drawing ")
            End If

        Catch ex As Exception
            MsgBox("Cannot connect to the database-11" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        Finally
            myConn.Close()
        End Try
        myConn.Close()

    End Sub

    Private Sub btnClearDwg_Click(sender As Object, e As EventArgs) Handles btnClearDwg.Click
        txtDwgNo.Text = ""
        txtTitle.Text = ""
        txtRev.Text = ""
        dtIssue.Text = ""
        dtNeedBy.Text = ""
        txtJobNo.Text = ""
        txtReq.Text = ""

    End Sub

    Private Sub btnUpdateDwg_Click(sender As Object, e As EventArgs) Handles btnUpdateDwg.Click
        'Update existing drawing 
        If Trim(txtDwgNo.Text) = "" Then
            MsgBox("Drawing number is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Drawing number")
            Exit Sub
        End If

        If Trim(txtECRNo.Text) = "" Then
            MsgBox("ECRNo is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No ECR Number")
            Exit Sub
        End If

        If Trim(txtRev.Text) = "" Then
            MsgBox("Revision No is missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "No Revision Number")
            Exit Sub
        End If

        If Trim(txtComments.Text) = "" Then
            MsgBox("Comments are missing", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Missing comments")
            Exit Sub
        End If

        'Create Command Object
        Try
            myCmd = myConn.CreateCommand
        myCmd.CommandText = "IF EXISTS (SELECT DwgNo FROM ecr_drawings WHERE ECRNo='" &
                            Trim(txtECRNo.Text) & "' AND DwgNo='" & Trim(txtDwgNo.Text) & "')" &
                            "UPDATE ecr_drawings SET Title='" & Trim(txtTitle.Text) & "'," &
                            "Rev='" & Trim(txtRev.Text) & "' WHERE ECRNo='" & Trim(txtECRNo.Text) &
                            "' AND DwgNo='" & Trim(txtDwgNo.Text) & "'"

            'Open connection

            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()
            If iInt1 > 0 Then
                MsgBox("Entry Successful ! !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success ! !")
                Call Search_Drawings()
            Else
                MsgBox("Unsuccessful Update! !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Try Again! !")
            End If

        Catch ex As Exception
            MsgBox("Error while updating! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error! !")
            Exit Sub
        End Try
    End Sub

    Sub Search_Drawings()

        gridDwgs.Rows.Clear()
        gridDwgs.Refresh()
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM ecr_drawings WHERE ECRNo = '" & Trim(txtECRNo.Text) & "' ORDER BY DwgNo"
            'Open connection
            myConn.Open()
            myReader = myCmd.ExecuteReader

            Do While myReader.Read
                If IsDBNull(myReader.GetString(2)) Then sStr1 = "" Else sStr1 = myReader.GetString(2)
                If IsDBNull(myReader.GetString(3)) Then sStr2 = "" Else sStr2 = myReader.GetString(3)
                If IsDBNull(myReader.GetString(4)) Then sStr3 = "" Else sStr3 = myReader.GetString(4)
                'Update grid
                gridDwgs.Rows.Add(New String() {sStr1, sStr2, sStr3})
            Loop
        Catch ex As Exception
            MsgBox("Cannot connect to the database-12" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try

        myReader.Close()
        myConn.Close()

    End Sub

    Function Get_Personnel() As String
        'Get requestor name from username
        sStr1 = My.User.Name.ToString
        iInt1 = sStr1.IndexOf("\")
        txtReq.Text = Strings.Mid(sStr1, iInt1 + 2, sStr1.Length)

        Return Trim(txtReq.Text)
    End Function

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtIssue.Text = Now.Date
        dtNeedBy.Text = Now.Date
        dtReview.Text = Now.Date
        dtImplementation.Text = Now.Date
        dtVerfied.Text = Now.Date

        'Check personnel
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT FullName FROM personnel ORDER By FullName ASC"
            myConn.Open()
            myReader = myCmd.ExecuteReader()

            iInt1 = 0
            Do While myReader.Read
                'Update Name List
                If Not IsDBNull(myReader.GetString(0)) Then cboReviewBy.Items.Add(myReader.GetString(0))
                If Not IsDBNull(myReader.GetString(0)) Then cboVerifiedBy.Items.Add(myReader.GetString(0))
                iInt1 += 1
            Loop
        Catch ex As Exception
            MsgBox("Cannot connect to the database-13" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End Try
        myReader.Close()
        myConn.Close()

        'Check Units
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT Units FROM units"
            myConn.Open()
            myReader = myCmd.ExecuteReader()

            iInt1 = 0
            Do While myReader.Read
                'Update Units List
                If Not IsDBNull(myReader.GetString(0)) Then cboUnits.Items.Add(myReader.GetString(0))
                iInt1 += 1
            Loop
        Catch ex As Exception
            MsgBox("Cannot connect to the database-14" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        Finally
            myReader.Close()
            myConn.Close()
        End Try

        Call Disable_All()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check Job No
        If (String.IsNullOrEmpty(Trim(txtJobNo.Text)) Or txtJobNo.Text = " - ") Then
            sStr1 = MsgBox("Entry For Job no missing. Store Job No As '-'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Job No Missing")
            If sStr1 = "No" Then
                Exit Sub
            End If
        End If

        'Check Status
        If String.IsNullOrEmpty(Trim(lblStatus.Text)) Then
            lblStatus.Text = "P"
            sStatus = lblStatus.Text
        ElseIf (Trim(lblStatus.Text) <> "R" Or Trim(lblStatus.Text) <> "A") Then
            sStatus = "P"
        Else
            sStatus = lblStatus.Text
        End If

        sJobNum = Trim(txtJobNo.Text)
        sPersonnel = Trim(txtReq.Text)

        'Initialize dates
        If String.IsNullOrEmpty(dtIssue.Text) Or dtIssue.Text = "01/01/1900" Then
            sIssueDate = Now.ToShortDateString
        Else
            sIssueDate = Trim(dtIssue.Text)
        End If

        If String.IsNullOrEmpty(dtNeedBy.Text) Or dtNeedBy.Text = "01/01/1900" Then
            sNeedDate = Now.ToShortDateString
        Else
            sNeedDate = Trim(dtIssue.Text)
        End If

        sCompDate = ""
        sComments = Trim(txtComments.Text)
        sRequest = "-"

        'Check checkboxes
        Call Get_Checkboxes()
        sCategory = CStr(iCheckBoxValue)

        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "UPDATE ecr_sheet1 SET Status='" & sStatus & "', JobNo='" & sJobNum & "', Requestor='" & sPersonnel &
                            "', IssueDate='" & sIssueDate & "', NeedByDate='" & sNeedDate & "', Request='" & sComments &
                            "', Cat='" & sCategory & "', CompDate='" & sCompDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

            'Open connection
            myConn.Open()
            myCmd.ExecuteNonQuery()


            MsgBox("ECR Data saved to database", MsgBoxStyle.Information, "Success! !")
        Catch ex As Exception
            MsgBox("Error while saving into the datbase-15" & ex.ToString, MsgBoxStyle.Critical, "Error")
            Exit Sub
        Finally
            myConn.Close()
        End Try

    End Sub

    Private Sub gridDwgs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDwgs.CellClick
        'Get the details onto the textboxes
        Dim _sDwgNo As String
        Dim _sTitle As String
        Dim _sRev As String

        _sDwgNo = gridDwgs.Rows(gridDwgs.CurrentCell.RowIndex).Cells(0).Value
        _sTitle = gridDwgs.Rows(gridDwgs.CurrentCell.RowIndex).Cells(1).Value
        _sRev = gridDwgs.Rows(gridDwgs.CurrentCell.RowIndex).Cells(2).Value

        txtDwgNo.Text = _sDwgNo
        txtTitle.Text = _sTitle
        txtRev.Text = _sRev
    End Sub

    Sub Get_Checkboxes()

        iInt1 = 0
        If chk1DwgErr.Checked Then iInt1 = iInt1 + 2 ^ 0
        If chk2Cost.Checked Then iInt1 = iInt1 + 2 ^ 1
        If chk3MfgImp.Checked Then iInt1 = iInt1 + 2 ^ 2
        If chk4Change.Checked Then iInt1 = iInt1 + 2 ^ 3
        If chk5Quality.Checked Then iInt1 = iInt1 + 2 ^ 4
        If chk6Clari.Checked Then iInt1 = iInt1 + 2 ^ 5
        If chk7Clerical.Checked Then iInt1 = iInt1 + 2 ^ 6
        If chk8Design.Checked Then iInt1 = iInt1 + 2 ^ 7
        If chk9Release.Checked Then iInt1 = iInt1 + 2 ^ 8
        If chk10Reject.Checked Then iInt1 = iInt1 + 2 ^ 9
        iCheckBoxValue = iInt1

    End Sub

    Sub Set_Checkboxes()

        iInt1 = CInt(sCategory)
        If (iInt1 And 2 ^ 0) Then chk1DwgErr.CheckState = CheckState.Checked Else chk1DwgErr.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 1) Then chk2Cost.CheckState = CheckState.Checked Else chk2Cost.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 2) Then chk3MfgImp.CheckState = CheckState.Checked Else chk3MfgImp.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 3) Then chk4Change.CheckState = CheckState.Checked Else chk4Change.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 4) Then chk5Quality.CheckState = CheckState.Checked Else chk5Quality.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 5) Then chk6Clari.CheckState = CheckState.Checked Else chk6Clari.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 6) Then chk7Clerical.CheckState = CheckState.Checked Else chk7Clerical.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 7) Then chk8Design.CheckState = CheckState.Checked Else chk8Design.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 8) Then chk9Release.CheckState = CheckState.Checked Else chk9Release.CheckState = CheckState.Unchecked
        If (iInt1 And 2 ^ 9) Then chk10Reject.CheckState = CheckState.Checked Else chk10Reject.CheckState = CheckState.Unchecked
        iInt1 = 0

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim oApp As Object
        Dim oMsg As Object
        Dim sMsgBody As String
        Dim sSub As String

        sSub = Trim(txtECRNo.Text)

        sMsgBody = "Please process subject ECR for review and action. Reviewer to perform the following:" & vbCr & vbCr &
                "1) Open the ECR Program and select 'Approval' Tab on the top left corner" & vbCr &
                "2) Complete the Reviewer section" & vbCr &
                "3) Save the update and submit the review to the ECR approval group." & vbCr & vbCr &
                "Thanks," & vbCr & vbCr & Trim(txtReq.Text)
        Try
            sSub = Trim(txtECRNo.Text)
            oApp = CreateObject("Outlook.Application")
            oMsg = oApp.CreateItem(0)
            oMsg.To = "Eng-Admin@thermaltechnology.com"
            oMsg.Subject = "ECR: " & sSub & " Requires review"

            oMsg.Body = sMsgBody
            oMsg.Display(False)
        Catch ex As Exception
            MsgBox("Error launching Outlook" & ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error ")
            Exit Sub
        End Try

    End Sub

    '*************************************************TAB 2 APPROVE*********************************************************

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        btnClearECR_Click(sender, e)
    End Sub

    Private Sub btnECR_Click(sender As Object, e As EventArgs)
        'Call btnSearchECR.PerformClick()
        'If txtECR2.Text = "" Then
        '    MsgBox("Enter ECR No", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error ")
        '    Call Disable_All()
        '    Exit Sub
        'Else
        '    txtECRNo.Text = txtECR2.Text
        '    btnSearchECR_Click(sender, e)
        '    Call Enable_All()


        'End If

    End Sub

    Private Sub txtECR2_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSearchECR.PerformClick()
        End If
    End Sub

    Public Sub btnClrRev_Click(sender As Object, e As EventArgs) Handles btnClrRev.Click
        'Clear reviewing section
        cboReviewBy.Text = ""
        cboReviewBy.SelectedIndex = -1
        cboUnits.SelectedIndex = -1
        dtReview.Text = ""
        rdoAccepted.Checked = False
        rdoWithMods.Checked = False
        rdoNotAccepted.Checked = False

        rdoUseAsIs.Checked = False
        rdoNoAffect.Checked = False
        rdoModify.Checked = False
        rdoScrap.Checked = False
        rdoRTV.Checked = False

        txtProdHrs.Text = ""
        txtEnggHrs.Text = ""
        txtCost.Text = ""
        txtQuantity.Text = ""
        cboUnits.Text = ""
        txtReviews.Text = ""

    End Sub

    Private Sub btnApproveSubmit_Click(sender As Object, e As EventArgs) Handles btnApproveSubmit.Click
        Dim Outl As Object
        Dim omsg As Object
        Dim msgBody, oSubj As String

        'Submit only when P changes to A
        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select Status FROM ecr_approval WHERE ECRNo = '" & Trim(txtECRNo.Text) & "'"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            If myReader.Read Then
                'Update Units List
                If Not IsDBNull(myReader.GetString(0)) Then sStr1 = myReader.GetString(0)

            End If

        Catch ex As Exception
            MsgBox("Cannot connect to the database-16" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        Finally
            myReader.Close()
            myConn.Close()

        End Try

        If sStr1 <> "A" Then
            MsgBox("Please save before submitting", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Exit Sub
        End If


        REM  Ensure that Imports System.Diagnostics.Process is called in the imports list.

        msgBody = "Please process subject ECR for approval.  Approver to perform the following:" & vbCr & vbCr
        msgBody = msgBody & "1) Open the Drawing Number Program and select the ECR form from the Modules menu." & vbCr
        msgBody = msgBody & "2) Load the subject ECR number and go to the Approvals section of sheet 2 of the module." & vbCr
        msgBody = msgBody & "3) Click the underlined Department name for approval; The ECR will be electronically signed by your login." & vbCr
        msgBody = msgBody & "4) Save the approval on Sheet 1 then email notify the Eng. Admin of your approval." & vbCr
        msgBody = msgBody & "5) Last approver notify QA rep for Verification sign-off." & vbCr

        oSubj = txtECRNo.Text

        Try

            Outl = CreateObject("Outlook.Application")
            omsg = Outl.createItem(0)
            omsg.To = "eccag@thermaltechnology.com"
            omsg.cc = "Eng-Admin@thermaltechnology.com"
            omsg.Subject = "ECR " & oSubj & " Requires Approval"

            omsg.body = msgBody
            omsg.Display(False)                         ' Must set to false otherwise you get 2 messages.

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Problem launching Outlook" & ex.Message, "Open Outlook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try


    End Sub

    Private Sub btnClrParts_Click(sender As Object, e As EventArgs)
        dtImplementation.ResetText()
    End Sub

    Private Sub btnClrVer_Click(sender As Object, e As EventArgs) Handles btnClrVer.Click
        cboVerifiedBy.Text = ""
        dtVerfied.Text = ""

    End Sub

    Private Sub btnClrEngg_Click(sender As Object, e As EventArgs) Handles btnClrEngg.Click
        lblEngg.Text = ""
        lblDEngg.Text = "Date: "
    End Sub

    Private Sub btnClrPurch_Click(sender As Object, e As EventArgs) Handles btnClrPurch.Click
        lblPurch.Text = ""
        lblDPurch.Text = "Date: "
    End Sub

    Private Sub btnClrAcc_Click(sender As Object, e As EventArgs) Handles btnClrAcc.Click
        lblAcc.Text = ""
        lblDAcc.Text = "Date: "
    End Sub

    Private Sub btnClrQuantity_Click(sender As Object, e As EventArgs) Handles btnClrQuality.Click
        lblQuantity.Text = ""
        lblDQuantity.Text = "Date: "
    End Sub

    Private Sub btnClrLogistics_Click(sender As Object, e As EventArgs) Handles btnClrLogistics.Click
        lblLogistics.Text = ""
        lblDLogistics.Text = "Date: "
    End Sub

    Private Sub btnClrProd_Click(sender As Object, e As EventArgs) Handles btnClrProd.Click
        lblProd.Text = ""
        lblDProd.Text = "Date: "
    End Sub

    Private Sub lblClickEngg_Click(sender As Object, e As EventArgs) Handles lblClickEngg.Click
        lblEngg.Text = Get_Personnel()
        lblDEngg.Text = "Date: " & Now.Date
    End Sub

    Public Sub Approve_Tab_Reset()
        'If txtECR2.Text = "" Then
        '    Call Disable_All()
        'End If
    End Sub

    Sub Disable_All()

        txtDwgNo.Text = ""
        txtRev.Text = ""
        txtTitle.Text = ""
        txtJobNo.Text = ""
        txtReq.Text = ""

        txtDwgNo.Enabled = False
        txtJobNo.Enabled = False
        txtRev.Enabled = False
        txtReq.Enabled = False
        txtTitle.Enabled = False
        txtReq.Enabled = False
        dtIssue.Enabled = False
        dtNeedBy.Enabled = False
        btnAddDwg.Enabled = False
        btnClearDwg.Enabled = False
        btnUpdateDwg.Enabled = False
        btnDeleteDwg.Enabled = False

        chk10Reject.Enabled = False
        chk1DwgErr.Enabled = False
        chk2Cost.Enabled = False
        chk3MfgImp.Enabled = False
        chk4Change.Enabled = False
        chk5Quality.Enabled = False
        chk6Clari.Enabled = False
        chk7Clerical.Enabled = False
        chk8Design.Enabled = False
        chk9Release.Enabled = False

        txtComments.Enabled = False
        btnSave.Enabled = False
        btnSubmit.Enabled = False




        btnClrRev.PerformClick()
        cboReviewBy.Enabled = False
        dtReview.Enabled = False
        rdoAccepted.Enabled = False
        rdoWithMods.Enabled = False
        rdoNotAccepted.Enabled = False

        rdoUseAsIs.Enabled = False
        rdoNoAffect.Enabled = False
        rdoModify.Enabled = False
        rdoScrap.Enabled = False
        rdoRTV.Enabled = False

        txtProdHrs.Enabled = False
        txtEnggHrs.Enabled = False
        txtCost.Enabled = False
        txtQuantity.Enabled = False
        cboUnits.Enabled = False
        txtReviews.Enabled = False

        lblEngg.Enabled = False
        lblPurch.Enabled = False
        lblAcc.Enabled = False
        lblQuantity.Enabled = False
        lblProd.Enabled = False
        lblLogistics.Enabled = False

        dtImplementation.Enabled = False
        dtVerfied.Enabled = False
        cboVerifiedBy.Enabled = False

        btnClrEngg.Enabled = False
        btnClrAcc.Enabled = False
        btnClrPurch.Enabled = False
        btnClrQuality.Enabled = False
        btnClrLogistics.Enabled = False
        btnClrProd.Enabled = False

        btnSaveApp.Enabled = False
        btnApproveSubmit.Enabled = False

        lblClickEngg.Enabled = False
        lblClickPurch.Enabled = False
        lblClickAcc.Enabled = False
        lblClickProd.Enabled = False
        lblClickLogistics.Enabled = False
        lblClickQuality.Enabled = False
        gridDwgs.Enabled = False

    End Sub

    Sub Enable_All()

        txtDwgNo.Text = ""
        txtRev.Text = ""
        txtTitle.Text = ""
        txtJobNo.Text = ""
        txtReq.Text = ""

        txtDwgNo.Enabled = True
        txtJobNo.Enabled = True
        txtRev.Enabled = True
        txtReq.Enabled = True
        txtTitle.Enabled = True
        txtReq.Enabled = True
        dtIssue.Enabled = True
        dtNeedBy.Enabled = True
        btnAddDwg.Enabled = True
        btnClearDwg.Enabled = True
        btnUpdateDwg.Enabled = True
        btnDeleteDwg.Enabled = True
        gridDwgs.Enabled = True

        chk10Reject.Enabled = True
        chk1DwgErr.Enabled = True
        chk2Cost.Enabled = True
        chk3MfgImp.Enabled = True
        chk4Change.Enabled = True
        chk5Quality.Enabled = True
        chk6Clari.Enabled = True
        chk7Clerical.Enabled = True
        chk8Design.Enabled = True
        chk9Release.Enabled = True

        txtComments.Enabled = True
        btnSave.Enabled = True
        btnSubmit.Enabled = True

        cboReviewBy.Enabled = True
        dtReview.Enabled = True
        rdoAccepted.Enabled = True
        rdoWithMods.Enabled = True
        rdoNotAccepted.Enabled = True

        rdoUseAsIs.Enabled = True
        rdoNoAffect.Enabled = True
        rdoModify.Enabled = True
        rdoScrap.Enabled = True
        rdoRTV.Enabled = True

        txtProdHrs.Enabled = True
        txtEnggHrs.Enabled = True
        txtCost.Enabled = True
        txtQuantity.Enabled = True
        cboUnits.Enabled = True
        txtReviews.Enabled = True

        lblEngg.Enabled = True
        lblPurch.Enabled = True
        lblAcc.Enabled = True
        lblQuantity.Enabled = True
        lblProd.Enabled = True
        lblLogistics.Enabled = True

        dtImplementation.Enabled = True
        dtVerfied.Enabled = True
        cboVerifiedBy.Enabled = True

        btnClrEngg.Enabled = True
        btnClrAcc.Enabled = True
        btnClrPurch.Enabled = True
        btnClrQuality.Enabled = True
        btnClrLogistics.Enabled = True
        btnClrProd.Enabled = True

        btnSaveApp.Enabled = True
        btnApproveSubmit.Enabled = True

        lblClickEngg.Enabled = True
        lblClickPurch.Enabled = True
        lblClickAcc.Enabled = True
        lblClickProd.Enabled = True
        lblClickLogistics.Enabled = True
        lblClickQuality.Enabled = True


    End Sub

    Private Sub lblClickEngg_MouseHover(sender As Object, e As EventArgs) Handles lblClickEngg.MouseHover
        Cursor = Cursors.Hand
        lblClickEngg.ForeColor = Color.Blue
    End Sub

    Private Sub lblClickEngg_MouseLeave(sender As Object, e As EventArgs) Handles lblClickEngg.MouseLeave
        Cursor = Cursors.Default
        lblClickEngg.ForeColor = Color.Black
    End Sub

    Private Sub lblClickPurch_MouseHover(sender As Object, e As EventArgs) Handles lblClickPurch.MouseHover
        Cursor = Cursors.Hand
        lblClickPurch.ForeColor = Color.Blue
    End Sub

    Private Sub lblClickPurch_MouseLeave(sender As Object, e As EventArgs) Handles lblClickPurch.MouseLeave
        Cursor = Cursors.Default
        lblClickPurch.ForeColor = Color.Black
    End Sub
    Private Sub lblClickAcc_MouseHover(sender As Object, e As EventArgs) Handles lblClickAcc.MouseHover
        Cursor = Cursors.Hand
        lblClickAcc.ForeColor = Color.Blue
    End Sub

    Private Sub lblClickAcc_MouseLeave(sender As Object, e As EventArgs) Handles lblClickAcc.MouseLeave
        Cursor = Cursors.Default
        lblClickAcc.ForeColor = Color.Black
    End Sub

    Private Sub lblClickQuality_MouseHover(sender As Object, e As EventArgs) Handles lblClickQuality.MouseHover
        Cursor = Cursors.Hand
        lblClickQuality.ForeColor = Color.Blue
    End Sub

    Private Sub lblClickQuality_MouseLeave(sender As Object, e As EventArgs) Handles lblClickQuality.MouseLeave
        Cursor = Cursors.Default
        lblClickQuality.ForeColor = Color.Black
    End Sub

    Private Sub lblClickLogistics_MouseHover(sender As Object, e As EventArgs) Handles lblClickLogistics.MouseHover
        Cursor = Cursors.Hand
        lblClickLogistics.ForeColor = Color.Blue
    End Sub

    Private Sub lblClickLogistics_MouseLeave(sender As Object, e As EventArgs) Handles lblClickLogistics.MouseLeave
        Cursor = Cursors.Default
        lblClickLogistics.ForeColor = Color.Black
    End Sub

    Private Sub lblClickProd_MouseHover(sender As Object, e As EventArgs) Handles lblClickProd.MouseHover
        Cursor = Cursors.Hand
        lblClickProd.ForeColor = Color.Blue
    End Sub

    Private Sub lblClickProd_MouseLeave(sender As Object, e As EventArgs) Handles lblClickProd.MouseLeave
        Cursor = Cursors.Default
        lblClickProd.ForeColor = Color.Black
    End Sub

    Private Sub lblClickPurch_Click(sender As Object, e As EventArgs) Handles lblClickPurch.Click
        lblPurch.Text = Get_Personnel()
        lblDPurch.Text = "Date: " & Now.Date
    End Sub

    Private Sub lblClickAcc_Click(sender As Object, e As EventArgs) Handles lblClickAcc.Click
        lblAcc.Text = Get_Personnel()
        lblDAcc.Text = "Date: " & Now.Date
    End Sub

    Private Sub lblClickQuality_Click(sender As Object, e As EventArgs) Handles lblClickQuality.Click
        lblQuantity.Text = Get_Personnel()
        lblDQuantity.Text = "Date: " & Now.Date
    End Sub

    Private Sub lblClickLogistics_Click(sender As Object, e As EventArgs) Handles lblClickLogistics.Click
        lblLogistics.Text = Get_Personnel()
        lblDLogistics.Text = "Date: " & Now.Date
    End Sub

    Private Sub lblClickProd_Click(sender As Object, e As EventArgs) Handles lblClickProd.Click
        lblProd.Text = Get_Personnel()
        lblDProd.Text = "Date: " & Now.Date
    End Sub

    Private Sub btnDeleteDwg_Click(sender As Object, e As EventArgs) Handles btnDeleteDwg.Click
        Dim sDwgNoDel As String
        'Check if dwg has been selected
        If Trim(txtDwgNo.Text) = "" Then
            MsgBox("No Drawing No selected", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        sDwgNoDel = Trim(txtDwgNo.Text)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "IF EXISTS (SELECT DwgNo FROM ecr_drawings WHERE ECRNo = '" &
                            Trim(txtECRNo.Text) & "' AND DwgNo='" & Trim(txtDwgNo.Text) & "')" &
                            "DELETE FROM ecr_drawings WHERE ECRNo='" & Trim(txtECRNo.Text) &
                            "' AND DwgNo='" & sDwgNoDel & "'"

        'Open connection
        Try
            myConn.Open()
            iInt1 = myCmd.ExecuteNonQuery()
            myConn.Close()
            If iInt1 > 0 Then
                txtDwgNo.Text = ""
                txtTitle.Text = ""
                txtRev.Text = ""

                MsgBox("Delete Successful ! !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success ! !")
            Else
                MsgBox("Drawing does not exist ! !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Drawing Non-existing")
            End If
        Catch ex As Exception
            MsgBox("Error while deleting ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
            Exit Sub
        Finally
            myConn.Close()
        End Try

        Call Search_Drawings()

    End Sub

    Private Sub btnChkBoxClear_Click(sender As Object, e As EventArgs) Handles btnChkBoxClear.Click
        chk1DwgErr.CheckState = CheckState.Unchecked
        chk2Cost.CheckState = CheckState.Unchecked
        chk3MfgImp.CheckState = CheckState.Unchecked
        chk4Change.CheckState = CheckState.Unchecked
        chk5Quality.CheckState = CheckState.Unchecked
        chk6Clari.CheckState = CheckState.Unchecked
        chk7Clerical.CheckState = CheckState.Unchecked
        chk8Design.CheckState = CheckState.Unchecked
        chk9Release.CheckState = CheckState.Unchecked
        chk10Reject.CheckState = CheckState.Unchecked

    End Sub

    Private Sub btnClrRequest_Click(sender As Object, e As EventArgs) Handles btnClrRequest.Click
        txtComments.Text = ""
    End Sub

    Private Sub btnSaveApp_Click(sender As Object, e As EventArgs) Handles btnSaveApp.Click
        Dim sEnggDate As String
        Dim sPurchDate As String
        Dim sAccDate As String
        Dim sLogDate As String
        Dim sQDate As String
        Dim sProdDate As String

        If cboReviewBy.Text = "" Then
            MsgBox("Name of Reviewer not selected", MsgBoxStyle.Critical, "No Reviewer")
            Exit Sub
        End If

        If rdoAccepted.Checked = False And rdoWithMods.Checked = False And rdoNotAccepted.Checked = False Then
            MsgBox("Review not selected", MsgBoxStyle.Critical, "No Review")
            Exit Sub
        End If

        If rdoAccepted.Checked = True Then iAccept = 1
        If rdoWithMods.Checked = True Then iAccept = 2
        If rdoNotAccepted.Checked = True Then iAccept = 3

        If rdoUseAsIs.Checked = False AndAlso rdoNoAffect.Checked = False AndAlso
        rdoModify.Checked = False AndAlso rdoScrap.Checked = False AndAlso
        rdoRTV.Checked = False Then
            MsgBox("Disposition of parts not selected", MsgBoxStyle.Critical, "Disposition")
            Exit Sub
        End If

        If rdoUseAsIs.Checked = True Then iDispo = 1
        If rdoNoAffect.Checked = True Then iDispo = 2
        If rdoModify.Checked = True Then iDispo = 3
        If rdoScrap.Checked = True Then iDispo = 4
        If rdoRTV.Checked = True Then iDispo = 5

        If txtQuantity.Text <> "" And cboUnits.SelectedItem = Nothing Then
            MsgBox("Units for quantity not selected", MsgBoxStyle.Critical, "No Units")
            Exit Sub
        End If

        If cboUnits.SelectedItem <> Nothing And txtQuantity.Text = "" Then
            cboUnits.SelectedItem = Nothing
        End If

        If txtReviews.Text = "" Then
            MsgBox("Enter Reviewer Comments", MsgBoxStyle.Critical, "No Review")
            Exit Sub
        End If

        '------------------------------------------------------------------------------------'
        'Update approval table
        'Check for any approvals
        If String.IsNullOrEmpty(lblDEngg.Text) AndAlso String.IsNullOrEmpty(lblDPurch.Text) AndAlso
            String.IsNullOrEmpty(lblDAcc.Text) AndAlso String.IsNullOrEmpty(lblDQuantity.Text) AndAlso
            String.IsNullOrEmpty(lblDLogistics.Text) AndAlso String.IsNullOrEmpty(lblDProd.Text) Then
            MsgBox("Click respectve department for approval date", MsgBoxStyle.Critical, "Click Approval")
            Exit Sub

        End If

        If Not String.IsNullOrEmpty(lblDEngg.Text) Then sEnggDate = lblDEngg.Text.Remove(0, 5)
        If Not String.IsNullOrEmpty(lblDPurch.Text) Then sPurchDate = lblDPurch.Text.Remove(0, 5)
        If Not String.IsNullOrEmpty(lblDAcc.Text) Then sAccDate = lblDAcc.Text.Remove(0, 5)
        If Not String.IsNullOrEmpty(lblDQuantity.Text) Then sQDate = lblDQuantity.Text.Remove(0, 5)
        If Not String.IsNullOrEmpty(lblDLogistics.Text) Then sLogDate = lblDLogistics.Text.Remove(0, 5)
        If Not String.IsNullOrEmpty(lblDProd.Text) Then sProdDate = lblDProd.Text.Remove(0, 5)



        If bEnggChanged = True Then
            Try
                myCmd.CommandText = "UPDATE ecr_approval SET Status='A', EnggRep='" & Trim(lblEngg.Text) &
                                "', EnggDate='" & sEnggDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

                myConn.Open()
                myCmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
                Exit Sub
            Finally
                myConn.Close()
            End Try
        End If

        If bPurchChanged = True Then
            Try
                myCmd.CommandText = "UPDATE ecr_approval SET Status='A', PurchRep='" & Trim(lblPurch.Text) &
                               "', PurchDate='" & sPurchDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

                myConn.Open()
                myCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
                Exit Sub
            Finally
                myConn.Close()
            End Try
        End If

        If bAccChanged = True Then
            Try
                myCmd.CommandText = "UPDATE ecr_approval SET Status='A', AccRep='" & Trim(lblAcc.Text) &
                                "', AccDate='" & sAccDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

                myConn.Open()
                myCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
                Exit Sub
            Finally
                myConn.Close()
            End Try
        End If

        If bQuantityChanged = True Then
            Try
                myCmd.CommandText = "UPDATE ecr_approval SET Status='A', QARep='" & Trim(lblQuantity.Text) &
                                "', QADate='" & sQDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

                myConn.Open()
                myCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
                Exit Sub
            Finally
                myConn.Close()
            End Try
        End If

        If bLogisticsChanged = True Then
            Try
                myCmd.CommandText = "UPDATE ecr_approval SET Status='A', LogRep='" & Trim(lblLogistics.Text) &
                                "', LogDate='" & sLogDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

                myConn.Open()
                myCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
                Exit Sub
            Finally
                myConn.Close()
            End Try
        End If

        If bProdChanged = True Then
            Try
                myCmd.CommandText = "UPDATE ecr_approval SET Status='A', ProdRep='" & Trim(lblProd.Text) &
                                "', ProdDate='" & sProdDate & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"

                myConn.Open()
                myCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
                Exit Sub
            Finally
                myConn.Close()
            End Try
        End If

        bEnggChanged = False
        bPurchChanged = False
        bAccChanged = False
        bQuantityChanged = False
        bLogisticsChanged = False
        bProdChanged = False

        Try
            myCmd.CommandText = "UPDATE ecr_sheet2 SET Reviewer='" & cboReviewBy.Text & "', ReviewDate='" & dtReview.Text &
                            "', Accept='" & iAccept & "', Notes ='" & Trim(txtReviews.Text) & "', VerBy ='" &
                            Trim(cboVerifiedBy.Text) & "', VerDate='" & dtVerfied.Text &
                            "', PartsDate='" & dtImplementation.Text & "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"
            myConn.Open()
            myCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
            Exit Sub
        Finally
            myConn.Close()
        End Try

        Try
            myCmd.CommandText = "UPDATE dispo_parts SET DispoCode='" & iDispo & "', QuantityAffected='" & Trim(txtQuantity.Text) &
                            "', Units='" & cboUnits.Text & "', ProdHrs='" & Trim(txtProdHrs.Text) &
                            "', EnggHrs='" & Trim(txtEnggHrs.Text) & "', CostofMat='" & Trim(txtCost.Text) &
                            "' WHERE ECRNo='" & Trim(txtECRNo.Text) & "'"
            myConn.Open()
            myCmd.ExecuteNonQuery()

            MsgBox("ECR Data saved to database", MsgBoxStyle.Information, "Success! !")
        Catch ex As Exception
            MsgBox("Error while updating ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
            Exit Sub
        Finally
            myConn.Close()
        End Try

    End Sub

    Private Sub lblEngg_TextChanged(sender As Object, e As EventArgs) Handles lblEngg.TextChanged
        bEnggChanged = True
    End Sub

    Private Sub lblPurch_TextChanged(sender As Object, e As EventArgs) Handles lblPurch.TextChanged
        bPurchChanged = True
    End Sub

    Private Sub lblAcc_TextChanged(sender As Object, e As EventArgs) Handles lblAcc.TextChanged
        bAccChanged = True
    End Sub

    Private Sub lblQuantity_TextChanged(sender As Object, e As EventArgs) Handles lblQuantity.TextChanged
        bQuantityChanged = True
    End Sub

    Private Sub lblLogistics_TextChanged(sender As Object, e As EventArgs) Handles lblLogistics.TextChanged
        bLogisticsChanged = True
    End Sub

    Private Sub lblProd_TextChanged(sender As Object, e As EventArgs) Handles lblProd.TextChanged
        bProdChanged = True
    End Sub

    Private Sub txtJobNo_MouseClick(sender As Object, e As MouseEventArgs) Handles txtJobNo.MouseClick
        txtJobNo.SelectionStart = 0
    End Sub

End Class