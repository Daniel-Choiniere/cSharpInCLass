using System;

namespace BestHandCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = 2;
            int handSize = 4;
            
            Game.StartGame(numberOfPlayers, handSize);
        }
    }
}
