using System;
using System.Collections;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lista número 1");
            
            ArrayList Lista1 = new ArrayList();
            
            Lista1.Add(1);
            Lista1.Add(3);
            Lista1.Add(5);
            Lista1.Add(7);
            Lista1.Add(9);

            imprime(Lista1);

            Console.WriteLine("lista número 2");
            
            ArrayList Lista2 = new ArrayList();

            Lista2.AddRange(Lista1);
            
            imprime(Lista2);

            Console.WriteLine("La listas 1 es: ");
            Lista1.Clear();
            imprime(Lista1);
        }
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0},", n);
            Console.WriteLine("\n-----------");
        }
    }
}