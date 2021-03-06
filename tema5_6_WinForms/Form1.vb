Public Class Form1
    Private vehiculoSelecGlobal As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim datos As DatosFormulariosModelView
        Dim baseDatos As BaseDatos

        datos = New DatosFormulariosModelView
        baseDatos = New BaseDatos

        datos.NombreUsuario = txtUsuario.Text
        datos.Matricula = txtMatricula.Text
        datos.Pieza = cmbPieza.SelectedItem.ToString()
        datos.Cantidad = txtCantidad.Text

        'Desarrollo sin variable global
        'If rdbCamion.Checked = True Then
        '    datos.Vehiculo = "Camión"
        'End If
        'If rdbCoche.Checked = True Then
        '    datos.Vehiculo = "Vehículo"
        'End If
        'If rdbMoto.Checked = True Then
        '    datos.Vehiculo = "Moto"
        'End If
        datos.Vehiculo = vehiculoSelecGlobal

        'Modo de prueba en la consola de visual studio 
        Debug.WriteLine("NombreUsuario:" & datos.NombreUsuario & " Matricula:" & datos.Matricula & " Pieza:" & datos.Pieza &
                        " Cantidad:" & datos.Cantidad & " Vehículo:" & datos.Vehiculo)
        'MessageBox.Show("NombreUsuario:" & datos.NombreUsuario & " Matricula:" & datos.Matricula & " Pieza:" & datos.Pieza &
        '                " Cantidad:" & datos.Cantidad & " Vehículo:" & datos.Vehiculo)

        If datos.DatosCorrectos = True Then
            baseDatos.EscribirBaseDatosForm1(datos)
            MessageBox.Show("Base de datos escrita correctamente", "Operación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Else
            MessageBox.Show("Existen campos vacios, por favor intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub rdbCamion_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCamion.CheckedChanged
        If rdbCamion.Checked = True Then
            cmbPieza.Items.AddRange(New String() {"Motor", "Ruedas", "Techo", "Puertas", "Chasis"})
            vehiculoSelecGlobal = "Camión"
        Else
            cmbPieza.Items.Clear()
        End If

    End Sub

    Private Sub rdbCoche_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCoche.CheckedChanged

        If rdbCoche.Checked = True Then
            cmbPieza.Items.AddRange(New String() {"Motor", "Ruedas", "Techo", "Puertas", "Maletero"})
            vehiculoSelecGlobal = "Coche"
        Else
            cmbPieza.Items.Clear()
        End If

    End Sub

    Private Sub rdbMoto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMoto.CheckedChanged
        If rdbMoto.Checked = True Then
            cmbPieza.Items.AddRange(New String() {"Motor", "Ruedas", "Asiento Conductor"})
            vehiculoSelecGlobal = "Moto"
        Else
            cmbPieza.Items.Clear()
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtCantidad.Clear()
        txtMatricula.Clear()
        txtUsuario.Clear()
        cmbPieza.Items.Clear()
        rdbCamion.Checked = False
        rdbCoche.Checked = False
        rdbMoto.Checked = False
    End Sub
End Class
