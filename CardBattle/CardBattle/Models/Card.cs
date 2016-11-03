using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    public class Card
    {
        public Card(Values values, Suit suit)
        {
            Suit = suit;
            Values = values;
        }
        public Suit Suit { get; set; }
        public Values Values { get; set; }

        public override string ToString()
        {
            return "Card " + Values + " of " + Suit;
        }
    }
}
