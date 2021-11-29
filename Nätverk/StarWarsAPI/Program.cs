using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;


namespace StarWarsAPI
{
    class karaktär
    {
        public string name {get; set;}
    }
    class karaktärer
    {
        public List<karaktär> results {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta alla karaktärer ifrån Star Wars");

            // Hämta karaktärer från  swapi.dev
            string url =  "https://swapi.dev/api";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            // Avkoda JSON-svaret
            karaktärer lista = new karaktärer();
            lista = JsonSerializer.Deserialize<karaktärer>(response.Content);

            // SKriv ut alla karakäterer
            if (lista != null)
            {
                foreach (var item in lista.results)
                {
                    Console.WriteLine(item.name);
                }
                
            }
        }
    }
}
