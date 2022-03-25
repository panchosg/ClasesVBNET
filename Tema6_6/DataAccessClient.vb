
Imports System.Data.SqlClient

Public Class DataAccessClient
    Private ReadOnly _connectionString As String

    Sub New(server As String, database As String, user As String, passwd As String)
        _connectionString = $"server={server};database={database};uid={user};pwd={passwd}"
    End Sub

    Public Function ConnectionTest() As Boolean
        Dim oConnection As SqlConnection
        Try
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString
            oConnection.Open()
            Debug.WriteLine("Conexión establecida")
            oConnection.Close()
            Debug.WriteLine("Conexión cerrada")
        Catch ex As Exception
            Debug.WriteLine("Hubo un error en la conexión")
        End Try


    End Function

End Class
