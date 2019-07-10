Imports System.Data.OleDb
Public Class frmMain
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    'sql for mr and ms 
    Dim sqlMs As String

    Dim tblMs As String

    'for copying
    Dim tblName As String

    Dim ctr As String
    Dim sql As String
    Dim name1 As String
    Dim num As Integer

    'compute total Ms for tblms in diff category
    Sub computeTotalMs()
        sql = String.Format("SELECT * FROM {0}", lblMs.Text)
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, lblMs.Text)
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        'For b = 2 To 8 column num sa tbl ng judges
        If cbCategory.Text = "Top 5" Then
            For a = 0 To 4
                Dim total As Double = 0
                Dim beauty As Double = 0
                Dim intel As Double = 0
                'beauty
                For b = 2 To 6
                    beauty += dset.Tables(lblMs.Text).Rows(a).Item(b)
                Next
                beauty = (beauty / 5) * 0.6
                'intel
                For b = 7 To 11
                    intel += dset.Tables(lblMs.Text).Rows(a).Item(b)
                Next
                intel = (intel / 5) * 0.4
                total = beauty + intel
                sql = String.Format("UPDATE {0} SET [Total] = {1} WHERE [ID] = {2}", lblMs.Text, total, a + 1)
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
            Next
            'ElseIf cbCategory.Text = "QnA" Then
            '    For a = 0 To 9
            '        Dim total As Double = 0
            '        Dim beauty As Double = 0
            '        Dim intel As Double = 0
            '        'beauty
            '        For b = 2 To 6
            '            beauty += dset.Tables(lblMs.Text).Rows(a).Item(b)
            '        Next
            '        beauty = (beauty / 5) * 0.6
            '        'intel
            '        For b = 7 To 11
            '            intel += dset.Tables(lblMs.Text).Rows(a).Item(b)
            '        Next
            '        intel = (intel / 5) * 0.4
            '        total = beauty + intel
            '        sql = String.Format("UPDATE {0} SET [Total] = {1} WHERE [ID] = {2}", lblMs.Text, total, a + 1)
            '        dcom.CommandText = sql
            '        dcom.ExecuteNonQuery()
            '    Next
        Else 'categories
            For a = 0 To 9
                Dim total As Double = 0
                For b = 2 To 6
                    total += dset.Tables(lblMs.Text).Rows(a).Item(b)
                Next
                total = total / 5
                sql = String.Format("UPDATE {0} SET [Total] = {1} WHERE [ID] = {2}", lblMs.Text, total, a + 1)
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
                sql = String.Format("UPDATE tblTotal SET {0} = {1} WHERE [ID] = {2}", lblMs.Text, total, a + 1)
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
            Next
        End If
    End Sub

    'top 5
    Sub computeMs5()
        da = New OleDbDataAdapter("SELECT * FROM tblTotal ORDER BY Total Desc", ultracon)
        dset = New DataSet
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        da.Fill(dset, "tblTotal")

        For a = 0 To 4
            num = dset.Tables("tblTotal").Rows(a).Item(0)
            name1 = dset.Tables("tblTotal").Rows(a).Item(1)

            sql = String.Format("UPDATE tblTop5 SET [Candidate] = '{0}', [conNumber] = '{1}' WHERE [ID] = {2}", name1, num, a + 1)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next
    End Sub

    Sub totalTotal()
        sql = String.Format("SELECT * FROM tblTotal")
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, "tblTotal")
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        For a = 0 To 9
            Dim total As Double = 0
            For b = 2 To 5
                If b = 5 Then
                    total += (dset.Tables("tblTotal").Rows(a).Item(b)) * 0.4
                Else
                    total += (dset.Tables("tblTotal").Rows(a).Item(b)) * 0.2
                End If
            Next

            sql = String.Format("UPDATE tblTotal SET [Total] = {0} WHERE [ID] = {1}", total, a + 1)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next
        MsgBox("Ready to take Top 5")
    End Sub

    'control judge's display
    Sub controlClient()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        sql = String.Format("UPDATE tblControl SET [ClientControl] = {0}", ctr)
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
    End Sub

    'stop client/judge show frmFlash
    Sub stopClient()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "UPDATE tblControl SET [ClientControl] = '0'"
        dcom.ExecuteNonQuery()
    End Sub

    'populate datagridview for Ms
    Sub popDgvMs()
        da = New OleDbDataAdapter(sqlMs, ultracon)
        dset = New DataSet
        da.Fill(dset, tblMs)
        dgvMs.DataSource = dset.Tables(tblMs).DefaultView
        With dgvMs
                .Columns(0).Visible = False
                .Columns(1).Width = 200
                .Columns(2).Width = 70
                .Columns(3).Width = 70
                .Columns(4).Width = 70
                .Columns(5).Width = 70
                .Columns(6).Width = 70
                .Columns(7).Width = 150
            End With
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()

        'add data to combo box
        With cbCategory
            .Items.Add("Filipiñana")
            .Items.Add("Swimsuit")
            .Items.Add("Ethnic")
            .Items.Add("QnA")
            .Items.Add("Top 5")
        End With

        With cbReport
            .Items.Add("Filipiñana")
            .Items.Add("Swimsuit")
            .Items.Add("Ethnic")
            .Items.Add("QnA")
            .Items.Add("Total")
            .Items.Add("Top 5")
        End With

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cbCategory.Text = "Filipiñana" Then
            tblMs = "tblFilipiñana"
            sqlMs = "SELECT * FROM tblFilipiñana"
            ctr = 1
            lblMs.Text = "tblFilipiñana"
        ElseIf cbCategory.Text = "Swimsuit" Then
            tblMs = "tblSwimsuit"
            sqlMs = "SELECT * FROM tblSwimsuit"
            ctr = 2
            lblMs.Text = "tblSwimsuit"
        ElseIf cbCategory.Text = "Ethnic" Then
            tblMs = "tblEthnicAttire"
            sqlMs = "SELECT * FROM tblEthnicAttire"
            ctr = 3
            lblMs.Text = "tblEthnicAttire"
        ElseIf cbCategory.Text = "QnA" Then
            tblMs = "tblQnA"
            sqlMs = "SELECT * FROM tblQnA"
            ctr = 4
            lblMs.Text = "tblQnA"
        ElseIf cbCategory.Text = "Top 5" Then
            tblMs = "tblTop5"
            sqlMs = "SELECT * FROM tblTop5"
            ctr = 5
            lblMs.Text = "tblTop5"
        End If

        If cbCategory.Text <> "" Then
            popDgvMs()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If MsgBox(cbCategory.Text & " Na?", MsgBoxStyle.YesNo) = vbYes Then
            controlClient()
        Else

        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If MsgBox("Tapos na ung " & cbCategory.Text, MsgBoxStyle.YesNo) = vbYes Then
            stopClient()
            computeTotalMs()
        Else

        End If
    End Sub

    Private Sub btnComputeTop10_Click(sender As Object, e As EventArgs) Handles btnComputeTop10.Click
        computeMs5()
        MsgBox("Final 5 na !!!")
    End Sub

    Private Sub btnRpt_Click(sender As Object, e As EventArgs) Handles btnRpt.Click
        If cbReport.SelectedIndex = 0 Then
            frmCrystalFilipiñana.Show()
        ElseIf cbReport.SelectedIndex = 1 Then
            frmCrystalSwimsuit.Show()
        ElseIf cbReport.SelectedIndex = 2 Then
            frmCrystalEthnic.Show()
        ElseIf cbReport.SelectedIndex = 3 Then
            frmCrystalQnA.Show()
        ElseIf cbReport.SelectedIndex = 4 Then
            frmCrystalTotal.Show()
        ElseIf cbReport.SelectedIndex = 5 Then
            frmCrystalTop5.Show()
        End If
    End Sub

    Private Sub btnComputeTotalAll_Click(sender As Object, e As EventArgs) Handles btnComputeTotalAll.Click
        totalTotal()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        sql = String.Format("UPDATE tblUser SET [status] = 'Offline' WHERE [username]  = 'admin'")
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
        MsgBox("You have been logged out. Now closing...")
        Application.Exit()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        End If
    End Sub
End Class