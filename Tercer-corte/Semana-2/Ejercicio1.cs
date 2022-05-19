using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1

{
    class Empleado
    {
        string nombre;
        float sueldo;

        public void Datos() 
        {
            string linea;
            Console.Write("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su sueldo:");
            linea = Console.ReadLine();
            sueldo=float.Parse(linea);
        }

        public void Impuestos() 
        {
            if (sueldo>3000) 
            {
                Console.WriteLine("Debe pagar impuestos");
            } 
            else
            {
                Console.WriteLine("No  debe pagar impuestos");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Empleado empleado1= new Empleado();
            empleado1.Datos();
            empleado1.Impuestos();
        }
    }
}
