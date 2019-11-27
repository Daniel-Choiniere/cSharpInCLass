using System;

namespace BestHandCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var deck1 = Deck.CreateFullDeck();
            deck1.Shuffle();
            
            foreach (var item in deck1.Cards)
            {
                Console.WriteLine("{0} {1}",  item.Number, item.Suit);
            }
        }
    }
}