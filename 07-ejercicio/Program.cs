/*7. Crea un programa que pida al usuario 2 números y el resultado de dividir
 el primero entre el segundo, así como el resto de esa división.*/
using System;
class Ejercicio_07
{
    static void Main()
    {

        Console.WriteLine("Introduce un valor");
        int valor1 = Convert.ToInt32(Console.ReadLine()); ;

        Console.WriteLine("Introduce un segundo valor");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(valor1 + " / " + valor2 + " = " + valor1 / valor2);
        Console.WriteLine("Resto: " + valor1 % valor2);


    }
}
