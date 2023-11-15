/*
76. Crea una variante del ejercicio anterior 
en la que reserves espacio para 1000 datos (
reales de simple precisión), aunque el 
usuario típicamente introducirá muchos menos.
El menú permitirá: Añadir un nuevo dato, 
ver todos los datos, calcular y mostrar 
el máximo de los datos, calcular y mostrar 
el mínimo de los datos, buscar un cierto 
dato, salir. La opción de Buscar preguntará 
el dato que se quiere localizar y 
responderá si está o no en el array.
*/

using System;
class E76
{
    static void Main()
    {
        const int constante = 10;
        float numero, mayor = 0, menor = 0;

        float[] arrayNumeros = new float[constante];

        Console.WriteLine("Menú");
        string[] arrayMenu = { "Salir", "Añadir datos", "Ver todos", "Valor Máximo", "Valor Minimo", "Buscar" };

        //Mostramos menú
        for (int i = 1; i <= arrayMenu.Length - 1; i++)
        {
            Console.WriteLine("{0}.{1}", i, arrayMenu[i]);

        }
        Console.WriteLine("{0}.{1}", 0, arrayMenu[0]);
        Console.Write("Escoge una opción del menú: ");
        byte opcion = Convert.ToByte(Console.ReadLine());
        Console.WriteLine();//Salto de línea

        do
        {

            switch (opcion)
            {
                case 1:
                    try
                    {
                        int contador = 0;
                        Console.WriteLine("Introduce un número o toca cualquier letra cuando quieras salir al menú.");
                        for (int i = 1; i < constante; i++)
                        {
                            Console.Write("Numero: ");
                            numero = Convert.ToSingle(Console.ReadLine());
                            arrayNumeros[contador] = numero;
                            contador++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                    }
                    break;

                case 2:

                    for (int i = 0; i <= arrayNumeros.Length - 1; i++)
                    {
                        if (arrayNumeros[i] != 0)
                            Console.Write(arrayNumeros[i] + " ");
                    }
                    Console.WriteLine();// Salto de línea 
                    break;
                case 3:
                    for (int i = 0; i <= arrayNumeros.Length - 1; i++)
                    {

                        if (arrayNumeros[i] > mayor)
                        {
                            mayor = arrayNumeros[i];
                        }

                    }
                    Console.WriteLine(mayor);
                    break;
                case 4:
                    menor = arrayNumeros[0];
                    for (int i = 0; i <= arrayNumeros.Length - 1; i++)
                    {
                        if ((arrayNumeros[i] < menor) && (arrayNumeros[i] != 0))
                        {
                            menor = arrayNumeros[i];
                        }
                    }
                    Console.WriteLine(menor);

                    break;
                case 5:
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

            }
            Console.WriteLine();//Salto línea

            //Mostramos menú
            Console.WriteLine("Menú");
            for (int i = 1; i <= arrayMenu.Length - 1; i++)
            {
                Console.WriteLine("{0}.{1}", i, arrayMenu[i]);

            }
            Console.WriteLine("{0}.{1}", 0, arrayMenu[0]);
            Console.Write("Escoge una opción del menú: ");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();//Salto de línea

        } while (opcion != 0);


        Console.WriteLine("Hasta pronto");

        Console.WriteLine();






    }
}