/*  */

using System;
using System.Collections.Generic;

namespace Labb_14
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Bok> lista = new List<Bok>();

            while (true)
            {

                // Ange Titel
                Console.Write("Ange bokens Titel: ");
                string titel = Console.ReadLine();

                // Avbryt om namn är tomt
                if (titel == "")
                {
                    break;
                }

                // Ange Författare
                Console.Write("Ange namnet på författare: ");
                string författare = Console.ReadLine();

                // Ange AntalSidor
                Console.Write("Ange Antalet sidor boken har: ");
                int antalSidor = int.Parse(Console.ReadLine());
                
                // Skapa ett objekt = bok av typen Bok
                // bok heter också instans av Bok;
                // Skapa och ge värdena samtidigt!                

                Bok bok = new Bok(titel, författare, antalSidor);
            }
            foreach (var bok in lista)
            {
                bok.Skrivut();
            }
        }
    }
}
