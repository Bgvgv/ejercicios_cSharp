/*
36. Crea un programa que pida al usuario dos números enteros 
y muestre su producto, empleando sumas repetitivas. 
Recuerda que 3 * 4 = 3 + 3 + 3 + 3 (4 sumandos) = 12.
*///Boris Garcés Vernier

using System;

class Ejercicio_36
{
    static void Main()
    {

        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int num1;
        int num2;

        if (numero1 > numero2)
        {
            num1 = numero2;
            num2 = numero1;
        }
        else
        {
            num1 = numero1;
            num2 = numero2;
        }

        Console.Write($"{num1} * {num2} = ");

        for (int i = 1; i <= num2; i++)
        {
            Console.Write(num1);
            if(i<num2){
                Console.Write(" + ");
            }
        }
        Console.Write($" ({num2} Sumandos) = {num1 * num2}.");
        Console.WriteLine();// Salto de línea

    }
}
