Option Explicit On
Option Strict On
Public Class Empleado
    Public Event EventoLimiteSueldo(sender As Empleado, e As EmpleArgs) 'Emisor
    Private pvSueldo As Double
    Public Property Nombre As String
    Public Property Sueldo As Double
        Get
            Return pvSueldo
        End Get
        Set(value As Double)
            If value > 1000 Then
                Dim empleArgs As EmpleArgs
                empleArgs = New EmpleArgs()
                empleArgs.SueldoIntentadoAsig = value
                empleArgs.MensajeRRHH = "La jefa de personal debe ser despedida"
                RaiseEvent EventoLimiteSueldo(Me, empleArgs)
            Else
                pvSueldo = value
            End If
        End Set
    End Property
End Class
