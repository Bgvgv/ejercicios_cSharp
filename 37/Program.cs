/*
37. Haz un programa que pida al usuario un alto y un ancho 
y que muestre un rectángulo formado por asteriscos, 
con ese alto y ancho, como en este ejemplo:
Alto? 5
Ancho? 3

***

***

***

***

***

*///Boris Garcés Vernier

using System;

class Ejercicio_37
{
    static void Main()
    {

        Console.WriteLine("Introduce el alto");
        int alto = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el ancho");
        int ancho = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= alto; i++)
        {
            for (int j = 1; j <= ancho; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();// Salto de línea
    }
}
