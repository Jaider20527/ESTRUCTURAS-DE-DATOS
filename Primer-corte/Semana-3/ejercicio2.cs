using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Por favor digite un numero:");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("---------------");
		for (int y = 1; y <= a; y++)
		{
			for (int x = 1; x <= a - y; x++)
			{
				Console.Write(" ");
			}

			for (int x = 1; x <= y; x++)
			{
				Console.Write("*");
			}

			for (int x = 1; x <= y - 1; x++)
			{
				Console.Write("*");
			}

			Console.WriteLine();
		}
		Console.WriteLine("---------------");
	}
}