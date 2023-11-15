/*
23. Crea una variante del ejercicio anterior, en la que la variable se llamará 
"impar y positivo", y recibirá el valor 1 si el número introducido por el usuario
 es positivo además de impar. En caso contrario (si no es positivo o no es impar), 
 tendrá el valor 0.
*/ // Boris Garcés Vernier
using System;

class Ejercicio_23
{
    static void Main()
    {

        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        int imparPositivo;

        if ((numero % 2 != 0) && (numero > 0))
        {
            imparPositivo = 1;
            Console.WriteLine("Resultado aplicando (if-else) = " + imparPositivo);
        }
        else
        {
            imparPositivo = 0;
            Console.WriteLine("Resultado aplicando (if-else) = " + imparPositivo);
        }

        imparPositivo = (numero % 2 != 0) && (numero > 0 )? 1 : 0;
        Console.WriteLine("Resultado aplicando Operador ternario = " +imparPositivo);


    }
}