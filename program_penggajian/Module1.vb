Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public OleCmd As OleDbCommand
    Public OleRdr As OleDbDataReader
    Public Cnn As OleDbConnection
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\gaji.accdb;"
        Cnn = New OleDbConnection(MyDB)
        If Cnn.State = ConnectionState.Closed Then Cnn.Open()
    End Sub
End Module
