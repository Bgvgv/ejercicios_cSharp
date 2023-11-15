/*
47. Muestra un calendario, pidiendo al usuario
 la cantidad de días del mes (por ejemplo, 31) 
 y el número en la semana del primer día 
 (por ejemplo, 2 para el martes). 
 El resultado debería ser algo como:

  L   M   X   J   V   S   D
      1   2   3   4   5   6
  7   8   9  10  11  12  13
 14  15  16  17  18  19  20
 21  22  23  24  25  26  27
 28  29  30  31
*///Boris Garcés vernier

using System;
class E47
{
    static void Main()
    {

        System.Console.WriteLine("Cantidad de días del mes");
        int diasMes = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Primer día de la semana");
        int diaSemana = Convert.ToInt32(Console.ReadLine());
        diaSemana--;

        int dias = 1;
        //int diasTotales = 0;

        Console.WriteLine(" L   M   X   J   V   S   D");

        for (int i = 1; i < diaSemana + 1; i++)
        {
            System.Console.Write("    ");
        }

        for (int i = 1; i < 7; i++)
        {
            if (i == 1)
            {
                for (int j = 1; j <= 7 - diaSemana; j++)
                {

                    System.Console.Write($" {dias}  ");
                    dias++;
                }
            }
            else
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (dias <= diasMes)
                    {
                        if (dias < 10)
                        {
                            System.Console.Write($" {dias}  ");
                        }
                        else
                        {
                            System.Console.Write($"{dias}  ");
                        }

                    }
                    dias++;
                }
            }




            System.Console.WriteLine();

        }






    }
}





