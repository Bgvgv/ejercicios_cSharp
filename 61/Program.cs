/*
61. Crea un programa que pida al usuario un símbolo y 
responda si se trata de un operador (+ - * / %), un símbolo de puntuación (. , ; : ),
 un dígito (0 al 9), o algún otro símbolo. Debes emplear el tipo de datos "char" 
 y hacerlo de dos formas distintas (en un mismo programa): primero usando "if" 
 y después empleando "switch". Recuerda agrupar casos cuando sea posible.
*/

using System;
class E61
{
    static void Main()
    {
        char simbolo;
        Console.Write("Escribe un símbolo: ");
        simbolo = Convert.ToChar(Console.ReadLine());

        if ((simbolo == '+') || (simbolo == '-') || (simbolo == '*') || (simbolo == '/') || (simbolo == '%'))
        {
            Console.WriteLine("{0} es un operador", simbolo);
        }
        else if ((simbolo == '.') || (simbolo == ',') || (simbolo == ';') || (simbolo == ':'))
        {
            Console.WriteLine("{0} es un símbolo de puntuación", simbolo);
        }
        else if ((simbolo >= 'a') && (simbolo <= 'z'))
        {
            Console.WriteLine("{0} es una letra", simbolo);
        }
        else if ((simbolo >= '0') || (simbolo <= '9'))
        {
            Console.WriteLine("{0} es un número", simbolo);
        }

       




    }
}