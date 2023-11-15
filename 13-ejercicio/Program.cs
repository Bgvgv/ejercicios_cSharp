using System;
class Ejercicio_12{
    static void Main(){

Console.WriteLine("Introduce un numero");
int numero = Convert.ToInt32(Console.ReadLine());



if(numero < 0){
    Console.WriteLine($"El numero {numero} es negativo");  
}
else{
    Console.WriteLine($"El numero {numero} es positivo");
}

    }
}
