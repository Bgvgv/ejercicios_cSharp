using System;

class Ejercicio_20_1
{
    static void Main()
    {

        Console.WriteLine("Introduce el número de un mes");
        int mes = Convert.ToInt32(Console.ReadLine());
        
        
        //Console.WriteLine(mes);
        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


        switch(mes){

            case 1: Console.WriteLine(meses[mes-1]+31);
            break;
            case 2: Console.WriteLine(meses[mes-1]+ 28);
            break;
            case 3: Console.WriteLine(meses[mes-1]+31);
            break;
            case 4: Console.WriteLine(meses[mes-1]+30);
            break;
            case 5: Console.WriteLine(meses[mes-1]+31);
            break;
            case 6: Console.WriteLine(meses[mes-1]+30);
            break;
            case 7: Console.WriteLine(meses[mes-1]+31);
            break;
            case 8: Console.WriteLine(meses[mes-1]+31);
            break;
            case 9: Console.WriteLine(meses[mes-1]+30);
            break;
            case 10: Console.WriteLine(meses[mes-1]+31);
            break;
            case 11: Console.WriteLine(meses[mes-1]+30);
            break;
            case 12: Console.WriteLine(meses[mes-1]+31);
            break;
            default: Console.WriteLine("Este numero no existe");
            break;
        }
    }
}

