using System;

class Ejercicio_40_1
{
    static void Main()
    {
        Console.WriteLine("Introduce un número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿A partir de qué número buscamos?");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿Hasta qué número buscamos?");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"He encontrado los siguientes múltiplos comunes de ambos números:");

        bool encontrados = false; // Variable para verificar si se encontraron múltiplos comunes

        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            if (i % numero1 == 0 && i % numero2 == 0)
            {
                Console.Write($"{i} ");
                encontrados = true;
            }
        }

        if (!encontrados)
        {
            Console.WriteLine("Ninguno");
        }

        Console.WriteLine(); // Salto de línea al final
    }
}
