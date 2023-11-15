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

class E67
{


    static void Main()
    {

        const int VER_DATOS = 1;
        const int NUEVO_DATO = 2;
        const int BUSCAR = 3;
        const int SALIR = 0;

        Console.WriteLine("Escoje una de estas opciones");
        Console.WriteLine(VER_DATOS + ". Ver datos existentes");
        Console.WriteLine(NUEVO_DATO + ". Añadir un nuevo dato");
        Console.WriteLine(BUSCAR + ". Buscar");
        Console.WriteLine(SALIR + ". Salir");

        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {

            case VER_DATOS:
                System.Console.WriteLine("Ha escogido la opción 1: Ver datos existentes");
                break;
            case NUEVO_DATO:
                System.Console.WriteLine("Ha escogido la opción 2: Añadir un nuevo dato");
                break;
            case BUSCAR:
                System.Console.WriteLine("Ha escogido la opción 3: Buscar");
                break;
            case SALIR:
                System.Console.WriteLine("Ha escogido la opción 0: Salir");
                break;
            default:
                System.Console.WriteLine("Opción incorrecta");
                break;
        }



    }
}