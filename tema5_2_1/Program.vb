Option Explicit On
Option Strict On

Module Program
    '1. Receptor eventos est�ticos
    '1.1 Declarar variable receptora
    Private WithEvents receptorEmpleado As Empleado 'receptor


    Sub Main(args As String())
        'Un programa que muestra cuando un empleado se le abona m�s de 1000 euros de sueldo
        receptorEmpleado = New Empleado()

        'Simulando los datos
        receptorEmpleado.Nombre = "Fernando"
        receptorEmpleado.Sueldo = 900

        receptorEmpleado.Nombre = "Sairam"
        receptorEmpleado.Sueldo = 1200

        receptorEmpleado.Nombre = "Jos�"
        receptorEmpleado.Sueldo = 500

        receptorEmpleado.Nombre = "Ale"
        receptorEmpleado.Sueldo = 1660

    End Sub

    '1.2 Declara funci�n enlazada a evento
    Public Sub ReceptorEmpleado_LimiteSueldo(sueldo As Double) Handles ReceptorEmpleado.EventoLimiteSueldo
        Console.WriteLine("la persona " & receptorEmpleado.Nombre & " ha recibido m�s de los estipulado: " & sueldo)
        Console.WriteLine("El importe no es v�lido")
    End Sub



End Module
