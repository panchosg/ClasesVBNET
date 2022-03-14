Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim datos As DatosFormulariosModelView
        datos = New DatosFormulariosModelView

        datos.NombreUsuario = txtUsuario.Text
        datos.Matricula = txtMatricula.Text
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
