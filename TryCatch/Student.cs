using System;
using System.Linq;

namespace TryCatch
{
    public class Student : Person
    {
        private string studieprogram;

        private string Studieprogram
        {
            get
            {
                return studieprogram;
            }

            set
            {
                // Kolla att inmattat studieprogram är: Teknik, IT, eller Estet
                //if (value.ToLower() != "teknik" && value.ToLower() != "it" && value.ToLower() != "estet")
                string[] lista = {"teknik", "estet", "it"};
                if (!lista.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Ogiltigt studieprogram!");
                }
                else
                {
                    studieprogram = value;
                }
                
            }
        }

        public Student(string förnamn, string efternamn, string studieprogram)
        : base(förnamn, efternamn)
        {
            Studieprogram = studieprogram;
        }
    }
}