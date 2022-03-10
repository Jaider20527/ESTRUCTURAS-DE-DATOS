using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class program
{
    public static void Main()
    {
        int j;
        char i;
        string frase;
        int vocales = 0;
        int consonantes = 0;
        int espacio = 0;
        string s;

        Console.Write("por favor ingrese una frase");
        frase = Console.ReadLine();

        for (j = 0; j < frase.Length; j++) ;
        {
            i = frase[j];
            int c = char.ToLower(i);
            
            if ( s == "a" || s == "e" || s == "i" || s == "o" || s == "u")
            {

                vocales++;

            }

            else if (s == "a" || s == "b" || s == "c" || s == "d" || s == "e" || s == "f" || s == "g" || s == "h" || s == "i" || s == "j" || s == "k" || s == "l" || s == "m" || s == "n" || s == "ñ" || s == "o" || s == "p" || s == "q" || s == "r" || s == "s" || s == "t" || s == "u" || s == "v" || s == "w" || s == "x" || s == "y" || s == "z")
            {
                consonantes++;
            }

            else if ((s == " ")) ;
            {
                espacio++;
            }




        }
        Console.WriteLine();
        Console.WriteLine(" La frase tiene " + vocales + " vocales");
        Console.WriteLine(" La frase tiene " + espacio + " espacios");
        Console.WriteLine(" La frase tiene " + consonantes + "consonantes");
        Console.WriteLine(" La frase tiene " + frase.Length + " numeros");
        Console.ReadKey();
    }

}