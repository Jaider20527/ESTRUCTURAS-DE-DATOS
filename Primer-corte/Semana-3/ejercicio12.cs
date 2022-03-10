using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;





namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

                    Dictionary<Elector, bool> Electores = new Dictionary<Elector, bool>();
        Dictionary<Aspirante, int> Aspirantes = new Dictionary<Aspirante, int>();

        public void ExampleButtonClick() =>
            Votar("Juan Osorio", 
                "Sebastian Rodriguez"); 


        public void Votar(string electorName, string aspiranteName)
        {
            bool _electorEncontrado = false; 

            foreach (var elector in Electores) 
            {
                if (elector.Key.Name == electorName)
                {
                    _electorEncontrado = true; 

                    if (!elector.Value) 
                    {
                        var aspirante = Aspirantes.Where(a => a.Key.Name ==
                        aspiranteName).FirstOrDefault().Key;

                        if (aspirante != null) 
                        {
                            Aspirantes[aspirante]++; 
                            Electores[elector.Key] = true; 
                            break; 
                        }
                        else throw new Exception("Este aspirante no ha sido encontrado en la base de datos");
                    }
                    else throw new Exception("Este elector ya ha votado!");
                }

            }

            if (!_electorEncontrado) throw new Exception("El elector no ha sido encontrado en la base de datos");
        }
    }

    public class Elector : User
    {
        public Elector(string name) { Name = name; }
    }

    public class Aspirante : User
    {
        public Aspirante(string name) { Name = name; }
    }

    public class User
    {
        public string Name { get; set; }
        public string Id { get { return ID.GetNew(); } } 
    }    public static class ID
    {
        private static int _count = 0;

        public static string GetNew()
        => (_count++).ToString("x4");
    }



        }
    }
       
}