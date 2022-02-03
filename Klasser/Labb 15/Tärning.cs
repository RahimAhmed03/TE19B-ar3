using System;

namespace Labb_15
{
    public class Tärning
    {
        private int AntalSidor { get; set; }

        public Tärning(int _antalSidor)
        {
            AntalSidor = _antalSidor;
        }

        public void Kasta()
        {
            Random generator = new Random();
            int slumptal = generator.Next(1, AntalSidor + 1);
            
            Console.WriteLine($"Tärningen har {AntalSidor} sidor, du kastade tärningen och fick siffran {slumptal} ");
        }
    }
}