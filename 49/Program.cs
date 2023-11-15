/*
49. Haz un programa que dé al usuario la oportunidad
de adivinar un número del 1 al 100 (que estará prefijado en el programa)
en un máximo de 6 intentos. En cada pasada deberá avisarle de si 
se ha pasado o se ha quedado corto.
*/ //Boris Garcés Vernier

using System;
class E49
{
    static void Main()
    {

        int numOculto = 34;
        int intentos = 1;

        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());


        while ((numero != numOculto) && (intentos < 6))
        {

            if (numero < numOculto)
            {
                Console.WriteLine("El número es muy bajo");
            }
            else
            {
                Console.WriteLine("El número es muy alto");
            }


            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());
            intentos++;
        }

        if (intentos == 6)
        {
            Console.WriteLine("Has superado el número de intentos posibles");
        }
        else
        {
            Console.WriteLine("El número número es correcto.");
        }

    }
}