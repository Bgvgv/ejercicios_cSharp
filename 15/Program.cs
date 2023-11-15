using System;
class Ejercicio_15
{
    static void Main()
    {
        System.Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        if (numero < 1 || numero > 7)
            Console.WriteLine("día no válido");

        switch (numero)
        {
            case 1:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
            case 2:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
            case 3:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
            case 4:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
            case 5:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
            case 6:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
            case 7:
                Console.WriteLine(diasSemana[numero - 1]);
                break;
        }
    }
}
