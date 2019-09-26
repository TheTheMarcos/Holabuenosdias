Option Strict On
Module Module1

    Sub Main()
        'Ejercicio 4'
        Dim radio As Double
        Console.WriteLine(" Introduzca un numero para radio")
        radio = Convert.ToDouble(Console.ReadLine())
        Dim longitud As Double = 2 * Math.PI * radio
        Dim Area As Double = Math.PI * Math.Pow(radio, 2)
        Dim volumen As Double = 4 / 3 * Math.PI
        Console.WriteLine("La longitud es de " & longitud)
        Console.WriteLine("El Area es de " & Area)
        Console.WriteLine("El volumen es de " & volumen)

        'Ejercicio 6'
        Dim n1 As Double
        Dim n2 As Double
        Console.WriteLine("Introduce un numero")
        n1 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Introduce otro numero")
        n2 = Convert.ToDouble(Console.ReadLine())
        Dim suma As Double = n1 + n2
        Dim resta As Double = n1 - n2
        Dim multi As Double = n1 * n2
        Console.WriteLine("El resultado de la suma es de " & suma)
        Console.WriteLine("El resultado de la resta es de " & resta)
        Console.WriteLine("El resultado de la multiplicacion es de " & multi)

        'Ejercicio 7'
        Dim cel As Double
        Console.WriteLine("Diem que temperatura hace hoy en Celsius")
        cel = Convert.ToDouble(Console.ReadLine())
        Dim far As Double = (5 / 9) * cel + 32
        Console.WriteLine(" Hoy hace " & cel & " grados Celsius que serian " & far & "Fahrenheit")

        'Ejercicio 8'
        Dim v As Double
        Dim n As Double
        Dim p As Double
        Dim r As Double = 0.082
        Dim t As Double
        Console.WriteLine("Dame el volumen")
        v = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Dame los moles")
        n = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine(" Dame al temperatura en Kelvin")
        t = Convert.ToDouble(Console.ReadLine())
        p = (n * r * t) / v
        Console.WriteLine("Con un volumen de " & v & " litros, y una temperatura de " & t & " Kelvin, " & n & " moles de un gas ideal tinen una presion de " & p & " Atmosferas")
        Console.ReadLine()
    End Sub

End Module
