using System;
using System.Collections;
using System.Linq;

namespace Ejercicio7
{
    public class Program 
    {

         public static void main(String[] args) {
 
            int Con = 0;
            int pre = 0;
            int pa = 0;

            Console.WriteLine("Ingrese el consumo de energia KiloWats");
            Con = Console.ReadLine(); 
            Console.WriteLine("Su consumo es de: " + Con);
            
            Console.WriteLine("Digita el costo por KiloWat");
            pre = Console.ReadLine();
            Console.WriteLine("El costo por kilowat es:" + pre);
            
            pa= Con * pre;
            Console.WriteLine("El pago por la energia es: " + pa);
         }
    }
}