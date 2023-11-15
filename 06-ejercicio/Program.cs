// 6. Crea un programa que pida al usuario 2 números y muestre su producto.
using System;
class Ejercicio_06
{
    static void Main()
    {

        Console.WriteLine("Introduce un valor");
        int valor1 = Convert.ToInt32(Console.ReadLine()); ;

        Console.WriteLine("Introduce un segundo valor");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(valor1 + " * " + valor2 + " = " + valor1 * valor2);


    }
}
