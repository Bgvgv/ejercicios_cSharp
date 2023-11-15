/*
22. Pide al usuario un número, que guardarás en una variable "numero". 
Dale a una variable llamada "impar" el valor 1 si "numero" es impar, 
o un valor 0 si es par. Hazlo de dos formas, como parte de un mismo 
programa: primero con "if" y luego con el operador ternario. 
Al igual que en el ejercicio anterior, tu programa pedirá el dato 
una única vez y mostrará la respuesta dos veces (una vez con "if" y 
otra vez con el "operador ternario"). Recuerda que para saber si es 
par o impar, puedes mirar el resto de su división entre 2.
*/ //Boris Garcés Vernier

using System;

class Ejercicio_22
{
    static void Main()
    {

        int impar;
        Console.WriteLine("Añade un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 != 0)
        {
            impar = 1;
            Console.WriteLine("Resultado aplicando (if-else) = " + impar);
        }
        else
        {
            impar = 0;
            Console.WriteLine("Resultado aplicando (if-else) = " + impar);
        }

        impar = numero % 2 != 0 ? 1 : 0;
        Console.WriteLine("Resultado aplicando operador ternario = " + impar);


    }
}