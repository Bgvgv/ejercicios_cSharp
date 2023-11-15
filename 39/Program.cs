/*
39. Escribe un programa que le pida al usuario dos números a y b, 
así como un límite inferior y un límite superior, y muestre todos 
los números entre ambos límites (incluidos) que sean a la vez múltiplos 
de a y de b, como en este ejemplo:

Introduce un número: 2

Introduce otro número: 5

¿A partir de qué número buscamos? 10

¿Hasta qué número buscamos? 30

He encontrado los siguientes múltiplos comunes de ambos números: 10 20 30

*///Boris Garcés Vernier

using System;

class Ejercicio_39
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Límite inferior");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Límite superior");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        int num1, num2, limInf, limSup;


        if ((numero1 > numero2) || (limiteInferior > limiteSuperior))
        {
            num1 = numero2;
            num2 = numero1;
            limInf = limiteSuperior;
            limSup = limiteInferior;

        }
        else
        {
            num1 = numero1;
            num2 = numero2;
            limInf = limiteInferior;
            limSup = limiteSuperior;
        }

        Console.Write($"{num1} {num2} ");
        Console.WriteLine($"{limInf} {limSup} ");

        for (int i = limInf; i <= limSup; i++)
        {

            if ((i % num1 == 0) && (i % num2 == 0))
            {
                System.Console.Write($"{i} ");

            }

        }

        Console.WriteLine();//Salto de línea.





    }
}