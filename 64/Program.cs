/*
64. Crea un programa que le pida al usuario dos números (reales de simple precisión)
y una operación para realizar en ellos (+, -, *, x, ·, /) y muestre el resultado 
de esa operación, como en este ejemplo:

Introduzca el primer número: 5
Introduzca la operación: ·
Introduzca el segundo número: 7
5 · 7 = 35
*/

using System;
class E64
{
    static void Main()
    {

        Console.WriteLine("Número 1: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Número 2: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Operador: ");
        char operador = Convert.ToChar(Console.ReadLine());

        int resultado;

        switch (operador)
        {
            case '+':
                resultado = numero1 + numero2;
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operador, numero2, resultado);
                break;
            case '-':
                resultado = numero1 - numero2;
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operador, numero2, resultado);
                break;
            case '*':
            case '·':
            case 'x':
                resultado = numero1 * numero2;
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operador, numero2, resultado);
                break;
            case '/':
                resultado = numero1 / numero2;
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operador, numero2, resultado);
                break;
            default:
                Console.WriteLine("{0} no es un operador", operador);
                break;

        }








    }
}