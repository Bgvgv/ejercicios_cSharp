/*
38. Muestra un triángulo decreciente alineado a la izquierda, con letras X, con el tamaño indicado por el usuario, usando "for":
Tamaño? 5

XXXXX

XXXX

XXX

XX

X

*///Boris Garcés Vernier

using System;

class Ejercicio_37
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contador = numero;

        for (int i = 0; i <= numero; i++)
        {
            for (int j = 1; j <= contador; j++)
            {
                Console.Write("X");

            }
            Console.WriteLine();
            contador--;
        }

    }
}