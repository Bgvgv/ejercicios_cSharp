using System;

class Program
{
    static void Main()
    {
        // Solicitar un número real al usuario
        Console.Write("Por favor, ingresa un número real: ");
        float numero = float.Parse(Console.ReadLine());

        // Inicializar la aproximación de la raíz cúbica
        float aproximacion = 0;

        // Definir el tamaño de incremento para tanteo
        float incremento = 0.1f;

        // Realizar el tanteo
        while (Math.Pow(aproximacion, 3) < numero)
        {
            aproximacion += incremento;
        }

        // Aproximación de la raíz cúbica con una cifra decimal
        float raizCubicaAproximada = (float)Math.Round(aproximacion, 1);

        // Imprimir el resultado
        Console.WriteLine($"La raíz cúbica aproximada de {numero} es {raizCubicaAproximada}");
    }
}
