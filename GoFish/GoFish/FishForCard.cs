using System;
using System.Collections.Generic;
using GoFish.CardDeck;

namespace GoFish
{
    public static class FishForCard
    {
        public static void Fish(List<Card> playerOne, List<Card> ai)
        {
            int playerOneScore = 0;
            int aiScore = 0;

            while (ai.Count > 0)
            {
//                DisplayHands(playerOne, AI);
            
                Console.Write("What card would you like to try for a match: ");
                var fishCard = Console.ReadLine();

                // Need to make a new list to be able to remove from the original AI card list
                List<Card> cardCopy = new List<Card>(ai);
            
                foreach (var item in cardCopy)
                {
                    string cardDescription = item.Number + " " +  item.Suit;
                    if (cardDescription == fishCard)
                    {
                        playerOne.Remove(item);
                        ai.Remove(item);
                        playerOneScore++;
                    }
                    Deck.PullSingleCard();
                }
                DisplayHands(playerOne, ai);
            }
            Console.WriteLine(playerOneScore);
        }

        public static void DisplayHands(List<Card> playerOne, List<Card> ai)
        {
            foreach (var item in playerOne)
            {
                Console.WriteLine("Deck One: {0} {1}",  item.Number, item.Suit);
            }
            Console.WriteLine("\n");
            
            foreach (var item in ai)
            {
                Console.WriteLine("Deck Two: {0} {1}",  item.Number, item.Suit);
            }
            Console.WriteLine("\n");

        }
    }
}