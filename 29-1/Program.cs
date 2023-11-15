/*29. Crea una versión mejorada del ejercicio de la contraseña numérica, 
en la que se pida al usuario tanto su login (que será el número 1000) 
como su contraseña (que será 1234). No se le permitirá seguir hasta 
que introduce ambos datos correctos. Esta versión hazla sólo una vez, 
empleando "while" o "do-while", como consideres más razonable.*/ 
//Boris Garcés Vernier

using System;
class Ejercicio_29_1
{
    static void Main()
    {
        int id1, id2;

        Console.WriteLine("Primera contraseña");
        id1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Segunda contraseña ");
        id2 = Convert.ToInt32(Console.ReadLine());
        if ((id1 != 1000) || (id2 != 1234))
        {
            System.Console.WriteLine("Contraseñas incorrectas prueba otra vez");
        }

        while ((id1 != 1000) || (id2 != 1234))
        {
            Console.WriteLine("Primera contraseña");
            id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segunda contraseña ");
            id2 = Convert.ToInt32(Console.ReadLine());

            if ((id1 != 1000) || (id2 != 1234))
            {
                System.Console.WriteLine("Contraseñas incorrectas prueba otra vez");
            }


        };

        Console.WriteLine("Contraseñas correctas");
    }
}