/*
28. Escribe un programa en C# que pida al usuario un número entero y muestre su tabla de multiplicar, usando "while".
*/ //Boris Garcés Vernier
using System;
class Ejercicio_28
{
    static void Main()
    {
        Console.WriteLine("Escribe un número del 1 al 9");
        int numero = Convert.ToInt32(Console.ReadLine());
        int multiplicador = 1;

        while (multiplicador <= 10)
        {
            Console.WriteLine($"{numero} * {multiplicador} = {numero * multiplicador} ");
            multiplicador++;
        };
    }
}