using System;

namespace Konstruktor
{

    class Program
    {
        static void Main(string[] args)
        {
            var bok = new Bok(10, "Harry Potter", "Rowling");

            var order = new Order();
            bok.Orders.Add(order);
            Console.WriteLine(bok.Titel);
            Console.WriteLine(bok.Författare);
            Console.WriteLine(bok.AntalSidor);
        }
    }
}
