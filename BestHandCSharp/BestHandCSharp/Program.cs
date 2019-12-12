namespace BestHandCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int handSize = 8;
            int numberOfPlayers = 2;
            int numOfRounds = 5;

            Game.StartGame(numberOfPlayers, handSize, numOfRounds);
        }
    }
}
