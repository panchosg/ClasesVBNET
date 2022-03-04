Option Explicit On
Option Strict On

Public Class Becario : Inherits Empleado

    ''' <summary>
    ''' Calcula salario mes del becario
    ''' </summary>
    Public Overrides Sub CalculaSalarioMes()
        pvSalarioMes = SalarioHora * HorasTrabajadas.Hours
    End Sub
    ''' <summary>
    ''' COnstructor de la clase hija
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="dni"></param>
    ''' <param name="salarioHora"></param>
    Sub New(nombre As String, dni As String, salarioHora As Double, horasTrabajadas As TimeSpan)
        MyBase.New(nombre, dni, salarioHora, horasTrabajadas)
    End Sub
End Class
