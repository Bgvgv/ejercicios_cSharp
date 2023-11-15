using System;
class Ejercicio_18
{
    static void Main()
    {
        System.Console.WriteLine("Añade tu nota");
        double nota = Convert.ToDouble(Console.ReadLine());

        switch (nota)
        {
            case 19.10:  Console.WriteLine( "Sobresaliente"); 
            break;
            case 7.8 :  Console.WriteLine( "Notable"); 
            break;
            case 6:  Console.WriteLine( "Bien"); 
            break;
            case 5:  Console.WriteLine( "Aprobado"); 
            break;
            case 0-4:  Console.WriteLine( "Suspenso"); 
            break;
        }



    }
}
