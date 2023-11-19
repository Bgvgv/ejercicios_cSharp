/*
86. Crea una versión mejorada del ejercicio anterior, 
que no reservará espacio sólo para 3 datos, sino para 1000 
(un "array sobredimensionado"), y mostrará un menú que permita 
al usuario añadir un nuevo dato, ver todos los existentes o salir.
*/ //Boris Garcés Vernier


using System;
class E86
{
    struct lanzamiento
    {
        public byte mes;
        public short anyo;
    }

    struct datosDelJuego
    {
        public string titulo;
        public string plataforma;

        public int espacioOcupado;
        public lanzamiento fechaLanzamiento;

    }

    static void Main()
    {
        byte opcion = 0;
        bool error = false;
        int i;

        int cantidad = 1;
        const int capacidad = 1000;
        object[] array = new object[capacidad];
        string[] menu = { "Añadir nuevo dato", "Ver datos existentes", "Salir" };
        System.Console.WriteLine();//Salto


        do
        {
            //Menú
            Console.WriteLine("Menú");
            for (i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}-{1}", i + 1, menu[i]);
            }
            System.Console.WriteLine();//Salto
            System.Console.Write("Elige una opción del menú: ");
            try
            {
                opcion = Convert.ToByte(Console.ReadLine());
            }
            catch (FormatException)
            {

                error = true;
            }


            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("Has elegido añadir dato");

                    for (i = 0; i < 1; i++)
                    {
                        Console.WriteLine("Introduce los datos del juego");
                        Console.Write("Título: ");
                        string? titulo = Console.ReadLine();
                        Console.Write("Plataforma: ");
                        string? plataforma = Console.ReadLine();
                        Console.Write("Espacio que ocupa en MB: ");
                        int espacio = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mes de Lanzamiento: ");
                        byte mes = Convert.ToByte(Console.ReadLine());
                        Console.Write("Año de Lanzamiento: ");
                        short anyo = Convert.ToInt16(Console.ReadLine());
                        System.Console.WriteLine();//Salto de línea

                        datosDelJuego[] juego = new datosDelJuego[cantidad];
                        juego[i].titulo = titulo;
                        juego[i].plataforma = plataforma;
                        juego[i].espacioOcupado = espacio;
                        juego[i].fechaLanzamiento.mes = mes;
                        juego[i].fechaLanzamiento.anyo = anyo;

                        if (cantidad < capacidad)
                        {
                            array[cantidad] =
                            "Títuto: " + juego[i].titulo + "\n" +
                            "Plataforma: " + juego[i].plataforma + "\n" +
                            "Espacio: " + juego[i].espacioOcupado + ".MB " + "\n" +
                            "Fecha de lanzamiento: " + +juego[i].fechaLanzamiento.mes + "/" + juego[i].fechaLanzamiento.anyo + ".";
                            cantidad++;
                        }

                    }
                    break;

                case 2:
                    System.Console.WriteLine("Has elegido ver datos");
                    Console.WriteLine();//Salto de línea

                    for (i = 1; i < cantidad; i++)
                    {
                        Console.WriteLine("Juego {0}", i);
                        Console.WriteLine(array[i]);
                        Console.WriteLine();//Salto de línea
                    }
                    break;

                case 3:
                    System.Console.WriteLine("Has elegido añadir salir.");
                    System.Console.WriteLine("Hasta pronto ¡¡¡");
                    break;

                default:
                    if (error)
                    {
                        System.Console.WriteLine("La opcion elegida no es válida");
                    }
                    break;
            }



        } while (opcion != 3);


    }
}