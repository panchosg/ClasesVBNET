Option Explicit On
Option Strict On
Public MustInherit Class Empleado

    Protected pvSalarioMes As Double
    Public Property Nombre As String
    Public Property HorasTrabajadas As TimeSpan
    Public Property Dni As String
    Public Property SalarioHora As Double
    Public ReadOnly Property SalarioMes As Double 'objeto.SalarioMes = value
        Get
            Return pvSalarioMes
        End Get
        'Set(value As Double)
        '    pvSalarioMes = value
        'End Set
    End Property

    Public MustOverride Sub CalculaSalarioMes()

    ''' <summary>
    ''' Constructor del padre Empleado
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="dni"></param>
    ''' <param name="salarioHora"></param>
    Sub New(nombre As String, dni As String, salarioHora As Double, horastrabajadas As TimeSpan)
        Me.Nombre = nombre
        Me.Dni = dni
        Me.SalarioHora = salarioHora
        Me.HorasTrabajadas = horastrabajadas
    End Sub

End Class
