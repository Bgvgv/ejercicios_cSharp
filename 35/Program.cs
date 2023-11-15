/*
35. Pregunta al usuario dos números n1 y n2 (por ejemplo, 0 y 10).
Muestra las tablas de multiplicar de todos lo números comprendidos 
entre n1 y n2, utilizando "for". Debe haber una línea en blanco 
separando cada tabla de multiplicar de la siguiente. 
El programa debe comportarse correctamente si el primer número 
es menor que el segundo (es decir: si introduce 10 y 0, aun así 
se mostrarán desde la tabla del 0 hasta la del 10).
*///Boris Garcés Vernier
class Ejercicio_35
{
    static void Main()
    {

        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int num1;
        int num2;

        if (numero1 > numero2)
        {
            num1 = numero2;
            num2 = numero1;
        }
        else
        {
            num1 = numero1;
            num2 = numero2;
        }

        Console.WriteLine($"Números introducidos {num1}, {num2}");

        for (int i = num1; i <= num2; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            Console.WriteLine();
        }


    }
}
