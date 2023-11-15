/*
27. Crea un programa que muestre los números del 10 al 20, separados por un espacio, sin avanzar de línea, usando "while".
*/ // Boris Garcés Vernier

using System;

class Ejercicio_27
{
    static void Main()
    {
        int numero = 1;

        while (numero <= 20)
        {
            Console.Write(numero + " ");
            numero++;
        }

    }
}