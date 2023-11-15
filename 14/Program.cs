using System;
class Ejercicio_14
{
    static void Main()
    {

        Console.WriteLine("Introduce un numero");
        int numero = Convert.ToInt32(Console.ReadLine());

        string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };


        if ((numero < 1) || (numero > 7))
        {
            Console.WriteLine("El número no es válido");
        }

        else
        {
            Console.WriteLine($"El día de la semana es el " + diasSemana[numero - 1]);
        }

    }
}
