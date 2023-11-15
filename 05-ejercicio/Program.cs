/*5. Calcula el resultado de (50 - 12 / 5 + 2 * 3 ) % 7 (hazlo tanto a mano como empleando un programa 
que te ayude a comprobar que tus cálculos son correctos).*/
using System;
class Ejercicio_05
{
    static void Main()
    {

        double resultadoCalculadora = (50 - 12.0 / 5 + 2 * 3) % 7;

        Console.WriteLine("Resultado sin calculadora: " + (50 - 12 / 5 + 2 * 3) % 7);
        Console.WriteLine("Resultado de la calculadora: " + resultadoCalculadora);
    }
}
