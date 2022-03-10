using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {



            int Empleado1h = 123456;
            int Empleado2h= 147258;
            int Empleado3h = 987654;
            int Empleado4h = 321654;
            int Empleado1m = 546987;
            int Empleado2m = 357894;
            int Empleado3m= 201357;
            int Empleado4m = 145780;
            int Tipoe = 0;
            int Generoe = 0;
            int VCT3 = 500;

            Empleado1h = 1;
            Empleado2h = 1;
            Empleado3h = 1;
            Empleado4h = 1;
            Empleado1m= 2;
            Empleado2m= 2;
            Empleado3m = 2;
            Empleado4m = 2;

            int Sueldo1h = 1200000;
            int Sueldo2h = 850000;
            int Sueldo3h = 2500000;
            int Sueldo4h = 1000000;
            int Sueldo1m = 1200000;
            int Sueldo2m = 1600000;
            int Sueldo3m = 1100000;
            int Sueldo4m = 950000;




            Console.WriteLine("Bienvenido ");
            Console.WriteLine("");
            Console.WriteLine("Esta es la nueva aplicacion de LASC, con ella podra consultar cuantar distinta informacion acerca" +
            "de nuestros empleados");





            Console.WriteLine("");
            Console.WriteLine("1-hombres");
            Console.WriteLine("2-Mujeres");
            Console.WriteLine("Seleccionar el tipo de empleado que desea consultar");
            Console.WriteLine("");
            Generoe= int.Parse(Console.ReadLine());

            switch (Generoe)
            {
                   case 1:
                    Console.WriteLine("ha seleccionado Hombre");
                    break;
                    case 2:
                    Console.WriteLine("Ha seleccionado Mujer");
                    break;
            }

            Console.WriteLine("Digite el legajo del empleado");
            Tipoe = int.Parse(Console.ReadLine());




            switch (Tipoe)
            {
                case 123456:
                    Console.WriteLine("ha Seleccionado al empleado Juan Luis Guerra");
                    Console.WriteLine("El sueldo de Juan Luis es de {0}",Sueldo1h);break;

                case 147258:
                    Console.WriteLine("ha Seleccionado al empleado Roberto Carlos");
                    Console.WriteLine("El sueldo de Roberto Carlos es de {0}", Sueldo2h); break;

                case 987654:

                    Console.WriteLine("ha Seleccionado al empleado Benito Suarez");
                    Console.WriteLine("El sueldo de Benito Suarez es de {0}", Sueldo3h); break;

                case 321654:

                    Console.WriteLine("ha Seleccionado al empleado Carlos Rojas");
                    Console.WriteLine("El sueldo de Carlos Rojas es de {0}", Sueldo4h); break;


                case 546987:

                    Console.WriteLine("ha Seleccionado al empleado Sofia Linares");
                    Console.WriteLine("El sueldo de Sofia Linares es de {0}", Sueldo1m); break;


                case 357894:

                    Console.WriteLine("ha Seleccionado al empleado Leidy Peña");
                    Console.WriteLine("El sueldo de Leidy Peña es de {0}", Sueldo2m); break;


                case 201357:

                    Console.WriteLine("ha Seleccionado al empleado Catalina Pardo");
                    Console.WriteLine("El sueldo de Catalina Pardo es de {0}", Sueldo3m); break;


                case 145780:

                    Console.WriteLine("ha Seleccionado al empleado Paula Cardozo");
                    Console.WriteLine("El sueldo de Paula Cardozo es de {0}", Sueldo4m); break;


            }

            Console.WriteLine("Seleccione 1- Para ver los Sueldos de los hombres");
            Console.WriteLine("Seleccione 2- Para ver los Sueldos de los Mujeres");
            Generoe = int.Parse(Console.ReadLine());

            switch (Generoe)
            {
                case 1:
                    if (Sueldo1h < 900000)
                    {
                        Console.WriteLine("el Dueldo de Juan Luis es menor de 900000");
                    }
                    
                        else if (Sueldo1h>900000)
                    { 
                            Console.WriteLine("El sueldo de Juan Luis es mayor de 900000");
                    }
                    if (Sueldo2h < 900000)
                    {
                        Console.WriteLine("el Dueldo de Roberto Carlos es menor de 900000");
                    }

                    else if (Sueldo2h > 900000)
                    {
                        Console.WriteLine("El sueldo de Roberto Carlos es mayor de 900000");
                    }
                    if (Sueldo3h < 900000)
                    {
                        Console.WriteLine("el Dueldo de Benito Suarez es menor de 900000");
                    }

                    else if (Sueldo3h > 900000)
                    {
                        Console.WriteLine("El sueldo de Benito Suarez es mayor de 900000");
                    }
                    if (Sueldo4h < 900000)
                    {
                        Console.WriteLine("el Dueldo de Carlos Rojas es menor de 900000");
                    }

                    else if (Sueldo4h > 900000)
                    {
                        Console.WriteLine("El sueldo de Carlos Rojas es mayor de 900000");
                    }

                    break;



                case 2:
                    if (Sueldo1m>1200000)
                    {
                        Console.WriteLine("el Dueldo de Sofia Carodozo es menor de 900000");
                    }

                    else if (Sueldo1m < 1200000)
                    {
                        Console.WriteLine("El sueldo de Sofia CArdozo es mayor de 900000");
                    }
                    if (Sueldo2m > 1200000)
                    {
                        Console.WriteLine("el Dueldo de Leidy Peña es menor de 900000");
                    }

                    else if (Sueldo2m < 1200000)
                    {
                        Console.WriteLine("El sueldo de Leidy Peña es mayor de 900000");
                    }
                    if (Sueldo3m > 1200000)
                    {
                        Console.WriteLine("el Dueldo de Catalina Pardo es menor de 900000");
                    }

                    else if (Sueldo3m < 1200000)
                    {
                        Console.WriteLine("El sueldo de Catalina PArdo es mayor de 900000");
                    }
                    if (Sueldo4m > 1200000)
                    {
                        Console.WriteLine("el Dueldo de Paula Cardozo es menor de 900000");
                    }

                    else if (Sueldo4m < 1200000)
                    {
                        Console.WriteLine("El sueldo de PAula Cardozo es mayor de 900000");
                    }
                    break;
            }

        }
    }
}