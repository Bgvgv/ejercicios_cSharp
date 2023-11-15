/*
75. Crea un array de números reales de simple precisión,
con espacio para 10 datos. Pide al usuario esos 10 datos 
y luego muestra un menú que le permita: Ver todos los datos 
en el orden en que se habían introducido, calcular y mostrar 
el máximo de los datos, calcular y mostrar el mínimo de los datos, 
buscar (ver si está almacenado) un cierto dato, salir. 
La opción de Buscar preguntará el dato que se quiere localizar 
y responderá si era parte de los 10 datos iniciales o no lo era.
*/// Boris Garcés Vernier


using System;
class E75
{
    static void Main()
    {
        const int constante = 10;
        float numero, mayor = 0, menor = 0;

        float[] arrayNumeros = new float[constante];

        for (int i = 0; i <= constante - 1; i++)
        {
            Console.Write("Introduce un número: ");
            numero = Convert.ToSingle(Console.ReadLine());
            arrayNumeros[i] = numero;
        }
        Console.WriteLine(); //Salto de línea.
        Console.WriteLine("Menú");
        string[] arrayMenu = { "0. Salir", "1. Ver todos", "2. Valor Máximo", "3. Valor Minimo", "4. Buscar" };
        foreach (string menu in arrayMenu)
        {
            Console.WriteLine(menu);
        }
        Console.Write("Escoge una opción del menú: ");
        byte opcion = Convert.ToByte(Console.ReadLine());
        Console.WriteLine();//Salto de línea

        switch (opcion)
        {
            case 1:
                for (int i = 0; i <= arrayNumeros.Length - 1; i++)
                {
                    Console.Write(arrayNumeros[i] + " ");
                }
                break;
            case 2:
                for (int i = 0; i <= arrayNumeros.Length - 1; i++)
                {

                    if (arrayNumeros[i] > mayor)
                    {
                        mayor = arrayNumeros[i];
                    }

                }
                Console.WriteLine(mayor);
                break;
            case 3:
                for (int i = 1; i <= arrayNumeros.Length - 1; i++)
                {
                    menor = arrayNumeros[0];
                    if (menor > arrayNumeros[i])
                    {
                        menor = arrayNumeros[i];
                    }
                }
                Console.WriteLine(menor);
                break;
            case 4:
                Console.Write("Introduce el valor a buscar: ");
                float numaBuscar = Convert.ToSingle(Console.ReadLine());
                bool encontrado = false;

                foreach (float numaB in arrayNumeros)
                {
                    if (numaB == numaBuscar)
                    {
                        encontrado = true;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine("El número {0} ha sido encontrado", numaBuscar);

                }
                else
                {
                    Console.WriteLine("El número {0} no ha sido encontrado", numaBuscar);
                }
                break;
            case 0:
                Console.WriteLine("Hasta pronto");
                break;
        }
        Console.WriteLine();






    }
}