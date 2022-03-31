Public Class Form1
    Private _dbAccess As DataAccessClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        _dbAccess = New DataAccessClient("DESKTOP-RSPABI0", "prueba", "fernando", "050584")
    End Sub
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        lstShowRegisters.DataSource = _dbAccess.ReadAllRows()
    End Sub


End Class
