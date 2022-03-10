using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int numero;
            Console.Write("Por favor ingresar un numero :");
            numero = int.Parse(Console.ReadLine());
            {
                if (numero > 0) ;
                else
                    Console.Write("El numero es:" + numero + " y su valor absoluto es:" + Math.Abs(numero));
            }
        }
    }
