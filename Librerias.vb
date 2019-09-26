Option Strict On
Module Module1

    Sub Main()
        'Libreria uqe contine las principales funciones matematicas '
        'No es necesario importarla'
        'Raiz cuadrada: Math.Sqrt(numero) --> devuelve siempre un dato'
        Dim numero As Integer = 85
        Dim raizcuadrada As Double = Math.Sqrt(numero)

        'Vamos a comprobar el calculo'
        Console.WriteLine("Raiz cuadrada de " & numero & " es de " & raizcuadrada)

        'POtencias: x elevado a y '
        ' Math.Pow (base, exponente) --> Devuelve un Double'
        'Solicitar base y exponente'
        Dim base, exponente As Integer
        Dim potencia As Double
        Console.WriteLine(" Introduzca la base :")
        base = Convert.ToInt32(Console.ReadLine())
        'Lo mismo con el exponente'
        Console.WriteLine(" Introduzca el exponente ")
        exponente = Convert.ToInt32(Console.ReadLine())
        potencia = Math.Pow(base, exponente)
        'Otra forma de calcular es con ^(Shift + Space + Tecla al lado p)'
        potencia = base ^ exponente
        Console.WriteLine(base & " elevado a " & exponente & " = " & potencia)
        'Funciones redondeadas a decimales'
        'Estas funciones no modificasn la variable original'
        'Generan  un nuevo valor con la aproximacion deseada'
        Console.WriteLine("Funciones de redondeo y ajuste de decimales")
        raizcuadrada = Math.Sqrt(13)
        Console.WriteLine(" Raiz cuadrada de 13 es igual" & raizcuadrada)
        'Funcion Matth.Floor(numero)' 
        'Devuelve el numero entero mas cercano por abajo'
        Console.WriteLine("Math.Floor(raizcuadrada)" & Math.Floor(raizcuadrada))
        'Math.Ceiling(numero)'
        'Devuelve el numero entero mas cercano por arriba'
        Console.WriteLine("Math.Ceiling(raizcuadrada)" & Math.Ceiling(raizcuadrada))
        'Math.Round(numero)'
        'Devuelve el numero entero mas cercano'
        Console.WriteLine("Math.Round(raizcuadrada)" & Math.Round(raizcuadrada))
        'La variable raizcuadrada no se vemodificadapor la llamada a las funciones Floor, Ceiling, Round'
        'Ya que estas variables no se ve modificada por la original, simplemente'
        Console.WriteLine("Raiz de 13 = " & raizcuadrada)
        'Esta libreria define 2 constantes: Math.PI y Math.E'
        Console.WriteLine(" PI = " & Math.PI)
        Console.WriteLine(" E = " & Math.E)
        'Podemos definir nuestras propias constantes'
        Const GRAVEDAD As Double = 9.81
        Dim masa As Double = 23
        Dim peso As Double = 80
        Console.ReadLine()
    End Sub

End Module

