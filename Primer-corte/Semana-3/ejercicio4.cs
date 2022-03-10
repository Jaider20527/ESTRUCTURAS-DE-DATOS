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
            int num;
            double resultado = 0;
            Console.WriteLine("Digite numero entero para realizar la operacion: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                resultado =  1 + (1.0 / i);

            }

            Console.WriteLine("El resultado de la suma de fraccionarios es: " + resultado);
        }
    }
}