using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace ejercicio6
{
    class program
    {

        static void Main(string[] args)
        {
            int numero = 0;
            


            Console.WriteLine("DIGITE NUMERO DEL 1 A 10 :))");
            numero = int.Parse(Console.ReadLine());

           switch (numero)
           {
                   case 1:
                        Console.WriteLine("UNO");
                        break;

                    case 2:
                        Console.WriteLine("DOS");
                        break;

                    case 3:
                        Console.WriteLine("TRES");
                        break;

                    case 4:
                        Console.WriteLine("CUATRO");
                        break;

                    case 5:
                        Console.WriteLine("CINCO");
                        break;

                    case 6:
                        Console.WriteLine("SEIS");
                        break;

                    case 7:
                        Console.WriteLine("SIETE");
                        break;

                    case 8:
                        Console.WriteLine("OCHO");
                        break;

                    case 9:
                        Console.WriteLine("NUEVE");
                        break;

                    case 10:
                        Console.WriteLine("DIEZ");
                        break;

                    default:
                        Console.WriteLine("DIGITE NUMERO VALIDO DE 1 A 10 :)");
                        break;
           }
        }
    }
}