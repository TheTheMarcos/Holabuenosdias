Module Module1

    Sub Main()
        'Declarar Variables'
        Dim p As Short = 29
        Dim u As Byte = 5
        Dim pf As Short = p * u
        Console.WriteLine("El Precio Final es de " & pf)
        'Rebaja'
        Dim r As Single = (pf * 15) / 100
        Console.WriteLine("El Precio Final con descuento aplicado es de " & (pf - r))
        Console.ReadLine()
    End Sub

End Module
