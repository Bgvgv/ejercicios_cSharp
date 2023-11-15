/*
32. Muestra los números pares del 30 al 10, ambos inclusive, 
descendiendo, separados por un espacio, sin avanzar de línea, 
usando "for". Hazlo dos veces como parte de un mismo programa: 
primero disminuyendo de 2 en 2 y luego repítelo 
disminuyendo de 1 en 1 pero comprobando si el número es par 
antes de escribirlo.
*///Boris Garcés Vernier
class Ejercicio_32
{
    static void Main()
    {

        for (int i = 30; i >= 10; i -= 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int i = 30; i >= 10; i--)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

    }
}
