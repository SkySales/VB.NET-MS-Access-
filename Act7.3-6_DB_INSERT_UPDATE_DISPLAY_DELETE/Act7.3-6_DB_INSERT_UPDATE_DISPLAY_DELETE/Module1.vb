Imports System.Data.OleDb
Module Module1
    Public connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0; data source =" & Application.StartupPath & "\db_vbNet.accdb"
    Public conn As New OleDbConnection(connStr)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function
End Module
