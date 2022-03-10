using System;

namespace ejercicio2
{
    class Program
    {
        static object Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, na;
            int contadorPares = 0, contadorImpares = 0;

            Console.WriteLine("Ingrese un Numero");
            n1 = int.Parse(Console.ReadLine());
            
                if (n1 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n2 = int.Parse(Console.ReadLine());
            
                if (n2 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n3 = int.Parse(Console.ReadLine());
            
                if (n3 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n4 = int.Parse(Console.ReadLine());
            
                if (n4 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n5 = int.Parse(Console.ReadLine());
            
                if (n5 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n6 = int.Parse(Console.ReadLine());
            
                if (n6 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n7 = int.Parse(Console.ReadLine());
            
                if (n7 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n8 = int.Parse(Console.ReadLine());
            
                if (n8 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            n9 = int.Parse(Console.ReadLine());
            
                if (n9 % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;
            

            Console.WriteLine("Ingrese un Numero");
            na = int.Parse(Console.ReadLine());
            
                if (na % 2 == 0)
                    contadorPares = contadorPares + 1;
                else
                    contadorImpares = contadorImpares + 1;

            Console.WriteLine("Cantidad de Pares: "+ contadorPares+ " Cantidad de Impares: "+ contadorImpares);

            double promedio = Convert.ToDouble(n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + na) / 10;
            Console.Write("El promedio de los numeros es: " + promedio);

        }   
    }
}