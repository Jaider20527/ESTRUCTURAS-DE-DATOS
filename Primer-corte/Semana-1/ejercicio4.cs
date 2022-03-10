using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class program
    {
        static void Main(string[] args)
        {
            int Numero;
            int Valor;
            Console.Write(" por favor ingresar el numero");
            Numero = int.Parse(Console.ReadLine());
            Valor = Numero;

            while (Valor > 1)
            {
                if (Valor % 2 == 0)
                {

                    Valor = (Valor / 2);
                    Console.Write(Valor + " ");

                }
                else { }

                {


                    Valor = (Valor * 3) + 1;
                    Console.Write(Valor + " ");

                }

            }

            Console.WriteLine("/n/n El numero: " + Numero + " tiene como conjetura de collatz consecutivamente:" + Valor);
            Console.ReadKey();

        }
    }

}