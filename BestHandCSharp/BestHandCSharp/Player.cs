using System.Collections.Generic;

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
    }
}