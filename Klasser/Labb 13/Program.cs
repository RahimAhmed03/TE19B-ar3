using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System;

namespace Labb_13
{
    class Person
    {
        public string Förnamn {get; set;}
        public string Efternamn {get; set;}
        public DateTime Födelsedag {get; set;}
        public float Vikt {get; set;}
        public float Höjd {get; set;}

        public void VisaNamn()
        {
            Console.WriteLine($" Ditt namn är {Förnamn} {Efternamn}");
        }

        public void VisaÅlder()
        {
            int ålder = DateTime.Now.Year - Födelsedag.Year;
            Console.WriteLine($"Ditt ålder är {ålder}");
        }

        public float BMI()
        {
            return Vikt / (Höjd * Höjd);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Now;
            Console.WriteLine($"Dagens datum är {datum}");
            Console.WriteLine($"Vi är i månad {datum.Month}");
            Console.WriteLine($"Vi är i dag {datum.Day}");
            Console.WriteLine($"Vi är i dag {datum.Hour}:{datum.Minute}");
        
            // Formatera datumet
            Console.WriteLine($"Dagens datum är {datum.ToString("dddd")}");
            Console.WriteLine($"Dagens datum är {datum.ToString("hh:mm")}");

            // Om 40 dagar skall arbetet vara klart, vilken dag är det?
            DateTime deadline = datum.AddDays(40);
            Console.WriteLine($"Arbetet skall vara klart {datum.ToString("dddd dd/MM-YY")}");

            // Be användare om födeksedatum
            Console.Write("När är du född? (yy-mm-dd) ");
            DateTime födelsedatum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(födelsedatum);

            // Berätta hur gammal användaren är?
            Console.WriteLine($"Din ålder är {datum.Year - födelsedatum.Year}");
            Console.WriteLine($"Din ålder är {GetAge(födelsedatum)}");

            // Vad är DateTime.Ticks?
            Console.WriteLine(födelsedatum.Ticks);

            Console.Write("Hur mycket väger du? ");
            Console.ReadLine();


            Console.WriteLine("Program för att skriva in namn");

            List<Person> lista = new List<Person>();

            while (true)
            {
                
                Person objekt = new Person();

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

        static public int GetAge(DateTime datum)
        {
            double age = 0;
            age = DateTime.Now.Subtract(datum).Days;
            age = age / 365.25;
            return (int)Math.Floor(age);
        }

    }
}
