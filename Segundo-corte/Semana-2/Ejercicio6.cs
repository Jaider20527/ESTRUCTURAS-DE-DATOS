using System;

public class Ejercicio6
{


	internal static string[] nombres = new string[5];
	internal static string[] materias = new string[5];

	internal static double[][] notas = RectangularArrays.RectangularDoubleArray(5, 3);

	public static void Main(string[] args)
	{

		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Registrando alumno #" + (i + 1));
			Console.Write("Nombre: ");
			nombres[i] = teclado.nextLine();
			Console.Write("Materia: ");
			materias[i] = teclado.nextLine();
			Console.Write("Nota 1: ");
			notas[i][0] = double.Parse(teclado.nextLine());
			Console.Write("Nota 2: ");
			notas[i][1] = double.Parse(teclado.nextLine());
			notas[i][2] = (((((notas[i][0] + notas[i][1]) / 2) + 0.5)) * 2) / 2;
			Console.WriteLine("Valor autocalculado para Nota 3: " + notas[i][2]);
			Console.WriteLine("Alumno registrado...\n");
		}

		int opcion = 0;
		do
		{
			Console.WriteLine("\n\n\t\tMENU OPCIONES\n");
			Console.WriteLine("[1] Mostrar nota promedio más alta.");
			Console.WriteLine("[2] Mostrar las 3 notas más bajas.");
			Console.WriteLine("[3] Ordenar de mayor a menor Nota 1.");
			Console.WriteLine("[4] SALIR.");
			Console.Write("Elija opcion: ");
			opcion = int.Parse(teclado.nextLine());
			switch (opcion)
			{
			case 1:
				notaPromedioMasAlta();
				break;
			case 2:
				tresNotasMasBajas();
				break;
			case 3:
				ordenaNota1();
				break;
			case 4:
				Console.WriteLine("\n\t\tFIN DE PROGRAMA");
				break;
			default:
				Console.WriteLine("\nOpcion equivocada. Escoja entre [1-4]");
				break;
			}
		}while (opcion != 4);

		teclado.close();
	}


	private static void notaPromedioMasAlta()
	{

		double masAlta = 0;
		int alumno = 0;

		for (int i = 0; i < notas.Length; i++)
		{
			double sumaNotas = notas[i][0] + notas[i][1] + notas[i][2];
			double promedio = sumaNotas / 3;
			if (promedio > masAlta)
			{
				masAlta = promedio;
				alumno = i;
			}
		}

		Console.Write("\nNota promedio más alta: {0:F2}\n", masAlta);
		Console.WriteLine("Alumno: " + nombres[alumno]);
	}

	private static void tresNotasMasBajas()
	{


		double[] todasNotas = new double[15];
		int z = 0;
		for (int i = 0; i < notas.Length; i++)
		{
			for (int j = 0; j < notas[0].Length; j++)
			{
				todasNotas[z] = notas[i][j];
				z++;
			}
		}
		for (int i = 0; i < todasNotas.Length - 1; i++)
		{
			for (int j = 0; j < todasNotas.Length - i - 1; j++)
			{
				if (todasNotas[j + 1] < todasNotas[j])
				{
					double aux = todasNotas[j + 1];
					todasNotas[j + 1] = todasNotas[j];
					todasNotas[j] = aux;
				}
			}
		}

		Console.WriteLine("\nLas tres notas más bajas son:");
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine("- " + todasNotas[i]);
		}
	}

	private static void ordenaNota1()
	{


		double[] notas1 = new double[5];
		for (int i = 0; i < 5; i++)
		{
			notas1[i] = notas[i][0];
		}
		for (int i = 0; i < notas1.Length - 1; i++)
		{
			for (int j = 0; j < notas1.Length - i - 1; j++)
			{
				if (notas1[j + 1] > notas1[j])
				{
					double aux = notas1[j + 1];
					notas1[j + 1] = notas1[j];
					notas1[j] = aux;
				}
			}
		}

		Console.WriteLine("\nNotas 1 de MAYOR a MENOR:");
		for (int i = 0; i < 5; i++)
		{
			Console.Write(notas1[i] + " ");
		}
	}
}