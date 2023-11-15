/*
50. Depuración: Crea un programa que muestre ciertos 
valores de la función y = x^2 - 6x + 9 
(usando valores enteros para x, en el rango desde -10 a +10).
Añade un punto de interrupción en el momento en que calculas
el valor de "y". Comprueba en cada pasada los valores de "x^2"
y de "6x", además del valor de "y". Deberás entregar una captura
de pantalla (estática) del proceso de depuración.
*/ // Boris Garcés Vernier

using System;
class E50
{
    static void Main()
    {
        System.Console.WriteLine("Introduce un valor entero entre -10 y 10");
        int x = Convert.ToInt32(Console.ReadLine());
        x = 4;
         
        while ((x < -10) || (x > 10))
        {
            if ((x < -10) || (x > 10))
            {
                System.Console.WriteLine("valor fuera de rango");

            }
            System.Console.WriteLine("Introduce un valor entero entre -10 y 10");
            x = Convert.ToInt32(Console.ReadLine());
        }

        int y = x * x - 6 * x + 9;
        Console.WriteLine($"Para x = {x}, y = {y}");

        Console.ReadLine();

    }
}