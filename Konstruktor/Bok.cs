using System.Collections.Generic;

namespace Konstruktor
{
    public class Bok
    {
        public string Titel;
        public string Författare;
        public int AntalSidor;
        public List<Order> Orders;

        public Bok()
        {
            Orders = new List<Order>();      
        }

        public Bok(int antalsidor)
            : this()
        {
            this.AntalSidor = antalsidor;
        }

        public Bok(int antalsidor, string titel, string författare)
            : this(antalsidor)
        {
            this.Titel = titel;
            this.Författare = författare;
        }
    }
}
