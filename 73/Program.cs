/*

73. Pide al usuario 10 enteros cortos sin signo y guárdalos en un array.
 Luego pide uno más y dile si estaba entre esos 10 datos iniciales,
de 2 formas distintas: primero usando un booleano y luego usando
un contador, para, en la segunda ocasión, responderle cuántas
veces aparecía (ambas respuestas serán parte del mismo programa,
no dos programas independientes).

*/ // Boris Garcés Vernier

using System;
class E73
{
    static void Main()
    {

        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Escibe un número");
            int numero = Convert.ToInt32(Console.ReadLine());

            numeros[i] = numero;

        }

        for (int i = 0; i <= numeros.Length - 1; i++)
        {
            System.Console.Write(numeros[i] + " ");
        }

        Console.WriteLine();// Salto de línea

        Console.Write("escribe otro número: ");
        int nuevoNumero = Convert.ToInt32(Console.ReadLine());

        bool existencia = false;
        foreach (int num in numeros)
        {
            if (num == nuevoNumero)
            {
                existencia = true;
            }
        }
        if (existencia)
        {
            System.Console.WriteLine("El número {0} se encuentra dentro del array", nuevoNumero);
        }
        else
        {
            System.Console.WriteLine("El número {0} no se encuentra dentro del array", nuevoNumero);
        }

        int contador = 0;
        foreach (int num in numeros)
        {
            if (num == nuevoNumero)
            {
                contador++;
            }

        }

        if (contador > 1)
        {
            System.Console.WriteLine("El número {0} aparece {1} vez en el array", nuevoNumero, contador);
        }
        else
        {
            System.Console.WriteLine("El número {0} aparece {1} vez en el array", nuevoNumero, contador);
        }

    }
}