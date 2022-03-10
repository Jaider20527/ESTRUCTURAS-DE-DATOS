using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)

        {
            int rangoInicio, rangoFinal;

            Console.WriteLine("Ingrese el rango inicial");
            rangoInicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el rango final");
            rangoFinal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nLos numeros pares entre el rango " + rangoInicio + " - " + rangoFinal + " Son :\n");
            for (int i = rangoInicio; i <= rangoFinal; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n\nLos numeros impares entre el rango " + rangoInicio + " - " + rangoFinal + " Son :\n");
            for (int i = rangoInicio; i <= rangoFinal; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Read();
        }
    }
}