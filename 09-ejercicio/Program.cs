/*9. Crea un programa que permita calcular longitudes de circunferencias.
 El usuario introducirá el radio y se le responderá algo como "La longitud
  de un circunferencia de radio 2 m es de 12,56 m2". 
  Recuerda que la fórmula es L = 2 * PI * radio. Debes usar {0} en vez de "Write". 
  No puedes utilizar "using System;". Debe contener un único comentario de múltiples líneas,
   que detalle tu nombre y el cometido del programa.*/
using System;

class Ejercicio_09
{
    static void Main()
    {

        double radio;
        Console.WriteLine("Introduce el radio de la circunferencia");
        radio = Convert.ToInt32(Console.ReadLine());

        double longitud = 2*3.14*radio;
        Console.WriteLine($"La longitud de un circunferencia {radio} m de radio es de {longitud} m2");

}
}
