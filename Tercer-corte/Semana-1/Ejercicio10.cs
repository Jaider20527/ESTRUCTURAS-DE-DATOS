namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string palabra = "Ejercicio con metodo Insert";

            Console.WriteLine(palabra);
            Console.WriteLine(palabra.Insert (16 ,"**")) ;
            Console.WriteLine(palabra.Insert(7, "AQUI"));
            Console.ReadLine();
           
        }
    }
}