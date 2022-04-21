using System;
using System.Linq;
using System.Collections;

namespace Ejercicio9
{
    
    class Program
    {
        int[] vector;
        int numerosGanarLo, numerosGanarLo1, numerosGanarLo2, numerosGanarLo3, numerosGanarLo4;
        int numeroPosi;
        int contadorApuestas;
        int limiteIntentos;
        public void pedirDa()
        {
           
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria1 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria2 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria3 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("Ingrese los numeros de loteria de entre 0 y 1000");
                numerosGanarLoteria4 = int.Parse(System.Console.ReadLine());
            
            Console.WriteLine("Cuantos intentos desea realizar");
            limiteIntentos = int.Parse(System.Console.ReadLine());
            vector = new int[limiteIntentos];
           }
    
        public void operarVec()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Random posibilidades = new Random();
                numeroPosibilidades = posibilidades.Next(0, 1001);
                Console.WriteLine("El numero es: " + numeroPosibilidades);
                contadorApuestas++;
                if (numeroPosi == numerosGanarLo || numeroPosi==numerosGanarLo1
                    ||numeroPosi==numerosGanarLo2 || numeroPosi==numerosGanarLo3
                    ||numeroPosi==numerosGanarLo4)
                {
                    Console.WriteLine("El numero de loteria es: " + numeroPosi);
                    Console.WriteLine($"Se necesitan {contadorApuestas} intentos para poder ganar con algun numero de la loteria");
                    
                }
              
            }
        }
            static void Main(string[] args)
            {
                Program loteria = new Program();
                loteria.pedirDa();
                loteria.operarVec();
           }
     }
}

