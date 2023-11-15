/*
70. Crea un programa en C# que pida al usuario una cadena y 
la muestre encriptada de dos maneras diferentes: primero sumando 
1 a cada carácter, luego con la operación XOR 1.
*///Boris Garcés Vernier

using System;

class E70
{


    static void Main()
    {

        System.Console.WriteLine("Escribe lo que  quieras");
        string frase = Console.ReadLine();

        foreach (char letra in frase)
        {
            System.Console.Write((char)(letra + 1));
        }
        System.Console.WriteLine();//Salto de línea

        foreach (char letra in frase)
        {
            System.Console.Write((char)(letra ^ 1));
        }
        System.Console.WriteLine();//Salto de línea


    }
}