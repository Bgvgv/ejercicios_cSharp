/*
53. Calcula la superficie de un círculo, a partir de su radio,
que introducirá el usuario en una variable real de doble precisión
llamada "radio". (Recuerda que la fórmula es: area = pi * radio al cuadrado).
Tanto el valor de "pi" como el resultado (la longitud) deben estar almacenados
en variables, que también serán números reales de doble precisión. 
Recuerda que para elevar x al cuadrado, basta con hacer x*x.
*/ //Boris Garcés Vernier

using System;
class E53
{
    static void Main()
    {

        double pi = 3.14, area, radioAlCuadrado;
        

        Console.WriteLine("Radio: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        radioAlCuadrado = radio * radio;
        area = pi * radioAlCuadrado;

        Console.WriteLine(area);


    }
}