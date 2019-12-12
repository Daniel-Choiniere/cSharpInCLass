using System;
using System.Collections.Generic;
using System.Linq;

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
        
        public void ExchangeACard(List<Card> hand)
        {
            Console.WriteLine("");
            Console.WriteLine("What card(s) would you like to trade in?");
            var cardToTrade = Console.ReadLine();

            var splitInput = cardToTrade.Split(" ");
            
            foreach (string word in splitInput)
                Console.WriteLine(word);

            foreach (Card card in hand)
            {
                if (card.Number.ToString() == splitInput[0] && card.Suit.ToString() == splitInput[1])
                {
                    Console.WriteLine("Its a match");
                }
            }
//            
//            var itemToRemove = hand.Single(r => r. == 2);
//            hand.Remove(itemToRemove);
        }
    }
}