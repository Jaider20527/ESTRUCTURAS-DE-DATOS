using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio3
{
    class program
    {
        static void Main(String[] args)
        {
            Random sen = new Random();
            int i,j;
            int x = 3;
            int z = 6;
            int [,] m;
            m = new int[x, z];

            Console.WriteLine("\n La matriz esta compuesta por los datos: ");

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < c; j++)
                    m[i, j] = num.Next(0, 10);
                  Console.WriteLine(m[i, j] + "\t");
                  Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}