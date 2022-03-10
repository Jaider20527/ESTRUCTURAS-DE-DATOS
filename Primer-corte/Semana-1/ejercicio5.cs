using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            double Numero = 0;
            Console.WriteLine("digite el numero del Radicando");
            Numero= double.Parse(System.Console.ReadLine());
            double raizCuadrada = Math.Sqrt(Numero);
            Console.WriteLine("La raíz cuadrada de {0} es {1}", Numero, raizCuadrada);
        }
    }
}