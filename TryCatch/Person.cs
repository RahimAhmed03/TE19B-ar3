using System;

namespace TryCatch
{
    public class Person
    {
        private string förnamn;
        private string efternamn;
        private string Förnamn 
        { 
            get
            {
                return förnamn;
            }

            set
            {
                // Börjar det med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Förnamn måste börja med en versal");
                }
                // Är förnamnet minst 4 tecken långt
                else if (value.Length < 4)
                {
                    throw new ArgumentException("Förnamn måste vara minst 4 tecken långt");
                }
                else
                {
                    förnamn = value;
                }
            }
        }
        private string Efternamn 
        { 
            get
            {
                return efternamn;
            }

            set
            {
                // Börjar det med en versal
                if (!char.IsUpper(value[1]))
                {
                    throw new ArgumentException("Efternamn måste börja med en versal");
                }
                // Är efternamnet minst 3 tecken långt
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Efternamn måste vara minst 3 tecken långt");
                }
                else
                {
                    efternamn = value;
                }
            } 
        }
        
        public Person(string förnamn, string efternamn)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
        }

        // Virtual betyder att man får skriva över den
        public virtual string Sammanfattning()
        {
            return "";
        }
    }
}