Option Explicit On
Option Strict On

Module Program
    '2. Receptor eventos dinámicos
    Sub Main(args As String())
        'Un programa que muestra cuando un empleado se le abona más de 1000 euros de sueldo
        Dim receptorEmpleado = New Empleado()

        AddHandler receptorEmpleado.EventoLimiteSueldo, AddressOf ReceptorEmpleado_LimiteSueldo
        'Simulando los datos
        receptorEmpleado.Nombre = "Fernando"
        receptorEmpleado.Sueldo = 900

        receptorEmpleado.Nombre = "Sairam"
        receptorEmpleado.Sueldo = 1200

        receptorEmpleado.Nombre = "José"
        receptorEmpleado.Sueldo = 500

        receptorEmpleado.Nombre = "Ale"
        receptorEmpleado.Sueldo = 1660

    End Sub

    '1.2 Declara función enlazada a evento
    'Public Sub ReceptorEmpleado_LimiteSueldo(sueldo As Double)
    '    Console.WriteLine("la persona ha recibido más de los estipulado: " & sueldo)
    '    Console.WriteLine("El importe no es válido")
    'End Sub

    Public Sub ReceptorEmpleado_LimiteSueldo(empleado As Empleado, emplArgs As EmpleArgs)
        Console.WriteLine("la persona" & empleado.Nombre & " ha recibido más de los estipulado: " & emplArgs.SueldoIntentadoAsig)
        Console.WriteLine("El importe no es válido")
    End Sub



End Module
