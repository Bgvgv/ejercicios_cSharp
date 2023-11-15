/*
42. Muestra un triángulo creciente, formado por "almohadillas" (#), 
alineado a la derecha, con el tamaño indicado por el usuario, usando "for":

Tamaño? 5
    #
   ##
  ###
 ####
#####
*/ //Boris Garcés Vernier

using System;
class E42
{
    static void Main()
    {

        System.Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        int numeroIn = numero - 1;

        for (int i = 0; i < numero; i++)
        {

            for (int j = 0; j < numeroIn; j++)
            {
                System.Console.Write(" ");
            }
            for (int h = numeroIn; h < numero; h++)
            {
                System.Console.Write("#");

            }

            numeroIn--;
            System.Console.WriteLine();
        }

    }
}
