Imports System.Data.OleDb
Public Class frmSwimsuit
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    'update score miss
    Sub updateScoreMs()
        da = New OleDbDataAdapter("SELECT * FROM tblSwimsuit", ultracon)
        dset = New DataSet
        da.Fill(dset, "tblSwimsuit")

        txtCandi1.Text = dset.Tables("tblSwimsuit").Rows(0).Item(frmFlash.lblJudge.Text)
        txtCandi2.Text = dset.Tables("tblSwimsuit").Rows(1).Item(frmFlash.lblJudge.Text)
        txtCandi3.Text = dset.Tables("tblSwimsuit").Rows(2).Item(frmFlash.lblJudge.Text)
        txtCandi4.Text = dset.Tables("tblSwimsuit").Rows(3).Item(frmFlash.lblJudge.Text)
        txtCandi5.Text = dset.Tables("tblSwimsuit").Rows(4).Item(frmFlash.lblJudge.Text)
        txtCandi6.Text = dset.Tables("tblSwimsuit").Rows(5).Item(frmFlash.lblJudge.Text)
        txtCandi7.Text = dset.Tables("tblSwimsuit").Rows(6).Item(frmFlash.lblJudge.Text)
        txtCandi8.Text = dset.Tables("tblSwimsuit").Rows(7).Item(frmFlash.lblJudge.Text)
        txtCandi9.Text = dset.Tables("tblSwimsuit").Rows(8).Item(frmFlash.lblJudge.Text)
        txtCandi10.Text = dset.Tables("tblSwimsuit").Rows(9).Item(frmFlash.lblJudge.Text)
    End Sub

    Private Sub frmSwimsuit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
    End Sub

    Private Sub pbCandi1_Click(sender As Object, e As EventArgs) Handles pbCandi1.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "1"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi2_Click(sender As Object, e As EventArgs) Handles pbCandi2.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "2"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi3_Click(sender As Object, e As EventArgs) Handles pbCandi3.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "3"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi4_Click(sender As Object, e As EventArgs) Handles pbCandi4.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "4"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi5_Click(sender As Object, e As EventArgs) Handles pbCandi5.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "5"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi6_Click(sender As Object, e As EventArgs) Handles pbCandi6.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "6"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi7_Click(sender As Object, e As EventArgs) Handles pbCandi7.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "7"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi8_Click(sender As Object, e As EventArgs) Handles pbCandi8.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "8"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi9_Click(sender As Object, e As EventArgs) Handles pbCandi9.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
        frmKeypad.lblID.Text = "9"
        frmKeypad.ShowDialog()
    End Sub

    Private Sub pbCandi10_Click(sender As Object, e As EventArgs) Handles pbCandi10.Click
        frmKeypad.lblCat.Text = "Swimsuit"
        frmKeypad.lblTable.Text = "tblSwimsuit"
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