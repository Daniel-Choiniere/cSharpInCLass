namespace finishLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var game = new FinishLine(1, new string[] { "player1" });
            game.PlayGame();
        }
    }
}
