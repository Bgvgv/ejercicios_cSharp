using System;

class Elercicio_19{
    static void Main(){
        Console.WriteLine("Introduce el número de un mes");
        int numMes = Convert.ToInt32(Console.ReadLine());

        
        if(numMes == 1){
            System.Console.WriteLine("Enero tiene 31 Dias");
        }else if(numMes == 2){
            System.Console.WriteLine("Febrero tiene 28 Dias");
        }else if(numMes == 3){
            System.Console.WriteLine("Marzo tiene 31 Dias");
        }else if(numMes == 4){
            System.Console.WriteLine("Abril tiene 30 Dias");
        }else if(numMes == 5){
            System.Console.WriteLine("Mayo tiene 31 Dias");
        }else if(numMes == 6){
            System.Console.WriteLine("Junio tiene 30 Dias");
        }else if(numMes == 7){
            System.Console.WriteLine("Julio tiene 31 Dias");
        }else if(numMes == 8){
            System.Console.WriteLine("Agosto tiene 31 Dias");
        }else if(numMes == 9){
            System.Console.WriteLine("Septiembre tiene 30 Dias");
        }else if(numMes == 10){
            System.Console.WriteLine("Octubre tiene 31 Dias");
        }else if(numMes == 11){
            System.Console.WriteLine("Noviembre tiene 30 Dias");
        }else if(numMes == 12){
            System.Console.WriteLine("Diciembre tiene 31 Dias");
        }
        else{
            System.Console.WriteLine("Este mes no existe");
        }
    }
}