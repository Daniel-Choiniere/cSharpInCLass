using System;

namespace finishLine
{
    public class FinishLine
    {
        private readonly int[] SUITS = { 0, 1, 2, 3 };
        private readonly int[] VALUES = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private static int NUM_JOKERS = 2;
        private readonly string[] MARKER_NAMES = { "A", "B", "C" };
        private readonly int[] RESTRICTED_VALUES = { 0, 1, 2, 11, 12, 13 };
        public Deck deck;
        public Die redDie;
        public Die blackDie;
        public Player player1;
        public int players;
        public Random rand;

        public FinishLine(int players, string player1Name)
        {
            this.players = players;
            player1 = new Player(player1Name, MARKER_NAMES);
            rand = new Random();
            deck = new Deck(VALUES, SUITS, NUM_JOKERS);
            redDie = new Die(6, 0xFF0000);
            blackDie = new Die(6, 0x000000);
            deck.Shuffle(rand);
            ValidateDeck();
            redDie.Roll(rand);
            blackDie.Roll(rand);
        }

        public void DisplayBoard()
        {
            Console.Clear();
            string master = "";
            string cardRow = "\t";
            string playerRow = "\t";

            cardRow += "Player1";
            playerRow += player1.HasMarkersAt(-1);

            master += cardRow + "\n" + playerRow + "\n\n";
            cardRow = "\t";
            playerRow = "\t";

            int counter = 0;
            foreach (Card card in deck.cards)
            {
                cardRow += "|" + card.Display() + "|";
                playerRow += " " + player1.HasMarkersAt(counter) + " ";
                counter++;
                if (counter % 9 == 0)
                {
                    master += cardRow + "\n" + playerRow + "\n\n";
                    cardRow = "\t";
                    playerRow = "\t";
                }
                else
                {
                    cardRow += "\t";
                    playerRow += "\t";
                }
            }
            Console.WriteLine(master);
        }

        public void ValidateCard(int position)
        {
            if (Array.IndexOf(RESTRICTED_VALUES, deck.cards[position].val) >= 0)
            {
                while (true)
                {
                    int newPosition = rand.Next(3, 51);
                    if (Array.IndexOf(RESTRICTED_VALUES, deck.cards[newPosition].val) >= 0)
                    {
                        continue;
                    }
                    Card temp = deck.cards[position];
                    deck.cards[position] = deck.cards[newPosition];
                    deck.cards[newPosition] = temp;
                    break;
                }
            }
        }

        public void ValidateDeck()
        {
            int[] RESTRICTED_POSITIONS = { 0, 1, 2, 51, 52, 53 };
            foreach (int position in RESTRICTED_POSITIONS)
            {
                ValidateCard(position);
            }

        }

        public void Turn(Player player)
        {
            string master = "";
            master += player.name + "'s turn!\n";
            redDie.Roll(rand);
            blackDie.Roll(rand);
            int stopValue = redDie.val + blackDie.val;
            master += "Red: " + redDie.val + "\tBlack" + blackDie.val + "\tStop Value: " + stopValue + "\n";

            GetMarker("Red", redDie, player, stopValue, master);
            GetMarker("Black", blackDie, player, stopValue, master);

        }

        public void GetMarker(string dieName, Die die, Player player, int stopValue, string master)
        {
            Console.WriteLine(master);
            Console.WriteLine("Choose marker (a,b,c) for {0}", dieName);
            string input = Console.ReadLine();
            int inputIndex = player.FindMarker(input.ToUpper());
            player.markers[inputIndex].Move(blackDie.val, blackDie.val, deck);

            DisplayBoard();
        }

        public void Round()
        {
            Turn(player1);
        }

        public void PlayGame()
        {
            while (true)
            {
                Round();
                //break;
            }

        }

    }
}
