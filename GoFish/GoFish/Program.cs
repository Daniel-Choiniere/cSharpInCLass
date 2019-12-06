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
            var ai = Deck.CreateFullDeck();
            
            playerOne.Shuffle();
            ai.Shuffle();
            
            var playerOneHand = playerOne.CreateHand(handSize);
            var aiHand = ai.CreateHand(handSize);

            FishForCard.DisplayHands(playerOneHand, aiHand);

            FishForCard.Fish(playerOneHand, aiHand);
        }
    }
}