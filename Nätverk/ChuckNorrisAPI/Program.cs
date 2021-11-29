using System;
using RestSharp;
using System.Text.Json;

namespace ChuckNorrisAPI
{

    /* 
    {
        "icon_url" : "https://assets.chucknorris.host/img/avatar/chuck-norris.png",
        "id" : "6181BpiWR_GTOJ1FhC1f5A",
        "url" : "",
        "value" : "Chuck Norris once traveled with the Ringling Bros and Barnum & Bailey Circus as the flaming chainsaw swallower."
    }
    */
    class Joke
    {
        public string icon_url  {get; set;}
        public string value {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuck Norris skämt");

            // Hämta ett skämt från api.chucknorris.io
            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            // Kolla på svaret
            //Console.WriteLine(response.Content);

            // Avkoda JSON-svaret
            Joke skämtet = new Joke();
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);

            // Skriv ut skämtet
            Console.WriteLine(skämtet.value);
        }
    }
}
