Imports System.Data.SqlClient

Public Class Form1
    Private _oDataAdapter As SqlDataAdapter
    Private _oDataSet As DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oConnection As SqlConnection
        Dim oCommandBuilder As SqlCommandBuilder
        Dim connectionString As String

        connectionString = "server=DESKTOP-RSPABI0;database=prueba;uid=fernando;pwd=050584"

        oConnection = New SqlConnection()
        oConnection.ConnectionString = connectionString

        _oDataAdapter = New SqlDataAdapter("SELECT * FROM gestores_bd", oConnection)
        oCommandBuilder = New SqlCommandBuilder(_oDataAdapter)

        _oDataSet = New DataSet()
        _oDataAdapter.Fill(_oDataSet, "gestores_bd")

        'Esto almacena en el datagrid todas las tablas de la BD
        dtViewMaster.DataSource = _oDataSet
        'Esto selecciona solamente una de esas tabla
        dtViewMaster.DataMember = "gestores_bd"

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        _oDataAdapter.Update(_oDataSet, "gestores_bd")
    End Sub
End Class
