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

class E68
{

    enum opciones { SALIR, VER_DATOS, NUEVO_DATO, BUSCAR };

    static void Main()
    {

        System.Console.WriteLine((int)opciones.VER_DATOS + ". Ver datos existentes");
        System.Console.WriteLine((int)opciones.NUEVO_DATO + ". Añadir un nuevo dato");
        System.Console.WriteLine((int)opciones.BUSCAR + ". Buscar");
        System.Console.WriteLine((int)opciones.SALIR + ". Salir");

        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {

            case (int)opciones.VER_DATOS:
                System.Console.WriteLine("Ha escogido la opción {0}: Ver datos existentes", (int)opciones.VER_DATOS);
                break;
            case (int)opciones.NUEVO_DATO:
                System.Console.WriteLine("Ha escogido la opción {0}: Añadir un nuevo dato", (int)opciones.NUEVO_DATO);
                break;
            case (int)opciones.BUSCAR:
                System.Console.WriteLine("Ha escogido la opción {0}: Buscar", (int)opciones.BUSCAR);
                break;
            case (int)opciones.SALIR:
                System.Console.WriteLine("Ha escogido la opción {0}: Salir", (int)opciones.SALIR);
                break;
            default:
                System.Console.WriteLine("Opción incorrecta");
                break;
        }




    }
}