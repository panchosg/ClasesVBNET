
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
    ''' Lectura de tabla en modo desconectado
    ''' </summary>
    ''' <returns></returns>
    Public Function ReadAllRows() As List(Of String)
        Dim rows As List(Of String)
        Dim oConnection As SqlConnection
        Dim sqlDataAdapter As SqlDataAdapter
        Dim dataSet As DataSet
        Dim dataTable As DataTable
        Dim row As DataRow
        Dim query As String
        Dim register As String

        rows = New List(Of String)
        Try

            query = "SELECT TOP(1000) * FROM gestores_bd;"

            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString

            'Crear objeto sqlDataAdapter
            sqlDataAdapter = New SqlDataAdapter(query, oConnection)

            'Crear el objeto dataSet
            dataSet = New DataSet()

            oConnection.Open()
            sqlDataAdapter.Fill(dataSet, "gestores_bd")
            oConnection.Close()

            'Acceder a la tabla almacenada
            dataTable = dataSet.Tables("gestores_bd")

            For Each row In dataTable.Rows
                register = $"id:{row.Item("id")}  nombre: {row.Item("nombre")} lanzamiento:{row.Item("lanzamiento")} 
                desarrollador:{row.Item("desarrollador")}"
                rows.Add(register)
            Next


        Catch ex As SqlException
            MessageBox.Show("Error" & ex.Message)
        End Try

        Return rows
    End Function

    Public Function InsertRow(name As String, launcher As Integer, developer As String) As Boolean
        Dim oConnection As SqlConnection
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As DataSet
        Dim oDataRow As DataRow
        Dim query As String

        query = "SELECT TOP(1000) * FROM gestores_bd;"
        Try
            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString

            'Crear objeto sqlDataAdapter
            oDataAdapter = New SqlDataAdapter(query, oConnection)

            'Crear el objeto dataSet
            oDataSet = New DataSet()

            oConnection.Open()
            oDataAdapter.Fill(oDataSet, "gestores_bd")
            oConnection.Close()

            'NewRow prepara la tabla para insertar una nueva fila
            oDataRow = oDataSet.Tables("gestores_bd").NewRow

            oDataRow("nombre") = name
            oDataRow("lanzamiento") = launcher
            oDataRow("desarrollador") = developer

            'Para añadir la fila a la coleccióin de registros de la tabla se usa add
            oDataSet.Tables("gestores_bd").Rows.Add(oDataRow)

            RefreshDataBase(oDataAdapter, oDataSet, "gestores_bd")

        Catch ex As SqlException

        End Try
    End Function
    ''' <summary>
    ''' Indicar al sistema que realice las modificaciones locales en la base de datos real
    ''' </summary>
    ''' <param name="oDataAdapter"></param>
    ''' <param name="oDataSet"></param>
    ''' <param name="nameOfTable"></param>
    ''' <returns></returns>
    Public Function RefreshDataBase(oDataAdapter As SqlDataAdapter, oDataSet As DataSet, nameOfTable As String) As Integer
        Dim rowsModify As Integer

        Try
            rowsModify = oDataAdapter.Update(oDataSet, nameOfTable)
        Catch ex As Exception
            Throw
        End Try
        Return rowsModify

    End Function




End Class
