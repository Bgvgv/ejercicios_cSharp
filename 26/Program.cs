/*26. Crea una variante del ejercicio anterior (contraseña numérica), empleando en esta ocasión "do-while" (no "while").*/
//Boris Garcés Vernier

using System;
class Ejercicio_26
{
    static void Main()
    {



        Console.WriteLine("Introduce una contraseña");
        int contrasena = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Introduce una contraseña");
            contrasena = Convert.ToInt32(Console.ReadLine());
        } while (contrasena != 1111);

        Console.WriteLine("Contraseña Correcta");

    }
}