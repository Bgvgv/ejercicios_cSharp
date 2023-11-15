/*
69. Escribe un programa que pida al usuario números reales de doble precisión y muestre su mínimo, máximo, suma y media después de cada paso. Terminará cuando introduzca la palabra "fin":

Dato: 5
Min = 5, Max = 5, Suma = 5, Media = 5
Dato: 2.2
Min = 2.2, Max = 5, Suma = 7.2, Media = 3.6
Dato: fin
¡Hasta otra!

Pista: deberás leer lo que introduzca el usuario como string, y convertir a dato numérico sólo en caso de que no sea la palabra "fin".
*/ //Boris Garcés Vernier

using System;

class E69
{

    static void Main()
    {
        //var min, max, suma, media, sumando;
        double suma = 0, sumando = 0, min = 0, max = 0, media = 0;
        var dato = "";
        int contador = 0;

        Console.Write("Dato: ");
        dato = Console.ReadLine();


        if (dato != "fin")
        {

            min = Convert.ToDouble(dato);


            suma = Convert.ToDouble(dato) + sumando;
            sumando = suma;


            if (Convert.ToDouble(dato) > sumando)
            {
                min = Convert.ToDouble(dato);
                max = sumando;
            }
            else
            {
                min = sumando;
                max = Convert.ToDouble(dato);
            }

            contador = 1;
            media = suma / contador;

            System.Console.WriteLine("Min = {0}, Max = {1}, Suma = {2}, Media = {3}", min, max, suma, media);



            //System.Console.WriteLine("Min:{0} Max:{1} Suma:{2}", min, max, suma, media);
        }


        do
        {
            Console.Write("Dato: ");
            dato = Console.ReadLine();


            if (dato != "fin")
            {


                suma = Convert.ToDouble(dato) + sumando;


                if (Convert.ToDouble(dato) < sumando)
                {
                    min = Convert.ToDouble(dato);
                    max = sumando;
                }
                else
                {
                    min = sumando;
                    max = Convert.ToDouble(dato);
                }


                contador++;
                media = suma / contador;


                System.Console.WriteLine("Min = {0}, Max = {1}, Suma = {2}, Media = {3}", min, max, suma, media.ToString("0.0"));



            }


        } while (dato != "fin");


        System.Console.WriteLine("Hasta pronto");


    }
}
/*


        var a = "1";
        Convert.ToInt32(a);
        double b = Convert.ToInt32(a) + Convert.ToInt32(a) + Convert.ToInt32(a);
        System.Console.WriteLine(b);


*/