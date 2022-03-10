using System;
using System;



namespace ejercicio11
{

    class program
    {
        static void Main(string[] args)
        {
            int Numero_1 = 0;
            int Numero_2 = 0;
            int Numero_3 = 0;
            double Resultado = 0;
            int Opcion = 0;
            int Opcion2= 0;
            int Opcion3 = 0;
            int total = 0;



            Console.WriteLine("Bienvenido, con esta aplicacion podra saber cual es el costo de sus, servicios segun su estrato");
            Console.WriteLine("");
            Console.WriteLine("1 - estrato 1");
            Console.WriteLine("2 - estrato 2");
            Console.WriteLine("3 - estrato 3");
            Console.WriteLine("4 - estrato 4");



            Console.Write("\nSeleccione su estrato segun el numero dado: ");
            Opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (Opcion)
            {
                case 1: Console.WriteLine("ha selecionado estrato 1");break;
                    
                case 2: Console.WriteLine("ha selecionado estrato 2"); break;
                    
                case 3: Console.WriteLine("ha selecionado estrato 3"); break;
                   
                case 4: Console.WriteLine("ha selecionado estrato 4"); break;

            }

            Console.WriteLine("");
            Console.Write("seleccione el valor a pagar de la Luz: ");
            Numero_1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("");
            { 
            
                

                switch(Opcion)
                {
                    case 1:

                        Opcion2 = ((Numero_1 * 17) / 100);
                        Opcion3 = Numero_1 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 1, se le hace un descuento del 17% ,por lo cual el valor" +
                            "a pagar es de {0}", Opcion3);break;
                   
                    case 2:

                        Opcion2 = ((Numero_1 * 15) / 100);
                        Opcion3 = Numero_1 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 2, se le hace un descuento del 15%, por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;
                    
                    
                    case 3:

                        Opcion2 = ((Numero_1 * 9) / 100);
                        Opcion3 = Numero_1 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 3, se le hace un descuento del 9% por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;
                    
                    
                    case 4:
                        Opcion2 = ((Numero_1 * 9) / 100);
                        Opcion3 = Numero_1 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 4, se le hace un descuento del 9% por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;

                }




                Console.WriteLine("");
                Console.Write("seleccione el valor a pagar de el agua: ");
                Numero_2 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("");



                switch (Opcion)
                {
                    case 1:

                        Opcion2 = ((Numero_1 * 17) / 100);
                        Opcion3 = Numero_2 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 1, se le hace un descuento del 17% ,por lo cual el valor" +
                            "a pagar es de {0}", Opcion3); break;

                    case 2:

                        Opcion2 = ((Numero_2 * 15) / 100);
                        Opcion3 = Numero_2 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 2, se le hace un descuento del 15%, por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;


                    case 3:

                        Opcion2 = ((Numero_2 * 9) / 100);
                        Opcion3 = Numero_2 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 3, se le hace un descuento del 9% por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;


                    case 4:
                        Opcion2 = ((Numero_2 * 9) / 100);
                        Opcion3 = Numero_2 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 4, se le hace un descuento del 9% por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;

                }



                Console.WriteLine("");
                Console.Write("seleccione el valor a pagar de el gas: ");
                Numero_3 = int.Parse(System.Console.ReadLine());
                Console.WriteLine("");


                switch (Opcion)
                {
                    case 1:

                        Opcion2 = ((Numero_3 * 17) / 100);
                        Opcion3 = Numero_3 - Opcion2;
                        total = Opcion3;
                        Console.WriteLine("debido a que usted es estrato 1, se le hace un descuento del 17% ,por lo cual el valor" +
                            "a pagar es de {0}", Opcion3); break;

                    case 2:

                        Opcion2 = ((Numero_3 * 15) / 100);
                        Opcion3 = Numero_3 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 2, se le hace un descuento del 15%, por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;


                    case 3:

                        Opcion2 = ((Numero_3 * 9) / 100);
                        Opcion3 = Numero_3 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 3, se le hace un descuento del 9% por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;


                    case 4:
                        Opcion2 = ((Numero_3 * 9) / 100);
                        Opcion3 = Numero_3 - Opcion2;

                        Console.WriteLine("debido a que usted es estrato 4, se le hace un descuento del 9% por lo cual el valor a pagar " +
                            " es de {0} ", Opcion3); break;

                }



            }



            Console.WriteLine("");
            total = Opcion3 + Opcion3 + Opcion3;
            Console.WriteLine("el total a pagar es de {0} ", total);
            Console.ReadKey();
        }
    }
}