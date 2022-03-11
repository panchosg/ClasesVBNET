Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Boton activado", "Titulo Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnEmegencia_Click(sender As Object, e As EventArgs) Handles btnEmegencia.Click
        MessageBox.Show("Esto es una emergencia, no un simulacro", "¡EMERGENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub
End Class
