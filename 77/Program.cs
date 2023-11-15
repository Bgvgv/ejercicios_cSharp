/*
77. Crea un programa que pregunte al usuario cuántos datos (enteros largos) va a introducir,
reserve espacio para todos ellos, se los pida al usuario y finamente muestre los números que
estén duplicados. Por ejemplo, si los números son 12 23 36 23 45, la respuesta sería "Duplicados: 23". 
Si no hubiera ningún duplicado, la respuesta deberá ser "Duplicados: Ninguno". Si algún dato aparece más de dos veces 
(por ejemplo, 12 23 36 23 45 23) puede que la respuesta sea "fea": "Duplicados: 23 23", pero eso no debe preocuparte.
*/

using System;
class E77
{
    static void Main()
    {

        Console.WriteLine("Cuantos números vas a introducir");
        int datosAIntroducir = Convert.ToInt32(Console.ReadLine());

        long[] arrayNumeros = new long[datosAIntroducir];

        for (int i = 0; i < datosAIntroducir; i++)
        {
            Console.Write("Numero {0}: ", i + 1);
            long numero = Convert.ToInt64(Console.ReadLine());
            arrayNumeros[i] = numero;
        }

        for (int i = 0; i < arrayNumeros.Length; i++)
        {

            Console.Write(arrayNumeros[i] + ", ");

        }

        System.Console.WriteLine();//Salto de línea

        
        for (int i = 0; i < arrayNumeros.Length - 1; i++)
        {
            for (long j = 1; j < arrayNumeros.Length - 1; j++)
            {
                if (arrayNumeros[i] == arrayNumeros[j])
                {
                    System.Console.WriteLine(arrayNumeros[i]);
                }
            }
        }


    }
}