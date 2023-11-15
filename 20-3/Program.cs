using System;

class Ejercicio_20_3
{
    static void Main()
    {

        Console.WriteLine("Introduce el número de un mes");
        int mes = Convert.ToInt32(Console.ReadLine());
        mes--;


        //Console.WriteLine(mes);
        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        for (int i = 0; i < meses.Length; i++)
        {

            if ((mes >= 0) && (mes < 7) && (mes == i) && (mes != 1) && (mes != 7))
            {
                if (mes % 2 == 0)
                {

                    Console.WriteLine(meses[i] + "31");
                }
                else
                {
                    Console.WriteLine(meses[i] + "30");
                }
            }
            else if ((mes > 7) && (mes == i))
            {
                if (mes % 2 == 0)
                {

                    Console.WriteLine(meses[i] + "30");
                }
                else
                {
                    Console.WriteLine(meses[i] + "31");
                }
            }
            else if ((mes == 1) && (mes == i))
            {
                Console.WriteLine(meses[i] + "28");
            }

        }
        if ((mes < 0) || (mes > 11))
        {
            Console.WriteLine("Este número no existe");
        }

    }
}

