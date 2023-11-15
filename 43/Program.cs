/*
43. Muestra un triángulo creciente, centrado, 
formado por asteriscos, con la altura indicada por el usuario, 
y comprobando errores con "try-catch":

Altura? 5
    *
   ***
  *****
 *******
*********
*///Boris Garcés Vernier

using System;
class E43
{
    static void Main()
    {

        try
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
                    System.Console.Write("*");
                }
                for (int h = numeroIn; h < numero - 1; h++)
                {
                    System.Console.Write("*");
                }
                numeroIn--;
                System.Console.WriteLine("");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("No es un número válido");
        }

    }
}