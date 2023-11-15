/*
74. Crea un programa en C# que pida al usuario el número de un mes
(por ejemplo, 3 para marzo) y el número de un día (por ejemplo, 10)
y muestre de qué número de día dentro del año se trata, en un año no bisiesto.
Por ejemplo: como enero tiene 31 días y febrero 28, el 10 de marzo sería el día
número 69 del año (31+28+10). Debes usar un array para guardar la cantidad de
días que tiene cada mes.
*/ // Boris Garcés Vernier

using System;
class E74
{
    static void Main()
    {

        try
        {

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };



            System.Console.Write("Elige un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());




            System.Console.Write("Elige un día del mes elegido: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            int[] diasPorMes = new int[mes];


            //int contador = 0, sumaMeses = 0, dias = 0, sumadorMes = 0;
            int dias = 0, sumaMeses = 0, diaDelAño = 0;
            bool error = false;


            for (int i = 0; i <= diasPorMes.Length - 1; i++)
            {

                if (i == 0)
                {

                    dias = 31;

                }
                else if (i == 1)
                {

                    dias = 28;

                }
                else if ((i != 0) && (i != 1) && (i % 2 == 0) && (i <= 7))
                {
                    dias = 31;
                }
                else if ((i != 0) && (i != 1) && (i % 2 != 0) && (i >= 7))
                {
                    dias = 31;
                }
                else
                {
                    dias = 30;
                }

                diasPorMes[i] = dias;
                sumaMeses += diasPorMes[i];

                if (
                (dia < 0) || (dia > 31) && (mes == 1) ||
                (dia < 0) || (dia > 28) && (mes == 2) ||
                (mes <= 7) && (mes % 2 != 0) && (dia < 0) || (dia > 31) ||
                (mes <= 7) && (mes % 2 == 0) && (dia < 0) || (dia > 30) ||
                (mes >= 7) && (mes % 2 != 0) && (dia < 0) || (dia > 30) ||
                (mes >= 7) && (mes % 2 == 0) && (dia < 0) || (dia > 31)
                )
                {
                    error = true;
                }
                else
                {
                    diaDelAño = (sumaMeses - diasPorMes[i]) + dia;
                }

            }




            if (error)
            {
                System.Console.WriteLine("Error en el dia");
            }
            else if (mes > 12)
            {
                System.Console.WriteLine("Error en el mes");
            }
            else
            {
                System.Console.WriteLine("{0} tiene {1} días. El día {2} de {3} es el día {4} del año.", meses[mes - 1], dias, dia, meses[mes - 1], diaDelAño);

            }

        }
        catch (OverflowException)
        {
            System.Console.WriteLine("Error en el mes");
        }



    }
}


