using System;

class Elercicio_20
{
    static void Main(){
        Console.WriteLine("Introduce el número de un mes");
        int numMes = Convert.ToInt32(Console.ReadLine());

        switch(numMes){
            case 1: System.Console.WriteLine("Enero tiene 31 Dias"); break;
            case 2: System.Console.WriteLine("Febrero tiene 28 Dias"); break;
            case 3: System.Console.WriteLine("Marzo tiene 31 Dias"); break;
            case 4: System.Console.WriteLine("Abril tiene 30 Dias"); break;
            case 5: System.Console.WriteLine("Mayo tiene 31 Dias"); break;
            case 6: System.Console.WriteLine("Junio tiene 30 Dias"); break;
            case 7: System.Console.WriteLine("Julio tiene 31 Dias"); break;
            case 8: System.Console.WriteLine("Agosto tiene 31 Dias"); break;
            case 9: System.Console.WriteLine("Septiembre tiene 30 Dias"); break;
            case 10: System.Console.WriteLine("Octubre tiene 31 Dias"); break;
            case 11: System.Console.WriteLine("Noviembre tiene 30 Dias"); break;
            case 12: System.Console.WriteLine("Diciembre tiene 31 Dias"); break;
            default: System.Console.WriteLine("Este mes no existe"); break;
        }
    }
}