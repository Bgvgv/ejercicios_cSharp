/* 3. Crea un programa que diga el resultado de dividir 8765 entre 233. 
 Compara el resultado con el que devuelve una calculadora.*/

using System;
class Ejercicio_03
{
    static void Main()
    {
        int a = 8765;
        double aCalculadora = 8765.0;
        int b = 233;
        int resultado = a / b;
        double resultadoCalculadora = aCalculadora / b;

        System.Console.WriteLine("8765 / 233 = " + resultado);
        System.Console.WriteLine("8765 / 233 en la calculadora = " + resultadoCalculadora);
    }
}
