namespace finishLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var game = new FinishLine(2, new string[] { "Cliff", "Joe" });
            game.PlayGame();
        }
    }
}
