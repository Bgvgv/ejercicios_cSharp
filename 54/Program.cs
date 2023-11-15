/*
54. Calcula el volumen de un cono, a partir de su radio y su altura,
que introducirá el usuario. El volumen será "pi por el radio al cuadrado,
multiplicado por la altura y dividido entre 3". Debes utilizar variables
"pi", "radio" y "volumen", de tipo "float" y mostrar los resultados con dos decimales.
*/ //Boris Garcés Vernier

using System;
class E54
{
    static void Main()
    {

        float pi = 3.14f, radioAlCuadrado, volumen;


        Console.WriteLine("Radio: ");
        float radio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Altura: ");
        float alturaF = Convert.ToInt32(Console.ReadLine());

        radioAlCuadrado = radio * radio;
        volumen = pi * radioAlCuadrado * alturaF / 3;

        Console.WriteLine(volumen.ToString("0.00"));


    }
}