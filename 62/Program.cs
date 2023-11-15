using System;
class E62
{
    static void Main()
    {

        System.Console.WriteLine("Extraer números de una frase");

        System.Console.WriteLine("Ingrese una frase con números");
        string frase = Console.ReadLine();


        foreach (char letra in frase)
        {
            if ((letra >= (int)'0') && (letra <= (int)'9'))
            {
                Console.Write(letra);
            }

        }

        System.Console.WriteLine(); //Salto de línea al final

    }
}