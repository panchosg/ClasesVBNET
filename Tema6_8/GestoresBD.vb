Public Class GestoresBD

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Lanzamiento As Integer
    Public Property Desarrollador As String

    ''' <summary>
    ''' Constructor de los campos de la tabla gestores_bd
    ''' </summary>
    Sub New(id As Integer, nombre As String, lanzamiento As Integer, desarrollador As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Lanzamiento = lanzamiento
        Me.Desarrollador = desarrollador
    End Sub
    ''' <summary>
    ''' Este método sobrecribe la función original de Convertir a cedena de texto
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return $"Id={Id} Nombre={Nombre} Lanzamiento={Lanzamiento} Desarrollador={Desarrollador}"
    End Function

End Class
