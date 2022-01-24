using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace Biluthyrning
{
    // Kostnad för bilarna
    // Volvo ABC123 -> 500:- /d
    // Saab DEF456 -> 400:- /d
    // Fiat GHI789 -> 199:- /d
    // Extra km = 2:- /km
    // Array? 
    // [
    //      ["ABC123", "500"],
    //      ["DEF456", "400"],
    //      ["GHI789", "199"]
    // ]


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Biluthyrningen!");

            // Skape ett första avtal = avtal1
            Avtal avtal1 = new Avtal();

            Console.WriteLine("Ange kundens personnr: ");
            avtal1.Personnr = Console.ReadLine();

            Console.WriteLine("Ange bilens regnr: ");
            avtal1.RegNr = Console.ReadLine();

            Console.WriteLine("Ange antal km: ");
            avtal1.Km = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange antal dygn: ");
            avtal1.Tidsram = int.Parse(Console.ReadLine());

            avtal1.Datum = DateTime.Today;

            // Räkna ut totala kostnaden
            Console.WriteLine($"Total hyran blir {avtal1.RäknaKostnad()}");
            Console.WriteLine($"Total hyran blir {avtal1.RäknaInlämningsdatum()}");


        }
    }

    class Avtal
    {
        // Egenskaper
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }

        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string Personnr { get; set; }

        // Privat variabler som bara ska användas inuti klassen
        private IDictionary<string, int> _bilar = new Dictionary<string, int> {
            {"ABC123", 500},
            {"DEF456", 400},
            {"GHI789", 199}
        };

        /// <summary>
        /// Räkna ut bilens dygnskostnad * antal dygn + 2:-/km
        /// </summary>
        /// <returns></returns>
        public float RäknaKostnad()
        {
            //Console.WriteLine(bilar["ABC123"]);
            // @todo inte krascha om regnr inte finns
            // @todo 100km ingår i hyran, bara betala för extra km
            
            Kostnad = _bilar[RegNr] * Tidsram + Km * 2;
            return Kostnad;
        }

        /// <summary>
        /// Räkna ut datum + Tidsram
        /// </summary>
        /// <returns></returns>
        public string RäknaInlämningsdatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd MMMM yyyy");
        }

    }
}
