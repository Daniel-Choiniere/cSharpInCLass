using System.Collections.Generic;

namespace BestHandCSharp
{
    public class Game
    {
        public static void StartGame(int players, int handSize, int numOfRounds)
        {
            var deck = Deck.CreateFullDeck();
            deck.Shuffle();
            
            Card randomCard = deck.PullSingleCard();
            
//            List<int> DeckList = new List<int>();
            var playerList = createListOfPlayersWithHands(players, handSize, deck);

            for (var rounds = 0; rounds < numOfRounds; rounds++)
            {
                foreach (Player player in playerList)
                {
                    Player.DisplayHand(player);
                    player.ExchangeACard(player.playerDeck, deck);
                }
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