/* 21. Escribe un programa que calcule (y muestre) el valor absoluto de un número x: 
si el número es positivo (o cero), su valor absoluto es exactamente el número x; 
en caso contrario, su valor absoluto es -x. Hazlo de dos maneras diferentes en el 
mismo programa: usando "if" y usando el "operador condicional" u "operador ternario" 
(?). Tu programa pedirá un dato "x" una única vez y mostrará la respuesta dos veces 
(una vez con "if" y otra vez con el "operador ternario").*/
//Boris Garcés Vernier

using System;
class Ejercico_21
{
    static void Main()
    {

        Console.WriteLine("Escribe un número");
        int x = Convert.ToInt32(Console.ReadLine());
        int absoluto;

        if (x >= 0)
        {
            absoluto= x;
            Console.WriteLine($"El valor absoluto de {x} es {absoluto}");
        }
        else
        {
            absoluto= -x;
            Console.WriteLine($"El valor absoluto de {x} es {absoluto}");
        }

        absoluto = x >= 0 ? x : -x;
        Console.WriteLine($"El valor absoluto de {x} es " + absoluto);

    }
}