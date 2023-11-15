/*10. Muestra la tabla de multiplicar del número escogido por el usuario,
 usando las estructuras que consideres más adecuadas... 
 pero sólo de las que conoces por ahora. El programa será MUY repetitivo, 
 pero en el próximo tema veremos cómo hacerlo más eficiente usando "bucles".*/
 
using System;

class Ejercicio_10
{
    static void Main()
    {

        Console.WriteLine("Introduce un número del 1 al 9 sin decimales");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{numero} * 1" + " = " + (numero * 1));
        Console.WriteLine($"{numero} * 2" + " = " + (numero * 2));
        Console.WriteLine($"{numero} * 3" + " = " + (numero * 3));
        Console.WriteLine($"{numero} * 4" + " = " + (numero * 4));
        Console.WriteLine($"{numero} * 5" + " = " + (numero * 5));
        Console.WriteLine($"{numero} * 6" + " = " + (numero * 5));
        Console.WriteLine($"{numero} * 7" + " = " + (numero * 7));
        Console.WriteLine($"{numero} * 8" + " = " + (numero * 8));
        Console.WriteLine($"{numero} * 9" + " = " + (numero * 9));
        Console.WriteLine($"{numero} * 10" + " = " + (numero * 10));
        


    }
}