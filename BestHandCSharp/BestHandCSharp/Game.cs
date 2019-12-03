using System;
using System.Collections.Generic;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame(int players)
        {
            List<Deck> DeckList = new List<Deck>();
            var numPlayers = players;
            while (numPlayers > 0)
            {
                var deck1 = Deck.CreateFullDeck();
                deck1.Shuffle();
                deck1.CreateHand();
                deck1.SumOfHand();
                DeckList.Add(deck1);
                
                numPlayers--;
            }
        }
    }
}