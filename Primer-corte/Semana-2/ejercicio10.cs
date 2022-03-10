using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;
            int descuento0, descuento1, descuento2, descuento3;
            int CUADRADO = 50;
            int a, a2, a3, b1, b2, b3;

            Console.WriteLine("Bienvenido, con esta aplicacion podras saber el costo de tu terreno, en metros cuadrados");
            Console.WriteLine("El valor de cada metro cuadrado es de 50$");
            Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("Ingrese el numero de metros cuadrados de su terreno ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 < 400)
            {
                descuento0 = (CUADRADO * n1);
                Console.WriteLine("El valor de su terreno es de {0}$ sin ningun tipo de descuento", descuento0);
            }
            else if (n1 >= 400)
            { 
                a= (CUADRADO*n1);
                descuento1 = (a*10/100); b1 = (a - descuento1);

                Console.WriteLine("El valor de su terreno es de {0}$ con el 10% de descuento ya que supera los" +
                    " 400 metros cuadrados ",b1);
            }
            else if (n1 >= 500)
            {
                a2= (CUADRADO * n1);
                descuento2 = (a2 * 17/100); b2 = (a2 - descuento2);

                Console.WriteLine("El valor de su terreno es de {0}$ con el 17% de descuento ya que supera los" +
                    "500 metros cuadrados ", b2);
            }
            else if (n1 >= 1000)
            {
                a3 = (CUADRADO * n1);
                descuento3= (a3 * 25 / 100); b3 = (a3 - descuento3);

                Console.WriteLine("El valor de su terreno es de {0}$ con el 17% de descuento ya que supera los" +
                    "1000 metros cuadrados ", b3);
            }
        }
    }
}