Imports System.Data.OleDb
Public Class frmLogin
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Sub login()
        da = New OleDbDataAdapter("SELECT * FROM tblUser WHERE username = '" & txt_User.Text & "' AND password = '" & txt_Pass.Text & "' And accesslvl = '" & cb_Level.Text & "'", ultracon)
        dset = New DataSet
        da.Fill(dset, "tblUser")
        If (dset.Tables("tblUser").Rows.Count <> 0) Then
            da = New OleDbDataAdapter("SELECT * FROM tblUser WHERE username = '" & txt_User.Text & "' AND password = '" & txt_Pass.Text & "' And accesslvl = '" & cb_Level.Text & "' AND status = 'Offline'", ultracon)
            dset = New DataSet
            da.Fill(dset, "tblUser")
            If (dset.Tables("tblUser").Rows.Count <> 0) Then
                If (cb_Level.Text = "Admin") Then
                    edit_status()
                    Me.Hide()
                    frmChecker.Show()


                ElseIf (cb_Level.Text = "Judge") Then
                    edit_status()
                    Me.Hide()
                    frmClientController.Show()
                    frmFlash.lblJudge.Text = txt_User.Text
                    frmFlash.Label1.Text = txt_User.Text
                End If


            Else
                MsgBox("The user is already Logged in!", MsgBoxStyle.Critical, "Try Again!")
                txt_User.Text = ""
                txt_Pass.Text = ""
                txt_User.Focus()
            End If
        Else
            MsgBox("Username and Password is Invalid!", MsgBoxStyle.Critical, "Try Again!")
            txt_User.Text = ""
            txt_Pass.Text = ""
            txt_User.Focus()
        End If
    End Sub

    Sub edit_status()
        dcom = New OleDbCommand
        With dcom
            .Connection = ultracon
            .CommandText = "UPDATE tblUser SET status = 'Online' WHERE username = '" & txt_User.Text & "'"
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ramcon()
        Catch ex As Exception
            MsgBox("ERROR DAW!" & ex.Message, MsgBoxStyle.Critical)
        End Try

        cb_Level.Items.Add("Admin")
        cb_Level.Items.Add("Judge")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub
End Class