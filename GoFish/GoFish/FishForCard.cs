using System;
using System.Collections.Generic;
using GoFish.CardDeck;

namespace GoFish
{
    public static class FishForCard
    {
        public static void Fish(Deck playerOne, Deck AI)
        {
            foreach (var item in playerOne.Cards)
            {
                Console.WriteLine("Deck One: {0} {1}",  item.Number, item.Suit);
            }
            Console.WriteLine("\n");
            
            foreach (var item in AI.Cards)
            {
                Console.WriteLine("Deck Two: {0} {1}",  item.Number, item.Suit);
            }
            
            Console.Write("What card would you like to try for a match: ");
            var fishCard = Console.ReadLine();
//            Console.WriteLine(fishCard);
            
//            Need to make a new list to be able to remove from the original AI card list
            List<Card> cardCopy = new List<Card>(AI.Cards);
            
            foreach (var item in cardCopy)
            {
                string cardDescrip = item.Number + " " +  item.Suit;
                if (cardDescrip == fishCard)
                {
                    AI.Cards.Remove(item);
                }
            }
            foreach (var item in AI.Cards)
            {
                Console.WriteLine("Deck Two: {0} {1}",  item.Number, item.Suit);
            }
        }
    }
}