/* 8. Crea un programa que pida al usuario una cantidad de pies y muestre 
su equivalencia en milímetros (1 pie = 305 milímetros). Debe emplear tres 
variables: pies, milimetros, milimetrosPorPie. Debe mostrar toda la información 
en una línea, algo como "2 pies son 610 mm", usando "Write" en vez de "{0}".
 Debe utilizar "using System;". Debe contener dos comentarios de una línea al principio: 
 uno con tu nombre y otro con el cometido del programa (p.ej: Conversor de pies a milímetros).*/

using System;
class Ejercicio_08{
    static void Main(){
        Console.WriteLine();
Console.WriteLine("Boris Garcés");
Console.WriteLine("Conversor de pies a milímetros");
Console.WriteLine();
 int pies, milimetros =350, milimetrosPorPie;
 
Console.WriteLine("Introduce un numero de pies");
pies = Convert.ToInt32(Console.ReadLine());

milimetrosPorPie = pies * milimetros;
Console.WriteLine(pies + " pies son " + milimetrosPorPie + " mm");
        
    }
}
