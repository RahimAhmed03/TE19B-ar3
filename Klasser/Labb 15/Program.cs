using System;

namespace Labb_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange sidor för tärning
            Console.WriteLine("Vi ska göra en tärning: hur många sidor ska den ha?");
            int antalSidor = int.Parse(Console.ReadLine());

            Tärning tärning = new Tärning(antalSidor);

            tärning.Kasta();



        }
    }
}
