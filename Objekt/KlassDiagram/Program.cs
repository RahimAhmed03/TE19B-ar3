using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace KlassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut lönekostnad");

            // Loopa ett antal gånger
            List<PersonInkomst> listaPerson = new List<PersonInkomst>();
            
            while (true)
            {
                // Skapa objektet person från klassen PersonInkomst¨
                PersonInkomst person = new PersonInkomst();

                // Ange namn
                Console.Write("Vad heter den anställde: ");
                person.namn = Console.ReadLine();

                // Avslutar om namn är tomt
                if (person.namn == "")
                {
                    break;
                }

                // Ange timlön
                Console.Write("Den anställdes timlön: ");
                person.timlön = ReadInt();

                // Ange timmar
                Console.Write("Den anställdes arbetstid: ");
                person.timmar = ReadInt();

                // Lagra i listan
                listaPerson.Add(person);
            }

            // Spara ned som JSON
            string jsonText = JsonConvert.SerializeObject(listaPerson, Formatting.Indented);

            // Spara ned JSON i textfil
            File.WriteAllText(@"personerinkomst.json", jsonText);

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
