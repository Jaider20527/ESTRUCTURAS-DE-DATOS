using System;
using System.Collections;


namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilaNumerosAlmacenados;
            ArrayList pilac = new ArrayList();
            ArrayList pilaPn= new ArrayList();
            
            Console.WriteLine("Ingrese el tamaño  de la pila:");
            
            int pila = int.Parse(System.Console.ReadLine()); 
            
            for(int pilaNumeros = 0; pilaNumeros < pila; pilaNumeros++)
            {
                
                Console.WriteLine($"Ingrese elemento {pilaNumeros+1}");
                
                pilaNumerosAlmacenados = int.Parse(System.Console.ReadLine());
                pilac.Add(pilaNumerosAlmacenados);
            }
            
            pilac.Sort();
            
            imprimir(pilac);
            
            Console.WriteLine("Copia de la pilac");
            
            Console.WriteLine(" ");
            
            imprimir(pilac);
            
            
            static void imprimir(ArrayList arreglo)
            {
                foreach (int p in arreglo)
                    Console.Write($" {p}");
                Console.WriteLine("\n-----------");
            }
        }
    }
}