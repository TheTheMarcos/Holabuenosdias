Option Strict On
Module Module1

    Sub Main()
        Dim edad As Byte
        Dim nombre As String
        'Para leer por teclado seguimos los siguientes pasos'
        '1) Mostrar mensaje solicitando el dato'
        Console.WriteLine("Introduzca su edad ")
        '2) Guardar el dato introducido en una variable'
        '3) Convertir String al tipo necesario'
        edad = Convert.ToByte(Console.ReadLine())
        'Solicitar Nombre'
        Console.WriteLine("Dime tu nombre ")
        '2) Asigna valor a la variable nombre '
        nombre = Console.ReadLine()
        Console.WriteLine("Te llamas " & nombre & " y tienes " & edad & " años")
        Console.WriteLine("Tienes " & edad & " años")
        Console.ReadLine()
    End Sub

End Module
