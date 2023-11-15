/*
57. Partiendo de la idea del ejercicio 45
y empleando números reales, vamos a tantear raíces cúbicas:
Pide un número real al usuario y calcula su raíz cúbica
con una cifra decimal, por aproximación, tanteando los
valores que sea necesario. Por ejemplo, para el número
27, la respuesta debería ser 3 (exacta), mientras que
para el número 35 la respuesta debería ser 3,2
(porque la respuesta "correcta" es mayor que 3,2 pero menor que 3,3).
*/ //Boris Garcés Vernier


/*
using System;
class E57
{
    static void Main()
    {
        System.Console.WriteLine("introduce un número");
        float numero = Convert.ToSingle(Console.ReadLine());
        float resultado = 0;
        float i = 0.1f;

        while (resultado < numero)
        {
            i++;
            resultado = (float)Math.Pow(i,3);
        }


        if (resultado <= numero)
        {
            Console.WriteLine($"{i} * {i} * {i}= {numero} (exacta)");
        }
        else
        {
            i--;
            System.Console.WriteLine($"{i} (aproximada)");
        }

        */

using System;

class E57
{
    static void Main()
    {
        // Solicitar un número real al usuario
        Console.Write("Por favor, ingresa un número real: ");
        double numero = double.Parse(Console.ReadLine());

        // Inicializar la aproximación de la raíz cúbica
        double aproximacion = 0;

        // Definir el tamaño de incremento para tanteo
        double incremento = 0.1;

        // Realizar el tanteo
        while (Math.Pow(aproximacion, 3) < numero)
        {
            aproximacion += incremento;
        }

        // Aproximación de la raíz cúbica con una cifra decimal
        double raizCubicaAproximada = Math.Round(aproximacion, 1);

        // Imprimir el resultado
        Console.WriteLine($"La raíz cúbica aproximada de {numero} es {raizCubicaAproximada}");
    }
}


