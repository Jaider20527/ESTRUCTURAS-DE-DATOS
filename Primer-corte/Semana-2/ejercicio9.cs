using System;

namespace ejercicio9
{
  
    class program
    {
        static void Main(string[] args)
        {
            int Numero_1 = 0;
            int Numero_2 = 0;
            double Resultado = 0;
            int Opcion = 0;


            Console.WriteLine("1 - triangulo");
            Console.WriteLine("2 - circulo");
            

            Console.Write("\nQue opcion deseas escoger: ");
            Opcion = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el primer valor por favor: ");
            {
                Numero_1 = int.Parse(System.Console.ReadLine());

                Console.Write("Dame el segundo valor por favor: ");
                Numero_2 = int.Parse(System.Console.ReadLine());

                if (Opcion == 1)
                    Resultado = Numero_1 * Numero_2 / 2;




                else
                    if (Opcion == 2 )
                    Resultado = Numero_1 * Numero_1 * Math.PI;



            }    Console.WriteLine($"El area es:  {Resultado}");
        }
    }
}