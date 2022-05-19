using System;

class Ejercicio12
{
   public static void Main()
   {
   string str = "Hellooooo";
   char uno = '.';

   Console.WriteLine(str.PadLeft(15, uno));
   Console.WriteLine(str.PadLeft(2, uno));
   }
}