Option Strict On
Module Module1

    Sub Main()
        'Operador es un simbolo que realiza accion'
        '+ (suma), - (Resta), * (multiplicacon), / (division), '
        'Mod (Resto divison entera)'
        Dim x As Integer = 4 + 5
        Dim y As Integer = x + 10

        'Operador Division: Devuelve Double'
        'Si quiero almacenar el resultado en un Integer'
        'Tengo que realizar una conversion explicita de Double a Integer'
        'Dim resultado As Integer = Convert.ToInt32( x / 7)'
        Dim resultado As Double = x / 7
        Console.WriteLine("Resultado: " & resultado)

        'Byte --> Short'
        Dim b1 As Byte = 10
        Dim s2 As Short = b1

        'Prohibido b1 = s2, la debo forzar'
        b1 = Convert.ToByte(s2)

        'Short --> Integer'
        Dim entero As Integer = s2
        s2 = Convert.ToInt16(entero)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" S2 = " & s2)

        'Integer --> Long'
        Dim enterolargo As Long = entero
        entero = Convert.ToInt32(enterolargo)

        'Single --> Double'
        Dim decimalsimple As Single = 5.6
        Dim decimaldouble As Double = decimalsimple
        decimalsimple = Convert.ToSingle(decimaldouble)
        Console.ReadLine()
    End Sub

End Module
