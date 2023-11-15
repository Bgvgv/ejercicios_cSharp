/*
55. Pide al usuario dos números enteros cortos y muestra todos
los números entre ellos, en hexadecimal, en la misma línea,
separados por un espacio. Por ejemplo, si introduce 7 y 12,
deberás mostrar "7 8 9 a b c". El programa se debe
 comportar correctamente si introduce los números en orden contrario,
  es decir, si primero indica 12 y 7 en vez de 7 y 12.
*/ //Boris Garcés Vernier

using System;
class E55
{

    static void Main()
    {

        Console.WriteLine("Número1: ");
        short numero1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Número2: ");
        short numero2 = Convert.ToInt16(Console.ReadLine());
        short nMenor, nMayor;


        if (numero2 < numero1)
        {
            nMenor = numero2;
            nMayor = numero1;
        }
        else
        {
            nMenor = numero1;
            nMayor = numero2;
        }

        for (short i = nMenor; i <= nMayor; i++)
        {
            System.Console.Write("{0} ", i.ToString("x"));
        }


    }
}
