﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardBattle.Models;

namespace CardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var spadesAce = new Card(Values.Ace, Suit.Spades);
            Console.WriteLine("I created a card : "+ spadesAce.ToString() );
            Console.ReadLine();
        }
    }
}
