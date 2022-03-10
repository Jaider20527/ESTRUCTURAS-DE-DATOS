using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio4
{
    class program
    {
        static void Main()
        {
            int[]numeros = new int[10];
            int operacion=0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero deseado: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite 1 para ordenar de menor a mayor");
                operacion = int.Parse(Console.ReadLine());

            
            if (operacion==1)
            { 
           
             Array.Sort(numeros);

              Console.WriteLine("\nLos números ordenados son:");

                  for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

     
        }
    }
}