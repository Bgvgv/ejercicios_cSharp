/*
44. Muestra un rectángulo hueco, con el ancho 
y el alto que elija el usuario, y usando como 
símbolo el número que escoja el usuario, como 
en este ejemplo:

Ancho? 4
Alto? 3
Número? 2
2222
2  2
2222
*/ // Boris Garcés Vernier

using System;
class E44
{
    static void Main()
    {
        System.Console.Write("Ancho?: ");
        int ancho = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Alto?: ");
        int alto = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("número?: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= alto; i++)
        {
            for (int j = 1; j <= ancho; j++)
            {
                if (((i == 1) || (i == alto)) || ((j == 1) || (j == ancho)))
                {
                    System.Console.Write(numero);
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}