using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int n1, n2, n3, n4;

            Console.Write("Hola Estudiante, Escribe tu Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}", nombre);

            Console.WriteLine("Ingrese su Nota de Matematicas ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 < 50)
            {
                Console.WriteLine("Su nota es Insuficiente");
            }
            else if (n1 >= 50)
            {
                Console.WriteLine("Su nota es Suficiente");
            }
            else if (n1 > 59)
            {
                Console.WriteLine("Su nota es Bien");
            }
           else if (n1 > 69)
            {
                Console.WriteLine("Su nota es Notable");
            }
           else if (n1 > 89)
            {
                Console.WriteLine("Su nota es Sobresaliente");
            }
            
            Console.WriteLine("Ingrese su Nota de Español ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 < 50)
            {
                Console.WriteLine("Su nota es Insuficiente");
            }
            else if (n2 >= 50)
            {
                Console.WriteLine("Su nota es Suficiente");
            }
            else if (n2 > 59)
            {
                Console.WriteLine("Su nota es Bien");
            }
            else if (n2 > 69)
            {
                Console.WriteLine("Su nota es Notable");
            }
            else if (n2 > 89)
            {
                Console.WriteLine("Su nota es Sobresaliente");
            }

            Console.WriteLine("Ingrese su Nota de Ingles ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n3 < 50)
            {
                Console.WriteLine("Su nota es Insuficiente");
            }
            else if (n3 >= 50)
            {
                Console.WriteLine("Su nota es Suficiente");
            }
            else if (n3 > 59)
            {
                Console.WriteLine("Su nota es Bien");
            }
            else if (n3 > 69)
            {
                Console.WriteLine("Su nota es Notable");
            }
            else if (n3 > 89)
            {
                Console.WriteLine("Su nota es Sobresaliente");
            }

            Console.WriteLine("Ingrese su Nota de Fisica ");
            n4 = Convert.ToInt32(Console.ReadLine());

            if (n4 < 50)
            {
                Console.WriteLine("Su nota es Insuficiente");
            }
            else if (n4 >= 50)
            {
                Console.WriteLine("Su nota es Suficiente");
            }
            else if (n4 > 59)
            {
                Console.WriteLine("Su nota es Bien");
            }
            else if (n4 > 69)
            {
                Console.WriteLine("Su nota es Notable");
            }
            else if (n4 > 89)
            {
                Console.WriteLine("Su nota es Sobresaliente");
            }

        }
    }
}