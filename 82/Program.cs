/*
82. Crea una variante del programa anterior, que pregunte al usuario 
cuántos datos guardará en un primer bloque de números reales de simple precisión, 
luego cuántos datos guardará en un segundo bloque, y finalmente pida los datos en sí. 
Los debe guardar en un array de arrays. Después calculará y mostrará el promedio 
de los valores que hay guardados en el primer subarray, luego el promedio de 
los valores en el segundo subarray y finalmente el promedio global.
*/ //Boris Garcés Vernier

using System;
class E82
{
    static void Main()
    {

        const int columnas = 2;
        float valorDato;
        int contador=0;
        float[] suma = new float[columnas];
        float[] promedio = new float[columnas];

        Console.Write("Cuantos datos contiene el primer bloque?: ");
        int datosB1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cuantos datos contiene el segundo bloque?: ");
        int datosB2 = Convert.ToInt32(Console.ReadLine());



        float[][] array = new float[columnas][];
        array[0] = new float[datosB1];
        array[1] = new float[datosB2];



        Console.WriteLine("Pide valores");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write("Valor {0}: ", j + 1);
                valorDato = Convert.ToSingle(Console.ReadLine());
                array[i][j] = valorDato;
            }
            Console.WriteLine(); //Salto de línea
        }

        Console.WriteLine("Muestra valores");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Valores {0}: ", i + 1);
            for (int j = 0; j < array[i].Length; j++)
            {

                Console.Write("{0} ", array[i][j]);
                contador++;

            }
            Console.WriteLine(); //Salto de línea
        }

        Console.WriteLine("Suma de valores por columnas");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                suma[i] += array[i][j];
                
            }
        }
        Console.WriteLine("Suma-1: {0}", suma[0]);
        Console.WriteLine("Suma-2: {0}", suma[1]);
        
        Console.WriteLine("Promedio de valores por columnas");
        int contador2=0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                contador2++;
                promedio[i] = suma[i]/array[i].Length;
                
            }
        }
        Console.WriteLine("Promedio-1: {0}", promedio[0]);
        Console.WriteLine("Promedio-2: {0}", promedio[1]);

        float sumaGeneral = suma[0] + suma[1];
        Console.WriteLine("Suma general: {0}", sumaGeneral);
        Console.WriteLine("Promedio general: {0}", (suma[0] + suma[1]) / contador);



    }
}