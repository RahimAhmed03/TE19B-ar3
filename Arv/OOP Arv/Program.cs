using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    class Program
    {
        class Creature
        {
            public int Power { get; set; }
            public int Toughness { get; set; }
            public string Type { get; set; }

            public Creature(string type, int power, int toughness)
            {
                Type = type;
                Power = power;
                Toughness = toughness;
            }

            public virtual void Attack()
            {
                Console.WriteLine(Type + " attacks with power " + Power);
            }
        }


        static void Main(string[] args)
        {
            List<Creature> creatures = new List<Creature>();
            creatures.Add(new Creature("Knight", 5, 5));
            creatures.Add(new Creature("Wizard", 7, 3));

            foreach(var c in creatures)
                c.Attack();


            Console.ReadKey();
        }
    }
}
