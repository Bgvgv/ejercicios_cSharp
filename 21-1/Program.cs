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

        int x, absoluto;
        x=-7;

        if(x>=0){
            absoluto=x;
        }else{
            absoluto=-x;
        }

Console.WriteLine(absoluto);

    }
}