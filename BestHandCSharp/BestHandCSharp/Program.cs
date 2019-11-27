using System;
using System.Collections.Generic;
using System.Globalization;

namespace BestHandCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var deck1 = Deck.CreateFullDeck();
//            Console.WriteLine(deck1.Cards[1].Number);

            foreach (var item in deck1.Cards)
            {
                Console.WriteLine("{0} {1}",  item.Number, item.Suit);
            }
        }
    }
}