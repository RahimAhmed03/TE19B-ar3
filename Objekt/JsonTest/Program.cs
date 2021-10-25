using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonTest
{
    class Film{
        public string Titel;
        public string Årtal;
        public string Regissör;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skapa JSON-objekt");

            // Objektet avatar
            Film avatar = new Film()
            {
                Titel = "Avatar",
                Årtal = "2009",
                Regissör = "James Cameron"
            };
            Film Legend = new Film()
            {
                Titel = "I Am Legend",
                Årtal = "2008",
                Regissör = "Francis Lawrence"
            };
            Film Interstellar = new Film()
            {
                Titel = "Interstellar",
                Årtal = "2014",
                Regissör = "Christopher Nolan"
            };

            // Skriv ut lite JSON
            string jsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            jsonText += ",\n" + JsonConvert.SerializeObject(Legend, Formatting.Indented);
            jsonText += ",\n" + JsonConvert.SerializeObject(Interstellar, Formatting.Indented);
            Console.WriteLine(jsonText);

            // Spara ned i json-fil
            File.WriteAllText("filmer.json", jsonText);
        }
    }
}
