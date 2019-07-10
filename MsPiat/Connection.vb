Imports System.Data.OleDb
Module Connection
    Public constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\LAPTOP-UOSC739\MsPiat\MsPiat\bin\Debug\dbmspiat2019.mdb"
    Public ultracon As New OleDbConnection(constr)



    Sub ramcon()
        If (ultracon.State = ConnectionState.Closed) Then
            ultracon.Open()
        End If
    End Sub
End Module
