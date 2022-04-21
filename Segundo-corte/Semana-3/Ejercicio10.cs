using System;
using System.Collections;


namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dat = new ArrayList();
            ArrayList dat2 = new ArrayList();
            int limite = 0;
            int elemento;
            
            
            Console.WriteLine("Ingrese cuantos elementos va a ingresar: ");
            limite = int.Parse(System.Console.ReadLine());
            
            
            for (int i = 0; i < limite; i++){
                Console.WriteLine($"Ingrese el elemento {i+1}: ");
                
                elemento = int.Parse(System.Console.ReadLine());
                dat.Add(elemento);
            }
            
            Console.WriteLine("1ra lista: ");
            foreach (int n in dat){
                Console.WriteLine(n);
            } 
            
            dat2.AddRange(dat);
            dat2.Reverse();
            
            
            Console.WriteLine("2da lista: ");
            foreach (int n in dat2){
                Console.WriteLine(n);
            } 
        }
    }
}