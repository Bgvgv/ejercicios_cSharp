/*
56. Pide al usuario un número entero largo y respóndele cuántas cifras tiene.
Lo puedes conseguir dividiendo entre 10 tantas veces como sea necesaria
 hasta que el número se convierta en 0.
*/ //Boris Garcés Vernier

using System;
class E56
{
    static void Main()
    {

        //18446744073709551615

        try
        {
            int contador = 0;
            Console.WriteLine("Añade un número de más de 10 cifras");
            long numero = Convert.ToInt64(Console.ReadLine());


            if ((numero < -9223372036854775808) || (numero > 9223372036854775807))
            {
                System.Console.WriteLine("No valido");
            }
            else
            {
                while (numero != 0)
                {
                    numero = numero / 10;
                    contador++;
                }
                System.Console.WriteLine(contador);
            }

        }
        catch (OverflowException)
        {
            Console.WriteLine("Número no válido");
        }


    }
}