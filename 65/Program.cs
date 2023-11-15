/*
65. Escribe un programa que pida un ancho y un alto (ambos serán "byte"), así como un carácter, y muestre un trapecio creciente como este:

Introduzca el ancho menor deseado: 5
Introduzca el alto deseado: 3
Introduzca el carácter: *
  *****
 *******
*********
*/

using System;
class E65
{
    static void Main()
    {

        Console.Write("Ancho: ");
        byte ancho = Convert.ToByte(Console.ReadLine());
        Console.Write("Alto: ");
        byte alto = Convert.ToByte(Console.ReadLine());
        Console.Write("Símbolo: ");
        char simbolo = Convert.ToChar(Console.ReadLine());
        int contadorAlto = alto;

        for (int i = 0; i < alto; i++)
        {
            for (int j = 1; j < contadorAlto; j++)
            {
                Console.Write(" ");
            }
            
            for (int h = 0; h < ancho; h++)
            {
                Console.Write(simbolo);
            }

            Console.WriteLine();
             contadorAlto--;
             ancho+=2;
        }

    }
}