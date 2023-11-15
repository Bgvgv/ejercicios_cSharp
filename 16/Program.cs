using System;
class Ejercicio_16
{
    static void Main()
    {
        System.Console.WriteLine("número 1");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("número 2");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("número 3");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        int numeroMenor = numero1;

        if (numero2 < numeroMenor)
        {
            numeroMenor = numero2;
        }
        if (numero3 < numeroMenor)
        {
            numeroMenor = numero3;
        }

        System.Console.WriteLine(numeroMenor);

    }
}
