using System;
using System.Collections; 



namespace Ejercicio6
{
    public class Ejercicio6
    {
        public static void Main()
        {
            String cadena1 = "Hola";
            Console.Write("¿La palabra Hola contiene la letra H?: "); 
            Console.WriteLine(cadena1.Contains("H"));

            Console.WriteLine();

            String cadena2 = "Hello";
            Console.Write("¿La palabra Hello contiene la letra S?: ");
            Console.WriteLine(cadena2.Contains("S"));
 
        }
    }
}
