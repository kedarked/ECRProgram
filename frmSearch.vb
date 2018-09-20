Public Class frmSearch

    Private Sub frmSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        dtFrom.Format = DateTimePickerFormat.Custom
        dtFrom.CustomFormat = "MM/dd/yyyy"
        dtFrom.Value = Now.Date
        'dtFrom.Text = Now.Date

        dtTo.Format = DateTimePickerFormat.Custom
        dtTo.CustomFormat = "MM/dd/yyyy"
        dtTo.Value = Now.Date
        'dtTo.Text = Now.Date

        'lstECRNos.Items.Clear()
        gridDwgs2.Rows.Clear()




    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bCancel = True
        Me.Close()
    End Sub

    Private Sub btnSelectDates_Click(sender As Object, e As EventArgs) Handles btnSelectDates.Click

        'lstECRNos.Items.Clear()
        gridDwgs2.Rows.Clear()

        'Check the range of dates
        If dtFrom.Value.Date > dtTo.Value.Date Then
            MsgBox("From date should be earlier than To date", MsgBoxStyle.Information, "Correct range")
            Exit Sub
        End If

        GetRadioButtons()

        'iRadioButtonValue


        Try
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select * FROM ecr_sheet1 WHERE IssueDate BETWEEN '" & dtFrom.Value.Date &
                                "' AND '" & dtTo.Value.Date & "' AND (Cat & " & iRadioButtonValue & ")=" &
                                iRadioButtonValue & " ORDER BY ECRNo DESC"

            myConn.Open()
            myReader = myCmd.ExecuteReader()
            iInt1 = 0
            Do While myReader.Read
                If Not IsDBNull(myReader.GetValue(0)) Then sStr1 = myReader.GetValue(0)     'ECR
                If Not IsDBNull(myReader.GetValue(1)) Then sStr2 = myReader.GetValue(1)     'Status
                If Not IsDBNull(myReader.GetValue(2)) Then sStr3 = myReader.GetValue(2)     'Job No
                If Not IsDBNull(myReader.GetValue(3)) Then sStr4 = myReader.GetValue(3)     'Requestor
                If Not IsDBNull(myReader.GetValue(6)) Then sStr5 = myReader.GetValue(6)     'Request
                If Not IsDBNull(myReader.GetValue(7)) Then sStr6 = myReader.GetValue(7)     'Cat Code
                'lstECRNos.Items.Add(sStr1)
                iInt1 = CInt(sStr6)
                iInt3 = iInt1 & iRadioButtonValue
                gridDwgs2.Rows.Add(New String() {sStr1, sStr2, sStr3, sStr5, sStr4, sStr6})
                iInt1 += 1
            Loop
        Catch ex As Exception
            MsgBox("Error while displaying ! !" & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error ! !")
            Exit Sub
        Finally
            myReader.Close()
            myConn.Close()
        End Try


        If iInt1 < 1 Then
            MsgBox("No ECR Numbers found", MsgBoxStyle.Information, "No ECR found")
            Exit Sub
        End If


    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        sStr1 = gridDwgs2.Rows(gridDwgs2.CurrentCell.RowIndex).Cells(0).Value       'ECRNo
        sStr2 = gridDwgs2.Rows(gridDwgs2.CurrentCell.RowIndex).Cells(1).Value       'Status
        sStr3 = gridDwgs2.Rows(gridDwgs2.CurrentCell.RowIndex).Cells(2).Value       'Job No
        sStr4 = gridDwgs2.Rows(gridDwgs2.CurrentCell.RowIndex).Cells(3).Value       'Request
        sStr5 = gridDwgs2.Rows(gridDwgs2.CurrentCell.RowIndex).Cells(4).Value       'Requestor

        frmMain.txtECRNo.Text = sStr1
        frmMain.lblStatus.Text = sStr2



        Me.Close()
    End Sub

    Private Sub lstECRNos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstECRNos_DoubleClick(sender As Object, e As EventArgs)
        btnSelect.PerformClick()
    End Sub

    Sub GetRadioButtons()
        iInt2 = 0
        If rdo1DrawingError.Checked = True Then iInt2 = +2 ^ 0
        If rdo2CostRed.Checked = True Then iInt2 = +2 ^ 1
        If rdo3MfgAssyImp.Checked = True Then iInt2 = +2 ^ 2
        If rdo4ChangeNote.Checked = True Then iInt2 = +2 ^ 3
        If rdo5Quality.Checked = True Then iInt2 = +2 ^ 4
        If rdo6DwgClari.Checked = True Then iInt2 = +2 ^ 5
        If rdo7Clerical.Checked = True Then iInt2 = +2 ^ 6
        If rdo8DesReq.Checked = True Then iInt2 = +2 ^ 7
        If rdo9NewRelease.Checked = True Then iInt2 = +2 ^ 8
        If rdo10NoChange.Checked = True Then iInt2 = +2 ^ 9

        iRadioButtonValue = iInt2
    End Sub


End Class