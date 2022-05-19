using System;

class Ejercicio21
{

    public static void Main()
    {

        string c1 = "-----comoestasx000000000000*";

        char[] charsToTrim1 = { '*', '0' };

        string c2 = "  abc         ";
        string c3 = "  -ABC--------";

        Console.WriteLine("Antes:");
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);

        Console.WriteLine("");

        Console.WriteLine("Despues:");

        Console.WriteLine(c1.TrimStart(charsToTrim1));
        Console.WriteLine(c2.TrimStart());
        Console.WriteLine(c3.TrimStart('-'));
    }
}