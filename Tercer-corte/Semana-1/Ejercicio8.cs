namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string palabra = "este es el ejercicio de Endswith";
           
            Console.WriteLine(palabra);
            Console.WriteLine(palabra.EndsWith("Endswith"));
            Console.WriteLine(palabra.EndsWith("Ejercicio"));
        }
    }
}