Imports System.Data.OleDb
Public Class frmTop5
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Sub updateScoreMs()
        da = New OleDbDataAdapter("SELECT * FROM tblTop5", ultracon)
        dset = New DataSet
        da.Fill(dset, "tblTop5")

        txtCandi1.Text = dset.Tables("tblTop5").Rows(0).Item(frmFlash.lblJudge.Text + " Beauty")
        txtCandi2.Text = dset.Tables("tblTop5").Rows(1).Item(frmFlash.lblJudge.Text + " Beauty")
        txtCandi3.Text = dset.Tables("tblTop5").Rows(2).Item(frmFlash.lblJudge.Text + " Beauty")
        txtCandi4.Text = dset.Tables("tblTop5").Rows(3).Item(frmFlash.lblJudge.Text + " Beauty")
        txtCandi5.Text = dset.Tables("tblTop5").Rows(4).Item(frmFlash.lblJudge.Text + " Beauty")

        txtCandi1i.Text = dset.Tables("tblTop5").Rows(0).Item(frmFlash.lblJudge.Text + " Intel")
        txtCandi2i.Text = dset.Tables("tblTop5").Rows(1).Item(frmFlash.lblJudge.Text + " Intel")
        txtCandi3i.Text = dset.Tables("tblTop5").Rows(2).Item(frmFlash.lblJudge.Text + " Intel")
        txtCandi4i.Text = dset.Tables("tblTop5").Rows(3).Item(frmFlash.lblJudge.Text + " Intel")
        txtCandi5i.Text = dset.Tables("tblTop5").Rows(4).Item(frmFlash.lblJudge.Text + " Intel")

        lblCandi1.Text = dset.Tables("tblTop5").Rows(0).Item(13)
        lblCandi2.Text = dset.Tables("tblTop5").Rows(1).Item(13)
        lblCandi3.Text = dset.Tables("tblTop5").Rows(2).Item(13)
        lblCandi4.Text = dset.Tables("tblTop5").Rows(3).Item(13)
        lblCandi5.Text = dset.Tables("tblTop5").Rows(4).Item(13)
    End Sub

    Sub showPic()
        'candi1
        If lblCandi1.Text = "1" Then
            pbCandi1.Image = My.Resources.candi1
        ElseIf lblCandi1.Text = "2" Then
            pbCandi1.Image = My.Resources.candi2
        ElseIf lblCandi1.Text = "3" Then
            pbCandi1.Image = My.Resources.candi3
        ElseIf lblCandi1.Text = "4" Then
            pbCandi1.Image = My.Resources.candi4
        ElseIf lblCandi1.Text = "5" Then
            pbCandi1.Image = My.Resources.candi5
        ElseIf lblCandi1.Text = "6" Then
            pbCandi1.Image = My.Resources.candi6
        ElseIf lblCandi1.Text = "7" Then
            pbCandi1.Image = My.Resources.candi7
        ElseIf lblCandi1.Text = "8" Then
            pbCandi1.Image = My.Resources.candi8
        ElseIf lblCandi1.Text = "9" Then
            pbCandi1.Image = My.Resources.candi9
        ElseIf lblCandi1.Text = "10" Then
            pbCandi1.Image = My.Resources.candi10
        End If

        'candi2
        If lblCandi2.Text = "1" Then
            pbCandi2.Image = My.Resources.candi1
        ElseIf lblCandi2.Text = "2" Then
            pbCandi2.Image = My.Resources.candi2
        ElseIf lblCandi2.Text = "3" Then
            pbCandi2.Image = My.Resources.candi3
        ElseIf lblCandi2.Text = "4" Then
            pbCandi2.Image = My.Resources.candi4
        ElseIf lblCandi2.Text = "5" Then
            pbCandi2.Image = My.Resources.candi5
        ElseIf lblCandi2.Text = "6" Then
            pbCandi2.Image = My.Resources.candi6
        ElseIf lblCandi2.Text = "7" Then
            pbCandi2.Image = My.Resources.candi7
        ElseIf lblCandi2.Text = "8" Then
            pbCandi2.Image = My.Resources.candi8
        ElseIf lblCandi2.Text = "9" Then
            pbCandi2.Image = My.Resources.candi9
        ElseIf lblCandi2.Text = "10" Then
            pbCandi2.Image = My.Resources.candi10
        End If

        'candi3
        If lblCandi3.Text = "1" Then
            pbCandi3.Image = My.Resources.candi1
        ElseIf lblCandi3.Text = "2" Then
            pbCandi3.Image = My.Resources.candi2
        ElseIf lblCandi3.Text = "3" Then
            pbCandi3.Image = My.Resources.candi3
        ElseIf lblCandi3.Text = "4" Then
            pbCandi3.Image = My.Resources.candi4
        ElseIf lblCandi3.Text = "5" Then
            pbCandi3.Image = My.Resources.candi5
        ElseIf lblCandi3.Text = "6" Then
            pbCandi3.Image = My.Resources.candi6
        ElseIf lblCandi3.Text = "7" Then
            pbCandi3.Image = My.Resources.candi7
        ElseIf lblCandi3.Text = "8" Then
            pbCandi3.Image = My.Resources.candi8
        ElseIf lblCandi3.Text = "9" Then
            pbCandi3.Image = My.Resources.candi9
        ElseIf lblCandi3.Text = "10" Then
            pbCandi3.Image = My.Resources.candi10
        End If

        'candi4
        If lblCandi4.Text = "1" Then
            pbCandi4.Image = My.Resources.candi1
        ElseIf lblCandi4.Text = "2" Then
            pbCandi4.Image = My.Resources.candi2
        ElseIf lblCandi4.Text = "3" Then
            pbCandi4.Image = My.Resources.candi3
        ElseIf lblCandi4.Text = "4" Then
            pbCandi4.Image = My.Resources.candi4
        ElseIf lblCandi4.Text = "5" Then
            pbCandi4.Image = My.Resources.candi5
        ElseIf lblCandi4.Text = "6" Then
            pbCandi4.Image = My.Resources.candi6
        ElseIf lblCandi4.Text = "7" Then
            pbCandi4.Image = My.Resources.candi7
        ElseIf lblCandi4.Text = "8" Then
            pbCandi4.Image = My.Resources.candi8
        ElseIf lblCandi4.Text = "9" Then
            pbCandi4.Image = My.Resources.candi9
        ElseIf lblCandi4.Text = "10" Then
            pbCandi4.Image = My.Resources.candi10
        End If

        'candi5
        If lblCandi5.Text = "1" Then
            pbCandi5.Image = My.Resources.candi1
        ElseIf lblCandi5.Text = "2" Then
            pbCandi5.Image = My.Resources.candi2
        ElseIf lblCandi5.Text = "3" Then
            pbCandi5.Image = My.Resources.candi3
        ElseIf lblCandi5.Text = "4" Then
            pbCandi5.Image = My.Resources.candi4
        ElseIf lblCandi5.Text = "5" Then
            pbCandi5.Image = My.Resources.candi5
        ElseIf lblCandi5.Text = "6" Then
            pbCandi5.Image = My.Resources.candi6
        ElseIf lblCandi5.Text = "7" Then
            pbCandi5.Image = My.Resources.candi7
        ElseIf lblCandi5.Text = "8" Then
            pbCandi5.Image = My.Resources.candi8
        ElseIf lblCandi5.Text = "9" Then
            pbCandi5.Image = My.Resources.candi9
        ElseIf lblCandi5.Text = "10" Then
            pbCandi5.Image = My.Resources.candi10
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updateScoreMs()
        showPic()
    End Sub

    'candi click
    Private Sub pbCandi1_Click(sender As Object, e As EventArgs) Handles pbCandi1.Click
        frmKeypad2.lblCat.Text = "Top 5"
        frmKeypad2.lblTable.Text = "tblTop5"
        frmKeypad2.lblID2.Text = "1"
        frmKeypad2.lblID.Text = lblCandi1.Text
        frmKeypad2.ShowDialog()
    End Sub

    Private Sub pbCandi2_Click(sender As Object, e As EventArgs) Handles pbCandi2.Click
        frmKeypad2.lblCat.Text = "Top 5"
        frmKeypad2.lblTable.Text = "tblTop5"
        frmKeypad2.lblID2.Text = "2"
        frmKeypad2.lblID.Text = lblCandi2.Text
        frmKeypad2.ShowDialog()
    End Sub

    Private Sub pbCandi3_Click(sender As Object, e As EventArgs) Handles pbCandi3.Click
        frmKeypad2.lblCat.Text = "Top 5"
        frmKeypad2.lblTable.Text = "tblTop5"
        frmKeypad2.lblID2.Text = "3"
        frmKeypad2.lblID.Text = lblCandi3.Text
        frmKeypad2.ShowDialog()
    End Sub

    Private Sub pbCandi4_Click(sender As Object, e As EventArgs) Handles pbCandi4.Click
        frmKeypad2.lblCat.Text = "Top 5"
        frmKeypad2.lblTable.Text = "tblTop5"
        frmKeypad2.lblID2.Text = "4"
        frmKeypad2.lblID.Text = lblCandi4.Text
        frmKeypad2.ShowDialog()
    End Sub

    Private Sub pbCandi5_Click(sender As Object, e As EventArgs) Handles pbCandi5.Click
        frmKeypad2.lblCat.Text = "Top 5"
        frmKeypad2.lblTable.Text = "tblTop5"
        frmKeypad2.lblID2.Text = "5"
        frmKeypad2.lblID.Text = lblCandi5.Text
        frmKeypad2.ShowDialog()
    End Sub
End Class