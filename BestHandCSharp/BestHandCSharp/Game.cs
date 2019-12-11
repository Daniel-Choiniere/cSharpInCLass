using System;
using System.Collections.Generic;
using System.Linq;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame(int players, int handSize)
        {
            var deck1 = Deck.CreateFullDeck();
            deck1.Shuffle();
            
//            List<int> DeckList = new List<int>();
            List<Player> playerList =new List<Player>();
            
            var numPlayers = players;
            var playerNumber = 1;
            
            while (numPlayers > 0)
            {
                var playerName = "Player" + playerNumber; 
                
                var playerHand = deck1.CreateHand(handSize);
                
                Player player = new Player(playerHand, playerName);
                
                playerList.Add(player);
                
                
//                DeckList.Add(deck1.SumOfHand(player.playerDeck));
                
                numPlayers--;
                playerNumber++;
            }
            
            foreach (Player play in playerList)
            {
                Console.WriteLine(play.playerName);
                foreach (Card card in play.playerDeck)
                {
                    Console.WriteLine(card.Number);
                }
            }

//            var winner = DeckList.IndexOf(DeckList.Max());
//            Console.WriteLine("The winner is Player: {0}", winner + 1);
        }
    }
}