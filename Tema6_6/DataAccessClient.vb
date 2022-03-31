
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
        Catch exb As SqlException
            Debug.WriteLine("Error específico de la conexión a BBDD")
        Catch ex As Exception
            Debug.WriteLine("Hubo un error genérico en la conexión")
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Se encarga de insertar valores en la tabla gestores_bd
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="lanzamiento"></param>
    ''' <param name="desarrollador"></param>
    ''' <returns></returns>
    Public Function InsertValue(nombre As String, lanzamiento As String, desarrollador As String) As Boolean

        Dim oConnection As SqlConnection
        Dim oCommand As SqlCommand
        Dim query As String
        Dim rowsAffected As Integer
        Try
            query = "INSERT INTO gestores_bd VALUES('" & nombre & "'," & lanzamiento & ",'" & desarrollador & "')"
            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString

            'Crear objeto comando
            'oCommand = New SqlCommand
            'oCommand.CommandText = query
            'oCommand.Connection = oConnection

            'Segunda forma de crear objeto comando
            oCommand = New SqlCommand(query, oConnection)
            oConnection.Open()
            rowsAffected = oCommand.ExecuteNonQuery()
            oConnection.Close()

            If rowsAffected > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException

        End Try
    End Function

    ''' <summary>
    ''' Se encarga de insertar valores en la tabla gestores_bd
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="lanzamiento"></param>
    ''' <param name="desarrollador"></param>
    ''' <returns></returns>
    Public Function InsertValueWithParameters(nombre As String, lanzamiento As String, desarrollador As String) As Boolean

        Dim oConnection As SqlConnection
        Dim oCommand As SqlCommand
        Dim query As String
        Dim rowsAffected As Integer
        Try
            query = "INSERT INTO gestores_bd VALUES(@nombre,@lanzamiento,@desarrollador)"

            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString
            'Segunda forma de crear objeto comando
            oCommand = New SqlCommand(query, oConnection)
            'Agregando parámetros
            oCommand.Parameters.Add(New SqlParameter("@nombre", SqlDbType.NVarChar))
            oCommand.Parameters("@nombre").Value = nombre
            oCommand.Parameters.Add(New SqlParameter("@lanzamiento", SqlDbType.Int))
            oCommand.Parameters("@lanzamiento").Value = lanzamiento
            oCommand.Parameters.Add(New SqlParameter("@desarrollador", SqlDbType.NVarChar))
            oCommand.Parameters("@desarrollador").Value = desarrollador

            oConnection.Open()
            rowsAffected = oCommand.ExecuteNonQuery()
            oConnection.Close()

        Catch ex As SqlException

        End Try
        If rowsAffected > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CountRows() As Integer

        Dim oConnection As SqlConnection
        Dim oCommand As SqlCommand
        Dim query As String
        Dim counted As Integer
        Try
            query = "SELECT COUNT(*) FROM gestores_bd"

            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString
            'Segunda forma de crear objeto comando
            oCommand = New SqlCommand(query, oConnection)

            oConnection.Open()
            counted = CInt(oCommand.ExecuteScalar())
            oConnection.Close()

        Catch ex As SqlException

        End Try
        Return counted
    End Function

    Public Function ReadAllRows() As List(Of String)
        Dim rows As List(Of String)
        Dim oConnection As SqlConnection
        Dim oCommand As SqlCommand
        Dim sqlReader As SqlDataReader
        Dim query As String
        Dim register As String

        Try
            rows = New List(Of String)
            query = "SELECT TOP(1000) * FROM gestores_bd;"

            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString
            'Segunda forma de crear objeto comando
            oCommand = New SqlCommand(query, oConnection)

            oConnection.Open()
            'Se realiza el enlace con los registros de la tabla
            sqlReader = oCommand.ExecuteReader()

            While sqlReader.Read() = True
                'register = $"id: {sqlReader.GetInt32(0)} nombre: {sqlReader.GetString(1)} lanzamiento:{sqlReader.GetInt32(2)}
                'desarrollador: {sqlReader.GetString(3)}"
                register = $"id:{sqlReader("id")}  nombre: {sqlReader("nombre")} lanzamiento:{sqlReader("lanzamiento")} 
                desarrollador:{sqlReader("desarrollador")}"
                rows.Add(register)
                'sqlReader.NextResult()
            End While
            sqlReader.Close()
            oConnection.Close()
            Return rows
        Catch ex As SqlException
            Throw
        End Try

    End Function





End Class
