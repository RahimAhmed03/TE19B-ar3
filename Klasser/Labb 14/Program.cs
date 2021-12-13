using System;
using System.Collections.Generic;

namespace Labb_14
{

    class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int AntalSidor { get; set; }

        public void Skrivut()
        {
            Console.WriteLine($"Boken heter {Titel}, författaren är {Författare} och antal sidor är {AntalSidor}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Bok> lista = new List<Bok>();

            while (true)
            {
                Bok objekt = new Bok();

                // Ange Titel
                Console.Write("Ange bokens Titel: ");
                objekt.Titel = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Titel == "")
                {
                    break;
                }

                // Ange Författare
                Console.Write("Ange namnet på författare: ");
                objekt.Författare = Console.ReadLine();

                // Ange AntalSidor
                Console.Write("Ange Antalet sidor boken har: ");
                objekt.AntalSidor = Console.ReadLine();

                lista.Add(objekt);
            }
            foreach (var bok in lista)
            {
                bok.Skrivut();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
