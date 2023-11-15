/*
51. Crea un programa en C# que pida al usuario su edad,
su año de nacimiento, su estatura en centímetros,
cuántos euros (sin céntimos) ahorró el último mes,
la población de su ciudad y la población estimada
del mundo. Debes optimizar los tipos de datos usados
(todos ellos serán números enteros).
*/ //Boris Garcés Vernier

using System;
class E51
{
    static void Main()
    {

        Console.WriteLine("Edad: ");
        byte edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Año de nacimiento: ");
        ushort añoNacimiento = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Estatura: ");
        byte estatura = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Ahorro del último mes: ");
        short ahorro = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Población: ");
        ulong poblacion = Convert.ToUInt64(Console.ReadLine());
  

    }
}