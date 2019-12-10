using System;
using System.Collections.Generic;
using GoFish.CardDeck;

namespace GoFish
{
    public static class FishForCard
    {
        public static void Fish(List<Card> player, List<Card> ai)
        {
            int playerScore = 0;
            int aiScore = 0;

            while (ai.Count > 0)
            {
                Console.Write("What card would you like to try for a match: ");
                var fishCard = Console.ReadLine();
                
                // Need to make a new list to be able to remove from the original AI card list in a foreach
                List<Card> cardCopy = new List<Card>(ai);
            
                foreach (var item in cardCopy)
                {
                    string cardDescription = item.Number + " " +  item.Suit;
                    if (cardDescription == fishCard)
                    {
                        player.Remove(item);
                        ai.Remove(item);
                        playerScore++;
                    }
//                    Implement pulling a card from the deck
//                    Deck.PullSingleCard();
                }
                DisplayHands(player, ai);
            }
            Console.WriteLine(playerScore);
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