using System.Collections.Generic;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame(int players, int handSize)
        {
            var deck = Deck.CreateFullDeck();
            deck.Shuffle();
            
//            List<int> DeckList = new List<int>();
            var playerList = createListOfPlayersWithHands(players, handSize, deck);
            
            foreach (Player player in playerList)
            {
                Player.DisplayHand(player);
                player.ExchangeACard(player.playerDeck);
            }

//            var winner = DeckList.IndexOf(DeckList.Max());
//            Console.WriteLine("The winner is Player: {0}", winner + 1);
        }

        public static List<Player> createListOfPlayersWithHands(int numPlayers, int handSize, Deck deck)
        {
            List<Player> playerList =new List<Player>();
            ;
            var playerNumber = 1;
            
            while (numPlayers > 0)
            {
                var playerName = "Player" + playerNumber; 
                
                var playerHand = deck.CreateHand(handSize);
                
                Player player = new Player(playerHand, playerName);
                
                playerList.Add(player);
                
//                DeckList.Add(deck1.SumOfHand(player.playerDeck));
                
                numPlayers--;
                playerNumber++;
            }

            return playerList;
        }
    }
}