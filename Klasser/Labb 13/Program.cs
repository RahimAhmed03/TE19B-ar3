using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System;

namespace Labb_13
{
    class Namn
    {
        public string Förnamn {get; set;}
        public string Efternamn {get; set;}

        public void VisaNamn()
        {
            Console.WriteLine($"{Förnamn} + {Efternamn}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att skriva in namn");

            List<Namn> lista = new List<Namn>();

            while (true)
            {
                
                Namn objekt = new Namn();

                // Ange Förnamn
                Console.Write("Ange ditt Förnamn: ");
                objekt.Förnamn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Förnamn == "")
                {
                    break;
                }

                Console.Write("Ange ditt Efternamn: ");
                objekt.Efternamn = Console.ReadLine();

                lista.Add(objekt);
            }
            foreach (var namn in lista)
            {
                namn.VisaNamn();
            }


            
        }
    }
}
