/*
63. Realiza una nueva versión del programa de la contraseña de acceso con 3 intentos,
pero esta vez pidiendo un login (que será una cadena de texto) y también una clave 
(otra cadena de texto). Usa una variable booleana llamada "acertado" y otra llamada 
"intentosAgotados".
*/

using System;
class E63
{
    static void Main()
    {

        byte intentos = 3;
        string id1, id2;
        bool acertado = false;
        bool intentosAgotados = false;




        do
        {

            System.Console.WriteLine("Ingrese su nombre");
            id1 = Console.ReadLine();

            System.Console.WriteLine("Ingrese su fecha de nacimiento");
            id2 = Console.ReadLine();

            intentos--;
            intentosAgotados = intentos == 0;
            acertado = ((id1 == "Boris") && (id2 == "22/12/77"));

            if (!acertado && !intentosAgotados)
            {
                System.Console.WriteLine("{0} su identificación es incorrecta", id1);
                System.Console.WriteLine("Le quedan {0} intentos, Vuelva a intentarlo", intentos);
                System.Console.WriteLine();//Salto de línea
            }

        } while (!acertado && !intentosAgotados);


        if (acertado)
        {
            System.Console.WriteLine("Hola {0} su identificación es correcta", id1, id2);
        }
        else
        {
            System.Console.WriteLine("Hola {0} su identificación es incorrecta", id1, id2);

        }




    }
}