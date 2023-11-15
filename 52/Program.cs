/*
52. Crea una versión mejorada del ejercicio 8: un programa
 que pida al usuario una cantidad de pies y muestre su
  equivalencia en metros (1 pie = 0,305 metros). 
  Debe emplear tres variables: pies, metros, metrosPorPie,
   todas ellas números reales de simple precisión (float).
    Debe mostrar toda la información en una línea, algo como "2 pies son 0,61 m".
*/ //Boris Garcés Vernier

using System;
class E52
{
    static void Main()
    {

        float metros = 0.3048f, metrosPorPies;
        Console.WriteLine("Pies: ");
        uint pies = Convert.ToUInt32(Console.ReadLine());

        metrosPorPies = pies * metros;

        Console.WriteLine("{0} pies son {1} m", pies, metrosPorPies.ToString("0.00"));
    }
}