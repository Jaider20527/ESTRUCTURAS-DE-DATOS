using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            Console.WriteLine("Primer Nivel: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo Nivel: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tercer Nivel: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 == n2 && n1 == n3)
                Console.WriteLine("Es Equilatero");

            else
            {
                if (n1 == n2 || n1 == n3 || n3 == n2)
                    Console.WriteLine("Es Isoceles");
                else
                {
                    if (n1 != n2 || n1 != n3 || n3 != n2)
                        Console.WriteLine("Es Escaleno");
                }
            }
            Console.Read();
        }
    }
}