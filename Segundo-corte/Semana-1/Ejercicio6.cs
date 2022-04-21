using System;

namespace Ejercicio6
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] Matriz;
            int longitudVector;
            int longitudColumna;
            int ultimoDigito;
            Console.WriteLine("Por favor ngrese el tamaño del vector");
            longitudVector = int.Parse(System.Console.ReadLine());
            Matriz = new int[longitudVector];
            Console.WriteLine("Por favor ingrese el ultimo digito que desea ver");
            ultimoDigito = int.Parse(System.Console.ReadLine());
            int f;
            int c = 0;
            Random numeroAleatorio = new Random();
            Console.WriteLine("La matriz es");

            for (f = 0; f < Matriz.Length; f++)
            {
                    Matriz[f] = numeroAleatorio.Next(1, 301);
                    Console.Write("   [" + Matriz[f] + "]");
                    Console.WriteLine();
              
                
                    if (Matriz[f] % 10 == ultimoDigito)
                    {

                        Console.WriteLine("El numero es: [" + Matriz[f] + "]");
                    }
                
            
            }

           
        }

        }
    }

    

    