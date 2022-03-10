using System;

public class Program
{
	public static void Main()
	{
        int f, num = 1;
        Console.WriteLine("Introduce el número de líneas del triángulo: ");
        filas = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------------------------------------");
        for (int i = 1; i <= f; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write ("\t" + num);
                num++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("---------------------------------------------------------");
    }

}