Public Class DatosFormulariosModelView
    Public Property NombreUsuario As String
    Public Property Matricula As String
    Public Property Pieza As String
    Public Property Cantidad As String
    Public Property Vehiculo As String
    ''' <summary>
    ''' Verifica que todas las propiedades tengan valores
    ''' </summary>
    ''' <returns>True si tienen datos, False si falta alguna</returns>
    Public Function DatosCorrectos() As Boolean
        Dim esCorrecto As Boolean
        'NombreUsuario="Fernando", Matricular="429804t", Pieza="3" 
        esCorrecto = Not String.IsNullOrEmpty(NombreUsuario) And Not String.IsNullOrEmpty(Matricula) And Not String.IsNullOrEmpty(Pieza) _
        And Not String.IsNullOrEmpty(Cantidad) And Not String.IsNullOrEmpty(Vehiculo)

        Return esCorrecto
    End Function

End Class
