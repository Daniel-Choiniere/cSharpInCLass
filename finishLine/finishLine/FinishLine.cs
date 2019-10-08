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
        public int numPlayers;
        public Player[] players;
        public Random rand;

        public FinishLine(int numPlayers, string[] playerNames)
        {
            this.numPlayers = numPlayers;
            players = new Player[numPlayers];
            for (int counter = 0; counter < numPlayers; counter++)
            {
                players[counter] = new Player(playerNames[counter], MARKER_NAMES);
            }
            
            rand = new Random();
            deck = new Deck(VALUES, SUITS, NUM_JOKERS);
            redDie = new Die(6, 0xFF0000);
            blackDie = new Die(6, 0x000000);
            deck.Shuffle(rand);
            ValidateDeck();
            redDie.Roll(rand);
            blackDie.Roll(rand);
        }

        private void intializePlayerRow(string[] playerRow)
        {
            for (int count = 0; count < numPlayers; count++)
            {
                playerRow[count] = "\t";
            }
        }

        private void DisplayBoard()
        {
            Console.Clear();
            string master = "";
            string cardRow = "\t";
            string[] playerRow = new string[numPlayers];
            

            foreach (var player in players)
            {
                cardRow += player.name + "\t";
                playerRow[0] += player.HasMarkersAt(-1) + "\t";
            }

            master += cardRow + "\n" + playerRow[0] + "\n\n";
            cardRow = "\t";
            intializePlayerRow(playerRow);

            int position = 0;
            foreach (Card card in deck.cards)
            {
                cardRow += "|" + card.Display() + "|";

                for (var count=0; count < numPlayers; count++)
                {
                    playerRow[count] += " " + this.players[count].HasMarkersAt(position) + " ";
                }

                position++;

                if (position % 9 == 0)
                {
                    master += cardRow + "\n";
                    for (int count = 0; count < numPlayers; count++)
                    {
                        master += playerRow[count] + "\n";
                    }
                    master += "\n";
                    cardRow = "\t";
                    intializePlayerRow(playerRow);
                }
                else
                {
                 
                    cardRow += "\t";
                    for (var count=0; count< numPlayers; count++)
                    {
                        playerRow[count] += "\t";
                    }

                   
                }
            }
            Console.WriteLine(master);
        }

        private void ValidateCard(int position)
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

        private void ValidateDeck()
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
            master += "Red: " + redDie.val + "\tBlack: " + blackDie.val + "\tStop Value: " + stopValue + "\n";

            GetMarker("Red", redDie, player, stopValue, master);
            GetMarker("Black", blackDie, player, stopValue, master);
        }

        private void GetMarker(string dieName, Die die, Player player, int stopValue, string master)
        {
            Console.WriteLine(master);
            Console.WriteLine("Choose marker (a,b,c) for {0}", dieName);
            string input = Console.ReadLine();
            int inputIndex = player.FindMarker(input.ToUpper());
            player.markers[inputIndex].Move(blackDie.val, blackDie.val, deck);

            DisplayBoard();
        }

        private Player Round()
        {
            foreach (var player in players)
            {
                Turn(player);
                if (DidWin(player))
                    return player;
            }
            

            return null;
        }

        public void PlayGame()
        {
            while (true)
            {
                Player winner = Round();
                if (winner != null)
                {
                    Console.WriteLine("Congrats {0}! You win!", winner.name);
                    break;
                }
            }
        }
        private bool DidWin(Player player)
        {
            return player.HasMarkersAt(53) == "ABC";
        }
    }

}
