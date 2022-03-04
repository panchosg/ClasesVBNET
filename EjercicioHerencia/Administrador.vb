Public Class Administrador : Inherits Empleado
    ''' <summary>
    ''' Calcula salario mes del Administrador
    ''' </summary>
    Public Overrides Sub CalculaSalarioMes()
        pvSalarioMes = SalarioHora * (HorasTrabajadas.TotalHours + 1)
    End Sub
    ''' <summary>
    ''' Constructor de la clase hija Becario
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="dni"></param>
    ''' <param name="salarioHora"></param>
    ''' <param name="horasTrabajadas"></param>
    Sub New(nombre As String, dni As String, salarioHora As Double, horasTrabajadas As TimeSpan)
        MyBase.New(nombre, dni, salarioHora, horasTrabajadas)
    End Sub
End Class
