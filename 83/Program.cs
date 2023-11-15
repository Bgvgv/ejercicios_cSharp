/*
83. Crea un "struct" para almacenar algunos datos de juegos de ordenador o consola, 
de momento sólo: título (cadena de texto), plataforma (cadena de texto), espacio ocupado 
(en MB, número entero). Pide al usuario datos de 2 juegos (sin usar todavía ningún array) 
y luego muéstralos.
*/ //Boris Garcés Vernier


using System;
class E81
{

    struct datosDelJuego
    {
        public string titulo;
        public string plataforma;

        public int espacioOcupado;

    }

    static void Main()
    {

        

        Console.WriteLine("Introduce los datos del juego");
        Console.Write("Título: ");
        string? titulo = Console.ReadLine();
        Console.Write("Plataforma: ");
        string? plataforma = Console.ReadLine();
        Console.Write("Espacio que ocupa en MB: ");
        int espacio = Convert.ToInt32(Console.ReadLine());

        datosDelJuego juego1;
        juego1.titulo = titulo;
        juego1.plataforma = plataforma;
        juego1.espacioOcupado = espacio;
        Console.WriteLine("Datos del juego: Nombre: {0}, Plataforma: {1}, Espacio que ocupa: {2} MG", juego1.titulo, juego1.plataforma, juego1.espacioOcupado);

        Console.WriteLine("Introduce los datos del juego");
        Console.Write("Título: ");
        string? titulo2 = Console.ReadLine();
        Console.Write("Plataforma: ");
        string? plataforma2 = Console.ReadLine();
        Console.Write("Espacio que ocupa en MB: ");
        int espacio2 = Convert.ToInt32(Console.ReadLine());

        datosDelJuego juego2;
        juego2.titulo = titulo2;
        juego2.plataforma = plataforma2;
        juego2.espacioOcupado = espacio2;
        Console.WriteLine("Datos del juego: Nombre: {0}, Plataforma: {1}, Espacio que ocupa: {2} MG", juego2.titulo, juego2.plataforma, juego2.espacioOcupado);

    }
}