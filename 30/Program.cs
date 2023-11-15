/*
30. Crea una versión mejorada del ejercicio anterior, 
en la que el usuario sólo tenga 3 intentos. 
Si al cabo de 3 intentos no ha indicado el login y la contraseña correctos, 
se le responderá con "Acceso denegado" y terminará el programa. Si introduce 
ambos datos de forma correcta en 3 intentos o menos, se le dirá "Acceso concedido" 
y terminará el programa. Esta versión hazla sólo una vez, empleando "while" o "do-while", 
como consideres más razonable.
*/ // Boris Garcés Vernier

using System;

class Ejercicio_30
{
    static void Main()
    {
        int id1, id2, intentos = 0;

        do
        {
            Console.WriteLine("Ingresa la primera contraseña:");
            id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la segunda contraseña:");
            id2 = Convert.ToInt32(Console.ReadLine());

            intentos++;

            if ((id1 != 1000 || id2 != 1234) && (intentos < 3))
            {
                Console.WriteLine("Contraseñas incorrectas. Intenta de nuevo.");
            }

        } while ((id1 != 1000 || id2 != 1234) && (intentos < 3));

        if (id1 == 1000 && id2 == 1234)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso denegado.");
        }
    }
}
