
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
    Public Function ReadAllRows() As List(Of GestoresBD)
        Dim rows As List(Of GestoresBD)
        Dim oConnection As SqlConnection
        Dim sqlDataAdapter As SqlDataAdapter
        Dim dataSet As DataSet
        Dim dataTable As DataTable
        Dim row As DataRow
        Dim gestoresBdFields As GestoresBD
        Dim query As String
        Dim register As String

        rows = New List(Of GestoresBD)
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
                gestoresBdFields = New GestoresBD(CInt(row.Item("id")), row.Item("nombre").ToString, CInt(row.Item("lanzamiento")),
                    row.Item("desarrollador").ToString)
                rows.Add(gestoresBdFields)
            Next


        Catch ex As SqlException
            MessageBox.Show("Error" & ex.Message)
        End Try

        Return rows
    End Function

    Public Function InsertRow(name As String, launcher As Integer, developer As String) As Integer
        Dim oConnection As SqlConnection
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As DataSet
        Dim oDataRow As DataRow
        Dim oCommandBuild As SqlCommandBuilder
        Dim rowsModified As Integer
        Dim query As String

        query = "SELECT TOP(1000) * FROM gestores_bd;"
        Try
            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString

            'Crear objeto sqlDataAdapter
            oDataAdapter = New SqlDataAdapter(query, oConnection)

            'Se crea un commando de la clase CommandBuilder que controlará al SqlDataAdapter
            oCommandBuild = New SqlCommandBuilder(oDataAdapter)

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

            rowsModified = RefreshDataBase(oDataAdapter, oDataSet, "gestores_bd")

        Catch ex As SqlException

        End Try
        Return rowsModified
    End Function

    Public Function RowModify(gestoresTable As GestoresBD) As Integer
        Dim oConnection As SqlConnection
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As DataSet
        Dim oCommandBuild As SqlCommandBuilder
        Dim registerList As List(Of GestoresBD)
        Dim dataRow As DataRow
        Dim position As Integer = 0
        Dim query As String

        query = "SELECT TOP(1000) * FROM gestores_bd;"
        Try
            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString

            'Crear objeto sqlDataAdapter
            oDataAdapter = New SqlDataAdapter(query, oConnection)

            'Se crea un commando de la clase CommandBuilder que controlará al SqlDataAdapter
            oCommandBuild = New SqlCommandBuilder(oDataAdapter)

            'Crear el objeto dataSet
            oDataSet = New DataSet()

            oConnection.Open()
            oDataAdapter.Fill(oDataSet, "gestores_bd")
            oConnection.Close()

            registerList = New List(Of GestoresBD)
            registerList = ReadAllRows()

            'Este for busca la posición del registro en la que se encuentra el id solicitado
            For Each row In registerList
                If row.Id = gestoresTable.Id Then
                    'Exit For obliga a salir del For Each aunque no terminé de recorrer la lista
                    Exit For
                End If
                position += 1
            Next

            ''Es necesario crear otro comando para acutalizar
            oDataAdapter.UpdateCommand = New SqlCommand($"UPDATE gestores_bd SET nombre = {gestoresTable.Nombre} " &
            $"WHERE id = {position}", oConnection)

            'Obtenemos la fila de una determinada posición
            dataRow = oDataSet.Tables("gestores_bd").Rows(position)

            dataRow.Item("nombre") = gestoresTable.Nombre
            dataRow.Item("lanzamiento") = gestoresTable.Lanzamiento
            dataRow.Item("desarrollador") = gestoresTable.Desarrollador

            RefreshDataBase(oDataAdapter, oDataSet, "gestores_bd")

        Catch ex As Exception

        End Try
    End Function

    Public Function DeletRow(id As Integer) As Boolean
        Dim oConnection As SqlConnection
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As DataSet
        Dim oCommandBuild As SqlCommandBuilder
        Dim oDataRow As DataRow
        Dim registerList As List(Of GestoresBD)
        Dim oTableDelete As DataTable
        Dim position As Integer = 0
        Dim query As String

        query = "SELECT TOP(1000) * FROM gestores_bd;"
        Try
            'Crear objeto conexión
            oConnection = New SqlConnection()
            oConnection.ConnectionString = _connectionString

            'Crear objeto sqlDataAdapter
            oDataAdapter = New SqlDataAdapter(query, oConnection)

            'Se crea un commando de la clase CommandBuilder que controlará al SqlDataAdapter
            oCommandBuild = New SqlCommandBuilder(oDataAdapter)

            'Crear el objeto dataSet
            oDataSet = New DataSet()

            'Esto abre la conexión
            oConnection.Open()
            oDataAdapter.Fill(oDataSet, "gestores_bd")
            oConnection.Close()

            registerList = New List(Of GestoresBD)
            registerList = ReadAllRows()

            'Este for busca la posición del registro en la que se encuentra el id solicitado
            For Each row In registerList
                If row.Id = id Then
                    'Exit For obliga a salir del For Each aunque no terminé de recorrer la lista
                    Exit For
                End If
                position += 1
            Next

            'Enceuntra la fila a borrar
            oDataRow = oDataSet.Tables("gestores_bd").Rows(position)
            'Borra la fila pero de la tabla locla, es decir la copia
            oDataRow.Delete()
            'Se crea una tabla con los cambios realizados
            oTableDelete = oDataSet.Tables("gestores_bd").GetChanges(DataRowState.Deleted)

            'Se intenta actualizar la tabla de la BBDD original
            oDataAdapter.Update(oTableDelete)
            oDataSet.Tables("gestores_bd").AcceptChanges()

        Catch ex As Exception

        End Try
        Return True
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
