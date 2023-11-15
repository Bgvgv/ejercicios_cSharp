/*
34. Muestra la tabla de multiplicar del número que escoja el usuario, usando "for".
*///Boris Garcés Vernier
class Ejercicio_34
{
    static void Main()
    {

        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
           Console.WriteLine($"{numero} * {i} = " + (numero * i));
        }


    }
}
