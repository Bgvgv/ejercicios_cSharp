/*
Crea un programa que pida al usuario números enteros, hasta que introduzca 
un número negativo o 0. Cuando esto ocurra, terminará el programa mostrando 
un mensaje que indique la cantidad de números que hemos consultado y 
un mensaje de despedida.
Cada vez que se introduzca un número, se mostrará la lista de los divisores
 de ese número, así como la cantidad de divisores que se han encontrado. 
 En caso de que sea primo, el segundo mensaje será "Este número es primo" 
 ya que solamente tiene 2 divisores (el 1 y el propio número)
Es decir, la ejecución DEBERÁ SEGUIR el siguiente ejemplo:

Introduce un número: 12
Los divisores del 12 son: 1 2 3 4 6 12
El número 12 tiene 6 divisores.


Introduce un número: 5
Los divisores del 5 son: 1 5
El número 5 es primo.


Introduce un número: 0
El programa ha realizado 2 búsquedas de divisores. 
Hasta pronto.
*/
// Boris Garcés Vernier


using System;
class EN_tema2
{
    static void Main()
    {

        int contador = 0;
        int busquedas = 0;
        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        while (numero != 0)
        {
            contador = 0;
            busquedas++;
            Console.Write($"Los divisores de {numero} son: ");

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.Write($"{i} ");

                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }
            }

            Console.WriteLine();

            if (contador == 2)
            {
                Console.WriteLine($"El número {numero} es primo");
            }
            else
            {
                Console.WriteLine($"El número {numero} tiene {contador} divisores");
            }

            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine($"El programa ha realizado {busquedas} búsquedas de divisores. ");
                Console.WriteLine("Hasta pronto.");
            }
        }
    }
}