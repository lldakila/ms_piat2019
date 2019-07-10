Imports System.Data.OleDb

Public Class frmFilipiñana
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Sub showpic()
        pbCandi1.Image = My.Resources.candi1
        pbCandi2.Image = My.Resources.candi2
        pbCandi3.Image = My.Resources.candi3
        pbCandi4.Image = My.Resources.candi4
        pbCandi5.Image = My.Resources.candi5
        pbCandi6.Image = My.Resources.candi6
        pbCandi7.Image = My.Resources.candi7
        pbCandi8.Image = My.Resources.candi8
        pbCandi9.Image = My.Resources.candi9
        pbCandi10.Image = My.Resources.candi10
    End Sub

    'update score miss
    Sub updateScoreMs()
        da = New OleDbDataAdapter("SELECT * FROM tblFilipiñana", ultracon)
        dset = New DataSet
        da.Fill(dset, "tblFilipiñana")

        txtCandi1.Text = dset.Tables("tblFilipiñana").Rows(0).Item(frmFlash.lblJudge.Text)
        txtCandi2.Text = dset.Tables("tblFilipiñana").Rows(1).Item(frmFlash.lblJudge.Text)
        txtCandi3.Text = dset.Tables("tblFilipiñana").Rows(2).Item(frmFlash.lblJudge.Text)
        txtCandi4.Text = dset.Tables("tblFilipiñana").Rows(3).Item(frmFlash.lblJudge.Text)
        txtCandi5.Text = dset.Tables("tblFilipiñana").Rows(4).Item(frmFlash.lblJudge.Text)
        txtCandi6.Text = dset.Tables("tblFilipiñana").Rows(5).Item(frmFlash.lblJudge.Text)
        txtCandi7.Text = dset.Tables("tblFilipiñana").Rows(6).Item(frmFlash.lblJudge.Text)
        txtCandi8.Text = dset.Tables("tblFilipiñana").Rows(7).Item(frmFlash.lblJudge.Text)
        txtCandi9.Text = dset.Tables("tblFilipiñana").Rows(8).Item(frmFlash.lblJudge.Text)
        txtCandi10.Text = dset.Tables("tblFilipiñana").Rows(9).Item(frmFlash.lblJudge.Text)
    End Sub

    Private Sub frmFilipiñana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
        showpic()
    End Sub

    Private Sub pbCandi1_Click(sender As Object, e As EventArgs) Handles pbCandi1.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "1"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi2_Click(sender As Object, e As EventArgs) Handles pbCandi2.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "2"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi3_Click(sender As Object, e As EventArgs) Handles pbCandi3.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "3"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi4_Click(sender As Object, e As EventArgs) Handles pbCandi4.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "4"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi5_Click(sender As Object, e As EventArgs) Handles pbCandi5.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "5"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi6_Click(sender As Object, e As EventArgs) Handles pbCandi6.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "6"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi7_Click(sender As Object, e As EventArgs) Handles pbCandi7.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "7"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi8_Click(sender As Object, e As EventArgs) Handles pbCandi8.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "8"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi9_Click(sender As Object, e As EventArgs) Handles pbCandi9.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "9"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi10_Click(sender As Object, e As EventArgs) Handles pbCandi10.Click
        frmKeypad.lblCat.Text = "Filipiñana"
        frmKeypad.lblTable.Text = "tblFilipiñana"
        frmKeypad.lblID.Text = "10"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            updateScoreMs()
        Catch ex As Exception
            Timer1.Enabled = False
            If MsgBox("Connection to Server has been Lost !", MsgBoxStyle.RetryCancel) = vbRetry Then
                Timer1.Enabled = True
            Else

            End If
        End Try
    End Sub
End Class