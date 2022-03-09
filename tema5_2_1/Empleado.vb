Option Explicit On
Option Strict On
Public Class Empleado
    Public Event EventoLimiteSueldo(sueldo As Double) 'Emisor
    Private pvSueldo As Double
    Public Property Nombre As String
    Public Property Sueldo As Double
        Get
            Return pvSueldo
        End Get
        Set(value As Double)
            If value > 1000 Then
                RaiseEvent EventoLimiteSueldo(value)
            Else
                pvSueldo = value
            End If
        End Set
    End Property
End Class
