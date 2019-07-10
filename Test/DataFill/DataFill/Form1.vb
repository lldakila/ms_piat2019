Imports System.Data.OleDb
Public Class Form1
    Dim dcom As New OleDbCommand
    Dim sql As String = ""
    Dim constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\LAPTOP-UOSC739\MsPiat\MsPiat\bin\Debug\dbmspiat2019.mdb"
    Dim ultracon As New OleDbConnection(constr)

    Function rand()
        Return Decimal.Round((5 + (Rnd() * 5)), 2, MidpointRounding.AwayFromZero)
    End Function

    Sub fillDatabase()
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        dcom.CommandText = "UPDATE tblControl SET [ClientControl] = '0'"
        dcom.ExecuteNonQuery()

        For a = 2 To 10
            sql = String.Format("UPDATE tblUser SET [status] = 'Online' WHERE [ID] = {0}", a)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For b = 1 To 20
            sql = String.Format("UPDATE tblSwimsuit SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), b)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For c = 1 To 20
            sql = String.Format("UPDATE tblEthnicAttire SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), c)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For d = 1 To 20
            sql = String.Format("UPDATE tblFilipiñana SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), d)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For e = 1 To 20
            sql = String.Format("UPDATE tblQnA SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), e)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next



        For h = 1 To 5
            sql = String.Format("UPDATE tblTop5 SET [Judge 1 Intel] = {0}, [Judge 2 Intel] = {1}, [Judge 3 Intel] = {2}, [Judge 4 Intel] = {3}, [Judge 5 Intel] = {4} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), h)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For j = 1 To 5
            sql = String.Format("UPDATE tblTop5 SET [Judge 1 Beauty] = {0}, [Judge 2 Beauty] = {1}, [Judge 3 Beauty] = {2}, [Judge 4 Beauty] = {3}, [Judge 5 Beauty] = {4} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), j)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        MsgBox("Database Fill Successful !")
    End Sub

    Sub resetDatabase()
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        dcom.CommandText = "UPDATE tblControl SET [ClientControl] = '0'"
        dcom.ExecuteNonQuery()

        dcom.CommandText = "UPDATE tblUser SET [status] = 'Offline'"
        dcom.ExecuteNonQuery()

        dcom.CommandText = "UPDATE tblSwimsuit SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblEthnicAttire SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblFilipiñana SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblQnA SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        'dcom.CommandText = "UPDATE tblTop10 SET [Candidate] = 'None', [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Judge 6] = 'None', [Judge 7] = 'None', [Total] = 'None'"
        'dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblTop5 SET [Candidate] = 'None', [Judge 1 Intel] = 'None', [Judge 2 Intel] = 'None', [Judge 3 Intel] = 'None', [Judge 4 Intel] = 'None', [Judge 5 Intel] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblTop5 SET [Candidate] = 'None', [Judge 1 Beauty] = 'None', [Judge 2 Beauty] = 'None', [Judge 3 Beauty] = 'None', [Judge 4 Beauty] = 'None', [Judge 5 Beauty] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()


        MsgBox("Database Reset Successful !")
    End Sub

    Sub semiResetDb()
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        dcom.CommandText = "UPDATE tblControl SET [ClientControl] = '0'"
        dcom.ExecuteNonQuery()

        dcom.CommandText = "UPDATE tblUser SET [status] = 'Offline'"
        dcom.ExecuteNonQuery()

        dcom.CommandText = "UPDATE tblProdNum SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Judge 6] = 'None', [Judge 7] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblGown SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Judge 6] = 'None', [Judge 7] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblSwimsuit2 SET [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Judge 6] = 'None', [Judge 7] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblTop10 SET [Candidate] = 'None', [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Judge 6] = 'None', [Judge 7] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()
        dcom.CommandText = "UPDATE tblTop5 SET [Candidate] = 'None', [Judge 1] = 'None', [Judge 2] = 'None', [Judge 3] = 'None', [Judge 4] = 'None', [Judge 5] = 'None', [Judge 6] = 'None', [Judge 7] = 'None', [Total] = 'None'"
        dcom.ExecuteNonQuery()


        MsgBox("Database SemiReset Successful !")
    End Sub

    Sub semiFillDb()
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        dcom.CommandText = "UPDATE tblControl SET [ClientControl] = '0'"
        dcom.ExecuteNonQuery()

        For a = 2 To 10
            sql = String.Format("UPDATE tblUser SET [status] = 'Online' WHERE [ID] = {0}", a)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For e = 1 To 20
            sql = String.Format("UPDATE tblProdNum SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4}, [Judge 6] = {5}, [Judge 7] = {6} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), e)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        For f = 1 To 20
            sql = String.Format("UPDATE tblGown SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4}, [Judge 6] = {5}, [Judge 7] = {6} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), f)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next





        For h = 1 To 5
            sql = String.Format("UPDATE tblTop5 SET [Judge 1] = {0}, [Judge 2] = {1}, [Judge 3] = {2}, [Judge 4] = {3}, [Judge 5] = {4}, [Judge 6] = {5}, [Judge 7] = {6} WHERE [ID] = {9}", rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), rand(), h)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
        Next

        MsgBox("Database SemiFill Successful !")
    End Sub

    Sub loginAll()
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        dcom.CommandText = "UPDATE tblUser SET [status] = 'Online'"
        dcom.ExecuteNonQuery()
        MsgBox("LoginAll Successful !")
    End Sub

    Sub logoutAll()
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        dcom.CommandText = "UPDATE tblUser SET [status] = 'Offline'"
        dcom.ExecuteNonQuery()
        MsgBox("LogoutAll Successful !")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ultracon.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Random na itu !", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            fillDatabase()
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Linis Din !", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            resetDatabase()
        Else
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("SemiLinis Din !", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            semiResetDb()
        Else
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("SemiRandom !", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            semiFillDb()
        Else
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("LoginAll Din !", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            loginAll()
        Else
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("LogoutAll Din !", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            logoutAll()
        Else
        End If
    End Sub
End Class
