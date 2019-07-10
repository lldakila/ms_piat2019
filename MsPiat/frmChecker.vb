Imports System.Data.OleDb
Public Class frmChecker
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Sub checkStatus()
        da = New OleDbDataAdapter("SELECT * FROM tblUser", ultracon)
        dset = New DataSet
        da.Fill(dset, "tblUser")

        lblJudge1.Text = dset.Tables("tblUser").Rows(1).Item(4)
        lblJudge2.Text = dset.Tables("tblUser").Rows(2).Item(4)
        lblJudge3.Text = dset.Tables("tblUser").Rows(3).Item(4)
        lblJudge4.Text = dset.Tables("tblUser").Rows(4).Item(4)
        lblJudge5.Text = dset.Tables("tblUser").Rows(5).Item(4)
        lblJudge6.Text = dset.Tables("tblUser").Rows(6).Item(4)
        lblJudge7.Text = dset.Tables("tblUser").Rows(7).Item(4)
    End Sub

    Sub statusColor()
        If lblJudge1.Text = "Online" Then
            lblJudge1.ForeColor = Color.Green
        Else
            lblJudge1.ForeColor = Color.Red
        End If
        If lblJudge2.Text = "Online" Then
            lblJudge2.ForeColor = Color.Green
        Else
            lblJudge2.ForeColor = Color.Red
        End If
        If lblJudge3.Text = "Online" Then
            lblJudge3.ForeColor = Color.Green
        Else
            lblJudge3.ForeColor = Color.Red
        End If
        If lblJudge4.Text = "Online" Then
            lblJudge4.ForeColor = Color.Green
        Else
            lblJudge4.ForeColor = Color.Red
        End If
        If lblJudge5.Text = "Online" Then
            lblJudge5.ForeColor = Color.Green
        Else
            lblJudge5.ForeColor = Color.Red
        End If
        If lblJudge6.Text = "Online" Then
            lblJudge6.ForeColor = Color.Green
        Else
            lblJudge6.ForeColor = Color.Red
        End If
        If lblJudge7.Text = "Online" Then
            lblJudge7.ForeColor = Color.Green
        Else
            lblJudge7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        checkStatus()
        statusColor()

        If lblJudge1.Text = "Online" And lblJudge2.Text = "Online" And lblJudge3.Text = "Online" And lblJudge4.Text = "Online" And lblJudge5.Text = "Online" Then
            Button1.Enabled = True
        Else
            'If lblJudge1.Text = "Online" And lblJudge2.Text = "Online" And lblJudge3.Text = "Online" And lblJudge4.Text = "Online" And lblJudge5.Text = "Online" And lblJudge6.Text = "Online" Then
            '    Button1.Enabled = True
            'Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub frmChecker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class