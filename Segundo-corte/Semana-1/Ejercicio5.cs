using System;

public class Ejercicio5
{

	public static void Main(string[] args)
	{

		

		char[] mayusculas = new char[26];
		for (int i = 65, j = 0; i <= 90; i++, j++)
		{
			mayusculas[j] = (char) i;
		}

		string cadena = "";
		int eleccion = -1;

		do
		{
			Console.WriteLine("Elija un indice entre 0 y " + (mayusculas.Length - 1));
			eleccion = sc.Next();

			if (!(eleccion >= 0 && eleccion <= mayusculas.Length - 1))
			{
				Console.WriteLine("Error, inserte otro numero");
			}
			else
			{
				if (eleccion != -1)
				{
					cadena += mayusculas[eleccion];
				}
			}

		} while (eleccion != -1);

		Console.WriteLine(cadena);

	}

}