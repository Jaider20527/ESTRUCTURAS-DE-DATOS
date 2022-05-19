using System;

 public class Ejercicio3
 {
	private string nombre;
	private int antiguedad;

	public Ejercicio3(Scanner teclado)
	{
		Console.Write("Ingrese el nombre del socio:");
		nombre = teclado.next();
		Console.Write("Ingrese la antiguedad:");
		antiguedad = teclado.Next();
	}

	public virtual void imprimir()
	{
		Console.WriteLine(nombre + " tiene una antiguedad de " + antiguedad);
	}

	public virtual int retornarAntiguedad()
	{
		return antiguedad;
	}
 }



  public class Club
  {
	private Socio socio1, socio2, socio3;
	private Scanner teclado;

	public Club()
	{
	  teclado = new Scanner(teclado);
	  socio1 = new Socio(teclado);
	  socio2 = new Socio(teclado);
	  socio3 = new Socio(teclado);
	}

	public virtual void mayorAntiguedad()
	{
		Console.Write("Socio con mayor antiguedad:");
		if (socio1.retornarAntiguedad() > socio2.retornarAntiguedad() && socio1.retornarAntiguedad() > socio3.retornarAntiguedad())
		{
			socio1.imprimir();
		}
		else
		{
			if (socio2.retornarAntiguedad() > socio3.retornarAntiguedad())
			{
				socio2.imprimir();
			}
			else
			{
				socio3.imprimir();
			}
		}
	}

	public static void Main(string[] ar)
	{
		Club club1 = new Club();
		club1.mayorAntiguedad();
	}
  }