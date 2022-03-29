Imports System.Data.SqlClient

Public Class Form1
    Private _dbAccess As DataAccessClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        _dbAccess = New DataAccessClient("DESKTOP-RSPABI0", "prueba", "fernando", "050584")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim isOK As Boolean

        isOK = _dbAccess.ConnectionTest()
        If (isOK = True) Then
            MessageBox.Show("La conexíon fué exitosa")
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim isOK As Boolean

        Try
            'isOK = dbAccess.InsertValue(txtName.Text, txtDate.Text, txtDevelopers.Text)
            isOK = _dbAccess.InsertValueWithParameters(txtName.Text, txtDate.Text, txtDevelopers.Text)

        Catch ex As SqlException

        End Try
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        Dim counted As Integer

        Try
            'isOK = dbAccess.InsertValue(txtName.Text, txtDate.Text, txtDevelopers.Text)
            counted = _dbAccess.CountRows()
            MessageBox.Show("Número de filas = " & counted)

        Catch ex As SqlException

        End Try
    End Sub

End Class
