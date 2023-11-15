using System;
class Ejercicio_17
{
    static void Main()
    {
        System.Console.WriteLine("Añade tu nota");
        double nota = Convert.ToDouble(Console.ReadLine());

        if ((nota < 0) || (nota > 10))
        {
            Console.WriteLine("El valor introducido no es válido");
        }
        else if ((nota >= 9.10) && (nota <= 10))
        {
            Console.WriteLine("Sobresaliente");
        }
        else if ((nota >= 7.8) && (nota <= 9.10))
        {
            Console.WriteLine("Notable");
        }
        else if ((nota >= 6) && (nota <= 7.8))
        {
            Console.WriteLine("Bien");
        }
        else if ((nota >= 5) && (nota <= 6))
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Suspenso");
        };


    }
}
