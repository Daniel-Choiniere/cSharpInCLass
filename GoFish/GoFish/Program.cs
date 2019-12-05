using System;

namespace GoFish
{
    public class Program
    {
        static void Main(string[] args)
        {
            int handSize = 5;
            
            var deck1 = Deck.CreateFullDeck();
            var deck2 = Deck.CreateFullDeck();
            deck1.Shuffle();
            deck2.Shuffle();
            deck1.CreateHand(handSize);
            deck2.CreateHand(handSize);
            
            
            
            foreach (var item in deck1.Cards)
            {
                Console.WriteLine("Deck One: {0} {1}",  item.Number, item.Suit);
            }
            
            Console.WriteLine("\n");
            
            foreach (var item in deck2.Cards)
            {
                Console.WriteLine("Deck Two: {0} {1}",  item.Number, item.Suit);
            }
        }
    }
}