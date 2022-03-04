Public Class Ingeniero : Inherits Empleado

    ''' <summary>
    ''' Calcula salario mes del Ingeniero
    ''' </summary>
    Public Overrides Sub CalculaSalarioMes()
        pvSalarioMes = SalarioHora * (HorasTrabajadas.TotalHours + 3)
    End Sub
    ''' <summary>
    ''' Constructor de la clase hija Ingeniero
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="dni"></param>
    ''' <param name="salarioHora"></param>
    ''' <param name="horasTrabajadas"></param>
    Sub New(nombre As String, dni As String, salarioHora As Double, horasTrabajadas As TimeSpan)
        MyBase.New(nombre, dni, salarioHora, horasTrabajadas)
    End Sub
End Class
