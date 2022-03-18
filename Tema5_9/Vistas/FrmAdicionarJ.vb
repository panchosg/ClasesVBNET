Public Class FrmAdicionarJ
    Private jugador As Jugador

    Private Sub FrmAdicionarJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TituloFormulario.Text = "Adición de jugadores"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDorsal.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim esCorrecto As Boolean
        Dim todoEstaOK As Boolean
        Dim resultadoDorsal As Integer
        Dim resultadoSueldo As Double


        todoEstaOK = True

        jugador = New Jugador
        jugador.Nombre = txtNombre.Text
        esCorrecto = Integer.TryParse(txtDorsal.Text, resultadoDorsal)
        'Valida que sea correcto el dorsal
        If esCorrecto Then
            jugador.Dorsal = resultadoDorsal
        Else
            MessageBox.Show("Error en dorsal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            todoEstaOK = False
        End If

        'Valida que sea correcto el sueldo
        esCorrecto = Double.TryParse(txtSueldo.Text, resultadoSueldo)

        If esCorrecto Then
            jugador.Sueldo = resultadoSueldo
        Else
            MessageBox.Show("Error en sueldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            todoEstaOK = False
        End If
        jugador.LicenciaEnVigor = chkLicenciaEnVigor.Checked

        If todoEstaOK = True Then
            GuardarEnBBDD(jugador)

            'Limpieza Formulario
            txtDorsal.Clear()
            txtNombre.Clear()
            txtSueldo.Clear()
            chkLicenciaEnVigor.Checked = False
        End If



    End Sub

    Private Sub GuardarEnBBDD(jugador As Jugador)
        Dim resultado As String
        resultado = "El jugador " & jugador.Nombre & "fue adicionado con éxito"
        MessageBox.Show(resultado)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class