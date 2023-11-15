using System;
class Ejercicio_20_1
{
    static void Main()
    {

        Console.WriteLine("Introduce el número de un mes");
        int mes = Convert.ToInt32(Console.ReadLine());
        mes--;
        //Console.WriteLine(mes);
        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


        if ((mes >= 0) && (mes < 7) && (mes != 1) && (mes != 7) && (mes != 8))
        {
            if (mes % 2 == 0)
            {
                System.Console.WriteLine(meses[mes] + 31);
            }
            else
            {
                System.Console.WriteLine(meses[mes] + 30);
            }
        }
        else if ((mes > 8) && (mes <= 12))
        {
            if (mes % 2 == 0)
            {
                System.Console.WriteLine(meses[mes] + 30);
            }
            else
            {
                System.Console.WriteLine(meses[mes] + 31);
            }
        }
        else if (mes == 1)
        {
            System.Console.WriteLine(meses[mes] + 28);
        }
        else if (mes == 7)
        {
            System.Console.WriteLine(meses[mes] + 31);
        }
        else if (mes == 8)
        {
            System.Console.WriteLine(meses[mes] + 30);
        }
        else
        {
            Console.WriteLine("Este mes no existe");
        }


    }
}

