
using System;
class Ejercicio_11{
    static void Main(){

Console.WriteLine("Introduce un numero");
int numero = Convert.ToInt32(Console.ReadLine());

int resultado = numero%2;

if(resultado == 0){
    Console.WriteLine($"El numero {numero} es par");  
}
if(resultado != 0){
    Console.WriteLine($"El numero {numero} es impar");
}

    }
}
