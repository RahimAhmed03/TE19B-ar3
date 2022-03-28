using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Kompakt inmatning
                Console.Write("Förnamn Efternamn: ");
                string[] input = Console.ReadLine().Split(" ");

                // Kolla att vi fick två textbitar
                if (input.Length == 4)
                {
                    // Lagra i en instans (objekt)
                    Arbetare arbetare = new Arbetare(input[0], input[1], input[2], input[3]);

                    // Skriv ut timlön
                    Console.WriteLine($"Din timlön blir {arbetare.RäknaTimlön()}");
                }
                else
                {
                    Console.WriteLine("Du måste mata in förnamn mellanrum efternamn");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
