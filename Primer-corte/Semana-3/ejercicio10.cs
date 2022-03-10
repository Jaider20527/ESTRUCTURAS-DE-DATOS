using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;





namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {



            int CantidadVacunas = 0;
            int VACUANSDIAS = 1000;
            int sitio = 0;
            int VCT1 = 150;
            int VCT2 = 200;
            int VCT3 = 500;



            Console.WriteLine("Bienvenido ");
            Console.WriteLine("");
            Console.WriteLine("Con esta aplicacion podras saber en que sitios de vacunacion hay por debajo de 200" +
            "dosis");





            Console.WriteLine("");
            Console.WriteLine("Seleccionar el establecimiento que quiera consultar");
            Console.WriteLine("");





            Console.WriteLine("1-La colina");
            Console.WriteLine("2-Simon bolivar");
            Console.WriteLine("3-Cardio Infantil");
            sitio = int.Parse(Console.ReadLine());





            switch (sitio)
            {
                case 1: Console.WriteLine("Usted escogio La Colina"); break;
                case 2: Console.WriteLine("Usted escogio El Simon Bolivar"); break;
                case 3: Console.WriteLine("Usted escogio Cardio Infantil"); break;



            }



            switch (sitio)
            {
                case 1:
                    if (VCT1 < 200)
                    {
                        Console.WriteLine("En este hospital no hay 200 vacunas disponibles");
                    }
                    else if (VCT1 >= 200)
                    {

                        Console.WriteLine("en el hospital si hay las vacunas necesarias);");

                    }
                    break;



                case 2:
                    if (VCT2 < 200)
                    {
                        Console.WriteLine("En este hospital no hay 200 vacunas disponibles");
                    }
                    else if (VCT2 >= 200)
                    {

                        Console.WriteLine("en el hospital si hay las vacunas necesarias");


                    }
                    break;


                case 3:
                    if (VCT3 < 200)
                    {
                        Console.WriteLine("En este hospital no hay 200 vacunas disponibles");
                    }
                    else if (VCT3 >= 200)


                    {

                        Console.WriteLine("en el hospital si hay las vacunas necesarias");

                    }
                    break;
            }


                    Console.WriteLine("");
                    Console.WriteLine("En el hospital La colina, el dia de hoy tiene un balance de {0} ",VCT1);

                    Console.WriteLine("");
                    Console.WriteLine("En el hospital Simon Bolivar, el dia de hoy tiene un balance de {0} ", VCT2);
                    Console.WriteLine("");

                    Console.WriteLine("En el hospital Cardio Infantil, el dia de hoy tiene un balance de {0} ", VCT3);
                    Console.WriteLine("");



        }
    }
}