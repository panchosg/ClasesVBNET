Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbAccess As DataAccessClient
        Dim isOK As Boolean
        dbAccess = New DataAccessClient("DESKTOP-RSPABI0", "prueba", "fernando", "050584")
        isOK = dbAccess.ConnectionTest()
        If (isOK = True) Then
            MessageBox.Show("La conexíon fué exitosa")
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim dbAccess As DataAccessClient
        Dim isOK As Boolean

        Try
            dbAccess = New DataAccessClient("DESKTOP-RSPABI0", "prueba", "fernando", "050584")
            isOK = dbAccess.InsertValue(txtName.Text, txtDate.Text, txtDevelopers.Text)
        Catch ex As SqlException

        End Try
    End Sub
End Class
