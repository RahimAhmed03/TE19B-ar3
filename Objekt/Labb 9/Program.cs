using System.Collections.Generic;
using System;

namespace Labb_9
{

    class NamnAdress
    {
        public string Förnamn = "";
        public string Efternamn = "";
        public string Adress = "";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera din adress");


            List<NamnAdress> lista = new List<NamnAdress>();

            // Upprepa tills användaren skriver tomt i förnamn
            while (true)
            {
                // lagra uppgifter ett objekt
                NamnAdress objekt = new NamnAdress();

                // Ange namn och lön
                Console.Write("Ange ditt förnamn: (Enter avbryter)");
                objekt.Förnamn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Förnamn == "")
                {
                    break;
                }

                Console.Write("Ange ditt efternamn: ");
                objekt.Efternamn = Console.ReadLine();

                Console.Write("Ange din adress: ");
                objekt.Adress = Console.ReadLine();

                // lägg in i listan
                lista.Add(objekt);
            }
        }
    }
}
