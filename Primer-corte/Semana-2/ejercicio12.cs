using System;



namespace ejercicio12
{

    class program
    {
        static void Main(string[] args, int nodescuento)
        {
            int Valormetro = 500;
            int Tipodecable = 0;
            int Metro = 0;
            int Valorcablecoaxial;
            int Valorcabletrenzado;
            int Valorcabledered;
            int total;



            Console.WriteLine("Bienvenido a la ferreteria don paco, aqui podra consultar el valor del metro del cable" +
            "segun el que escoja ");
            Console.WriteLine("");

            Console.WriteLine("A continuacion se le va a mostrar diferentes opciones de cable que desee consultar");
            Console.WriteLine("");

            Console.WriteLine("1- Cable de par trenzado.");

            Console.WriteLine("2- Cable de red");

            Console.WriteLine("3- Cable coaxial.");


            Console.WriteLine("seleccionar que tipo de cable desea: ");
            Tipodecable = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (Tipodecable)
            {
                case 1: Console.WriteLine("Ha seleccionado el tipo de cable trenzado"); break;
                case 2: Console.WriteLine("Ha seleccionado el tipo de cable de red"); break;
                case 3: Console.WriteLine("Ha seleccionado el tipo de cable coaxial"); break;


            }



            Console.WriteLine("Digitar un valor de metros que dessea consultar: ");
            Console.WriteLine("");
            Metro = int.Parse(Console.ReadLine());



            switch (Tipodecable)
            {

                case 1:

                    Valormetro = ((Metro * 5) / 100);
                    Valorcabletrenzado = Metro - Valormetro;

                    Console.WriteLine("debido a que usted compro una cantidad entre 20 a 40 metros de cable, se le realizara un descuento del 5%" +
                        "a pagar es de {0}", Valorcabletrenzado); break;



                case 2:

                    Valormetro = ((Metro * 5) / 100);
                    Valorcabletrenzado = Metro - Valormetro;

                    Console.WriteLine("debido a que usted compro una cantidad entre 20 a 40 metros de cable, se le realizara un descuento del 5%" +
                        "a pagar es de {0}", Valorcabletrenzado); break;

                case 3:

                    Valormetro = ((Metro * 5) / 100);
                    Valorcabletrenzado = Metro - Valormetro;

                    Console.WriteLine("debido a que usted compro una cantidad entre 20 a 40 metros de cable, se le realizara un descuento del 5%" +
                        "a pagar es de {0}", Valorcabletrenzado); break;





            }

            total = Valorcabletrenzado;
            Console.WriteLine("el valor a pagar es de {0}", total);
        }
    }
}