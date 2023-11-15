/*
33. Pide dos números enteros al usuario y responde 
cuántos números hay entre ellos (ambos inclusive) 
que sean a la vez pares y múltiplos de 3, así:
Número inicial? 11
Número final? 21
Números pares y a la vez múltiplos de 3 encontrados: 2
*///Boris Garcés Vernier
class Ejercicio_33
{
    static void Main()
    {

        int numeroInicial = 11;
        int numeroFinal = 21;
        int contador = 0;

        for (int i = numeroInicial; i <= numeroFinal; i++)
        {
            if ((i % 2 == 0) && (i % 3 == 0))
            {
                contador++;

            }
        }
        Console.WriteLine("Números pares y a la vez múltiplos de 3 encontrados: {0}", contador);
    }
}
