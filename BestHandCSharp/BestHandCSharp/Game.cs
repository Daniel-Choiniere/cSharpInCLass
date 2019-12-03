using System;
using System.Collections.Generic;
using System.Linq;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame(int players)
        {
            List<int> DeckList = new List<int>();
            var numPlayers = players;
            while (numPlayers > 0)
            {
                var deck1 = Deck.CreateFullDeck();
                deck1.Shuffle();
                deck1.CreateHand();
                DeckList.Add(deck1.SumOfHand());
                
                numPlayers--;
            }

            var winner = DeckList.IndexOf(DeckList.Max());
            Console.WriteLine("The winner is Player: " + (winner + 1));
        }
    }
}