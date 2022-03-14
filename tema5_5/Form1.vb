Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Boton activado", "Titulo Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnEmegencia_Click(sender As Object, e As EventArgs) Handles btnEmergencia.Click
        MessageBox.Show("Esto es una emergencia, no un simulacro", "¡EMERGENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub

    'Private Sub btnEmegencia_MouseEnter(sender As Object, e As EventArgs)
    '    MessageBox.Show("¿está seguro de lo que hace?", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'End Sub

    Private Sub btnEmergencia_MouseHover(sender As Object, e As EventArgs) Handles btnEmergencia.MouseHover
        MessageBox.Show("Mouse quieto")
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.Blue

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuestaUsuario As Boolean
        respuestaUsuario = MessageBox.Show("Se va a cerrar el formulario", "¡EMERGENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        If respuestaUsuario = True Then
            MessageBox.Show("Cerrando aplicación")
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
