/*
25. Escribe un programa en C# que pida al usuario una contraseña numérica. 
Se le dirá "Acceso concedido" cuando acierte la contraseña correcta, 1111.
 Si no la acierta, se le volverá a pedir tantas veces como sea necesario. 
 Hazlo con "while" (no con "do-while"). */
//Boris Garcés Vernier

using System;
class Ejercicio_25
{
    static void Main()
    {


        Console.WriteLine("Introduce una contraseña");
        int contrasena = Convert.ToInt32(Console.ReadLine());

        while (contrasena != 1111)

        {
            Console.WriteLine("Introduce una contraseña");
            contrasena = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Contraseña Correcta");



    }
}