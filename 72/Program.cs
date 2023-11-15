/*
72. Crea un array que contenga los nombres de los meses,
prefijando sus datos entre llaves. Muestra todos los meses
en pantalla, desde el primero (enero) hasta el último
(diciembre), en una misma línea y separados por espacios,
usando "foreach". En la siguiente línea, muéstralos en orden inverso
(de diciembre a enero), empleando "for". Finalmente, pide al usuario
un número de mes (por ejemplo, el 3) y muestra su nombre (el 2 sería febrero).
*/ // Boris Garcés Vernier

using System;
class E72
{
    static void Main()
    {

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        Console.WriteLine();// Salto de línea.
        foreach (string mes in meses)
        {
            System.Console.Write(mes + " ");
        }

        System.Console.WriteLine(); // Salto de línea
        System.Console.WriteLine(); // Salto de línea

        for (int i = meses.Length - 1; i >= 0; i--)
        {
            System.Console.Write(meses[i] + " ");
        }

        System.Console.WriteLine(); // Salto de línea
        System.Console.WriteLine(); // Salto de línea

        try
        {
            System.Console.WriteLine("Elige un número de mes");
            byte mesOpcion = Convert.ToByte(Console.ReadLine());

            System.Console.WriteLine(meses[mesOpcion - 1]);

            if (mesOpcion > meses.Length)
            {
                System.Console.WriteLine("Has tenido un error al elegir el mes");

            }

        }
        catch (OverflowException)
        {
            System.Console.WriteLine("Has tenido un error al elegir el mes");

        }
        catch (IndexOutOfRangeException)
        {
            System.Console.WriteLine("Has tenido un error al elegir el mes");

        }
        catch (FormatException)
        {
            System.Console.WriteLine("Has tenido un error al elegir el mes");
        }
        Console.WriteLine();// Salto de línea.


    }
}