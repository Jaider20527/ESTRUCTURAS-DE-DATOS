using System;
namespace ejercicio8
{

    class ejercicio8
    {
        static void Main(String[] args)
        {


            acciones o = new acciones();
            o.pedir_datos();
            o.sumar();      
            o.restar();
            o.multiplicar();
            o.dividir();

            Console.ReadKey();


        }
    }
}


class acciones
{
    double a, b;

    public void pedir_datos()
    {
        Console.WriteLine("Digite el primer numero");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el segundo numero");
        b = int.Parse(Console.ReadLine());


        while (a <= 0 || b <= 0)
        {
            Console.Clear();
            Console.WriteLine("Digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = int.Parse(Console.ReadLine());

        }

    }


    public void sumar()
    {
        Console.WriteLine("La suma de {0} + {1} es {2}", a, b, a + b);
    }

    public void restar()
    {
        Console.WriteLine("La resta de {0} - {1} es {2}", a, b, a - b);
    }

    public void multiplicar()
    {
        Console.WriteLine("La multiplicacion de{0} x {1} es {2}", a, b, a * b);
    }

    public void dividir()
    {
        Console.WriteLine("La divicion de {0} / {1} es {2}", a, b, a / b);
    }

}