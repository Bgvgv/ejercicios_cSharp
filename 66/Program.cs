/*
66. Crea un menú como el siguiente. El usuario deberá escoger la opción 0, 1 o 2, 
y después se le mostrará la opción que ha escogido, usando "switch" y datos de tipo "byte":

1. Ver datos existentes
2. Añadir un nuevo dato
3. Buscar
0. Salir
1
Ha escogido la opción "1": "Ver datos existentes"

*/

using System;

class E66
{


    static void Main()
    {

        System.Console.WriteLine("Escoje una de estas opciones");
        System.Console.WriteLine("1. Ver datos existentes");
        System.Console.WriteLine("2. Añadir un nuevo dato");
        System.Console.WriteLine("3.Buscar");
        System.Console.WriteLine("0.Salir");


        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {
            case 0:
                System.Console.WriteLine("Ha escogido la opción 0:  salir");
                break;
            case 1:
                System.Console.WriteLine("Ha escogido la opción 1: Ver datos existentes");
                break;
            case 2:
                System.Console.WriteLine("Ha escogido la opción 2: Añadir un nuevo dato");
                break;
            case 3:
                System.Console.WriteLine("Ha escogido la opción 3: Buscar");
                break;
            default:
                System.Console.WriteLine("Opción incorrecta");
                break;
        }

    }
}