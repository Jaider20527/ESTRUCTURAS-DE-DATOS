using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int num;
            char fin;
            do
            {
                Console.WriteLine("Ingrese un Numero mayor a 100");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Segundo numero ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("1 = Suma 2 = Resta 3 = Multiplicacion 4 = Division");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;
                    case 2:
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine(a / b);
                        break;
                }
                Console.WriteLine("CONTINUAR [S/N]");
                fin = char.Parse(Console.ReadLine().ToUpper());

            }
        }
    }
}