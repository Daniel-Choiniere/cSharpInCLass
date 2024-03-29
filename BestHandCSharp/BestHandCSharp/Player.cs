using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace BestHandCSharp
{
    public class Player
    {
        public List<Card> playerDeck;
        public string playerName;
        
        public Player(List<Card> deck, string name)
        {
            playerDeck = deck;
            playerName = name;
        }

        public static void DisplayHand(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine(player.playerName);
            foreach (Card card in player.playerDeck)
                Console.WriteLine("{0} {1}", card.Number, card.Suit);
        }
        
        public static void DisplayHand(List<Card> hand)
        {
            foreach (Card card in hand)
                Console.WriteLine("{0} {1}", card.Number, card.Suit);
        }
        
        
        public void ExchangeACard(List<Card> hand, Deck deck)
        {
            Console.WriteLine("");
            while (Console.ReadLine() != "exchange")
            {
                Console.WriteLine("List a card you would you like to swap for a card from the deck, if no swap necessary type exchange");
                var cardToTrade = Console.ReadLine().ToUpper();

                var splitInput = cardToTrade.Split(" ");

                List<Card> handToRemoveCard = new List<Card>(hand);
                foreach (Card card in handToRemoveCard)
                {
                    if (card.Number.ToString().ToUpper() == splitInput[0] && card.Suit.ToString().ToUpper() == splitInput[1])
                    {
                        deck.DiscardCard(hand, card);
                        Card singleCard = deck.PullSingleCard();
                        hand.Add(singleCard);
                    }
                }
            
                Console.WriteLine("");
                DisplayHand(hand);
            }
            
        }
    }
}