using System;

namespace Labb_16
{
    public class Card
    {
        public int Value { get; set; }
        public SuitType Suit { get; set; }
        public int BlackJackValue { get; set;}

        public Card(int _value, SuitType _suit, )
        {
            Value = _value;
            Suit = _suit;
        }
        public string ToString()
        {
            return null;
        }
    }
}