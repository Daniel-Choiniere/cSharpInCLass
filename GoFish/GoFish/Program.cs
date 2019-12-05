using System;

namespace GoFish
{
    public class Program
    {
        static void Main(string[] args)
        {
            int handSize = 5;
            CreateHands(handSize);
        }

        private static void CreateHands(int handSize)
        {
            var playerOne = Deck.CreateFullDeck();
            var AI = Deck.CreateFullDeck();
            playerOne.Shuffle();
            AI.Shuffle();
            playerOne.CreateHand(handSize);
            AI.CreateHand(handSize);
            
            FishForCard.Fish(playerOne, AI);
        }
    }
}