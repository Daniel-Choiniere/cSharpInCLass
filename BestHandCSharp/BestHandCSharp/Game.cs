using System;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame()
        {
            var deck1 = Deck.CreateFullDeck();
            deck1.Shuffle();
            
            deck1.CreateHand();
            
            foreach (var item in deck1.Cards)
            {
                Console.WriteLine("{0} {1}",  item.Number, item.Suit);
            }
        }
    }
}