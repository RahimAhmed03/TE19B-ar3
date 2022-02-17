using System;

namespace Labb_18
{
    public class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }
        protected string Name { get; set;}

        public Creature(string name)
        {
            Name = name;
        }

        public string GetInfo()
        {
            
        }
    }

    public class Knight : Creature
    {
        protected string Weapon { get; set; }

        public Knight(string name, string weapon) : base(name)
        {
            Name = name;
            Weapon = weapon;

        }
        public void Attack()
        {

        }
    }

    public class Dragon : Creature
    {
        protected string Color { get; set; }

        public Dragon(string name, string color) : base(name)
        {
            Name = name;
            Color = color;
        }
        
        public void Attack()
        {

        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("a");
            }
        }
    }
}
