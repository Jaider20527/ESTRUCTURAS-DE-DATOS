using System;

namespace Ejercicio13
{
    class Metodos
    {
        static void Main(string[] args)
        {
            string Algo="que tal tu dia ";
            char Signo='?';

            Console.WriteLine(Algo);
            Console.WriteLine(Algo.PadRight(15, Signo));
            Console.WriteLine(Algo.PadRight(20, Signo));
        }
    } 
}