Option Explicit On
Option Strict On
Public MustInherit Class Impresora
    Public Property Hojas As List(Of Hoja)

    ''' <summary>
    ''' Calcula el promedio de la calidad de la impresora a través de las hojas
    ''' </summary>
    ''' <returns></returns>
    Public Function CalculaCalidad() As Double
        Dim cantidadHojas As Integer = 0
        Dim totalCalidadHojas As Integer = 0

        cantidadHojas = Hojas.Count()
        For Each hoja In Hojas
            totalCalidadHojas = totalCalidadHojas + hoja.Calidad
        Next
        Return totalCalidadHojas / cantidadHojas
    End Function
    ''' <summary>
    ''' obligo a que tiene que existir en cada hija la función, pero cada hija debe implementar su propio código
    ''' </summary>
    ''' <returns></returns>
    Public MustOverride Sub Imprimir()



End Class
