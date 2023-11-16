/*
85. Vamos a añadir un "struct anidado" al ejercicio anterior: 
Crea un "struct" para almacenar algunos datos de juegos de ordenador o consola, 
de momento sólo: título (cadena de texto), plataforma (cadena de texto), 
espacio ocupado (en MB, número entero) y fecha de lanzamiento (mes y año, 
en forma de struct anidado). Pide al usuario datos de 3 juegos (que serán 
parte de un array) y luego muéstralos.
*/ //Boris Garcés Vernier


/*
84. Crea una versión mejorada del ejercicio anterior, que pida al usuario los datos de 3 juegos, los guarde en un array y luego los muestre.
*/ //Boris Garcés Vernier


using System;
class E85
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


            array[i] = 
            "Títuto: " + juego[i].titulo + "\n" + 
            "Plataforma: " +  juego[i].plataforma + "\n" + 
            "Espacio: " +  juego[i].espacioOcupado + ".MB " + "\n"+ 
            "Fecha de lanzamiento: " +  +juego[i].fechaLanzamiento.mes + "/" + juego[i].fechaLanzamiento.anyo + ".";

        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(array[i]);
            System.Console.WriteLine();//Salto de Línea
        }



    }
}