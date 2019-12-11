using System;
using System.Collections.Generic;
using System.Linq;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame(int players, int handSize)
        {
            List<int> DeckList = new List<int>();
            var numPlayers = players;

            var playerNumber = 1;
            while (numPlayers > 0)
            {
                var playerName = "player" + playerNumber;
                Console.WriteLine(playerName);
                
                Deck deck1 = Deck.CreateFullDeck();
                deck1.Shuffle();
                deck1.CreateHand(handSize);
                
                Player player = new Player(deck1, playerName);
                
                DeckList.Add(deck1.SumOfHand());
                
                numPlayers--;
                playerNumber++;
            }

            var winner = DeckList.IndexOf(DeckList.Max());
            Console.WriteLine("The winner is Player: {0}", winner + 1);
        }
    }
}