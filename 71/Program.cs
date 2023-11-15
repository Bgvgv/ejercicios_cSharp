/*
71. Crea un nueva versión del menú (ejercicio 66), 
que muestra una serie de opciones y después dice
cuál ha escogido. En esta versión, los nombres
de las opciones estarán en un array,
por lo que no será necesario ningún "switch". 
La apariencia será como ésta:

1. Ver datos existentes
2. Añadir un nuevo dato
3. Buscar
0. Salir
1
Ha escogido la opción "1": "Ver datos existentes"
*///Boris Garcés Vernier


using System;
class E71
{
    static void Main()
    {

        Console.WriteLine("Elige una opción del menú");
        string[] array =
        {
            "Salir",
            "Ver datos existentes",
            "Añadir un nuevo dato",
            "Buscar"

        };

        //Mostramos menú
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0}. {1}", (i), array[i]);
        }
        try
        {
            byte opcion = Convert.ToByte(Console.ReadLine());

            
            for (int i = 0; i < array.Length; i++)
            {

                if (opcion == i)
                {
                    Console.WriteLine("Has elegido {0}. {1}", (i), array[i]);

                }
            }

            if (opcion >= array.Length)
            {
                System.Console.WriteLine("Esta opción no se encuentra en el menú");
               
            }



        }
        catch (OverflowException)
        {
            System.Console.WriteLine("Esta opción no se encuentra en el menú");
            
        }
        catch(FormatException){
             System.Console.WriteLine("Esta opción no se encuentra en el menú");
        }
        Console.WriteLine();// Salto de línea.








    }
}