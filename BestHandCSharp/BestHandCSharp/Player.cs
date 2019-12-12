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
        
        
        public void ExchangeACard(List<Card> hand)
        {
            Console.WriteLine("");
            Console.WriteLine("What card(s) would you like to trade in?");
            var cardToTrade = Console.ReadLine();

            var splitInput = cardToTrade.Split(" ");

            List<Card> handToRemoveCard = new List<Card>(hand);
            foreach (Card card in handToRemoveCard)
            {
                if (card.Number.ToString() == splitInput[0] && card.Suit.ToString() == splitInput[1])
                {
                    hand.Remove(card);
                }
            }
            Console.WriteLine("");
            DisplayHand(hand);

        }
    }
}