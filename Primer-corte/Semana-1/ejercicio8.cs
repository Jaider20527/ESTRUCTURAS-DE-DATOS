using System;

class ejercicio8
{
    static void Main()
    {
        string miniscula;
        string letra;
        Console.WriteLine("Digite la letra o digito");
        letra = Console.ReadLine();
        miniscula = Console.ReadLine();
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Console.WriteLine("La letra es una {0} Vocal", letra);
        }
        else
        {
            Console.WriteLine("La letr{0} Vocal", letra);
        }
        if (miniscula == "a" || miniscula == "b" || miniscula == "c" || miniscula == "d" || miniscula == "e" || miniscula == "f" || miniscula == "g" || miniscula == "h" || miniscula == "i" || miniscula == "j" || miniscula == "k" || miniscula == "l" || miniscula == "m" || miniscula == "n" || miniscula == "ñ" || miniscula == "o" || miniscula == "p" || miniscula == "q" || miniscula == "r" || miniscula == "s" || miniscula == "t" || miniscula == "u" || miniscula == "v" || miniscula == "w" || miniscula == "x" || miniscula == "y" || miniscula == "z")
        {
            Console.WriteLine("La letra {0} es una miniscula", miniscula);
        }
        else
        { Console.WriteLine("la letra {0} No es una Minuscula", miniscula); }
    }
}
