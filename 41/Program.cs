/*
41. Pide al usuario dos números enteros y muestra su división. 
Usa excepciones para comprobar los posibles errores.
*/ //Boris Garcés Vernier
using System;
class E41
{
    static void Main()
    {
        try
        {
            System.Console.WriteLine("Introduce un número");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Introduce un número");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = numero1 / numero2;
            System.Console.WriteLine("Su división es: {0}", resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("No es un número válido");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir entre cero");
        }
    }
}