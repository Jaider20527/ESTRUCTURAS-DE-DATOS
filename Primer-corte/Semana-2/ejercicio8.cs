using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  static void Main()
{

    int mes;
    
    Console.WriteLine("introduzca numero de mes");
    mes = int.Parse(Console.ReadLine());

    if (mes < 1 || mes > 12)
        Console.WriteLine("Mes incorrecto");
     else { 
    
        switch (mes)
        {
            case 1:
                Console.WriteLine("Enero");
                break;
            case 2:
                Console.WriteLine("Febrero");
                break;
            case 3:
                Console.WriteLine("Marzo");
                break;
            case 4:
                Console.WriteLine("Abril");
                break;
            case 5:
                Console.WriteLine("Mayo");
                break;
            case 6:
                Console.WriteLine("Junio");
                break;
            case 7:
                Console.WriteLine("Julio");
                break;
            case 8:
                Console.WriteLine("Agosto");
                break;
            case 9:
                Console.WriteLine("Septiembre");
                break;
            case 10:
                Console.WriteLine("Octubre");
                break;
            case 11:
                Console.WriteLine("Noviembre");
                break;
            case 12:
                Console.WriteLine("Diciembre");
                break;
        }
        if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            Console.WriteLine("Es un mes de 30 dias");
          
          else if (mes == 2)
            Console.WriteLine("Es un mes de 28 dias");
             else
                 Console.WriteLine("Es un mes de 31 dias");


        
     }
  }