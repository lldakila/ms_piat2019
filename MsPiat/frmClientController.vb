Imports System.Data.OleDb
Public Class frmClientController
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand
    Dim sql As String = ""

    Sub updateControl()
        da = New OleDbDataAdapter("SELECT * FROM tblControl", ultracon)
        dset = New DataSet
        da.Fill(dset, "tblControl")

        Label1.Text = dset.Tables("tblControl").Rows(0).Item(0)
    End Sub

    Private Sub frmClientController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            updateControl()
        Catch ex As Exception
            Timer1.Enabled = False
            If MsgBox(ex.Message, MsgBoxStyle.RetryCancel) = vbRetry Then
                Timer1.Enabled = True
            Else

            End If
        End Try

        If Label1.Text = "0" Then
            frmFlash.Show()
            frmFilipiñana.Hide()
            frmSwimsuit.Hide()
            frmEthnic.Hide()
            frmQnA.Hide()
            frmTop5.Hide()

        ElseIf Label1.Text = "1" Then
            frmFlash.Hide()
            frmFilipiñana.Show()
            frmSwimsuit.Hide()
            frmEthnic.Hide()
            frmQnA.Hide()
            frmTop5.Hide()

        ElseIf (Label1.Text) = "2" Then
            frmFlash.Hide()
            frmFilipiñana.Hide()
            frmSwimsuit.Show()
            frmEthnic.Hide()

            frmTop5.Hide()

        ElseIf Label1.Text = "3" Then
            frmFlash.Hide()
            frmFilipiñana.Hide()
            frmSwimsuit.Hide()
            frmEthnic.Show()
            frmQnA.Hide()
            frmTop5.Hide()

        ElseIf Label1.Text = "4" Then
            frmFlash.Hide()
            frmFilipiñana.Hide()
            frmSwimsuit.Hide()
            frmEthnic.Hide()
            frmQnA.Show()
            frmTop5.Hide()

        ElseIf Label1.Text = "5" Then
            frmFlash.Hide()
            frmFilipiñana.Hide()
            frmSwimsuit.Hide()
            frmEthnic.Hide()
            frmQnA.Hide()
            frmTop5.Show()

        Else
            frmFlash.Show()
            frmFilipiñana.Hide()
            frmSwimsuit.Hide()
            frmEthnic.Hide()

            frmTop5.Hide()

        End If
    End Sub

    Private Sub frmClientController_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            ' Cancel the Closing event from closing the form.

            e.Cancel = True

        End If

        'MsgBox("You sure you want to close this? This will close the entire program", MsgBoxStyle.YesNo)
        'If MsgBoxResult.Yes Then
        '    dcom = New OleDbCommand
        '    dcom.Connection = ultracon

        '    sql = String.Format("UPDATE tblUser SET [status] = 'Offline' WHERE [username]  = '{0}'", frmFlash.lblJudge.Text)
        '    dcom.CommandText = sql
        '    dcom.ExecuteNonQuery()
        '    MsgBox("You have been logged out. Now closing...")
        '    Application.Exit()
        'ElseIf MsgBoxResult.No Then
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub frmClientController_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        sql = String.Format("UPDATE tblUser SET [status] = 'Offline' WHERE [username]  = '{0}'", frmFlash.lblJudge.Text)
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
        MsgBox("You have been logged out. Now closing...")
        Application.Exit()
    End Sub
End Class