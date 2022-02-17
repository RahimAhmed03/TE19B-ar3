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

    class Knight : Creature
    {
        protected string Weapon { get; set; }

        public Knight(string name, string weapon)
        {
            Name = name;

        }
        public void Attack()
        {

        }
    }

    class Dragon : Creature
    {
        protected string color { get; set; }

        public Dragon(string name, string color)
        {
            Name = name;
        }
        
        public void Attack()
        {

        }
    }
}
