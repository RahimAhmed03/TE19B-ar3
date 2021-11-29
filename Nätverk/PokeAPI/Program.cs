using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace PokeAPI
{

    /* 
    {
        "count": 1118,
        "next": "https://pokeapi.co/api/v2/pokemon?offset=20&limit=20",
        "previous": null,
        "results": [
            {
            "name": "bulbasaur",
            "url": "https://pokeapi.co/api/v2/pokemon/1/"
            },
            ...
     */
    class Pokemon
    {
        public string name {get; set;}
        public string url {get; set;}
    }
    class Pokemons
    {
        public int count {get; set;}
        public string next {get; set;}
        public List<Pokemon> results {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta alla Pokemon");

            // Hämta pokemon från pokeapi.co
            string url = "https://pokeapi.co/api/v2";
            var client = new RestClient(url);
            var request = new RestRequest("pokemon", DataFormat.Json);
            var response = client.Get(request);

            // Kollar på svaret
            //Console.WriteLine(response.Content);

            // Avkoda JSON-svaret
            Pokemons lista = new Pokemons();
            lista = JsonSerializer.Deserialize<Pokemons>(response.Content);

            // Skriv ut alla pokemons
            if (lista != null)  // Kolla att det gick att avkoda annars kraschar programmet
            {
                foreach (var item in lista.results)
                {
                    Console.WriteLine(item.name);
                }
            }

        }
    }
}
