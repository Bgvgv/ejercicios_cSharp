/*
24. Haz un programa que diga al usuario "Introduce un número negativo",
 y se lo pida tantas veces como sea necesario, repitiendo en caso de que introduzca un número no válido.
 */ //Boris Garcés Vernier

using System;
class Ejercicio_24
{
    static void Main()
    {

        Console.WriteLine("Introduce un número negativo");
        int numNegativo = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine("Introduce un número negativo");
            numNegativo = Convert.ToInt32(Console.ReadLine());
        } while (numNegativo >= 0);
        
        Console.WriteLine($"{numNegativo} es un número correcto");



    }
}