using System;
using System.Collections.Generic;

namespace Inkomster
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

           
            List<PersonInkomst> lista = new List<PersonInkomst>();

            // Upprepa tills användaren skriver tomt i namn 
            while (true)
            {
                 // lagra uppgifter i ett objekt
                PersonInkomst objekt = new PersonInkomst();

                // Ange namn och lön
                Console.Write("Ange ditt namn: (Enter avbryter)");
                objekt.Namn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Namn == "")
                {
                    break;
                }

                Console.Write("Ange din månadslön. ");
                objekt.Lön = ReadInt(); 

                // lägg in i listan
                lista.Add(objekt);

            }
        }

        static int ReadInt()
        {
        int heltal;
        while (!int.TryParse(Console.ReadLine(), out heltal))
        {
        Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
        }
        return heltal;
        }
    }
}
