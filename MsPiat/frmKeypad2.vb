Imports System.Data.OleDb
Public Class frmKeypad2
    Dim dcom As New OleDbCommand
    Dim sql As String
    Dim dotss As Integer
    Dim ck As Double


    Sub seeDotsss()
        dotss = 0
        For looop = 1 To (Len(txtIntel.Text))
            If (Mid(txtIntel.Text, looop, 1) = ".") Then
                dotss = 1
            End If
        Next
    End Sub

    Sub seeDotsss2()
        dotss = 0
        For looop = 1 To (Len(txtBeauty.Text))
            If (Mid(txtBeauty.Text, looop, 1) = ".") Then
                dotss = 1
            End If
        Next
    End Sub



    Private Sub txtIntel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIntel.KeyPress
        'Dim Allowed As String = "1234567890" + vbBack
        Dim Allowed As String = ""
        If Allowed.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If

        'backspace
        If Asc(e.KeyChar) = 8 Then
            If (txtIntel.Text <> "") Then
                txtIntel.Text = Microsoft.VisualBasic.Left(txtIntel.Text, (Len(txtIntel.Text)) - 1)
            End If
        End If

        'dot
        If Asc(e.KeyChar) = 46 Then
            seeDotsss()
            If (txtIntel.Text <> "") Then
                If ((dotss = 0) And (Len(txtIntel.Text) < 2)) Then
                    txtIntel.Text += "."
                End If
            End If
        End If

        'enter/carriage return
        If Asc(e.KeyChar) = 13 Then
            'MsgBox("You have pressed ASCII code " & Asc(e.KeyChar))
            If lblTable.Text = "tblTop5" Then
                If txtIntel.Text <> "" And txtBeauty.Text <> "" Then
                    dcom = New OleDbCommand
                    dcom.Connection = ultracon

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Intel", txtIntel.Text, Val(lblID2.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Beauty", txtBeauty.Text, Val(lblID2.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()
                    txtBeauty.Text = ""
                    txtIntel.Text = ""
                    Me.Hide()
                Else
                    Me.ActiveControl = txtBeauty
                End If
            Else
                If txtIntel.Text <> "" And txtBeauty.Text <> "" Then
                    dcom = New OleDbCommand
                    dcom.Connection = ultracon

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Intel", txtIntel.Text, Val(lblID.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Beauty", txtBeauty.Text, Val(lblID.Text))
                    dcom.CommandText = sql
                    MsgBox(dcom.CommandText)
                    dcom.ExecuteNonQuery()
                    txtBeauty.Text = ""
                    txtIntel.Text = ""
                    Me.Hide()
                Else
                    Me.ActiveControl = txtBeauty
                End If
            End If
        End If

        If Asc(e.KeyChar) = 48 Then
            seeDotsss()
            If ((txtIntel.Text <> "") And (Val(txtIntel.Text) < 2) And (Len(txtIntel.Text) < 4)) Then
                txtIntel.Text += "0"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "0"
            End If
        End If

        If Asc(e.KeyChar) = 49 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "1"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "1"
            End If
        End If

        If Asc(e.KeyChar) = 50 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "2"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "2"
            End If
        End If

        If Asc(e.KeyChar) = 51 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "3"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "3"
            End If
        End If

        If Asc(e.KeyChar) = 52 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "4"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "4"
            End If
        End If

        If Asc(e.KeyChar) = 53 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "5"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "5"
            End If
        End If

        If Asc(e.KeyChar) = 54 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "6"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "6"
            End If
        End If

        If Asc(e.KeyChar) = 55 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "7"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "7"
            End If
        End If

        If Asc(e.KeyChar) = 56 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "8"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "8"
            End If
        End If

        If Asc(e.KeyChar) = 57 Then
            seeDotsss()
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "9"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "9"
            End If
        End If
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        seeDotsss()
        If Me.ActiveControl Is txtIntel Then
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "1"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "1"
            End If
        ElseIf Me.ActiveControl Is txtBeauty Then
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "1"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "1"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        seeDotsss()
        If Me.ActiveControl Is txtIntel Then
            If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
                txtIntel.Text += "2"
            ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
                txtIntel.Text += "2"
            End If
        ElseIf Me.ActiveControl Is txtBeauty Then
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "2"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "2"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "3"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "4"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "5"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "6"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "7"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "8"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        seeDotsss()
        If (Val(txtIntel.Text) < 10) And (Len(txtIntel.Text) < 1) Then
            txtIntel.Text += "9"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "9"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        seeDotsss()
        If ((txtIntel.Text <> "") And (Val(txtIntel.Text) < 2) And (Len(txtIntel.Text) < 4)) Then
            txtIntel.Text += "0"
        ElseIf (dotss = 1) And (Len(txtIntel.Text) < 4) Then
            txtIntel.Text += "0"
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        seeDotsss()
        If (txtIntel.Text <> "") Then
            If ((dotss = 0) And (Len(txtIntel.Text) < 2)) Then
                txtIntel.Text += "."
            End If
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        If (txtIntel.Text <> "") Then
            txtIntel.Text = Microsoft.VisualBasic.Left(txtIntel.Text, (Len(txtIntel.Text)) - 1)
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If lblTable.Text = "tblTop5" Then
            If txtIntel.Text <> "" And txtBeauty.Text <> "" Then
                dcom = New OleDbCommand
                dcom.Connection = ultracon

                sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Intel", txtIntel.Text, Val(lblID2.Text))
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()

                sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Beauty", txtBeauty.Text, Val(lblID2.Text))
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
                txtBeauty.Text = ""
                txtIntel.Text = ""
                Me.Hide()
            Else
                Me.ActiveControl = txtBeauty
            End If
        Else
            If txtIntel.Text <> "" And txtBeauty.Text <> "" Then
                dcom = New OleDbCommand
                dcom.Connection = ultracon

                sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Intel", txtIntel.Text, Val(lblID.Text))
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()

                sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Beauty", txtBeauty.Text, Val(lblID.Text))
                dcom.CommandText = sql
                MsgBox(dcom.CommandText)
                dcom.ExecuteNonQuery()
                txtBeauty.Text = ""
                txtIntel.Text = ""
                Me.Hide()
            Else
                Me.ActiveControl = txtBeauty
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub frmKeypad2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtBeauty
    End Sub

    Private Sub txtBeauty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBeauty.KeyPress
        'Dim Allowed As String = "1234567890" + vbBack
        Dim Allowed As String = ""
        If Allowed.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If

        'backspace
        If Asc(e.KeyChar) = 8 Then
            If (txtBeauty.Text <> "") Then
                txtBeauty.Text = Microsoft.VisualBasic.Left(txtBeauty.Text, (Len(txtBeauty.Text)) - 1)
            End If
        End If

        'dot
        If Asc(e.KeyChar) = 46 Then
            seeDotsss()
            If (txtBeauty.Text <> "") Then
                If ((dotss = 0) And (Len(txtBeauty.Text) < 2)) Then
                    txtBeauty.Text += "."
                End If
            End If
        End If

        'enter/carriage return
        If Asc(e.KeyChar) = 13 Then
            'MsgBox("You have pressed ASCII code " & Asc(e.KeyChar))
            If lblTable.Text = "tblTop5" Then
                If txtIntel.Text <> "" And txtBeauty.Text <> "" Then
                    dcom = New OleDbCommand
                    dcom.Connection = ultracon

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Intel", txtIntel.Text, Val(lblID2.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Beauty", txtBeauty.Text, Val(lblID2.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()
                    txtBeauty.Text = ""
                    txtIntel.Text = ""
                    Me.Hide()
                Else
                    Me.ActiveControl = txtIntel
                End If
            Else
                If txtIntel.Text <> "" And txtBeauty.Text <> "" Then
                    dcom = New OleDbCommand
                    dcom.Connection = ultracon

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Intel", txtIntel.Text, Val(lblID.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()

                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frmFlash.lblJudge.Text + " Beauty", txtBeauty.Text, Val(lblID.Text))
                    dcom.CommandText = sql
                    MsgBox(dcom.CommandText)
                    dcom.ExecuteNonQuery()
                    txtBeauty.Text = ""
                    txtIntel.Text = ""
                    Me.Hide()
                Else
                    Me.ActiveControl = txtIntel
                End If
            End If
        End If

        If Asc(e.KeyChar) = 48 Then
            seeDotsss2()
            If ((txtBeauty.Text <> "") And (Val(txtBeauty.Text) < 2) And (Len(txtBeauty.Text) < 4)) Then
                txtBeauty.Text += "0"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "0"
            End If
        End If

        If Asc(e.KeyChar) = 49 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "1"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "1"
            End If
        End If

        If Asc(e.KeyChar) = 50 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "2"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "2"
            End If
        End If

        If Asc(e.KeyChar) = 51 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "3"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "3"
            End If
        End If

        If Asc(e.KeyChar) = 52 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "4"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "4"
            End If
        End If

        If Asc(e.KeyChar) = 53 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "5"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "5"
            End If
        End If

        If Asc(e.KeyChar) = 54 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "6"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "6"
            End If
        End If

        If Asc(e.KeyChar) = 55 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "7"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "7"
            End If
        End If

        If Asc(e.KeyChar) = 56 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "8"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "8"
            End If
        End If

        If Asc(e.KeyChar) = 57 Then
            seeDotsss2()
            If (Val(txtBeauty.Text) < 10) And (Len(txtBeauty.Text) < 1) Then
                txtBeauty.Text += "9"
            ElseIf (dotss = 1) And (Len(txtBeauty.Text) < 4) Then
                txtBeauty.Text += "9"
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class