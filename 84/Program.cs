/*
84. Crea una versión mejorada del ejercicio anterior, que pida al usuario los datos de 3 juegos, los guarde en un array y luego los muestre.
*/ //Boris Garcés Vernier


using System;
class E84
{

    struct datosDelJuego
    {
        public string titulo;
        public string plataforma;

        public int espacioOcupado;

    }

    static void Main()
    {
const int cantidad = 3;
        object[] array = new object[cantidad];
        
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Introduce los datos del juego");
            Console.Write("Título: ");
            string? titulo = Console.ReadLine();
            Console.Write("Plataforma: ");
            string? plataforma = Console.ReadLine();
            Console.Write("Espacio que ocupa en MB: ");
            int espacio = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();//Salto de línea

            datosDelJuego[] juego = new datosDelJuego[cantidad];
            juego[i].titulo = titulo;
            juego[i].plataforma = plataforma;
            juego[i].espacioOcupado = espacio;

            array[i] = juego[i].titulo + " " + juego[i].plataforma +" "+ juego[i].espacioOcupado + "MB. ";

        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(array[i]);
        }



    }
}