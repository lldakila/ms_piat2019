Imports System.Data.OleDb
Public Class frmFlash
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Private Sub judge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
    End Sub
End Class